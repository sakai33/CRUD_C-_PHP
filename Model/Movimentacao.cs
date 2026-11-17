using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_CONTA_CORRENTE.Model
{
    internal class Movimentacao
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

        private int Data_Mov
        {
            get { return Data_Mov; }
            set
            {
                if (Data_Mov != value)
                {
                    Data_Mov = value;
                }

            }
        }

        private string Num_Docto
        {
            get { return Num_Docto; }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    Num_Docto = value;
                }
            }
        }

        private string Debito_Credito
        {
            get { return Debito_Credito; }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    Debito_Credito = value;
                }
            }
        }

        private int ID_His
        {
            get { return ID_His; }
            set
            {
                if (ID_His != value)
                {
                    ID_His = value;
                }

            }
        }

        private string Compl_His
        {
            get { return Compl_His; }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    Compl_His = value;
                }
            }
        }

        private int Valor
        {
            get { return Valor; }
            set
            {
                if (Valor != value)
                {
                    Valor = value;
                }

            }
        }

        private int Saldo
        {
            get { return Saldo; }
            set
            {
                if (Saldo != value)
                {
                    Saldo = value;
                }

            }
        }

        private Movimentacao(int num_Age, int num_CC, int data_Mov, string num_Docto, string debito_Credito, int iD_His,
            string compl_His, int valor, int saldo)
        {
            Num_Age = num_Age;
            Num_CC = num_CC;
            Data_Mov = data_Mov;
            Num_Docto = num_Docto;
            Debito_Credito = debito_Credito;
            ID_His = iD_His;
            Compl_His = compl_His;
            Valor = valor;
            Saldo = saldo;
        }
    
        public String dadosSQLValues()
            {
                String dadosClientes;
                dadosClientes = "'"
                    + this.Num_Age + "','"
                    + this.Num_CC + "','"
                    + this.Data_Mov + "','"
                    + this.Num_Docto + "','"
                    + this.Debito_Credito + "','"
                    + this.ID_His + "','"
                    + this.Compl_His + "','"
                    + this.Valor + "','"
                    + this.Saldo + "','";
               

                return dadosClientes;
            }

        public String alteraDadosSQLValues()
        {
            String dadosMovimentacao;
            dadosMovimentacao = 
                "NUM_AGE='" + this.Num_Age + "',"
                + "NUM_CC='" + this.Num_CC + "',"
                + "DATA_MOV='" + this.Data_Mov + "',"
                + "NUM_DOCTO='" + this.Num_Docto + "',"
                + "DEBITO_CREDITO='" + this.Debito_Credito + "',"
                + "ID_HIS='" + this.ID_His + "',"
                + "COMPL_HIS='" + this.Compl_His + "',"
                + "VALOR='" + this.Valor + "',"
                + "SALDO='" + this.Saldo + "',";
           
            return dadosMovimentacao;
        }

    }
}

