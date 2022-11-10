namespace _05_Serialization
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
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnEffacer = new System.Windows.Forms.Button();
            this.textSolde = new System.Windows.Forms.TextBox();
            this.textNumero = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnRestaurerCSV = new System.Windows.Forms.Button();
            this.btnSauvegarderCSV = new System.Windows.Forms.Button();
            this.btnRestaurerJSON = new System.Windows.Forms.Button();
            this.btnSauvegarderJSON = new System.Windows.Forms.Button();
            this.btnRestaurerXML = new System.Windows.Forms.Button();
            this.btnSauvegarderXML = new System.Windows.Forms.Button();
            this.btnRestaurerBin = new System.Windows.Forms.Button();
            this.btnSauvegarderBin = new System.Windows.Forms.Button();
            this.lstAccounts = new System.Windows.Forms.ListBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAjouter);
            this.groupBox1.Controls.Add(this.btnEffacer);
            this.groupBox1.Controls.Add(this.textSolde);
            this.groupBox1.Controls.Add(this.textNumero);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(38, 193);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(264, 277);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gestion de compte";
            // 
            // btnAjouter
            // 
            this.btnAjouter.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAjouter.Location = new System.Drawing.Point(137, 186);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(107, 44);
            this.btnAjouter.TabIndex = 5;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // btnEffacer
            // 
            this.btnEffacer.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEffacer.Location = new System.Drawing.Point(17, 186);
            this.btnEffacer.Name = "btnEffacer";
            this.btnEffacer.Size = new System.Drawing.Size(79, 44);
            this.btnEffacer.TabIndex = 4;
            this.btnEffacer.Text = "Effacer";
            this.btnEffacer.UseVisualStyleBackColor = true;
            this.btnEffacer.Click += new System.EventHandler(this.btnEffacer_Click);
            // 
            // textSolde
            // 
            this.textSolde.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textSolde.Location = new System.Drawing.Point(105, 118);
            this.textSolde.Name = "textSolde";
            this.textSolde.Size = new System.Drawing.Size(139, 34);
            this.textSolde.TabIndex = 3;
            // 
            // textNumero
            // 
            this.textNumero.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textNumero.Location = new System.Drawing.Point(105, 52);
            this.textNumero.Name = "textNumero";
            this.textNumero.Size = new System.Drawing.Size(139, 34);
            this.textNumero.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(17, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Solde";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(17, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numéro";
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSupprimer.Location = new System.Drawing.Point(175, 132);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(127, 44);
            this.btnSupprimer.TabIndex = 6;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnRestaurerCSV);
            this.groupBox2.Controls.Add(this.btnSauvegarderCSV);
            this.groupBox2.Controls.Add(this.btnRestaurerJSON);
            this.groupBox2.Controls.Add(this.btnSauvegarderJSON);
            this.groupBox2.Controls.Add(this.btnRestaurerXML);
            this.groupBox2.Controls.Add(this.btnSauvegarderXML);
            this.groupBox2.Controls.Add(this.btnRestaurerBin);
            this.groupBox2.Controls.Add(this.btnSauvegarderBin);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.Location = new System.Drawing.Point(396, 24);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(292, 446);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Serialize";
            // 
            // btnRestaurerCSV
            // 
            this.btnRestaurerCSV.BackColor = System.Drawing.Color.Cyan;
            this.btnRestaurerCSV.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnRestaurerCSV.Location = new System.Drawing.Point(24, 396);
            this.btnRestaurerCSV.Name = "btnRestaurerCSV";
            this.btnRestaurerCSV.Size = new System.Drawing.Size(248, 35);
            this.btnRestaurerCSV.TabIndex = 7;
            this.btnRestaurerCSV.Text = "Restaurer CSV";
            this.btnRestaurerCSV.UseVisualStyleBackColor = false;
            this.btnRestaurerCSV.Click += new System.EventHandler(this.btnRestaurerCSV_Click);
            // 
            // btnSauvegarderCSV
            // 
            this.btnSauvegarderCSV.BackColor = System.Drawing.Color.Cyan;
            this.btnSauvegarderCSV.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSauvegarderCSV.Location = new System.Drawing.Point(24, 355);
            this.btnSauvegarderCSV.Name = "btnSauvegarderCSV";
            this.btnSauvegarderCSV.Size = new System.Drawing.Size(248, 35);
            this.btnSauvegarderCSV.TabIndex = 6;
            this.btnSauvegarderCSV.Text = "Sauvegarder CSV";
            this.btnSauvegarderCSV.UseVisualStyleBackColor = false;
            this.btnSauvegarderCSV.Click += new System.EventHandler(this.btnSauvegarderCSV_Click);
            // 
            // btnRestaurerJSON
            // 
            this.btnRestaurerJSON.BackColor = System.Drawing.Color.Yellow;
            this.btnRestaurerJSON.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnRestaurerJSON.Location = new System.Drawing.Point(24, 289);
            this.btnRestaurerJSON.Name = "btnRestaurerJSON";
            this.btnRestaurerJSON.Size = new System.Drawing.Size(248, 35);
            this.btnRestaurerJSON.TabIndex = 5;
            this.btnRestaurerJSON.Text = "Restaurer JSON";
            this.btnRestaurerJSON.UseVisualStyleBackColor = false;
            this.btnRestaurerJSON.Click += new System.EventHandler(this.btnRestaurerJSON_Click);
            // 
            // btnSauvegarderJSON
            // 
            this.btnSauvegarderJSON.BackColor = System.Drawing.Color.Yellow;
            this.btnSauvegarderJSON.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSauvegarderJSON.Location = new System.Drawing.Point(24, 246);
            this.btnSauvegarderJSON.Name = "btnSauvegarderJSON";
            this.btnSauvegarderJSON.Size = new System.Drawing.Size(248, 35);
            this.btnSauvegarderJSON.TabIndex = 4;
            this.btnSauvegarderJSON.Text = "Sauvegarder JSON";
            this.btnSauvegarderJSON.UseVisualStyleBackColor = false;
            this.btnSauvegarderJSON.Click += new System.EventHandler(this.btnSauvegarderJSON_Click);
            // 
            // btnRestaurerXML
            // 
            this.btnRestaurerXML.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnRestaurerXML.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnRestaurerXML.Location = new System.Drawing.Point(24, 186);
            this.btnRestaurerXML.Name = "btnRestaurerXML";
            this.btnRestaurerXML.Size = new System.Drawing.Size(248, 35);
            this.btnRestaurerXML.TabIndex = 3;
            this.btnRestaurerXML.Text = "Restaurer XML";
            this.btnRestaurerXML.UseVisualStyleBackColor = false;
            this.btnRestaurerXML.Click += new System.EventHandler(this.btnRestaurerXML_Click);
            // 
            // btnSauvegarderXML
            // 
            this.btnSauvegarderXML.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnSauvegarderXML.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnSauvegarderXML.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSauvegarderXML.Location = new System.Drawing.Point(24, 145);
            this.btnSauvegarderXML.Name = "btnSauvegarderXML";
            this.btnSauvegarderXML.Size = new System.Drawing.Size(248, 35);
            this.btnSauvegarderXML.TabIndex = 2;
            this.btnSauvegarderXML.Text = "Sauvegarder XML";
            this.btnSauvegarderXML.UseVisualStyleBackColor = false;
            this.btnSauvegarderXML.Click += new System.EventHandler(this.btnSauvegarderXML_Click);
            // 
            // btnRestaurerBin
            // 
            this.btnRestaurerBin.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnRestaurerBin.Location = new System.Drawing.Point(24, 84);
            this.btnRestaurerBin.Name = "btnRestaurerBin";
            this.btnRestaurerBin.Size = new System.Drawing.Size(248, 35);
            this.btnRestaurerBin.TabIndex = 1;
            this.btnRestaurerBin.Text = "Restaurer Bin";
            this.btnRestaurerBin.UseVisualStyleBackColor = true;
            this.btnRestaurerBin.Click += new System.EventHandler(this.btnRestaurerBin_Click);
            // 
            // btnSauvegarderBin
            // 
            this.btnSauvegarderBin.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSauvegarderBin.Location = new System.Drawing.Point(24, 43);
            this.btnSauvegarderBin.Name = "btnSauvegarderBin";
            this.btnSauvegarderBin.Size = new System.Drawing.Size(248, 35);
            this.btnSauvegarderBin.TabIndex = 0;
            this.btnSauvegarderBin.Text = "Sauvegarder Bin";
            this.btnSauvegarderBin.UseVisualStyleBackColor = true;
            this.btnSauvegarderBin.Click += new System.EventHandler(this.btnSauvegarderBin_Click);
            // 
            // lstAccounts
            // 
            this.lstAccounts.FormattingEnabled = true;
            this.lstAccounts.ItemHeight = 20;
            this.lstAccounts.Location = new System.Drawing.Point(38, 12);
            this.lstAccounts.Name = "lstAccounts";
            this.lstAccounts.Size = new System.Drawing.Size(264, 104);
            this.lstAccounts.TabIndex = 8;
            this.lstAccounts.SelectedIndexChanged += new System.EventHandler(this.lstAccounts_SelectedIndexChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 491);
            this.Controls.Add(this.lstAccounts);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Serialization";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private Button btnEffacer;
        private TextBox textSolde;
        private TextBox textNumero;
        private Label label2;
        private Label label1;
        private Button btnAjouter;
        private Button btnSupprimer;
        private GroupBox groupBox2;
        private ListBox lstAccounts;
        private Button btnRestaurerCSV;
        private Button btnSauvegarderCSV;
        private Button btnRestaurerJSON;
        private Button btnSauvegarderJSON;
        private Button btnRestaurerXML;
        private Button btnSauvegarderXML;
        private Button btnRestaurerBin;
        private Button btnSauvegarderBin;
        private SaveFileDialog saveFileDialog1;
        private OpenFileDialog openFileDialog1;
    }
}