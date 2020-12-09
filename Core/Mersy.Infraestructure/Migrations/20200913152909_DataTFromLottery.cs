using Microsoft.EntityFrameworkCore.Migrations;

namespace Mersy.Infraestructure.Migrations
{
    public partial class DataTFromLottery : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"

 
 SET IDENTITY_INSERT lotteryfrom ON

insert into lotteryfrom (id,Name) values (1,'Global Dominicana');

insert into lotteryfrom  (id,Name)  values (2,'Global Bourlette');

SET IDENTITY_INSERT lotteryfrom off;



");


        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
