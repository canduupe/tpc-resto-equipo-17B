create database RESTO_RUDO
go
use RESTO_RUDO

create table Usuarios(
Id int primary key identity (1,1),
Usuario varchar(20) not null,
Contraseña varchar(20) not null,
TipoUsuario int not null
)

CREATE TABLE Mesero(
IdMesero int primary key identity (1,1),
Nombre varchar(50) not null, 
Apellido varchar(50) not null,
IdUsuario int foreign key  references Usuarios(Id),
MesasAsignadas int not null
)

Create table Gerente(
IdGerente int Primary key identity(1,1),
Nombre varchar(50) not null, 
Apellido varchar(50) not null,
IdUsuario int foreign key references Usuarios(Id)
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

select * from Articulo
select * from Usuarios

select IdArticulo, Nombre, Descripcion, Precio, Tipo, CantidadDisponible from Articulo

insert into TipoArticulo (Descripcion)
values ('bebida')

insert into TipoArticulo (Descripcion)
values ('principal')

insert into Articulo (Nombre, Descripcion, Precio, Tipo, CantidadDisponible) values ('Ñoquis', 'Exquisita Pasta para los dias 29', 3000, 2, 180)
insert into Articulo (Nombre, Descripcion, Precio, Tipo, CantidadDisponible) values ('Coca', 'Bebida', 3000, 1,180)
insert into Articulo (Nombre, Descripcion, Precio, Tipo, CantidadDisponible) values ('Milanesa A la Rudesa', 'Principal', 3000, 1,180)

create procedure storedCarta as
select IdArticulo, Nombre, Descripcion, Precio, Tipo, CantidadDisponible from Articulo

exec storedCarta

insert into Usuarios (Usuario, Contraseña, TipoUsuario)
values ('gerente', 'geren', 1)

insert into Usuarios (Usuario, Contraseña, TipoUsuario)
values ('mesero', 'mese', 2)

create procedure storedAltaArticulo
@Nombre varchar(50),
@Descripcion varchar(50),
@Precio Money,
@Tipo int,
@Cantidad int
as
insert into Articulo values (@Nombre, @Descripcion, @Precio, @Tipo, @Cantidad)
