using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_CONTA_CORRENTE.Model
{
    internal class Usuario
    {
       private int ID
        {
            get { return ID; }
            set
            {
                if (ID != value)
                {
                    ID = value;
                }

            }
        }
        private int SENHA
        {
            get { return SENHA; }
            set
            {
                if (SENHA != value)
                {
                    SENHA = value;
                }

            }
        }
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
      public Usuario()
        {

        }

        public Usuario(int ID, int SENHA, int Num_Age, int Num_CC) : this()
        {
            this.ID = ID;  
            this.SENHA = SENHA;
            this.Num_Age = Num_Age;
            this.Num_CC = Num_CC;
        }
        public String dadosSQLValues()
        {
            String dadosClientes;
            dadosClientes = "'"
                + this.ID + "','"
                + this.SENHA + "','"
                + this.Num_CC + "','"
                + this.Num_Age + "','";
               

            return dadosClientes;
        }

        public String alteraDadosSQLValues()
        {
            String dadosUsuario;
            dadosUsuario =
                 "ID='" + this.ID + "',"
                + "SENHA='" + this.SENHA + "',"
                + "NUM_AGE='" + this.Num_Age + "',"
                + "NUM_CC='" + this.Num_CC + "',";
               
            return dadosUsuario;
        }

    }
}
