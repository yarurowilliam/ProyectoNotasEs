--CREACION DOCENTE

CREATE TABLE Docente (
    TipoIdentificacion VARCHAR2(50) NOT NULL,
    NumeroIdentificacion VARCHAR2(20) PRIMARY KEY,
    PrimerNombre VARCHAR2(50) NOT NULL,
    SegundoNombre VARCHAR2(50),
    PrimerApellido VARCHAR2(50) NOT NULL,
    SegundoApellido VARCHAR2(50),
    FechaNacimiento DATE NOT NULL,
    Telefono VARCHAR2(15),
    Direccion VARCHAR2(100),
    Correo VARCHAR2(100),
    Practicante NUMBER(1) DEFAULT 0 CHECK (Practicante IN (0, 1)),
    FechaCreacion DATE DEFAULT SYSDATE,
    FechaModificacion DATE,
    UltimoUsuario VARCHAR2(50),
    Estado VARCHAR2(10) DEFAULT 'ACTIVO' CHECK (Estado IN ('ACTIVO', 'INACTIVO'))
);

CREATE TABLE Usuario (
    Identificacion VARCHAR2(20) PRIMARY KEY,
    Password VARCHAR2(50) DEFAULT 'Colegio2024',
    Estado VARCHAR2(10) DEFAULT 'ACTIVO' CHECK (Estado IN ('ACTIVO', 'INACTIVO'))
);


--FUNCIONES

CREATE OR REPLACE FUNCTION CalcularEdad(p_FechaNacimiento DATE) RETURN NUMBER IS
    v_Edad NUMBER;
BEGIN
    v_Edad := TRUNC(MONTHS_BETWEEN(SYSDATE, p_FechaNacimiento) / 12);
    RETURN v_Edad;
END CalcularEdad;
/

-- Especificaci�n del Paquete PARA LA GESTION DOCENTE
CREATE OR REPLACE PACKAGE GestionDocente AS
    PROCEDURE InsertarDocente (
        p_TipoIdentificacion IN VARCHAR2,
        p_NumeroIdentificacion IN VARCHAR2,
        p_PrimerNombre IN VARCHAR2,
        p_SegundoNombre IN VARCHAR2,
        p_PrimerApellido IN VARCHAR2,
        p_SegundoApellido IN VARCHAR2,
        p_FechaNacimiento IN DATE,
        p_Telefono IN VARCHAR2,
        p_Direccion IN VARCHAR2,
        p_Correo IN VARCHAR2,
        p_Practicante IN NUMBER,
        p_UltimoUsuario IN VARCHAR2
    );

    PROCEDURE ConsultarDocente (
        p_NumeroIdentificacion IN VARCHAR2 DEFAULT NULL,
        resultado OUT SYS_REFCURSOR
    );

    PROCEDURE ModificarDocente (
        p_NumeroIdentificacion IN VARCHAR2,
        p_TipoIdentificacion IN VARCHAR2,
        p_PrimerNombre IN VARCHAR2,
        p_SegundoNombre IN VARCHAR2,
        p_PrimerApellido IN VARCHAR2,
        p_SegundoApellido IN VARCHAR2,
        p_FechaNacimiento IN DATE,
        p_Telefono IN VARCHAR2,
        p_Direccion IN VARCHAR2,
        p_Correo IN VARCHAR2,
        p_Practicante IN NUMBER,
        p_Estado IN VARCHAR2,
        p_UltimoUsuario IN VARCHAR2
    );

    PROCEDURE InactivarDocente (
        p_NumeroIdentificacion IN VARCHAR2
    );
END GestionDocente;
/

