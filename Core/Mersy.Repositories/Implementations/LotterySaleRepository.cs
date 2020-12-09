using Mersy.Infraestructure;
using System.Threading.Tasks;

namespace Mersy.Repositories.Implementations.Cor
{
    using CommonTaskStd.Data;
    using Mersy.Common.Entities;
    using Mersy.Common.Helpers;
    using Mersy.Common.Models;
    using Mersy.Common.Responses;
    using Microsoft.EntityFrameworkCore;
    using MoreLinq;
    using System;
    using System.Collections.Generic;
    using System.Linq;


    public class LotterySaleRepository : Repository<LotterySale>
    {
        public LotterySaleRepository(ApplicationDbContext context) : base(context)
        {
        }

        public async Task<ResultsViewModel> GetResultsFromDate(DateTime date, long ownerId)
        {
            var modelList = await GetResultsAsync(date, ownerId);

            var vm = new ResultsViewModel { Date = date };
            var lotteries = await GetLoteries();

            vm.Bo = lotteries.FirstOrDefault(p => p.Id == 3);
            vm.Ln = lotteries.FirstOrDefault(p => p.Id == 4);
            vm.Ns = lotteries.FirstOrDefault(p => p.Id == 2);

            var boResult = modelList.FirstOrDefault(p => p.Lottery == vm.Bo);
            var lnResult = modelList.FirstOrDefault(p => p.Lottery == vm.Ln);
            var nsResult = modelList.FirstOrDefault(p => p.Lottery == vm.Ns);

            if (boResult != null)
            {
                vm.Bo1 = boResult.FirstValue;
                vm.Bo2 = boResult.SecondValue;
                vm.Bo3 = boResult.ThirdValue;
            }

            if (lnResult != null)
            {
                vm.Ln1 = lnResult.FirstValue;
                vm.Ln2 = lnResult.SecondValue;
                vm.Ln3 = lnResult.ThirdValue;
            }

            if (nsResult != null)
            {
                vm.Ns1 = nsResult.FirstValue;
                vm.Ns2 = nsResult.SecondValue;
                vm.Ns3 = nsResult.ThirdValue;
            }

            return vm;
        }

        public async Task<PrizePayment> GetPrizzePayment(long id)
        {
            return await Context.PrizePayments.Include(p => p.CreatedUser).Include(p => p.Seller)
                .Where(p => p.Id == id)
                .FirstOrDefaultAsync();
        }

        
        public async Task<List<PrizePayment>> GetMakedPrizzes(long ownerId, DateTime df, DateTime dt, long shop, string userId, bool createIfDontExists)
        {
            return await Context.PrizePayments.Include(p => p.Seller)
                .Where(p => p.CreatedAt.Value.Date >= df.Date &&
                p.CreatedAt.Value.Date <= dt.Date && p.SellerId == userId)
                .ToListAsync();
        }

        
          
        public async Task<Response> SavePrizePayment(PrizePayment model, long ownerId)
        {       
            Context.Add(model); 

            try
            {
                await SaveAllAsync();
                return new Response { IsSuccess = true, Result = model.Id };
            }
            catch (Exception ex)
            {
                return new Response { IsSuccess = false, Message = ex.Message };

            }
        }
         
        public async Task<List<ApplicationUser>> GetUsersForCombo(long ownerId)
        {
            var users = new List<ApplicationUser>
            {
                new ApplicationUser { Id = "", Name = "", Nickname = "" }
            };
            users.AddRange(await Context.Users.Where(p => p.Owner.Id == ownerId).ToListAsync());

            return users;
        }
         
        public async Task<List<Lottery>> GetLotteriesForCombo()
        {
            var lotteries = new List<Lottery>
            {
                new Lottery { Id = 0, Name = "-- Seleccione una Loteria" }
            };
            lotteries.AddRange(await GetLoteries());

            return lotteries;
        }

        public async Task<Response> SaveLotteryDetails(LotteryViewModel vm)
        {
            var currentModel = await GetLotery(vm.Id);
            currentModel.Available = vm.Available;
            currentModel.Loto1First = vm.Loto1First;
            currentModel.Loto1Second = vm.Loto1Second;
            currentModel.Loto1Third = vm.Loto1Third;
            currentModel.Loto2First = vm.Loto2First;
            currentModel.Loto2Second = vm.Loto2Second;
            currentModel.Loto3First = vm.Loto3First;
            currentModel.Loto3Second = vm.Loto3Second;
            currentModel.Loto4First = vm.Loto4First;
            currentModel.Name = vm.Name;
            currentModel.Code = vm.Code;
            currentModel.ColorInHex = vm.ColorInHex;
            //yess was try it, butdoesnt work
            //vm.Transfer(ref currentModel, null, false,false);

            var schedules = currentModel.LotterySchedules; // await Context.LotterySchedules.Where(p => p.LotteryId == vm.Id).ToListAsync();
            var v2 = schedules.Where(p => p.DayOfTheWeek == 1).FirstOrDefault();
            v2.CloseHour = vm.CloseMonday;
            var v4 = schedules.Where(p => p.DayOfTheWeek == 2).FirstOrDefault();
            v4.CloseHour = vm.CloseTuesday;
            var v6 = schedules.Where(p => p.DayOfTheWeek == 3).FirstOrDefault();
            v6.CloseHour = vm.CloseWednesday;
            var v8 = schedules.Where(p => p.DayOfTheWeek == 4).FirstOrDefault();
            v8.CloseHour = vm.CloseThursday;
            var v10 = schedules.Where(p => p.DayOfTheWeek == 5).FirstOrDefault();
            v10.CloseHour = vm.CloseFriday;
            var v12 = schedules.Where(p => p.DayOfTheWeek == 6).FirstOrDefault();
            v12.CloseHour = vm.CloseSaturday;
            var v14 = schedules.Where(p => p.DayOfTheWeek == 7).FirstOrDefault();
            v14.CloseHour = vm.CloseSunday;

            Context.Update(v2);
            Context.Update(v4);
            Context.Update(v6);
            Context.Update(v8);
            Context.Update(v10);
            Context.Update(v12);
            Context.Update(v14);
            Context.Update(currentModel);
            return new Response { IsSuccess = await SaveAllAsync() };
        }

        public async Task<Response> SaveLottery(Lottery vm)
        {
            if (vm.IsNew)
            {
                for (int i = 0; i < 7; i++)
                {
                    var lotSchedule = new Common.Entities.LotterySchedule
                    {
                        CloseHour = vm.CloseHour,
                        DayOfTheWeek = i + 1,
                        //OpenHour = vm.OpenHour.
                    };
                    vm.LotterySchedules.Add(lotSchedule);

                }

                vm.CloseHour = vm.CloseHour;
                Context.Add(vm);
            }
            else
            {

                var currentModel = await Context.Lotteries.FindAsync(vm.Id);
                vm.CloseHour = vm.CloseHour;

                //Only Update the Neccesary fields
                vm.Transfer(ref currentModel, null, false);

                Context.Update(currentModel);

            }

            return new Response { IsSuccess = await SaveAllAsync() };
        }

