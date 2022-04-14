
namespace Gestion_De_Stock.PL
{
    partial class FRM_Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_Menu));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_Commande = new System.Windows.Forms.Button();
            this.pnlBtn = new System.Windows.Forms.Panel();
            this.button_Menu = new System.Windows.Forms.Button();
            this.button_Produit = new System.Windows.Forms.Button();
            this.button_Categorie = new System.Windows.Forms.Button();
            this.button_client = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pnlparamettre = new System.Windows.Forms.Panel();
            this.button_deconnecter = new System.Windows.Forms.Button();
            this.button_connecter = new System.Windows.Forms.Button();
            this.panel_affiche = new System.Windows.Forms.Panel();
            this.button_paramettre = new System.Windows.Forms.Button();
            this.Minimize = new System.Windows.Forms.Button();
            this.Close = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.pnlparamettre.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(25)))), ((int)(((byte)(90)))));
            this.panel1.Controls.Add(this.button_Commande);
            this.panel1.Controls.Add(this.pnlBtn);
            this.panel1.Controls.Add(this.button_Menu);
            this.panel1.Controls.Add(this.button_Produit);
            this.panel1.Controls.Add(this.button_Categorie);
            this.panel1.Controls.Add(this.button_client);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(229, 582);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // button_Commande
            // 
            this.button_Commande.FlatAppearance.BorderSize = 0;
            this.button_Commande.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(195)))), ((int)(((byte)(0)))));
            this.button_Commande.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Commande.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Commande.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_Commande.Image = ((System.Drawing.Image)(resources.GetObject("button_Commande.Image")));
            this.button_Commande.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Commande.Location = new System.Drawing.Point(12, 409);
            this.button_Commande.Name = "button_Commande";
            this.button_Commande.Size = new System.Drawing.Size(213, 60);
            this.button_Commande.TabIndex = 9;
            this.button_Commande.Text = "        Commande";
            this.button_Commande.UseVisualStyleBackColor = true;
            this.button_Commande.Click += new System.EventHandler(this.button_Commande_Click_1);
            // 
            // pnlBtn
            // 
            this.pnlBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(195)))), ((int)(((byte)(0)))));
            this.pnlBtn.Location = new System.Drawing.Point(3, 66);
            this.pnlBtn.Name = "pnlBtn";
            this.pnlBtn.Size = new System.Drawing.Size(10, 60);
            this.pnlBtn.TabIndex = 4;
            // 
            // button_Menu
            // 
            this.button_Menu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Menu.FlatAppearance.BorderSize = 0;
            this.button_Menu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Menu.Image = ((System.Drawing.Image)(resources.GetObject("button_Menu.Image")));
            this.button_Menu.Location = new System.Drawing.Point(197, 3);
            this.button_Menu.Name = "button_Menu";
            this.button_Menu.Size = new System.Drawing.Size(29, 27);
            this.button_Menu.TabIndex = 4;
            this.button_Menu.Text = " ";
            this.button_Menu.UseVisualStyleBackColor = true;
            this.button_Menu.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button_Produit
            // 
            this.button_Produit.FlatAppearance.BorderSize = 0;
            this.button_Produit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(195)))), ((int)(((byte)(0)))));
            this.button_Produit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Produit.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Produit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_Produit.Image = ((System.Drawing.Image)(resources.GetObject("button_Produit.Image")));
            this.button_Produit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Produit.Location = new System.Drawing.Point(12, 184);
            this.button_Produit.Name = "button_Produit";
            this.button_Produit.Size = new System.Drawing.Size(213, 60);
            this.button_Produit.TabIndex = 6;
            this.button_Produit.Text = "    Produit";
            this.button_Produit.UseVisualStyleBackColor = true;
            this.button_Produit.Click += new System.EventHandler(this.button_Produit_Click);
            // 
            // button_Categorie
            // 
            this.button_Categorie.FlatAppearance.BorderSize = 0;
            this.button_Categorie.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(195)))), ((int)(((byte)(0)))));
            this.button_Categorie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Categorie.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Categorie.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_Categorie.Image = ((System.Drawing.Image)(resources.GetObject("button_Categorie.Image")));
            this.button_Categorie.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Categorie.Location = new System.Drawing.Point(12, 297);
            this.button_Categorie.Name = "button_Categorie";
            this.button_Categorie.Size = new System.Drawing.Size(213, 60);
            this.button_Categorie.TabIndex = 5;
            this.button_Categorie.Text = "      Categorie";
            this.button_Categorie.UseVisualStyleBackColor = true;
            this.button_Categorie.Click += new System.EventHandler(this.button_Categorie_Click);
            // 
            // button_client
            // 
            this.button_client.FlatAppearance.BorderSize = 0;
            this.button_client.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(195)))), ((int)(((byte)(0)))));
            this.button_client.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_client.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_client.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_client.Image = ((System.Drawing.Image)(resources.GetObject("button_client.Image")));
            this.button_client.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_client.Location = new System.Drawing.Point(12, 66);
            this.button_client.Name = "button_client";
            this.button_client.Size = new System.Drawing.Size(213, 60);
            this.button_client.TabIndex = 4;
            this.button_client.Text = "    Client";
            this.button_client.UseVisualStyleBackColor = true;
            this.button_client.Click += new System.EventHandler(this.button_client_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(195)))), ((int)(((byte)(0)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(229, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(801, 10);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.pnlparamettre);
            this.panel3.Controls.Add(this.panel_affiche);
            this.panel3.Controls.Add(this.button_paramettre);
            this.panel3.Controls.Add(this.Minimize);
            this.panel3.Controls.Add(this.Close);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(229, 10);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(801, 572);
            this.panel3.TabIndex = 2;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // pnlparamettre
            // 
            this.pnlparamettre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(25)))), ((int)(((byte)(90)))));
            this.pnlparamettre.Controls.Add(this.button_deconnecter);
            this.pnlparamettre.Controls.Add(this.button_connecter);
            this.pnlparamettre.Location = new System.Drawing.Point(47, 2);
            this.pnlparamettre.Name = "pnlparamettre";
            this.pnlparamettre.Size = new System.Drawing.Size(224, 114);
            this.pnlparamettre.TabIndex = 9;
            // 
            // button_deconnecter
            // 
            this.button_deconnecter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(25)))), ((int)(((byte)(90)))));
            this.button_deconnecter.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(195)))), ((int)(((byte)(0)))));
            this.button_deconnecter.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(195)))), ((int)(((byte)(0)))));
            this.button_deconnecter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_deconnecter.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_deconnecter.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_deconnecter.Image = ((System.Drawing.Image)(resources.GetObject("button_deconnecter.Image")));
            this.button_deconnecter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_deconnecter.Location = new System.Drawing.Point(3, 61);
            this.button_deconnecter.Name = "button_deconnecter";
            this.button_deconnecter.Size = new System.Drawing.Size(217, 48);
            this.button_deconnecter.TabIndex = 3;
            this.button_deconnecter.Text = "Deconnecter";
            this.button_deconnecter.UseVisualStyleBackColor = false;
            this.button_deconnecter.Click += new System.EventHandler(this.button_deconnecter_Click);
            // 
            // button_connecter
            // 
            this.button_connecter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(25)))), ((int)(((byte)(90)))));
            this.button_connecter.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(195)))), ((int)(((byte)(0)))));
            this.button_connecter.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(195)))), ((int)(((byte)(0)))));
            this.button_connecter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_connecter.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_connecter.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_connecter.Image = ((System.Drawing.Image)(resources.GetObject("button_connecter.Image")));
            this.button_connecter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_connecter.Location = new System.Drawing.Point(3, 3);
            this.button_connecter.Name = "button_connecter";
            this.button_connecter.Size = new System.Drawing.Size(217, 48);
            this.button_connecter.TabIndex = 0;
            this.button_connecter.Text = "Connecter";
            this.button_connecter.UseVisualStyleBackColor = false;
            this.button_connecter.Click += new System.EventHandler(this.button_connecter_Click);
            // 
            // panel_affiche
            // 
            this.panel_affiche.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_affiche.BackColor = System.Drawing.SystemColors.Control;
            this.panel_affiche.Location = new System.Drawing.Point(2, 60);
            this.panel_affiche.Name = "panel_affiche";
            this.panel_affiche.Size = new System.Drawing.Size(798, 512);
            this.panel_affiche.TabIndex = 11;
            this.panel_affiche.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_affiche_Paint);
            // 
            // button_paramettre
            // 
            this.button_paramettre.FlatAppearance.BorderSize = 0;
            this.button_paramettre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_paramettre.Image = ((System.Drawing.Image)(resources.GetObject("button_paramettre.Image")));
            this.button_paramettre.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button_paramettre.Location = new System.Drawing.Point(3, 3);
            this.button_paramettre.Name = "button_paramettre";
            this.button_paramettre.Size = new System.Drawing.Size(38, 37);
            this.button_paramettre.TabIndex = 10;
            this.button_paramettre.Text = " ";
            this.button_paramettre.UseVisualStyleBackColor = true;
            this.button_paramettre.Click += new System.EventHandler(this.button_paramettre_Click);
            // 
            // Minimize
            // 
            this.Minimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Minimize.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Minimize.BackgroundImage")));
            this.Minimize.FlatAppearance.BorderSize = 0;
            this.Minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Minimize.Location = new System.Drawing.Point(721, 6);
            this.Minimize.Name = "Minimize";
            this.Minimize.Size = new System.Drawing.Size(32, 37);
            this.Minimize.TabIndex = 8;
            this.Minimize.Text = " ";
            this.Minimize.UseVisualStyleBackColor = true;
            this.Minimize.Click += new System.EventHandler(this.Minimize_Click);
            // 
            // Close
            // 
            this.Close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Close.FlatAppearance.BorderSize = 0;
            this.Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Close.Image = ((System.Drawing.Image)(resources.GetObject("Close.Image")));
            this.Close.Location = new System.Drawing.Point(759, 3);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(39, 37);
            this.Close.TabIndex = 7;
            this.Close.Text = " ";
            this.Close.UseVisualStyleBackColor = true;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // FRM_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1030, 582);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FRM_Menu";
            this.Text = "FRM_Menu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FRM_Menu_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.pnlparamettre.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button_client;
        private System.Windows.Forms.Button button_Produit;
        private System.Windows.Forms.Button button_Categorie;
        private System.Windows.Forms.Button button_Menu;
        private System.Windows.Forms.Panel pnlBtn;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button_paramettre;
        private System.Windows.Forms.Panel pnlparamettre;
        private System.Windows.Forms.Button button_deconnecter;
        private System.Windows.Forms.Button button_connecter;
        private System.Windows.Forms.Button Minimize;
        private System.Windows.Forms.Button Close;
        private System.Windows.Forms.Panel panel_affiche;
        private System.Windows.Forms.Button button_Commande;
    }
}