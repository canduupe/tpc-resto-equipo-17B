---MESAS

create procedure storedAltaMesa
@NumeroMesa int,
@Disponible int,
@Sector varchar(50)
as
insert into Mesa (NumeroMesa, Disponible, Sector)
values (@NumeroMesa, @Disponible, @Sector)

--------------------------------------------