        public async Task<Response> SaveSale(LotterySale sell, long ownerId, ApplicationUser conectedUser)
        {
            if (sell.TotalAmount <= 0)
                return new Response { IsSuccess = false, Message = "El monto de la venta debe ser superior a 0" };
             
            //if (cashierdet == null)
            //{
            //    cashierdet = await GetCashierFromUser2(conectedUser);
            //    if (cashierdet == null)
            //        return new Response { IsSuccess = false, Message = "Este Usuario no tiene caja asignada abierta en estos momentos" };
            //}

            var listDetail = new List<LotterySaleItem>();

            foreach (var item in sell.LotterySaleItems)
            {
                //while (item.PlayedNumbers.Length > 0)
                //{ 
                if (item.LotteryModeId == 5 || item.LotteryModeId == 1 || item.LotteryModeId == 4)
                {
                    item.Played1 = item.PlayedNumbers;
                }
                else if (item.LotteryModeId == 2 || item.LotteryModeId == 7 || item.LotteryModeId == 6)
                {
                    item.Played1 = item.PlayedNumbers.Substring(0, 2);
                    item.Played2 = item.PlayedNumbers.Substring(2, 2);
                }
                else if (item.LotteryModeId == 3)
                {
                    item.Played1 = item.PlayedNumbers.Substring(0, 2);
                    item.Played2 = item.PlayedNumbers.Substring(2, 2);
                    item.Played3 = item.PlayedNumbers.Substring(4, 2);
                }

                //}

                listDetail.Add(item);
            }

            sell.LotterySaleItems.Clear();
            sell.LotterySaleItems = listDetail;

            var valida = await ValidaVenta(sell, ownerId);
            if (!string.IsNullOrEmpty(valida))
                return new Response { IsSuccess = false, Message = valida };
             
            var totPaid = sell.TotalAmount;
            // todo: verificar que esto este bien
            sell.SeqByOwner = GenerateRecord(ownerId, 7);
          
            var owner = await Context.Owners.FindAsync(ownerId);
            if (string.IsNullOrEmpty(owner.PrefixFact))
                owner.PrefixFact = "";
             
                sell.Ticket = $"{owner.PrefixFact}{sell.SeqByOwner:0000000}";
             
            Context.LotterySales.Add(sell);
            try
            {
                await SaveAllAsync();
            }
            catch (Exception ex)
            {
                return new Response { IsSuccess = false, Message = ex.Message };
            }

            var comission = totPaid * conectedUser.Comission / 100;
         
            var objPayment = new Payment
            {
                Type = 1,
                LotterySaleId = sell.Id,
                // PaymentTypeId = 1,// sell.LotterySale.PaymentTypeId,
                Amountx = totPaid,
                ComissionAmount = comission, 
            };

            objPayment.Date = DateTime.Now;
             
            Context.Payments.Add(objPayment);

            try
            {
                await SaveAllAsync();
                return new Response { IsSuccess = true };
            }
            catch (Exception ex)
            {
                return new Response { IsSuccess = false, Message = ex.Message };
            }

        }

        public int GenerateRecord(long authorId, int from = 0, long shopId = 0)
        {
            try
            {
                int maxseq = 0;
                switch (from)
                {

                    case 7:
                        maxseq = Context.LotterySales.Where(u => u.CreatedUser.Owner.Id == authorId).Max(p => p.SeqByOwner);
                        break;
                    case 8:
                        maxseq = Context.LotterySales
                            .Where(u => u.CreatedUser.Owner.Id == authorId )
                            .Max(p => p.SeqByShop);
                        break;
                    default:
                        break;
                }

                return maxseq + 1;
            }
            catch (Exception)
            {
                return 1;
            }

        }

        public async Task<List<Lottery>> GetLoteries()
        {
            return await Context.Lotteries.Include(p => p.LotterySchedules).ToListAsync();
        }

        public async Task<Lottery> GetLotery(long id)
        {
            return await Context.Lotteries.Include(p => p.LotterySchedules).FirstOrDefaultAsync(p => p.Id == id);
        }

        public async Task<LotteryMode> GetMode(long id)
        {
            return await Context.LotteryModes.FirstOrDefaultAsync(p => p.Id == id);
        }

        public async Task<Lottery> GetLoteryAsync(long id)
        {
            return await Context.Lotteries.FindAsync(id);
        }

        public async Task<List<LotteryMode>> GetModesForCombo()
        {
            var modes = new List<LotteryMode>
            {
                new LotteryMode { Id = 0, Name = "-- Seleccione un PR" }
            };
            modes.AddRange(await Context.LotteryModes.ToListAsync());

            return modes;
        }

        public async Task<Response> PayPrizedTicket(LotterySale entity, ApplicationUser conectedUser)
        { 
            var totPaid = entity.Prize - (entity.Prize * 2);

            var objPayment = new Payment
            {
                Type = 2,
                LotterySaleId = entity.Id,
                Amountx = totPaid
            };


            objPayment.Date = DateTime.Now;
              
            Context.Payments.Add(objPayment);
            entity.WasPaid = true;
            Context.Update(entity);

            return new Response { IsSuccess = await SaveAllAsync() };

        }

