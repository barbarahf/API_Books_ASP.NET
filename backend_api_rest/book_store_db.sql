DROP DATABASE book_store;

CREATE DATABASE book_store;

USE book_store;
 
CREATE TABLE [genero]
(
    id     int             NOT NULL IDENTITY(1, 1) PRIMARY KEY,
    genero char(50)  NOT NULL
);

CREATE TABLE [editorial]
(
    id               int             NOT NULL IDENTITY(1, 1) PRIMARY KEY,
    nombre_editorial char(60)  NOT NULL
);

CREATE TABLE [libro]
(
    id           int       NOT NULL IDENTITY(1, 1) PRIMARY KEY,
    titulo       char(50)  UNIQUE NOT NULL,
    autor        char(50)  NOT NULL,
    fecha_publicacion DATE NOT NULL,
    precio float NOT NULL,
    id_genero int not null,
    id_editorial int not null ,
    img char(50) not null,
    FOREIGN KEY (id_editorial) REFERENCES editorial (id),
    FOREIGN KEY (id_genero) REFERENCES genero (id)
);

INSERT INTO genero (genero)
VALUES ('Romantica');
INSERT INTO genero (genero)
VALUES ('Poesía');
INSERT INTO genero (genero)
VALUES ('Novela negra');
INSERT INTO genero (genero)
VALUES ('Fantasía');
INSERT INTO genero (genero)
VALUES ('Ciencia ficción');
INSERT INTO genero (genero)
VALUES ('Novela contemporanea');
INSERT INTO genero (genero)
VALUES ('Clásicos literarios');

INSERT INTO editorial (nombre_editorial)
VALUES ('Planeta');
INSERT INTO editorial (nombre_editorial)
VALUES ('Alba libros');
INSERT INTO editorial (nombre_editorial)
VALUES ('Anaya');
INSERT INTO editorial (nombre_editorial)
VALUES ('Salamandra');

INSERT INTO libro (titulo, autor, fecha_publicacion, id_editorial, id_genero, img,precio)
values ('Jane Eyre', 'charlotte bronte', '1847-01-01', 4, 1, 'jane_eyre.jpeg',15.0);

INSERT INTO libro (titulo, autor, fecha_publicacion, id_editorial, id_genero, img,precio)
values ('Call me by your name', 'André Aciman', '2014-01-01', 4, 1, 'call_me_by_your_name.jpg',20.5);

INSERT INTO libro (titulo, autor, fecha_publicacion, id_editorial, id_genero, img,precio)
values ('El juego de Ender ', 'Orson Scott Card', '1985-01-01', 4, 5, 'el_juego_de_ender.png',16.8);

INSERT INTO libro (titulo, autor, fecha_publicacion, id_editorial, id_genero, img,precio)
values ('Dune', 'Frank Herbert', '1965-01-01', 1, 5, 'dune.png',21.5);

INSERT INTO libro (titulo, autor, fecha_publicacion, id_editorial, id_genero, img,precio)
values ('La insoportable levedad del ser', 'Milan Kundera', '1984-01-01', 1, 6, 'la_insoportable_levedad_del_ser.jpg',7.0);