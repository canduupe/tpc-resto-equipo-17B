----ARTICULOS

create procedure storedCarta as
select IdArticulo, Nombre, Descripcion, Precio, Tipo, CantidadDisponible from Articulo

-----------------------------------------------

create procedure storedAltaArticulo
@Nombre varchar(50),
@Descripcion varchar(50),
@Precio Money,
@Tipo int,
@Cantidad int
as
insert into Articulo(Nombre, Descripcion, Precio, Tipo, CantidadDisponible)
values (@Nombre, @Descripcion, @Precio, @Tipo, @Cantidad)

-----------------------------------------------

create procedure SpModificarArticulo
@IdArticulo int,
@Nombre varchar(50),
@Descripcion varchar(50),
@Precio money,
@Tipo int,
@CantidadDisponible int
as
update Articulo set Nombre=@Nombre, Descripcion=@Descripcion, Precio=@Precio, Tipo=@Tipo, CantidadDisponible=@CantidadDisponible 
where IdArticulo=@IdArticulo          


-----------------------------------------------

create procedure SpEliminarArticulo
@IdArticulo int
as
delete from Articulo
where IdArticulo = @IdArticulo;       

