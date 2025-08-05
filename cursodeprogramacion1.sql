CREATE TABLE Cursodeprogramacion(
    nombre VARCHAR(100),
    apellido VARCHAR(100),
    genero VARCHAR(100),
    age INT
);

INSERT INTO Cursodeprogramacion ( nombre, apellido, genero, edad,) VALUES
("mariana","quintero","femenino",21),

ALTER TABLE Cursodeprogramacion
ADD COLUMN profesion VARCHAR(150);
ALTER TABLE Cursodeprogramacion
DROP COLUMN age;

UPDATE Cursodeprogramacion
SET profesion = "galletera"
WHERE nombre = nombre

