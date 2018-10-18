/************************************************************/
/*****              R_Supplier                    *****/
/************************************************************/

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[R_Supplier]') AND type in (N'U'))
DROP TABLE [R_Supplier]
GO

CREATE TABLE R_Supplier
    (
    SupplierId INT NOT NULL IDENTITY (1, 1),
    Name nvarchar(max) NOT NULL,
    SupplierTypeId INT NOT NULL,
    Phone nvarchar(max) NOT NULL,
    Email nvarchar(max) NULL,
    Latitude FLOAT NULL,
    Longitude FLOAT NULL,
    Description nvarchar(max) NULL,
    Website nvarchar(max) NULL,
    AddressId INT NULL,
    IsDeleted BIT NOT NULL,
    CreateBy INT NULL,
    CreateOn DATETIME NULL,
    UpdateBy INT NULL,
    UpdateOn DATETIME NULL
    )  ON [PRIMARY]
GO


ALTER TABLE R_Supplier ADD CONSTRAINT
    PK_R_Supplier PRIMARY KEY CLUSTERED 
    (
    SupplierId
    ) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO

/************************************************************/
/*****              R_RefoodUser                    *****/
/************************************************************/

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[R_RefoodUser]') AND type in (N'U'))
DROP TABLE [R_RefoodUser]
GO

CREATE TABLE R_RefoodUser
    (
    RefoodUserId INT NOT NULL IDENTITY (1, 1),
    Username nvarchar(max) NOT NULL,
    Fullname nvarchar(max) NOT NULL,
    Email nvarchar(max) NULL,
    Active BIT NOT NULL,
    IsDeleted BIT NOT NULL,
    CreateBy INT NULL,
    CreateOn DATETIME NULL,
    UpdateBy INT NULL,
    UpdateOn DATETIME NULL
    )  ON [PRIMARY]
GO


ALTER TABLE R_RefoodUser ADD CONSTRAINT
    PK_R_RefoodUser PRIMARY KEY CLUSTERED 
    (
    RefoodUserId
    ) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO

/************************************************************/
/*****              R_SupplierType                    *****/
/************************************************************/

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[R_SupplierType]') AND type in (N'U'))
DROP TABLE [R_SupplierType]
GO

CREATE TABLE R_SupplierType
    (
    SupplierTypeId INT NOT NULL IDENTITY (1, 1),
    Name nvarchar(max) NOT NULL,
    Description nvarchar(max) NOT NULL,
    Active BIT NOT NULL,
    IsDeleted BIT NOT NULL,
    CreateBy INT NULL,
    CreateOn DATETIME NULL,
    UpdateBy INT NULL,
    UpdateOn DATETIME NULL
    )  ON [PRIMARY]
GO


ALTER TABLE R_SupplierType ADD CONSTRAINT
    PK_R_SupplierType PRIMARY KEY CLUSTERED 
    (
    SupplierTypeId
    ) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO

/************************************************************/
/*****              R_Volunteer                    *****/
/************************************************************/

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[R_Volunteer]') AND type in (N'U'))
DROP TABLE [R_Volunteer]
GO

CREATE TABLE R_Volunteer
    (
    VolunteerId INT NOT NULL IDENTITY (1, 1),
    Name nvarchar(max) NULL,
    Gender INT NULL,
    BirthDate DATETIME NULL,
    Occupation nvarchar(max) NULL,
    Employer nvarchar(max) NULL,
    Phone nvarchar(max) NULL,
    Email nvarchar(max) NULL,
    IdentityCardNumber nvarchar(max) NULL,
    CountryId INT NULL,
    FriendOrFamilyContact nvarchar(max) NULL,
    Photo INT NULL,
    AddressId INT NULL,
    HasCar BIT NOT NULL,
    HasDriverLicense BIT NOT NULL,
    HasBike BIT NOT NULL,
    VehicleMake nvarchar(max) NULL,
    VehicleModel nvarchar(max) NULL,
    Active BIT NOT NULL,
    IsDeleted BIT NOT NULL,
    CreateBy INT NULL,
    CreateOn DATETIME NULL,
    UpdateBy INT NULL,
    UpdateOn DATETIME NULL
    )  ON [PRIMARY]
GO


ALTER TABLE R_Volunteer ADD CONSTRAINT
    PK_R_Volunteer PRIMARY KEY CLUSTERED 
    (
    VolunteerId
    ) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO

/************************************************************/
/*****              R_Beneficiary                    *****/
/************************************************************/

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[R_Beneficiary]') AND type in (N'U'))
DROP TABLE [R_Beneficiary]
GO

CREATE TABLE R_Beneficiary
    (
    BeneficiaryId INT NOT NULL IDENTITY (1, 1),
    Name nvarchar(max) NULL,
    Number INT NULL,
    AddressId INT NULL,
    NumberOfAdults INT NULL,
    NumberOfChildren INT NULL,
    NumberOfTupperware INT NULL,
    NumberOfSoups INT NULL,
    Description nvarchar(max) NULL,
    Active BIT NOT NULL,
    IsDeleted BIT NOT NULL,
    CreateBy INT NULL,
    CreateOn DATETIME NULL,
    UpdateBy INT NULL,
    UpdateOn DATETIME NULL
    )  ON [PRIMARY]
GO


ALTER TABLE R_Beneficiary ADD CONSTRAINT
    PK_R_Beneficiary PRIMARY KEY CLUSTERED 
    (
    BeneficiaryId
    ) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO

/************************************************************/
/*****              R_BenificiaryMember                    *****/
/************************************************************/

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[R_BenificiaryMember]') AND type in (N'U'))
DROP TABLE [R_BenificiaryMember]
GO

