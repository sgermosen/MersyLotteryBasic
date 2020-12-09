USE [master]
GO
/****** Object:  Database [lotteryfm]    Script Date: 12/9/2020 1:41:21 PM ******/
CREATE DATABASE [lotteryfm]
       
GO
USE [lotteryfm]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 12/9/2020 1:41:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetRoleClaims]    Script Date: 12/9/2020 1:41:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetRoleClaims](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[RoleId] [nvarchar](450) NOT NULL,
	[ClaimType] [nvarchar](max) NULL,
	[ClaimValue] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetRoleClaims] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetRoles]    Script Date: 12/9/2020 1:41:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetRoles](
	[Id] [nvarchar](450) NOT NULL,
	[Name] [nvarchar](256) NULL,
	[NormalizedName] [nvarchar](256) NULL,
	[ConcurrencyStamp] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetRoles] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserClaims]    Script Date: 12/9/2020 1:41:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserClaims](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UserId] [nvarchar](450) NOT NULL,
	[ClaimType] [nvarchar](max) NULL,
	[ClaimValue] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetUserClaims] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserLogins]    Script Date: 12/9/2020 1:41:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserLogins](
	[LoginProvider] [nvarchar](450) NOT NULL,
	[ProviderKey] [nvarchar](450) NOT NULL,
	[ProviderDisplayName] [nvarchar](max) NULL,
	[UserId] [nvarchar](450) NOT NULL,
 CONSTRAINT [PK_AspNetUserLogins] PRIMARY KEY CLUSTERED 
(
	[LoginProvider] ASC,
	[ProviderKey] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserRoles]    Script Date: 12/9/2020 1:41:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserRoles](
	[UserId] [nvarchar](450) NOT NULL,
	[RoleId] [nvarchar](450) NOT NULL,
 CONSTRAINT [PK_AspNetUserRoles] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC,
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUsers]    Script Date: 12/9/2020 1:41:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUsers](
	[Id] [nvarchar](450) NOT NULL,
	[UserName] [nvarchar](256) NULL,
	[NormalizedUserName] [nvarchar](256) NULL,
	[Email] [nvarchar](256) NOT NULL,
	[NormalizedEmail] [nvarchar](256) NULL,
	[EmailConfirmed] [bit] NOT NULL,
	[PasswordHash] [nvarchar](max) NULL,
	[SecurityStamp] [nvarchar](max) NULL,
	[ConcurrencyStamp] [nvarchar](max) NULL,
	[PhoneNumber] [nvarchar](max) NULL,
	[PhoneNumberConfirmed] [bit] NOT NULL,
	[TwoFactorEnabled] [bit] NOT NULL,
	[LockoutEnd] [datetimeoffset](7) NULL,
	[LockoutEnabled] [bit] NOT NULL,
	[AccessFailedCount] [int] NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Address] [nvarchar](150) NULL,
	[Comission] [int] NOT NULL,
	[IsExternal] [bit] NOT NULL,
	[OwnerId] [bigint] NULL,
	[ComissionSupervisor] [int] NOT NULL,
	[IsAdmin] [bit] NOT NULL,
	[IsCobrator] [bit] NOT NULL,
	[IsOperator] [bit] NOT NULL,
	[IsSeller] [bit] NOT NULL,
	[IsSupervisor] [bit] NOT NULL,
	[Nickname] [nvarchar](max) NULL,
	[TakeCommision] [bit] NOT NULL,
	[Imagen] [nvarchar](max) NULL,
	[IsDisabled] [bit] NOT NULL,
 CONSTRAINT [PK_AspNetUsers] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserTokens]    Script Date: 12/9/2020 1:41:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserTokens](
	[UserId] [nvarchar](450) NOT NULL,
	[LoginProvider] [nvarchar](450) NOT NULL,
	[Name] [nvarchar](450) NOT NULL,
	[Value] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetUserTokens] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC,
	[LoginProvider] ASC,
	[Name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Currencies]    Script Date: 12/9/2020 1:41:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Currencies](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NULL,
	[Code] [nvarchar](max) NULL,
 CONSTRAINT [PK_Currencies] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Lotteries]    Script Date: 12/9/2020 1:41:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Lotteries](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NULL,
	[Code] [nvarchar](max) NOT NULL,
	[CloseHour] [datetime2](7) NOT NULL,
	[ColorInHex] [nvarchar](max) NULL,
	[LotteryFromId] [bigint] NOT NULL,
	[Loto1First] [decimal](18, 2) NOT NULL,
	[Loto1Second] [decimal](18, 2) NOT NULL,
	[Loto1Third] [decimal](18, 2) NOT NULL,
	[Loto2First] [decimal](18, 2) NOT NULL,
	[Loto2Second] [decimal](18, 2) NOT NULL,
	[Loto3First] [decimal](18, 2) NOT NULL,
	[Loto3Second] [decimal](18, 2) NOT NULL,
	[Loto4First] [decimal](18, 2) NOT NULL,
	[Available] [bit] NOT NULL,
 CONSTRAINT [PK_Lotteries] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LotteryFroms]    Script Date: 12/9/2020 1:41:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LotteryFroms](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NULL,
 CONSTRAINT [PK_LotteryFroms] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LotteryModes]    Script Date: 12/9/2020 1:41:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LotteryModes](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NULL,
	[PlayableNumber] [int] NOT NULL,
	[AwardedNumber] [int] NOT NULL,
	[Code] [nvarchar](max) NULL,
 CONSTRAINT [PK_LotteryModes] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LotteryResults]    Script Date: 12/9/2020 1:41:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LotteryResults](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NULL,
	[Deleted] [bit] NOT NULL,
	[CreatedAt] [datetime2](7) NULL,
	[CreatedBy] [nvarchar](450) NULL,
	[UpdatedAt] [datetime2](7) NULL,
	[UpdatedBy] [nvarchar](450) NULL,
	[DeletedAt] [datetime2](7) NULL,
	[DeletedBy] [nvarchar](450) NULL,
	[LotteryId] [bigint] NOT NULL,
	[Date] [datetime2](7) NOT NULL,
	[FirstValue] [nvarchar](max) NOT NULL,
	[SecondValue] [nvarchar](max) NOT NULL,
	[ThirdValue] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_LotteryResults] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LotterySaleItems]    Script Date: 12/9/2020 1:41:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LotterySaleItems](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NULL,
	[Deleted] [bit] NOT NULL,
	[CreatedAt] [datetime2](7) NULL,
	[CreatedBy] [nvarchar](450) NULL,
	[UpdatedAt] [datetime2](7) NULL,
	[UpdatedBy] [nvarchar](450) NULL,
	[DeletedAt] [datetime2](7) NULL,
	[DeletedBy] [nvarchar](450) NULL,
	[LotterySaleId] [bigint] NOT NULL,
	[LotteryModeId] [bigint] NOT NULL,
	[LotteryId] [bigint] NOT NULL,
	[PlayedAmount] [decimal](12, 2) NOT NULL,
	[Played1] [nvarchar](max) NULL,
	[Played2] [nvarchar](max) NULL,
	[Played3] [nvarchar](max) NULL,
	[PlayedNumbers] [nvarchar](max) NULL,
	[Prize] [decimal](18, 2) NOT NULL,
	[Prize1] [decimal](18, 2) NOT NULL,
	[Prize2] [decimal](18, 2) NOT NULL,
	[Prize3] [decimal](18, 2) NOT NULL,
 CONSTRAINT [PK_LotterySaleItems] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LotterySales]    Script Date: 12/9/2020 1:41:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LotterySales](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NULL,
	[Deleted] [bit] NOT NULL,
	[CreatedAt] [datetime2](7) NULL,
	[CreatedBy] [nvarchar](450) NULL,
	[UpdatedAt] [datetime2](7) NULL,
	[UpdatedBy] [nvarchar](450) NULL,
	[DeletedAt] [datetime2](7) NULL,
	[DeletedBy] [nvarchar](450) NULL,
	[Ticket] [nvarchar](max) NULL,
	[Barcode] [nvarchar](max) NULL,
	[TotalAmount] [decimal](12, 2) NOT NULL,
	[SeqByOwner] [int] NOT NULL,
	[SeqByShop] [int] NOT NULL,
	[Remarks] [nvarchar](max) NULL,
	[Prize] [decimal](12, 2) NOT NULL,
	[WasPaid] [bit] NOT NULL,
	[Anulated] [bit] NOT NULL,
	[Winner] [bit] NOT NULL,
	[AnulatedSol] [bit] NOT NULL,
 CONSTRAINT [PK_LotterySales] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LotterySchedules]    Script Date: 12/9/2020 1:41:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LotterySchedules](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NULL,
	[Deleted] [bit] NOT NULL,
	[CreatedAt] [datetime2](7) NULL,
	[CreatedBy] [nvarchar](450) NULL,
	[UpdatedAt] [datetime2](7) NULL,
	[UpdatedBy] [nvarchar](450) NULL,
	[DeletedAt] [datetime2](7) NULL,
	[DeletedBy] [nvarchar](450) NULL,
	[LotteryId] [bigint] NOT NULL,
	[DayOfTheWeek] [int] NOT NULL,
	[CloseHour] [datetime2](7) NOT NULL,
	[InactiveDate] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_LotterySchedules] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[OptionModules]    Script Date: 12/9/2020 1:41:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OptionModules](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NULL,
	[Description] [nvarchar](100) NOT NULL,
	[Area] [nvarchar](25) NULL,
	[Controller] [nvarchar](25) NULL,
	[Action] [nvarchar](25) NULL,
	[Link] [nvarchar](100) NULL,
	[Order] [int] NOT NULL,
	[Class] [nvarchar](100) NULL,
	[ImageUrl] [nvarchar](max) NULL,
	[Icon] [nvarchar](max) NULL,
 CONSTRAINT [PK_OptionModules] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Options]    Script Date: 12/9/2020 1:41:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Options](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NULL,
	[Description] [nvarchar](100) NOT NULL,
	[Link] [nvarchar](100) NULL,
	[Area] [nvarchar](25) NULL,
	[Controller] [nvarchar](25) NULL,
	[Action] [nvarchar](25) NULL,
	[Order] [int] NOT NULL,
	[Class] [nvarchar](100) NULL,
	[ImageUrl] [nvarchar](max) NULL,
	[Icon] [nvarchar](max) NULL,
	[OptionModuleId] [bigint] NOT NULL,
	[PlanId] [bigint] NULL,
 CONSTRAINT [PK_Options] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[OwnerPlans]    Script Date: 12/9/2020 1:41:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OwnerPlans](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NULL,
	[OwnerId] [bigint] NOT NULL,
	[PlanId] [bigint] NOT NULL,
 CONSTRAINT [PK_OwnerPlans] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Owners]    Script Date: 12/9/2020 1:41:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Owners](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](100) NOT NULL,
	[Rnc] [nvarchar](max) NULL,
	[Code] [nvarchar](max) NULL,
	[LastName] [nvarchar](100) NOT NULL,
	[Email] [nvarchar](50) NOT NULL,
	[WebAddress] [nvarchar](max) NULL,
	[Address] [nvarchar](max) NULL,
	[Imagen] [nvarchar](max) NULL,
	[Tel] [nvarchar](15) NULL,
	[PrefixExp] [nvarchar](10) NULL,
	[PrefixFact] [nvarchar](15) NULL,
	[PrefixOrder] [nvarchar](10) NULL,
	[StartDate] [datetime2](7) NULL,
	[PrefixNcf] [nvarchar](16) NULL,
	[SeqNcf] [int] NULL,
	[PrefixFinalFact] [nvarchar](18) NULL,
	[NcfEnds] [nvarchar](25) NULL,
	[SeqFact] [int] NULL,
	[Header1] [nvarchar](100) NULL,
	[Header2] [nvarchar](100) NULL,
	[Header3] [nvarchar](100) NULL,
	[Footer1] [nvarchar](100) NULL,
	[Footer2] [nvarchar](100) NULL,
	[Footer3] [nvarchar](100) NULL,
	[UsersAvailable] [int] NOT NULL,
	[MegabytesAvailable] [int] NOT NULL,
	[RegitersAvailable] [int] NOT NULL,
	[PlanActiveUntil] [datetime2](7) NULL,
	[OwnerTypeId] [bigint] NULL,
	[SeqNcfGub] [int] NOT NULL,
	[PrefixNcfGub] [nvarchar](max) NULL,
	[IsActive] [bit] NOT NULL,
	[UserNameInReport] [bit] NOT NULL,
 CONSTRAINT [PK_Owners] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[OwnerTypes]    Script Date: 12/9/2020 1:41:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OwnerTypes](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NULL,
 CONSTRAINT [PK_OwnerTypes] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Payments]    Script Date: 12/9/2020 1:41:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Payments](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NULL,
	[Deleted] [bit] NOT NULL,
	[CreatedAt] [datetime2](7) NULL,
	[CreatedBy] [nvarchar](450) NULL,
	[UpdatedAt] [datetime2](7) NULL,
	[UpdatedBy] [nvarchar](450) NULL,
	[DeletedAt] [datetime2](7) NULL,
	[DeletedBy] [nvarchar](450) NULL,
	[LotterySaleId] [bigint] NULL,
	[Date] [datetime2](7) NULL,
	[Remarks] [nvarchar](200) NULL,
	[ReceivedAmount] [decimal](12, 2) NULL,
	[DevolvedAmount] [decimal](12, 2) NULL,
	[Amountx] [decimal](12, 2) NOT NULL,
	[Type] [bigint] NOT NULL,
	[ComissionAmount] [decimal](18, 2) NOT NULL,
	[SupervisorAmount] [decimal](18, 2) NOT NULL,
 CONSTRAINT [PK_Payments] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PaymentTypes]    Script Date: 12/9/2020 1:41:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PaymentTypes](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NULL,
	[Code] [nvarchar](10) NOT NULL,
 CONSTRAINT [PK_PaymentTypes] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Periodicities]    Script Date: 12/9/2020 1:41:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Periodicities](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NULL,
	[Code] [nvarchar](max) NULL,
 CONSTRAINT [PK_Periodicities] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PlanOption]    Script Date: 12/9/2020 1:41:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PlanOption](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NULL,
	[PlanId] [bigint] NOT NULL,
	[OptionId] [bigint] NOT NULL,
	[OptionModuleId] [bigint] NULL,
 CONSTRAINT [PK_PlanOption] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Plans]    Script Date: 12/9/2020 1:41:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Plans](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NULL,
	[Amount] [decimal](12, 2) NOT NULL,
	[CurrencyId] [bigint] NOT NULL,
	[PeriodicityId] [bigint] NOT NULL,
	[Megabytes] [int] NOT NULL,
	[UserPosibility] [int] NOT NULL,
	[RegiterCount] [int] NOT NULL,
 CONSTRAINT [PK_Plans] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PlanTransactions]    Script Date: 12/9/2020 1:41:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PlanTransactions](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NULL,
	[Amount] [decimal](12, 2) NOT NULL,
	[Date] [datetime2](7) NOT NULL,
	[Megabytes] [int] NOT NULL,
	[Registers] [int] NOT NULL,
	[UserPosibility] [int] NOT NULL,
	[CurrencyId] [bigint] NOT NULL,
	[PaymentTypeId] [bigint] NOT NULL,
	[OwnerPlanId] [bigint] NOT NULL,
 CONSTRAINT [PK_PlanTransactions] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PrizePayments]    Script Date: 12/9/2020 1:41:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PrizePayments](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NULL,
	[Deleted] [bit] NOT NULL,
	[CreatedAt] [datetime2](7) NULL,
	[CreatedBy] [nvarchar](450) NULL,
	[UpdatedAt] [datetime2](7) NULL,
	[UpdatedBy] [nvarchar](450) NULL,
	[DeletedAt] [datetime2](7) NULL,
	[DeletedBy] [nvarchar](450) NULL,
	[Amount] [decimal](12, 2) NOT NULL,
	[Date] [datetime2](7) NULL,
	[SellerId] [nvarchar](450) NULL,
	[UseSupervisorAmount] [bit] NOT NULL,
	[PreviousSupervisorAmount] [decimal](18, 2) NOT NULL,
 CONSTRAINT [PK_PrizePayments] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Status]    Script Date: 12/9/2020 1:41:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Status](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NULL,
	[Table] [nvarchar](max) NULL,
 CONSTRAINT [PK_Status] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20200818173217_Initialization', N'2.2.6-servicing-10079')
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20200818193336_InitialData', N'2.2.6-servicing-10079')
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20200820155202_GettingTickets', N'2.2.6-servicing-10079')
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20200827114833_PlayNumbers', N'2.2.6-servicing-10079')
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20200829122053_Restrictions', N'2.2.6-servicing-10079')
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20200829144639_RestrictionsUsers', N'2.2.6-servicing-10079')
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20200829215048_CleaningResult', N'2.2.6-servicing-10079')
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20200829223519_PaymentPrize', N'2.2.6-servicing-10079')
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20200902084740_UserShop', N'2.2.6-servicing-10079')
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20200905002321_FixOnCashier', N'2.2.6-servicing-10079')
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20200909134636_RefactoringEntities', N'2.2.6-servicing-10079')
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20200909175212_RemovingHour', N'2.2.6-servicing-10079')
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20200910101622_AddingCode', N'2.2.6-servicing-10079')
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20200913114723_AddingSelectOnTicket', N'2.2.6-servicing-10079')
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20200913152743_FromLotteryToRestrictions', N'2.2.6-servicing-10079')
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20200913152909_DataTFromLottery', N'2.2.6-servicing-10079')
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20200916134932_AddingFather', N'3.1.8')
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20200916214408_AddingF', N'3.1.8')
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20200918211435_RestructureOfLottery', N'3.1.8')
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20200919121731_ChangingNumbersToString', N'3.1.8')
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20200919175916_RemoveSomePayments', N'3.1.8')
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20200921191931_UserRestructure', N'3.1.8')
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20200923004841_RemovePeople', N'3.1.8')
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20200923023612_RemoveLastname', N'3.1.8')
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20201005040343_RemovingDetailsNumberse', N'3.1.8')
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20201005213450_AddingThingsToLottery', N'3.1.8')
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20201006013012_AddingPrizeToItemsy', N'3.1.8')
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20201017190136_ChangeAvailable', N'3.1.8')
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20201018022053_DisableUsere', N'3.1.8')
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20201018043956_CreatingCuadree', N'3.1.8')
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20201018185729_AddingValuesToCuadree', N'3.1.8')
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20201019012431_CuadreRestructure', N'3.1.8')
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20201019050830_CuadreFinalRestructure', N'3.1.8')
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20201019233521_RemoveDateture', N'3.1.8')
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20201021193754_NewTablese', N'3.1.8')
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20201021204813_PrizePaymente', N'3.1.8')
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20201027215637_PrizeSegmentede', N'3.1.8')
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20201104010715_SolRemove', N'3.1.8')
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20201209165118_RemovingToShare', N'3.1.8')
GO
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
INSERT [dbo].[AspNetRoles] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'd65d7a94-1829-4644-9268-feb41725a45b', N'Seller', N'SELLER', N'60e31468-0eed-47c9-84a7-8f6b22f8ac1a')
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
INSERT [dbo].[AspNetUserClaims] ([Id], [UserId], [ClaimType], [ClaimValue]) VALUES (10, N'74dffedd-b38f-40a4-9806-0bda7b3277f5', N'OwnerId', N'5')
GO
INSERT [dbo].[AspNetUserClaims] ([Id], [UserId], [ClaimType], [ClaimValue]) VALUES (11, N'7e6a6b22-870c-4764-aca7-eafc78205e6f', N'OwnerId', N'5')
GO
INSERT [dbo].[AspNetUserClaims] ([Id], [UserId], [ClaimType], [ClaimValue]) VALUES (12, N'5fd14b9a-e90b-4784-9a86-29fd2c3b2488', N'OwnerId', N'5')
GO
INSERT [dbo].[AspNetUserClaims] ([Id], [UserId], [ClaimType], [ClaimValue]) VALUES (13, N'bebee6d5-6024-493c-b0af-75b766aff12d', N'OwnerId', N'5')
GO
INSERT [dbo].[AspNetUserClaims] ([Id], [UserId], [ClaimType], [ClaimValue]) VALUES (14, N'71f1cd55-742e-47db-8ed0-43bbf5665a0a', N'OwnerId', N'5')
GO
INSERT [dbo].[AspNetUserClaims] ([Id], [UserId], [ClaimType], [ClaimValue]) VALUES (15, N'a5a98f46-a697-41a5-b2f6-5d38cb129548', N'OwnerId', N'5')
GO
INSERT [dbo].[AspNetUserClaims] ([Id], [UserId], [ClaimType], [ClaimValue]) VALUES (16, N'a83c99a3-1b2e-464d-ad3b-72d773960375', N'OwnerId', N'5')
GO
INSERT [dbo].[AspNetUserClaims] ([Id], [UserId], [ClaimType], [ClaimValue]) VALUES (17, N'3db67221-31cd-4eba-b9ec-f49f2a7b28b1', N'OwnerId', N'5')
GO
INSERT [dbo].[AspNetUserClaims] ([Id], [UserId], [ClaimType], [ClaimValue]) VALUES (18, N'e55b8336-e346-432a-af74-d59606bf09bf', N'OwnerId', N'5')
GO
INSERT [dbo].[AspNetUserClaims] ([Id], [UserId], [ClaimType], [ClaimValue]) VALUES (19, N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', N'OwnerId', N'5')
GO
INSERT [dbo].[AspNetUserClaims] ([Id], [UserId], [ClaimType], [ClaimValue]) VALUES (20, N'c42fe951-65d3-4035-8acc-7f8ccd892cdd', N'OwnerId', N'5')
GO
INSERT [dbo].[AspNetUserClaims] ([Id], [UserId], [ClaimType], [ClaimValue]) VALUES (21, N'9c3c13b4-f4de-409b-a264-92ccb28b532d', N'OwnerId', N'5')
GO
INSERT [dbo].[AspNetUserClaims] ([Id], [UserId], [ClaimType], [ClaimValue]) VALUES (22, N'49bee3c9-fce9-4c25-b1bc-c5e0cfde8aa9', N'OwnerId', N'5')
GO
INSERT [dbo].[AspNetUserClaims] ([Id], [UserId], [ClaimType], [ClaimValue]) VALUES (23, N'aeb07043-b3c1-4ecc-a728-208ee584ee26', N'OwnerId', N'5')
GO
INSERT [dbo].[AspNetUserClaims] ([Id], [UserId], [ClaimType], [ClaimValue]) VALUES (24, N'0475b2fd-03f2-4b3e-8d13-cd13c15af367', N'OwnerId', N'5')
GO
INSERT [dbo].[AspNetUserClaims] ([Id], [UserId], [ClaimType], [ClaimValue]) VALUES (25, N'6c9db330-a7a8-4224-bad2-e2ecf2490149', N'OwnerId', N'5')
GO
INSERT [dbo].[AspNetUserClaims] ([Id], [UserId], [ClaimType], [ClaimValue]) VALUES (26, N'00c10492-090a-4f70-a0cd-e38ac8d3b4d9', N'OwnerId', N'5')
GO
INSERT [dbo].[AspNetUserClaims] ([Id], [UserId], [ClaimType], [ClaimValue]) VALUES (27, N'9490fe8c-1fe4-442e-8c69-04db71592da7', N'OwnerId', N'5')
GO
INSERT [dbo].[AspNetUserClaims] ([Id], [UserId], [ClaimType], [ClaimValue]) VALUES (28, N'e0d8b459-38dd-425f-8109-0968dcc502db', N'OwnerId', N'5')
GO
SET IDENTITY_INSERT [dbo].[AspNetUserClaims] OFF
GO
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'00c10492-090a-4f70-a0cd-e38ac8d3b4d9', N'160e2ca4-d166-4bb4-a7f0-c2e038d6abbf')
GO
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'0475b2fd-03f2-4b3e-8d13-cd13c15af367', N'160e2ca4-d166-4bb4-a7f0-c2e038d6abbf')
GO
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'127beb63-74c2-4fef-9e28-6edcb2605a84', N'160e2ca4-d166-4bb4-a7f0-c2e038d6abbf')
GO
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'175a6b21-ecd1-4ed2-8875-49ff60dd6414', N'160e2ca4-d166-4bb4-a7f0-c2e038d6abbf')
GO
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'3417c47c-c25d-4888-a094-6751c431bea2', N'160e2ca4-d166-4bb4-a7f0-c2e038d6abbf')
GO
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'3db67221-31cd-4eba-b9ec-f49f2a7b28b1', N'160e2ca4-d166-4bb4-a7f0-c2e038d6abbf')
GO
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'49bee3c9-fce9-4c25-b1bc-c5e0cfde8aa9', N'160e2ca4-d166-4bb4-a7f0-c2e038d6abbf')
GO
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'5fd14b9a-e90b-4784-9a86-29fd2c3b2488', N'160e2ca4-d166-4bb4-a7f0-c2e038d6abbf')
GO
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'6c9db330-a7a8-4224-bad2-e2ecf2490149', N'160e2ca4-d166-4bb4-a7f0-c2e038d6abbf')
GO
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', N'160e2ca4-d166-4bb4-a7f0-c2e038d6abbf')
GO
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'71f1cd55-742e-47db-8ed0-43bbf5665a0a', N'160e2ca4-d166-4bb4-a7f0-c2e038d6abbf')
GO
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'74dffedd-b38f-40a4-9806-0bda7b3277f5', N'160e2ca4-d166-4bb4-a7f0-c2e038d6abbf')
GO
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'7e6a6b22-870c-4764-aca7-eafc78205e6f', N'160e2ca4-d166-4bb4-a7f0-c2e038d6abbf')
GO
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'8f28e0bb-fab9-4fb7-a4ae-2a5e2ab17b6b', N'160e2ca4-d166-4bb4-a7f0-c2e038d6abbf')
GO
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'9490fe8c-1fe4-442e-8c69-04db71592da7', N'160e2ca4-d166-4bb4-a7f0-c2e038d6abbf')
GO
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'9c3c13b4-f4de-409b-a264-92ccb28b532d', N'160e2ca4-d166-4bb4-a7f0-c2e038d6abbf')
GO
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'a5a98f46-a697-41a5-b2f6-5d38cb129548', N'160e2ca4-d166-4bb4-a7f0-c2e038d6abbf')
GO
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'a83c99a3-1b2e-464d-ad3b-72d773960375', N'160e2ca4-d166-4bb4-a7f0-c2e038d6abbf')
GO
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'aeb07043-b3c1-4ecc-a728-208ee584ee26', N'160e2ca4-d166-4bb4-a7f0-c2e038d6abbf')
GO
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'beba71ef-5894-4ce1-9fb0-8bd1483d1908', N'160e2ca4-d166-4bb4-a7f0-c2e038d6abbf')
GO
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'bebee6d5-6024-493c-b0af-75b766aff12d', N'160e2ca4-d166-4bb4-a7f0-c2e038d6abbf')
GO
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'c42fe951-65d3-4035-8acc-7f8ccd892cdd', N'160e2ca4-d166-4bb4-a7f0-c2e038d6abbf')
GO
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'cbe2581e-7044-462a-8560-7490d68fd739', N'160e2ca4-d166-4bb4-a7f0-c2e038d6abbf')
GO
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'e0d8b459-38dd-425f-8109-0968dcc502db', N'160e2ca4-d166-4bb4-a7f0-c2e038d6abbf')
GO
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'e55b8336-e346-432a-af74-d59606bf09bf', N'160e2ca4-d166-4bb4-a7f0-c2e038d6abbf')
GO
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'175a6b21-ecd1-4ed2-8875-49ff60dd6414', N'326ec5da-8e43-40e2-a5d4-38ff913eb41d')
GO
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'74dffedd-b38f-40a4-9806-0bda7b3277f5', N'326ec5da-8e43-40e2-a5d4-38ff913eb41d')
GO
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'8f28e0bb-fab9-4fb7-a4ae-2a5e2ab17b6b', N'326ec5da-8e43-40e2-a5d4-38ff913eb41d')
GO
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'beba71ef-5894-4ce1-9fb0-8bd1483d1908', N'326ec5da-8e43-40e2-a5d4-38ff913eb41d')
GO
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'175a6b21-ecd1-4ed2-8875-49ff60dd6414', N'3ad0ee1b-2f93-4535-9940-5b318f407c48')
GO
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'74dffedd-b38f-40a4-9806-0bda7b3277f5', N'3ad0ee1b-2f93-4535-9940-5b318f407c48')
GO
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'8f28e0bb-fab9-4fb7-a4ae-2a5e2ab17b6b', N'3ad0ee1b-2f93-4535-9940-5b318f407c48')
GO
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'beba71ef-5894-4ce1-9fb0-8bd1483d1908', N'3ad0ee1b-2f93-4535-9940-5b318f407c48')
GO
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'49bee3c9-fce9-4c25-b1bc-c5e0cfde8aa9', N'47a091fe-9535-45f1-bc20-de8cb66acadc')
GO
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'e55b8336-e346-432a-af74-d59606bf09bf', N'47a091fe-9535-45f1-bc20-de8cb66acadc')
GO
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'127beb63-74c2-4fef-9e28-6edcb2605a84', N'69a618c6-64d2-41d2-af6e-a1cd008bfbd5')
GO
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'175a6b21-ecd1-4ed2-8875-49ff60dd6414', N'69a618c6-64d2-41d2-af6e-a1cd008bfbd5')
GO
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'74dffedd-b38f-40a4-9806-0bda7b3277f5', N'69a618c6-64d2-41d2-af6e-a1cd008bfbd5')
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
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'00c10492-090a-4f70-a0cd-e38ac8d3b4d9', N'ce7b0eb1-57ee-439d-9acf-6934c8b28a4e')
GO
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'127beb63-74c2-4fef-9e28-6edcb2605a84', N'ce7b0eb1-57ee-439d-9acf-6934c8b28a4e')
GO
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'175a6b21-ecd1-4ed2-8875-49ff60dd6414 ', N'ce7b0eb1-57ee-439d-9acf-6934c8b28a4e')
GO
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'225439b4-4c3a-4299-990e-72b72b4875c5', N'ce7b0eb1-57ee-439d-9acf-6934c8b28a4e')
GO
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'3f9bca09-60eb-4a21-8128-0662d970a8c8', N'ce7b0eb1-57ee-439d-9acf-6934c8b28a4e')
GO
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'6c9db330-a7a8-4224-bad2-e2ecf2490149', N'ce7b0eb1-57ee-439d-9acf-6934c8b28a4e')
GO
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'74dffedd-b38f-40a4-9806-0bda7b3277f5', N'ce7b0eb1-57ee-439d-9acf-6934c8b28a4e')
GO
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'9c3c13b4-f4de-409b-a264-92ccb28b532d', N'ce7b0eb1-57ee-439d-9acf-6934c8b28a4e')
GO
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'beba71ef-5894-4ce1-9fb0-8bd1483d1908', N'ce7b0eb1-57ee-439d-9acf-6934c8b28a4e')
GO
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'c42fe951-65d3-4035-8acc-7f8ccd892cdd', N'ce7b0eb1-57ee-439d-9acf-6934c8b28a4e')
GO
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'cbe2581e-7044-462a-8560-7490d68fd739', N'ce7b0eb1-57ee-439d-9acf-6934c8b28a4e')
GO
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'e0d8b459-38dd-425f-8109-0968dcc502db', N'ce7b0eb1-57ee-439d-9acf-6934c8b28a4e')
GO
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'0475b2fd-03f2-4b3e-8d13-cd13c15af367', N'd65d7a94-1829-4644-9268-feb41725a45b')
GO
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'225439b4-4c3a-4299-990e-72b72b4875c5', N'd65d7a94-1829-4644-9268-feb41725a45b')
GO
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', N'd65d7a94-1829-4644-9268-feb41725a45b')
GO
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'71f1cd55-742e-47db-8ed0-43bbf5665a0a', N'd65d7a94-1829-4644-9268-feb41725a45b')
GO
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'74dffedd-b38f-40a4-9806-0bda7b3277f5', N'd65d7a94-1829-4644-9268-feb41725a45b')
GO
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'9490fe8c-1fe4-442e-8c69-04db71592da7', N'd65d7a94-1829-4644-9268-feb41725a45b')
GO
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'a5a98f46-a697-41a5-b2f6-5d38cb129548', N'd65d7a94-1829-4644-9268-feb41725a45b')
GO
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'a83c99a3-1b2e-464d-ad3b-72d773960375', N'd65d7a94-1829-4644-9268-feb41725a45b')
GO
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'aeb07043-b3c1-4ecc-a728-208ee584ee26', N'd65d7a94-1829-4644-9268-feb41725a45b')
GO
INSERT [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount], [Name], [Address], [Comission], [IsExternal], [OwnerId], [ComissionSupervisor], [IsAdmin], [IsCobrator], [IsOperator], [IsSeller], [IsSupervisor], [Nickname], [TakeCommision], [Imagen], [IsDisabled]) VALUES (N'00c10492-090a-4f70-a0cd-e38ac8d3b4d9', N'xx@mersyrd.com', N'XX@MERSYRD.COM', N'xx@mersyrd.com', N'XX@MERSYRD.COM', 1, N'AQAAAAEAACcQAAAAENolOFGZyfCwLpmIqjb1VZINcIjEClVcSV1HvmkzxTiranX80Ht/ZQL/vzJQst9rTQ==', N'NAHGCSURHO3PMU5OOOPG62A7CWLI73VY', N'2e87c57e-66e4-4a61-a402-9761982a8735', N'(222) 222-2222', 0, 0, NULL, 1, 0, N'xx', NULL, 0, 0, 5, 0, 1, 0, 0, 0, 0, NULL, 0, NULL, 0)
GO
INSERT [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount], [Name], [Address], [Comission], [IsExternal], [OwnerId], [ComissionSupervisor], [IsAdmin], [IsCobrator], [IsOperator], [IsSeller], [IsSupervisor], [Nickname], [TakeCommision], [Imagen], [IsDisabled]) VALUES (N'0475b2fd-03f2-4b3e-8d13-cd13c15af367', N'regio@gmail.com', N'REGIO@GMAIL.COM', N'regio@gmail.com', N'REGIO@GMAIL.COM', 1, N'AQAAAAEAACcQAAAAEEM5Mdq1D0DhSYmYdQMLsUhJ7FJtNEMhmmndYk1vdWpLrZCgpPVcafjvPScQqrx6MQ==', N'YJT2F4J7WLYCOC4D54DCOLECFOAXPW7A', N'f9c2292a-b8f1-4549-abf9-62f5c35be0eb', NULL, 0, 0, NULL, 1, 0, N'Juan Alberto', NULL, 0, 0, 5, 0, 0, 0, 0, 1, 0, N'EMPRESA LA SOLIDARIA', 0, NULL, 0)
GO
INSERT [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount], [Name], [Address], [Comission], [IsExternal], [OwnerId], [ComissionSupervisor], [IsAdmin], [IsCobrator], [IsOperator], [IsSeller], [IsSupervisor], [Nickname], [TakeCommision], [Imagen], [IsDisabled]) VALUES (N'127beb63-74c2-4fef-9e28-6edcb2605a84', N'yolivarez@hotmail.es', N'YOLIVAREZ@HOTMAIL.ES', N'yolivarez@hotmail.es', N'YOLIVAREZ@HOTMAIL.ES', 1, N'AQAAAAEAACcQAAAAEHSu9RnYrJdQhqxAVYguQR/0L/9oZhw32atAVsgy9iuwYX8cFaKTTcmyXwbJq7exrw==', N'SVRUYOXRGPUHPXYNCLN4PBZIK3OW5DTP', N'a655ec3e-78f7-43aa-b051-b401f502afa0', NULL, 0, 0, NULL, 1, 0, N'Yahaira', NULL, 5, 0, 2, 0, 0, 0, 0, 1, 0, NULL, 0, NULL, 0)
GO
INSERT [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount], [Name], [Address], [Comission], [IsExternal], [OwnerId], [ComissionSupervisor], [IsAdmin], [IsCobrator], [IsOperator], [IsSeller], [IsSupervisor], [Nickname], [TakeCommision], [Imagen], [IsDisabled]) VALUES (N'175a6b21-ecd1-4ed2-8875-49ff60dd6414', N'owner01@mersyrd.com', N'OWNER01@MERSYRD.COM', N'owner01@mersyrd.com', N'OWNER01@MERSYRD.COM', 1, N'AQAAAAEAACcQAAAAEEAFudfQZEWVWHvEDLUrloZQtqHHfRhf0uCJJnoLkZM5ikjGxLWd2LqGwLwr7ecTTQ==', N'7R6LYXIQW343FJACWQHZITVWRFSGO5LP', N'6e4f3336-43ad-41fc-b812-341af50d9ca0', NULL, 0, 0, NULL, 1, 0, N'Mersy', NULL, 5, 0, 1, 0, 0, 0, 0, 1, 0, NULL, 0, NULL, 0)
GO
INSERT [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount], [Name], [Address], [Comission], [IsExternal], [OwnerId], [ComissionSupervisor], [IsAdmin], [IsCobrator], [IsOperator], [IsSeller], [IsSupervisor], [Nickname], [TakeCommision], [Imagen], [IsDisabled]) VALUES (N'225439b4-4c3a-4299-990e-72b72b4875c5', N'mersyrd@gmail.com', N'MERSYRD@GMAIL.COM', N'mersyrd@gmail.com', N'MERSYRD@GMAIL.COM', 1, N'AQAAAAEAACcQAAAAEDYFi8F/8BzywkT2PwyT6MYm98GcgmXwHP3MU4uNuwWB2wpcW4zuf6Sev6mL6ND6Wg==', N'EJ7TJFRSIKYDJD76RRFJ2G2TSSYMGBRU', N'de3310ad-765f-400f-b0b4-371644918035', N'849 207 7714', 0, 0, NULL, 1, 0, N'Mersy', NULL, 5, 0, 1, 0, 0, 0, 0, 1, 0, NULL, 0, NULL, 0)
GO
INSERT [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount], [Name], [Address], [Comission], [IsExternal], [OwnerId], [ComissionSupervisor], [IsAdmin], [IsCobrator], [IsOperator], [IsSeller], [IsSupervisor], [Nickname], [TakeCommision], [Imagen], [IsDisabled]) VALUES (N'3417c47c-c25d-4888-a094-6751c431bea2', N'3e6acefe-3d12-498a-ba2f-238ea709be4b@mersyrd.com', N'3E6ACEFE-3D12-498A-BA2F-238EA709BE4B@MERSYRD.COM', N'3e6acefe-3d12-498a-ba2f-238ea709be4b@mersyrd.com', N'3E6ACEFE-3D12-498A-BA2F-238EA709BE4B@MERSYRD.COM', 1, N'AQAAAAEAACcQAAAAEIHxJa8GDOXY0BCkoCi1cgCo7lOcrBlwjMv5ZoK1RkkG1EKpyRGN0bbhNp/dx9F3RA==', N'AATLYHFET3BJTVMETM37QHLNVV27ZEF3', N'cc4ade44-a1b6-4c6c-9540-08de231b2310', NULL, 0, 0, NULL, 1, 0, N'Paciente de Prueba', NULL, 5, 0, 1, 0, 0, 0, 0, 1, 0, NULL, 0, NULL, 0)
GO
INSERT [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount], [Name], [Address], [Comission], [IsExternal], [OwnerId], [ComissionSupervisor], [IsAdmin], [IsCobrator], [IsOperator], [IsSeller], [IsSupervisor], [Nickname], [TakeCommision], [Imagen], [IsDisabled]) VALUES (N'3db67221-31cd-4eba-b9ec-f49f2a7b28b1', N'almont@kk.com', N'ALMONT@KK.COM', N'almont@kk.com', N'ALMONT@KK.COM', 1, N'AQAAAAEAACcQAAAAEFR7o8vrKiIUCj2/OVJJaNqa5a1Kwl3GKbTXf95tkbqr5Mdd6CeGbiOYIac+cW2Kvw==', N'3O7QLHKBC5Z25UL573LHP73IL3KFF7QH', N'8da3605f-b5ee-4bc0-8294-d40e71a85b5a', N'(333) 333-3333', 0, 0, NULL, 1, 0, N'juan', NULL, 0, 0, 5, 0, 0, 0, 0, 1, 0, NULL, 0, NULL, 1)
GO
INSERT [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount], [Name], [Address], [Comission], [IsExternal], [OwnerId], [ComissionSupervisor], [IsAdmin], [IsCobrator], [IsOperator], [IsSeller], [IsSupervisor], [Nickname], [TakeCommision], [Imagen], [IsDisabled]) VALUES (N'3f9bca09-60eb-4a21-8128-0662d970a8c8', N'mersycore@gmail.com', N'MERSYCORE@GMAIL.COM', N'mersycore@gmail.com', N'MERSYCORE@GMAIL.COM', 1, N'AQAAAAEAACcQAAAAEKRjbwFu8BgKtY+yFlTqpIzWXLVfupkdw58SthyQSpK59eVleOLizbtLt++ON/MvHw==', N'4TXJFRJDSW32TYNRIK5SGC4CZK7FPJWP', N'0f63e3d8-4730-49ee-a745-a91ea2b16371', N'wwww', 0, 0, NULL, 1, 0, N'Mersy', NULL, 5, 0, 2, 0, 0, 0, 0, 1, 0, NULL, 0, NULL, 0)
GO
INSERT [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount], [Name], [Address], [Comission], [IsExternal], [OwnerId], [ComissionSupervisor], [IsAdmin], [IsCobrator], [IsOperator], [IsSeller], [IsSupervisor], [Nickname], [TakeCommision], [Imagen], [IsDisabled]) VALUES (N'49bee3c9-fce9-4c25-b1bc-c5e0cfde8aa9', N'xxww@asds.com', N'XXWW@ASDS.COM', N'xxww@asds.com', N'XXWW@ASDS.COM', 1, N'AQAAAAEAACcQAAAAEApgtaSYWU39UTDl7grrE/auLmLwz61EkiIQaoJmk60M6aIWFrqhz1l2mf52hlVOlg==', N'HN5RZM7GTMFSBCBZEBBWF3SDA625WDPZ', N'44e4d1c5-1136-4b5d-b6cd-0f7adbb875c9', NULL, 0, 0, NULL, 1, 0, N'xx', NULL, 0, 0, 5, 0, 0, 0, 0, 0, 1, NULL, 0, NULL, 0)
GO
INSERT [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount], [Name], [Address], [Comission], [IsExternal], [OwnerId], [ComissionSupervisor], [IsAdmin], [IsCobrator], [IsOperator], [IsSeller], [IsSupervisor], [Nickname], [TakeCommision], [Imagen], [IsDisabled]) VALUES (N'5fd14b9a-e90b-4784-9a86-29fd2c3b2488', N'edinolfifa17@gmail.com', N'EDINOLFIFA17@GMAIL.COM', N'edinolfifa17@gmail.com', N'EDINOLFIFA17@GMAIL.COM', 1, N'AQAAAAEAACcQAAAAECX/dKP2PSuzKVOJBkVLzyQIT6ahhDQw8yUiLb4Ds0qrwq3BXb+L4zCI4FyGVgitBA==', N'P2BO5OAJDT6FX4TC2J5CSY2RXPPVZS6N', N'bea3cdbb-27b7-48aa-8508-dac8e8f834a2', N'(000) 000-0000', 0, 0, NULL, 1, 0, N'Bernarda', NULL, 0, 0, 5, 0, 1, 0, 0, 1, 0, NULL, 0, NULL, 1)
GO
INSERT [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount], [Name], [Address], [Comission], [IsExternal], [OwnerId], [ComissionSupervisor], [IsAdmin], [IsCobrator], [IsOperator], [IsSeller], [IsSupervisor], [Nickname], [TakeCommision], [Imagen], [IsDisabled]) VALUES (N'6c9db330-a7a8-4224-bad2-e2ecf2490149', N'sg@gmail.com', N'SG@GMAIL.COM', N'sg@gmail.com', N'SG@GMAIL.COM', 1, N'AQAAAAEAACcQAAAAEA8bgDtAHD1NQX4N6+fjJEyuRB7KX/45+56RCDyWkN5bRE9UTeVa7+pj+FOelSR9Tw==', N'YMFORQCH6UIL6FG4LQE6VNM5NEBMBP53', N'66911049-5bcf-49d4-9def-34b3cfff8cfa', NULL, 0, 0, NULL, 1, 0, N'EMPRESA SOLIDARIA', NULL, 0, 0, 5, 0, 1, 0, 0, 0, 0, NULL, 0, NULL, 0)
GO
INSERT [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount], [Name], [Address], [Comission], [IsExternal], [OwnerId], [ComissionSupervisor], [IsAdmin], [IsCobrator], [IsOperator], [IsSeller], [IsSupervisor], [Nickname], [TakeCommision], [Imagen], [IsDisabled]) VALUES (N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', N'carlos@gmail.com', N'CARLOS@GMAIL.COM', N'carlos@gmail.com', N'CARLOS@GMAIL.COM', 1, N'AQAAAAEAACcQAAAAEL50XIOFWaMHI5r1EqCwt7fmiswxJ1ta5rf5RWAaUT96viPzksPjs6F42+URg/o/mQ==', N'QN2BSGVJM2HQ6RWSMZNPYEO3BEGC4PHS', N'98318768-ceef-4bc1-b0f9-3038323b6878', N'(222) 222-2222', 0, 0, NULL, 1, 0, N'Carlos', N'calle', 15, 0, 5, 0, 0, 0, 0, 1, 0, N'LACONFIANCE V DE LOS RIOS', 0, NULL, 0)
GO
INSERT [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount], [Name], [Address], [Comission], [IsExternal], [OwnerId], [ComissionSupervisor], [IsAdmin], [IsCobrator], [IsOperator], [IsSeller], [IsSupervisor], [Nickname], [TakeCommision], [Imagen], [IsDisabled]) VALUES (N'71f1cd55-742e-47db-8ed0-43bbf5665a0a', N'222@222.com', N'222@222.COM', N'222@222.com', N'222@222.COM', 1, N'AQAAAAEAACcQAAAAEAlknyYe+FNLpWcWGgNfcSK1JGyjS0+e4Q+GGdEnt8ogxmHbpncC/mASCigqf9xBig==', N'KVCMXJNEOOLGXZCOZPW5OR4LE3YJCYGO', N'db30213a-3481-4f24-8be9-231f1d30ee24', N'(222) 222-2222', 0, 0, NULL, 1, 0, N'ddd', NULL, 0, 0, 5, 0, 0, 0, 0, 1, 0, N'ddxx', 0, NULL, 1)
GO
INSERT [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount], [Name], [Address], [Comission], [IsExternal], [OwnerId], [ComissionSupervisor], [IsAdmin], [IsCobrator], [IsOperator], [IsSeller], [IsSupervisor], [Nickname], [TakeCommision], [Imagen], [IsDisabled]) VALUES (N'74dffedd-b38f-40a4-9806-0bda7b3277f5', N'juan@gmail.com', N'JUAN@GMAIL.COM', N'juan@gmail.com', N'JUAN@GMAIL.COM', 1, N'AQAAAAEAACcQAAAAEMMHNuxK1Zz9x+Z22yMEeWsU2tqkti3/VZJE/YIkmePWVEtF3I30OiMoyvmMcCXzSw==', N'S6DOCFUB3ZZLQSMWK3KD5NDB5INJDDOD', N'0b09413b-fbb7-4e35-a3ed-896863bcb37f', N'(849) 207-7714', 0, 0, NULL, 1, 0, N'Juanx', NULL, 0, 0, 5, 0, 0, 0, 0, 1, 0, NULL, 0, NULL, 0)
GO
INSERT [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount], [Name], [Address], [Comission], [IsExternal], [OwnerId], [ComissionSupervisor], [IsAdmin], [IsCobrator], [IsOperator], [IsSeller], [IsSupervisor], [Nickname], [TakeCommision], [Imagen], [IsDisabled]) VALUES (N'7e6a6b22-870c-4764-aca7-eafc78205e6f', N'externo@gmail.com', N'EXTERNO@GMAIL.COM', N'externo@gmail.com', N'EXTERNO@GMAIL.COM', 1, N'AQAAAAEAACcQAAAAEJ8TLi89BtZDQkvLdD6qr9jt1qCYkND9QS8Ow6DdJcLHaJ7Kl+TV86e+1MJJw7iR/g==', N'GNAHX22YR5YIWVE7DJQEBOCK57WGENCO', N'28f26e79-c172-41a0-a303-18650c2845e2', NULL, 0, 0, NULL, 1, 0, N'La', NULL, 0, 0, 5, 0, 0, 0, 0, 1, 0, NULL, 0, NULL, 1)
GO
INSERT [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount], [Name], [Address], [Comission], [IsExternal], [OwnerId], [ComissionSupervisor], [IsAdmin], [IsCobrator], [IsOperator], [IsSeller], [IsSupervisor], [Nickname], [TakeCommision], [Imagen], [IsDisabled]) VALUES (N'8f28e0bb-fab9-4fb7-a4ae-2a5e2ab17b6b', N'sgrysoft@gmail.com', N'SGRYSOFT@GMAIL.COM', N'sgrysoft@gmail.com', N'SGRYSOFT@GMAIL.COM', 1, N'AQAAAAEAACcQAAAAEIyWaIh1BjDN7mcicEvjOSzy28mfhccUAZcyHbxjgjfnoXbzsRT7vFNzapK5ndz1OA==', N'MEJLR2BKQKKXXBGUVZT7RDRQOSTPP4JV', N'03d2b768-9938-416d-9437-a27c46e4e980', NULL, 0, 0, NULL, 1, 0, N'Starling', NULL, 5, 0, 1, 0, 0, 0, 0, 1, 0, NULL, 0, NULL, 0)
GO
INSERT [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount], [Name], [Address], [Comission], [IsExternal], [OwnerId], [ComissionSupervisor], [IsAdmin], [IsCobrator], [IsOperator], [IsSeller], [IsSupervisor], [Nickname], [TakeCommision], [Imagen], [IsDisabled]) VALUES (N'9490fe8c-1fe4-442e-8c69-04db71592da7', N'yy@mersyrd.com', N'YY@MERSYRD.COM', N'yy@mersyrd.com', N'YY@MERSYRD.COM', 1, N'AQAAAAEAACcQAAAAEGbCcU0P0ya8ZexpncXzyKsLh5MQtixKN4BS17PRq28VVFLyZ0W3xidhpX6BHbKmvg==', N'P375BQ2P7X75D6A7M2OB5NHYL4HWHJ52', N'1b4f0003-00e2-402e-aa4a-e53a8b9ad1a5', NULL, 0, 0, NULL, 1, 0, N'yy', NULL, 0, 0, 5, 0, 0, 0, 0, 1, 0, N'yy', 0, NULL, 0)
GO
INSERT [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount], [Name], [Address], [Comission], [IsExternal], [OwnerId], [ComissionSupervisor], [IsAdmin], [IsCobrator], [IsOperator], [IsSeller], [IsSupervisor], [Nickname], [TakeCommision], [Imagen], [IsDisabled]) VALUES (N'9c3c13b4-f4de-409b-a264-92ccb28b532d', N'adms0@gmail.com', N'ADMS0@GMAIL.COM', N'adms0@gmail.com', N'ADMS0@GMAIL.COM', 1, N'AQAAAAEAACcQAAAAEEF+d1QiP87P3kRZYMS7riD2+Fo7DQtkJ8ymFyuZt6+b93Fh9YRPIEaL4f1zHb29Nw==', N'EPKNA3VAEZNW7457I67R3LMYQL7RYXHG', N'8c661057-4b77-497b-96b5-0b263b841807', N'(333) 333-3333', 0, 0, NULL, 1, 0, N'Admin 000', NULL, 0, 0, 5, 0, 1, 0, 0, 0, 0, NULL, 0, NULL, 0)
GO
INSERT [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount], [Name], [Address], [Comission], [IsExternal], [OwnerId], [ComissionSupervisor], [IsAdmin], [IsCobrator], [IsOperator], [IsSeller], [IsSupervisor], [Nickname], [TakeCommision], [Imagen], [IsDisabled]) VALUES (N'a5a98f46-a697-41a5-b2f6-5d38cb129548', N'eee@kk.com', N'EEE@KK.COM', N'eee@kk.com', N'EEE@KK.COM', 1, N'AQAAAAEAACcQAAAAENaq9fr6kixvLUoOwl8oOrONVi1x35Oj6yn2C144FFw3u2fTummKkVU33BZDsezygg==', N'Z767ZI3DGVZNHFCCEML72TN57J2QTYFR', N'73c87be6-5e17-418f-990b-d83d30c0eeb6', NULL, 0, 0, NULL, 1, 0, N'kkk', NULL, 0, 0, 5, 0, 0, 0, 0, 1, 0, N'kkk', 0, NULL, 1)
GO
INSERT [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount], [Name], [Address], [Comission], [IsExternal], [OwnerId], [ComissionSupervisor], [IsAdmin], [IsCobrator], [IsOperator], [IsSeller], [IsSupervisor], [Nickname], [TakeCommision], [Imagen], [IsDisabled]) VALUES (N'a83c99a3-1b2e-464d-ad3b-72d773960375', N'elya@iii.com', N'ELYA@III.COM', N'elya@iii.com', N'ELYA@III.COM', 1, N'AQAAAAEAACcQAAAAECoJ+UwwpzZc0dRDMeGTzvPVIvDn9vouNrST03aFDeap6uYPCIClZ0BDqImvvxnirw==', N'A7ZXRCP6Z5XGWRKVNN4T4PBZLDYXBVT5', N'e079e6f9-2717-4700-bfd0-d9eed42b477e', NULL, 0, 0, NULL, 1, 0, N'LACONFIANCE VENECIA', NULL, 0, 0, 5, 0, 0, 0, 0, 1, 0, N'LACONFIANCE VENECIA', 0, NULL, 0)
GO
INSERT [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount], [Name], [Address], [Comission], [IsExternal], [OwnerId], [ComissionSupervisor], [IsAdmin], [IsCobrator], [IsOperator], [IsSeller], [IsSupervisor], [Nickname], [TakeCommision], [Imagen], [IsDisabled]) VALUES (N'aeb07043-b3c1-4ecc-a728-208ee584ee26', N'asdas@sdas.com', N'ASDAS@SDAS.COM', N'asdas@sdas.com', N'ASDAS@SDAS.COM', 1, N'AQAAAAEAACcQAAAAEPkpApyyPUzVBQELYkkinPW8cT4GH9lXbOAyeMIrK11s32qvPUZzTH4SYeVdhsj6Lg==', N'4K4AIM5EUEJBIO3E3BIUP3MT6HIPXET4', N'914070bd-c271-4f1e-81b6-9fe7cdb79bf0', NULL, 0, 0, NULL, 1, 0, N'asdas@sdas.com', NULL, 0, 0, 5, 0, 0, 0, 0, 1, 0, N'sad', 0, NULL, 0)
GO
INSERT [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount], [Name], [Address], [Comission], [IsExternal], [OwnerId], [ComissionSupervisor], [IsAdmin], [IsCobrator], [IsOperator], [IsSeller], [IsSupervisor], [Nickname], [TakeCommision], [Imagen], [IsDisabled]) VALUES (N'beba71ef-5894-4ce1-9fb0-8bd1483d1908', N'tomasaquinomf@hotmail.com', N'TOMASAQUINOMF@HOTMAIL.COM', N'tomasaquinomf@hotmail.com', N'TOMASAQUINOMF@HOTMAIL.COM', 1, N'AQAAAAEAACcQAAAAEGqVLei93JhEX8Qj1MMw/X773oqfwzLgss/vdKp56LnRrfysFEe7l9qYRKKP770oCw==', N'5BUWPRM6NZXZE7B4MOIUWVEJ3YRIPHIH', N'f07b01c7-004c-4b36-b460-1595c470cdc5', NULL, 0, 0, NULL, 1, 0, N'Tomas', NULL, 5, 0, 1, 0, 0, 0, 0, 1, 0, NULL, 0, NULL, 0)
GO
INSERT [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount], [Name], [Address], [Comission], [IsExternal], [OwnerId], [ComissionSupervisor], [IsAdmin], [IsCobrator], [IsOperator], [IsSeller], [IsSupervisor], [Nickname], [TakeCommision], [Imagen], [IsDisabled]) VALUES (N'bebee6d5-6024-493c-b0af-75b766aff12d', N'sgr@ooo.com', N'SGR@OOO.COM', N'sgr@ooo.com', N'SGR@OOO.COM', 1, N'AQAAAAEAACcQAAAAEI6YYtJ2BypYoNH7k7AsgH4rAvCw2AVQURIIs/CyZ4QGrWrYneFWGC4i+ObCXONAaA==', N'RFTM2IJ2RKKA4ZUJKK4FAMYNO4KZOBFN', N'cf89b573-f50c-4e7c-8459-216a251af6ec', N'(999) 999-9999', 0, 0, NULL, 1, 0, N'almonte', NULL, 0, 0, 5, 0, 0, 0, 0, 1, 0, N'albert', 0, NULL, 1)
GO
INSERT [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount], [Name], [Address], [Comission], [IsExternal], [OwnerId], [ComissionSupervisor], [IsAdmin], [IsCobrator], [IsOperator], [IsSeller], [IsSupervisor], [Nickname], [TakeCommision], [Imagen], [IsDisabled]) VALUES (N'c42fe951-65d3-4035-8acc-7f8ccd892cdd', N'adm0@gmail.com', N'ADM0@GMAIL.COM', N'adm0@gmail.com', N'ADM0@GMAIL.COM', 1, N'AQAAAAEAACcQAAAAEN9xp4d8NYypFUPELv6AMr67O2Kvxh8U4kON1PDxH7Cs7OsGeVPiXgvRfyZ586S+7A==', N'4LRWUI7OXNLKRBRG6SDJE7NBW6TNMXH7', N'9b469fc1-84dd-4434-a35b-2d17b2b5106f', N'(333) 333-3333', 0, 0, NULL, 1, 0, N'Admin 000', NULL, 0, 0, 5, 0, 1, 0, 0, 0, 0, NULL, 0, NULL, 0)
GO
INSERT [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount], [Name], [Address], [Comission], [IsExternal], [OwnerId], [ComissionSupervisor], [IsAdmin], [IsCobrator], [IsOperator], [IsSeller], [IsSupervisor], [Nickname], [TakeCommision], [Imagen], [IsDisabled]) VALUES (N'cbe2581e-7044-462a-8560-7490d68fd739', N'owner02@mersyrd.com', N'OWNER02@MERSYRD.COM', N'owner02@mersyrd.com', N'OWNER02@MERSYRD.COM', 1, N'AQAAAAEAACcQAAAAEOMqTJv3AYhexAbkkfTyAFBkQEFxWJenNiaWiF3HvMWzLFVv/GCtqYgW7bdBsyIZpw==', N'NI6HEZYETZOS54OIPQF3F3275QEJRNFW', N'ece401e4-b171-4b23-b92a-ef4489f9a9ed', NULL, 0, 0, NULL, 1, 0, N'Owner 02', NULL, 5, 0, 2, 0, 0, 0, 0, 1, 0, NULL, 0, NULL, 0)
GO
INSERT [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount], [Name], [Address], [Comission], [IsExternal], [OwnerId], [ComissionSupervisor], [IsAdmin], [IsCobrator], [IsOperator], [IsSeller], [IsSupervisor], [Nickname], [TakeCommision], [Imagen], [IsDisabled]) VALUES (N'e0d8b459-38dd-425f-8109-0968dcc502db', N'rct@mersyrd.com', N'RCT@MERSYRD.COM', N'rct@mersyrd.com', N'RCT@MERSYRD.COM', 1, N'AQAAAAEAACcQAAAAEH0ABb4IjcdhLRtHzcywK5C+/LvZ3iAJipJDZbzWkYos0rEizP9CjK2tjKccqsQ6bQ==', N'PMADPWVUIUPNOMRY2IUJPWC3UNDJESPJ', N'a118ce30-c612-4aee-91bf-a35f446f34db', NULL, 0, 0, NULL, 1, 0, N'rtrt', NULL, 0, 0, 5, 0, 1, 0, 0, 0, 0, NULL, 0, NULL, 0)
GO
INSERT [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount], [Name], [Address], [Comission], [IsExternal], [OwnerId], [ComissionSupervisor], [IsAdmin], [IsCobrator], [IsOperator], [IsSeller], [IsSupervisor], [Nickname], [TakeCommision], [Imagen], [IsDisabled]) VALUES (N'e55b8336-e346-432a-af74-d59606bf09bf', N'ksdflsnd@ksdkfjdsf.com', N'KSDFLSND@KSDKFJDSF.COM', N'ksdflsnd@ksdkfjdsf.com', N'KSDFLSND@KSDKFJDSF.COM', 1, N'AQAAAAEAACcQAAAAEIk/rdMl2CKB7yN3czYMo07R85W4YgkLCAnZBOMCEix45gE9plAhNOpcZkFjBPUbDA==', N'BAEIMNNPX3EDH6GHYFJOAD7ER5LA7AAD', N'c2c02abe-255f-4a33-9304-49aa37dce09a', N'(333) 333-3333', 0, 0, NULL, 1, 0, N'judn', NULL, 0, 0, 5, 0, 0, 0, 0, 1, 1, NULL, 0, NULL, 1)
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
GO
SET IDENTITY_INSERT [dbo].[Lotteries] ON 
GO
INSERT [dbo].[Lotteries] ([Id], [Name], [Code], [CloseHour], [ColorInHex], [LotteryFromId], [Loto1First], [Loto1Second], [Loto1Third], [Loto2First], [Loto2Second], [Loto3First], [Loto3Second], [Loto4First], [Available]) VALUES (1, N'FLORIDA DIA', N'FD', CAST(N'2020-09-01T13:15:00.0000000' AS DateTime2), NULL, 2, CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), 0)
GO
INSERT [dbo].[Lotteries] ([Id], [Name], [Code], [CloseHour], [ColorInHex], [LotteryFromId], [Loto1First], [Loto1Second], [Loto1Third], [Loto2First], [Loto2Second], [Loto3First], [Loto3Second], [Loto4First], [Available]) VALUES (2, N'New York Soir', N'NS', CAST(N'2020-09-05T23:59:00.0000000' AS DateTime2), NULL, 2, CAST(60.00 AS Decimal(18, 2)), CAST(20.00 AS Decimal(18, 2)), CAST(10.00 AS Decimal(18, 2)), CAST(700.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(500.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(2000.00 AS Decimal(18, 2)), 1)
GO
INSERT [dbo].[Lotteries] ([Id], [Name], [Code], [CloseHour], [ColorInHex], [LotteryFromId], [Loto1First], [Loto1Second], [Loto1Third], [Loto2First], [Loto2Second], [Loto3First], [Loto3Second], [Loto4First], [Available]) VALUES (3, N'New York Matin', N'BO', CAST(N'2020-09-03T22:15:00.0000000' AS DateTime2), NULL, 2, CAST(60.00 AS Decimal(18, 2)), CAST(20.00 AS Decimal(18, 2)), CAST(10.00 AS Decimal(18, 2)), CAST(700.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(500.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(2000.00 AS Decimal(18, 2)), 1)
GO
INSERT [dbo].[Lotteries] ([Id], [Name], [Code], [CloseHour], [ColorInHex], [LotteryFromId], [Loto1First], [Loto1Second], [Loto1Third], [Loto2First], [Loto2Second], [Loto3First], [Loto3Second], [Loto4First], [Available]) VALUES (4, N'Loteria Nacional', N'LN', CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2), NULL, 1, CAST(100.00 AS Decimal(18, 2)), CAST(40.00 AS Decimal(18, 2)), CAST(10.00 AS Decimal(18, 2)), CAST(200.00 AS Decimal(18, 2)), CAST(100.00 AS Decimal(18, 2)), CAST(1000.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), 1)
GO
INSERT [dbo].[Lotteries] ([Id], [Name], [Code], [CloseHour], [ColorInHex], [LotteryFromId], [Loto1First], [Loto1Second], [Loto1Third], [Loto2First], [Loto2Second], [Loto3First], [Loto3Second], [Loto4First], [Available]) VALUES (5, N'FLORIDA NOCHE', N'FN', CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2), NULL, 2, CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), 0)
GO
SET IDENTITY_INSERT [dbo].[Lotteries] OFF
GO
SET IDENTITY_INSERT [dbo].[LotteryFroms] ON 
GO
INSERT [dbo].[LotteryFroms] ([Id], [Name]) VALUES (1, N'Global Dominicana')
GO
INSERT [dbo].[LotteryFroms] ([Id], [Name]) VALUES (2, N'Global Bourlette')
GO
SET IDENTITY_INSERT [dbo].[LotteryFroms] OFF
GO
SET IDENTITY_INSERT [dbo].[LotteryModes] ON 
GO
INSERT [dbo].[LotteryModes] ([Id], [Name], [PlayableNumber], [AwardedNumber], [Code]) VALUES (1, N'Quiniela', 1, 1, N'Qu')
GO
INSERT [dbo].[LotteryModes] ([Id], [Name], [PlayableNumber], [AwardedNumber], [Code]) VALUES (2, N'Pale', 2, 2, N'Pa')
GO
INSERT [dbo].[LotteryModes] ([Id], [Name], [PlayableNumber], [AwardedNumber], [Code]) VALUES (3, N'Tripleta', 3, 3, N'Tr')
GO
INSERT [dbo].[LotteryModes] ([Id], [Name], [PlayableNumber], [AwardedNumber], [Code]) VALUES (4, N'Borlette', 1, 1, N'Bo')
GO
INSERT [dbo].[LotteryModes] ([Id], [Name], [PlayableNumber], [AwardedNumber], [Code]) VALUES (5, N'Loto 3', 1, 1, N'L3')
GO
INSERT [dbo].[LotteryModes] ([Id], [Name], [PlayableNumber], [AwardedNumber], [Code]) VALUES (6, N'Loto 4', 1, 1, N'L4')
GO
INSERT [dbo].[LotteryModes] ([Id], [Name], [PlayableNumber], [AwardedNumber], [Code]) VALUES (7, N'Mariage', 1, 1, N'Ma')
GO
INSERT [dbo].[LotteryModes] ([Id], [Name], [PlayableNumber], [AwardedNumber], [Code]) VALUES (8, N'Super Pale', 1, 1, N'L3+')
GO
SET IDENTITY_INSERT [dbo].[LotteryModes] OFF
GO
SET IDENTITY_INSERT [dbo].[LotteryResults] ON 
GO
INSERT [dbo].[LotteryResults] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [LotteryId], [Date], [FirstValue], [SecondValue], [ThirdValue]) VALUES (15, NULL, 0, CAST(N'2020-10-20T00:37:02.1297420' AS DateTime2), N'74dffedd-b38f-40a4-9806-0bda7b3277f5', CAST(N'2020-10-20T00:37:02.1297420' AS DateTime2), N'74dffedd-b38f-40a4-9806-0bda7b3277f5', NULL, NULL, 2, CAST(N'2020-10-18T00:00:00.0000000' AS DateTime2), N'111', N'11', N'11')
GO
INSERT [dbo].[LotteryResults] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [LotteryId], [Date], [FirstValue], [SecondValue], [ThirdValue]) VALUES (16, NULL, 0, CAST(N'2020-10-20T02:01:45.8919030' AS DateTime2), N'74dffedd-b38f-40a4-9806-0bda7b3277f5', CAST(N'2020-10-20T02:01:45.8919030' AS DateTime2), N'74dffedd-b38f-40a4-9806-0bda7b3277f5', NULL, NULL, 4, CAST(N'2020-10-18T00:00:00.0000000' AS DateTime2), N'12', N'12', N'12')
GO
INSERT [dbo].[LotteryResults] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [LotteryId], [Date], [FirstValue], [SecondValue], [ThirdValue]) VALUES (17, NULL, 0, CAST(N'2020-11-04T22:51:30.8649241' AS DateTime2), N'74dffedd-b38f-40a4-9806-0bda7b3277f5', CAST(N'2020-11-04T22:51:30.8649241' AS DateTime2), N'74dffedd-b38f-40a4-9806-0bda7b3277f5', NULL, NULL, 3, CAST(N'2020-11-04T00:00:00.0000000' AS DateTime2), N'034', N'34', N'34')
GO
INSERT [dbo].[LotteryResults] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [LotteryId], [Date], [FirstValue], [SecondValue], [ThirdValue]) VALUES (18, NULL, 0, CAST(N'2020-11-06T16:11:32.2366840' AS DateTime2), N'74dffedd-b38f-40a4-9806-0bda7b3277f5', CAST(N'2020-11-06T16:11:32.2366840' AS DateTime2), N'74dffedd-b38f-40a4-9806-0bda7b3277f5', NULL, NULL, 3, CAST(N'2020-11-06T00:00:00.0000000' AS DateTime2), N'123 ', N'22', N'55')
GO
INSERT [dbo].[LotteryResults] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [LotteryId], [Date], [FirstValue], [SecondValue], [ThirdValue]) VALUES (19, NULL, 0, CAST(N'2020-11-11T12:17:01.6050971' AS DateTime2), N'74dffedd-b38f-40a4-9806-0bda7b3277f5', CAST(N'2020-11-11T12:17:01.6050971' AS DateTime2), N'74dffedd-b38f-40a4-9806-0bda7b3277f5', NULL, NULL, 3, CAST(N'2020-11-11T00:00:00.0000000' AS DateTime2), N'123 ', N'22', N'68')
GO
INSERT [dbo].[LotteryResults] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [LotteryId], [Date], [FirstValue], [SecondValue], [ThirdValue]) VALUES (24, NULL, 0, CAST(N'2020-11-17T21:38:59.0486830' AS DateTime2), N'74dffedd-b38f-40a4-9806-0bda7b3277f5', CAST(N'2020-11-17T21:38:59.0486830' AS DateTime2), N'74dffedd-b38f-40a4-9806-0bda7b3277f5', NULL, NULL, 2, CAST(N'2020-11-17T00:00:00.0000000' AS DateTime2), N'12', N'12', N'12')
GO
SET IDENTITY_INSERT [dbo].[LotteryResults] OFF
GO
SET IDENTITY_INSERT [dbo].[LotterySaleItems] ON 
GO
INSERT [dbo].[LotterySaleItems] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [LotterySaleId], [LotteryModeId], [LotteryId], [PlayedAmount], [Played1], [Played2], [Played3], [PlayedNumbers], [Prize], [Prize1], [Prize2], [Prize3]) VALUES (47, NULL, 0, CAST(N'2020-10-19T03:14:11.5006670' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', CAST(N'2020-10-19T22:23:24.3187340' AS DateTime2), N'74dffedd-b38f-40a4-9806-0bda7b3277f5', NULL, NULL, 23, 2, 4, CAST(100.00 AS Decimal(12, 2)), N'12', N'12', NULL, N'1212', CAST(10000.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[LotterySaleItems] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [LotterySaleId], [LotteryModeId], [LotteryId], [PlayedAmount], [Played1], [Played2], [Played3], [PlayedNumbers], [Prize], [Prize1], [Prize2], [Prize3]) VALUES (48, NULL, 0, CAST(N'2020-10-19T03:14:56.6601530' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', CAST(N'2020-10-19T22:23:24.3190220' AS DateTime2), N'74dffedd-b38f-40a4-9806-0bda7b3277f5', NULL, NULL, 24, 2, 4, CAST(100.00 AS Decimal(12, 2)), N'12', N'12', NULL, N'1212', CAST(10000.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[LotterySaleItems] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [LotterySaleId], [LotteryModeId], [LotteryId], [PlayedAmount], [Played1], [Played2], [Played3], [PlayedNumbers], [Prize], [Prize1], [Prize2], [Prize3]) VALUES (49, NULL, 0, CAST(N'2020-10-19T03:14:56.6608630' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', CAST(N'2020-10-19T22:23:24.3193000' AS DateTime2), N'74dffedd-b38f-40a4-9806-0bda7b3277f5', NULL, NULL, 24, 3, 4, CAST(100.00 AS Decimal(12, 2)), N'12', N'12', N'12', N'121212', CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[LotterySaleItems] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [LotterySaleId], [LotteryModeId], [LotteryId], [PlayedAmount], [Played1], [Played2], [Played3], [PlayedNumbers], [Prize], [Prize1], [Prize2], [Prize3]) VALUES (50, NULL, 0, CAST(N'2020-10-19T03:14:56.6615740' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', CAST(N'2020-10-19T22:23:24.3195680' AS DateTime2), N'74dffedd-b38f-40a4-9806-0bda7b3277f5', NULL, NULL, 24, 1, 4, CAST(123.00 AS Decimal(12, 2)), N'15', NULL, NULL, N'15', CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[LotterySaleItems] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [LotterySaleId], [LotteryModeId], [LotteryId], [PlayedAmount], [Played1], [Played2], [Played3], [PlayedNumbers], [Prize], [Prize1], [Prize2], [Prize3]) VALUES (51, NULL, 0, CAST(N'2020-10-19T03:15:17.8311820' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', CAST(N'2020-10-19T22:23:24.3198340' AS DateTime2), N'74dffedd-b38f-40a4-9806-0bda7b3277f5', NULL, NULL, 25, 2, 4, CAST(2323.00 AS Decimal(12, 2)), N'23', N'23', NULL, N'2323', CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[LotterySaleItems] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [LotterySaleId], [LotteryModeId], [LotteryId], [PlayedAmount], [Played1], [Played2], [Played3], [PlayedNumbers], [Prize], [Prize1], [Prize2], [Prize3]) VALUES (52, NULL, 0, CAST(N'2020-10-19T03:15:34.6398450' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', CAST(N'2020-10-19T22:23:24.3201160' AS DateTime2), N'74dffedd-b38f-40a4-9806-0bda7b3277f5', NULL, NULL, 26, 2, 4, CAST(234.00 AS Decimal(12, 2)), N'23', N'23', NULL, N'2323', CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[LotterySaleItems] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [LotterySaleId], [LotteryModeId], [LotteryId], [PlayedAmount], [Played1], [Played2], [Played3], [PlayedNumbers], [Prize], [Prize1], [Prize2], [Prize3]) VALUES (53, NULL, 0, CAST(N'2020-10-19T03:15:47.0041620' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', CAST(N'2020-10-19T22:23:24.3204110' AS DateTime2), N'74dffedd-b38f-40a4-9806-0bda7b3277f5', NULL, NULL, 27, 1, 4, CAST(234.00 AS Decimal(12, 2)), N'12', NULL, NULL, N'12', CAST(23400.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[LotterySaleItems] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [LotterySaleId], [LotteryModeId], [LotteryId], [PlayedAmount], [Played1], [Played2], [Played3], [PlayedNumbers], [Prize], [Prize1], [Prize2], [Prize3]) VALUES (54, NULL, 0, CAST(N'2020-10-19T03:16:01.7471070' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', CAST(N'2020-10-19T22:23:24.3206880' AS DateTime2), N'74dffedd-b38f-40a4-9806-0bda7b3277f5', NULL, NULL, 28, 2, 4, CAST(2344.00 AS Decimal(12, 2)), N'23', N'23', NULL, N'2323', CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[LotterySaleItems] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [LotterySaleId], [LotteryModeId], [LotteryId], [PlayedAmount], [Played1], [Played2], [Played3], [PlayedNumbers], [Prize], [Prize1], [Prize2], [Prize3]) VALUES (55, NULL, 0, CAST(N'2020-10-19T03:16:14.5411170' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', CAST(N'2020-10-19T22:23:24.3209800' AS DateTime2), N'74dffedd-b38f-40a4-9806-0bda7b3277f5', NULL, NULL, 29, 2, 4, CAST(234.00 AS Decimal(12, 2)), N'23', N'23', NULL, N'2323', CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[LotterySaleItems] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [LotterySaleId], [LotteryModeId], [LotteryId], [PlayedAmount], [Played1], [Played2], [Played3], [PlayedNumbers], [Prize], [Prize1], [Prize2], [Prize3]) VALUES (56, NULL, 0, CAST(N'2020-10-19T03:16:27.9440660' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', CAST(N'2020-10-19T22:23:24.3212550' AS DateTime2), N'74dffedd-b38f-40a4-9806-0bda7b3277f5', NULL, NULL, 30, 3, 4, CAST(234.00 AS Decimal(12, 2)), N'23', N'23', N'23', N'232323', CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[LotterySaleItems] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [LotterySaleId], [LotteryModeId], [LotteryId], [PlayedAmount], [Played1], [Played2], [Played3], [PlayedNumbers], [Prize], [Prize1], [Prize2], [Prize3]) VALUES (57, NULL, 0, CAST(N'2020-10-19T03:16:44.0127140' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', CAST(N'2020-10-19T22:23:24.3215340' AS DateTime2), N'74dffedd-b38f-40a4-9806-0bda7b3277f5', NULL, NULL, 31, 3, 4, CAST(234.00 AS Decimal(12, 2)), N'24', N'24', N'24', N'242424', CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[LotterySaleItems] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [LotterySaleId], [LotteryModeId], [LotteryId], [PlayedAmount], [Played1], [Played2], [Played3], [PlayedNumbers], [Prize], [Prize1], [Prize2], [Prize3]) VALUES (58, NULL, 0, CAST(N'2020-10-19T03:17:13.3511730' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', CAST(N'2020-10-19T22:23:24.3218080' AS DateTime2), N'74dffedd-b38f-40a4-9806-0bda7b3277f5', NULL, NULL, 32, 3, 4, CAST(2342.00 AS Decimal(12, 2)), N'23', N'23', N'23', N'232323', CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[LotterySaleItems] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [LotterySaleId], [LotteryModeId], [LotteryId], [PlayedAmount], [Played1], [Played2], [Played3], [PlayedNumbers], [Prize], [Prize1], [Prize2], [Prize3]) VALUES (59, NULL, 0, CAST(N'2020-10-19T03:17:29.0349170' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', CAST(N'2020-10-19T22:23:24.3222220' AS DateTime2), N'74dffedd-b38f-40a4-9806-0bda7b3277f5', NULL, NULL, 33, 3, 4, CAST(234324.00 AS Decimal(12, 2)), N'23', N'23', N'23', N'232323', CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[LotterySaleItems] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [LotterySaleId], [LotteryModeId], [LotteryId], [PlayedAmount], [Played1], [Played2], [Played3], [PlayedNumbers], [Prize], [Prize1], [Prize2], [Prize3]) VALUES (60, NULL, 0, CAST(N'2020-10-19T03:17:53.9619140' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', CAST(N'2020-10-19T22:23:24.3225060' AS DateTime2), N'74dffedd-b38f-40a4-9806-0bda7b3277f5', NULL, NULL, 34, 3, 4, CAST(698.00 AS Decimal(12, 2)), N'00', N'00', N'00', N'000000', CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[LotterySaleItems] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [LotterySaleId], [LotteryModeId], [LotteryId], [PlayedAmount], [Played1], [Played2], [Played3], [PlayedNumbers], [Prize], [Prize1], [Prize2], [Prize3]) VALUES (61, NULL, 0, CAST(N'2020-10-19T03:18:22.0996750' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', CAST(N'2020-10-19T22:23:24.3228560' AS DateTime2), N'74dffedd-b38f-40a4-9806-0bda7b3277f5', NULL, NULL, 35, 2, 4, CAST(0.00 AS Decimal(12, 2)), N'00', N'00', NULL, N'0000', CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[LotterySaleItems] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [LotterySaleId], [LotteryModeId], [LotteryId], [PlayedAmount], [Played1], [Played2], [Played3], [PlayedNumbers], [Prize], [Prize1], [Prize2], [Prize3]) VALUES (62, NULL, 0, CAST(N'2020-10-19T03:18:22.1002540' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', CAST(N'2020-10-19T22:23:24.3231510' AS DateTime2), N'74dffedd-b38f-40a4-9806-0bda7b3277f5', NULL, NULL, 35, 2, 4, CAST(68.00 AS Decimal(12, 2)), N'00', N'00', NULL, N'0000', CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[LotterySaleItems] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [LotterySaleId], [LotteryModeId], [LotteryId], [PlayedAmount], [Played1], [Played2], [Played3], [PlayedNumbers], [Prize], [Prize1], [Prize2], [Prize3]) VALUES (63, NULL, 0, CAST(N'2020-10-19T03:18:43.8756950' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', CAST(N'2020-10-19T22:23:24.3236900' AS DateTime2), N'74dffedd-b38f-40a4-9806-0bda7b3277f5', NULL, NULL, 36, 2, 4, CAST(100.00 AS Decimal(12, 2)), N'12', N'12', NULL, N'1212', CAST(10000.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[LotterySaleItems] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [LotterySaleId], [LotteryModeId], [LotteryId], [PlayedAmount], [Played1], [Played2], [Played3], [PlayedNumbers], [Prize], [Prize1], [Prize2], [Prize3]) VALUES (64, NULL, 0, CAST(N'2020-10-19T03:19:21.9967390' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', CAST(N'2020-10-19T22:23:24.3239950' AS DateTime2), N'74dffedd-b38f-40a4-9806-0bda7b3277f5', NULL, NULL, 37, 1, 4, CAST(100.00 AS Decimal(12, 2)), N'12', NULL, NULL, N'12', CAST(10000.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[LotterySaleItems] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [LotterySaleId], [LotteryModeId], [LotteryId], [PlayedAmount], [Played1], [Played2], [Played3], [PlayedNumbers], [Prize], [Prize1], [Prize2], [Prize3]) VALUES (65, NULL, 0, CAST(N'2020-10-19T03:19:21.9973180' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', CAST(N'2020-10-19T22:23:24.3244480' AS DateTime2), N'74dffedd-b38f-40a4-9806-0bda7b3277f5', NULL, NULL, 37, 2, 4, CAST(234.00 AS Decimal(12, 2)), N'23', N'23', NULL, N'2323', CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[LotterySaleItems] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [LotterySaleId], [LotteryModeId], [LotteryId], [PlayedAmount], [Played1], [Played2], [Played3], [PlayedNumbers], [Prize], [Prize1], [Prize2], [Prize3]) VALUES (66, NULL, 0, CAST(N'2020-10-19T03:19:21.9979040' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', CAST(N'2020-10-19T22:23:24.3247800' AS DateTime2), N'74dffedd-b38f-40a4-9806-0bda7b3277f5', NULL, NULL, 37, 3, 4, CAST(234.00 AS Decimal(12, 2)), N'23', N'23', N'23', N'232323', CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[LotterySaleItems] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [LotterySaleId], [LotteryModeId], [LotteryId], [PlayedAmount], [Played1], [Played2], [Played3], [PlayedNumbers], [Prize], [Prize1], [Prize2], [Prize3]) VALUES (67, NULL, 0, CAST(N'2020-10-19T03:19:21.9985100' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', CAST(N'2020-10-19T22:23:24.3252650' AS DateTime2), N'74dffedd-b38f-40a4-9806-0bda7b3277f5', NULL, NULL, 37, 3, 4, CAST(233.00 AS Decimal(12, 2)), N'23', N'23', N'23', N'232323', CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[LotterySaleItems] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [LotterySaleId], [LotteryModeId], [LotteryId], [PlayedAmount], [Played1], [Played2], [Played3], [PlayedNumbers], [Prize], [Prize1], [Prize2], [Prize3]) VALUES (68, NULL, 0, CAST(N'2020-10-19T03:19:42.9454420' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', CAST(N'2020-10-19T22:23:24.3256010' AS DateTime2), N'74dffedd-b38f-40a4-9806-0bda7b3277f5', NULL, NULL, 38, 2, 4, CAST(100.00 AS Decimal(12, 2)), N'12', N'12', NULL, N'1212', CAST(10000.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[LotterySaleItems] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [LotterySaleId], [LotteryModeId], [LotteryId], [PlayedAmount], [Played1], [Played2], [Played3], [PlayedNumbers], [Prize], [Prize1], [Prize2], [Prize3]) VALUES (69, NULL, 0, CAST(N'2020-10-19T03:19:42.9460170' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', CAST(N'2020-10-19T22:23:24.3259000' AS DateTime2), N'74dffedd-b38f-40a4-9806-0bda7b3277f5', NULL, NULL, 38, 1, 4, CAST(100.00 AS Decimal(12, 2)), N'12', NULL, NULL, N'12', CAST(10000.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[LotterySaleItems] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [LotterySaleId], [LotteryModeId], [LotteryId], [PlayedAmount], [Played1], [Played2], [Played3], [PlayedNumbers], [Prize], [Prize1], [Prize2], [Prize3]) VALUES (70, NULL, 0, CAST(N'2020-10-19T03:20:16.6728990' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', CAST(N'2020-10-19T22:23:24.3261670' AS DateTime2), N'74dffedd-b38f-40a4-9806-0bda7b3277f5', NULL, NULL, 39, 3, 4, CAST(100.00 AS Decimal(12, 2)), N'12', N'12', N'12', N'121212', CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[LotterySaleItems] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [LotterySaleId], [LotteryModeId], [LotteryId], [PlayedAmount], [Played1], [Played2], [Played3], [PlayedNumbers], [Prize], [Prize1], [Prize2], [Prize3]) VALUES (71, NULL, 0, CAST(N'2020-10-19T03:20:16.6735680' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', CAST(N'2020-10-19T22:23:24.3264320' AS DateTime2), N'74dffedd-b38f-40a4-9806-0bda7b3277f5', NULL, NULL, 39, 2, 4, CAST(234.00 AS Decimal(12, 2)), N'32', N'32', NULL, N'3232', CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[LotterySaleItems] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [LotterySaleId], [LotteryModeId], [LotteryId], [PlayedAmount], [Played1], [Played2], [Played3], [PlayedNumbers], [Prize], [Prize1], [Prize2], [Prize3]) VALUES (72, NULL, 0, CAST(N'2020-10-19T03:20:16.6741750' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', CAST(N'2020-10-19T22:23:24.3266970' AS DateTime2), N'74dffedd-b38f-40a4-9806-0bda7b3277f5', NULL, NULL, 39, 3, 4, CAST(234234.00 AS Decimal(12, 2)), N'23', N'23', N'23', N'232323', CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[LotterySaleItems] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [LotterySaleId], [LotteryModeId], [LotteryId], [PlayedAmount], [Played1], [Played2], [Played3], [PlayedNumbers], [Prize], [Prize1], [Prize2], [Prize3]) VALUES (73, NULL, 0, CAST(N'2020-10-19T03:20:16.6747660' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', CAST(N'2020-10-19T22:23:24.3269640' AS DateTime2), N'74dffedd-b38f-40a4-9806-0bda7b3277f5', NULL, NULL, 39, 1, 4, CAST(100.00 AS Decimal(12, 2)), N'12', NULL, NULL, N'12', CAST(10000.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[LotterySaleItems] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [LotterySaleId], [LotteryModeId], [LotteryId], [PlayedAmount], [Played1], [Played2], [Played3], [PlayedNumbers], [Prize], [Prize1], [Prize2], [Prize3]) VALUES (74, NULL, 0, CAST(N'2020-10-19T03:20:39.1048790' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', CAST(N'2020-10-19T22:23:24.3272230' AS DateTime2), N'74dffedd-b38f-40a4-9806-0bda7b3277f5', NULL, NULL, 40, 2, 4, CAST(100.00 AS Decimal(12, 2)), N'12', N'12', NULL, N'1212', CAST(10000.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[LotterySaleItems] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [LotterySaleId], [LotteryModeId], [LotteryId], [PlayedAmount], [Played1], [Played2], [Played3], [PlayedNumbers], [Prize], [Prize1], [Prize2], [Prize3]) VALUES (75, NULL, 0, CAST(N'2020-10-19T03:20:39.1054810' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', CAST(N'2020-10-19T22:23:24.3274880' AS DateTime2), N'74dffedd-b38f-40a4-9806-0bda7b3277f5', NULL, NULL, 40, 3, 4, CAST(3453.00 AS Decimal(12, 2)), N'13', N'13', N'13', N'131313', CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[LotterySaleItems] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [LotterySaleId], [LotteryModeId], [LotteryId], [PlayedAmount], [Played1], [Played2], [Played3], [PlayedNumbers], [Prize], [Prize1], [Prize2], [Prize3]) VALUES (76, NULL, 0, CAST(N'2020-10-19T03:21:01.1968520' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', CAST(N'2020-10-19T22:23:24.3277480' AS DateTime2), N'74dffedd-b38f-40a4-9806-0bda7b3277f5', NULL, NULL, 41, 3, 4, CAST(34534.00 AS Decimal(12, 2)), N'34', N'34', N'34', N'343434', CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[LotterySaleItems] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [LotterySaleId], [LotteryModeId], [LotteryId], [PlayedAmount], [Played1], [Played2], [Played3], [PlayedNumbers], [Prize], [Prize1], [Prize2], [Prize3]) VALUES (77, NULL, 0, CAST(N'2020-10-19T23:36:49.3641130' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', CAST(N'2020-10-19T23:36:49.3641130' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', NULL, NULL, 54, 2, 4, CAST(345.00 AS Decimal(12, 2)), N'34', N'55', NULL, N'3455', CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[LotterySaleItems] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [LotterySaleId], [LotteryModeId], [LotteryId], [PlayedAmount], [Played1], [Played2], [Played3], [PlayedNumbers], [Prize], [Prize1], [Prize2], [Prize3]) VALUES (78, NULL, 0, CAST(N'2020-10-19T23:37:29.6890770' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', CAST(N'2020-10-19T23:37:29.6890770' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', NULL, NULL, 55, 3, 4, CAST(100.00 AS Decimal(12, 2)), N'12', N'34', N'56', N'123456', CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[LotterySaleItems] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [LotterySaleId], [LotteryModeId], [LotteryId], [PlayedAmount], [Played1], [Played2], [Played3], [PlayedNumbers], [Prize], [Prize1], [Prize2], [Prize3]) VALUES (79, NULL, 0, CAST(N'2020-10-19T23:37:29.6897210' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', CAST(N'2020-10-19T23:37:29.6897210' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', NULL, NULL, 55, 3, 4, CAST(567.00 AS Decimal(12, 2)), N'67', N'56', N'75', N'675675', CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[LotterySaleItems] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [LotterySaleId], [LotteryModeId], [LotteryId], [PlayedAmount], [Played1], [Played2], [Played3], [PlayedNumbers], [Prize], [Prize1], [Prize2], [Prize3]) VALUES (80, NULL, 0, CAST(N'2020-10-19T23:37:48.8639130' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', CAST(N'2020-10-19T23:37:48.8639130' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', NULL, NULL, 56, 3, 4, CAST(56756.00 AS Decimal(12, 2)), N'12', N'34', N'67', N'123467', CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[LotterySaleItems] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [LotterySaleId], [LotteryModeId], [LotteryId], [PlayedAmount], [Played1], [Played2], [Played3], [PlayedNumbers], [Prize], [Prize1], [Prize2], [Prize3]) VALUES (81, NULL, 0, CAST(N'2020-10-19T23:38:27.1705240' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', CAST(N'2020-10-19T23:38:27.1705240' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', NULL, NULL, 57, 2, 4, CAST(56.00 AS Decimal(12, 2)), N'12', N'56', NULL, N'1256', CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[LotterySaleItems] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [LotterySaleId], [LotteryModeId], [LotteryId], [PlayedAmount], [Played1], [Played2], [Played3], [PlayedNumbers], [Prize], [Prize1], [Prize2], [Prize3]) VALUES (82, NULL, 0, CAST(N'2020-10-19T23:38:27.1711980' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', CAST(N'2020-10-19T23:38:27.1711980' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', NULL, NULL, 57, 2, 4, CAST(67.00 AS Decimal(12, 2)), N'10', N'06', NULL, N'1006', CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[LotterySaleItems] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [LotterySaleId], [LotteryModeId], [LotteryId], [PlayedAmount], [Played1], [Played2], [Played3], [PlayedNumbers], [Prize], [Prize1], [Prize2], [Prize3]) VALUES (83, NULL, 0, CAST(N'2020-10-19T23:38:27.1718600' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', CAST(N'2020-10-19T23:38:27.1718600' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', NULL, NULL, 57, 4, 2, CAST(67.00 AS Decimal(12, 2)), N'67', NULL, NULL, N'67', CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[LotterySaleItems] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [LotterySaleId], [LotteryModeId], [LotteryId], [PlayedAmount], [Played1], [Played2], [Played3], [PlayedNumbers], [Prize], [Prize1], [Prize2], [Prize3]) VALUES (84, NULL, 0, CAST(N'2020-10-19T23:38:41.7877840' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', CAST(N'2020-10-19T23:38:41.7877840' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', NULL, NULL, 58, 5, 2, CAST(100.00 AS Decimal(12, 2)), N'388', NULL, NULL, N'388', CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[LotterySaleItems] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [LotterySaleId], [LotteryModeId], [LotteryId], [PlayedAmount], [Played1], [Played2], [Played3], [PlayedNumbers], [Prize], [Prize1], [Prize2], [Prize3]) VALUES (85, NULL, 0, CAST(N'2020-10-19T23:38:53.4996790' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', CAST(N'2020-10-19T23:38:53.4996790' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', NULL, NULL, 59, 5, 2, CAST(100.00 AS Decimal(12, 2)), N'123', NULL, NULL, N'123', CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[LotterySaleItems] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [LotterySaleId], [LotteryModeId], [LotteryId], [PlayedAmount], [Played1], [Played2], [Played3], [PlayedNumbers], [Prize], [Prize1], [Prize2], [Prize3]) VALUES (86, NULL, 0, CAST(N'2020-10-19T23:39:09.0953280' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', CAST(N'2020-10-19T23:39:09.0953280' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', NULL, NULL, 60, 7, 2, CAST(100.00 AS Decimal(12, 2)), N'12', N'34', NULL, N'1234', CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[LotterySaleItems] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [LotterySaleId], [LotteryModeId], [LotteryId], [PlayedAmount], [Played1], [Played2], [Played3], [PlayedNumbers], [Prize], [Prize1], [Prize2], [Prize3]) VALUES (87, NULL, 0, CAST(N'2020-10-19T23:39:22.8894340' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', CAST(N'2020-10-19T23:39:22.8894340' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', NULL, NULL, 61, 6, 2, CAST(100.00 AS Decimal(12, 2)), N'12', N'34', NULL, N'1234', CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[LotterySaleItems] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [LotterySaleId], [LotteryModeId], [LotteryId], [PlayedAmount], [Played1], [Played2], [Played3], [PlayedNumbers], [Prize], [Prize1], [Prize2], [Prize3]) VALUES (88, NULL, 0, CAST(N'2020-10-19T23:39:46.8170710' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', CAST(N'2020-10-19T23:39:46.8170710' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', NULL, NULL, 62, 7, 2, CAST(4564.00 AS Decimal(12, 2)), N'34', N'56', NULL, N'3456', CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[LotterySaleItems] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [LotterySaleId], [LotteryModeId], [LotteryId], [PlayedAmount], [Played1], [Played2], [Played3], [PlayedNumbers], [Prize], [Prize1], [Prize2], [Prize3]) VALUES (89, NULL, 0, CAST(N'2020-10-19T23:40:03.4049880' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', CAST(N'2020-10-19T23:40:03.4049880' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', NULL, NULL, 63, 5, 2, CAST(456456456.00 AS Decimal(12, 2)), N'124', NULL, NULL, N'124', CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[LotterySaleItems] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [LotterySaleId], [LotteryModeId], [LotteryId], [PlayedAmount], [Played1], [Played2], [Played3], [PlayedNumbers], [Prize], [Prize1], [Prize2], [Prize3]) VALUES (90, NULL, 0, CAST(N'2020-10-19T23:40:31.0314800' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', CAST(N'2020-10-19T23:40:31.0314800' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', NULL, NULL, 64, 2, 4, CAST(34534.00 AS Decimal(12, 2)), N'45', N'33', NULL, N'4533', CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[LotterySaleItems] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [LotterySaleId], [LotteryModeId], [LotteryId], [PlayedAmount], [Played1], [Played2], [Played3], [PlayedNumbers], [Prize], [Prize1], [Prize2], [Prize3]) VALUES (91, NULL, 0, CAST(N'2020-10-19T23:40:53.0697350' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', CAST(N'2020-10-19T23:40:53.0697350' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', NULL, NULL, 65, 1, 4, CAST(3433443.00 AS Decimal(12, 2)), N'34', NULL, NULL, N'34', CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[LotterySaleItems] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [LotterySaleId], [LotteryModeId], [LotteryId], [PlayedAmount], [Played1], [Played2], [Played3], [PlayedNumbers], [Prize], [Prize1], [Prize2], [Prize3]) VALUES (92, NULL, 0, CAST(N'2020-10-19T23:41:31.0797630' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', CAST(N'2020-10-19T23:41:31.0797630' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', NULL, NULL, 66, 2, 4, CAST(300000000.00 AS Decimal(12, 2)), N'24', N'23', NULL, N'2423', CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[LotterySaleItems] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [LotterySaleId], [LotteryModeId], [LotteryId], [PlayedAmount], [Played1], [Played2], [Played3], [PlayedNumbers], [Prize], [Prize1], [Prize2], [Prize3]) VALUES (93, NULL, 0, CAST(N'2020-10-26T21:57:02.1800280' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', CAST(N'2020-10-26T21:57:02.1800280' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', NULL, NULL, 67, 4, 2, CAST(3434.00 AS Decimal(12, 2)), N'34', NULL, NULL, N'34', CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[LotterySaleItems] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [LotterySaleId], [LotteryModeId], [LotteryId], [PlayedAmount], [Played1], [Played2], [Played3], [PlayedNumbers], [Prize], [Prize1], [Prize2], [Prize3]) VALUES (94, NULL, 0, CAST(N'2020-10-26T21:57:29.7689380' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', CAST(N'2020-10-26T21:57:29.7689380' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', NULL, NULL, 68, 5, 2, CAST(234.00 AS Decimal(12, 2)), N'234', NULL, NULL, N'234', CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[LotterySaleItems] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [LotterySaleId], [LotteryModeId], [LotteryId], [PlayedAmount], [Played1], [Played2], [Played3], [PlayedNumbers], [Prize], [Prize1], [Prize2], [Prize3]) VALUES (95, NULL, 0, CAST(N'2020-10-26T21:57:51.4431930' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', CAST(N'2020-10-26T21:57:51.4431930' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', NULL, NULL, 69, 5, 2, CAST(1000.00 AS Decimal(12, 2)), N'123', NULL, NULL, N'123', CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[LotterySaleItems] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [LotterySaleId], [LotteryModeId], [LotteryId], [PlayedAmount], [Played1], [Played2], [Played3], [PlayedNumbers], [Prize], [Prize1], [Prize2], [Prize3]) VALUES (96, NULL, 0, CAST(N'2020-10-26T21:57:51.4439230' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', CAST(N'2020-10-26T21:57:51.4439230' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', NULL, NULL, 69, 5, 2, CAST(100.00 AS Decimal(12, 2)), N'123', NULL, NULL, N'123', CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[LotterySaleItems] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [LotterySaleId], [LotteryModeId], [LotteryId], [PlayedAmount], [Played1], [Played2], [Played3], [PlayedNumbers], [Prize], [Prize1], [Prize2], [Prize3]) VALUES (97, NULL, 0, CAST(N'2020-10-26T21:58:07.4243330' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', CAST(N'2020-10-26T21:58:07.4243330' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', NULL, NULL, 70, 7, 2, CAST(1000.00 AS Decimal(12, 2)), N'12', N'34', NULL, N'1234', CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[LotterySaleItems] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [LotterySaleId], [LotteryModeId], [LotteryId], [PlayedAmount], [Played1], [Played2], [Played3], [PlayedNumbers], [Prize], [Prize1], [Prize2], [Prize3]) VALUES (98, NULL, 0, CAST(N'2020-10-26T21:58:26.6852200' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', CAST(N'2020-10-26T21:58:26.6852200' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', NULL, NULL, 71, 2, 4, CAST(1000.00 AS Decimal(12, 2)), N'12', N'34', NULL, N'1234', CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[LotterySaleItems] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [LotterySaleId], [LotteryModeId], [LotteryId], [PlayedAmount], [Played1], [Played2], [Played3], [PlayedNumbers], [Prize], [Prize1], [Prize2], [Prize3]) VALUES (99, NULL, 0, CAST(N'2020-10-26T21:58:36.5495480' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', CAST(N'2020-10-26T21:58:36.5495480' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', NULL, NULL, 72, 1, 4, CAST(1000.00 AS Decimal(12, 2)), N'12', NULL, NULL, N'12', CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[LotterySaleItems] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [LotterySaleId], [LotteryModeId], [LotteryId], [PlayedAmount], [Played1], [Played2], [Played3], [PlayedNumbers], [Prize], [Prize1], [Prize2], [Prize3]) VALUES (100, NULL, 0, CAST(N'2020-10-26T21:58:50.6053250' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', CAST(N'2020-10-26T21:58:50.6053250' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', NULL, NULL, 73, 3, 4, CAST(131313.00 AS Decimal(12, 2)), N'12', N'31', N'31', N'123131', CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[LotterySaleItems] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [LotterySaleId], [LotteryModeId], [LotteryId], [PlayedAmount], [Played1], [Played2], [Played3], [PlayedNumbers], [Prize], [Prize1], [Prize2], [Prize3]) VALUES (101, NULL, 0, CAST(N'2020-10-26T22:23:50.5803490' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', CAST(N'2020-10-26T22:23:50.5803490' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', NULL, NULL, 74, 4, 2, CAST(2333.00 AS Decimal(12, 2)), N'23', NULL, NULL, N'23', CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[LotterySaleItems] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [LotterySaleId], [LotteryModeId], [LotteryId], [PlayedAmount], [Played1], [Played2], [Played3], [PlayedNumbers], [Prize], [Prize1], [Prize2], [Prize3]) VALUES (102, NULL, 0, CAST(N'2020-10-26T22:25:09.7394960' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', CAST(N'2020-10-26T22:25:09.7394960' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', NULL, NULL, 75, 4, 2, CAST(3434.00 AS Decimal(12, 2)), N'34', NULL, NULL, N'34', CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[LotterySaleItems] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [LotterySaleId], [LotteryModeId], [LotteryId], [PlayedAmount], [Played1], [Played2], [Played3], [PlayedNumbers], [Prize], [Prize1], [Prize2], [Prize3]) VALUES (103, NULL, 0, CAST(N'2020-10-27T04:32:47.8594760' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', CAST(N'2020-10-27T04:32:47.8594760' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', NULL, NULL, 76, 4, 2, CAST(56.00 AS Decimal(12, 2)), N'56', NULL, NULL, N'56', CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[LotterySaleItems] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [LotterySaleId], [LotteryModeId], [LotteryId], [PlayedAmount], [Played1], [Played2], [Played3], [PlayedNumbers], [Prize], [Prize1], [Prize2], [Prize3]) VALUES (104, NULL, 0, CAST(N'2020-10-27T04:33:08.2018360' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', CAST(N'2020-10-27T04:33:08.2018360' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', NULL, NULL, 77, 5, 2, CAST(5.00 AS Decimal(12, 2)), N'576', NULL, NULL, N'576', CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[LotterySaleItems] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [LotterySaleId], [LotteryModeId], [LotteryId], [PlayedAmount], [Played1], [Played2], [Played3], [PlayedNumbers], [Prize], [Prize1], [Prize2], [Prize3]) VALUES (105, NULL, 0, CAST(N'2020-11-03T17:23:33.8823600' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', CAST(N'2020-11-03T17:23:33.8823600' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', NULL, NULL, 78, 7, 2, CAST(1000.00 AS Decimal(12, 2)), N'24', N'42', NULL, N'2442', CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[LotterySaleItems] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [LotterySaleId], [LotteryModeId], [LotteryId], [PlayedAmount], [Played1], [Played2], [Played3], [PlayedNumbers], [Prize], [Prize1], [Prize2], [Prize3]) VALUES (106, NULL, 0, CAST(N'2020-11-03T17:24:00.9604700' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', CAST(N'2020-11-03T17:24:00.9604700' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', NULL, NULL, 79, 5, 2, CAST(34534.00 AS Decimal(12, 2)), N'345', NULL, NULL, N'345', CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[LotterySaleItems] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [LotterySaleId], [LotteryModeId], [LotteryId], [PlayedAmount], [Played1], [Played2], [Played3], [PlayedNumbers], [Prize], [Prize1], [Prize2], [Prize3]) VALUES (107, NULL, 0, CAST(N'2020-11-03T17:24:51.6481390' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', CAST(N'2020-11-03T17:24:51.6481390' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', NULL, NULL, 80, 1, 4, CAST(233.00 AS Decimal(12, 2)), N'23', NULL, NULL, N'23', CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[LotterySaleItems] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [LotterySaleId], [LotteryModeId], [LotteryId], [PlayedAmount], [Played1], [Played2], [Played3], [PlayedNumbers], [Prize], [Prize1], [Prize2], [Prize3]) VALUES (108, NULL, 0, CAST(N'2020-11-03T17:24:51.6487200' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', CAST(N'2020-11-03T17:24:51.6487200' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', NULL, NULL, 80, 2, 4, CAST(23.00 AS Decimal(12, 2)), N'23', N'23', NULL, N'2323', CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[LotterySaleItems] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [LotterySaleId], [LotteryModeId], [LotteryId], [PlayedAmount], [Played1], [Played2], [Played3], [PlayedNumbers], [Prize], [Prize1], [Prize2], [Prize3]) VALUES (109, NULL, 0, CAST(N'2020-11-03T17:24:51.6493390' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', CAST(N'2020-11-03T17:24:51.6493390' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', NULL, NULL, 80, 2, 4, CAST(23.00 AS Decimal(12, 2)), N'23', N'23', NULL, N'2323', CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[LotterySaleItems] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [LotterySaleId], [LotteryModeId], [LotteryId], [PlayedAmount], [Played1], [Played2], [Played3], [PlayedNumbers], [Prize], [Prize1], [Prize2], [Prize3]) VALUES (110, NULL, 0, CAST(N'2020-11-03T17:24:51.6503210' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', CAST(N'2020-11-03T17:24:51.6503210' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', NULL, NULL, 80, 2, 4, CAST(2323.00 AS Decimal(12, 2)), N'23', N'23', NULL, N'2323', CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[LotterySaleItems] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [LotterySaleId], [LotteryModeId], [LotteryId], [PlayedAmount], [Played1], [Played2], [Played3], [PlayedNumbers], [Prize], [Prize1], [Prize2], [Prize3]) VALUES (111, NULL, 0, CAST(N'2020-11-03T17:24:51.6509230' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', CAST(N'2020-11-03T17:24:51.6509230' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', NULL, NULL, 80, 2, 4, CAST(233.00 AS Decimal(12, 2)), N'23', N'23', NULL, N'2323', CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[LotterySaleItems] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [LotterySaleId], [LotteryModeId], [LotteryId], [PlayedAmount], [Played1], [Played2], [Played3], [PlayedNumbers], [Prize], [Prize1], [Prize2], [Prize3]) VALUES (112, NULL, 0, CAST(N'2020-11-03T17:25:10.9637610' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', CAST(N'2020-11-03T17:25:10.9637610' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', NULL, NULL, 81, 3, 4, CAST(234234.00 AS Decimal(12, 2)), N'23', N'42', N'34', N'234234', CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[LotterySaleItems] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [LotterySaleId], [LotteryModeId], [LotteryId], [PlayedAmount], [Played1], [Played2], [Played3], [PlayedNumbers], [Prize], [Prize1], [Prize2], [Prize3]) VALUES (113, NULL, 0, CAST(N'2020-11-03T17:25:20.1391430' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', CAST(N'2020-11-03T17:25:20.1391430' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', NULL, NULL, 82, 5, 2, CAST(234243.00 AS Decimal(12, 2)), N'234', NULL, NULL, N'234', CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[LotterySaleItems] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [LotterySaleId], [LotteryModeId], [LotteryId], [PlayedAmount], [Played1], [Played2], [Played3], [PlayedNumbers], [Prize], [Prize1], [Prize2], [Prize3]) VALUES (114, NULL, 0, CAST(N'2020-11-03T17:25:31.0383720' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', CAST(N'2020-11-03T17:25:31.0383720' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', NULL, NULL, 83, 5, 2, CAST(2344.00 AS Decimal(12, 2)), N'234', NULL, NULL, N'234', CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[LotterySaleItems] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [LotterySaleId], [LotteryModeId], [LotteryId], [PlayedAmount], [Played1], [Played2], [Played3], [PlayedNumbers], [Prize], [Prize1], [Prize2], [Prize3]) VALUES (115, NULL, 0, CAST(N'2020-11-04T16:54:30.8775320' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', CAST(N'2020-11-04T22:51:30.8651332' AS DateTime2), N'74dffedd-b38f-40a4-9806-0bda7b3277f5', NULL, NULL, 84, 4, 3, CAST(1000.00 AS Decimal(12, 2)), N'12', NULL, NULL, N'12', CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[LotterySaleItems] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [LotterySaleId], [LotteryModeId], [LotteryId], [PlayedAmount], [Played1], [Played2], [Played3], [PlayedNumbers], [Prize], [Prize1], [Prize2], [Prize3]) VALUES (116, NULL, 0, CAST(N'2020-11-04T16:54:30.8783530' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', CAST(N'2020-11-04T22:51:30.8654498' AS DateTime2), N'74dffedd-b38f-40a4-9806-0bda7b3277f5', NULL, NULL, 84, 5, 3, CAST(1000.00 AS Decimal(12, 2)), N'123', NULL, NULL, N'123', CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[LotterySaleItems] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [LotterySaleId], [LotteryModeId], [LotteryId], [PlayedAmount], [Played1], [Played2], [Played3], [PlayedNumbers], [Prize], [Prize1], [Prize2], [Prize3]) VALUES (117, NULL, 0, CAST(N'2020-11-04T16:54:46.8644260' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', CAST(N'2020-11-04T16:54:46.8644260' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', NULL, NULL, 85, 2, 4, CAST(123.00 AS Decimal(12, 2)), N'12', N'33', NULL, N'1233', CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[LotterySaleItems] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [LotterySaleId], [LotteryModeId], [LotteryId], [PlayedAmount], [Played1], [Played2], [Played3], [PlayedNumbers], [Prize], [Prize1], [Prize2], [Prize3]) VALUES (118, NULL, 0, CAST(N'2020-11-04T16:54:55.1441400' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', CAST(N'2020-11-04T16:54:55.1441400' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', NULL, NULL, 86, 2, 4, CAST(123.00 AS Decimal(12, 2)), N'12', N'34', NULL, N'1234', CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[LotterySaleItems] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [LotterySaleId], [LotteryModeId], [LotteryId], [PlayedAmount], [Played1], [Played2], [Played3], [PlayedNumbers], [Prize], [Prize1], [Prize2], [Prize3]) VALUES (119, NULL, 0, CAST(N'2020-11-04T16:55:05.3255260' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', CAST(N'2020-11-04T16:55:05.3255260' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', NULL, NULL, 87, 2, 4, CAST(1222.00 AS Decimal(12, 2)), N'12', N'31', NULL, N'1231', CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[LotterySaleItems] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [LotterySaleId], [LotteryModeId], [LotteryId], [PlayedAmount], [Played1], [Played2], [Played3], [PlayedNumbers], [Prize], [Prize1], [Prize2], [Prize3]) VALUES (120, NULL, 1, CAST(N'2020-11-04T16:55:15.0183100' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', CAST(N'2020-11-04T22:37:55.7716410' AS DateTime2), N'74dffedd-b38f-40a4-9806-0bda7b3277f5', NULL, NULL, 88, 2, 4, CAST(232.00 AS Decimal(12, 2)), N'32', N'42', NULL, N'3242', CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[LotterySaleItems] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [LotterySaleId], [LotteryModeId], [LotteryId], [PlayedAmount], [Played1], [Played2], [Played3], [PlayedNumbers], [Prize], [Prize1], [Prize2], [Prize3]) VALUES (121, NULL, 0, CAST(N'2020-11-04T16:55:24.3980190' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', CAST(N'2020-11-04T16:55:24.3980190' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', NULL, NULL, 89, 2, 4, CAST(234.00 AS Decimal(12, 2)), N'23', N'42', NULL, N'2342', CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[LotterySaleItems] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [LotterySaleId], [LotteryModeId], [LotteryId], [PlayedAmount], [Played1], [Played2], [Played3], [PlayedNumbers], [Prize], [Prize1], [Prize2], [Prize3]) VALUES (122, NULL, 0, CAST(N'2020-11-04T16:55:31.4955080' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', CAST(N'2020-11-04T16:55:31.4955080' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', NULL, NULL, 90, 2, 4, CAST(234.00 AS Decimal(12, 2)), N'23', N'42', NULL, N'2342', CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[LotterySaleItems] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [LotterySaleId], [LotteryModeId], [LotteryId], [PlayedAmount], [Played1], [Played2], [Played3], [PlayedNumbers], [Prize], [Prize1], [Prize2], [Prize3]) VALUES (123, NULL, 0, CAST(N'2020-11-04T16:55:41.2614040' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', CAST(N'2020-11-04T22:51:30.8657557' AS DateTime2), N'74dffedd-b38f-40a4-9806-0bda7b3277f5', NULL, NULL, 91, 5, 3, CAST(23.00 AS Decimal(12, 2)), N'234', NULL, NULL, N'234', CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[LotterySaleItems] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [LotterySaleId], [LotteryModeId], [LotteryId], [PlayedAmount], [Played1], [Played2], [Played3], [PlayedNumbers], [Prize], [Prize1], [Prize2], [Prize3]) VALUES (124, NULL, 0, CAST(N'2020-11-04T16:55:49.2580070' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', CAST(N'2020-11-04T22:51:30.8715118' AS DateTime2), N'74dffedd-b38f-40a4-9806-0bda7b3277f5', NULL, NULL, 92, 5, 3, CAST(2344.00 AS Decimal(12, 2)), N'234', NULL, NULL, N'234', CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[LotterySaleItems] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [LotterySaleId], [LotteryModeId], [LotteryId], [PlayedAmount], [Played1], [Played2], [Played3], [PlayedNumbers], [Prize], [Prize1], [Prize2], [Prize3]) VALUES (125, NULL, 0, CAST(N'2020-11-04T16:56:04.5085750' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', CAST(N'2020-11-04T22:51:30.8718135' AS DateTime2), N'74dffedd-b38f-40a4-9806-0bda7b3277f5', NULL, NULL, 93, 7, 3, CAST(2423.00 AS Decimal(12, 2)), N'10', N'00', NULL, N'1000', CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[LotterySaleItems] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [LotterySaleId], [LotteryModeId], [LotteryId], [PlayedAmount], [Played1], [Played2], [Played3], [PlayedNumbers], [Prize], [Prize1], [Prize2], [Prize3]) VALUES (126, NULL, 0, CAST(N'2020-11-04T16:56:13.9043350' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', CAST(N'2020-11-04T22:51:30.8720988' AS DateTime2), N'74dffedd-b38f-40a4-9806-0bda7b3277f5', NULL, NULL, 94, 5, 3, CAST(234.00 AS Decimal(12, 2)), N'234', NULL, NULL, N'234', CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[LotterySaleItems] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [LotterySaleId], [LotteryModeId], [LotteryId], [PlayedAmount], [Played1], [Played2], [Played3], [PlayedNumbers], [Prize], [Prize1], [Prize2], [Prize3]) VALUES (127, NULL, 0, CAST(N'2020-11-04T16:56:54.1363900' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', CAST(N'2020-11-04T22:51:30.8723978' AS DateTime2), N'74dffedd-b38f-40a4-9806-0bda7b3277f5', NULL, NULL, 95, 4, 3, CAST(123.00 AS Decimal(12, 2)), N'12', NULL, NULL, N'12', CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[LotterySaleItems] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [LotterySaleId], [LotteryModeId], [LotteryId], [PlayedAmount], [Played1], [Played2], [Played3], [PlayedNumbers], [Prize], [Prize1], [Prize2], [Prize3]) VALUES (128, NULL, 0, CAST(N'2020-11-04T21:50:26.8707852' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', CAST(N'2020-11-04T21:50:26.8707852' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', NULL, NULL, 96, 4, 2, CAST(12.00 AS Decimal(12, 2)), N'12', NULL, NULL, N'12', CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[LotterySaleItems] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [LotterySaleId], [LotteryModeId], [LotteryId], [PlayedAmount], [Played1], [Played2], [Played3], [PlayedNumbers], [Prize], [Prize1], [Prize2], [Prize3]) VALUES (129, NULL, 0, CAST(N'2020-11-04T21:50:39.8677836' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', CAST(N'2020-11-04T21:50:39.8677836' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', NULL, NULL, 97, 4, 2, CAST(344.00 AS Decimal(12, 2)), N'34', NULL, NULL, N'34', CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[LotterySaleItems] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [LotterySaleId], [LotteryModeId], [LotteryId], [PlayedAmount], [Played1], [Played2], [Played3], [PlayedNumbers], [Prize], [Prize1], [Prize2], [Prize3]) VALUES (130, NULL, 0, CAST(N'2020-11-05T00:50:14.6840112' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', CAST(N'2020-11-05T00:50:14.6840112' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', NULL, NULL, 98, 5, 2, CAST(1000.00 AS Decimal(12, 2)), N'123', NULL, NULL, N'123', CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[LotterySaleItems] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [LotterySaleId], [LotteryModeId], [LotteryId], [PlayedAmount], [Played1], [Played2], [Played3], [PlayedNumbers], [Prize], [Prize1], [Prize2], [Prize3]) VALUES (131, NULL, 0, CAST(N'2020-11-05T00:50:14.6847748' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', CAST(N'2020-11-05T00:50:14.6847748' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', NULL, NULL, 98, 7, 2, CAST(1000.00 AS Decimal(12, 2)), N'12', N'34', NULL, N'1234', CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[LotterySaleItems] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [LotterySaleId], [LotteryModeId], [LotteryId], [PlayedAmount], [Played1], [Played2], [Played3], [PlayedNumbers], [Prize], [Prize1], [Prize2], [Prize3]) VALUES (132, NULL, 0, CAST(N'2020-11-05T00:50:14.6855405' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', CAST(N'2020-11-05T00:50:14.6855405' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', NULL, NULL, 98, 6, 2, CAST(1000.00 AS Decimal(12, 2)), N'12', N'34', NULL, N'1234', CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[LotterySaleItems] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [LotterySaleId], [LotteryModeId], [LotteryId], [PlayedAmount], [Played1], [Played2], [Played3], [PlayedNumbers], [Prize], [Prize1], [Prize2], [Prize3]) VALUES (133, NULL, 0, CAST(N'2020-11-06T15:54:13.4653985' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', CAST(N'2020-11-06T15:54:13.4653985' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', NULL, NULL, 99, 4, 2, CAST(1000.00 AS Decimal(12, 2)), N'22', NULL, NULL, N'22', CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[LotterySaleItems] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [LotterySaleId], [LotteryModeId], [LotteryId], [PlayedAmount], [Played1], [Played2], [Played3], [PlayedNumbers], [Prize], [Prize1], [Prize2], [Prize3]) VALUES (134, NULL, 0, CAST(N'2020-11-06T15:54:13.4661363' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', CAST(N'2020-11-06T15:54:13.4661363' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', NULL, NULL, 99, 4, 2, CAST(1000.00 AS Decimal(12, 2)), N'68', NULL, NULL, N'68', CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[LotterySaleItems] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [LotterySaleId], [LotteryModeId], [LotteryId], [PlayedAmount], [Played1], [Played2], [Played3], [PlayedNumbers], [Prize], [Prize1], [Prize2], [Prize3]) VALUES (135, NULL, 0, CAST(N'2020-11-06T15:54:13.4668569' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', CAST(N'2020-11-06T15:54:13.4668569' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', NULL, NULL, 99, 4, 2, CAST(1000.00 AS Decimal(12, 2)), N'23', NULL, NULL, N'23', CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[LotterySaleItems] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [LotterySaleId], [LotteryModeId], [LotteryId], [PlayedAmount], [Played1], [Played2], [Played3], [PlayedNumbers], [Prize], [Prize1], [Prize2], [Prize3]) VALUES (136, NULL, 0, CAST(N'2020-11-06T15:54:13.4676429' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', CAST(N'2020-11-06T15:54:13.4676429' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', NULL, NULL, 99, 4, 2, CAST(1000.00 AS Decimal(12, 2)), N'21', NULL, NULL, N'21', CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[LotterySaleItems] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [LotterySaleId], [LotteryModeId], [LotteryId], [PlayedAmount], [Played1], [Played2], [Played3], [PlayedNumbers], [Prize], [Prize1], [Prize2], [Prize3]) VALUES (137, NULL, 0, CAST(N'2020-11-06T15:54:13.4742416' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', CAST(N'2020-11-06T15:54:13.4742416' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', NULL, NULL, 99, 5, 2, CAST(1000.00 AS Decimal(12, 2)), N'232', NULL, NULL, N'232', CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[LotterySaleItems] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [LotterySaleId], [LotteryModeId], [LotteryId], [PlayedAmount], [Played1], [Played2], [Played3], [PlayedNumbers], [Prize], [Prize1], [Prize2], [Prize3]) VALUES (138, NULL, 0, CAST(N'2020-11-06T15:54:13.4749395' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', CAST(N'2020-11-06T15:54:13.4749395' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', NULL, NULL, 99, 5, 2, CAST(1000.00 AS Decimal(12, 2)), N'423', NULL, NULL, N'423', CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[LotterySaleItems] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [LotterySaleId], [LotteryModeId], [LotteryId], [PlayedAmount], [Played1], [Played2], [Played3], [PlayedNumbers], [Prize], [Prize1], [Prize2], [Prize3]) VALUES (139, NULL, 0, CAST(N'2020-11-06T15:54:13.4757340' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', CAST(N'2020-11-06T15:54:13.4757340' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', NULL, NULL, 99, 7, 2, CAST(1000.00 AS Decimal(12, 2)), N'21', N'32', NULL, N'2132', CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[LotterySaleItems] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [LotterySaleId], [LotteryModeId], [LotteryId], [PlayedAmount], [Played1], [Played2], [Played3], [PlayedNumbers], [Prize], [Prize1], [Prize2], [Prize3]) VALUES (140, NULL, 0, CAST(N'2020-11-06T16:01:20.8085001' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', CAST(N'2020-11-06T16:11:32.2368449' AS DateTime2), N'74dffedd-b38f-40a4-9806-0bda7b3277f5', NULL, NULL, 100, 4, 3, CAST(2000.00 AS Decimal(12, 2)), N'23', NULL, NULL, N'23', CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[LotterySaleItems] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [LotterySaleId], [LotteryModeId], [LotteryId], [PlayedAmount], [Played1], [Played2], [Played3], [PlayedNumbers], [Prize], [Prize1], [Prize2], [Prize3]) VALUES (141, NULL, 0, CAST(N'2020-11-06T16:01:20.8149689' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', CAST(N'2020-11-06T16:11:32.2369908' AS DateTime2), N'74dffedd-b38f-40a4-9806-0bda7b3277f5', NULL, NULL, 100, 4, 3, CAST(2000.00 AS Decimal(12, 2)), N'55', NULL, NULL, N'55', CAST(20000.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(20000.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[LotterySaleItems] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [LotterySaleId], [LotteryModeId], [LotteryId], [PlayedAmount], [Played1], [Played2], [Played3], [PlayedNumbers], [Prize], [Prize1], [Prize2], [Prize3]) VALUES (142, NULL, 0, CAST(N'2020-11-11T12:14:13.9637818' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', CAST(N'2020-11-11T12:17:01.6052180' AS DateTime2), N'74dffedd-b38f-40a4-9806-0bda7b3277f5', NULL, NULL, 101, 4, 3, CAST(2000.00 AS Decimal(12, 2)), N'22', NULL, NULL, N'22', CAST(40000.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(40000.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[LotterySaleItems] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [LotterySaleId], [LotteryModeId], [LotteryId], [PlayedAmount], [Played1], [Played2], [Played3], [PlayedNumbers], [Prize], [Prize1], [Prize2], [Prize3]) VALUES (143, NULL, 0, CAST(N'2020-11-11T12:14:13.9644002' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', CAST(N'2020-11-11T12:17:01.6053859' AS DateTime2), N'74dffedd-b38f-40a4-9806-0bda7b3277f5', NULL, NULL, 101, 4, 3, CAST(2000.00 AS Decimal(12, 2)), N'23', NULL, NULL, N'23', CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[LotterySaleItems] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [LotterySaleId], [LotteryModeId], [LotteryId], [PlayedAmount], [Played1], [Played2], [Played3], [PlayedNumbers], [Prize], [Prize1], [Prize2], [Prize3]) VALUES (144, NULL, 0, CAST(N'2020-11-11T12:14:13.9650242' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', CAST(N'2020-11-11T12:17:01.6055584' AS DateTime2), N'74dffedd-b38f-40a4-9806-0bda7b3277f5', NULL, NULL, 101, 5, 3, CAST(3000.00 AS Decimal(12, 2)), N'123', NULL, NULL, N'123', CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[LotterySaleItems] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [LotterySaleId], [LotteryModeId], [LotteryId], [PlayedAmount], [Played1], [Played2], [Played3], [PlayedNumbers], [Prize], [Prize1], [Prize2], [Prize3]) VALUES (145, NULL, 0, CAST(N'2020-11-11T12:14:13.9656785' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', CAST(N'2020-11-11T12:17:01.6057194' AS DateTime2), N'74dffedd-b38f-40a4-9806-0bda7b3277f5', NULL, NULL, 101, 4, 3, CAST(1000.00 AS Decimal(12, 2)), N'68', NULL, NULL, N'68', CAST(10000.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(10000.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[LotterySaleItems] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [LotterySaleId], [LotteryModeId], [LotteryId], [PlayedAmount], [Played1], [Played2], [Played3], [PlayedNumbers], [Prize], [Prize1], [Prize2], [Prize3]) VALUES (146, NULL, 0, CAST(N'2020-11-11T12:14:13.9663508' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', CAST(N'2020-11-11T12:17:01.6058997' AS DateTime2), N'74dffedd-b38f-40a4-9806-0bda7b3277f5', NULL, NULL, 101, 7, 3, CAST(1000.00 AS Decimal(12, 2)), N'22', N'68', NULL, N'2268', CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[LotterySaleItems] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [LotterySaleId], [LotteryModeId], [LotteryId], [PlayedAmount], [Played1], [Played2], [Played3], [PlayedNumbers], [Prize], [Prize1], [Prize2], [Prize3]) VALUES (147, NULL, 0, CAST(N'2020-11-17T19:33:46.7620280' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', CAST(N'2020-11-17T21:38:59.0506620' AS DateTime2), N'74dffedd-b38f-40a4-9806-0bda7b3277f5', NULL, NULL, 102, 5, 2, CAST(100.00 AS Decimal(12, 2)), N'123', N'12', NULL, N'123', CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[LotterySaleItems] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [LotterySaleId], [LotteryModeId], [LotteryId], [PlayedAmount], [Played1], [Played2], [Played3], [PlayedNumbers], [Prize], [Prize1], [Prize2], [Prize3]) VALUES (148, NULL, 0, CAST(N'2020-11-17T19:33:46.7628320' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', CAST(N'2020-11-17T21:38:59.0527050' AS DateTime2), N'74dffedd-b38f-40a4-9806-0bda7b3277f5', NULL, NULL, 102, 7, 2, CAST(100.00 AS Decimal(12, 2)), N'12', N'12', NULL, N'1234', CAST(420000.00 AS Decimal(18, 2)), CAST(210000.00 AS Decimal(18, 2)), CAST(210000.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[LotterySaleItems] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [LotterySaleId], [LotteryModeId], [LotteryId], [PlayedAmount], [Played1], [Played2], [Played3], [PlayedNumbers], [Prize], [Prize1], [Prize2], [Prize3]) VALUES (149, NULL, 0, CAST(N'2020-11-17T19:33:46.7637960' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', CAST(N'2020-11-17T21:38:59.0523120' AS DateTime2), N'74dffedd-b38f-40a4-9806-0bda7b3277f5', NULL, NULL, 102, 6, 2, CAST(100.00 AS Decimal(12, 2)), N'12', N'12', NULL, N'1234', CAST(200000.00 AS Decimal(18, 2)), CAST(200000.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[LotterySaleItems] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [LotterySaleId], [LotteryModeId], [LotteryId], [PlayedAmount], [Played1], [Played2], [Played3], [PlayedNumbers], [Prize], [Prize1], [Prize2], [Prize3]) VALUES (150, NULL, 0, CAST(N'2020-11-17T19:33:46.7645950' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', CAST(N'2020-11-17T21:38:59.0488090' AS DateTime2), N'74dffedd-b38f-40a4-9806-0bda7b3277f5', NULL, NULL, 102, 4, 2, CAST(100.00 AS Decimal(12, 2)), N'12', N'12', NULL, N'12', CAST(9000.00 AS Decimal(18, 2)), CAST(6000.00 AS Decimal(18, 2)), CAST(8000.00 AS Decimal(18, 2)), CAST(9000.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[LotterySaleItems] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [LotterySaleId], [LotteryModeId], [LotteryId], [PlayedAmount], [Played1], [Played2], [Played3], [PlayedNumbers], [Prize], [Prize1], [Prize2], [Prize3]) VALUES (151, NULL, 0, CAST(N'2020-11-17T19:34:02.2173480' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', CAST(N'2020-11-17T21:38:59.0490010' AS DateTime2), N'74dffedd-b38f-40a4-9806-0bda7b3277f5', NULL, NULL, 103, 4, 2, CAST(100.00 AS Decimal(12, 2)), N'12', NULL, NULL, N'12', CAST(21000.00 AS Decimal(18, 2)), CAST(30000.00 AS Decimal(18, 2)), CAST(32000.00 AS Decimal(18, 2)), CAST(21000.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[LotterySaleItems] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [LotterySaleId], [LotteryModeId], [LotteryId], [PlayedAmount], [Played1], [Played2], [Played3], [PlayedNumbers], [Prize], [Prize1], [Prize2], [Prize3]) VALUES (152, NULL, 0, CAST(N'2020-11-17T19:34:50.5480910' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', CAST(N'2020-11-17T21:38:59.0494360' AS DateTime2), N'74dffedd-b38f-40a4-9806-0bda7b3277f5', NULL, NULL, 104, 4, 2, CAST(100.00 AS Decimal(12, 2)), N'12', NULL, NULL, N'12', CAST(21000.00 AS Decimal(18, 2)), CAST(30000.00 AS Decimal(18, 2)), CAST(32000.00 AS Decimal(18, 2)), CAST(21000.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[LotterySaleItems] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [LotterySaleId], [LotteryModeId], [LotteryId], [PlayedAmount], [Played1], [Played2], [Played3], [PlayedNumbers], [Prize], [Prize1], [Prize2], [Prize3]) VALUES (153, NULL, 0, CAST(N'2020-11-17T19:34:50.5486380' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', CAST(N'2020-11-17T21:38:59.0509940' AS DateTime2), N'74dffedd-b38f-40a4-9806-0bda7b3277f5', NULL, NULL, 104, 5, 2, CAST(1000.00 AS Decimal(12, 2)), N'234', NULL, NULL, N'234', CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[LotterySaleItems] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [LotterySaleId], [LotteryModeId], [LotteryId], [PlayedAmount], [Played1], [Played2], [Played3], [PlayedNumbers], [Prize], [Prize1], [Prize2], [Prize3]) VALUES (154, NULL, 0, CAST(N'2020-11-17T19:34:50.5492010' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', CAST(N'2020-11-17T21:38:59.0511930' AS DateTime2), N'74dffedd-b38f-40a4-9806-0bda7b3277f5', NULL, NULL, 104, 5, 2, CAST(1213.00 AS Decimal(12, 2)), N'342', NULL, NULL, N'342', CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[LotterySaleItems] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [LotterySaleId], [LotteryModeId], [LotteryId], [PlayedAmount], [Played1], [Played2], [Played3], [PlayedNumbers], [Prize], [Prize1], [Prize2], [Prize3]) VALUES (155, NULL, 0, CAST(N'2020-11-17T19:34:50.5498390' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', CAST(N'2020-11-17T21:38:59.0529060' AS DateTime2), N'74dffedd-b38f-40a4-9806-0bda7b3277f5', NULL, NULL, 104, 7, 2, CAST(123.00 AS Decimal(12, 2)), N'12', N'31', NULL, N'1231', CAST(688800.00 AS Decimal(18, 2)), CAST(688800.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[LotterySaleItems] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [LotterySaleId], [LotteryModeId], [LotteryId], [PlayedAmount], [Played1], [Played2], [Played3], [PlayedNumbers], [Prize], [Prize1], [Prize2], [Prize3]) VALUES (156, NULL, 0, CAST(N'2020-11-17T19:35:09.7564020' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', CAST(N'2020-11-17T21:38:59.0514270' AS DateTime2), N'74dffedd-b38f-40a4-9806-0bda7b3277f5', NULL, NULL, 105, 5, 2, CAST(100.00 AS Decimal(12, 2)), N'123', NULL, NULL, N'123', CAST(150000.00 AS Decimal(18, 2)), CAST(300000.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[LotterySaleItems] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [LotterySaleId], [LotteryModeId], [LotteryId], [PlayedAmount], [Played1], [Played2], [Played3], [PlayedNumbers], [Prize], [Prize1], [Prize2], [Prize3]) VALUES (157, NULL, 0, CAST(N'2020-11-17T19:35:09.7569300' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', CAST(N'2020-11-17T21:38:59.0516170' AS DateTime2), N'74dffedd-b38f-40a4-9806-0bda7b3277f5', NULL, NULL, 105, 5, 2, CAST(100.00 AS Decimal(12, 2)), N'234', NULL, NULL, N'234', CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[LotterySaleItems] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [LotterySaleId], [LotteryModeId], [LotteryId], [PlayedAmount], [Played1], [Played2], [Played3], [PlayedNumbers], [Prize], [Prize1], [Prize2], [Prize3]) VALUES (158, NULL, 0, CAST(N'2020-11-17T19:35:37.5374240' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', CAST(N'2020-11-17T21:38:59.0525170' AS DateTime2), N'74dffedd-b38f-40a4-9806-0bda7b3277f5', NULL, NULL, 106, 6, 2, CAST(100.00 AS Decimal(12, 2)), N'12', N'34', NULL, N'1234', CAST(600000.00 AS Decimal(18, 2)), CAST(1200000.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[LotterySaleItems] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [LotterySaleId], [LotteryModeId], [LotteryId], [PlayedAmount], [Played1], [Played2], [Played3], [PlayedNumbers], [Prize], [Prize1], [Prize2], [Prize3]) VALUES (159, NULL, 0, CAST(N'2020-11-17T19:35:37.5380390' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', CAST(N'2020-11-17T21:38:59.0518200' AS DateTime2), N'74dffedd-b38f-40a4-9806-0bda7b3277f5', NULL, NULL, 106, 5, 2, CAST(23424.00 AS Decimal(12, 2)), N'234', NULL, NULL, N'234', CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[LotterySaleItems] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [LotterySaleId], [LotteryModeId], [LotteryId], [PlayedAmount], [Played1], [Played2], [Played3], [PlayedNumbers], [Prize], [Prize1], [Prize2], [Prize3]) VALUES (160, NULL, 0, CAST(N'2020-11-17T19:36:00.3047480' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', CAST(N'2020-11-17T21:38:59.0531090' AS DateTime2), N'74dffedd-b38f-40a4-9806-0bda7b3277f5', NULL, NULL, 107, 7, 2, CAST(100.00 AS Decimal(12, 2)), N'12', N'34', NULL, N'1234', CAST(700000.00 AS Decimal(18, 2)), CAST(560000.00 AS Decimal(18, 2)), CAST(210000.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[LotterySaleItems] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [LotterySaleId], [LotteryModeId], [LotteryId], [PlayedAmount], [Played1], [Played2], [Played3], [PlayedNumbers], [Prize], [Prize1], [Prize2], [Prize3]) VALUES (161, NULL, 0, CAST(N'2020-11-17T19:36:00.3053730' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', CAST(N'2020-11-17T21:38:59.0520920' AS DateTime2), N'74dffedd-b38f-40a4-9806-0bda7b3277f5', NULL, NULL, 107, 5, 2, CAST(3545.00 AS Decimal(12, 2)), N'345', NULL, NULL, N'345', CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[LotterySaleItems] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [LotterySaleId], [LotteryModeId], [LotteryId], [PlayedAmount], [Played1], [Played2], [Played3], [PlayedNumbers], [Prize], [Prize1], [Prize2], [Prize3]) VALUES (162, NULL, 0, CAST(N'2020-11-17T19:36:36.5608670' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', CAST(N'2020-11-17T21:38:59.0498330' AS DateTime2), N'74dffedd-b38f-40a4-9806-0bda7b3277f5', NULL, NULL, 108, 4, 2, CAST(100.00 AS Decimal(12, 2)), N'12', NULL, NULL, N'12', CAST(21000.00 AS Decimal(18, 2)), CAST(30000.00 AS Decimal(18, 2)), CAST(32000.00 AS Decimal(18, 2)), CAST(21000.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[LotterySaleItems] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [LotterySaleId], [LotteryModeId], [LotteryId], [PlayedAmount], [Played1], [Played2], [Played3], [PlayedNumbers], [Prize], [Prize1], [Prize2], [Prize3]) VALUES (163, NULL, 0, CAST(N'2020-11-17T19:36:36.5614530' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', CAST(N'2020-11-17T21:38:59.0502870' AS DateTime2), N'74dffedd-b38f-40a4-9806-0bda7b3277f5', NULL, NULL, 108, 4, 2, CAST(100.00 AS Decimal(12, 2)), N'12', NULL, NULL, N'12', CAST(21000.00 AS Decimal(18, 2)), CAST(30000.00 AS Decimal(18, 2)), CAST(32000.00 AS Decimal(18, 2)), CAST(21000.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[LotterySaleItems] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [LotterySaleId], [LotteryModeId], [LotteryId], [PlayedAmount], [Played1], [Played2], [Played3], [PlayedNumbers], [Prize], [Prize1], [Prize2], [Prize3]) VALUES (164, NULL, 0, CAST(N'2020-12-09T17:35:01.6896167' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', CAST(N'2020-12-09T17:35:01.6896167' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', NULL, NULL, 109, 5, 2, CAST(1000.00 AS Decimal(12, 2)), N'333', NULL, NULL, N'333', CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)))
GO
SET IDENTITY_INSERT [dbo].[LotterySaleItems] OFF
GO
SET IDENTITY_INSERT [dbo].[LotterySales] ON 
GO
INSERT [dbo].[LotterySales] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [Ticket], [Barcode], [TotalAmount], [SeqByOwner], [SeqByShop], [Remarks], [Prize], [WasPaid], [Anulated], [Winner], [AnulatedSol]) VALUES (1, NULL, 0, CAST(N'2020-09-02T18:44:29.5403559' AS DateTime2), N'74dffedd-b38f-40a4-9806-0bda7b3277f5', CAST(N'2020-09-02T18:44:29.5403559' AS DateTime2), N'74dffedd-b38f-40a4-9806-0bda7b3277f5', NULL, NULL, N'00001', NULL, CAST(1212.00 AS Decimal(12, 2)), 1, 1, N'', CAST(0.00 AS Decimal(12, 2)), 0, 0, 0, 0)
GO
INSERT [dbo].[LotterySales] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [Ticket], [Barcode], [TotalAmount], [SeqByOwner], [SeqByShop], [Remarks], [Prize], [WasPaid], [Anulated], [Winner], [AnulatedSol]) VALUES (2, NULL, 0, CAST(N'2020-09-02T18:51:37.6882682' AS DateTime2), N'74dffedd-b38f-40a4-9806-0bda7b3277f5', CAST(N'2020-09-02T18:51:37.6882682' AS DateTime2), N'74dffedd-b38f-40a4-9806-0bda7b3277f5', NULL, NULL, N'00002', NULL, CAST(400.00 AS Decimal(12, 2)), 2, 2, N'', CAST(0.00 AS Decimal(12, 2)), 0, 0, 0, 0)
GO
INSERT [dbo].[LotterySales] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [Ticket], [Barcode], [TotalAmount], [SeqByOwner], [SeqByShop], [Remarks], [Prize], [WasPaid], [Anulated], [Winner], [AnulatedSol]) VALUES (3, NULL, 0, CAST(N'2020-09-02T18:53:33.9517796' AS DateTime2), N'74dffedd-b38f-40a4-9806-0bda7b3277f5', CAST(N'2020-09-02T18:53:33.9517796' AS DateTime2), N'74dffedd-b38f-40a4-9806-0bda7b3277f5', NULL, NULL, N'00003', NULL, CAST(150.00 AS Decimal(12, 2)), 3, 3, N'', CAST(0.00 AS Decimal(12, 2)), 0, 0, 0, 0)
GO
INSERT [dbo].[LotterySales] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [Ticket], [Barcode], [TotalAmount], [SeqByOwner], [SeqByShop], [Remarks], [Prize], [WasPaid], [Anulated], [Winner], [AnulatedSol]) VALUES (4, NULL, 0, CAST(N'2020-09-02T18:55:20.7597607' AS DateTime2), N'74dffedd-b38f-40a4-9806-0bda7b3277f5', CAST(N'2020-10-17T19:56:34.9507890' AS DateTime2), N'74dffedd-b38f-40a4-9806-0bda7b3277f5', NULL, NULL, N'00004', NULL, CAST(100.00 AS Decimal(12, 2)), 4, 4, N'', CAST(0.00 AS Decimal(12, 2)), 0, 0, 0, 0)
GO
INSERT [dbo].[LotterySales] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [Ticket], [Barcode], [TotalAmount], [SeqByOwner], [SeqByShop], [Remarks], [Prize], [WasPaid], [Anulated], [Winner], [AnulatedSol]) VALUES (5, NULL, 0, CAST(N'2020-09-02T18:55:58.8392564' AS DateTime2), N'74dffedd-b38f-40a4-9806-0bda7b3277f5', CAST(N'2020-09-02T18:55:58.8392564' AS DateTime2), N'74dffedd-b38f-40a4-9806-0bda7b3277f5', NULL, NULL, N'00005', NULL, CAST(1525.00 AS Decimal(12, 2)), 5, 5, N'', CAST(0.00 AS Decimal(12, 2)), 0, 0, 0, 0)
GO
INSERT [dbo].[LotterySales] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [Ticket], [Barcode], [TotalAmount], [SeqByOwner], [SeqByShop], [Remarks], [Prize], [WasPaid], [Anulated], [Winner], [AnulatedSol]) VALUES (6, NULL, 0, CAST(N'2020-09-03T07:56:37.2485533' AS DateTime2), N'74dffedd-b38f-40a4-9806-0bda7b3277f5', CAST(N'2020-09-03T17:11:06.4266225' AS DateTime2), N'74dffedd-b38f-40a4-9806-0bda7b3277f5', NULL, NULL, N'00006', NULL, CAST(300.00 AS Decimal(12, 2)), 6, 6, N'', CAST(610000.00 AS Decimal(12, 2)), 0, 0, 0, 0)
GO
INSERT [dbo].[LotterySales] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [Ticket], [Barcode], [TotalAmount], [SeqByOwner], [SeqByShop], [Remarks], [Prize], [WasPaid], [Anulated], [Winner], [AnulatedSol]) VALUES (7, NULL, 0, CAST(N'2020-09-03T09:05:27.8270128' AS DateTime2), N'74dffedd-b38f-40a4-9806-0bda7b3277f5', CAST(N'2020-09-03T17:16:39.6589138' AS DateTime2), N'74dffedd-b38f-40a4-9806-0bda7b3277f5', NULL, NULL, N'00007', NULL, CAST(300.00 AS Decimal(12, 2)), 7, 7, N'', CAST(610000.00 AS Decimal(12, 2)), 1, 0, 0, 0)
GO
INSERT [dbo].[LotterySales] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [Ticket], [Barcode], [TotalAmount], [SeqByOwner], [SeqByShop], [Remarks], [Prize], [WasPaid], [Anulated], [Winner], [AnulatedSol]) VALUES (8, NULL, 0, CAST(N'2020-09-03T19:49:22.3752439' AS DateTime2), N'74dffedd-b38f-40a4-9806-0bda7b3277f5', CAST(N'2020-09-03T19:49:22.3752439' AS DateTime2), N'74dffedd-b38f-40a4-9806-0bda7b3277f5', NULL, NULL, N'00008', NULL, CAST(400.00 AS Decimal(12, 2)), 8, 8, N'', CAST(0.00 AS Decimal(12, 2)), 0, 0, 0, 0)
GO
INSERT [dbo].[LotterySales] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [Ticket], [Barcode], [TotalAmount], [SeqByOwner], [SeqByShop], [Remarks], [Prize], [WasPaid], [Anulated], [Winner], [AnulatedSol]) VALUES (9, NULL, 0, CAST(N'2020-09-06T00:16:08.9913022' AS DateTime2), N'74dffedd-b38f-40a4-9806-0bda7b3277f5', CAST(N'2020-09-06T00:16:08.9913022' AS DateTime2), N'74dffedd-b38f-40a4-9806-0bda7b3277f5', NULL, NULL, N'00009', NULL, CAST(100.00 AS Decimal(12, 2)), 9, 9, N'', CAST(0.00 AS Decimal(12, 2)), 0, 0, 0, 0)
GO
INSERT [dbo].[LotterySales] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [Ticket], [Barcode], [TotalAmount], [SeqByOwner], [SeqByShop], [Remarks], [Prize], [WasPaid], [Anulated], [Winner], [AnulatedSol]) VALUES (10, NULL, 0, CAST(N'2020-09-06T00:18:35.6778521' AS DateTime2), N'74dffedd-b38f-40a4-9806-0bda7b3277f5', CAST(N'2020-09-06T00:18:35.6778521' AS DateTime2), N'74dffedd-b38f-40a4-9806-0bda7b3277f5', NULL, NULL, N'00010', NULL, CAST(200.00 AS Decimal(12, 2)), 10, 10, N'', CAST(0.00 AS Decimal(12, 2)), 0, 0, 0, 0)
GO
INSERT [dbo].[LotterySales] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [Ticket], [Barcode], [TotalAmount], [SeqByOwner], [SeqByShop], [Remarks], [Prize], [WasPaid], [Anulated], [Winner], [AnulatedSol]) VALUES (11, NULL, 0, CAST(N'2020-09-06T01:37:26.2341010' AS DateTime2), N'74dffedd-b38f-40a4-9806-0bda7b3277f5', CAST(N'2020-09-06T01:37:26.2341010' AS DateTime2), N'74dffedd-b38f-40a4-9806-0bda7b3277f5', NULL, NULL, N'00011', NULL, CAST(100.00 AS Decimal(12, 2)), 11, 11, N'', CAST(0.00 AS Decimal(12, 2)), 0, 0, 0, 0)
GO
INSERT [dbo].[LotterySales] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [Ticket], [Barcode], [TotalAmount], [SeqByOwner], [SeqByShop], [Remarks], [Prize], [WasPaid], [Anulated], [Winner], [AnulatedSol]) VALUES (12, NULL, 0, CAST(N'2020-09-10T01:01:53.2114504' AS DateTime2), N'74dffedd-b38f-40a4-9806-0bda7b3277f5', CAST(N'2020-09-10T01:01:53.2114504' AS DateTime2), N'74dffedd-b38f-40a4-9806-0bda7b3277f5', NULL, NULL, N'00012', NULL, CAST(111.00 AS Decimal(12, 2)), 12, 12, N'', CAST(0.00 AS Decimal(12, 2)), 0, 0, 0, 0)
GO
INSERT [dbo].[LotterySales] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [Ticket], [Barcode], [TotalAmount], [SeqByOwner], [SeqByShop], [Remarks], [Prize], [WasPaid], [Anulated], [Winner], [AnulatedSol]) VALUES (13, NULL, 0, CAST(N'2020-09-10T01:12:56.9588788' AS DateTime2), N'74dffedd-b38f-40a4-9806-0bda7b3277f5', CAST(N'2020-09-10T01:29:28.8623168' AS DateTime2), N'74dffedd-b38f-40a4-9806-0bda7b3277f5', NULL, NULL, N'00013', NULL, CAST(100.00 AS Decimal(12, 2)), 13, 13, N'', CAST(200000.00 AS Decimal(12, 2)), 0, 0, 0, 0)
GO
INSERT [dbo].[LotterySales] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [Ticket], [Barcode], [TotalAmount], [SeqByOwner], [SeqByShop], [Remarks], [Prize], [WasPaid], [Anulated], [Winner], [AnulatedSol]) VALUES (14, NULL, 0, CAST(N'2020-09-10T01:13:45.1937624' AS DateTime2), N'74dffedd-b38f-40a4-9806-0bda7b3277f5', CAST(N'2020-09-10T01:29:28.8804656' AS DateTime2), N'74dffedd-b38f-40a4-9806-0bda7b3277f5', NULL, NULL, N'00014', NULL, CAST(100.00 AS Decimal(12, 2)), 14, 14, N'', CAST(50000.00 AS Decimal(12, 2)), 0, 0, 0, 0)
GO
INSERT [dbo].[LotterySales] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [Ticket], [Barcode], [TotalAmount], [SeqByOwner], [SeqByShop], [Remarks], [Prize], [WasPaid], [Anulated], [Winner], [AnulatedSol]) VALUES (15, NULL, 0, CAST(N'2020-09-10T11:28:36.4469794' AS DateTime2), N'74dffedd-b38f-40a4-9806-0bda7b3277f5', CAST(N'2020-09-10T11:28:36.4469794' AS DateTime2), N'74dffedd-b38f-40a4-9806-0bda7b3277f5', NULL, NULL, N'00015', NULL, CAST(400.00 AS Decimal(12, 2)), 15, 15, N'', CAST(0.00 AS Decimal(12, 2)), 0, 0, 0, 0)
GO
INSERT [dbo].[LotterySales] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [Ticket], [Barcode], [TotalAmount], [SeqByOwner], [SeqByShop], [Remarks], [Prize], [WasPaid], [Anulated], [Winner], [AnulatedSol]) VALUES (16, NULL, 0, CAST(N'2020-09-10T11:46:58.2511212' AS DateTime2), N'74dffedd-b38f-40a4-9806-0bda7b3277f5', CAST(N'2020-09-10T11:46:58.2511212' AS DateTime2), N'74dffedd-b38f-40a4-9806-0bda7b3277f5', NULL, NULL, N'00016', NULL, CAST(200.00 AS Decimal(12, 2)), 16, 16, N'', CAST(0.00 AS Decimal(12, 2)), 0, 0, 0, 0)
GO
INSERT [dbo].[LotterySales] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [Ticket], [Barcode], [TotalAmount], [SeqByOwner], [SeqByShop], [Remarks], [Prize], [WasPaid], [Anulated], [Winner], [AnulatedSol]) VALUES (17, NULL, 0, CAST(N'2020-09-10T11:57:34.6270427' AS DateTime2), N'74dffedd-b38f-40a4-9806-0bda7b3277f5', CAST(N'2020-09-10T11:57:34.6270427' AS DateTime2), N'74dffedd-b38f-40a4-9806-0bda7b3277f5', NULL, NULL, N'00017', NULL, CAST(500.00 AS Decimal(12, 2)), 17, 17, N'', CAST(0.00 AS Decimal(12, 2)), 0, 0, 0, 0)
GO
INSERT [dbo].[LotterySales] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [Ticket], [Barcode], [TotalAmount], [SeqByOwner], [SeqByShop], [Remarks], [Prize], [WasPaid], [Anulated], [Winner], [AnulatedSol]) VALUES (19, NULL, 0, CAST(N'2020-09-25T15:49:03.8541610' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', CAST(N'2020-09-25T15:49:03.8541610' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', NULL, NULL, N'00001', NULL, CAST(12.00 AS Decimal(12, 2)), 18, 1, N'', CAST(0.00 AS Decimal(12, 2)), 0, 0, 0, 0)
GO
INSERT [dbo].[LotterySales] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [Ticket], [Barcode], [TotalAmount], [SeqByOwner], [SeqByShop], [Remarks], [Prize], [WasPaid], [Anulated], [Winner], [AnulatedSol]) VALUES (20, NULL, 0, CAST(N'2020-09-25T21:13:06.5653420' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', CAST(N'2020-09-25T21:13:06.5653420' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', NULL, NULL, N'00002', NULL, CAST(122.00 AS Decimal(12, 2)), 19, 2, N'', CAST(0.00 AS Decimal(12, 2)), 0, 0, 0, 0)
GO
INSERT [dbo].[LotterySales] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [Ticket], [Barcode], [TotalAmount], [SeqByOwner], [SeqByShop], [Remarks], [Prize], [WasPaid], [Anulated], [Winner], [AnulatedSol]) VALUES (21, NULL, 0, CAST(N'2020-09-25T21:19:34.6853300' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', CAST(N'2020-09-25T21:19:34.6853300' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', NULL, NULL, N'00003', NULL, CAST(12123123.00 AS Decimal(12, 2)), 20, 3, N'', CAST(0.00 AS Decimal(12, 2)), 0, 0, 0, 0)
GO
INSERT [dbo].[LotterySales] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [Ticket], [Barcode], [TotalAmount], [SeqByOwner], [SeqByShop], [Remarks], [Prize], [WasPaid], [Anulated], [Winner], [AnulatedSol]) VALUES (22, NULL, 0, CAST(N'2020-10-08T19:11:45.7423004' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', CAST(N'2020-10-08T19:39:21.6461405' AS DateTime2), N'74dffedd-b38f-40a4-9806-0bda7b3277f5', NULL, NULL, N'00004', NULL, CAST(3000.00 AS Decimal(12, 2)), 21, 4, N'', CAST(0.00 AS Decimal(12, 2)), 0, 0, 1, 0)
GO
INSERT [dbo].[LotterySales] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [Ticket], [Barcode], [TotalAmount], [SeqByOwner], [SeqByShop], [Remarks], [Prize], [WasPaid], [Anulated], [Winner], [AnulatedSol]) VALUES (23, NULL, 0, CAST(N'2020-10-19T03:14:11.5000730' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', CAST(N'2020-10-19T22:23:24.3280220' AS DateTime2), N'74dffedd-b38f-40a4-9806-0bda7b3277f5', NULL, NULL, N'0000022', NULL, CAST(100.00 AS Decimal(12, 2)), 22, 18, N'', CAST(30000.00 AS Decimal(12, 2)), 0, 0, 1, 0)
GO
INSERT [dbo].[LotterySales] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [Ticket], [Barcode], [TotalAmount], [SeqByOwner], [SeqByShop], [Remarks], [Prize], [WasPaid], [Anulated], [Winner], [AnulatedSol]) VALUES (24, NULL, 0, CAST(N'2020-10-19T03:14:56.6595440' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', CAST(N'2020-10-19T22:23:24.3281350' AS DateTime2), N'74dffedd-b38f-40a4-9806-0bda7b3277f5', NULL, NULL, N'0000023', NULL, CAST(323.00 AS Decimal(12, 2)), 23, 19, N'', CAST(30000.00 AS Decimal(12, 2)), 0, 0, 1, 0)
GO
INSERT [dbo].[LotterySales] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [Ticket], [Barcode], [TotalAmount], [SeqByOwner], [SeqByShop], [Remarks], [Prize], [WasPaid], [Anulated], [Winner], [AnulatedSol]) VALUES (25, NULL, 0, CAST(N'2020-10-19T03:15:17.8304760' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', CAST(N'2020-10-19T03:15:17.8304760' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', NULL, NULL, N'0000024', NULL, CAST(2323.00 AS Decimal(12, 2)), 24, 20, N'', CAST(0.00 AS Decimal(12, 2)), 0, 0, 0, 0)
GO
INSERT [dbo].[LotterySales] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [Ticket], [Barcode], [TotalAmount], [SeqByOwner], [SeqByShop], [Remarks], [Prize], [WasPaid], [Anulated], [Winner], [AnulatedSol]) VALUES (26, NULL, 0, CAST(N'2020-10-19T03:15:34.6391030' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', CAST(N'2020-10-19T03:15:34.6391030' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', NULL, NULL, N'0000025', NULL, CAST(234.00 AS Decimal(12, 2)), 25, 21, N'', CAST(0.00 AS Decimal(12, 2)), 0, 0, 0, 0)
GO
INSERT [dbo].[LotterySales] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [Ticket], [Barcode], [TotalAmount], [SeqByOwner], [SeqByShop], [Remarks], [Prize], [WasPaid], [Anulated], [Winner], [AnulatedSol]) VALUES (27, NULL, 0, CAST(N'2020-10-19T03:15:47.0034620' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', CAST(N'2020-10-19T22:23:24.3282360' AS DateTime2), N'74dffedd-b38f-40a4-9806-0bda7b3277f5', NULL, NULL, N'0000026', NULL, CAST(234.00 AS Decimal(12, 2)), 26, 22, N'', CAST(23400.00 AS Decimal(12, 2)), 0, 0, 1, 0)
GO
INSERT [dbo].[LotterySales] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [Ticket], [Barcode], [TotalAmount], [SeqByOwner], [SeqByShop], [Remarks], [Prize], [WasPaid], [Anulated], [Winner], [AnulatedSol]) VALUES (28, NULL, 0, CAST(N'2020-10-19T03:16:01.7465710' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', CAST(N'2020-10-19T03:16:01.7465710' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', NULL, NULL, N'0000027', NULL, CAST(2344.00 AS Decimal(12, 2)), 27, 23, N'', CAST(0.00 AS Decimal(12, 2)), 0, 0, 0, 0)
GO
INSERT [dbo].[LotterySales] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [Ticket], [Barcode], [TotalAmount], [SeqByOwner], [SeqByShop], [Remarks], [Prize], [WasPaid], [Anulated], [Winner], [AnulatedSol]) VALUES (29, NULL, 0, CAST(N'2020-10-19T03:16:14.5404380' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', CAST(N'2020-10-19T03:16:14.5404380' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', NULL, NULL, N'0000028', NULL, CAST(234.00 AS Decimal(12, 2)), 28, 24, N'', CAST(0.00 AS Decimal(12, 2)), 0, 0, 0, 0)
GO
INSERT [dbo].[LotterySales] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [Ticket], [Barcode], [TotalAmount], [SeqByOwner], [SeqByShop], [Remarks], [Prize], [WasPaid], [Anulated], [Winner], [AnulatedSol]) VALUES (30, NULL, 0, CAST(N'2020-10-19T03:16:27.9435640' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', CAST(N'2020-10-19T03:16:27.9435640' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', NULL, NULL, N'0000029', NULL, CAST(234.00 AS Decimal(12, 2)), 29, 25, N'', CAST(0.00 AS Decimal(12, 2)), 0, 0, 0, 0)
GO
INSERT [dbo].[LotterySales] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [Ticket], [Barcode], [TotalAmount], [SeqByOwner], [SeqByShop], [Remarks], [Prize], [WasPaid], [Anulated], [Winner], [AnulatedSol]) VALUES (31, NULL, 0, CAST(N'2020-10-19T03:16:44.0121630' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', CAST(N'2020-10-19T03:16:44.0121630' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', NULL, NULL, N'0000030', NULL, CAST(234.00 AS Decimal(12, 2)), 30, 26, N'', CAST(0.00 AS Decimal(12, 2)), 0, 0, 0, 0)
GO
INSERT [dbo].[LotterySales] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [Ticket], [Barcode], [TotalAmount], [SeqByOwner], [SeqByShop], [Remarks], [Prize], [WasPaid], [Anulated], [Winner], [AnulatedSol]) VALUES (32, NULL, 0, CAST(N'2020-10-19T03:17:13.3506070' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', CAST(N'2020-10-19T03:17:13.3506070' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', NULL, NULL, N'0000031', NULL, CAST(2342.00 AS Decimal(12, 2)), 31, 27, N'', CAST(0.00 AS Decimal(12, 2)), 0, 0, 0, 0)
GO
INSERT [dbo].[LotterySales] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [Ticket], [Barcode], [TotalAmount], [SeqByOwner], [SeqByShop], [Remarks], [Prize], [WasPaid], [Anulated], [Winner], [AnulatedSol]) VALUES (33, NULL, 0, CAST(N'2020-10-19T03:17:29.0339880' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', CAST(N'2020-10-19T03:17:29.0339880' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', NULL, NULL, N'0000032', NULL, CAST(234324.00 AS Decimal(12, 2)), 32, 28, N'', CAST(0.00 AS Decimal(12, 2)), 0, 0, 0, 0)
GO
INSERT [dbo].[LotterySales] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [Ticket], [Barcode], [TotalAmount], [SeqByOwner], [SeqByShop], [Remarks], [Prize], [WasPaid], [Anulated], [Winner], [AnulatedSol]) VALUES (34, NULL, 0, CAST(N'2020-10-19T03:17:53.9613440' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', CAST(N'2020-10-19T03:17:53.9613440' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', NULL, NULL, N'0000033', NULL, CAST(698.00 AS Decimal(12, 2)), 33, 29, N'', CAST(0.00 AS Decimal(12, 2)), 0, 0, 0, 0)
GO
INSERT [dbo].[LotterySales] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [Ticket], [Barcode], [TotalAmount], [SeqByOwner], [SeqByShop], [Remarks], [Prize], [WasPaid], [Anulated], [Winner], [AnulatedSol]) VALUES (35, NULL, 0, CAST(N'2020-10-19T03:18:22.0991610' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', CAST(N'2020-10-19T03:18:22.0991610' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', NULL, NULL, N'0000034', NULL, CAST(68.00 AS Decimal(12, 2)), 34, 30, N'', CAST(0.00 AS Decimal(12, 2)), 0, 0, 0, 0)
GO
INSERT [dbo].[LotterySales] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [Ticket], [Barcode], [TotalAmount], [SeqByOwner], [SeqByShop], [Remarks], [Prize], [WasPaid], [Anulated], [Winner], [AnulatedSol]) VALUES (36, NULL, 0, CAST(N'2020-10-19T03:18:43.8752030' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', CAST(N'2020-10-19T22:23:24.3283460' AS DateTime2), N'74dffedd-b38f-40a4-9806-0bda7b3277f5', NULL, NULL, N'0000035', NULL, CAST(100.00 AS Decimal(12, 2)), 35, 31, N'', CAST(30000.00 AS Decimal(12, 2)), 0, 0, 1, 0)
GO
INSERT [dbo].[LotterySales] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [Ticket], [Barcode], [TotalAmount], [SeqByOwner], [SeqByShop], [Remarks], [Prize], [WasPaid], [Anulated], [Winner], [AnulatedSol]) VALUES (37, NULL, 0, CAST(N'2020-10-19T03:19:21.9962510' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', CAST(N'2020-10-19T22:23:24.3284500' AS DateTime2), N'74dffedd-b38f-40a4-9806-0bda7b3277f5', NULL, NULL, N'0000036', NULL, CAST(801.00 AS Decimal(12, 2)), 36, 32, N'', CAST(10000.00 AS Decimal(12, 2)), 0, 0, 1, 0)
GO
INSERT [dbo].[LotterySales] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [Ticket], [Barcode], [TotalAmount], [SeqByOwner], [SeqByShop], [Remarks], [Prize], [WasPaid], [Anulated], [Winner], [AnulatedSol]) VALUES (38, NULL, 0, CAST(N'2020-10-19T03:19:42.9449670' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', CAST(N'2020-10-19T22:23:24.3285550' AS DateTime2), N'74dffedd-b38f-40a4-9806-0bda7b3277f5', NULL, NULL, N'0000037', NULL, CAST(200.00 AS Decimal(12, 2)), 37, 33, N'', CAST(40000.00 AS Decimal(12, 2)), 0, 0, 1, 0)
GO
INSERT [dbo].[LotterySales] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [Ticket], [Barcode], [TotalAmount], [SeqByOwner], [SeqByShop], [Remarks], [Prize], [WasPaid], [Anulated], [Winner], [AnulatedSol]) VALUES (39, NULL, 0, CAST(N'2020-10-19T03:20:16.6722470' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', CAST(N'2020-10-19T22:23:24.3286570' AS DateTime2), N'74dffedd-b38f-40a4-9806-0bda7b3277f5', NULL, NULL, N'0000038', NULL, CAST(234668.00 AS Decimal(12, 2)), 38, 34, N'', CAST(10000.00 AS Decimal(12, 2)), 0, 0, 1, 0)
GO
INSERT [dbo].[LotterySales] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [Ticket], [Barcode], [TotalAmount], [SeqByOwner], [SeqByShop], [Remarks], [Prize], [WasPaid], [Anulated], [Winner], [AnulatedSol]) VALUES (40, NULL, 0, CAST(N'2020-10-19T03:20:39.1043500' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', CAST(N'2020-10-20T02:10:35.8382770' AS DateTime2), N'74dffedd-b38f-40a4-9806-0bda7b3277f5', NULL, NULL, N'0000039', NULL, CAST(3553.00 AS Decimal(12, 2)), 39, 35, N'', CAST(30000.00 AS Decimal(12, 2)), 1, 0, 1, 0)
GO
INSERT [dbo].[LotterySales] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [Ticket], [Barcode], [TotalAmount], [SeqByOwner], [SeqByShop], [Remarks], [Prize], [WasPaid], [Anulated], [Winner], [AnulatedSol]) VALUES (41, NULL, 0, CAST(N'2020-10-19T03:21:01.1958950' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', CAST(N'2020-10-19T03:21:01.1958950' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', NULL, NULL, N'0000040', NULL, CAST(34534.00 AS Decimal(12, 2)), 40, 36, N'', CAST(0.00 AS Decimal(12, 2)), 0, 0, 0, 0)
GO
INSERT [dbo].[LotterySales] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [Ticket], [Barcode], [TotalAmount], [SeqByOwner], [SeqByShop], [Remarks], [Prize], [WasPaid], [Anulated], [Winner], [AnulatedSol]) VALUES (54, NULL, 0, CAST(N'2020-10-19T23:36:49.3633940' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', CAST(N'2020-10-19T23:36:49.3633940' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', NULL, NULL, N'0000041', NULL, CAST(345.00 AS Decimal(12, 2)), 41, 37, N'', CAST(0.00 AS Decimal(12, 2)), 0, 0, 0, 0)
GO
INSERT [dbo].[LotterySales] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [Ticket], [Barcode], [TotalAmount], [SeqByOwner], [SeqByShop], [Remarks], [Prize], [WasPaid], [Anulated], [Winner], [AnulatedSol]) VALUES (55, NULL, 0, CAST(N'2020-10-19T23:37:29.6885350' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', CAST(N'2020-10-19T23:37:29.6885350' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', NULL, NULL, N'0000042', NULL, CAST(667.00 AS Decimal(12, 2)), 42, 38, N'', CAST(0.00 AS Decimal(12, 2)), 0, 0, 0, 0)
GO
INSERT [dbo].[LotterySales] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [Ticket], [Barcode], [TotalAmount], [SeqByOwner], [SeqByShop], [Remarks], [Prize], [WasPaid], [Anulated], [Winner], [AnulatedSol]) VALUES (56, NULL, 0, CAST(N'2020-10-19T23:37:48.8632970' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', CAST(N'2020-10-19T23:37:48.8632970' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', NULL, NULL, N'0000043', NULL, CAST(56756.00 AS Decimal(12, 2)), 43, 39, N'', CAST(0.00 AS Decimal(12, 2)), 0, 0, 0, 0)
GO
INSERT [dbo].[LotterySales] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [Ticket], [Barcode], [TotalAmount], [SeqByOwner], [SeqByShop], [Remarks], [Prize], [WasPaid], [Anulated], [Winner], [AnulatedSol]) VALUES (57, NULL, 0, CAST(N'2020-10-19T23:38:27.1699630' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', CAST(N'2020-10-19T23:38:27.1699630' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', NULL, NULL, N'0000044', NULL, CAST(190.00 AS Decimal(12, 2)), 44, 40, N'', CAST(0.00 AS Decimal(12, 2)), 0, 0, 0, 0)
GO
INSERT [dbo].[LotterySales] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [Ticket], [Barcode], [TotalAmount], [SeqByOwner], [SeqByShop], [Remarks], [Prize], [WasPaid], [Anulated], [Winner], [AnulatedSol]) VALUES (58, NULL, 0, CAST(N'2020-10-19T23:38:41.7872620' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', CAST(N'2020-10-19T23:38:41.7872620' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', NULL, NULL, N'0000045', NULL, CAST(100.00 AS Decimal(12, 2)), 45, 41, N'', CAST(0.00 AS Decimal(12, 2)), 0, 0, 0, 0)
GO
INSERT [dbo].[LotterySales] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [Ticket], [Barcode], [TotalAmount], [SeqByOwner], [SeqByShop], [Remarks], [Prize], [WasPaid], [Anulated], [Winner], [AnulatedSol]) VALUES (59, NULL, 0, CAST(N'2020-10-19T23:38:53.4991500' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', CAST(N'2020-10-19T23:38:53.4991500' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', NULL, NULL, N'0000046', NULL, CAST(100.00 AS Decimal(12, 2)), 46, 42, N'', CAST(0.00 AS Decimal(12, 2)), 0, 0, 0, 0)
GO
INSERT [dbo].[LotterySales] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [Ticket], [Barcode], [TotalAmount], [SeqByOwner], [SeqByShop], [Remarks], [Prize], [WasPaid], [Anulated], [Winner], [AnulatedSol]) VALUES (60, NULL, 0, CAST(N'2020-10-19T23:39:09.0947800' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', CAST(N'2020-10-19T23:39:09.0947800' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', NULL, NULL, N'0000047', NULL, CAST(100.00 AS Decimal(12, 2)), 47, 43, N'', CAST(0.00 AS Decimal(12, 2)), 0, 0, 0, 0)
GO
INSERT [dbo].[LotterySales] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [Ticket], [Barcode], [TotalAmount], [SeqByOwner], [SeqByShop], [Remarks], [Prize], [WasPaid], [Anulated], [Winner], [AnulatedSol]) VALUES (61, NULL, 0, CAST(N'2020-10-19T23:39:22.8888000' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', CAST(N'2020-10-19T23:39:22.8888000' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', NULL, NULL, N'0000048', NULL, CAST(100.00 AS Decimal(12, 2)), 48, 44, N'', CAST(0.00 AS Decimal(12, 2)), 0, 0, 0, 0)
GO
INSERT [dbo].[LotterySales] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [Ticket], [Barcode], [TotalAmount], [SeqByOwner], [SeqByShop], [Remarks], [Prize], [WasPaid], [Anulated], [Winner], [AnulatedSol]) VALUES (62, NULL, 0, CAST(N'2020-10-19T23:39:46.8164990' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', CAST(N'2020-10-19T23:39:46.8164990' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', NULL, NULL, N'0000049', NULL, CAST(4564.00 AS Decimal(12, 2)), 49, 45, N'', CAST(0.00 AS Decimal(12, 2)), 0, 0, 0, 0)
GO
INSERT [dbo].[LotterySales] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [Ticket], [Barcode], [TotalAmount], [SeqByOwner], [SeqByShop], [Remarks], [Prize], [WasPaid], [Anulated], [Winner], [AnulatedSol]) VALUES (63, NULL, 0, CAST(N'2020-10-19T23:40:03.4044400' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', CAST(N'2020-10-19T23:40:03.4044400' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', NULL, NULL, N'0000050', NULL, CAST(456456456.00 AS Decimal(12, 2)), 50, 46, N'', CAST(0.00 AS Decimal(12, 2)), 0, 0, 0, 0)
GO
INSERT [dbo].[LotterySales] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [Ticket], [Barcode], [TotalAmount], [SeqByOwner], [SeqByShop], [Remarks], [Prize], [WasPaid], [Anulated], [Winner], [AnulatedSol]) VALUES (64, NULL, 0, CAST(N'2020-10-19T23:40:31.0309820' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', CAST(N'2020-10-19T23:40:31.0309820' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', NULL, NULL, N'0000051', NULL, CAST(34534.00 AS Decimal(12, 2)), 51, 47, N'', CAST(0.00 AS Decimal(12, 2)), 0, 0, 0, 0)
GO
INSERT [dbo].[LotterySales] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [Ticket], [Barcode], [TotalAmount], [SeqByOwner], [SeqByShop], [Remarks], [Prize], [WasPaid], [Anulated], [Winner], [AnulatedSol]) VALUES (65, NULL, 0, CAST(N'2020-10-19T23:40:53.0691940' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', CAST(N'2020-10-19T23:40:53.0691940' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', NULL, NULL, N'0000052', NULL, CAST(3433443.00 AS Decimal(12, 2)), 52, 48, N'', CAST(0.00 AS Decimal(12, 2)), 0, 0, 0, 0)
GO
INSERT [dbo].[LotterySales] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [Ticket], [Barcode], [TotalAmount], [SeqByOwner], [SeqByShop], [Remarks], [Prize], [WasPaid], [Anulated], [Winner], [AnulatedSol]) VALUES (66, NULL, 0, CAST(N'2020-10-19T23:41:31.0792480' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', CAST(N'2020-10-19T23:41:31.0792480' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', NULL, NULL, N'0000053', NULL, CAST(300000000.00 AS Decimal(12, 2)), 53, 49, N'', CAST(0.00 AS Decimal(12, 2)), 0, 0, 0, 0)
GO
INSERT [dbo].[LotterySales] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [Ticket], [Barcode], [TotalAmount], [SeqByOwner], [SeqByShop], [Remarks], [Prize], [WasPaid], [Anulated], [Winner], [AnulatedSol]) VALUES (67, NULL, 0, CAST(N'2020-10-26T21:57:02.1794000' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', CAST(N'2020-10-26T21:57:02.1794000' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', NULL, NULL, N'0000054', NULL, CAST(3434.00 AS Decimal(12, 2)), 54, 50, N'', CAST(0.00 AS Decimal(12, 2)), 0, 0, 0, 0)
GO
INSERT [dbo].[LotterySales] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [Ticket], [Barcode], [TotalAmount], [SeqByOwner], [SeqByShop], [Remarks], [Prize], [WasPaid], [Anulated], [Winner], [AnulatedSol]) VALUES (68, NULL, 0, CAST(N'2020-10-26T21:57:29.7683500' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', CAST(N'2020-10-26T21:57:29.7683500' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', NULL, NULL, N'0000055', NULL, CAST(234.00 AS Decimal(12, 2)), 55, 51, N'', CAST(0.00 AS Decimal(12, 2)), 0, 0, 0, 0)
GO
INSERT [dbo].[LotterySales] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [Ticket], [Barcode], [TotalAmount], [SeqByOwner], [SeqByShop], [Remarks], [Prize], [WasPaid], [Anulated], [Winner], [AnulatedSol]) VALUES (69, NULL, 0, CAST(N'2020-10-26T21:57:51.4426470' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', CAST(N'2020-10-26T21:57:51.4426470' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', NULL, NULL, N'0000056', NULL, CAST(1100.00 AS Decimal(12, 2)), 56, 52, N'', CAST(0.00 AS Decimal(12, 2)), 0, 0, 0, 0)
GO
INSERT [dbo].[LotterySales] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [Ticket], [Barcode], [TotalAmount], [SeqByOwner], [SeqByShop], [Remarks], [Prize], [WasPaid], [Anulated], [Winner], [AnulatedSol]) VALUES (70, NULL, 0, CAST(N'2020-10-26T21:58:07.4237350' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', CAST(N'2020-10-26T21:58:07.4237350' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', NULL, NULL, N'0000057', NULL, CAST(1000.00 AS Decimal(12, 2)), 57, 53, N'', CAST(0.00 AS Decimal(12, 2)), 0, 0, 0, 0)
GO
INSERT [dbo].[LotterySales] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [Ticket], [Barcode], [TotalAmount], [SeqByOwner], [SeqByShop], [Remarks], [Prize], [WasPaid], [Anulated], [Winner], [AnulatedSol]) VALUES (71, NULL, 0, CAST(N'2020-10-26T21:58:26.6846720' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', CAST(N'2020-10-26T21:58:26.6846720' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', NULL, NULL, N'0000058', NULL, CAST(1000.00 AS Decimal(12, 2)), 58, 54, N'', CAST(0.00 AS Decimal(12, 2)), 0, 0, 0, 0)
GO
INSERT [dbo].[LotterySales] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [Ticket], [Barcode], [TotalAmount], [SeqByOwner], [SeqByShop], [Remarks], [Prize], [WasPaid], [Anulated], [Winner], [AnulatedSol]) VALUES (72, NULL, 0, CAST(N'2020-10-26T21:58:36.5489700' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', CAST(N'2020-10-26T21:58:36.5489700' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', NULL, NULL, N'0000059', NULL, CAST(1000.00 AS Decimal(12, 2)), 59, 55, N'', CAST(0.00 AS Decimal(12, 2)), 0, 0, 0, 0)
GO
INSERT [dbo].[LotterySales] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [Ticket], [Barcode], [TotalAmount], [SeqByOwner], [SeqByShop], [Remarks], [Prize], [WasPaid], [Anulated], [Winner], [AnulatedSol]) VALUES (73, NULL, 0, CAST(N'2020-10-26T21:58:50.6047190' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', CAST(N'2020-10-26T21:58:50.6047190' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', NULL, NULL, N'0000060', NULL, CAST(131313.00 AS Decimal(12, 2)), 60, 56, N'', CAST(0.00 AS Decimal(12, 2)), 0, 0, 0, 0)
GO
INSERT [dbo].[LotterySales] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [Ticket], [Barcode], [TotalAmount], [SeqByOwner], [SeqByShop], [Remarks], [Prize], [WasPaid], [Anulated], [Winner], [AnulatedSol]) VALUES (74, NULL, 0, CAST(N'2020-10-26T22:23:50.5797370' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', CAST(N'2020-10-26T22:23:50.5797370' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', NULL, NULL, N'0000061', NULL, CAST(2333.00 AS Decimal(12, 2)), 61, 57, N'', CAST(0.00 AS Decimal(12, 2)), 0, 0, 0, 0)
GO
INSERT [dbo].[LotterySales] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [Ticket], [Barcode], [TotalAmount], [SeqByOwner], [SeqByShop], [Remarks], [Prize], [WasPaid], [Anulated], [Winner], [AnulatedSol]) VALUES (75, NULL, 0, CAST(N'2020-10-26T22:25:09.7382870' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', CAST(N'2020-10-26T22:25:09.7382870' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', NULL, NULL, N'0000062', NULL, CAST(3434.00 AS Decimal(12, 2)), 62, 58, N'', CAST(0.00 AS Decimal(12, 2)), 0, 0, 0, 0)
GO
INSERT [dbo].[LotterySales] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [Ticket], [Barcode], [TotalAmount], [SeqByOwner], [SeqByShop], [Remarks], [Prize], [WasPaid], [Anulated], [Winner], [AnulatedSol]) VALUES (76, NULL, 0, CAST(N'2020-10-27T04:32:47.8588470' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', CAST(N'2020-10-27T04:32:47.8588470' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', NULL, NULL, N'0000063', NULL, CAST(56.00 AS Decimal(12, 2)), 63, 59, N'', CAST(0.00 AS Decimal(12, 2)), 0, 0, 0, 0)
GO
INSERT [dbo].[LotterySales] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [Ticket], [Barcode], [TotalAmount], [SeqByOwner], [SeqByShop], [Remarks], [Prize], [WasPaid], [Anulated], [Winner], [AnulatedSol]) VALUES (77, NULL, 0, CAST(N'2020-10-27T04:33:08.2012110' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', CAST(N'2020-10-27T04:33:08.2012110' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', NULL, NULL, N'0000064', NULL, CAST(5.00 AS Decimal(12, 2)), 64, 60, N'', CAST(0.00 AS Decimal(12, 2)), 0, 0, 0, 0)
GO
INSERT [dbo].[LotterySales] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [Ticket], [Barcode], [TotalAmount], [SeqByOwner], [SeqByShop], [Remarks], [Prize], [WasPaid], [Anulated], [Winner], [AnulatedSol]) VALUES (78, NULL, 0, CAST(N'2020-11-03T17:23:33.8818260' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', CAST(N'2020-11-03T17:23:33.8818260' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', NULL, NULL, N'0000065', NULL, CAST(1000.00 AS Decimal(12, 2)), 65, 61, N'', CAST(0.00 AS Decimal(12, 2)), 0, 0, 0, 0)
GO
INSERT [dbo].[LotterySales] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [Ticket], [Barcode], [TotalAmount], [SeqByOwner], [SeqByShop], [Remarks], [Prize], [WasPaid], [Anulated], [Winner], [AnulatedSol]) VALUES (79, NULL, 0, CAST(N'2020-11-03T17:24:00.9598750' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', CAST(N'2020-11-03T17:24:00.9598750' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', NULL, NULL, N'0000066', NULL, CAST(34534.00 AS Decimal(12, 2)), 66, 62, N'', CAST(0.00 AS Decimal(12, 2)), 0, 0, 0, 0)
GO
INSERT [dbo].[LotterySales] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [Ticket], [Barcode], [TotalAmount], [SeqByOwner], [SeqByShop], [Remarks], [Prize], [WasPaid], [Anulated], [Winner], [AnulatedSol]) VALUES (80, NULL, 0, CAST(N'2020-11-03T17:24:51.6475680' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', CAST(N'2020-11-03T17:24:51.6475680' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', NULL, NULL, N'0000067', NULL, CAST(2835.00 AS Decimal(12, 2)), 67, 63, N'', CAST(0.00 AS Decimal(12, 2)), 0, 0, 0, 0)
GO
INSERT [dbo].[LotterySales] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [Ticket], [Barcode], [TotalAmount], [SeqByOwner], [SeqByShop], [Remarks], [Prize], [WasPaid], [Anulated], [Winner], [AnulatedSol]) VALUES (81, NULL, 0, CAST(N'2020-11-03T17:25:10.9632910' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', CAST(N'2020-11-04T01:32:38.1212000' AS DateTime2), N'74dffedd-b38f-40a4-9806-0bda7b3277f5', NULL, NULL, N'0000068', NULL, CAST(234234.00 AS Decimal(12, 2)), 68, 64, N'', CAST(0.00 AS Decimal(12, 2)), 0, 0, 0, 1)
GO
INSERT [dbo].[LotterySales] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [Ticket], [Barcode], [TotalAmount], [SeqByOwner], [SeqByShop], [Remarks], [Prize], [WasPaid], [Anulated], [Winner], [AnulatedSol]) VALUES (82, NULL, 0, CAST(N'2020-11-03T17:25:20.1386060' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', CAST(N'2020-11-04T01:29:40.7232240' AS DateTime2), N'74dffedd-b38f-40a4-9806-0bda7b3277f5', NULL, NULL, N'0000069', NULL, CAST(234243.00 AS Decimal(12, 2)), 69, 65, N'', CAST(0.00 AS Decimal(12, 2)), 0, 0, 0, 1)
GO
INSERT [dbo].[LotterySales] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [Ticket], [Barcode], [TotalAmount], [SeqByOwner], [SeqByShop], [Remarks], [Prize], [WasPaid], [Anulated], [Winner], [AnulatedSol]) VALUES (83, NULL, 0, CAST(N'2020-11-03T17:25:31.0378780' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', CAST(N'2020-11-03T17:25:31.0378780' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', NULL, NULL, N'0000070', NULL, CAST(2344.00 AS Decimal(12, 2)), 70, 66, N'', CAST(0.00 AS Decimal(12, 2)), 0, 0, 0, 0)
GO
INSERT [dbo].[LotterySales] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [Ticket], [Barcode], [TotalAmount], [SeqByOwner], [SeqByShop], [Remarks], [Prize], [WasPaid], [Anulated], [Winner], [AnulatedSol]) VALUES (84, NULL, 0, CAST(N'2020-11-04T16:54:30.8768710' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', CAST(N'2020-11-04T18:59:12.4453230' AS DateTime2), N'74dffedd-b38f-40a4-9806-0bda7b3277f5', NULL, NULL, N'0000071', NULL, CAST(2000.00 AS Decimal(12, 2)), 71, 67, N'', CAST(0.00 AS Decimal(12, 2)), 0, 0, 0, 1)
GO
INSERT [dbo].[LotterySales] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [Ticket], [Barcode], [TotalAmount], [SeqByOwner], [SeqByShop], [Remarks], [Prize], [WasPaid], [Anulated], [Winner], [AnulatedSol]) VALUES (85, NULL, 0, CAST(N'2020-11-04T16:54:46.8638420' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', CAST(N'2020-11-04T16:54:46.8638420' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', NULL, NULL, N'0000072', NULL, CAST(123.00 AS Decimal(12, 2)), 72, 68, N'', CAST(0.00 AS Decimal(12, 2)), 0, 0, 0, 0)
GO
INSERT [dbo].[LotterySales] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [Ticket], [Barcode], [TotalAmount], [SeqByOwner], [SeqByShop], [Remarks], [Prize], [WasPaid], [Anulated], [Winner], [AnulatedSol]) VALUES (86, NULL, 0, CAST(N'2020-11-04T16:54:55.1436070' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', CAST(N'2020-11-04T16:54:55.1436070' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', NULL, NULL, N'0000073', NULL, CAST(123.00 AS Decimal(12, 2)), 73, 69, N'', CAST(0.00 AS Decimal(12, 2)), 0, 0, 0, 0)
GO
INSERT [dbo].[LotterySales] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [Ticket], [Barcode], [TotalAmount], [SeqByOwner], [SeqByShop], [Remarks], [Prize], [WasPaid], [Anulated], [Winner], [AnulatedSol]) VALUES (87, NULL, 0, CAST(N'2020-11-04T16:55:05.3249160' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', CAST(N'2020-11-04T22:32:32.4208870' AS DateTime2), N'74dffedd-b38f-40a4-9806-0bda7b3277f5', NULL, NULL, N'0000074', NULL, CAST(1222.00 AS Decimal(12, 2)), 74, 70, N'', CAST(0.00 AS Decimal(12, 2)), 0, 0, 0, 0)
GO
INSERT [dbo].[LotterySales] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [Ticket], [Barcode], [TotalAmount], [SeqByOwner], [SeqByShop], [Remarks], [Prize], [WasPaid], [Anulated], [Winner], [AnulatedSol]) VALUES (88, NULL, 0, CAST(N'2020-11-04T16:55:15.0178340' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', CAST(N'2020-11-04T22:37:55.7737800' AS DateTime2), N'74dffedd-b38f-40a4-9806-0bda7b3277f5', NULL, NULL, N'0000075', NULL, CAST(232.00 AS Decimal(12, 2)), 75, 71, N'', CAST(0.00 AS Decimal(12, 2)), 0, 1, 0, 1)
GO
INSERT [dbo].[LotterySales] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [Ticket], [Barcode], [TotalAmount], [SeqByOwner], [SeqByShop], [Remarks], [Prize], [WasPaid], [Anulated], [Winner], [AnulatedSol]) VALUES (89, NULL, 0, CAST(N'2020-11-04T16:55:24.3974290' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', CAST(N'2020-11-04T16:55:24.3974290' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', NULL, NULL, N'0000076', NULL, CAST(234.00 AS Decimal(12, 2)), 76, 72, N'', CAST(0.00 AS Decimal(12, 2)), 0, 0, 0, 0)
GO
INSERT [dbo].[LotterySales] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [Ticket], [Barcode], [TotalAmount], [SeqByOwner], [SeqByShop], [Remarks], [Prize], [WasPaid], [Anulated], [Winner], [AnulatedSol]) VALUES (90, NULL, 0, CAST(N'2020-11-04T16:55:31.4950480' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', CAST(N'2020-11-04T17:03:34.0389350' AS DateTime2), N'74dffedd-b38f-40a4-9806-0bda7b3277f5', NULL, NULL, N'0000077', NULL, CAST(234.00 AS Decimal(12, 2)), 77, 73, N'', CAST(0.00 AS Decimal(12, 2)), 0, 0, 0, 1)
GO
INSERT [dbo].[LotterySales] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [Ticket], [Barcode], [TotalAmount], [SeqByOwner], [SeqByShop], [Remarks], [Prize], [WasPaid], [Anulated], [Winner], [AnulatedSol]) VALUES (91, NULL, 0, CAST(N'2020-11-04T16:55:41.2609560' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', CAST(N'2020-11-04T18:06:24.4071560' AS DateTime2), N'74dffedd-b38f-40a4-9806-0bda7b3277f5', NULL, NULL, N'0000078', NULL, CAST(23.00 AS Decimal(12, 2)), 78, 74, N'', CAST(0.00 AS Decimal(12, 2)), 0, 0, 0, 1)
GO
INSERT [dbo].[LotterySales] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [Ticket], [Barcode], [TotalAmount], [SeqByOwner], [SeqByShop], [Remarks], [Prize], [WasPaid], [Anulated], [Winner], [AnulatedSol]) VALUES (92, NULL, 0, CAST(N'2020-11-04T16:55:49.2574710' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', CAST(N'2020-11-04T17:03:19.6720770' AS DateTime2), N'74dffedd-b38f-40a4-9806-0bda7b3277f5', NULL, NULL, N'0000079', NULL, CAST(2344.00 AS Decimal(12, 2)), 79, 75, N'', CAST(0.00 AS Decimal(12, 2)), 0, 0, 0, 1)
GO
INSERT [dbo].[LotterySales] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [Ticket], [Barcode], [TotalAmount], [SeqByOwner], [SeqByShop], [Remarks], [Prize], [WasPaid], [Anulated], [Winner], [AnulatedSol]) VALUES (93, NULL, 0, CAST(N'2020-11-04T16:56:04.5079920' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', CAST(N'2020-11-04T17:03:08.5029420' AS DateTime2), N'74dffedd-b38f-40a4-9806-0bda7b3277f5', NULL, NULL, N'0000080', NULL, CAST(2423.00 AS Decimal(12, 2)), 80, 76, N'', CAST(0.00 AS Decimal(12, 2)), 0, 0, 0, 1)
GO
INSERT [dbo].[LotterySales] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [Ticket], [Barcode], [TotalAmount], [SeqByOwner], [SeqByShop], [Remarks], [Prize], [WasPaid], [Anulated], [Winner], [AnulatedSol]) VALUES (94, NULL, 0, CAST(N'2020-11-04T16:56:13.9038690' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', CAST(N'2020-11-04T17:02:57.4257910' AS DateTime2), N'74dffedd-b38f-40a4-9806-0bda7b3277f5', NULL, NULL, N'0000081', NULL, CAST(234.00 AS Decimal(12, 2)), 81, 77, N'', CAST(0.00 AS Decimal(12, 2)), 0, 0, 0, 1)
GO
INSERT [dbo].[LotterySales] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [Ticket], [Barcode], [TotalAmount], [SeqByOwner], [SeqByShop], [Remarks], [Prize], [WasPaid], [Anulated], [Winner], [AnulatedSol]) VALUES (95, NULL, 0, CAST(N'2020-11-04T16:56:54.1359300' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', CAST(N'2020-11-04T17:02:48.3339660' AS DateTime2), N'74dffedd-b38f-40a4-9806-0bda7b3277f5', NULL, NULL, N'0000082', NULL, CAST(123.00 AS Decimal(12, 2)), 82, 78, N'', CAST(0.00 AS Decimal(12, 2)), 0, 0, 0, 1)
GO
INSERT [dbo].[LotterySales] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [Ticket], [Barcode], [TotalAmount], [SeqByOwner], [SeqByShop], [Remarks], [Prize], [WasPaid], [Anulated], [Winner], [AnulatedSol]) VALUES (96, NULL, 0, CAST(N'2020-11-04T21:50:26.8702018' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', CAST(N'2020-11-04T21:50:26.8702018' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', NULL, NULL, N'0000083', NULL, CAST(12.00 AS Decimal(12, 2)), 83, 79, N'', CAST(0.00 AS Decimal(12, 2)), 0, 0, 0, 0)
GO
INSERT [dbo].[LotterySales] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [Ticket], [Barcode], [TotalAmount], [SeqByOwner], [SeqByShop], [Remarks], [Prize], [WasPaid], [Anulated], [Winner], [AnulatedSol]) VALUES (97, NULL, 0, CAST(N'2020-11-04T21:50:39.8672297' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', CAST(N'2020-11-04T21:50:39.8672297' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', NULL, NULL, N'0000084', NULL, CAST(344.00 AS Decimal(12, 2)), 84, 80, N'', CAST(0.00 AS Decimal(12, 2)), 0, 0, 0, 0)
GO
INSERT [dbo].[LotterySales] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [Ticket], [Barcode], [TotalAmount], [SeqByOwner], [SeqByShop], [Remarks], [Prize], [WasPaid], [Anulated], [Winner], [AnulatedSol]) VALUES (98, NULL, 0, CAST(N'2020-11-05T00:50:14.6833059' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', CAST(N'2020-11-05T00:50:14.6833059' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', NULL, NULL, N'0000085', NULL, CAST(3000.00 AS Decimal(12, 2)), 85, 81, N'', CAST(0.00 AS Decimal(12, 2)), 0, 0, 0, 0)
GO
INSERT [dbo].[LotterySales] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [Ticket], [Barcode], [TotalAmount], [SeqByOwner], [SeqByShop], [Remarks], [Prize], [WasPaid], [Anulated], [Winner], [AnulatedSol]) VALUES (99, NULL, 0, CAST(N'2020-11-06T15:54:13.4647461' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', CAST(N'2020-11-06T15:54:13.4647461' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', NULL, NULL, N'0000086', NULL, CAST(7000.00 AS Decimal(12, 2)), 86, 82, N'', CAST(0.00 AS Decimal(12, 2)), 0, 0, 0, 0)
GO
INSERT [dbo].[LotterySales] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [Ticket], [Barcode], [TotalAmount], [SeqByOwner], [SeqByShop], [Remarks], [Prize], [WasPaid], [Anulated], [Winner], [AnulatedSol]) VALUES (100, NULL, 0, CAST(N'2020-11-06T16:01:20.8079319' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', CAST(N'2020-11-06T16:11:32.2371312' AS DateTime2), N'74dffedd-b38f-40a4-9806-0bda7b3277f5', NULL, NULL, N'0000087', NULL, CAST(4000.00 AS Decimal(12, 2)), 87, 83, N'', CAST(20000.00 AS Decimal(12, 2)), 0, 0, 1, 0)
GO
INSERT [dbo].[LotterySales] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [Ticket], [Barcode], [TotalAmount], [SeqByOwner], [SeqByShop], [Remarks], [Prize], [WasPaid], [Anulated], [Winner], [AnulatedSol]) VALUES (101, NULL, 0, CAST(N'2020-11-11T12:14:13.9632446' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', CAST(N'2020-11-11T12:17:01.6060599' AS DateTime2), N'74dffedd-b38f-40a4-9806-0bda7b3277f5', NULL, NULL, N'0000088', NULL, CAST(9000.00 AS Decimal(12, 2)), 88, 84, N'', CAST(50000.00 AS Decimal(12, 2)), 0, 0, 1, 0)
GO
INSERT [dbo].[LotterySales] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [Ticket], [Barcode], [TotalAmount], [SeqByOwner], [SeqByShop], [Remarks], [Prize], [WasPaid], [Anulated], [Winner], [AnulatedSol]) VALUES (102, NULL, 0, CAST(N'2020-11-17T19:33:46.7613200' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', CAST(N'2020-11-17T21:38:59.0533020' AS DateTime2), N'74dffedd-b38f-40a4-9806-0bda7b3277f5', NULL, NULL, N'0000089', NULL, CAST(400.00 AS Decimal(12, 2)), 89, 85, N'', CAST(629000.00 AS Decimal(12, 2)), 0, 0, 1, 0)
GO
INSERT [dbo].[LotterySales] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [Ticket], [Barcode], [TotalAmount], [SeqByOwner], [SeqByShop], [Remarks], [Prize], [WasPaid], [Anulated], [Winner], [AnulatedSol]) VALUES (103, NULL, 0, CAST(N'2020-11-17T19:34:02.2167610' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', CAST(N'2020-11-17T21:38:59.0533950' AS DateTime2), N'74dffedd-b38f-40a4-9806-0bda7b3277f5', NULL, NULL, N'0000090', NULL, CAST(100.00 AS Decimal(12, 2)), 90, 86, N'', CAST(21000.00 AS Decimal(12, 2)), 0, 0, 1, 0)
GO
INSERT [dbo].[LotterySales] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [Ticket], [Barcode], [TotalAmount], [SeqByOwner], [SeqByShop], [Remarks], [Prize], [WasPaid], [Anulated], [Winner], [AnulatedSol]) VALUES (104, NULL, 0, CAST(N'2020-11-17T19:34:50.5475960' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', CAST(N'2020-11-17T21:38:59.0534730' AS DateTime2), N'74dffedd-b38f-40a4-9806-0bda7b3277f5', NULL, NULL, N'0000091', NULL, CAST(2436.00 AS Decimal(12, 2)), 91, 87, N'', CAST(709800.00 AS Decimal(12, 2)), 0, 0, 1, 0)
GO
INSERT [dbo].[LotterySales] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [Ticket], [Barcode], [TotalAmount], [SeqByOwner], [SeqByShop], [Remarks], [Prize], [WasPaid], [Anulated], [Winner], [AnulatedSol]) VALUES (105, NULL, 0, CAST(N'2020-11-17T19:35:09.7559150' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', CAST(N'2020-11-17T21:09:56.7423180' AS DateTime2), N'74dffedd-b38f-40a4-9806-0bda7b3277f5', NULL, NULL, N'0000092', NULL, CAST(200.00 AS Decimal(12, 2)), 92, 88, N'', CAST(150000.00 AS Decimal(12, 2)), 0, 0, 1, 0)
GO
INSERT [dbo].[LotterySales] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [Ticket], [Barcode], [TotalAmount], [SeqByOwner], [SeqByShop], [Remarks], [Prize], [WasPaid], [Anulated], [Winner], [AnulatedSol]) VALUES (106, NULL, 0, CAST(N'2020-11-17T19:35:37.5369270' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', CAST(N'2020-11-17T21:09:56.7423820' AS DateTime2), N'74dffedd-b38f-40a4-9806-0bda7b3277f5', NULL, NULL, N'0000093', NULL, CAST(23524.00 AS Decimal(12, 2)), 93, 89, N'', CAST(600000.00 AS Decimal(12, 2)), 0, 0, 1, 0)
GO
INSERT [dbo].[LotterySales] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [Ticket], [Barcode], [TotalAmount], [SeqByOwner], [SeqByShop], [Remarks], [Prize], [WasPaid], [Anulated], [Winner], [AnulatedSol]) VALUES (107, NULL, 0, CAST(N'2020-11-17T19:36:00.3041800' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', CAST(N'2020-11-17T21:38:59.0535490' AS DateTime2), N'74dffedd-b38f-40a4-9806-0bda7b3277f5', NULL, NULL, N'0000094', NULL, CAST(3645.00 AS Decimal(12, 2)), 94, 90, N'', CAST(700000.00 AS Decimal(12, 2)), 0, 0, 1, 0)
GO
INSERT [dbo].[LotterySales] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [Ticket], [Barcode], [TotalAmount], [SeqByOwner], [SeqByShop], [Remarks], [Prize], [WasPaid], [Anulated], [Winner], [AnulatedSol]) VALUES (108, NULL, 0, CAST(N'2020-11-17T19:36:36.5603450' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', CAST(N'2020-11-17T21:38:59.0536230' AS DateTime2), N'74dffedd-b38f-40a4-9806-0bda7b3277f5', NULL, NULL, N'0000095', NULL, CAST(200.00 AS Decimal(12, 2)), 95, 91, N'', CAST(42000.00 AS Decimal(12, 2)), 0, 0, 1, 0)
GO
INSERT [dbo].[LotterySales] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [Ticket], [Barcode], [TotalAmount], [SeqByOwner], [SeqByShop], [Remarks], [Prize], [WasPaid], [Anulated], [Winner], [AnulatedSol]) VALUES (109, NULL, 0, CAST(N'2020-12-09T17:35:01.6893380' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', CAST(N'2020-12-09T17:35:01.6893380' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', NULL, NULL, N'0000096', NULL, CAST(1000.00 AS Decimal(12, 2)), 96, 0, N'', CAST(0.00 AS Decimal(12, 2)), 0, 0, 0, 0)
GO
SET IDENTITY_INSERT [dbo].[LotterySales] OFF
GO
SET IDENTITY_INSERT [dbo].[LotterySchedules] ON 
GO
INSERT [dbo].[LotterySchedules] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [LotteryId], [DayOfTheWeek], [CloseHour], [InactiveDate]) VALUES (1, NULL, 0, CAST(N'2020-09-01T12:18:53.3507857' AS DateTime2), N'74dffedd-b38f-40a4-9806-0bda7b3277f5', CAST(N'2020-10-17T20:23:28.5650040' AS DateTime2), N'74dffedd-b38f-40a4-9806-0bda7b3277f5', NULL, NULL, 1, 1, CAST(N'2020-10-17T19:55:00.0000000' AS DateTime2), CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2))
GO
INSERT [dbo].[LotterySchedules] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [LotteryId], [DayOfTheWeek], [CloseHour], [InactiveDate]) VALUES (2, NULL, 0, CAST(N'2020-09-01T12:18:53.3572287' AS DateTime2), N'74dffedd-b38f-40a4-9806-0bda7b3277f5', CAST(N'2020-10-17T20:23:28.5651040' AS DateTime2), N'74dffedd-b38f-40a4-9806-0bda7b3277f5', NULL, NULL, 1, 2, CAST(N'2020-10-17T19:55:00.0000000' AS DateTime2), CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2))
GO
INSERT [dbo].[LotterySchedules] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [LotteryId], [DayOfTheWeek], [CloseHour], [InactiveDate]) VALUES (3, NULL, 0, CAST(N'2020-09-01T12:18:53.3578813' AS DateTime2), N'74dffedd-b38f-40a4-9806-0bda7b3277f5', CAST(N'2020-10-17T20:23:28.5651870' AS DateTime2), N'74dffedd-b38f-40a4-9806-0bda7b3277f5', NULL, NULL, 1, 3, CAST(N'2020-10-17T19:55:00.0000000' AS DateTime2), CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2))
GO
INSERT [dbo].[LotterySchedules] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [LotteryId], [DayOfTheWeek], [CloseHour], [InactiveDate]) VALUES (4, NULL, 0, CAST(N'2020-09-01T12:18:53.3584861' AS DateTime2), N'74dffedd-b38f-40a4-9806-0bda7b3277f5', CAST(N'2020-10-17T20:23:28.5652820' AS DateTime2), N'74dffedd-b38f-40a4-9806-0bda7b3277f5', NULL, NULL, 1, 4, CAST(N'2020-10-17T19:55:00.0000000' AS DateTime2), CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2))
GO
INSERT [dbo].[LotterySchedules] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [LotteryId], [DayOfTheWeek], [CloseHour], [InactiveDate]) VALUES (5, NULL, 0, CAST(N'2020-09-01T12:18:53.3591525' AS DateTime2), N'74dffedd-b38f-40a4-9806-0bda7b3277f5', CAST(N'2020-10-17T20:23:28.5653640' AS DateTime2), N'74dffedd-b38f-40a4-9806-0bda7b3277f5', NULL, NULL, 1, 5, CAST(N'2020-10-17T19:55:00.0000000' AS DateTime2), CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2))
GO
INSERT [dbo].[LotterySchedules] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [LotteryId], [DayOfTheWeek], [CloseHour], [InactiveDate]) VALUES (6, NULL, 0, CAST(N'2020-09-01T12:18:53.3597723' AS DateTime2), N'74dffedd-b38f-40a4-9806-0bda7b3277f5', CAST(N'2020-10-17T20:23:28.5654440' AS DateTime2), N'74dffedd-b38f-40a4-9806-0bda7b3277f5', NULL, NULL, 1, 6, CAST(N'2020-10-17T19:55:00.0000000' AS DateTime2), CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2))
GO
INSERT [dbo].[LotterySchedules] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [LotteryId], [DayOfTheWeek], [CloseHour], [InactiveDate]) VALUES (7, NULL, 0, CAST(N'2020-09-01T12:18:53.3604092' AS DateTime2), N'74dffedd-b38f-40a4-9806-0bda7b3277f5', CAST(N'2020-10-17T20:23:28.5655240' AS DateTime2), N'74dffedd-b38f-40a4-9806-0bda7b3277f5', NULL, NULL, 1, 7, CAST(N'2020-10-17T19:55:00.0000000' AS DateTime2), CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2))
GO
INSERT [dbo].[LotterySchedules] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [LotteryId], [DayOfTheWeek], [CloseHour], [InactiveDate]) VALUES (8, NULL, 0, CAST(N'2020-09-01T12:21:38.1087613' AS DateTime2), N'74dffedd-b38f-40a4-9806-0bda7b3277f5', CAST(N'2020-11-17T19:41:48.7660987' AS DateTime2), N'74dffedd-b38f-40a4-9806-0bda7b3277f5', NULL, NULL, 2, 1, CAST(N'2020-11-17T20:15:00.0000000' AS DateTime2), CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2))
GO
INSERT [dbo].[LotterySchedules] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [LotteryId], [DayOfTheWeek], [CloseHour], [InactiveDate]) VALUES (9, NULL, 0, CAST(N'2020-09-01T12:21:38.1093452' AS DateTime2), N'74dffedd-b38f-40a4-9806-0bda7b3277f5', CAST(N'2020-11-17T19:41:48.7662644' AS DateTime2), N'74dffedd-b38f-40a4-9806-0bda7b3277f5', NULL, NULL, 2, 2, CAST(N'2020-11-17T14:15:00.0000000' AS DateTime2), CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2))
GO
INSERT [dbo].[LotterySchedules] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [LotteryId], [DayOfTheWeek], [CloseHour], [InactiveDate]) VALUES (10, NULL, 0, CAST(N'2020-09-01T12:21:38.1156979' AS DateTime2), N'74dffedd-b38f-40a4-9806-0bda7b3277f5', CAST(N'2020-11-17T19:41:48.7664237' AS DateTime2), N'74dffedd-b38f-40a4-9806-0bda7b3277f5', NULL, NULL, 2, 3, CAST(N'2020-11-17T20:15:00.0000000' AS DateTime2), CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2))
GO
INSERT [dbo].[LotterySchedules] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [LotteryId], [DayOfTheWeek], [CloseHour], [InactiveDate]) VALUES (11, NULL, 0, CAST(N'2020-09-01T12:21:38.1163311' AS DateTime2), N'74dffedd-b38f-40a4-9806-0bda7b3277f5', CAST(N'2020-11-17T19:41:48.7665964' AS DateTime2), N'74dffedd-b38f-40a4-9806-0bda7b3277f5', NULL, NULL, 2, 4, CAST(N'2020-11-17T20:15:00.0000000' AS DateTime2), CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2))
GO
INSERT [dbo].[LotterySchedules] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [LotteryId], [DayOfTheWeek], [CloseHour], [InactiveDate]) VALUES (12, NULL, 0, CAST(N'2020-09-01T12:21:38.1169379' AS DateTime2), N'74dffedd-b38f-40a4-9806-0bda7b3277f5', CAST(N'2020-11-17T19:41:48.7667431' AS DateTime2), N'74dffedd-b38f-40a4-9806-0bda7b3277f5', NULL, NULL, 2, 5, CAST(N'2020-11-17T20:15:00.0000000' AS DateTime2), CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2))
GO
INSERT [dbo].[LotterySchedules] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [LotteryId], [DayOfTheWeek], [CloseHour], [InactiveDate]) VALUES (13, NULL, 0, CAST(N'2020-09-01T12:21:38.1175430' AS DateTime2), N'74dffedd-b38f-40a4-9806-0bda7b3277f5', CAST(N'2020-11-17T19:41:48.7668647' AS DateTime2), N'74dffedd-b38f-40a4-9806-0bda7b3277f5', NULL, NULL, 2, 6, CAST(N'2020-11-17T20:15:00.0000000' AS DateTime2), CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2))
GO
INSERT [dbo].[LotterySchedules] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [LotteryId], [DayOfTheWeek], [CloseHour], [InactiveDate]) VALUES (14, NULL, 0, CAST(N'2020-09-01T12:21:38.1184509' AS DateTime2), N'74dffedd-b38f-40a4-9806-0bda7b3277f5', CAST(N'2020-11-17T19:41:48.7670015' AS DateTime2), N'74dffedd-b38f-40a4-9806-0bda7b3277f5', NULL, NULL, 2, 7, CAST(N'2020-11-17T20:15:00.0000000' AS DateTime2), CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2))
GO
INSERT [dbo].[LotterySchedules] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [LotteryId], [DayOfTheWeek], [CloseHour], [InactiveDate]) VALUES (15, NULL, 0, CAST(N'2020-09-03T19:41:14.2436380' AS DateTime2), N'74dffedd-b38f-40a4-9806-0bda7b3277f5', CAST(N'2020-11-11T12:16:01.4121135' AS DateTime2), N'74dffedd-b38f-40a4-9806-0bda7b3277f5', NULL, NULL, 3, 1, CAST(N'2020-11-11T14:15:00.0000000' AS DateTime2), CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2))
GO
INSERT [dbo].[LotterySchedules] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [LotteryId], [DayOfTheWeek], [CloseHour], [InactiveDate]) VALUES (16, NULL, 0, CAST(N'2020-09-03T19:41:14.2454915' AS DateTime2), N'74dffedd-b38f-40a4-9806-0bda7b3277f5', CAST(N'2020-11-11T12:16:01.4121816' AS DateTime2), N'74dffedd-b38f-40a4-9806-0bda7b3277f5', NULL, NULL, 3, 2, CAST(N'2020-11-11T14:15:00.0000000' AS DateTime2), CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2))
GO
INSERT [dbo].[LotterySchedules] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [LotteryId], [DayOfTheWeek], [CloseHour], [InactiveDate]) VALUES (17, NULL, 0, CAST(N'2020-09-03T19:41:14.2466867' AS DateTime2), N'74dffedd-b38f-40a4-9806-0bda7b3277f5', CAST(N'2020-11-11T12:16:01.4122372' AS DateTime2), N'74dffedd-b38f-40a4-9806-0bda7b3277f5', NULL, NULL, 3, 3, CAST(N'2020-11-11T08:15:00.0000000' AS DateTime2), CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2))
GO
INSERT [dbo].[LotterySchedules] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [LotteryId], [DayOfTheWeek], [CloseHour], [InactiveDate]) VALUES (18, NULL, 0, CAST(N'2020-09-03T19:41:14.2477520' AS DateTime2), N'74dffedd-b38f-40a4-9806-0bda7b3277f5', CAST(N'2020-11-11T12:16:01.4122906' AS DateTime2), N'74dffedd-b38f-40a4-9806-0bda7b3277f5', NULL, NULL, 3, 4, CAST(N'2020-11-11T14:15:00.0000000' AS DateTime2), CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2))
GO
INSERT [dbo].[LotterySchedules] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [LotteryId], [DayOfTheWeek], [CloseHour], [InactiveDate]) VALUES (19, NULL, 0, CAST(N'2020-09-03T19:41:14.2488346' AS DateTime2), N'74dffedd-b38f-40a4-9806-0bda7b3277f5', CAST(N'2020-11-11T12:16:01.4123423' AS DateTime2), N'74dffedd-b38f-40a4-9806-0bda7b3277f5', NULL, NULL, 3, 5, CAST(N'2020-11-11T12:01:00.0000000' AS DateTime2), CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2))
GO
INSERT [dbo].[LotterySchedules] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [LotteryId], [DayOfTheWeek], [CloseHour], [InactiveDate]) VALUES (20, NULL, 0, CAST(N'2020-09-03T19:41:14.2501183' AS DateTime2), N'74dffedd-b38f-40a4-9806-0bda7b3277f5', CAST(N'2020-11-11T12:16:01.4123955' AS DateTime2), N'74dffedd-b38f-40a4-9806-0bda7b3277f5', NULL, NULL, 3, 6, CAST(N'2020-11-11T14:15:00.0000000' AS DateTime2), CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2))
GO
INSERT [dbo].[LotterySchedules] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [LotteryId], [DayOfTheWeek], [CloseHour], [InactiveDate]) VALUES (21, NULL, 0, CAST(N'2020-09-03T19:41:14.2512531' AS DateTime2), N'74dffedd-b38f-40a4-9806-0bda7b3277f5', CAST(N'2020-11-11T12:16:01.4124742' AS DateTime2), N'74dffedd-b38f-40a4-9806-0bda7b3277f5', NULL, NULL, 3, 7, CAST(N'2020-11-11T14:15:00.0000000' AS DateTime2), CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2))
GO
INSERT [dbo].[LotterySchedules] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [LotteryId], [DayOfTheWeek], [CloseHour], [InactiveDate]) VALUES (22, NULL, 0, CAST(N'2020-09-05T23:27:17.0378229' AS DateTime2), N'74dffedd-b38f-40a4-9806-0bda7b3277f5', CAST(N'2020-11-04T21:49:30.2982708' AS DateTime2), N'74dffedd-b38f-40a4-9806-0bda7b3277f5', NULL, NULL, 4, 1, CAST(N'2020-11-04T23:55:00.0000000' AS DateTime2), CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2))
GO
INSERT [dbo].[LotterySchedules] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [LotteryId], [DayOfTheWeek], [CloseHour], [InactiveDate]) VALUES (23, NULL, 0, CAST(N'2020-09-05T23:27:17.0383611' AS DateTime2), N'74dffedd-b38f-40a4-9806-0bda7b3277f5', CAST(N'2020-11-04T21:49:30.2983446' AS DateTime2), N'74dffedd-b38f-40a4-9806-0bda7b3277f5', NULL, NULL, 4, 2, CAST(N'2020-11-04T14:15:00.0000000' AS DateTime2), CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2))
GO
INSERT [dbo].[LotterySchedules] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [LotteryId], [DayOfTheWeek], [CloseHour], [InactiveDate]) VALUES (24, NULL, 0, CAST(N'2020-09-05T23:27:17.0389967' AS DateTime2), N'74dffedd-b38f-40a4-9806-0bda7b3277f5', CAST(N'2020-11-04T21:49:30.2984168' AS DateTime2), N'74dffedd-b38f-40a4-9806-0bda7b3277f5', NULL, NULL, 4, 3, CAST(N'2020-11-04T21:15:00.0000000' AS DateTime2), CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2))
GO
INSERT [dbo].[LotterySchedules] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [LotteryId], [DayOfTheWeek], [CloseHour], [InactiveDate]) VALUES (25, NULL, 0, CAST(N'2020-09-05T23:27:17.0395906' AS DateTime2), N'74dffedd-b38f-40a4-9806-0bda7b3277f5', CAST(N'2020-11-04T21:49:30.2984793' AS DateTime2), N'74dffedd-b38f-40a4-9806-0bda7b3277f5', NULL, NULL, 4, 4, CAST(N'2020-11-04T14:15:00.0000000' AS DateTime2), CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2))
GO
INSERT [dbo].[LotterySchedules] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [LotteryId], [DayOfTheWeek], [CloseHour], [InactiveDate]) VALUES (26, NULL, 0, CAST(N'2020-09-05T23:27:17.0401705' AS DateTime2), N'74dffedd-b38f-40a4-9806-0bda7b3277f5', CAST(N'2020-11-04T21:49:30.2985345' AS DateTime2), N'74dffedd-b38f-40a4-9806-0bda7b3277f5', NULL, NULL, 4, 5, CAST(N'2020-11-04T23:55:00.0000000' AS DateTime2), CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2))
GO
INSERT [dbo].[LotterySchedules] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [LotteryId], [DayOfTheWeek], [CloseHour], [InactiveDate]) VALUES (27, NULL, 0, CAST(N'2020-09-05T23:27:17.0466251' AS DateTime2), N'74dffedd-b38f-40a4-9806-0bda7b3277f5', CAST(N'2020-11-04T21:49:30.2986252' AS DateTime2), N'74dffedd-b38f-40a4-9806-0bda7b3277f5', NULL, NULL, 4, 6, CAST(N'2020-11-04T23:55:00.0000000' AS DateTime2), CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2))
GO
INSERT [dbo].[LotterySchedules] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [LotteryId], [DayOfTheWeek], [CloseHour], [InactiveDate]) VALUES (28, NULL, 0, CAST(N'2020-09-05T23:27:17.0472172' AS DateTime2), N'74dffedd-b38f-40a4-9806-0bda7b3277f5', CAST(N'2020-11-04T21:49:30.2986979' AS DateTime2), N'74dffedd-b38f-40a4-9806-0bda7b3277f5', NULL, NULL, 4, 7, CAST(N'2020-11-04T23:55:00.0000000' AS DateTime2), CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2))
GO
INSERT [dbo].[LotterySchedules] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [LotteryId], [DayOfTheWeek], [CloseHour], [InactiveDate]) VALUES (29, NULL, 0, CAST(N'2020-09-09T18:01:42.5616703' AS DateTime2), N'74dffedd-b38f-40a4-9806-0bda7b3277f5', CAST(N'2020-10-17T20:24:53.4189660' AS DateTime2), N'74dffedd-b38f-40a4-9806-0bda7b3277f5', NULL, NULL, 5, 1, CAST(N'2020-10-17T19:55:00.0000000' AS DateTime2), CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2))
GO
INSERT [dbo].[LotterySchedules] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [LotteryId], [DayOfTheWeek], [CloseHour], [InactiveDate]) VALUES (30, NULL, 0, CAST(N'2020-09-09T18:01:42.5642849' AS DateTime2), N'74dffedd-b38f-40a4-9806-0bda7b3277f5', CAST(N'2020-10-17T20:24:53.4190400' AS DateTime2), N'74dffedd-b38f-40a4-9806-0bda7b3277f5', NULL, NULL, 5, 2, CAST(N'2020-10-17T19:55:00.0000000' AS DateTime2), CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2))
GO
INSERT [dbo].[LotterySchedules] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [LotteryId], [DayOfTheWeek], [CloseHour], [InactiveDate]) VALUES (31, NULL, 0, CAST(N'2020-09-09T18:01:42.5670381' AS DateTime2), N'74dffedd-b38f-40a4-9806-0bda7b3277f5', CAST(N'2020-10-17T20:24:53.4191050' AS DateTime2), N'74dffedd-b38f-40a4-9806-0bda7b3277f5', NULL, NULL, 5, 3, CAST(N'2020-10-17T19:55:00.0000000' AS DateTime2), CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2))
GO
INSERT [dbo].[LotterySchedules] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [LotteryId], [DayOfTheWeek], [CloseHour], [InactiveDate]) VALUES (32, NULL, 0, CAST(N'2020-09-09T18:01:42.5698000' AS DateTime2), N'74dffedd-b38f-40a4-9806-0bda7b3277f5', CAST(N'2020-10-17T20:24:53.4191730' AS DateTime2), N'74dffedd-b38f-40a4-9806-0bda7b3277f5', NULL, NULL, 5, 4, CAST(N'2020-10-17T19:55:00.0000000' AS DateTime2), CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2))
GO
INSERT [dbo].[LotterySchedules] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [LotteryId], [DayOfTheWeek], [CloseHour], [InactiveDate]) VALUES (33, NULL, 0, CAST(N'2020-09-09T18:01:42.5721240' AS DateTime2), N'74dffedd-b38f-40a4-9806-0bda7b3277f5', CAST(N'2020-10-17T20:24:53.4192390' AS DateTime2), N'74dffedd-b38f-40a4-9806-0bda7b3277f5', NULL, NULL, 5, 5, CAST(N'2020-10-17T19:55:00.0000000' AS DateTime2), CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2))
GO
INSERT [dbo].[LotterySchedules] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [LotteryId], [DayOfTheWeek], [CloseHour], [InactiveDate]) VALUES (34, NULL, 0, CAST(N'2020-09-09T18:01:42.5735659' AS DateTime2), N'74dffedd-b38f-40a4-9806-0bda7b3277f5', CAST(N'2020-10-17T20:24:53.4193030' AS DateTime2), N'74dffedd-b38f-40a4-9806-0bda7b3277f5', NULL, NULL, 5, 6, CAST(N'2020-10-17T19:55:00.0000000' AS DateTime2), CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2))
GO
INSERT [dbo].[LotterySchedules] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [LotteryId], [DayOfTheWeek], [CloseHour], [InactiveDate]) VALUES (35, NULL, 0, CAST(N'2020-09-09T18:01:42.5761228' AS DateTime2), N'74dffedd-b38f-40a4-9806-0bda7b3277f5', CAST(N'2020-10-17T20:24:53.4193670' AS DateTime2), N'74dffedd-b38f-40a4-9806-0bda7b3277f5', NULL, NULL, 5, 7, CAST(N'2020-10-17T19:55:00.0000000' AS DateTime2), CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2))
GO
SET IDENTITY_INSERT [dbo].[LotterySchedules] OFF
GO
SET IDENTITY_INSERT [dbo].[OwnerPlans] ON 
GO
INSERT [dbo].[OwnerPlans] ([Id], [Name], [OwnerId], [PlanId]) VALUES (1, NULL, 1, 1)
GO
SET IDENTITY_INSERT [dbo].[OwnerPlans] OFF
GO
SET IDENTITY_INSERT [dbo].[Owners] ON 
GO
INSERT [dbo].[Owners] ([Id], [Name], [Rnc], [Code], [LastName], [Email], [WebAddress], [Address], [Imagen], [Tel], [PrefixExp], [PrefixFact], [PrefixOrder], [StartDate], [PrefixNcf], [SeqNcf], [PrefixFinalFact], [NcfEnds], [SeqFact], [Header1], [Header2], [Header3], [Footer1], [Footer2], [Footer3], [UsersAvailable], [MegabytesAvailable], [RegitersAvailable], [PlanActiveUntil], [OwnerTypeId], [SeqNcfGub], [PrefixNcfGub], [IsActive], [UserNameInReport]) VALUES (1, N'Tomas Aquino', NULL, N'Tomas Aquino', N' Mendes', N'mersyrd@gmail.com', N'mersyrd.com', NULL, N'~/images/Logos/773d0a0d-7827-409b-89ef-bae3ebbb92f2.jpeg', N'8492077714', N'MED', N'FAC', N'ORD', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, N'Tels: (849) 207-7714, (829) 349-5083', NULL, 5, 5, 500, NULL, NULL, 0, NULL, 1, 0)
GO
INSERT [dbo].[Owners] ([Id], [Name], [Rnc], [Code], [LastName], [Email], [WebAddress], [Address], [Imagen], [Tel], [PrefixExp], [PrefixFact], [PrefixOrder], [StartDate], [PrefixNcf], [SeqNcf], [PrefixFinalFact], [NcfEnds], [SeqFact], [Header1], [Header2], [Header3], [Footer1], [Footer2], [Footer3], [UsersAvailable], [MegabytesAvailable], [RegitersAvailable], [PlanActiveUntil], [OwnerTypeId], [SeqNcfGub], [PrefixNcfGub], [IsActive], [UserNameInReport]) VALUES (2, N'Yajaira Olivarez', NULL, N'Yajaira Olivare', N' ', N'mersycore@gmail.com', N'mersycore.com', NULL, N'~/images/Capture 1.PNG', N'8293495083', N'MED', N'FAC', N'ORD', NULL, NULL, NULL, NULL, NULL, NULL, N'Yajaira Olivarez de Mendez', N'Ginecologa-Obstetra, Colposcopista Ginecoestetica', NULL, N'Centro Policlinico Nacional', NULL, NULL, 0, 0, 0, NULL, NULL, 0, NULL, 1, 0)
GO
INSERT [dbo].[Owners] ([Id], [Name], [Rnc], [Code], [LastName], [Email], [WebAddress], [Address], [Imagen], [Tel], [PrefixExp], [PrefixFact], [PrefixOrder], [StartDate], [PrefixNcf], [SeqNcf], [PrefixFinalFact], [NcfEnds], [SeqFact], [Header1], [Header2], [Header3], [Footer1], [Footer2], [Footer3], [UsersAvailable], [MegabytesAvailable], [RegitersAvailable], [PlanActiveUntil], [OwnerTypeId], [SeqNcfGub], [PrefixNcfGub], [IsActive], [UserNameInReport]) VALUES (4, N'ccc', NULL, NULL, N'cccc', N'mersyrd@gmail.com', NULL, NULL, NULL, N'3', NULL, NULL, NULL, CAST(N'2020-07-02T17:31:07.1487748' AS DateTime2), NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 0, 0, 0, NULL, NULL, 0, NULL, 0, 0)
GO
INSERT [dbo].[Owners] ([Id], [Name], [Rnc], [Code], [LastName], [Email], [WebAddress], [Address], [Imagen], [Tel], [PrefixExp], [PrefixFact], [PrefixOrder], [StartDate], [PrefixNcf], [SeqNcf], [PrefixFinalFact], [NcfEnds], [SeqFact], [Header1], [Header2], [Header3], [Footer1], [Footer2], [Footer3], [UsersAvailable], [MegabytesAvailable], [RegitersAvailable], [PlanActiveUntil], [OwnerTypeId], [SeqNcfGub], [PrefixNcfGub], [IsActive], [UserNameInReport]) VALUES (5, N'Juan', NULL, NULL, N'Merodio', N'juan@gmail.com', NULL, NULL, NULL, N'8492077714', NULL, N'', NULL, CAST(N'2020-08-31T20:28:53.0372120' AS DateTime2), NULL, NULL, NULL, NULL, NULL, N'Loteria verddera', NULL, NULL, N'revise su ticket antes de dejar el lugar', NULL, NULL, 0, -1, 0, NULL, 1, 0, NULL, 0, 0)
GO
SET IDENTITY_INSERT [dbo].[Owners] OFF
GO
SET IDENTITY_INSERT [dbo].[OwnerTypes] ON 
GO
INSERT [dbo].[OwnerTypes] ([Id], [Name]) VALUES (1, N'Empresa')
GO
INSERT [dbo].[OwnerTypes] ([Id], [Name]) VALUES (2, N'Persona')
GO
SET IDENTITY_INSERT [dbo].[OwnerTypes] OFF
GO
SET IDENTITY_INSERT [dbo].[Payments] ON 
GO
INSERT [dbo].[Payments] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [LotterySaleId], [Date], [Remarks], [ReceivedAmount], [DevolvedAmount], [Amountx], [Type], [ComissionAmount], [SupervisorAmount]) VALUES (20, NULL, 0, CAST(N'2020-09-25T12:38:03.0503640' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', CAST(N'2020-09-25T12:38:03.0503640' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', NULL, NULL, NULL, CAST(N'2020-09-25T08:38:02.7133630' AS DateTime2), NULL, NULL, NULL, CAST(0.00 AS Decimal(12, 2)), 1, CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[Payments] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [LotterySaleId], [Date], [Remarks], [ReceivedAmount], [DevolvedAmount], [Amountx], [Type], [ComissionAmount], [SupervisorAmount]) VALUES (21, NULL, 0, CAST(N'2020-09-25T12:39:40.6725640' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', CAST(N'2020-09-25T12:39:40.6725640' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', NULL, NULL, NULL, CAST(N'2020-09-25T08:39:40.6693160' AS DateTime2), NULL, NULL, NULL, CAST(0.00 AS Decimal(12, 2)), 1, CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[Payments] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [LotterySaleId], [Date], [Remarks], [ReceivedAmount], [DevolvedAmount], [Amountx], [Type], [ComissionAmount], [SupervisorAmount]) VALUES (22, NULL, 0, CAST(N'2020-09-25T14:37:23.4882820' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', CAST(N'2020-09-25T14:37:23.4882820' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', NULL, NULL, NULL, CAST(N'2020-09-25T10:37:23.3212400' AS DateTime2), NULL, NULL, NULL, CAST(0.00 AS Decimal(12, 2)), 1, CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[Payments] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [LotterySaleId], [Date], [Remarks], [ReceivedAmount], [DevolvedAmount], [Amountx], [Type], [ComissionAmount], [SupervisorAmount]) VALUES (23, NULL, 0, CAST(N'2020-09-25T14:39:31.9125360' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', CAST(N'2020-09-25T14:39:31.9125360' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', NULL, NULL, NULL, CAST(N'2020-09-25T10:39:31.9084510' AS DateTime2), NULL, NULL, NULL, CAST(0.00 AS Decimal(12, 2)), 1, CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[Payments] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [LotterySaleId], [Date], [Remarks], [ReceivedAmount], [DevolvedAmount], [Amountx], [Type], [ComissionAmount], [SupervisorAmount]) VALUES (25, NULL, 0, CAST(N'2020-09-25T15:49:08.5662020' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', CAST(N'2020-09-25T15:49:08.5662020' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', NULL, NULL, 19, CAST(N'2020-09-25T11:49:08.5199950' AS DateTime2), NULL, NULL, NULL, CAST(12.00 AS Decimal(12, 2)), 1, CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[Payments] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [LotterySaleId], [Date], [Remarks], [ReceivedAmount], [DevolvedAmount], [Amountx], [Type], [ComissionAmount], [SupervisorAmount]) VALUES (26, NULL, 0, CAST(N'2020-09-25T21:13:07.1888740' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', CAST(N'2020-09-25T21:13:07.1888740' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', NULL, NULL, 20, CAST(N'2020-09-25T17:13:07.1482710' AS DateTime2), NULL, NULL, NULL, CAST(122.00 AS Decimal(12, 2)), 1, CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[Payments] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [LotterySaleId], [Date], [Remarks], [ReceivedAmount], [DevolvedAmount], [Amountx], [Type], [ComissionAmount], [SupervisorAmount]) VALUES (27, NULL, 0, CAST(N'2020-09-25T21:19:35.3122040' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', CAST(N'2020-09-25T21:19:35.3122040' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', NULL, NULL, 21, CAST(N'2020-09-25T17:19:35.2687190' AS DateTime2), NULL, NULL, NULL, CAST(12123123.00 AS Decimal(12, 2)), 1, CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[Payments] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [LotterySaleId], [Date], [Remarks], [ReceivedAmount], [DevolvedAmount], [Amountx], [Type], [ComissionAmount], [SupervisorAmount]) VALUES (28, NULL, 0, CAST(N'2020-10-08T19:11:46.1964940' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', CAST(N'2020-10-08T19:11:46.1964940' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', NULL, NULL, 22, CAST(N'2020-10-08T15:11:46.0732680' AS DateTime2), NULL, NULL, NULL, CAST(3000.00 AS Decimal(12, 2)), 1, CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[Payments] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [LotterySaleId], [Date], [Remarks], [ReceivedAmount], [DevolvedAmount], [Amountx], [Type], [ComissionAmount], [SupervisorAmount]) VALUES (29, NULL, 0, CAST(N'2020-10-19T03:14:12.8509420' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', CAST(N'2020-10-19T03:14:12.8509420' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', NULL, NULL, 23, CAST(N'2020-10-18T23:14:12.7892050' AS DateTime2), NULL, NULL, NULL, CAST(100.00 AS Decimal(12, 2)), 1, CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[Payments] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [LotterySaleId], [Date], [Remarks], [ReceivedAmount], [DevolvedAmount], [Amountx], [Type], [ComissionAmount], [SupervisorAmount]) VALUES (30, NULL, 0, CAST(N'2020-10-19T03:14:57.1537190' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', CAST(N'2020-10-19T03:14:57.1537190' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', NULL, NULL, 24, CAST(N'2020-10-18T23:14:57.1463920' AS DateTime2), NULL, NULL, NULL, CAST(323.00 AS Decimal(12, 2)), 1, CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[Payments] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [LotterySaleId], [Date], [Remarks], [ReceivedAmount], [DevolvedAmount], [Amountx], [Type], [ComissionAmount], [SupervisorAmount]) VALUES (31, NULL, 0, CAST(N'2020-10-19T03:15:18.1819710' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', CAST(N'2020-10-19T03:15:18.1819710' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', NULL, NULL, 25, CAST(N'2020-10-18T23:15:18.1749550' AS DateTime2), NULL, NULL, NULL, CAST(2323.00 AS Decimal(12, 2)), 1, CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[Payments] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [LotterySaleId], [Date], [Remarks], [ReceivedAmount], [DevolvedAmount], [Amountx], [Type], [ComissionAmount], [SupervisorAmount]) VALUES (32, NULL, 0, CAST(N'2020-10-19T03:15:35.0046170' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', CAST(N'2020-10-19T03:15:35.0046170' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', NULL, NULL, 26, CAST(N'2020-10-18T23:15:34.9993720' AS DateTime2), NULL, NULL, NULL, CAST(234.00 AS Decimal(12, 2)), 1, CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[Payments] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [LotterySaleId], [Date], [Remarks], [ReceivedAmount], [DevolvedAmount], [Amountx], [Type], [ComissionAmount], [SupervisorAmount]) VALUES (33, NULL, 0, CAST(N'2020-10-19T03:15:47.3494430' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', CAST(N'2020-10-19T03:15:47.3494430' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', NULL, NULL, 27, CAST(N'2020-10-18T23:15:47.3440610' AS DateTime2), NULL, NULL, NULL, CAST(234.00 AS Decimal(12, 2)), 1, CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[Payments] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [LotterySaleId], [Date], [Remarks], [ReceivedAmount], [DevolvedAmount], [Amountx], [Type], [ComissionAmount], [SupervisorAmount]) VALUES (34, NULL, 0, CAST(N'2020-10-19T03:16:02.1359900' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', CAST(N'2020-10-19T03:16:02.1359900' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', NULL, NULL, 28, CAST(N'2020-10-18T23:16:02.1296720' AS DateTime2), NULL, NULL, NULL, CAST(2344.00 AS Decimal(12, 2)), 1, CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[Payments] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [LotterySaleId], [Date], [Remarks], [ReceivedAmount], [DevolvedAmount], [Amountx], [Type], [ComissionAmount], [SupervisorAmount]) VALUES (35, NULL, 0, CAST(N'2020-10-19T03:16:14.8709660' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', CAST(N'2020-10-19T03:16:14.8709660' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', NULL, NULL, 29, CAST(N'2020-10-18T23:16:14.8664310' AS DateTime2), NULL, NULL, NULL, CAST(234.00 AS Decimal(12, 2)), 1, CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[Payments] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [LotterySaleId], [Date], [Remarks], [ReceivedAmount], [DevolvedAmount], [Amountx], [Type], [ComissionAmount], [SupervisorAmount]) VALUES (36, NULL, 0, CAST(N'2020-10-19T03:16:28.2677310' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', CAST(N'2020-10-19T03:16:28.2677310' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', NULL, NULL, 30, CAST(N'2020-10-18T23:16:28.2634110' AS DateTime2), NULL, NULL, NULL, CAST(234.00 AS Decimal(12, 2)), 1, CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[Payments] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [LotterySaleId], [Date], [Remarks], [ReceivedAmount], [DevolvedAmount], [Amountx], [Type], [ComissionAmount], [SupervisorAmount]) VALUES (37, NULL, 0, CAST(N'2020-10-19T03:16:44.3416120' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', CAST(N'2020-10-19T03:16:44.3416120' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', NULL, NULL, 31, CAST(N'2020-10-18T23:16:44.3372500' AS DateTime2), NULL, NULL, NULL, CAST(234.00 AS Decimal(12, 2)), 1, CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[Payments] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [LotterySaleId], [Date], [Remarks], [ReceivedAmount], [DevolvedAmount], [Amountx], [Type], [ComissionAmount], [SupervisorAmount]) VALUES (38, NULL, 0, CAST(N'2020-10-19T03:17:13.6842470' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', CAST(N'2020-10-19T03:17:13.6842470' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', NULL, NULL, 32, CAST(N'2020-10-18T23:17:13.6778030' AS DateTime2), NULL, NULL, NULL, CAST(2342.00 AS Decimal(12, 2)), 1, CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[Payments] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [LotterySaleId], [Date], [Remarks], [ReceivedAmount], [DevolvedAmount], [Amountx], [Type], [ComissionAmount], [SupervisorAmount]) VALUES (39, NULL, 0, CAST(N'2020-10-19T03:17:29.3870400' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', CAST(N'2020-10-19T03:17:29.3870400' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', NULL, NULL, 33, CAST(N'2020-10-18T23:17:29.3813290' AS DateTime2), NULL, NULL, NULL, CAST(234324.00 AS Decimal(12, 2)), 1, CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[Payments] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [LotterySaleId], [Date], [Remarks], [ReceivedAmount], [DevolvedAmount], [Amountx], [Type], [ComissionAmount], [SupervisorAmount]) VALUES (40, NULL, 0, CAST(N'2020-10-19T03:17:54.2991100' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', CAST(N'2020-10-19T03:17:54.2991100' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', NULL, NULL, 34, CAST(N'2020-10-18T23:17:54.2942830' AS DateTime2), NULL, NULL, NULL, CAST(698.00 AS Decimal(12, 2)), 1, CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[Payments] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [LotterySaleId], [Date], [Remarks], [ReceivedAmount], [DevolvedAmount], [Amountx], [Type], [ComissionAmount], [SupervisorAmount]) VALUES (41, NULL, 0, CAST(N'2020-10-19T03:18:22.5446080' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', CAST(N'2020-10-19T03:18:22.5446080' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', NULL, NULL, 35, CAST(N'2020-10-18T23:18:22.5381370' AS DateTime2), NULL, NULL, NULL, CAST(68.00 AS Decimal(12, 2)), 1, CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[Payments] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [LotterySaleId], [Date], [Remarks], [ReceivedAmount], [DevolvedAmount], [Amountx], [Type], [ComissionAmount], [SupervisorAmount]) VALUES (42, NULL, 0, CAST(N'2020-10-19T03:18:44.2056770' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', CAST(N'2020-10-19T03:18:44.2056770' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', NULL, NULL, 36, CAST(N'2020-10-18T23:18:44.1999900' AS DateTime2), NULL, NULL, NULL, CAST(100.00 AS Decimal(12, 2)), 1, CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[Payments] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [LotterySaleId], [Date], [Remarks], [ReceivedAmount], [DevolvedAmount], [Amountx], [Type], [ComissionAmount], [SupervisorAmount]) VALUES (43, NULL, 0, CAST(N'2020-10-19T03:19:22.3775780' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', CAST(N'2020-10-19T03:19:22.3775780' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', NULL, NULL, 37, CAST(N'2020-10-18T23:19:22.3718740' AS DateTime2), NULL, NULL, NULL, CAST(801.00 AS Decimal(12, 2)), 1, CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[Payments] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [LotterySaleId], [Date], [Remarks], [ReceivedAmount], [DevolvedAmount], [Amountx], [Type], [ComissionAmount], [SupervisorAmount]) VALUES (44, NULL, 0, CAST(N'2020-10-19T03:19:43.3509940' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', CAST(N'2020-10-19T03:19:43.3509940' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', NULL, NULL, 38, CAST(N'2020-10-18T23:19:43.3445880' AS DateTime2), NULL, NULL, NULL, CAST(200.00 AS Decimal(12, 2)), 1, CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[Payments] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [LotterySaleId], [Date], [Remarks], [ReceivedAmount], [DevolvedAmount], [Amountx], [Type], [ComissionAmount], [SupervisorAmount]) VALUES (45, NULL, 0, CAST(N'2020-10-19T03:20:17.0300370' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', CAST(N'2020-10-19T03:20:17.0300370' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', NULL, NULL, 39, CAST(N'2020-10-18T23:20:17.0246550' AS DateTime2), NULL, NULL, NULL, CAST(234668.00 AS Decimal(12, 2)), 1, CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[Payments] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [LotterySaleId], [Date], [Remarks], [ReceivedAmount], [DevolvedAmount], [Amountx], [Type], [ComissionAmount], [SupervisorAmount]) VALUES (46, NULL, 0, CAST(N'2020-10-19T03:20:39.5215440' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', CAST(N'2020-10-19T03:20:39.5215440' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', NULL, NULL, 40, CAST(N'2020-10-18T23:20:39.5170060' AS DateTime2), NULL, NULL, NULL, CAST(3553.00 AS Decimal(12, 2)), 1, CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[Payments] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [LotterySaleId], [Date], [Remarks], [ReceivedAmount], [DevolvedAmount], [Amountx], [Type], [ComissionAmount], [SupervisorAmount]) VALUES (47, NULL, 0, CAST(N'2020-10-19T03:21:01.5340170' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', CAST(N'2020-10-19T03:21:01.5340170' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', NULL, NULL, 41, CAST(N'2020-10-18T23:21:01.5278840' AS DateTime2), NULL, NULL, NULL, CAST(34534.00 AS Decimal(12, 2)), 1, CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[Payments] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [LotterySaleId], [Date], [Remarks], [ReceivedAmount], [DevolvedAmount], [Amountx], [Type], [ComissionAmount], [SupervisorAmount]) VALUES (48, NULL, 0, CAST(N'2020-10-19T23:36:49.9771450' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', CAST(N'2020-10-19T23:36:49.9771450' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', NULL, NULL, 54, CAST(N'2020-10-19T19:36:49.9288450' AS DateTime2), NULL, NULL, NULL, CAST(345.00 AS Decimal(12, 2)), 1, CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[Payments] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [LotterySaleId], [Date], [Remarks], [ReceivedAmount], [DevolvedAmount], [Amountx], [Type], [ComissionAmount], [SupervisorAmount]) VALUES (49, NULL, 0, CAST(N'2020-10-19T23:37:30.1453910' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', CAST(N'2020-10-19T23:37:30.1453910' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', NULL, NULL, 55, CAST(N'2020-10-19T19:37:30.1394540' AS DateTime2), NULL, NULL, NULL, CAST(667.00 AS Decimal(12, 2)), 1, CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[Payments] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [LotterySaleId], [Date], [Remarks], [ReceivedAmount], [DevolvedAmount], [Amountx], [Type], [ComissionAmount], [SupervisorAmount]) VALUES (50, NULL, 0, CAST(N'2020-10-19T23:37:49.3161790' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', CAST(N'2020-10-19T23:37:49.3161790' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', NULL, NULL, 56, CAST(N'2020-10-19T19:37:49.3091840' AS DateTime2), NULL, NULL, NULL, CAST(56756.00 AS Decimal(12, 2)), 1, CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[Payments] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [LotterySaleId], [Date], [Remarks], [ReceivedAmount], [DevolvedAmount], [Amountx], [Type], [ComissionAmount], [SupervisorAmount]) VALUES (51, NULL, 0, CAST(N'2020-10-19T23:38:27.6738430' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', CAST(N'2020-10-19T23:38:27.6738430' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', NULL, NULL, 57, CAST(N'2020-10-19T19:38:27.6672650' AS DateTime2), NULL, NULL, NULL, CAST(190.00 AS Decimal(12, 2)), 1, CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[Payments] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [LotterySaleId], [Date], [Remarks], [ReceivedAmount], [DevolvedAmount], [Amountx], [Type], [ComissionAmount], [SupervisorAmount]) VALUES (52, NULL, 0, CAST(N'2020-10-19T23:38:42.1583080' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', CAST(N'2020-10-19T23:38:42.1583080' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', NULL, NULL, 58, CAST(N'2020-10-19T19:38:42.1534920' AS DateTime2), NULL, NULL, NULL, CAST(100.00 AS Decimal(12, 2)), 1, CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[Payments] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [LotterySaleId], [Date], [Remarks], [ReceivedAmount], [DevolvedAmount], [Amountx], [Type], [ComissionAmount], [SupervisorAmount]) VALUES (53, NULL, 0, CAST(N'2020-10-19T23:38:53.8394070' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', CAST(N'2020-10-19T23:38:53.8394070' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', NULL, NULL, 59, CAST(N'2020-10-19T19:38:53.8328610' AS DateTime2), NULL, NULL, NULL, CAST(100.00 AS Decimal(12, 2)), 1, CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[Payments] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [LotterySaleId], [Date], [Remarks], [ReceivedAmount], [DevolvedAmount], [Amountx], [Type], [ComissionAmount], [SupervisorAmount]) VALUES (54, NULL, 0, CAST(N'2020-10-19T23:39:09.4605780' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', CAST(N'2020-10-19T23:39:09.4605780' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', NULL, NULL, 60, CAST(N'2020-10-19T19:39:09.4565370' AS DateTime2), NULL, NULL, NULL, CAST(100.00 AS Decimal(12, 2)), 1, CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[Payments] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [LotterySaleId], [Date], [Remarks], [ReceivedAmount], [DevolvedAmount], [Amountx], [Type], [ComissionAmount], [SupervisorAmount]) VALUES (55, NULL, 0, CAST(N'2020-10-19T23:39:23.2283190' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', CAST(N'2020-10-19T23:39:23.2283190' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', NULL, NULL, 61, CAST(N'2020-10-19T19:39:23.2225100' AS DateTime2), NULL, NULL, NULL, CAST(100.00 AS Decimal(12, 2)), 1, CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[Payments] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [LotterySaleId], [Date], [Remarks], [ReceivedAmount], [DevolvedAmount], [Amountx], [Type], [ComissionAmount], [SupervisorAmount]) VALUES (56, NULL, 0, CAST(N'2020-10-19T23:39:47.2424130' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', CAST(N'2020-10-19T23:39:47.2424130' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', NULL, NULL, 62, CAST(N'2020-10-19T19:39:47.2358090' AS DateTime2), NULL, NULL, NULL, CAST(4564.00 AS Decimal(12, 2)), 1, CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[Payments] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [LotterySaleId], [Date], [Remarks], [ReceivedAmount], [DevolvedAmount], [Amountx], [Type], [ComissionAmount], [SupervisorAmount]) VALUES (57, NULL, 0, CAST(N'2020-10-19T23:40:03.7599050' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', CAST(N'2020-10-19T23:40:03.7599050' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', NULL, NULL, 63, CAST(N'2020-10-19T19:40:03.7542840' AS DateTime2), NULL, NULL, NULL, CAST(456456456.00 AS Decimal(12, 2)), 1, CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[Payments] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [LotterySaleId], [Date], [Remarks], [ReceivedAmount], [DevolvedAmount], [Amountx], [Type], [ComissionAmount], [SupervisorAmount]) VALUES (58, NULL, 0, CAST(N'2020-10-19T23:40:31.3766460' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', CAST(N'2020-10-19T23:40:31.3766460' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', NULL, NULL, 64, CAST(N'2020-10-19T19:40:31.3707270' AS DateTime2), NULL, NULL, NULL, CAST(34534.00 AS Decimal(12, 2)), 1, CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[Payments] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [LotterySaleId], [Date], [Remarks], [ReceivedAmount], [DevolvedAmount], [Amountx], [Type], [ComissionAmount], [SupervisorAmount]) VALUES (59, NULL, 0, CAST(N'2020-10-19T23:40:53.4165720' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', CAST(N'2020-10-19T23:40:53.4165720' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', NULL, NULL, 65, CAST(N'2020-10-19T19:40:53.4104040' AS DateTime2), NULL, NULL, NULL, CAST(3433443.00 AS Decimal(12, 2)), 1, CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[Payments] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [LotterySaleId], [Date], [Remarks], [ReceivedAmount], [DevolvedAmount], [Amountx], [Type], [ComissionAmount], [SupervisorAmount]) VALUES (60, NULL, 0, CAST(N'2020-10-19T23:41:31.4293550' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', CAST(N'2020-10-19T23:41:31.4293550' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', NULL, NULL, 66, CAST(N'2020-10-19T19:41:31.4234170' AS DateTime2), NULL, NULL, NULL, CAST(300000000.00 AS Decimal(12, 2)), 1, CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[Payments] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [LotterySaleId], [Date], [Remarks], [ReceivedAmount], [DevolvedAmount], [Amountx], [Type], [ComissionAmount], [SupervisorAmount]) VALUES (61, NULL, 0, CAST(N'2020-10-20T02:10:35.8378310' AS DateTime2), N'74dffedd-b38f-40a4-9806-0bda7b3277f5', CAST(N'2020-10-20T02:10:35.8378310' AS DateTime2), N'74dffedd-b38f-40a4-9806-0bda7b3277f5', NULL, NULL, 40, CAST(N'2020-10-19T22:10:35.7527300' AS DateTime2), NULL, NULL, NULL, CAST(-30000.00 AS Decimal(12, 2)), 2, CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[Payments] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [LotterySaleId], [Date], [Remarks], [ReceivedAmount], [DevolvedAmount], [Amountx], [Type], [ComissionAmount], [SupervisorAmount]) VALUES (62, NULL, 0, CAST(N'2020-10-26T21:57:16.4130110' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', CAST(N'2020-10-26T21:57:16.4130110' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', NULL, NULL, 67, CAST(N'2020-10-26T17:57:03.1176260' AS DateTime2), NULL, NULL, NULL, CAST(3434.00 AS Decimal(12, 2)), 1, CAST(515.10 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[Payments] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [LotterySaleId], [Date], [Remarks], [ReceivedAmount], [DevolvedAmount], [Amountx], [Type], [ComissionAmount], [SupervisorAmount]) VALUES (63, NULL, 0, CAST(N'2020-10-26T21:57:30.1311970' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', CAST(N'2020-10-26T21:57:30.1311970' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', NULL, NULL, 68, CAST(N'2020-10-26T17:57:30.1239880' AS DateTime2), NULL, NULL, NULL, CAST(234.00 AS Decimal(12, 2)), 1, CAST(35.10 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[Payments] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [LotterySaleId], [Date], [Remarks], [ReceivedAmount], [DevolvedAmount], [Amountx], [Type], [ComissionAmount], [SupervisorAmount]) VALUES (64, NULL, 0, CAST(N'2020-10-26T21:57:51.8698920' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', CAST(N'2020-10-26T21:57:51.8698920' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', NULL, NULL, 69, CAST(N'2020-10-26T17:57:51.8630420' AS DateTime2), NULL, NULL, NULL, CAST(1100.00 AS Decimal(12, 2)), 1, CAST(165.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[Payments] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [LotterySaleId], [Date], [Remarks], [ReceivedAmount], [DevolvedAmount], [Amountx], [Type], [ComissionAmount], [SupervisorAmount]) VALUES (65, NULL, 0, CAST(N'2020-10-26T21:58:07.7713520' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', CAST(N'2020-10-26T21:58:07.7713520' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', NULL, NULL, 70, CAST(N'2020-10-26T17:58:07.7650620' AS DateTime2), NULL, NULL, NULL, CAST(1000.00 AS Decimal(12, 2)), 1, CAST(150.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[Payments] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [LotterySaleId], [Date], [Remarks], [ReceivedAmount], [DevolvedAmount], [Amountx], [Type], [ComissionAmount], [SupervisorAmount]) VALUES (66, NULL, 0, CAST(N'2020-10-26T21:58:27.0460800' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', CAST(N'2020-10-26T21:58:27.0460800' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', NULL, NULL, 71, CAST(N'2020-10-26T17:58:27.0405020' AS DateTime2), NULL, NULL, NULL, CAST(1000.00 AS Decimal(12, 2)), 1, CAST(150.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[Payments] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [LotterySaleId], [Date], [Remarks], [ReceivedAmount], [DevolvedAmount], [Amountx], [Type], [ComissionAmount], [SupervisorAmount]) VALUES (67, NULL, 0, CAST(N'2020-10-26T21:58:36.9196920' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', CAST(N'2020-10-26T21:58:36.9196920' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', NULL, NULL, 72, CAST(N'2020-10-26T17:58:36.9132380' AS DateTime2), NULL, NULL, NULL, CAST(1000.00 AS Decimal(12, 2)), 1, CAST(150.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[Payments] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [LotterySaleId], [Date], [Remarks], [ReceivedAmount], [DevolvedAmount], [Amountx], [Type], [ComissionAmount], [SupervisorAmount]) VALUES (68, NULL, 0, CAST(N'2020-10-26T21:58:50.9556490' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', CAST(N'2020-10-26T21:58:50.9556490' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', NULL, NULL, 73, CAST(N'2020-10-26T17:58:50.9493350' AS DateTime2), NULL, NULL, NULL, CAST(131313.00 AS Decimal(12, 2)), 1, CAST(19696.95 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[Payments] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [LotterySaleId], [Date], [Remarks], [ReceivedAmount], [DevolvedAmount], [Amountx], [Type], [ComissionAmount], [SupervisorAmount]) VALUES (69, NULL, 0, CAST(N'2020-10-26T22:23:51.0964080' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', CAST(N'2020-10-26T22:23:51.0964080' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', NULL, NULL, 74, CAST(N'2020-10-26T18:23:51.0671360' AS DateTime2), NULL, NULL, NULL, CAST(2333.00 AS Decimal(12, 2)), 1, CAST(349.95 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[Payments] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [LotterySaleId], [Date], [Remarks], [ReceivedAmount], [DevolvedAmount], [Amountx], [Type], [ComissionAmount], [SupervisorAmount]) VALUES (70, NULL, 0, CAST(N'2020-10-26T22:25:10.0788320' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', CAST(N'2020-10-26T22:25:10.0788320' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', NULL, NULL, 75, CAST(N'2020-10-26T18:25:10.0726180' AS DateTime2), NULL, NULL, NULL, CAST(3434.00 AS Decimal(12, 2)), 1, CAST(515.10 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[Payments] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [LotterySaleId], [Date], [Remarks], [ReceivedAmount], [DevolvedAmount], [Amountx], [Type], [ComissionAmount], [SupervisorAmount]) VALUES (71, NULL, 0, CAST(N'2020-10-27T04:32:48.7447660' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', CAST(N'2020-10-27T04:32:48.7447660' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', NULL, NULL, 76, CAST(N'2020-10-27T00:32:48.7127820' AS DateTime2), NULL, NULL, NULL, CAST(56.00 AS Decimal(12, 2)), 1, CAST(8.40 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[Payments] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [LotterySaleId], [Date], [Remarks], [ReceivedAmount], [DevolvedAmount], [Amountx], [Type], [ComissionAmount], [SupervisorAmount]) VALUES (72, NULL, 0, CAST(N'2020-10-27T04:33:09.5831840' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', CAST(N'2020-10-27T04:33:09.5831840' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', NULL, NULL, 77, CAST(N'2020-10-27T00:33:09.5749560' AS DateTime2), NULL, NULL, NULL, CAST(5.00 AS Decimal(12, 2)), 1, CAST(0.75 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[Payments] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [LotterySaleId], [Date], [Remarks], [ReceivedAmount], [DevolvedAmount], [Amountx], [Type], [ComissionAmount], [SupervisorAmount]) VALUES (73, NULL, 0, CAST(N'2020-11-03T17:23:34.9222330' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', CAST(N'2020-11-03T17:23:34.9222330' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', NULL, NULL, 78, CAST(N'2020-11-03T13:23:34.8915910' AS DateTime2), NULL, NULL, NULL, CAST(1000.00 AS Decimal(12, 2)), 1, CAST(150.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[Payments] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [LotterySaleId], [Date], [Remarks], [ReceivedAmount], [DevolvedAmount], [Amountx], [Type], [ComissionAmount], [SupervisorAmount]) VALUES (74, NULL, 0, CAST(N'2020-11-03T17:24:01.4755230' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', CAST(N'2020-11-03T17:24:01.4755230' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', NULL, NULL, 79, CAST(N'2020-11-03T13:24:01.4692760' AS DateTime2), NULL, NULL, NULL, CAST(34534.00 AS Decimal(12, 2)), 1, CAST(5180.10 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[Payments] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [LotterySaleId], [Date], [Remarks], [ReceivedAmount], [DevolvedAmount], [Amountx], [Type], [ComissionAmount], [SupervisorAmount]) VALUES (75, NULL, 0, CAST(N'2020-11-03T17:24:52.7591780' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', CAST(N'2020-11-03T17:24:52.7591780' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', NULL, NULL, 80, CAST(N'2020-11-03T13:24:52.7533240' AS DateTime2), NULL, NULL, NULL, CAST(2835.00 AS Decimal(12, 2)), 1, CAST(425.25 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[Payments] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [LotterySaleId], [Date], [Remarks], [ReceivedAmount], [DevolvedAmount], [Amountx], [Type], [ComissionAmount], [SupervisorAmount]) VALUES (76, NULL, 0, CAST(N'2020-11-03T17:25:11.4215400' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', CAST(N'2020-11-03T17:25:11.4215400' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', NULL, NULL, 81, CAST(N'2020-11-03T13:25:11.4160530' AS DateTime2), NULL, NULL, NULL, CAST(234234.00 AS Decimal(12, 2)), 1, CAST(35135.10 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[Payments] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [LotterySaleId], [Date], [Remarks], [ReceivedAmount], [DevolvedAmount], [Amountx], [Type], [ComissionAmount], [SupervisorAmount]) VALUES (77, NULL, 0, CAST(N'2020-11-03T17:25:20.4663290' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', CAST(N'2020-11-03T17:25:20.4663290' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', NULL, NULL, 82, CAST(N'2020-11-03T13:25:20.4612020' AS DateTime2), NULL, NULL, NULL, CAST(234243.00 AS Decimal(12, 2)), 1, CAST(35136.45 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[Payments] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [LotterySaleId], [Date], [Remarks], [ReceivedAmount], [DevolvedAmount], [Amountx], [Type], [ComissionAmount], [SupervisorAmount]) VALUES (78, NULL, 0, CAST(N'2020-11-03T17:25:31.4012190' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', CAST(N'2020-11-03T17:25:31.4012190' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', NULL, NULL, 83, CAST(N'2020-11-03T13:25:31.3965210' AS DateTime2), NULL, NULL, NULL, CAST(2344.00 AS Decimal(12, 2)), 1, CAST(351.60 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[Payments] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [LotterySaleId], [Date], [Remarks], [ReceivedAmount], [DevolvedAmount], [Amountx], [Type], [ComissionAmount], [SupervisorAmount]) VALUES (79, NULL, 0, CAST(N'2020-11-04T16:54:31.4806140' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', CAST(N'2020-11-04T16:54:31.4806140' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', NULL, NULL, 84, CAST(N'2020-11-04T12:54:31.4490340' AS DateTime2), NULL, NULL, NULL, CAST(2000.00 AS Decimal(12, 2)), 1, CAST(300.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[Payments] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [LotterySaleId], [Date], [Remarks], [ReceivedAmount], [DevolvedAmount], [Amountx], [Type], [ComissionAmount], [SupervisorAmount]) VALUES (80, NULL, 0, CAST(N'2020-11-04T16:54:47.2559180' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', CAST(N'2020-11-04T16:54:47.2559180' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', NULL, NULL, 85, CAST(N'2020-11-04T12:54:47.2504490' AS DateTime2), NULL, NULL, NULL, CAST(123.00 AS Decimal(12, 2)), 1, CAST(18.45 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[Payments] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [LotterySaleId], [Date], [Remarks], [ReceivedAmount], [DevolvedAmount], [Amountx], [Type], [ComissionAmount], [SupervisorAmount]) VALUES (81, NULL, 0, CAST(N'2020-11-04T16:54:55.4876820' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', CAST(N'2020-11-04T16:54:55.4876820' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', NULL, NULL, 86, CAST(N'2020-11-04T12:54:55.4824830' AS DateTime2), NULL, NULL, NULL, CAST(123.00 AS Decimal(12, 2)), 1, CAST(18.45 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[Payments] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [LotterySaleId], [Date], [Remarks], [ReceivedAmount], [DevolvedAmount], [Amountx], [Type], [ComissionAmount], [SupervisorAmount]) VALUES (82, NULL, 0, CAST(N'2020-11-04T16:55:05.6726920' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', CAST(N'2020-11-04T16:55:05.6726920' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', NULL, NULL, 87, CAST(N'2020-11-04T12:55:05.6671310' AS DateTime2), NULL, NULL, NULL, CAST(1222.00 AS Decimal(12, 2)), 1, CAST(183.30 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[Payments] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [LotterySaleId], [Date], [Remarks], [ReceivedAmount], [DevolvedAmount], [Amountx], [Type], [ComissionAmount], [SupervisorAmount]) VALUES (83, NULL, 1, CAST(N'2020-11-04T16:55:15.3641700' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', CAST(N'2020-11-04T22:37:55.7726870' AS DateTime2), N'74dffedd-b38f-40a4-9806-0bda7b3277f5', NULL, NULL, 88, CAST(N'2020-11-04T12:55:15.3601650' AS DateTime2), NULL, NULL, NULL, CAST(232.00 AS Decimal(12, 2)), 1, CAST(34.80 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[Payments] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [LotterySaleId], [Date], [Remarks], [ReceivedAmount], [DevolvedAmount], [Amountx], [Type], [ComissionAmount], [SupervisorAmount]) VALUES (84, NULL, 0, CAST(N'2020-11-04T16:55:24.7950900' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', CAST(N'2020-11-04T16:55:24.7950900' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', NULL, NULL, 89, CAST(N'2020-11-04T12:55:24.7898480' AS DateTime2), NULL, NULL, NULL, CAST(234.00 AS Decimal(12, 2)), 1, CAST(35.10 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[Payments] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [LotterySaleId], [Date], [Remarks], [ReceivedAmount], [DevolvedAmount], [Amountx], [Type], [ComissionAmount], [SupervisorAmount]) VALUES (85, NULL, 0, CAST(N'2020-11-04T16:55:31.8534640' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', CAST(N'2020-11-04T16:55:31.8534640' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', NULL, NULL, 90, CAST(N'2020-11-04T12:55:31.8493140' AS DateTime2), NULL, NULL, NULL, CAST(234.00 AS Decimal(12, 2)), 1, CAST(35.10 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[Payments] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [LotterySaleId], [Date], [Remarks], [ReceivedAmount], [DevolvedAmount], [Amountx], [Type], [ComissionAmount], [SupervisorAmount]) VALUES (86, NULL, 0, CAST(N'2020-11-04T16:55:41.6268330' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', CAST(N'2020-11-04T16:55:41.6268330' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', NULL, NULL, 91, CAST(N'2020-11-04T12:55:41.6228040' AS DateTime2), NULL, NULL, NULL, CAST(23.00 AS Decimal(12, 2)), 1, CAST(3.45 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[Payments] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [LotterySaleId], [Date], [Remarks], [ReceivedAmount], [DevolvedAmount], [Amountx], [Type], [ComissionAmount], [SupervisorAmount]) VALUES (87, NULL, 0, CAST(N'2020-11-04T16:55:49.6853810' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', CAST(N'2020-11-04T16:55:49.6853810' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', NULL, NULL, 92, CAST(N'2020-11-04T12:55:49.6810950' AS DateTime2), NULL, NULL, NULL, CAST(2344.00 AS Decimal(12, 2)), 1, CAST(351.60 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[Payments] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [LotterySaleId], [Date], [Remarks], [ReceivedAmount], [DevolvedAmount], [Amountx], [Type], [ComissionAmount], [SupervisorAmount]) VALUES (88, NULL, 0, CAST(N'2020-11-04T16:56:04.8360730' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', CAST(N'2020-11-04T16:56:04.8360730' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', NULL, NULL, 93, CAST(N'2020-11-04T12:56:04.8315770' AS DateTime2), NULL, NULL, NULL, CAST(2423.00 AS Decimal(12, 2)), 1, CAST(363.45 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[Payments] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [LotterySaleId], [Date], [Remarks], [ReceivedAmount], [DevolvedAmount], [Amountx], [Type], [ComissionAmount], [SupervisorAmount]) VALUES (89, NULL, 0, CAST(N'2020-11-04T16:56:14.2677370' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', CAST(N'2020-11-04T16:56:14.2677370' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', NULL, NULL, 94, CAST(N'2020-11-04T12:56:14.2639550' AS DateTime2), NULL, NULL, NULL, CAST(234.00 AS Decimal(12, 2)), 1, CAST(35.10 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[Payments] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [LotterySaleId], [Date], [Remarks], [ReceivedAmount], [DevolvedAmount], [Amountx], [Type], [ComissionAmount], [SupervisorAmount]) VALUES (90, NULL, 0, CAST(N'2020-11-04T16:56:54.4790140' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', CAST(N'2020-11-04T16:56:54.4790140' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', NULL, NULL, 95, CAST(N'2020-11-04T12:56:54.4743240' AS DateTime2), NULL, NULL, NULL, CAST(123.00 AS Decimal(12, 2)), 1, CAST(18.45 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[Payments] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [LotterySaleId], [Date], [Remarks], [ReceivedAmount], [DevolvedAmount], [Amountx], [Type], [ComissionAmount], [SupervisorAmount]) VALUES (91, NULL, 0, CAST(N'2020-11-04T21:50:27.0245983' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', CAST(N'2020-11-04T21:50:27.0245983' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', NULL, NULL, 96, CAST(N'2020-11-04T17:50:26.9559693' AS DateTime2), NULL, NULL, NULL, CAST(12.00 AS Decimal(12, 2)), 1, CAST(1.80 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[Payments] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [LotterySaleId], [Date], [Remarks], [ReceivedAmount], [DevolvedAmount], [Amountx], [Type], [ComissionAmount], [SupervisorAmount]) VALUES (92, NULL, 0, CAST(N'2020-11-04T21:50:39.9948660' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', CAST(N'2020-11-04T21:50:39.9948660' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', NULL, NULL, 97, CAST(N'2020-11-04T17:50:39.9849195' AS DateTime2), NULL, NULL, NULL, CAST(344.00 AS Decimal(12, 2)), 1, CAST(51.60 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[Payments] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [LotterySaleId], [Date], [Remarks], [ReceivedAmount], [DevolvedAmount], [Amountx], [Type], [ComissionAmount], [SupervisorAmount]) VALUES (93, NULL, 0, CAST(N'2020-11-05T00:50:15.4901371' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', CAST(N'2020-11-05T00:50:15.4901371' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', NULL, NULL, 98, CAST(N'2020-11-04T20:50:15.4083876' AS DateTime2), NULL, NULL, NULL, CAST(3000.00 AS Decimal(12, 2)), 1, CAST(450.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[Payments] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [LotterySaleId], [Date], [Remarks], [ReceivedAmount], [DevolvedAmount], [Amountx], [Type], [ComissionAmount], [SupervisorAmount]) VALUES (94, NULL, 0, CAST(N'2020-11-06T15:54:13.9166600' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', CAST(N'2020-11-06T15:54:13.9166600' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', NULL, NULL, 99, CAST(N'2020-11-06T11:54:13.8427088' AS DateTime2), NULL, NULL, NULL, CAST(7000.00 AS Decimal(12, 2)), 1, CAST(1050.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[Payments] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [LotterySaleId], [Date], [Remarks], [ReceivedAmount], [DevolvedAmount], [Amountx], [Type], [ComissionAmount], [SupervisorAmount]) VALUES (95, NULL, 0, CAST(N'2020-11-06T16:01:20.8841288' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', CAST(N'2020-11-06T16:01:20.8841288' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', NULL, NULL, 100, CAST(N'2020-11-06T12:01:20.8738451' AS DateTime2), NULL, NULL, NULL, CAST(4000.00 AS Decimal(12, 2)), 1, CAST(600.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[Payments] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [LotterySaleId], [Date], [Remarks], [ReceivedAmount], [DevolvedAmount], [Amountx], [Type], [ComissionAmount], [SupervisorAmount]) VALUES (96, NULL, 0, CAST(N'2020-11-11T12:14:14.3987733' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', CAST(N'2020-11-11T12:14:14.3987733' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', NULL, NULL, 101, CAST(N'2020-11-11T08:14:14.3281802' AS DateTime2), NULL, NULL, NULL, CAST(9000.00 AS Decimal(12, 2)), 1, CAST(1350.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[Payments] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [LotterySaleId], [Date], [Remarks], [ReceivedAmount], [DevolvedAmount], [Amountx], [Type], [ComissionAmount], [SupervisorAmount]) VALUES (97, NULL, 0, CAST(N'2020-11-17T19:33:47.8693330' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', CAST(N'2020-11-17T19:33:47.8693330' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', NULL, NULL, 102, CAST(N'2020-11-17T15:33:47.8374840' AS DateTime2), NULL, NULL, NULL, CAST(400.00 AS Decimal(12, 2)), 1, CAST(60.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[Payments] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [LotterySaleId], [Date], [Remarks], [ReceivedAmount], [DevolvedAmount], [Amountx], [Type], [ComissionAmount], [SupervisorAmount]) VALUES (98, NULL, 0, CAST(N'2020-11-17T19:34:02.5481590' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', CAST(N'2020-11-17T19:34:02.5481590' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', NULL, NULL, 103, CAST(N'2020-11-17T15:34:02.5423620' AS DateTime2), NULL, NULL, NULL, CAST(100.00 AS Decimal(12, 2)), 1, CAST(15.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[Payments] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [LotterySaleId], [Date], [Remarks], [ReceivedAmount], [DevolvedAmount], [Amountx], [Type], [ComissionAmount], [SupervisorAmount]) VALUES (99, NULL, 0, CAST(N'2020-11-17T19:34:50.9100160' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', CAST(N'2020-11-17T19:34:50.9100160' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', NULL, NULL, 104, CAST(N'2020-11-17T15:34:50.9047870' AS DateTime2), NULL, NULL, NULL, CAST(2436.00 AS Decimal(12, 2)), 1, CAST(365.40 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[Payments] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [LotterySaleId], [Date], [Remarks], [ReceivedAmount], [DevolvedAmount], [Amountx], [Type], [ComissionAmount], [SupervisorAmount]) VALUES (100, NULL, 0, CAST(N'2020-11-17T19:35:10.2107920' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', CAST(N'2020-11-17T19:35:10.2107920' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', NULL, NULL, 105, CAST(N'2020-11-17T15:35:10.2060640' AS DateTime2), NULL, NULL, NULL, CAST(200.00 AS Decimal(12, 2)), 1, CAST(30.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[Payments] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [LotterySaleId], [Date], [Remarks], [ReceivedAmount], [DevolvedAmount], [Amountx], [Type], [ComissionAmount], [SupervisorAmount]) VALUES (101, NULL, 0, CAST(N'2020-11-17T19:35:38.0410670' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', CAST(N'2020-11-17T19:35:38.0410670' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', NULL, NULL, 106, CAST(N'2020-11-17T15:35:38.0362300' AS DateTime2), NULL, NULL, NULL, CAST(23524.00 AS Decimal(12, 2)), 1, CAST(3528.60 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[Payments] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [LotterySaleId], [Date], [Remarks], [ReceivedAmount], [DevolvedAmount], [Amountx], [Type], [ComissionAmount], [SupervisorAmount]) VALUES (102, NULL, 0, CAST(N'2020-11-17T19:36:00.7067770' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', CAST(N'2020-11-17T19:36:00.7067770' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', NULL, NULL, 107, CAST(N'2020-11-17T15:36:00.7014240' AS DateTime2), NULL, NULL, NULL, CAST(3645.00 AS Decimal(12, 2)), 1, CAST(546.75 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[Payments] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [LotterySaleId], [Date], [Remarks], [ReceivedAmount], [DevolvedAmount], [Amountx], [Type], [ComissionAmount], [SupervisorAmount]) VALUES (103, NULL, 0, CAST(N'2020-11-17T19:36:36.9666440' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', CAST(N'2020-11-17T19:36:36.9666440' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', NULL, NULL, 108, CAST(N'2020-11-17T15:36:36.9617240' AS DateTime2), NULL, NULL, NULL, CAST(200.00 AS Decimal(12, 2)), 1, CAST(30.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[Payments] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [LotterySaleId], [Date], [Remarks], [ReceivedAmount], [DevolvedAmount], [Amountx], [Type], [ComissionAmount], [SupervisorAmount]) VALUES (104, NULL, 0, CAST(N'2020-12-09T17:35:01.9440957' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', CAST(N'2020-12-09T17:35:01.9440957' AS DateTime2), N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', NULL, NULL, 109, CAST(N'2020-12-09T13:35:01.9014005' AS DateTime2), NULL, NULL, NULL, CAST(1000.00 AS Decimal(12, 2)), 1, CAST(150.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)))
GO
SET IDENTITY_INSERT [dbo].[Payments] OFF
GO
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
GO
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
GO
SET IDENTITY_INSERT [dbo].[Plans] ON 
GO
INSERT [dbo].[Plans] ([Id], [Name], [Amount], [CurrencyId], [PeriodicityId], [Megabytes], [UserPosibility], [RegiterCount]) VALUES (1, N'Basico', CAST(10.00 AS Decimal(12, 2)), 1, 11, 5, 5, 500)
GO
INSERT [dbo].[Plans] ([Id], [Name], [Amount], [CurrencyId], [PeriodicityId], [Megabytes], [UserPosibility], [RegiterCount]) VALUES (4, N'Plan Avanzado', CAST(500.00 AS Decimal(12, 2)), 1, 11, 1012, 25, 250000)
GO
SET IDENTITY_INSERT [dbo].[Plans] OFF
GO
SET IDENTITY_INSERT [dbo].[PlanTransactions] ON 
GO
INSERT [dbo].[PlanTransactions] ([Id], [Name], [Amount], [Date], [Megabytes], [Registers], [UserPosibility], [CurrencyId], [PaymentTypeId], [OwnerPlanId]) VALUES (1, NULL, CAST(10.00 AS Decimal(12, 2)), CAST(N'2020-07-03T01:02:57.0263626' AS DateTime2), 5, 500, 5, 1, 1, 1)
GO
SET IDENTITY_INSERT [dbo].[PlanTransactions] OFF
GO
SET IDENTITY_INSERT [dbo].[PrizePayments] ON 
GO
INSERT [dbo].[PrizePayments] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [Amount], [Date], [SellerId], [UseSupervisorAmount], [PreviousSupervisorAmount]) VALUES (1, NULL, 0, CAST(N'2020-10-21T20:50:14.3606750' AS DateTime2), N'74dffedd-b38f-40a4-9806-0bda7b3277f5', CAST(N'2020-10-21T20:50:14.3606750' AS DateTime2), N'74dffedd-b38f-40a4-9806-0bda7b3277f5', NULL, NULL, CAST(1000.00 AS Decimal(12, 2)), NULL, N'74dffedd-b38f-40a4-9806-0bda7b3277f5', 0, CAST(0.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[PrizePayments] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [Amount], [Date], [SellerId], [UseSupervisorAmount], [PreviousSupervisorAmount]) VALUES (2, NULL, 0, CAST(N'2020-11-04T20:23:41.8262450' AS DateTime2), N'74dffedd-b38f-40a4-9806-0bda7b3277f5', CAST(N'2020-11-04T20:23:41.8262450' AS DateTime2), N'74dffedd-b38f-40a4-9806-0bda7b3277f5', NULL, NULL, CAST(17000.00 AS Decimal(12, 2)), NULL, N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', 0, CAST(0.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[PrizePayments] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [Amount], [Date], [SellerId], [UseSupervisorAmount], [PreviousSupervisorAmount]) VALUES (3, NULL, 0, CAST(N'2020-11-04T20:36:54.8322250' AS DateTime2), N'74dffedd-b38f-40a4-9806-0bda7b3277f5', CAST(N'2020-11-04T20:36:54.8322250' AS DateTime2), N'74dffedd-b38f-40a4-9806-0bda7b3277f5', NULL, NULL, CAST(800.00 AS Decimal(12, 2)), NULL, N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', 0, CAST(0.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[PrizePayments] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [Amount], [Date], [SellerId], [UseSupervisorAmount], [PreviousSupervisorAmount]) VALUES (4, NULL, 0, CAST(N'2020-11-04T20:44:57.1012870' AS DateTime2), N'74dffedd-b38f-40a4-9806-0bda7b3277f5', CAST(N'2020-11-04T20:44:57.1012870' AS DateTime2), N'74dffedd-b38f-40a4-9806-0bda7b3277f5', NULL, NULL, CAST(233.00 AS Decimal(12, 2)), NULL, N'74dffedd-b38f-40a4-9806-0bda7b3277f5', 0, CAST(0.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[PrizePayments] ([Id], [Name], [Deleted], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [DeletedBy], [Amount], [Date], [SellerId], [UseSupervisorAmount], [PreviousSupervisorAmount]) VALUES (5, NULL, 0, CAST(N'2020-11-05T01:01:58.3011260' AS DateTime2), N'74dffedd-b38f-40a4-9806-0bda7b3277f5', CAST(N'2020-11-05T01:01:58.3011260' AS DateTime2), N'74dffedd-b38f-40a4-9806-0bda7b3277f5', NULL, NULL, CAST(1200.00 AS Decimal(12, 2)), NULL, N'6fdc0ce8-4415-4576-b8c1-2b35c275011e', 0, CAST(0.00 AS Decimal(18, 2)))
GO
SET IDENTITY_INSERT [dbo].[PrizePayments] OFF
GO
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
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_AspNetRoleClaims_RoleId]    Script Date: 12/9/2020 1:41:21 PM ******/
CREATE NONCLUSTERED INDEX [IX_AspNetRoleClaims_RoleId] ON [dbo].[AspNetRoleClaims]
(
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [RoleNameIndex]    Script Date: 12/9/2020 1:41:21 PM ******/
CREATE UNIQUE NONCLUSTERED INDEX [RoleNameIndex] ON [dbo].[AspNetRoles]
(
	[NormalizedName] ASC
)
WHERE ([NormalizedName] IS NOT NULL)
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_AspNetUserClaims_UserId]    Script Date: 12/9/2020 1:41:21 PM ******/
CREATE NONCLUSTERED INDEX [IX_AspNetUserClaims_UserId] ON [dbo].[AspNetUserClaims]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_AspNetUserLogins_UserId]    Script Date: 12/9/2020 1:41:21 PM ******/
CREATE NONCLUSTERED INDEX [IX_AspNetUserLogins_UserId] ON [dbo].[AspNetUserLogins]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_AspNetUserRoles_RoleId]    Script Date: 12/9/2020 1:41:21 PM ******/
CREATE NONCLUSTERED INDEX [IX_AspNetUserRoles_RoleId] ON [dbo].[AspNetUserRoles]
(
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [EmailIndex]    Script Date: 12/9/2020 1:41:21 PM ******/
CREATE NONCLUSTERED INDEX [EmailIndex] ON [dbo].[AspNetUsers]
(
	[NormalizedEmail] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_AspNetUsers_OwnerId]    Script Date: 12/9/2020 1:41:21 PM ******/
CREATE NONCLUSTERED INDEX [IX_AspNetUsers_OwnerId] ON [dbo].[AspNetUsers]
(
	[OwnerId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UserNameIndex]    Script Date: 12/9/2020 1:41:21 PM ******/
CREATE UNIQUE NONCLUSTERED INDEX [UserNameIndex] ON [dbo].[AspNetUsers]
(
	[NormalizedUserName] ASC
)
WHERE ([NormalizedUserName] IS NOT NULL)
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Lotteries_LotteryFromId]    Script Date: 12/9/2020 1:41:21 PM ******/
CREATE NONCLUSTERED INDEX [IX_Lotteries_LotteryFromId] ON [dbo].[Lotteries]
(
	[LotteryFromId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_LotteryResults_CreatedBy]    Script Date: 12/9/2020 1:41:21 PM ******/
CREATE NONCLUSTERED INDEX [IX_LotteryResults_CreatedBy] ON [dbo].[LotteryResults]
(
	[CreatedBy] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_LotteryResults_DeletedBy]    Script Date: 12/9/2020 1:41:21 PM ******/
CREATE NONCLUSTERED INDEX [IX_LotteryResults_DeletedBy] ON [dbo].[LotteryResults]
(
	[DeletedBy] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_LotteryResults_LotteryId]    Script Date: 12/9/2020 1:41:21 PM ******/
CREATE NONCLUSTERED INDEX [IX_LotteryResults_LotteryId] ON [dbo].[LotteryResults]
(
	[LotteryId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_LotteryResults_UpdatedBy]    Script Date: 12/9/2020 1:41:21 PM ******/
CREATE NONCLUSTERED INDEX [IX_LotteryResults_UpdatedBy] ON [dbo].[LotteryResults]
(
	[UpdatedBy] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_LotterySaleItems_CreatedBy]    Script Date: 12/9/2020 1:41:21 PM ******/
CREATE NONCLUSTERED INDEX [IX_LotterySaleItems_CreatedBy] ON [dbo].[LotterySaleItems]
(
	[CreatedBy] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_LotterySaleItems_DeletedBy]    Script Date: 12/9/2020 1:41:21 PM ******/
CREATE NONCLUSTERED INDEX [IX_LotterySaleItems_DeletedBy] ON [dbo].[LotterySaleItems]
(
	[DeletedBy] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_LotterySaleItems_LotteryId]    Script Date: 12/9/2020 1:41:21 PM ******/
CREATE NONCLUSTERED INDEX [IX_LotterySaleItems_LotteryId] ON [dbo].[LotterySaleItems]
(
	[LotteryId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_LotterySaleItems_LotteryModeId]    Script Date: 12/9/2020 1:41:21 PM ******/
CREATE NONCLUSTERED INDEX [IX_LotterySaleItems_LotteryModeId] ON [dbo].[LotterySaleItems]
(
	[LotteryModeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_LotterySaleItems_LotterySaleId]    Script Date: 12/9/2020 1:41:21 PM ******/
CREATE NONCLUSTERED INDEX [IX_LotterySaleItems_LotterySaleId] ON [dbo].[LotterySaleItems]
(
	[LotterySaleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_LotterySaleItems_UpdatedBy]    Script Date: 12/9/2020 1:41:21 PM ******/
CREATE NONCLUSTERED INDEX [IX_LotterySaleItems_UpdatedBy] ON [dbo].[LotterySaleItems]
(
	[UpdatedBy] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_LotterySales_CreatedBy]    Script Date: 12/9/2020 1:41:21 PM ******/
CREATE NONCLUSTERED INDEX [IX_LotterySales_CreatedBy] ON [dbo].[LotterySales]
(
	[CreatedBy] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_LotterySales_DeletedBy]    Script Date: 12/9/2020 1:41:21 PM ******/
CREATE NONCLUSTERED INDEX [IX_LotterySales_DeletedBy] ON [dbo].[LotterySales]
(
	[DeletedBy] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_LotterySales_UpdatedBy]    Script Date: 12/9/2020 1:41:21 PM ******/
CREATE NONCLUSTERED INDEX [IX_LotterySales_UpdatedBy] ON [dbo].[LotterySales]
(
	[UpdatedBy] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_LotterySchedules_CreatedBy]    Script Date: 12/9/2020 1:41:21 PM ******/
CREATE NONCLUSTERED INDEX [IX_LotterySchedules_CreatedBy] ON [dbo].[LotterySchedules]
(
	[CreatedBy] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_LotterySchedules_DeletedBy]    Script Date: 12/9/2020 1:41:21 PM ******/
CREATE NONCLUSTERED INDEX [IX_LotterySchedules_DeletedBy] ON [dbo].[LotterySchedules]
(
	[DeletedBy] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_LotterySchedules_LotteryId]    Script Date: 12/9/2020 1:41:21 PM ******/
CREATE NONCLUSTERED INDEX [IX_LotterySchedules_LotteryId] ON [dbo].[LotterySchedules]
(
	[LotteryId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_LotterySchedules_UpdatedBy]    Script Date: 12/9/2020 1:41:21 PM ******/
CREATE NONCLUSTERED INDEX [IX_LotterySchedules_UpdatedBy] ON [dbo].[LotterySchedules]
(
	[UpdatedBy] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Options_OptionModuleId]    Script Date: 12/9/2020 1:41:21 PM ******/
CREATE NONCLUSTERED INDEX [IX_Options_OptionModuleId] ON [dbo].[Options]
(
	[OptionModuleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Options_PlanId]    Script Date: 12/9/2020 1:41:21 PM ******/
CREATE NONCLUSTERED INDEX [IX_Options_PlanId] ON [dbo].[Options]
(
	[PlanId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_OwnerPlans_OwnerId]    Script Date: 12/9/2020 1:41:21 PM ******/
CREATE NONCLUSTERED INDEX [IX_OwnerPlans_OwnerId] ON [dbo].[OwnerPlans]
(
	[OwnerId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_OwnerPlans_PlanId]    Script Date: 12/9/2020 1:41:21 PM ******/
CREATE NONCLUSTERED INDEX [IX_OwnerPlans_PlanId] ON [dbo].[OwnerPlans]
(
	[PlanId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Owners_OwnerTypeId]    Script Date: 12/9/2020 1:41:21 PM ******/
CREATE NONCLUSTERED INDEX [IX_Owners_OwnerTypeId] ON [dbo].[Owners]
(
	[OwnerTypeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_Payments_CreatedBy]    Script Date: 12/9/2020 1:41:21 PM ******/
CREATE NONCLUSTERED INDEX [IX_Payments_CreatedBy] ON [dbo].[Payments]
(
	[CreatedBy] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_Payments_DeletedBy]    Script Date: 12/9/2020 1:41:21 PM ******/
CREATE NONCLUSTERED INDEX [IX_Payments_DeletedBy] ON [dbo].[Payments]
(
	[DeletedBy] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Payments_LotterySaleId]    Script Date: 12/9/2020 1:41:21 PM ******/
CREATE NONCLUSTERED INDEX [IX_Payments_LotterySaleId] ON [dbo].[Payments]
(
	[LotterySaleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_Payments_UpdatedBy]    Script Date: 12/9/2020 1:41:21 PM ******/
CREATE NONCLUSTERED INDEX [IX_Payments_UpdatedBy] ON [dbo].[Payments]
(
	[UpdatedBy] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_PlanOption_OptionId]    Script Date: 12/9/2020 1:41:21 PM ******/
CREATE NONCLUSTERED INDEX [IX_PlanOption_OptionId] ON [dbo].[PlanOption]
(
	[OptionId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_PlanOption_OptionModuleId]    Script Date: 12/9/2020 1:41:21 PM ******/
CREATE NONCLUSTERED INDEX [IX_PlanOption_OptionModuleId] ON [dbo].[PlanOption]
(
	[OptionModuleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_PlanOption_PlanId]    Script Date: 12/9/2020 1:41:21 PM ******/
CREATE NONCLUSTERED INDEX [IX_PlanOption_PlanId] ON [dbo].[PlanOption]
(
	[PlanId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Plans_CurrencyId]    Script Date: 12/9/2020 1:41:21 PM ******/
CREATE NONCLUSTERED INDEX [IX_Plans_CurrencyId] ON [dbo].[Plans]
(
	[CurrencyId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Plans_PeriodicityId]    Script Date: 12/9/2020 1:41:21 PM ******/
CREATE NONCLUSTERED INDEX [IX_Plans_PeriodicityId] ON [dbo].[Plans]
(
	[PeriodicityId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_PlanTransactions_CurrencyId]    Script Date: 12/9/2020 1:41:21 PM ******/
CREATE NONCLUSTERED INDEX [IX_PlanTransactions_CurrencyId] ON [dbo].[PlanTransactions]
(
	[CurrencyId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_PlanTransactions_OwnerPlanId]    Script Date: 12/9/2020 1:41:21 PM ******/
CREATE NONCLUSTERED INDEX [IX_PlanTransactions_OwnerPlanId] ON [dbo].[PlanTransactions]
(
	[OwnerPlanId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_PlanTransactions_PaymentTypeId]    Script Date: 12/9/2020 1:41:21 PM ******/
CREATE NONCLUSTERED INDEX [IX_PlanTransactions_PaymentTypeId] ON [dbo].[PlanTransactions]
(
	[PaymentTypeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_PrizePayments_CreatedBy]    Script Date: 12/9/2020 1:41:21 PM ******/
CREATE NONCLUSTERED INDEX [IX_PrizePayments_CreatedBy] ON [dbo].[PrizePayments]
(
	[CreatedBy] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_PrizePayments_DeletedBy]    Script Date: 12/9/2020 1:41:21 PM ******/
CREATE NONCLUSTERED INDEX [IX_PrizePayments_DeletedBy] ON [dbo].[PrizePayments]
(
	[DeletedBy] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_PrizePayments_SellerId]    Script Date: 12/9/2020 1:41:21 PM ******/
CREATE NONCLUSTERED INDEX [IX_PrizePayments_SellerId] ON [dbo].[PrizePayments]
(
	[SellerId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_PrizePayments_UpdatedBy]    Script Date: 12/9/2020 1:41:21 PM ******/
CREATE NONCLUSTERED INDEX [IX_PrizePayments_UpdatedBy] ON [dbo].[PrizePayments]
(
	[UpdatedBy] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[AspNetUsers] ADD  DEFAULT ((0)) FOR [ComissionSupervisor]
GO
ALTER TABLE [dbo].[AspNetUsers] ADD  DEFAULT (CONVERT([bit],(0))) FOR [IsAdmin]
GO
ALTER TABLE [dbo].[AspNetUsers] ADD  DEFAULT (CONVERT([bit],(0))) FOR [IsCobrator]
GO
ALTER TABLE [dbo].[AspNetUsers] ADD  DEFAULT (CONVERT([bit],(0))) FOR [IsOperator]
GO
ALTER TABLE [dbo].[AspNetUsers] ADD  DEFAULT (CONVERT([bit],(0))) FOR [IsSeller]
GO
ALTER TABLE [dbo].[AspNetUsers] ADD  DEFAULT (CONVERT([bit],(0))) FOR [IsSupervisor]
GO
ALTER TABLE [dbo].[AspNetUsers] ADD  DEFAULT (CONVERT([bit],(0))) FOR [TakeCommision]
GO
ALTER TABLE [dbo].[AspNetUsers] ADD  DEFAULT (CONVERT([bit],(0))) FOR [IsDisabled]
GO
ALTER TABLE [dbo].[Lotteries] ADD  DEFAULT ((0.0)) FOR [Loto1First]
GO
ALTER TABLE [dbo].[Lotteries] ADD  DEFAULT ((0.0)) FOR [Loto1Second]
GO
ALTER TABLE [dbo].[Lotteries] ADD  DEFAULT ((0.0)) FOR [Loto1Third]
GO
ALTER TABLE [dbo].[Lotteries] ADD  DEFAULT ((0.0)) FOR [Loto2First]
GO
ALTER TABLE [dbo].[Lotteries] ADD  DEFAULT ((0.0)) FOR [Loto2Second]
GO
ALTER TABLE [dbo].[Lotteries] ADD  DEFAULT ((0.0)) FOR [Loto3First]
GO
ALTER TABLE [dbo].[Lotteries] ADD  DEFAULT ((0.0)) FOR [Loto3Second]
GO
ALTER TABLE [dbo].[Lotteries] ADD  DEFAULT ((0.0)) FOR [Loto4First]
GO
ALTER TABLE [dbo].[Lotteries] ADD  DEFAULT (CONVERT([bit],(0))) FOR [Available]
GO
ALTER TABLE [dbo].[LotterySaleItems] ADD  DEFAULT ((0.0)) FOR [Prize]
GO
ALTER TABLE [dbo].[LotterySaleItems] ADD  DEFAULT ((0.0)) FOR [Prize1]
GO
ALTER TABLE [dbo].[LotterySaleItems] ADD  DEFAULT ((0.0)) FOR [Prize2]
GO
ALTER TABLE [dbo].[LotterySaleItems] ADD  DEFAULT ((0.0)) FOR [Prize3]
GO
ALTER TABLE [dbo].[LotterySales] ADD  DEFAULT ((0.0)) FOR [Prize]
GO
ALTER TABLE [dbo].[LotterySales] ADD  DEFAULT ((0)) FOR [WasPaid]
GO
ALTER TABLE [dbo].[LotterySales] ADD  DEFAULT (CONVERT([bit],(0))) FOR [Anulated]
GO
ALTER TABLE [dbo].[LotterySales] ADD  DEFAULT (CONVERT([bit],(0))) FOR [Winner]
GO
ALTER TABLE [dbo].[LotterySales] ADD  DEFAULT (CONVERT([bit],(0))) FOR [AnulatedSol]
GO
ALTER TABLE [dbo].[Payments] ADD  DEFAULT (CONVERT([bigint],(0))) FOR [Type]
GO
ALTER TABLE [dbo].[Payments] ADD  DEFAULT ((0.0)) FOR [ComissionAmount]
GO
ALTER TABLE [dbo].[Payments] ADD  DEFAULT ((0.0)) FOR [SupervisorAmount]
GO
ALTER TABLE [dbo].[AspNetRoleClaims]  WITH CHECK ADD  CONSTRAINT [FK_AspNetRoleClaims_AspNetRoles_RoleId] FOREIGN KEY([RoleId])
REFERENCES [dbo].[AspNetRoles] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetRoleClaims] CHECK CONSTRAINT [FK_AspNetRoleClaims_AspNetRoles_RoleId]
GO
ALTER TABLE [dbo].[AspNetUserClaims]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserClaims_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserClaims] CHECK CONSTRAINT [FK_AspNetUserClaims_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUserLogins]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserLogins_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserLogins] CHECK CONSTRAINT [FK_AspNetUserLogins_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUserRoles]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserRoles_AspNetRoles_RoleId] FOREIGN KEY([RoleId])
REFERENCES [dbo].[AspNetRoles] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserRoles] CHECK CONSTRAINT [FK_AspNetUserRoles_AspNetRoles_RoleId]
GO
ALTER TABLE [dbo].[AspNetUserRoles]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserRoles_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserRoles] CHECK CONSTRAINT [FK_AspNetUserRoles_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUsers]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUsers_Owners_OwnerId] FOREIGN KEY([OwnerId])
REFERENCES [dbo].[Owners] ([Id])
GO
ALTER TABLE [dbo].[AspNetUsers] CHECK CONSTRAINT [FK_AspNetUsers_Owners_OwnerId]
GO
ALTER TABLE [dbo].[AspNetUserTokens]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserTokens_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserTokens] CHECK CONSTRAINT [FK_AspNetUserTokens_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[Lotteries]  WITH CHECK ADD  CONSTRAINT [FK_Lotteries_LotteryFroms_LotteryFromId] FOREIGN KEY([LotteryFromId])
REFERENCES [dbo].[LotteryFroms] ([Id])
GO
ALTER TABLE [dbo].[Lotteries] CHECK CONSTRAINT [FK_Lotteries_LotteryFroms_LotteryFromId]
GO
ALTER TABLE [dbo].[LotteryResults]  WITH CHECK ADD  CONSTRAINT [FK_LotteryResults_AspNetUsers_CreatedBy] FOREIGN KEY([CreatedBy])
REFERENCES [dbo].[AspNetUsers] ([Id])
GO
ALTER TABLE [dbo].[LotteryResults] CHECK CONSTRAINT [FK_LotteryResults_AspNetUsers_CreatedBy]
GO
ALTER TABLE [dbo].[LotteryResults]  WITH CHECK ADD  CONSTRAINT [FK_LotteryResults_AspNetUsers_DeletedBy] FOREIGN KEY([DeletedBy])
REFERENCES [dbo].[AspNetUsers] ([Id])
GO
ALTER TABLE [dbo].[LotteryResults] CHECK CONSTRAINT [FK_LotteryResults_AspNetUsers_DeletedBy]
GO
ALTER TABLE [dbo].[LotteryResults]  WITH CHECK ADD  CONSTRAINT [FK_LotteryResults_AspNetUsers_UpdatedBy] FOREIGN KEY([UpdatedBy])
REFERENCES [dbo].[AspNetUsers] ([Id])
GO
ALTER TABLE [dbo].[LotteryResults] CHECK CONSTRAINT [FK_LotteryResults_AspNetUsers_UpdatedBy]
GO
ALTER TABLE [dbo].[LotteryResults]  WITH CHECK ADD  CONSTRAINT [FK_LotteryResults_Lotteries_LotteryId] FOREIGN KEY([LotteryId])
REFERENCES [dbo].[Lotteries] ([Id])
GO
ALTER TABLE [dbo].[LotteryResults] CHECK CONSTRAINT [FK_LotteryResults_Lotteries_LotteryId]
GO
ALTER TABLE [dbo].[LotterySaleItems]  WITH CHECK ADD  CONSTRAINT [FK_LotterySaleItems_AspNetUsers_CreatedBy] FOREIGN KEY([CreatedBy])
REFERENCES [dbo].[AspNetUsers] ([Id])
GO
ALTER TABLE [dbo].[LotterySaleItems] CHECK CONSTRAINT [FK_LotterySaleItems_AspNetUsers_CreatedBy]
GO
ALTER TABLE [dbo].[LotterySaleItems]  WITH CHECK ADD  CONSTRAINT [FK_LotterySaleItems_AspNetUsers_DeletedBy] FOREIGN KEY([DeletedBy])
REFERENCES [dbo].[AspNetUsers] ([Id])
GO
ALTER TABLE [dbo].[LotterySaleItems] CHECK CONSTRAINT [FK_LotterySaleItems_AspNetUsers_DeletedBy]
GO
ALTER TABLE [dbo].[LotterySaleItems]  WITH CHECK ADD  CONSTRAINT [FK_LotterySaleItems_AspNetUsers_UpdatedBy] FOREIGN KEY([UpdatedBy])
REFERENCES [dbo].[AspNetUsers] ([Id])
GO
ALTER TABLE [dbo].[LotterySaleItems] CHECK CONSTRAINT [FK_LotterySaleItems_AspNetUsers_UpdatedBy]
GO
ALTER TABLE [dbo].[LotterySaleItems]  WITH CHECK ADD  CONSTRAINT [FK_LotterySaleItems_Lotteries_LotteryId] FOREIGN KEY([LotteryId])
REFERENCES [dbo].[Lotteries] ([Id])
GO
ALTER TABLE [dbo].[LotterySaleItems] CHECK CONSTRAINT [FK_LotterySaleItems_Lotteries_LotteryId]
GO
ALTER TABLE [dbo].[LotterySaleItems]  WITH CHECK ADD  CONSTRAINT [FK_LotterySaleItems_LotteryModes_LotteryModeId] FOREIGN KEY([LotteryModeId])
REFERENCES [dbo].[LotteryModes] ([Id])
GO
ALTER TABLE [dbo].[LotterySaleItems] CHECK CONSTRAINT [FK_LotterySaleItems_LotteryModes_LotteryModeId]
GO
ALTER TABLE [dbo].[LotterySaleItems]  WITH CHECK ADD  CONSTRAINT [FK_LotterySaleItems_LotterySales_LotterySaleId] FOREIGN KEY([LotterySaleId])
REFERENCES [dbo].[LotterySales] ([Id])
GO
ALTER TABLE [dbo].[LotterySaleItems] CHECK CONSTRAINT [FK_LotterySaleItems_LotterySales_LotterySaleId]
GO
ALTER TABLE [dbo].[LotterySales]  WITH CHECK ADD  CONSTRAINT [FK_LotterySales_AspNetUsers_CreatedBy] FOREIGN KEY([CreatedBy])
REFERENCES [dbo].[AspNetUsers] ([Id])
GO
ALTER TABLE [dbo].[LotterySales] CHECK CONSTRAINT [FK_LotterySales_AspNetUsers_CreatedBy]
GO
ALTER TABLE [dbo].[LotterySales]  WITH CHECK ADD  CONSTRAINT [FK_LotterySales_AspNetUsers_DeletedBy] FOREIGN KEY([DeletedBy])
REFERENCES [dbo].[AspNetUsers] ([Id])
GO
ALTER TABLE [dbo].[LotterySales] CHECK CONSTRAINT [FK_LotterySales_AspNetUsers_DeletedBy]
GO
ALTER TABLE [dbo].[LotterySales]  WITH CHECK ADD  CONSTRAINT [FK_LotterySales_AspNetUsers_UpdatedBy] FOREIGN KEY([UpdatedBy])
REFERENCES [dbo].[AspNetUsers] ([Id])
GO
ALTER TABLE [dbo].[LotterySales] CHECK CONSTRAINT [FK_LotterySales_AspNetUsers_UpdatedBy]
GO
ALTER TABLE [dbo].[LotterySchedules]  WITH CHECK ADD  CONSTRAINT [FK_LotterySchedules_AspNetUsers_CreatedBy] FOREIGN KEY([CreatedBy])
REFERENCES [dbo].[AspNetUsers] ([Id])
GO
ALTER TABLE [dbo].[LotterySchedules] CHECK CONSTRAINT [FK_LotterySchedules_AspNetUsers_CreatedBy]
GO
ALTER TABLE [dbo].[LotterySchedules]  WITH CHECK ADD  CONSTRAINT [FK_LotterySchedules_AspNetUsers_DeletedBy] FOREIGN KEY([DeletedBy])
REFERENCES [dbo].[AspNetUsers] ([Id])
GO
ALTER TABLE [dbo].[LotterySchedules] CHECK CONSTRAINT [FK_LotterySchedules_AspNetUsers_DeletedBy]
GO
ALTER TABLE [dbo].[LotterySchedules]  WITH CHECK ADD  CONSTRAINT [FK_LotterySchedules_AspNetUsers_UpdatedBy] FOREIGN KEY([UpdatedBy])
REFERENCES [dbo].[AspNetUsers] ([Id])
GO
ALTER TABLE [dbo].[LotterySchedules] CHECK CONSTRAINT [FK_LotterySchedules_AspNetUsers_UpdatedBy]
GO
ALTER TABLE [dbo].[LotterySchedules]  WITH CHECK ADD  CONSTRAINT [FK_LotterySchedules_Lotteries_LotteryId] FOREIGN KEY([LotteryId])
REFERENCES [dbo].[Lotteries] ([Id])
GO
ALTER TABLE [dbo].[LotterySchedules] CHECK CONSTRAINT [FK_LotterySchedules_Lotteries_LotteryId]
GO
ALTER TABLE [dbo].[Options]  WITH CHECK ADD  CONSTRAINT [FK_Options_OptionModules_OptionModuleId] FOREIGN KEY([OptionModuleId])
REFERENCES [dbo].[OptionModules] ([Id])
GO
ALTER TABLE [dbo].[Options] CHECK CONSTRAINT [FK_Options_OptionModules_OptionModuleId]
GO
ALTER TABLE [dbo].[Options]  WITH CHECK ADD  CONSTRAINT [FK_Options_Plans_PlanId] FOREIGN KEY([PlanId])
REFERENCES [dbo].[Plans] ([Id])
GO
ALTER TABLE [dbo].[Options] CHECK CONSTRAINT [FK_Options_Plans_PlanId]
GO
ALTER TABLE [dbo].[OwnerPlans]  WITH CHECK ADD  CONSTRAINT [FK_OwnerPlans_Owners_OwnerId] FOREIGN KEY([OwnerId])
REFERENCES [dbo].[Owners] ([Id])
GO
ALTER TABLE [dbo].[OwnerPlans] CHECK CONSTRAINT [FK_OwnerPlans_Owners_OwnerId]
GO
ALTER TABLE [dbo].[OwnerPlans]  WITH CHECK ADD  CONSTRAINT [FK_OwnerPlans_Plans_PlanId] FOREIGN KEY([PlanId])
REFERENCES [dbo].[Plans] ([Id])
GO
ALTER TABLE [dbo].[OwnerPlans] CHECK CONSTRAINT [FK_OwnerPlans_Plans_PlanId]
GO
ALTER TABLE [dbo].[Owners]  WITH CHECK ADD  CONSTRAINT [FK_Owners_OwnerTypes_OwnerTypeId] FOREIGN KEY([OwnerTypeId])
REFERENCES [dbo].[OwnerTypes] ([Id])
GO
ALTER TABLE [dbo].[Owners] CHECK CONSTRAINT [FK_Owners_OwnerTypes_OwnerTypeId]
GO
ALTER TABLE [dbo].[Payments]  WITH CHECK ADD  CONSTRAINT [FK_Payments_AspNetUsers_CreatedBy] FOREIGN KEY([CreatedBy])
REFERENCES [dbo].[AspNetUsers] ([Id])
GO
ALTER TABLE [dbo].[Payments] CHECK CONSTRAINT [FK_Payments_AspNetUsers_CreatedBy]
GO
ALTER TABLE [dbo].[Payments]  WITH CHECK ADD  CONSTRAINT [FK_Payments_AspNetUsers_DeletedBy] FOREIGN KEY([DeletedBy])
REFERENCES [dbo].[AspNetUsers] ([Id])
GO
ALTER TABLE [dbo].[Payments] CHECK CONSTRAINT [FK_Payments_AspNetUsers_DeletedBy]
GO
ALTER TABLE [dbo].[Payments]  WITH CHECK ADD  CONSTRAINT [FK_Payments_AspNetUsers_UpdatedBy] FOREIGN KEY([UpdatedBy])
REFERENCES [dbo].[AspNetUsers] ([Id])
GO
ALTER TABLE [dbo].[Payments] CHECK CONSTRAINT [FK_Payments_AspNetUsers_UpdatedBy]
GO
ALTER TABLE [dbo].[Payments]  WITH CHECK ADD  CONSTRAINT [FK_Payments_LotterySales_LotterySaleId] FOREIGN KEY([LotterySaleId])
REFERENCES [dbo].[LotterySales] ([Id])
GO
ALTER TABLE [dbo].[Payments] CHECK CONSTRAINT [FK_Payments_LotterySales_LotterySaleId]
GO
ALTER TABLE [dbo].[PlanOption]  WITH CHECK ADD  CONSTRAINT [FK_PlanOption_OptionModules_OptionModuleId] FOREIGN KEY([OptionModuleId])
REFERENCES [dbo].[OptionModules] ([Id])
GO
ALTER TABLE [dbo].[PlanOption] CHECK CONSTRAINT [FK_PlanOption_OptionModules_OptionModuleId]
GO
ALTER TABLE [dbo].[PlanOption]  WITH CHECK ADD  CONSTRAINT [FK_PlanOption_Options_OptionId] FOREIGN KEY([OptionId])
REFERENCES [dbo].[Options] ([Id])
GO
ALTER TABLE [dbo].[PlanOption] CHECK CONSTRAINT [FK_PlanOption_Options_OptionId]
GO
ALTER TABLE [dbo].[PlanOption]  WITH CHECK ADD  CONSTRAINT [FK_PlanOption_Plans_PlanId] FOREIGN KEY([PlanId])
REFERENCES [dbo].[Plans] ([Id])
GO
ALTER TABLE [dbo].[PlanOption] CHECK CONSTRAINT [FK_PlanOption_Plans_PlanId]
GO
ALTER TABLE [dbo].[Plans]  WITH CHECK ADD  CONSTRAINT [FK_Plans_Currencies_CurrencyId] FOREIGN KEY([CurrencyId])
REFERENCES [dbo].[Currencies] ([Id])
GO
ALTER TABLE [dbo].[Plans] CHECK CONSTRAINT [FK_Plans_Currencies_CurrencyId]
GO
ALTER TABLE [dbo].[Plans]  WITH CHECK ADD  CONSTRAINT [FK_Plans_Periodicities_PeriodicityId] FOREIGN KEY([PeriodicityId])
REFERENCES [dbo].[Periodicities] ([Id])
GO
ALTER TABLE [dbo].[Plans] CHECK CONSTRAINT [FK_Plans_Periodicities_PeriodicityId]
GO
ALTER TABLE [dbo].[PlanTransactions]  WITH CHECK ADD  CONSTRAINT [FK_PlanTransactions_Currencies_CurrencyId] FOREIGN KEY([CurrencyId])
REFERENCES [dbo].[Currencies] ([Id])
GO
ALTER TABLE [dbo].[PlanTransactions] CHECK CONSTRAINT [FK_PlanTransactions_Currencies_CurrencyId]
GO
ALTER TABLE [dbo].[PlanTransactions]  WITH CHECK ADD  CONSTRAINT [FK_PlanTransactions_OwnerPlans_OwnerPlanId] FOREIGN KEY([OwnerPlanId])
REFERENCES [dbo].[OwnerPlans] ([Id])
GO
ALTER TABLE [dbo].[PlanTransactions] CHECK CONSTRAINT [FK_PlanTransactions_OwnerPlans_OwnerPlanId]
GO
ALTER TABLE [dbo].[PlanTransactions]  WITH CHECK ADD  CONSTRAINT [FK_PlanTransactions_PaymentTypes_PaymentTypeId] FOREIGN KEY([PaymentTypeId])
REFERENCES [dbo].[PaymentTypes] ([Id])
GO
ALTER TABLE [dbo].[PlanTransactions] CHECK CONSTRAINT [FK_PlanTransactions_PaymentTypes_PaymentTypeId]
GO
ALTER TABLE [dbo].[PrizePayments]  WITH CHECK ADD  CONSTRAINT [FK_PrizePayments_AspNetUsers_CreatedBy] FOREIGN KEY([CreatedBy])
REFERENCES [dbo].[AspNetUsers] ([Id])
GO
ALTER TABLE [dbo].[PrizePayments] CHECK CONSTRAINT [FK_PrizePayments_AspNetUsers_CreatedBy]
GO
ALTER TABLE [dbo].[PrizePayments]  WITH CHECK ADD  CONSTRAINT [FK_PrizePayments_AspNetUsers_DeletedBy] FOREIGN KEY([DeletedBy])
REFERENCES [dbo].[AspNetUsers] ([Id])
GO
ALTER TABLE [dbo].[PrizePayments] CHECK CONSTRAINT [FK_PrizePayments_AspNetUsers_DeletedBy]
GO
ALTER TABLE [dbo].[PrizePayments]  WITH CHECK ADD  CONSTRAINT [FK_PrizePayments_AspNetUsers_SellerId] FOREIGN KEY([SellerId])
REFERENCES [dbo].[AspNetUsers] ([Id])
GO
ALTER TABLE [dbo].[PrizePayments] CHECK CONSTRAINT [FK_PrizePayments_AspNetUsers_SellerId]
GO
ALTER TABLE [dbo].[PrizePayments]  WITH CHECK ADD  CONSTRAINT [FK_PrizePayments_AspNetUsers_UpdatedBy] FOREIGN KEY([UpdatedBy])
REFERENCES [dbo].[AspNetUsers] ([Id])
GO
ALTER TABLE [dbo].[PrizePayments] CHECK CONSTRAINT [FK_PrizePayments_AspNetUsers_UpdatedBy]
GO
USE [master]
GO
ALTER DATABASE [lotteryfm] SET  READ_WRITE 
GO