        public async Task<Response> RegisterResult(LotteryResult vm, long ownerId, DateTime date, bool save = true)
        {
            var choosenLottery = vm.Lottery;
            if (choosenLottery == null)
                return new Response { IsSuccess = false, Message = "Loteria no encontrada" };

            var modesFrom = await Context.LotteryModes
                .ToListAsync();

            var modes = new List<LotteryMode>();

            long[] filter = new long[] { 1, 2, 3, 8 };

            if (choosenLottery.LotteryFromId == 1)
            {
                foreach (var item in modesFrom)
                {
                    if (item.Id == 1 || item.Id == 2 || item.Id == 3 || item.Id == 8)
                    {
                        modes.Add(item);
                    }
                }
            }
            else
            {
                foreach (var item in modesFrom)
                {
                    if (item.Id == 4 || item.Id == 5 || item.Id == 6 || item.Id == 7)
                    {
                        modes.Add(item);
                    }
                }
            }

            var itemsDb = await Context.LotterySaleItems
                    .Include(p => p.LotterySale)
                    .Where(p => p.LotteryId == vm.LotteryId && !p.LotterySale.Anulated
                    && p.CreatedAt.Value.Date.Date == vm.Date.Date).ToListAsync();

            foreach (var mode in modes)
            {
                var items = itemsDb.Where(p => p.LotteryMode == mode).ToList();

                foreach (var item in items)
                {
                    if (mode.Id == 1 && item.LotteryModeId == 1) //Quiniela/Loto1
                    {
                        //its winner
                        if (vm.FirstValue == item.Played1 || vm.SecondValue == item.Played1 || vm.ThirdValue == item.Played1)
                        {
                            item.LotterySale.Winner = true;
                            if (item.Played1 == vm.FirstValue)
                            {
                                item.Prize += item.PlayedAmount * choosenLottery.Loto1First;
                                item.Prize1 += item.Prize;
                                item.LotterySale.Prize += item.PlayedAmount * choosenLottery.Loto1First; // prize.FirstValue * ;
                            }
                            else if (item.Played1 == vm.SecondValue)
                            {
                                item.Prize += item.PlayedAmount * choosenLottery.Loto1Second;
                                item.Prize2 += item.Prize;
                                item.LotterySale.Prize += item.PlayedAmount * choosenLottery.Loto1Second; //prize.SecondValue * 
                            }
                            else if (item.Played1 == vm.ThirdValue)
                            {
                                item.Prize += item.PlayedAmount * choosenLottery.Loto1Third;
                                item.Prize3 += item.Prize;
                                item.LotterySale.Prize += item.PlayedAmount * choosenLottery.Loto1Third; //prize.ThirdValue
                            }
                        }
                    }
                    else if (mode.Id == 4 && item.LotteryModeId == 4) //Bourlette/Loto1
                    {
                        if (vm.FirstValue == item.Played1 || vm.SecondValue == item.Played1 || vm.ThirdValue == item.Played1)
                        {
                            item.LotterySale.Winner = true;

                            if (item.Played1 == vm.FirstValue)
                            {
                                var amount = item.PlayedAmount * choosenLottery.Loto1First;
                                item.Prize += amount;
                                item.Prize1 += amount;
                                item.LotterySale.Prize += amount; //prize.FirstValue 
                            }
                            if (item.Played1 == vm.SecondValue)
                            {
                                var amount = item.PlayedAmount * choosenLottery.Loto1Second;
                                item.Prize += amount;
                                item.Prize2 += amount;
                                item.LotterySale.Prize += amount; // prize.SecondValue; 
                            }
                            if (item.Played1 == vm.ThirdValue)
                            {
                                var amount = item.PlayedAmount * choosenLottery.Loto1Third;
                                item.Prize += amount;
                                item.Prize3 += amount;
                                item.LotterySale.Prize += amount;// prize.ThirdValue;
                            }
                        }
                    }
                    else if (mode.Id == 5 && item.LotteryModeId == 5) //Loto 3
                    {
                        if (vm.FirstValue == item.Played1)
                        {
                            item.LotterySale.Winner = true;
                            item.Prize += item.PlayedAmount * choosenLottery.Loto3First;
                            item.Prize1 += item.Prize;
                            item.LotterySale.Prize += item.PlayedAmount * choosenLottery.Loto3First; //prize.FirstValue 
                        }
                    }
                    else if (mode.Id == 8 && item.LotteryModeId == 8) //Super Pale/ TODO: Ver como funciona esto
                    {
                        if (vm.FirstValue == item.Played1)
                        {
                            item.LotterySale.Winner = true;
                            item.Prize += item.PlayedAmount * choosenLottery.Loto3First;
                            item.Prize1 += item.Prize;
                            item.LotterySale.Prize += item.PlayedAmount * choosenLottery.Loto3First; //prize.FirstValue 
                        }
                    }
                    else if (mode.Id == 2 && item.LotteryModeId == 2) //Pale/Loto2
                    {
                        if ((item.Played1 == vm.FirstValue && item.Played2 == vm.SecondValue) || (item.Played1 == vm.SecondValue && item.Played2 == vm.FirstValue))
                        {
                            item.LotterySale.Winner = true;
                            item.Prize += item.PlayedAmount * choosenLottery.Loto2First;
                            item.Prize1 += item.Prize;
                            item.LotterySale.Prize += item.PlayedAmount * choosenLottery.Loto2First; //prize.FirstValue 
                        }

                        if ((item.Played1 == vm.ThirdValue && item.Played2 == vm.SecondValue) || (item.Played1 == vm.SecondValue && item.Played2 == vm.ThirdValue))
                        {
                            item.LotterySale.Winner = true;
                            item.Prize += item.PlayedAmount * choosenLottery.Loto2Second;
                            item.Prize2 += item.Prize;
                            item.LotterySale.Prize += item.PlayedAmount * choosenLottery.Loto2Second; //prize.SecondValue 
                        }
                    }
                    else if (mode.Id == 7 && item.LotteryModeId == 7) //Mariage/Loto2
                    {
                        var amount = item.PlayedAmount * choosenLottery.Loto2First;
                        if (item.Played1 == vm.FirstValue)
                        {
                            item.Prize += amount;
                            item.Prize1 += amount;
                            item.LotterySale.Winner = true;
                            item.LotterySale.Prize += amount; //prize.FirstValue 
                        }
                        if (item.Played1 == vm.SecondValue)
                        {
                            item.Prize += amount;
                            item.Prize1 += amount;
                            item.LotterySale.Winner = true;
                            item.LotterySale.Prize += amount; //prize.FirstValue 
                        }
                        if (item.Played1 == vm.ThirdValue)
                        {
                            item.Prize += amount;
                            item.Prize1 += amount;
                            item.LotterySale.Winner = true;
                            item.LotterySale.Prize += amount; //prize.FirstValue 
                        }

                        if (item.Played2 == vm.FirstValue)
                        {
                            item.Prize += amount;
                            item.Prize2 += amount;
                            item.LotterySale.Winner = true;
                            item.LotterySale.Prize += amount; //prize.FirstValue 
                        }
                        if (item.Played2 == vm.SecondValue)
                        {
                            item.Prize += amount;
                            item.Prize2 += amount;
                            item.LotterySale.Winner = true;
                            item.LotterySale.Prize += amount; //prize.FirstValue 
                        }
                        if (item.Played2 == vm.ThirdValue)
                        {
                            item.Prize += amount;
                            item.Prize2 += amount;
                            item.LotterySale.Winner = true;
                            item.LotterySale.Prize += amount; //prize.FirstValue 
                        }
                        //if ((item.Played1 == vm.FirstValue && item.Played2 == vm.SecondValue) || (item.Played1 == vm.SecondValue && item.Played2 == vm.FirstValue))
                        //{
                        //    item.Prize = item.PlayedAmount * choosenLottery.Loto2First;
                        //    item.Prize1 = item.Prize;
                        //    item.LotterySale.Winner = true;
                        //    item.LotterySale.Prize += item.PlayedAmount * choosenLottery.Loto2First; //prize.FirstValue 
                        //}

                        //if ((item.Played1 == vm.ThirdValue && item.Played2 == vm.SecondValue) || (item.Played1 == vm.SecondValue && item.Played2 == vm.ThirdValue))
                        //{
                        //    item.Prize = item.PlayedAmount * choosenLottery.Loto2Second;
                        //    item.Prize2 = item.Prize;
                        //    item.LotterySale.Winner = true;
                        //    item.LotterySale.Prize += item.PlayedAmount * choosenLottery.Loto2Second; //prize.SecondValue
                        //}

                    }
                    else if (mode.Id == 3 && item.LotteryModeId == 3) //Tripleta/Loto4
                    {
                        if ((item.Played1 == vm.FirstValue && item.Played2 == vm.SecondValue && item.Played3 == vm.ThirdValue)
                     || (item.Played1 == vm.FirstValue && item.Played2 == vm.ThirdValue && item.Played3 == vm.SecondValue)
                     || (item.Played1 == vm.SecondValue && item.Played2 == vm.ThirdValue && item.Played3 == vm.FirstValue)
                     || (item.Played1 == vm.SecondValue && item.Played2 == vm.FirstValue && item.Played3 == vm.ThirdValue)
                     || (item.Played1 == vm.ThirdValue && item.Played2 == vm.SecondValue && item.Played3 == vm.FirstValue)
                     || (item.Played1 == vm.ThirdValue && item.Played2 == vm.FirstValue && item.Played3 == vm.SecondValue)
                     )
                        {
                            item.Prize += item.PlayedAmount * choosenLottery.Loto4First;
                            item.Prize1 += item.Prize;
                            item.LotterySale.Winner = true;
                            item.LotterySale.Prize += item.PlayedAmount * choosenLottery.Loto4First; //; //prize.FirstValue
                        }

                    }
                    else if (mode.Id == 6 && item.LotteryModeId == 6) //Loto 4
                    {
                        if ((item.Played1 == vm.SecondValue && item.Played2 == vm.ThirdValue))// || (item.Played1 == vm.ThirdValue && item.Played2 == vm.SecondValue))
                        {
                            item.Prize += item.PlayedAmount * choosenLottery.Loto4First;
                            item.Prize1 += item.Prize;
                            item.LotterySale.Winner = true;
                            item.LotterySale.Prize += item.PlayedAmount * choosenLottery.Loto4First; // //prize.FirstValue
                        }
                    }

                    Context.Update(item);
                }
            }

            Context.Add(vm);
            if (save)
            {
                try
                {
                    await SaveAllAsync();
                    return new Response { IsSuccess = true };
                }
                catch (Exception ex)
                {
                    return new Response { IsSuccess = false, Message = ex.Message };
                }
            }

            return new Response { IsSuccess = true };
        }

        public async Task<Response> RegisterResultAsync(ResultsViewModel vm, long ownerId)
        {
            if (string.IsNullOrEmpty(vm.Bo1) && string.IsNullOrEmpty(vm.Bo2) && string.IsNullOrEmpty(vm.Bo3) && string.IsNullOrEmpty(vm.Ln1) && string.IsNullOrEmpty(vm.Ln2) && string.IsNullOrEmpty(vm.Ln3) && string.IsNullOrEmpty(vm.Ns1) && string.IsNullOrEmpty(vm.Ns2) && string.IsNullOrEmpty(vm.Ns3))
                return new Response { IsSuccess = false, Message = "No hay nada que guardar" };

            var lotteries = await GetLoteries();

            vm.Bo = lotteries.FirstOrDefault(p => p.Id == 3);
            vm.Ln = lotteries.FirstOrDefault(p => p.Id == 4);
            vm.Ns = lotteries.FirstOrDefault(p => p.Id == 2);

            var results = await GetResultsAsync(vm.Date, ownerId);

            var couldSaveBo = await ValidaAndSaveIndividualLotteryResult(vm.Bo1, vm.Bo2, vm.Bo3, vm.Bo, vm.Date, ownerId, results);
            var couldSaveLn = await ValidaAndSaveIndividualLotteryResult(vm.Ln1, vm.Ln2, vm.Ln3, vm.Ln, vm.Date, ownerId, results);
            var couldSaveNs = await ValidaAndSaveIndividualLotteryResult(vm.Ns1, vm.Ns2, vm.Ns3, vm.Ns, vm.Date, ownerId, results);

            if (!couldSaveBo.IsSuccess)
                return new Response { IsSuccess = false, Message = couldSaveBo.Message };
            if (!couldSaveLn.IsSuccess)
                return new Response { IsSuccess = false, Message = couldSaveLn.Message };
            if (!couldSaveNs.IsSuccess)
                return new Response { IsSuccess = false, Message = couldSaveNs.Message };

            try
            {
                await SaveAllAsync();
                return new Response { IsSuccess = true };
            }
            catch (Exception ex)
            {
                return new Response { IsSuccess = false, Message = ex.Message };
            }
        }

