IF NOT EXISTS (
    SELECT name 
    FROM sys.databases 
    WHERE name = 'grupo17_DB'
)
BEGIN
    CREATE DATABASE grupo17_DB;
END;

USE
grupo17_DB;
GO

-- Tabla Categoria
CREATE TABLE Categoria (
    nombre VARCHAR(255) NOT NULL PRIMARY KEY,
    numero_de_productos INT DEFAULT 0
);

-- Tabla Atributo
CREATE TABLE Atributo (
    nombre VARCHAR(255) NOT NULL PRIMARY KEY,
    tipo VARCHAR(10) NOT NULL
);

-- Tabla Producto
CREATE TABLE Producto (
    SKU CHAR(14) NOT NULL,  -- Longitud fija de 14
    GTIN CHAR(14) NOT NULL, -- Longitud fija de 14
    nombre VARCHAR(255) NOT NULL,
    categoria_nombre VARCHAR(255) NOT NULL,
    PRIMARY KEY (SKU, GTIN),
    FOREIGN KEY (categoria_nombre) REFERENCES Categoria (nombre) ON DELETE CASCADE
);

-- Tabla ValorAtributo
CREATE TABLE ValorAtributo (
    producto_sku CHAR(14) NOT NULL,  -- Longitud fija de 14
    producto_gtin CHAR(14) NOT NULL, -- Longitud fija de 14
    atributo_nombre VARCHAR(255) NOT NULL,
    valor VARCHAR(255) NOT NULL,
    PRIMARY KEY (producto_sku, producto_gtin, atributo_nombre),
    FOREIGN KEY (producto_sku, producto_gtin) REFERENCES Producto (SKU, GTIN) ON DELETE CASCADE,
    FOREIGN KEY (atributo_nombre) REFERENCES Atributo (nombre) ON DELETE CASCADE
);

-- Tabla productoCategoria


CREATE TABLE ProductoCategoria (
    producto_sku CHAR(14) NOT NULL,  -- Longitud fija de 14
    producto_gtin CHAR(14) NOT NULL, -- Longitud fija de 14
    categoria_nombre VARCHAR(255) NOT NULL,
    PRIMARY KEY (producto_sku, producto_gtin, categoria_nombre),
    FOREIGN KEY (producto_sku, producto_gtin) REFERENCES Producto (SKU, GTIN) ON DELETE CASCADE,
    FOREIGN KEY (categoria_nombre) REFERENCES Categoria (nombre) ON DELETE NO ACTION -- Cambio a NO ACTION
);

-- Insertar datos en Categoria
INSERT INTO Categoria (nombre, numero_de_productos)
VALUES 
  ('Categoria1', 1),
  ('Categoria3', 1);

-- Insertar datos en Atributo
INSERT INTO Atributo (nombre, tipo)
VALUES 
  ('Coste', 'Cadena'),
  ('Detalle', 'Cadena'),
  ('Precio', 'Real'),
  ('Tamaño', 'Real');


INSERT INTO Producto (SKU, GTIN, nombre, categoria_nombre)
VALUES 
  ('001', '001', 'Producto1', 'Categoria1'),
  ('003', '003', 'Producto3', 'Categoria3'),
  ('004', '004', 'Producto4', 'Categoria1'),
  ('005', '005', 'Producto5', 'Categoria1');



INSERT INTO ValorAtributo (producto_sku, producto_gtin, atributo_nombre, valor)
VALUES 
  ('001', '001', 'Detalle', '45'),
  ('003', '003', 'Detalle', '30'),
  ('003', '003', 'Precio', '15'),
  ('003', '003', 'Tamaño', '10');



INSERT INTO ProductoCategoria (producto_sku, producto_gtin, categoria_nombre) VALUES
('001', '001', 'Categoria1'),
('004', '004', 'Categoria1'),
('005', '005', 'Categoria1'),
('001', '001', 'Categoria3'),
('004', '004', 'Categoria3');