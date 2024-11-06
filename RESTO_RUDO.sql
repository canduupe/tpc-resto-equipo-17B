create database RESTO_RUDO
go
use RESTO_RUDO

create table Usuarios(
Id int primary key identity (1,1),
Usuario varchar(20) not null,
Contrase�a varchar(20) not null,
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

create table Articulo(
IdArticulo int primary key identity(1,1),
Nombre varchar(50) not null,
Descripcion varchar(50) not null,
Precio Money not null,
Tipo varchar(50) not null,
CantidadDisponible int not null
)


select * from Articulo
select * from Usuarios

select IdArticulo, Nombre, Descripcion, Precio, Tipo, CantidadDisponible from Articulo

insert into Articulo (Nombre, Descripcion, Precio, Tipo, CantidadDisponible) values ('�oquis', 'Exquisita Pasta para los dias 29', 3000,'Principal', 180)
insert into Articulo (Nombre, Descripcion, Precio, Tipo, CantidadDisponible) values ('Coca', 'Bebida', 3000, 'Bebidas',180)
insert into Articulo (Nombre, Descripcion, Precio, Tipo, CantidadDisponible) values ('Milanesa A la Rudesa', 'Principal', 3000, 'Bebidas',180)

create procedure storedCarta as
select IdArticulo, Nombre, Descripcion, Precio, Tipo, CantidadDisponible from Articulo

exec storedCarta

insert into Usuarios (Usuario, Contrase�a, TipoUsuario)
values ('gerente', 'geren', 1)

insert into Usuarios (Usuario, Contrase�a, TipoUsuario)
values ('mesero', 'mese', 2)