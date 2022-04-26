using Modelos;

namespace Examen.Pages.Interfaces;

public interface IUsuarioServicio
{
    Task<bool> Nuevo(Usuario usuario);

    Task<IEnumerable<Usuario>> GetLista();
    Task<Usuario> GetPorCodigo(string codigo);
}
