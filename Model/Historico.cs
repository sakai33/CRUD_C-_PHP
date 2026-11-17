using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_CONTA_CORRENTE.Model
{
    internal class Historico
    {
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
        private string Des_His
        {
            get { return Des_His; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    Des_His = value;
                }
            }
        }
   
    public Historico ()
        {

        }


        public Historico(int ID_His, string Des_His) : this()
        {
            this.ID_His = ID_His;
            this.Des_His = Des_His;

        }
        public String dadosSQLValues()
        {
            String dadosClientes;
            dadosClientes = "'"
                + this.ID_His + "','"
                + this.Des_His + "','";
               

            return dadosClientes;
        }

        public String alteraDadosSQLValues()
        {
            String dadosHistorico;
            dadosHistorico =
                "ID_HIS='" + this.ID_His + "',"
                + "DES_HIS='" + this.Des_His + "',";
                
            return dadosHistorico;
        }

    }
}