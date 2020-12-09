using Microsoft.EntityFrameworkCore.Migrations;

namespace Mersy.Infraestructure.Migrations
{
    public partial class InitialData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.Sql(@"

 
 SET IDENTITY_INSERT [dbo].[OwnerTypes] ON 
GO
INSERT [dbo].[OwnerTypes] ([Id], [Name]) VALUES (1, N'Empresa')
GO
INSERT [dbo].[OwnerTypes] ([Id], [Name]) VALUES (2, N'Persona')
GO
SET IDENTITY_INSERT [dbo].[OwnerTypes] OFF
GO
go
SET IDENTITY_INSERT [dbo].[Owners] ON 
GO
INSERT [dbo].[Owners] ([Id], [Name], [Rnc], [Code], [LastName], [Email], [WebAddress], [Address], [Imagen], [Tel], [PrefixExp], [PrefixFact], [PrefixOrder], [StartDate], [PrefixNcf], [SeqNcf], [PrefixFinalFact], [NcfEnds], [SeqFact], [Header1], [Header2], [Header3], [Footer1], [Footer2], [Footer3], [UsersAvailable], [MegabytesAvailable], [RegitersAvailable], [PlanActiveUntil], [OwnerTypeId], [IsActive], UserNameInReport, SeqNcfGub) VALUES (1, N'Tomas Aquino', NULL, N'Tomas Aquino', N' Mendes', N'mersyrd@gmail.com', N'mersyrd.com', NULL, N'~/images/Logos/773d0a0d-7827-409b-89ef-bae3ebbb92f2.jpeg', N'8492077714', N'MED', N'FAC', N'ORD', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, N'Tels: (849) 207-7714, (829) 349-5083', NULL, 5, 5, 500, NULL, NULL, 1, 0,0)
GO
INSERT [dbo].[Owners] ([Id], [Name], [Rnc], [Code], [LastName], [Email], [WebAddress], [Address], [Imagen], [Tel], [PrefixExp], [PrefixFact], [PrefixOrder], [StartDate], [PrefixNcf], [SeqNcf], [PrefixFinalFact], [NcfEnds], [SeqFact], [Header1], [Header2], [Header3], [Footer1], [Footer2], [Footer3], [UsersAvailable], [MegabytesAvailable], [RegitersAvailable], [PlanActiveUntil], [OwnerTypeId], [IsActive], UserNameInReport, SeqNcfGub) VALUES (2, N'Yajaira Olivarez', NULL, N'Yajaira Olivare', N' ', N'mersycore@gmail.com', N'mersycore.com', NULL, N'~/images/Capture 1.PNG', N'8293495083', N'MED', N'FAC', N'ORD', NULL, NULL, NULL, NULL, NULL, NULL, N'Yajaira Olivarez de Mendez', N'Ginecologa-Obstetra, Colposcopista Ginecoestetica', NULL, N'Centro Policlinico Nacional', NULL, NULL, 0, 0, 0, NULL, NULL, 1,0,0)
GO
INSERT [dbo].[Owners] ([Id], [Name], [Rnc], [Code], [LastName], [Email], [WebAddress], [Address], [Imagen], [Tel], [PrefixExp], [PrefixFact], [PrefixOrder], [StartDate], [PrefixNcf], [SeqNcf], [PrefixFinalFact], [NcfEnds], [SeqFact], [Header1], [Header2], [Header3], [Footer1], [Footer2], [Footer3], [UsersAvailable], [MegabytesAvailable], [RegitersAvailable], [PlanActiveUntil], [OwnerTypeId], [IsActive], UserNameInReport, SeqNcfGub) VALUES (4, N'ccc', NULL, NULL, N'cccc', N'mersyrd@gmail.com', NULL, NULL, NULL, N'3', NULL, NULL, NULL, CAST(N'2020-07-02T17:31:07.1487748' AS DateTime2), NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 0, 0, 0, NULL, NULL, 0,0,0)
GO
SET IDENTITY_INSERT [dbo].[Owners] OFF
go
SET IDENTITY_INSERT [dbo].[Ocupations] ON 
GO
INSERT [dbo].[Ocupations] ([Id], [Name]) VALUES (1, N'Licenciado(a)')
GO
INSERT [dbo].[Ocupations] ([Id], [Name]) VALUES (2, N'Operario(a)')
GO
INSERT [dbo].[Ocupations] ([Id], [Name]) VALUES (3, N'Maestro(a)')
GO
INSERT [dbo].[Ocupations] ([Id], [Name]) VALUES (4, N'Estilista')
GO
INSERT [dbo].[Ocupations] ([Id], [Name]) VALUES (5, N'Jubilado(a)/Pensionado(a)')
GO
INSERT [dbo].[Ocupations] ([Id], [Name]) VALUES (6, N'Secretario(a)')
GO
INSERT [dbo].[Ocupations] ([Id], [Name]) VALUES (7, N'Ebanista')
GO
INSERT [dbo].[Ocupations] ([Id], [Name]) VALUES (8, N'Chiripero(a)')
GO
INSERT [dbo].[Ocupations] ([Id], [Name]) VALUES (9, N'Administrador(a)')
GO
INSERT [dbo].[Ocupations] ([Id], [Name]) VALUES (10, N'Modista')
GO
INSERT [dbo].[Ocupations] ([Id], [Name]) VALUES (11, N'Mecanico')
GO
INSERT [dbo].[Ocupations] ([Id], [Name]) VALUES (12, N'Programador(a)')
GO
INSERT [dbo].[Ocupations] ([Id], [Name]) VALUES (13, N'Abogado(a)')
GO
INSERT [dbo].[Ocupations] ([Id], [Name]) VALUES (14, N'Cominicador(a)')
GO
INSERT [dbo].[Ocupations] ([Id], [Name]) VALUES (15, N'Enfermero(a)')
GO
INSERT [dbo].[Ocupations] ([Id], [Name]) VALUES (16, N'Carpintero')
GO
INSERT [dbo].[Ocupations] ([Id], [Name]) VALUES (17, N'Ingeniero(a)')
GO
INSERT [dbo].[Ocupations] ([Id], [Name]) VALUES (18, N'Albañil')
GO
INSERT [dbo].[Ocupations] ([Id], [Name]) VALUES (19, N'Chofer')
GO
INSERT [dbo].[Ocupations] ([Id], [Name]) VALUES (20, N'Empleado(a)')
GO
INSERT [dbo].[Ocupations] ([Id], [Name]) VALUES (21, N'_N/A')
GO
INSERT [dbo].[Ocupations] ([Id], [Name]) VALUES (22, N'Otr@')
GO
INSERT [dbo].[Ocupations] ([Id], [Name]) VALUES (23, N'Vendedor(a)')
GO
INSERT [dbo].[Ocupations] ([Id], [Name]) VALUES (24, N'Independiente')
GO
INSERT [dbo].[Ocupations] ([Id], [Name]) VALUES (25, N'Ama de Casa')
GO
INSERT [dbo].[Ocupations] ([Id], [Name]) VALUES (26, N'Pintor(a)')
GO
INSERT [dbo].[Ocupations] ([Id], [Name]) VALUES (27, N'Operario(a)')
GO
INSERT [dbo].[Ocupations] ([Id], [Name]) VALUES (28, N'Tecnico')
GO
INSERT [dbo].[Ocupations] ([Id], [Name]) VALUES (29, N'Que haceres del hogar')
GO
INSERT [dbo].[Ocupations] ([Id], [Name]) VALUES (30, N'Estudiante')
GO
INSERT [dbo].[Ocupations] ([Id], [Name]) VALUES (31, N'Quehaceres Domesticos')
GO
INSERT [dbo].[Ocupations] ([Id], [Name]) VALUES (32, N'Empleado(a) Privado')
GO
INSERT [dbo].[Ocupations] ([Id], [Name]) VALUES (33, N'Agricultor(a)')
GO
INSERT [dbo].[Ocupations] ([Id], [Name]) VALUES (34, N'Comerciante')
GO
INSERT [dbo].[Ocupations] ([Id], [Name]) VALUES (35, N'Politico(a)')
GO
INSERT [dbo].[Ocupations] ([Id], [Name]) VALUES (36, N'Doctor(a)')
GO
INSERT [dbo].[Ocupations] ([Id], [Name]) VALUES (37, N'Empleado(a) Publico')
GO
INSERT [dbo].[Ocupations] ([Id], [Name]) VALUES (38, N'Trabajador(a) Independiente')
GO
INSERT [dbo].[Ocupations] ([Id], [Name]) VALUES (39, N'Otras')
GO
SET IDENTITY_INSERT [dbo].[Ocupations] OFF
GO
SET IDENTITY_INSERT [dbo].[Origins] ON 
GO
INSERT [dbo].[Origins] ([Id], [Name], [Code], [Simbol], [Description]) VALUES (1, N'Credito', N'1', NULL, N'Ingreso/Ahorro/Activo')
GO
INSERT [dbo].[Origins] ([Id], [Name], [Code], [Simbol], [Description]) VALUES (2, N'Debito', N'-1', NULL, N'Gasto/Prestamo/Pasivo')
GO
SET IDENTITY_INSERT [dbo].[Origins] OFF
go

SET IDENTITY_INSERT [dbo].[PaymentTypes] ON 
GO
INSERT [dbo].[PaymentTypes] ([Id], [Name], [Code]) VALUES (1, N'Online', N'On')
GO
INSERT [dbo].[PaymentTypes] ([Id], [Name], [Code]) VALUES (2, N'Orden de Compra', N'OC')
GO
INSERT [dbo].[PaymentTypes] ([Id], [Name], [Code]) VALUES (3, N'Bonos', N'Bn')
GO
INSERT [dbo].[PaymentTypes] ([Id], [Name], [Code]) VALUES (4, N'Trasnferencia Electronica', N'TE')
GO
INSERT [dbo].[PaymentTypes] ([Id], [Name], [Code]) VALUES (5, N'Cheque', N'Ch')
GO
INSERT [dbo].[PaymentTypes] ([Id], [Name], [Code]) VALUES (6, N'Tarjeta de Credito', N'TC')
GO
INSERT [dbo].[PaymentTypes] ([Id], [Name], [Code]) VALUES (7, N'Credito', N'CR')
GO
INSERT [dbo].[PaymentTypes] ([Id], [Name], [Code]) VALUES (8, N'Efectivo', N'Ef')
GO
SET IDENTITY_INSERT [dbo].[PaymentTypes] OFF
go

SET IDENTITY_INSERT [dbo].[Periodicities] ON 
GO
INSERT [dbo].[Periodicities] ([Id], [Name], [Code]) VALUES (1, N'Diario', N'D')
GO
INSERT [dbo].[Periodicities] ([Id], [Name], [Code]) VALUES (2, N'Semanal', N'W')
GO
INSERT [dbo].[Periodicities] ([Id], [Name], [Code]) VALUES (3, N'Quincenal', N'Q')
GO
INSERT [dbo].[Periodicities] ([Id], [Name], [Code]) VALUES (4, N'Mensual', N'M')
GO
INSERT [dbo].[Periodicities] ([Id], [Name], [Code]) VALUES (5, N'Bimensual', N'B')
GO
INSERT [dbo].[Periodicities] ([Id], [Name], [Code]) VALUES (6, N'Trimestral', N'T')
GO
INSERT [dbo].[Periodicities] ([Id], [Name], [Code]) VALUES (7, N'Cuatrimestral', N'C')
GO
INSERT [dbo].[Periodicities] ([Id], [Name], [Code]) VALUES (8, N'Semestral', N'S')
GO
INSERT [dbo].[Periodicities] ([Id], [Name], [Code]) VALUES (9, N'Anual', N'A')
GO
INSERT [dbo].[Periodicities] ([Id], [Name], [Code]) VALUES (10, N'Irregular', N'I')
GO
INSERT [dbo].[Periodicities] ([Id], [Name], [Code]) VALUES (11, N'Unico', N'U')
GO
INSERT [dbo].[Periodicities] ([Id], [Name], [Code]) VALUES (12, N'_Ninguna', N'N')
GO
SET IDENTITY_INSERT [dbo].[Periodicities] OFF
go

INSERT [dbo].[AspNetRoles] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'160e2ca4-d166-4bb4-a7f0-c2e038d6abbf', N'User', N'USER', N'640792c1-abeb-4361-879d-a4a70de326db')
GO
INSERT [dbo].[AspNetRoles] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'326ec5da-8e43-40e2-a5d4-38ff913eb41d', N'Teacher', N'TEACHER', N'189732a8-c8d3-4816-9182-aecba6f08730')
GO
INSERT [dbo].[AspNetRoles] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'3ad0ee1b-2f93-4535-9940-5b318f407c48', N'Doctor', N'DOCTOR', N'3064dd0d-e483-48e9-b596-b7fb9364d2a7')
GO
INSERT [dbo].[AspNetRoles] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'47a091fe-9535-45f1-bc20-de8cb66acadc', N'Supervisor', N'SUPERVISOR', N'c9a720c8-f94a-48a0-94fd-f6c8a0ee5c0f')
GO
INSERT [dbo].[AspNetRoles] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'69a618c6-64d2-41d2-af6e-a1cd008bfbd5', N'Employee', N'EMPLOYEE', N'8ba6d758-4236-45e7-927f-3752f479b5c4')
GO
INSERT [dbo].[AspNetRoles] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'7ce23cee-8438-4834-8cd4-ed3b2ce7f690', N'Patient', N'PATIENT', N'36b4ac72-9543-401d-9a15-fb48c4eb3d84')
GO
INSERT [dbo].[AspNetRoles] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'89a56a62-aef8-4d14-9dd5-59ff01ead8b1', N'Student', N'STUDENT', N'ef45623a-90c9-476c-9700-32c0dce2156b')
GO
INSERT [dbo].[AspNetRoles] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'8fc0bd77-db4b-4161-94a7-7e5bfa55fd69', N'SuperUser', N'SUPERUSER', N'a415eb88-df06-40e1-a059-b60a5fdda1ca')
GO
INSERT [dbo].[AspNetRoles] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'ac82bb3b-aef7-4a22-b76a-d0453bcb2bff', N'Root', N'ROOT', N'c072d716-1683-4f3e-9387-e1e9b8c5de71')
GO
INSERT [dbo].[AspNetRoles] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'ce7b0eb1-57ee-439d-9acf-6934c8b28a4e', N'Admin', N'ADMIN', N'76edb7ca-07d6-416e-bfdf-ac399c9ca465')
GO


