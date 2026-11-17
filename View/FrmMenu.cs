namespace CRUD_CONTA_CORRENTE
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void cCONTACORRENTEToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void uSUSARIOSToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripContainer1_TopToolStripPanel_Click(object sender, EventArgs e)
        {

        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void iNCLUSÃOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAgencia FormularioAgencias = new FrmAgencia();
            FormularioAgencias.Show();
        }

        private void iNCLUSÃOToolStripMenuItem1_Click_2(object sender, EventArgs e)
        {
            FrmClientes FormularioClientes = new FrmClientes();
            FormularioClientes.Show();
        }

        private void iNCLUSÃOToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FrmHistorico FormularioHistorico = new FrmHistorico();
            FormularioHistorico.Show();
        }

        private void iNCLUSÃOToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            FrmContaCorrente FormularioContaCorrente = new FrmContaCorrente();
            FormularioContaCorrente.Show();
        }
    }
}
