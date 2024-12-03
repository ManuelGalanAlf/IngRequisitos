
-- Seleccionar la base de datos
USE grupo17_DB;
GO
-- Tabla Categoria
IF OBJECT_ID('Categoria', 'U') IS NOT NULL
    DROP TABLE Categoria;

CREATE TABLE Categoria (
  nombre VARCHAR(255) NOT NULL PRIMARY KEY,
  numero_de_productos INT DEFAULT 0
);

-- Insertar datos en Categoria
INSERT INTO Categoria (nombre, numero_de_productos)
VALUES 
  ('Categoria1', 1),
  ('Categoria3', 1);

-- Tabla Atributo
IF OBJECT_ID('Atributo', 'U') IS NOT NULL
    DROP TABLE Atributo;

CREATE TABLE Atributo (
  nombre VARCHAR(255) NOT NULL PRIMARY KEY,
  tipo VARCHAR(10) NOT NULL
);

-- Validación manual para "tipo" en SQL Server
-- Insertar datos en Atributo
INSERT INTO Atributo (nombre, tipo)
VALUES 
  ('Coste', 'Cadena'),
  ('Detalle', 'Cadena'),
  ('Precio', 'Real'),
  ('Tamaño', 'Real');

-- Tabla Producto
IF OBJECT_ID('Producto', 'U') IS NOT NULL
    DROP TABLE Producto;

CREATE TABLE Producto (
  SKU VARCHAR(50) NOT NULL,
  GTIN VARCHAR(50) NOT NULL,
  nombre VARCHAR(255) NOT NULL,
  categoria_nombre VARCHAR(255) NOT NULL,
  PRIMARY KEY (SKU, GTIN),
  FOREIGN KEY (categoria_nombre) REFERENCES Categoria (nombre) ON DELETE CASCADE
);

-- Insertar datos en Producto
INSERT INTO Producto (SKU, GTIN, nombre, categoria_nombre)
VALUES 
  ('001', '001', 'Producto1', 'Categoria1'),
  ('003', '003', 'Producto3', 'Categoria3');

-- Tabla ValorAtributo
IF OBJECT_ID('ValorAtributo', 'U') IS NOT NULL
    DROP TABLE ValorAtributo;

CREATE TABLE ValorAtributo (
  producto_sku VARCHAR(50) NOT NULL,
  producto_gtin VARCHAR(50) NOT NULL,
  atributo_nombre VARCHAR(255) NOT NULL,
  valor VARCHAR(255) NOT NULL,
  PRIMARY KEY (producto_sku, producto_gtin, atributo_nombre),
  FOREIGN KEY (producto_sku, producto_gtin) REFERENCES Producto (SKU, GTIN) ON DELETE CASCADE,
  FOREIGN KEY (atributo_nombre) REFERENCES Atributo (nombre) ON DELETE CASCADE
);

-- Insertar datos en ValorAtributo
INSERT INTO ValorAtributo (producto_sku, producto_gtin, atributo_nombre, valor)
VALUES 
  ('001', '001', 'Detalle', '45'),
  ('003', '003', 'Detalle', '30'),
  ('003', '003', 'Precio', '15'),
  ('003', '003', 'Tamaño', '10');



USE
grupo17_DB;
GO
-- Crear la tabla productoCategoria
CREATE TABLE productoCategoria (
    producto_sku VARCHAR(10),
    producto_gtin VARCHAR(10),
    categoria_nombre VARCHAR(50),
    PRIMARY KEY (producto_sku, producto_gtin, categoria_nombre)
);

-- Insertar datos en la tabla
INSERT INTO productoCategoria (producto_sku, producto_gtin, categoria_nombre) VALUES
('001', '001', 'Categoria1'),
('004', '004', 'Categoria1'),
('005', '005', 'Categoria1'),
('001', '001', 'Categoria3'),
('004', '004', 'Categoria3');

