using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Mersy.Infraestructure.Migrations
{
    public partial class RefactoringEntities : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Images_Activities_ActivityId",
                table: "Images");

            migrationBuilder.DropForeignKey(
                name: "FK_Images_Benefits_BenefitId",
                table: "Images");

            migrationBuilder.DropForeignKey(
                name: "FK_Images_Classes_ClasseId",
                table: "Images");

            migrationBuilder.DropForeignKey(
                name: "FK_Images_ColaboratorDonations_ColaboratorDonationId",
                table: "Images");

            migrationBuilder.DropForeignKey(
                name: "FK_Images_Foods_FoodId",
                table: "Images");

            migrationBuilder.DropForeignKey(
                name: "FK_Images_Projects_ProjectId",
                table: "Images");

            migrationBuilder.DropForeignKey(
                name: "FK_Images_Signatures_SignatureId",
                table: "Images");

            migrationBuilder.DropForeignKey(
                name: "FK_Payments_Sales_SaleId",
                table: "Payments");

            migrationBuilder.DropForeignKey(
                name: "FK_People_BloodTypes_BloodTypeId",
                table: "People");

            migrationBuilder.DropForeignKey(
                name: "FK_People_Insurances_InsuranceId",
                table: "People");

            migrationBuilder.DropForeignKey(
                name: "FK_People_MemberTypes_MemberTypeId",
                table: "People");

            migrationBuilder.DropForeignKey(
                name: "FK_People_Specialities_SpecialityId",
                table: "People");

            migrationBuilder.DropTable(
                name: "ActivityBeneficiaries");

            migrationBuilder.DropTable(
                name: "ActivityParticipants");

            migrationBuilder.DropTable(
                name: "Admisions");

            migrationBuilder.DropTable(
                name: "Analiticals");

            migrationBuilder.DropTable(
                name: "AnalyticalSheets");

            migrationBuilder.DropTable(
                name: "Appointments");

            migrationBuilder.DropTable(
                name: "Asistants");

            migrationBuilder.DropTable(
                name: "BariatricVisits");

            migrationBuilder.DropTable(
                name: "Beneficiaries");

            migrationBuilder.DropTable(
                name: "BloodTypes");

            migrationBuilder.DropTable(
                name: "BuyDetails");

            migrationBuilder.DropTable(
                name: "ClinicHistories");

            migrationBuilder.DropTable(
                name: "ColaboratorDonations");

            migrationBuilder.DropTable(
                name: "Comensals");

            migrationBuilder.DropTable(
                name: "Conditions");

            migrationBuilder.DropTable(
                name: "CreditDebits");

            migrationBuilder.DropTable(
                name: "DaysOfTheWeeks");

            migrationBuilder.DropTable(
                name: "DentalHistories");

            migrationBuilder.DropTable(
                name: "Diagnostics");

            migrationBuilder.DropTable(
                name: "EconomicPerfils");

            migrationBuilder.DropTable(
                name: "Emergencies");

            migrationBuilder.DropTable(
                name: "Endocrines");

            migrationBuilder.DropTable(
                name: "Estudies");

            migrationBuilder.DropTable(
                name: "FoodDetails");

            migrationBuilder.DropTable(
                name: "ForumCommentReplies");

            migrationBuilder.DropTable(
                name: "ForumGradings");

            migrationBuilder.DropTable(
                name: "GeneralAfectionVisits");

            migrationBuilder.DropTable(
                name: "GeneralVisits");

            migrationBuilder.DropTable(
                name: "Gradings");

            migrationBuilder.DropTable(
                name: "GroupMessages");

            migrationBuilder.DropTable(
                name: "GroupStudents");

            migrationBuilder.DropTable(
                name: "GynecologyVisits");

            migrationBuilder.DropTable(
                name: "Inventories");

            migrationBuilder.DropTable(
                name: "Kids");

            migrationBuilder.DropTable(
                name: "Laboratories");

            migrationBuilder.DropTable(
                name: "LaboratoryResult");

            migrationBuilder.DropTable(
                name: "LessonReplies");

            migrationBuilder.DropTable(
                name: "MaterialInAndOuts");

            migrationBuilder.DropTable(
                name: "MaterialRequisitionDetails");

            migrationBuilder.DropTable(
                name: "MedicalCertificates");

            migrationBuilder.DropTable(
                name: "MemberTypes");

            migrationBuilder.DropTable(
                name: "MessageChats");

            migrationBuilder.DropTable(
                name: "MultiaxialHistories");

            migrationBuilder.DropTable(
                name: "ObstetricVisits");

            migrationBuilder.DropTable(
                name: "Occupants");

            migrationBuilder.DropTable(
                name: "OrderDetails");

            migrationBuilder.DropTable(
                name: "PatientAllergies");

            migrationBuilder.DropTable(
                name: "PatientDiagnostics");

            migrationBuilder.DropTable(
                name: "Pediatrics");

            migrationBuilder.DropTable(
                name: "PersonSpecialities");

            migrationBuilder.DropTable(
                name: "Prices");

            migrationBuilder.DropTable(
                name: "ProjectMembers");

            migrationBuilder.DropTable(
                name: "PurchaseDetails");

            migrationBuilder.DropTable(
                name: "QuickNotes");

            migrationBuilder.DropTable(
                name: "QuizzChoises");

            migrationBuilder.DropTable(
                name: "QuizzSubmitions");

            migrationBuilder.DropTable(
                name: "Recipes");

            migrationBuilder.DropTable(
                name: "RelatedPeople");

            migrationBuilder.DropTable(
                name: "SaleDetails");

            migrationBuilder.DropTable(
                name: "SaleLiquidationDetails");

            migrationBuilder.DropTable(
                name: "SaleLiquidations");

            migrationBuilder.DropTable(
                name: "SalesAccounts");

            migrationBuilder.DropTable(
                name: "SignatureMembers");

            migrationBuilder.DropTable(
                name: "Surgeries");

            migrationBuilder.DropTable(
                name: "UploadComments");

            migrationBuilder.DropTable(
                name: "UserEmailSettings");

            migrationBuilder.DropTable(
                name: "Visits");

            migrationBuilder.DropTable(
                name: "Activities");

            migrationBuilder.DropTable(
                name: "Doctors");

            migrationBuilder.DropTable(
                name: "Bariatrics");

            migrationBuilder.DropTable(
                name: "Benefits");

            migrationBuilder.DropTable(
                name: "Buys");

            migrationBuilder.DropTable(
                name: "Colaborators");

            migrationBuilder.DropTable(
                name: "Origins");

            migrationBuilder.DropTable(
                name: "Patients");

            migrationBuilder.DropTable(
                name: "Foods");

            migrationBuilder.DropTable(
                name: "ForumComments");

            migrationBuilder.DropTable(
                name: "GeneralAfections");

            migrationBuilder.DropTable(
                name: "Generals");

            migrationBuilder.DropTable(
                name: "Submissions");

            migrationBuilder.DropTable(
                name: "Gynecologies");

            migrationBuilder.DropTable(
                name: "Schools");

            migrationBuilder.DropTable(
                name: "Tandas");

            migrationBuilder.DropTable(
                name: "LabClasifications");

            migrationBuilder.DropTable(
                name: "LessonComments");

            migrationBuilder.DropTable(
                name: "Materials");

            migrationBuilder.DropTable(
                name: "MaterialRequisitions");

            migrationBuilder.DropTable(
                name: "Obstetrics");

            migrationBuilder.DropTable(
                name: "Classes");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Allergies");

            migrationBuilder.DropTable(
                name: "DiagnosticCies");

            migrationBuilder.DropTable(
                name: "Purchases");

            migrationBuilder.DropTable(
                name: "QuizzQuestions");

            migrationBuilder.DropTable(
                name: "RelationTypes");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Sales");

            migrationBuilder.DropTable(
                name: "Uploads");

            migrationBuilder.DropTable(
                name: "Schedules");

            migrationBuilder.DropTable(
                name: "Forums");

            migrationBuilder.DropTable(
                name: "Assignments");

            migrationBuilder.DropTable(
                name: "Lessons");

            migrationBuilder.DropTable(
                name: "Signatures");

            migrationBuilder.DropTable(
                name: "AllergyCategories");

            migrationBuilder.DropTable(
                name: "DiagnosticCategoryCie10s");

            migrationBuilder.DropTable(
                name: "Suppliers");

            migrationBuilder.DropTable(
                name: "Quizzes");

            migrationBuilder.DropTable(
                name: "Brands");

            migrationBuilder.DropTable(
                name: "Measures");

            migrationBuilder.DropTable(
                name: "ServiceTypes");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Insurances");

            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
                name: "Places");

            migrationBuilder.DropTable(
                name: "ScheduleFormats");

            migrationBuilder.DropTable(
                name: "Projects");

            migrationBuilder.DropTable(
                name: "Groups");

            migrationBuilder.DropTable(
                name: "Zones");

            migrationBuilder.DropTable(
                name: "Subjects");

            migrationBuilder.DropTable(
                name: "Courses");

            migrationBuilder.DropTable(
                name: "Specialities");

            migrationBuilder.DropTable(
                name: "SubjectModalities");

            migrationBuilder.DropTable(
                name: "CourseModalities");

            migrationBuilder.DropTable(
                name: "CourseTypes");

            migrationBuilder.DropIndex(
                name: "IX_People_BloodTypeId",
                table: "People");

            migrationBuilder.DropIndex(
                name: "IX_People_InsuranceId",
                table: "People");

            migrationBuilder.DropIndex(
                name: "IX_People_MemberTypeId",
                table: "People");

            migrationBuilder.DropIndex(
                name: "IX_People_SpecialityId",
                table: "People");

            migrationBuilder.DropIndex(
                name: "IX_Payments_SaleId",
                table: "Payments");

            migrationBuilder.DropIndex(
                name: "IX_Images_ActivityId",
                table: "Images");

            migrationBuilder.DropIndex(
                name: "IX_Images_BenefitId",
                table: "Images");

            migrationBuilder.DropIndex(
                name: "IX_Images_ClasseId",
                table: "Images");

            migrationBuilder.DropIndex(
                name: "IX_Images_ColaboratorDonationId",
                table: "Images");

            migrationBuilder.DropIndex(
                name: "IX_Images_FoodId",
                table: "Images");

            migrationBuilder.DropIndex(
                name: "IX_Images_ProjectId",
                table: "Images");

            migrationBuilder.DropIndex(
                name: "IX_Images_SignatureId",
                table: "Images");

            migrationBuilder.DropColumn(
                name: "BloodTypeId",
                table: "People");

            migrationBuilder.DropColumn(
                name: "InsuranceId",
                table: "People");

            migrationBuilder.DropColumn(
                name: "InsuranceNumber",
                table: "People");

            migrationBuilder.DropColumn(
                name: "MemberTypeId",
                table: "People");

            migrationBuilder.DropColumn(
                name: "SpecialityId",
                table: "People");

            migrationBuilder.DropColumn(
                name: "SaleId",
                table: "Payments");

            migrationBuilder.DropColumn(
                name: "ActivityId",
                table: "Images");

            migrationBuilder.DropColumn(
                name: "BenefitId",
                table: "Images");

            migrationBuilder.DropColumn(
                name: "ClasseId",
                table: "Images");

            migrationBuilder.DropColumn(
                name: "ColaboratorDonationId",
                table: "Images");

            migrationBuilder.DropColumn(
                name: "FoodId",
                table: "Images");

            migrationBuilder.DropColumn(
                name: "ProjectId",
                table: "Images");

            migrationBuilder.DropColumn(
                name: "SignatureId",
                table: "Images");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "BloodTypeId",
                table: "People",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "InsuranceId",
                table: "People",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "InsuranceNumber",
                table: "People",
                maxLength: 15,
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "MemberTypeId",
                table: "People",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "SpecialityId",
                table: "People",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "SaleId",
                table: "Payments",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "ActivityId",
                table: "Images",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "BenefitId",
                table: "Images",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "ClasseId",
                table: "Images",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "ColaboratorDonationId",
                table: "Images",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "FoodId",
                table: "Images",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "ProjectId",
                table: "Images",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "SignatureId",
                table: "Images",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "AllergyCategories",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AllergyCategories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Analiticals",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedAt = table.Column<DateTime>(nullable: true),
                    CreatedBy = table.Column<string>(nullable: true),
                    Deleted = table.Column<bool>(nullable: false),
                    DeletedAt = table.Column<DateTime>(nullable: true),
                    DeletedBy = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    ImageIsFrom = table.Column<int>(nullable: false),
                    ImagenUrl = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    PersonId = table.Column<long>(nullable: true),
                    UpdatedAt = table.Column<DateTime>(nullable: true),
                    UpdatedBy = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Analiticals", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Analiticals_AspNetUsers_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Analiticals_AspNetUsers_DeletedBy",
                        column: x => x.DeletedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Analiticals_People_PersonId",
                        column: x => x.PersonId,
                        principalTable: "People",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Analiticals_AspNetUsers_UpdatedBy",
                        column: x => x.UpdatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AnalyticalSheets",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AcFolico = table.Column<bool>(nullable: false),
                    AcUrico = table.Column<bool>(nullable: false),
                    AcidoFolico = table.Column<bool>(nullable: false),
                    AcidoUrico = table.Column<bool>(nullable: false),
                    AcidoValproico = table.Column<bool>(nullable: false),
                    Acth = table.Column<bool>(nullable: false),
                    AgAustraliano = table.Column<bool>(nullable: false),
                    Albumina = table.Column<bool>(nullable: false),
                    AlfaAmilasaPancreatica = table.Column<bool>(nullable: false),
                    Alfafetoproteina = table.Column<bool>(nullable: false),
                    Amilasa = table.Column<bool>(nullable: false),
                    AnalyticalSheetDate = table.Column<DateTime>(nullable: true),
                    AntiHaVlgM = table.Column<bool>(nullable: false),
                    AntiHav = table.Column<bool>(nullable: false),
                    AntiHbc = table.Column<bool>(nullable: false),
                    AntiHbe = table.Column<bool>(nullable: false),
                    AntiHbs = table.Column<bool>(nullable: false),
                    AntiHvc = table.Column<bool>(nullable: false),
                    AntigenosFebriles = table.Column<bool>(nullable: false),
                    AsoCuantitativo = table.Column<bool>(nullable: false),
                    B1 = table.Column<bool>(nullable: false),
                    B6 = table.Column<bool>(nullable: false),
                    BaciloscopiadeEsputo = table.Column<bool>(nullable: false),
                    BaciloscopiaenOrina = table.Column<bool>(nullable: false),
                    Bd = table.Column<bool>(nullable: false),
                    Bhcg = table.Column<bool>(nullable: false),
                    BhcgCuantitativo = table.Column<bool>(nullable: false),
                    Bi = table.Column<bool>(nullable: false),
                    BilD = table.Column<bool>(nullable: false),
                    BilI = table.Column<bool>(nullable: false),
                    BilTotal = table.Column<bool>(nullable: false),
                    Bilirrubina = table.Column<bool>(nullable: false),
                    Bun = table.Column<bool>(nullable: false),
                    Ca125 = table.Column<bool>(nullable: false),
                    Ca153 = table.Column<bool>(nullable: false),
                    Ca199 = table.Column<bool>(nullable: false),
                    Calcio = table.Column<bool>(nullable: false),
                    Cea = table.Column<bool>(nullable: false),
                    Cetos = table.Column<bool>(nullable: false),
                    ClamidialgG = table.Column<bool>(nullable: false),
                    ClamidialgM = table.Column<bool>(nullable: false),
                    ColesterolTotal = table.Column<bool>(nullable: false),
                    ConteodeEosinofilos = table.Column<bool>(nullable: false),
                    ConteodePlaquetas = table.Column<bool>(nullable: false),
                    ConteodeReticulocitos = table.Column<bool>(nullable: false),
                    Coprocultivo = table.Column<bool>(nullable: false),
                    Coprologico = table.Column<bool>(nullable: false),
                    CortisolAm = table.Column<bool>(nullable: false),
                    CortisolPm = table.Column<bool>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: true),
                    CreatedBy = table.Column<string>(nullable: true),
                    Creatinina = table.Column<bool>(nullable: false),
                    Cultivo = table.Column<bool>(nullable: false),
                    CultivoSecAbsceso = table.Column<bool>(nullable: false),
                    CultivoSecSemen = table.Column<bool>(nullable: false),
                    CultivoSecUretral = table.Column<bool>(nullable: false),
                    CultivoSecVaginal = table.Column<bool>(nullable: false),
                    CultivoSecdeHerida = table.Column<bool>(nullable: false),
                    CultivoVagin = table.Column<bool>(nullable: false),
                    Deleted = table.Column<bool>(nullable: false),
                    DeletedAt = table.Column<DateTime>(nullable: true),
                    DeletedBy = table.Column<string>(nullable: true),
                    DenguelgG = table.Column<bool>(nullable: false),
                    DenguelgM = table.Column<bool>(nullable: false),
                    DepuraciondeCreatinina = table.Column<bool>(nullable: false),
                    DimeroD = table.Column<bool>(nullable: false),
                    DoctorText = table.Column<string>(maxLength: 50, nullable: true),
                    ElectDeProteinas = table.Column<bool>(nullable: false),
                    ElectroforesisdeHemoglobina = table.Column<bool>(nullable: false),
                    EpsteinBarrlgG = table.Column<bool>(nullable: false),
                    EpsteinBarrlgM = table.Column<bool>(nullable: false),
                    Eritrosedimentacion = table.Column<bool>(nullable: false),
                    Espermatograma = table.Column<bool>(nullable: false),
                    Estradial = table.Column<bool>(nullable: false),
                    Estradiol = table.Column<bool>(nullable: false),
                    EstrogenosTotales = table.Column<bool>(nullable: false),
                    EstudiodeDigestion = table.Column<bool>(nullable: false),
                    Fal = table.Column<bool>(nullable: false),
                    Falcemia = table.Column<bool>(nullable: false),
                    Ferremia = table.Column<bool>(nullable: false),
                    Ferritina = table.Column<bool>(nullable: false),
                    Fibrinogeno = table.Column<bool>(nullable: false),
                    FosAlcalina = table.Column<bool>(nullable: false),
                    Fosforo = table.Column<bool>(nullable: false),
                    FragilidadEntrocitica = table.Column<bool>(nullable: false),
                    Fsh = table.Column<bool>(nullable: false),
                    Ftaabs = table.Column<bool>(nullable: false),
                    Ftabs = table.Column<bool>(nullable: false),
                    Ggpt = table.Column<bool>(nullable: false),
                    Glisemia = table.Column<bool>(nullable: false),
                    Glubotinas = table.Column<bool>(nullable: false),
                    GlucosaAyunas = table.Column<bool>(nullable: false),
                    GlucosaCurvaHoras = table.Column<bool>(nullable: false),
                    GlucosaPostPrandial = table.Column<bool>(nullable: false),
                    Hb = table.Column<bool>(nullable: false),
                    Hba1C = table.Column<bool>(nullable: false),
                    HbeAg = table.Column<bool>(nullable: false),
                    Hbsag = table.Column<bool>(nullable: false),
                    Hcc = table.Column<bool>(nullable: false),
                    Hcg = table.Column<bool>(nullable: false),
                    Hdl = table.Column<bool>(nullable: false),
                    Hemocultivo = table.Column<bool>(nullable: false),
                    HemoglobinaGlicosilada = table.Column<bool>(nullable: false),
                    Hemograma = table.Column<bool>(nullable: false),
                    HerpesIyIIlgG = table.Column<bool>(nullable: false),
                    HerpesIyIIlgM = table.Column<bool>(nullable: false),
                    Hhcg = table.Column<bool>(nullable: false),
                    HierroCaptacionFijacion = table.Column<bool>(nullable: false),
                    Hiv = table.Column<bool>(nullable: false),
                    Homa = table.Column<bool>(nullable: false),
                    HormonadeCrecPostEstimulo = table.Column<bool>(nullable: false),
                    HormonadeCrecimientoBasal = table.Column<bool>(nullable: false),
                    Hto = table.Column<bool>(nullable: false),
                    Igg = table.Column<bool>(nullable: false),
                    Igm = table.Column<bool>(nullable: false),
                    Insulina = table.Column<bool>(nullable: false),
                    InsulinaBasal = table.Column<bool>(nullable: false),
                    InsulinaPostPandrial = table.Column<bool>(nullable: false),
                    InvdeCelulasFalciformes = table.Column<bool>(nullable: false),
                    InvdeHematozoarias = table.Column<bool>(nullable: false),
                    InvdeSangreoculta = table.Column<bool>(nullable: false),
                    Ldh = table.Column<bool>(nullable: false),
                    Ldl = table.Column<bool>(nullable: false),
                    LgAInmunoglobina = table.Column<bool>(nullable: false),
                    LgE = table.Column<bool>(nullable: false),
                    LgGInmunoglobina = table.Column<bool>(nullable: false),
                    LgMInmunoglobina = table.Column<bool>(nullable: false),
                    Lh = table.Column<bool>(nullable: false),
                    Lipasa = table.Column<bool>(nullable: false),
                    LipidosTotales = table.Column<bool>(nullable: false),
                    Litemia = table.Column<bool>(nullable: false),
                    Magnesio = table.Column<bool>(nullable: false),
                    MicroalbuminaCualitativa = table.Column<bool>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Observations = table.Column<string>(maxLength: 500, nullable: true),
                    Oh = table.Column<bool>(nullable: false),
                    Orina = table.Column<bool>(nullable: false),
                    Panel4 = table.Column<bool>(nullable: false),
                    Paratohormona = table.Column<bool>(nullable: false),
                    PatientName = table.Column<string>(maxLength: 100, nullable: true),
                    PcRdealtaSensibilidad = table.Column<bool>(nullable: false),
                    Pcr = table.Column<bool>(nullable: false),
                    PeptidoC = table.Column<bool>(nullable: false),
                    PersonId = table.Column<long>(nullable: false),
                    Potasio = table.Column<bool>(nullable: false),
                    Progesterona = table.Column<bool>(nullable: false),
                    Prolactina = table.Column<bool>(nullable: false),
                    Proteinas = table.Column<bool>(nullable: false),
                    ProteinasTotales = table.Column<bool>(nullable: false),
                    PruebadeEmbarazo = table.Column<bool>(nullable: false),
                    Pth = table.Column<bool>(nullable: false),
                    RetracciondeCoagulo = table.Column<bool>(nullable: false),
                    RtoGb = table.Column<bool>(nullable: false),
                    Rubeola = table.Column<bool>(nullable: false),
                    Sgotast = table.Column<bool>(nullable: false),
                    Sgptalt = table.Column<bool>(nullable: false),
                    Sodio = table.Column<bool>(nullable: false),
                    T3 = table.Column<bool>(nullable: false),
                    T3Libre = table.Column<bool>(nullable: false),
                    T4 = table.Column<bool>(nullable: false),
                    T4Libre = table.Column<bool>(nullable: false),
                    Tc = table.Column<bool>(nullable: false),
                    TestdeCommbsDirecto = table.Column<bool>(nullable: false),
                    TestdeCommbsIndirecto = table.Column<bool>(nullable: false),
                    Tg = table.Column<bool>(nullable: false),
                    Tgo = table.Column<bool>(nullable: false),
                    Tgp = table.Column<bool>(nullable: false),
                    TiempodeCoagulacion = table.Column<bool>(nullable: false),
                    TiempodeSangria = table.Column<bool>(nullable: false),
                    TiempodeTrombina = table.Column<bool>(nullable: false),
                    Tipificacion = table.Column<bool>(nullable: false),
                    Tiroglubolina = table.Column<bool>(nullable: false),
                    ToxolgG = table.Column<bool>(nullable: false),
                    ToxolgM = table.Column<bool>(nullable: false),
                    Toxoplasmosis = table.Column<bool>(nullable: false),
                    Tp = table.Column<bool>(nullable: false),
                    Tpt = table.Column<bool>(nullable: false),
                    Transferrina = table.Column<bool>(nullable: false),
                    Trigiceridos = table.Column<bool>(nullable: false),
                    Trigliceridos = table.Column<bool>(nullable: false),
                    Tsh = table.Column<bool>(nullable: false),
                    Ttp = table.Column<bool>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: true),
                    UpdatedBy = table.Column<string>(nullable: true),
                    Urea = table.Column<bool>(nullable: false),
                    UreaNitrgenada = table.Column<bool>(nullable: false),
                    UroanalisisCompleto = table.Column<bool>(nullable: false),
                    Urocultivo = table.Column<bool>(nullable: false),
                    VdrLenLcr = table.Column<bool>(nullable: false),
                    Vdrl = table.Column<bool>(nullable: false),
                    VitD = table.Column<bool>(nullable: false),
                    VitaminaB12 = table.Column<bool>(nullable: false),
                    Vldl = table.Column<bool>(nullable: false),
                    Vma = table.Column<bool>(nullable: false),
                    Zinc = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AnalyticalSheets", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AnalyticalSheets_AspNetUsers_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AnalyticalSheets_AspNetUsers_DeletedBy",
                        column: x => x.DeletedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AnalyticalSheets_People_PersonId",
                        column: x => x.PersonId,
                        principalTable: "People",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AnalyticalSheets_AspNetUsers_UpdatedBy",
                        column: x => x.UpdatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Bariatrics",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Aburrimiento = table.Column<bool>(nullable: false),
                    Accidente = table.Column<bool>(nullable: false),
                    ActualMedication = table.Column<string>(maxLength: 2000, nullable: true),
                    AditionalMedication = table.Column<string>(maxLength: 2000, nullable: true),
                    Alcohol = table.Column<bool>(nullable: false),
                    Ansiedad = table.Column<bool>(nullable: false),
                    Artropatia = table.Column<bool>(nullable: false),
                    Atracones = table.Column<bool>(nullable: false),
                    Ayuno = table.Column<bool>(nullable: false),
                    BandaGastrica = table.Column<string>(maxLength: 15, nullable: true),
                    BodyFat = table.Column<string>(maxLength: 10, nullable: true),
                    BxparaH = table.Column<string>(maxLength: 100, nullable: true),
                    CPap = table.Column<bool>(nullable: false),
                    Carcinogenas = table.Column<bool>(nullable: false),
                    Cardiopatias = table.Column<bool>(nullable: false),
                    Cirugias = table.Column<bool>(nullable: false),
                    Complicaciones = table.Column<string>(maxLength: 500, nullable: true),
                    ComplicacionesPost = table.Column<string>(maxLength: 100, nullable: true),
                    ConsultationDate = table.Column<DateTime>(nullable: true),
                    CreatedAt = table.Column<DateTime>(nullable: true),
                    CreatedBy = table.Column<string>(nullable: true),
                    Deleted = table.Column<bool>(nullable: false),
                    DeletedAt = table.Column<DateTime>(nullable: true),
                    DeletedBy = table.Column<string>(nullable: true),
                    Depresion = table.Column<bool>(nullable: false),
                    DescripcionTecnica = table.Column<string>(maxLength: 2000, nullable: true),
                    Diabetes = table.Column<bool>(nullable: false),
                    Dislipemia = table.Column<bool>(nullable: false),
                    Drugs = table.Column<bool>(nullable: false),
                    Dulces = table.Column<bool>(nullable: false),
                    Ecocardiograma = table.Column<string>(maxLength: 100, nullable: true),
                    EcodopplerVenoso = table.Column<string>(maxLength: 100, nullable: true),
                    EcografiaAbdominal = table.Column<string>(maxLength: 100, nullable: true),
                    Ejercicio = table.Column<bool>(nullable: false),
                    Emocional = table.Column<bool>(nullable: false),
                    Enojo = table.Column<bool>(nullable: false),
                    EquipoQuirurgico = table.Column<string>(maxLength: 100, nullable: true),
                    Estadia = table.Column<string>(maxLength: 100, nullable: true),
                    EstadiaO = table.Column<string>(maxLength: 100, nullable: true),
                    FamilaryAlergias = table.Column<bool>(nullable: false),
                    FamilaryCardiopatias = table.Column<bool>(nullable: false),
                    FamiliaryComents = table.Column<string>(maxLength: 2000, nullable: true),
                    FamiliaryDiabetes = table.Column<bool>(nullable: false),
                    FamiliaryHipertension = table.Column<bool>(nullable: false),
                    FamiliaryObesy = table.Column<bool>(nullable: false),
                    FamiliaryOthers = table.Column<string>(maxLength: 500, nullable: true),
                    FamilySupport = table.Column<bool>(nullable: false),
                    FuncionalRespiratorio = table.Column<string>(maxLength: 100, nullable: true),
                    HdLbaja = table.Column<bool>(nullable: false),
                    Height = table.Column<string>(maxLength: 10, nullable: true),
                    Hepatobiliary = table.Column<bool>(nullable: false),
                    Hipertension = table.Column<bool>(nullable: false),
                    HistoryComents = table.Column<string>(maxLength: 2000, nullable: true),
                    HorasSemana = table.Column<string>(maxLength: 100, nullable: true),
                    Imc = table.Column<string>(maxLength: 10, nullable: true),
                    InformativeDate = table.Column<DateTime>(nullable: true),
                    IngestaEmocional = table.Column<int>(nullable: false),
                    Intolerancia = table.Column<bool>(nullable: false),
                    KidsNumber = table.Column<int>(nullable: false),
                    Laxantes = table.Column<bool>(nullable: false),
                    Limitaciones = table.Column<string>(maxLength: 100, nullable: true),
                    Liquidos = table.Column<bool>(nullable: false),
                    Marca = table.Column<string>(maxLength: 15, nullable: true),
                    MaxWeight = table.Column<string>(maxLength: 25, nullable: true),
                    Motivo = table.Column<string>(maxLength: 100, nullable: true),
                    Name = table.Column<string>(nullable: true),
                    NotasNutricional = table.Column<string>(maxLength: 2000, nullable: true),
                    Nro = table.Column<string>(maxLength: 15, nullable: true),
                    NroSerie = table.Column<string>(maxLength: 100, nullable: true),
                    Obesity = table.Column<int>(nullable: false),
                    ObesyChilds = table.Column<bool>(nullable: false),
                    ObesyKids = table.Column<bool>(nullable: false),
                    ObesyYears = table.Column<string>(maxLength: 25, nullable: true),
                    OtrasDepresion = table.Column<bool>(nullable: false),
                    OtrosPreQuirurgico = table.Column<string>(maxLength: 500, nullable: true),
                    PersonId = table.Column<long>(nullable: false),
                    PhysiologicalDisordersObstainers = table.Column<bool>(nullable: false),
                    Polisomnografia = table.Column<string>(maxLength: 100, nullable: true),
                    PreImc = table.Column<string>(maxLength: 10, nullable: true),
                    PreWeight = table.Column<string>(maxLength: 10, nullable: true),
                    ProcedimientosCombinados = table.Column<string>(maxLength: 100, nullable: true),
                    Purgas = table.Column<bool>(nullable: false),
                    RequirioUti = table.Column<bool>(nullable: false),
                    ResistenciaInsulina = table.Column<bool>(nullable: false),
                    RiesgoQuirurgico = table.Column<string>(maxLength: 100, nullable: true),
                    Rxtorax = table.Column<string>(maxLength: 100, nullable: true),
                    Salados = table.Column<bool>(nullable: false),
                    SeriadaGd = table.Column<string>(maxLength: 100, nullable: true),
                    Sgd = table.Column<string>(maxLength: 100, nullable: true),
                    Soledad = table.Column<bool>(nullable: false),
                    Solidos = table.Column<bool>(nullable: false),
                    SurgeryDate = table.Column<DateTime>(nullable: true),
                    SuturasMecanicas = table.Column<string>(maxLength: 15, nullable: true),
                    TabTrastornos = table.Column<bool>(nullable: false),
                    Tabaco = table.Column<bool>(nullable: false),
                    TecnicaOperatoria = table.Column<int>(nullable: false),
                    TiempQuirurgico = table.Column<string>(maxLength: 100, nullable: true),
                    TipoActividad = table.Column<string>(maxLength: 500, nullable: true),
                    Tolerancia = table.Column<string>(maxLength: 100, nullable: true),
                    Trastornos = table.Column<bool>(nullable: false),
                    TrastornosEndocrinos = table.Column<bool>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: true),
                    UpdatedBy = table.Column<string>(nullable: true),
                    Veda = table.Column<string>(maxLength: 100, nullable: true),
                    Vomitos = table.Column<bool>(nullable: false),
                    Weight = table.Column<string>(maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bariatrics", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Bariatrics_AspNetUsers_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Bariatrics_AspNetUsers_DeletedBy",
                        column: x => x.DeletedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Bariatrics_People_PersonId",
                        column: x => x.PersonId,
                        principalTable: "People",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Bariatrics_AspNetUsers_UpdatedBy",
                        column: x => x.UpdatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Benefits",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Amount = table.Column<decimal>(type: "decimal(12,2)", nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: true),
                    CreatedBy = table.Column<string>(nullable: true),
                    Date = table.Column<DateTime>(nullable: false),
                    Deleted = table.Column<bool>(nullable: false),
                    DeletedAt = table.Column<DateTime>(nullable: true),
                    DeletedBy = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    UpdatedAt = table.Column<DateTime>(nullable: true),
                    UpdatedBy = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Benefits", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Benefits_AspNetUsers_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Benefits_AspNetUsers_DeletedBy",
                        column: x => x.DeletedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Benefits_AspNetUsers_UpdatedBy",
                        column: x => x.UpdatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "BloodTypes",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Code = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BloodTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Brands",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedAt = table.Column<DateTime>(nullable: true),
                    CreatedBy = table.Column<string>(nullable: true),
                    Deleted = table.Column<bool>(nullable: false),
                    DeletedAt = table.Column<DateTime>(nullable: true),
                    DeletedBy = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    UpdatedAt = table.Column<DateTime>(nullable: true),
                    UpdatedBy = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Brands", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Brands_AspNetUsers_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Brands_AspNetUsers_DeletedBy",
                        column: x => x.DeletedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Brands_AspNetUsers_UpdatedBy",
                        column: x => x.UpdatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Buys",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedAt = table.Column<DateTime>(nullable: true),
                    CreatedBy = table.Column<string>(nullable: true),
                    Date = table.Column<DateTime>(nullable: false),
                    DateFrom = table.Column<DateTime>(nullable: false),
                    DateTo = table.Column<DateTime>(nullable: false),
                    Deleted = table.Column<bool>(nullable: false),
                    DeletedAt = table.Column<DateTime>(nullable: true),
                    DeletedBy = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Ncf = table.Column<string>(nullable: true),
                    No = table.Column<string>(nullable: true),
                    Notes = table.Column<string>(nullable: true),
                    Total = table.Column<decimal>(type: "decimal(12,2)", nullable: false),
                    TotalAmount = table.Column<decimal>(type: "decimal(12,2)", nullable: false),
                    TotalDiscount = table.Column<decimal>(type: "decimal(12,2)", nullable: false),
                    TotalItbis = table.Column<decimal>(type: "decimal(12,2)", nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: true),
                    UpdatedBy = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Buys", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Buys_AspNetUsers_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Buys_AspNetUsers_DeletedBy",
                        column: x => x.DeletedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Buys_AspNetUsers_UpdatedBy",
                        column: x => x.UpdatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedAt = table.Column<DateTime>(nullable: true),
                    CreatedBy = table.Column<string>(nullable: true),
                    Deleted = table.Column<bool>(nullable: false),
                    DeletedAt = table.Column<DateTime>(nullable: true),
                    DeletedBy = table.Column<string>(nullable: true),
                    IsSaleCategory = table.Column<bool>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    UpdatedAt = table.Column<DateTime>(nullable: true),
                    UpdatedBy = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Categories_AspNetUsers_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Categories_AspNetUsers_DeletedBy",
                        column: x => x.DeletedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Categories_AspNetUsers_UpdatedBy",
                        column: x => x.UpdatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ClinicHistories",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Alcohol = table.Column<string>(maxLength: 4, nullable: true),
                    Alucinaciones = table.Column<string>(maxLength: 4, nullable: true),
                    Anhedonia = table.Column<string>(maxLength: 4, nullable: true),
                    AsustaIntimida = table.Column<string>(maxLength: 4, nullable: true),
                    BuenApetito = table.Column<string>(maxLength: 4, nullable: true),
                    CONNERS = table.Column<string>(maxLength: 4, nullable: true),
                    CambioDeseoSexual = table.Column<string>(maxLength: 4, nullable: true),
                    CambioMotriz = table.Column<string>(maxLength: 4, nullable: true),
                    CambioPeso = table.Column<string>(maxLength: 4, nullable: true),
                    CantDrogasFrec = table.Column<string>(maxLength: 50, nullable: true),
                    CantTisanasFrec = table.Column<string>(maxLength: 50, nullable: true),
                    Cesarea = table.Column<string>(maxLength: 4, nullable: true),
                    ComeMucho = table.Column<string>(maxLength: 4, nullable: true),
                    ComePoco = table.Column<string>(maxLength: 4, nullable: true),
                    ComoIntento = table.Column<string>(maxLength: 250, nullable: true),
                    ConformePeso = table.Column<string>(maxLength: 4, nullable: true),
                    CreatedAt = table.Column<DateTime>(nullable: true),
                    CreatedBy = table.Column<string>(nullable: true),
                    CuandoInicio = table.Column<string>(maxLength: 250, nullable: true),
                    CuandoIntento = table.Column<string>(maxLength: 250, nullable: true),
                    CulpaOtros = table.Column<string>(maxLength: 4, nullable: true),
                    Deleted = table.Column<bool>(nullable: false),
                    DeletedAt = table.Column<DateTime>(nullable: true),
                    DeletedBy = table.Column<string>(nullable: true),
                    Delirios = table.Column<string>(maxLength: 4, nullable: true),
                    Describir = table.Column<string>(maxLength: 250, nullable: true),
                    DificultadTomaDecisiones = table.Column<string>(maxLength: 4, nullable: true),
                    Discute = table.Column<string>(maxLength: 4, nullable: true),
                    DoloresAhogo = table.Column<string>(maxLength: 4, nullable: true),
                    Drogas = table.Column<string>(maxLength: 4, nullable: true),
                    EnfermedadesDentales = table.Column<string>(maxLength: 50, nullable: true),
                    EnfermedadesFisicas = table.Column<string>(maxLength: 50, nullable: true),
                    EnfermedadesMentales = table.Column<string>(maxLength: 50, nullable: true),
                    EnfermedadesOtros = table.Column<string>(maxLength: 50, nullable: true),
                    EsCruel = table.Column<string>(maxLength: 4, nullable: true),
                    Escalofrios = table.Column<string>(maxLength: 4, nullable: true),
                    EstacionEspecificar = table.Column<string>(maxLength: 25, nullable: true),
                    EvitaGanarPeso = table.Column<string>(maxLength: 4, nullable: true),
                    EvitaPerderPeso = table.Column<string>(maxLength: 4, nullable: true),
                    FaltaAlientoAsfixia = table.Column<string>(maxLength: 4, nullable: true),
                    FaltaClases = table.Column<string>(maxLength: 4, nullable: true),
                    FaltaEnergia = table.Column<string>(maxLength: 4, nullable: true),
                    FrecuenciaPerderGanarPeso = table.Column<string>(maxLength: 50, nullable: true),
                    FueBuenEstudiante = table.Column<string>(maxLength: 4, nullable: true),
                    GestacionConComplicaciones = table.Column<string>(maxLength: 4, nullable: true),
                    GestacionNormal = table.Column<string>(maxLength: 4, nullable: true),
                    HaCometidoRobos = table.Column<string>(maxLength: 4, nullable: true),
                    HaDestruidoPropiedad = table.Column<string>(maxLength: 4, nullable: true),
                    HaForzadoSexo = table.Column<string>(maxLength: 4, nullable: true),
                    Inapetente = table.Column<string>(maxLength: 4, nullable: true),
                    IniciaPeleas = table.Column<string>(maxLength: 4, nullable: true),
                    Insaciable = table.Column<string>(maxLength: 4, nullable: true),
                    IntentoSuicidio = table.Column<string>(maxLength: 4, nullable: true),
                    Intranquilo = table.Column<string>(maxLength: 4, nullable: true),
                    Iracundo = table.Column<string>(maxLength: 4, nullable: true),
                    Irritabilidad = table.Column<string>(maxLength: 4, nullable: true),
                    Irritable = table.Column<string>(maxLength: 4, nullable: true),
                    LastimaFísicamente = table.Column<string>(maxLength: 4, nullable: true),
                    MOCA = table.Column<string>(maxLength: 4, nullable: true),
                    MecanismosDefensa = table.Column<string>(maxLength: 50, nullable: true),
                    Medicamentos = table.Column<string>(maxLength: 4, nullable: true),
                    MedicamentosFrec = table.Column<string>(maxLength: 50, nullable: true),
                    MiedoMuerte = table.Column<string>(maxLength: 4, nullable: true),
                    MolestaOtros = table.Column<string>(maxLength: 4, nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Nauseas = table.Column<string>(maxLength: 4, nullable: true),
                    NotasPsiquiatricas = table.Column<string>(nullable: true),
                    OtrosHabitosAlimenticios = table.Column<string>(maxLength: 25, nullable: true),
                    Palpitaciones = table.Column<string>(maxLength: 4, nullable: true),
                    PartoNatural = table.Column<string>(maxLength: 4, nullable: true),
                    PerdidaEquilibrio = table.Column<string>(maxLength: 4, nullable: true),
                    PersonId = table.Column<long>(nullable: false),
                    Pesadillos = table.Column<string>(maxLength: 4, nullable: true),
                    PesoActual = table.Column<string>(maxLength: 10, nullable: true),
                    Pica = table.Column<string>(maxLength: 4, nullable: true),
                    PiensaHacerseDanio = table.Column<string>(maxLength: 4, nullable: true),
                    PocoApetito = table.Column<string>(maxLength: 4, nullable: true),
                    ProblemasConcentracion = table.Column<string>(maxLength: 4, nullable: true),
                    QuejasSomaticas = table.Column<string>(maxLength: 4, nullable: true),
                    RAVEN = table.Column<string>(maxLength: 4, nullable: true),
                    SaleTarde = table.Column<string>(maxLength: 4, nullable: true),
                    SeEnoja = table.Column<string>(maxLength: 4, nullable: true),
                    SeRehusa = table.Column<string>(maxLength: 4, nullable: true),
                    SeVenga = table.Column<string>(maxLength: 4, nullable: true),
                    SensacionAhogo = table.Column<string>(maxLength: 4, nullable: true),
                    SensacionMareo = table.Column<string>(maxLength: 4, nullable: true),
                    SentimientosCulpa = table.Column<string>(maxLength: 4, nullable: true),
                    SexualmenteActivo = table.Column<string>(maxLength: 4, nullable: true),
                    SolucionesIntentadas = table.Column<string>(maxLength: 250, nullable: true),
                    Sonambulismo = table.Column<string>(maxLength: 4, nullable: true),
                    Sudoracion = table.Column<string>(maxLength: 4, nullable: true),
                    Sudoracion2 = table.Column<string>(maxLength: 4, nullable: true),
                    Te = table.Column<string>(maxLength: 4, nullable: true),
                    TematicaSuenos = table.Column<string>(maxLength: 50, nullable: true),
                    Temblores = table.Column<string>(maxLength: 4, nullable: true),
                    TemorEngordar = table.Column<string>(maxLength: 4, nullable: true),
                    TerroresNocturnos = table.Column<string>(maxLength: 4, nullable: true),
                    TienePareja = table.Column<string>(maxLength: 4, nullable: true),
                    TipologiaA = table.Column<string>(maxLength: 4, nullable: true),
                    TipologiaB = table.Column<string>(maxLength: 4, nullable: true),
                    TipologiaC = table.Column<string>(maxLength: 4, nullable: true),
                    Tranquilo = table.Column<string>(maxLength: 4, nullable: true),
                    UpdatedAt = table.Column<DateTime>(nullable: true),
                    UpdatedBy = table.Column<string>(nullable: true),
                    UtilizaArmas = table.Column<string>(maxLength: 4, nullable: true),
                    UtilizaPreservativo = table.Column<string>(maxLength: 4, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClinicHistories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ClinicHistories_AspNetUsers_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ClinicHistories_AspNetUsers_DeletedBy",
                        column: x => x.DeletedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ClinicHistories_People_PersonId",
                        column: x => x.PersonId,
                        principalTable: "People",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ClinicHistories_AspNetUsers_UpdatedBy",
                        column: x => x.UpdatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Colaborators",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Address = table.Column<string>(nullable: true),
                    ContactName = table.Column<string>(nullable: true),
                    CreatedAt = table.Column<DateTime>(nullable: true),
                    CreatedBy = table.Column<string>(nullable: true),
                    Deleted = table.Column<bool>(nullable: false),
                    DeletedAt = table.Column<DateTime>(nullable: true),
                    DeletedBy = table.Column<string>(nullable: true),
                    Details = table.Column<string>(nullable: true),
                    DonatedAmount = table.Column<decimal>(type: "decimal(12,2)", nullable: false),
                    Email = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Representant = table.Column<string>(nullable: true),
                    Tel1 = table.Column<string>(nullable: true),
                    Tel2 = table.Column<string>(nullable: true),
                    UpdatedAt = table.Column<DateTime>(nullable: true),
                    UpdatedBy = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Colaborators", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Colaborators_AspNetUsers_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Colaborators_AspNetUsers_DeletedBy",
                        column: x => x.DeletedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Colaborators_AspNetUsers_UpdatedBy",
                        column: x => x.UpdatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Conditions",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Conditions = table.Column<string>(nullable: true),
                    CreatedAt = table.Column<DateTime>(nullable: true),
                    CreatedBy = table.Column<string>(nullable: true),
                    CreationDate = table.Column<DateTime>(nullable: false),
                    Deleted = table.Column<bool>(nullable: false),
                    DeletedAt = table.Column<DateTime>(nullable: true),
                    DeletedBy = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    PersonId = table.Column<long>(nullable: false),
                    Title = table.Column<string>(nullable: true),
                    UpdatedAt = table.Column<DateTime>(nullable: true),
                    UpdatedBy = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Conditions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Conditions_AspNetUsers_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Conditions_AspNetUsers_DeletedBy",
                        column: x => x.DeletedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Conditions_People_PersonId",
                        column: x => x.PersonId,
                        principalTable: "People",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Conditions_AspNetUsers_UpdatedBy",
                        column: x => x.UpdatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CourseModalities",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Code = table.Column<string>(maxLength: 10, nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CourseModalities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CourseTypes",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Code = table.Column<string>(maxLength: 10, nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CourseTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DentalHistories",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    BruxismoCentrico = table.Column<string>(maxLength: 4, nullable: true),
                    BruxismoExcentrico = table.Column<string>(maxLength: 4, nullable: true),
                    CantidadDePiezasPerdidas = table.Column<string>(maxLength: 50, nullable: true),
                    CreatedAt = table.Column<DateTime>(nullable: true),
                    CreatedBy = table.Column<string>(nullable: true),
                    CualesPiezas = table.Column<string>(maxLength: 50, nullable: true),
                    Deleted = table.Column<bool>(nullable: false),
                    DeletedAt = table.Column<DateTime>(nullable: true),
                    DeletedBy = table.Column<string>(nullable: true),
                    Edentulismo = table.Column<string>(maxLength: 4, nullable: true),
                    Gingivitis = table.Column<string>(maxLength: 4, nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Periodontitis = table.Column<string>(maxLength: 4, nullable: true),
                    PersonId = table.Column<long>(nullable: false),
                    Ulcerativa = table.Column<string>(maxLength: 4, nullable: true),
                    UpdatedAt = table.Column<DateTime>(nullable: true),
                    UpdatedBy = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DentalHistories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DentalHistories_AspNetUsers_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DentalHistories_AspNetUsers_DeletedBy",
                        column: x => x.DeletedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DentalHistories_People_PersonId",
                        column: x => x.PersonId,
                        principalTable: "People",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DentalHistories_AspNetUsers_UpdatedBy",
                        column: x => x.UpdatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DiagnosticCategoryCie10s",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Code = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DiagnosticCategoryCie10s", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Doctors",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    City = table.Column<string>(nullable: true),
                    Cmd = table.Column<string>(nullable: true),
                    CreatedAt = table.Column<DateTime>(nullable: true),
                    CreatedBy = table.Column<string>(nullable: true),
                    Deleted = table.Column<bool>(nullable: false),
                    DeletedAt = table.Column<DateTime>(nullable: true),
                    DeletedBy = table.Column<string>(nullable: true),
                    Exequartur = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    PersonId = table.Column<long>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: true),
                    UpdatedBy = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Doctors", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Doctors_AspNetUsers_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Doctors_AspNetUsers_DeletedBy",
                        column: x => x.DeletedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Doctors_People_PersonId",
                        column: x => x.PersonId,
                        principalTable: "People",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Doctors_AspNetUsers_UpdatedBy",
                        column: x => x.UpdatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "EconomicPerfils",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ABANICOS = table.Column<bool>(nullable: false),
                    ACTIVIDADESOTRO = table.Column<string>(nullable: true),
                    AGRICOLAOTRO = table.Column<string>(nullable: true),
                    AGRICOLAS = table.Column<bool>(nullable: false),
                    AGUA = table.Column<int>(nullable: false),
                    ALQUILERS = table.Column<bool>(nullable: false),
                    ALUMBRADO = table.Column<int>(nullable: false),
                    ANALFABETISMO = table.Column<int>(nullable: false),
                    ARROZE = table.Column<bool>(nullable: false),
                    ASISTENESCUELA = table.Column<int>(nullable: false),
                    ATENCION = table.Column<int>(nullable: false),
                    BASURA = table.Column<int>(nullable: false),
                    BIENESOTRO = table.Column<string>(nullable: true),
                    CARNES = table.Column<bool>(nullable: false),
                    CISTERNAS = table.Column<bool>(nullable: false),
                    COMIDAS = table.Column<int>(nullable: false),
                    COMPUTADORAS = table.Column<bool>(nullable: false),
                    COMUNITARIO = table.Column<int>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: true),
                    CreatedBy = table.Column<string>(nullable: true),
                    Deleted = table.Column<bool>(nullable: false),
                    DeletedAt = table.Column<DateTime>(nullable: true),
                    DeletedBy = table.Column<string>(nullable: true),
                    Descripcion = table.Column<string>(nullable: true),
                    EDA = table.Column<int>(nullable: false),
                    EMPLEO = table.Column<int>(nullable: false),
                    ESCOLARIDAD = table.Column<int>(nullable: false),
                    ESTATUSMARITAL = table.Column<int>(nullable: false),
                    ESTUFAS = table.Column<bool>(nullable: false),
                    FAMILIARESS = table.Column<bool>(nullable: false),
                    FRUTASE = table.Column<bool>(nullable: false),
                    HABICHUELASE = table.Column<bool>(nullable: false),
                    HACINAMIENTO = table.Column<int>(nullable: false),
                    HUEVOSE = table.Column<bool>(nullable: false),
                    INGRESOS = table.Column<int>(nullable: false),
                    INGRESOSOTRO = table.Column<string>(nullable: true),
                    INTERESESS = table.Column<bool>(nullable: false),
                    IRA = table.Column<int>(nullable: false),
                    JUBILACIONS = table.Column<bool>(nullable: false),
                    LAVADORAS = table.Column<bool>(nullable: false),
                    LECHES = table.Column<bool>(nullable: false),
                    MICROEMPRESAOTRO = table.Column<string>(nullable: true),
                    MICROEMPRESAS = table.Column<bool>(nullable: false),
                    MIEMBROS = table.Column<int>(nullable: false),
                    NEVERAS = table.Column<bool>(nullable: false),
                    NIVELECONOMICO = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    OTROSACTIVIDADS = table.Column<bool>(nullable: false),
                    OTROSBIENESE = table.Column<bool>(nullable: false),
                    OTROSINGRESOS = table.Column<int>(nullable: false),
                    OTROSINGRESOSS = table.Column<bool>(nullable: false),
                    PANE = table.Column<bool>(nullable: false),
                    PAREDES = table.Column<int>(nullable: false),
                    PECUARIOOTRO = table.Column<string>(nullable: true),
                    PECUARIOS = table.Column<bool>(nullable: false),
                    PERSONASDORMITORIO = table.Column<int>(nullable: false),
                    PIEZAS = table.Column<int>(nullable: false),
                    PISO = table.Column<int>(nullable: false),
                    PLATANOS = table.Column<bool>(nullable: false),
                    PROPIETARIO = table.Column<int>(nullable: false),
                    PUNTUACIONFINAL = table.Column<int>(nullable: false),
                    PersonId = table.Column<long>(nullable: false),
                    RADIOS = table.Column<bool>(nullable: false),
                    RELIGION = table.Column<int>(nullable: false),
                    REMESASS = table.Column<bool>(nullable: false),
                    SANITARIO = table.Column<int>(nullable: false),
                    TECHO = table.Column<int>(nullable: false),
                    TELEFONOS = table.Column<bool>(nullable: false),
                    TELEVISORE = table.Column<bool>(nullable: false),
                    TIERRAS = table.Column<int>(nullable: false),
                    TIPOEMPLEADOR = table.Column<int>(nullable: false),
                    TIPOVIVIENDA = table.Column<int>(nullable: false),
                    TRABAJOSADICIONALES = table.Column<int>(nullable: false),
                    TRANSPORTE = table.Column<int>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: true),
                    UpdatedBy = table.Column<string>(nullable: true),
                    VEGETALESE = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EconomicPerfils", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EconomicPerfils_AspNetUsers_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_EconomicPerfils_AspNetUsers_DeletedBy",
                        column: x => x.DeletedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_EconomicPerfils_People_PersonId",
                        column: x => x.PersonId,
                        principalTable: "People",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_EconomicPerfils_AspNetUsers_UpdatedBy",
                        column: x => x.UpdatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Emergencies",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Accident = table.Column<bool>(nullable: false),
                    Aggression = table.Column<bool>(nullable: false),
                    Alergies = table.Column<bool>(nullable: false),
                    AlergiesDetails = table.Column<string>(maxLength: 500, nullable: true),
                    Antecedentes = table.Column<string>(maxLength: 1000, nullable: true),
                    AttentionWhere = table.Column<string>(maxLength: 200, nullable: true),
                    Clinic = table.Column<bool>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: true),
                    CreatedBy = table.Column<string>(nullable: true),
                    Date = table.Column<DateTime>(nullable: false),
                    Deleted = table.Column<bool>(nullable: false),
                    DeletedAt = table.Column<DateTime>(nullable: true),
                    DeletedBy = table.Column<string>(nullable: true),
                    Diagnostic = table.Column<string>(maxLength: 1000, nullable: true),
                    DoctorAutorization = table.Column<string>(maxLength: 100, nullable: true),
                    DriveAccidend = table.Column<bool>(nullable: false),
                    Ekg = table.Column<string>(maxLength: 1000, nullable: true),
                    Fc = table.Column<string>(maxLength: 50, nullable: true),
                    Fight = table.Column<bool>(nullable: false),
                    Fr = table.Column<string>(maxLength: 50, nullable: true),
                    General = table.Column<bool>(nullable: false),
                    Glisemia = table.Column<bool>(nullable: false),
                    Hemograma = table.Column<bool>(nullable: false),
                    Hour = table.Column<DateTime>(nullable: true),
                    Inmovilizacion = table.Column<bool>(nullable: false),
                    LaboralAccident = table.Column<bool>(nullable: false),
                    Maternidad = table.Column<bool>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Nebulization = table.Column<bool>(nullable: false),
                    NurseAdmision = table.Column<string>(maxLength: 100, nullable: true),
                    Observations = table.Column<string>(maxLength: 1000, nullable: true),
                    OriginOther = table.Column<string>(maxLength: 1000, nullable: true),
                    Orina = table.Column<bool>(nullable: false),
                    Others = table.Column<string>(maxLength: 200, nullable: true),
                    OthersEmergency = table.Column<string>(maxLength: 200, nullable: true),
                    PersonId = table.Column<long>(nullable: false),
                    PlaceId = table.Column<long>(nullable: false),
                    PregnantTest = table.Column<bool>(nullable: false),
                    PreviousAttention = table.Column<bool>(nullable: false),
                    Pulse = table.Column<string>(maxLength: 50, nullable: true),
                    Radiographics = table.Column<string>(maxLength: 1000, nullable: true),
                    Reanimation = table.Column<bool>(nullable: false),
                    Reason = table.Column<string>(maxLength: 1000, nullable: true),
                    Satura = table.Column<bool>(nullable: false),
                    Sonographics = table.Column<string>(maxLength: 1000, nullable: true),
                    StatusId = table.Column<long>(nullable: false),
                    Ta = table.Column<string>(maxLength: 50, nullable: true),
                    Temp = table.Column<string>(maxLength: 50, nullable: true),
                    Test = table.Column<string>(maxLength: 1000, nullable: true),
                    TestComments = table.Column<string>(maxLength: 1000, nullable: true),
                    Unid911 = table.Column<string>(nullable: true),
                    UpdatedAt = table.Column<DateTime>(nullable: true),
                    UpdatedBy = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Emergencies", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Emergencies_AspNetUsers_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Emergencies_AspNetUsers_DeletedBy",
                        column: x => x.DeletedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Emergencies_People_PersonId",
                        column: x => x.PersonId,
                        principalTable: "People",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Emergencies_Status_StatusId",
                        column: x => x.StatusId,
                        principalTable: "Status",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Emergencies_AspNetUsers_UpdatedBy",
                        column: x => x.UpdatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Endocrines",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Abdomen = table.Column<string>(maxLength: 500, nullable: true),
                    Abortions = table.Column<string>(maxLength: 50, nullable: true),
                    Acv = table.Column<bool>(nullable: false),
                    Alcohol = table.Column<bool>(nullable: false),
                    Alergies = table.Column<bool>(nullable: false),
                    AliveChilds = table.Column<string>(maxLength: 50, nullable: true),
                    Analgesicos = table.Column<bool>(nullable: false),
                    Antiagregantes = table.Column<bool>(nullable: false),
                    Antiarritmicos = table.Column<bool>(nullable: false),
                    Antibioticos = table.Column<bool>(nullable: false),
                    Anticoagulantes = table.Column<bool>(nullable: false),
                    Anticonceptivos = table.Column<bool>(nullable: false),
                    Antiinflamatorios = table.Column<bool>(nullable: false),
                    Arritmias = table.Column<bool>(nullable: false),
                    Asma = table.Column<bool>(nullable: false),
                    BornedDead = table.Column<string>(maxLength: 50, nullable: true),
                    Caesarean = table.Column<string>(maxLength: 50, nullable: true),
                    Cancer = table.Column<bool>(nullable: false),
                    Cardiopatia = table.Column<bool>(nullable: false),
                    ChestXray = table.Column<string>(maxLength: 500, nullable: true),
                    Coffee = table.Column<bool>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: true),
                    CreatedBy = table.Column<string>(nullable: true),
                    Creatinina = table.Column<string>(maxLength: 15, nullable: true),
                    CreationDate = table.Column<DateTime>(nullable: true),
                    Cuello = table.Column<string>(maxLength: 100, nullable: true),
                    Deleted = table.Column<bool>(nullable: false),
                    DeletedAt = table.Column<DateTime>(nullable: true),
                    DeletedBy = table.Column<string>(nullable: true),
                    Diabetes = table.Column<bool>(nullable: false),
                    Disnea = table.Column<bool>(nullable: false),
                    Dpn = table.Column<bool>(nullable: false),
                    Echocardiogram = table.Column<string>(maxLength: 500, nullable: true),
                    Edema = table.Column<bool>(nullable: false),
                    Electrocardiograph = table.Column<string>(maxLength: 500, nullable: true),
                    EnfHepaticas = table.Column<bool>(nullable: false),
                    EnfRenal = table.Column<bool>(nullable: false),
                    Esteroides = table.Column<bool>(nullable: false),
                    EvolCaso = table.Column<string>(maxLength: 1000, nullable: true),
                    ExOrina = table.Column<string>(maxLength: 15, nullable: true),
                    Fc = table.Column<string>(maxLength: 15, nullable: true),
                    Forceps = table.Column<string>(maxLength: 50, nullable: true),
                    Fr = table.Column<string>(maxLength: 15, nullable: true),
                    Gb = table.Column<string>(maxLength: 15, nullable: true),
                    Gestas = table.Column<string>(maxLength: 50, nullable: true),
                    Glicemia = table.Column<string>(maxLength: 15, nullable: true),
                    Hb = table.Column<string>(maxLength: 15, nullable: true),
                    Hbsag = table.Column<string>(maxLength: 15, nullable: true),
                    Hcto = table.Column<string>(maxLength: 15, nullable: true),
                    Hearth = table.Column<string>(maxLength: 500, nullable: true),
                    Hipotensores = table.Column<bool>(nullable: false),
                    Hta = table.Column<bool>(nullable: false),
                    Icc = table.Column<bool>(nullable: false),
                    IlegalSustances = table.Column<bool>(nullable: false),
                    Inr = table.Column<string>(maxLength: 15, nullable: true),
                    LastPregnant = table.Column<string>(maxLength: 50, nullable: true),
                    LowerExtremities = table.Column<string>(maxLength: 500, nullable: true),
                    Lungs = table.Column<string>(maxLength: 500, nullable: true),
                    MotConsulta = table.Column<string>(maxLength: 1000, nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Neurological = table.Column<string>(maxLength: 500, nullable: true),
                    Obecy = table.Column<bool>(nullable: false),
                    Obs = table.Column<string>(maxLength: 1000, nullable: true),
                    Observations = table.Column<string>(maxLength: 100, nullable: true),
                    Ortopnea = table.Column<bool>(nullable: false),
                    OtherCardio = table.Column<string>(maxLength: 500, nullable: true),
                    OtherMedicaments = table.Column<string>(maxLength: 500, nullable: true),
                    Others = table.Column<string>(maxLength: 500, nullable: true),
                    OthersPersonal = table.Column<string>(maxLength: 500, nullable: true),
                    OthersToxic = table.Column<string>(maxLength: 500, nullable: true),
                    Palpitaciones = table.Column<bool>(nullable: false),
                    PatientRisk = table.Column<string>(maxLength: 100, nullable: true),
                    PersonId = table.Column<long>(nullable: false),
                    Plaquetas = table.Column<string>(maxLength: 15, nullable: true),
                    Pregnancies = table.Column<string>(maxLength: 50, nullable: true),
                    PrematureChilds = table.Column<string>(maxLength: 50, nullable: true),
                    PresurgicalDiagnosis = table.Column<string>(maxLength: 100, nullable: true),
                    PreviousSurgeries = table.Column<string>(maxLength: 150, nullable: true),
                    Procedure = table.Column<string>(maxLength: 100, nullable: true),
                    ProcedureRisk = table.Column<string>(maxLength: 100, nullable: true),
                    Smoke = table.Column<bool>(nullable: false),
                    SuperiorLimbs = table.Column<string>(maxLength: 500, nullable: true),
                    Ta = table.Column<string>(maxLength: 15, nullable: true),
                    Tgo = table.Column<string>(maxLength: 15, nullable: true),
                    Tgp = table.Column<string>(maxLength: 15, nullable: true),
                    Torax = table.Column<string>(maxLength: 100, nullable: true),
                    ToraxPain = table.Column<bool>(nullable: false),
                    Tos = table.Column<bool>(nullable: false),
                    Tp = table.Column<string>(maxLength: 15, nullable: true),
                    Tpt = table.Column<string>(maxLength: 15, nullable: true),
                    UpdatedAt = table.Column<DateTime>(nullable: true),
                    UpdatedBy = table.Column<string>(nullable: true),
                    Valvulopatia = table.Column<bool>(nullable: false),
                    VascularPeriferic = table.Column<bool>(nullable: false),
                    Vhc = table.Column<string>(maxLength: 15, nullable: true),
                    Vih = table.Column<string>(maxLength: 15, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Endocrines", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Endocrines_AspNetUsers_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Endocrines_AspNetUsers_DeletedBy",
                        column: x => x.DeletedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Endocrines_People_PersonId",
                        column: x => x.PersonId,
                        principalTable: "People",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Endocrines_AspNetUsers_UpdatedBy",
                        column: x => x.UpdatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Estudies",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedAt = table.Column<DateTime>(nullable: true),
                    CreatedBy = table.Column<string>(nullable: true),
                    Deleted = table.Column<bool>(nullable: false),
                    DeletedAt = table.Column<DateTime>(nullable: true),
                    DeletedBy = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    ImageIsFrom = table.Column<int>(nullable: false),
                    ImagenUrl = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    PersonId = table.Column<long>(nullable: true),
                    UpdatedAt = table.Column<DateTime>(nullable: true),
                    UpdatedBy = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Estudies", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Estudies_AspNetUsers_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Estudies_AspNetUsers_DeletedBy",
                        column: x => x.DeletedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Estudies_People_PersonId",
                        column: x => x.PersonId,
                        principalTable: "People",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Estudies_AspNetUsers_UpdatedBy",
                        column: x => x.UpdatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Foods",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Amount = table.Column<decimal>(type: "decimal(12,2)", nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: true),
                    CreatedBy = table.Column<string>(nullable: true),
                    Date = table.Column<DateTime>(nullable: false),
                    Deleted = table.Column<bool>(nullable: false),
                    DeletedAt = table.Column<DateTime>(nullable: true),
                    DeletedBy = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    UpdatedAt = table.Column<DateTime>(nullable: true),
                    UpdatedBy = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Foods", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Foods_AspNetUsers_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Foods_AspNetUsers_DeletedBy",
                        column: x => x.DeletedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Foods_AspNetUsers_UpdatedBy",
                        column: x => x.UpdatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "GeneralAfections",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Conclusion = table.Column<string>(maxLength: 500, nullable: true),
                    CreatedAt = table.Column<DateTime>(nullable: true),
                    CreatedBy = table.Column<string>(nullable: true),
                    Deleted = table.Column<bool>(nullable: false),
                    DeletedAt = table.Column<DateTime>(nullable: true),
                    DeletedBy = table.Column<string>(nullable: true),
                    Indications = table.Column<string>(maxLength: 500, nullable: true),
                    Labs = table.Column<string>(maxLength: 500, nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Notes = table.Column<string>(maxLength: 500, nullable: true),
                    PersonId = table.Column<long>(nullable: false),
                    PhysicalExam = table.Column<string>(maxLength: 500, nullable: true),
                    Symptoms = table.Column<string>(maxLength: 500, nullable: true),
                    UpdatedAt = table.Column<DateTime>(nullable: true),
                    UpdatedBy = table.Column<string>(nullable: true),
                    VisitDate = table.Column<DateTime>(nullable: true),
                    VisitReason = table.Column<string>(maxLength: 500, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GeneralAfections", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GeneralAfections_AspNetUsers_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_GeneralAfections_AspNetUsers_DeletedBy",
                        column: x => x.DeletedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_GeneralAfections_People_PersonId",
                        column: x => x.PersonId,
                        principalTable: "People",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_GeneralAfections_AspNetUsers_UpdatedBy",
                        column: x => x.UpdatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Generals",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Accidents = table.Column<string>(maxLength: 500, nullable: true),
                    Alcohol = table.Column<bool>(nullable: false),
                    Alergys = table.Column<string>(maxLength: 500, nullable: true),
                    AntFamiliar = table.Column<string>(maxLength: 500, nullable: true),
                    AntPersonales = table.Column<string>(maxLength: 500, nullable: true),
                    CreatedAt = table.Column<DateTime>(nullable: true),
                    CreatedBy = table.Column<string>(nullable: true),
                    Deleted = table.Column<bool>(nullable: false),
                    DeletedAt = table.Column<DateTime>(nullable: true),
                    DeletedBy = table.Column<string>(nullable: true),
                    Diabetes = table.Column<bool>(nullable: false),
                    Drugs = table.Column<bool>(nullable: false),
                    Enfermedades = table.Column<string>(maxLength: 500, nullable: true),
                    Food = table.Column<string>(maxLength: 500, nullable: true),
                    Fracturas = table.Column<string>(maxLength: 500, nullable: true),
                    Incapacidades = table.Column<string>(maxLength: 500, nullable: true),
                    InfanciaEnferma = table.Column<string>(maxLength: 500, nullable: true),
                    Medicaments = table.Column<string>(maxLength: 500, nullable: true),
                    Menstruacion = table.Column<string>(maxLength: 500, nullable: true),
                    Name = table.Column<string>(nullable: true),
                    NoQuirurgicas = table.Column<string>(maxLength: 500, nullable: true),
                    Observations = table.Column<string>(maxLength: 2000, nullable: true),
                    Pasatiempos = table.Column<string>(maxLength: 500, nullable: true),
                    PersonId = table.Column<long>(nullable: false),
                    Piel = table.Column<string>(maxLength: 500, nullable: true),
                    Psiquiatria = table.Column<string>(maxLength: 500, nullable: true),
                    Respiracion = table.Column<string>(maxLength: 500, nullable: true),
                    Sports = table.Column<string>(maxLength: 500, nullable: true),
                    Sugeries = table.Column<string>(maxLength: 500, nullable: true),
                    Tobaco = table.Column<bool>(nullable: false),
                    Traumatismos = table.Column<string>(maxLength: 500, nullable: true),
                    UpdatedAt = table.Column<DateTime>(nullable: true),
                    UpdatedBy = table.Column<string>(nullable: true),
                    Urinarias = table.Column<string>(maxLength: 500, nullable: true),
                    Work = table.Column<string>(maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Generals", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Generals_AspNetUsers_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Generals_AspNetUsers_DeletedBy",
                        column: x => x.DeletedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Generals_People_PersonId",
                        column: x => x.PersonId,
                        principalTable: "People",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Generals_AspNetUsers_UpdatedBy",
                        column: x => x.UpdatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Gynecologies",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Abortions = table.Column<string>(maxLength: 50, nullable: true),
                    ActualUse = table.Column<string>(maxLength: 50, nullable: true),
                    AliveChilds = table.Column<string>(maxLength: 50, nullable: true),
                    Barrier = table.Column<string>(maxLength: 50, nullable: true),
                    BornedDead = table.Column<string>(maxLength: 50, nullable: true),
                    Caesarean = table.Column<string>(maxLength: 50, nullable: true),
                    CreatedAt = table.Column<DateTime>(nullable: true),
                    CreatedBy = table.Column<string>(nullable: true),
                    Deleted = table.Column<bool>(nullable: false),
                    DeletedAt = table.Column<DateTime>(nullable: true),
                    DeletedBy = table.Column<string>(nullable: true),
                    Div = table.Column<string>(maxLength: 50, nullable: true),
                    Dysmenorrhoea = table.Column<string>(maxLength: 50, nullable: true),
                    FirstSexualRelation = table.Column<string>(maxLength: 50, nullable: true),
                    Forceps = table.Column<string>(maxLength: 50, nullable: true),
                    Gestas = table.Column<string>(maxLength: 50, nullable: true),
                    LabsResult = table.Column<string>(maxLength: 2000, nullable: true),
                    LastPregnant = table.Column<string>(maxLength: 50, nullable: true),
                    MarriedTime = table.Column<string>(maxLength: 50, nullable: true),
                    Menarche = table.Column<string>(maxLength: 500, nullable: true),
                    MenstrualPatron = table.Column<string>(maxLength: 50, nullable: true),
                    Name = table.Column<string>(nullable: true),
                    NoSexualPartners = table.Column<string>(maxLength: 50, nullable: true),
                    Norplat = table.Column<string>(maxLength: 50, nullable: true),
                    Observations = table.Column<string>(maxLength: 2000, nullable: true),
                    Oral = table.Column<string>(maxLength: 50, nullable: true),
                    PastUse = table.Column<string>(maxLength: 50, nullable: true),
                    PersonId = table.Column<long>(nullable: false),
                    Pregnancies = table.Column<string>(maxLength: 50, nullable: true),
                    PrematureChilds = table.Column<string>(maxLength: 50, nullable: true),
                    Pubarquia = table.Column<string>(maxLength: 500, nullable: true),
                    SexualRelationPerWeek = table.Column<string>(maxLength: 50, nullable: true),
                    Telarquia = table.Column<string>(maxLength: 500, nullable: true),
                    UpdatedAt = table.Column<DateTime>(nullable: true),
                    UpdatedBy = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gynecologies", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Gynecologies_AspNetUsers_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Gynecologies_AspNetUsers_DeletedBy",
                        column: x => x.DeletedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Gynecologies_People_PersonId",
                        column: x => x.PersonId,
                        principalTable: "People",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Gynecologies_AspNetUsers_UpdatedBy",
                        column: x => x.UpdatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Insurances",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AditionalInfo = table.Column<string>(maxLength: 400, nullable: true),
                    Code = table.Column<string>(maxLength: 100, nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Rnc = table.Column<string>(maxLength: 15, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Insurances", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LabClasifications",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Comentary = table.Column<string>(maxLength: 200, nullable: true),
                    CreatedAt = table.Column<DateTime>(nullable: true),
                    CreatedBy = table.Column<string>(nullable: true),
                    Deleted = table.Column<bool>(nullable: false),
                    DeletedAt = table.Column<DateTime>(nullable: true),
                    DeletedBy = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    UpdatedAt = table.Column<DateTime>(nullable: true),
                    UpdatedBy = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LabClasifications", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LabClasifications_AspNetUsers_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_LabClasifications_AspNetUsers_DeletedBy",
                        column: x => x.DeletedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_LabClasifications_AspNetUsers_UpdatedBy",
                        column: x => x.UpdatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "LaboratoryResult",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ASO = table.Column<string>(maxLength: 25, nullable: true),
                    AcFolico = table.Column<string>(maxLength: 25, nullable: true),
                    AcUrico = table.Column<string>(maxLength: 25, nullable: true),
                    Acetona = table.Column<string>(maxLength: 25, nullable: true),
                    Albumina = table.Column<string>(maxLength: 25, nullable: true),
                    AlbuminaQ = table.Column<string>(maxLength: 25, nullable: true),
                    Amilasa = table.Column<string>(maxLength: 25, nullable: true),
                    Aspecto = table.Column<string>(maxLength: 25, nullable: true),
                    B1 = table.Column<string>(maxLength: 25, nullable: true),
                    B12 = table.Column<string>(maxLength: 25, nullable: true),
                    B6 = table.Column<string>(maxLength: 25, nullable: true),
                    Bacterias = table.Column<string>(maxLength: 25, nullable: true),
                    Banda = table.Column<string>(maxLength: 25, nullable: true),
                    Basofilos = table.Column<string>(maxLength: 25, nullable: true),
                    Bil = table.Column<string>(maxLength: 25, nullable: true),
                    Bilirrubina = table.Column<string>(maxLength: 25, nullable: true),
                    BrucelaAbortus = table.Column<string>(maxLength: 25, nullable: true),
                    CKMB = table.Column<string>(maxLength: 25, nullable: true),
                    Calcio = table.Column<string>(maxLength: 25, nullable: true),
                    CdeEosinofilos = table.Column<string>(maxLength: 25, nullable: true),
                    CdePlaquetas = table.Column<string>(maxLength: 25, nullable: true),
                    CdeReticulocitos = table.Column<string>(maxLength: 25, nullable: true),
                    CelEpiteliales = table.Column<string>(maxLength: 25, nullable: true),
                    CelFalciformes = table.Column<string>(maxLength: 25, nullable: true),
                    CelJuveniles = table.Column<string>(maxLength: 25, nullable: true),
                    Chcm = table.Column<string>(maxLength: 25, nullable: true),
                    Cilindros = table.Column<string>(maxLength: 25, nullable: true),
                    Ck = table.Column<string>(maxLength: 25, nullable: true),
                    Colesterol = table.Column<string>(maxLength: 25, nullable: true),
                    Color = table.Column<string>(maxLength: 25, nullable: true),
                    ComentAntigenos = table.Column<string>(maxLength: 25, nullable: true),
                    ComentOrinaCop = table.Column<string>(maxLength: 25, nullable: true),
                    ComentQuimica = table.Column<string>(maxLength: 25, nullable: true),
                    ComentariosRecuento = table.Column<string>(maxLength: 25, nullable: true),
                    CreatedAt = table.Column<DateTime>(nullable: true),
                    CreatedBy = table.Column<string>(nullable: true),
                    Creatinina = table.Column<string>(maxLength: 25, nullable: true),
                    Cristales = table.Column<string>(maxLength: 25, nullable: true),
                    Deleted = table.Column<bool>(nullable: false),
                    DeletedAt = table.Column<DateTime>(nullable: true),
                    DeletedBy = table.Column<string>(nullable: true),
                    Densidad = table.Column<string>(maxLength: 25, nullable: true),
                    Directa = table.Column<string>(maxLength: 25, nullable: true),
                    Eosinofilos = table.Column<string>(maxLength: 25, nullable: true),
                    Eritrosedimentacion = table.Column<string>(maxLength: 25, nullable: true),
                    ExtdeSangPeriferica = table.Column<string>(maxLength: 25, nullable: true),
                    FactorRH = table.Column<string>(maxLength: 25, nullable: true),
                    FactorReumatoide = table.Column<string>(maxLength: 25, nullable: true),
                    Fal = table.Column<string>(maxLength: 25, nullable: true),
                    Ferremia = table.Column<string>(maxLength: 25, nullable: true),
                    FibMucosas = table.Column<string>(maxLength: 25, nullable: true),
                    FosfatasaAcida = table.Column<string>(maxLength: 25, nullable: true),
                    FosfatasaAlcalina = table.Column<string>(maxLength: 25, nullable: true),
                    GBlancos = table.Column<string>(maxLength: 25, nullable: true),
                    GRojos = table.Column<string>(maxLength: 25, nullable: true),
                    Gb = table.Column<string>(maxLength: 25, nullable: true),
                    Glicemia = table.Column<string>(maxLength: 25, nullable: true),
                    Globulina = table.Column<string>(maxLength: 25, nullable: true),
                    Glucemia = table.Column<string>(maxLength: 25, nullable: true),
                    Glucosa = table.Column<string>(maxLength: 25, nullable: true),
                    Gr = table.Column<string>(maxLength: 25, nullable: true),
                    Grs = table.Column<string>(maxLength: 25, nullable: true),
                    HIV = table.Column<string>(maxLength: 25, nullable: true),
                    HPilory = table.Column<string>(maxLength: 25, nullable: true),
                    HVC = table.Column<string>(maxLength: 25, nullable: true),
                    Hb = table.Column<string>(maxLength: 25, nullable: true),
                    HbA1C = table.Column<string>(maxLength: 25, nullable: true),
                    HbGlucosilada = table.Column<string>(maxLength: 25, nullable: true),
                    Hcm = table.Column<string>(maxLength: 25, nullable: true),
                    Hdl = table.Column<string>(maxLength: 25, nullable: true),
                    Hematozoarios = table.Column<string>(maxLength: 25, nullable: true),
                    HepatitisB = table.Column<string>(maxLength: 25, nullable: true),
                    HepatitisC = table.Column<string>(maxLength: 25, nullable: true),
                    Homa = table.Column<string>(maxLength: 25, nullable: true),
                    Hto = table.Column<string>(maxLength: 25, nullable: true),
                    Huevos = table.Column<string>(maxLength: 25, nullable: true),
                    Indirecta = table.Column<string>(maxLength: 25, nullable: true),
                    Insulina = table.Column<string>(maxLength: 25, nullable: true),
                    InvdeAmebas = table.Column<string>(maxLength: 25, nullable: true),
                    LDH = table.Column<string>(maxLength: 25, nullable: true),
                    Ldl = table.Column<string>(maxLength: 25, nullable: true),
                    Levaduras = table.Column<string>(maxLength: 25, nullable: true),
                    Linfocitos = table.Column<string>(maxLength: 25, nullable: true),
                    Lipasa = table.Column<string>(maxLength: 25, nullable: true),
                    Magnesio = table.Column<string>(maxLength: 25, nullable: true),
                    Monocitos = table.Column<string>(maxLength: 25, nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Nitrito = table.Column<string>(maxLength: 25, nullable: true),
                    Notes = table.Column<string>(maxLength: 500, nullable: true),
                    Olor = table.Column<string>(maxLength: 25, nullable: true),
                    OtrosCop = table.Column<string>(maxLength: 25, nullable: true),
                    PCR = table.Column<string>(maxLength: 25, nullable: true),
                    Parasitos = table.Column<string>(maxLength: 25, nullable: true),
                    ParatyphiA = table.Column<string>(maxLength: 25, nullable: true),
                    ParatyphiB = table.Column<string>(maxLength: 25, nullable: true),
                    PersonId = table.Column<long>(nullable: false),
                    Ph = table.Column<string>(maxLength: 25, nullable: true),
                    ProteinaTotal = table.Column<string>(maxLength: 25, nullable: true),
                    Proteinas = table.Column<string>(maxLength: 25, nullable: true),
                    ProteusOxig = table.Column<string>(maxLength: 25, nullable: true),
                    PruebdeEmbarazo = table.Column<string>(maxLength: 25, nullable: true),
                    Pth = table.Column<string>(maxLength: 25, nullable: true),
                    RealizationDate = table.Column<DateTime>(nullable: true),
                    RelacionAG = table.Column<string>(maxLength: 25, nullable: true),
                    ResultDate = table.Column<DateTime>(nullable: true),
                    RtoGb = table.Column<string>(maxLength: 25, nullable: true),
                    SGOT = table.Column<string>(maxLength: 25, nullable: true),
                    SGPT = table.Column<string>(maxLength: 25, nullable: true),
                    SalmonelaThupiO = table.Column<string>(maxLength: 25, nullable: true),
                    SalmonelaTyphiH = table.Column<string>(maxLength: 25, nullable: true),
                    SangOculta = table.Column<string>(maxLength: 25, nullable: true),
                    SangOcultaCop = table.Column<string>(maxLength: 25, nullable: true),
                    Segmentados = table.Column<string>(maxLength: 25, nullable: true),
                    TP = table.Column<string>(maxLength: 25, nullable: true),
                    TSanguinea = table.Column<string>(maxLength: 25, nullable: true),
                    TdeCoagulacion = table.Column<string>(maxLength: 25, nullable: true),
                    TdeSangria = table.Column<string>(maxLength: 25, nullable: true),
                    Tg = table.Column<string>(maxLength: 25, nullable: true),
                    Tgo = table.Column<string>(maxLength: 25, nullable: true),
                    Tgp = table.Column<string>(maxLength: 25, nullable: true),
                    Total = table.Column<string>(maxLength: 25, nullable: true),
                    ToxoIGG = table.Column<string>(maxLength: 25, nullable: true),
                    ToxoIGM = table.Column<string>(maxLength: 25, nullable: true),
                    Tpt = table.Column<string>(maxLength: 25, nullable: true),
                    Trigliceridos = table.Column<string>(maxLength: 25, nullable: true),
                    Tsh = table.Column<string>(maxLength: 25, nullable: true),
                    UpdatedAt = table.Column<DateTime>(nullable: true),
                    UpdatedBy = table.Column<string>(nullable: true),
                    Urea = table.Column<string>(maxLength: 25, nullable: true),
                    Urobilinogeno = table.Column<string>(maxLength: 25, nullable: true),
                    VDRL = table.Column<string>(maxLength: 25, nullable: true),
                    VLDL = table.Column<string>(maxLength: 25, nullable: true),
                    Vcm = table.Column<string>(maxLength: 25, nullable: true),
                    VitD = table.Column<string>(maxLength: 25, nullable: true),
                    Zinc = table.Column<string>(maxLength: 25, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LaboratoryResult", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LaboratoryResult_AspNetUsers_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_LaboratoryResult_AspNetUsers_DeletedBy",
                        column: x => x.DeletedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_LaboratoryResult_People_PersonId",
                        column: x => x.PersonId,
                        principalTable: "People",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_LaboratoryResult_AspNetUsers_UpdatedBy",
                        column: x => x.UpdatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MaterialRequisitions",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Amount = table.Column<decimal>(type: "decimal(12,2)", nullable: false),
                    AprubedBy = table.Column<string>(nullable: true),
                    CreatedAt = table.Column<DateTime>(nullable: true),
                    CreatedBy = table.Column<string>(nullable: true),
                    Date = table.Column<DateTime>(nullable: false),
                    Deleted = table.Column<bool>(nullable: false),
                    DeletedAt = table.Column<DateTime>(nullable: true),
                    DeletedBy = table.Column<string>(nullable: true),
                    ElaboratedBy = table.Column<string>(nullable: true),
                    From = table.Column<string>(nullable: true),
                    LimitDate = table.Column<DateTime>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Notes = table.Column<string>(nullable: true),
                    PendingLiquidations = table.Column<string>(nullable: true),
                    RequisitorId = table.Column<string>(nullable: true),
                    StatusId = table.Column<long>(nullable: false),
                    To = table.Column<string>(nullable: true),
                    UpdatedAt = table.Column<DateTime>(nullable: true),
                    UpdatedBy = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MaterialRequisitions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MaterialRequisitions_AspNetUsers_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MaterialRequisitions_AspNetUsers_DeletedBy",
                        column: x => x.DeletedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MaterialRequisitions_AspNetUsers_RequisitorId",
                        column: x => x.RequisitorId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MaterialRequisitions_Status_StatusId",
                        column: x => x.StatusId,
                        principalTable: "Status",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MaterialRequisitions_AspNetUsers_UpdatedBy",
                        column: x => x.UpdatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Materials",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedAt = table.Column<DateTime>(nullable: true),
                    CreatedBy = table.Column<string>(nullable: true),
                    Deleted = table.Column<bool>(nullable: false),
                    DeletedAt = table.Column<DateTime>(nullable: true),
                    DeletedBy = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Stock = table.Column<int>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: true),
                    UpdatedBy = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Materials", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Materials_AspNetUsers_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Materials_AspNetUsers_DeletedBy",
                        column: x => x.DeletedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Materials_AspNetUsers_UpdatedBy",
                        column: x => x.UpdatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Measures",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Code = table.Column<string>(maxLength: 100, nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: true),
                    CreatedBy = table.Column<string>(nullable: true),
                    Deleted = table.Column<bool>(nullable: false),
                    DeletedAt = table.Column<DateTime>(nullable: true),
                    DeletedBy = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    UpdatedAt = table.Column<DateTime>(nullable: true),
                    UpdatedBy = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Measures", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Measures_AspNetUsers_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Measures_AspNetUsers_DeletedBy",
                        column: x => x.DeletedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Measures_AspNetUsers_UpdatedBy",
                        column: x => x.UpdatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MedicalCertificates",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Affections = table.Column<string>(maxLength: 1000, nullable: true),
                    Cmd = table.Column<string>(maxLength: 50, nullable: true),
                    CreatedAt = table.Column<DateTime>(nullable: true),
                    CreatedBy = table.Column<string>(nullable: true),
                    Deleted = table.Column<bool>(nullable: false),
                    DeletedAt = table.Column<DateTime>(nullable: true),
                    DeletedBy = table.Column<string>(nullable: true),
                    DoctorText = table.Column<string>(maxLength: 50, nullable: true),
                    Exequartur = table.Column<string>(maxLength: 50, nullable: true),
                    MedicalCertificateDate = table.Column<DateTime>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    PatientName = table.Column<string>(maxLength: 200, nullable: true),
                    PersonId = table.Column<long>(nullable: false),
                    Place = table.Column<string>(maxLength: 100, nullable: true),
                    Recomendations = table.Column<string>(maxLength: 450, nullable: true),
                    UpdatedAt = table.Column<DateTime>(nullable: true),
                    UpdatedBy = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MedicalCertificates", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MedicalCertificates_AspNetUsers_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MedicalCertificates_AspNetUsers_DeletedBy",
                        column: x => x.DeletedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MedicalCertificates_People_PersonId",
                        column: x => x.PersonId,
                        principalTable: "People",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MedicalCertificates_AspNetUsers_UpdatedBy",
                        column: x => x.UpdatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MemberTypes",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedAt = table.Column<DateTime>(nullable: true),
                    CreatedBy = table.Column<string>(nullable: true),
                    Deleted = table.Column<bool>(nullable: false),
                    DeletedAt = table.Column<DateTime>(nullable: true),
                    DeletedBy = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    UpdatedAt = table.Column<DateTime>(nullable: true),
                    UpdatedBy = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MemberTypes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MemberTypes_AspNetUsers_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MemberTypes_AspNetUsers_DeletedBy",
                        column: x => x.DeletedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MemberTypes_AspNetUsers_UpdatedBy",
                        column: x => x.UpdatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MessageChats",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedAt = table.Column<DateTime>(nullable: true),
                    CreatedBy = table.Column<string>(nullable: true),
                    Deleted = table.Column<bool>(nullable: false),
                    DeletedAt = table.Column<DateTime>(nullable: true),
                    DeletedBy = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Text = table.Column<string>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: true),
                    UpdatedBy = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: true),
                    UserName = table.Column<string>(nullable: false),
                    When = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MessageChats", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MessageChats_AspNetUsers_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MessageChats_AspNetUsers_DeletedBy",
                        column: x => x.DeletedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MessageChats_AspNetUsers_UpdatedBy",
                        column: x => x.UpdatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MessageChats_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MultiaxialHistories",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CondicionesMedicas = table.Column<string>(nullable: true),
                    CreatedAt = table.Column<DateTime>(nullable: true),
                    CreatedBy = table.Column<string>(nullable: true),
                    Deleted = table.Column<bool>(nullable: false),
                    DeletedAt = table.Column<DateTime>(nullable: true),
                    DeletedBy = table.Column<string>(nullable: true),
                    MarcoTiempo = table.Column<string>(maxLength: 50, nullable: true),
                    Name = table.Column<string>(nullable: true),
                    OtrosProblemasPsicosociales = table.Column<string>(maxLength: 250, nullable: true),
                    PersonId = table.Column<long>(nullable: false),
                    ProblemasAccesoSalud = table.Column<string>(maxLength: 250, nullable: true),
                    ProblemasAmbienteSocial = table.Column<string>(maxLength: 250, nullable: true),
                    ProblemasEconomicos = table.Column<string>(maxLength: 250, nullable: true),
                    ProblemasEducativos = table.Column<string>(maxLength: 250, nullable: true),
                    ProblemasGrupoApoyo = table.Column<string>(maxLength: 250, nullable: true),
                    ProblemasInteraccionLegal = table.Column<string>(maxLength: 250, nullable: true),
                    ProblemasOcupacionales = table.Column<string>(maxLength: 250, nullable: true),
                    ProblemasVivienda = table.Column<string>(maxLength: 250, nullable: true),
                    Puntuacion = table.Column<string>(maxLength: 50, nullable: true),
                    TrastornosClinicos = table.Column<string>(nullable: true),
                    TrastornosPersonalidad = table.Column<string>(nullable: true),
                    UpdatedAt = table.Column<DateTime>(nullable: true),
                    UpdatedBy = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MultiaxialHistories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MultiaxialHistories_AspNetUsers_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MultiaxialHistories_AspNetUsers_DeletedBy",
                        column: x => x.DeletedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MultiaxialHistories_People_PersonId",
                        column: x => x.PersonId,
                        principalTable: "People",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MultiaxialHistories_AspNetUsers_UpdatedBy",
                        column: x => x.UpdatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Obstetrics",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    A = table.Column<string>(maxLength: 50, nullable: true),
                    Allergies = table.Column<string>(maxLength: 500, nullable: true),
                    App = table.Column<string>(maxLength: 500, nullable: true),
                    BornObservations = table.Column<string>(maxLength: 2000, nullable: true),
                    C = table.Column<string>(maxLength: 50, nullable: true),
                    Coombs = table.Column<string>(maxLength: 500, nullable: true),
                    CreatedAt = table.Column<DateTime>(nullable: true),
                    CreatedBy = table.Column<string>(nullable: true),
                    CreationDate = table.Column<DateTime>(nullable: true),
                    Deleted = table.Column<bool>(nullable: false),
                    DeletedAt = table.Column<DateTime>(nullable: true),
                    DeletedBy = table.Column<string>(nullable: true),
                    Dmg = table.Column<string>(maxLength: 50, nullable: true),
                    E = table.Column<string>(maxLength: 50, nullable: true),
                    Electrophoresis = table.Column<string>(maxLength: 50, nullable: true),
                    Falcemia = table.Column<string>(maxLength: 50, nullable: true),
                    Fpp = table.Column<DateTime>(nullable: true),
                    FstTt = table.Column<string>(maxLength: 50, nullable: true),
                    Fum = table.Column<DateTime>(nullable: true),
                    Gesta = table.Column<string>(maxLength: 50, nullable: true),
                    Glycemia = table.Column<string>(maxLength: 50, nullable: true),
                    Hb = table.Column<string>(maxLength: 50, nullable: true),
                    HbsAg = table.Column<string>(maxLength: 50, nullable: true),
                    Hiv = table.Column<string>(maxLength: 50, nullable: true),
                    Hvc = table.Column<string>(maxLength: 50, nullable: true),
                    InductionLungMaturity = table.Column<string>(maxLength: 50, nullable: true),
                    LastPregnant = table.Column<string>(maxLength: 50, nullable: true),
                    Name = table.Column<string>(nullable: true),
                    P = table.Column<string>(maxLength: 50, nullable: true),
                    PersonId = table.Column<long>(nullable: false),
                    Plaq = table.Column<string>(maxLength: 50, nullable: true),
                    SndTt = table.Column<string>(maxLength: 50, nullable: true),
                    Sonography = table.Column<string>(maxLength: 2000, nullable: true),
                    UpdatedAt = table.Column<DateTime>(nullable: true),
                    UpdatedBy = table.Column<string>(nullable: true),
                    Urine = table.Column<string>(maxLength: 50, nullable: true),
                    Vdrl = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Obstetrics", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Obstetrics_AspNetUsers_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Obstetrics_AspNetUsers_DeletedBy",
                        column: x => x.DeletedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Obstetrics_People_PersonId",
                        column: x => x.PersonId,
                        principalTable: "People",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Obstetrics_AspNetUsers_UpdatedBy",
                        column: x => x.UpdatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedAt = table.Column<DateTime>(nullable: true),
                    CreatedBy = table.Column<string>(nullable: true),
                    Deleted = table.Column<bool>(nullable: false),
                    DeletedAt = table.Column<DateTime>(nullable: true),
                    DeletedBy = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    OrderDate = table.Column<DateTime>(nullable: true),
                    OrderNo = table.Column<string>(maxLength: 100, nullable: true),
                    PersonId = table.Column<long>(nullable: false),
                    Remarks = table.Column<string>(maxLength: 200, nullable: true),
                    Seq = table.Column<int>(nullable: false),
                    SubTotal = table.Column<decimal>(type: "decimal(12,2)", nullable: false),
                    Total = table.Column<decimal>(type: "decimal(12,2)", nullable: false),
                    TotalCharges = table.Column<decimal>(type: "decimal(12,2)", nullable: false),
                    TotalDiscount = table.Column<decimal>(type: "decimal(12,2)", nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: true),
                    UpdatedBy = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Orders_AspNetUsers_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Orders_AspNetUsers_DeletedBy",
                        column: x => x.DeletedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Orders_People_PersonId",
                        column: x => x.PersonId,
                        principalTable: "People",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Orders_AspNetUsers_UpdatedBy",
                        column: x => x.UpdatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Origins",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Code = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Simbol = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Origins", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Patients",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Alergies = table.Column<string>(maxLength: 150, nullable: true),
                    Companion = table.Column<string>(nullable: true),
                    CreatedAt = table.Column<DateTime>(nullable: true),
                    CreatedBy = table.Column<string>(nullable: true),
                    Deleted = table.Column<bool>(nullable: false),
                    DeletedAt = table.Column<DateTime>(nullable: true),
                    DeletedBy = table.Column<string>(nullable: true),
                    Illness = table.Column<string>(maxLength: 150, nullable: true),
                    MedicamentationTime = table.Column<string>(maxLength: 150, nullable: true),
                    Medicaments = table.Column<string>(maxLength: 150, nullable: true),
                    Name = table.Column<string>(nullable: true),
                    PersonId = table.Column<long>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: true),
                    UpdatedBy = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Patients", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Patients_AspNetUsers_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Patients_AspNetUsers_DeletedBy",
                        column: x => x.DeletedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Patients_People_PersonId",
                        column: x => x.PersonId,
                        principalTable: "People",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Patients_AspNetUsers_UpdatedBy",
                        column: x => x.UpdatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Pediatrics",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Abortos = table.Column<string>(maxLength: 25, nullable: true),
                    Alergia = table.Column<string>(maxLength: 25, nullable: true),
                    Alimentacion = table.Column<string>(maxLength: 50, nullable: true),
                    AliveKids = table.Column<string>(maxLength: 25, nullable: true),
                    Amebiasis = table.Column<string>(maxLength: 25, nullable: true),
                    Amigdalitis = table.Column<string>(maxLength: 25, nullable: true),
                    AnomaliasCongenitas = table.Column<string>(maxLength: 25, nullable: true),
                    Apendicitis = table.Column<string>(maxLength: 25, nullable: true),
                    Apgar2 = table.Column<string>(maxLength: 50, nullable: true),
                    BloodTypeId = table.Column<int>(nullable: false),
                    BornConditions = table.Column<string>(maxLength: 50, nullable: true),
                    BornPounds = table.Column<string>(maxLength: 25, nullable: true),
                    Brothers = table.Column<string>(maxLength: 100, nullable: true),
                    Camino = table.Column<string>(maxLength: 25, nullable: true),
                    Cesarea = table.Column<string>(maxLength: 25, nullable: true),
                    Cianosis = table.Column<string>(maxLength: 50, nullable: true),
                    Colicos = table.Column<string>(maxLength: 50, nullable: true),
                    Constipacion = table.Column<string>(maxLength: 25, nullable: true),
                    ControlIntestinos = table.Column<string>(maxLength: 25, nullable: true),
                    ControlVesical = table.Column<string>(maxLength: 25, nullable: true),
                    Convulciones = table.Column<string>(maxLength: 50, nullable: true),
                    ConvulcionesPersonales = table.Column<string>(maxLength: 25, nullable: true),
                    Convulsiones = table.Column<string>(maxLength: 25, nullable: true),
                    CreatedAt = table.Column<DateTime>(nullable: true),
                    CreatedBy = table.Column<string>(nullable: true),
                    Deleted = table.Column<bool>(nullable: false),
                    DeletedAt = table.Column<DateTime>(nullable: true),
                    DeletedBy = table.Column<string>(nullable: true),
                    Dengue = table.Column<string>(maxLength: 25, nullable: true),
                    Diabetes = table.Column<string>(maxLength: 25, nullable: true),
                    Diarrea = table.Column<string>(maxLength: 25, nullable: true),
                    DietaActual = table.Column<string>(maxLength: 25, nullable: true),
                    Difteria = table.Column<string>(maxLength: 25, nullable: true),
                    Escarlatina = table.Column<string>(maxLength: 25, nullable: true),
                    Father = table.Column<string>(maxLength: 50, nullable: true),
                    FiebreEumatica = table.Column<string>(maxLength: 25, nullable: true),
                    FirstWords = table.Column<string>(maxLength: 25, nullable: true),
                    Formulas = table.Column<string>(maxLength: 50, nullable: true),
                    FracesCortas = table.Column<string>(maxLength: 25, nullable: true),
                    FrstWeekConditions = table.Column<string>(maxLength: 50, nullable: true),
                    Gesta = table.Column<string>(maxLength: 25, nullable: true),
                    HabitosAlimenticios = table.Column<string>(maxLength: 50, nullable: true),
                    Ictericia = table.Column<string>(maxLength: 50, nullable: true),
                    Infomatec = table.Column<string>(maxLength: 25, nullable: true),
                    Irs = table.Column<string>(maxLength: 25, nullable: true),
                    LabsResult = table.Column<string>(maxLength: 2000, nullable: true),
                    Mother = table.Column<string>(maxLength: 50, nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Obitos = table.Column<string>(maxLength: 25, nullable: true),
                    Observations = table.Column<string>(maxLength: 2000, nullable: true),
                    Operaciones = table.Column<string>(maxLength: 25, nullable: true),
                    Others = table.Column<string>(maxLength: 500, nullable: true),
                    Otitis = table.Column<string>(maxLength: 25, nullable: true),
                    OtrasEnfermedades = table.Column<string>(maxLength: 500, nullable: true),
                    Paperas = table.Column<string>(maxLength: 25, nullable: true),
                    Para = table.Column<string>(maxLength: 25, nullable: true),
                    Parto = table.Column<string>(maxLength: 25, nullable: true),
                    Pecho = table.Column<string>(maxLength: 25, nullable: true),
                    PersonId = table.Column<long>(nullable: false),
                    PrimerDiente = table.Column<string>(maxLength: 25, nullable: true),
                    Rubeola = table.Column<string>(maxLength: 25, nullable: true),
                    Sarampion = table.Column<string>(maxLength: 25, nullable: true),
                    SeParo = table.Column<string>(maxLength: 25, nullable: true),
                    SeSento = table.Column<string>(maxLength: 25, nullable: true),
                    Sisters = table.Column<string>(maxLength: 100, nullable: true),
                    SoftFoods = table.Column<string>(maxLength: 50, nullable: true),
                    TallaAlNacer = table.Column<string>(maxLength: 25, nullable: true),
                    Termino = table.Column<string>(maxLength: 50, nullable: true),
                    Tosferina = table.Column<string>(maxLength: 25, nullable: true),
                    Tuberculosis = table.Column<string>(maxLength: 25, nullable: true),
                    UpdatedAt = table.Column<DateTime>(nullable: true),
                    UpdatedBy = table.Column<string>(nullable: true),
                    Varicela = table.Column<string>(maxLength: 25, nullable: true),
                    Vitaminas = table.Column<string>(maxLength: 25, nullable: true),
                    Vomitos = table.Column<string>(maxLength: 25, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pediatrics", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Pediatrics_AspNetUsers_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Pediatrics_AspNetUsers_DeletedBy",
                        column: x => x.DeletedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Pediatrics_People_PersonId",
                        column: x => x.PersonId,
                        principalTable: "People",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Pediatrics_AspNetUsers_UpdatedBy",
                        column: x => x.UpdatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Projects",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedAt = table.Column<DateTime>(nullable: true),
                    CreatedBy = table.Column<string>(nullable: true),
                    Deleted = table.Column<bool>(nullable: false),
                    DeletedAt = table.Column<DateTime>(nullable: true),
                    DeletedBy = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    UpdatedAt = table.Column<DateTime>(nullable: true),
                    UpdatedBy = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Projects", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Projects_AspNetUsers_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Projects_AspNetUsers_DeletedBy",
                        column: x => x.DeletedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Projects_AspNetUsers_UpdatedBy",
                        column: x => x.UpdatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "QuickNotes",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedAt = table.Column<DateTime>(nullable: true),
                    CreatedBy = table.Column<string>(nullable: true),
                    CreationDate = table.Column<DateTime>(nullable: true),
                    Deleted = table.Column<bool>(nullable: false),
                    DeletedAt = table.Column<DateTime>(nullable: true),
                    DeletedBy = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Note = table.Column<string>(nullable: true),
                    PersonId = table.Column<long>(nullable: false),
                    Title = table.Column<string>(nullable: true),
                    UpdatedAt = table.Column<DateTime>(nullable: true),
                    UpdatedBy = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuickNotes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_QuickNotes_AspNetUsers_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_QuickNotes_AspNetUsers_DeletedBy",
                        column: x => x.DeletedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_QuickNotes_People_PersonId",
                        column: x => x.PersonId,
                        principalTable: "People",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_QuickNotes_AspNetUsers_UpdatedBy",
                        column: x => x.UpdatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Recipes",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedAt = table.Column<DateTime>(nullable: true),
                    CreatedBy = table.Column<string>(nullable: true),
                    Deleted = table.Column<bool>(nullable: false),
                    DeletedAt = table.Column<DateTime>(nullable: true),
                    DeletedBy = table.Column<string>(nullable: true),
                    DoctorText = table.Column<string>(maxLength: 50, nullable: true),
                    Duracion = table.Column<string>(maxLength: 50, nullable: true),
                    Envases = table.Column<string>(maxLength: 50, nullable: true),
                    Indications = table.Column<string>(maxLength: 50, nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Observations = table.Column<string>(maxLength: 500, nullable: true),
                    PatientName = table.Column<string>(maxLength: 100, nullable: true),
                    PersonId = table.Column<long>(nullable: false),
                    Place = table.Column<string>(maxLength: 100, nullable: true),
                    Posologia = table.Column<string>(maxLength: 50, nullable: true),
                    RecipeDate = table.Column<DateTime>(nullable: true),
                    RecipeText = table.Column<string>(maxLength: 1000, nullable: true),
                    UpdatedAt = table.Column<DateTime>(nullable: true),
                    UpdatedBy = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Recipes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Recipes_AspNetUsers_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Recipes_AspNetUsers_DeletedBy",
                        column: x => x.DeletedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Recipes_People_PersonId",
                        column: x => x.PersonId,
                        principalTable: "People",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Recipes_AspNetUsers_UpdatedBy",
                        column: x => x.UpdatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "RelationTypes",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RelationTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ScheduleFormats",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ScheduleFormats", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Schools",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedAt = table.Column<DateTime>(nullable: true),
                    CreatedBy = table.Column<string>(nullable: true),
                    Deleted = table.Column<bool>(nullable: false),
                    DeletedAt = table.Column<DateTime>(nullable: true),
                    DeletedBy = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    UpdatedAt = table.Column<DateTime>(nullable: true),
                    UpdatedBy = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Schools", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Schools_AspNetUsers_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Schools_AspNetUsers_DeletedBy",
                        column: x => x.DeletedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Schools_AspNetUsers_UpdatedBy",
                        column: x => x.UpdatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ServiceTypes",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServiceTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Specialities",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedAt = table.Column<DateTime>(nullable: true),
                    CreatedBy = table.Column<string>(nullable: true),
                    Deleted = table.Column<bool>(nullable: false),
                    DeletedAt = table.Column<DateTime>(nullable: true),
                    DeletedBy = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    UpdatedAt = table.Column<DateTime>(nullable: true),
                    UpdatedBy = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Specialities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Specialities_AspNetUsers_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Specialities_AspNetUsers_DeletedBy",
                        column: x => x.DeletedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Specialities_AspNetUsers_UpdatedBy",
                        column: x => x.UpdatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SubjectModalities",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Code = table.Column<string>(maxLength: 10, nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubjectModalities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Suppliers",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Address = table.Column<string>(maxLength: 200, nullable: true),
                    CreatedAt = table.Column<DateTime>(nullable: true),
                    CreatedBy = table.Column<string>(nullable: true),
                    CreditAmount = table.Column<decimal>(type: "decimal(12,2)", nullable: false),
                    DebAmount = table.Column<decimal>(type: "decimal(12,2)", nullable: false),
                    Deleted = table.Column<bool>(nullable: false),
                    DeletedAt = table.Column<DateTime>(nullable: true),
                    DeletedBy = table.Column<string>(nullable: true),
                    Email = table.Column<string>(maxLength: 50, nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Tel = table.Column<string>(maxLength: 15, nullable: true),
                    UpdatedAt = table.Column<DateTime>(nullable: true),
                    UpdatedBy = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Suppliers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Suppliers_AspNetUsers_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Suppliers_AspNetUsers_DeletedBy",
                        column: x => x.DeletedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Suppliers_AspNetUsers_UpdatedBy",
                        column: x => x.UpdatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Surgeries",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Abdomen = table.Column<int>(nullable: false),
                    ActualMedication = table.Column<string>(maxLength: 500, nullable: true),
                    Acv = table.Column<bool>(nullable: false),
                    Alcohol = table.Column<bool>(nullable: false),
                    Alergias = table.Column<bool>(nullable: false),
                    AnestesiaOtro = table.Column<string>(maxLength: 100, nullable: true),
                    Angina = table.Column<bool>(nullable: false),
                    Angina2 = table.Column<bool>(nullable: false),
                    AntecedentesA = table.Column<string>(maxLength: 500, nullable: true),
                    Anticonseptivos = table.Column<bool>(nullable: false),
                    AperturaBucal = table.Column<int>(nullable: false),
                    Aqrs = table.Column<string>(maxLength: 20, nullable: true),
                    ArcodeFlexion = table.Column<int>(nullable: false),
                    Arritmias = table.Column<bool>(nullable: false),
                    Asa = table.Column<int>(nullable: false),
                    AsmaBronquial = table.Column<bool>(nullable: false),
                    Bd = table.Column<string>(maxLength: 20, nullable: true),
                    Bi = table.Column<string>(maxLength: 20, nullable: true),
                    BloqueosAv = table.Column<string>(maxLength: 20, nullable: true),
                    BloqueosRama = table.Column<string>(maxLength: 20, nullable: true),
                    BradicardiaS = table.Column<string>(maxLength: 20, nullable: true),
                    Cafe = table.Column<bool>(nullable: false),
                    Cancer = table.Column<bool>(nullable: false),
                    CardioOtros = table.Column<string>(maxLength: 500, nullable: true),
                    CardiopatiaIsquemica = table.Column<bool>(nullable: false),
                    CardiopatiaReumatica = table.Column<bool>(nullable: false),
                    Cianosis = table.Column<bool>(nullable: false),
                    CirugiasPrevias = table.Column<bool>(nullable: false),
                    Conclucion = table.Column<string>(maxLength: 500, nullable: true),
                    Consideraciones = table.Column<string>(maxLength: 2000, nullable: true),
                    Convulciones = table.Column<bool>(nullable: false),
                    Corazon = table.Column<int>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: true),
                    CreatedBy = table.Column<string>(nullable: true),
                    Cuello = table.Column<int>(nullable: false),
                    Cv = table.Column<bool>(nullable: false),
                    Date = table.Column<DateTime>(nullable: true),
                    Deleted = table.Column<bool>(nullable: false),
                    DeletedAt = table.Column<DateTime>(nullable: true),
                    DeletedBy = table.Column<string>(nullable: true),
                    DerramePleural = table.Column<bool>(nullable: false),
                    DiabetesMellitus = table.Column<bool>(nullable: false),
                    Diagnostic = table.Column<string>(maxLength: 100, nullable: true),
                    Discutido = table.Column<int>(nullable: false),
                    Dislipidemia = table.Column<bool>(nullable: false),
                    Dismea = table.Column<bool>(nullable: false),
                    DistanciaEsternomentoniana = table.Column<int>(nullable: false),
                    DistanciaTiromentoniana = table.Column<int>(nullable: false),
                    Dpn = table.Column<bool>(nullable: false),
                    Drogas = table.Column<bool>(nullable: false),
                    Ebpoc = table.Column<bool>(nullable: false),
                    Edema = table.Column<bool>(nullable: false),
                    Embarazo = table.Column<bool>(nullable: false),
                    Endocrino = table.Column<bool>(nullable: false),
                    EnfEmatologica = table.Column<bool>(nullable: false),
                    EnfGastrointestinal = table.Column<bool>(nullable: false),
                    EnfHepatica = table.Column<bool>(nullable: false),
                    EnfRenal = table.Column<bool>(nullable: false),
                    ExtencionAtlantoOccipital = table.Column<int>(nullable: false),
                    Extrasistoles = table.Column<string>(maxLength: 20, nullable: true),
                    ExtremInferiores = table.Column<int>(nullable: false),
                    ExtremSuperiores = table.Column<int>(nullable: false),
                    FamilyAlergy = table.Column<int>(nullable: false),
                    Fatiga = table.Column<bool>(nullable: false),
                    Fc = table.Column<string>(maxLength: 20, nullable: true),
                    FcElectro = table.Column<string>(maxLength: 20, nullable: true),
                    Fr = table.Column<string>(maxLength: 20, nullable: true),
                    Hemorragias = table.Column<bool>(nullable: false),
                    Hepatica = table.Column<bool>(nullable: false),
                    Hipertrofia = table.Column<string>(maxLength: 20, nullable: true),
                    Hquirurgica = table.Column<string>(maxLength: 500, nullable: true),
                    HtaEsencial = table.Column<bool>(nullable: false),
                    Huevos = table.Column<bool>(nullable: false),
                    Iam = table.Column<int>(nullable: false),
                    Imc = table.Column<string>(maxLength: 20, nullable: true),
                    InsufVasc = table.Column<bool>(nullable: false),
                    Latex = table.Column<bool>(nullable: false),
                    Mallampati = table.Column<int>(nullable: false),
                    Manejo = table.Column<string>(maxLength: 2000, nullable: true),
                    Marcapaso = table.Column<bool>(nullable: false),
                    MovTempmandibular = table.Column<int>(nullable: false),
                    Nac = table.Column<bool>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Obesidad = table.Column<bool>(nullable: false),
                    ObservacionesIam = table.Column<string>(maxLength: 500, nullable: true),
                    OndasQ = table.Column<string>(maxLength: 20, nullable: true),
                    OndasT = table.Column<string>(maxLength: 20, nullable: true),
                    Ortopnea = table.Column<bool>(nullable: false),
                    OtrasPatologias = table.Column<string>(maxLength: 500, nullable: true),
                    OtrosHistoria = table.Column<string>(maxLength: 500, nullable: true),
                    P = table.Column<string>(maxLength: 20, nullable: true),
                    Palpitaciones = table.Column<bool>(nullable: false),
                    PatologiasCardio = table.Column<string>(maxLength: 500, nullable: true),
                    PersonId = table.Column<long>(nullable: false),
                    Peso = table.Column<int>(nullable: false),
                    PesoArt = table.Column<string>(maxLength: 20, nullable: true),
                    PlanAnestesia = table.Column<int>(nullable: false),
                    Pr = table.Column<string>(maxLength: 20, nullable: true),
                    Preferencias = table.Column<string>(maxLength: 2000, nullable: true),
                    Procedure = table.Column<string>(maxLength: 100, nullable: true),
                    Pulmonar = table.Column<bool>(nullable: false),
                    Pulmones = table.Column<int>(nullable: false),
                    Qrs = table.Column<string>(maxLength: 20, nullable: true),
                    Qt = table.Column<string>(maxLength: 20, nullable: true),
                    Recomendaciones = table.Column<string>(maxLength: 2000, nullable: true),
                    Reflujo = table.Column<bool>(nullable: false),
                    RenalUrinario = table.Column<bool>(nullable: false),
                    Riesgos = table.Column<string>(maxLength: 2000, nullable: true),
                    Ritmo = table.Column<string>(maxLength: 20, nullable: true),
                    Sedentarismo = table.Column<bool>(nullable: false),
                    Sicc = table.Column<bool>(nullable: false),
                    Sincope = table.Column<bool>(nullable: false),
                    SintomasNoCardio = table.Column<string>(maxLength: 500, nullable: true),
                    Sncsnp = table.Column<bool>(nullable: false),
                    Spo2 = table.Column<string>(maxLength: 20, nullable: true),
                    SurgeryDate = table.Column<DateTime>(nullable: true),
                    SurgeryHour = table.Column<DateTime>(nullable: true),
                    Tabaquismo = table.Column<bool>(nullable: false),
                    Tabaquismo2 = table.Column<bool>(nullable: false),
                    Talla = table.Column<string>(maxLength: 20, nullable: true),
                    TaquicardiaS = table.Column<string>(maxLength: 20, nullable: true),
                    TbPulmonar = table.Column<bool>(nullable: false),
                    Torax = table.Column<int>(nullable: false),
                    Tos = table.Column<bool>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: true),
                    UpdatedBy = table.Column<string>(nullable: true),
                    Valvulopatia = table.Column<bool>(nullable: false),
                    ViasRespiratorias = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Surgeries", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Surgeries_AspNetUsers_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Surgeries_AspNetUsers_DeletedBy",
                        column: x => x.DeletedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Surgeries_People_PersonId",
                        column: x => x.PersonId,
                        principalTable: "People",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Surgeries_AspNetUsers_UpdatedBy",
                        column: x => x.UpdatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Tandas",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tandas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserEmailSettings",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedAt = table.Column<DateTime>(nullable: true),
                    CreatedBy = table.Column<string>(nullable: true),
                    Deleted = table.Column<bool>(nullable: false),
                    DeletedAt = table.Column<DateTime>(nullable: true),
                    DeletedBy = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    HostNameSmtp = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true),
                    Port = table.Column<int>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: true),
                    UpdatedBy = table.Column<string>(nullable: true),
                    UserEmailSettingId = table.Column<int>(nullable: false),
                    UserId = table.Column<int>(nullable: false),
                    UserId1 = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserEmailSettings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserEmailSettings_AspNetUsers_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UserEmailSettings_AspNetUsers_DeletedBy",
                        column: x => x.DeletedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UserEmailSettings_AspNetUsers_UpdatedBy",
                        column: x => x.UpdatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UserEmailSettings_AspNetUsers_UserId1",
                        column: x => x.UserId1,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Visits",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    BMI = table.Column<decimal>(type: "decimal(12,2)", nullable: false),
                    BloodOxygen = table.Column<string>(nullable: true),
                    BloodPressure = table.Column<string>(nullable: true),
                    CreatedAt = table.Column<DateTime>(nullable: true),
                    CreatedBy = table.Column<string>(nullable: true),
                    Date = table.Column<DateTime>(nullable: false),
                    Deleted = table.Column<bool>(nullable: false),
                    DeletedAt = table.Column<DateTime>(nullable: true),
                    DeletedBy = table.Column<string>(nullable: true),
                    Heigth = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Observations = table.Column<string>(maxLength: 2000, nullable: true),
                    PersonId = table.Column<long>(nullable: false),
                    Pulse = table.Column<string>(nullable: true),
                    RespiratoryRate = table.Column<string>(nullable: true),
                    Temperature = table.Column<string>(nullable: true),
                    UpdatedAt = table.Column<DateTime>(nullable: true),
                    UpdatedBy = table.Column<string>(nullable: true),
                    Weight = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Visits", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Visits_AspNetUsers_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Visits_AspNetUsers_DeletedBy",
                        column: x => x.DeletedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Visits_People_PersonId",
                        column: x => x.PersonId,
                        principalTable: "People",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Visits_AspNetUsers_UpdatedBy",
                        column: x => x.UpdatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Zones",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedAt = table.Column<DateTime>(nullable: true),
                    CreatedBy = table.Column<string>(nullable: true),
                    Deleted = table.Column<bool>(nullable: false),
                    DeletedAt = table.Column<DateTime>(nullable: true),
                    DeletedBy = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Observations = table.Column<string>(maxLength: 500, nullable: true),
                    ShopId = table.Column<long>(nullable: true),
                    UpdatedAt = table.Column<DateTime>(nullable: true),
                    UpdatedBy = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Zones", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Zones_AspNetUsers_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Zones_AspNetUsers_DeletedBy",
                        column: x => x.DeletedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Zones_Shops_ShopId",
                        column: x => x.ShopId,
                        principalTable: "Shops",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Zones_AspNetUsers_UpdatedBy",
                        column: x => x.UpdatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Allergies",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AllergyCategoryId = table.Column<long>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Allergies", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Allergies_AllergyCategories_AllergyCategoryId",
                        column: x => x.AllergyCategoryId,
                        principalTable: "AllergyCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "BariatricVisits",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    BariatricId = table.Column<long>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: true),
                    CreatedBy = table.Column<string>(nullable: true),
                    Deleted = table.Column<bool>(nullable: false),
                    DeletedAt = table.Column<DateTime>(nullable: true),
                    DeletedBy = table.Column<string>(nullable: true),
                    Imc = table.Column<string>(maxLength: 25, nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Notes = table.Column<string>(maxLength: 500, nullable: true),
                    Nutricion = table.Column<string>(maxLength: 500, nullable: true),
                    Peso = table.Column<string>(maxLength: 25, nullable: true),
                    Type = table.Column<bool>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: true),
                    UpdatedBy = table.Column<string>(nullable: true),
                    Variacion = table.Column<string>(maxLength: 25, nullable: true),
                    VisitDate = table.Column<DateTime>(nullable: true),
                    VisitReason = table.Column<string>(maxLength: 500, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BariatricVisits", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BariatricVisits_Bariatrics_BariatricId",
                        column: x => x.BariatricId,
                        principalTable: "Bariatrics",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BariatricVisits_AspNetUsers_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BariatricVisits_AspNetUsers_DeletedBy",
                        column: x => x.DeletedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BariatricVisits_AspNetUsers_UpdatedBy",
                        column: x => x.UpdatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Beneficiaries",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Amount = table.Column<decimal>(type: "decimal(12,2)", nullable: false),
                    BenefitId = table.Column<long>(nullable: true),
                    BenefitString = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Quantity = table.Column<int>(nullable: false),
                    ReceiverId = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Beneficiaries", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Beneficiaries_Benefits_BenefitId",
                        column: x => x.BenefitId,
                        principalTable: "Benefits",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Beneficiaries_People_ReceiverId",
                        column: x => x.ReceiverId,
                        principalTable: "People",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "BuyDetails",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    BuyId = table.Column<long>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: true),
                    CreatedBy = table.Column<string>(nullable: true),
                    Deleted = table.Column<bool>(nullable: false),
                    DeletedAt = table.Column<DateTime>(nullable: true),
                    DeletedBy = table.Column<string>(nullable: true),
                    DiscountAmount = table.Column<decimal>(type: "decimal(12,2)", nullable: false),
                    ItbisAmount = table.Column<decimal>(type: "decimal(12,2)", nullable: false),
                    Name = table.Column<string>(nullable: true),
                    ProductName = table.Column<string>(nullable: true),
                    Quantity = table.Column<int>(nullable: false),
                    SubTotal = table.Column<decimal>(type: "decimal(12,2)", nullable: false),
                    TotalDetail = table.Column<decimal>(type: "decimal(12,2)", nullable: false),
                    UnitPrice = table.Column<decimal>(type: "decimal(12,2)", nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: true),
                    UpdatedBy = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BuyDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BuyDetails_Buys_BuyId",
                        column: x => x.BuyId,
                        principalTable: "Buys",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BuyDetails_AspNetUsers_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BuyDetails_AspNetUsers_DeletedBy",
                        column: x => x.DeletedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BuyDetails_AspNetUsers_UpdatedBy",
                        column: x => x.UpdatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ColaboratorDonations",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Amount = table.Column<decimal>(type: "decimal(12,2)", nullable: false),
                    ColaboratorId = table.Column<long>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: true),
                    CreatedBy = table.Column<string>(nullable: true),
                    Date = table.Column<DateTime>(nullable: false),
                    Deleted = table.Column<bool>(nullable: false),
                    DeletedAt = table.Column<DateTime>(nullable: true),
                    DeletedBy = table.Column<string>(nullable: true),
                    Details = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Quantity = table.Column<int>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: true),
                    UpdatedBy = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ColaboratorDonations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ColaboratorDonations_Colaborators_ColaboratorId",
                        column: x => x.ColaboratorId,
                        principalTable: "Colaborators",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ColaboratorDonations_AspNetUsers_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ColaboratorDonations_AspNetUsers_DeletedBy",
                        column: x => x.DeletedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ColaboratorDonations_AspNetUsers_UpdatedBy",
                        column: x => x.UpdatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Courses",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Code = table.Column<string>(nullable: true),
                    CourseModalityId = table.Column<long>(nullable: false),
                    CourseTypeId = table.Column<long>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: true),
                    CreatedBy = table.Column<string>(nullable: true),
                    Deleted = table.Column<bool>(nullable: false),
                    DeletedAt = table.Column<DateTime>(nullable: true),
                    DeletedBy = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Imagen = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    UpdatedAt = table.Column<DateTime>(nullable: true),
                    UpdatedBy = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Courses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Courses_CourseModalities_CourseModalityId",
                        column: x => x.CourseModalityId,
                        principalTable: "CourseModalities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Courses_CourseTypes_CourseTypeId",
                        column: x => x.CourseTypeId,
                        principalTable: "CourseTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Courses_AspNetUsers_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Courses_AspNetUsers_DeletedBy",
                        column: x => x.DeletedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Courses_AspNetUsers_UpdatedBy",
                        column: x => x.UpdatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DiagnosticCies",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Code = table.Column<string>(nullable: true),
                    DiagnosticCategoryId = table.Column<long>(nullable: false),
                    FatherCode = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DiagnosticCies", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DiagnosticCies_DiagnosticCategoryCie10s_DiagnosticCategoryId",
                        column: x => x.DiagnosticCategoryId,
                        principalTable: "DiagnosticCategoryCie10s",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Comensals",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Amount = table.Column<decimal>(type: "decimal(12,2)", nullable: false),
                    ComensalId = table.Column<long>(nullable: true),
                    FoodId = table.Column<long>(nullable: false),
                    FoodString = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    ParticipantString = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comensals", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Comensals_People_ComensalId",
                        column: x => x.ComensalId,
                        principalTable: "People",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Comensals_Foods_FoodId",
                        column: x => x.FoodId,
                        principalTable: "Foods",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "FoodDetails",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedAt = table.Column<DateTime>(nullable: true),
                    CreatedBy = table.Column<string>(nullable: true),
                    Deleted = table.Column<bool>(nullable: false),
                    DeletedAt = table.Column<DateTime>(nullable: true),
                    DeletedBy = table.Column<string>(nullable: true),
                    FoodId = table.Column<long>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Quantity = table.Column<int>(nullable: false),
                    Total = table.Column<decimal>(type: "decimal(12,2)", nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: true),
                    UpdatedBy = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FoodDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FoodDetails_AspNetUsers_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FoodDetails_AspNetUsers_DeletedBy",
                        column: x => x.DeletedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FoodDetails_Foods_FoodId",
                        column: x => x.FoodId,
                        principalTable: "Foods",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FoodDetails_AspNetUsers_UpdatedBy",
                        column: x => x.UpdatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "GeneralAfectionVisits",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Altura = table.Column<string>(nullable: true),
                    Conclusion = table.Column<string>(maxLength: 500, nullable: true),
                    CreatedAt = table.Column<DateTime>(nullable: true),
                    CreatedBy = table.Column<string>(nullable: true),
                    Deleted = table.Column<bool>(nullable: false),
                    DeletedAt = table.Column<DateTime>(nullable: true),
                    DeletedBy = table.Column<string>(nullable: true),
                    Diagnostic = table.Column<string>(maxLength: 500, nullable: true),
                    GeneralAfectionId = table.Column<long>(nullable: false),
                    Indications = table.Column<string>(maxLength: 500, nullable: true),
                    Labs = table.Column<string>(maxLength: 500, nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Notes = table.Column<string>(maxLength: 500, nullable: true),
                    Peso = table.Column<int>(nullable: false),
                    PhysicalExam = table.Column<string>(maxLength: 500, nullable: true),
                    PresionArterial = table.Column<int>(nullable: false),
                    PresionArterialDiast = table.Column<int>(nullable: false),
                    PresionArterialSist = table.Column<int>(nullable: false),
                    Pulsaciones = table.Column<int>(nullable: false),
                    Revision = table.Column<string>(maxLength: 500, nullable: true),
                    RitmoResp = table.Column<int>(nullable: false),
                    Temp = table.Column<int>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: true),
                    UpdatedBy = table.Column<string>(nullable: true),
                    VisitDate = table.Column<DateTime>(nullable: true),
                    VisitReason = table.Column<string>(maxLength: 500, nullable: false),
                    VitalSign = table.Column<string>(maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GeneralAfectionVisits", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GeneralAfectionVisits_AspNetUsers_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_GeneralAfectionVisits_AspNetUsers_DeletedBy",
                        column: x => x.DeletedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_GeneralAfectionVisits_GeneralAfections_GeneralAfectionId",
                        column: x => x.GeneralAfectionId,
                        principalTable: "GeneralAfections",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_GeneralAfectionVisits_AspNetUsers_UpdatedBy",
                        column: x => x.UpdatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "GeneralVisits",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Altura = table.Column<string>(nullable: true),
                    Conclusion = table.Column<string>(maxLength: 500, nullable: true),
                    CreatedAt = table.Column<DateTime>(nullable: true),
                    CreatedBy = table.Column<string>(nullable: true),
                    Deleted = table.Column<bool>(nullable: false),
                    DeletedAt = table.Column<DateTime>(nullable: true),
                    DeletedBy = table.Column<string>(nullable: true),
                    Diagnostic = table.Column<string>(maxLength: 500, nullable: true),
                    GeneralId = table.Column<long>(nullable: false),
                    Indications = table.Column<string>(maxLength: 500, nullable: true),
                    Labs = table.Column<string>(maxLength: 500, nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Notes = table.Column<string>(maxLength: 500, nullable: true),
                    Peso = table.Column<int>(nullable: false),
                    PhysicalExam = table.Column<string>(maxLength: 500, nullable: true),
                    PresionArterial = table.Column<int>(nullable: false),
                    PresionArterialDiast = table.Column<int>(nullable: false),
                    PresionArterialSist = table.Column<int>(nullable: false),
                    Pulsaciones = table.Column<int>(nullable: false),
                    Revision = table.Column<string>(maxLength: 500, nullable: true),
                    RitmoResp = table.Column<int>(nullable: false),
                    Temp = table.Column<int>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: true),
                    UpdatedBy = table.Column<string>(nullable: true),
                    VisitDate = table.Column<DateTime>(nullable: true),
                    VisitReason = table.Column<string>(maxLength: 500, nullable: false),
                    VitalSign = table.Column<string>(maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GeneralVisits", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GeneralVisits_AspNetUsers_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_GeneralVisits_AspNetUsers_DeletedBy",
                        column: x => x.DeletedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_GeneralVisits_Generals_GeneralId",
                        column: x => x.GeneralId,
                        principalTable: "Generals",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_GeneralVisits_AspNetUsers_UpdatedBy",
                        column: x => x.UpdatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "GynecologyVisits",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Conclusion = table.Column<string>(maxLength: 500, nullable: true),
                    CreatedAt = table.Column<DateTime>(nullable: true),
                    CreatedBy = table.Column<string>(nullable: true),
                    Deleted = table.Column<bool>(nullable: false),
                    DeletedAt = table.Column<DateTime>(nullable: true),
                    DeletedBy = table.Column<string>(nullable: true),
                    GynecologyId = table.Column<long>(nullable: false),
                    Indications = table.Column<string>(maxLength: 500, nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Symptoms = table.Column<string>(maxLength: 500, nullable: true),
                    UpdatedAt = table.Column<DateTime>(nullable: true),
                    UpdatedBy = table.Column<string>(nullable: true),
                    VisitDate = table.Column<DateTime>(nullable: true),
                    VisitReason = table.Column<string>(maxLength: 500, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GynecologyVisits", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GynecologyVisits_AspNetUsers_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_GynecologyVisits_AspNetUsers_DeletedBy",
                        column: x => x.DeletedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_GynecologyVisits_Gynecologies_GynecologyId",
                        column: x => x.GynecologyId,
                        principalTable: "Gynecologies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_GynecologyVisits_AspNetUsers_UpdatedBy",
                        column: x => x.UpdatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SaleLiquidations",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedAt = table.Column<DateTime>(nullable: true),
                    CreatedBy = table.Column<string>(nullable: true),
                    Date = table.Column<DateTime>(nullable: true),
                    Deleted = table.Column<bool>(nullable: false),
                    DeletedAt = table.Column<DateTime>(nullable: true),
                    DeletedBy = table.Column<string>(nullable: true),
                    InsuranceId = table.Column<long>(nullable: true),
                    InvoiceNo = table.Column<string>(maxLength: 100, nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Ncf = table.Column<string>(maxLength: 100, nullable: true),
                    Remarks = table.Column<string>(maxLength: 400, nullable: true),
                    Seq = table.Column<int>(nullable: false),
                    SubTotal = table.Column<decimal>(type: "decimal(12,2)", nullable: false),
                    Total = table.Column<decimal>(type: "decimal(12,2)", nullable: false),
                    TotalCharges = table.Column<decimal>(type: "decimal(12,2)", nullable: false),
                    TotalDiscount = table.Column<decimal>(type: "decimal(12,2)", nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: true),
                    UpdatedBy = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SaleLiquidations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SaleLiquidations_AspNetUsers_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SaleLiquidations_AspNetUsers_DeletedBy",
                        column: x => x.DeletedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SaleLiquidations_Insurances_InsuranceId",
                        column: x => x.InsuranceId,
                        principalTable: "Insurances",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SaleLiquidations_AspNetUsers_UpdatedBy",
                        column: x => x.UpdatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Sales",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AutorizationNumber = table.Column<string>(nullable: true),
                    CashierDetailId = table.Column<long>(nullable: true),
                    CategoryId = table.Column<long>(nullable: true),
                    CoverPercent = table.Column<decimal>(type: "decimal(12,2)", nullable: true),
                    CreatedAt = table.Column<DateTime>(nullable: true),
                    CreatedBy = table.Column<string>(nullable: true),
                    DebtAmount = table.Column<decimal>(type: "decimal(12,2)", nullable: false),
                    Deleted = table.Column<bool>(nullable: false),
                    DeletedAt = table.Column<DateTime>(nullable: true),
                    DeletedBy = table.Column<string>(nullable: true),
                    FiscalCredit = table.Column<bool>(nullable: false),
                    InsuranceId = table.Column<long>(nullable: false),
                    InvoiceNo = table.Column<string>(maxLength: 100, nullable: true),
                    IsPrivate = table.Column<bool>(nullable: true),
                    LiqSec = table.Column<int>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Ncf = table.Column<string>(maxLength: 100, nullable: true),
                    NcfGub = table.Column<string>(nullable: true),
                    PaidAmount = table.Column<decimal>(type: "decimal(12,2)", nullable: false),
                    PaidDate = table.Column<DateTime>(nullable: true),
                    PaymentTypeId = table.Column<long>(nullable: true),
                    PersonId = table.Column<long>(nullable: false),
                    Remarks = table.Column<string>(maxLength: 200, nullable: true),
                    SalesDate = table.Column<DateTime>(nullable: true),
                    SalesInvoiceNo = table.Column<string>(maxLength: 100, nullable: true),
                    Seq = table.Column<int>(nullable: false),
                    StatusId = table.Column<long>(nullable: false),
                    SubTotal = table.Column<decimal>(type: "decimal(12,2)", nullable: false),
                    Total = table.Column<decimal>(type: "decimal(12,2)", nullable: false),
                    TotalCharges = table.Column<decimal>(type: "decimal(12,2)", nullable: false),
                    TotalDiscount = table.Column<decimal>(type: "decimal(12,2)", nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: true),
                    UpdatedBy = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sales", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Sales_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Sales_AspNetUsers_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Sales_AspNetUsers_DeletedBy",
                        column: x => x.DeletedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Sales_Insurances_InsuranceId",
                        column: x => x.InsuranceId,
                        principalTable: "Insurances",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Sales_PaymentTypes_PaymentTypeId",
                        column: x => x.PaymentTypeId,
                        principalTable: "PaymentTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Sales_People_PersonId",
                        column: x => x.PersonId,
                        principalTable: "People",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Sales_Status_StatusId",
                        column: x => x.StatusId,
                        principalTable: "Status",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Sales_AspNetUsers_UpdatedBy",
                        column: x => x.UpdatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Laboratories",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Code = table.Column<string>(maxLength: 50, nullable: false),
                    Comentary = table.Column<string>(maxLength: 200, nullable: true),
                    CreatedAt = table.Column<DateTime>(nullable: true),
                    CreatedBy = table.Column<string>(nullable: true),
                    Deleted = table.Column<bool>(nullable: false),
                    DeletedAt = table.Column<DateTime>(nullable: true),
                    DeletedBy = table.Column<string>(nullable: true),
                    LabClasificationId = table.Column<int>(nullable: true),
                    LabClasificationId1 = table.Column<long>(nullable: true),
                    Methods = table.Column<string>(maxLength: 50, nullable: false),
                    Name = table.Column<string>(nullable: true),
                    OwnerId = table.Column<int>(nullable: false),
                    OwnerId1 = table.Column<long>(nullable: true),
                    Reference = table.Column<string>(maxLength: 50, nullable: false),
                    Unids = table.Column<string>(maxLength: 20, nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: true),
                    UpdatedBy = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Laboratories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Laboratories_AspNetUsers_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Laboratories_AspNetUsers_DeletedBy",
                        column: x => x.DeletedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Laboratories_LabClasifications_LabClasificationId1",
                        column: x => x.LabClasificationId1,
                        principalTable: "LabClasifications",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Laboratories_Owners_OwnerId1",
                        column: x => x.OwnerId1,
                        principalTable: "Owners",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Laboratories_AspNetUsers_UpdatedBy",
                        column: x => x.UpdatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MaterialRequisitionDetails",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedAt = table.Column<DateTime>(nullable: true),
                    CreatedBy = table.Column<string>(nullable: true),
                    Deleted = table.Column<bool>(nullable: false),
                    DeletedAt = table.Column<DateTime>(nullable: true),
                    DeletedBy = table.Column<string>(nullable: true),
                    Itbis = table.Column<decimal>(type: "decimal(12,2)", nullable: false),
                    ItbisAmount = table.Column<decimal>(type: "decimal(12,2)", nullable: false),
                    ManualMaterial = table.Column<string>(nullable: true),
                    MaterialRequisitionId = table.Column<long>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Quantity = table.Column<int>(nullable: false),
                    Total = table.Column<decimal>(type: "decimal(12,2)", nullable: false),
                    UnitPrice = table.Column<decimal>(type: "decimal(12,2)", nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: true),
                    UpdatedBy = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MaterialRequisitionDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MaterialRequisitionDetails_AspNetUsers_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MaterialRequisitionDetails_AspNetUsers_DeletedBy",
                        column: x => x.DeletedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MaterialRequisitionDetails_MaterialRequisitions_MaterialRequisitionId",
                        column: x => x.MaterialRequisitionId,
                        principalTable: "MaterialRequisitions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MaterialRequisitionDetails_AspNetUsers_UpdatedBy",
                        column: x => x.UpdatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MaterialInAndOuts",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedAt = table.Column<DateTime>(nullable: true),
                    CreatedBy = table.Column<string>(nullable: true),
                    Date = table.Column<DateTime>(nullable: false),
                    Deleted = table.Column<bool>(nullable: false),
                    DeletedAt = table.Column<DateTime>(nullable: true),
                    DeletedBy = table.Column<string>(nullable: true),
                    Details = table.Column<string>(nullable: true),
                    MaterialId = table.Column<long>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Quantity = table.Column<int>(nullable: false),
                    Type = table.Column<int>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: true),
                    UpdatedBy = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MaterialInAndOuts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MaterialInAndOuts_AspNetUsers_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MaterialInAndOuts_AspNetUsers_DeletedBy",
                        column: x => x.DeletedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MaterialInAndOuts_Materials_MaterialId",
                        column: x => x.MaterialId,
                        principalTable: "Materials",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MaterialInAndOuts_AspNetUsers_UpdatedBy",
                        column: x => x.UpdatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ObstetricVisits",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AuSem = table.Column<string>(maxLength: 50, nullable: true),
                    Conclusion = table.Column<string>(maxLength: 500, nullable: true),
                    CreatedAt = table.Column<DateTime>(nullable: true),
                    CreatedBy = table.Column<string>(nullable: true),
                    Deleted = table.Column<bool>(nullable: false),
                    DeletedAt = table.Column<DateTime>(nullable: true),
                    DeletedBy = table.Column<string>(nullable: true),
                    Edema = table.Column<string>(maxLength: 50, nullable: true),
                    Fcf = table.Column<string>(maxLength: 50, nullable: true),
                    GestationalAge = table.Column<string>(maxLength: 50, nullable: true),
                    Indications = table.Column<string>(maxLength: 500, nullable: true),
                    Name = table.Column<string>(nullable: true),
                    ObstetricId = table.Column<long>(nullable: false),
                    Pounds = table.Column<string>(maxLength: 50, nullable: true),
                    Present = table.Column<string>(maxLength: 50, nullable: true),
                    Symptoms = table.Column<string>(maxLength: 500, nullable: true),
                    Tammhg = table.Column<string>(maxLength: 50, nullable: true),
                    UpdatedAt = table.Column<DateTime>(nullable: true),
                    UpdatedBy = table.Column<string>(nullable: true),
                    Varicose = table.Column<string>(maxLength: 50, nullable: true),
                    VisitDate = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ObstetricVisits", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ObstetricVisits_AspNetUsers_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ObstetricVisits_AspNetUsers_DeletedBy",
                        column: x => x.DeletedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ObstetricVisits_Obstetrics_ObstetricId",
                        column: x => x.ObstetricId,
                        principalTable: "Obstetrics",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ObstetricVisits_AspNetUsers_UpdatedBy",
                        column: x => x.UpdatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CreditDebits",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Amount = table.Column<decimal>(type: "decimal(12,2)", nullable: false),
                    AppliedDate = table.Column<DateTime>(nullable: true),
                    CreatedAt = table.Column<DateTime>(nullable: true),
                    CreatedBy = table.Column<string>(nullable: true),
                    CreditNo = table.Column<string>(nullable: true),
                    Date = table.Column<DateTime>(nullable: true),
                    Deleted = table.Column<bool>(nullable: false),
                    DeletedAt = table.Column<DateTime>(nullable: true),
                    DeletedBy = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    OriginId = table.Column<long>(nullable: true),
                    PersonId = table.Column<long>(nullable: false),
                    Reazon = table.Column<string>(maxLength: 500, nullable: true),
                    UpdatedAt = table.Column<DateTime>(nullable: true),
                    UpdatedBy = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CreditDebits", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CreditDebits_AspNetUsers_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CreditDebits_AspNetUsers_DeletedBy",
                        column: x => x.DeletedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CreditDebits_Origins_OriginId",
                        column: x => x.OriginId,
                        principalTable: "Origins",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CreditDebits_People_PersonId",
                        column: x => x.PersonId,
                        principalTable: "People",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CreditDebits_AspNetUsers_UpdatedBy",
                        column: x => x.UpdatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ProjectMembers",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    MemberId = table.Column<long>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    ProjectId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectMembers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProjectMembers_People_MemberId",
                        column: x => x.MemberId,
                        principalTable: "People",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ProjectMembers_Projects_ProjectId",
                        column: x => x.ProjectId,
                        principalTable: "Projects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Signatures",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedAt = table.Column<DateTime>(nullable: true),
                    CreatedBy = table.Column<string>(nullable: true),
                    Deleted = table.Column<bool>(nullable: false),
                    DeletedAt = table.Column<DateTime>(nullable: true),
                    DeletedBy = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    ProjectId = table.Column<long>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: true),
                    UpdatedBy = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Signatures", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Signatures_AspNetUsers_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Signatures_AspNetUsers_DeletedBy",
                        column: x => x.DeletedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Signatures_Projects_ProjectId",
                        column: x => x.ProjectId,
                        principalTable: "Projects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Signatures_AspNetUsers_UpdatedBy",
                        column: x => x.UpdatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "RelatedPeople",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    RelatedPersonId = table.Column<long>(nullable: false),
                    RelationTypeId = table.Column<long>(nullable: false),
                    RelationedPersonId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RelatedPeople", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RelatedPeople_People_RelatedPersonId",
                        column: x => x.RelatedPersonId,
                        principalTable: "People",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_RelatedPeople_RelationTypes_RelationTypeId",
                        column: x => x.RelationTypeId,
                        principalTable: "RelationTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_RelatedPeople_People_RelationedPersonId",
                        column: x => x.RelationedPersonId,
                        principalTable: "People",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    BarCode = table.Column<int>(nullable: false),
                    BarcodeImage = table.Column<byte[]>(nullable: true),
                    BrandId = table.Column<long>(nullable: false),
                    BuyPrice = table.Column<decimal>(type: "decimal(12,2)", nullable: false),
                    CategoryId = table.Column<long>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: true),
                    CreatedBy = table.Column<string>(nullable: true),
                    Deleted = table.Column<bool>(nullable: false),
                    DeletedAt = table.Column<DateTime>(nullable: true),
                    DeletedBy = table.Column<string>(nullable: true),
                    ImageUrl = table.Column<string>(nullable: true),
                    Itbis = table.Column<decimal>(type: "decimal(12,2)", nullable: false),
                    Logo = table.Column<string>(nullable: true),
                    MeasureId = table.Column<long>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Observations = table.Column<string>(maxLength: 200, nullable: true),
                    SellPrice = table.Column<decimal>(type: "decimal(12,2)", nullable: false),
                    ServiceTypeId = table.Column<long>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: true),
                    UpdatedBy = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_Brands_BrandId",
                        column: x => x.BrandId,
                        principalTable: "Brands",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Products_AspNetUsers_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Products_AspNetUsers_DeletedBy",
                        column: x => x.DeletedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Products_Measures_MeasureId",
                        column: x => x.MeasureId,
                        principalTable: "Measures",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Products_ServiceTypes_ServiceTypeId",
                        column: x => x.ServiceTypeId,
                        principalTable: "ServiceTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Products_AspNetUsers_UpdatedBy",
                        column: x => x.UpdatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PersonSpecialities",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    PersonId = table.Column<long>(nullable: false),
                    SpecialityId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonSpecialities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PersonSpecialities_People_PersonId",
                        column: x => x.PersonId,
                        principalTable: "People",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PersonSpecialities_Specialities_SpecialityId",
                        column: x => x.SpecialityId,
                        principalTable: "Specialities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Purchases",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Conduce = table.Column<string>(nullable: true),
                    CreatedAt = table.Column<DateTime>(nullable: true),
                    CreatedBy = table.Column<string>(nullable: true),
                    DebtAmount = table.Column<decimal>(type: "decimal(12,2)", nullable: false),
                    Deleted = table.Column<bool>(nullable: false),
                    DeletedAt = table.Column<DateTime>(nullable: true),
                    DeletedBy = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    PaidAmount = table.Column<decimal>(type: "decimal(12,2)", nullable: false),
                    PaidDate = table.Column<DateTime>(nullable: true),
                    PurchaseDate = table.Column<DateTime>(nullable: true),
                    PurchaseInvoiceNo = table.Column<string>(maxLength: 100, nullable: false),
                    Remarks = table.Column<string>(maxLength: 200, nullable: true),
                    SubTotal = table.Column<decimal>(type: "decimal(12,2)", nullable: false),
                    SupplierId = table.Column<long>(nullable: false),
                    Total = table.Column<decimal>(type: "decimal(12,2)", nullable: false),
                    TotalCharges = table.Column<decimal>(type: "decimal(12,2)", nullable: false),
                    TotalDiscount = table.Column<decimal>(type: "decimal(12,2)", nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: true),
                    UpdatedBy = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Purchases", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Purchases_AspNetUsers_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Purchases_AspNetUsers_DeletedBy",
                        column: x => x.DeletedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Purchases_Suppliers_SupplierId",
                        column: x => x.SupplierId,
                        principalTable: "Suppliers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Purchases_AspNetUsers_UpdatedBy",
                        column: x => x.UpdatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Appointments",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedAt = table.Column<DateTime>(nullable: true),
                    CreatedBy = table.Column<string>(nullable: true),
                    Deleted = table.Column<bool>(nullable: false),
                    DeletedAt = table.Column<DateTime>(nullable: true),
                    DeletedBy = table.Column<string>(nullable: true),
                    DoctorId = table.Column<long>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Notes = table.Column<string>(maxLength: 1000, nullable: true),
                    PersonId = table.Column<long>(nullable: false),
                    SpecialityId = table.Column<long>(nullable: true),
                    TandaId = table.Column<int>(nullable: true),
                    TandaId1 = table.Column<long>(nullable: true),
                    UpdatedAt = table.Column<DateTime>(nullable: true),
                    UpdatedBy = table.Column<string>(nullable: true),
                    VisitDate = table.Column<DateTime>(nullable: true),
                    VisitReason = table.Column<string>(maxLength: 500, nullable: false),
                    WasSend = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Appointments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Appointments_AspNetUsers_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Appointments_AspNetUsers_DeletedBy",
                        column: x => x.DeletedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Appointments_Doctors_DoctorId",
                        column: x => x.DoctorId,
                        principalTable: "Doctors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Appointments_People_PersonId",
                        column: x => x.PersonId,
                        principalTable: "People",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Appointments_Specialities_SpecialityId",
                        column: x => x.SpecialityId,
                        principalTable: "Specialities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Appointments_Tandas_TandaId1",
                        column: x => x.TandaId1,
                        principalTable: "Tandas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Appointments_AspNetUsers_UpdatedBy",
                        column: x => x.UpdatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Places",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedAt = table.Column<DateTime>(nullable: true),
                    CreatedBy = table.Column<string>(nullable: true),
                    Deleted = table.Column<bool>(nullable: false),
                    DeletedAt = table.Column<DateTime>(nullable: true),
                    DeletedBy = table.Column<string>(nullable: true),
                    Ext = table.Column<string>(maxLength: 20, nullable: true),
                    IsDepartment = table.Column<bool>(nullable: false),
                    IsFreePlace = table.Column<bool>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Observations = table.Column<string>(maxLength: 500, nullable: true),
                    PersonId = table.Column<long>(nullable: true),
                    StatusId = table.Column<long>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: true),
                    UpdatedBy = table.Column<string>(nullable: true),
                    ZoneId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Places", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Places_AspNetUsers_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Places_AspNetUsers_DeletedBy",
                        column: x => x.DeletedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Places_People_PersonId",
                        column: x => x.PersonId,
                        principalTable: "People",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Places_Status_StatusId",
                        column: x => x.StatusId,
                        principalTable: "Status",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Places_AspNetUsers_UpdatedBy",
                        column: x => x.UpdatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Places_Zones_ZoneId",
                        column: x => x.ZoneId,
                        principalTable: "Zones",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PatientAllergies",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AllergyId = table.Column<long>(nullable: true),
                    Anaemia = table.Column<bool>(nullable: false),
                    Anaphylaxis = table.Column<bool>(nullable: false),
                    Angioedema = table.Column<bool>(nullable: false),
                    Arrhythmia = table.Column<bool>(nullable: false),
                    Bronchospasm = table.Column<bool>(nullable: false),
                    Cough = table.Column<bool>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: true),
                    CreatedBy = table.Column<string>(nullable: true),
                    Deleted = table.Column<bool>(nullable: false),
                    DeletedAt = table.Column<DateTime>(nullable: true),
                    DeletedBy = table.Column<string>(nullable: true),
                    Diarrhea = table.Column<bool>(nullable: false),
                    Dystonia = table.Column<bool>(nullable: false),
                    Fever = table.Column<bool>(nullable: false),
                    Flushing = table.Column<bool>(nullable: false),
                    GiUpset = table.Column<bool>(nullable: false),
                    Headache = table.Column<bool>(nullable: false),
                    Hepatotoxicity = table.Column<bool>(nullable: false),
                    Hives = table.Column<bool>(nullable: false),
                    Hypertension = table.Column<bool>(nullable: false),
                    Itching = table.Column<bool>(nullable: false),
                    MentalStatusChange = table.Column<bool>(nullable: false),
                    MuscoloskeletalPain = table.Column<bool>(nullable: false),
                    Myalgia = table.Column<bool>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Notes = table.Column<string>(maxLength: 500, nullable: false),
                    PersonId = table.Column<long>(nullable: false),
                    Rash = table.Column<bool>(nullable: false),
                    Severity = table.Column<int>(nullable: false),
                    Unknown = table.Column<bool>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: true),
                    UpdatedBy = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PatientAllergies", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PatientAllergies_Allergies_AllergyId",
                        column: x => x.AllergyId,
                        principalTable: "Allergies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PatientAllergies_AspNetUsers_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PatientAllergies_AspNetUsers_DeletedBy",
                        column: x => x.DeletedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PatientAllergies_People_PersonId",
                        column: x => x.PersonId,
                        principalTable: "People",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PatientAllergies_AspNetUsers_UpdatedBy",
                        column: x => x.UpdatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Kids",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AddressSchool = table.Column<string>(maxLength: 150, nullable: true),
                    BornPlace = table.Column<string>(maxLength: 100, nullable: true),
                    CourseId = table.Column<long>(nullable: true),
                    CreatedAt = table.Column<DateTime>(nullable: true),
                    CreatedBy = table.Column<string>(nullable: true),
                    Deleted = table.Column<bool>(nullable: false),
                    DeletedAt = table.Column<DateTime>(nullable: true),
                    DeletedBy = table.Column<string>(nullable: true),
                    DificultSubject = table.Column<string>(maxLength: 150, nullable: true),
                    Fired = table.Column<bool>(nullable: false),
                    HasLostSchoolarYear = table.Column<bool>(nullable: false),
                    MedicalPlace = table.Column<string>(maxLength: 150, nullable: true),
                    Name = table.Column<string>(nullable: true),
                    NoBrothers = table.Column<int>(nullable: false),
                    PediatricName = table.Column<string>(maxLength: 150, nullable: true),
                    PersonId = table.Column<long>(nullable: false),
                    Place = table.Column<string>(maxLength: 150, nullable: true),
                    SchoolId = table.Column<long>(nullable: true),
                    SchoolStr = table.Column<string>(maxLength: 150, nullable: true),
                    TandaId = table.Column<long>(nullable: false),
                    TelSchool = table.Column<string>(maxLength: 15, nullable: true),
                    UpdatedAt = table.Column<DateTime>(nullable: true),
                    UpdatedBy = table.Column<string>(nullable: true),
                    WhoLive = table.Column<string>(maxLength: 150, nullable: true),
                    WhoSleep = table.Column<string>(maxLength: 150, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kids", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Kids_Courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Courses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Kids_AspNetUsers_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Kids_AspNetUsers_DeletedBy",
                        column: x => x.DeletedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Kids_People_PersonId",
                        column: x => x.PersonId,
                        principalTable: "People",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Kids_Schools_SchoolId",
                        column: x => x.SchoolId,
                        principalTable: "Schools",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Kids_Tandas_TandaId",
                        column: x => x.TandaId,
                        principalTable: "Tandas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Kids_AspNetUsers_UpdatedBy",
                        column: x => x.UpdatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Subjects",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Code = table.Column<string>(nullable: true),
                    CourseId = table.Column<long>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: true),
                    CreatedBy = table.Column<string>(nullable: true),
                    Deleted = table.Column<bool>(nullable: false),
                    DeletedAt = table.Column<DateTime>(nullable: true),
                    DeletedBy = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Imagen = table.Column<string>(nullable: true),
                    IsGeneric = table.Column<bool>(nullable: false),
                    MinimumPoints = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Observations = table.Column<string>(nullable: true),
                    PossiblePoints = table.Column<int>(nullable: false),
                    SpecialityId = table.Column<long>(nullable: false),
                    SubjectModalityId = table.Column<long>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: true),
                    UpdatedBy = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subjects", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Subjects_Courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Courses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Subjects_AspNetUsers_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Subjects_AspNetUsers_DeletedBy",
                        column: x => x.DeletedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Subjects_Specialities_SpecialityId",
                        column: x => x.SpecialityId,
                        principalTable: "Specialities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Subjects_SubjectModalities_SubjectModalityId",
                        column: x => x.SubjectModalityId,
                        principalTable: "SubjectModalities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Subjects_AspNetUsers_UpdatedBy",
                        column: x => x.UpdatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Diagnostics",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedAt = table.Column<DateTime>(nullable: true),
                    CreatedBy = table.Column<string>(nullable: true),
                    Date = table.Column<DateTime>(nullable: false),
                    Deleted = table.Column<bool>(nullable: false),
                    DeletedAt = table.Column<DateTime>(nullable: true),
                    DeletedBy = table.Column<string>(nullable: true),
                    DiagnosticId = table.Column<long>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Notes = table.Column<string>(maxLength: 500, nullable: false),
                    PatientId = table.Column<long>(nullable: true),
                    PersonId = table.Column<long>(nullable: false),
                    Severity = table.Column<int>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: true),
                    UpdatedBy = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Diagnostics", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Diagnostics_AspNetUsers_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Diagnostics_AspNetUsers_DeletedBy",
                        column: x => x.DeletedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Diagnostics_DiagnosticCies_DiagnosticId",
                        column: x => x.DiagnosticId,
                        principalTable: "DiagnosticCies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Diagnostics_Patients_PatientId",
                        column: x => x.PatientId,
                        principalTable: "Patients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Diagnostics_People_PersonId",
                        column: x => x.PersonId,
                        principalTable: "People",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Diagnostics_AspNetUsers_UpdatedBy",
                        column: x => x.UpdatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PatientDiagnostics",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedAt = table.Column<DateTime>(nullable: true),
                    CreatedBy = table.Column<string>(nullable: true),
                    Date = table.Column<DateTime>(nullable: false),
                    Deleted = table.Column<bool>(nullable: false),
                    DeletedAt = table.Column<DateTime>(nullable: true),
                    DeletedBy = table.Column<string>(nullable: true),
                    DiagnosticId = table.Column<long>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Notes = table.Column<string>(maxLength: 500, nullable: false),
                    PersonId = table.Column<long>(nullable: false),
                    Severity = table.Column<int>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: true),
                    UpdatedBy = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PatientDiagnostics", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PatientDiagnostics_AspNetUsers_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PatientDiagnostics_AspNetUsers_DeletedBy",
                        column: x => x.DeletedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PatientDiagnostics_DiagnosticCies_DiagnosticId",
                        column: x => x.DiagnosticId,
                        principalTable: "DiagnosticCies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PatientDiagnostics_People_PersonId",
                        column: x => x.PersonId,
                        principalTable: "People",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PatientDiagnostics_AspNetUsers_UpdatedBy",
                        column: x => x.UpdatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SaleLiquidationDetails",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedAt = table.Column<DateTime>(nullable: true),
                    CreatedBy = table.Column<string>(nullable: true),
                    Deleted = table.Column<bool>(nullable: false),
                    DeletedAt = table.Column<DateTime>(nullable: true),
                    DeletedBy = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    SaleId = table.Column<long>(nullable: true),
                    Seq = table.Column<int>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: true),
                    UpdatedBy = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SaleLiquidationDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SaleLiquidationDetails_AspNetUsers_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SaleLiquidationDetails_AspNetUsers_DeletedBy",
                        column: x => x.DeletedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SaleLiquidationDetails_Sales_SaleId",
                        column: x => x.SaleId,
                        principalTable: "Sales",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SaleLiquidationDetails_AspNetUsers_UpdatedBy",
                        column: x => x.UpdatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SalesAccounts",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedAt = table.Column<DateTime>(nullable: true),
                    CreatedBy = table.Column<string>(nullable: true),
                    Deleted = table.Column<bool>(nullable: false),
                    DeletedAt = table.Column<DateTime>(nullable: true),
                    DeletedBy = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    SalesId = table.Column<long>(nullable: true),
                    UpdatedAt = table.Column<DateTime>(nullable: true),
                    UpdatedBy = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SalesAccounts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SalesAccounts_AspNetUsers_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SalesAccounts_AspNetUsers_DeletedBy",
                        column: x => x.DeletedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SalesAccounts_Sales_SalesId",
                        column: x => x.SalesId,
                        principalTable: "Sales",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SalesAccounts_AspNetUsers_UpdatedBy",
                        column: x => x.UpdatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SignatureMembers",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    MemberId = table.Column<long>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    SignatureId = table.Column<long>(nullable: false),
                    SignatureMemberId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SignatureMembers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SignatureMembers_People_MemberId",
                        column: x => x.MemberId,
                        principalTable: "People",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SignatureMembers_Signatures_SignatureId",
                        column: x => x.SignatureId,
                        principalTable: "Signatures",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "OrderDetails",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedAt = table.Column<DateTime>(nullable: true),
                    CreatedBy = table.Column<string>(nullable: true),
                    Deleted = table.Column<bool>(nullable: false),
                    DeletedAt = table.Column<DateTime>(nullable: true),
                    DeletedBy = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    OrderId = table.Column<long>(nullable: false),
                    Price = table.Column<decimal>(type: "decimal(12,2)", nullable: false),
                    ProductCharges = table.Column<decimal>(type: "decimal(12,2)", nullable: false),
                    ProductDiscounts = table.Column<decimal>(type: "decimal(12,2)", nullable: false),
                    ProductId = table.Column<long>(nullable: false),
                    Quantity = table.Column<int>(nullable: false),
                    SubTotal = table.Column<decimal>(type: "decimal(12,2)", nullable: false),
                    TotalDetail = table.Column<decimal>(type: "decimal(12,2)", nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: true),
                    UpdatedBy = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrderDetails_AspNetUsers_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OrderDetails_AspNetUsers_DeletedBy",
                        column: x => x.DeletedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OrderDetails_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OrderDetails_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OrderDetails_AspNetUsers_UpdatedBy",
                        column: x => x.UpdatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Prices",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedAt = table.Column<DateTime>(nullable: true),
                    CreatedBy = table.Column<string>(nullable: true),
                    Deleted = table.Column<bool>(nullable: false),
                    DeletedAt = table.Column<DateTime>(nullable: true),
                    DeletedBy = table.Column<string>(nullable: true),
                    FromDate = table.Column<DateTime>(nullable: true),
                    InsuranceId = table.Column<long>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    ProductId = table.Column<long>(nullable: false),
                    Remarks = table.Column<string>(maxLength: 200, nullable: true),
                    SellPrice = table.Column<decimal>(type: "decimal(12,2)", nullable: false),
                    ToDate = table.Column<DateTime>(nullable: true),
                    UpdatedAt = table.Column<DateTime>(nullable: true),
                    UpdatedBy = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Prices", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Prices_AspNetUsers_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Prices_AspNetUsers_DeletedBy",
                        column: x => x.DeletedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Prices_Insurances_InsuranceId",
                        column: x => x.InsuranceId,
                        principalTable: "Insurances",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Prices_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Prices_AspNetUsers_UpdatedBy",
                        column: x => x.UpdatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SaleDetails",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedAt = table.Column<DateTime>(nullable: true),
                    CreatedBy = table.Column<string>(nullable: true),
                    Deleted = table.Column<bool>(nullable: false),
                    DeletedAt = table.Column<DateTime>(nullable: true),
                    DeletedBy = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    ProductCharges = table.Column<decimal>(type: "decimal(12,2)", nullable: false),
                    ProductDiscount = table.Column<decimal>(type: "decimal(12,2)", nullable: false),
                    ProductId = table.Column<long>(nullable: false),
                    Quantity = table.Column<int>(nullable: false),
                    SaleId = table.Column<long>(nullable: false),
                    SellPrice = table.Column<decimal>(type: "decimal(12,2)", nullable: false),
                    SubTotal = table.Column<decimal>(type: "decimal(12,2)", nullable: false),
                    TotalDetail = table.Column<decimal>(type: "decimal(12,2)", nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: true),
                    UpdatedBy = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SaleDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SaleDetails_AspNetUsers_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SaleDetails_AspNetUsers_DeletedBy",
                        column: x => x.DeletedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SaleDetails_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SaleDetails_Sales_SaleId",
                        column: x => x.SaleId,
                        principalTable: "Sales",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SaleDetails_AspNetUsers_UpdatedBy",
                        column: x => x.UpdatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Inventories",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedAt = table.Column<DateTime>(nullable: true),
                    CreatedBy = table.Column<string>(nullable: true),
                    Deleted = table.Column<bool>(nullable: false),
                    DeletedAt = table.Column<DateTime>(nullable: true),
                    DeletedBy = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    ProductCharges = table.Column<decimal>(type: "decimal(12,2)", nullable: false),
                    ProductDiscount = table.Column<decimal>(type: "decimal(12,2)", nullable: false),
                    ProductId = table.Column<long>(nullable: false),
                    PurchaseId = table.Column<long>(nullable: false),
                    Quantity = table.Column<int>(nullable: false),
                    ShopId = table.Column<long>(nullable: false),
                    SubTotal = table.Column<decimal>(type: "decimal(12,2)", nullable: false),
                    Total = table.Column<decimal>(type: "decimal(12,2)", nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: true),
                    UpdatedBy = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Inventories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Inventories_AspNetUsers_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Inventories_AspNetUsers_DeletedBy",
                        column: x => x.DeletedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Inventories_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Inventories_Purchases_PurchaseId",
                        column: x => x.PurchaseId,
                        principalTable: "Purchases",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Inventories_Shops_ShopId",
                        column: x => x.ShopId,
                        principalTable: "Shops",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Inventories_AspNetUsers_UpdatedBy",
                        column: x => x.UpdatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PurchaseDetails",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    BuyPrice = table.Column<decimal>(type: "decimal(12,2)", nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: true),
                    CreatedBy = table.Column<string>(nullable: true),
                    Deleted = table.Column<bool>(nullable: false),
                    DeletedAt = table.Column<DateTime>(nullable: true),
                    DeletedBy = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    ProductCharges = table.Column<decimal>(type: "decimal(12,2)", nullable: false),
                    ProductDiscount = table.Column<decimal>(type: "decimal(12,2)", nullable: false),
                    ProductId = table.Column<long>(nullable: true),
                    PurchaseId = table.Column<long>(nullable: true),
                    Quantity = table.Column<int>(nullable: false),
                    SellPrice = table.Column<decimal>(type: "decimal(12,2)", nullable: false),
                    SubTotal = table.Column<decimal>(type: "decimal(12,2)", nullable: false),
                    TotalDetail = table.Column<decimal>(type: "decimal(12,2)", nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: true),
                    UpdatedBy = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PurchaseDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PurchaseDetails_AspNetUsers_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PurchaseDetails_AspNetUsers_DeletedBy",
                        column: x => x.DeletedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PurchaseDetails_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PurchaseDetails_Purchases_PurchaseId",
                        column: x => x.PurchaseId,
                        principalTable: "Purchases",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PurchaseDetails_AspNetUsers_UpdatedBy",
                        column: x => x.UpdatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Admisions",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Complicaciones = table.Column<string>(maxLength: 300, nullable: true),
                    CreatedAt = table.Column<DateTime>(nullable: true),
                    CreatedBy = table.Column<string>(nullable: true),
                    Date = table.Column<DateTime>(nullable: false),
                    Deleted = table.Column<bool>(nullable: false),
                    DeletedAt = table.Column<DateTime>(nullable: true),
                    DeletedBy = table.Column<string>(nullable: true),
                    Diagnostico = table.Column<string>(maxLength: 300, nullable: true),
                    DoctorAutorization = table.Column<string>(maxLength: 100, nullable: true),
                    ExitDate = table.Column<DateTime>(nullable: true),
                    ExitDoctor = table.Column<string>(maxLength: 100, nullable: true),
                    ExitHour = table.Column<DateTime>(nullable: true),
                    Fuga = table.Column<bool>(nullable: false),
                    HallazgosLab = table.Column<string>(maxLength: 300, nullable: true),
                    HallazgosRad = table.Column<string>(maxLength: 300, nullable: true),
                    HistoPatologia = table.Column<string>(maxLength: 300, nullable: true),
                    Hour = table.Column<DateTime>(nullable: true),
                    Muerte = table.Column<bool>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    NoAutorizacion = table.Column<string>(maxLength: 20, nullable: true),
                    NurseAdmision = table.Column<string>(maxLength: 100, nullable: true),
                    Observations = table.Column<string>(maxLength: 500, nullable: true),
                    OrdenMedica = table.Column<bool>(nullable: false),
                    OtrosEst = table.Column<string>(maxLength: 300, nullable: true),
                    PatientId = table.Column<long>(nullable: true),
                    PersonId = table.Column<long>(nullable: false),
                    Peticion = table.Column<bool>(nullable: false),
                    PlaceId = table.Column<long>(nullable: true),
                    Procedimientos = table.Column<string>(maxLength: 300, nullable: true),
                    Reason = table.Column<string>(maxLength: 500, nullable: true),
                    StatusId = table.Column<long>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: true),
                    UpdatedBy = table.Column<string>(nullable: true),
                    UserAltaId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Admisions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Admisions_AspNetUsers_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Admisions_AspNetUsers_DeletedBy",
                        column: x => x.DeletedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Admisions_Patients_PatientId",
                        column: x => x.PatientId,
                        principalTable: "Patients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Admisions_People_PersonId",
                        column: x => x.PersonId,
                        principalTable: "People",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Admisions_Places_PlaceId",
                        column: x => x.PlaceId,
                        principalTable: "Places",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Admisions_Status_StatusId",
                        column: x => x.StatusId,
                        principalTable: "Status",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Admisions_AspNetUsers_UpdatedBy",
                        column: x => x.UpdatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Admisions_AspNetUsers_UserAltaId",
                        column: x => x.UserAltaId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Classes",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedAt = table.Column<DateTime>(nullable: true),
                    CreatedBy = table.Column<string>(nullable: true),
                    DateFrom = table.Column<DateTime>(nullable: false),
                    DateTo = table.Column<DateTime>(nullable: false),
                    Deleted = table.Column<bool>(nullable: false),
                    DeletedAt = table.Column<DateTime>(nullable: true),
                    DeletedBy = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    PlaceId = table.Column<long>(nullable: false),
                    SignatureId = table.Column<long>(nullable: false),
                    Teacher = table.Column<string>(nullable: true),
                    UpdatedAt = table.Column<DateTime>(nullable: true),
                    UpdatedBy = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Classes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Classes_AspNetUsers_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Classes_AspNetUsers_DeletedBy",
                        column: x => x.DeletedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Classes_Places_PlaceId",
                        column: x => x.PlaceId,
                        principalTable: "Places",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Classes_Signatures_SignatureId",
                        column: x => x.SignatureId,
                        principalTable: "Signatures",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Classes_AspNetUsers_UpdatedBy",
                        column: x => x.UpdatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Groups",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Code = table.Column<string>(nullable: true),
                    CreatedAt = table.Column<DateTime>(nullable: true),
                    CreatedBy = table.Column<string>(nullable: true),
                    Deleted = table.Column<bool>(nullable: false),
                    DeletedAt = table.Column<DateTime>(nullable: true),
                    DeletedBy = table.Column<string>(nullable: true),
                    EmployeeId = table.Column<long>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    SubjectId = table.Column<long>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: true),
                    UpdatedBy = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Groups", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Groups_AspNetUsers_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Groups_AspNetUsers_DeletedBy",
                        column: x => x.DeletedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Groups_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Groups_Subjects_SubjectId",
                        column: x => x.SubjectId,
                        principalTable: "Subjects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Groups_AspNetUsers_UpdatedBy",
                        column: x => x.UpdatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Asistants",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AsistanceId = table.Column<long>(nullable: false),
                    ClasseId = table.Column<long>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Asistants", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Asistants_People_AsistanceId",
                        column: x => x.AsistanceId,
                        principalTable: "People",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Asistants_Classes_ClasseId",
                        column: x => x.ClasseId,
                        principalTable: "Classes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DaysOfTheWeeks",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ClasseId = table.Column<long>(nullable: true),
                    CreatedAt = table.Column<DateTime>(nullable: true),
                    CreatedBy = table.Column<string>(nullable: true),
                    Deleted = table.Column<bool>(nullable: false),
                    DeletedAt = table.Column<DateTime>(nullable: true),
                    DeletedBy = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    UpdatedAt = table.Column<DateTime>(nullable: true),
                    UpdatedBy = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DaysOfTheWeeks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DaysOfTheWeeks_Classes_ClasseId",
                        column: x => x.ClasseId,
                        principalTable: "Classes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DaysOfTheWeeks_AspNetUsers_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DaysOfTheWeeks_AspNetUsers_DeletedBy",
                        column: x => x.DeletedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DaysOfTheWeeks_AspNetUsers_UpdatedBy",
                        column: x => x.UpdatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Occupants",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ClasseId = table.Column<long>(nullable: true),
                    DateFrom = table.Column<DateTime>(nullable: true),
                    DateTo = table.Column<DateTime>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Observations = table.Column<string>(maxLength: 500, nullable: true),
                    PersonId = table.Column<long>(nullable: true),
                    PlaceId = table.Column<long>(nullable: false),
                    Undefined = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Occupants", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Occupants_Classes_ClasseId",
                        column: x => x.ClasseId,
                        principalTable: "Classes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Occupants_People_PersonId",
                        column: x => x.PersonId,
                        principalTable: "People",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Occupants_Places_PlaceId",
                        column: x => x.PlaceId,
                        principalTable: "Places",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Assignments",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedAt = table.Column<DateTime>(nullable: true),
                    CreatedBy = table.Column<string>(nullable: true),
                    DateEnd = table.Column<DateTime>(nullable: false),
                    DateStart = table.Column<DateTime>(nullable: false),
                    Deleted = table.Column<bool>(nullable: false),
                    DeletedAt = table.Column<DateTime>(nullable: true),
                    DeletedBy = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    FilePath = table.Column<string>(nullable: true),
                    GroupId = table.Column<long>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    SubjectId = table.Column<long>(nullable: true),
                    UpdatedAt = table.Column<DateTime>(nullable: true),
                    UpdatedBy = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Assignments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Assignments_AspNetUsers_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Assignments_AspNetUsers_DeletedBy",
                        column: x => x.DeletedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Assignments_Groups_GroupId",
                        column: x => x.GroupId,
                        principalTable: "Groups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Assignments_Subjects_SubjectId",
                        column: x => x.SubjectId,
                        principalTable: "Subjects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Assignments_AspNetUsers_UpdatedBy",
                        column: x => x.UpdatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Forums",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Content = table.Column<string>(nullable: true),
                    CreatedAt = table.Column<DateTime>(nullable: true),
                    CreatedBy = table.Column<string>(nullable: true),
                    DateEnd = table.Column<DateTime>(nullable: true),
                    DateStart = table.Column<DateTime>(nullable: true),
                    Deleted = table.Column<bool>(nullable: false),
                    DeletedAt = table.Column<DateTime>(nullable: true),
                    DeletedBy = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    GroupId = table.Column<long>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    PosiblePoints = table.Column<int>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: true),
                    UpdatedBy = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Forums", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Forums_AspNetUsers_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Forums_AspNetUsers_DeletedBy",
                        column: x => x.DeletedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Forums_Groups_GroupId",
                        column: x => x.GroupId,
                        principalTable: "Groups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Forums_AspNetUsers_UpdatedBy",
                        column: x => x.UpdatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "GroupMessages",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Content = table.Column<string>(nullable: true),
                    CreatedAt = table.Column<DateTime>(nullable: true),
                    CreatedBy = table.Column<string>(nullable: true),
                    Deleted = table.Column<bool>(nullable: false),
                    DeletedAt = table.Column<DateTime>(nullable: true),
                    DeletedBy = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    FilePath = table.Column<string>(nullable: true),
                    GroupId = table.Column<long>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    UpdatedAt = table.Column<DateTime>(nullable: true),
                    UpdatedBy = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GroupMessages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GroupMessages_AspNetUsers_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_GroupMessages_AspNetUsers_DeletedBy",
                        column: x => x.DeletedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_GroupMessages_Groups_GroupId",
                        column: x => x.GroupId,
                        principalTable: "Groups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_GroupMessages_AspNetUsers_UpdatedBy",
                        column: x => x.UpdatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Lessons",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Content = table.Column<string>(nullable: true),
                    CreatedAt = table.Column<DateTime>(nullable: true),
                    CreatedBy = table.Column<string>(nullable: true),
                    DateEnd = table.Column<DateTime>(nullable: false),
                    DateStart = table.Column<DateTime>(nullable: false),
                    Deleted = table.Column<bool>(nullable: false),
                    DeletedAt = table.Column<DateTime>(nullable: true),
                    DeletedBy = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    FilePath = table.Column<string>(nullable: true),
                    GroupId = table.Column<long>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    UpdatedAt = table.Column<DateTime>(nullable: true),
                    UpdatedBy = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lessons", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Lessons_AspNetUsers_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Lessons_AspNetUsers_DeletedBy",
                        column: x => x.DeletedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Lessons_Groups_GroupId",
                        column: x => x.GroupId,
                        principalTable: "Groups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Lessons_AspNetUsers_UpdatedBy",
                        column: x => x.UpdatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Quizzes",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedAt = table.Column<DateTime>(nullable: true),
                    CreatedBy = table.Column<string>(nullable: true),
                    DateEnd = table.Column<DateTime>(nullable: false),
                    DateStart = table.Column<DateTime>(nullable: false),
                    Deleted = table.Column<bool>(nullable: false),
                    DeletedAt = table.Column<DateTime>(nullable: true),
                    DeletedBy = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    GroupId = table.Column<long>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    PosiblePoints = table.Column<int>(nullable: false),
                    QuizzType = table.Column<int>(nullable: false),
                    RepeatTimes = table.Column<int>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: true),
                    UpdatedBy = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Quizzes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Quizzes_AspNetUsers_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Quizzes_AspNetUsers_DeletedBy",
                        column: x => x.DeletedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Quizzes_Groups_GroupId",
                        column: x => x.GroupId,
                        principalTable: "Groups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Quizzes_AspNetUsers_UpdatedBy",
                        column: x => x.UpdatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Schedules",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedAt = table.Column<DateTime>(nullable: true),
                    CreatedBy = table.Column<string>(nullable: true),
                    DateEnd = table.Column<DateTime>(nullable: false),
                    DateStart = table.Column<DateTime>(nullable: false),
                    Deleted = table.Column<bool>(nullable: false),
                    DeletedAt = table.Column<DateTime>(nullable: true),
                    DeletedBy = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    GroupId = table.Column<long>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    PlaceId = table.Column<long>(nullable: true),
                    ScheduleFormatId = table.Column<long>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: true),
                    UpdatedBy = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Schedules", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Schedules_AspNetUsers_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Schedules_AspNetUsers_DeletedBy",
                        column: x => x.DeletedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Schedules_Groups_GroupId",
                        column: x => x.GroupId,
                        principalTable: "Groups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Schedules_Places_PlaceId",
                        column: x => x.PlaceId,
                        principalTable: "Places",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Schedules_ScheduleFormats_ScheduleFormatId",
                        column: x => x.ScheduleFormatId,
                        principalTable: "ScheduleFormats",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Schedules_AspNetUsers_UpdatedBy",
                        column: x => x.UpdatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedAt = table.Column<DateTime>(nullable: true),
                    CreatedBy = table.Column<string>(nullable: true),
                    Deleted = table.Column<bool>(nullable: false),
                    DeletedAt = table.Column<DateTime>(nullable: true),
                    DeletedBy = table.Column<string>(nullable: true),
                    GroupId = table.Column<long>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    PersonId = table.Column<long>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: true),
                    UpdatedBy = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Students_AspNetUsers_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Students_AspNetUsers_DeletedBy",
                        column: x => x.DeletedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Students_Groups_GroupId",
                        column: x => x.GroupId,
                        principalTable: "Groups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Students_People_PersonId",
                        column: x => x.PersonId,
                        principalTable: "People",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Students_AspNetUsers_UpdatedBy",
                        column: x => x.UpdatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "LessonComments",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Comment = table.Column<string>(nullable: true),
                    CreatedAt = table.Column<DateTime>(nullable: true),
                    CreatedBy = table.Column<string>(nullable: true),
                    Deleted = table.Column<bool>(nullable: false),
                    DeletedAt = table.Column<DateTime>(nullable: true),
                    DeletedBy = table.Column<string>(nullable: true),
                    LessonId = table.Column<long>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    SubmitDate = table.Column<DateTime>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: true),
                    UpdatedBy = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LessonComments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LessonComments_AspNetUsers_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_LessonComments_AspNetUsers_DeletedBy",
                        column: x => x.DeletedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_LessonComments_Lessons_LessonId",
                        column: x => x.LessonId,
                        principalTable: "Lessons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_LessonComments_AspNetUsers_UpdatedBy",
                        column: x => x.UpdatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "QuizzQuestions",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedAt = table.Column<DateTime>(nullable: true),
                    CreatedBy = table.Column<string>(nullable: true),
                    Deleted = table.Column<bool>(nullable: false),
                    DeletedAt = table.Column<DateTime>(nullable: true),
                    DeletedBy = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    QuizzId = table.Column<long>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: true),
                    UpdatedBy = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuizzQuestions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_QuizzQuestions_AspNetUsers_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_QuizzQuestions_AspNetUsers_DeletedBy",
                        column: x => x.DeletedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_QuizzQuestions_Quizzes_QuizzId",
                        column: x => x.QuizzId,
                        principalTable: "Quizzes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_QuizzQuestions_AspNetUsers_UpdatedBy",
                        column: x => x.UpdatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Activities",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Amount = table.Column<decimal>(type: "decimal(12,2)", nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: true),
                    CreatedBy = table.Column<string>(nullable: true),
                    DateFrom = table.Column<DateTime>(nullable: false),
                    DateTo = table.Column<DateTime>(nullable: false),
                    Deleted = table.Column<bool>(nullable: false),
                    DeletedAt = table.Column<DateTime>(nullable: true),
                    DeletedBy = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    GroupId = table.Column<long>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    PlaceId = table.Column<long>(nullable: true),
                    ScheduleId = table.Column<long>(nullable: false),
                    StatusId = table.Column<long>(nullable: true),
                    UpdatedAt = table.Column<DateTime>(nullable: true),
                    UpdatedBy = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Activities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Activities_AspNetUsers_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Activities_AspNetUsers_DeletedBy",
                        column: x => x.DeletedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Activities_Groups_GroupId",
                        column: x => x.GroupId,
                        principalTable: "Groups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Activities_Places_PlaceId",
                        column: x => x.PlaceId,
                        principalTable: "Places",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Activities_Schedules_ScheduleId",
                        column: x => x.ScheduleId,
                        principalTable: "Schedules",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Activities_Status_StatusId",
                        column: x => x.StatusId,
                        principalTable: "Status",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Activities_AspNetUsers_UpdatedBy",
                        column: x => x.UpdatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ForumComments",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Comment = table.Column<string>(nullable: true),
                    CreatedAt = table.Column<DateTime>(nullable: true),
                    CreatedBy = table.Column<string>(nullable: true),
                    Deleted = table.Column<bool>(nullable: false),
                    DeletedAt = table.Column<DateTime>(nullable: true),
                    DeletedBy = table.Column<string>(nullable: true),
                    ForumId = table.Column<long>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    StudentId = table.Column<long>(nullable: true),
                    SubmitDate = table.Column<DateTime>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: true),
                    UpdatedBy = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ForumComments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ForumComments_AspNetUsers_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ForumComments_AspNetUsers_DeletedBy",
                        column: x => x.DeletedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ForumComments_Forums_ForumId",
                        column: x => x.ForumId,
                        principalTable: "Forums",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ForumComments_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ForumComments_AspNetUsers_UpdatedBy",
                        column: x => x.UpdatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "GroupStudents",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Cal1 = table.Column<int>(nullable: false),
                    Cal2 = table.Column<int>(nullable: false),
                    Cal3 = table.Column<int>(nullable: false),
                    Cal4 = table.Column<int>(nullable: false),
                    Cal5 = table.Column<int>(nullable: false),
                    CalificationNote = table.Column<string>(nullable: true),
                    CommuledPoints = table.Column<int>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: true),
                    CreatedBy = table.Column<string>(nullable: true),
                    Deleted = table.Column<bool>(nullable: false),
                    DeletedAt = table.Column<DateTime>(nullable: true),
                    DeletedBy = table.Column<string>(nullable: true),
                    FinalPoints = table.Column<int>(nullable: false),
                    GroupId = table.Column<long>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Observations = table.Column<string>(nullable: true),
                    PersonId = table.Column<long>(nullable: true),
                    StudentId = table.Column<long>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: true),
                    UpdatedBy = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GroupStudents", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GroupStudents_AspNetUsers_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_GroupStudents_AspNetUsers_DeletedBy",
                        column: x => x.DeletedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_GroupStudents_Groups_GroupId",
                        column: x => x.GroupId,
                        principalTable: "Groups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_GroupStudents_People_PersonId",
                        column: x => x.PersonId,
                        principalTable: "People",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_GroupStudents_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_GroupStudents_AspNetUsers_UpdatedBy",
                        column: x => x.UpdatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "QuizzSubmitions",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CorrectAnswers = table.Column<int>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: true),
                    CreatedBy = table.Column<string>(nullable: true),
                    Deleted = table.Column<bool>(nullable: false),
                    DeletedAt = table.Column<DateTime>(nullable: true),
                    DeletedBy = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    QuizzId = table.Column<long>(nullable: false),
                    Score = table.Column<int>(nullable: false),
                    StudentId = table.Column<long>(nullable: true),
                    SubmitDate = table.Column<DateTime>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: true),
                    UpdatedBy = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuizzSubmitions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_QuizzSubmitions_AspNetUsers_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_QuizzSubmitions_AspNetUsers_DeletedBy",
                        column: x => x.DeletedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_QuizzSubmitions_Quizzes_QuizzId",
                        column: x => x.QuizzId,
                        principalTable: "Quizzes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_QuizzSubmitions_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_QuizzSubmitions_AspNetUsers_UpdatedBy",
                        column: x => x.UpdatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Submissions",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AssignmentId = table.Column<long>(nullable: false),
                    Comment = table.Column<string>(nullable: true),
                    CreatedAt = table.Column<DateTime>(nullable: true),
                    CreatedBy = table.Column<string>(nullable: true),
                    Deleted = table.Column<bool>(nullable: false),
                    DeletedAt = table.Column<DateTime>(nullable: true),
                    DeletedBy = table.Column<string>(nullable: true),
                    FilePath = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    StudentId = table.Column<long>(nullable: true),
                    SubmitDate = table.Column<DateTime>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: true),
                    UpdatedBy = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Submissions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Submissions_Assignments_AssignmentId",
                        column: x => x.AssignmentId,
                        principalTable: "Assignments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Submissions_AspNetUsers_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Submissions_AspNetUsers_DeletedBy",
                        column: x => x.DeletedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Submissions_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Submissions_AspNetUsers_UpdatedBy",
                        column: x => x.UpdatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Uploads",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedAt = table.Column<DateTime>(nullable: true),
                    CreatedBy = table.Column<string>(nullable: true),
                    Deleted = table.Column<bool>(nullable: false),
                    DeletedAt = table.Column<DateTime>(nullable: true),
                    DeletedBy = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    FilePath = table.Column<string>(nullable: true),
                    GroupId = table.Column<long>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    StudentId = table.Column<long>(nullable: true),
                    UpdatedAt = table.Column<DateTime>(nullable: true),
                    UpdatedBy = table.Column<string>(nullable: true),
                    UploadType = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Uploads", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Uploads_AspNetUsers_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Uploads_AspNetUsers_DeletedBy",
                        column: x => x.DeletedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Uploads_Groups_GroupId",
                        column: x => x.GroupId,
                        principalTable: "Groups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Uploads_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Uploads_AspNetUsers_UpdatedBy",
                        column: x => x.UpdatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "LessonReplies",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedAt = table.Column<DateTime>(nullable: true),
                    CreatedBy = table.Column<string>(nullable: true),
                    Date = table.Column<DateTime>(nullable: false),
                    Deleted = table.Column<bool>(nullable: false),
                    DeletedAt = table.Column<DateTime>(nullable: true),
                    DeletedBy = table.Column<string>(nullable: true),
                    Feedback = table.Column<string>(nullable: true),
                    LessonCommentId = table.Column<long>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Point = table.Column<int>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: true),
                    UpdatedBy = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LessonReplies", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LessonReplies_AspNetUsers_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_LessonReplies_AspNetUsers_DeletedBy",
                        column: x => x.DeletedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_LessonReplies_LessonComments_LessonCommentId",
                        column: x => x.LessonCommentId,
                        principalTable: "LessonComments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_LessonReplies_AspNetUsers_UpdatedBy",
                        column: x => x.UpdatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "QuizzChoises",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedAt = table.Column<DateTime>(nullable: true),
                    CreatedBy = table.Column<string>(nullable: true),
                    Deleted = table.Column<bool>(nullable: false),
                    DeletedAt = table.Column<DateTime>(nullable: true),
                    DeletedBy = table.Column<string>(nullable: true),
                    IsCorrect = table.Column<bool>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    QuizzQuestionId = table.Column<long>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: true),
                    UpdatedBy = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuizzChoises", x => x.Id);
                    table.ForeignKey(
                        name: "FK_QuizzChoises_AspNetUsers_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_QuizzChoises_AspNetUsers_DeletedBy",
                        column: x => x.DeletedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_QuizzChoises_QuizzQuestions_QuizzQuestionId",
                        column: x => x.QuizzQuestionId,
                        principalTable: "QuizzQuestions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_QuizzChoises_AspNetUsers_UpdatedBy",
                        column: x => x.UpdatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ActivityBeneficiaries",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ActivityId = table.Column<long>(nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(12,2)", nullable: false),
                    BenefitId = table.Column<long>(nullable: false),
                    BenefitString = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Quantity = table.Column<int>(nullable: false),
                    QuantityPart = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ActivityBeneficiaries", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ActivityBeneficiaries_Activities_ActivityId",
                        column: x => x.ActivityId,
                        principalTable: "Activities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ActivityBeneficiaries_Benefits_BenefitId",
                        column: x => x.BenefitId,
                        principalTable: "Benefits",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ActivityParticipants",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ActivityId = table.Column<long>(nullable: false),
                    ManualParticipant = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    ParticipantId = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ActivityParticipants", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ActivityParticipants_Activities_ActivityId",
                        column: x => x.ActivityId,
                        principalTable: "Activities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ActivityParticipants_People_ParticipantId",
                        column: x => x.ParticipantId,
                        principalTable: "People",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ForumCommentReplies",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedAt = table.Column<DateTime>(nullable: true),
                    CreatedBy = table.Column<string>(nullable: true),
                    Date = table.Column<DateTime>(nullable: false),
                    Deleted = table.Column<bool>(nullable: false),
                    DeletedAt = table.Column<DateTime>(nullable: true),
                    DeletedBy = table.Column<string>(nullable: true),
                    Feedback = table.Column<string>(nullable: true),
                    ForumCommentId = table.Column<long>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Point = table.Column<int>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: true),
                    UpdatedBy = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ForumCommentReplies", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ForumCommentReplies_AspNetUsers_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ForumCommentReplies_AspNetUsers_DeletedBy",
                        column: x => x.DeletedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ForumCommentReplies_ForumComments_ForumCommentId",
                        column: x => x.ForumCommentId,
                        principalTable: "ForumComments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ForumCommentReplies_AspNetUsers_UpdatedBy",
                        column: x => x.UpdatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ForumGradings",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedAt = table.Column<DateTime>(nullable: true),
                    CreatedBy = table.Column<string>(nullable: true),
                    Date = table.Column<DateTime>(nullable: false),
                    Deleted = table.Column<bool>(nullable: false),
                    DeletedAt = table.Column<DateTime>(nullable: true),
                    DeletedBy = table.Column<string>(nullable: true),
                    Feedback = table.Column<string>(nullable: true),
                    ForumCommentId = table.Column<long>(nullable: false),
                    Grade = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    UpdatedAt = table.Column<DateTime>(nullable: true),
                    UpdatedBy = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ForumGradings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ForumGradings_AspNetUsers_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ForumGradings_AspNetUsers_DeletedBy",
                        column: x => x.DeletedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ForumGradings_ForumComments_ForumCommentId",
                        column: x => x.ForumCommentId,
                        principalTable: "ForumComments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ForumGradings_AspNetUsers_UpdatedBy",
                        column: x => x.UpdatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Gradings",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedAt = table.Column<DateTime>(nullable: true),
                    CreatedBy = table.Column<string>(nullable: true),
                    Date = table.Column<DateTime>(nullable: false),
                    Deleted = table.Column<bool>(nullable: false),
                    DeletedAt = table.Column<DateTime>(nullable: true),
                    DeletedBy = table.Column<string>(nullable: true),
                    Feedback = table.Column<string>(nullable: true),
                    Grade = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    SubmissionId = table.Column<long>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: true),
                    UpdatedBy = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gradings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Gradings_AspNetUsers_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Gradings_AspNetUsers_DeletedBy",
                        column: x => x.DeletedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Gradings_Submissions_SubmissionId",
                        column: x => x.SubmissionId,
                        principalTable: "Submissions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Gradings_AspNetUsers_UpdatedBy",
                        column: x => x.UpdatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "UploadComments",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Comment = table.Column<string>(nullable: true),
                    CreatedAt = table.Column<DateTime>(nullable: true),
                    CreatedBy = table.Column<string>(nullable: true),
                    Deleted = table.Column<bool>(nullable: false),
                    DeletedAt = table.Column<DateTime>(nullable: true),
                    DeletedBy = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    SubmitDate = table.Column<DateTime>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: true),
                    UpdatedBy = table.Column<string>(nullable: true),
                    UploadId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UploadComments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UploadComments_AspNetUsers_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UploadComments_AspNetUsers_DeletedBy",
                        column: x => x.DeletedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UploadComments_AspNetUsers_UpdatedBy",
                        column: x => x.UpdatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UploadComments_Uploads_UploadId",
                        column: x => x.UploadId,
                        principalTable: "Uploads",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_People_BloodTypeId",
                table: "People",
                column: "BloodTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_People_InsuranceId",
                table: "People",
                column: "InsuranceId");

            migrationBuilder.CreateIndex(
                name: "IX_People_MemberTypeId",
                table: "People",
                column: "MemberTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_People_SpecialityId",
                table: "People",
                column: "SpecialityId");

            migrationBuilder.CreateIndex(
                name: "IX_Payments_SaleId",
                table: "Payments",
                column: "SaleId");

            migrationBuilder.CreateIndex(
                name: "IX_Images_ActivityId",
                table: "Images",
                column: "ActivityId");

            migrationBuilder.CreateIndex(
                name: "IX_Images_BenefitId",
                table: "Images",
                column: "BenefitId");

            migrationBuilder.CreateIndex(
                name: "IX_Images_ClasseId",
                table: "Images",
                column: "ClasseId");

            migrationBuilder.CreateIndex(
                name: "IX_Images_ColaboratorDonationId",
                table: "Images",
                column: "ColaboratorDonationId");

            migrationBuilder.CreateIndex(
                name: "IX_Images_FoodId",
                table: "Images",
                column: "FoodId");

            migrationBuilder.CreateIndex(
                name: "IX_Images_ProjectId",
                table: "Images",
                column: "ProjectId");

            migrationBuilder.CreateIndex(
                name: "IX_Images_SignatureId",
                table: "Images",
                column: "SignatureId");

            migrationBuilder.CreateIndex(
                name: "IX_Activities_CreatedBy",
                table: "Activities",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Activities_DeletedBy",
                table: "Activities",
                column: "DeletedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Activities_GroupId",
                table: "Activities",
                column: "GroupId");

            migrationBuilder.CreateIndex(
                name: "IX_Activities_PlaceId",
                table: "Activities",
                column: "PlaceId");

            migrationBuilder.CreateIndex(
                name: "IX_Activities_ScheduleId",
                table: "Activities",
                column: "ScheduleId");

            migrationBuilder.CreateIndex(
                name: "IX_Activities_StatusId",
                table: "Activities",
                column: "StatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Activities_UpdatedBy",
                table: "Activities",
                column: "UpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_ActivityBeneficiaries_ActivityId",
                table: "ActivityBeneficiaries",
                column: "ActivityId");

            migrationBuilder.CreateIndex(
                name: "IX_ActivityBeneficiaries_BenefitId",
                table: "ActivityBeneficiaries",
                column: "BenefitId");

            migrationBuilder.CreateIndex(
                name: "IX_ActivityParticipants_ActivityId",
                table: "ActivityParticipants",
                column: "ActivityId");

            migrationBuilder.CreateIndex(
                name: "IX_ActivityParticipants_ParticipantId",
                table: "ActivityParticipants",
                column: "ParticipantId");

            migrationBuilder.CreateIndex(
                name: "IX_Admisions_CreatedBy",
                table: "Admisions",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Admisions_DeletedBy",
                table: "Admisions",
                column: "DeletedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Admisions_PatientId",
                table: "Admisions",
                column: "PatientId");

            migrationBuilder.CreateIndex(
                name: "IX_Admisions_PersonId",
                table: "Admisions",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_Admisions_PlaceId",
                table: "Admisions",
                column: "PlaceId");

            migrationBuilder.CreateIndex(
                name: "IX_Admisions_StatusId",
                table: "Admisions",
                column: "StatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Admisions_UpdatedBy",
                table: "Admisions",
                column: "UpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Admisions_UserAltaId",
                table: "Admisions",
                column: "UserAltaId");

            migrationBuilder.CreateIndex(
                name: "IX_Allergies_AllergyCategoryId",
                table: "Allergies",
                column: "AllergyCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Analiticals_CreatedBy",
                table: "Analiticals",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Analiticals_DeletedBy",
                table: "Analiticals",
                column: "DeletedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Analiticals_PersonId",
                table: "Analiticals",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_Analiticals_UpdatedBy",
                table: "Analiticals",
                column: "UpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_AnalyticalSheets_CreatedBy",
                table: "AnalyticalSheets",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_AnalyticalSheets_DeletedBy",
                table: "AnalyticalSheets",
                column: "DeletedBy");

            migrationBuilder.CreateIndex(
                name: "IX_AnalyticalSheets_PersonId",
                table: "AnalyticalSheets",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_AnalyticalSheets_UpdatedBy",
                table: "AnalyticalSheets",
                column: "UpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Appointments_CreatedBy",
                table: "Appointments",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Appointments_DeletedBy",
                table: "Appointments",
                column: "DeletedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Appointments_DoctorId",
                table: "Appointments",
                column: "DoctorId");

            migrationBuilder.CreateIndex(
                name: "IX_Appointments_PersonId",
                table: "Appointments",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_Appointments_SpecialityId",
                table: "Appointments",
                column: "SpecialityId");

            migrationBuilder.CreateIndex(
                name: "IX_Appointments_TandaId1",
                table: "Appointments",
                column: "TandaId1");

            migrationBuilder.CreateIndex(
                name: "IX_Appointments_UpdatedBy",
                table: "Appointments",
                column: "UpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Asistants_AsistanceId",
                table: "Asistants",
                column: "AsistanceId");

            migrationBuilder.CreateIndex(
                name: "IX_Asistants_ClasseId",
                table: "Asistants",
                column: "ClasseId");

            migrationBuilder.CreateIndex(
                name: "IX_Assignments_CreatedBy",
                table: "Assignments",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Assignments_DeletedBy",
                table: "Assignments",
                column: "DeletedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Assignments_GroupId",
                table: "Assignments",
                column: "GroupId");

            migrationBuilder.CreateIndex(
                name: "IX_Assignments_SubjectId",
                table: "Assignments",
                column: "SubjectId");

            migrationBuilder.CreateIndex(
                name: "IX_Assignments_UpdatedBy",
                table: "Assignments",
                column: "UpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Bariatrics_CreatedBy",
                table: "Bariatrics",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Bariatrics_DeletedBy",
                table: "Bariatrics",
                column: "DeletedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Bariatrics_PersonId",
                table: "Bariatrics",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_Bariatrics_UpdatedBy",
                table: "Bariatrics",
                column: "UpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_BariatricVisits_BariatricId",
                table: "BariatricVisits",
                column: "BariatricId");

            migrationBuilder.CreateIndex(
                name: "IX_BariatricVisits_CreatedBy",
                table: "BariatricVisits",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_BariatricVisits_DeletedBy",
                table: "BariatricVisits",
                column: "DeletedBy");

            migrationBuilder.CreateIndex(
                name: "IX_BariatricVisits_UpdatedBy",
                table: "BariatricVisits",
                column: "UpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Beneficiaries_BenefitId",
                table: "Beneficiaries",
                column: "BenefitId");

            migrationBuilder.CreateIndex(
                name: "IX_Beneficiaries_ReceiverId",
                table: "Beneficiaries",
                column: "ReceiverId");

            migrationBuilder.CreateIndex(
                name: "IX_Benefits_CreatedBy",
                table: "Benefits",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Benefits_DeletedBy",
                table: "Benefits",
                column: "DeletedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Benefits_UpdatedBy",
                table: "Benefits",
                column: "UpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Brands_CreatedBy",
                table: "Brands",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Brands_DeletedBy",
                table: "Brands",
                column: "DeletedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Brands_UpdatedBy",
                table: "Brands",
                column: "UpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_BuyDetails_BuyId",
                table: "BuyDetails",
                column: "BuyId");

            migrationBuilder.CreateIndex(
                name: "IX_BuyDetails_CreatedBy",
                table: "BuyDetails",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_BuyDetails_DeletedBy",
                table: "BuyDetails",
                column: "DeletedBy");

            migrationBuilder.CreateIndex(
                name: "IX_BuyDetails_UpdatedBy",
                table: "BuyDetails",
                column: "UpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Buys_CreatedBy",
                table: "Buys",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Buys_DeletedBy",
                table: "Buys",
                column: "DeletedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Buys_UpdatedBy",
                table: "Buys",
                column: "UpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Categories_CreatedBy",
                table: "Categories",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Categories_DeletedBy",
                table: "Categories",
                column: "DeletedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Categories_UpdatedBy",
                table: "Categories",
                column: "UpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Classes_CreatedBy",
                table: "Classes",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Classes_DeletedBy",
                table: "Classes",
                column: "DeletedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Classes_PlaceId",
                table: "Classes",
                column: "PlaceId");

            migrationBuilder.CreateIndex(
                name: "IX_Classes_SignatureId",
                table: "Classes",
                column: "SignatureId");

            migrationBuilder.CreateIndex(
                name: "IX_Classes_UpdatedBy",
                table: "Classes",
                column: "UpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_ClinicHistories_CreatedBy",
                table: "ClinicHistories",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_ClinicHistories_DeletedBy",
                table: "ClinicHistories",
                column: "DeletedBy");

            migrationBuilder.CreateIndex(
                name: "IX_ClinicHistories_PersonId",
                table: "ClinicHistories",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_ClinicHistories_UpdatedBy",
                table: "ClinicHistories",
                column: "UpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_ColaboratorDonations_ColaboratorId",
                table: "ColaboratorDonations",
                column: "ColaboratorId");

            migrationBuilder.CreateIndex(
                name: "IX_ColaboratorDonations_CreatedBy",
                table: "ColaboratorDonations",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_ColaboratorDonations_DeletedBy",
                table: "ColaboratorDonations",
                column: "DeletedBy");

            migrationBuilder.CreateIndex(
                name: "IX_ColaboratorDonations_UpdatedBy",
                table: "ColaboratorDonations",
                column: "UpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Colaborators_CreatedBy",
                table: "Colaborators",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Colaborators_DeletedBy",
                table: "Colaborators",
                column: "DeletedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Colaborators_UpdatedBy",
                table: "Colaborators",
                column: "UpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Comensals_ComensalId",
                table: "Comensals",
                column: "ComensalId");

            migrationBuilder.CreateIndex(
                name: "IX_Comensals_FoodId",
                table: "Comensals",
                column: "FoodId");

            migrationBuilder.CreateIndex(
                name: "IX_Conditions_CreatedBy",
                table: "Conditions",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Conditions_DeletedBy",
                table: "Conditions",
                column: "DeletedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Conditions_PersonId",
                table: "Conditions",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_Conditions_UpdatedBy",
                table: "Conditions",
                column: "UpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Courses_CourseModalityId",
                table: "Courses",
                column: "CourseModalityId");

            migrationBuilder.CreateIndex(
                name: "IX_Courses_CourseTypeId",
                table: "Courses",
                column: "CourseTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Courses_CreatedBy",
                table: "Courses",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Courses_DeletedBy",
                table: "Courses",
                column: "DeletedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Courses_UpdatedBy",
                table: "Courses",
                column: "UpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_CreditDebits_CreatedBy",
                table: "CreditDebits",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_CreditDebits_DeletedBy",
                table: "CreditDebits",
                column: "DeletedBy");

            migrationBuilder.CreateIndex(
                name: "IX_CreditDebits_OriginId",
                table: "CreditDebits",
                column: "OriginId");

            migrationBuilder.CreateIndex(
                name: "IX_CreditDebits_PersonId",
                table: "CreditDebits",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_CreditDebits_UpdatedBy",
                table: "CreditDebits",
                column: "UpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_DaysOfTheWeeks_ClasseId",
                table: "DaysOfTheWeeks",
                column: "ClasseId");

            migrationBuilder.CreateIndex(
                name: "IX_DaysOfTheWeeks_CreatedBy",
                table: "DaysOfTheWeeks",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_DaysOfTheWeeks_DeletedBy",
                table: "DaysOfTheWeeks",
                column: "DeletedBy");

            migrationBuilder.CreateIndex(
                name: "IX_DaysOfTheWeeks_UpdatedBy",
                table: "DaysOfTheWeeks",
                column: "UpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_DentalHistories_CreatedBy",
                table: "DentalHistories",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_DentalHistories_DeletedBy",
                table: "DentalHistories",
                column: "DeletedBy");

            migrationBuilder.CreateIndex(
                name: "IX_DentalHistories_PersonId",
                table: "DentalHistories",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_DentalHistories_UpdatedBy",
                table: "DentalHistories",
                column: "UpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_DiagnosticCies_DiagnosticCategoryId",
                table: "DiagnosticCies",
                column: "DiagnosticCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Diagnostics_CreatedBy",
                table: "Diagnostics",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Diagnostics_DeletedBy",
                table: "Diagnostics",
                column: "DeletedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Diagnostics_DiagnosticId",
                table: "Diagnostics",
                column: "DiagnosticId");

            migrationBuilder.CreateIndex(
                name: "IX_Diagnostics_PatientId",
                table: "Diagnostics",
                column: "PatientId");

            migrationBuilder.CreateIndex(
                name: "IX_Diagnostics_PersonId",
                table: "Diagnostics",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_Diagnostics_UpdatedBy",
                table: "Diagnostics",
                column: "UpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Doctors_CreatedBy",
                table: "Doctors",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Doctors_DeletedBy",
                table: "Doctors",
                column: "DeletedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Doctors_PersonId",
                table: "Doctors",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_Doctors_UpdatedBy",
                table: "Doctors",
                column: "UpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_EconomicPerfils_CreatedBy",
                table: "EconomicPerfils",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_EconomicPerfils_DeletedBy",
                table: "EconomicPerfils",
                column: "DeletedBy");

            migrationBuilder.CreateIndex(
                name: "IX_EconomicPerfils_PersonId",
                table: "EconomicPerfils",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_EconomicPerfils_UpdatedBy",
                table: "EconomicPerfils",
                column: "UpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Emergencies_CreatedBy",
                table: "Emergencies",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Emergencies_DeletedBy",
                table: "Emergencies",
                column: "DeletedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Emergencies_PersonId",
                table: "Emergencies",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_Emergencies_StatusId",
                table: "Emergencies",
                column: "StatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Emergencies_UpdatedBy",
                table: "Emergencies",
                column: "UpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Endocrines_CreatedBy",
                table: "Endocrines",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Endocrines_DeletedBy",
                table: "Endocrines",
                column: "DeletedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Endocrines_PersonId",
                table: "Endocrines",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_Endocrines_UpdatedBy",
                table: "Endocrines",
                column: "UpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Estudies_CreatedBy",
                table: "Estudies",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Estudies_DeletedBy",
                table: "Estudies",
                column: "DeletedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Estudies_PersonId",
                table: "Estudies",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_Estudies_UpdatedBy",
                table: "Estudies",
                column: "UpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_FoodDetails_CreatedBy",
                table: "FoodDetails",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_FoodDetails_DeletedBy",
                table: "FoodDetails",
                column: "DeletedBy");

            migrationBuilder.CreateIndex(
                name: "IX_FoodDetails_FoodId",
                table: "FoodDetails",
                column: "FoodId");

            migrationBuilder.CreateIndex(
                name: "IX_FoodDetails_UpdatedBy",
                table: "FoodDetails",
                column: "UpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Foods_CreatedBy",
                table: "Foods",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Foods_DeletedBy",
                table: "Foods",
                column: "DeletedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Foods_UpdatedBy",
                table: "Foods",
                column: "UpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_ForumCommentReplies_CreatedBy",
                table: "ForumCommentReplies",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_ForumCommentReplies_DeletedBy",
                table: "ForumCommentReplies",
                column: "DeletedBy");

            migrationBuilder.CreateIndex(
                name: "IX_ForumCommentReplies_ForumCommentId",
                table: "ForumCommentReplies",
                column: "ForumCommentId");

            migrationBuilder.CreateIndex(
                name: "IX_ForumCommentReplies_UpdatedBy",
                table: "ForumCommentReplies",
                column: "UpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_ForumComments_CreatedBy",
                table: "ForumComments",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_ForumComments_DeletedBy",
                table: "ForumComments",
                column: "DeletedBy");

            migrationBuilder.CreateIndex(
                name: "IX_ForumComments_ForumId",
                table: "ForumComments",
                column: "ForumId");

            migrationBuilder.CreateIndex(
                name: "IX_ForumComments_StudentId",
                table: "ForumComments",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_ForumComments_UpdatedBy",
                table: "ForumComments",
                column: "UpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_ForumGradings_CreatedBy",
                table: "ForumGradings",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_ForumGradings_DeletedBy",
                table: "ForumGradings",
                column: "DeletedBy");

            migrationBuilder.CreateIndex(
                name: "IX_ForumGradings_ForumCommentId",
                table: "ForumGradings",
                column: "ForumCommentId");

            migrationBuilder.CreateIndex(
                name: "IX_ForumGradings_UpdatedBy",
                table: "ForumGradings",
                column: "UpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Forums_CreatedBy",
                table: "Forums",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Forums_DeletedBy",
                table: "Forums",
                column: "DeletedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Forums_GroupId",
                table: "Forums",
                column: "GroupId");

            migrationBuilder.CreateIndex(
                name: "IX_Forums_UpdatedBy",
                table: "Forums",
                column: "UpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_GeneralAfections_CreatedBy",
                table: "GeneralAfections",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_GeneralAfections_DeletedBy",
                table: "GeneralAfections",
                column: "DeletedBy");

            migrationBuilder.CreateIndex(
                name: "IX_GeneralAfections_PersonId",
                table: "GeneralAfections",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_GeneralAfections_UpdatedBy",
                table: "GeneralAfections",
                column: "UpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_GeneralAfectionVisits_CreatedBy",
                table: "GeneralAfectionVisits",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_GeneralAfectionVisits_DeletedBy",
                table: "GeneralAfectionVisits",
                column: "DeletedBy");

            migrationBuilder.CreateIndex(
                name: "IX_GeneralAfectionVisits_GeneralAfectionId",
                table: "GeneralAfectionVisits",
                column: "GeneralAfectionId");

            migrationBuilder.CreateIndex(
                name: "IX_GeneralAfectionVisits_UpdatedBy",
                table: "GeneralAfectionVisits",
                column: "UpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Generals_CreatedBy",
                table: "Generals",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Generals_DeletedBy",
                table: "Generals",
                column: "DeletedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Generals_PersonId",
                table: "Generals",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_Generals_UpdatedBy",
                table: "Generals",
                column: "UpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_GeneralVisits_CreatedBy",
                table: "GeneralVisits",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_GeneralVisits_DeletedBy",
                table: "GeneralVisits",
                column: "DeletedBy");

            migrationBuilder.CreateIndex(
                name: "IX_GeneralVisits_GeneralId",
                table: "GeneralVisits",
                column: "GeneralId");

            migrationBuilder.CreateIndex(
                name: "IX_GeneralVisits_UpdatedBy",
                table: "GeneralVisits",
                column: "UpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Gradings_CreatedBy",
                table: "Gradings",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Gradings_DeletedBy",
                table: "Gradings",
                column: "DeletedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Gradings_SubmissionId",
                table: "Gradings",
                column: "SubmissionId");

            migrationBuilder.CreateIndex(
                name: "IX_Gradings_UpdatedBy",
                table: "Gradings",
                column: "UpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_GroupMessages_CreatedBy",
                table: "GroupMessages",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_GroupMessages_DeletedBy",
                table: "GroupMessages",
                column: "DeletedBy");

            migrationBuilder.CreateIndex(
                name: "IX_GroupMessages_GroupId",
                table: "GroupMessages",
                column: "GroupId");

            migrationBuilder.CreateIndex(
                name: "IX_GroupMessages_UpdatedBy",
                table: "GroupMessages",
                column: "UpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Groups_CreatedBy",
                table: "Groups",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Groups_DeletedBy",
                table: "Groups",
                column: "DeletedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Groups_EmployeeId",
                table: "Groups",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Groups_SubjectId",
                table: "Groups",
                column: "SubjectId");

            migrationBuilder.CreateIndex(
                name: "IX_Groups_UpdatedBy",
                table: "Groups",
                column: "UpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_GroupStudents_CreatedBy",
                table: "GroupStudents",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_GroupStudents_DeletedBy",
                table: "GroupStudents",
                column: "DeletedBy");

            migrationBuilder.CreateIndex(
                name: "IX_GroupStudents_GroupId",
                table: "GroupStudents",
                column: "GroupId");

            migrationBuilder.CreateIndex(
                name: "IX_GroupStudents_PersonId",
                table: "GroupStudents",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_GroupStudents_StudentId",
                table: "GroupStudents",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_GroupStudents_UpdatedBy",
                table: "GroupStudents",
                column: "UpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Gynecologies_CreatedBy",
                table: "Gynecologies",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Gynecologies_DeletedBy",
                table: "Gynecologies",
                column: "DeletedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Gynecologies_PersonId",
                table: "Gynecologies",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_Gynecologies_UpdatedBy",
                table: "Gynecologies",
                column: "UpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_GynecologyVisits_CreatedBy",
                table: "GynecologyVisits",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_GynecologyVisits_DeletedBy",
                table: "GynecologyVisits",
                column: "DeletedBy");

            migrationBuilder.CreateIndex(
                name: "IX_GynecologyVisits_GynecologyId",
                table: "GynecologyVisits",
                column: "GynecologyId");

            migrationBuilder.CreateIndex(
                name: "IX_GynecologyVisits_UpdatedBy",
                table: "GynecologyVisits",
                column: "UpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Inventories_CreatedBy",
                table: "Inventories",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Inventories_DeletedBy",
                table: "Inventories",
                column: "DeletedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Inventories_ProductId",
                table: "Inventories",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Inventories_PurchaseId",
                table: "Inventories",
                column: "PurchaseId");

            migrationBuilder.CreateIndex(
                name: "IX_Inventories_ShopId",
                table: "Inventories",
                column: "ShopId");

            migrationBuilder.CreateIndex(
                name: "IX_Inventories_UpdatedBy",
                table: "Inventories",
                column: "UpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Kids_CourseId",
                table: "Kids",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_Kids_CreatedBy",
                table: "Kids",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Kids_DeletedBy",
                table: "Kids",
                column: "DeletedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Kids_PersonId",
                table: "Kids",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_Kids_SchoolId",
                table: "Kids",
                column: "SchoolId");

            migrationBuilder.CreateIndex(
                name: "IX_Kids_TandaId",
                table: "Kids",
                column: "TandaId");

            migrationBuilder.CreateIndex(
                name: "IX_Kids_UpdatedBy",
                table: "Kids",
                column: "UpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_LabClasifications_CreatedBy",
                table: "LabClasifications",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_LabClasifications_DeletedBy",
                table: "LabClasifications",
                column: "DeletedBy");

            migrationBuilder.CreateIndex(
                name: "IX_LabClasifications_UpdatedBy",
                table: "LabClasifications",
                column: "UpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Laboratories_CreatedBy",
                table: "Laboratories",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Laboratories_DeletedBy",
                table: "Laboratories",
                column: "DeletedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Laboratories_LabClasificationId1",
                table: "Laboratories",
                column: "LabClasificationId1");

            migrationBuilder.CreateIndex(
                name: "IX_Laboratories_OwnerId1",
                table: "Laboratories",
                column: "OwnerId1");

            migrationBuilder.CreateIndex(
                name: "IX_Laboratories_UpdatedBy",
                table: "Laboratories",
                column: "UpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_LaboratoryResult_CreatedBy",
                table: "LaboratoryResult",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_LaboratoryResult_DeletedBy",
                table: "LaboratoryResult",
                column: "DeletedBy");

            migrationBuilder.CreateIndex(
                name: "IX_LaboratoryResult_PersonId",
                table: "LaboratoryResult",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_LaboratoryResult_UpdatedBy",
                table: "LaboratoryResult",
                column: "UpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_LessonComments_CreatedBy",
                table: "LessonComments",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_LessonComments_DeletedBy",
                table: "LessonComments",
                column: "DeletedBy");

            migrationBuilder.CreateIndex(
                name: "IX_LessonComments_LessonId",
                table: "LessonComments",
                column: "LessonId");

            migrationBuilder.CreateIndex(
                name: "IX_LessonComments_UpdatedBy",
                table: "LessonComments",
                column: "UpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_LessonReplies_CreatedBy",
                table: "LessonReplies",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_LessonReplies_DeletedBy",
                table: "LessonReplies",
                column: "DeletedBy");

            migrationBuilder.CreateIndex(
                name: "IX_LessonReplies_LessonCommentId",
                table: "LessonReplies",
                column: "LessonCommentId");

            migrationBuilder.CreateIndex(
                name: "IX_LessonReplies_UpdatedBy",
                table: "LessonReplies",
                column: "UpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Lessons_CreatedBy",
                table: "Lessons",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Lessons_DeletedBy",
                table: "Lessons",
                column: "DeletedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Lessons_GroupId",
                table: "Lessons",
                column: "GroupId");

            migrationBuilder.CreateIndex(
                name: "IX_Lessons_UpdatedBy",
                table: "Lessons",
                column: "UpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_MaterialInAndOuts_CreatedBy",
                table: "MaterialInAndOuts",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_MaterialInAndOuts_DeletedBy",
                table: "MaterialInAndOuts",
                column: "DeletedBy");

            migrationBuilder.CreateIndex(
                name: "IX_MaterialInAndOuts_MaterialId",
                table: "MaterialInAndOuts",
                column: "MaterialId");

            migrationBuilder.CreateIndex(
                name: "IX_MaterialInAndOuts_UpdatedBy",
                table: "MaterialInAndOuts",
                column: "UpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_MaterialRequisitionDetails_CreatedBy",
                table: "MaterialRequisitionDetails",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_MaterialRequisitionDetails_DeletedBy",
                table: "MaterialRequisitionDetails",
                column: "DeletedBy");

            migrationBuilder.CreateIndex(
                name: "IX_MaterialRequisitionDetails_MaterialRequisitionId",
                table: "MaterialRequisitionDetails",
                column: "MaterialRequisitionId");

            migrationBuilder.CreateIndex(
                name: "IX_MaterialRequisitionDetails_UpdatedBy",
                table: "MaterialRequisitionDetails",
                column: "UpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_MaterialRequisitions_CreatedBy",
                table: "MaterialRequisitions",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_MaterialRequisitions_DeletedBy",
                table: "MaterialRequisitions",
                column: "DeletedBy");

            migrationBuilder.CreateIndex(
                name: "IX_MaterialRequisitions_RequisitorId",
                table: "MaterialRequisitions",
                column: "RequisitorId");

            migrationBuilder.CreateIndex(
                name: "IX_MaterialRequisitions_StatusId",
                table: "MaterialRequisitions",
                column: "StatusId");

            migrationBuilder.CreateIndex(
                name: "IX_MaterialRequisitions_UpdatedBy",
                table: "MaterialRequisitions",
                column: "UpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Materials_CreatedBy",
                table: "Materials",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Materials_DeletedBy",
                table: "Materials",
                column: "DeletedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Materials_UpdatedBy",
                table: "Materials",
                column: "UpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Measures_CreatedBy",
                table: "Measures",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Measures_DeletedBy",
                table: "Measures",
                column: "DeletedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Measures_UpdatedBy",
                table: "Measures",
                column: "UpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_MedicalCertificates_CreatedBy",
                table: "MedicalCertificates",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_MedicalCertificates_DeletedBy",
                table: "MedicalCertificates",
                column: "DeletedBy");

            migrationBuilder.CreateIndex(
                name: "IX_MedicalCertificates_PersonId",
                table: "MedicalCertificates",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_MedicalCertificates_UpdatedBy",
                table: "MedicalCertificates",
                column: "UpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_MemberTypes_CreatedBy",
                table: "MemberTypes",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_MemberTypes_DeletedBy",
                table: "MemberTypes",
                column: "DeletedBy");

            migrationBuilder.CreateIndex(
                name: "IX_MemberTypes_UpdatedBy",
                table: "MemberTypes",
                column: "UpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_MessageChats_CreatedBy",
                table: "MessageChats",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_MessageChats_DeletedBy",
                table: "MessageChats",
                column: "DeletedBy");

            migrationBuilder.CreateIndex(
                name: "IX_MessageChats_UpdatedBy",
                table: "MessageChats",
                column: "UpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_MessageChats_UserId",
                table: "MessageChats",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_MultiaxialHistories_CreatedBy",
                table: "MultiaxialHistories",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_MultiaxialHistories_DeletedBy",
                table: "MultiaxialHistories",
                column: "DeletedBy");

            migrationBuilder.CreateIndex(
                name: "IX_MultiaxialHistories_PersonId",
                table: "MultiaxialHistories",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_MultiaxialHistories_UpdatedBy",
                table: "MultiaxialHistories",
                column: "UpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Obstetrics_CreatedBy",
                table: "Obstetrics",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Obstetrics_DeletedBy",
                table: "Obstetrics",
                column: "DeletedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Obstetrics_PersonId",
                table: "Obstetrics",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_Obstetrics_UpdatedBy",
                table: "Obstetrics",
                column: "UpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_ObstetricVisits_CreatedBy",
                table: "ObstetricVisits",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_ObstetricVisits_DeletedBy",
                table: "ObstetricVisits",
                column: "DeletedBy");

            migrationBuilder.CreateIndex(
                name: "IX_ObstetricVisits_ObstetricId",
                table: "ObstetricVisits",
                column: "ObstetricId");

            migrationBuilder.CreateIndex(
                name: "IX_ObstetricVisits_UpdatedBy",
                table: "ObstetricVisits",
                column: "UpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Occupants_ClasseId",
                table: "Occupants",
                column: "ClasseId");

            migrationBuilder.CreateIndex(
                name: "IX_Occupants_PersonId",
                table: "Occupants",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_Occupants_PlaceId",
                table: "Occupants",
                column: "PlaceId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_CreatedBy",
                table: "OrderDetails",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_DeletedBy",
                table: "OrderDetails",
                column: "DeletedBy");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_OrderId",
                table: "OrderDetails",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_ProductId",
                table: "OrderDetails",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_UpdatedBy",
                table: "OrderDetails",
                column: "UpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_CreatedBy",
                table: "Orders",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_DeletedBy",
                table: "Orders",
                column: "DeletedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_PersonId",
                table: "Orders",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_UpdatedBy",
                table: "Orders",
                column: "UpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_PatientAllergies_AllergyId",
                table: "PatientAllergies",
                column: "AllergyId");

            migrationBuilder.CreateIndex(
                name: "IX_PatientAllergies_CreatedBy",
                table: "PatientAllergies",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_PatientAllergies_DeletedBy",
                table: "PatientAllergies",
                column: "DeletedBy");

            migrationBuilder.CreateIndex(
                name: "IX_PatientAllergies_PersonId",
                table: "PatientAllergies",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_PatientAllergies_UpdatedBy",
                table: "PatientAllergies",
                column: "UpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_PatientDiagnostics_CreatedBy",
                table: "PatientDiagnostics",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_PatientDiagnostics_DeletedBy",
                table: "PatientDiagnostics",
                column: "DeletedBy");

            migrationBuilder.CreateIndex(
                name: "IX_PatientDiagnostics_DiagnosticId",
                table: "PatientDiagnostics",
                column: "DiagnosticId");

            migrationBuilder.CreateIndex(
                name: "IX_PatientDiagnostics_PersonId",
                table: "PatientDiagnostics",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_PatientDiagnostics_UpdatedBy",
                table: "PatientDiagnostics",
                column: "UpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Patients_CreatedBy",
                table: "Patients",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Patients_DeletedBy",
                table: "Patients",
                column: "DeletedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Patients_PersonId",
                table: "Patients",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_Patients_UpdatedBy",
                table: "Patients",
                column: "UpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Pediatrics_CreatedBy",
                table: "Pediatrics",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Pediatrics_DeletedBy",
                table: "Pediatrics",
                column: "DeletedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Pediatrics_PersonId",
                table: "Pediatrics",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_Pediatrics_UpdatedBy",
                table: "Pediatrics",
                column: "UpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_PersonSpecialities_PersonId",
                table: "PersonSpecialities",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_PersonSpecialities_SpecialityId",
                table: "PersonSpecialities",
                column: "SpecialityId");

            migrationBuilder.CreateIndex(
                name: "IX_Places_CreatedBy",
                table: "Places",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Places_DeletedBy",
                table: "Places",
                column: "DeletedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Places_PersonId",
                table: "Places",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_Places_StatusId",
                table: "Places",
                column: "StatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Places_UpdatedBy",
                table: "Places",
                column: "UpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Places_ZoneId",
                table: "Places",
                column: "ZoneId");

            migrationBuilder.CreateIndex(
                name: "IX_Prices_CreatedBy",
                table: "Prices",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Prices_DeletedBy",
                table: "Prices",
                column: "DeletedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Prices_InsuranceId",
                table: "Prices",
                column: "InsuranceId");

            migrationBuilder.CreateIndex(
                name: "IX_Prices_ProductId",
                table: "Prices",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Prices_UpdatedBy",
                table: "Prices",
                column: "UpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Products_BrandId",
                table: "Products",
                column: "BrandId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_CreatedBy",
                table: "Products",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Products_DeletedBy",
                table: "Products",
                column: "DeletedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Products_MeasureId",
                table: "Products",
                column: "MeasureId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_ServiceTypeId",
                table: "Products",
                column: "ServiceTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_UpdatedBy",
                table: "Products",
                column: "UpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectMembers_MemberId",
                table: "ProjectMembers",
                column: "MemberId");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectMembers_ProjectId",
                table: "ProjectMembers",
                column: "ProjectId");

            migrationBuilder.CreateIndex(
                name: "IX_Projects_CreatedBy",
                table: "Projects",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Projects_DeletedBy",
                table: "Projects",
                column: "DeletedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Projects_UpdatedBy",
                table: "Projects",
                column: "UpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_PurchaseDetails_CreatedBy",
                table: "PurchaseDetails",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_PurchaseDetails_DeletedBy",
                table: "PurchaseDetails",
                column: "DeletedBy");

            migrationBuilder.CreateIndex(
                name: "IX_PurchaseDetails_ProductId",
                table: "PurchaseDetails",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_PurchaseDetails_PurchaseId",
                table: "PurchaseDetails",
                column: "PurchaseId");

            migrationBuilder.CreateIndex(
                name: "IX_PurchaseDetails_UpdatedBy",
                table: "PurchaseDetails",
                column: "UpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Purchases_CreatedBy",
                table: "Purchases",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Purchases_DeletedBy",
                table: "Purchases",
                column: "DeletedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Purchases_SupplierId",
                table: "Purchases",
                column: "SupplierId");

            migrationBuilder.CreateIndex(
                name: "IX_Purchases_UpdatedBy",
                table: "Purchases",
                column: "UpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_QuickNotes_CreatedBy",
                table: "QuickNotes",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_QuickNotes_DeletedBy",
                table: "QuickNotes",
                column: "DeletedBy");

            migrationBuilder.CreateIndex(
                name: "IX_QuickNotes_PersonId",
                table: "QuickNotes",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_QuickNotes_UpdatedBy",
                table: "QuickNotes",
                column: "UpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_QuizzChoises_CreatedBy",
                table: "QuizzChoises",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_QuizzChoises_DeletedBy",
                table: "QuizzChoises",
                column: "DeletedBy");

            migrationBuilder.CreateIndex(
                name: "IX_QuizzChoises_QuizzQuestionId",
                table: "QuizzChoises",
                column: "QuizzQuestionId");

            migrationBuilder.CreateIndex(
                name: "IX_QuizzChoises_UpdatedBy",
                table: "QuizzChoises",
                column: "UpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Quizzes_CreatedBy",
                table: "Quizzes",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Quizzes_DeletedBy",
                table: "Quizzes",
                column: "DeletedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Quizzes_GroupId",
                table: "Quizzes",
                column: "GroupId");

            migrationBuilder.CreateIndex(
                name: "IX_Quizzes_UpdatedBy",
                table: "Quizzes",
                column: "UpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_QuizzQuestions_CreatedBy",
                table: "QuizzQuestions",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_QuizzQuestions_DeletedBy",
                table: "QuizzQuestions",
                column: "DeletedBy");

            migrationBuilder.CreateIndex(
                name: "IX_QuizzQuestions_QuizzId",
                table: "QuizzQuestions",
                column: "QuizzId");

            migrationBuilder.CreateIndex(
                name: "IX_QuizzQuestions_UpdatedBy",
                table: "QuizzQuestions",
                column: "UpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_QuizzSubmitions_CreatedBy",
                table: "QuizzSubmitions",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_QuizzSubmitions_DeletedBy",
                table: "QuizzSubmitions",
                column: "DeletedBy");

            migrationBuilder.CreateIndex(
                name: "IX_QuizzSubmitions_QuizzId",
                table: "QuizzSubmitions",
                column: "QuizzId");

            migrationBuilder.CreateIndex(
                name: "IX_QuizzSubmitions_StudentId",
                table: "QuizzSubmitions",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_QuizzSubmitions_UpdatedBy",
                table: "QuizzSubmitions",
                column: "UpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Recipes_CreatedBy",
                table: "Recipes",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Recipes_DeletedBy",
                table: "Recipes",
                column: "DeletedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Recipes_PersonId",
                table: "Recipes",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_Recipes_UpdatedBy",
                table: "Recipes",
                column: "UpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_RelatedPeople_RelatedPersonId",
                table: "RelatedPeople",
                column: "RelatedPersonId");

            migrationBuilder.CreateIndex(
                name: "IX_RelatedPeople_RelationTypeId",
                table: "RelatedPeople",
                column: "RelationTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_RelatedPeople_RelationedPersonId",
                table: "RelatedPeople",
                column: "RelationedPersonId");

            migrationBuilder.CreateIndex(
                name: "IX_SaleDetails_CreatedBy",
                table: "SaleDetails",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_SaleDetails_DeletedBy",
                table: "SaleDetails",
                column: "DeletedBy");

            migrationBuilder.CreateIndex(
                name: "IX_SaleDetails_ProductId",
                table: "SaleDetails",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_SaleDetails_SaleId",
                table: "SaleDetails",
                column: "SaleId");

            migrationBuilder.CreateIndex(
                name: "IX_SaleDetails_UpdatedBy",
                table: "SaleDetails",
                column: "UpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_SaleLiquidationDetails_CreatedBy",
                table: "SaleLiquidationDetails",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_SaleLiquidationDetails_DeletedBy",
                table: "SaleLiquidationDetails",
                column: "DeletedBy");

            migrationBuilder.CreateIndex(
                name: "IX_SaleLiquidationDetails_SaleId",
                table: "SaleLiquidationDetails",
                column: "SaleId");

            migrationBuilder.CreateIndex(
                name: "IX_SaleLiquidationDetails_UpdatedBy",
                table: "SaleLiquidationDetails",
                column: "UpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_SaleLiquidations_CreatedBy",
                table: "SaleLiquidations",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_SaleLiquidations_DeletedBy",
                table: "SaleLiquidations",
                column: "DeletedBy");

            migrationBuilder.CreateIndex(
                name: "IX_SaleLiquidations_InsuranceId",
                table: "SaleLiquidations",
                column: "InsuranceId");

            migrationBuilder.CreateIndex(
                name: "IX_SaleLiquidations_UpdatedBy",
                table: "SaleLiquidations",
                column: "UpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Sales_CategoryId",
                table: "Sales",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Sales_CreatedBy",
                table: "Sales",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Sales_DeletedBy",
                table: "Sales",
                column: "DeletedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Sales_InsuranceId",
                table: "Sales",
                column: "InsuranceId");

            migrationBuilder.CreateIndex(
                name: "IX_Sales_PaymentTypeId",
                table: "Sales",
                column: "PaymentTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Sales_PersonId",
                table: "Sales",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_Sales_StatusId",
                table: "Sales",
                column: "StatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Sales_UpdatedBy",
                table: "Sales",
                column: "UpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_SalesAccounts_CreatedBy",
                table: "SalesAccounts",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_SalesAccounts_DeletedBy",
                table: "SalesAccounts",
                column: "DeletedBy");

            migrationBuilder.CreateIndex(
                name: "IX_SalesAccounts_SalesId",
                table: "SalesAccounts",
                column: "SalesId");

            migrationBuilder.CreateIndex(
                name: "IX_SalesAccounts_UpdatedBy",
                table: "SalesAccounts",
                column: "UpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Schedules_CreatedBy",
                table: "Schedules",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Schedules_DeletedBy",
                table: "Schedules",
                column: "DeletedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Schedules_GroupId",
                table: "Schedules",
                column: "GroupId");

            migrationBuilder.CreateIndex(
                name: "IX_Schedules_PlaceId",
                table: "Schedules",
                column: "PlaceId");

            migrationBuilder.CreateIndex(
                name: "IX_Schedules_ScheduleFormatId",
                table: "Schedules",
                column: "ScheduleFormatId");

            migrationBuilder.CreateIndex(
                name: "IX_Schedules_UpdatedBy",
                table: "Schedules",
                column: "UpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Schools_CreatedBy",
                table: "Schools",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Schools_DeletedBy",
                table: "Schools",
                column: "DeletedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Schools_UpdatedBy",
                table: "Schools",
                column: "UpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_SignatureMembers_MemberId",
                table: "SignatureMembers",
                column: "MemberId");

            migrationBuilder.CreateIndex(
                name: "IX_SignatureMembers_SignatureId",
                table: "SignatureMembers",
                column: "SignatureId");

            migrationBuilder.CreateIndex(
                name: "IX_Signatures_CreatedBy",
                table: "Signatures",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Signatures_DeletedBy",
                table: "Signatures",
                column: "DeletedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Signatures_ProjectId",
                table: "Signatures",
                column: "ProjectId");

            migrationBuilder.CreateIndex(
                name: "IX_Signatures_UpdatedBy",
                table: "Signatures",
                column: "UpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Specialities_CreatedBy",
                table: "Specialities",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Specialities_DeletedBy",
                table: "Specialities",
                column: "DeletedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Specialities_UpdatedBy",
                table: "Specialities",
                column: "UpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Students_CreatedBy",
                table: "Students",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Students_DeletedBy",
                table: "Students",
                column: "DeletedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Students_GroupId",
                table: "Students",
                column: "GroupId");

            migrationBuilder.CreateIndex(
                name: "IX_Students_PersonId",
                table: "Students",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_Students_UpdatedBy",
                table: "Students",
                column: "UpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Subjects_CourseId",
                table: "Subjects",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_Subjects_CreatedBy",
                table: "Subjects",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Subjects_DeletedBy",
                table: "Subjects",
                column: "DeletedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Subjects_SpecialityId",
                table: "Subjects",
                column: "SpecialityId");

            migrationBuilder.CreateIndex(
                name: "IX_Subjects_SubjectModalityId",
                table: "Subjects",
                column: "SubjectModalityId");

            migrationBuilder.CreateIndex(
                name: "IX_Subjects_UpdatedBy",
                table: "Subjects",
                column: "UpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Submissions_AssignmentId",
                table: "Submissions",
                column: "AssignmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Submissions_CreatedBy",
                table: "Submissions",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Submissions_DeletedBy",
                table: "Submissions",
                column: "DeletedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Submissions_StudentId",
                table: "Submissions",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_Submissions_UpdatedBy",
                table: "Submissions",
                column: "UpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Suppliers_CreatedBy",
                table: "Suppliers",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Suppliers_DeletedBy",
                table: "Suppliers",
                column: "DeletedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Suppliers_UpdatedBy",
                table: "Suppliers",
                column: "UpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Surgeries_CreatedBy",
                table: "Surgeries",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Surgeries_DeletedBy",
                table: "Surgeries",
                column: "DeletedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Surgeries_PersonId",
                table: "Surgeries",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_Surgeries_UpdatedBy",
                table: "Surgeries",
                column: "UpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_UploadComments_CreatedBy",
                table: "UploadComments",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_UploadComments_DeletedBy",
                table: "UploadComments",
                column: "DeletedBy");

            migrationBuilder.CreateIndex(
                name: "IX_UploadComments_UpdatedBy",
                table: "UploadComments",
                column: "UpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_UploadComments_UploadId",
                table: "UploadComments",
                column: "UploadId");

            migrationBuilder.CreateIndex(
                name: "IX_Uploads_CreatedBy",
                table: "Uploads",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Uploads_DeletedBy",
                table: "Uploads",
                column: "DeletedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Uploads_GroupId",
                table: "Uploads",
                column: "GroupId");

            migrationBuilder.CreateIndex(
                name: "IX_Uploads_StudentId",
                table: "Uploads",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_Uploads_UpdatedBy",
                table: "Uploads",
                column: "UpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_UserEmailSettings_CreatedBy",
                table: "UserEmailSettings",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_UserEmailSettings_DeletedBy",
                table: "UserEmailSettings",
                column: "DeletedBy");

            migrationBuilder.CreateIndex(
                name: "IX_UserEmailSettings_UpdatedBy",
                table: "UserEmailSettings",
                column: "UpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_UserEmailSettings_UserId1",
                table: "UserEmailSettings",
                column: "UserId1");

            migrationBuilder.CreateIndex(
                name: "IX_Visits_CreatedBy",
                table: "Visits",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Visits_DeletedBy",
                table: "Visits",
                column: "DeletedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Visits_PersonId",
                table: "Visits",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_Visits_UpdatedBy",
                table: "Visits",
                column: "UpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Zones_CreatedBy",
                table: "Zones",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Zones_DeletedBy",
                table: "Zones",
                column: "DeletedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Zones_ShopId",
                table: "Zones",
                column: "ShopId");

            migrationBuilder.CreateIndex(
                name: "IX_Zones_UpdatedBy",
                table: "Zones",
                column: "UpdatedBy");

            migrationBuilder.AddForeignKey(
                name: "FK_Images_Activities_ActivityId",
                table: "Images",
                column: "ActivityId",
                principalTable: "Activities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Images_Benefits_BenefitId",
                table: "Images",
                column: "BenefitId",
                principalTable: "Benefits",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Images_Classes_ClasseId",
                table: "Images",
                column: "ClasseId",
                principalTable: "Classes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Images_ColaboratorDonations_ColaboratorDonationId",
                table: "Images",
                column: "ColaboratorDonationId",
                principalTable: "ColaboratorDonations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Images_Foods_FoodId",
                table: "Images",
                column: "FoodId",
                principalTable: "Foods",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Images_Projects_ProjectId",
                table: "Images",
                column: "ProjectId",
                principalTable: "Projects",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Images_Signatures_SignatureId",
                table: "Images",
                column: "SignatureId",
                principalTable: "Signatures",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Payments_Sales_SaleId",
                table: "Payments",
                column: "SaleId",
                principalTable: "Sales",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_People_BloodTypes_BloodTypeId",
                table: "People",
                column: "BloodTypeId",
                principalTable: "BloodTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_People_Insurances_InsuranceId",
                table: "People",
                column: "InsuranceId",
                principalTable: "Insurances",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_People_MemberTypes_MemberTypeId",
                table: "People",
                column: "MemberTypeId",
                principalTable: "MemberTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_People_Specialities_SpecialityId",
                table: "People",
                column: "SpecialityId",
                principalTable: "Specialities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