CREATE TABLE R_BenificiaryMember
    (
    BenificiaryMemberId INT NOT NULL IDENTITY (1, 1),
    BenificiaryId INT NULL,
    Name nvarchar(max) NULL,
    IsChild BIT NOT NULL,
    Description nvarchar(max) NULL,
    BirthDate DATETIME NULL,
    Active BIT NOT NULL,
    IsDeleted BIT NOT NULL,
    CreateBy INT NULL,
    CreateOn DATETIME NULL,
    UpdateBy INT NULL,
    UpdateOn DATETIME NULL
    )  ON [PRIMARY]
GO


ALTER TABLE R_BenificiaryMember ADD CONSTRAINT
    PK_R_BenificiaryMember PRIMARY KEY CLUSTERED 
    (
    BenificiaryMemberId
    ) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO

/************************************************************/
/*****              R_Equipment                    *****/
/************************************************************/

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[R_Equipment]') AND type in (N'U'))
DROP TABLE [R_Equipment]
GO

CREATE TABLE R_Equipment
    (
    EquipmentId INT NOT NULL IDENTITY (1, 1),
    Name nvarchar(max) NULL,
    Description nvarchar(max) NULL,
    Category nvarchar(max) NULL,
    Photo INT NULL,
    QuantityInStock FLOAT NULL,
    MinimumQuantityNeeded FLOAT NULL,
    PricePerUnit FLOAT NULL,
    StorageLocation nvarchar(max) NULL,
    Active BIT NOT NULL,
    IsDeleted BIT NOT NULL,
    CreateBy INT NULL,
    CreateOn DATETIME NULL,
    UpdateBy INT NULL,
    UpdateOn DATETIME NULL
    )  ON [PRIMARY]
GO


ALTER TABLE R_Equipment ADD CONSTRAINT
    PK_R_Equipment PRIMARY KEY CLUSTERED 
    (
    EquipmentId
    ) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO

/************************************************************/
/*****              R_PlannedRoute                    *****/
/************************************************************/

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[R_PlannedRoute]') AND type in (N'U'))
DROP TABLE [R_PlannedRoute]
GO

CREATE TABLE R_PlannedRoute
    (
    PlannedRouteId INT NOT NULL IDENTITY (1, 1),
    Name nvarchar(max) NULL,
    RouteTypeId INT NULL,
    TransportTypeId INT NULL,
    Description nvarchar(max) NULL,
    StartHour DATETIME NULL,
    EstimatedDuration INT NULL,
    TotalDistance FLOAT NULL,
    RouteDayOfTheWeek nvarchar(max) NULL,
    Active BIT NOT NULL,
    IsDeleted BIT NOT NULL,
    CreateBy INT NULL,
    CreateOn DATETIME NULL,
    UpdateBy INT NULL,
    UpdateOn DATETIME NULL
    )  ON [PRIMARY]
GO


ALTER TABLE R_PlannedRoute ADD CONSTRAINT
    PK_R_PlannedRoute PRIMARY KEY CLUSTERED 
    (
    PlannedRouteId
    ) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO

/************************************************************/
/*****              R_Checkpoint                    *****/
/************************************************************/

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[R_Checkpoint]') AND type in (N'U'))
DROP TABLE [R_Checkpoint]
GO

CREATE TABLE R_Checkpoint
    (
    CheckpointId INT NOT NULL IDENTITY (1, 1),
    PlannedRouteId INT NOT NULL,
    Name nvarchar(max) NOT NULL,
    OrderNumber INT NOT NULL,
    Latitude FLOAT NULL,
    Longitude FLOAT NULL,
    AddressId INT NULL,
    EstimatedTimeArrival INT NOT NULL,
    MinimumTime DATETIME NULL,
    MaximumTime DATETIME NULL,
    NucleoId INT NULL,
    SupplierId INT NULL,
    Active BIT NOT NULL,
    IsDeleted BIT NOT NULL,
    CreateBy INT NULL,
    CreateOn DATETIME NULL,
    UpdateBy INT NULL,
    UpdateOn DATETIME NULL
    )  ON [PRIMARY]
GO


ALTER TABLE R_Checkpoint ADD CONSTRAINT
    PK_R_Checkpoint PRIMARY KEY CLUSTERED 
    (
    CheckpointId
    ) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO

/************************************************************/
/*****              R_Nucleo                    *****/
/************************************************************/

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[R_Nucleo]') AND type in (N'U'))
DROP TABLE [R_Nucleo]
GO

CREATE TABLE R_Nucleo
    (
    NucleoId INT NOT NULL IDENTITY (1, 1),
    Name nvarchar(max) NULL,
    PersonResponsible nvarchar(max) NULL,
    Photo INT NULL,
    AddressId INT NULL,
    OpeningDate DATETIME NULL,
    PrimaryPhoneNumber nvarchar(max) NULL,
    PrimaryEmail nvarchar(max) NULL,
    Active BIT NOT NULL,
    IsDeleted BIT NOT NULL,
    CreateBy INT NULL,
    CreateOn DATETIME NULL,
    UpdateBy INT NULL,
    UpdateOn DATETIME NULL
    )  ON [PRIMARY]
GO


ALTER TABLE R_Nucleo ADD CONSTRAINT
    PK_R_Nucleo PRIMARY KEY CLUSTERED 
    (
    NucleoId
    ) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO

/************************************************************/
/*****              R_FoodTemplate                    *****/
/************************************************************/

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[R_FoodTemplate]') AND type in (N'U'))
DROP TABLE [R_FoodTemplate]
GO