        public async Task<Response> ValidaAndSaveIndividualLotteryResult(string val1, string val2, string val3, Lottery lottery, DateTime date, long ownerId, List<LotteryResult> results)
        {
            if (!string.IsNullOrEmpty(val1) || !string.IsNullOrEmpty(val2) || !string.IsNullOrEmpty(val3))
            {
                if (string.IsNullOrEmpty(val1) || string.IsNullOrEmpty(val2) || string.IsNullOrEmpty(val3))
                    return new Response { IsSuccess = false, Message = "Debe llenar todos los campos para cerrar la loteria" };

                if (date.Date >= DateTime.Now.Date)
                {
                    var schedule = GetScheduleAsync(lottery, date);
                    if (schedule.CloseHour.TimeOfDay > DateTime.Now.TimeOfDay)
                        return new Response { IsSuccess = false, Message = "La Loteria no ha cerrado para registrar resultados" };
                }

                var dbResult = results.FirstOrDefault(p => p.Lottery == lottery);
                if (dbResult != null)
                {
                    if (val1 != dbResult.FirstValue || val2 != dbResult.SecondValue || val3 != dbResult.ThirdValue)
                        return new Response { IsSuccess = false, Message = "No puede cambiar los resultados de la loteria" };
                }
                else
                {
                    var currentResult = new LotteryResult
                    {
                        Date = date,
                        LotteryId = lottery.Id,
                        Lottery = lottery,
                        FirstValue = val1,
                        SecondValue = val2,
                        ThirdValue = val3
                    };
                    var result = await RegisterResult(currentResult, ownerId, date, false);
                    if (!result.IsSuccess)
                        return new Response { IsSuccess = false, Message = result.Message };
                }
            }
            return new Response { IsSuccess = true, Message = "No hay nada que guardar" };
        }

        public LotterySchedule GetScheduleAsync(Lottery lottery, DateTime date)
        {
            return Context.LotterySchedules.FirstOrDefault(p => p.Lottery == lottery && p.DayOfTheWeek == Dates.GetValueDayOfTheWeek(date.DayOfWeek));
        }

        public async Task<LotteryResult> GetResultAsync(DateTime date, long ownerId, long lotteryId)
        {
            return await Context.LotteryResults
                .FirstOrDefaultAsync(p => p.LotteryId == lotteryId && p.Date.Date == date.Date
                && p.CreatedUser.Owner.Id == ownerId);
        }

        public async Task<List<LotteryResult>> GetResultsAsync(DateTime date, long ownerId)
        {
            return await Context.LotteryResults.Include(p => p.Lottery)
                .Where(p => p.Date.Date == date.Date && p.CreatedUser.Owner.Id == ownerId).ToListAsync();
        }

        public async Task<Response> DeleteTicketSol(long id)
        {
            var sale = await GetTicketAsync(id);

            sale.AnulatedSol = true;
            Context.Update(sale);
            return new Response { IsSuccess = await SaveAllAsync() };
        }

        public async Task<Response> NoDeleteTicket(long id)
        {
            var sale = await GetTicketAsync(id);

            sale.AnulatedSol = false;
            Context.Update(sale);
            return new Response { IsSuccess = await SaveAllAsync() };
        }

        public async Task<Response> DeleteTicket(long id)
        {
            var sale = await GetTicketAsync(id);

            //Todo: Fecha debe ser validada
            if (sale == null || sale.Winner)
                return new Response { IsSuccess = false, Message = "Elemento no encontrado o esta en un estado que no permite su anulacion" };
              
            foreach (var item in sale.LotterySaleItems)
            {
                item.Deleted = true;
                Context.Update(item);
            }

            var totPaid = sale.TotalAmount; //(decimal)objPayment.Amount + (decimal)objPayment.AmountCheck +
                                            //                (decimal)objPayment.AmountNc + (decimal)objPayment.AmountTc +
                                            //                (decimal)objPayment.AmountTe;
            var objPayment = await Context.Payments
                 .FirstOrDefaultAsync(p => p.LotterySaleId == id);

            objPayment.Deleted = true;
            Context.Update(objPayment);
   
            sale.Anulated = true;
            Context.Update(sale);
            return new Response { IsSuccess = await SaveAllAsync() };
        }
         
        public async Task<List<Lottery>> GetLotteriesAvailableToSell(long ownerId)
        {
            var lotteries = await Context.Lotteries.Include(p => p.LotteryFrom)
                .Include(p => p.LotterySchedules).ThenInclude(p => p.CreatedUser).ThenInclude(p => p.Owner).Where(p => p.Available)
                .ToListAsync();

            var list = new List<Lottery>();
            int day = Dates.GetValueDayOfTheWeek(DateTime.Now.DayOfWeek);

            foreach (var lottery in lotteries)
            {
                var schedule = lottery.LotterySchedules.Where(p => p.DayOfTheWeek == day).FirstOrDefault();

                if (string.IsNullOrEmpty(ValidaHorario(lottery, ownerId, day, schedule)))
                    list.Add(lottery);
            }

            return list;
        }

        public async Task<string> ValidaHorario(long lotteryId, long ownerId)
        {
            var lottery = await Context.Lotteries
                .Include(p => p.LotterySchedules).FirstOrDefaultAsync(p => p.Id == lotteryId);

            return ValidaHorario(lottery, ownerId);
        }

        public LotteryTicketView TicketForPrinter(LotterySale ticket)
        {
            var vm = new LotteryTicketView();
            ticket.Transfer(ref vm, null, false);

            var owner = ticket.CreatedUser.Owner;//await GetOwnerAsync(); 
             
                owner.Transfer(ref vm, null, false);

            if (owner.UserNameInReport)
            {
                var user = ticket.CreatedUser; // await GetUserAsync();
                vm.UserName = user.FullName;
            }

            return vm;
        }

        public string ValidaHorario(Lottery lottery, long ownerId, int day = 0, LotterySchedule schedule = null)
        {
            if (day == 0)
                day = Dates.GetValueDayOfTheWeek(DateTime.Now.DayOfWeek);

            if (schedule == null)
                schedule = lottery.LotterySchedules.Where(p => p.CreatedUser.Owner.Id == ownerId && p.DayOfTheWeek == day).FirstOrDefault();

            if (DateTime.Now.TimeOfDay >= schedule.CloseHour.TimeOfDay)// || DateTime.Now.Hour < schedule.OpenHour.Hour)
                return "Esta loteria no está disponible en este horario";
            var date = DateTime.Now;
            var schedule2 = lottery.LotterySchedules.Where(p => p.InactiveDate.Date == date).FirstOrDefault();

            if (schedule2 != null)
                return "Esta loteria no está disponible en este dia";

            return "";
        }

        public async Task<string> ValidaVenta(LotterySale sell, long ownerId)
        {
            var lotteries = await Context.Lotteries
                .Include(p => p.LotterySchedules).ThenInclude(p => p.CreatedUser).ThenInclude(p => p.Owner)
                .ToListAsync();
             
            var results = new List<LotteryResult>();
            var date = DateTime.Now;
            try
            {
                results = await Context.LotteryResults.Where(p => p.Date.Date == date.Date).ToListAsync();
                 
            }
            catch (Exception  )
            {

            }
            foreach (var item in sell.LotterySaleItems)
            {
                var result = results.Where(p => p.LotteryId == item.LotteryId).FirstOrDefault();

                if (result != null)
                    return "Esta loteria ya tiene resultados registrados";

                var lottery = lotteries.Where(p => p.Id == item.LotteryId).FirstOrDefault();

                if (!string.IsNullOrEmpty(ValidaHorario(lottery, ownerId)))
                    return ValidaHorario(lottery, ownerId);
            }
            return "";
        }

        public async Task<LotterySale> GetTicketAsync(long id)
        {
            return await Context.LotterySales
                .Include(p => p.CreatedUser).ThenInclude(p => p.Owner)
                .Include(p => p.CreatedUser) 
                .Include(p => p.LotterySaleItems).ThenInclude(p => p.Lottery)
                .Include(p => p.LotterySaleItems).ThenInclude(p => p.LotteryMode)
                .Include(p => p.LotterySaleItems)
                .FirstOrDefaultAsync(p => p.Id == id);
        }

