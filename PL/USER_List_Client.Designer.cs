
namespace Gestion_De_Stock.PL
{
    partial class USER_List_Client
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(USER_List_Client));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.button_modifierClient = new System.Windows.Forms.Button();
            this.button_supprimerClient = new System.Windows.Forms.Button();
            this.button_ajouterClient = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridClient = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBox_recherche = new System.Windows.Forms.ComboBox();
            this.textBox_recherch = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridClient)).BeginInit();
            this.SuspendLayout();
            // 
            // button_modifierClient
            // 
            this.button_modifierClient.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button_modifierClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(25)))), ((int)(((byte)(90)))));
            this.button_modifierClient.FlatAppearance.BorderSize = 0;
            this.button_modifierClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_modifierClient.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_modifierClient.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(195)))), ((int)(((byte)(0)))));
            this.button_modifierClient.Image = ((System.Drawing.Image)(resources.GetObject("button_modifierClient.Image")));
            this.button_modifierClient.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_modifierClient.Location = new System.Drawing.Point(436, 17);
            this.button_modifierClient.Name = "button_modifierClient";
            this.button_modifierClient.Size = new System.Drawing.Size(260, 58);
            this.button_modifierClient.TabIndex = 2;
            this.button_modifierClient.Text = "Modifier";
            this.button_modifierClient.UseVisualStyleBackColor = false;
            this.button_modifierClient.Click += new System.EventHandler(this.button_modifierClient_Click);
            // 
            // button_supprimerClient
            // 
            this.button_supprimerClient.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_supprimerClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(25)))), ((int)(((byte)(90)))));
            this.button_supprimerClient.FlatAppearance.BorderSize = 0;
            this.button_supprimerClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_supprimerClient.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_supprimerClient.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(195)))), ((int)(((byte)(0)))));
            this.button_supprimerClient.Image = ((System.Drawing.Image)(resources.GetObject("button_supprimerClient.Image")));
            this.button_supprimerClient.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_supprimerClient.Location = new System.Drawing.Point(810, 17);
            this.button_supprimerClient.Name = "button_supprimerClient";
            this.button_supprimerClient.Size = new System.Drawing.Size(260, 58);
            this.button_supprimerClient.TabIndex = 1;
            this.button_supprimerClient.Text = "Supprimer";
            this.button_supprimerClient.UseVisualStyleBackColor = false;
            this.button_supprimerClient.Click += new System.EventHandler(this.button_supprimerClient_Click);
            // 
            // button_ajouterClient
            // 
            this.button_ajouterClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(25)))), ((int)(((byte)(90)))));
            this.button_ajouterClient.FlatAppearance.BorderSize = 0;
            this.button_ajouterClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_ajouterClient.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_ajouterClient.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(195)))), ((int)(((byte)(0)))));
            this.button_ajouterClient.Image = ((System.Drawing.Image)(resources.GetObject("button_ajouterClient.Image")));
            this.button_ajouterClient.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_ajouterClient.Location = new System.Drawing.Point(76, 17);
            this.button_ajouterClient.Name = "button_ajouterClient";
            this.button_ajouterClient.Size = new System.Drawing.Size(260, 58);
            this.button_ajouterClient.TabIndex = 0;
            this.button_ajouterClient.Text = "Ajouter";
            this.button_ajouterClient.UseVisualStyleBackColor = false;
            this.button_ajouterClient.Click += new System.EventHandler(this.button_ajouterClient_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(30)))));
            this.panel1.Location = new System.Drawing.Point(76, 81);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(994, 3);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(30)))));
            this.panel2.Location = new System.Drawing.Point(76, 164);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(994, 3);
            this.panel2.TabIndex = 4;
            // 
            // dataGridClient
            // 
            this.dataGridClient.AllowUserToAddRows = false;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridClient.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridClient.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridClient.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridClient.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridClient.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridClient.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridClient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridClient.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column9,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8});
            this.dataGridClient.EnableHeadersVisualStyles = false;
            this.dataGridClient.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridClient.Location = new System.Drawing.Point(3, 173);
            this.dataGridClient.Name = "dataGridClient";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridClient.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridClient.RowHeadersVisible = false;
            this.dataGridClient.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridClient.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridClient.Size = new System.Drawing.Size(1131, 544);
            this.dataGridClient.TabIndex = 8;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Select";
            this.Column1.Name = "Column1";
            // 
            // Column9
            // 
            this.Column9.HeaderText = "ID";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nom";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Prenom";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Adresse";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Telephone";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Email";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Ville";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Pays";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // comboBox_recherche
            // 
            this.comboBox_recherche.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_recherche.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_recherche.FormattingEnabled = true;
            this.comboBox_recherche.Items.AddRange(new object[] {
            "Nom",
            "Prenom",
            "Telephone",
            "Email",
            "Ville",
            "Pays"});
            this.comboBox_recherche.Location = new System.Drawing.Point(228, 108);
            this.comboBox_recherche.Name = "comboBox_recherche";
            this.comboBox_recherche.Size = new System.Drawing.Size(286, 33);
            this.comboBox_recherche.TabIndex = 19;
            this.comboBox_recherche.SelectedIndexChanged += new System.EventHandler(this.comboBox_recherche_SelectedIndexChanged_1);
            // 
            // textBox_recherch
            // 
            this.textBox_recherch.BackColor = System.Drawing.SystemColors.Control;
            this.textBox_recherch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_recherch.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_recherch.ForeColor = System.Drawing.Color.DimGray;
            this.textBox_recherch.Location = new System.Drawing.Point(570, 102);
            this.textBox_recherch.Multiline = true;
            this.textBox_recherch.Name = "textBox_recherch";
            this.textBox_recherch.Size = new System.Drawing.Size(311, 39);
            this.textBox_recherch.TabIndex = 18;
            this.textBox_recherch.Text = "Recherche";
            this.textBox_recherch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_recherch.TextChanged += new System.EventHandler(this.textBox_recherch_TextChanged);
            this.textBox_recherch.Enter += new System.EventHandler(this.textBox_rechercher_Enter);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(30)))));
            this.panel3.Location = new System.Drawing.Point(570, 141);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(311, 3);
            this.panel3.TabIndex = 17;
            // 
            // USER_List_Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.comboBox_recherche);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.textBox_recherch);
            this.Controls.Add(this.dataGridClient);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button_modifierClient);
            this.Controls.Add(this.button_supprimerClient);
            this.Controls.Add(this.button_ajouterClient);
            this.Name = "USER_List_Client";
            this.Size = new System.Drawing.Size(1137, 720);
            this.Load += new System.EventHandler(this.USER_List_Client_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridClient)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_ajouterClient;
        private System.Windows.Forms.Button button_supprimerClient;
        private System.Windows.Forms.Button button_modifierClient;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridClient;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.ComboBox comboBox_recherche;
        private System.Windows.Forms.Panel panel3;
        public System.Windows.Forms.TextBox textBox_recherch;
    }
}
