using System.Collections.Generic;
using System.Drawing;

namespace Moda_System.Classes
{
    public interface IProdutoRepositorio : IRepositorioBase<Produto>
    {
        //Aqui Implemento métodos Especializados
        IEnumerable<Produto> BuscarPorNome(string nome);
        List<Produto> ConsultaPro(Produto filtro);
        Image GetImagePro(int codPro);
        string Add_and_Update(Produto pro);
    }
}
