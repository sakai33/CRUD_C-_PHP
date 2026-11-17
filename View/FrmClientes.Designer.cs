using System.Windows.Forms;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace CRUD_CONTA_CORRENTE
{
    partial class FrmClientes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            LblIDCli = new Label();
            LblNomeCli = new Label();
            LblCPFCli = new Label();
            TxBIDCli = new TextBox();
            TxBNomeCli = new TextBox();
            TxBCPFCli = new TextBox();
            TxBEndeCli = new TextBox();
            LblEndeCli = new Label();
            TxBCEPCli = new TextBox();
            LblCEPCli = new Label();
            TxBCidCli = new TextBox();
            LblCidCli = new Label();
            TxBUFcli = new TextBox();
            LblUFcli = new Label();
            TxBFoneCli = new TextBox();
            LblFoneCli = new Label();
            TxBBairCli = new TextBox();
            LblBairCli = new Label();
            TxBComplCli = new TextBox();
            LblComplCli = new Label();
            TxBCNPJCli = new TextBox();
            LblCNPJCli = new Label();
            TxBDataNascCli = new TextBox();
            LblDataNascCli = new Label();
            SuspendLayout();
            // 
            // LblIDCli
            // 
            LblIDCli.AutoSize = true;
            LblIDCli.Location = new Point(8, 12);
            LblIDCli.MinimumSize = new Size(10, 10);
            LblIDCli.Name = "LblIDCli";
            LblIDCli.Size = new Size(59, 15);
            LblIDCli.TabIndex = 0;
            LblIDCli.Text = "ID cliente:";
            // 
            // LblNomeCli
            // 
            LblNomeCli.AutoSize = true;
            LblNomeCli.Location = new Point(8, 80);
            LblNomeCli.Name = "LblNomeCli";
            LblNomeCli.Size = new Size(98, 15);
            LblNomeCli.TabIndex = 1;
            LblNomeCli.Text = "Nome do cliente:";
            // 
            // LblCPFCli
            // 
            LblCPFCli.AutoSize = true;
            LblCPFCli.Location = new Point(8, 46);
            LblCPFCli.Name = "LblCPFCli";
            LblCPFCli.Size = new Size(86, 15);
            LblCPFCli.TabIndex = 2;
            LblCPFCli.Text = "CPF do cliente:";
            // 
            // TxBIDCli
            // 
            TxBIDCli.Location = new Point(199, 4);
            TxBIDCli.Name = "TxBIDCli";
            TxBIDCli.Size = new Size(100, 23);
            TxBIDCli.TabIndex = 3;
            // 
            // TxBNomeCli
            // 
            TxBNomeCli.Location = new Point(199, 72);
            TxBNomeCli.Name = "TxBNomeCli";
            TxBNomeCli.Size = new Size(200, 23);
            TxBNomeCli.TabIndex = 5;
            // 
            // TxBCPFCli
            // 
            TxBCPFCli.Location = new Point(199, 38);
            TxBCPFCli.Name = "TxBCPFCli";
            TxBCPFCli.Size = new Size(100, 23);
            TxBCPFCli.TabIndex = 4;
            // 
            // TxBEndeCli
            // 
            TxBEndeCli.Location = new Point(199, 106);
            TxBEndeCli.Name = "TxBEndeCli";
            TxBEndeCli.Size = new Size(200, 23);
            TxBEndeCli.TabIndex = 7;
            // 
            // LblEndeCli
            // 
            LblEndeCli.AutoSize = true;
            LblEndeCli.Location = new Point(8, 114);
            LblEndeCli.Name = "LblEndeCli";
            LblEndeCli.Size = new Size(114, 15);
            LblEndeCli.TabIndex = 6;
            LblEndeCli.Text = "Endereço do cliente:";
            // 
            // TxBCEPCli
            // 
            TxBCEPCli.Location = new Point(199, 140);
            TxBCEPCli.Name = "TxBCEPCli";
            TxBCEPCli.Size = new Size(100, 23);
            TxBCEPCli.TabIndex = 9;
            // 
            // LblCEPCli
            // 
            LblCEPCli.AutoSize = true;
            LblCEPCli.Location = new Point(8, 148);
            LblCEPCli.Name = "LblCEPCli";
            LblCEPCli.Size = new Size(86, 15);
            LblCEPCli.TabIndex = 8;
            LblCEPCli.Text = "CEP do cliente:";
            // 
            // TxBCidCli
            // 
            TxBCidCli.Location = new Point(199, 174);
            TxBCidCli.Name = "TxBCidCli";
            TxBCidCli.Size = new Size(150, 23);
            TxBCidCli.TabIndex = 11;
            // 
            // LblCidCli
            // 
            LblCidCli.AutoSize = true;
            LblCidCli.Location = new Point(8, 182);
            LblCidCli.Name = "LblCidCli";
            LblCidCli.Size = new Size(102, 15);
            LblCidCli.TabIndex = 10;
            LblCidCli.Text = "Cidade do cliente:";
            // 
            // TxBUFcli
            // 
            TxBUFcli.Location = new Point(199, 208);
            TxBUFcli.Name = "TxBUFcli";
            TxBUFcli.Size = new Size(50, 23);
            TxBUFcli.TabIndex = 13;
            // 
            // LblUFcli
            // 
            LblUFcli.AutoSize = true;
            LblUFcli.Location = new Point(8, 216);
            LblUFcli.Name = "LblUFcli";
            LblUFcli.Size = new Size(100, 15);
            LblUFcli.TabIndex = 12;
            LblUFcli.Text = "Estado do cliente:";
            // 
            // TxBFoneCli
            // 
            TxBFoneCli.Location = new Point(199, 242);
            TxBFoneCli.Name = "TxBFoneCli";
            TxBFoneCli.Size = new Size(120, 23);
            TxBFoneCli.TabIndex = 15;
            // 
            // LblFoneCli
            // 
            LblFoneCli.AutoSize = true;
            LblFoneCli.Location = new Point(8, 250);
            LblFoneCli.Name = "LblFoneCli";
            LblFoneCli.Size = new Size(109, 15);
            LblFoneCli.TabIndex = 14;
            LblFoneCli.Text = "Telefone do cliente:";
            // 
            // TxBBairCli
            // 
            TxBBairCli.Location = new Point(199, 276);
            TxBBairCli.Name = "TxBBairCli";
            TxBBairCli.Size = new Size(150, 23);
            TxBBairCli.TabIndex = 17;
            // 
            // LblBairCli
            // 
            LblBairCli.AutoSize = true;
            LblBairCli.Location = new Point(8, 284);
            LblBairCli.Name = "LblBairCli";
            LblBairCli.Size = new Size(96, 15);
            LblBairCli.TabIndex = 16;
            LblBairCli.Text = "Bairro do cliente:";
            // 
            // TxBComplCli
            // 
            TxBComplCli.Location = new Point(199, 310);
            TxBComplCli.Name = "TxBComplCli";
            TxBComplCli.Size = new Size(200, 23);
            TxBComplCli.TabIndex = 19;
            // 
            // LblComplCli
            // 
            LblComplCli.AutoSize = true;
            LblComplCli.Location = new Point(8, 318);
            LblComplCli.Name = "LblComplCli";
            LblComplCli.Size = new Size(156, 15);
            LblComplCli.TabIndex = 18;
            LblComplCli.Text = "Complemento do endereço:";
            // 
            // TxBCNPJCli
            // 
            TxBCNPJCli.Location = new Point(199, 339);
            TxBCNPJCli.Name = "TxBCNPJCli";
            TxBCNPJCli.Size = new Size(100, 23);
            TxBCNPJCli.TabIndex = 21;
            // 
            // LblCNPJCli
            // 
            LblCNPJCli.AutoSize = true;
            LblCNPJCli.Location = new Point(8, 347);
            LblCNPJCli.Name = "LblCNPJCli";
            LblCNPJCli.Size = new Size(92, 15);
            LblCNPJCli.TabIndex = 20;
            LblCNPJCli.Text = "CNPJ do cliente:";
            // 
            // TxBDataNascCli
            // 
            TxBDataNascCli.Location = new Point(199, 377);
            TxBDataNascCli.Name = "TxBDataNascCli";
            TxBDataNascCli.Size = new Size(100, 23);
            TxBDataNascCli.TabIndex = 23;
            TxBDataNascCli.TextChanged += TxBDataNascCli_TextChanged;
            // 
            // LblDataNascCli
            // 
            LblDataNascCli.AutoSize = true;
            LblDataNascCli.Location = new Point(8, 380);
            LblDataNascCli.Name = "LblDataNascCli";
            LblDataNascCli.Size = new Size(170, 15);
            LblDataNascCli.TabIndex = 22;
            LblDataNascCli.Text = "Data de nascimento do cliente:";
            // 
            // FrmClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1110, 653);
            Controls.Add(TxBDataNascCli);
            Controls.Add(LblDataNascCli);
            Controls.Add(TxBCNPJCli);
            Controls.Add(LblCNPJCli);
            Controls.Add(TxBComplCli);
            Controls.Add(LblComplCli);
            Controls.Add(TxBBairCli);
            Controls.Add(LblBairCli);
            Controls.Add(TxBFoneCli);
            Controls.Add(LblFoneCli);
            Controls.Add(TxBUFcli);
            Controls.Add(LblUFcli);
            Controls.Add(TxBCidCli);
            Controls.Add(LblCidCli);
            Controls.Add(TxBCEPCli);
            Controls.Add(LblCEPCli);
            Controls.Add(TxBEndeCli);
            Controls.Add(LblEndeCli);
            Controls.Add(TxBNomeCli);
            Controls.Add(TxBCPFCli);
            Controls.Add(TxBIDCli);
            Controls.Add(LblCPFCli);
            Controls.Add(LblNomeCli);
            Controls.Add(LblIDCli);
            Name = "FrmClientes";
            Text = "Cadastro de clientes";
            Load += FrmClientes_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LblIDCli;
        private Label LblNomeCli;
        private Label LblCPFCli;

        private TextBox TxBIDCli;
        private TextBox TxBCPFCli;
        private TextBox TxBNomeCli;
        private TextBox TxBEndeCli;
        private Label LblEndeCli;
        private TextBox TxBCEPCli;
        private Label LblCEPCli;
        private TextBox TxBCidCli;
        private Label LblCidCli;
        private TextBox TxBUFcli;
        private Label LblUFcli;
        private TextBox TxBFoneCli;
        private Label LblFoneCli;
        private TextBox TxBBairCli;
        private Label LblBairCli;
        private TextBox TxBComplCli;
        private Label LblComplCli;
        private TextBox TxBCNPJCli;
        private Label LblCNPJCli;
        private TextBox TxBDataNascCli;
        private Label LblDataNascCli;
    }
}