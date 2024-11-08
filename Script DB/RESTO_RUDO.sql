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

---INSERTS

---tipo articulo
insert into TipoArticulo (Descripcion)
values ('bebida')

insert into TipoArticulo (Descripcion)
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

select * from Articulo
select * from Usuarios
select * from Gerente
select * from Mesero
