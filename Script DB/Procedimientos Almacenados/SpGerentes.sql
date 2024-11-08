---GERENTES

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

--------------------------------------------

create PROCEDURE sp_ActualizarUsuariosGerentes
    @IdUsuario INT,
    @NuevoUsuario VARCHAR(20),
    @NuevaContrase�a VARCHAR(20),
    @IdGerente INT,
    @NuevoNombre VARCHAR(50),
    @NuevoApellido VARCHAR(50)
AS
        UPDATE Usuarios
        SET 
            Usuario = @NuevoUsuario,
            Contrase�a = @NuevaContrase�a
        WHERE Id = @IdUsuario;

     
        UPDATE Gerente
        SET 
            Nombre = @NuevoNombre,
            Apellido = @NuevoApellido
        WHERE IdGerente = @IdGerente

--------------------------------------------

CREATE PROCEDURE spEliminarUsuarioYGerente
@IdUsuario INT
AS
DELETE FROM Gerente
WHERE IdUsuario = @IdUsuario;       

DELETE FROM Usuarios
WHERE Id = @IdUsuario;

--------------------------------------------