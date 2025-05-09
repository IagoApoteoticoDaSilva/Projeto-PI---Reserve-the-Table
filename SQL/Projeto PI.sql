DROP DATABASE IF EXISTS `Reserve The Table`;
CREATE SCHEMA IF NOT EXISTS `Reserve The Table` DEFAULT CHARACTER SET utf8 ;
USE `Reserve The Table` ;

CREATE TABLE cliente(
	idCliente INT PRIMARY KEY NOT NULL AUTO_INCREMENT,
    nome VARCHAR (45) NOT NULL,
    telefone VARCHAR (11) NOT NULL
);

CREATE TABLE mesa (
	idMesa INT PRIMARY KEY NOT NULL AUTO_INCREMENT,
    numeroMesa VARCHAR (4) NOT NULL,
    capacidade INT (1) NOT NULL
);

CREATE TABLE reserva(
		idReserva INT PRIMARY KEY NOT NULL AUTO_INCREMENT,
        mesaID INT NOT NULL,
        clienteID INT NOT NULL,
        dataReserva DATE NOT NULL,
        horaReserva TIME (0) NOT NULL,
        
		FOREIGN KEY (clienteId) 
        REFERENCES cliente(idCliente),
        
		FOREIGN KEY (mesaId) 
        REFERENCES mesa(idMesa)
);

CREATE TABLE Garcom(
    idGarcom INT AUTO_INCREMENT PRIMARY KEY,
    nome VARCHAR(45) NOT NULL,
    senha VARCHAR(4) NOT NULL
);


-- Cliente (teste)
INSERT INTO cliente (nome, telefone)
VALUES 
('Maria Silva', '11999998888'),
('Carlos Mendes', '11912345678');
SELECT * FROM cliente;

-- Mesas (teste)
INSERT INTO mesa (numeroMesa, capacidade)
VALUES 
(1, 4),
(2, 2),
(3, 6);
SELECT * FROM mesa;

-- Reserva (teste)
INSERT INTO reserva (clienteId, mesaId, dataReserva, horaReserva)
VALUES 
(1, 2, '2025-04-20', '19:30');
SELECT * FROM reserva;

-- Garcom (teste)
INSERT INTO garcom (idGarcom, nome, senha)
VALUES
(1, 'IAGO SANTOS', '2201'),
(2, 'JONAS ARAUJO', '2802'),
(3, 'IZABELLA SILVA', '0111');
SELECT * FROM garcom;