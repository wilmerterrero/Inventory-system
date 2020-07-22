use sys_inventario;
go

CREATE TABLE Productos(
prod_id int identity(1,1) primary key,
nombre varchar(50) not null,
precio float
);

CREATE TABLE TiposProductos(
tipos_id int identity(1,1) primary key,
nombre varchar(50) not null
);

CREATE TABLE Proveedores(
prov_id int identity(1,1) primary key,
cedula nvarchar(12) not null,
nombre varchar(50) not null,
telefono nvarchar(13) not null,
email varchar(240) not null
);

CREATE TABLE Clientes(
cl_id int identity(1,1) primary key,
cedula nvarchar(12) not null,
nombre varchar(50) not null,
telefono nvarchar(13) not null,
email varchar(240) not null,
);

CREATE TABLE CategoriasClientes(
categoria_id int identity(1,1) primary key,
nombre varchar(7) not null
);


CREATE TABLE Entradas(
prod_id int,
prov_id int,
cantidad int not null,
fecha date not null,
FOREIGN KEY (prod_id) REFERENCES Productos(prod_id),
FOREIGN KEY (prov_id) REFERENCES Proveedores(prov_id)
);

CREATE TABLE Inventario(
prod_id int,
prov_id int,
cantidad int not null,
FOREIGN KEY (prod_id) REFERENCES Productos(prod_id),
FOREIGN KEY (prov_id) REFERENCES Proveedores(prov_id)
);

CREATE TABLE Facturacion(
cl_id int,
prod_id int,
cantidad int not null,
importe float not null,
fecha date not null,
FOREIGN KEY (cl_id) REFERENCES Clientes(cl_id),
FOREIGN KEY (prod_id) REFERENCES Productos(prod_id),
);

ALTER TABLE Productos ADD marca VARCHAR(40);
ALTER TABLE Productos ADD tipos_id int;
ALTER TABLE Productos ADD FOREIGN KEY (tipos_id) REFERENCES TiposProductos(tipos_id);

ALTER TABLE Proveedores ADD tipos_id int;
ALTER TABLE Proveedores ADD FOREIGN KEY (tipos_id) REFERENCES TiposProductos(tipos_id);

ALTER TABLE Entradas ADD CONSTRAINT df_date DEFAULT getdate() FOR fecha;
ALTER TABLE Entradas ALTER COLUMN fecha DATETIME;

ALTER TABLE Clientes ADD categoria_id int;
ALTER TABLE Clientes ADD FOREIGN KEY (categoria_id) REFERENCES CategoriasClientes(categoria_id);

ALTER TABLE Facturacion ALTER COLUMN fecha DATETIME;
ALTER TABLE Facturacion DROP COLUMN prov_id;
ALTER TABLE Facturacion ADD total float;
ALTER TABLE Facturacion ADD total_descuento float;
ALTER TABLE Facturacion ADD CONSTRAINT p_cantidad CHECK(cantidad <= dbo.pedidos_cantidad(prod_id));

-------------------------------------------------------

--INSERTAR
IF EXISTS(SELECT 1 FROM sys.procedures 
          WHERE Name = 'InsertarProductos')
BEGIN
    DROP PROCEDURE dbo.InsertarProductos
END
CREATE PROCEDURE InsertarProductos
@nombre varchar(50),
@marca varchar(40),
@precio float,
@tipo int
AS
INSERT INTO Productos values (@nombre, @precio, @marca, @tipo);

---MOSTRAR
IF EXISTS(SELECT 1 FROM sys.procedures 
          WHERE Name = 'MostrarProductos')
BEGIN
    DROP PROCEDURE dbo.MostrarProductos
END
CREATE PROCEDURE MostrarProductos
AS
SELECT prod_id AS 'ID', nombre AS 'NOMBRE', marca AS 'MARCA', precio as 'PRECIO' FROM Productos;

---ELIMINAR
IF EXISTS(SELECT 1 FROM sys.procedures 
          WHERE Name = 'EliminarProductos')
BEGIN
    DROP PROCEDURE dbo.EliminarProductos
END
CREATE PROCEDURE EliminarProductos
@id int
AS
DELETE FROM Productos WHERE prod_id = @id;

---ACTUALIZAR
IF EXISTS(SELECT 1 FROM sys.procedures 
          WHERE Name = 'EditarProductos')
