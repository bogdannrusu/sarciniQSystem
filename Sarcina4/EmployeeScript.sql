CREATE DATABASE Employee;
USE Employee;

CREATE TABLE JobTitles (
    Id INT PRIMARY KEY IDENTITY(1,1),
    Title NVARCHAR(100) NOT NULL,
    BaseSalary DECIMAL(10,2) NOT NULL
);

CREATE TABLE Employees (
    Id INT PRIMARY KEY IDENTITY(1,1),
    FullName NVARCHAR(150) NOT NULL,
    DateOfBirth DATE NOT NULL,
    EmploymentDate DATE NOT NULL,
    JobTitleId INT NOT NULL,
    FOREIGN KEY (JobTitleId) REFERENCES JobTitles(Id)
);

-- Inserăm câteva funcții
INSERT INTO JobTitles (Title, BaseSalary)
VALUES 
('Programator', 12000),
('Manager HR', 15000),
('Contabil', 10000);

-- Inserăm câțiva angajați
INSERT INTO Employees (FullName, DateOfBirth, EmploymentDate, JobTitleId)
VALUES 
('Ion Popescu', '1985-05-10', '2020-01-15', 1),
('Maria Ionescu', '1978-11-02', '2019-03-01', 2),
('Andrei Radu', '1992-07-25', '2021-06-10', 3);


