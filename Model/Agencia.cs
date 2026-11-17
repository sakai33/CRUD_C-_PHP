using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_CONTA_CORRENTE.Model
{
    internal class Agencia
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
        private string Nome_Age
        {
            get { return Nome_Age; }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    Nome_Age = value;
                }
            }
        }
        private string Ende_Age
        {
            get { return Ende_Age; }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    Ende_Age = value;
                }
            }
        }
        private string Nume_Age
        {
            get { return Nume_Age; }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    Nume_Age = value;
                }
            }
        }
        private string Compl_Age
        {
            get { return Compl_Age; }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    Compl_Age = value;
                }
            }
        }
        private string Bair_Age
        {
            get { return Bair_Age; }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    Bair_Age = value;
                }
            }
        }
        private string Cida_Age
        {
            get { return Cida_Age; }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    Cida_Age = value;
                }
            }
        }
        private string UF_Age
        {
            get { return UF_Age; }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    UF_Age = value;
                }
            }
        }
        private string CEP_Age
        {
            get { return CEP_Age; }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    CEP_Age = value;
                }
            }
        }
        private string Fone_Age
        {
            get { return Fone_Age; }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    Fone_Age = value;
                }
            }
        }


        public Agencia()
        {

        }
        public Agencia(int Num_Age, string Nome_Age, string Ende_Age, string Nume_Age, string Compl_Age, string Bair_Age, string Cida_Age,
    string UF_Age, string CEP_Age, string Fone_Age) : this()
        {
            this.Num_Age = Num_Age;
            this.Nome_Age = Nome_Age;
            this.Ende_Age = Ende_Age;
            this.Nume_Age = Nume_Age;
            this.Compl_Age = Compl_Age;
            this.Bair_Age = Bair_Age;
            this.Cida_Age = Cida_Age;
            this.UF_Age = UF_Age;
            this.CEP_Age = CEP_Age;
            this.Fone_Age = Fone_Age;
        }

        public String dadosSQLValues()
        {
            String dadosClientes;
            dadosClientes =
                this.Num_Age + "','"
                + this.Nome_Age + "','"
                + this.Ende_Age + "','"
                + this.Nume_Age + "','"
                + this.Compl_Age + "','"
                + this.Bair_Age + "','"
                + this.Cida_Age + "','"
                + this.UF_Age + "','"
                + this.CEP_Age + "','"
                + this.Fone_Age + "'";
            return dadosClientes;
        }
    }
}