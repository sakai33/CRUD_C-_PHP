namespace CRUD_CONTA_CORRENTE
{
    partial class FrmHistorico
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
            LblIDHist = new Label();
            LblDesHist = new Label();
            TxBIDHist = new TextBox();
            TxBDesHist = new TextBox();
            SuspendLayout();
            // 
            // LblIDHist
            // 
            LblIDHist.AutoSize = true;
            LblIDHist.Location = new Point(8, 12);
            LblIDHist.MinimumSize = new Size(10, 10);
            LblIDHist.Name = "LblIDHist";
            LblIDHist.Size = new Size(72, 15);
            LblIDHist.TabIndex = 0;
            LblIDHist.Text = "ID Historico:";
            // 
            // LblDesHist
            // 
            LblDesHist.AutoSize = true;
            LblDesHist.Location = new Point(8, 46);
            LblDesHist.Name = "LblDesHist";
            LblDesHist.Size = new Size(127, 15);
            LblDesHist.TabIndex = 2;
            LblDesHist.Text = "Descrição do historico:";
            // 
            // TxBIDHist
            // 
            TxBIDHist.Location = new Point(164, 9);
            TxBIDHist.Name = "TxBIDHist";
            TxBIDHist.Size = new Size(100, 23);
            TxBIDHist.TabIndex = 3;
            // 
            // TxBDesHist
            // 
            TxBDesHist.Location = new Point(164, 43);
            TxBDesHist.Name = "TxBDesHist";
            TxBDesHist.Size = new Size(136, 23);
            TxBDesHist.TabIndex = 4;
            // 
            // FrmHistorico
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1110, 653);
            Controls.Add(TxBDesHist);
            Controls.Add(TxBIDHist);
            Controls.Add(LblDesHist);
            Controls.Add(LblIDHist);
            Name = "FrmHistorico";
            Text = "Cadastro de Historicos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LblIDHist;
        private Label LblDesHist;
        private TextBox TxBIDHist;
        private TextBox TxBDesHist;
    }
}