INSERT [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount], [Name], [Lastname], [Rnc], [Address], [OwnerId],Comission,IsExternal) VALUES (N'127beb63-74c2-4fef-9e28-6edcb2605a84', N'yolivarez@hotmail.es', N'YOLIVAREZ@HOTMAIL.ES', N'yolivarez@hotmail.es', N'YOLIVAREZ@HOTMAIL.ES', 1, N'AQAAAAEAACcQAAAAEHSu9RnYrJdQhqxAVYguQR/0L/9oZhw32atAVsgy9iuwYX8cFaKTTcmyXwbJq7exrw==', N'SVRUYOXRGPUHPXYNCLN4PBZIK3OW5DTP', N'a655ec3e-78f7-43aa-b051-b401f502afa0', NULL, 0, 0, NULL, 1, 0, N'Yahaira', N'Olivares', NULL, NULL, 2, 5, 0)
GO
INSERT [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount], [Name], [Lastname], [Rnc], [Address], [OwnerId],Comission,IsExternal)  VALUES (N'175a6b21-ecd1-4ed2-8875-49ff60dd6414', N'owner01@mersyrd.com', N'OWNER01@MERSYRD.COM', N'owner01@mersyrd.com', N'OWNER01@MERSYRD.COM', 1, N'AQAAAAEAACcQAAAAEEAFudfQZEWVWHvEDLUrloZQtqHHfRhf0uCJJnoLkZM5ikjGxLWd2LqGwLwr7ecTTQ==', N'7R6LYXIQW343FJACWQHZITVWRFSGO5LP', N'6e4f3336-43ad-41fc-b812-341af50d9ca0', NULL, 0, 0, NULL, 1, 0, N'Mersy', N'RD', NULL, NULL, 1, 5, 0)
GO
INSERT [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount], [Name], [Lastname], [Rnc], [Address], [OwnerId],Comission,IsExternal) VALUES (N'225439b4-4c3a-4299-990e-72b72b4875c5', N'mersyrd@gmail.com', N'MERSYRD@GMAIL.COM', N'mersyrd@gmail.com', N'MERSYRD@GMAIL.COM', 1, N'AQAAAAEAACcQAAAAEDYFi8F/8BzywkT2PwyT6MYm98GcgmXwHP3MU4uNuwWB2wpcW4zuf6Sev6mL6ND6Wg==', N'EJ7TJFRSIKYDJD76RRFJ2G2TSSYMGBRU', N'de3310ad-765f-400f-b0b4-371644918035', N'849 207 7714', 0, 0, NULL, 1, 0, N'Mersy', N'RD', NULL, NULL, 1, 5, 0)
GO
INSERT [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount], [Name], [Lastname], [Rnc], [Address], [OwnerId],Comission,IsExternal) VALUES (N'3417c47c-c25d-4888-a094-6751c431bea2', N'3e6acefe-3d12-498a-ba2f-238ea709be4b@mersyrd.com', N'3E6ACEFE-3D12-498A-BA2F-238EA709BE4B@MERSYRD.COM', N'3e6acefe-3d12-498a-ba2f-238ea709be4b@mersyrd.com', N'3E6ACEFE-3D12-498A-BA2F-238EA709BE4B@MERSYRD.COM', 1, N'AQAAAAEAACcQAAAAEIHxJa8GDOXY0BCkoCi1cgCo7lOcrBlwjMv5ZoK1RkkG1EKpyRGN0bbhNp/dx9F3RA==', N'AATLYHFET3BJTVMETM37QHLNVV27ZEF3', N'cc4ade44-a1b6-4c6c-9540-08de231b2310', NULL, 0, 0, NULL, 1, 0, N'Paciente de Prueba', N'Para Probar', NULL, NULL, 1, 5, 0)
GO
INSERT [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount], [Name], [Lastname], [Rnc], [Address], [OwnerId],Comission,IsExternal) VALUES (N'3f9bca09-60eb-4a21-8128-0662d970a8c8', N'mersycore@gmail.com', N'MERSYCORE@GMAIL.COM', N'mersycore@gmail.com', N'MERSYCORE@GMAIL.COM', 1, N'AQAAAAEAACcQAAAAEKRjbwFu8BgKtY+yFlTqpIzWXLVfupkdw58SthyQSpK59eVleOLizbtLt++ON/MvHw==', N'4TXJFRJDSW32TYNRIK5SGC4CZK7FPJWP', N'0f63e3d8-4730-49ee-a745-a91ea2b16371', N'wwww', 0, 0, NULL, 1, 0, N'Mersy', N'Core', NULL, NULL, 2, 5, 0)
GO
INSERT [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount], [Name], [Lastname], [Rnc], [Address], [OwnerId],Comission,IsExternal) VALUES (N'8f28e0bb-fab9-4fb7-a4ae-2a5e2ab17b6b', N'sgrysoft@gmail.com', N'SGRYSOFT@GMAIL.COM', N'sgrysoft@gmail.com', N'SGRYSOFT@GMAIL.COM', 1, N'AQAAAAEAACcQAAAAEIyWaIh1BjDN7mcicEvjOSzy28mfhccUAZcyHbxjgjfnoXbzsRT7vFNzapK5ndz1OA==', N'MEJLR2BKQKKXXBGUVZT7RDRQOSTPP4JV', N'03d2b768-9938-416d-9437-a27c46e4e980', NULL, 0, 0, NULL, 1, 0, N'Starling', N'Germosen', NULL, NULL, 1, 5, 0)
GO
INSERT [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount], [Name], [Lastname], [Rnc], [Address], [OwnerId],Comission,IsExternal) VALUES (N'beba71ef-5894-4ce1-9fb0-8bd1483d1908', N'tomasaquinomf@hotmail.com', N'TOMASAQUINOMF@HOTMAIL.COM', N'tomasaquinomf@hotmail.com', N'TOMASAQUINOMF@HOTMAIL.COM', 1, N'AQAAAAEAACcQAAAAEGqVLei93JhEX8Qj1MMw/X773oqfwzLgss/vdKp56LnRrfysFEe7l9qYRKKP770oCw==', N'5BUWPRM6NZXZE7B4MOIUWVEJ3YRIPHIH', N'f07b01c7-004c-4b36-b460-1595c470cdc5', NULL, 0, 0, NULL, 1, 0, N'Tomas', N'Aquino', NULL, NULL, 1, 5, 0)
GO
INSERT [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount], [Name], [Lastname], [Rnc], [Address], [OwnerId],Comission,IsExternal) VALUES (N'cbe2581e-7044-462a-8560-7490d68fd739', N'owner02@mersyrd.com', N'OWNER02@MERSYRD.COM', N'owner02@mersyrd.com', N'OWNER02@MERSYRD.COM', 1, N'AQAAAAEAACcQAAAAEOMqTJv3AYhexAbkkfTyAFBkQEFxWJenNiaWiF3HvMWzLFVv/GCtqYgW7bdBsyIZpw==', N'NI6HEZYETZOS54OIPQF3F3275QEJRNFW', N'ece401e4-b171-4b23-b92a-ef4489f9a9ed', NULL, 0, 0, NULL, 1, 0, N'Owner 02', N'02', NULL, NULL, 2, 5, 0)
GO


 SET IDENTITY_INSERT [dbo].[AspNetUserClaims] ON 
GO
INSERT [dbo].[AspNetUserClaims] ([Id], [UserId], [ClaimType], [ClaimValue]) VALUES (1, N'225439b4-4c3a-4299-990e-72b72b4875c5', N'OwnerId', N'1')
GO
INSERT [dbo].[AspNetUserClaims] ([Id], [UserId], [ClaimType], [ClaimValue]) VALUES (2, N'3f9bca09-60eb-4a21-8128-0662d970a8c8', N'OwnerId', N'2')
GO
INSERT [dbo].[AspNetUserClaims] ([Id], [UserId], [ClaimType], [ClaimValue]) VALUES (3, N'175a6b21-ecd1-4ed2-8875-49ff60dd6414', N'OwnerId', N'1')
GO
INSERT [dbo].[AspNetUserClaims] ([Id], [UserId], [ClaimType], [ClaimValue]) VALUES (4, N'beba71ef-5894-4ce1-9fb0-8bd1483d1908', N'OwnerId', N'1')
GO
INSERT [dbo].[AspNetUserClaims] ([Id], [UserId], [ClaimType], [ClaimValue]) VALUES (5, N'3417c47c-c25d-4888-a094-6751c431bea2', N'OwnerId', N'1')
GO
INSERT [dbo].[AspNetUserClaims] ([Id], [UserId], [ClaimType], [ClaimValue]) VALUES (6, N'cbe2581e-7044-462a-8560-7490d68fd739', N'OwnerId', N'2')
GO
INSERT [dbo].[AspNetUserClaims] ([Id], [UserId], [ClaimType], [ClaimValue]) VALUES (7, N'127beb63-74c2-4fef-9e28-6edcb2605a84', N'OwnerId', N'2')
GO
INSERT [dbo].[AspNetUserClaims] ([Id], [UserId], [ClaimType], [ClaimValue]) VALUES (9, N'8f28e0bb-fab9-4fb7-a4ae-2a5e2ab17b6b', N'OwnerId', N'1')
GO
SET IDENTITY_INSERT [dbo].[AspNetUserClaims] OFF
go
 


GO
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'127beb63-74c2-4fef-9e28-6edcb2605a84', N'160e2ca4-d166-4bb4-a7f0-c2e038d6abbf')
GO
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'175a6b21-ecd1-4ed2-8875-49ff60dd6414', N'160e2ca4-d166-4bb4-a7f0-c2e038d6abbf')
GO
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'3417c47c-c25d-4888-a094-6751c431bea2', N'160e2ca4-d166-4bb4-a7f0-c2e038d6abbf')
GO
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'8f28e0bb-fab9-4fb7-a4ae-2a5e2ab17b6b', N'160e2ca4-d166-4bb4-a7f0-c2e038d6abbf')
GO
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'beba71ef-5894-4ce1-9fb0-8bd1483d1908', N'160e2ca4-d166-4bb4-a7f0-c2e038d6abbf')
GO
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'cbe2581e-7044-462a-8560-7490d68fd739', N'160e2ca4-d166-4bb4-a7f0-c2e038d6abbf')
GO
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'175a6b21-ecd1-4ed2-8875-49ff60dd6414', N'326ec5da-8e43-40e2-a5d4-38ff913eb41d')
GO
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'8f28e0bb-fab9-4fb7-a4ae-2a5e2ab17b6b', N'326ec5da-8e43-40e2-a5d4-38ff913eb41d')
GO
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'beba71ef-5894-4ce1-9fb0-8bd1483d1908', N'326ec5da-8e43-40e2-a5d4-38ff913eb41d')
GO
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'175a6b21-ecd1-4ed2-8875-49ff60dd6414', N'3ad0ee1b-2f93-4535-9940-5b318f407c48')
GO
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'8f28e0bb-fab9-4fb7-a4ae-2a5e2ab17b6b', N'3ad0ee1b-2f93-4535-9940-5b318f407c48')
GO
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'beba71ef-5894-4ce1-9fb0-8bd1483d1908', N'3ad0ee1b-2f93-4535-9940-5b318f407c48')
GO
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'127beb63-74c2-4fef-9e28-6edcb2605a84', N'69a618c6-64d2-41d2-af6e-a1cd008bfbd5')
GO
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'175a6b21-ecd1-4ed2-8875-49ff60dd6414', N'69a618c6-64d2-41d2-af6e-a1cd008bfbd5')
GO
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'8f28e0bb-fab9-4fb7-a4ae-2a5e2ab17b6b', N'69a618c6-64d2-41d2-af6e-a1cd008bfbd5')
GO
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'beba71ef-5894-4ce1-9fb0-8bd1483d1908', N'69a618c6-64d2-41d2-af6e-a1cd008bfbd5')
GO
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'cbe2581e-7044-462a-8560-7490d68fd739', N'69a618c6-64d2-41d2-af6e-a1cd008bfbd5')
GO
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'3417c47c-c25d-4888-a094-6751c431bea2', N'7ce23cee-8438-4834-8cd4-ed3b2ce7f690')
GO
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'8f28e0bb-fab9-4fb7-a4ae-2a5e2ab17b6b', N'ac82bb3b-aef7-4a22-b76a-d0453bcb2bff')
GO
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'127beb63-74c2-4fef-9e28-6edcb2605a84', N'ce7b0eb1-57ee-439d-9acf-6934c8b28a4e')
GO
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'175a6b21-ecd1-4ed2-8875-49ff60dd6414 ', N'ce7b0eb1-57ee-439d-9acf-6934c8b28a4e')
GO
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'225439b4-4c3a-4299-990e-72b72b4875c5', N'ce7b0eb1-57ee-439d-9acf-6934c8b28a4e')
GO
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'3f9bca09-60eb-4a21-8128-0662d970a8c8', N'ce7b0eb1-57ee-439d-9acf-6934c8b28a4e')
GO
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'beba71ef-5894-4ce1-9fb0-8bd1483d1908', N'ce7b0eb1-57ee-439d-9acf-6934c8b28a4e')
GO
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'cbe2581e-7044-462a-8560-7490d68fd739', N'ce7b0eb1-57ee-439d-9acf-6934c8b28a4e')
go

SET IDENTITY_INSERT [dbo].[BloodTypes] ON 
GO
INSERT [dbo].[BloodTypes] ([Id], [Name], [Code]) VALUES (1, N'B+', N'B+')
GO
INSERT [dbo].[BloodTypes] ([Id], [Name], [Code]) VALUES (2, N'AB-', N'AB-')
GO
INSERT [dbo].[BloodTypes] ([Id], [Name], [Code]) VALUES (3, N'B-', N'B-')
GO
INSERT [dbo].[BloodTypes] ([Id], [Name], [Code]) VALUES (4, N'A-', N'A-')
GO
INSERT [dbo].[BloodTypes] ([Id], [Name], [Code]) VALUES (5, N'O-', N'O-')
GO
INSERT [dbo].[BloodTypes] ([Id], [Name], [Code]) VALUES (6, N'AB+', N'AB+')
GO
INSERT [dbo].[BloodTypes] ([Id], [Name], [Code]) VALUES (7, N'A+', N'A+')
GO
INSERT [dbo].[BloodTypes] ([Id], [Name], [Code]) VALUES (8, N'O+', N'O+')
GO
INSERT [dbo].[BloodTypes] ([Id], [Name], [Code]) VALUES (9, N'_Desconocido', N'_Desconocido')
GO
SET IDENTITY_INSERT [dbo].[BloodTypes] OFF
go

