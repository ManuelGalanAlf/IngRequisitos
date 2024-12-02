CREATE TABLE ProductoCategoria (
  producto_sku varchar(50) NOT NULL,
  producto_gtin varchar(50) NOT NULL,
  categoria_nombre varchar(255) NOT NULL,
  PRIMARY KEY (producto_sku, producto_gtin, categoria_nombre)
);

-- Insertando datos en la tabla
INSERT INTO ProductoCategoria (producto_sku, producto_gtin, categoria_nombre) 
VALUES 
  ('001', '001', 'Categoria1'),
  ('004', '004', 'Categoria1'),
  ('005', '005', 'Categoria1'),
  ('001', '001', 'Categoria3'),
  ('004', '004', 'Categoria3');
