using AutoMapper;
using Mersy.Api.DTOs;
using Mersy.Api.Helpers;
using Mersy.Api.Servicios;
using Mersy.Common.Entities;
using Mersy.Infraestructure;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic.Core;
using System.Threading.Tasks;

namespace Mersy.Api.Controllers
{
    [ApiController]
    [Route("api/tickets")]
    //[Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme, Roles = "user")]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class TicketsController : CustomBaseController
    {
        private readonly ApplicationDbContext context;
        private readonly IMapper mapper;
        private readonly IAlmacenadorArchivos almacenadorArchivos;
        private readonly ILogger<TicketsController> logger;
        // private readonly string contenedor = "tickets";

        public TicketsController(ApplicationDbContext context,
            IMapper mapper,
            IAlmacenadorArchivos almacenadorArchivos,
            ILogger<TicketsController> logger)
            : base(context, mapper)
        {
            this.context = context;
            this.mapper = mapper;
            this.almacenadorArchivos = almacenadorArchivos;
            this.logger = logger;
        }

        [HttpGet]
        public async Task<ActionResult<LotterySalesIndexDTO>> Get()
        {
            var top = 5;
            var hoy = DateTime.Today;

            var proximosEstrenos = await context.LotterySales
                .Where(x => x.CreatedAt > hoy)
                .OrderBy(x => x.CreatedAt)
                .Take(top)
                .ToListAsync();

            var enCines = await context.LotterySales
                .Where(x => !x.Anulated)
                .Take(top)
                .ToListAsync();

            var resultado = new LotterySalesIndexDTO();
            resultado.DelDia = mapper.Map<List<LotterySaleDTO>>(proximosEstrenos);
            resultado.Premiados = mapper.Map<List<LotterySaleDTO>>(enCines);
            return resultado;
        }

        [HttpGet("filter")]
        public async Task<ActionResult<List<LotterySaleDTO>>> Filtrar([FromQuery] FiltroLotterySalesDTO filtroLotterySalesDTO)
        {
            var lotterySalesQueryable = context.LotterySales.AsQueryable();

            if (!string.IsNullOrEmpty(filtroLotterySalesDTO.Titulo))
            {
                lotterySalesQueryable = lotterySalesQueryable.Where(x => x.Ticket.Contains(filtroLotterySalesDTO.Titulo));
            }

            if (filtroLotterySalesDTO.EnCines)
            {
                lotterySalesQueryable = lotterySalesQueryable.Where(x => !x.Anulated);
            }

            if (filtroLotterySalesDTO.ProximosEstrenos)
            {
                var hoy = DateTime.Today;
                lotterySalesQueryable = lotterySalesQueryable.Where(x => x.CreatedAt > hoy);
            }

            //if (filtroLotterySalesDTO.GeneroId != 0)
            //{
            //    lotterySalesQueryable = lotterySalesQueryable
            //        .Where(x => x.LotterySaleItems.Select(y => y.GeneroId)
            //        .Contains(filtroLotterySalesDTO.GeneroId));
            //}

            if (!string.IsNullOrEmpty(filtroLotterySalesDTO.CampoOrdenar))
            {
                var tipoOrden = filtroLotterySalesDTO.OrdenAscendente ? "ascending" : "descending";

                try
                {
                    lotterySalesQueryable = lotterySalesQueryable.OrderBy($"{filtroLotterySalesDTO.CampoOrdenar} {tipoOrden}");

                }
                catch (Exception ex)
                {
                    logger.LogError(ex.Message, ex);
                }
            }

            await HttpContext.InsertarParametrosPaginacion(lotterySalesQueryable,
                filtroLotterySalesDTO.CantidadRegistrosPorPagina);

            var lotterySales = await lotterySalesQueryable.Paginar(filtroLotterySalesDTO.Paginacion).ToListAsync();

            return mapper.Map<List<LotterySaleDTO>>(lotterySales);
        }

        [HttpGet("{id}", Name = "getTickets")]
        public async Task<ActionResult<LotterySaleDTO>> Get(int id)
        {
            var lotterySale = await context.LotterySales
                .Include(x => x.LotterySaleItems).ThenInclude(x => x.Lottery)
                .Include(x => x.LotterySaleItems).ThenInclude(x => x.LotteryMode)
                .FirstOrDefaultAsync(x => x.Id == id);

            if (lotterySale == null)
            {
                return NotFound();
            }

            lotterySale.LotterySaleItems = lotterySale.LotterySaleItems.OrderBy(x => x.Id).ToList();

            return mapper.Map<LotterySaleDTO>(lotterySale);
        }

        [HttpPost]
        public async Task<ActionResult> Post([FromForm] LotterySaleDTO lotterySaleCreacionDTO)
        {
            var lotterySale = mapper.Map<LotterySale>(lotterySaleCreacionDTO);

            //if (lotterySaleCreacionDTO.Poster != null)
            //{
            //    using (var memoryStream = new MemoryStream())
            //    {
            //        await lotterySaleCreacionDTO.Poster.CopyToAsync(memoryStream);
            //        var contenido = memoryStream.ToArray();
            //        var extension = Path.GetExtension(lotterySaleCreacionDTO.Poster.FileName);
            //       // lotterySale.Poster = await almacenadorArchivos.GuardarArchivo(contenido, extension, contenedor,
            //            //lotterySaleCreacionDTO.Poster.ContentType);
            //    }
            //}

            //  AsignarOrdenLotterySaleItems(lotterySale);
            context.Add(lotterySale);
            await context.SaveChangesAsync();
            var lotterySaleDTO = mapper.Map<LotterySaleDTO>(lotterySale);
            return new CreatedAtRouteResult("obtenerLotterySale", new { id = lotterySale.Id }, lotterySaleDTO);
        }

        //private void AsignarOrdenLotterySaleItems(LotterySale lotterySale)
        //{
        //    if (lotterySale.LotterySaleItems != null)
        //    {
        //        for (int i = 0; i < lotterySale.LotterySaleItems.Count; i++)
        //        {
        //            lotterySale.LotterySaleItems[i].Orden = i;
        //        }
        //    }
        //} 

        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id, [FromForm] LotterySaleDTO lotterySaleCreacionDTO)
        {
            var lotterySaleDB = await context.LotterySales
                .Include(x => x.LotterySaleItems)
                .FirstOrDefaultAsync(x => x.Id == id);

            if (lotterySaleDB == null) { return NotFound(); }

            lotterySaleDB = mapper.Map(lotterySaleCreacionDTO, lotterySaleDB);

            //if (lotterySaleCreacionDTO.Poster != null)
            //{
            //    using (var memoryStream = new MemoryStream())
            //    {
            //        await lotterySaleCreacionDTO.Poster.CopyToAsync(memoryStream);
            //        var contenido = memoryStream.ToArray();
            //        var extension = Path.GetExtension(lotterySaleCreacionDTO.Poster.FileName);
            //        lotterySaleDB.Poster = await almacenadorArchivos.EditarArchivo(contenido, extension, contenedor,
            //            lotterySaleDB.Poster,
            //            lotterySaleCreacionDTO.Poster.ContentType);
            //    }
            //}

            // AsignarOrdenLotterySaleItems(lotterySaleDB);

            await context.SaveChangesAsync();
            return NoContent();
        }

        //[HttpPatch("{id}")]
        //public async Task<ActionResult> Patch(long id, 
        //    [FromBody] JsonPatchDocument<LotterySaleDTO> patchDocument)
        //{
        //    return await Patch<LotterySale, LotterySaleDTO>(id, patchDocument);
        //}

        //[HttpDelete("{id}")]
        //public async Task<ActionResult> Delete(long id)
        //{
        //    return await Delete<LotterySale>(id);
        //}
    }
}