BEGIN
    DROP PROCEDURE dbo.EditarProductos
END
CREATE PROCEDURE EditarProductos
@id int,
@nombre varchar(50),
@marca varchar(40),
@precio float
AS
UPDATE Productos SET nombre = @nombre, marca = @marca, precio = @precio WHERE prod_id = @id;


---------
IF EXISTS(SELECT 1 FROM sys.procedures 
          WHERE Name = 'MostrarEntradasProductos')
BEGIN
    DROP PROCEDURE dbo.MostrarEntradasProductos
END
CREATE PROCEDURE MostrarEntradasProductos
AS
SELECT prod.nombre AS 'PRODUCTO', prov.nombre AS 'PROVEEDOR', e.cantidad AS 'CANTIDAD', e.fecha AS 'FECHA' FROM Entradas AS e 
INNER JOIN Productos AS prod ON e.prod_id = prod.prod_id 
INNER JOIN Proveedores AS prov ON e.prov_id = prov.prov_id;


IF EXISTS(SELECT 1 FROM sys.procedures 
          WHERE Name = 'InsertarEntradasProductos')
BEGIN
    DROP PROCEDURE dbo.InsertarEntradasProductos
END
CREATE PROCEDURE InsertarEntradasProductos
	@prod_id int,
	@prov_id int,
	@cantidad int,
	@fecha datetime
AS
	SET @fecha = GETDATE();
	INSERT INTO Entradas values (@prod_id, @prov_id, @cantidad, @fecha);
	IF EXISTS (SELECT prod_id FROM inventario WHERE prod_id = @prod_id)
		BEGIN
			UPDATE Inventario SET cantidad = (SELECT SUM(cantidad+@cantidad) FROM inventario WHERE prod_id = @prod_id) WHERE prod_id = @prod_id;
		END
	ELSE
		BEGIN
			INSERT INTO Inventario VALUES(@prod_id, @prov_id, @cantidad)
		END

---PROVEEDORES

---MOSTRAR
IF EXISTS(SELECT 1 FROM sys.procedures 
          WHERE Name = 'MostrarProveedores')
BEGIN
    DROP PROCEDURE dbo.MostrarProveedores
END
CREATE PROCEDURE MostrarProveedores
AS
SELECT Prov.prov_id AS 'ID', Prov.nombre AS 'NOMBRE', Prov.cedula AS 'CEDULA', Prov.email as 'EMAIL', Prov.telefono as 'TELEFONO', Tipos.nombre AS 'CATEGORIA' FROM Proveedores AS Prov
INNER JOIN TiposProductos Tipos ON Prov.tipos_id = Tipos.tipos_id;

--INSERTAR
IF EXISTS(SELECT 1 FROM sys.procedures 
          WHERE Name = 'InsertarProveedores')
BEGIN
    DROP PROCEDURE dbo.InsertarProveedores
END
CREATE PROCEDURE InsertarProveedores
@cedula nvarchar(12),
@nombre varchar(50),
@telefono nvarchar(13),
@email varchar(240),
@tipos int
AS
INSERT INTO Proveedores values (@cedula, @nombre, @telefono, @email, @tipos);

---ACTUALIZAR
IF EXISTS(SELECT 1 FROM sys.procedures 
          WHERE Name = 'EditarProveedor')
BEGIN
    DROP PROCEDURE dbo.EditarProveedor
END
CREATE PROCEDURE EditarProveedor
@id int,
@cedula nvarchar(12),
@nombre varchar(50),
@telefono nvarchar(13),
@email varchar(240),
@tipos int
AS
UPDATE Proveedores SET nombre = @nombre, cedula = @cedula, telefono = @telefono, email = @email, tipos_id = @tipos WHERE prov_id = @id;

---ELIMINAR
IF EXISTS(SELECT 1 FROM sys.procedures 
          WHERE Name = 'EliminarProveedor')
BEGIN
    DROP PROCEDURE dbo.EliminarProveedor
END
CREATE PROCEDURE EliminarProveedor
@id int
AS
DELETE FROM Proveedores WHERE prov_id = @id;

--CLIENTES
---MOSTRAR
IF EXISTS(SELECT 1 FROM sys.procedures 
          WHERE Name = 'MostrarClientes')
BEGIN
    DROP PROCEDURE dbo.MostrarClientes
