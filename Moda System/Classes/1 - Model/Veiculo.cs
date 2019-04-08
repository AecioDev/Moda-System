
namespace Moda_System.Classes
{
    public class Veiculo
    {
        public Veiculo() { }

        public int VeiculoId { get; set; }
        public string DescVeiculo { get; set; }
        public string PlacaVeiculo { get; set; }
        public int CodMotorista { get; set; }
        public int CodLocal { get; set; }

        public virtual Estoque Estoque { get; set; }
        public virtual Vendedor Motorista { get; set; }

    }
}
