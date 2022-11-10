namespace _02_RadioButtons
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonValide = new System.Windows.Forms.Button();
            this.radioDepot = new System.Windows.Forms.RadioButton();
            this.radioRetrait = new System.Windows.Forms.RadioButton();
            this.textMontant = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textSolde = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonValide);
            this.groupBox1.Controls.Add(this.radioDepot);
            this.groupBox1.Controls.Add(this.radioRetrait);
            this.groupBox1.Controls.Add(this.textMontant);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textSolde);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(32, 25);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(349, 389);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Opérations";
            // 
            // buttonValide
            // 
            this.buttonValide.Location = new System.Drawing.Point(83, 314);
            this.buttonValide.Name = "buttonValide";
            this.buttonValide.Size = new System.Drawing.Size(177, 40);
            this.buttonValide.TabIndex = 7;
            this.buttonValide.Text = "Valider";
            this.buttonValide.UseVisualStyleBackColor = true;
            this.buttonValide.Click += new System.EventHandler(this.buttonValide_Click);
            // 
            // radioDepot
            // 
            this.radioDepot.AutoSize = true;
            this.radioDepot.Location = new System.Drawing.Point(205, 256);
            this.radioDepot.Name = "radioDepot";
            this.radioDepot.Size = new System.Drawing.Size(88, 32);
            this.radioDepot.TabIndex = 6;
            this.radioDepot.TabStop = true;
            this.radioDepot.Text = "Dépot";
            this.radioDepot.UseVisualStyleBackColor = true;
            // 
            // radioRetrait
            // 
            this.radioRetrait.AutoSize = true;
            this.radioRetrait.Location = new System.Drawing.Point(34, 256);
            this.radioRetrait.Name = "radioRetrait";
            this.radioRetrait.Size = new System.Drawing.Size(90, 32);
            this.radioRetrait.TabIndex = 5;
            this.radioRetrait.TabStop = true;
            this.radioRetrait.Text = "Retrait";
            this.radioRetrait.UseVisualStyleBackColor = true;
            // 
            // textMontant
            // 
            this.textMontant.Location = new System.Drawing.Point(170, 160);
            this.textMontant.Name = "textMontant";
            this.textMontant.Size = new System.Drawing.Size(125, 34);
            this.textMontant.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 28);
            this.label2.TabIndex = 3;
            this.label2.Text = "Montant";
            // 
            // textSolde
            // 
            this.textSolde.Location = new System.Drawing.Point(170, 84);
            this.textSolde.Name = "textSolde";
            this.textSolde.Size = new System.Drawing.Size(125, 34);
            this.textSolde.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Solde";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 630);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private Button buttonValide;
        private RadioButton radioDepot;
        private RadioButton radioRetrait;
        private TextBox textMontant;
        private Label label2;
        private TextBox textSolde;
        private Label label1;
    }
}