SET IDENTITY_INSERT [dbo].[Countries] ON 
GO
INSERT [dbo].[Countries] ([Id], [Name], [Denomym]) VALUES (1, N'Republica Dominicana', N'_Dominican@')
GO
INSERT [dbo].[Countries] ([Id], [Name], [Denomym]) VALUES (2, N'Venezuela', N'Venezolan@')
GO
INSERT [dbo].[Countries] ([Id], [Name], [Denomym]) VALUES (3, N'China', N'Chino@')
GO
INSERT [dbo].[Countries] ([Id], [Name], [Denomym]) VALUES (4, N'Colombia', N'Colombian@')
GO
INSERT [dbo].[Countries] ([Id], [Name], [Denomym]) VALUES (5, N'Haiti', N'Haitian@')
GO
INSERT [dbo].[Countries] ([Id], [Name], [Denomym]) VALUES (6, N'Usa', N'American@')
GO
INSERT [dbo].[Countries] ([Id], [Name], [Denomym]) VALUES (7, N'Otro', N'Otro')
GO
SET IDENTITY_INSERT [dbo].[Countries] OFF
GO
SET IDENTITY_INSERT [dbo].[CourseModalities] ON 
GO
INSERT [dbo].[CourseModalities] ([Id], [Name], [Code]) VALUES (1, N'Presencial', N'P')
GO
INSERT [dbo].[CourseModalities] ([Id], [Name], [Code]) VALUES (2, N'Online', N'O')
GO
INSERT [dbo].[CourseModalities] ([Id], [Name], [Code]) VALUES (3, N'Semi-Presencial', N'SP')
GO
SET IDENTITY_INSERT [dbo].[CourseModalities] OFF
go

SET IDENTITY_INSERT [dbo].[CourseTypes] ON 
GO
INSERT [dbo].[CourseTypes] ([Id], [Name], [Code]) VALUES (1, N'Carrera', N'Ca')
GO
INSERT [dbo].[CourseTypes] ([Id], [Name], [Code]) VALUES (2, N'Curso', N'Cu')
GO
INSERT [dbo].[CourseTypes] ([Id], [Name], [Code]) VALUES (3, N'Taller', N'Ta')
GO
INSERT [dbo].[CourseTypes] ([Id], [Name], [Code]) VALUES (4, N'Seminario', N'Se')
GO
SET IDENTITY_INSERT [dbo].[CourseTypes] OFF
GO
SET IDENTITY_INSERT [dbo].[Currencies] ON 
GO
INSERT [dbo].[Currencies] ([Id], [Name], [Code]) VALUES (1, N'US Dollar', N'USD')
GO
INSERT [dbo].[Currencies] ([Id], [Name], [Code]) VALUES (2, N'Pesos Dominicanos', N'DOP')
GO
INSERT [dbo].[Currencies] ([Id], [Name], [Code]) VALUES (3, N'EURO', N'EUR')
GO
SET IDENTITY_INSERT [dbo].[Currencies] OFF
go

SET IDENTITY_INSERT [dbo].[Genders] ON 
GO
INSERT [dbo].[Genders] ([Id], [Name]) VALUES (1, N'M')
GO
INSERT [dbo].[Genders] ([Id], [Name]) VALUES (2, N'F')
GO
INSERT [dbo].[Genders] ([Id], [Name]) VALUES (3, N'I')
GO
SET IDENTITY_INSERT [dbo].[Genders] OFF
go

SET IDENTITY_INSERT [dbo].[Insurances] ON 
GO
INSERT [dbo].[Insurances] ([Id], [Name], [Code], [AditionalInfo], [Rnc]) VALUES (1, N'Seguros Ademi, S.A.', N'Ademi', N'Calle Madame Curie No. 21, La Esperilla   Santo Domingo, D.N.  Tel.: (809) 683-0203 ext.2616', NULL)
GO
INSERT [dbo].[Insurances] ([Id], [Name], [Code], [AditionalInfo], [Rnc]) VALUES (2, N'REHSA Compañía de Seguros y Reaseguros, S.A.', N'REHSA', N'Av. Gustavo Mejía Ricart No.8,   Edif. Angloamericana, 2do nivel,  El Millón, Santo Domingo, D.N.  Tel.: (809) 548-7171', NULL)
GO
INSERT [dbo].[Insurances] ([Id], [Name], [Code], [AditionalInfo], [Rnc]) VALUES (3, N'Multiseguros Mehr, S.A. ', N'Multiseguros Mehr', N'Av. Lope de Vega, Torre Novocentro,  Piso 3, Suite C8C  Ensanche Naco, Santo Domingo, D.N.  Tel.: (809) 378-1820', NULL)
GO
INSERT [dbo].[Insurances] ([Id], [Name], [Code], [AditionalInfo], [Rnc]) VALUES (4, N'La Monumental de Seguros, C por A ', N'La Monumental', N'Max Henríquez Ureña No.79  Santo Domingo, R.D.  Tel.: (809) 686-4744 - Fax: (809) 685-5381  www.lamonumental.com.do', NULL)
GO
INSERT [dbo].[Insurances] ([Id], [Name], [Code], [AditionalInfo], [Rnc]) VALUES (5, N'Humano', N'Humano', N'', NULL)
GO
INSERT [dbo].[Insurances] ([Id], [Name], [Code], [AditionalInfo], [Rnc]) VALUES (6, N'La Colonial, S.A. ', N'La Colonial', N'Av. Sarasota No. 75, Bella Vista  Santo Domingo, R.D.  Tel.: (809) 508-0707 / (809) 533-8969  Fax: (809) 508-0608  Email: luis.guerrero@lacolonial.com.do', NULL)
GO
INSERT [dbo].[Insurances] ([Id], [Name], [Code], [AditionalInfo], [Rnc]) VALUES (7, N'General de Seguros, S.A. ', N'General de Seguros', N'Av. Sarasota No. 39, Torre Sarasota Center,  Bella Vista, Apartado 2183  Santo Domingo, R.D.  Tel.: (809) 535-8888', NULL)
GO
INSERT [dbo].[Insurances] ([Id], [Name], [Code], [AditionalInfo], [Rnc]) VALUES (8, N'Cooperativa Nacional de Seguros, C por A', N'COOPSEGUROS', N'C/Hnos. Deligne No. 156.  Gascue, Santo Domingo, R.D.  Tel.: (809) 682-6118 / 6313  Email:coop.seguros@verizon.net.do', NULL)
GO
INSERT [dbo].[Insurances] ([Id], [Name], [Code], [AditionalInfo], [Rnc]) VALUES (9, N'Seguros Patria, S. A.', N'Patria', N'Av. 27 de Febrero #215, Entre Ortega y Gasset y   Tiradentes, Ens. Naco, Santo Domingo, D.N.  Tel: (809) 547-1234 Reclam (809) 687-3151  1(809) 200-1160 - Fax: 809) 221-8128  Email: patria@verizon.net.do', NULL)
GO
INSERT [dbo].[Insurances] ([Id], [Name], [Code], [AditionalInfo], [Rnc]) VALUES (10, N'xed', N'xed', N'', NULL)
GO
INSERT [dbo].[Insurances] ([Id], [Name], [Code], [AditionalInfo], [Rnc]) VALUES (11, N'Seguros Reservas, S.A.', N'Reservas', N'Av. Jiménez Moya, esq Calle 4   Ens. La Paz, Santo Domingo, R.D.  Tel.: (809) 960-7200 - Fax: (809) 960-6148  Email: smahfoud@segbanreservas.com', NULL)
GO
INSERT [dbo].[Insurances] ([Id], [Name], [Code], [AditionalInfo], [Rnc]) VALUES (12, N'Palic Salud', N'Palic', N'', NULL)
GO
INSERT [dbo].[Insurances] ([Id], [Name], [Code], [AditionalInfo], [Rnc]) VALUES (13, N'PRIMERA ARS', N'Primera', N'', NULL)
GO
INSERT [dbo].[Insurances] ([Id], [Name], [Code], [AditionalInfo], [Rnc]) VALUES (14, N'CONSTITUCION', N'Constitucion', N'', NULL)
GO
INSERT [dbo].[Insurances] ([Id], [Name], [Code], [AditionalInfo], [Rnc]) VALUES (15, N'BANCENTRAL', N'BanCentral', N'', NULL)
GO
INSERT [dbo].[Insurances] ([Id], [Name], [Code], [AditionalInfo], [Rnc]) VALUES (16, N'SENASA SUBSIDIADO', N'SenasaSub', N'', NULL)
GO
INSERT [dbo].[Insurances] ([Id], [Name], [Code], [AditionalInfo], [Rnc]) VALUES (17, N'xed', N'xed', N'', NULL)
GO
INSERT [dbo].[Insurances] ([Id], [Name], [Code], [AditionalInfo], [Rnc]) VALUES (18, N'ARL', N'ARL', N'', NULL)
GO
INSERT [dbo].[Insurances] ([Id], [Name], [Code], [AditionalInfo], [Rnc]) VALUES (19, N'Metasalud', N'Metasalud', N'', NULL)
GO
INSERT [dbo].[Insurances] ([Id], [Name], [Code], [AditionalInfo], [Rnc]) VALUES (20, N'Seguros Universal, S. A.', N'Universal', N'Av. Winston Churchill 1100, Apartado 1052  Santo Domingo, R.D.  Tels.: (809)544-7200 / (809) 544-7968  Fax: (809) 544-7914 - Santiago: (809) 530-5282  Email: universal.seguros@codetel.net.do', NULL)
GO
INSERT [dbo].[Insurances] ([Id], [Name], [Code], [AditionalInfo], [Rnc]) VALUES (21, N'GMA', N'GMA', N'', NULL)
GO
INSERT [dbo].[Insurances] ([Id], [Name], [Code], [AditionalInfo], [Rnc]) VALUES (22, N'SENASA CONTRIBUTIVO', N'SenasaC', N'', NULL)
GO
INSERT [dbo].[Insurances] ([Id], [Name], [Code], [AditionalInfo], [Rnc]) VALUES (23, N'Simag', N'Simag', N'', NULL)
GO
INSERT [dbo].[Insurances] ([Id], [Name], [Code], [AditionalInfo], [Rnc]) VALUES (24, N'Semunace', N'Semunace', N'', NULL)
GO
INSERT [dbo].[Insurances] ([Id], [Name], [Code], [AditionalInfo], [Rnc]) VALUES (25, N'Futuro', N'Futuro', N'', NULL)
GO
INSERT [dbo].[Insurances] ([Id], [Name], [Code], [AditionalInfo], [Rnc]) VALUES (26, N'Semma', N'Semma', N'', NULL)
GO
INSERT [dbo].[Insurances] ([Id], [Name], [Code], [AditionalInfo], [Rnc]) VALUES (27, N'Renacer', N'Renacer', N'', NULL)
GO
INSERT [dbo].[Insurances] ([Id], [Name], [Code], [AditionalInfo], [Rnc]) VALUES (28, N'xed', N'xed', N'', NULL)
GO
INSERT [dbo].[Insurances] ([Id], [Name], [Code], [AditionalInfo], [Rnc]) VALUES (29, N'UASD', N'UASD', N'', NULL)
GO
INSERT [dbo].[Insurances] ([Id], [Name], [Code], [AditionalInfo], [Rnc]) VALUES (30, N'Bupa Dominicana, S.A.', N'Bupa', N'', NULL)
GO
INSERT [dbo].[Insurances] ([Id], [Name], [Code], [AditionalInfo], [Rnc]) VALUES (31, N'Compañia de Seguros APS, S.R.L.', N'APS', N'', NULL)
GO
INSERT [dbo].[Insurances] ([Id], [Name], [Code], [AditionalInfo], [Rnc]) VALUES (32, N'ARS BMI', N'BMI', N'', NULL)
GO
INSERT [dbo].[Insurances] ([Id], [Name], [Code], [AditionalInfo], [Rnc]) VALUES (33, N'ARS CMD (Colegio Médico Dominicano)', N'CMD', N'', NULL)
GO
INSERT [dbo].[Insurances] ([Id], [Name], [Code], [AditionalInfo], [Rnc]) VALUES (34, N'F.F.A.A.', N'F.F.A.A.', N'', NULL)
GO
INSERT [dbo].[Insurances] ([Id], [Name], [Code], [AditionalInfo], [Rnc]) VALUES (35, N'ARS Yunen', N'Yunen', N'', NULL)
GO
INSERT [dbo].[Insurances] ([Id], [Name], [Code], [AditionalInfo], [Rnc]) VALUES (36, N'SALUD SEGURA', N'SaludS', N'', NULL)
GO
INSERT [dbo].[Insurances] ([Id], [Name], [Code], [AditionalInfo], [Rnc]) VALUES (37, N'_Privado/Desconocido o No Asegurado', N'_N/A', N'', NULL)
GO
INSERT [dbo].[Insurances] ([Id], [Name], [Code], [AditionalInfo], [Rnc]) VALUES (38, N'ARS ASEMAP', N'ASEMAP', N'', NULL)
GO
SET IDENTITY_INSERT [dbo].[Insurances] OFF
GO
SET IDENTITY_INSERT [dbo].[MaritalSituations] ON 
GO
INSERT [dbo].[MaritalSituations] ([Id], [Name]) VALUES (1, N'_N/A (Desconocido)')
GO
INSERT [dbo].[MaritalSituations] ([Id], [Name]) VALUES (2, N'Solter@')
GO
INSERT [dbo].[MaritalSituations] ([Id], [Name]) VALUES (3, N'Union Libre')
GO
INSERT [dbo].[MaritalSituations] ([Id], [Name]) VALUES (4, N'Casad@')
GO
INSERT [dbo].[MaritalSituations] ([Id], [Name]) VALUES (5, N'Divorciad@')
GO
INSERT [dbo].[MaritalSituations] ([Id], [Name]) VALUES (6, N'Viud@')
GO
SET IDENTITY_INSERT [dbo].[MaritalSituations] OFF
go