        public async Task<List<LotterySale>> GetTicketsAsync(long ownerId, DateTime? date, bool all = true, string ticket = "",
           string user = "", bool wasPaid = false, bool wasPrized = false, long lotterySaleId = 0, int status = 0)
        {
            var tickets = await GetTicketsAsync(ownerId, date, all, ticket,
                                                user, wasPaid, wasPrized, lotterySaleId);

            if (status == 1)
                tickets = tickets.Where(p => p.WasPaid).ToList();
            else if (status == 2)
                tickets = tickets.Where(p => p.Winner && !p.WasPaid).ToList();
            else if (status == 3)
                tickets = tickets.Where(p => p.Prize == 0).ToList();
            return tickets;
        }

        public async Task<List<LotterySale>> GetTicketsAsync(long ownerId, DateTime? date, bool all = true, string ticket = "",
            string user = "", bool wasPaid = false, bool wasPrized = false, long lotterySaleId = 0)
        {
            var tickets = GetTickets(ownerId);

            if (lotterySaleId != 0)
                tickets = tickets.Where(p => p.Id == lotterySaleId);
            else
            {
                if (!string.IsNullOrEmpty(ticket))
                    tickets = tickets.Where(p => p.Ticket == ticket);
                else
                {
                    if (date != null)
                        tickets = tickets.Where(p => p.CreatedAt.Value.Date == date.Value.Date);

                    if (!string.IsNullOrEmpty(user))
                        tickets = tickets.Where(p => p.CreatedBy == user);

                    if (all == false)
                    {
                        tickets = tickets.Where(p => p.WasPaid == wasPaid);

                        tickets = tickets.Where(p => p.Winner == wasPrized);
                    }


                    tickets = tickets.OrderByDescending(p => p.Id).Take(50);

                }
            }
            return await tickets.ToListAsync();
        }

        public async Task<List<LotterySaleItemView>> GetPlays(string userId, long ouwnerId, long mode, string play, long lottery, DateTime? date, DateTime? dateTo)
        {
            if (date == null)
                date = DateTime.Now;
            if (dateTo == null)
                dateTo = DateTime.Now;

            var plays = new List<LotterySaleItemView>();

            var lotteries = await Context.Lotteries.ToListAsync();
            if (lottery != 0)
                lotteries = lotteries.Where(p => p.Id == lottery).ToList();

            var lotteryModes = await Context.LotteryModes.ToListAsync();
            if (mode != 0)
                lotteryModes = lotteryModes.Where(p => p.Id == mode).ToList();

            var playsFromDb = await Context.LotterySaleItems.Include(p => p.CreatedUser)
                .Include(p => p.LotterySale)
                .Include(p => p.LotteryMode)
                .Include(p => p.Lottery)
                .Where(p => p.CreatedAt.Value.Date >= date.Value.Date && p.CreatedAt.Value.Date <= date.Value.Date
                && p.CreatedUser.Owner.Id == ouwnerId)
                .ToListAsync();

            if (!string.IsNullOrEmpty(play))
                playsFromDb = playsFromDb.Where(p => p.PlayedNumbers.Contains(play)).ToList();

            //#region PreloadData

            //var LimitsByNumber = await Context.LotteryRestrictionByNumbers.Where(p => p.CreatedUser.Owner.Id == ouwnerId).ToListAsync();
            //var limitsBySeller = await Context.LotteryRestrictionBySellers.Where(p => p.CreatedUser.Owner.Id == ouwnerId).ToListAsync();
            //var limits = await Context.LotteryRestrictions.Where(p => p.CreatedUser.Owner.Id == ouwnerId).ToListAsync();

            //#endregion
            var numbers = new List<string>();

            foreach (var item in playsFromDb)
            {
                var findit = numbers.Where(p => p.Contains(item.PlayedNumbers)).FirstOrDefault();
                if (findit == null)
                {
                    numbers.Add(item.PlayedNumbers);
                }
            }
            foreach (var number in numbers)
            {
                foreach (var lot in lotteries)
                {
                    foreach (var lotMode in lotteryModes)
                    {
                        var nums = playsFromDb.Where(p => p.PlayedNumbers.Contains(number) && p.Lottery == lot && p.LotteryMode == lotMode).ToList();

                        if (nums != null && nums.Count > 0)
                        {
                          //  decimal restrictionAmount = GetRestrictionLimit(userId, number, lot.Id, lotMode.Id, 1); //GetRestrictionAmount

                            decimal playedAmount = 0;

                            foreach (var num in nums)
                            {
                                playedAmount += num.PlayedAmount;
                            }

                          
                            plays.Add(new LotterySaleItemView
                            {
                                Number = number,
                                Limit = 10000,
                                Cumulative = playedAmount,
                                Available = 10000,
                                Lottery = lot,
                                LotteryMode = lotMode,
                                PlayedNumbers = nums.Count().ToString(),
                                LotterySale = new LotterySale(),
                                CreatedUser = new ApplicationUser(),
                                CreatedAt = date
                            }); ;
                        }
                    }
                }
            }

            return plays;
        }

        public async Task<List<LotterySaleItemView>> GetPlaysFilter(string userId, long ouwnerId, long mode, string play, long lottery, DateTime? date)
        {
            if (date == null)
                date = DateTime.Now;

            var plays = new List<LotterySaleItemView>();

            var playsFromDb = await Context.LotterySaleItems
                .Include(p => p.CreatedUser)
                .Include(p => p.LotterySale)
                .Include(p => p.LotteryMode)
                .Include(p => p.Lottery)
                .Where(p => p.CreatedAt.Value.Date == date.Value.Date
                && p.CreatedUser.Owner.Id == ouwnerId
                && p.LotteryId == lottery && p.LotteryModeId == mode)
                .ToListAsync();

            playsFromDb = playsFromDb.Where(p => p.PlayedNumbers.Contains(play)).ToList();
            var lot = await GetLotery(lottery);
            var mod = await GetMode(mode);

            foreach (var item in playsFromDb)
            {
                plays.Add(new LotterySaleItemView
                {
                    LotterySaleId = item.LotterySaleId,
                    Number = play,
                    Limit = 0,
                    Cumulative = 0,
                    Available = 0,
                    Lottery = lot,
                    LotteryMode = mod,
                    PlayedAmount = item.PlayedAmount,
                    PlayedNumbers = item.PlayedNumbers,
                    LotterySale = item.LotterySale,
                    CreatedUser = item.CreatedUser,
                    CreatedAt = item.CreatedAt
                }); ;

            }

            return plays;
        }
         
