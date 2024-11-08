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
insert into Articulo values (@Nombre, @Descripcion, @Precio, @Tipo, @Cantidad)

-----------------------------------------------

