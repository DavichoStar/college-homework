CREATE DATABASE IF NOT EXISTS Tienda;
USE Tienda;

CREATE TABLE IF NOT EXISTS Rol (
    Id_Rol INT PRIMARY KEY AUTO_INCREMENT,
    Nombre VARCHAR(50) NOT NULL,
    Descripcion VARCHAR(200) NOT NULL,
    SueldoBase INT
);

CREATE TABLE IF NOT EXISTS Personal (
    Id_Personal INT PRIMARY KEY AUTO_INCREMENT,
    Nombre VARCHAR(50) NOT NULL,
    ApellidoP VARCHAR(50) NOT NULL,
    ApellidoM VARCHAR(50) NOT NULL,
    Telefono VARCHAR(12),
    Correo VARCHAR(50) NOT NULL,
    Id_Rol INT NOT NULL,
    FOREIGN KEY (Id_Rol) REFERENCES Rol(Id_Rol) ON DELETE CASCADE
);

CREATE TABLE IF NOT EXISTS Cliente (
    Id_Cliente INT PRIMARY KEY AUTO_INCREMENT,
    Nombre VARCHAR(50) NOT NULL,
    ApellidoP VARCHAR(50) NOT NULL,
    ApellidoM VARCHAR(50) NOT NULL,
    Telefono VARCHAR(12) NOT NULL,
    Correo VARCHAR(50) NOT NULL
);

CREATE TABLE IF NOT EXISTS Pedido (
    Id_Pedido INT PRIMARY KEY AUTO_INCREMENT,
    Id_Cliente INT NOT NULL,
    Id_Personal INT NOT NULL,
    FechaEntrega DATE DEFAULT CURRENT_DATE(),
    FOREIGN KEY (Id_Cliente)
        REFERENCES Cliente(Id_Cliente)
        ON DELETE CASCADE,
    FOREIGN KEY (Id_Personal)
        REFERENCES Personal(Id_Personal)
        ON DELETE NO ACTION
);

CREATE TABLE IF NOT EXISTS Producto (
    Id_Producto INT PRIMARY KEY AUTO_INCREMENT,
    Nombre VARCHAR(50) NOT NULL,
    Descripcion VARCHAR(200) NOT NULL,
    Precio INT NOT NULL,
    Stock INT DEFAULT 0
);

CREATE TABLE IF NOT EXISTS Carrito (
    Id_Pedido INT NOT NULL,
    Id_Producto INT NOT NULL,
    Cantidad INT DEFAULT 1,
    FOREIGN KEY (Id_Pedido)
        REFERENCES Pedido(Id_Pedido)
        ON DELETE CASCADE,
    FOREIGN KEY (Id_Producto)
        REFERENCES Producto(Id_Producto)
        ON DELETE CASCADE
);

CREATE TABLE IF NOT EXISTS Garantia (
    Id_Garantia INT PRIMARY KEY AUTO_INCREMENT,
    Id_Pedido INT NOT NULL,
    Id_Producto INT NOT NULL,
    Duracion DATE NOT NULL DEFAULT CURRENT_DATE(),
    FOREIGN KEY (Id_Pedido)
        REFERENCES Pedido(Id_Pedido)
        ON DELETE NO ACTION ,
    FOREIGN KEY (Id_Producto)
        REFERENCES Producto(Id_Producto)
        ON DELETE NO ACTION
);

CREATE TABLE IF NOT EXISTS Cobro (
    Id_Cobro INT PRIMARY KEY AUTO_INCREMENT,
    Id_Pedido INT NOT NULL,
    MetodoPago VARCHAR(50) NOT NULL,
    CostoTotal INT NOT NULL,
    FOREIGN KEY (Id_Pedido)
        REFERENCES Pedido(Id_Pedido)
        ON DELETE CASCADE
);

CREATE TABLE IF NOT EXISTS Envio (
    Id_Pedido INT NOT NULL,
    Id_Personal INT NOT NULL,
    Estado VARCHAR(50) NOT NULL,
    FechaSalida DATE NOT NULL DEFAULT CURRENT_DATE(),
    FechaEntrada DATE,
    FOREIGN KEY (Id_Pedido)
        REFERENCES Pedido(Id_Pedido)
        ON DELETE CASCADE,
    FOREIGN KEY (Id_Personal)
        REFERENCES Personal(Id_Personal)
        ON DELETE NO ACTION
);