CREATE TABLE R_FoodTemplate
    (
    FoodTemplateId INT NOT NULL IDENTITY (1, 1),
    Name nvarchar(max) NOT NULL,
    Description nvarchar(max) NULL,
    FoodCategory nvarchar(max) NULL,
    Calories INT NULL,
    AverageExpirationTime DATETIME NULL,
    Liquid BIT NOT NULL,
    NeedsRefrigeration BIT NOT NULL,
    Active BIT NOT NULL,
    IsDeleted BIT NOT NULL,
    CreateBy INT NULL,
    CreateOn DATETIME NULL,
    UpdateBy INT NULL,
    UpdateOn DATETIME NULL
    )  ON [PRIMARY]
GO


ALTER TABLE R_FoodTemplate ADD CONSTRAINT
    PK_R_FoodTemplate PRIMARY KEY CLUSTERED 
    (
    FoodTemplateId
    ) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO

/************************************************************/
/*****              R_Food                    *****/
/************************************************************/

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[R_Food]') AND type in (N'U'))
DROP TABLE [R_Food]
GO

CREATE TABLE R_Food
    (
    FoodId INT NOT NULL IDENTITY (1, 1),
    Name nvarchar(max) NULL,
    Quantity FLOAT NULL,
    FoodTemplateId INT NULL,
    SpecificObservations nvarchar(max) NULL,
    Location nvarchar(max) NULL,
    Progress INT NULL,
    Expired BIT NOT NULL,
    Liquid BIT NOT NULL,
    Rating INT NULL,
    FeedbackFromBeneficiary nvarchar(max) NULL,
    DeliveredBy INT NULL,
    DeliveredTo INT NULL,
    OrderDateTime DATETIME NULL,
    CookedDateTime DATETIME NULL,
    PickupDateTime DATETIME NULL,
    StorageDateTime DATETIME NULL,
    DeliveryDateTime DATETIME NULL,
    Active BIT NOT NULL,
    IsDeleted BIT NOT NULL,
    CreateBy INT NULL,
    CreateOn DATETIME NULL,
    UpdateBy INT NULL,
    UpdateOn DATETIME NULL
    )  ON [PRIMARY]
GO


ALTER TABLE R_Food ADD CONSTRAINT
    PK_R_Food PRIMARY KEY CLUSTERED 
    (
    FoodId
    ) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO

/************************************************************/
/*****              R_Meal                    *****/
/************************************************************/

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[R_Meal]') AND type in (N'U'))
DROP TABLE [R_Meal]
GO

CREATE TABLE R_Meal
    (
    MealId INT NOT NULL IDENTITY (1, 1),
    NuceloId INT NULL,
    Day DATETIME NULL,
    NumberMealsReceived INT NULL,
    NumberDelivered INT NULL,
    MaximumCapacityMeals INT NULL,
    Active BIT NOT NULL,
    IsDeleted BIT NOT NULL,
    CreateBy INT NULL,
    CreateOn DATETIME NULL,
    UpdateBy INT NULL,
    UpdateOn DATETIME NULL
    )  ON [PRIMARY]
GO


ALTER TABLE R_Meal ADD CONSTRAINT
    PK_R_Meal PRIMARY KEY CLUSTERED 
    (
    MealId
    ) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO

/************************************************************/
/*****              R_Task                    *****/
/************************************************************/

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[R_Task]') AND type in (N'U'))
DROP TABLE [R_Task]
GO

CREATE TABLE R_Task
    (
    TaskId INT NOT NULL IDENTITY (1, 1),
    Name nvarchar(max) NULL,
    TaskTypeId INT NULL,
    TaskDate DATETIME NULL,
    WeekDay INT NULL,
    StartTime DATETIME NULL,
    EndTime DATETIME NULL,
    EstimatedDuration INT NULL,
    Description nvarchar(max) NULL,
    RequiresCar BIT NULL,
    TeamLeaderId INT NULL,
    Active BIT NOT NULL,
    IsDeleted BIT NOT NULL,
    CreateBy INT NULL,
    CreateOn DATETIME NULL,
    UpdateBy INT NULL,
    UpdateOn DATETIME NULL
    )  ON [PRIMARY]
GO


ALTER TABLE R_Task ADD CONSTRAINT
    PK_R_Task PRIMARY KEY CLUSTERED 
    (
    TaskId
    ) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO

/************************************************************/
/*****              R_TaskType                    *****/
/************************************************************/

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[R_TaskType]') AND type in (N'U'))
DROP TABLE [R_TaskType]
GO

CREATE TABLE R_TaskType
    (
    TaskTypeId INT NOT NULL IDENTITY (1, 1),
    Name nvarchar(max) NOT NULL,
    Description nvarchar(max) NULL,
    Active BIT NOT NULL,
    IsDeleted BIT NOT NULL,
    CreateBy INT NULL,
    CreateOn DATETIME NULL,
    UpdateBy INT NULL,
    UpdateOn DATETIME NULL
    )  ON [PRIMARY]
GO


ALTER TABLE R_TaskType ADD CONSTRAINT
    PK_R_TaskType PRIMARY KEY CLUSTERED 
    (
    TaskTypeId
    ) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO

/************************************************************/
/*****              R_EnergySource                    *****/
/************************************************************/

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[R_EnergySource]') AND type in (N'U'))
DROP TABLE [R_EnergySource]
GO

CREATE TABLE R_EnergySource
    (
    EnergySourceId INT NOT NULL IDENTITY (1, 1),
    Name nvarchar(max) NOT NULL,
    Description nvarchar(max) NULL,
    Active BIT NOT NULL,
    IsDeleted BIT NOT NULL,
    CreateBy INT NULL,
    CreateOn DATETIME NULL,
    UpdateBy INT NULL,
    UpdateOn DATETIME NULL
    )  ON [PRIMARY]
GO


ALTER TABLE R_EnergySource ADD CONSTRAINT
    PK_R_EnergySource PRIMARY KEY CLUSTERED 
    (
    EnergySourceId
    ) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO

