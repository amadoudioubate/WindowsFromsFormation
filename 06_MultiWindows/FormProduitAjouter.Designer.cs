namespace MultiWindows
{
    partial class FormProduitAjouter
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textDescription = new System.Windows.Forms.TextBox();
            this.textPrix = new System.Windows.Forms.TextBox();
            this.textQuantite = new System.Windows.Forms.TextBox();
            this.textId = new System.Windows.Forms.TextBox();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 125);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Description";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 193);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Prix";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 272);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 28);
            this.label3.TabIndex = 2;
            this.label3.Text = "Quantité";
            // 
            // textDescription
            // 
            this.textDescription.Location = new System.Drawing.Point(234, 122);
            this.textDescription.Name = "textDescription";
            this.textDescription.Size = new System.Drawing.Size(218, 34);
            this.textDescription.TabIndex = 3;
            // 
            // textPrix
            // 
            this.textPrix.Location = new System.Drawing.Point(234, 193);
            this.textPrix.Name = "textPrix";
            this.textPrix.Size = new System.Drawing.Size(218, 34);
            this.textPrix.TabIndex = 4;
            // 
            // textQuantite
            // 
            this.textQuantite.Location = new System.Drawing.Point(234, 266);
            this.textQuantite.Name = "textQuantite";
            this.textQuantite.Size = new System.Drawing.Size(218, 34);
            this.textQuantite.TabIndex = 5;
            // 
            // textId
            // 
            this.textId.Location = new System.Drawing.Point(234, 60);
            this.textId.Name = "textId";
            this.textId.Size = new System.Drawing.Size(218, 34);
            this.textId.TabIndex = 6;
            // 
            // btnAjouter
            // 
            this.btnAjouter.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAjouter.Location = new System.Drawing.Point(290, 342);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(162, 41);
            this.btnAjouter.TabIndex = 7;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // FormProduitAjouter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 445);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.textId);
            this.Controls.Add(this.textQuantite);
            this.Controls.Add(this.textPrix);
            this.Controls.Add(this.textDescription);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormProduitAjouter";
            this.Text = "FormProduitAjouter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textDescription;
        private TextBox textPrix;
        private TextBox textQuantite;
        private TextBox textId;
        private Button btnAjouter;
    }
}