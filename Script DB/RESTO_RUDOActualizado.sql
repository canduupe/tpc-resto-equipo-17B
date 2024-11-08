create database RESTO_RUDO
go
use RESTO_RUDO

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

select * from Articulo
select Id, Usuario, Contraseña, TipoUsuario from Usuarios

select IdArticulo, Nombre, Descripcion, Precio, Tipo, CantidadDisponible from Articulo

insert into TipoArticulo (Descripcion)
values ('bebida')

insert into TipoArticulo (Descripcion)
values ('principal')

insert into Articulo (Nombre, Descripcion, Precio, Tipo, CantidadDisponible) values ('Ñoquis', 'Exquisita Pasta para los dias 29', 3000, 2, 180)
insert into Articulo (Nombre, Descripcion, Precio, Tipo, CantidadDisponible) values ('Coca', 'Bebida', 3000, 1,180)
insert into Articulo (Nombre, Descripcion, Precio, Tipo, CantidadDisponible) values ('Milanesa A la Rudesa', 'Principal', 3000, 1,180)
----------------------------------------------------------------------------------------------
create procedure storedCarta as
select IdArticulo, Nombre, Descripcion, Precio, Tipo, CantidadDisponible from Articulo
----------------------------------------------------------------------------------------------
exec storedCarta

insert into Usuarios (Usuario, Contraseña, TipoUsuario)
values ('gerente', 'geren', 1)

insert into Usuarios (Usuario, Contraseña, TipoUsuario)
values ('mesero', 'mese', 2)
------------------------------------------------------------------------------
create procedure storedAltaArticulo
@Nombre varchar(50),
@Descripcion varchar(50),
@Precio Money,
@Tipo int,
@Cantidad int
as
insert into Articulo values (@Nombre, @Descripcion, @Precio, @Tipo, @Cantidad)

------------------------------------------------------------------------------
create procedure spAltaGerente
@Nombre varchar(50),
@apellido varchar(50),
@Usuario varchar(20),
@Contraseña varchar(20)
as
INSERT INTO Usuarios (Usuario, Contraseña, TipoUsuario)
    VALUES (@Usuario, @Contraseña, 2)

	DECLARE @IdUsuario INT
    SET @IdUsuario = SCOPE_IDENTITY()

insert into Gerente (Nombre, Apellido, IdUsuario, Activo)
values (@Nombre, @apellido, @IdUsuario, 1)
--------..----------------------------------------------------------------------

insert into Gerente (Nombre, Apellido, IdUsuario, Activo)
values ('Nombre', 'apellido', 9 , 1)


select IdGerente, Nombre, Apellido, IdUsuario, Activo from Gerente


select M.IdMesero, M.Nombre, M.Apellido, M.IdUsuario, M.Activo, U.Usuario, U.Contraseña from Mesero as M
inner join Usuarios as U On u.Id = m.IdUsuario


create PROCEDURE sp_ActualizarUsuariosGerentes
    @IdUsuario INT,
    @NuevoUsuario VARCHAR(20),
    @NuevaContraseña VARCHAR(20),
    @IdGerente INT,
    @NuevoNombre VARCHAR(50),
    @NuevoApellido VARCHAR(50)
AS
        UPDATE Usuarios
        SET 
            Usuario = @NuevoUsuario,
            Contraseña = @NuevaContraseña
        WHERE Id = @IdUsuario;

     
        UPDATE Gerente
        SET 
            Nombre = @NuevoNombre,
            Apellido = @NuevoApellido
        WHERE IdGerente = @IdGerente

    exec sp_ActualizarUsuariosMesero 6, 'Hola', 'Chau', 3, 'Joa', 'Pollez' 


CREATE PROCEDURE spEliminarUsuarioYMesero
@IdUsuario INT
AS
DELETE FROM Mesero
WHERE IdUsuario = @IdUsuario;       

DELETE FROM Usuarios
WHERE Id = @IdUsuario;


exec spEliminarUsuarioYGerente 8



CREATE PROCEDURE spEliminarUsuarioYGerente
@IdUsuario INT
AS
DELETE FROM Gerente
WHERE IdUsuario = @IdUsuario;       

DELETE FROM Usuarios
WHERE Id = @IdUsuario;




