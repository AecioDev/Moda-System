using System;
using System.IO;
using System.Configuration;
using System.Windows.Forms;
using System.Data.SqlServerCe;
using System.Drawing;
using System.Drawing.Imaging;
using Canducci.Zip;
using System.Security.Cryptography;
using System.Text;

namespace Moda_System.Classes
{
    //Classe Responsável por Prover Informações Globais para o Sistema
    //Criada em 22/01/2019
    //Aécio Espinoza Miranda   

    public class Funcoes 
    {
        public static int versao = 1;

        public static string folder = Environment.CurrentDirectory + @"\Dados\";
        public static string PathArquivo = folder + "Connection.cfg"; //Caminho completo do arquivo        
        public static string PathBD = folder + "ModaSystemBD.sdf";

        //String de Conexxão do Banco de Dados
        public static string strConn = String.Format("DataSource={0}; Password='{1}'", PathBD, "9854");
        public static string msgCab = "Moda System";

        public static string ValidaBancoDados(string pastaBD)
        {            
            int retorno = 0;
            int scriptBD = 0;
            string scriptTable = "";         
            SqlCeConnection conexao = null;
            SqlCeCommand comd = null;

            try
            {
                if (pastaBD.Length > 0)
                {
                    #region Novo Cria banco de Dados
                    /********************** Trecho que cria o Banco de Dados e as Tabelas *****************************/
                    if (!Directory.Exists(pastaBD))
                    {
                        DirectoryInfo diretorio = Directory.CreateDirectory(pastaBD);
                        diretorio.Attributes = FileAttributes.Hidden;
                    }

                    pastaBD = pastaBD + @"\ModaSystem.sdf";
                    scriptTable = String.Format("DataSource={0}; Password='{1}'", pastaBD, "9854");
                    //Mensagem: Aguarde... Criando Banco de Dados!!!
                    SqlCeEngine SqlEng = new SqlCeEngine(scriptTable);
                    SqlEng.CreateDatabase();

                    GravaArquivoConexao(scriptTable);

                    /********************** Cria as tabelas do banco de dados *****************************/
                    //Mensagem - "Criando as Tabelas...\n";
                    conexao = Funcoes.CriaConexao();
                    conexao.Open();

                    while (true)
                    {
                        scriptTable = CriaTabelasBD.CriaTabelas(scriptBD); //Carrega o script
                        if (scriptTable != "FIM")
                        {
                            comd = new SqlCeCommand(scriptTable, conexao);
                            retorno = comd.ExecuteNonQuery();   //Executa o script
                            scriptBD++;
                        }
                        else
                            break;
                    }
                    //Mensagem - "Tabelas criadas com sucesso!!!";
                    conexao.Close();

                    /************************* Cria os Índices das Tabelas ********************************/
                    //Mensagem - "Criando Índices das Tabelas...\n";
                    conexao = Funcoes.CriaConexao();
                    conexao.Open();
                    scriptBD = 0;
                    while (true)
                    {
                        scriptTable = CriaTabelasBD.CriaIndices(scriptBD); //Carrega o script
                        if (scriptTable != "FIM")
                        {
                            comd = new SqlCeCommand(scriptTable, conexao);
                            retorno = comd.ExecuteNonQuery();   //Executa o script
                            scriptBD++;
                        }
                        else
                            break;
                    }
                    //Mensagem - "Índices criados com sucesso!!!";
                    conexao.Close();

                    /********************** Cria o Relacionamento entre Tabelas *****************************/
                    //Mensagem - "Criando as Referências das Tabelas...\n";
                    conexao = Funcoes.CriaConexao();
                    conexao.Open();
                    scriptBD = 0;
                    while (true)
                    {
                        scriptTable = CriaTabelasBD.CriaReferencias(scriptBD); //Carrega o script
                        if (scriptTable != "FIM")
                        {
                            comd = new SqlCeCommand(scriptTable, conexao);
                            retorno = comd.ExecuteNonQuery();   //Executa o script
                            scriptBD++;
                        }
                        else
                            break;
                    }
                    //Mensagem - "Referências criadas com sucesso!!!";
                    conexao.Close();

                    /********************** Faz a inserção dos dados iniciais. *****************************/
                    //Mensagem - "Inserindo dados iniciais...\n";
                    conexao = Funcoes.CriaConexao();
                    conexao.Open();
                    scriptBD = 0;
                    while (true)
                    {
                        scriptTable = InsertsPadroes.InsereDados(scriptBD); //Carrega o script
                        if (scriptTable != "FIM")
                        {
                            comd = new SqlCeCommand(scriptTable, conexao);
                            retorno = comd.ExecuteNonQuery();   //Executa o script
                            scriptBD++;
                        }
                        else
                            break;
                    }
                    //Mensagem - "Dados iniciais inseridos com sucesso!!! \n";
                    conexao.Close();
                    #endregion
                }
                else
                {
                    /********************** Este Trecho faz a Atualização do Banco de Dados *****************************/

                    //Busca o número do último script executado
                    //Mensagem: Aguarde... Verificando Estrutura do Banco de Dados
                    conexao = Funcoes.CriaConexao();
                    scriptTable = "SELECT scriptBD FROM SYS000 WHERE versaoSistema = " + versao;
                    comd = new SqlCeCommand(scriptTable, conexao);
                    conexao.Open();
                    SqlCeDataReader reader = comd.ExecuteReader();
                    while (reader.Read())
                    {
                        scriptBD = reader.GetInt32(0);
                    }
                    conexao.Close();

                    //Cria as tabelas do banco de dados
                    //Mensagem - "Criando as Tabelas...\n";
                    conexao = Funcoes.CriaConexao();
                    conexao.Open();

                    while (true)
                    {
                        scriptTable = AtualizaBD.Script(scriptBD); //Carrega o script
                        if (scriptTable != "FIM")
                        {
                            comd = new SqlCeCommand(scriptTable, conexao);
                            retorno = comd.ExecuteNonQuery();   //Executa o script
                            scriptBD++;
                        }
                        else
                            break;
                    }
                    //Mensagem - "Tabelas criadas com sucesso!!!";
                    conexao.Close();

                    //Atualiza Tabela de Parametros SYS000 com o ultimo script executado
                    conexao = Funcoes.CriaConexao();
                    scriptTable = "UPDATE SYS000 SET scriptBD = " + scriptBD + " WHERE versaoSistema = " + versao; //Grava o próximo script a ser executado
                    comd = new SqlCeCommand(scriptTable, conexao);
                    conexao.Open();
                    comd.ExecuteNonQuery();
                    conexao.Close();
                }

                return "OK";
            }
            catch (Exception ex)
            {
                return ex.Message;
                //MessageBox.Show("Erro ao criar o Banco De Dados!!!\n\n" + ex.Message, msgCab,
                //            MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #region Leitura e Gravação do Arquivo de Conexão
        public static void CriArquivoConexao()
        {
            try
            {
                if (!Directory.Exists(folder))
                {
                    DirectoryInfo diretorio = Directory.CreateDirectory(folder);
                    diretorio.Attributes = FileAttributes.Hidden;
                }

                FileStream fs = new FileStream(PathArquivo, FileMode.Create, FileAccess.ReadWrite);

                //MessageBox.Show("Arquivo de Conexão Criado com Sucesso!!!", msgCab,
                //            MessageBoxButtons.OK, MessageBoxIcon.Information);

                fs.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao criar o arquivo de Conexão!!!\n\n" + ex.Message, msgCab,
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
                
        public static void GravaArquivoConexao(string conexao)
        {
            try
            {
                FileStream fs = new FileStream(PathArquivo, FileMode.Create, FileAccess.Write);
                StreamWriter sw = new StreamWriter(fs);

                sw.WriteLine(conexao);

                sw.Close(); //grava e fecha

                //MessageBox.Show("Conexão gravada com Sucesso!!!", msgCab,
                //            MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao gravar a conexão no arquivo de Conexão!!!\n\n" + ex.Message, msgCab,
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static string Busca_Conexao()
        {
            string connstr = "";
            try
            {
                if (!File.Exists(PathArquivo))
                {
                    //Se não existir Chama a tela para cadastrar a conexão
                    //ConexaoSQL conexao = new ConexaoSQL();
                    //conexao.ShowDialog();
                }

                FileStream fs = new FileStream(PathArquivo, FileMode.Open, FileAccess.Read);
                StreamReader sr = new StreamReader(fs);
                connstr = sr.ReadToEnd();
                sr.Close(); //grava e fecha

                return connstr.Trim();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao buscar o arquivo de Conexão!!!\n\n" + ex.Message, msgCab,
                           MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return connstr;

        }

        public static SqlCeConnection CriaConexao()
        {
            SqlCeConnection Conn = new SqlCeConnection(Busca_Conexao());
            return Conn;
        }
        #endregion

        //Função utilizada para converter a imagem em binário para salvar no banco de dados.
        public static byte[] SetImage(Image picFoto, string ext)
        {
            byte[] img_array = null;

            //convertendo a foto para dados binários
            if (picFoto != null)
            {
                MemoryStream ms = new MemoryStream();
                if (ext == ".png")
                    picFoto.Save(ms, ImageFormat.Png);

                if (ext == ".jpg")
                    picFoto.Save(ms, ImageFormat.Jpeg);

                if (ext == ".gif")
                    picFoto.Save(ms, ImageFormat.Gif);

                byte[] foto_array = new byte[ms.Length];

                ms.Position = 0;
                ms.Read(foto_array, 0, foto_array.Length);
                img_array = foto_array;
            }

            return img_array;
        }

        //public static byte[] Set_Image(FileInfo file)
        //{
        //    BinaryReader reader = new BinaryReader(file.OpenRead());
        //    return reader.ReadBytes((int)file.Length);
        //}

        public static Image GetImage(byte[] foto)
        {
            Image imgFoto = null;

            if (foto.Length > 0)
            {
                MemoryStream ms = new MemoryStream(foto, true);

                imgFoto = Image.FromStream(ms, true);
            }
            return imgFoto;
        }

        public static ModelEndereco BuscaEnd(string cep)
        {
            ZipCodeLoad load = new ZipCodeLoad();
            try
            {
                ModelEndereco end = new ModelEndereco();
                ZipCodeInfo endereco = load.Find(cep); // BUSCA DE CEP
                
                if (endereco.Erro == false)
                {
                    end.Rua = endereco.Address;
                    end.Complemento = endereco.Complement;
                    end.Bairro = endereco.District;
                    end.Cidade = endereco.City;
                    end.Estado = endereco.Uf;
                    end.Resultado = 1;
                }
                else
                {
                    end.Resultado = 0;
                }
                return end;
            }
            catch (ZipCodeException ex)
            {
                throw ex;
            }
        }

        public static string GetMd5Hash(string input)
        {
            MD5 md5Hash = MD5.Create();

            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));

            StringBuilder sBuilder = new StringBuilder();

            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }

            return sBuilder.ToString();
        }

        public static bool VerifyMd5Hash(string input, string hash)
        {
            MD5 md5Hash = MD5.Create();

            // Create a StringComparer an compare the hashes.
            StringComparer comparer = StringComparer.OrdinalIgnoreCase;

            if (0 == comparer.Compare(input, hash))
                return true;
            else
                return false;
        }
    }
}
