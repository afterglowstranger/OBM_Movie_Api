-- MySQL dump 10.13  Distrib 8.0.36, for Win64 (x86_64)
--
-- Host: 127.0.0.1    Database: movie_db
-- ------------------------------------------------------
-- Server version	8.3.0

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
-- Table structure for table `GenresTemp`
--

DROP TABLE IF EXISTS `GenresTemp`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `GenresTemp` (
  `Id` char(36) CHARACTER SET ascii COLLATE ascii_general_ci NOT NULL,
  `Name` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `GuidId` char(36) CHARACTER SET ascii COLLATE ascii_general_ci NOT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `GenresTemp`
--

LOCK TABLES `GenresTemp` WRITE;
/*!40000 ALTER TABLE `GenresTemp` DISABLE KEYS */;
INSERT INTO `GenresTemp` VALUES ('10402','Music','e2ba0784-b904-11ee-a36a-0242ac1c0002'),('10749','Romance','e2ba08e1-b904-11ee-a36a-0242ac1c0002'),('10751','Family','e2ba09ec-b904-11ee-a36a-0242ac1c0002'),('10752','War','e2ba0a11-b904-11ee-a36a-0242ac1c0002'),('10769','Foreign','e2ba0a2e-b904-11ee-a36a-0242ac1c0002'),('10770','TV Movie','e2ba0a47-b904-11ee-a36a-0242ac1c0002'),('11176','Carousel Productions','e2ba0a60-b904-11ee-a36a-0242ac1c0002'),('11602','Vision View Entertainment','e2ba0a7c-b904-11ee-a36a-0242ac1c0002'),('12','Adventure','e2ba0a98-b904-11ee-a36a-0242ac1c0002'),('14','Fantasy','e2ba0ab2-b904-11ee-a36a-0242ac1c0002'),('16','Animation','e2ba0acb-b904-11ee-a36a-0242ac1c0002'),('17161','Odyssey Media','e2ba0ae5-b904-11ee-a36a-0242ac1c0002'),('18','Drama','e2ba0afd-b904-11ee-a36a-0242ac1c0002'),('18012','Pulser Productions','e2ba0b16-b904-11ee-a36a-0242ac1c0002'),('18013','Rogue State','e2ba0b2d-b904-11ee-a36a-0242ac1c0002'),('23822','The Cartel','e2ba0b44-b904-11ee-a36a-0242ac1c0002'),('27','Horror','e2ba0b5b-b904-11ee-a36a-0242ac1c0002'),('28','Action','e2ba0b74-b904-11ee-a36a-0242ac1c0002'),('2883','Aniplex','e2ba0beb-b904-11ee-a36a-0242ac1c0002'),('29812','Telescene Film Group Productions','e2ba0c09-b904-11ee-a36a-0242ac1c0002'),('33751','Sentai Filmworks','e2ba0c24-b904-11ee-a36a-0242ac1c0002'),('35','Comedy','e2ba0c3b-b904-11ee-a36a-0242ac1c0002'),('36','History','e2ba0c51-b904-11ee-a36a-0242ac1c0002'),('37','Western','e2ba0c68-b904-11ee-a36a-0242ac1c0002'),('53','Thriller','e2ba0c7f-b904-11ee-a36a-0242ac1c0002'),('7759','GoHands','e2ba0c97-b904-11ee-a36a-0242ac1c0002'),('7760','BROSTA TV','e2ba0cae-b904-11ee-a36a-0242ac1c0002'),('7761','Mardock Scramble Production Committee','e2ba0cc5-b904-11ee-a36a-0242ac1c0002'),('80','Crime','e2ba0cdc-b904-11ee-a36a-0242ac1c0002'),('878','Science Fiction','e2ba0cf2-b904-11ee-a36a-0242ac1c0002'),('9648','Mystery','e2ba0d09-b904-11ee-a36a-0242ac1c0002'),('99','Documentary','e2ba0d20-b904-11ee-a36a-0242ac1c0002');
/*!40000 ALTER TABLE `GenresTemp` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2024-01-23 16:40:51