SET IDENTITY_INSERT [dbo].[Plans] ON 
GO
INSERT [dbo].[Plans] ([Id], [Name], [Amount], [CurrencyId], [PeriodicityId], [Megabytes], [UserPosibility], [RegiterCount]) VALUES (1, N'Basico', CAST(10.00 AS Decimal(12, 2)), 1, 11, 5, 5, 500)
GO
INSERT [dbo].[Plans] ([Id], [Name], [Amount], [CurrencyId], [PeriodicityId], [Megabytes], [UserPosibility], [RegiterCount]) VALUES (4, N'Plan Avanzado', CAST(500.00 AS Decimal(12, 2)), 1, 11, 1012, 25, 250000)
GO
SET IDENTITY_INSERT [dbo].[Plans] OFF
go

SET IDENTITY_INSERT [dbo].[RelationTypes] ON 
GO
INSERT [dbo].[RelationTypes] ([Id], [Name]) VALUES (1, N'Madrastra')
GO
INSERT [dbo].[RelationTypes] ([Id], [Name]) VALUES (2, N'Padrastro')
GO
INSERT [dbo].[RelationTypes] ([Id], [Name]) VALUES (3, N'Amiga')
GO
INSERT [dbo].[RelationTypes] ([Id], [Name]) VALUES (4, N'Amigo')
GO
INSERT [dbo].[RelationTypes] ([Id], [Name]) VALUES (5, N'Prima')
GO
INSERT [dbo].[RelationTypes] ([Id], [Name]) VALUES (6, N'Primo')
GO
INSERT [dbo].[RelationTypes] ([Id], [Name]) VALUES (7, N'Tio')
GO
INSERT [dbo].[RelationTypes] ([Id], [Name]) VALUES (8, N'Otro')
GO
INSERT [dbo].[RelationTypes] ([Id], [Name]) VALUES (9, N'Abuelo')
GO
INSERT [dbo].[RelationTypes] ([Id], [Name]) VALUES (10, N'Abuela')
GO
INSERT [dbo].[RelationTypes] ([Id], [Name]) VALUES (11, N'Tutor')
GO
INSERT [dbo].[RelationTypes] ([Id], [Name]) VALUES (12, N'Padre')
GO
INSERT [dbo].[RelationTypes] ([Id], [Name]) VALUES (13, N'Tia')
GO
INSERT [dbo].[RelationTypes] ([Id], [Name]) VALUES (14, N'Madre')
GO
SET IDENTITY_INSERT [dbo].[RelationTypes] OFF
GO
SET IDENTITY_INSERT [dbo].[Religions] ON 
GO
INSERT [dbo].[Religions] ([Id], [Name]) VALUES (1, N'_N/A (Desconocida)')
GO
INSERT [dbo].[Religions] ([Id], [Name]) VALUES (2, N'Ate@')
GO
INSERT [dbo].[Religions] ([Id], [Name]) VALUES (3, N'Mormon')
GO
INSERT [dbo].[Religions] ([Id], [Name]) VALUES (4, N'Judio')
GO
INSERT [dbo].[Religions] ([Id], [Name]) VALUES (5, N'Musulman')
GO
INSERT [dbo].[Religions] ([Id], [Name]) VALUES (6, N'Hinduista')
GO
INSERT [dbo].[Religions] ([Id], [Name]) VALUES (7, N'Budista')
GO
INSERT [dbo].[Religions] ([Id], [Name]) VALUES (8, N'Taoista')
GO
INSERT [dbo].[Religions] ([Id], [Name]) VALUES (9, N'Confusionista')
GO
INSERT [dbo].[Religions] ([Id], [Name]) VALUES (10, N'Shintoista')
GO
INSERT [dbo].[Religions] ([Id], [Name]) VALUES (11, N'Otr@')
GO
INSERT [dbo].[Religions] ([Id], [Name]) VALUES (12, N'Testigo de Jehova')
GO
INSERT [dbo].[Religions] ([Id], [Name]) VALUES (13, N'Adventista')
GO
INSERT [dbo].[Religions] ([Id], [Name]) VALUES (14, N'Cristian@')
GO
INSERT [dbo].[Religions] ([Id], [Name]) VALUES (15, N'Evangelic@')
GO
INSERT [dbo].[Religions] ([Id], [Name]) VALUES (16, N'Catolic@')
GO
SET IDENTITY_INSERT [dbo].[Religions] OFF
GO
SET IDENTITY_INSERT [dbo].[ScheduleFormats] ON 
GO
INSERT [dbo].[ScheduleFormats] ([Id], [Name]) VALUES (1, N'Actividad Unica')
GO
INSERT [dbo].[ScheduleFormats] ([Id], [Name]) VALUES (2, N'Diaria')
GO
INSERT [dbo].[ScheduleFormats] ([Id], [Name]) VALUES (3, N'Dias Laborales')
GO
INSERT [dbo].[ScheduleFormats] ([Id], [Name]) VALUES (4, N'Semanal')
GO
INSERT [dbo].[ScheduleFormats] ([Id], [Name]) VALUES (5, N'Semanal Mixto')
GO
INSERT [dbo].[ScheduleFormats] ([Id], [Name]) VALUES (6, N'Mensual')
GO
INSERT [dbo].[ScheduleFormats] ([Id], [Name]) VALUES (7, N'Bimestral')
GO
INSERT [dbo].[ScheduleFormats] ([Id], [Name]) VALUES (8, N'Trimestral')
GO
INSERT [dbo].[ScheduleFormats] ([Id], [Name]) VALUES (9, N'Cuatrimestral')
GO
INSERT [dbo].[ScheduleFormats] ([Id], [Name]) VALUES (10, N'Semestral')
GO
INSERT [dbo].[ScheduleFormats] ([Id], [Name]) VALUES (11, N'Anual')
GO
SET IDENTITY_INSERT [dbo].[ScheduleFormats] OFF
GO

SET IDENTITY_INSERT [dbo].[SchoolLevels] ON 
GO
INSERT [dbo].[SchoolLevels] ([Id], [Name]) VALUES (1, N'Secundaria')
GO
INSERT [dbo].[SchoolLevels] ([Id], [Name]) VALUES (2, N'No Aplica')
GO
INSERT [dbo].[SchoolLevels] ([Id], [Name]) VALUES (3, N'Tecnica')
GO
INSERT [dbo].[SchoolLevels] ([Id], [Name]) VALUES (4, N'Doctorado')
GO
INSERT [dbo].[SchoolLevels] ([Id], [Name]) VALUES (5, N'Universitaria')
GO
INSERT [dbo].[SchoolLevels] ([Id], [Name]) VALUES (6, N'_N/A (Desconocida)')
GO
INSERT [dbo].[SchoolLevels] ([Id], [Name]) VALUES (7, N'Maestria')
GO
INSERT [dbo].[SchoolLevels] ([Id], [Name]) VALUES (8, N'Primaria')
GO
INSERT [dbo].[SchoolLevels] ([Id], [Name]) VALUES (9, N'Ninguno')
GO
SET IDENTITY_INSERT [dbo].[SchoolLevels] OFF
GO
SET IDENTITY_INSERT [dbo].[ServiceTypes] ON 
GO
INSERT [dbo].[ServiceTypes] ([Id], [Name]) VALUES (1, N'Producto')
GO
INSERT [dbo].[ServiceTypes] ([Id], [Name]) VALUES (2, N'_Servicio')
GO
SET IDENTITY_INSERT [dbo].[ServiceTypes] OFF
go

SET IDENTITY_INSERT [dbo].[Status] ON 
GO
INSERT [dbo].[Status] ([Id], [Name], [Table]) VALUES (1, N'_Activo', N'ALL')
GO
INSERT [dbo].[Status] ([Id], [Name], [Table]) VALUES (2, N'Inactivo', N'ALL')
GO
INSERT [dbo].[Status] ([Id], [Name], [Table]) VALUES (3, N'Egresado', N'ALL')
GO
INSERT [dbo].[Status] ([Id], [Name], [Table]) VALUES (4, N'Retirado', N'ALL')
GO
INSERT [dbo].[Status] ([Id], [Name], [Table]) VALUES (5, N'Requerida', N'Requisition')
GO
INSERT [dbo].[Status] ([Id], [Name], [Table]) VALUES (6, N'Aprobada', N'Requisition')
GO
INSERT [dbo].[Status] ([Id], [Name], [Table]) VALUES (7, N'Rechazada', N'Rechazada')
GO
SET IDENTITY_INSERT [dbo].[Status] OFF
GO
SET IDENTITY_INSERT [dbo].[SubjectModalities] ON 
GO
INSERT [dbo].[SubjectModalities] ([Id], [Name], [Code]) VALUES (1, N'Presencial', N'P')
GO
INSERT [dbo].[SubjectModalities] ([Id], [Name], [Code]) VALUES (2, N'Online', N'O')
GO
INSERT [dbo].[SubjectModalities] ([Id], [Name], [Code]) VALUES (3, N'Semi-Presencial', N'SP')
GO
SET IDENTITY_INSERT [dbo].[SubjectModalities] OFF
go

SET IDENTITY_INSERT [dbo].[Tandas] ON 
GO
INSERT [dbo].[Tandas] ([Id], [Name]) VALUES (1, N'Nocturna')
GO
INSERT [dbo].[Tandas] ([Id], [Name]) VALUES (2, N'Tarde')
GO
INSERT [dbo].[Tandas] ([Id], [Name]) VALUES (3, N'Medio Dia')
GO
INSERT [dbo].[Tandas] ([Id], [Name]) VALUES (4, N'Matutina')
GO
SET IDENTITY_INSERT [dbo].[Tandas] OFF
go
SET IDENTITY_INSERT [dbo].[MemberTypes] ON 
GO
INSERT [dbo].[MemberTypes] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy]) VALUES (1, N'Aspirante', 0, CAST(N'2019-11-25T03:08:49.5871103' AS DateTime2), N'225439b4-4c3a-4299-990e-72b72b4875c5', CAST(N'2019-11-25T03:08:49.5871103' AS DateTime2), N'225439b4-4c3a-4299-990e-72b72b4875c5', NULL, NULL)
GO
INSERT [dbo].[MemberTypes] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy]) VALUES (2, N'NNAs/Miembro', 0, CAST(N'2019-11-25T03:08:58.8786397' AS DateTime2), N'225439b4-4c3a-4299-990e-72b72b4875c5', CAST(N'2019-11-25T03:08:58.8786397' AS DateTime2), N'225439b4-4c3a-4299-990e-72b72b4875c5', NULL, NULL)
GO
INSERT [dbo].[MemberTypes] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy]) VALUES (3, N'Voluntario', 0, CAST(N'2019-11-25T03:09:06.9799785' AS DateTime2), N'225439b4-4c3a-4299-990e-72b72b4875c5', CAST(N'2019-11-25T03:09:06.9799785' AS DateTime2), N'225439b4-4c3a-4299-990e-72b72b4875c5', NULL, NULL)
GO
INSERT [dbo].[MemberTypes] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy]) VALUES (4, N'Empleado', 0, CAST(N'2019-11-25T03:09:13.9176994' AS DateTime2), N'225439b4-4c3a-4299-990e-72b72b4875c5', CAST(N'2019-11-25T03:09:13.9176994' AS DateTime2), N'225439b4-4c3a-4299-990e-72b72b4875c5', NULL, NULL)
GO
INSERT [dbo].[MemberTypes] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy]) VALUES (5, N'Relacionado (Padre, Tutor)', 0, CAST(N'2019-11-25T03:09:20.8069737' AS DateTime2), N'225439b4-4c3a-4299-990e-72b72b4875c5', CAST(N'2019-11-25T03:09:20.8069737' AS DateTime2), N'225439b4-4c3a-4299-990e-72b72b4875c5', NULL, NULL)
GO
INSERT [dbo].[MemberTypes] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy]) VALUES (6, N'Egresado', 0, CAST(N'2019-11-25T03:09:27.7842355' AS DateTime2), N'225439b4-4c3a-4299-990e-72b72b4875c5', CAST(N'2019-11-25T03:09:27.7842355' AS DateTime2), N'225439b4-4c3a-4299-990e-72b72b4875c5', NULL, NULL)
GO
INSERT [dbo].[MemberTypes] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy]) VALUES (7, N'Voluntarios', 0, CAST(N'2020-02-05T11:02:28.0708076' AS DateTime2), N'225439b4-4c3a-4299-990e-72b72b4875c5', CAST(N'2020-02-05T11:02:28.0708076' AS DateTime2), N'225439b4-4c3a-4299-990e-72b72b4875c5', NULL, NULL)
GO
INSERT [dbo].[MemberTypes] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy]) VALUES (8, N'Comunitarios', 0, CAST(N'2020-02-05T11:02:39.7922995' AS DateTime2), N'225439b4-4c3a-4299-990e-72b72b4875c5', CAST(N'2020-02-05T11:02:39.7922995' AS DateTime2), N'225439b4-4c3a-4299-990e-72b72b4875c5', NULL, NULL)
GO
SET IDENTITY_INSERT [dbo].[MemberTypes] OFF
go
SET IDENTITY_INSERT [dbo].[Measures] ON 
GO
INSERT [dbo].[Measures] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [Code]) VALUES (1, N'_N/A', 0, CAST(N'2020-02-09T15:28:10.5205114' AS DateTime2), N'225439b4-4c3a-4299-990e-72b72b4875c5', CAST(N'2020-02-09T15:28:10.5205114' AS DateTime2), N'225439b4-4c3a-4299-990e-72b72b4875c5', NULL, NULL, N'_N/A')
GO
INSERT [dbo].[Measures] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [Code]) VALUES (2, N'_N/A', 0, CAST(N'2020-02-09T15:28:10.5205114' AS DateTime2), N'3f9bca09-60eb-4a21-8128-0662d970a8c8', CAST(N'2020-02-09T15:28:10.5205114' AS DateTime2), N'3f9bca09-60eb-4a21-8128-0662d970a8c8', NULL, NULL, N'_N/A')
GO
INSERT [dbo].[Measures] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [Code]) VALUES (5, N'_N/A', 0, CAST(N'2020-07-15T06:40:55.4003228' AS DateTime2), N'8f28e0bb-fab9-4fb7-a4ae-2a5e2ab17b6b', CAST(N'2020-07-15T06:40:55.4003228' AS DateTime2), N'8f28e0bb-fab9-4fb7-a4ae-2a5e2ab17b6b', NULL, NULL, N'NA')
GO
SET IDENTITY_INSERT [dbo].[Measures] OFF
go


