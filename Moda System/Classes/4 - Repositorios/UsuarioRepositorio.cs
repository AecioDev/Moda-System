
using System.Collections.Generic;
using System.Linq;

namespace Moda_System.Classes
{
    public class UsuarioRepositorio : RepositorioBase<Usuario>, IUsuarioRepositorio
    {
        public Usuario BuscarPorLogin(string login)
        {
            return Db.Usuario.Where(u => u.LoginUser == login).FirstOrDefault();
        }

        public List<Usuario> ConsultaUser(string login, string status, string nome)
        {
            var user = Db.Usuario.AsQueryable();

            if (!string.IsNullOrEmpty(status))
                user = user.Where(u => u.StaUser == status);

            if (!string.IsNullOrEmpty(login))
                user = user.Where(u => u.LoginUser.Contains(login));

            if (!string.IsNullOrEmpty(nome))
                user = user.Where(u => u.NomeUser.Contains(nome));

            return user.ToList();

        }
    }
}
