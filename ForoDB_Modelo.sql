-- Creaci�n de la base de datos
IF EXISTS (SELECT * FROM sys.databases WHERE name = 'ForoDB_Modelo')
  DROP DATABASE ForoDB_Modelo;

CREATE DATABASE ForoDB_Modelo;
GO

USE ForoDB_Modelo;
GO

-- Creaci�n de la tabla cliente
IF OBJECT_ID('cliente', 'U') IS NOT NULL
  DROP TABLE cliente;
CREATE TABLE cliente (
    cliente_id INT IDENTITY(1,1) PRIMARY KEY,
    nombre VARCHAR(50),
	apellido VARCHAR(50),
    direccion VARCHAR(150),
    telefono VARCHAR(50),
    fechaNacimiento DATE,
    estado BIT
);

INSERT INTO cliente (nombre, apellido, direccion, telefono, fechaNacimiento, estado)
VALUES ('Juan', 'Ramirez', 'Direcci�n1', '1234567890', '1990-01-01', 1),
       ('Jose', 'Mendoza', 'Direcci�n2', '2345678901', '1990-02-02', 1),
       ('Pepe', 'Yanez', 'Direcci�n3', '3456789012', '1990-03-03', 0),
       ('Maria', 'Agudo', 'Direcci�n4', '4567890123', '1990-04-04', 1),
       ('Manuel', 'Cuesta', 'Direcci�n5', '5678901234', '1990-05-05', 0);