SET IDENTITY_INSERT [dbo].[DaysOfTheWeeks] ON 
GO
INSERT [dbo].[DaysOfTheWeeks] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [ClasseId]) VALUES (1, N'Lunes', 0, CAST(N'2019-11-25T03:03:57.5823217' AS DateTime2), NULL, CAST(N'2019-11-25T03:03:57.5823217' AS DateTime2), NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[DaysOfTheWeeks] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [ClasseId]) VALUES (2, N'Martes', 0, CAST(N'2019-11-25T03:03:57.5856420' AS DateTime2), NULL, CAST(N'2019-11-25T03:03:57.5856420' AS DateTime2), NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[DaysOfTheWeeks] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [ClasseId]) VALUES (3, N'Miercoles', 0, CAST(N'2019-11-25T03:03:57.5946008' AS DateTime2), NULL, CAST(N'2019-11-25T03:03:57.5946008' AS DateTime2), NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[DaysOfTheWeeks] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [ClasseId]) VALUES (4, N'Jueves', 0, CAST(N'2019-11-25T03:03:57.6077879' AS DateTime2), NULL, CAST(N'2019-11-25T03:03:57.6077879' AS DateTime2), NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[DaysOfTheWeeks] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [ClasseId]) VALUES (5, N'Viernes', 0, CAST(N'2019-11-25T03:03:57.6114565' AS DateTime2), NULL, CAST(N'2019-11-25T03:03:57.6114565' AS DateTime2), NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[DaysOfTheWeeks] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [ClasseId]) VALUES (6, N'Sabado', 0, CAST(N'2019-11-25T03:03:57.6184257' AS DateTime2), NULL, CAST(N'2019-11-25T03:03:57.6184257' AS DateTime2), NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[DaysOfTheWeeks] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [ClasseId]) VALUES (7, N'Domingo', 0, CAST(N'2019-11-25T03:03:57.6276875' AS DateTime2), NULL, CAST(N'2019-11-25T03:03:57.6276875' AS DateTime2), NULL, NULL, NULL, NULL)
GO
SET IDENTITY_INSERT [dbo].[DaysOfTheWeeks] OFF
go
SET IDENTITY_INSERT [dbo].[Courses] ON 
GO
INSERT [dbo].[Courses] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [CourseTypeId], [CourseModalityId], [Code], [Description], [Imagen]) VALUES (1, N'Ing. en Sistemas', 0, CAST(N'2020-05-09T12:04:10.5469780' AS DateTime2), N'225439b4-4c3a-4299-990e-72b72b4875c5', CAST(N'2020-05-09T12:04:10.5469780' AS DateTime2), N'225439b4-4c3a-4299-990e-72b72b4875c5', NULL, NULL, 1, 1, NULL, NULL, NULL)
GO
INSERT [dbo].[Courses] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [CourseTypeId], [CourseModalityId], [Code], [Description], [Imagen]) VALUES (2, N'Artes & Diseño', 0, CAST(N'2020-05-09T12:04:58.5771873' AS DateTime2), N'225439b4-4c3a-4299-990e-72b72b4875c5', CAST(N'2020-05-09T12:04:58.5771873' AS DateTime2), N'225439b4-4c3a-4299-990e-72b72b4875c5', NULL, NULL, 1, 1, NULL, NULL, NULL)
GO
INSERT [dbo].[Courses] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [CourseTypeId], [CourseModalityId], [Code], [Description], [Imagen]) VALUES (3, N'Lenguas y Literatura', 0, CAST(N'2020-05-09T12:05:19.1595252' AS DateTime2), N'225439b4-4c3a-4299-990e-72b72b4875c5', CAST(N'2020-05-09T12:05:19.1595252' AS DateTime2), N'225439b4-4c3a-4299-990e-72b72b4875c5', NULL, NULL, 1, 1, NULL, NULL, NULL)
GO
INSERT [dbo].[Courses] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [CourseTypeId], [CourseModalityId], [Code], [Description], [Imagen]) VALUES (4, N'Adm. de Empresas', 0, CAST(N'2020-05-09T12:05:43.8924845' AS DateTime2), N'225439b4-4c3a-4299-990e-72b72b4875c5', CAST(N'2020-05-09T12:05:43.8924845' AS DateTime2), N'225439b4-4c3a-4299-990e-72b72b4875c5', NULL, NULL, 1, 1, NULL, NULL, NULL)
GO
SET IDENTITY_INSERT [dbo].[Courses] OFF
GO
SET IDENTITY_INSERT [dbo].[Brands] ON 
GO
INSERT [dbo].[Brands] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy]) VALUES (1, N'_N/A', 0, CAST(N'2020-02-09T15:27:54.5511947' AS DateTime2), N'225439b4-4c3a-4299-990e-72b72b4875c5', CAST(N'2020-02-09T15:27:54.5511947' AS DateTime2), N'225439b4-4c3a-4299-990e-72b72b4875c5', NULL, NULL)
GO
SET IDENTITY_INSERT [dbo].[Brands] OFF
GO
SET IDENTITY_INSERT [dbo].[Categories] ON 
GO
INSERT [dbo].[Categories] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [IsSaleCategory]) VALUES (1, N'_N/A', 0, CAST(N'2020-02-09T15:28:36.6727975' AS DateTime2), N'225439b4-4c3a-4299-990e-72b72b4875c5', CAST(N'2020-02-09T15:28:36.6727975' AS DateTime2), N'225439b4-4c3a-4299-990e-72b72b4875c5', NULL, NULL, 0)
GO
SET IDENTITY_INSERT [dbo].[Categories] OFF
GO

SET IDENTITY_INSERT [dbo].[Specialities] ON 
GO
INSERT [dbo].[Specialities] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy]) VALUES (1, N'N/A', 0, CAST(N'2020-06-24T07:02:52.5938159' AS DateTime2), N'225439b4-4c3a-4299-990e-72b72b4875c5', CAST(N'2020-06-24T07:02:52.5938159' AS DateTime2), N'225439b4-4c3a-4299-990e-72b72b4875c5', NULL, NULL)
GO
INSERT [dbo].[Specialities] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy]) VALUES (2, N'Cirujano Bariatrico Y Metabolico', 0, CAST(N'2020-06-24T07:21:01.2440697' AS DateTime2), N'175a6b21-ecd1-4ed2-8875-49ff60dd6414', CAST(N'2020-06-24T07:21:01.2440697' AS DateTime2), N'175a6b21-ecd1-4ed2-8875-49ff60dd6414', NULL, NULL)
GO
INSERT [dbo].[Specialities] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy]) VALUES (3, N'_N/A', 0, CAST(N'2020-06-24T08:24:30.7707301' AS DateTime2), N'cbe2581e-7044-462a-8560-7490d68fd739', CAST(N'2020-06-24T08:24:30.7707301' AS DateTime2), N'cbe2581e-7044-462a-8560-7490d68fd739', NULL, NULL)
GO
INSERT [dbo].[Specialities] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy]) VALUES (4, N'Ginecologia', 0, CAST(N'2020-06-24T08:25:16.1458146' AS DateTime2), N'cbe2581e-7044-462a-8560-7490d68fd739', CAST(N'2020-06-24T08:25:16.1458146' AS DateTime2), N'cbe2581e-7044-462a-8560-7490d68fd739', NULL, NULL)
GO
INSERT [dbo].[Specialities] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy]) VALUES (6, N'_N/A', 0, CAST(N'2020-07-15T06:40:55.3995080' AS DateTime2), N'8f28e0bb-fab9-4fb7-a4ae-2a5e2ab17b6b', CAST(N'2020-07-15T06:40:55.3995080' AS DateTime2), N'8f28e0bb-fab9-4fb7-a4ae-2a5e2ab17b6b', NULL, NULL)
GO
SET IDENTITY_INSERT [dbo].[Specialities] OFF
go
SET IDENTITY_INSERT [dbo].[People] ON 
GO
INSERT [dbo].[People] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [Date], [BornDate], [GenderId], [SchoolLevelId], [CountryId], [Cel], [MaritalSituationId], [OcupationId], [ReligionId], [Imagen], [Record2], [Record], [PlaceOfWork], [Age], [BloodTypeId], [Nss], [UserId], [StatusId], [InsuranceId], [InsuranceNumber], [Record3], [CreationDate], [MemberTypeId], [SpecialityId]) VALUES (1, NULL, 0, CAST(N'2020-04-12T19:51:27.9212490' AS DateTime2), N'225439b4-4c3a-4299-990e-72b72b4875c5', CAST(N'2020-04-12T22:42:16.4491134' AS DateTime2), N'225439b4-4c3a-4299-990e-72b72b4875c5', NULL, NULL, CAST(N'2020-04-13T02:42:14.3999893' AS DateTime2), CAST(N'2020-04-12T23:51:25.0427375' AS DateTime2), NULL, 6, 1, N'', NULL, 21, 1, N'', N'00001', 1, NULL, N'', 1, N'', N'225439b4-4c3a-4299-990e-72b72b4875c5', 1, NULL, NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[People] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [Date], [BornDate], [GenderId], [SchoolLevelId], [CountryId], [Cel], [MaritalSituationId], [OcupationId], [ReligionId], [Imagen], [Record2], [Record], [PlaceOfWork], [Age], [BloodTypeId], [Nss], [UserId], [StatusId], [InsuranceId], [InsuranceNumber], [Record3], [CreationDate], [MemberTypeId], [SpecialityId]) VALUES (2, NULL, 0, CAST(N'2020-04-16T07:52:42.6084302' AS DateTime2), N'3f9bca09-60eb-4a21-8128-0662d970a8c8', CAST(N'2020-04-16T07:52:42.6084302' AS DateTime2), N'3f9bca09-60eb-4a21-8128-0662d970a8c8', NULL, NULL, CAST(N'2020-04-16T11:52:35.6683233' AS DateTime2), CAST(N'2020-04-16T11:52:35.6683233' AS DateTime2), NULL, 6, 1, NULL, NULL, 21, 1, N'', N'00002', 2, NULL, N'', 1, N'', N'3f9bca09-60eb-4a21-8128-0662d970a8c8', 1, NULL, NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[People] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [Date], [BornDate], [GenderId], [SchoolLevelId], [CountryId], [Cel], [MaritalSituationId], [OcupationId], [ReligionId], [Imagen], [Record2], [Record], [PlaceOfWork], [Age], [BloodTypeId], [Nss], [UserId], [StatusId], [InsuranceId], [InsuranceNumber], [Record3], [CreationDate], [MemberTypeId], [SpecialityId]) VALUES (3, NULL, 0, CAST(N'2020-06-24T07:04:49.5126721' AS DateTime2), N'225439b4-4c3a-4299-990e-72b72b4875c5', CAST(N'2020-06-24T07:04:49.5126721' AS DateTime2), N'225439b4-4c3a-4299-990e-72b72b4875c5', NULL, NULL, CAST(N'2020-06-24T07:04:47.6016006' AS DateTime2), CAST(N'2020-06-24T11:04:47.6012351' AS DateTime2), 3, 6, 1, NULL, 1, 21, 1, N'', N'00', 2, NULL, NULL, NULL, NULL, N'175a6b21-ecd1-4ed2-8875-49ff60dd6414', 1, NULL, NULL, NULL, NULL, NULL, 1)
GO
INSERT [dbo].[People] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [Date], [BornDate], [GenderId], [SchoolLevelId], [CountryId], [Cel], [MaritalSituationId], [OcupationId], [ReligionId], [Imagen], [Record2], [Record], [PlaceOfWork], [Age], [BloodTypeId], [Nss], [UserId], [StatusId], [InsuranceId], [InsuranceNumber], [Record3], [CreationDate], [MemberTypeId], [SpecialityId]) VALUES (4, NULL, 0, CAST(N'2020-06-24T07:22:21.8440244' AS DateTime2), N'175a6b21-ecd1-4ed2-8875-49ff60dd6414', CAST(N'2020-06-24T07:22:21.8440244' AS DateTime2), N'175a6b21-ecd1-4ed2-8875-49ff60dd6414', NULL, NULL, CAST(N'2020-06-24T07:22:20.6733842' AS DateTime2), CAST(N'2020-06-24T11:22:20.6733641' AS DateTime2), 2, 6, 1, NULL, 4, 36, 1, N'', N'00003', 3, NULL, NULL, NULL, NULL, N'beba71ef-5894-4ce1-9fb0-8bd1483d1908', 1, NULL, NULL, NULL, NULL, NULL, 2)
GO
INSERT [dbo].[People] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [Date], [BornDate], [GenderId], [SchoolLevelId], [CountryId], [Cel], [MaritalSituationId], [OcupationId], [ReligionId], [Imagen], [Record2], [Record], [PlaceOfWork], [Age], [BloodTypeId], [Nss], [UserId], [StatusId], [InsuranceId], [InsuranceNumber], [Record3], [CreationDate], [MemberTypeId], [SpecialityId]) VALUES (5, NULL, 0, CAST(N'2020-06-24T07:25:44.4425678' AS DateTime2), N'beba71ef-5894-4ce1-9fb0-8bd1483d1908', CAST(N'2020-06-24T07:25:44.4425678' AS DateTime2), N'beba71ef-5894-4ce1-9fb0-8bd1483d1908', NULL, NULL, CAST(N'2020-06-24T07:25:44.0898333' AS DateTime2), CAST(N'2020-06-24T11:25:44.0898182' AS DateTime2), 2, 6, 1, NULL, 4, 21, 1, N'', N'00004', 4, NULL, NULL, 9, NULL, N'3417c47c-c25d-4888-a094-6751c431bea2', 1, 37, NULL, NULL, NULL, NULL, 1)
GO
INSERT [dbo].[People] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [Date], [BornDate], [GenderId], [SchoolLevelId], [CountryId], [Cel], [MaritalSituationId], [OcupationId], [ReligionId], [Imagen], [Record2], [Record], [PlaceOfWork], [Age], [BloodTypeId], [Nss], [UserId], [StatusId], [InsuranceId], [InsuranceNumber], [Record3], [CreationDate], [MemberTypeId], [SpecialityId]) VALUES (6, NULL, 0, CAST(N'2020-06-24T08:13:11.1064425' AS DateTime2), N'175a6b21-ecd1-4ed2-8875-49ff60dd6414', CAST(N'2020-06-24T08:13:11.1064425' AS DateTime2), N'175a6b21-ecd1-4ed2-8875-49ff60dd6414', NULL, NULL, CAST(N'2020-06-24T08:13:08.6687013' AS DateTime2), CAST(N'2020-06-24T12:13:08.6686823' AS DateTime2), 2, 6, 1, NULL, 4, 21, 1, N'', N'00005', 5, NULL, NULL, NULL, NULL, N'cbe2581e-7044-462a-8560-7490d68fd739', 1, NULL, NULL, NULL, NULL, NULL, 1)
GO
INSERT [dbo].[People] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [Date], [BornDate], [GenderId], [SchoolLevelId], [CountryId], [Cel], [MaritalSituationId], [OcupationId], [ReligionId], [Imagen], [Record2], [Record], [PlaceOfWork], [Age], [BloodTypeId], [Nss], [UserId], [StatusId], [InsuranceId], [InsuranceNumber], [Record3], [CreationDate], [MemberTypeId], [SpecialityId]) VALUES (7, NULL, 0, CAST(N'2020-06-24T08:30:31.3571810' AS DateTime2), N'cbe2581e-7044-462a-8560-7490d68fd739', CAST(N'2020-06-24T08:30:31.3571810' AS DateTime2), N'cbe2581e-7044-462a-8560-7490d68fd739', NULL, NULL, CAST(N'2020-06-24T08:30:30.9481077' AS DateTime2), CAST(N'2020-06-24T12:30:30.9480902' AS DateTime2), 2, 6, 1, NULL, 4, 21, 1, N'', N'1', 3, NULL, NULL, NULL, NULL, N'127beb63-74c2-4fef-9e28-6edcb2605a84', 1, NULL, NULL, NULL, NULL, NULL, 4)
GO
INSERT [dbo].[People] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [Date], [BornDate], [GenderId], [SchoolLevelId], [CountryId], [Cel], [MaritalSituationId], [OcupationId], [ReligionId], [Imagen], [Record2], [Record], [PlaceOfWork], [Age], [BloodTypeId], [Nss], [UserId], [StatusId], [InsuranceId], [InsuranceNumber], [Record3], [CreationDate], [MemberTypeId], [SpecialityId]) VALUES (9, NULL, 0, CAST(N'2020-07-01T11:26:11.3947772' AS DateTime2), N'beba71ef-5894-4ce1-9fb0-8bd1483d1908', CAST(N'2020-07-01T11:26:11.3947772' AS DateTime2), N'beba71ef-5894-4ce1-9fb0-8bd1483d1908', NULL, NULL, CAST(N'2020-07-01T11:26:10.2059672' AS DateTime2), CAST(N'2020-07-01T15:26:10.2056234' AS DateTime2), 3, 6, 1, NULL, 1, 21, 1, N'', N'00006', 6, NULL, NULL, NULL, NULL, N'8f28e0bb-fab9-4fb7-a4ae-2a5e2ab17b6b', 1, NULL, NULL, NULL, NULL, NULL, 3)
GO
SET IDENTITY_INSERT [dbo].[People] OFF
go
SET IDENTITY_INSERT [dbo].[Patients] ON 
GO
INSERT [dbo].[Patients] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [PersonId], [Alergies], [Illness], [Medicaments], [MedicamentationTime], [Companion]) VALUES (1, NULL, 0, CAST(N'2020-06-24T07:25:44.4489834' AS DateTime2), N'beba71ef-5894-4ce1-9fb0-8bd1483d1908', CAST(N'2020-06-24T07:25:44.4489834' AS DateTime2), N'beba71ef-5894-4ce1-9fb0-8bd1483d1908', NULL, NULL, 5, NULL, NULL, NULL, NULL, NULL)
GO
SET IDENTITY_INSERT [dbo].[Patients] OFF
GO

