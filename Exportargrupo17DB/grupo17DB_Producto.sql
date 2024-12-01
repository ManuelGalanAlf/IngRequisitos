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
-- Table structure for table `Producto`
--

DROP TABLE IF EXISTS `Producto`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `Producto` (
  `SKU` varchar(50) NOT NULL,
  `GTIN` varchar(50) NOT NULL,
  `thumbnail_url` varchar(2083) DEFAULT NULL,
  `nombre` varchar(255) NOT NULL,
  PRIMARY KEY (`SKU`,`GTIN`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `Producto`
--

LOCK TABLES `Producto` WRITE;
/*!40000 ALTER TABLE `Producto` DISABLE KEYS */;
INSERT INTO `Producto` VALUES ('001','001','','Producto1'),('002','002','','Producto2'),('003','003','','Producto3'),('004','004','','Producto4'),('005','005','','producto5'),('006','006','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','producto6');
/*!40000 ALTER TABLE `Producto` ENABLE KEYS */;
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

-- Dump completed on 2024-12-03  0:05:22
