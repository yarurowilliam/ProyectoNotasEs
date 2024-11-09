using DAL;
using Entity;

namespace BLL;

public class RolesBLL
{
    private readonly RolesDAL _rolesDAL;

    public RolesBLL()
    {
        _rolesDAL = new RolesDAL();
    }

    public async Task<bool> InsertarRolAsync(string nombreRol)
    {
        if (string.IsNullOrWhiteSpace(nombreRol))
            throw new ArgumentException("El nombre del rol es obligatorio.");

        return await _rolesDAL.InsertarRolAsync(nombreRol);
    }

    public async Task<Rol> ConsultarRolPorNombreAsync(string nombreRol)
    {
        if (string.IsNullOrWhiteSpace(nombreRol))
            throw new ArgumentException("El nombre del rol es obligatorio.");

        return await _rolesDAL.ConsultarRolPorNombreAsync(nombreRol);
    }

    public async Task<bool> InactivarRolAsync(string nombreRol)
    {
        if (string.IsNullOrWhiteSpace(nombreRol))
            throw new ArgumentException("El nombre del rol es obligatorio.");

        return await _rolesDAL.InactivarRolAsync(nombreRol);
    }
}
