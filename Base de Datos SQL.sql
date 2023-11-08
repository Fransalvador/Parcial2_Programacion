--crear la base de datos
CREATE DATABASE BDParcial2FranciscoyHugo;

-- Usar la base de datos recién creada
USE BDParcial2FranciscoyHugo;

-- Crear la tabla 'Departamento'
CREATE TABLE Departamento (
    DepartamentoID INT IDENTITY(1,1) PRIMARY KEY,
    NombreDepartamento VARCHAR(50)
);

-- Crear la tabla 'Municipio'
CREATE TABLE Municipio (
    MunicipioID INT IDENTITY(1,1) PRIMARY KEY,
    NombreMunicipio VARCHAR(50),
    DepartamentoID INT,
    CONSTRAINT FK_Municipio_Departamento
    FOREIGN KEY (DepartamentoID) REFERENCES Departamento(DepartamentoID)
);

-- Crear la tabla 'Cliente'
CREATE TABLE Cliente (
    ClienteID INT IDENTITY(1,1) PRIMARY KEY,
    Nombre VARCHAR(50),
    Apellido VARCHAR(50),
    DepartamentoID INT,
    MunicipioID INT,
    CONSTRAINT FK_Cliente_Departamento
    FOREIGN KEY (DepartamentoID) REFERENCES Departamento(DepartamentoID),
    CONSTRAINT FK_Cliente_Municipio
    FOREIGN KEY (MunicipioID) REFERENCES Municipio(MunicipioID)
);

-- Insertar 4 departamentos
INSERT INTO Departamento (NombreDepartamento) VALUES
('San Salvador'),
('San Miguel'),
('La Libertad'),
('Santa Ana');

-- Insertar 3 municipios por departamento
INSERT INTO Municipio (NombreMunicipio, DepartamentoID) VALUES
('San Salvador', 1),
('Santa Tecla', 1),
('Soyapango', 1),
('San Miguel', 2),
('Moncagua', 2),
('Quelepa', 2),
('Antiguo Cuscatlan', 3),
('Colon', 3),
('La Libertad', 3),
('Santa Ana', 4),
('Metapan', 4),
('Chalchuapa', 4);

-- Insertar 2 clientes
INSERT INTO Cliente (Nombre, Apellido, DepartamentoID, MunicipioID) VALUES
('Francisco', 'Moreno', 1, 1);


-- Realizar la consulta JOIN para unir tablas
SELECT Cliente.Nombre, Cliente.Apellido, Departamento.NombreDepartamento, Municipio.NombreMunicipio
FROM Cliente
JOIN Departamento ON Cliente.DepartamentoID = Departamento.DepartamentoID
JOIN Municipio ON Cliente.MunicipioID = Municipio.MunicipioID;

Select * from Cliente 