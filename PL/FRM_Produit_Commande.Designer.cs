
namespace Gestion_De_Stock.PL
{
    partial class FRM_Produit_Commande
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
            this.groupBox_vendreproduit = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox_detailproduit = new System.Windows.Forms.GroupBox();
            this.label__id = new System.Windows.Forms.Label();
            this.label_id = new System.Windows.Forms.Label();
            this.label_prix = new System.Windows.Forms.Label();
            this.label_stock = new System.Windows.Forms.Label();
            this.label_nom = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_total = new System.Windows.Forms.TextBox();
            this.textBox_remise = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_quantite = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_enregistrer = new System.Windows.Forms.Button();
            this.groupBox_vendreproduit.SuspendLayout();
            this.groupBox_detailproduit.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_vendreproduit
            // 
            this.groupBox_vendreproduit.Controls.Add(this.label11);
            this.groupBox_vendreproduit.Controls.Add(this.label2);
            this.groupBox_vendreproduit.Controls.Add(this.groupBox_detailproduit);
            this.groupBox_vendreproduit.Controls.Add(this.textBox_total);
            this.groupBox_vendreproduit.Controls.Add(this.textBox_remise);
            this.groupBox_vendreproduit.Controls.Add(this.label6);
            this.groupBox_vendreproduit.Controls.Add(this.label3);
            this.groupBox_vendreproduit.Controls.Add(this.textBox_quantite);
            this.groupBox_vendreproduit.Controls.Add(this.label1);
            this.groupBox_vendreproduit.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_vendreproduit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox_vendreproduit.Location = new System.Drawing.Point(-5, 3);
            this.groupBox_vendreproduit.Name = "groupBox_vendreproduit";
            this.groupBox_vendreproduit.Size = new System.Drawing.Size(577, 285);
            this.groupBox_vendreproduit.TabIndex = 20;
            this.groupBox_vendreproduit.TabStop = false;
            this.groupBox_vendreproduit.Text = "Vendre Produit";
            this.groupBox_vendreproduit.Enter += new System.EventHandler(this.groupBox_vendreproduit_Enter);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label11.Location = new System.Drawing.Point(533, 143);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(25, 19);
            this.label11.TabIndex = 31;
            this.label11.Text = "%";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(388, 264);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 19);
            this.label2.TabIndex = 19;
            this.label2.Text = "-------------------------";
            // 
            // groupBox_detailproduit
            // 
            this.groupBox_detailproduit.Controls.Add(this.label__id);
            this.groupBox_detailproduit.Controls.Add(this.label_id);
            this.groupBox_detailproduit.Controls.Add(this.label_prix);
            this.groupBox_detailproduit.Controls.Add(this.label_stock);
            this.groupBox_detailproduit.Controls.Add(this.label_nom);
            this.groupBox_detailproduit.Controls.Add(this.label5);
            this.groupBox_detailproduit.Controls.Add(this.label4);
            this.groupBox_detailproduit.Controls.Add(this.label7);
            this.groupBox_detailproduit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox_detailproduit.Location = new System.Drawing.Point(9, 26);
            this.groupBox_detailproduit.Name = "groupBox_detailproduit";
            this.groupBox_detailproduit.Size = new System.Drawing.Size(373, 250);
            this.groupBox_detailproduit.TabIndex = 18;
            this.groupBox_detailproduit.TabStop = false;
            this.groupBox_detailproduit.Text = "Detail Produit";
            this.groupBox_detailproduit.Enter += new System.EventHandler(this.groupBox_detailproduit_Enter);
            // 
            // label__id
            // 
            this.label__id.AutoSize = true;
            this.label__id.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label__id.Location = new System.Drawing.Point(73, 41);
            this.label__id.Name = "label__id";
            this.label__id.Size = new System.Drawing.Size(0, 19);
            this.label__id.TabIndex = 29;
            // 
            // label_id
            // 
            this.label_id.AutoSize = true;
            this.label_id.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_id.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(195)))), ((int)(((byte)(0)))));
            this.label_id.Location = new System.Drawing.Point(6, 36);
            this.label_id.Name = "label_id";
            this.label_id.Size = new System.Drawing.Size(58, 25);
            this.label_id.TabIndex = 28;
            this.label_id.Text = "ID : ";
            // 
            // label_prix
            // 
            this.label_prix.AutoSize = true;
            this.label_prix.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_prix.Location = new System.Drawing.Point(73, 201);
            this.label_prix.Name = "label_prix";
            this.label_prix.Size = new System.Drawing.Size(0, 19);
            this.label_prix.TabIndex = 27;
            // 
            // label_stock
            // 
            this.label_stock.AutoSize = true;
            this.label_stock.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_stock.Location = new System.Drawing.Point(89, 157);
            this.label_stock.Name = "label_stock";
            this.label_stock.Size = new System.Drawing.Size(0, 19);
            this.label_stock.TabIndex = 26;
            // 
            // label_nom
            // 
            this.label_nom.AutoSize = true;
            this.label_nom.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_nom.Location = new System.Drawing.Point(73, 97);
            this.label_nom.Name = "label_nom";
            this.label_nom.Size = new System.Drawing.Size(0, 19);
            this.label_nom.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(195)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(6, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 25);
            this.label5.TabIndex = 24;
            this.label5.Text = "Prix : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(195)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(6, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 25);
            this.label4.TabIndex = 23;
            this.label4.Text = "Nom : ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(195)))), ((int)(((byte)(0)))));
            this.label7.Location = new System.Drawing.Point(6, 152);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 25);
            this.label7.TabIndex = 22;
            this.label7.Text = "Stock : ";
            // 
            // textBox_total
            // 
            this.textBox_total.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBox_total.Enabled = false;
            this.textBox_total.Location = new System.Drawing.Point(392, 220);
            this.textBox_total.Name = "textBox_total";
            this.textBox_total.Size = new System.Drawing.Size(173, 27);
            this.textBox_total.TabIndex = 17;
            // 
            // textBox_remise
            // 
            this.textBox_remise.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBox_remise.Location = new System.Drawing.Point(392, 140);
            this.textBox_remise.Name = "textBox_remise";
            this.textBox_remise.Size = new System.Drawing.Size(140, 27);
            this.textBox_remise.TabIndex = 15;
            this.textBox_remise.TextChanged += new System.EventHandler(this.textBox_remise_TextChanged);
            this.textBox_remise.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_remise_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(388, 109);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(184, 19);
            this.label6.TabIndex = 14;
            this.label6.Text = "--- Remise ------------";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(388, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(181, 19);
            this.label3.TabIndex = 13;
            this.label3.Text = "--- Quantité ----------";
            // 
            // textBox_quantite
            // 
            this.textBox_quantite.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBox_quantite.Location = new System.Drawing.Point(392, 62);
            this.textBox_quantite.Name = "textBox_quantite";
            this.textBox_quantite.Size = new System.Drawing.Size(166, 27);
            this.textBox_quantite.TabIndex = 7;
            this.textBox_quantite.TextChanged += new System.EventHandler(this.textBox_quantite_TextChanged);
            this.textBox_quantite.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_quantite_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(388, 184);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "--- ToTal  -------------";
            // 
            // button_enregistrer
            // 
            this.button_enregistrer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(195)))), ((int)(((byte)(0)))));
            this.button_enregistrer.FlatAppearance.BorderSize = 0;
            this.button_enregistrer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_enregistrer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_enregistrer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(25)))), ((int)(((byte)(90)))));
            this.button_enregistrer.Location = new System.Drawing.Point(126, 294);
            this.button_enregistrer.Name = "button_enregistrer";
            this.button_enregistrer.Size = new System.Drawing.Size(324, 56);
            this.button_enregistrer.TabIndex = 30;
            this.button_enregistrer.Text = "Enregistrer";
            this.button_enregistrer.UseVisualStyleBackColor = false;
            this.button_enregistrer.Click += new System.EventHandler(this.button_enregistrer_Click);
            // 
            // FRM_Produit_Commande
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(25)))), ((int)(((byte)(90)))));
            this.ClientSize = new System.Drawing.Size(584, 362);
            this.Controls.Add(this.button_enregistrer);
            this.Controls.Add(this.groupBox_vendreproduit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FRM_Produit_Commande";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Produit";
            this.Load += new System.EventHandler(this.FRM_Produit_Commande_Load);
            this.groupBox_vendreproduit.ResumeLayout(false);
            this.groupBox_vendreproduit.PerformLayout();
            this.groupBox_detailproduit.ResumeLayout(false);
            this.groupBox_detailproduit.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_enregistrer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox_detailproduit;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.Label label_prix;
        public System.Windows.Forms.Label label_stock;
        public System.Windows.Forms.Label label_nom;
        public System.Windows.Forms.TextBox textBox_total;
        public System.Windows.Forms.Label label__id;
        private System.Windows.Forms.Label label_id;
        public System.Windows.Forms.GroupBox groupBox_vendreproduit;
        public System.Windows.Forms.TextBox textBox_quantite;
        public System.Windows.Forms.TextBox textBox_remise;
    }
}