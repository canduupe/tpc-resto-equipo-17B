create database RESTO_RUDO
go
use RESTO_RUDO

---TABLAS
create table Usuarios(
Id int primary key identity (1,1),
Usuario varchar(20) not null,
Contraseña varchar(20) not null,
TipoUsuario int not null
)
alter table Usuarios 
add Activo int not null default 1;

CREATE TABLE Mesero(
IdMesero int primary key identity (1,1),
Nombre varchar(50) not null, 
Apellido varchar(50) not null,
IdUsuario int foreign key  references Usuarios(Id),
Activo int not null
)

Create table Gerente(
IdGerente int Primary key identity(1,1),
Nombre varchar(50) not null, 
Apellido varchar(50) not null,
IdUsuario int foreign key references Usuarios(Id),
Activo int not null
)

create table TipoArticulo(
Id int primary key identity (1,1),
Descripcion varchar(50) not null
)

create table Articulo(
IdArticulo int primary key identity(1,1),
Nombre varchar(50) not null,
Descripcion varchar(50) not null,
Precio Money not null,
Tipo int not null references TipoArticulo(Id),
CantidadDisponible int not null
)

create table Mesa(
IdMesa int primary key identity (1,1),
IdMesero int null references Mesero(IdMesero),
NumeroMesa int not null,
Disponible int not null default 1,
Sector varchar(50) null
)

create table Pedidos(
IdPedido int primary key identity (1,1),
IdMesa int not null references Mesa(IdMesa),
IdMesero int not null references Mesero(IdMesero),
Fecha datetime not null,
Activo int not null default 1
)



INSERT INTO Pedidos (IdMesa, IdMesero, Fecha)
VALUES (1, 8, GETDATE());
select IdPedido, IdMesa, IdMesero, Fecha, Activo from Pedidos


create table Articulos_X_Pedido(
IdPedido int Foreign key references Pedidos(IdPedido),
IdArticulo int not null references Articulo (IdArticulo),
Mesero int not null FOREIGN key references Usuarios(Id),
Activo int not null default 1,
Precio money not null
)

insert into Articulos_X_Pedido values (2, 5, 15, 1, 800)

DELETE FROM Pedidos;
DELETE FROM Articulos_X_Pedido;



---INSERTS

---tipo articulo
insert into TipoArticulo (Descripcion)
values ('bebida')

insert into TipoArticulo (Descripcion)select IdPedido, IdArticulo, Mesero, Activo, Precio from Articulos_X_Pedido

values ('principal')

---articulos
insert into Articulo (Nombre, Descripcion, Precio, Tipo, CantidadDisponible) values ('Ñoquis', 'Exquisita Pasta para los dias 29', 3000, 2, 180)
insert into Articulo (Nombre, Descripcion, Precio, Tipo, CantidadDisponible) values ('Coca', 'Bebida', 3000, 1,180)
insert into Articulo (Nombre, Descripcion, Precio, Tipo, CantidadDisponible) values ('Milanesa A la Rudesa', 'Principal', 3000, 1,180)

---usuarios
insert into Usuarios (Usuario, Contraseña, TipoUsuario)
values ('gerente', 'geren', 1)

insert into Usuarios (Usuario, Contraseña, TipoUsuario)
values ('mesero', 'mese', 2)

---gerentes
insert into Gerente (Nombre, Apellido, IdUsuario, Activo)
values ('Pablo', 'Perez', 1 , 1)

insert into Gerente (Nombre, Apellido, IdUsuario, Activo)
values ('Sabrina', 'Lopez', 1 , 1)

---meseros
insert into Mesero (Nombre, Apellido, IdUsuario, Activo)
values ('Joaquin', 'Lopez', 2 , 1)

insert into Mesero (Nombre, Apellido, IdUsuario, Activo)
values ('Candela', 'Peña', 2 , 1)

insert into Mesero (Nombre, Apellido, IdUsuario, Activo)
values ('Magali', 'Tourne', 15 , 1)

---mesas
insert into Mesa (IdMesero, NumeroMesa, Disponible, Sector)
values (1, 1, 1, 'Patio')

insert into Mesa (IdMesero, NumeroMesa, Disponible, Sector)
values (2, 2, 1, 'Pasillo')

insert into Mesa (IdMesero, NumeroMesa, Disponible, Sector)
values (2, 4, 1, 'Pasillo')


select * from Articulo
select * from Usuarios
select * from Gerente
select * from Mesero
select * from Mesa
select * from Pedidos

DELETE FROM Mesa
WHERE IdMesa= 9;





Create Procedure eliminarDeOrden
@IdArti int
as
Delete from Articulos_X_Pedido
where IdArticulo = @IdArti



Create Procedure PedidosXMese
@IdMesero int
as 
select P.IdPedido as IdPedido, P.IdMesero  as Mesero from Pedidos P
inner join Mesero as M on M.IdMesero = P.IdMesero
inner Join Usuarios as U on U.Id = M.IdUsuario
Where P.IdMesero = @IdMesero