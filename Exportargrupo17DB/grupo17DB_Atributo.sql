-- Creación de la tabla Atributo con restricción CHECK para simular ENUM
CREATE TABLE Atributo (
  nombre varchar(255) NOT NULL,
  tipo varchar(50) NOT NULL,
  PRIMARY KEY (nombre),
  CONSTRAINT CHK_Tipo CHECK (tipo IN ('Entero', 'Real', 'Cadena'))
);

-- Insertando datos en la tabla Atributo
INSERT INTO Atributo (nombre, tipo) 
VALUES 
  ('Coste', 'Cadena'),
  ('Detalle', 'Cadena'),
  ('Precio', 'Real'),
  ('Tamaño', 'Real');
