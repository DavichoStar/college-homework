CREATE DATABASE IF NOT EXISTS EncuestasDB;

USE EncuestasDB;

CREATE TABLE IF NOT EXISTS Encuestas(
    Id INT NOT NULL AUTO_INCREMENT,
    FInicio DATE NOT NULL,
    FFin DATE NOT NULL,
    Pregunta VARCHAR(120) NOT NULL,
    PRIMARY KEY (Id)
);

CREATE TABLE IF NOT EXISTS IPs(
    Id INT NOT NULL AUTO_INCREMENT,
    IP VARCHAR(15) NOT NULL,
    UltimaFecha DATE NOT NULL,
    Navegador VARCHAR(255) NOT NULL,
    PRIMARY KEY (Id)
);

CREATE TABLE IF NOT EXISTS Respuestas(
    Id INT NOT NULL AUTO_INCREMENT,
    IdEncuesta INT NOT NULL,
    Respuesta VARCHAR(120) NOT NULL,
    FOREIGN KEY (IdEncuesta)
        REFERENCES Encuestas(Id)
        ON DELETE CASCADE,
    PRIMARY KEY (Id)
);

CREATE TABLE IF NOT EXISTS Votos(
    Id INT NOT NULL AUTO_INCREMENT,
    IdEncuesta INT NOT NULL,
    IdIP INT NOT NULL,
    IdRespuesta INT NOT NULL,
    FOREIGN KEY (IdEncuesta)
        REFERENCES Encuestas(Id)
        ON DELETE CASCADE,
    FOREIGN KEY (IdIP)
        REFERENCES IPs(Id)
        ON DELETE CASCADE,
    FOREIGN KEY (IdRespuesta)
        REFERENCES Respuestas(Id)
        ON DELETE CASCADE,
    PRIMARY KEY (Id)
);

SHOW TABLES;

DESCRIBE Encuestas;

INSERT INTO Encuestas VALUES (null, '2020-11-01', '2020-11-10', '¿Cuál es tu navegador web favorito?'),
(null, '2020-11-05', '2020-11-14', '¿Cuál es tu red social favorita?');

SELECT * FROM Encuestas;

/*ALTER TABLE Respuestas ADD Respuesta VARCHAR(120);*/

INSERT INTO Respuestas VALUES (null, 1, 'Brave'),
(null, 1, 'Google Chrome'),
(null, 2, 'Discord'),
(null, 2, 'WhatsApp'),
(null, 2, 'Instagram');

SELECT * FROM Respuestas WHERE IdEncuesta = 2;

INSERT INTO IPs VALUES (null, '192.168.1.10', '2020-11-04', 'Firefox'),
(null, '192.1668.15.218', NOW(), 'Brave');

SELECT * FROM IPs;

INSERT INTO Votos VALUES (null, 1, 1, 1),
(null, 1, 2, 2);

SELECT * FROM Votos;

SELECT * FROM Encuestas ORDER BY Id;
SELECT * FROM Encuestas WHERE Id = 2;
SELECT COUNT(*) FROM Votos;
SELECT COUNT(*) FROM Votos WHERE IdEncuesta = 4;
SELECT GROUP_CONCAT(Respuesta) FROM Respuestas WHERE IdEncuesta = 1;
SELECT  COUNT(*) FROM Respuestas GROUP BY IdEncuesta;
SELECT Id, COUNT(*) FROM Votos GROUP BY IdRespuesta;
SELECT Pregunta, Respuesta FROM Encuestas, Respuestas LIMIT 5;
SELECT Respuesta FROM Respuestas WHERE IdEncuesta = 2;
SELECT Id FROM Respuestas WHERE IdEncuesta = 2;
SELECT Id FROM Votos WHERE IdEncuesta = 1;
SELECT Id FROM IPs WHERE IP = '192.168.2.45';