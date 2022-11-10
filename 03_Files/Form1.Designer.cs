namespace _03_Files
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
            this.btnEcrire = new System.Windows.Forms.Button();
            this.btnLire = new System.Windows.Forms.Button();
            this.textEcrire = new System.Windows.Forms.TextBox();
            this.textLire = new System.Windows.Forms.TextBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // btnEcrire
            // 
            this.btnEcrire.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEcrire.Location = new System.Drawing.Point(277, 94);
            this.btnEcrire.Name = "btnEcrire";
            this.btnEcrire.Size = new System.Drawing.Size(186, 29);
            this.btnEcrire.TabIndex = 0;
            this.btnEcrire.Text = "Ecrire dans le fichier";
            this.btnEcrire.UseVisualStyleBackColor = true;
            this.btnEcrire.Click += new System.EventHandler(this.btnEcrire_Click);
            // 
            // btnLire
            // 
            this.btnLire.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLire.Location = new System.Drawing.Point(277, 268);
            this.btnLire.Name = "btnLire";
            this.btnLire.Size = new System.Drawing.Size(186, 29);
            this.btnLire.TabIndex = 1;
            this.btnLire.Text = "Lire dans le fichier";
            this.btnLire.UseVisualStyleBackColor = true;
            this.btnLire.Click += new System.EventHandler(this.btnLire_Click);
            // 
            // textEcrire
            // 
            this.textEcrire.Location = new System.Drawing.Point(79, 50);
            this.textEcrire.Multiline = true;
            this.textEcrire.Name = "textEcrire";
            this.textEcrire.Size = new System.Drawing.Size(146, 112);
            this.textEcrire.TabIndex = 2;
            // 
            // textLire
            // 
            this.textLire.Location = new System.Drawing.Point(79, 215);
            this.textLire.Multiline = true;
            this.textLire.Name = "textLire";
            this.textLire.Size = new System.Drawing.Size(146, 112);
            this.textLire.TabIndex = 3;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 450);
            this.Controls.Add(this.textLire);
            this.Controls.Add(this.textEcrire);
            this.Controls.Add(this.btnLire);
            this.Controls.Add(this.btnEcrire);
            this.Name = "Form1";
            this.Text = "Files";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnEcrire;
        private Button btnLire;
        private TextBox textEcrire;
        private TextBox textLire;
        private SaveFileDialog saveFileDialog1;
        private OpenFileDialog openFileDialog1;
    }
}