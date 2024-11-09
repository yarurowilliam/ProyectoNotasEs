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


--FUNCIONES

CREATE OR REPLACE FUNCTION CalcularEdad(p_FechaNacimiento DATE) RETURN NUMBER IS
    v_Edad NUMBER;
BEGIN
    v_Edad := TRUNC(MONTHS_BETWEEN(SYSDATE, p_FechaNacimiento) / 12);
    RETURN v_Edad;
END CalcularEdad;
/

-- Especificación del Paquete PARA LA GESTION DOCENTE
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
        p_TipoIdentificacion IN VARCHAR2 DEFAULT NULL,
        p_NumeroIdentificacion IN VARCHAR2 DEFAULT NULL,
        p_PrimerNombre IN VARCHAR2 DEFAULT NULL,
        p_SegundoNombre IN VARCHAR2 DEFAULT NULL,
        p_PrimerApellido IN VARCHAR2 DEFAULT NULL,
        p_SegundoApellido IN VARCHAR2 DEFAULT NULL,
        p_FechaNacimiento IN DATE DEFAULT NULL,
        p_Telefono IN VARCHAR2 DEFAULT NULL,
        p_Direccion IN VARCHAR2 DEFAULT NULL,
        p_Correo IN VARCHAR2 DEFAULT NULL,
        p_Practicante IN NUMBER DEFAULT NULL,
        p_Estado IN VARCHAR2 DEFAULT NULL,
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
    END InsertarDocente;

    PROCEDURE ConsultarDocente (
        p_TipoIdentificacion IN VARCHAR2 DEFAULT NULL,
        p_NumeroIdentificacion IN VARCHAR2 DEFAULT NULL,
        p_PrimerNombre IN VARCHAR2 DEFAULT NULL,
        p_SegundoNombre IN VARCHAR2 DEFAULT NULL,
        p_PrimerApellido IN VARCHAR2 DEFAULT NULL,
        p_SegundoApellido IN VARCHAR2 DEFAULT NULL,
        p_FechaNacimiento IN DATE DEFAULT NULL,
        p_Telefono IN VARCHAR2 DEFAULT NULL,
        p_Direccion IN VARCHAR2 DEFAULT NULL,
        p_Correo IN VARCHAR2 DEFAULT NULL,
        p_Practicante IN NUMBER DEFAULT NULL,
        p_Estado IN VARCHAR2 DEFAULT NULL,
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
            WHERE (p_TipoIdentificacion IS NULL OR TipoIdentificacion = p_TipoIdentificacion)
              AND (p_NumeroIdentificacion IS NULL OR NumeroIdentificacion = p_NumeroIdentificacion)
              AND (p_PrimerNombre IS NULL OR PrimerNombre = p_PrimerNombre)
              AND (p_SegundoNombre IS NULL OR SegundoNombre = p_SegundoNombre)
              AND (p_PrimerApellido IS NULL OR PrimerApellido = p_PrimerApellido)
              AND (p_SegundoApellido IS NULL OR SegundoApellido = p_SegundoApellido)
              AND (p_FechaNacimiento IS NULL OR FechaNacimiento = p_FechaNacimiento)
              AND (p_Telefono IS NULL OR Telefono = p_Telefono)
              AND (p_Direccion IS NULL OR Direccion = p_Direccion)
              AND (p_Correo IS NULL OR Correo = p_Correo)
              AND (p_Practicante IS NULL OR Practicante = p_Practicante)
              AND (p_Estado IS NULL OR Estado = p_Estado);
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
    END InactivarDocente;
END GestionDocente;
/


