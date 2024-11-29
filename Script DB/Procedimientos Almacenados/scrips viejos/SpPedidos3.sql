---PEDIDOS

CREATE PROCEDURE InsertarArticulosXPedido
    @IdPedido INT,
    @IdArticulo INT,
    @IdUsuM INT,
    @Precio MONEY
AS
  INSERT INTO Articulos_X_Pedido (IdPedido, IdArticulo, Mesero, Precio)
        VALUES (@IdPedido, @IdArticulo, @IdUsuM, @Precio);

------------------------------------------------------

CREATE PROCEDURE InsertarPedido
    @IdMesa INT,
    @Fecha DATETIME
AS
    INSERT INTO Pedidos (IdMesa, Fecha)
    VALUES (@IdMesa, @Fecha)

-----------------------------------------------------

Create Procedure PedidosXMese
@IdMesero int
as 
select P.IdPedido as IdPedido, P.IdMesero  as Mesero from Pedidos P
inner join Mesero as M on M.IdMesero = P.IdMesero
inner Join Usuarios as U on U.Id = M.IdUsuario
Where P.IdMesero = @IdMesero


-------------------------------------------------------


Create Procedure eliminarDeOrden
@IdArti int
as
Delete from Articulos_X_Pedido
where IdArticulo = @IdArti


----------------------------------------------------------

CREATE PROCEDURE EnviarPedidos
    @IdPedido INT
AS
UPDATE Articulos_X_Pedido
SET Activo = 0
WHERE IdPedido = @IdPedido;

UPDATE Pedidos
set Activo = 0
where IdPedido = @IdPedido;
