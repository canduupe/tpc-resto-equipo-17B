----MESEROS

create procedure spAltaMesero
@Nombre varchar(50),
@apellido varchar(50),
@Usuario varchar(20),
@Contraseña varchar(20)
as
INSERT INTO Usuarios (Usuario, Contraseña, TipoUsuario)
    VALUES (@Usuario, @Contraseña, 2)

	DECLARE @IdUsuario INT
    SET @IdUsuario = SCOPE_IDENTITY()

insert into Mesero (Nombre, Apellido, IdUsuario, Activo)
values (@Nombre, @apellido, @IdUsuario, 1)

 -----------------------------------------

 create PROCEDURE sp_ActualizarUsuariosMesero
    @IdUsuario INT,
    @NuevoUsuario VARCHAR(20),
    @NuevaContraseña VARCHAR(20),
    @IdMesero INT,
    @NuevoNombre VARCHAR(50),
    @NuevoApellido VARCHAR(50)
AS
        UPDATE Usuarios
        SET 
            Usuario = @NuevoUsuario,
            Contraseña = @NuevaContraseña
        WHERE Id = @IdUsuario;

     
        UPDATE Mesero
        SET 
            Nombre = @NuevoNombre,
            Apellido = @NuevoApellido
        WHERE IdMesero = @IdMesero

 -----------------------------------------

 CREATE PROCEDURE spEliminarUsuarioYMesero
@IdUsuario INT
AS
DELETE FROM Mesero
WHERE IdUsuario = @IdUsuario;       

DELETE FROM Usuarios
WHERE Id = @IdUsuario;

 -----------------------------------------

