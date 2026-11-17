using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_CONTA_CORRENTE.Model
{
    internal class ContaCorrente
    {
        private int Num_Age
        {
            get { return Num_Age; }
            set
            {
                if (Num_Age != value)
                {
                    Num_Age = value;
                }

            }
        }
        private int Num_CC
        {
            get { return Num_CC; }
            set
            {
                if (Num_CC != value)
                {
                    Num_CC = value;
                }

            }
        }
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
        private int SALDO
        {
            get { return SALDO; }
            set
            {
                if (SALDO != value)
                {
                    SALDO = value;
                }

            }
        }
   
    public ContaCorrente ()
        {

        }

        public ContaCorrente(int Num_Age, int Num_CC, int ID_Cli, int SALDO) : this()
        {
            this.Num_Age = Num_Age;
            this.Num_CC = Num_CC;
            this.ID_Cli = ID_Cli;
            this.SALDO = SALDO;
        }

             public String dadosSQLValues()
        {
            String dadosClientes;
            dadosClientes = "'"
                + this.Num_Age + "','"
                + this.Num_CC + "','"
                + this.ID_Cli + "','"
                + this.SALDO + "','";
                

            return dadosClientes;
        }

        public String alteraDadosSQLValues()
        {
            String dadosAgencia;
            dadosAgencia =
                "NUM_AGE='" + this.Num_Age + "',"
                + "NUM_CC='" + this.Num_CC + "',"
                + "ID_CLI='" + this.ID_Cli + "',"
                + "SALDO='" + this.SALDO + "',";
               
            return dadosAgencia;
        }

    }
}