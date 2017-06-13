-- MySQL dump 10.13  Distrib 5.6.22, for Win32 (x86)
--
-- Host: localhost    Database: restaurant
-- ------------------------------------------------------
-- Server version	5.6.22-log

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `cust_order`
--

DROP TABLE IF EXISTS `cust_order`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `cust_order` (
  `orderID` int(11) NOT NULL AUTO_INCREMENT,
  `ID` int(11) DEFAULT NULL,
  `FID` int(11) DEFAULT NULL,
  `QUANTITY` int(11) DEFAULT NULL,
  PRIMARY KEY (`orderID`),
  KEY `ID` (`ID`),
  KEY `custOrder` (`FID`),
  CONSTRAINT `custOrder` FOREIGN KEY (`FID`) REFERENCES `food` (`FID`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=17 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `cust_order`
--

LOCK TABLES `cust_order` WRITE;
/*!40000 ALTER TABLE `cust_order` DISABLE KEYS */;
INSERT INTO `cust_order` VALUES (10,4,1,4),(15,4,3,4),(16,1,3,6);
/*!40000 ALTER TABLE `cust_order` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `cust_table`
--

DROP TABLE IF EXISTS `cust_table`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `cust_table` (
  `TID` int(11) NOT NULL,
  `FNAME` varchar(30) DEFAULT NULL,
  `PARTY` int(11) DEFAULT NULL,
  `MAX_SEAT` int(11) DEFAULT '0',
  `isAvailable` tinyint(4) DEFAULT '0',
  PRIMARY KEY (`TID`),
  UNIQUE KEY `FNAME` (`FNAME`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `cust_table`
--

LOCK TABLES `cust_table` WRITE;
/*!40000 ALTER TABLE `cust_table` DISABLE KEYS */;
INSERT INTO `cust_table` VALUES (1,'isabelle',4,6,0),(2,NULL,0,2,1),(3,NULL,0,4,1),(4,'alex',1,4,0),(5,NULL,0,4,1),(6,NULL,0,4,1),(7,NULL,0,4,1),(8,NULL,0,2,1),(9,NULL,0,8,1);
/*!40000 ALTER TABLE `cust_table` ENABLE KEYS */;
UNLOCK TABLES;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50017 DEFINER=`root`@`localhost`*/ /*!50003 TRIGGER leaveTable AFTER UPDATE ON CUST_TABLE
FOR EACH ROW
DELETE FROM CUST_ORDER WHERE NEW.TID = CUST_ORDER.ID */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;

--
-- Table structure for table `food`
--

DROP TABLE IF EXISTS `food`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `food` (
  `FID` int(11) NOT NULL,
  `NAME` varchar(30) DEFAULT NULL,
  `STOCK` int(11) DEFAULT '0',
  PRIMARY KEY (`FID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `food`
--

LOCK TABLES `food` WRITE;
/*!40000 ALTER TABLE `food` DISABLE KEYS */;
INSERT INTO `food` VALUES (0,'soup',10),(1,'cake',10),(2,'pizza',10),(3,'hamburger',10),(4,'fries',10),(5,'eggs',50),(6,'hotdog',9),(7,'corndog',1);
/*!40000 ALTER TABLE `food` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `waiting_cust`
--

DROP TABLE IF EXISTS `waiting_cust`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `waiting_cust` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `FNAME` varchar(30) DEFAULT NULL,
  `PARTY` int(11) DEFAULT NULL,
  PRIMARY KEY (`ID`),
  UNIQUE KEY `FName` (`FNAME`)
) ENGINE=InnoDB AUTO_INCREMENT=48 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `waiting_cust`
--

LOCK TABLES `waiting_cust` WRITE;
/*!40000 ALTER TABLE `waiting_cust` DISABLE KEYS */;
INSERT INTO `waiting_cust` VALUES (47,'tony',2);
/*!40000 ALTER TABLE `waiting_cust` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2017-06-12 23:48:26