INSERT INTO Rol VALUES
(NULL, 'Administrador', 'PersonaL encargado de gestionar, supervisar y dirigir al resto del personal', 5000),
(NULL, 'Vendedor', 'Personal encargado de ofrecer a nuestros clientes los productos y completar la compra', 1200),
(NULL, 'Empaquetador', 'Personal encargado de completar los pedidos desde el embalaje de los productos hasta la entrega del pedido.', 1500);

INSERT INTO Personal VALUES
(NULL, 'Eric', 'Hernandez', 'Castro', '525512345678', 'correo@tienda.com', 1),
(NULL, 'Dulce Valeria', 'Arellano', 'Amaro', NULL, 'correo@tienda.com', 2),
(NULL, 'Tiffani Gisell', 'Rangel', 'Luviano', '5512345678', 'correo@cliente.com', 2),
(NULL, 'Alejandro', 'Corona', 'Velasquez', '5512345678', 'correo@tienda.com', 3);

INSERT INTO Cliente VALUES
(NULL, 'Isaura', 'Luna', 'Muñoz', '5512345678', 'correo@cliente.com'),
(NULL, 'Erick David', 'Flores', 'Escobar', '5573025655', 'correo@cliente.com'),
(NULL, 'Zulema', 'Baños', 'Loyo', '5512345678', 'correo@cliente.com');

INSERT INTO Pedido VALUES (NULL, 2, 3, '2020-12-08'),
                          (NULL, 1, 2, CURRENT_DATE()),
                          (NULL, 2, 2, CURRENT_DATE()),
                          (NULL, 3, 3, CURRENT_DATE());

INSERT INTO Producto VALUES
(NULL, 'Aceite Capullo', 'Aceite de 1L para cocinar', 29, 100),
(NULL, 'Foco ahorrador', 'Bombilla de luz blanca de bajo consumo', 35, 50),
(NULL, 'Salvo Grande', 'Jabón liquido para lavar trastes de cocina de 1,5L', 40, 100),
(NULL, 'Axión Chico', 'Jabón liquido para lavar trastes de cocina de 500ml', 18, 200),
(NULL, 'Suavitel', 'Acondicionador de telas de 1L', 19, 150),
(NULL, 'Paquete Oreo', 'Caja con 4 paquetes de 8 galletas oreo sabor chocolate blanco', 38, 10);

INSERT INTO Carrito VALUES (1, 2, 1),
                           (1, 6, 2),
                           (1, 4, 1),
                           (2, 6, 1),
                           (3, 2, 3),
                           (4, 1, 2),
                           (4, 3, 1),
                           (4, 5, 2);

INSERT INTO Garantia VALUES (NULL, 1, 2, '2020-12-25'),
                            (NULL, 1, 6, '2021-02-05'),
                            (NULL, 1, 4, '2020-12-29'),
                            (NULL, 2, 6, '2021-01-02'),
                            (NULL, 3, 2, '2020-12-20'),
                            (NULL, 4, 1, '2021-01-15'),
                            (NULL, 4, 3, '2021-01-13'),
                            (NULL, 4, 5, '2021-01-09');

INSERT INTO Cobro VALUES (NULL, 1, 'PayPal', 129),
                         (NULL, 2, 'Tranferencia', 38),
                         (NULL, 3, 'PayPal', 105),
                         (NULL, 4, 'Efectivo', 136);

INSERT INTO Envio VALUES (1, 4, 'Entregado', '2020-12-08', '2020-12-10'),
                         (2, 4, 'En Viaje', CURRENT_DATE(), NULL),
                         (3, 4, 'Preparando Envío', CURRENT_DATE(), NULL),
                         (4, 4, 'En Espera de Validar Pago', CURRENT_DATE(), NULL);

SELECT * FROM Rol;
SELECT * FROM Personal;
SELECT * FROM Cliente;
SELECT * FROM Pedido WHERE Id_Personal = 2;
SELECT * FROM Producto;
SELECT * FROM Carrito;
SELECT * FROM Garantia WHERE Id_Pedido != 2 AND Id_Pedido != 3;
SELECT * FROM Cobro ORDER BY CostoTotal DESC;
SELECT * FROM Envio WHERE Estado != 'Entregado';
