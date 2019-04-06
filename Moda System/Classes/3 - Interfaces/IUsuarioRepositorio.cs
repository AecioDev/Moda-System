
using System.Collections.Generic;

namespace Moda_System.Classes
{
    public interface IUsuarioRepositorio : IRepositorioBase<Usuario>
    {
        Usuario BuscarPorLogin(string login);
        List<Usuario> ConsultaUser(string login, string status, string nome);
    }
}