        public IQueryable<LotterySale> GetTickets(long ownerId)
        {
            return Context.LotterySales.Include(p => p.CreatedUser)
                .Include(p => p.LotterySaleItems)
                .Where(p => p.CreatedUser.Owner.Id == ownerId && !p.AnulatedSol).AsNoTracking();
        }
        public async Task<LotterySaleView> GetSalesForHomeResume(DateTime dateFrom, DateTime dateTo, long ownerId, ApplicationUser user, bool isForHome = false)
        {
            var vm = new LotterySaleView();
            var sales = await GetSalesAsync(dateFrom, dateTo, ownerId);
            var lotteries = new List<LotteryView>();
            vm.Sales = sales;
            foreach (var item in sales)
            {
                vm.PrizeAmount += item.Prize;
                vm.SalesAmount += item.TotalAmount;
                foreach (var played in item.LotterySaleItems)
                {
                    lotteries.Add(new LotteryView
                    {
                        ModeId = played.LotteryModeId,
                        Id = played.LotteryId,
                        SalesAmount = played.PlayedAmount
                    });
                }
            }
            vm.ComissionAmount = user.Comission * vm.SalesAmount;
            if (vm.ComissionAmount > 0)
                vm.ComissionAmount /= 100;
            vm.BalanceAmount = vm.SalesAmount - vm.ComissionAmount - vm.PrizeAmount;
            var dbLotteries = await Context.Lotteries.ToListAsync();
            var listToLottery = new List<LotteryView>();
            vm.Lotteries = new List<LotteryView>();
            decimal totalAmount = 0;
            decimal totalPrize = 0;
            foreach (var lot in dbLotteries)
            {
                var colectionLotteries = lotteries.Where(p => p.Id == lot.Id);
                var lotToView = new LotteryView { Id = lot.Id, SalesAmount = 0, Name = lot.Name };
                if (colectionLotteries != null)
                {
                    foreach (var item in colectionLotteries)
                    {
                        lotToView.SalesAmount += item.SalesAmount;
                        lotToView.Prizes += item.Prizes;
                    }
                    lotToView.Comissions = user.Comission * lotToView.SalesAmount;
                    if (lotToView.Comissions > 0)
                        lotToView.Comissions /= 100;

                    lotToView.Results += lotToView.SalesAmount - lotToView.Comissions - lotToView.Prizes;
                    totalAmount += lotToView.SalesAmount;
                    totalPrize += lotToView.Prizes;
                }
                listToLottery.Add(lotToView);
                if (!isForHome)
                {
                    foreach (var item in listToLottery)
                    {
                        try
                        {
                            item.Percent = (item.SalesAmount / totalAmount) * 100;
                        }
                        catch (Exception  )
                        {
                            item.Percent = 0;
                        }
                        vm.Lotteries.Add(item);
                    }
                    var genCommision = user.Comission * totalAmount;
                    if (genCommision > 0)
                        genCommision /= 100;

                    var genResult = totalAmount - genCommision - totalPrize;

                    vm.Lotteries.Add(new LotteryView
                    {
                        Name = "TOTALES",
                        Percent = 100,
                        SalesAmount = totalAmount,
                        Prizes = totalPrize,
                        Comissions = genCommision,
                        Results = genResult

                    });
                }
                else
                    vm.Lotteries = listToLottery;

            }
            vm.Modes = new List<LotteryModeView>();
            if (!isForHome)
            {
                var dbModes = await Context.LotteryModes.ToListAsync();

                var salesItems = Context.LotterySaleItems.Include(p => p.Lottery).Include(p => p.LotteryMode)
                    .Where(p => p.CreatedAt.Value.Date >= dateFrom
                    && p.CreatedAt.Value.Date <= dateTo && p.CreatedUser.Owner.Id == ownerId);

                decimal totalSell = 0;
                decimal total1 = 0;
                decimal total2 = 0;
                decimal total3 = 0;
                totalPrize = 0;
                var listModes = new List<LotteryModeView>();
                foreach (var mod in dbModes)
                {
                    var colectionmode = salesItems.Where(p => p.LotteryModeId == mod.Id).ToList();

                    if (colectionmode != null)
                    {
                        var modToView = new LotteryModeView { Mode = mod.Name };

                        foreach (var item in colectionmode)
                        {
                            modToView.Sell += item.PlayedAmount;
                            modToView.First += item.Prize1;
                            modToView.Second += item.Prize2;
                            modToView.Third += item.Prize3;
                            modToView.Prize += item.Prize;
                        }
                        listModes.Add(modToView);

                        totalSell += modToView.Sell;
                        total1 += modToView.First;
                        total2 += modToView.Second;
                        total3 += modToView.Third;
                        totalPrize += modToView.Prize;
                    }
                }
                foreach (var item in listModes)
                {
                    try
                    {
                        decimal percent = (item.Sell / totalSell) * 100;
                        item.Percent = Convert.ToInt32(percent);
                    }
                    catch (Exception  )
                    {
                        item.Percent = 0;
                    }

                    vm.Modes.Add(item);
                }
                var modToViewx = new LotteryModeView
                {
                    Mode = "TOTALES",
                    Prize = totalPrize,
                    First = total1,
                    Second = total2,
                    Third = total3,
                    Sell = totalSell,
                    Percent = 100
                };
                vm.Modes.Add(modToViewx);
            }
            return vm;
        }

        public async Task<LotterySaleView> GetSalesForPlayAndLotteries(DateTime dateFrom, DateTime dateTo, long ownerId, ApplicationUser user, bool isForHome = false)
        {
            var vm = new LotterySaleView();
            decimal totalAmount = 0;
            decimal totalPrize = 0;
            vm.Modes = new List<LotteryModeView>();
            vm.Lotteries = new List<LotteryView>();

            var dbModes = await Context.LotteryModes.ToListAsync();
            var dbLotteries = await Context.Lotteries.Where(p => p.Available).ToListAsync();

            var salesItems = Context.LotterySaleItems.Include(p => p.Lottery).Include(p => p.LotteryMode)
                    .Where(p => p.CreatedAt.Value.Date >= dateFrom
                    && p.CreatedAt.Value.Date <= dateTo && p.CreatedUser.Owner.Id == ownerId);

            decimal totalSell = 0;
            decimal totalComission = 0;
            decimal totalResult = 0;
            decimal total1 = 0;
            decimal total2 = 0;
            decimal total3 = 0;
            totalPrize = 0;
            var listModes = new List<LotteryModeView>();
            var listLotteries = new List<LotteryView>();
            foreach (var mod in dbModes)
            {
                var colectionmode = salesItems.Where(p => p.LotteryModeId == mod.Id).ToList();

                if (colectionmode != null)
                {
                    var modToView = new LotteryModeView { Mode = mod.Name };

                    foreach (var item in colectionmode)
                    {
                        modToView.Sell += item.PlayedAmount;
                        modToView.First += item.Prize1;
                        modToView.Second += item.Prize2;
                        modToView.Third += item.Prize3;
                        modToView.Prize += item.Prize;
                    }
                    listModes.Add(modToView);

                    totalSell += modToView.Sell;
                    total1 += modToView.First;
                    total2 += modToView.Second;
                    total3 += modToView.Third;
                    totalPrize += modToView.Prize;
                }
            }
            foreach (var item in listModes)
            {
                try
                {
                    decimal percent = (item.Sell / totalSell) * 100;
                    item.Percent = Convert.ToInt32(percent);
                }
                catch (Exception  )
                {
                    item.Percent = 0;
                }

                vm.Modes.Add(item);
            }
            var modToViewx = new LotteryModeView
            {
                Mode = "TOTALES",
                Prize = totalPrize,
                First = total1,
                Second = total2,
                Third = total3,
                Sell = totalSell,
                Percent = 100
            };
            vm.Modes.Add(modToViewx);
            foreach (var mod in dbLotteries)
            {
                var colectionmode = salesItems.Where(p => p.LotteryId == mod.Id).ToList();

                if (colectionmode != null)
                {
                    var modToView = new LotteryView { };

                    foreach (var item in colectionmode)
                    {
                        modToView.Prizes += item.Prize;
                        modToView.SalesAmount += item.PlayedAmount;
                    }
                    modToView.Comissions = user.Comission * modToView.SalesAmount;
                    if (modToView.Comissions > 0)
                        modToView.Comissions /= 100;
                    modToView.Results = modToView.SalesAmount - modToView.Comissions - modToView.Prizes;
                    modToView.Name = mod.Name;
                    listLotteries.Add(modToView);

                    totalAmount += modToView.SalesAmount;
                    totalComission += modToView.Comissions;
                    totalResult += modToView.Results;
                    totalPrize += modToView.Prizes;
                }
            }
            foreach (var item in listLotteries)
            {
                try
                {
                    decimal percent = (item.SalesAmount / totalAmount) * 100;
                    item.Percent = Convert.ToInt32(percent);
                }
                catch (Exception  )
                {
                    item.Percent = 0;
                }

                vm.Lotteries.Add(item);
            }
            var modToViewxx = new LotteryView
            {
                Name = "TOTALES",
                Prizes = totalPrize,
                SalesAmount = totalAmount,
                Results = totalResult,
                Comissions = totalComission,
                Percent = 100
            };
            vm.Lotteries.Add(modToViewxx);

            return vm;
        }

        public async Task<List<LotterySale>> GetSalesAsync(DateTime dateFrom, DateTime dateTo, long ownerId)
        {
            var sales = Context.LotterySales 
                .Include(p => p.CreatedUser).ThenInclude(p => p.Owner)
                .Include(p => p.LotterySaleItems)
                .Include(p => p.LotterySaleItems).ThenInclude(p => p.Lottery).ThenInclude(p => p.LotterySchedules)
                .Include(p => p.LotterySaleItems).ThenInclude(p => p.Lottery).ThenInclude(p => p.LotteryFrom)
                .Include(p => p.LotterySaleItems).ThenInclude(p => p.LotteryMode)
                .Where(p => p.CreatedUser.Owner.Id == ownerId).AsNoTracking();

            return await sales.Where(p => p.CreatedAt.Value.Date >= dateFrom.Date && p.CreatedAt.Value.Date <= dateTo.Date).ToListAsync();
        }