/************************************************************/
/*****              R_VehicleType                    *****/
/************************************************************/

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[R_VehicleType]') AND type in (N'U'))
DROP TABLE [R_VehicleType]
GO

CREATE TABLE R_VehicleType
    (
    VehicleTypeId INT NOT NULL IDENTITY (1, 1),
    Name nvarchar(max) NOT NULL,
    Description nvarchar(max) NULL,
    Active BIT NOT NULL,
    IsDeleted BIT NOT NULL,
    CreateBy INT NULL,
    CreateOn DATETIME NULL,
    UpdateBy INT NULL,
    UpdateOn DATETIME NULL
    )  ON [PRIMARY]
GO


ALTER TABLE R_VehicleType ADD CONSTRAINT
    PK_R_VehicleType PRIMARY KEY CLUSTERED 
    (
    VehicleTypeId
    ) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO

/************************************************************/
/*****              R_Team                    *****/
/************************************************************/

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[R_Team]') AND type in (N'U'))
DROP TABLE [R_Team]
GO

CREATE TABLE R_Team
    (
    TeamId INT NOT NULL IDENTITY (1, 1),
    NucleoId INT NULL,
    Name nvarchar(max) NOT NULL,
    Description nvarchar(max) NULL,
    Active BIT NOT NULL,
    IsDeleted BIT NOT NULL,
    CreateBy INT NULL,
    CreateOn DATETIME NULL,
    UpdateBy INT NULL,
    UpdateOn DATETIME NULL
    )  ON [PRIMARY]
GO


ALTER TABLE R_Team ADD CONSTRAINT
    PK_R_Team PRIMARY KEY CLUSTERED 
    (
    TeamId
    ) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO

/************************************************************/
/*****              R_Tutorial                    *****/
/************************************************************/

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[R_Tutorial]') AND type in (N'U'))
DROP TABLE [R_Tutorial]
GO

CREATE TABLE R_Tutorial
    (
    TutorialId INT NOT NULL IDENTITY (1, 1),
    Name nvarchar(max) NOT NULL,
    Description nvarchar(max) NULL,
    Location nvarchar(max) NULL,
    IsOnlineTutorial BIT NOT NULL,
    Language nvarchar(max) NULL,
    Active BIT NOT NULL,
    IsDeleted BIT NOT NULL,
    CreateBy INT NULL,
    CreateOn DATETIME NULL,
    UpdateBy INT NULL,
    UpdateOn DATETIME NULL
    )  ON [PRIMARY]
GO


ALTER TABLE R_Tutorial ADD CONSTRAINT
    PK_R_Tutorial PRIMARY KEY CLUSTERED 
    (
    TutorialId
    ) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO

/************************************************************/
/*****              R_Vehicle                    *****/
/************************************************************/

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[R_Vehicle]') AND type in (N'U'))
DROP TABLE [R_Vehicle]
GO

CREATE TABLE R_Vehicle
    (
    VehicleId INT NOT NULL IDENTITY (1, 1),
    Make nvarchar(max) NULL,
    Model nvarchar(max) NULL,
    Owner nvarchar(max) NULL,
    OwnerId INT NULL,
    NucleoId INT NULL,
    VehicleTypeId INT NOT NULL,
    EnergySourceId INT NOT NULL,
    AverageSpeed INT NULL,
    HorsePower INT NULL,
    FuelConsumption FLOAT NULL,
    FuelAutonomyDistance FLOAT NULL,
    RechargeTime INT NULL,
    LicensePlate nvarchar(max) NULL,
    Color nvarchar(max) NULL,
    NumberSeats INT NULL,
    CargoVolumeCapacity INT NULL,
    Active BIT NOT NULL,
    IsDeleted BIT NOT NULL,
    CreateBy INT NULL,
    CreateOn DATETIME NULL,
    UpdateBy INT NULL,
    UpdateOn DATETIME NULL
    )  ON [PRIMARY]
GO


ALTER TABLE R_Vehicle ADD CONSTRAINT
    PK_R_Vehicle PRIMARY KEY CLUSTERED 
    (
    VehicleId
    ) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO

/************************************************************/
/*****              R_Event                    *****/
/************************************************************/

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[R_Event]') AND type in (N'U'))
DROP TABLE [R_Event]
GO

CREATE TABLE R_Event
    (
    EventId INT NOT NULL IDENTITY (1, 1),
    NucleoId INT NULL,
    Name nvarchar(max) NOT NULL,
    Description nvarchar(max) NULL,
    StartDate DATETIME NULL,
    EndDate DATETIME NULL,
    Location nvarchar(max) NULL,
    Duration INT NULL,
    Organizer nvarchar(max) NULL,
    PhotoUrl nvarchar(max) NULL,
    VideoUrl nvarchar(max) NULL,
    Active BIT NOT NULL,
    IsDeleted BIT NOT NULL,
    CreateBy INT NULL,
    CreateOn DATETIME NULL,
    UpdateBy INT NULL,
    UpdateOn DATETIME NULL
    )  ON [PRIMARY]
GO


ALTER TABLE R_Event ADD CONSTRAINT
    PK_R_Event PRIMARY KEY CLUSTERED 
    (
    EventId
    ) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO

/************************************************************/
/*****              R_Video                    *****/
/************************************************************/

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[R_Video]') AND type in (N'U'))
DROP TABLE [R_Video]
GO

CREATE TABLE R_Video
    (
    VideoId INT NOT NULL IDENTITY (1, 1),
    Name nvarchar(max) NOT NULL,
    Description nvarchar(max) NULL,
    VideoUrl nvarchar(max) NULL,
    Duration INT NULL,
    Language nvarchar(max) NULL,
    Active BIT NOT NULL,
    IsDeleted BIT NOT NULL,
    CreateBy INT NULL,
    CreateOn DATETIME NULL,
    UpdateBy INT NULL,
    UpdateOn DATETIME NULL
    )  ON [PRIMARY]
