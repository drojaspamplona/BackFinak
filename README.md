# Backend en .NET 6

Este proyecto es una API desarrollada en .NET 6 para gestionar eventos "Logs". Utiliza C# y se basa en la arquitectura de Web API.

## Requisitos

Asegúrate de tener [Visual Studio](https://visualstudio.microsoft.com/) o [Visual Studio Code](https://code.visualstudio.com/) instalado con el [SDK de .NET 6](https://dotnet.microsoft.com/download/dotnet/6.0).

## Clonar el Repositorio

Para clonar este repositorio en tu máquina local, utiliza el siguiente comando:

```bash
git clone https://github.com/drojaspamplona/BackFinak



Configuración de la Base de Datos
Antes de ejecutar la aplicación, debes configurar la base de datos. Utiliza el siguiente script SQL para crear la base de datos y las tablas necesarias:
S

CREATE DATABASE LogsFinacktiva;
USE LogsFinacktiva;

CREATE SCHEMA Audit;

CREATE TABLE Audit.EventType(
    IdEventType INT PRIMARY KEY IDENTITY NOT NULL,
    EventType VARCHAR(100)
);

INSERT INTO Audit.EventType(EventType) VALUES ('Manual'),('Api');

CREATE TABLE Audit.EventLog(
    IdEventLog VARCHAR(200) PRIMARY KEY NOT NULL,
    EventDate DATETIME NOT NULL,
    DescriptionEvent VARCHAR(500) NOT NULL,
    IdEventType INT NOT NULL,
    CONSTRAINT FK_EventType FOREIGN KEY (IdEventType)
        REFERENCES Audit.EventType(IdEventType)
);

Asegúrate de cambiar la cadena de conexión en el archivo appsettings.json para que coincida con tu configuración de base de datos. El archivo debe tener un formato similar al siguiente:
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Database=LogsFinacktiva;User Id=usuario;Password=contraseña;"
  }
}