SET IDENTITY_INSERT [dbo].[Recipes] ON 
GO
INSERT [dbo].[Recipes] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [PersonId], [RecipeDate], [RecipeText], [Envases], [Posologia], [Duracion], [Indications], [Observations], [DoctorText], [PatientName], [Place]) VALUES (1, NULL, 0, CAST(N'2020-06-24T07:53:19.4034263' AS DateTime2), N'beba71ef-5894-4ce1-9fb0-8bd1483d1908', CAST(N'2020-06-24T07:53:19.4034263' AS DateTime2), N'beba71ef-5894-4ce1-9fb0-8bd1483d1908', NULL, NULL, 5, CAST(N'2020-06-05T00:00:00.0000000' AS DateTime2), N'Esta es una indicacion de receta de prueba que se utiliza para indicarle medicamentos

Medicamento de prueba 1 100mg, 4 veces al dia

Medicamento de prueba 2 Jaraba, 2 veces al dia', NULL, NULL, NULL, NULL, N'Esto es una observacion de prueba como por ejemplo: El primer medicamento sse debe tomar  una hora despues de ingerir alimentos.', NULL, NULL, NULL)
GO
INSERT [dbo].[Recipes] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [PersonId], [RecipeDate], [RecipeText], [Envases], [Posologia], [Duracion], [Indications], [Observations], [DoctorText], [PatientName], [Place]) VALUES (3, NULL, 0, CAST(N'2020-07-02T22:13:12.3796531' AS DateTime2), N'beba71ef-5894-4ce1-9fb0-8bd1483d1908', CAST(N'2020-07-02T22:13:12.3796531' AS DateTime2), N'beba71ef-5894-4ce1-9fb0-8bd1483d1908', NULL, NULL, 5, CAST(N'2020-07-16T00:00:00.0000000' AS DateTime2), N'vvvvvvvvvvvvvvvvvvvvvvvvvvvvvvv', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
GO
SET IDENTITY_INSERT [dbo].[Recipes] OFF
go

SET IDENTITY_INSERT [dbo].[Subjects] ON 
GO
INSERT [dbo].[Subjects] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [Code], [CourseId], [SubjectModalityId], [SpecialityId], [Observations], [Description], [Imagen], [PossiblePoints], [MinimumPoints], [IsGeneric]) VALUES (1, N'Matematica para Informaticos', 0, CAST(N'2020-05-09T12:08:34.3353658' AS DateTime2), N'225439b4-4c3a-4299-990e-72b72b4875c5', CAST(N'2020-05-09T12:08:34.3353658' AS DateTime2), N'225439b4-4c3a-4299-990e-72b72b4875c5', NULL, NULL, N'Mat-Inf-101', 1, 2, 3, NULL, NULL, NULL, 100, 70, 0)
GO
INSERT [dbo].[Subjects] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [Code], [CourseId], [SubjectModalityId], [SpecialityId], [Observations], [Description], [Imagen], [PossiblePoints], [MinimumPoints], [IsGeneric]) VALUES (2, N'Adm. Servidores', 0, CAST(N'2020-05-09T12:09:20.8744438' AS DateTime2), N'225439b4-4c3a-4299-990e-72b72b4875c5', CAST(N'2020-05-09T12:09:20.8744438' AS DateTime2), N'225439b4-4c3a-4299-990e-72b72b4875c5', NULL, NULL, N'Inf-908', 1, 2, 3, NULL, NULL, NULL, 100, 70, 0)
GO
INSERT [dbo].[Subjects] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [Code], [CourseId], [SubjectModalityId], [SpecialityId], [Observations], [Description], [Imagen], [PossiblePoints], [MinimumPoints], [IsGeneric]) VALUES (3, N'Programación 4', 0, CAST(N'2020-05-09T12:10:01.7471982' AS DateTime2), N'225439b4-4c3a-4299-990e-72b72b4875c5', CAST(N'2020-05-09T12:10:01.7471982' AS DateTime2), N'225439b4-4c3a-4299-990e-72b72b4875c5', NULL, NULL, N'inf-907', 1, 2, 3, NULL, NULL, NULL, 100, 70, 0)
GO
INSERT [dbo].[Subjects] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [Code], [CourseId], [SubjectModalityId], [SpecialityId], [Observations], [Description], [Imagen], [PossiblePoints], [MinimumPoints], [IsGeneric]) VALUES (4, N'Español General', 0, CAST(N'2020-05-09T12:10:47.9143722' AS DateTime2), N'225439b4-4c3a-4299-990e-72b72b4875c5', CAST(N'2020-05-09T12:10:47.9143722' AS DateTime2), N'225439b4-4c3a-4299-990e-72b72b4875c5', NULL, NULL, N'Esp-101', 1, 2, 1, NULL, NULL, NULL, 100, 70, 1)
GO
SET IDENTITY_INSERT [dbo].[Subjects] OFF
go
GO
SET IDENTITY_INSERT [dbo].[Surgeries] ON 
GO
INSERT [dbo].[Surgeries] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [PersonId], [Date], [SurgeryDate], [SurgeryHour], [Procedure], [Diagnostic], [SintomasNoCardio], [Hquirurgica], [AntecedentesA], [FamilyAlergy], [Latex], [Huevos], [Sncsnp], [Pulmonar], [Cv], [Hepatica], [RenalUrinario], [Endocrino], [Hemorragias], [Reflujo], [Tabaquismo], [Embarazo], [OtrosHistoria], [ActualMedication], [Iam], [ObservacionesIam], [Arritmias], [CardiopatiaIsquemica], [CardiopatiaReumatica], [HtaEsencial], [Angina], [Sicc], [Acv], [Dislipidemia], [Valvulopatia], [Marcapaso], [InsufVasc], [Obesidad], [CardioOtros], [Nac], [TbPulmonar], [DerramePleural], [Ebpoc], [AsmaBronquial], [Cancer], [Alergias], [Sedentarismo], [Alcohol], [Tabaquismo2], [Anticonseptivos], [Cafe], [Drogas], [CirugiasPrevias], [Convulciones], [Angina2], [Palpitaciones], [Dismea], [Sincope], [Ortopnea], [EnfGastrointestinal], [EnfHepatica], [EnfRenal], [DiabetesMellitus], [EnfEmatologica], [Tos], [Dpn], [Edema], [Fatiga], [Cianosis], [Peso], [Cuello], [Corazon], [Torax], [Abdomen], [Pulmones], [ExtremSuperiores], [ExtremInferiores], [ViasRespiratorias], [AperturaBucal], [Mallampati], [MovTempmandibular], [DistanciaTiromentoniana], [DistanciaEsternomentoniana], [ArcodeFlexion], [ExtencionAtlantoOccipital], [Bd], [Bi], [Fc], [Fr], [PesoArt], [Talla], [Imc], [Spo2], [Ritmo], [FcElectro], [P], [Pr], [Qrs], [Qt], [Aqrs], [OndasQ], [OndasT], [Extrasistoles], [BradicardiaS], [TaquicardiaS], [Hipertrofia], [BloqueosAv], [BloqueosRama], [PatologiasCardio], [OtrasPatologias], [Conclucion], [Asa], [PlanAnestesia], [AnestesiaOtro], [Discutido], [Consideraciones], [Preferencias], [Riesgos], [Manejo], [Recomendaciones]) VALUES (1, NULL, 0, CAST(N'2020-06-24T07:58:45.1477452' AS DateTime2), N'beba71ef-5894-4ce1-9fb0-8bd1483d1908', CAST(N'2020-06-24T07:58:45.1477452' AS DateTime2), N'beba71ef-5894-4ce1-9fb0-8bd1483d1908', NULL, NULL, 5, CAST(N'2020-06-17T00:00:00.0000000' AS DateTime2), CAST(N'2020-06-16T00:00:00.0000000' AS DateTime2), NULL, NULL, NULL, NULL, NULL, NULL, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, NULL, NULL, 0, NULL, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, NULL, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 0, 0, NULL, 0, NULL, NULL, NULL, NULL, N'Historia Quirurgica de Prueba, que sirve para probar cosas de prueba')
GO
SET IDENTITY_INSERT [dbo].[Surgeries] OFF
GO
SET IDENTITY_INSERT [dbo].[QuickNotes] ON 
GO
INSERT [dbo].[QuickNotes] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [PersonId], [CreationDate], [Note], [Title]) VALUES (1, NULL, 0, CAST(N'2020-06-24T07:27:17.2021040' AS DateTime2), N'beba71ef-5894-4ce1-9fb0-8bd1483d1908', CAST(N'2020-06-24T07:27:17.2021040' AS DateTime2), N'beba71ef-5894-4ce1-9fb0-8bd1483d1908', NULL, NULL, 5, NULL, N'Esta es una nota rapida de prueba, donde se pueden digitar diversos tipos de informaciones breves, que permitan dar alerta a los demas medicos que esten tratando al paciente dentro del mismo centro.', N'Nota rapida de prueba')
GO
SET IDENTITY_INSERT [dbo].[QuickNotes] OFF
GO
SET IDENTITY_INSERT [dbo].[Obstetrics] ON 
GO
INSERT [dbo].[Obstetrics] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [PersonId], [CreationDate], [Allergies], [Coombs], [App], [LastPregnant], [Hb], [Plaq], [Glycemia], [Urine], [Vdrl], [HbsAg], [Hvc], [Hiv], [Falcemia], [Electrophoresis], [Dmg], [InductionLungMaturity], [FstTt], [SndTt], [Gesta], [P], [C], [A], [E], [Fum], [Fpp], [Sonography], [BornObservations]) VALUES (1, NULL, 0, CAST(N'2020-06-24T07:58:44.4274072' AS DateTime2), N'beba71ef-5894-4ce1-9fb0-8bd1483d1908', CAST(N'2020-06-24T07:58:44.4274072' AS DateTime2), N'beba71ef-5894-4ce1-9fb0-8bd1483d1908', NULL, NULL, 5, CAST(N'2020-04-30T00:00:00.0000000' AS DateTime2), NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, CAST(N'2020-05-25T00:00:00.0000000' AS DateTime2), CAST(N'2021-03-04T00:00:00.0000000' AS DateTime2), NULL, N'Historia Pre Natal de Prueba, que sirve para probar cosas')
GO
SET IDENTITY_INSERT [dbo].[Obstetrics] OFF
GO
SET IDENTITY_INSERT [dbo].[MedicalCertificates] ON 
GO
INSERT [dbo].[MedicalCertificates] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [PersonId], [MedicalCertificateDate], [DoctorText], [Exequartur], [Cmd], [PatientName], [Affections], [Recomendations], [Place]) VALUES (1, NULL, 0, CAST(N'2020-06-24T07:54:40.5461208' AS DateTime2), N'beba71ef-5894-4ce1-9fb0-8bd1483d1908', CAST(N'2020-06-24T07:54:40.5461208' AS DateTime2), N'beba71ef-5894-4ce1-9fb0-8bd1483d1908', NULL, NULL, 5, CAST(N'2020-06-24T00:00:00.0000000' AS DateTime2), N'Medico de Prueba', N'9999', N'99', N'Paciente de Prueba Para Probar', N'Sintomas de prueba', N'A modo de prueba recomiendo reposo por 28 dias.', NULL)
GO
SET IDENTITY_INSERT [dbo].[MedicalCertificates] OFF
GO

