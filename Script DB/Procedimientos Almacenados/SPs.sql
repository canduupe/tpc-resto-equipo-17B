create procedure spAltaMesero
@Nombre varchar(50),
@apellido varchar(50),
@Usuario varchar(20),
@Contrase�a varchar(20)
as
INSERT INTO Usuarios (Usuario, Contrase�a, TipoUsuario)
    VALUES (@Usuario, @Contrase�a, 2)

	DECLARE @IdUsuario INT
    SET @IdUsuario = SCOPE_IDENTITY()

insert into Mesero (Nombre, Apellido, IdUsuario, Activo)
values (@Nombre, @apellido, @IdUsuario, 1)



create procedure spAltaGerente
@Nombre varchar(50),
@apellido varchar(50),
@Usuario varchar(20),
@Contrase�a varchar(20)
as
INSERT INTO Usuarios (Usuario, Contrase�a, TipoUsuario)
    VALUES (@Usuario, @Contrase�a, 2)

	DECLARE @IdUsuario INT
    SET @IdUsuario = SCOPE_IDENTITY()

insert into Gerente (Nombre, Apellido, IdUsuario, Activo)
values (@Nombre, @apellido, @IdUsuario, 1)



create PROCEDURE sp_ActualizarUsuariosMesero
    @IdUsuario INT,
    @NuevoUsuario VARCHAR(20),
    @NuevaContrase�a VARCHAR(20),
    @IdMesero INT,
    @NuevoNombre VARCHAR(50),
    @NuevoApellido VARCHAR(50)
AS
        UPDATE Usuarios
        SET 
            Usuario = @NuevoUsuario,
            Contrase�a = @NuevaContrase�a
        WHERE Id = @IdUsuario;

     
        UPDATE Mesero
        SET 
            Nombre = @NuevoNombre,
            Apellido = @NuevoApellido
        WHERE IdMesero = @IdMesero



create procedure storedCarta as
select IdArticulo, Nombre, Descripcion, Precio, Tipo, CantidadDisponible from Articulo


create procedure storedAltaArticulo
@Nombre varchar(50),
@Descripcion varchar(50),
@Precio Money,
@Tipo int,
@Cantidad int
as
insert into Articulo values (@Nombre, @Descripcion, @Precio, @Tipo, @Cantidad)