GO


ALTER TABLE R_Video ADD CONSTRAINT
    PK_R_Video PRIMARY KEY CLUSTERED 
    (
    VideoId
    ) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO

/************************************************************/
/*****              R_Photo                    *****/
/************************************************************/

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[R_Photo]') AND type in (N'U'))
DROP TABLE [R_Photo]
GO

CREATE TABLE R_Photo
    (
    PhotoId INT NOT NULL IDENTITY (1, 1),
    Name nvarchar(max) NULL,
    Description nvarchar(max) NULL,
    PhotoUrl nvarchar(max) NULL,
    PhotoDate DATETIME NULL,
    IsPublic BIT NOT NULL,
    Active BIT NOT NULL,
    IsDeleted BIT NOT NULL,
    CreateBy INT NULL,
    CreateOn DATETIME NULL,
    UpdateBy INT NULL,
    UpdateOn DATETIME NULL
    )  ON [PRIMARY]
GO


ALTER TABLE R_Photo ADD CONSTRAINT
    PK_R_Photo PRIMARY KEY CLUSTERED 
    (
    PhotoId
    ) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO

/************************************************************/
/*****              R_CalendarEvent                    *****/
/************************************************************/

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[R_CalendarEvent]') AND type in (N'U'))
DROP TABLE [R_CalendarEvent]
GO

CREATE TABLE R_CalendarEvent
    (
    CalendarEventId INT NOT NULL IDENTITY (1, 1),
    NucleoId INT NULL,
    Name nvarchar(max) NOT NULL,
    Description nvarchar(max) NULL,
    StartDate DATETIME NOT NULL,
    EndDate DATETIME NOT NULL,
    Active BIT NOT NULL,
    IsDeleted BIT NOT NULL,
    CreateBy INT NULL,
    CreateOn DATETIME NULL,
    UpdateBy INT NULL,
    UpdateOn DATETIME NULL
    )  ON [PRIMARY]
GO


ALTER TABLE R_CalendarEvent ADD CONSTRAINT
    PK_R_CalendarEvent PRIMARY KEY CLUSTERED 
    (
    CalendarEventId
    ) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO

/************************************************************/
/*****              R_WeekDay                    *****/
/************************************************************/

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[R_WeekDay]') AND type in (N'U'))
DROP TABLE [R_WeekDay]
GO

CREATE TABLE R_WeekDay
    (
    WeekDayId INT NOT NULL IDENTITY (1, 1),
    NucleoId INT NULL,
    Name nvarchar(max) NOT NULL,
    Description nvarchar(max) NULL,
    ResponsiblePersonId INT NULL,
    Active BIT NOT NULL,
    IsDeleted BIT NOT NULL,
    CreateBy INT NULL,
    CreateOn DATETIME NULL,
    UpdateBy INT NULL,
    UpdateOn DATETIME NULL
    )  ON [PRIMARY]
GO


ALTER TABLE R_WeekDay ADD CONSTRAINT
    PK_R_WeekDay PRIMARY KEY CLUSTERED 
    (
    WeekDayId
    ) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO

/************************************************************/
/*****              R_DeliveryReport                    *****/
/************************************************************/

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[R_DeliveryReport]') AND type in (N'U'))
DROP TABLE [R_DeliveryReport]
GO

CREATE TABLE R_DeliveryReport
    (
    DeliveryReportId INT NOT NULL IDENTITY (1, 1),
    Name nvarchar(max) NULL,
    Description nvarchar(max) NULL,
    ReportDate DATETIME NULL,
    WeekDay nvarchar(max) NULL,
    Submitted BIT NOT NULL,
    IsDeleted BIT NOT NULL,
    CreateBy INT NULL,
    CreateOn DATETIME NULL,
    UpdateBy INT NULL,
    UpdateOn DATETIME NULL
    )  ON [PRIMARY]
GO


ALTER TABLE R_DeliveryReport ADD CONSTRAINT
    PK_R_DeliveryReport PRIMARY KEY CLUSTERED 
    (
    DeliveryReportId
    ) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO

/************************************************************/
/*****              R_DeliveryReportMessage                    *****/
/************************************************************/

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[R_DeliveryReportMessage]') AND type in (N'U'))
DROP TABLE [R_DeliveryReportMessage]
GO

CREATE TABLE R_DeliveryReportMessage
    (
    DeliveryReportMessageId INT NOT NULL IDENTITY (1, 1),
    DeliveryReportMessageTypeId INT NOT NULL,
    Message nvarchar(max) NOT NULL,
    IsDeleted BIT NOT NULL,
    CreateBy INT NULL,
    CreateOn DATETIME NULL,
    UpdateBy INT NULL,
    UpdateOn DATETIME NULL
    )  ON [PRIMARY]
GO


ALTER TABLE R_DeliveryReportMessage ADD CONSTRAINT
    PK_R_DeliveryReportMessage PRIMARY KEY CLUSTERED 
    (
    DeliveryReportMessageId
    ) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO

/************************************************************/
/*****              R_DeliveryReportNoShowBeneficiary                    *****/
/************************************************************/

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[R_DeliveryReportNoShowBeneficiary]') AND type in (N'U'))
DROP TABLE [R_DeliveryReportNoShowBeneficiary]
GO

CREATE TABLE R_DeliveryReportNoShowBeneficiary
    (
    DeliveryReportNoShowBeneficiaryId INT NOT NULL IDENTITY (1, 1),
    DeliveryReportId nvarchar(max) NOT NULL,
    BeneficiaryName nvarchar(max) NOT NULL,
    BeneficiaryId INT NULL,
    IsDeleted BIT NOT NULL,
    CreateBy INT NULL,
    CreateOn DATETIME NULL,
    UpdateBy INT NULL,
    UpdateOn DATETIME NULL
    )  ON [PRIMARY]