END
CREATE PROCEDURE MostrarClientes
AS
SELECT C.cl_id AS 'ID', C.nombre AS 'NOMBRE', C.cedula AS 'CEDULA', C.email as 'EMAIL', C.telefono as 'TELEFONO', Ca.nombre AS 'CATEGORIA' FROM Clientes AS C
INNER JOIN CategoriasClientes Ca ON C.categoria_id = Ca.categoria_id;

--INSERTAR
IF EXISTS(SELECT 1 FROM sys.procedures 
          WHERE Name = 'InsertarCliente')
BEGIN
    DROP PROCEDURE dbo.InsertarCliente
END
CREATE PROCEDURE InsertarCliente
@cedula nvarchar(12),
@nombre varchar(50),
@telefono nvarchar(13),
@email varchar(240),
@categoria int
AS
INSERT INTO Clientes values (@cedula, @nombre, @telefono, @email, @categoria);

---ACTUALIZAR
IF EXISTS(SELECT 1 FROM sys.procedures 
          WHERE Name = 'EditarCliente')
BEGIN
    DROP PROCEDURE dbo.EditarCliente
END
CREATE PROCEDURE EditarCliente
@id int,
@cedula nvarchar(12),
@nombre varchar(50),
@telefono nvarchar(13),
@email varchar(240),
@categoria int
AS
UPDATE Clientes SET nombre = @nombre, cedula = @cedula, telefono = @telefono, email = @email, categoria_id = @categoria WHERE cl_id = @id;

---ELIMINAR
IF EXISTS(SELECT 1 FROM sys.procedures 
          WHERE Name = 'EliminarCliente')
BEGIN
    DROP PROCEDURE dbo.EliminarCliente
END
CREATE PROCEDURE EliminarCliente
@id int
AS
DELETE FROM Clientes WHERE cl_id = @id;

--CATEGORIA
IF EXISTS (SELECT 1 FROM sys.procedures
			WHERE Name = 'MostrarCategoriasClientes')
BEGIN
	DROP PROCEDURE dbo.MostrarCategoriasClientes
END
CREATE PROCEDURE MostrarCategoriasClientes
AS
DECLARE @premium int
DECLARE @regular int
SET @premium = (SELECT COUNT(categoria_id) FROM Clientes WHERE categoria_id = 1);
SET @regular = (SELECT COUNT(categoria_id) FROM Clientes WHERE categoria_id = 2);
SELECT @premium AS 'PREMIUM', @regular AS 'REGULAR';

--PEDIDOS
CREATE FUNCTION pedidos_cantidad(@Producto int)
RETURNS int
AS
BEGIN
RETURN (SELECT cantidad FROM Inventario WHERE prod_id = @Producto)
END;

IF EXISTS(SELECT 1 FROM sys.procedures 
          WHERE Name = 'CantidadProductos')
BEGIN
    DROP PROCEDURE dbo.CantidadProductos
END
CREATE PROCEDURE CantidadProductos @Producto VARCHAR(200)
AS
DECLARE @Cantidad INT
DECLARE @Counter INT 

SET @Counter=1
SET @Cantidad = (SELECT E.cantidad FROM Productos AS Prod INNER JOIN Entradas AS E ON E.prod_id = Prod.prod_id WHERE Prod.nombre = @Producto)
WHILE (@Counter <= @Cantidad)
BEGIN
    SELECT @Counter;
    SET @Counter  = @Counter  + 1
END

--INVENTARIO
IF EXISTS(SELECT 1 FROM sys.procedures 
          WHERE Name = 'MostrarInventario')
BEGIN
    DROP PROCEDURE dbo.MostrarInventario
END
CREATE PROCEDURE MostrarInventario
AS
SELECT prod.nombre AS 'PRODUCTO', prov.nombre AS 'PROVEEDOR', e.cantidad AS 'CANTIDAD' FROM Inventario AS e 
INNER JOIN Productos AS prod ON e.prod_id = prod.prod_id 
INNER JOIN Proveedores AS prov ON e.prov_id = prov.prov_id;

--FACTURACION
IF EXISTS(SELECT 1 FROM sys.procedures 
          WHERE Name = 'GenerarFactura')
BEGIN
    DROP PROCEDURE dbo.GenerarFactura
