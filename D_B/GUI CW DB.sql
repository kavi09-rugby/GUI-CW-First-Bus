--CREATE DATABASE First_Bus

CREATE TABLE Passenger
(
	PassengerEmail varchar(200) Primary key,
	PassengerFirstName varchar(100) Not Null,
	PassengerLastName varchar(100),
	PassengerGender varchar(20) Not Null,
	PassengerWhatsApp varchar(50) Not Null,
	PassengerPassword varchar(100) Not Null,
	PassengerStreet varchar(100) Not Null,
	PassengerCity varchar(100) Not Null
);

CREATE TABLE Bus_Routes
(
	RouteNumber varchar(100) Primary key,
	RouteName varchar(200) Not Null,
	Distance varchar(200) Not Null,
	TravelTime varchar(100) Not Null,
);

CREATE TABLE Bus
(
	BusRegisterNumber varchar(100) Primary key,
	BusName varchar(100) Not Null,
	BusType varchar(100) Not Null,
	BusPassword varchar(100) Not Null,
	BusWhatsApp varchar(20) Not Null,
	RouteNumber varchar(100) foreign key references Bus_Routes(RouteNumber)
);

CREATE TABLE Bus_Keeper
(
	BusKeeperID varchar(100) Primary key,
	BusKeeperFirstName varchar(100) Not Null,
	BusKeeperLastName varchar(100),
	BusKeeperPassword varchar(100) Not Null,
	BusStandName varchar(200) Not Null,
	BusKeeperEmail varchar(200) Not Null,
	BusKeeperWhatsApp varchar(20) Not Null
);

CREATE TABLE Bus_TimeTable
(
	BusRegisterNumber varchar(100) foreign key references Bus (BusRegisterNumber),
	RouteNumber varchar(100) foreign key references Bus_Routes(RouteNumber),
	BusTime varchar(100) Not Null, 
	BusAvailability varchar(100) Not Null,
);


INSERT INTO Passenger(PassengerEmail,PassengerFirstName,PassengerLastName,PassengerGender,PassengerWhatsApp,PassengerPassword,PassengerStreet,PassengerCity)
VALUES 
('abc@gmail.com','saman','silva','male','0771234567','123','temple road','galle'),
('xyz@gmail.com','alexa','perera','female','0764571356','xyz','lotus road','colombo')

INSERT INTO Bus_Routes(RouteNumber,RouteName,Distance,TravelTime)
VALUES
('R001','yakkalamulla','120km','2 hours'),
('R002','pilana','80km','1 hours')

INSERT INTO Bus(BusRegisterNumber,BusName,BusType,BusPassword,BusWhatsApp,RouteNumber)
VALUES
('B005','abesekara','private','b124','0741258796','R001'),
('B010','rathnaloka','private','b789','0767842135','R002')

INSERT INTO Bus_Keeper(BusKeeperID,BusKeeperFirstName,BusKeeperLastName,BusKeeperPassword,BusStandName,BusKeeperEmail,BusKeeperWhatsApp)
VALUES
('BK001','kamal','nishantha','bk123','galle','lmn@gmail.com','0751234781'),
('BK002','nimal','siriwardana','bk789','matara','pqr@gmail.com','0723459702')

INSERT INTO Bus_TimeTable(BusRegisterNumber,RouteNumber,BusTime,BusAvailability)
VALUES
('B005','R001','7.00 am','available'),
('B010','R002','10.30 am','not available')

SELECT*FROM Passenger
SELECT*FROM Bus_Routes
SELECT*FROM Bus
SELECT*FROM Bus_Keeper
SELECT*FROM Bus_TimeTable


SELECT * FROM Passenger WHERE PassengerEmail = 'abc@gmail.com' AND PassengerPassword = '123'

SELECT B.BusRegisterNumber,B.BusName,B.BusType,B.BusWhatsApp,R.RouteNumber,R.RouteName FROM Bus B JOIN Bus_Routes R ON B.RouteNumber = R.RouteNumber WHERE BusPassword = 'b124'