-- Cuerpo del Paquete
CREATE OR REPLACE PACKAGE BODY GestionDocente AS
    PROCEDURE InsertarDocente (
        p_TipoIdentificacion IN VARCHAR2,
        p_NumeroIdentificacion IN VARCHAR2,
        p_PrimerNombre IN VARCHAR2,
        p_SegundoNombre IN VARCHAR2,
        p_PrimerApellido IN VARCHAR2,
        p_SegundoApellido IN VARCHAR2,
        p_FechaNacimiento IN DATE,
        p_Telefono IN VARCHAR2,
        p_Direccion IN VARCHAR2,
        p_Correo IN VARCHAR2,
        p_Practicante IN NUMBER,
        p_UltimoUsuario IN VARCHAR2
    ) AS
    BEGIN
        -- Insertar en la tabla Docente
        INSERT INTO Docente (
            TipoIdentificacion,
            NumeroIdentificacion,
            PrimerNombre,
            SegundoNombre,
            PrimerApellido,
            SegundoApellido,
            FechaNacimiento,
            Telefono,
            Direccion,
            Correo,
            Practicante,
            FechaCreacion,
            Estado,
            UltimoUsuario
        ) VALUES (
            p_TipoIdentificacion,
            p_NumeroIdentificacion,
            p_PrimerNombre,
            p_SegundoNombre,
            p_PrimerApellido,
            p_SegundoApellido,
            p_FechaNacimiento,
            p_Telefono,
            p_Direccion,
            p_Correo,
            p_Practicante,
            SYSDATE,
            'ACTIVO',
            p_UltimoUsuario
        );

        -- Insertar en la tabla Usuario
        INSERT INTO Usuario (
            Identificacion,
            Password,
            Estado
        ) VALUES (
            p_NumeroIdentificacion,
            'Colegio2024', -- Contraseña predeterminada
            'ACTIVO'       -- Estado inicial
        );

    END InsertarDocente;

    PROCEDURE ConsultarDocente (
        p_NumeroIdentificacion IN VARCHAR2 DEFAULT NULL,
        resultado OUT SYS_REFCURSOR
    ) AS
    BEGIN
        OPEN resultado FOR
            SELECT TipoIdentificacion,
                   NumeroIdentificacion,
                   PrimerNombre,
                   SegundoNombre,
                   PrimerApellido,
                   SegundoApellido,
                   FechaNacimiento,
                   CalcularEdad(FechaNacimiento) AS Edad,
                   Telefono,
                   Direccion,
                   Correo,
                   Practicante,
                   FechaCreacion,
                   FechaModificacion,
                   UltimoUsuario,
                   Estado
            FROM Docente
            WHERE (p_NumeroIdentificacion IS NULL OR NumeroIdentificacion = p_NumeroIdentificacion);
    END ConsultarDocente;

    PROCEDURE ModificarDocente (
        p_NumeroIdentificacion IN VARCHAR2,
        p_TipoIdentificacion IN VARCHAR2,
        p_PrimerNombre IN VARCHAR2,
        p_SegundoNombre IN VARCHAR2,
        p_PrimerApellido IN VARCHAR2,
        p_SegundoApellido IN VARCHAR2,
        p_FechaNacimiento IN DATE,
        p_Telefono IN VARCHAR2,
        p_Direccion IN VARCHAR2,
        p_Correo IN VARCHAR2,
        p_Practicante IN NUMBER,
        p_Estado IN VARCHAR2,
        p_UltimoUsuario IN VARCHAR2
    ) AS
    BEGIN
        UPDATE Docente
        SET TipoIdentificacion = p_TipoIdentificacion,
            PrimerNombre = p_PrimerNombre,
            SegundoNombre = p_SegundoNombre,
            PrimerApellido = p_PrimerApellido,
            SegundoApellido = p_SegundoApellido,
            FechaNacimiento = p_FechaNacimiento,
            Telefono = p_Telefono,
            Direccion = p_Direccion,
            Correo = p_Correo,
            Practicante = p_Practicante,
            Estado = p_Estado,
            UltimoUsuario = p_UltimoUsuario
        WHERE NumeroIdentificacion = p_NumeroIdentificacion;
    END ModificarDocente;

    PROCEDURE InactivarDocente (
        p_NumeroIdentificacion IN VARCHAR2
    ) AS
    BEGIN
        UPDATE Docente
        SET Estado = 'INACTIVO'
        WHERE NumeroIdentificacion = p_NumeroIdentificacion;

        UPDATE Usuario
        SET Estado = 'INACTIVO'
        WHERE Identificacion = p_NumeroIdentificacion;
    END InactivarDocente;
END GestionDocente;
/

CREATE OR REPLACE TRIGGER trg_update_fecha_modificacion
BEFORE UPDATE ON Docente
FOR EACH ROW
BEGIN
    :NEW.FechaModificacion := SYSDATE;
END;
/