GO


ALTER TABLE R_DeliveryReportNoShowBeneficiary ADD CONSTRAINT
    PK_R_DeliveryReportNoShowBeneficiary PRIMARY KEY CLUSTERED 
    (
    DeliveryReportNoShowBeneficiaryId
    ) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO

/************************************************************/
/*****              R_DeliveryReportMessageType                    *****/
/************************************************************/

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[R_DeliveryReportMessageType]') AND type in (N'U'))
DROP TABLE [R_DeliveryReportMessageType]
GO

CREATE TABLE R_DeliveryReportMessageType
    (
    DeliveryReportMessageTypeId INT NOT NULL IDENTITY (1, 1),
    Name nvarchar(max) NOT NULL,
    Description nvarchar(max) NULL,
    Active BIT NOT NULL,
    IsDeleted BIT NOT NULL,
    CreateBy INT NULL,
    CreateOn DATETIME NULL,
    UpdateBy INT NULL,
    UpdateOn DATETIME NULL
    )  ON [PRIMARY]
GO


ALTER TABLE R_DeliveryReportMessageType ADD CONSTRAINT
    PK_R_DeliveryReportMessageType PRIMARY KEY CLUSTERED 
    (
    DeliveryReportMessageTypeId
    ) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO

/************************************************************/
/*****              R_ExperimentalPhaseLog                    *****/
/************************************************************/

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[R_ExperimentalPhaseLog]') AND type in (N'U'))
DROP TABLE [R_ExperimentalPhaseLog]
GO

CREATE TABLE R_ExperimentalPhaseLog
    (
    ExperimentalPhaseLogId INT NOT NULL IDENTITY (1, 1),
    NucleoId INT NULL,
    LogDate DATETIME NOT NULL,
    Task nvarchar(max) NOT NULL,
    ActivityDescription nvarchar(max) NULL,
    ManagerName nvarchar(max) NOT NULL,
    VolunteerName nvarchar(max) NOT NULL,
    VolunteerConfirmation BIT NOT NULL,
    DocumentId INT NULL,
    IsDeleted BIT NOT NULL,
    CreateBy INT NULL,
    CreateOn DATETIME NULL,
    UpdateBy INT NULL,
    UpdateOn DATETIME NULL
    )  ON [PRIMARY]
GO


ALTER TABLE R_ExperimentalPhaseLog ADD CONSTRAINT
    PK_R_ExperimentalPhaseLog PRIMARY KEY CLUSTERED 
    (
    ExperimentalPhaseLogId
    ) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO

/************************************************************/
/*****              R_Partner                    *****/
/************************************************************/

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[R_Partner]') AND type in (N'U'))
DROP TABLE [R_Partner]
GO

CREATE TABLE R_Partner
    (
    PartnerId INT NOT NULL IDENTITY (1, 1),
    NucleoId INT NULL,
    Name nvarchar(max) NOT NULL,
    EnterpriseContributor BIT NOT NULL,
    PrivateContributor BIT NOT NULL,
    ContributionTypeId INT NOT NULL,
    PartnershipTypeId INT NOT NULL,
    ContactPerson nvarchar(max) NULL,
    Department nvarchar(max) NULL,
    Phone nvarchar(max) NULL,
    Email nvarchar(max) NULL,
    Iban nvarchar(max) NULL,
    BicSwift nvarchar(max) NULL,
    FiscalNumber nvarchar(max) NULL,
    Latitude FLOAT NULL,
    Longitude FLOAT NULL,
    PhotoUrl nvarchar(max) NULL,
    AddressId INT NULL,
    PartnershipStartDate DATETIME NULL,
    DurationCommitment DATETIME NULL,
    RefoodAreaInteraction nvarchar(max) NULL,
    Reliability nvarchar(max) NULL,
    InteractionFrequency nvarchar(max) NULL,
    Active BIT NOT NULL,
    IsDeleted BIT NOT NULL,
    CreateBy INT NULL,
    CreateOn DATETIME NULL,
    UpdateBy INT NULL,
    UpdateOn DATETIME NULL
    )  ON [PRIMARY]
GO


ALTER TABLE R_Partner ADD CONSTRAINT
    PK_R_Partner PRIMARY KEY CLUSTERED 
    (
    PartnerId
    ) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO

/************************************************************/
/*****              R_ContributionType                    *****/
/************************************************************/

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[R_ContributionType]') AND type in (N'U'))
DROP TABLE [R_ContributionType]
GO

CREATE TABLE R_ContributionType
    (
    ContributionTypeId INT NOT NULL IDENTITY (1, 1),
    Name nvarchar(max) NOT NULL,
    Description nvarchar(max) NULL,
    Active BIT NOT NULL,
    IsDeleted BIT NOT NULL,
    CreateBy INT NULL,
    CreateOn DATETIME NULL,
    UpdateBy INT NULL,
    UpdateOn DATETIME NULL
    )  ON [PRIMARY]
GO


ALTER TABLE R_ContributionType ADD CONSTRAINT
    PK_R_ContributionType PRIMARY KEY CLUSTERED 
    (
    ContributionTypeId
    ) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO

/************************************************************/
/*****              R_PartnershipType                    *****/
/************************************************************/

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[R_PartnershipType]') AND type in (N'U'))
DROP TABLE [R_PartnershipType]
GO

CREATE TABLE R_PartnershipType
    (
    PartnershipTypeId INT NOT NULL IDENTITY (1, 1),
    Name nvarchar(max) NOT NULL,
    Description nvarchar(max) NULL,
    ActivityType nvarchar(max) NULL,
    Active BIT NOT NULL,
    IsDeleted BIT NOT NULL,
    CreateBy INT NULL,
    CreateOn DATETIME NULL,
    UpdateBy INT NULL,
    UpdateOn DATETIME NULL
    )  ON [PRIMARY]
