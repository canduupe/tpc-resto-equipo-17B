---PEDIDOS

CREATE PROCEDURE InsertarArticulosXPedido
    @IdPedido INT,
    @IdArticulo INT,
    @IdUsuM INT,
    @Precio MONEY
AS
  INSERT INTO Articulos_X_Pedido (IdPedido, IdArticulo, Mesero, Precio)
        VALUES (@IdPedido, @IdArticulo, @IdUsuM, @Precio);