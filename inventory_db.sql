-- MySQL dump 10.13  Distrib 8.0.31, for Win64 (x86_64)
--
-- Host: localhost    Database: inventory_db
-- ------------------------------------------------------
-- Server version	8.0.31

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

--
-- Table structure for table `tble_customers`
--

DROP TABLE IF EXISTS `tble_customers`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tble_customers` (
  `ID` int NOT NULL AUTO_INCREMENT,
  `CUSTOMERID` varchar(90) NOT NULL,
  `FIRSTNAME` varchar(90) NOT NULL,
  `LASTNAME` varchar(90) NOT NULL,
  `ADDRESS` varchar(90) NOT NULL,
  `MOBILE` varchar(30) NOT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=22 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tble_customers`
--

LOCK TABLES `tble_customers` WRITE;
/*!40000 ALTER TABLE `tble_customers` DISABLE KEYS */;
INSERT INTO `tble_customers` VALUES (12,'A1','Teena Mae','Bercasio','Aurora ZDS','09122911909'),(13,'A2','Camra','Hashim','Aurora ZDS','09128982911'),(14,'A3','Jamiecah Ann ','Quinco','Aurora ZDS','09122911909'),(15,'A4','Julaica ','Sungahid','Aurora ZDS','09122911987'),(16,'A5','Glen','Tiondo','Aurora ZDS','0911212211211'),(17,'A6','Danica','Ranque','Pagadian ZDS','09122909011');
/*!40000 ALTER TABLE `tble_customers` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tble_settings`
--

DROP TABLE IF EXISTS `tble_settings`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tble_settings` (
  `SETID` int NOT NULL AUTO_INCREMENT,
  `CATEGORYID` varchar(90) NOT NULL,
  `DESCRIPTION` varchar(990) NOT NULL,
  PRIMARY KEY (`SETID`)
) ENGINE=InnoDB AUTO_INCREMENT=23 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tble_settings`
--

LOCK TABLES `tble_settings` WRITE;
/*!40000 ALTER TABLE `tble_settings` DISABLE KEYS */;
INSERT INTO `tble_settings` VALUES (19,'1','Delo'),(20,'2','Castrol'),(21,'3','Havoline');
/*!40000 ALTER TABLE `tble_settings` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tble_stock_in_out`
--

DROP TABLE IF EXISTS `tble_stock_in_out`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tble_stock_in_out` (
  `STOCKOUTID` int NOT NULL AUTO_INCREMENT,
  `DATE` datetime DEFAULT NULL,
  `ITEMID` varchar(20) NOT NULL,
  `ITEM` longtext NOT NULL,
  `DESCRIPTION` longtext NOT NULL,
  `TYPE` varchar(50) NOT NULL,
  `TOTALPRICE` double NOT NULL,
  `QUANTITY` int NOT NULL,
  `CUSTOMERID` varchar(20) NOT NULL,
  PRIMARY KEY (`STOCKOUTID`)
) ENGINE=InnoDB AUTO_INCREMENT=124 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tble_stock_in_out`
--

LOCK TABLES `tble_stock_in_out` WRITE;
/*!40000 ALTER TABLE `tble_stock_in_out` DISABLE KEYS */;
INSERT INTO `tble_stock_in_out` VALUES (121,'2022-12-19 00:00:00','10','Gasoline Engine Oil','15w40','Delo',639,3,'A2'),(122,'2022-12-19 00:00:00','11','Diesel','20w50\n1Liter','Delo',1372,4,'A2'),(123,'2022-12-21 00:00:00','10','Gasoline Engine Oil','15w40','Delo',1917,9,'a1');
/*!40000 ALTER TABLE `tble_stock_in_out` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tble_stocks`
--

DROP TABLE IF EXISTS `tble_stocks`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tble_stocks` (
  `ITEMID` int NOT NULL AUTO_INCREMENT,
  `ITEM` varchar(90) NOT NULL,
  `DESCRIPTION` varchar(90) NOT NULL,
  `TYPE` varchar(30) NOT NULL,
  `PRICE` double NOT NULL,
  `QUANTITY` int NOT NULL,
  PRIMARY KEY (`ITEMID`)
) ENGINE=InnoDB AUTO_INCREMENT=17 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tble_stocks`
--

LOCK TABLES `tble_stocks` WRITE;
/*!40000 ALTER TABLE `tble_stocks` DISABLE KEYS */;
INSERT INTO `tble_stocks` VALUES (10,'Gasoline Engine Oil','15w40','Delo',213,6988),(11,'Diesel','20w50\n1Liter','Delo',343,4317),(13,'Magnatec Gasoline Engine Oil','15w40 1Liter','Castrol',700,20000),(14,'Brake Fluid','Axle','Castrol',232,1000),(15,'Gasoline Engine Oil','15w40','Havoline',188,8000);
/*!40000 ALTER TABLE `tble_stocks` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tble_user`
--

DROP TABLE IF EXISTS `tble_user`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tble_user` (
  `USER_ID` int NOT NULL AUTO_INCREMENT,
  `NAME` varchar(90) DEFAULT NULL,
  `USERNAME` varchar(90) DEFAULT NULL,
  `PASSWORD` varchar(90) DEFAULT NULL,
  `TYPE` varchar(30) DEFAULT NULL,
  PRIMARY KEY (`USER_ID`)
) ENGINE=MyISAM AUTO_INCREMENT=11 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tble_user`
--

LOCK TABLES `tble_user` WRITE;
/*!40000 ALTER TABLE `tble_user` DISABLE KEYS */;
INSERT INTO `tble_user` VALUES (1,'admin','admin','admin','Administrator'),(2,'Aileen Legarde','aileen','aileen','Administrator'),(3,'Jay Ann Robless','jay','jay','Administrator'),(4,'Wilfredo Basiga','wilfredo','wilfredo','Administrator'),(5,'Brown Strawman','Brown','Sample','Staff');
/*!40000 ALTER TABLE `tble_user` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2022-12-22 12:39:58