GO


ALTER TABLE R_PartnershipType ADD CONSTRAINT
    PK_R_PartnershipType PRIMARY KEY CLUSTERED 
    (
    PartnershipTypeId
    ) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO

/************************************************************/
/*****              R_Address                    *****/
/************************************************************/

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[R_Address]') AND type in (N'U'))
DROP TABLE [R_Address]
GO

CREATE TABLE R_Address
    (
    AddressId INT NOT NULL IDENTITY (1, 1),
    Name nvarchar(max) NULL,
    AddressFirstLine nvarchar(max) NULL,
    AddressSecondLine nvarchar(max) NULL,
    CountryId INT NULL,
    DistrictId INT NULL,
    CountyId INT NULL,
    ParishId INT NULL,
    ZipCode nvarchar(max) NULL,
    Latitude FLOAT NULL,
    Longitude FLOAT NULL,
    Active BIT NOT NULL,
    IsDeleted BIT NOT NULL,
    CreateBy INT NULL,
    CreateOn DATETIME NULL,
    UpdateBy INT NULL,
    UpdateOn DATETIME NULL
    )  ON [PRIMARY]
GO


ALTER TABLE R_Address ADD CONSTRAINT
    PK_R_Address PRIMARY KEY CLUSTERED 
    (
    AddressId
    ) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO

/************************************************************/
/*****              R_Project                    *****/
/************************************************************/

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[R_Project]') AND type in (N'U'))
DROP TABLE [R_Project]
GO

CREATE TABLE R_Project
    (
    ProjectId INT NOT NULL IDENTITY (1, 1),
    NucleoId INT NULL,
    Name nvarchar(max) NULL,
    Description nvarchar(max) NULL,
    DeadlineCall nvarchar(max) NULL,
    Budget FLOAT NULL,
    Funding nvarchar(max) NULL,
    StartDate DATETIME NULL,
    EndDate DATETIME NULL,
    AreaOfInterest nvarchar(max) NULL,
    Active BIT NOT NULL,
    IsDeleted BIT NOT NULL,
    CreateBy INT NULL,
    CreateOn DATETIME NULL,
    UpdateBy INT NULL,
    UpdateOn DATETIME NULL
    )  ON [PRIMARY]
GO


ALTER TABLE R_Project ADD CONSTRAINT
    PK_R_Project PRIMARY KEY CLUSTERED 
    (
    ProjectId
    ) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO

/************************************************************/
/*****              R_ProjectPartner                    *****/
/************************************************************/

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[R_ProjectPartner]') AND type in (N'U'))
DROP TABLE [R_ProjectPartner]
GO

CREATE TABLE R_ProjectPartner
    (
    ProjectPartnerId INT NOT NULL IDENTITY (1, 1),
    ProjectId INT NOT NULL,
    PartnerId INT NOT NULL,
    GrantValue FLOAT NULL,
    IsDeleted BIT NOT NULL,
    CreateBy INT NULL,
    CreateOn DATETIME NULL,
    UpdateBy INT NULL,
    UpdateOn DATETIME NULL
    )  ON [PRIMARY]
GO


ALTER TABLE R_ProjectPartner ADD CONSTRAINT
    PK_R_ProjectPartner PRIMARY KEY CLUSTERED 
    (
    ProjectPartnerId
    ) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO

/************************************************************/
/*****              R_ContributionMonetary                    *****/
/************************************************************/

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[R_ContributionMonetary]') AND type in (N'U'))
DROP TABLE [R_ContributionMonetary]
GO

CREATE TABLE R_ContributionMonetary
    (
    ContributionMonetaryId INT NOT NULL IDENTITY (1, 1),
    NucleoId INT NULL,
    ResponsiblePersonId INT NULL,
    DocumentId INT NULL,
    PartnerId INT NULL,
    ContributionDate DATETIME NULL,
    Amount FLOAT NOT NULL,
    ContactPerson nvarchar(max) NULL,
    IbanOrigin nvarchar(max) NULL,
    BicSwiftOrigin nvarchar(max) NULL,
    IbanDestination nvarchar(max) NULL,
    BicSwiftDestination nvarchar(max) NULL,
    FiscalNumber nvarchar(max) NULL,
    ContributionChannelId INT NULL,
    IsDeleted BIT NOT NULL,
    CreateBy INT NULL,
    CreateOn DATETIME NULL,
    UpdateBy INT NULL,
    UpdateOn DATETIME NULL
    )  ON [PRIMARY]
GO


ALTER TABLE R_ContributionMonetary ADD CONSTRAINT
    PK_R_ContributionMonetary PRIMARY KEY CLUSTERED 
    (
    ContributionMonetaryId
    ) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO

/************************************************************/
/*****              R_ContributionChannel                    *****/
/************************************************************/

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[R_ContributionChannel]') AND type in (N'U'))
DROP TABLE [R_ContributionChannel]
GO

CREATE TABLE R_ContributionChannel
    (
    ContributionChannelId INT NOT NULL IDENTITY (1, 1),
    Name nvarchar(max) NOT NULL,
    Description nvarchar(max) NULL,
    Active BIT NOT NULL,
    IsDeleted BIT NOT NULL,
    CreateBy INT NULL,
    CreateOn DATETIME NULL,
    UpdateBy INT NULL,
    UpdateOn DATETIME NULL
    )  ON [PRIMARY]
GO


ALTER TABLE R_ContributionChannel ADD CONSTRAINT
    PK_R_ContributionChannel PRIMARY KEY CLUSTERED 
    (
    ContributionChannelId
    ) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO

