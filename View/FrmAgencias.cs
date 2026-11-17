using CRUD_CONTA_CORRENTE.DAO;
using CRUD_CONTACORRENTE.DAO;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD_CONTA_CORRENTE
{
    public partial class FrmAgencia : Form
    {
        public FrmAgencia()
        {
            InitializeComponent();
        }



        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void lblCidaAge_Click(object sender, EventArgs e)
        {

        }

        private void lblEndeAge_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblNumAge_Click(object sender, EventArgs e)
        {

        }

        private void btnVisualizar_Click(object sender, EventArgs e)
        {
            string ID_Age = TxBIDAge.Text;
            string Nome_Age = TxBNomeAge.Text;
            string Ende_Age = TxBEndeAge.Text;
            string Nume_Age = TxBNumAge.Text;
            string Bairro_Age = TxBBairAge.Text;
            string Cidade_Age = TxBCidAge.Text;
            string UF_Age = TxBUFAge.Text; // Ajustado para refletir o campo correto de UF
            string CEP_Age = TxBCEPAge.Text;
            string Fone_Age = TxBNumeAge.Text;

            string mensagem = $"ID da Agência: {ID_Age}\n" +
                             $"Nome da Agência: {Nome_Age}\n" +
                             $"Endereço: {Ende_Age}\n" +
                             $"Número: {Nume_Age}\n" +
                             $"Bairro: {Bairro_Age}\n" +
                             $"Cidade: {Cidade_Age}\n" +
                             $"UF: {UF_Age}\n" +
                             $"CEP: {CEP_Age}\n" +
                             $"Telefone: {Fone_Age}";
        }


        private void BtnVisualizar_Click(object sender, EventArgs e)
        {
            {
                // testando a conexão com o BD
                try
                {

                    ConnectDAO connectDAO = new ConnectDAO();

                    if (connectDAO.TestarConexao())

                    {

                        MessageBox.Show("Conectado com o BD com sucesso!", "Iniciando a Conexão!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        if (connectDAO.FecharConexao())

                        {

                            MessageBox.Show("Conexão fechada com sucesso!", "Finalizando a Conexão!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }

                    }

                    else

                    {

                        MessageBox.Show("Falha na conexão com o BD!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }

                }
                catch
                {

                    MessageBox.Show("Falha no processo de conexão com o BD!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }

        private void LblNumeAge_Click(object sender, EventArgs e)
        {

        }

        private void TxBEndeAge_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxBNomeAge_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmAgencia_Load(object sender, EventArgs e)
        {

        }
    }
}
