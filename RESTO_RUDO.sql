create database RESTO_RUDO
go
use RESTO_RUDO



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
Apellido varchar(50) not null
IdUsuario int foreign key references Usuarios(Id),

)


create table Usuarios(
Id int primary key identity (1,1),
Usuario varchar(20) not null,
Contraseña varchar(20) not null
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



insert into Articulo (Nombre, Descripcion, Precio, Tipo, CantidadDisponible) values ('Ñoquis', 'Exquisita Pasta para los dias 29', 3000,'Principal', 180)
insert into Articulo (Nombre, Descripcion, Precio, Tipo, CantidadDisponible) values ('Coca', 'Bebida', 3000, 'Bebidas',180)
insert into Articulo (Nombre, Descripcion, Precio, Tipo, CantidadDisponible) values ('Milanesa A la Rudesa', 'Principal', 3000, 'Bebidas',180)

update Articulo set precio=1000 where IdArticulo = 2

update Articulo set Nombre = 'Coca~Cola' where IdArticulo=2



