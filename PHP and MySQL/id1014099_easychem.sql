-- phpMyAdmin SQL Dump
-- version 4.6.6
-- https://www.phpmyadmin.net/
--
-- Host: localhost:3306
-- Generation Time: Apr 21, 2017 at 09:01 AM
-- Server version: 10.1.20-MariaDB
-- PHP Version: 7.0.8

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `id1014099_easychem`
--

-- --------------------------------------------------------

--
-- Table structure for table `Users`
--

CREATE TABLE `Users` (
  `ID` int(6) NOT NULL,
  `User_ID` varchar(40) COLLATE utf8_unicode_ci NOT NULL,
  `Password` varchar(40) COLLATE utf8_unicode_ci NOT NULL,
  `El1` int(11) NOT NULL DEFAULT '0',
  `El2` int(11) NOT NULL DEFAULT '0',
  `El3` int(11) NOT NULL DEFAULT '0',
  `El4` int(11) NOT NULL DEFAULT '0',
  `El5` int(11) NOT NULL DEFAULT '0',
  `El6` int(11) NOT NULL DEFAULT '0',
  `El7` int(11) NOT NULL DEFAULT '0',
  `El8` int(11) NOT NULL DEFAULT '0',
  `El9` int(11) NOT NULL DEFAULT '0',
  `El10` int(11) NOT NULL DEFAULT '0',
  `El11` int(11) NOT NULL DEFAULT '0',
  `El12` int(11) NOT NULL DEFAULT '0',
  `Test1` int(11) NOT NULL DEFAULT '0',
  `Test2` int(11) NOT NULL DEFAULT '0',
  `Test3` int(11) NOT NULL DEFAULT '0',
  `Test4` int(11) NOT NULL DEFAULT '0',
  `Test5` int(11) NOT NULL DEFAULT '0'
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Dumping data for table `Users`
--

INSERT INTO `Users` (`ID`, `User_ID`, `Password`, `El1`, `El2`, `El3`, `El4`, `El5`, `El6`, `El7`, `El8`, `El9`, `El10`, `El11`, `El12`, `Test1`, `Test2`, `Test3`, `Test4`, `Test5`) VALUES
(1, '1037436423029044', '', 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0),
(2, 'nikolay1499@gmail.com', 'nikolay1499', 0, 1, 0, 0, 0, 1, 0, 1, 0, 0, 0, 0, 1, 0, 0, 0, 0),
(3, 'nikolay199@gmail.com', '12345678', 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0),
(4, 'nikol@gmail.com', '12345678', 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0),
(5, 'nik@abv.bg', '12345678', 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0),
(6, 'ni12@gmail.com', 'qwertyui', 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `Users`
--
ALTER TABLE `Users`
  ADD UNIQUE KEY `ID` (`ID`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `Users`
--
ALTER TABLE `Users`
  MODIFY `ID` int(6) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
