using CRUD_CONTA_CORRENTE.DAO;
using Microsoft.Data.SqlClient;

namespace CRUD_CONTA_CORRENTE
{
    partial class FrmAgencia
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
            LblIDAge = new Label();
            LblNomeAge = new Label();
            LblNumAge = new Label();
            TxBIDAge = new TextBox();
            TxBNumAge = new TextBox();
            TxBNomeAge = new TextBox();
            TxBEndeAge = new TextBox();
            LblEndeAge = new Label();
            TxBCEPAge = new TextBox();
            LblCEPAge = new Label();
            TxBCidAge = new TextBox();
            LblCidAge = new Label();
            TxBUFAge = new TextBox();
            LblUFAge = new Label();
            TxBFoneAge = new TextBox();
            LblFoneAge = new Label();
            TxBBairAge = new TextBox();
            LblBairAge = new Label();
            TxBComplAge = new TextBox();
            LblComplAge = new Label();
            TxBNumeAge = new TextBox();
            LblNumeAge = new Label();
            BtnVisualizar = new Button();
            SuspendLayout();
            // 
            // LblIDAge
            // 
            LblIDAge.AutoSize = true;
            LblIDAge.Location = new Point(8, 12);
            LblIDAge.MinimumSize = new Size(10, 10);
            LblIDAge.Name = "LblIDAge";
            LblIDAge.Size = new Size(65, 15);
            LblIDAge.TabIndex = 0;
            LblIDAge.Text = "ID agência:";
            // 
            // LblNomeAge
            // 
            LblNomeAge.AutoSize = true;
            LblNomeAge.Location = new Point(8, 80);
            LblNomeAge.Name = "LblNomeAge";
            LblNomeAge.Size = new Size(103, 15);
            LblNomeAge.TabIndex = 1;
            LblNomeAge.Text = "Nome da agência:";
            // 
            // LblNumAge
            // 
            LblNumAge.AutoSize = true;
            LblNumAge.Location = new Point(8, 46);
            LblNumAge.Name = "LblNumAge";
            LblNumAge.Size = new Size(114, 15);
            LblNumAge.TabIndex = 2;
            LblNumAge.Text = "Número da agência:";
            // 
            // TxBIDAge
            // 
            TxBIDAge.Location = new Point(164, 9);
            TxBIDAge.Name = "TxBIDAge";
            TxBIDAge.Size = new Size(100, 23);
            TxBIDAge.TabIndex = 3;
            // 
            // TxBNumAge
            // 
            TxBNumAge.Location = new Point(164, 43);
            TxBNumAge.Name = "TxBNumAge";
            TxBNumAge.Size = new Size(136, 23);
            TxBNumAge.TabIndex = 4;
            // 
            // TxBNomeAge
            // 
            TxBNomeAge.Location = new Point(164, 77);
            TxBNomeAge.Name = "TxBNomeAge";
            TxBNomeAge.Size = new Size(158, 23);
            TxBNomeAge.TabIndex = 5;
            TxBNomeAge.TextChanged += TxBNomeAge_TextChanged;
            // 
            // TxBEndeAge
            // 
            TxBEndeAge.Location = new Point(164, 111);
            TxBEndeAge.Name = "TxBEndeAge";
            TxBEndeAge.Size = new Size(158, 23);
            TxBEndeAge.TabIndex = 7;
            TxBEndeAge.TextChanged += TxBEndeAge_TextChanged;
            // 
            // LblEndeAge
            // 
            LblEndeAge.AutoSize = true;
            LblEndeAge.Location = new Point(8, 114);
            LblEndeAge.Name = "LblEndeAge";
            LblEndeAge.Size = new Size(119, 15);
            LblEndeAge.TabIndex = 6;
            LblEndeAge.Text = "Endereço da agência:";
            // 
            // TxBCEPAge
            // 
            TxBCEPAge.Location = new Point(164, 145);
            TxBCEPAge.Name = "TxBCEPAge";
            TxBCEPAge.Size = new Size(100, 23);
            TxBCEPAge.TabIndex = 9;
            // 
            // LblCEPAge
            // 
            LblCEPAge.AutoSize = true;
            LblCEPAge.Location = new Point(8, 148);
            LblCEPAge.Name = "LblCEPAge";
            LblCEPAge.Size = new Size(91, 15);
            LblCEPAge.TabIndex = 8;
            LblCEPAge.Text = "CEP da agência:";
            // 
            // TxBCidAge
            // 
            TxBCidAge.Location = new Point(164, 179);
            TxBCidAge.Name = "TxBCidAge";
            TxBCidAge.Size = new Size(136, 23);
            TxBCidAge.TabIndex = 11;
            // 
            // LblCidAge
            // 
            LblCidAge.AutoSize = true;
            LblCidAge.Location = new Point(8, 182);
            LblCidAge.Name = "LblCidAge";
            LblCidAge.Size = new Size(107, 15);
            LblCidAge.TabIndex = 10;
            LblCidAge.Text = "Cidade da agência:";
            // 
            // TxBUFAge
            // 
            TxBUFAge.Location = new Point(164, 213);
            TxBUFAge.Name = "TxBUFAge";
            TxBUFAge.Size = new Size(62, 23);
            TxBUFAge.TabIndex = 13;
            // 
            // LblUFAge
            // 
            LblUFAge.AutoSize = true;
            LblUFAge.Location = new Point(8, 216);
            LblUFAge.Name = "LblUFAge";
            LblUFAge.Size = new Size(105, 15);
            LblUFAge.TabIndex = 12;
            LblUFAge.Text = "Estado da agência:";
            // 
            // TxBFoneAge
            // 
            TxBFoneAge.Location = new Point(164, 247);
            TxBFoneAge.Name = "TxBFoneAge";
            TxBFoneAge.Size = new Size(100, 23);
            TxBFoneAge.TabIndex = 15;
            // 
            // LblFoneAge
            // 
            LblFoneAge.AutoSize = true;
            LblFoneAge.Location = new Point(8, 250);
            LblFoneAge.Name = "LblFoneAge";
            LblFoneAge.Size = new Size(115, 15);
            LblFoneAge.TabIndex = 14;
            LblFoneAge.Text = "Telefone da agência:";
            // 
            // TxBBairAge
            // 
            TxBBairAge.Location = new Point(164, 281);
            TxBBairAge.Name = "TxBBairAge";
            TxBBairAge.Size = new Size(100, 23);
            TxBBairAge.TabIndex = 17;
            // 
            // LblBairAge
            // 
            LblBairAge.AutoSize = true;
            LblBairAge.Location = new Point(8, 284);
            LblBairAge.Name = "LblBairAge";
            LblBairAge.Size = new Size(101, 15);
            LblBairAge.TabIndex = 16;
            LblBairAge.Text = "Bairro da agência:";
            // 
            // TxBComplAge
            // 
            TxBComplAge.Location = new Point(164, 315);
            TxBComplAge.Name = "TxBComplAge";
            TxBComplAge.Size = new Size(158, 23);
            TxBComplAge.TabIndex = 19;
            // 
            // LblComplAge
            // 
            LblComplAge.AutoSize = true;
            LblComplAge.Location = new Point(8, 318);
            LblComplAge.Name = "LblComplAge";
            LblComplAge.Size = new Size(154, 15);
            LblComplAge.TabIndex = 18;
            LblComplAge.Text = "complemento do endereço:";
            // 
            // TxBNumeAge
            // 
            TxBNumeAge.Location = new Point(164, 353);
            TxBNumeAge.Name = "TxBNumeAge";
            TxBNumeAge.Size = new Size(62, 23);
            TxBNumeAge.TabIndex = 21;
            // 
            // LblNumeAge
            // 
            LblNumeAge.AutoSize = true;
            LblNumeAge.Location = new Point(8, 356);
            LblNumeAge.Name = "LblNumeAge";
            LblNumeAge.Size = new Size(114, 15);
            LblNumeAge.TabIndex = 20;
            LblNumeAge.Text = "Número da agência:";
            LblNumeAge.Click += LblNumeAge_Click;
            // 
            // BtnVisualizar
            // 
            BtnVisualizar.Location = new Point(8, 397);
            BtnVisualizar.Name = "BtnVisualizar";
            BtnVisualizar.Size = new Size(119, 51);
            BtnVisualizar.TabIndex = 22;
            BtnVisualizar.Text = "Visualizar dados digitados";
            BtnVisualizar.UseVisualStyleBackColor = true;
            BtnVisualizar.Click += BtnVisualizar_Click;
            // 
            // FrmAgencia
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1110, 653);
            Controls.Add(BtnVisualizar);
            Controls.Add(TxBNumeAge);
            Controls.Add(LblNumeAge);
            Controls.Add(TxBComplAge);
            Controls.Add(LblComplAge);
            Controls.Add(TxBBairAge);
            Controls.Add(LblBairAge);
            Controls.Add(TxBFoneAge);
            Controls.Add(LblFoneAge);
            Controls.Add(TxBUFAge);
            Controls.Add(LblUFAge);
            Controls.Add(TxBCidAge);
            Controls.Add(LblCidAge);
            Controls.Add(TxBCEPAge);
            Controls.Add(LblCEPAge);
            Controls.Add(TxBEndeAge);
            Controls.Add(LblEndeAge);
            Controls.Add(TxBNomeAge);
            Controls.Add(TxBNumAge);
            Controls.Add(TxBIDAge);
            Controls.Add(LblNumAge);
            Controls.Add(LblNomeAge);
            Controls.Add(LblIDAge);
            Name = "FrmAgencia";
            Text = "Cadastro de agencias";
            Load += FrmAgencia_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LblIDAge;
        private Label LblNomeAge;
        private Label LblNumAge;
        private TextBox TxBIDAge;
        private TextBox TxBNumAge;
        private TextBox TxBNomeAge;
        private TextBox TxBEndeAge;
        private Label LblEndeAge;
        private TextBox TxBCEPAge;
        private Label LblCEPAge;
        private TextBox TxBCidAge;
        private Label LblCidAge;
        private TextBox TxBUFAge;
        private Label LblUFAge;
        private TextBox TxBFoneAge;
        private Label LblFoneAge;
        private TextBox TxBBairAge;
        private Label LblBairAge;
        private TextBox TxBComplAge;
        private Label LblComplAge;
        private TextBox TxBNumeAge;
        private Label LblNumeAge;
        private Button BtnVisualizar;
        
    }
}