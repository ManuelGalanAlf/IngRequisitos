-- MySQL dump 10.13  Distrib 8.0.40, for Win64 (x86_64)
--
-- Host: database-minipim.cdwgeayaeh1v.eu-central-1.rds.amazonaws.com    Database: grupo17DB
-- ------------------------------------------------------
-- Server version	8.0.39

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;
SET @MYSQLDUMP_TEMP_LOG_BIN = @@SESSION.SQL_LOG_BIN;
SET @@SESSION.SQL_LOG_BIN= 0;

--
-- GTID state at the beginning of the backup 
--

SET @@GLOBAL.GTID_PURGED=/*!80000 '+'*/ '';

--
-- Table structure for table `ValorAtributo`
--

DROP TABLE IF EXISTS `ValorAtributo`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `ValorAtributo` (
  `producto_sku` varchar(50) NOT NULL,
  `producto_gtin` varchar(50) NOT NULL,
  `atributo_nombre` varchar(255) NOT NULL,
  `valor` varchar(255) NOT NULL,
  PRIMARY KEY (`producto_sku`,`producto_gtin`,`atributo_nombre`),
  KEY `ValorAtributo_ibfk_2` (`atributo_nombre`),
  CONSTRAINT `ValorAtributo_ibfk_1` FOREIGN KEY (`producto_sku`, `producto_gtin`) REFERENCES `Producto` (`SKU`, `GTIN`) ON DELETE CASCADE,
  CONSTRAINT `ValorAtributo_ibfk_2` FOREIGN KEY (`atributo_nombre`) REFERENCES `Atributo` (`nombre`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `ValorAtributo`
--

LOCK TABLES `ValorAtributo` WRITE;
/*!40000 ALTER TABLE `ValorAtributo` DISABLE KEYS */;
INSERT INTO `ValorAtributo` VALUES ('001','001','Detalle','45'),('003','003','Detalle','30'),('003','003','Precio','15'),('003','003','Tamaño','10');
/*!40000 ALTER TABLE `ValorAtributo` ENABLE KEYS */;
UNLOCK TABLES;
SET @@SESSION.SQL_LOG_BIN = @MYSQLDUMP_TEMP_LOG_BIN;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2024-12-03  0:05:20
