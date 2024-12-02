-- Creación de la tabla Categoria
CREATE TABLE Categoria (
  nombre varchar(255) NOT NULL,
  numero_de_productos int DEFAULT 0,
  PRIMARY KEY (nombre)
);

-- Insertando datos en la tabla Categoria
INSERT INTO Categoria (nombre, numero_de_productos) 
VALUES 
  ('Categoria1', 1),
  ('Categoria3', 1);
