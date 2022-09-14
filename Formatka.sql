CREATE DATABASE Formatka

GO

USE Formatka

GO

--Tworzę tabele Customers
CREATE TABLE [dbo].[Customers] (
    [Id]INT IDENTITY (1, 1) NOT NULL,
    [First_Name] NVARCHAR (30) NOT NULL,
    [Surname] NVARCHAR (60) NOT NULL,
    [PESEL] VARCHAR (11)NOT NULL,
    [Id_card_number] VARCHAR (9)NOT NULL,
	[Mail] VARCHAR (60) NULL,
    [Phone_Number] VARCHAR (9) NULL,
    [Main_Address] NVARCHAR (200)NOT NULL,
    [Correspondence_Address] NVARCHAR (200)NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
	CONSTRAINT C_UNIQUE_ID UNIQUE(Id)
);
GO

--Tworzę tabele Service_Type
CREATE TABLE [dbo].[Service_Type](
	[Id] INT PRIMARY KEY IDENTITY,
	[Name] NVARCHAR (100) NOT NULL
);
GO

--Tworzę tabele Service_Name
CREATE TABLE [dbo].[Service_Name](
	[Id] INT PRIMARY KEY IDENTITY,
	[Name] nvarchar (50) NOT NULL,
	[Amount_of_internet] INT NULL,
	[Amount_of_TV_channels] INT NULL,
	[Price] MONEY NOT NULL,
	[Description] nvarchar (500) NULL,
	[Id_Service_Type] INT FOREIGN KEY REFERENCES Service_Type(Id) NOT NULL
);
GO


--Tworzę tabele Orders
CREATE TABLE [dbo].Orders(
	[Id] [INT] PRIMARY KEY IDENTITY,
	[Id_Customer] [INT] FOREIGN KEY REFERENCES Customers(Id) NOT NULL,
	[Id_Service] [INT] FOREIGN KEY REFERENCES [Service_Name](Id) NOT NULL,
	[Delivery_date] varchar (40) NOT NULL,
	[Date_of_order] varchar (40) NOT NULL
);
GO


INSERT INTO [dbo].[Customers] (
[First_Name], [Surname], [PESEL], [Id_card_number], [Mail], [Phone_Number], [Main_Address], [Correspondence_Address]) 
VALUES 
('Gracjan','Mróz','99023197940','FIC959150','GracjanMroz@gmail.com','644762113','Lublin Rolna Osada 25', 'ul. Jarocińska 116 04-171 Warszawa'),
('Franciszek','Zawadzki','74022861150','UFH445818','FranciszekZawadzki@interia.pl','297872009','Warszawa Rumby 78a/286','Warszawa Rumby 78a/286'),
('Kamil','Szewczyk','95071868135','QMO204785','KamilSzewczyk@outlook.com','344390025','Sopot 3 Maja 65','Sopot 3 Maja 65'),
('Urszula','Szewczyk','55083125003','VZW461120',NULL,'628058160','Warszawa Bruna 6/345','Warszawa Bruna 6/345'),
('Dawid','Andrzejewski','68112318295','RNZ071913','DawidAndrzejewski@o2.pl','126592704','Skoroszyce Braterstwa Broni 114/7','ul. Pankiewicza Józefa 78 31-999 Kraków'),
('Kinga','Szulc','89040912312','HHF272163','KingaSzulc@tlen.pl','471158469','Poznań Podlaska 44','ul. Abrahama Antoniego 43 81-833 Sopot'),
('Kinga','Sikorska','81033044931','SHU128529','KingaSikorska@.gmail.com','639745692','Toruń Sobieskiego 122/14','Toruń Sobieskiego 122/14'),
('Halina','Baran','34833020425','NCV309349',NULL,'123456789','Krakow Długa 18/4a','Krakow Długa 18/4a'),
('Błażej','Włodarczyk','46033197009','ZVL433670','jacek123@gmail.com','456897285','Łódź Moniuszki Stanisława 137','Łódź Moniuszki Stanisława 137'),
('Ida','Lis','79043011001','QBY262544','lisek.skrzynka@outlook.com','504668974','Łódź Sierakowskiego Zygmunta 38','Łódź Sierakowskiego Zygmunta 38'),
('Daria','Piotrowska','77093090814','SLX628264',NULL,'519806259','ul. Mestwina 131a/140 03-175 Warszawa','ul. Świętej Teresy 49 91-222 Łódź'),
('Diego','Zalewski','64093025535','XCO496473','Diegokolego@onet.com.pl','665408221','ul. Brzechwy Jana 67 44-335 Jastrzębie-Zdrój','ul. Miodowa 52 35-303 Rzeszów'),
('Dorota','Kucharska','37022864110','JWQ909386','kuchenka5@gmail.com','501664498','ul. Lindego Samuela Bogumiła 28/13 01-995 Warszawa','ul. Irlandzka 111 03-909 Warszawa'),
('Eugeniusz','Rutkowski','91013151788','JGQ392032','EugeniuszRutkowski@interia.pl','889564289','ul. Kmieca 38/16 51-514 Wrocław','ul. Kmieca 38/16 51-514 Wrocław'),
('Marysia','Sawicka','60043027718','SHP119843','GracjanMroz@gmail.com','564258915','ul. Leżajska 138/2 61-315 Poznań','ul. Leżajska 138/2 61-315 Poznań'),
('Marzanna','Makowska','59082074248','KID143283','Marzanna.Makowska@wyrobycukierniczemarzanna.pl','504059870','Lublin Rolna Osada 6','ul. Samulowskiego Andrzeja 88 10-530 Olsztyn'),
('Amadeusz','Rutkowski','96112337098','ZEK609794',NULL,'881265312','ul. Kardynała Wyszyńskiego Stefana 138 41-600 Świętochłowice','ul. Trakcyjna 51 92-409 Staniątki'),
('Kornel','Duda','80051330706','IEM786001','GracjanMroz@gmail.com','501645895','ul. Morska 44/286 75-225 Koszalin','ul. Morska 44/286 75-225 Koszalin'),
('Amalia','Dąbrowska','73062990088','CLM753330',NULL,'519555555','Kraków Dywizjonu 303 64a/9','Kraków Dywizjonu 303 5/98'),
('Diana','Krawczyk','93013116259','BMZ015572','piter222444@o2.pl','721564201','ul. Dworcowa 14/5 32-540 Trzebinia','ul. Dworcowa 14/5 32-540 Trzebinia')

