CREATE DATABASE  IF NOT EXISTS `test_bank` /*!40100 DEFAULT CHARACTER SET utf8 COLLATE utf8_bin */ /*!80016 DEFAULT ENCRYPTION='N' */;
USE `test_bank`;
-- MySQL dump 10.13  Distrib 8.0.25, for Win64 (x86_64)
--
-- Host: 127.0.0.1    Database: test_bank
-- ------------------------------------------------------
-- Server version	8.0.25

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
-- Table structure for table `bank_account`
--

DROP TABLE IF EXISTS `bank_account`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `bank_account` (
  `account_no` varchar(30) COLLATE utf8_bin NOT NULL,
  `cust_id` varchar(13) COLLATE utf8_bin DEFAULT NULL,
  `balance` double DEFAULT NULL,
  PRIMARY KEY (`account_no`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3 COLLATE=utf8_bin;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `bank_account`
--

LOCK TABLES `bank_account` WRITE;
/*!40000 ALTER TABLE `bank_account` DISABLE KEYS */;
INSERT INTO `bank_account` VALUES ('NL17INGB1958634190','1234567890123',2795),('NL33INGB6111062476','1234567890123',1699),('NL94INGB7020127142','0123456789012',1898.6);
/*!40000 ALTER TABLE `bank_account` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `bank_config`
--

DROP TABLE IF EXISTS `bank_config`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `bank_config` (
  `effective_date` date DEFAULT NULL,
  `fee_deposite` double DEFAULT NULL,
  `fee_transfer` double DEFAULT NULL,
  `fee_withdraw` double DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3 COLLATE=utf8_bin;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `bank_config`
--

LOCK TABLES `bank_config` WRITE;
/*!40000 ALTER TABLE `bank_config` DISABLE KEYS */;
INSERT INTO `bank_config` VALUES ('2021-06-03',0.1,0,0.1);
/*!40000 ALTER TABLE `bank_config` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `customer`
--

DROP TABLE IF EXISTS `customer`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `customer` (
  `cust_id` varchar(13) COLLATE utf8_bin NOT NULL,
  `cust_name` varchar(100) COLLATE utf8_bin DEFAULT NULL,
  `cust_surname` varchar(100) COLLATE utf8_bin DEFAULT NULL,
  PRIMARY KEY (`cust_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3 COLLATE=utf8_bin;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `customer`
--

LOCK TABLES `customer` WRITE;
/*!40000 ALTER TABLE `customer` DISABLE KEYS */;
INSERT INTO `customer` VALUES ('0123456789012','สมหมาย','นะจ๊ะ'),('1234567890123','ธนชาติ','ช้างเจริญ');
/*!40000 ALTER TABLE `customer` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `transaction`
--

DROP TABLE IF EXISTS `transaction`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `transaction` (
  `id` int NOT NULL AUTO_INCREMENT,
  `trans_type` varchar(1) COLLATE utf8_bin DEFAULT NULL,
  `from_acc` varchar(30) COLLATE utf8_bin DEFAULT NULL,
  `to_acc` varchar(30) COLLATE utf8_bin DEFAULT NULL,
  `value` double DEFAULT NULL,
  `fee_rate` double DEFAULT NULL,
  `fee_amount` double DEFAULT NULL,
  `total` double DEFAULT NULL,
  `timestamp` datetime DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=16 DEFAULT CHARSET=utf8mb3 COLLATE=utf8_bin;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `transaction`
--

LOCK TABLES `transaction` WRITE;
/*!40000 ALTER TABLE `transaction` DISABLE KEYS */;
INSERT INTO `transaction` VALUES (1,'D',NULL,'NL17INGB1958634190',1000,0.1,1,999,'2021-06-03 14:37:50'),(2,'D',NULL,'NL17INGB1958634190',1000,0.1,1,999,'2021-06-03 14:37:57'),(3,'D',NULL,'NL17INGB1958634190',1000,0.1,1,999,'2021-06-03 14:42:09'),(4,'D',NULL,'NL17INGB1958634190',1000,0.1,1,999,'2021-06-03 14:42:20'),(5,'T','NL17INGB1958634190','NL33INGB6111062476',100,0.1,0,100,'2021-06-03 14:53:49'),(6,'D',NULL,'NL17INGB1958634190',1000,0.1,1,999,'2021-06-03 14:53:55'),(7,'T','NL17INGB1958634190','NL33INGB6111062476',100,0.1,0,100,'2021-06-03 14:53:55'),(8,'D',NULL,'NL94INGB7020127142',100,0.1,0.1,99.9,'2021-06-03 20:18:50'),(9,'D',NULL,'NL94INGB7020127142',100,0.1,0.1,99.9,'2021-06-03 20:19:59'),(10,'D',NULL,'NL94INGB7020127142',200,0.1,0.2,199.8,'2021-06-03 20:20:08'),(11,'T','NL17INGB1958634190','NL94INGB7020127142',1000,0.1,0,1000,'2021-06-03 20:47:02'),(12,'D',NULL,'NL94INGB7020127142',1000,0.1,1,999,'2021-06-03 20:55:39'),(13,'D',NULL,'NL33INGB6111062476',1000,0.1,1,999,'2021-06-03 20:55:51'),(14,'W',NULL,'NL17INGB1958634190',1000,0.1,1,999,'2021-06-03 20:56:03'),(15,'T','NL94INGB7020127142','NL33INGB6111062476',500,0.1,0,500,'2021-06-03 20:56:25');
/*!40000 ALTER TABLE `transaction` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2021-06-03 21:05:40
