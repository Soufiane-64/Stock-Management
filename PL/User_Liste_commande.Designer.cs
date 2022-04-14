
namespace Gestion_De_Stock.PL
{
    partial class User_Liste_commande
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(User_Liste_commande));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.button_cherche = new System.Windows.Forms.Button();
            this.dataGridcommande = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_ajoutercommande = new System.Windows.Forms.Button();
            this.label_debut = new System.Windows.Forms.Label();
            this.label_fin = new System.Windows.Forms.Label();
            this.datef = new System.Windows.Forms.DateTimePicker();
            this.dated = new System.Windows.Forms.DateTimePicker();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total_ttc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridcommande)).BeginInit();
            this.SuspendLayout();
            // 
            // button_cherche
            // 
            this.button_cherche.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_cherche.BackColor = System.Drawing.SystemColors.Control;
            this.button_cherche.FlatAppearance.BorderSize = 0;
            this.button_cherche.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_cherche.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_cherche.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_cherche.Image = ((System.Drawing.Image)(resources.GetObject("button_cherche.Image")));
            this.button_cherche.Location = new System.Drawing.Point(1062, 12);
            this.button_cherche.Name = "button_cherche";
            this.button_cherche.Size = new System.Drawing.Size(58, 58);
            this.button_cherche.TabIndex = 30;
            this.button_cherche.UseVisualStyleBackColor = false;
            this.button_cherche.Click += new System.EventHandler(this.button_cherche_Click);
            // 
            // dataGridcommande
            // 
            this.dataGridcommande.AllowUserToAddRows = false;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridcommande.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridcommande.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridcommande.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridcommande.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridcommande.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridcommande.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridcommande.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridcommande.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column9,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Total_ttc});
            this.dataGridcommande.EnableHeadersVisualStyles = false;
            this.dataGridcommande.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridcommande.Location = new System.Drawing.Point(3, 85);
            this.dataGridcommande.Name = "dataGridcommande";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridcommande.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridcommande.RowHeadersVisible = false;
            this.dataGridcommande.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridcommande.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridcommande.Size = new System.Drawing.Size(1131, 548);
            this.dataGridcommande.TabIndex = 29;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(30)))));
            this.panel1.Location = new System.Drawing.Point(20, 76);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1100, 3);
            this.panel1.TabIndex = 25;
            // 
            // button_ajoutercommande
            // 
            this.button_ajoutercommande.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(25)))), ((int)(((byte)(90)))));
            this.button_ajoutercommande.FlatAppearance.BorderSize = 0;
            this.button_ajoutercommande.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_ajoutercommande.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_ajoutercommande.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(195)))), ((int)(((byte)(0)))));
            this.button_ajoutercommande.Image = ((System.Drawing.Image)(resources.GetObject("button_ajoutercommande.Image")));
            this.button_ajoutercommande.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_ajoutercommande.Location = new System.Drawing.Point(20, 12);
            this.button_ajoutercommande.Name = "button_ajoutercommande";
            this.button_ajoutercommande.Size = new System.Drawing.Size(248, 58);
            this.button_ajoutercommande.TabIndex = 22;
            this.button_ajoutercommande.Text = "Ajouter";
            this.button_ajoutercommande.UseVisualStyleBackColor = false;
            this.button_ajoutercommande.Click += new System.EventHandler(this.button_ajoutercommande_Click);
            // 
            // label_debut
            // 
            this.label_debut.AutoSize = true;
            this.label_debut.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_debut.ForeColor = System.Drawing.Color.DarkGreen;
            this.label_debut.Location = new System.Drawing.Point(274, 29);
            this.label_debut.Name = "label_debut";
            this.label_debut.Size = new System.Drawing.Size(146, 23);
            this.label_debut.TabIndex = 31;
            this.label_debut.Text = "Date de début :";
            // 
            // label_fin
            // 
            this.label_fin.AutoSize = true;
            this.label_fin.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_fin.ForeColor = System.Drawing.Color.DarkRed;
            this.label_fin.Location = new System.Drawing.Point(676, 29);
            this.label_fin.Name = "label_fin";
            this.label_fin.Size = new System.Drawing.Size(117, 23);
            this.label_fin.TabIndex = 33;
            this.label_fin.Text = "Date de fin :";
            // 
            // datef
            // 
            this.datef.Location = new System.Drawing.Point(799, 32);
            this.datef.Name = "datef";
            this.datef.Size = new System.Drawing.Size(200, 20);
            this.datef.TabIndex = 34;
            // 
            // dated
            // 
            this.dated.Location = new System.Drawing.Point(426, 32);
            this.dated.Name = "dated";
            this.dated.Size = new System.Drawing.Size(200, 20);
            this.dated.TabIndex = 35;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "ID";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Date";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Client";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Total HT";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "TVA%";
            this.Column5.Name = "Column5";
            // 
            // Total_ttc
            // 
            this.Total_ttc.HeaderText = "Total TTC";
            this.Total_ttc.Name = "Total_ttc";
            // 
            // User_Liste_commande
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dated);
            this.Controls.Add(this.datef);
            this.Controls.Add(this.label_fin);
            this.Controls.Add(this.label_debut);
            this.Controls.Add(this.button_cherche);
            this.Controls.Add(this.dataGridcommande);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button_ajoutercommande);
            this.Name = "User_Liste_commande";
            this.Size = new System.Drawing.Size(1137, 720);
            this.Load += new System.EventHandler(this.User_Liste_commande_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridcommande)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_cherche;
        private System.Windows.Forms.DataGridView dataGridcommande;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_ajoutercommande;
        private System.Windows.Forms.Label label_debut;
        private System.Windows.Forms.Label label_fin;
        private System.Windows.Forms.DateTimePicker datef;
        private System.Windows.Forms.DateTimePicker dated;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total_ttc;
    }
}
