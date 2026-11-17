namespace CRUD_CONTA_CORRENTE
{
    partial class FrmContaCorrente
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

        private void InitializeComponent()
        {
            LblNumAge = new Label();
            LblNumCC = new Label();
            LblIDCli = new Label();
            LblSaldo = new Label();
            TxBNumAge = new TextBox();
            TxBNumCC = new TextBox();
            TxBIDCli = new TextBox();
            TxBSaldo = new TextBox();
            SuspendLayout();
            // 
            // LblNumAge
            // 
            LblNumAge.AutoSize = true;
            LblNumAge.Location = new Point(8, 20);
            LblNumAge.Name = "LblNumAge";
            LblNumAge.Size = new Size(114, 15);
            LblNumAge.TabIndex = 0;
            LblNumAge.Text = "Número da agência:";
            // 
            // LblNumCC
            // 
            LblNumCC.AutoSize = true;
            LblNumCC.Location = new Point(8, 54);
            LblNumCC.Name = "LblNumCC";
            LblNumCC.Size = new Size(103, 15);
            LblNumCC.TabIndex = 2;
            LblNumCC.Text = "Número da conta:";
            // 
            // LblIDCli
            // 
            LblIDCli.AutoSize = true;
            LblIDCli.Location = new Point(8, 88);
            LblIDCli.Name = "LblIDCli";
            LblIDCli.Size = new Size(76, 15);
            LblIDCli.TabIndex = 4;
            LblIDCli.Text = "ID do cliente:";
            // 
            // LblSaldo
            // 
            LblSaldo.AutoSize = true;
            LblSaldo.Location = new Point(8, 122);
            LblSaldo.Name = "LblSaldo";
            LblSaldo.Size = new Size(39, 15);
            LblSaldo.TabIndex = 6;
            LblSaldo.Text = "Saldo:";
            // 
            // TxBNumAge
            // 
            TxBNumAge.Location = new Point(164, 17);
            TxBNumAge.Name = "TxBNumAge";
            TxBNumAge.Size = new Size(100, 23);
            TxBNumAge.TabIndex = 1;
            // 
            // TxBNumCC
            // 
            TxBNumCC.Location = new Point(164, 51);
            TxBNumCC.Name = "TxBNumCC";
            TxBNumCC.Size = new Size(120, 23);
            TxBNumCC.TabIndex = 3;
            // 
            // TxBIDCli
            // 
            TxBIDCli.Location = new Point(164, 85);
            TxBIDCli.Name = "TxBIDCli";
            TxBIDCli.Size = new Size(100, 23);
            TxBIDCli.TabIndex = 5;
            // 
            // TxBSaldo
            // 
            TxBSaldo.Location = new Point(164, 119);
            TxBSaldo.Name = "TxBSaldo";
            TxBSaldo.Size = new Size(120, 23);
            TxBSaldo.TabIndex = 7;
            // 
            // FrmContaCorrente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(926, 427);
            Controls.Add(TxBSaldo);
            Controls.Add(LblSaldo);
            Controls.Add(TxBIDCli);
            Controls.Add(LblIDCli);
            Controls.Add(TxBNumCC);
            Controls.Add(LblNumCC);
            Controls.Add(TxBNumAge);
            Controls.Add(LblNumAge);
            Name = "FrmContaCorrente";
            Text = "Cadastro de Conta Corrente";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LblNumAge;
        private Label LblNumCC;
        private Label LblIDCli;
        private Label LblSaldo;

        private TextBox TxBNumAge;
        private TextBox TxBNumCC;
        private TextBox TxBIDCli;
        private TextBox TxBSaldo;
    }
}