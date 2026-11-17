using Microsoft.Data.SqlClient; // Ou System.Data.SqlClient para projetos legadosusing MySqlConnector;using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text.RegularExpressions;
using MySql.Data.MySqlClient;

namespace CRUD_CONTACORRENTE.DAO
{
    public class ConnectDAO
    {
        // Ajuste o nome do banco, usuario e senha conforme o MySQL do seu XAMPP.
        private readonly string connectionString =
            "Server=127.0.0.1;Port=3306;Database=MOV_CONTA_CORRENTE;Uid=root;Pwd=;";

        public MySqlConnection GetConnection() => new MySqlConnection(connectionString);

        public bool TestarConexao()
        {
            try
            {
                using var connection = GetConnection();
                connection.Open();
                return true;
            }
            catch (MySqlException) { return false; }
        }

        // Mantido por compatibilidade com a chamada ja existente no FrmAgencias.
        // As conexoes dos outros metodos sao fechadas automaticamente pelo using.
        public bool FecharConexao()
        {
            try
            {
                using var connection = GetConnection();
                connection.Close();
                return true;
            }
            catch (MySqlException) { return false; }
        }

        private static string Identificador(string nome)
        {
            if (string.IsNullOrWhiteSpace(nome) ||
                !Regex.IsMatch(nome, @"^[A-Za-z_][A-Za-z0-9_]*$"))
                throw new ArgumentException("Nome de tabela ou coluna invalido.", nameof(nome));
            return $"`{nome}`";
        }

        private static void AdicionarParametros(MySqlCommand comando, IReadOnlyDictionary<string, object?> valores)
        {
            foreach (var item in valores)
                comando.Parameters.AddWithValue("@" + item.Key, item.Value ?? DBNull.Value);
        }

        // INSERT: adiciona um registro e retorna a quantidade de linhas afetadas.
        public int Inserir(string tabela, IReadOnlyDictionary<string, object?> valores)
        {
            if (valores == null || valores.Count == 0) throw new ArgumentException("Informe os valores.");
            string colunas = string.Join(", ", valores.Keys.Select(Identificador));
            string parametros = string.Join(", ", valores.Keys.Select(c => "@" + c));
            string sql = $"INSERT INTO {Identificador(tabela)} ({colunas}) VALUES ({parametros})";
            using var conexao = GetConnection();
            using var comando = new MySqlCommand(sql, conexao);
            AdicionarParametros(comando, valores);
            conexao.Open();
            return comando.ExecuteNonQuery();
        }

        // SELECT: consulta todos os registros da tabela e devolve um DataTable.
        public DataTable Selecionar(string tabela)
        {
            string sql = $"SELECT * FROM {Identificador(tabela)}";
            using var conexao = GetConnection();
            using var comando = new MySqlCommand(sql, conexao);
            using var adaptador = new MySqlDataAdapter(comando);
            var resultado = new DataTable();
            adaptador.Fill(resultado);
            return resultado;
        }

        // UPDATE: altera colunas de um registro identificado por sua chave.
        public int Atualizar(string tabela, string colunaId, object id,
            IReadOnlyDictionary<string, object?> valores)
        {
            if (valores == null || valores.Count == 0) throw new ArgumentException("Informe os valores.");
            string alteracoes = string.Join(", ", valores.Keys.Select(c => $"{Identificador(c)} = @set_{c}"));
            string sql = $"UPDATE {Identificador(tabela)} SET {alteracoes} WHERE {Identificador(colunaId)} = @id";
            using var conexao = GetConnection();
            using var comando = new MySqlCommand(sql, conexao);
            foreach (var item in valores)
                comando.Parameters.AddWithValue("@set_" + item.Key, item.Value ?? DBNull.Value);
            comando.Parameters.AddWithValue("@id", id);
            conexao.Open();
            return comando.ExecuteNonQuery();
        }

        // DELETE: exclui apenas o registro identificado pela chave informada.
        public int Excluir(string tabela, string colunaId, object id)
        {
            string sql = $"DELETE FROM {Identificador(tabela)} WHERE {Identificador(colunaId)} = @id";
            using var conexao = GetConnection();
            using var comando = new MySqlCommand(sql, conexao);
            comando.Parameters.AddWithValue("@id", id);
            conexao.Open();
            return comando.ExecuteNonQuery();
        }
    }
}