/************************************************************/
/*****              R_ContributionMonetaryReviewer                    *****/
/************************************************************/

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[R_ContributionMonetaryReviewer]') AND type in (N'U'))
DROP TABLE [R_ContributionMonetaryReviewer]
GO

CREATE TABLE R_ContributionMonetaryReviewer
    (
    ContributionMonetaryReviewerId INT NOT NULL IDENTITY (1, 1),
    VolunteerId INT NULL,
    IsDeleted BIT NOT NULL,
    CreateBy INT NULL,
    CreateOn DATETIME NULL,
    UpdateBy INT NULL,
    UpdateOn DATETIME NULL
    )  ON [PRIMARY]
GO


ALTER TABLE R_ContributionMonetaryReviewer ADD CONSTRAINT
    PK_R_ContributionMonetaryReviewer PRIMARY KEY CLUSTERED 
    (
    ContributionMonetaryReviewerId
    ) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO

/************************************************************/
/*****              R_Expense                    *****/
/************************************************************/

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[R_Expense]') AND type in (N'U'))
DROP TABLE [R_Expense]
GO

CREATE TABLE R_Expense
    (
    ExpenseId INT NOT NULL IDENTITY (1, 1),
    NucleoId INT NULL,
    Name nvarchar(max) NOT NULL,
    Description nvarchar(max) NULL,
    ResponsiblePersonId INT NULL,
    ExecuterPersonId INT NULL,
    DocumentId INT NULL,
    PartnerId INT NULL,
    InvoiceDate DATETIME NULL,
    Amount FLOAT NOT NULL,
    IsDeleted BIT NOT NULL,
    CreateBy INT NULL,
    CreateOn DATETIME NULL,
    UpdateBy INT NULL,
    UpdateOn DATETIME NULL
    )  ON [PRIMARY]
GO


ALTER TABLE R_Expense ADD CONSTRAINT
    PK_R_Expense PRIMARY KEY CLUSTERED 
    (
    ExpenseId
    ) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO

/************************************************************/
/*****              R_Country                    *****/
/************************************************************/

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[R_Country]') AND type in (N'U'))
DROP TABLE [R_Country]
GO

CREATE TABLE R_Country
    (
    CountryId INT NOT NULL IDENTITY (1, 1),
    Name nvarchar(max) NULL,
    EnglishName nvarchar(max) NULL,
    IsoCode nvarchar(max) NULL,
    CapitalCity nvarchar(max) NULL,
    Latitude FLOAT NULL,
    Longitude FLOAT NULL,
    PhonePrefix FLOAT NULL,
    Active BIT NOT NULL,
    IsDeleted BIT NOT NULL,
    CreateBy INT NULL,
    CreateOn DATETIME NULL,
    UpdateBy INT NULL,
    UpdateOn DATETIME NULL
    )  ON [PRIMARY]
GO


ALTER TABLE R_Country ADD CONSTRAINT
    PK_R_Country PRIMARY KEY CLUSTERED 
    (
    CountryId
    ) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO

/************************************************************/
/*****              R_District                    *****/
/************************************************************/

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[R_District]') AND type in (N'U'))
DROP TABLE [R_District]
GO

CREATE TABLE R_District
    (
    DistrictId INT NOT NULL IDENTITY (1, 1),
    CountryId INT NULL,
    Name nvarchar(max) NULL,
    Code nvarchar(max) NULL,
    Latitude FLOAT NULL,
    Longitude FLOAT NULL,
    Active BIT NOT NULL,
    IsDeleted BIT NOT NULL,
    CreateBy INT NULL,
    CreateOn DATETIME NULL,
    UpdateBy INT NULL,
    UpdateOn DATETIME NULL
    )  ON [PRIMARY]
GO


ALTER TABLE R_District ADD CONSTRAINT
    PK_R_District PRIMARY KEY CLUSTERED 
    (
    DistrictId
    ) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO

/************************************************************/
/*****              R_County                    *****/
/************************************************************/

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[R_County]') AND type in (N'U'))
DROP TABLE [R_County]
GO

CREATE TABLE R_County
    (
    CountyId INT NOT NULL IDENTITY (1, 1),
    DistrictId INT NULL,
    CountryId INT NULL,
    Name nvarchar(max) NULL,
    Code nvarchar(max) NULL,
    Latitude FLOAT NULL,
    Longitude FLOAT NULL,
    Active BIT NOT NULL,
    IsDeleted BIT NOT NULL,
    CreateBy INT NULL,
    CreateOn DATETIME NULL,
    UpdateBy INT NULL,
    UpdateOn DATETIME NULL
    )  ON [PRIMARY]
GO


ALTER TABLE R_County ADD CONSTRAINT
    PK_R_County PRIMARY KEY CLUSTERED 
    (
    CountyId
    ) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO

/************************************************************/
/*****              R_Parish                    *****/
/************************************************************/

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[R_Parish]') AND type in (N'U'))
DROP TABLE [R_Parish]
GO

CREATE TABLE R_Parish
    (
    ParishId INT NOT NULL IDENTITY (1, 1),
    CountyId INT NULL,
    DistrictId INT NULL,
    CountryId INT NULL,
    Name nvarchar(max) NULL,
    Code nvarchar(max) NULL,
    Latitude FLOAT NULL,
    Longitude FLOAT NULL,
    Active BIT NOT NULL,
    IsDeleted BIT NOT NULL,
    CreateBy INT NULL,
    CreateOn DATETIME NULL,
    UpdateBy INT NULL,
    UpdateOn DATETIME NULL
    )  ON [PRIMARY]
GO


ALTER TABLE R_Parish ADD CONSTRAINT
    PK_R_Parish PRIMARY KEY CLUSTERED 
    (
    ParishId
    ) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO


