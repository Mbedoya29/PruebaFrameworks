-- Active: 1717530141832@@bfej1h5hfgk0jn4nzdmd-mysql.services.clever-cloud.com@3306
CREATE TABLE Owners(
    Id INT PRIMARY KEY AUTO_INCREMENT,
    Names VARCHAR(50),
    LastNames VARCHAR(50),
    Email VARCHAR(100) UNIQUE,
    Address VARCHAR(100),
    Phone VARCHAR(25)
);

CREATE TABLE Pets(
    Id INT PRIMARY KEY AUTO_INCREMENT,
    Name VARCHAR(25),
    Specie ENUM("Cat", "Dog"),
    Race ENUM ("Bulldog", "Persa"),
    DateBirth DATETIME,
    OwnerId INT,
    Photo TEXT,
    FOREIGN KEY (OwnerId) REFERENCES Owners(Id)
);

CREATE TABLE Vets(
    Id INT PRIMARY KEY AUTO_INCREMENT,
    Name VARCHAR(120),
    Phone VARCHAR(30),
    Address VARCHAR(30),
    Email VARCHAR(100) UNIQUE
);

CREATE TABLE Quotes(
    Id INT PRIMARY KEY AUTO_INCREMENT,
    Date DATETIME,
    PetId INT,
    VetId INT,
    Description TEXT,
    FOREIGN KEY (PetId) REFERENCES Pets(Id),
    FOREIGN KEY (VetId) REFERENCES Vets(Id)
);

DROP TABLE Quotes

INSERT INTO Owners (Names, LastNames, Email, Address, Phone) VALUES ('Jhon', 'Puerta', 'jhon@gmail.com', 'calle 24', '123456');
INSERT INTO Pets (Name, Specie, Race, DateBirth, OwnerId, Photo) VALUES ('Tito', 2, 1, '2015-05-15T03:00:00', 1, 'foto1');
INSERT INTO Vets (Name, Phone, Address, Email) VALUES ('Vet1', '12345678', 'calle 34', 'vet1@gmail.com');
INSERT INTO Quotes (Date, PetId, VetId, Description) VALUES ('2024-06-15T05:30:00', 1, 1, 'cita1');