SET IDENTITY_INSERT [dbo].[Gynecologies] ON 
GO
INSERT [dbo].[Gynecologies] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [PersonId], [Menarche], [Pubarquia], [Telarquia], [MenstrualPatron], [Dysmenorrhoea], [FirstSexualRelation], [SexualRelationPerWeek], [NoSexualPartners], [MarriedTime], [ActualUse], [PastUse], [Oral], [Div], [Barrier], [Norplat], [Gestas], [Pregnancies], [Caesarean], [Abortions], [AliveChilds], [PrematureChilds], [BornedDead], [LastPregnant], [Forceps], [LabsResult], [Observations]) VALUES (1, NULL, 0, CAST(N'2020-06-24T07:58:43.9138502' AS DateTime2), N'beba71ef-5894-4ce1-9fb0-8bd1483d1908', CAST(N'2020-06-24T07:58:43.9138502' AS DateTime2), N'beba71ef-5894-4ce1-9fb0-8bd1483d1908', NULL, NULL, 5, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, N'Historia Ginecologica de prueba que sirve para agregar cosas de prueba')
GO
SET IDENTITY_INSERT [dbo].[Gynecologies] OFF
GO
SET IDENTITY_INSERT [dbo].[GynecologyVisits] ON 
GO
INSERT [dbo].[GynecologyVisits] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [GynecologyId], [VisitDate], [VisitReason], [Symptoms], [Conclusion], [Indications]) VALUES (1, NULL, 0, CAST(N'2020-07-02T23:07:38.8510486' AS DateTime2), N'beba71ef-5894-4ce1-9fb0-8bd1483d1908', CAST(N'2020-07-02T23:07:38.8510486' AS DateTime2), N'beba71ef-5894-4ce1-9fb0-8bd1483d1908', NULL, NULL, 1, CAST(N'2020-07-10T00:00:00.0000000' AS DateTime2), N'zzz', NULL, NULL, NULL)
GO
SET IDENTITY_INSERT [dbo].[GynecologyVisits] OFF
GO
SET IDENTITY_INSERT [dbo].[Employees] ON 
GO
INSERT [dbo].[Employees] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [PersonId]) VALUES (1, NULL, 0, CAST(N'2020-04-12T19:51:27.9223852' AS DateTime2), N'225439b4-4c3a-4299-990e-72b72b4875c5', CAST(N'2020-04-12T22:42:16.4501265' AS DateTime2), N'225439b4-4c3a-4299-990e-72b72b4875c5', NULL, NULL, 1)
GO
INSERT [dbo].[Employees] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [PersonId]) VALUES (2, NULL, 0, CAST(N'2020-04-16T07:52:42.6093991' AS DateTime2), N'3f9bca09-60eb-4a21-8128-0662d970a8c8', CAST(N'2020-04-16T07:52:42.6093991' AS DateTime2), N'3f9bca09-60eb-4a21-8128-0662d970a8c8', NULL, NULL, 2)
GO
INSERT [dbo].[Employees] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [PersonId]) VALUES (3, NULL, 0, CAST(N'2020-06-24T07:04:49.5236793' AS DateTime2), N'225439b4-4c3a-4299-990e-72b72b4875c5', CAST(N'2020-06-24T07:04:49.5236793' AS DateTime2), N'225439b4-4c3a-4299-990e-72b72b4875c5', NULL, NULL, 3)
GO
INSERT [dbo].[Employees] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [PersonId]) VALUES (4, NULL, 0, CAST(N'2020-06-24T07:22:21.8532679' AS DateTime2), N'175a6b21-ecd1-4ed2-8875-49ff60dd6414', CAST(N'2020-06-24T07:22:21.8532679' AS DateTime2), N'175a6b21-ecd1-4ed2-8875-49ff60dd6414', NULL, NULL, 4)
GO
INSERT [dbo].[Employees] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [PersonId]) VALUES (5, NULL, 0, CAST(N'2020-06-24T08:13:11.1124402' AS DateTime2), N'175a6b21-ecd1-4ed2-8875-49ff60dd6414', CAST(N'2020-06-24T08:13:11.1124402' AS DateTime2), N'175a6b21-ecd1-4ed2-8875-49ff60dd6414', NULL, NULL, 6)
GO
INSERT [dbo].[Employees] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [PersonId]) VALUES (6, NULL, 0, CAST(N'2020-06-24T08:30:31.3630703' AS DateTime2), N'cbe2581e-7044-462a-8560-7490d68fd739', CAST(N'2020-06-24T08:30:31.3630703' AS DateTime2), N'cbe2581e-7044-462a-8560-7490d68fd739', NULL, NULL, 7)
GO
INSERT [dbo].[Employees] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [PersonId]) VALUES (7, NULL, 0, CAST(N'2020-07-01T11:26:11.3988856' AS DateTime2), N'beba71ef-5894-4ce1-9fb0-8bd1483d1908', CAST(N'2020-07-01T11:26:11.3988856' AS DateTime2), N'beba71ef-5894-4ce1-9fb0-8bd1483d1908', NULL, NULL, 9)
GO
SET IDENTITY_INSERT [dbo].[Employees] OFF
 
GO
SET IDENTITY_INSERT [dbo].[Doctors] ON 
GO
INSERT [dbo].[Doctors] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [PersonId], [Exequartur], [Cmd], [City]) VALUES (1, NULL, 0, CAST(N'2020-06-24T07:04:49.5188482' AS DateTime2), N'225439b4-4c3a-4299-990e-72b72b4875c5', CAST(N'2020-06-24T07:04:49.5188482' AS DateTime2), N'225439b4-4c3a-4299-990e-72b72b4875c5', NULL, NULL, 3, N'99-13', NULL, N'Santo Domingo')
GO
INSERT [dbo].[Doctors] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [PersonId], [Exequartur], [Cmd], [City]) VALUES (2, NULL, 0, CAST(N'2020-06-24T07:22:21.8515485' AS DateTime2), N'175a6b21-ecd1-4ed2-8875-49ff60dd6414', CAST(N'2020-06-24T07:22:21.8515485' AS DateTime2), N'175a6b21-ecd1-4ed2-8875-49ff60dd6414', NULL, NULL, 4, N'99-13', NULL, N'Santo Domingo')
GO
INSERT [dbo].[Doctors] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [PersonId], [Exequartur], [Cmd], [City]) VALUES (3, NULL, 0, CAST(N'2020-06-24T08:38:27.8695059' AS DateTime2), N'127beb63-74c2-4fef-9e28-6edcb2605a84', CAST(N'2020-06-24T08:38:27.8695059' AS DateTime2), N'127beb63-74c2-4fef-9e28-6edcb2605a84', NULL, NULL, 7, N'110-12', NULL, N'Santo Domingo')
GO
INSERT [dbo].[Doctors] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [PersonId], [Exequartur], [Cmd], [City]) VALUES (4, NULL, 0, CAST(N'2020-07-01T11:26:11.3976625' AS DateTime2), N'beba71ef-5894-4ce1-9fb0-8bd1483d1908', CAST(N'2020-07-01T11:26:11.3976625' AS DateTime2), N'beba71ef-5894-4ce1-9fb0-8bd1483d1908', NULL, NULL, 9, NULL, NULL, NULL)
GO
SET IDENTITY_INSERT [dbo].[Doctors] OFF
go
SET IDENTITY_INSERT [dbo].[Customers] ON 
GO
INSERT [dbo].[Customers] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [PersonId], [DebAmount], [CreditAmount], [WastedAmount]) VALUES (1, NULL, 0, CAST(N'2020-06-24T07:04:49.5157312' AS DateTime2), N'225439b4-4c3a-4299-990e-72b72b4875c5', CAST(N'2020-06-24T07:04:49.5157312' AS DateTime2), N'225439b4-4c3a-4299-990e-72b72b4875c5', NULL, NULL, 3, CAST(0.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)))
GO
INSERT [dbo].[Customers] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [PersonId], [DebAmount], [CreditAmount], [WastedAmount]) VALUES (2, NULL, 0, CAST(N'2020-06-24T07:22:21.8476018' AS DateTime2), N'175a6b21-ecd1-4ed2-8875-49ff60dd6414', CAST(N'2020-06-24T07:22:21.8476018' AS DateTime2), N'175a6b21-ecd1-4ed2-8875-49ff60dd6414', NULL, NULL, 4, CAST(0.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)))
GO
INSERT [dbo].[Customers] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [PersonId], [DebAmount], [CreditAmount], [WastedAmount]) VALUES (3, NULL, 0, CAST(N'2020-06-24T07:25:44.4478644' AS DateTime2), N'beba71ef-5894-4ce1-9fb0-8bd1483d1908', CAST(N'2020-06-24T07:25:44.4478644' AS DateTime2), N'beba71ef-5894-4ce1-9fb0-8bd1483d1908', NULL, NULL, 5, CAST(0.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)))
GO
INSERT [dbo].[Customers] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [PersonId], [DebAmount], [CreditAmount], [WastedAmount]) VALUES (4, NULL, 0, CAST(N'2020-06-24T08:13:11.1092497' AS DateTime2), N'175a6b21-ecd1-4ed2-8875-49ff60dd6414', CAST(N'2020-06-24T08:13:11.1092497' AS DateTime2), N'175a6b21-ecd1-4ed2-8875-49ff60dd6414', NULL, NULL, 6, CAST(0.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)))
GO
INSERT [dbo].[Customers] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [PersonId], [DebAmount], [CreditAmount], [WastedAmount]) VALUES (5, NULL, 0, CAST(N'2020-06-24T08:30:31.3603146' AS DateTime2), N'cbe2581e-7044-462a-8560-7490d68fd739', CAST(N'2020-06-24T08:30:31.3603146' AS DateTime2), N'cbe2581e-7044-462a-8560-7490d68fd739', NULL, NULL, 7, CAST(0.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)))
GO
INSERT [dbo].[Customers] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [PersonId], [DebAmount], [CreditAmount], [WastedAmount]) VALUES (7, NULL, 0, CAST(N'2020-07-01T11:26:11.3963626' AS DateTime2), N'beba71ef-5894-4ce1-9fb0-8bd1483d1908', CAST(N'2020-07-01T11:26:11.3963626' AS DateTime2), N'beba71ef-5894-4ce1-9fb0-8bd1483d1908', NULL, NULL, 9, CAST(0.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)))
GO
SET IDENTITY_INSERT [dbo].[Customers] OFF
go
SET IDENTITY_INSERT [dbo].[Bariatrics] ON 
GO
INSERT [dbo].[Bariatrics] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [PersonId], [InformativeDate], [ConsultationDate], [SurgeryDate], [Height], [Weight], [PreWeight], [Imc], [PreImc], [BodyFat], [Obesity], [ObesyYears], [ObesyKids], [MaxWeight], [Tabaco], [Alcohol], [Drugs], [KidsNumber], [ObesyChilds], [FamilySupport], [Diabetes], [Intolerancia], [ResistenciaInsulina], [Hipertension], [Cardiopatias], [Accidente], [Artropatia], [Trastornos], [CPap], [Hepatobiliary], [Carcinogenas], [Dislipemia], [HdLbaja], [PhysiologicalDisordersObstainers], [TabTrastornos], [TrastornosEndocrinos], [OtrasDepresion], [Cirugias], [HistoryComents], [ActualMedication], [AditionalMedication], [FamiliaryObesy], [FamiliaryHipertension], [FamiliaryDiabetes], [FamilaryCardiopatias], [FamilaryAlergias], [FamiliaryOthers], [FamiliaryComents], [TipoActividad], [HorasSemana], [Limitaciones], [Rxtorax], [SeriadaGd], [Veda], [BxparaH], [FuncionalRespiratorio], [Ecocardiograma], [RiesgoQuirurgico], [Polisomnografia], [EcografiaAbdominal], [EcodopplerVenoso], [OtrosPreQuirurgico], [EquipoQuirurgico], [TecnicaOperatoria], [DescripcionTecnica], [SuturasMecanicas], [BandaGastrica], [Marca], [Nro], [NroSerie], [ProcedimientosCombinados], [TiempQuirurgico], [Complicaciones], [Estadia], [RequirioUti], [Motivo], [EstadiaO], [Tolerancia], [Sgd], [ComplicacionesPost], [Emocional], [Enojo], [Ansiedad], [Soledad], [Depresion], [Aburrimiento], [Dulces], [Salados], [IngestaEmocional], [Solidos], [Liquidos], [Atracones], [Vomitos], [Purgas], [Ayuno], [Laxantes], [Ejercicio], [NotasNutricional]) VALUES (1, NULL, 0, CAST(N'2020-06-24T07:56:15.2344165' AS DateTime2), N'beba71ef-5894-4ce1-9fb0-8bd1483d1908', CAST(N'2020-06-24T07:56:15.2344165' AS DateTime2), N'beba71ef-5894-4ce1-9fb0-8bd1483d1908', NULL, NULL, 5, CAST(N'2020-06-24T00:00:00.0000000' AS DateTime2), CAST(N'2020-06-24T00:00:00.0000000' AS DateTime2), CAST(N'2020-06-24T00:00:00.0000000' AS DateTime2), NULL, NULL, NULL, NULL, NULL, NULL, 0, NULL, 0, NULL, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, NULL, NULL, NULL, 0, 0, 0, 0, 0, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 0, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 0, NULL, NULL, NULL, NULL, NULL, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, N'Historia Bariatrica de prueba en las cuales se pueden agregar cosas de prueba')
GO
SET IDENTITY_INSERT [dbo].[Bariatrics] OFF
GO
SET IDENTITY_INSERT [dbo].[AnalyticalSheets] ON 
GO
INSERT [dbo].[AnalyticalSheets] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [PersonId], [AnalyticalSheetDate], [Hemograma], [ConteodePlaquetas], [ConteodeReticulocitos], [ConteodeEosinofilos], [Eritrosedimentacion], [Falcemia], [InvdeHematozoarias], [InvdeCelulasFalciformes], [TiempodeSangria], [TiempodeCoagulacion], [RetracciondeCoagulo], [FragilidadEntrocitica], [Tp], [Ttp], [Fibrinogeno], [TiempodeTrombina], [PruebadeEmbarazo], [UroanalisisCompleto], [Espermatograma], [Cultivo], [Coprologico], [EstudiodeDigestion], [InvdeSangreoculta], [AcidoUrico], [AcidoValproico], [AlfaAmilasaPancreatica], [Amilasa], [Bilirrubina], [ColesterolTotal], [Hdl], [Ldl], [Vldl], [Creatinina], [Calcio], [DepuraciondeCreatinina], [Fosforo], [GlucosaAyunas], [GlucosaPostPrandial], [GlucosaCurvaHoras], [Ggpt], [Glubotinas], [HemoglobinaGlicosilada], [HierroCaptacionFijacion], [LipidosTotales], [Magnesio], [MicroalbuminaCualitativa], [Sgotast], [Sgptalt], [Trigiceridos], [UreaNitrgenada], [Bun], [Acth], [AcidoFolico], [Alfafetoproteina], [AntiHav], [AntiHaVlgM], [AntiHbc], [AntiHbe], [AntiHbs], [Hhcg], [Cea], [Ca125], [Ca153], [Ca199], [ClamidialgG], [ClamidialgM], [CortisolAm], [CortisolPm], [DimeroD], [DenguelgG], [DenguelgM], [EpsteinBarrlgM], [EpsteinBarrlgG], [ElectroforesisdeHemoglobina], [ElectDeProteinas], [Estradiol], [EstrogenosTotales], [Ferritina], [Hiv], [HerpesIyIIlgG], [HerpesIyIIlgM], [HormonadeCrecimientoBasal], [HormonadeCrecPostEstimulo], [HbeAg], [Insulina], [InsulinaBasal], [InsulinaPostPandrial], [Lh], [Progesterona], [Prolactina], [T3], [T3Libre], [T4], [T4Libre], [Tiroglubolina], [ToxolgG], [ToxolgM], [Transferrina], [VitaminaB12], [Tsh], [Cetos], [Oh], [Fsh], [Vma], [AntigenosFebriles], [AsoCuantitativo], [AgAustraliano], [BhcgCuantitativo], [Ftaabs], [LgAInmunoglobina], [LgGInmunoglobina], [LgE], [LgMInmunoglobina], [PcRdealtaSensibilidad], [Tipificacion], [TestdeCommbsDirecto], [TestdeCommbsIndirecto], [Vdrl], [VdrLenLcr], [BaciloscopiadeEsputo], [BaciloscopiaenOrina], [CultivoSecUretral], [CultivoSecVaginal], [CultivoSecdeHerida], [CultivoSecAbsceso], [CultivoSecSemen], [Coprocultivo], [Hemocultivo], [Urocultivo], [Hba1C], [Bd], [Tc], [Igm], [Urea], [ProteinasTotales], [Estradial], [Ldh], [Tgo], [Trigliceridos], [Sodio], [Hbsag], [Rubeola], [Tgp], [BilTotal], [Pcr], [Toxoplasmosis], [Potasio], [CultivoVagin], [Bhcg], [Glisemia], [Bi], [Ftabs], [Igg], [Hcg], [Hto], [Hb], [RtoGb], [AcUrico], [Fal], [Proteinas], [Homa], [Tg], [Pth], [VitD], [AcFolico], [Ferremia], [B1], [B6], [Zinc], [Paratohormona], [Panel4], [Litemia], [Tpt], [Lipasa], [FosAlcalina], [Albumina], [PeptidoC], [BilD], [BilI], [AntiHvc], [Orina], [Hcc], [Observations], [DoctorText], [PatientName]) VALUES (1, NULL, 0, CAST(N'2020-06-24T07:50:24.3739804' AS DateTime2), N'beba71ef-5894-4ce1-9fb0-8bd1483d1908', CAST(N'2020-06-24T07:50:24.3739804' AS DateTime2), N'beba71ef-5894-4ce1-9fb0-8bd1483d1908', NULL, NULL, 5, CAST(N'2020-06-07T00:00:00.0000000' AS DateTime2), 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, N'Estas son observaciones de prueba realizadas a un envio de analitica de prueba', N'Tomas Aquino', N'Paciente de Prueba Para Probar')
GO
SET IDENTITY_INSERT [dbo].[AnalyticalSheets] OFF
GO
SET IDENTITY_INSERT [dbo].[Appointments] ON 
GO
INSERT [dbo].[Appointments] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [VisitDate], [VisitReason], [WasSend], [Notes], [PersonId], [DoctorId], [SpecialityId], [TandaId], [TandaId1]) VALUES (1, NULL, 0, CAST(N'2020-06-24T07:41:22.3212924' AS DateTime2), N'beba71ef-5894-4ce1-9fb0-8bd1483d1908', CAST(N'2020-06-24T07:41:22.3212924' AS DateTime2), N'beba71ef-5894-4ce1-9fb0-8bd1483d1908', NULL, NULL, CAST(N'2020-06-04T10:00:00.0000000' AS DateTime2), N'Una cita de prueba para realizar una consulta de prueba que nos servira para probar cosas', 0, N'Esta es una observacion de prueba que se realiza a la cita de prueba, en caso de que queramos indicarle observaciones al paciente, como que debe venir en ayudas o que debe tomarse algun medicamento o no tomar alimentos etc.', 5, 1, 1, 1, NULL)
GO
SET IDENTITY_INSERT [dbo].[Appointments] OFF
go

