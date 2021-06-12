-- MySQL dump 10.13  Distrib 8.0.22, for Win64 (x86_64)
--
-- Host: 193.191.240.67    Database: mydb
-- ------------------------------------------------------
-- Server version	8.0.23-0ubuntu0.20.04.1

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
-- Table structure for table `AdventureStock`
--

DROP TABLE IF EXISTS `AdventureStock`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `AdventureStock` (
  `id` int NOT NULL AUTO_INCREMENT,
  `name` varchar(45) DEFAULT NULL,
  `quantity` int DEFAULT NULL,
  `Color` varchar(45) DEFAULT NULL,
  `Size` varchar(45) DEFAULT NULL,
  `min` int DEFAULT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `id_UNIQUE` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=10 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `AdventureStock`
--

LOCK TABLES `AdventureStock` WRITE;
/*!40000 ALTER TABLE `AdventureStock` DISABLE KEYS */;
INSERT INTO `AdventureStock` VALUES (1,'cadreRenforcee',3,'Red','26',1),(2,'cadreRenforcee',4,'Green','26',1),(3,'cadreRenforcee',2,'Blue','26',1),(4,'cadreRenforcee',4,'Red','28',1),(5,'cadreRenforcee',3,'Green','28',1),(6,'cadreRenforcee',4,'Blue','28',1),(7,'pneuLarge',9,NULL,'26',3),(8,'pneuLarge',11,NULL,'28',3);
/*!40000 ALTER TABLE `AdventureStock` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `Agent`
--

DROP TABLE IF EXISTS `Agent`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `Agent` (
  `idAgent` int NOT NULL AUTO_INCREMENT,
  `Name` varchar(45) DEFAULT NULL,
  `Phone` varchar(45) DEFAULT NULL,
  `User` varchar(45) DEFAULT NULL,
  `Password` varchar(45) DEFAULT NULL,
  `OrdersDone` int DEFAULT NULL,
  PRIMARY KEY (`idAgent`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `Agent`
--

LOCK TABLES `Agent` WRITE;
/*!40000 ALTER TABLE `Agent` DISABLE KEYS */;
INSERT INTO `Agent` VALUES (1,'Khaled','04','khaled','1234',0);
/*!40000 ALTER TABLE `Agent` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `Assembler`
--

DROP TABLE IF EXISTS `Assembler`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `Assembler` (
  `idAssembler` int NOT NULL AUTO_INCREMENT,
  `Name` varchar(45) DEFAULT NULL,
  `User` varchar(45) DEFAULT NULL,
  `Password` varchar(45) DEFAULT NULL,
  `Phone` varchar(45) DEFAULT NULL,
  `BikesDone` int DEFAULT NULL,
  PRIMARY KEY (`idAssembler`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `Assembler`
--

LOCK TABLES `Assembler` WRITE;
/*!40000 ALTER TABLE `Assembler` DISABLE KEYS */;
INSERT INTO `Assembler` VALUES (1,'Thierry','frigofri','1234','04',7);
/*!40000 ALTER TABLE `Assembler` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `Bike`
--

DROP TABLE IF EXISTS `Bike`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `Bike` (
  `idBike` int NOT NULL AUTO_INCREMENT,
  `Type` varchar(45) DEFAULT NULL,
  `Size` int DEFAULT NULL,
  `Color` varchar(45) DEFAULT NULL,
  `Price` int DEFAULT NULL,
  `Assembler_idAssembler` int NOT NULL,
  PRIMARY KEY (`idBike`),
  KEY `fk_Bike_Assembler1_idx` (`Assembler_idAssembler`),
  CONSTRAINT `fk_Bike_Assembler1` FOREIGN KEY (`Assembler_idAssembler`) REFERENCES `Assembler` (`idAssembler`) ON DELETE RESTRICT ON UPDATE RESTRICT
) ENGINE=InnoDB AUTO_INCREMENT=990 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `Bike`
--

LOCK TABLES `Bike` WRITE;
/*!40000 ALTER TABLE `Bike` DISABLE KEYS */;
/*!40000 ALTER TABLE `Bike` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `CityStock`
--

DROP TABLE IF EXISTS `CityStock`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `CityStock` (
  `id` int NOT NULL AUTO_INCREMENT,
  `name` varchar(45) DEFAULT NULL,
  `quantity` int DEFAULT NULL,
  `Color` varchar(45) DEFAULT NULL,
  `Size` varchar(45) DEFAULT NULL,
  `min` int DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=20 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `CityStock`
--

LOCK TABLES `CityStock` WRITE;
/*!40000 ALTER TABLE `CityStock` DISABLE KEYS */;
INSERT INTO `CityStock` VALUES (1,'cadre',1,'Red','26',1),(2,'cadre',1,'Blue','26',1),(3,'cadre',4,'Green','26',1),(4,'cadre',4,'Red','28',1),(5,'cadre',4,'Blue','28',1),(6,'cadre',4,'Green','28',1),(7,'gardeBoue',1,'Red','26',1),(8,'gardeBoue',1,'Blue','26',1),(9,'gardeBoue',4,'Green','26',1),(10,'gardeBoue',4,'Red','28',1),(11,'gardeBoue',4,'Blue','28',1),(12,'gardeBoue',4,'Green','26',1),(13,'pneu',12,NULL,'28',3),(14,'pneu',3,NULL,'26',3),(15,'eclairage',6,NULL,NULL,6),(16,'porteBagage',6,NULL,NULL,6);
/*!40000 ALTER TABLE `CityStock` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `Customer`
--

DROP TABLE IF EXISTS `Customer`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `Customer` (
  `idCustomer` int NOT NULL AUTO_INCREMENT,
  `Adress` varchar(45) DEFAULT NULL,
  `Name` varchar(45) DEFAULT NULL,
  `Phone` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`idCustomer`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `Customer`
--

LOCK TABLES `Customer` WRITE;
/*!40000 ALTER TABLE `Customer` DISABLE KEYS */;
/*!40000 ALTER TABLE `Customer` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `ExplorerStock`
--

DROP TABLE IF EXISTS `ExplorerStock`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `ExplorerStock` (
  `id` int NOT NULL AUTO_INCREMENT,
  `name` varchar(45) DEFAULT NULL,
  `quantity` int DEFAULT NULL,
  `Color` varchar(45) DEFAULT NULL,
  `Size` varchar(45) DEFAULT NULL,
  `min` int DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=12 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `ExplorerStock`
--

LOCK TABLES `ExplorerStock` WRITE;
/*!40000 ALTER TABLE `ExplorerStock` DISABLE KEYS */;
INSERT INTO `ExplorerStock` VALUES (1,'cadre',2,'Red','26',1),(2,'cadre',1,'Blue','26',1),(3,'cadre',4,'Green','26',1),(4,'cadre',4,'Red','28',1),(5,'cadre',4,'Blue','28',1),(6,'cadre',4,'Green','28',1),(7,'gardeBoueLarge',1,'Black','26',1),(8,'gardeBoueLarge',2,'Black','28',1),(9,'eclairage',16,NULL,NULL,6),(10,'pneuLarge',4,NULL,'26',3),(11,'pneuLarge',12,NULL,'28',3);
/*!40000 ALTER TABLE `ExplorerStock` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `Manager`
--

DROP TABLE IF EXISTS `Manager`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `Manager` (
  `idManager` int NOT NULL AUTO_INCREMENT,
  `Name` varchar(45) DEFAULT NULL,
  `Phone` varchar(45) DEFAULT NULL,
  `User` varchar(45) DEFAULT NULL,
  `Password` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`idManager`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `Manager`
--

LOCK TABLES `Manager` WRITE;
/*!40000 ALTER TABLE `Manager` DISABLE KEYS */;
/*!40000 ALTER TABLE `Manager` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `OrderLine`
--

DROP TABLE IF EXISTS `OrderLine`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `OrderLine` (
  `idOrderLine` int NOT NULL AUTO_INCREMENT,
  `Date` date DEFAULT NULL,
  `Bike_idBike` int NOT NULL,
  PRIMARY KEY (`idOrderLine`),
  KEY `fk_OrderLine_Bike1_idx` (`Bike_idBike`),
  CONSTRAINT `fk_OrderLine_Bike1` FOREIGN KEY (`Bike_idBike`) REFERENCES `Bike` (`idBike`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `OrderLine`
--

LOCK TABLES `OrderLine` WRITE;
/*!40000 ALTER TABLE `OrderLine` DISABLE KEYS */;
/*!40000 ALTER TABLE `OrderLine` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `Part`
--

DROP TABLE IF EXISTS `Part`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `Part` (
  `idPart` int NOT NULL AUTO_INCREMENT,
  `Name` varchar(45) DEFAULT NULL,
  `Location` varchar(45) DEFAULT NULL,
  `Bike_idBike` int NOT NULL,
  `Quantity` int DEFAULT NULL,
  PRIMARY KEY (`idPart`),
  KEY `fk_Part_Bike_idx` (`Bike_idBike`),
  CONSTRAINT `fk_Part_Bike` FOREIGN KEY (`Bike_idBike`) REFERENCES `Bike` (`idBike`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `Part`
--

LOCK TABLES `Part` WRITE;
/*!40000 ALTER TABLE `Part` DISABLE KEYS */;
/*!40000 ALTER TABLE `Part` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `PartsToOrder`
--

DROP TABLE IF EXISTS `PartsToOrder`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `PartsToOrder` (
  `id` int NOT NULL AUTO_INCREMENT,
  `name` varchar(45) DEFAULT NULL,
  `quantity` int DEFAULT NULL,
  `Color` varchar(45) DEFAULT NULL,
  `Size` varchar(45) DEFAULT NULL,
  `min` int DEFAULT NULL,
  `Type` varchar(15) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `PartsToOrder`
--

LOCK TABLES `PartsToOrder` WRITE;
/*!40000 ALTER TABLE `PartsToOrder` DISABLE KEYS */;
/*!40000 ALTER TABLE `PartsToOrder` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `Schedule`
--

DROP TABLE IF EXISTS `Schedule`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `Schedule` (
  `idSchedule` int NOT NULL AUTO_INCREMENT,
  `Date` date DEFAULT NULL,
  `Heure` datetime DEFAULT NULL,
  `Manager_idManager` int NOT NULL,
  `Assembler_idAssembler` int NOT NULL,
  `Bike_idBike` int NOT NULL,
  PRIMARY KEY (`idSchedule`),
  KEY `fk_Schedule_Manager1_idx` (`Manager_idManager`),
  KEY `fk_Schedule_Assembler1_idx` (`Assembler_idAssembler`),
  KEY `fk_Schedule_Bike1_idx` (`Bike_idBike`),
  CONSTRAINT `fk_Schedule_Assembler1` FOREIGN KEY (`Assembler_idAssembler`) REFERENCES `Assembler` (`idAssembler`),
  CONSTRAINT `fk_Schedule_Bike1` FOREIGN KEY (`Bike_idBike`) REFERENCES `Bike` (`idBike`),
  CONSTRAINT `fk_Schedule_Manager1` FOREIGN KEY (`Manager_idManager`) REFERENCES `Manager` (`idManager`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `Schedule`
--

LOCK TABLES `Schedule` WRITE;
/*!40000 ALTER TABLE `Schedule` DISABLE KEYS */;
/*!40000 ALTER TABLE `Schedule` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `Stock`
--

DROP TABLE IF EXISTS `Stock`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `Stock` (
  `idStock` int NOT NULL AUTO_INCREMENT,
  `name` varchar(45) DEFAULT NULL,
  `quantity` int DEFAULT NULL,
  `min` int DEFAULT NULL,
  PRIMARY KEY (`idStock`)
) ENGINE=InnoDB AUTO_INCREMENT=16 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `Stock`
--

LOCK TABLES `Stock` WRITE;
/*!40000 ALTER TABLE `Stock` DISABLE KEYS */;
INSERT INTO `Stock` VALUES (1,'bequille',14,1),(2,'kitFrein',14,1),(3,'kitVitesse',14,1),(4,'kidPedalier',14,1),(5,'cassettePignons',14,1),(6,'catadioptre',14,4),(7,'chaine',14,1),(8,'chambreAir',14,2),(9,'derailleur',14,1),(10,'disqueFrein',14,2),(11,'fourche',14,1),(12,'guidon',14,1),(13,'plateau',14,1),(14,'roue',14,2),(15,'selle',14,1);
/*!40000 ALTER TABLE `Stock` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `Test`
--

DROP TABLE IF EXISTS `Test`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `Test` (
  `idTest` int NOT NULL AUTO_INCREMENT,
  `Price` int DEFAULT NULL,
  `Quantity` int DEFAULT NULL,
  `Delay` int DEFAULT NULL,
  `AgentID` int DEFAULT NULL,
  `CustomerID` int DEFAULT NULL,
  PRIMARY KEY (`idTest`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `Test`
--

LOCK TABLES `Test` WRITE;
/*!40000 ALTER TABLE `Test` DISABLE KEYS */;
/*!40000 ALTER TABLE `Test` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `catalog`
--

DROP TABLE IF EXISTS `catalog`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `catalog` (
  `idcatalog` int NOT NULL,
  `Color` varchar(45) DEFAULT NULL,
  `Type` varchar(45) DEFAULT NULL,
  `Size` int NOT NULL,
  PRIMARY KEY (`idcatalog`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `catalog`
--

LOCK TABLES `catalog` WRITE;
/*!40000 ALTER TABLE `catalog` DISABLE KEYS */;
/*!40000 ALTER TABLE `catalog` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2021-06-12  4:46:55