        public async Task<List<ReportSaleItemView>> GetNumbersAsync(long ownerId, DateTime? dateFrom, DateTime? dateTo, long shop = 0,
           string userId = "", long lotteryId = 0, long modeId = 0)
        {
            var numbers = await GetItemsTicketsAsync(ownerId, dateFrom, dateTo, shop, userId, lotteryId, modeId);
            var lotteries = await Context.Lotteries.ToListAsync();
            var modes = await Context.LotteryModes.ToListAsync();

            if (modeId != 0)
                modes = modes.Where(p => p.Id == modeId).ToList();
            if (lotteryId != 0)
                lotteries = lotteries.Where(p => p.Id == lotteryId).ToList();

            var list = new List<ReportSaleItemView>();
            decimal amount = 0;

            var plays = await GetPlays(userId, ownerId, modeId, "", lotteryId, dateFrom, dateTo);
            foreach (var item in plays)
            {
                amount += item.Cumulative;
                list.Add(new ReportSaleItemView
                {
                    Lottery = item.Lottery.Name,
                    Mode = item.LotteryMode.Name,
                    Number = item.Number,
                    Amount = item.Cumulative
                });

            }

            list.Add(new ReportSaleItemView
            {
                Lottery = "TOTALES",
                Mode = "",
                Number = "",
                Amount = amount
            });
            return list;
        }

        public async Task<List<ReportSaleView>> GetSalesAsync(long ownerId, DateTime? dateFrom, DateTime? dateTo, long shop = 0,
           string userId = "")
        {
            var tickets = await GetTicketsAsync2(ownerId, dateFrom, dateTo, shop, userId);
            var users = await Context.Users.Where(p => p.Owner.Id == ownerId).ToListAsync();

            var saleList = new List<ReportSaleView>();

            decimal SaleAmounts = 0;
            decimal Prizes = 0;
            decimal Comissions = 0;
            decimal SupComissions = 0;
            decimal Results = 0;

            string seller;
            decimal sSaleAmounts = 0;
            decimal sPrizes = 0;
            decimal sComissions = 0;
            decimal sSupComissions = 0;
            decimal sResults = 0;

            foreach (var item in users)
            {
                var ticketsFromuser = tickets.Where(p => p.CreatedBy == item.Id).ToList();
                if (ticketsFromuser.Any())
                {
                    seller = item.FullName;
                    foreach (var ticket in ticketsFromuser)
                    {
                        sSaleAmounts += ticket.TotalAmount;
                        sPrizes += ticket.Prize;
                    }

                    sComissions = sSaleAmounts * (item.Comission / 100); 
                    sResults = sSaleAmounts - sSupComissions - sComissions - sPrizes;

                    saleList.Add(new ReportSaleView
                    {
                        Seller = seller,
                        SaleAmounts = sSaleAmounts,
                        Prizes = sPrizes,
                        Comissions = sComissions, 
                        Results = sResults
                    });

                    SaleAmounts += sSaleAmounts;
                    Prizes += sPrizes;
                    Comissions += sComissions;
                    SupComissions += sSupComissions;
                    Results += sResults;

                    sSaleAmounts = 0;
                    sPrizes = 0;
                    sComissions = 0;
                    sSupComissions = 0;
                    sResults = 0;
                }
            }

            saleList.Add(new ReportSaleView
            {
                Seller = "TOTALES",
                SaleAmounts = SaleAmounts,
                Prizes = Prizes,
                Comissions = Comissions,
                SupComissions = SupComissions,
                Results = Results
            });

            return saleList;
        }

        public async Task<List<ReportSaleView>> GetSupervisorAsync(long ownerId, DateTime? dateFrom, DateTime? dateTo, long shop = 0,
          string userId = "")
        {
            var tickets = await GetTicketsAsync2(ownerId, dateFrom, dateTo, shop, userId);
            var users = await Context.Users.Where(p => p.Owner.Id == ownerId).ToListAsync();

            var saleList = new List<ReportSaleView>();

            decimal SaleAmounts = 0;
            decimal Prizes = 0;
            decimal Comissions = 0;
            decimal SupComissions = 0;
            decimal Results = 0;

            string seller;
            decimal sSaleAmounts = 0;
            decimal sPrizes = 0;
            decimal sComissions = 0;
            decimal sSupComissions = 0;
            decimal sResults = 0;

            foreach (var item in users)
            {
                var ticketsFromuser = tickets.Where(p => p.CreatedUser == item).ToList();
                if (ticketsFromuser.Any())
                {
                    seller = item.FullName;
                    foreach (var ticket in ticketsFromuser)
                    {
                        sSaleAmounts += ticket.TotalAmount;
                        sPrizes += ticket.Prize;
                    }

                    sComissions = sSaleAmounts * (item.Comission / 100); 
                    sResults = sSaleAmounts - sSupComissions - sComissions - sPrizes;

                    saleList.Add(new ReportSaleView
                    {
                        Seller = seller,
                        SaleAmounts = sSaleAmounts,
                        Prizes = sPrizes,
                        Comissions = sComissions,
                        SupComissions = sSupComissions,
                        Results = sResults
                    });

                    SaleAmounts += sSaleAmounts;
                    Prizes += sPrizes;
                    Comissions += sComissions;
                    SupComissions += sSupComissions;
                    Results += sResults;

                    sSaleAmounts = 0;
                    sPrizes = 0;
                    sComissions = 0;
                    sSupComissions = 0;
                    sResults = 0;
                }
            }

            saleList.Add(new ReportSaleView
            {
                Seller = "",
                SaleAmounts = SaleAmounts,
                Prizes = Prizes,
                Comissions = Comissions,
                SupComissions = SupComissions,
                Results = Results
            });

            return saleList;
        }

        public async Task<ReportSellerView> GetSellerSalesAsync(long ownerId, DateTime? dateFrom, DateTime? dateTo, long shop = 0,
          string userId = "", int type = 0, bool isResumen = true)
        {
            var obj = new ReportSellerView();
            var tickets = await GetTicketsAsync2(ownerId, dateFrom, dateTo, shop, userId);
            var user = await Context.Users.FindAsync(userId);
            if (user == null)
                return obj;
            var saleList = new List<ReportSaleView>();
            var ticketList = new List<ReportSaleTicketView>();

            var ticketView = new ReportSaleTicketView
            {
                Makeit = tickets.Count(),
                Deleted = tickets.Where(p => p.Anulated).Count(),
                Paids = tickets.Where(p => p.WasPaid).Count(),
                Winners = tickets.Where(p => p.Winner).Count(),
                Pending = tickets.Where(p => p.Winner && !p.WasPaid).Count()
            };

            foreach (var item in tickets.Where(p => p.WasPaid))
            {
                ticketView.PaidAmount += item.Prize;
            }
            foreach (var item in tickets.Where(p => p.Winner && !p.WasPaid))
            {
                ticketView.PendingAmount += item.Prize;
            }

            ticketList.Add(ticketView);

            decimal SaleAmounts = 0;
            decimal Prizes = 0;
            decimal Comissions = 0;
            decimal SupComissions = 0;
            decimal Results = 0;

            //  string seller;
            decimal sSaleAmounts = 0;
            decimal sPrizes = 0;
            if (tickets.Any())
            {
                foreach (var ticket in tickets.Where(p => !p.Anulated))
                {
                    sSaleAmounts += ticket.TotalAmount;
                    sPrizes += ticket.Prize;
                }

                decimal sComissions = sSaleAmounts * (user.Comission / 100); 
                decimal sResults = sSaleAmounts -   sComissions - sPrizes;
                saleList.Add(new ReportSaleView
                {
                    // Seller = user.FullName,
                    SaleAmounts = sSaleAmounts,
                    Prizes = sPrizes,
                    Comissions = sComissions, 
                    Results = sResults
                });

                SaleAmounts += sSaleAmounts;
                Prizes += sPrizes;
                Comissions += sComissions; 
                Results += sResults;

                sSaleAmounts = 0;
                sPrizes = 0;

            }

            if (!isResumen)
            {
                saleList.Add(new ReportSaleView
                {
                    Seller = "TOTALES",
                    SaleAmounts = SaleAmounts,
                    Prizes = Prizes,
                    Comissions = Comissions,
                    SupComissions = SupComissions,
                    Results = Results
                });
            }


            obj.ReportSales = saleList;
            obj.ReportSaleTickets = ticketList;
            return obj;
        }

