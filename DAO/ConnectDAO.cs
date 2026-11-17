using Microsoft.Data.SqlClient; // Ou System.Data.SqlClient para projetos legadosusing MySqlConnector;using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CRUD_CONTACORRENTE.DAO
{
    public class ConnectDAO
    {
        /*
            // String de conexão com o SQL Server
            private readonly string connectionString =
                @"Server=localhost;
                  Database=MOV_CONTA_CORRENTE;
                  User Id=corredato;
                  Password=Abc@123;
                  TrustServerCertificate=True;";
            // Método responsável por criar a conexão
            public SqlConnection GetConnection()
            {
                return new SqlConnection(connectionString);
            }
        */// String de conexão com o MySQL no Xamppstring conexaoString = "datasource=127.0.0.1;port=3306;username=root;password=;database=sua_base;";
        private readonly string connectionString =
@"datasource=127.0.0.1;
              port=3306;
              username=root;
              password=;
              database=MOV_CONTA_CORRENTE;";
        public MySqlConnection GetConnection()
        {
            return new MySqlConnection(connectionString);
        }       
        // Método para testar a conexãopublic bool TestarConexao()
        {
            try            {
                using (MySqlConnection connection = GetConnection())
                {
                    connection.Open();
                    return true;
                }
}
            catch            {
    return false;
}
        }
        public bool FecharConexao()
{
    try
    {
        using (MySqlConnection connection = GetConnection())
        {
            connection.Close();
            return true;
        }
    }
    catch
    {
        return false;
    }
}
public bool InsereRegistroJFDB(string tabela, string strDados)
{
    try
    {
        using (MySqlConnection connection = GetConnection())
        {
            connection.Open();
            string sql = $"INSERT INTO dbo.{tabela} VALUES ({strDados})";
            Console.WriteLine("String de Insert: " + sql);
            using (MySqlCommand command = new MySqlCommand(sql, connection))
            {
                int registrosAfetados = command.ExecuteNonQuery();
                Console.WriteLine(
                $"Inclusão executada com sucesso! Registros afetados: {registrosAfetados}");
                return true;
            }
        }
    }
    catch (SqlException erro)
    {
        Console.WriteLine("Erro SQL:");
        Console.WriteLine($"Mensagem: {erro.Message}");
        Console.WriteLine($"Estado: {erro.State}");
        Console.WriteLine($"Código: {erro.Number}");
        return false;
    }
    catch (Exception erro)
    {
        Console.WriteLine("Erro geral:");
        Console.WriteLine(erro.Message);
        return false;
    }
}
    }
}