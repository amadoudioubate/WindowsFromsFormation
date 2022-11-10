namespace _04_Calculatrices
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
            this.btnSomme = new System.Windows.Forms.Button();
            this.btnSoustraction = new System.Windows.Forms.Button();
            this.btnMultiplication = new System.Windows.Forms.Button();
            this.btnDivision = new System.Windows.Forms.Button();
            this.btnTrois = new System.Windows.Forms.Button();
            this.btnSix = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.btnEfface = new System.Windows.Forms.Button();
            this.btnDeux = new System.Windows.Forms.Button();
            this.btnUn = new System.Windows.Forms.Button();
            this.btnCinq = new System.Windows.Forms.Button();
            this.btnQuatre = new System.Windows.Forms.Button();
            this.btnHuit = new System.Windows.Forms.Button();
            this.btnSept = new System.Windows.Forms.Button();
            this.btnRetourEfface = new System.Windows.Forms.Button();
            this.btnEqual = new System.Windows.Forms.Button();
            this.btnNeuf = new System.Windows.Forms.Button();
            this.btnOnOff = new System.Windows.Forms.Button();
            this.textCalcul = new System.Windows.Forms.TextBox();
            this.textResult = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSomme);
            this.groupBox1.Controls.Add(this.btnSoustraction);
            this.groupBox1.Controls.Add(this.btnMultiplication);
            this.groupBox1.Controls.Add(this.btnDivision);
            this.groupBox1.Controls.Add(this.btnTrois);
            this.groupBox1.Controls.Add(this.btnSix);
            this.groupBox1.Controls.Add(this.button10);
            this.groupBox1.Controls.Add(this.btnEfface);
            this.groupBox1.Controls.Add(this.btnDeux);
            this.groupBox1.Controls.Add(this.btnUn);
            this.groupBox1.Controls.Add(this.btnCinq);
            this.groupBox1.Controls.Add(this.btnQuatre);
            this.groupBox1.Controls.Add(this.btnHuit);
            this.groupBox1.Controls.Add(this.btnSept);
            this.groupBox1.Controls.Add(this.btnRetourEfface);
            this.groupBox1.Controls.Add(this.btnEqual);
            this.groupBox1.Controls.Add(this.btnNeuf);
            this.groupBox1.Controls.Add(this.btnOnOff);
            this.groupBox1.Controls.Add(this.textCalcul);
            this.groupBox1.Controls.Add(this.textResult);
            this.groupBox1.Location = new System.Drawing.Point(40, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(347, 363);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // btnSomme
            // 
            this.btnSomme.Location = new System.Drawing.Point(244, 282);
            this.btnSomme.Name = "btnSomme";
            this.btnSomme.Size = new System.Drawing.Size(63, 29);
            this.btnSomme.TabIndex = 31;
            this.btnSomme.Text = "+";
            this.btnSomme.UseVisualStyleBackColor = true;
            this.btnSomme.Click += new System.EventHandler(this.btnSimpleKey_Click);
            // 
            // btnSoustraction
            // 
            this.btnSoustraction.Location = new System.Drawing.Point(244, 247);
            this.btnSoustraction.Name = "btnSoustraction";
            this.btnSoustraction.Size = new System.Drawing.Size(63, 29);
            this.btnSoustraction.TabIndex = 30;
            this.btnSoustraction.Text = "-";
            this.btnSoustraction.UseVisualStyleBackColor = true;
            this.btnSoustraction.Click += new System.EventHandler(this.btnSimpleKey_Click);
            // 
            // btnMultiplication
            // 
            this.btnMultiplication.Location = new System.Drawing.Point(244, 212);
            this.btnMultiplication.Name = "btnMultiplication";
            this.btnMultiplication.Size = new System.Drawing.Size(63, 29);
            this.btnMultiplication.TabIndex = 29;
            this.btnMultiplication.Text = "*";
            this.btnMultiplication.UseVisualStyleBackColor = true;
            this.btnMultiplication.Click += new System.EventHandler(this.btnSimpleKey_Click);
            // 
            // btnDivision
            // 
            this.btnDivision.Location = new System.Drawing.Point(244, 177);
            this.btnDivision.Name = "btnDivision";
            this.btnDivision.Size = new System.Drawing.Size(63, 29);
            this.btnDivision.TabIndex = 28;
            this.btnDivision.Text = "/";
            this.btnDivision.UseVisualStyleBackColor = true;
            this.btnDivision.Click += new System.EventHandler(this.btn_Operator);
            // 
            // btnTrois
            // 
            this.btnTrois.Location = new System.Drawing.Point(175, 281);
            this.btnTrois.Name = "btnTrois";
            this.btnTrois.Size = new System.Drawing.Size(63, 29);
            this.btnTrois.TabIndex = 27;
            this.btnTrois.Text = "3";
            this.btnTrois.UseVisualStyleBackColor = true;
            this.btnTrois.Click += new System.EventHandler(this.btnSimpleKey_Click);
            // 
            // btnSix
            // 
            this.btnSix.Location = new System.Drawing.Point(175, 247);
            this.btnSix.Name = "btnSix";
            this.btnSix.Size = new System.Drawing.Size(63, 29);
            this.btnSix.TabIndex = 26;
            this.btnSix.Text = "6";
            this.btnSix.UseVisualStyleBackColor = true;
            this.btnSix.Click += new System.EventHandler(this.btnSimpleKey_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(106, 316);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(63, 29);
            this.button10.TabIndex = 25;
            this.button10.Text = "0";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.btnSimpleKey_Click);
            // 
            // btnEfface
            // 
            this.btnEfface.Location = new System.Drawing.Point(37, 316);
            this.btnEfface.Name = "btnEfface";
            this.btnEfface.Size = new System.Drawing.Size(63, 29);
            this.btnEfface.TabIndex = 24;
            this.btnEfface.Text = "C";
            this.btnEfface.UseVisualStyleBackColor = true;
            this.btnEfface.Click += new System.EventHandler(this.btnEfface_Click);
            // 
            // btnDeux
            // 
            this.btnDeux.Location = new System.Drawing.Point(106, 282);
            this.btnDeux.Name = "btnDeux";
            this.btnDeux.Size = new System.Drawing.Size(63, 29);
            this.btnDeux.TabIndex = 23;
            this.btnDeux.Text = "2";
            this.btnDeux.UseVisualStyleBackColor = true;
            this.btnDeux.Click += new System.EventHandler(this.btnSimpleKey_Click);
            // 
            // btnUn
            // 
            this.btnUn.Location = new System.Drawing.Point(37, 282);
            this.btnUn.Name = "btnUn";
            this.btnUn.Size = new System.Drawing.Size(63, 29);
            this.btnUn.TabIndex = 22;
            this.btnUn.Text = "1";
            this.btnUn.UseVisualStyleBackColor = true;
            this.btnUn.Click += new System.EventHandler(this.btnSimpleKey_Click);
            // 
            // btnCinq
            // 
            this.btnCinq.Location = new System.Drawing.Point(106, 247);
            this.btnCinq.Name = "btnCinq";
            this.btnCinq.Size = new System.Drawing.Size(63, 29);
            this.btnCinq.TabIndex = 21;
            this.btnCinq.Text = "5";
            this.btnCinq.UseVisualStyleBackColor = true;
            this.btnCinq.Click += new System.EventHandler(this.btnSimpleKey_Click);
            // 
            // btnQuatre
            // 
            this.btnQuatre.Location = new System.Drawing.Point(37, 247);
            this.btnQuatre.Name = "btnQuatre";
            this.btnQuatre.Size = new System.Drawing.Size(63, 29);
            this.btnQuatre.TabIndex = 20;
            this.btnQuatre.Text = "4";
            this.btnQuatre.UseVisualStyleBackColor = true;
            this.btnQuatre.Click += new System.EventHandler(this.btnSimpleKey_Click);
            // 
            // btnHuit
            // 
            this.btnHuit.Location = new System.Drawing.Point(106, 212);
            this.btnHuit.Name = "btnHuit";
            this.btnHuit.Size = new System.Drawing.Size(63, 29);
            this.btnHuit.TabIndex = 19;
            this.btnHuit.Text = "8";
            this.btnHuit.UseVisualStyleBackColor = true;
            this.btnHuit.Click += new System.EventHandler(this.btnSimpleKey_Click);
            // 
            // btnSept
            // 
            this.btnSept.Location = new System.Drawing.Point(37, 212);
            this.btnSept.Name = "btnSept";
            this.btnSept.Size = new System.Drawing.Size(63, 29);
            this.btnSept.TabIndex = 18;
            this.btnSept.Text = "7";
            this.btnSept.UseVisualStyleBackColor = true;
            this.btnSept.Click += new System.EventHandler(this.btnSimpleKey_Click);
            // 
            // btnRetourEfface
            // 
            this.btnRetourEfface.Location = new System.Drawing.Point(175, 177);
            this.btnRetourEfface.Name = "btnRetourEfface";
            this.btnRetourEfface.Size = new System.Drawing.Size(63, 29);
            this.btnRetourEfface.TabIndex = 17;
            this.btnRetourEfface.Text = "<<<<";
            this.btnRetourEfface.UseVisualStyleBackColor = true;
            this.btnRetourEfface.Click += new System.EventHandler(this.btnRetourEfface_Click);
            // 
            // btnEqual
            // 
            this.btnEqual.Location = new System.Drawing.Point(175, 316);
            this.btnEqual.Name = "btnEqual";
            this.btnEqual.Size = new System.Drawing.Size(132, 29);
            this.btnEqual.TabIndex = 15;
            this.btnEqual.Text = "=";
            this.btnEqual.UseVisualStyleBackColor = true;
            // 
            // btnNeuf
            // 
            this.btnNeuf.Location = new System.Drawing.Point(175, 212);
            this.btnNeuf.Name = "btnNeuf";
            this.btnNeuf.Size = new System.Drawing.Size(63, 29);
            this.btnNeuf.TabIndex = 5;
            this.btnNeuf.Text = "9";
            this.btnNeuf.UseVisualStyleBackColor = true;
            this.btnNeuf.Click += new System.EventHandler(this.btnSimpleKey_Click);
            // 
            // btnOnOff
            // 
            this.btnOnOff.Location = new System.Drawing.Point(37, 177);
            this.btnOnOff.Name = "btnOnOff";
            this.btnOnOff.Size = new System.Drawing.Size(132, 29);
            this.btnOnOff.TabIndex = 2;
            this.btnOnOff.Text = "ON";
            this.btnOnOff.UseVisualStyleBackColor = true;
            this.btnOnOff.Click += new System.EventHandler(this.btnOnOff_Click);
            // 
            // textCalcul
            // 
            this.textCalcul.Location = new System.Drawing.Point(51, 115);
            this.textCalcul.Name = "textCalcul";
            this.textCalcul.Size = new System.Drawing.Size(240, 27);
            this.textCalcul.TabIndex = 1;
            // 
            // textResult
            // 
            this.textResult.Location = new System.Drawing.Point(37, 26);
            this.textResult.Multiline = true;
            this.textResult.Name = "textResult";
            this.textResult.Size = new System.Drawing.Size(270, 129);
            this.textResult.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Calculatrices";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private Button btnOnOff;
        private TextBox textCalcul;
        private TextBox textResult;
        private Button btnNeuf;
        private Button btnSomme;
        private Button btnSoustraction;
        private Button btnMultiplication;
        private Button btnDivision;
        private Button btnTrois;
        private Button btnSix;
        private Button button10;
        private Button btnEfface;
        private Button btnDeux;
        private Button btnUn;
        private Button btnCinq;
        private Button btnQuatre;
        private Button btnHuit;
        private Button btnSept;
        private Button btnRetourEfface;
        private Button btnEqual;
    }
}