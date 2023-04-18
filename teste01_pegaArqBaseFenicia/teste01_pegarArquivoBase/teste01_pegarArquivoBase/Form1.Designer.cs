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
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            treeView_diretorios = new TreeView();
            button1 = new Button();
            textBox_linkGdrive = new TextBox();
            button_download2 = new Button();
            button_copiarLink = new Button();
            statusStrip_dados.SuspendLayout();
            SuspendLayout();
            // 
            // comboBox_listaBases
            // 
            comboBox_listaBases.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox_listaBases.FormattingEnabled = true;
            comboBox_listaBases.Location = new Point(94, 29);
            comboBox_listaBases.Name = "comboBox_listaBases";
            comboBox_listaBases.Size = new Size(251, 28);
            comboBox_listaBases.TabIndex = 0;
            // 
            // statusStrip_dados
            // 
            statusStrip_dados.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            statusStrip_dados.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel_dados, toolStripStatusLabel1 });
            statusStrip_dados.Location = new Point(0, 417);
            statusStrip_dados.Name = "statusStrip_dados";
            statusStrip_dados.Size = new Size(782, 25);
            statusStrip_dados.TabIndex = 1;
            // 
            // toolStripStatusLabel_dados
            // 
            toolStripStatusLabel_dados.Name = "toolStripStatusLabel_dados";
            toolStripStatusLabel_dados.Size = new Size(0, 20);
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(160, 20);
            toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // treeView_diretorios
            // 
            treeView_diretorios.Location = new Point(94, 80);
            treeView_diretorios.Name = "treeView_diretorios";
            treeView_diretorios.Size = new Size(352, 244);
            treeView_diretorios.TabIndex = 6;
            treeView_diretorios.DoubleClick += treeView_diretorios_DoubleClick;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(371, 29);
            button1.Name = "button1";
            button1.Size = new Size(75, 28);
            button1.TabIndex = 7;
            button1.Text = "Listar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox_linkGdrive
            // 
            textBox_linkGdrive.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_linkGdrive.Location = new Point(245, 348);
            textBox_linkGdrive.Name = "textBox_linkGdrive";
            textBox_linkGdrive.ReadOnly = true;
            textBox_linkGdrive.Size = new Size(301, 25);
            textBox_linkGdrive.TabIndex = 9;
            // 
            // button_download2
            // 
            button_download2.Location = new Point(94, 348);
            button_download2.Name = "button_download2";
            button_download2.Size = new Size(128, 23);
            button_download2.TabIndex = 10;
            button_download2.Text = "Download";
            button_download2.UseVisualStyleBackColor = true;
            button_download2.Click += button_download2_Click;
            // 
            // button_copiarLink
            // 
            button_copiarLink.Location = new Point(552, 348);
            button_copiarLink.Name = "button_copiarLink";
            button_copiarLink.Size = new Size(100, 23);
            button_copiarLink.TabIndex = 11;
            button_copiarLink.Text = "Copiar";
            button_copiarLink.UseVisualStyleBackColor = true;
            button_copiarLink.Click += button_copiarLink_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(782, 442);
            Controls.Add(button_copiarLink);
            Controls.Add(button_download2);
            Controls.Add(textBox_linkGdrive);
            Controls.Add(button1);
            Controls.Add(treeView_diretorios);
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
        private TreeView treeView_diretorios;
        private Button button1;
        // private Button button_download;
        private TextBox textBox_linkGdrive;
        private Button button_download2;
        private Button button_copiarLink;
        private ToolStripStatusLabel toolStripStatusLabel1;
    }
}