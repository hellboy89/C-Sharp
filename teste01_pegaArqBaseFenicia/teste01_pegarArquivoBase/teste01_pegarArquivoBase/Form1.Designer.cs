namespace teste01_pegarArquivoBase
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            comboBox_listaBases = new ComboBox();
            statusStrip_dados = new StatusStrip();
            toolStripStatusLabel_dados = new ToolStripStatusLabel();
            listBox_listarDiretorio = new ListBox();
            button_voltar = new Button();
            button_mostraGlobal = new Button();
            button_fileDialog = new Button();
            openFileDialog1 = new OpenFileDialog();
            statusStrip_dados.SuspendLayout();
            SuspendLayout();
            // 
            // comboBox_listaBases
            // 
            comboBox_listaBases.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox_listaBases.FormattingEnabled = true;
            comboBox_listaBases.Location = new Point(110, 41);
            comboBox_listaBases.Name = "comboBox_listaBases";
            comboBox_listaBases.Size = new Size(279, 28);
            comboBox_listaBases.TabIndex = 0;
            comboBox_listaBases.SelectedValueChanged += comboBox_listaBases_SelectedValueChanged;
            // 
            // statusStrip_dados
            // 
            statusStrip_dados.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            statusStrip_dados.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel_dados });
            statusStrip_dados.Location = new Point(0, 420);
            statusStrip_dados.Name = "statusStrip_dados";
            statusStrip_dados.Size = new Size(782, 22);
            statusStrip_dados.TabIndex = 1;
            // 
            // toolStripStatusLabel_dados
            // 
            toolStripStatusLabel_dados.Name = "toolStripStatusLabel_dados";
            toolStripStatusLabel_dados.Size = new Size(0, 17);
            // 
            // listBox_listarDiretorio
            // 
            listBox_listarDiretorio.FormattingEnabled = true;
            listBox_listarDiretorio.ItemHeight = 15;
            listBox_listarDiretorio.Location = new Point(110, 88);
            listBox_listarDiretorio.Name = "listBox_listarDiretorio";
            listBox_listarDiretorio.Size = new Size(279, 244);
            listBox_listarDiretorio.TabIndex = 2;
            listBox_listarDiretorio.DoubleClick += listBox_listarDiretorio_DoubleClick;
            // 
            // button_voltar
            // 
            button_voltar.Location = new Point(406, 88);
            button_voltar.Name = "button_voltar";
            button_voltar.Size = new Size(75, 23);
            button_voltar.TabIndex = 3;
            button_voltar.Text = "VOLTAR";
            button_voltar.UseVisualStyleBackColor = true;
            button_voltar.Click += button_voltar_Click;
            // 
            // button_mostraGlobal
            // 
            button_mostraGlobal.Location = new Point(12, 382);
            button_mostraGlobal.Name = "button_mostraGlobal";
            button_mostraGlobal.Size = new Size(152, 23);
            button_mostraGlobal.TabIndex = 4;
            button_mostraGlobal.Text = "MOSTRAR GLOBAL";
            button_mostraGlobal.UseVisualStyleBackColor = true;
            button_mostraGlobal.Click += button_mostraGlobal_Click;
            // 
            // button_fileDialog
            // 
            button_fileDialog.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button_fileDialog.Location = new Point(474, 202);
            button_fileDialog.Name = "button_fileDialog";
            button_fileDialog.Size = new Size(157, 47);
            button_fileDialog.TabIndex = 5;
            button_fileDialog.Text = "Abrir Pastas";
            button_fileDialog.UseVisualStyleBackColor = true;
            button_fileDialog.Click += button_fileDialog_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            openFileDialog1.FileOk += openFileDialog1_FileOk;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(782, 442);
            Controls.Add(button_fileDialog);
            Controls.Add(button_mostraGlobal);
            Controls.Add(button_voltar);
            Controls.Add(listBox_listarDiretorio);
            Controls.Add(statusStrip_dados);
            Controls.Add(comboBox_listaBases);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Form1";
            statusStrip_dados.ResumeLayout(false);
            statusStrip_dados.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox_listaBases;
        private StatusStrip statusStrip_dados;
        private ToolStripStatusLabel toolStripStatusLabel_dados;
        private ListBox listBox_listarDiretorio;
        private Button button_voltar;
        private Button button_mostraGlobal;
        private Button button_fileDialog;
        private OpenFileDialog openFileDialog1;
    }
}