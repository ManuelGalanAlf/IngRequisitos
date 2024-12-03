-- Crear la base de datos si no existe
IF NOT EXISTS (
    SELECT name 
    FROM sys.databases 
    WHERE name = 'grupo17_DB'
)
BEGIN
    CREATE DATABASE grupo17_DB;
END;
