-- Creación de la tabla Producto
CREATE TABLE Producto (
  SKU varchar(50) NOT NULL,
  GTIN varchar(50) NOT NULL,
  thumbnail_url varchar(2083) DEFAULT NULL,
  nombre varchar(255) NOT NULL,
  PRIMARY KEY (SKU, GTIN)
);

-- Insertando datos en la tabla Producto
INSERT INTO Producto (SKU, GTIN, thumbnail_url, nombre) 
VALUES 
  ('001', '001', '', 'Producto1'),
  ('002', '002', '', 'Producto2'),
  ('003', '003', '', 'Producto3'),
  ('004', '004', '', 'Producto4'),
  ('005', '005', '', 'producto5'),
  ('006', '006', '', 'producto6');