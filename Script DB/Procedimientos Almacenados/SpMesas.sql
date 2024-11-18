---MESAS

create procedure storedAltaMesa
@NumeroMesa int,
@Disponible int,
@Sector varchar(50)
as
insert into Mesa (NumeroMesa, Disponible, Sector)
values (@NumeroMesa, @Disponible, @Sector)

--------------------------------------------

 create PROCEDURE SpAsignarMesero
	@IdMesa int,
    @IdMesero int,
	@Disponible int
as
    update Mesa
    set 
    IdMesero = @IdMesero,
	Disponible = @Disponible
	where IdMesa = @IdMesa;

--------------------------------------------

CREATE PROCEDURE SpElimnarMesa
@IdMesa int
AS
DELETE FROM Mesa
WHERE IdMesa = @IdMesa;  

--------------------------------------------