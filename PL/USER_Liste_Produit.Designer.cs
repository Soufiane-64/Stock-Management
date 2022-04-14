
namespace Gestion_De_Stock.PL
{
    partial class USER_Liste_Produit
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(USER_Liste_Produit));
            this.dataGridProduit = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.textBox_recherche = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_modifierProduit = new System.Windows.Forms.Button();
            this.button_supprimerProduit = new System.Windows.Forms.Button();
            this.button_ajouterProduit = new System.Windows.Forms.Button();
            this.button_afficherPhoto = new System.Windows.Forms.Button();
            this.button_excel = new System.Windows.Forms.Button();
            this.button_actualiser = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProduit)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridProduit
            // 
            this.dataGridProduit.AllowUserToAddRows = false;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridProduit.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridProduit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridProduit.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridProduit.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridProduit.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridProduit.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridProduit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridProduit.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column9,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dataGridProduit.EnableHeadersVisualStyles = false;
            this.dataGridProduit.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridProduit.Location = new System.Drawing.Point(3, 148);
            this.dataGridProduit.Name = "dataGridProduit";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridProduit.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridProduit.RowHeadersVisible = false;
            this.dataGridProduit.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridProduit.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridProduit.Size = new System.Drawing.Size(1131, 483);
            this.dataGridProduit.TabIndex = 17;
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
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Quantité";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Prix";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Catégorie";
            this.Column5.Name = "Column5";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(30)))));
            this.panel3.Location = new System.Drawing.Point(20, 122);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(535, 3);
            this.panel3.TabIndex = 14;
            // 
            // textBox_recherche
            // 
            this.textBox_recherche.BackColor = System.Drawing.SystemColors.Control;
            this.textBox_recherche.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_recherche.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_recherche.ForeColor = System.Drawing.Color.DimGray;
            this.textBox_recherche.Location = new System.Drawing.Point(20, 83);
            this.textBox_recherche.Multiline = true;
            this.textBox_recherche.Name = "textBox_recherche";
            this.textBox_recherche.Size = new System.Drawing.Size(535, 39);
            this.textBox_recherche.TabIndex = 15;
            this.textBox_recherche.Text = "Rechercher";
            this.textBox_recherche.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_recherche.TextChanged += new System.EventHandler(this.textBox_rechercher_TextChanged);
            this.textBox_recherche.Enter += new System.EventHandler(this.textBox_rechercher_Enter);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(30)))));
            this.panel2.Location = new System.Drawing.Point(20, 139);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1100, 3);
            this.panel2.TabIndex = 13;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(30)))));
            this.panel1.Location = new System.Drawing.Point(20, 74);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1100, 3);
            this.panel1.TabIndex = 12;
            // 
            // button_modifierProduit
            // 
            this.button_modifierProduit.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button_modifierProduit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(25)))), ((int)(((byte)(90)))));
            this.button_modifierProduit.FlatAppearance.BorderSize = 0;
            this.button_modifierProduit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_modifierProduit.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_modifierProduit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(195)))), ((int)(((byte)(0)))));
            this.button_modifierProduit.Image = ((System.Drawing.Image)(resources.GetObject("button_modifierProduit.Image")));
            this.button_modifierProduit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_modifierProduit.Location = new System.Drawing.Point(307, 10);
            this.button_modifierProduit.Name = "button_modifierProduit";
            this.button_modifierProduit.Size = new System.Drawing.Size(248, 58);
            this.button_modifierProduit.TabIndex = 11;
            this.button_modifierProduit.Text = "Modifier";
            this.button_modifierProduit.UseVisualStyleBackColor = false;
            this.button_modifierProduit.Click += new System.EventHandler(this.button_modifierProduit_Click);
            // 
            // button_supprimerProduit
            // 
            this.button_supprimerProduit.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button_supprimerProduit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(25)))), ((int)(((byte)(90)))));
            this.button_supprimerProduit.FlatAppearance.BorderSize = 0;
            this.button_supprimerProduit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_supprimerProduit.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_supprimerProduit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(195)))), ((int)(((byte)(0)))));
            this.button_supprimerProduit.Image = ((System.Drawing.Image)(resources.GetObject("button_supprimerProduit.Image")));
            this.button_supprimerProduit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_supprimerProduit.Location = new System.Drawing.Point(585, 10);
            this.button_supprimerProduit.Name = "button_supprimerProduit";
            this.button_supprimerProduit.Size = new System.Drawing.Size(248, 58);
            this.button_supprimerProduit.TabIndex = 10;
            this.button_supprimerProduit.Text = "Supprimer";
            this.button_supprimerProduit.UseVisualStyleBackColor = false;
            this.button_supprimerProduit.Click += new System.EventHandler(this.button_supprimerProduit_Click);
            // 
            // button_ajouterProduit
            // 
            this.button_ajouterProduit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(25)))), ((int)(((byte)(90)))));
            this.button_ajouterProduit.FlatAppearance.BorderSize = 0;
            this.button_ajouterProduit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_ajouterProduit.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_ajouterProduit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(195)))), ((int)(((byte)(0)))));
            this.button_ajouterProduit.Image = ((System.Drawing.Image)(resources.GetObject("button_ajouterProduit.Image")));
            this.button_ajouterProduit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_ajouterProduit.Location = new System.Drawing.Point(20, 10);
            this.button_ajouterProduit.Name = "button_ajouterProduit";
            this.button_ajouterProduit.Size = new System.Drawing.Size(248, 58);
            this.button_ajouterProduit.TabIndex = 9;
            this.button_ajouterProduit.Text = "Ajouter";
            this.button_ajouterProduit.UseVisualStyleBackColor = false;
            this.button_ajouterProduit.Click += new System.EventHandler(this.button_ajouterProduit_Click);
            // 
            // button_afficherPhoto
            // 
            this.button_afficherPhoto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_afficherPhoto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(25)))), ((int)(((byte)(90)))));
            this.button_afficherPhoto.FlatAppearance.BorderSize = 0;
            this.button_afficherPhoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_afficherPhoto.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_afficherPhoto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(195)))), ((int)(((byte)(0)))));
            this.button_afficherPhoto.Image = ((System.Drawing.Image)(resources.GetObject("button_afficherPhoto.Image")));
            this.button_afficherPhoto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_afficherPhoto.Location = new System.Drawing.Point(872, 10);
            this.button_afficherPhoto.Name = "button_afficherPhoto";
            this.button_afficherPhoto.Size = new System.Drawing.Size(248, 58);
            this.button_afficherPhoto.TabIndex = 18;
            this.button_afficherPhoto.Text = "Afficher Photo";
            this.button_afficherPhoto.UseVisualStyleBackColor = false;
            this.button_afficherPhoto.Click += new System.EventHandler(this.button_afficherPhoto_Click);
            // 
            // button_excel
            // 
            this.button_excel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_excel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(25)))), ((int)(((byte)(90)))));
            this.button_excel.FlatAppearance.BorderSize = 0;
            this.button_excel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_excel.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_excel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(195)))), ((int)(((byte)(0)))));
            this.button_excel.Image = ((System.Drawing.Image)(resources.GetObject("button_excel.Image")));
            this.button_excel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_excel.Location = new System.Drawing.Point(307, 648);
            this.button_excel.Name = "button_excel";
            this.button_excel.Size = new System.Drawing.Size(526, 58);
            this.button_excel.TabIndex = 20;
            this.button_excel.Text = "Sauvgarder dans excel";
            this.button_excel.UseVisualStyleBackColor = false;
            this.button_excel.Click += new System.EventHandler(this.button_excel_Click);
            // 
            // button_actualiser
            // 
            this.button_actualiser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_actualiser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(25)))), ((int)(((byte)(90)))));
            this.button_actualiser.FlatAppearance.BorderSize = 0;
            this.button_actualiser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_actualiser.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_actualiser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(195)))), ((int)(((byte)(0)))));
            this.button_actualiser.Image = ((System.Drawing.Image)(resources.GetObject("button_actualiser.Image")));
            this.button_actualiser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_actualiser.Location = new System.Drawing.Point(872, 83);
            this.button_actualiser.Name = "button_actualiser";
            this.button_actualiser.Size = new System.Drawing.Size(248, 52);
            this.button_actualiser.TabIndex = 21;
            this.button_actualiser.Text = "Actualiser";
            this.button_actualiser.UseVisualStyleBackColor = false;
            this.button_actualiser.Click += new System.EventHandler(this.button_actualiser_Click);
            // 
            // USER_Liste_Produit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button_actualiser);
            this.Controls.Add(this.button_excel);
            this.Controls.Add(this.button_afficherPhoto);
            this.Controls.Add(this.dataGridProduit);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.textBox_recherche);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button_modifierProduit);
            this.Controls.Add(this.button_supprimerProduit);
            this.Controls.Add(this.button_ajouterProduit);
            this.Name = "USER_Liste_Produit";
            this.Size = new System.Drawing.Size(1137, 720);
            this.Load += new System.EventHandler(this.USER_Liste_Produit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProduit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridProduit;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox textBox_recherche;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_modifierProduit;
        private System.Windows.Forms.Button button_supprimerProduit;
        private System.Windows.Forms.Button button_ajouterProduit;
        private System.Windows.Forms.Button button_afficherPhoto;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.Button button_excel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Button button_actualiser;
    }
}
