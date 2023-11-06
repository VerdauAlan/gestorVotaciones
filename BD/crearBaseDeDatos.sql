-- MySQL Workbench Forward Engineering

SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION';

-- -----------------------------------------------------
-- Schema mydb
-- -----------------------------------------------------
-- -----------------------------------------------------
-- Schema jorgitoexclusivo
-- -----------------------------------------------------

-- -----------------------------------------------------
-- Schema jorgitoexclusivo
-- -----------------------------------------------------
CREATE SCHEMA IF NOT EXISTS `jorgitoexclusivo` DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci ;
USE `jorgitoexclusivo` ;

-- -----------------------------------------------------
-- Table `jorgitoexclusivo`.`candidato`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `jorgitoexclusivo`.`candidato` (
  `DNI` VARCHAR(45) NOT NULL,
  `nombre` VARCHAR(45) NOT NULL,
  `apellido` VARCHAR(45) NOT NULL,
  `Propuesta` VARCHAR(180) NOT NULL,
  PRIMARY KEY (`DNI`))
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8mb4
COLLATE = utf8mb4_0900_ai_ci;


-- -----------------------------------------------------
-- Table `jorgitoexclusivo`.`usuario`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `jorgitoexclusivo`.`usuario` (
  `DNI` VARCHAR(45) NOT NULL,
  `nombre` VARCHAR(45) NOT NULL,
  `apellido` VARCHAR(45) NOT NULL,
  `email` VARCHAR(45) NOT NULL,
  `contrasenia` VARCHAR(45) NOT NULL,
  PRIMARY KEY (`DNI`))
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8mb4
COLLATE = utf8mb4_0900_ai_ci;


-- -----------------------------------------------------
-- Table `jorgitoexclusivo`.`voto`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `jorgitoexclusivo`.`voto` (
  `idVoto` INT NOT NULL,
  `titulo` VARCHAR(45) NOT NULL,
  `tematica` VARCHAR(45) NOT NULL,
  `fechaInicio` DATETIME NOT NULL,
  `fechaFin` DATETIME NOT NULL,
  `Descripción` VARCHAR(180) NOT NULL,
  PRIMARY KEY (`idVoto`))
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8mb4
COLLATE = utf8mb4_0900_ai_ci;


-- -----------------------------------------------------
-- Table `jorgitoexclusivo`.`registro`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `jorgitoexclusivo`.`registro` (
  `Usuario_DniUsuario` VARCHAR(45) NOT NULL,
  `Candidato_DniCandidato` VARCHAR(45) NOT NULL,
  `Voto_idVoto` INT NOT NULL,
  `horaDelVoto` DATETIME NOT NULL,
  INDEX `Usuario_DniUsuario` (`Usuario_DniUsuario` ASC) INVISIBLE,
  INDEX `Candidato_DniCandidato` (`Candidato_DniCandidato` ASC) INVISIBLE,
  INDEX `Voto_idVoto` (`Voto_idVoto` ASC) VISIBLE,
  CONSTRAINT `Candidato_DniCandidato`
    FOREIGN KEY (`Candidato_DniCandidato`)
    REFERENCES `jorgitoexclusivo`.`candidato` (`DNI`),
  CONSTRAINT `Usuario_DniUsuario`
    FOREIGN KEY (`Usuario_DniUsuario`)
    REFERENCES `jorgitoexclusivo`.`usuario` (`DNI`),
  CONSTRAINT `Voto_idVoto`
    FOREIGN KEY (`Voto_idVoto`)
    REFERENCES `jorgitoexclusivo`.`voto` (`idVoto`))
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8mb4
COLLATE = utf8mb4_0900_ai_ci;


SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;
