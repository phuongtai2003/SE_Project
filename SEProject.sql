create database SEProject;

CREATE TABLE Customer(
	userId int IDENTITY(1,1),
	personalId VARCHAR(10),
	userName VARCHAR(30),
	userPassword VARCHAR(30), 
)
ALTER TABLE Customer
ADD CONSTRAINT PK_Customer PRIMARY KEY(userId);

SELECT * FROM Customer

CREATE TABLE Destination(
	destinationId int Identity(1,1),
	destNum NVARCHAR(30),
	destRoad NVARCHAR(30),
	destWard NVARCHAR(30),
	destDistrict NVARCHAR(30),
	CONSTRAINT PK_Dest PRIMARY KEY (destinationId),
)

INSERT INTO Destination (destNum, destRoad, destWard, destDistrict) VALUES (N'123', N'Nguyễn Tri Phương', N'3', N'5');
INSERT INTO Destination (destNum, destRoad, destWard, destDistrict) VALUES (N'324', N'An Dương Vương', N'4', N'12');
INSERT INTO Destination (destNum, destRoad, destWard, destDistrict) VALUES (N'4', N'Nguyễn Chí Thanh', N'5', N'12');

CREATE TABLE CreditCard(
	cardId int Identity(1,1),
	cardNum VARCHAR(30),
	cardExpiredMonth INT,
	cardExpiredYear INT,
	securityCode VARCHAR(10),
	balance float,
	CONSTRAINT PK_CreditCard PRIMARY KEY (cardId),
)

INSERT INTO CreditCard (cardNum, cardExpiredMonth, cardExpiredYear, securityCode, balance) VALUES ('4123523461254123', 5, 2027, '204', 100);
INSERT INTO CreditCard (cardNum, cardExpiredMonth, cardExpiredYear, securityCode, balance) VALUES ('4125325212423423', 2, 2025, '554', 40);
INSERT INTO CreditCard (cardNum, cardExpiredMonth, cardExpiredYear, securityCode, balance) VALUES ('5323421421352452', 12, 2026, '341', 70);

SELECT * FROM CreditCard


CREATE TABLE Ticket(
	ticketId int Identity(1,1),
	destId int,
	customerId int,
	amount float,
	CONSTRAINT FK_Ticket_DestID FOREIGN KEY (destId) REFERENCES Destination(destinationId),
	CONSTRAINT FK_Ticket_CustomerID FOREIGN KEY (customerId) REFERENCES Customer(userId),
	CONSTRAINT PK_Ticket PRIMARY KEY (ticketId, destId, customerId),
);

SELECT * FROM Ticket