        public async Task<List<ReportSaleView>> GetLotteriesAndPlaysAsync(long ownerId, DateTime? dateFrom, DateTime? dateTo, long shop = 0,
          string userId = "")
        {
            var tickets = await GetItemsTicketsAsync(ownerId, dateFrom, dateTo, shop, userId);
            var users = await Context.Users.Where(p => p.Owner.Id == ownerId).ToListAsync();
            var lotteries = await Context.Lotteries.ToListAsync();

            var saleList = new List<ReportSaleView>();

            decimal SaleAmounts = 0;
            decimal Prizes = 0;
            decimal Comissions = 0;
            decimal SupComissions = 0;
            decimal Results = 0;

            // string seller;
            decimal sSaleAmounts = 0;
            decimal sPrizes = 0;
            decimal sComissions = 0;
            decimal sSupComissions = 0;
            decimal sResults = 0;

            foreach (var lottery in lotteries)
            {
                var ticketsFromuser = tickets.Where(p => p.Lottery == lottery).ToList();
                if (ticketsFromuser.Any())
                {
                    foreach (var ticket in ticketsFromuser)
                    {
                        sSaleAmounts += ticket.PlayedAmount;
                        sPrizes += ticket.Prize; 
                        sComissions += sSaleAmounts * (ticket.CreatedUser.Comission / 100);
                    }
                    sResults = sSaleAmounts - sSupComissions - sComissions - sPrizes;

                    saleList.Add(new ReportSaleView
                    {
                        LotteryId = lottery.Id,
                        Lottery = lottery.Name,
                        Seller = "",
                        SaleAmounts = sSaleAmounts,
                        Prizes = sPrizes,
                        Comissions = sComissions,
                        SupComissions = sSupComissions,
                        Results = sResults
                    });

                    SaleAmounts += sSaleAmounts;
                    Prizes += sPrizes;
                    Comissions += sComissions;
                    SupComissions += sSupComissions;
                    Results += sResults;

                    sSaleAmounts = 0;
                    sPrizes = 0;
                    sComissions = 0;
                    sSupComissions = 0;
                    sResults = 0;
                }
            }

            var returnList = new List<ReportSaleView>();

            foreach (var lottery in lotteries)
            {
                var lotData = saleList.Where(p => p.LotteryId == lottery.Id).FirstOrDefault();
                if (lotData != null)
                {
                    try
                    {
                        lotData.Percent = $"{(lotData.SaleAmounts / SaleAmounts) * 100} %";
                    }
                    catch (Exception )
                    {
                        lotData.Percent = "0 %";
                    }
                    returnList.Add(lotData);
                }
            }
            returnList.Add(new ReportSaleView
            {
                SaleAmounts = SaleAmounts,
                Prizes = Prizes,
                Comissions = Comissions,
                SupComissions = SupComissions,
                Results = Results,
                Percent = "100 %"
            });

            return returnList;
        }

        public async Task<List<ReportSaleView>> GetWinnersAsync(long ownerId, DateTime? dateFrom, DateTime? dateTo, long shop = 0,
         string userId = "")
        {
            var tickets = await GetItemsTicketsAsync(ownerId, dateFrom, dateTo, shop, userId);
            var saleList = new List<ReportSaleView>();
            foreach (var item in tickets.Where(p => p.Prize > 0))
            {
                saleList.Add(new ReportSaleView
                {
                    Seller = item.CreatedUser.FullName,
                    Ticket = item.LotterySale.Ticket,
                    Date = item.CreatedAt.Value.Date,
                    SaleAmounts = item.PlayedAmount,
                    Prizes = item.Prize,
                });
            }
            return saleList;
        }

        public async Task<List<ReportSaleView>> GetWinnersNoPaidAsync(long ownerId, DateTime? dateFrom, DateTime? dateTo, long shop = 0,
          string userId = "")
        {
            var tickets = await GetItemsTicketsAsync(ownerId, dateFrom, dateTo, shop, userId);
            var saleList = new List<ReportSaleView>();
            foreach (var item in tickets.Where(p => p.Prize > 0 && !p.LotterySale.WasPaid))
            {
                saleList.Add(new ReportSaleView
                {
                    Seller = item.CreatedUser.FullName,
                    Ticket = item.LotterySale.Ticket,
                    Date = item.CreatedAt.Value.Date,
                    SaleAmounts = item.PlayedAmount,
                    Prizes = item.Prize,
                });
            }
            return saleList;
        }

        public List<LotterySale> GetAnulatedSol(long ownerId)
        {
            var tickets = Context.LotterySaleItems
                .Include(p => p.LotterySale).ThenInclude(p => p.CreatedUser)
                .Include(p => p.LotterySale).ThenInclude(p => p.LotterySaleItems)
                .Where(p => p.LotterySale.AnulatedSol
                && p.CreatedAt.Value.Date == DateTime.Now.Date && p.CreatedUser.Owner.Id == ownerId)
                .ToList();

            var listToReturn = new List<LotterySale>();
            var lotteries = Task.Run(GetLoteries).Result;

            foreach (var lot in lotteries)
            {
                var schedule = GetScheduleAsync(lot, DateTime.Now);
                if (schedule.CloseHour.TimeOfDay > DateTime.Now.TimeOfDay)
                {
                    var reducedList = tickets.Where(p => p.Lottery == lot).ToList();

                    foreach (var item in reducedList.DistinctBy(p => p.LotterySaleId))
                    {
                        listToReturn.Add(item.LotterySale);
                    }
                    //var itemsToAdd = reducedList
                    //    .Select(p => p.LotterySaleId)
                    //              .DistinctBy(prop=>prop.).ToList();

                }
            }

            return listToReturn;
        }

        public async Task<List<ReportSaleView>> GetAnulatedAsync(long ownerId, DateTime? dateFrom, DateTime? dateTo, long shop = 0,
          string userId = "")
        {
            var tickets = await GetTicketsAsync2(ownerId, dateFrom, dateTo, shop, userId);
            var saleList = new List<ReportSaleView>();
            foreach (var item in tickets.Where(p => p.Anulated))
            {
                saleList.Add(new ReportSaleView
                {
                    Seller = item.UpdatedUser.FullName,
                    Ticket = item.Ticket,
                    Date = item.UpdatedAt.Value.Date,
                    SaleAmounts = item.TotalAmount,
                    Prizes = item.Prize,
                });
            }
            return saleList;
        }

        public async Task<List<LotterySaleItem>> GetItemsTicketsAsync(long ownerId, DateTime? dateFrom, DateTime? dateTo, long shop = 0,
           string userId = "", long lottery = 0, long mode = 0)
        {
            var tickets = Context.LotterySaleItems
                .Include(p => p.CreatedUser)
                .Include(p => p.LotterySale) 
                .Where(p => p.CreatedUser.Owner.Id == ownerId).AsNoTracking();

            if (!string.IsNullOrEmpty(userId))
                tickets = tickets.Where(p => p.CreatedBy == userId);
             
            if (lottery != 0)
                tickets = tickets.Where(p => p.LotteryId == lottery);

            if (mode != 0)
                tickets = tickets.Where(p => p.LotteryModeId == mode);

            if (dateFrom != null)
                tickets = tickets.Where(p => p.CreatedAt.Value.Date >= dateFrom.Value.Date);
            else
                tickets = tickets.Where(p => p.CreatedAt.Value.Date >= DateTime.Now.Date);

            if (dateTo != null)
                tickets = tickets.Where(p => p.CreatedAt.Value.Date <= dateTo.Value.Date);
            else
                tickets = tickets.Where(p => p.CreatedAt.Value.Date <= DateTime.Now.Date);

            return await tickets.ToListAsync();
        }

        public async Task<List<LotterySale>> GetTicketsAsync2(long ownerId, DateTime? dateFrom, DateTime? dateTo, long shop = 0,
            string userId = "")
        {
            var tickets = Context.LotterySales
                .Include(p => p.CreatedUser)
                .Include(p => p.UpdatedUser)
                .Where(p => p.CreatedUser.Owner.Id == ownerId).AsNoTracking();

            if (!string.IsNullOrEmpty(userId))
                tickets = tickets.Where(p => p.CreatedBy == userId);
             
            if ((dateFrom != null))
            {
                tickets = tickets.Where(p => p.CreatedAt.Value.Date >= dateFrom.Value.Date);
            }
            else
                tickets = tickets.Where(p => p.CreatedAt.Value.Date >= DateTime.Now.Date);

            if (dateTo != null)
            {
                tickets = tickets.Where(p => p.CreatedAt.Value.Date <= dateTo.Value.Date);
            }
            else
                tickets = tickets.Where(p => p.CreatedAt.Value.Date <= DateTime.Now.Date);

            return await tickets.ToListAsync();
        }
    }
}
