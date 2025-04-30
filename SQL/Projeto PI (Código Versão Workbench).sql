SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION';

-- ----------------------------------------------------
-- Schema ReserveTheTable
-- -----------------------------------------------------

DROP DATABASE IF EXISTS `ReserveTheTable (WORKBENCH VERSION)`;
CREATE SCHEMA IF NOT EXISTS `ReserveTheTable (WORKBENCH VERSION)` DEFAULT CHARACTER SET utf8 ;
USE `ReserveTheTable (WORKBENCH VERSION)` ;

-- -----------------------------------------------------
-- Table `ReserveTheTable`.`Mesa`
-- -----------------------------------------------------

CREATE TABLE IF NOT EXISTS `ReserveTheTable`.`Mesa` (
  `idMesa` INT NOT NULL,
  `NumeroMesa` VARCHAR(4) NOT NULL,
  `Capacidade` INT(1) NOT NULL,
  PRIMARY KEY (`idMesa`))
ENGINE = InnoDB;

-- -----------------------------------------------------
-- Table `ReserveTheTable`.`Cliente`
-- -----------------------------------------------------

CREATE TABLE IF NOT EXISTS `ReserveTheTable`.`Cliente` (
  `idCliente` INT NOT NULL AUTO_INCREMENT,
  `nome` VARCHAR(45) NOT NULL,
  `telefone` INT(11) NOT NULL,
  PRIMARY KEY (`idCliente`))
ENGINE = InnoDB;

-- -----------------------------------------------------
-- Table `ReserveTheTable`.`Reserva`
-- -----------------------------------------------------

CREATE TABLE IF NOT EXISTS `ReserveTheTable`.`Reserva` (
  `idReserva` INT NOT NULL AUTO_INCREMENT,
  `clienteId` INT NOT NULL,
  `mesaId` INT NOT NULL,
  `dataReserva` DATE NOT NULL,
  `horaReserva` TIME NOT NULL,
  PRIMARY KEY (`idReserva`),
  
  CONSTRAINT `fk_ClienteReserva`
    FOREIGN KEY (`clienteId`)
    REFERENCES `ReserveTheTable`.`Cliente` (`idCliente`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
    
  CONSTRAINT `fk_MesaReserva`
    FOREIGN KEY (`mesaId`)
    REFERENCES `ReserveTheTable`.`Mesa` (`idMesa`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
    
ENGINE = InnoDB;


SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;