END
CREATE PROCEDURE GenerarFactura
@cl_id int,
@prod_id int,
@cantidad int,
@importe float,
@total_descuento float,
@fecha datetime,
@total float
AS
SET @importe = (CAST((SELECT SUM(precio * 0.18) FROM Productos WHERE prod_id = @prod_id) AS float));
SET @fecha = GETDATE();
SET @total = (CAST((SUM(@total_descuento + @importe)) AS float));
BEGIN TRY
	BEGIN TRAN
		INSERT INTO Facturacion VALUES (@cl_id, @prod_id, @cantidad, @importe, @fecha, @total, @total_descuento);
		UPDATE Inventario SET cantidad = cantidad - @cantidad WHERE prod_id = @prod_id;
	COMMIT
END TRY
BEGIN CATCH
	ROLLBACK
END CATCH

--MOSTRAR
IF EXISTS(SELECT 1 FROM sys.procedures 
          WHERE Name = 'MostrarFactura')
BEGIN
    DROP PROCEDURE dbo.MostrarFactura
END
CREATE PROCEDURE MostrarFactura
AS
SELECT cli.nombre AS 'CLIENTE', prodc.nombre AS 'PRODUCTO', f.cantidad AS 'CANTIDAD', f.importe AS 'ITBIS', 
f.fecha AS 'FECHA', f.total_descuento AS 'TOTAL SIN ITBIS', f.total 'TOTAL' 
FROM Facturacion AS f 
INNER JOIN Clientes AS cli ON cli.cl_id = f.cl_id 
INNER JOIN Productos AS prodc ON prodc.prod_id = f.prod_id;

--FILTROS PRODUCTOS
IF EXISTS(SELECT 1 FROM sys.procedures 
          WHERE Name = 'FiltroProductos')
BEGIN
    DROP PROCEDURE dbo.FiltroProductos
END
CREATE PROCEDURE FiltroProductos
@nombre varchar(70)
AS
SELECT prod_id AS 'ID', nombre AS 'NOMBRE', marca AS 'MARCA', precio as 'PRECIO' FROM Productos WHERE nombre LIKE '%' + @nombre + '%';


IF EXISTS(SELECT 1 FROM sys.procedures 
          WHERE Name = 'EntradasFechaFiltro')
BEGIN
    DROP PROCEDURE dbo.EntradasFechaFiltro
END
CREATE PROCEDURE EntradasFechaFiltro
@fecha varchar(25)
AS
SELECT prod.nombre AS 'PRODUCTO', prov.nombre AS 'PROVEEDOR', e.cantidad AS 'CANTIDAD', e.fecha AS 'FECHA' FROM Entradas AS e 
INNER JOIN Productos AS prod ON e.prod_id = prod.prod_id
INNER JOIN Proveedores AS prov ON e.prov_id = prov.prov_id WHERE convert(VARCHAR(25), e.fecha, 126) LIKE '%' + @fecha + '%';

IF EXISTS(SELECT 1 FROM sys.procedures 
          WHERE Name = 'EntradasProductoFiltro')
BEGIN
    DROP PROCEDURE dbo.EntradasProductoFiltro
END
CREATE PROCEDURE EntradasProductoFiltro
@producto varchar(100)
AS
SELECT prod.nombre AS 'PRODUCTO', prov.nombre AS 'PROVEEDOR', e.cantidad AS 'CANTIDAD', e.fecha AS 'FECHA' FROM Entradas AS e 
INNER JOIN Productos AS prod ON e.prod_id = prod.prod_id
INNER JOIN Proveedores AS prov ON e.prov_id = prov.prov_id WHERE prod.nombre LIKE '%' + @producto + '%';

IF EXISTS(SELECT 1 FROM sys.procedures 
          WHERE Name = 'EntradasProveedorFiltro')
BEGIN
    DROP PROCEDURE dbo.EntradasProveedorFiltro
END
CREATE PROCEDURE EntradasProveedorFiltro
@proveedor varchar(100)
AS
SELECT prod.nombre AS 'PRODUCTO', prov.nombre AS 'PROVEEDOR', e.cantidad AS 'CANTIDAD', e.fecha AS 'FECHA' FROM Entradas AS e 
INNER JOIN Productos AS prod ON e.prod_id = prod.prod_id
INNER JOIN Proveedores AS prov ON e.prov_id = prov.prov_id WHERE prov.nombre LIKE '%' + @proveedor + '%';

