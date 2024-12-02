-- Creación de la tabla ValorAtributo
CREATE TABLE ValorAtributo (
  producto_sku VARCHAR(50) NOT NULL,
  producto_gtin VARCHAR(50) NOT NULL,
  atributo_nombre VARCHAR(255) NOT NULL,
  valor VARCHAR(255) NOT NULL,
  PRIMARY KEY (producto_sku, producto_gtin, atributo_nombre),
  
  -- Clave foránea para producto
  CONSTRAINT FK_ValorAtributo_Producto
    FOREIGN KEY (producto_sku, producto_gtin)
    REFERENCES Producto(SKU, GTIN) ON DELETE CASCADE,
  
  -- Clave foránea para atributo
  CONSTRAINT FK_ValorAtributo_Atributo
    FOREIGN KEY (atributo_nombre)
    REFERENCES Atributo(nombre) ON DELETE CASCADE ON UPDATE CASCADE
);

-- Insertando datos en la tabla ValorAtributo
INSERT INTO ValorAtributo (producto_sku, producto_gtin, atributo_nombre, valor) 
VALUES 
  ('001', '001', 'Detalle', '45'),
  ('003', '003', 'Detalle', '30'),
  ('003', '003', 'Precio', '15'),
  ('003', '003', 'Tamaño', '10');