GO

--Uzupełniam tabele Kategorie_usług
INSERT INTO [Service_Type] (
 [Name])
VALUES 
('Mobilne'),
('Stacjonarne'),
('Konwergentne')
GO

--Uzupełniam tabele Usługi
INSERT INTO [Service_Name](
[Name],[Amount_of_internet],[Amount_of_TV_channels],[Price],[Description],[Id_Service_Type])
VALUES
('PM40',6,NULL,40,'numer komórkowy',1),
('PM50',24,NULL,50,'numer komórkowy',1),
('PM60',50,NULL,60,'numer komórkowy',1),
('PM80',105,NULL,80,'numer komórkowy',1),
('Internet',NULL,NULL,60,'internet stacjonarny',2),
('Internet z TV',NULL,120,100,'internet stacjonarny, telewizja (TV)',2),
('Pakiet Standard',30,120,110,'numer komórkowy, internet stacjonarny, telewizja (TV)',3),
('Pakiet Extra',50,179,160,'numer komórkowy, internet stacjonarny, telewizja (TV)',3),
('Pakiet Premium',80,191,210,'numer komórkowy, internet stacjonarny, telewizja (TV)',3)
GO


--Uzupełniam tabele Zamówienia 24 rekordami
INSERT INTO [Orders] (
 [Id_Customer],[Id_Service],[Delivery_date],[Date_of_order])
VALUES 
(6,2,'08-09-2022','2021-11-14'),
(5,7,'08-09-2022','2021-12-03'),
(14,8,'08-09-2022','2021-12-17'),
(7,2,'08-09-2022','2021-12-18'),
(8,7,'08-09-2022','2021-12-21'),
(12,5,'08-09-2022','2021-12-22'),
(17,8,'08-09-2022','2021-12-22'),
(4,2,'08-09-2022','2021-12-23'),
(13,9,'08-09-2022','2021-12-27'),
(7,6,'08-09-2022','2022-01-02'),
(12,7,'08-09-2022','2022-01-05'),
(17,3,'08-09-2022','2022-01-10'),
(20,2,'08-09-2022','2022-01-14'),
(3,8,'08-09-2022','2022-01-21'),
(8,1,'08-09-2022','2022-01-24'),
(4,7,'08-09-2022','2022-01-24'),
(15,4,'08-09-2022','2022-01-25'),
(9,6,'08-09-2022','2022-01-25'),
(2,5,'08-09-2022','2022-01-29'),
(18,2,'08-09-2022','2022-01-31'),
(10,7,'08-09-2022','2022-01-31'),
(16,8,'08-09-2022','2022-02-01'),
(19,3,'08-09-2022','2022-02-02'),
(11,7,'08-09-2022','2022-02-02'),
(1,6,'08-09-2022','2022-02-03')
GO


CREATE PROCEDURE [dbo].[addCustomer]
	@pFirst_Name NVARCHAR(30),
	@pSurname NVARCHAR (60),
	@pPESEL VARCHAR(11),
	@pId_card_number VARCHAR(9),
	@pMail VARCHAR (60),
	@pPhone_Number VARCHAR (9),
	@pMain_Address NVARCHAR (200),
	@pCorrespondence_Address NVARCHAR (200)
AS
	INSERT INTO Customers (First_Name, Surname, PESEL, Id_card_number, Mail, Phone_Number, Main_Address, Correspondence_Address) VALUES (@pFirst_Name,@pSurname,@pPESEL,@pId_card_number,@pMail,@pPhone_Number,@pMain_Address,@pCorrespondence_Address);

GO

CREATE PROCEDURE [dbo].[addOrder]
	@pId_Customer INT,
	@pId_Service INT,
	@pDelivery_date varchar,
	@pDate_of_order DATE
AS
	INSERT INTO Orders (Id_Customer, Id_Service,Delivery_date, Date_of_order) VALUES (@pId_Customer,@pId_Service,@pDelivery_date,@pDate_of_order);

GO




CREATE PROCEDURE [dbo].[deleteRecord]
	@pID int
AS
	DELETE Customers
	WHERE id = @pID;

GO

CREATE PROCEDURE dbo.[searchRecords]
	@PESELPhrase VARCHAR(11)
AS
	declare @param VARCHAR(11)
	set @param = '%' + @PESELPhrase + '%' 

	SELECT * FROM Customers WHERE PESEL LIKE @param;

GO