--FILTROS PROVEEDORES
CREATE PROCEDURE ProveedorNombreFiltro
@nombre varchar(70)
AS
SELECT Prov.prov_id AS 'ID', Prov.nombre AS 'NOMBRE', Prov.cedula AS 'CEDULA', Prov.email as 'EMAIL', Prov.telefono as 'TELEFONO', Tipos.nombre AS 'CATEGORIA' FROM Proveedores AS Prov 
INNER JOIN TiposProductos Tipos ON Prov.tipos_id = Tipos.tipos_id WHERE Prov.nombre LIKE '%' + @nombre + '%';

IF EXISTS(SELECT 1 FROM sys.procedures 
          WHERE Name = 'ProveedorEmailFiltro')
BEGIN
    DROP PROCEDURE dbo.ProveedorEmailFiltro
END
CREATE PROCEDURE ProveedorEmailFiltro
@email varchar(70)
AS
SELECT Prov.prov_id AS 'ID', Prov.nombre AS 'NOMBRE', Prov.cedula AS 'CEDULA', Prov.email as 'EMAIL', Prov.telefono as 'TELEFONO', Tipos.nombre AS 'CATEGORIA' FROM Proveedores AS Prov 
INNER JOIN TiposProductos Tipos ON Prov.tipos_id = Tipos.tipos_id WHERE Prov.email LIKE '%' + @email + '%'

--FILTRAR CLIENTES
CREATE PROCEDURE ClientesNombreFiltro
@nombre varchar(70)
AS
SELECT C.cl_id AS 'ID', C.nombre AS 'NOMBRE', C.cedula AS 'CEDULA', C.email as 'EMAIL', C.telefono as 'TELEFONO' FROM Clientes AS C
WHERE C.nombre LIKE '%' + @nombre + '%';

--TIPOS DE CLIENTES
INSERT INTO CategoriasClientes VALUES ('Regular');
INSERT INTO CategoriasClientes VALUES ('Premium');

---TIPOS DE PRODUCTO
INSERT INTO TiposProductos VALUES ('Computadoras');
INSERT INTO TiposProductos VALUES ('Celulares & Tablets');
INSERT INTO TiposProductos VALUES ('Accesorios');

---SELECTS
SELECT * FROM Productos;
SELECT * FROM TiposProductos;
SELECT * FROM Proveedores;
SELECT * FROM Clientes;
SELECT * FROM Entradas;
SELECT * FROM Facturacion;
SELECT * FROM Inventario;

TRUNCATE TABLE Inventario;
TRUNCATE TABLE Entradas;
TRUNCATE TABLE Facturacion;

--CLONANDO ENTRADAS
INSERT INTO Inventario SELECT prod_id, prov_id, cantidad FROM Entradas;


DBCC CHECKIDENT ('Productos', RESEED, 0);

DELETE FROM Proveedores WHERE prov_id = 1;

----TEST
INSERT INTO Entradas values (3, 2, 35, GETDATE());

INSERT INTO Proveedores VALUES ('202002-1', 'Lucas', '809-233-2322', 'lucas@lucas', 3);

INSERT INTO Clientes VALUES ('202020-2', 'Wilmer', '809-233-2322', 'wilmer@wilmer', 1);

EXEC InsertarEntradasProductos @prod_id = 5, @prov_id = 3, @cantidad = 10, @fecha = '';

EXEC EditarProductos @id = 1003, @nombre = 'Lenovo One', @marca = 'ThinkPath', @precio = 2400;

EXEC InsertarProductos @nombre = '6s Plus', @marca = 'iPhone', @precio = 10000, @tipo = 2;

EXEC MostrarProductos;

EXEC EliminarProductos @id = 2;

EXEC MostrarEntradasProductos;

EXEC MostrarProveedores;

EXEC MostrarCategoriasClientes;

EXEC EntradasFiltro @fecha = '2020'

EXEC CantidadProductos @Producto = 'Galaxy A8';

SELECT Prod.nombre, E.prod_id FROM Entradas AS E
INNER JOIN Productos AS Prod ON E.prod_id = Prod.prod_id

SELECT E.cantidad, E.prod_id, Prod.nombre FROM Productos AS Prod
INNER JOIN Entradas AS E ON E.prod_id = Prod.prod_id WHERE Prod.nombre = 'Galaxy A8';

INSERT INTO Facturacion VALUES(2, 2, 50, 45.5, '2020', 5000);

SELECT * FROM Productos WHERE nombre = 'Galaxy';
