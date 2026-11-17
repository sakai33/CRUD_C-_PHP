using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_CONTA_CORRENTE.Model
{
    internal class Cliente
    {
        private int ID_Cli
        {
            get { return ID_Cli; }
            set
            {
                if (ID_Cli != value)
                {
                    ID_Cli = value;
                }

            }
        }
        private string Nome_Cli
        {
            get { return Nome_Cli; }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    Nome_Cli = value;
                }
            }
        }
        private string Ende_Cli
        {
            get { return Ende_Cli; }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    Ende_Cli = value;
                }
            }
        }
        private string Nume_Cli
        {
            get { return Nume_Cli; }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    Nume_Cli = value;
                }
            }
        }
        private string Compl_Cli
        {
            get { return Compl_Cli; }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    Compl_Cli = value;
                }
            }
        }
        private string Bair_Cli
        {
            get { return Bair_Cli; }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    Bair_Cli = value;
                }
            }
        }
        private string Cida_Cli
        {
            get { return Cida_Cli; }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    Cida_Cli = value;
                }
            }
        }
        private string UF_Cli
        {
            get { return UF_Cli; }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    UF_Cli = value;
                }
            }
        }
        private string CEP_Cli
        {
            get { return CEP_Cli; }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    CEP_Cli = value;
                }
            }
        }
        private string Fone_Cli
        {
            get { return Fone_Cli; }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    Fone_Cli = value;
                }
            }
        }
        private string CPF_Cli
        {
            get { return CPF_Cli; }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    CPF_Cli = value;
                }
            }
        }
        private string Data_Nasc
        {
            get { return Data_Nasc; }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    Data_Nasc = value;
                }
            }
        }
        private string Cnpj_Cli
        {
            get { return Cnpj_Cli; }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    Cnpj_Cli = value;
                }
            }
        }


        public Cliente()
        {

        }
        public Cliente(int ID_Cli, string Nome_Cli, string Ende_Cli, string Nume_Cli, string Compl_Cli, string Bair_Cli, string Cida_Cli,
    string UF_Cli, string CEP_Cli, string Fone_Cli, string CPF_Cli, string Data_Nasc, string Cnpj_Cli) : this()
        {
            this.ID_Cli = ID_Cli;
            this.Nome_Cli = Nome_Cli;
            this.Ende_Cli = Ende_Cli;
            this.Nume_Cli = Nume_Cli;
            this.Compl_Cli = Compl_Cli;
            this.Bair_Cli = Bair_Cli;
            this.Cida_Cli = Cida_Cli;
            this.UF_Cli = UF_Cli;
            this.CEP_Cli = CEP_Cli;
            this.Fone_Cli = Fone_Cli;
            this.CPF_Cli = CPF_Cli;
            this.Data_Nasc = Data_Nasc;
            this.Cnpj_Cli = Cnpj_Cli;
        }

        public String dadosSQLValues()
        {
            String dadosClientes;
            dadosClientes = "'"
                + this.ID_Cli + "','"
                + this.Nome_Cli + "','"
                + this.Ende_Cli + "','"
                + this.Nume_Cli + "','"
                + this.Compl_Cli + "','"
                + this.Bair_Cli + "','"
                + this.Cida_Cli + "','"
                + this.UF_Cli + "','"
                + this.CEP_Cli + "','"
                + this.Fone_Cli + "'"
                +this.Cnpj_Cli + "'";
        
            return dadosClientes;
        }

        public String alteraDadosSQLValues()
        {
            String dadosClientes;
            dadosClientes = "NUM_CLI='" + this.ID_Cli + "',"
                + "NOME_CLI='" + this.Nome_Cli + "',"
                + "ENDE_CLI='" + this.Ende_Cli + "',"
                + "NUME_CLI='" + this.Nume_Cli + "',"
                + "COMPL_CLI='" + this.Compl_Cli + "',"
                + "BAIR_CLI='" + this.Bair_Cli + "',"
                + "CIDA_CLI='" + this.Cida_Cli + "',"
                + "UF_CLI='" + this.UF_Cli + "',"
                + "CEP_CLI='" + this.CEP_Cli + "',"
                + "FONE_CLI='" + this.Fone_Cli + "',"
                +"CNPJ_CLI='" + this.Cnpj_Cli + "',";
            return dadosClientes;
        }

    }
}
