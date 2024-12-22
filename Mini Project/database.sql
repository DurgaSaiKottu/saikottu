use sql
----table trains

CREATE TABLE Trains(

    TrainNo INT  PRIMARY KEY,

    TrainName VARCHAR(50),

    TotalBerths INT NOT NULL,

    AvailbleBerths INT NOT NULL,

    ClassType VARCHAR(50),

    Source VARCHAR(50),

    Destination NVARCHAR(100),

    IsActive BIT NOT NULL

); 

select * from Trains
 
 --Table bookings

CREATE TABLE Bookings (
   BookingId INT IDENTITY(1,1) PRIMARY KEY,
   TrainNo INT NOT NULL FOREIGN KEY References trains(TrainNo),
   PassengerName VARCHAR(255),
   TicketsBooked INT,
   BookingStatus VARCHAR(50),
   IsTicketBooked BIT NOT NULL,
   IsTicketCancelled BIT NOT NULL,
    
);
----drop table Bookings

select* from Bookings

--add train

CREATE  or Alter PROCEDURE sp_AddTrain
   @TrainNo INT,
   @TrainName NVARCHAR(50),
   @TotalBerths INT,
   @AvailbleBerths INT,
   @ClassType VARCHAR(50),
   @Source VARCHAR(50),
   @Destination VARCHAR(50),
   @IsActive BIT
AS
BEGIN
IF EXISTS (
       SELECT 1
       FROM Trains
       WHERE TrainNo = @TrainNo
   )
   BEGIN
       RAISERROR ('A train number already exists.', 16, 1);
       RETURN;
   END
   INSERT INTO Trains (TrainNo, TrainName, TotalBerths, AvailbleBerths, ClassType, Source, Destination, IsActive)
   VALUES (@TrainNo, @TrainName, @TotalBerths, @AvailbleBerths, @ClassType, @Source, @Destination, @IsActive);
END;

------BookTicket

CREATE or alter PROCEDURE sp_BookTicket
   @TrainNO INT,
   @PassengerName VARCHAR(50),
   @TicketsBooked INT,
   @BookingStatus VARCHAR(50),
   @IsTicketBooked BIT
   
AS
BEGIN
   DECLARE @AvailableBerths INT, @TrainNumber INT, @IsActive BIT;
   SELECT @AvailableBerths = AvailbleBerths, @TrainNumber = TrainNo, @IsActive = IsActive
   FROM Trains
   WHERE @TrainNo = TrainNo;
IF @TrainNumber IS NULL
   BEGIN
       RAISERROR('Train with the given TrainNumber does not exist.', 16, 1);
       RETURN;
   END
IF @IsActive = 0
   BEGIN
       RAISERROR('Train is not active. Booking cannot be done.', 16, 1);
       RETURN;
   END
   BEGIN
       INSERT INTO Bookings (TrainNo, PassengerName,Ticketsbooked, BookingStatus, IsTicketBooked, IsTicketCancelled)
       VALUES (@TrainNo, @PassengerName, @TicketsBooked,@BookingStatus, @IsTicketBooked, 0);
       UPDATE Trains
       SET AvailbleBerths = @AvailableBerths - @TicketsBooked
       WHERE TrainNo = @TrainNo;
    END
 
END

select * from Trains
select * from Bookings

exec sp_BookTicket


-----CancelTicket

CREATE or Alter PROCEDURE sp_CancelTicket
   @BookingId INT,
   @BookingStatus VARCHAR(50)
AS
BEGIN
   DECLARE @TrainNumber INT,@TicketsBooked INT, @IsTicketBooked BIT;
   SELECT @TrainNumber = TrainNo,@TicketsBooked = TicketsBooked, @IsTicketBooked = IsTicketBooked
   FROM Bookings
   WHERE BookingId = @BookingId;
   IF @IsTicketBooked = 1
   BEGIN
       UPDATE Trains
       SET AvailbleBerths = AvailbleBerths + @TicketsBooked
       WHERE TrainNo = @TrainNumber;
       UPDATE Bookings
       SET IsTicketCancelled = 1, BookingStatus = @BookingStatus
       WHERE BookingId = @BookingId;
   END
   ELSE
   BEGIN
       RAISERROR('Ticket not booked or already cancelled.', 16, 1);
   END
END;

select * from Bookings
select*from Trains


----DeleteTrain

CREATE or ALTER PROCEDURE sp_DeleteTrain
   @TrainNumber INT
AS
BEGIN
   IF NOT EXISTS (SELECT 1 FROM Trains WHERE TrainNo = @TrainNumber)
   BEGIN
       RAISERROR ('Train not found.', 16, 1);
       RETURN;
   END
   UPDATE Trains
   SET IsActive = 0
   WHERE TrainNo = @TrainNumber;
END;


-----ModifyTrain

CREATE or ALTER PROCEDURE sp_ModifyTrain
   @TrainNumber INT,
   @TrainName VARCHAR(50),
   @TotalBerths INT,
   @AvailbleBerths INT,
   @ClassType VARCHAR(50),
   @Source VARCHAR(50),
   @Destination VARCHAR(50),
   @IsActive BIT
AS
BEGIN
   IF NOT EXISTS (SELECT 1 FROM Trains WHERE TrainNo = @TrainNumber)
   BEGIN
       RAISERROR ('Train not found.', 16, 1);
       RETURN;
   END
   IF EXISTS (SELECT 1 FROM Trains WHERE TrainName = @TrainName AND TrainNo <> @TrainNumber)
   BEGIN
       RAISERROR ('A train with the same name already exists.', 16, 1);
       RETURN;
   END
   UPDATE Trains
   SET TrainName = @TrainName, TotalBerths = @TotalBerths, AvailbleBerths = @AvailbleBerths,
       ClassType = @ClassType, Source = @Source, Destination = @Destination, IsActive = @IsActive
   WHERE TrainNo = @TrainNumber;
END;


select*from Trains
-----ShowAllTrains

CREATE or Alter PROCEDURE sp_ShowAllTrains
AS
BEGIN
    SELECT TrainNo, TrainName, TotalBerths, AvailbleBerths, ClassType, Source, Destination, IsActive
    FROM Trains;
END



------ShowBookings

CREATE  or ALTER PROCEDURE sp_ShowBookings
AS
BEGIN
   SELECT BookingId, TrainNo, PassengerName, BookingStatus, IsTicketBooked, IsTicketCancelled
   FROM Bookings;
END;


select * from Trains


select * from Bookings