SET IDENTITY_INSERT [dbo].[Groups] ON 
GO
INSERT [dbo].[Groups] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [Code], [SubjectId], [EmployeeId]) VALUES (1, N'20-01-04-0463', 0, CAST(N'2020-05-09T12:13:39.4585096' AS DateTime2), N'225439b4-4c3a-4299-990e-72b72b4875c5', CAST(N'2020-05-09T12:13:39.4585096' AS DateTime2), N'225439b4-4c3a-4299-990e-72b72b4875c5', NULL, NULL, N'20-01-04-0463', 1, 3)
GO
INSERT [dbo].[Groups] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [Code], [SubjectId], [EmployeeId]) VALUES (2, N'20-01-04-0462', 0, CAST(N'2020-05-09T12:14:09.5126290' AS DateTime2), N'225439b4-4c3a-4299-990e-72b72b4875c5', CAST(N'2020-05-09T12:14:09.5126290' AS DateTime2), N'225439b4-4c3a-4299-990e-72b72b4875c5', NULL, NULL, N'20-01-04-0462', 1, 5)
GO
INSERT [dbo].[Groups] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [Code], [SubjectId], [EmployeeId]) VALUES (3, N'20-01-04-0461', 0, CAST(N'2020-05-09T12:14:26.5677914' AS DateTime2), N'225439b4-4c3a-4299-990e-72b72b4875c5', CAST(N'2020-05-09T12:14:26.5677914' AS DateTime2), N'225439b4-4c3a-4299-990e-72b72b4875c5', NULL, NULL, N'20-01-04-0461', 1, 3)
GO
INSERT [dbo].[Groups] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [Code], [SubjectId], [EmployeeId]) VALUES (4, N'20-01-04-0908', 0, CAST(N'2020-05-09T12:14:48.8602425' AS DateTime2), N'225439b4-4c3a-4299-990e-72b72b4875c5', CAST(N'2020-05-09T12:14:48.8602425' AS DateTime2), N'225439b4-4c3a-4299-990e-72b72b4875c5', NULL, NULL, N'20-01-04-0908', 2, 3)
GO
INSERT [dbo].[Groups] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [Code], [SubjectId], [EmployeeId]) VALUES (5, N'20-04-08-0908', 0, CAST(N'2020-05-09T12:15:50.2482373' AS DateTime2), N'225439b4-4c3a-4299-990e-72b72b4875c5', CAST(N'2020-05-09T12:15:50.2482373' AS DateTime2), N'225439b4-4c3a-4299-990e-72b72b4875c5', NULL, NULL, N'20-04-08-0908', 4, 6)
GO
SET IDENTITY_INSERT [dbo].[Groups] OFF
go
SET IDENTITY_INSERT [dbo].[Forums] ON 
GO
INSERT [dbo].[Forums] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [Content], [PosiblePoints], [Description], [DateStart], [DateEnd], [GroupId]) VALUES (1, N'Q&A', 0, CAST(N'2020-05-09T12:13:39.4592367' AS DateTime2), N'225439b4-4c3a-4299-990e-72b72b4875c5', CAST(N'2020-05-09T12:13:39.4592367' AS DateTime2), N'225439b4-4c3a-4299-990e-72b72b4875c5', NULL, NULL, N'Use este espacio para hacer sus preguntas y dudas generales que tenga respecto a la seccion', 0, N'Foro de Preguntas y Respuestas', NULL, NULL, 1)
GO
INSERT [dbo].[Forums] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [Content], [PosiblePoints], [Description], [DateStart], [DateEnd], [GroupId]) VALUES (2, N'Q&A', 0, CAST(N'2020-05-09T12:14:09.5177890' AS DateTime2), N'225439b4-4c3a-4299-990e-72b72b4875c5', CAST(N'2020-05-09T12:14:09.5177890' AS DateTime2), N'225439b4-4c3a-4299-990e-72b72b4875c5', NULL, NULL, N'Use este espacio para hacer sus preguntas y dudas generales que tenga respecto a la seccion', 0, N'Foro de Preguntas y Respuestas', NULL, NULL, 2)
GO
INSERT [dbo].[Forums] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [Content], [PosiblePoints], [Description], [DateStart], [DateEnd], [GroupId]) VALUES (3, N'Q&A', 0, CAST(N'2020-05-09T12:14:26.5683228' AS DateTime2), N'225439b4-4c3a-4299-990e-72b72b4875c5', CAST(N'2020-05-09T12:14:26.5683228' AS DateTime2), N'225439b4-4c3a-4299-990e-72b72b4875c5', NULL, NULL, N'Use este espacio para hacer sus preguntas y dudas generales que tenga respecto a la seccion', 0, N'Foro de Preguntas y Respuestas', NULL, NULL, 3)
GO
INSERT [dbo].[Forums] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [Content], [PosiblePoints], [Description], [DateStart], [DateEnd], [GroupId]) VALUES (4, N'Q&A', 0, CAST(N'2020-05-09T12:14:48.8617858' AS DateTime2), N'225439b4-4c3a-4299-990e-72b72b4875c5', CAST(N'2020-05-09T12:14:48.8617858' AS DateTime2), N'225439b4-4c3a-4299-990e-72b72b4875c5', NULL, NULL, N'Use este espacio para hacer sus preguntas y dudas generales que tenga respecto a la seccion', 0, N'Foro de Preguntas y Respuestas', NULL, NULL, 4)
GO
INSERT [dbo].[Forums] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [Content], [PosiblePoints], [Description], [DateStart], [DateEnd], [GroupId]) VALUES (5, N'Q&A', 0, CAST(N'2020-05-09T12:15:50.2690506' AS DateTime2), N'225439b4-4c3a-4299-990e-72b72b4875c5', CAST(N'2020-05-09T12:15:50.2690506' AS DateTime2), N'225439b4-4c3a-4299-990e-72b72b4875c5', NULL, NULL, N'Use este espacio para hacer sus preguntas y dudas generales que tenga respecto a la seccion', 0, N'Foro de Preguntas y Respuestas', NULL, NULL, 5)
GO
SET IDENTITY_INSERT [dbo].[Forums] OFF
go

SET IDENTITY_INSERT [dbo].[OwnerPlans] ON 
GO
INSERT [dbo].[OwnerPlans] ([Id], [Name], [OwnerId], [PlanId]) VALUES (1, NULL, 1, 1)
GO
SET IDENTITY_INSERT [dbo].[OwnerPlans] OFF
go

SET IDENTITY_INSERT [dbo].[PlanTransactions] ON 
GO
INSERT [dbo].[PlanTransactions] ([Id], [Name], [Amount], [Date], [Megabytes], [Registers], [UserPosibility], [CurrencyId], [PaymentTypeId], [OwnerPlanId]) VALUES (1, NULL, CAST(10.00 AS Decimal(12, 2)), CAST(N'2020-07-03T01:02:57.0263626' AS DateTime2), 5, 500, 5, 1, 1, 1)
GO
SET IDENTITY_INSERT [dbo].[PlanTransactions] OFF
go

SET IDENTITY_INSERT [dbo].[Schedules] ON 
GO
INSERT [dbo].[Schedules] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [ScheduleFormatId], [GroupId], [DateStart], [DateEnd], [Description], [PlaceId]) VALUES (1, N'Clase Presencial', 0, CAST(N'2020-05-09T12:37:38.0134017' AS DateTime2), N'225439b4-4c3a-4299-990e-72b72b4875c5', CAST(N'2020-05-09T12:37:38.0134017' AS DateTime2), N'225439b4-4c3a-4299-990e-72b72b4875c5', NULL, NULL, 4, 3, CAST(N'2020-01-13T18:45:00.0000000' AS DateTime2), CAST(N'2020-04-13T21:45:00.0000000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[Schedules] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [ScheduleFormatId], [GroupId], [DateStart], [DateEnd], [Description], [PlaceId]) VALUES (2, N'Inicio de Semana de Examenes', 0, CAST(N'2020-05-09T12:39:17.9957651' AS DateTime2), N'225439b4-4c3a-4299-990e-72b72b4875c5', CAST(N'2020-05-09T12:39:17.9957651' AS DateTime2), N'225439b4-4c3a-4299-990e-72b72b4875c5', NULL, NULL, 1, 3, CAST(N'2020-04-20T00:00:00.0000000' AS DateTime2), CAST(N'2020-04-20T00:00:00.0000000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[Schedules] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [ScheduleFormatId], [GroupId], [DateStart], [DateEnd], [Description], [PlaceId]) VALUES (3, N'Clases Presenciales', 0, CAST(N'2020-05-09T12:41:46.3458057' AS DateTime2), N'225439b4-4c3a-4299-990e-72b72b4875c5', CAST(N'2020-05-09T12:41:46.3458057' AS DateTime2), N'225439b4-4c3a-4299-990e-72b72b4875c5', NULL, NULL, 5, 2, CAST(N'2020-01-07T00:00:00.0000000' AS DateTime2), CAST(N'2020-04-28T12:59:00.0000000' AS DateTime2), NULL, NULL)
GO
SET IDENTITY_INSERT [dbo].[Schedules] OFF


insert into LotteryModes values ('Quiniela', 1,1)
go
insert into LotteryModes values ('Pale', 2,2)
go
insert into LotteryModes values ('Tripleta', 3,3)
go



");

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
