CREATE TABLE tiendita_productos (
    ID_Producto INT PRIMARY KEY,
    Nombre VARCHAR(100),
    Descripcion VARCHAR(255),
    Precio DECIMAL(10, 2),
    Stock INT,
    Categoria VARCHAR(50)
);

INSERT INTO tiendita_productos (ID_Producto, Nombre, Descripcion, Precio, Stock, Categoria) VALUES
(1, 'Camiseta', 'Camiseta de algodón negra', 15.99, 50, 'Ropa'),
(2, 'Pantalón', 'Pantalón vaquero azul', 29.99, 30, 'Ropa'),
(3, 'Zapatos', 'Zapatos de cuero marrón', 49.99, 20, 'Calzado'),
(4, 'Gorra', 'Gorra deportiva negra', 9.99, 100, 'Accesorios'),
(5, 'Reloj', 'Reloj analógico plateado', 39.99, 15, 'Accesorios'),
(6, 'Libreta', 'Libreta de notas de tapa dura', 5.99, 80, 'Papelería'),
(7, 'Lápiz', 'Lápiz grafito HB', 0.99, 200, 'Papelería'),
(8, 'Mochila', 'Mochila escolar negra', 24.99, 25, 'Accesorios'),
(9, 'Sudadera', 'Sudadera con capucha gris', 34.99, 40, 'Ropa'),
(10, 'Bolígrafo', 'Bolígrafo de tinta azul', 1.49, 150, 'Papelería');

CREATE TABLE tiendita_clientes (
    ID_Cliente INT PRIMARY KEY,
    Nombre VARCHAR(100),
    Apellido VARCHAR(100),
    Direccion VARCHAR(255),
    Telefono VARCHAR(20),
    CorreoElectronico VARCHAR(100)
);

INSERT INTO tiendita_clientes (ID_Cliente, Nombre, Apellido, Direccion, Telefono, CorreoElectronico) VALUES
(1, 'Juan', 'Pérez', 'Calle Principal 123', '555-1234', 'juan@example.com'),
(2, 'María', 'García', 'Avenida Central 456', '555-5678', 'maria@example.com'),
(3, 'Carlos', 'López', 'Plaza Mayor 789', '555-9012', 'carlos@example.com'),
(4, 'Ana', 'Martínez', 'Calle Secundaria 321', '555-3456', 'ana@example.com'),
(5, 'Pedro', 'Rodríguez', 'Boulevard Norte 654', '555-7890', 'pedro@example.com'),
(6, 'Laura', 'Sánchez', 'Avenida Sur 987', '555-2345', 'laura@example.com'),
(7, 'Luis', 'Gómez', 'Paseo Central 246', '555-6789', 'luis@example.com'),
(8, 'Marta', 'Díaz', 'Calle Este 135', '555-0123', 'marta@example.com'),
(9, 'Javier', 'Fernández', 'Avenida Oeste 864', '555-4567', 'javier@example.com'),
(10, 'Elena', 'Moreno', 'Plaza Principal 579', '555-8901', 'elena@example.com');

CREATE TABLE tiendita_ventas (
    ID_Venta INT PRIMARY KEY,
    ID_Cliente INT,
    Fecha DATE,
    Total DECIMAL(10, 2),
    MetodoPago VARCHAR(50),
    Estado VARCHAR(50),
    FOREIGN KEY (ID_Cliente) REFERENCES tiendita_clientes(ID_Cliente)
);

INSERT INTO tiendita_ventas (ID_Venta, ID_Cliente, Fecha, Total, MetodoPago, Estado) VALUES
(1, 3, TO_DATE('2024-02-28', 'YYYY-MM-DD'), 59.97, 'Tarjeta de crédito', 'Completado'),
(2, 7, TO_DATE('2024-02-27', 'YYYY-MM-DD'), 45.97, 'Efectivo', 'Completado'),
(3, 2, TO_DATE('2024-02-26', 'YYYY-MM-DD'), 21.96, 'Tarjeta de débito', 'Completado'),
(4, 9, TO_DATE('2024-02-25', 'YYYY-MM-DD'), 134.94, 'Transferencia bancaria', 'Completado'),
(5, 5, TO_DATE('2024-02-24', 'YYYY-MM-DD'), 119.88, 'Efectivo', 'Completado'),
(6, 10, TO_DATE('2024-02-23', 'YYYY-MM-DD'), 14.90, 'Tarjeta de crédito', 'Completado'),
(7, 4, TO_DATE('2024-02-22', 'YYYY-MM-DD'), 109.88, 'Efectivo', 'Completado'),
(8, 6, TO_DATE('2024-02-21', 'YYYY-MM-DD'), 5.99, 'Efectivo', 'Completado'),
(9, 1, TO_DATE('2024-02-20', 'YYYY-MM-DD'), 44.94, 'Tarjeta de débito', 'Completado'),
(10, 8, TO_DATE('2024-02-19', 'YYYY-MM-DD'), 36.96, 'Efectivo', 'Completado');

CREATE TABLE tiendita_detalles_venta (
    ID_Detalle INT PRIMARY KEY,
    ID_Venta INT,
    ID_Producto INT,
    Cantidad INT,
    PrecioUnitario DECIMAL(10, 2),
    Subtotal DECIMAL(10, 2),
    FOREIGN KEY (ID_Venta) REFERENCES tiendita_ventas(ID_Venta),
    FOREIGN KEY (ID_Producto) REFERENCES tiendita_productos(ID_Producto)
);

INSERT INTO tiendita_detalles_venta (ID_Detalle, ID_Venta, ID_Producto, Cantidad, PrecioUnitario, Subtotal) VALUES
(1, 1, 3, 1, 49.99, 49.99),
(2, 1, 7, 2, 0.99, 1.98),
(3, 2, 6, 1, 5.99, 5.99),
(4, 2, 10, 3, 1.49, 4.47),
(5, 3, 1, 1, 15.99, 15.99),
(6, 3, 2, 1, 29.99, 29.99),
(7, 4, 4, 2, 9.99, 19.98),
(8, 4, 5, 1, 39.99, 39.99),
(9, 5, 9, 2, 34.99, 69.98),
(10, 5, 8, 1, 24.99, 24.99);


select * from tiendita_productos;
select * from tiendita_ventas;
select * from tiendita_clientes;
select * from tiendita_detalles_venta;

CREATE SEQUENCE SEQ_VENTAS
START WITH 1
INCREMENT BY 1;


CREATE OR REPLACE PROCEDURE incrementar_stock(
    p_ID_Producto IN INT
)
AS
    v_Stock_actual INT;
BEGIN
    -- Obtener el stock actual del producto
    SELECT Stock INTO v_Stock_actual FROM tiendita_productos WHERE ID_Producto = p_ID_Producto;

    -- Incrementar el stock en 100 unidades
    UPDATE tiendita_productos SET Stock = v_Stock_actual + 100 WHERE ID_Producto = p_ID_Producto;

    COMMIT;
END incrementar_stock;


CREATE OR REPLACE TRIGGER aumentar_stock_existente
BEFORE INSERT ON tiendita_productos
FOR EACH ROW
BEGIN
    IF :NEW.ID_Producto IS NOT NULL THEN
        -- Incrementar el stock en 100 unidades para el nuevo producto
        :NEW.Stock := :NEW.Stock + 100;
    END IF;
END aumentar_stock_existente;


BEGIN
    incrementar_stock(5); -- Incrementar el stock del producto con ID 5 en 100 unidades
END;