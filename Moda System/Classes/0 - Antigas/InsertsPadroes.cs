namespace Moda_System.Classes
{
    public class InsertsPadroes
    {
        public static string InsereDados(int codScript)
        {
            string script = "";
            switch (codScript)
            {
                case 0:
                    script = "INSERT INTO Usuario (StaUser, NomeUser, EmailUser, LoginUser, SenUser, PerfilUser) VALUES('A', 'Conta Interna de Suporte', 'modasystem@gmail.com', 'ADMIN', '26724c7966cd6be98cfb44f7c1d46b48', 'A');";
                    break;
                case 1:
                    script = "INSERT INTO SYS000 (VersaoSistema, ScriptBD) VALUES(1, 0);";
                    break;
                default:
                    script = "FIM";
                    break;
            }

            return script;
        }
    }
}
