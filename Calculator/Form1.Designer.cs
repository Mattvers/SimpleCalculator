namespace Calculator
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.buttonZERO = new System.Windows.Forms.Button();
            this.buttonCE = new System.Windows.Forms.Button();
            this.buttonDOT = new System.Windows.Forms.Button();
            this.buttonPLUS = new System.Windows.Forms.Button();
            this.buttonRESULT = new System.Windows.Forms.Button();
            this.buttonONE = new System.Windows.Forms.Button();
            this.buttonFOUR = new System.Windows.Forms.Button();
            this.buttonSEVEN = new System.Windows.Forms.Button();
            this.buttonEIGHT = new System.Windows.Forms.Button();
            this.buttonFIVE = new System.Windows.Forms.Button();
            this.buttonTWO = new System.Windows.Forms.Button();
            this.buttonTHREE = new System.Windows.Forms.Button();
            this.buttonMINUS = new System.Windows.Forms.Button();
            this.buttonSIX = new System.Windows.Forms.Button();
            this.buttonCROSS = new System.Windows.Forms.Button();
            this.buttonC = new System.Windows.Forms.Button();
            this.buttonNINE = new System.Windows.Forms.Button();
            this.buttonDIV = new System.Windows.Forms.Button();
            this.labelText = new System.Windows.Forms.Label();
            this.textBoxOperationResult = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonZERO
            // 
            this.buttonZERO.Font = new System.Drawing.Font("Forte", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonZERO.Location = new System.Drawing.Point(12, 281);
            this.buttonZERO.Name = "buttonZERO";
            this.buttonZERO.Size = new System.Drawing.Size(106, 50);
            this.buttonZERO.TabIndex = 0;
            this.buttonZERO.Text = "0";
            this.buttonZERO.UseVisualStyleBackColor = true;
            this.buttonZERO.Click += new System.EventHandler(this.button_Click);
            // 
            // buttonCE
            // 
            this.buttonCE.Font = new System.Drawing.Font("Forte", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCE.Location = new System.Drawing.Point(236, 113);
            this.buttonCE.Name = "buttonCE";
            this.buttonCE.Size = new System.Drawing.Size(50, 50);
            this.buttonCE.TabIndex = 1;
            this.buttonCE.Text = "CE";
            this.buttonCE.UseVisualStyleBackColor = true;
            this.buttonCE.Click += new System.EventHandler(this.clear_Click);
            // 
            // buttonDOT
            // 
            this.buttonDOT.Font = new System.Drawing.Font("Forte", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDOT.Location = new System.Drawing.Point(124, 281);
            this.buttonDOT.Name = "buttonDOT";
            this.buttonDOT.Size = new System.Drawing.Size(50, 50);
            this.buttonDOT.TabIndex = 2;
            this.buttonDOT.Text = ",";
            this.buttonDOT.UseVisualStyleBackColor = true;
            this.buttonDOT.Click += new System.EventHandler(this.button_Click);
            // 
            // buttonPLUS
            // 
            this.buttonPLUS.Font = new System.Drawing.Font("Forte", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPLUS.Location = new System.Drawing.Point(180, 281);
            this.buttonPLUS.Name = "buttonPLUS";
            this.buttonPLUS.Size = new System.Drawing.Size(50, 50);
            this.buttonPLUS.TabIndex = 3;
            this.buttonPLUS.Text = "+";
            this.buttonPLUS.UseVisualStyleBackColor = true;
            this.buttonPLUS.Click += new System.EventHandler(this.operator_Click);
            // 
            // buttonRESULT
            // 
            this.buttonRESULT.Font = new System.Drawing.Font("Forte", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRESULT.Location = new System.Drawing.Point(236, 225);
            this.buttonRESULT.Name = "buttonRESULT";
            this.buttonRESULT.Size = new System.Drawing.Size(50, 106);
            this.buttonRESULT.TabIndex = 4;
            this.buttonRESULT.Text = "=";
            this.buttonRESULT.UseVisualStyleBackColor = true;
            this.buttonRESULT.Click += new System.EventHandler(this.buttonRESULT_Click);
            // 
            // buttonONE
            // 
            this.buttonONE.Font = new System.Drawing.Font("Forte", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonONE.Location = new System.Drawing.Point(12, 225);
            this.buttonONE.Name = "buttonONE";
            this.buttonONE.Size = new System.Drawing.Size(50, 50);
            this.buttonONE.TabIndex = 5;
            this.buttonONE.Text = "1";
            this.buttonONE.UseVisualStyleBackColor = true;
            this.buttonONE.Click += new System.EventHandler(this.button_Click);
            // 
            // buttonFOUR
            // 
            this.buttonFOUR.Font = new System.Drawing.Font("Forte", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFOUR.Location = new System.Drawing.Point(12, 169);
            this.buttonFOUR.Name = "buttonFOUR";
            this.buttonFOUR.Size = new System.Drawing.Size(50, 50);
            this.buttonFOUR.TabIndex = 6;
            this.buttonFOUR.Text = "4";
            this.buttonFOUR.UseVisualStyleBackColor = true;
            this.buttonFOUR.Click += new System.EventHandler(this.button_Click);
            // 
            // buttonSEVEN
            // 
            this.buttonSEVEN.Font = new System.Drawing.Font("Forte", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSEVEN.Location = new System.Drawing.Point(12, 113);
            this.buttonSEVEN.Name = "buttonSEVEN";
            this.buttonSEVEN.Size = new System.Drawing.Size(50, 50);
            this.buttonSEVEN.TabIndex = 7;
            this.buttonSEVEN.Text = "7";
            this.buttonSEVEN.UseVisualStyleBackColor = true;
            this.buttonSEVEN.Click += new System.EventHandler(this.button_Click);
            // 
            // buttonEIGHT
            // 
            this.buttonEIGHT.Font = new System.Drawing.Font("Forte", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEIGHT.Location = new System.Drawing.Point(68, 113);
            this.buttonEIGHT.Name = "buttonEIGHT";
            this.buttonEIGHT.Size = new System.Drawing.Size(50, 50);
            this.buttonEIGHT.TabIndex = 8;
            this.buttonEIGHT.Text = "8";
            this.buttonEIGHT.UseVisualStyleBackColor = true;
            this.buttonEIGHT.Click += new System.EventHandler(this.button_Click);
            // 
            // buttonFIVE
            // 
            this.buttonFIVE.Font = new System.Drawing.Font("Forte", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFIVE.Location = new System.Drawing.Point(68, 169);
            this.buttonFIVE.Name = "buttonFIVE";
            this.buttonFIVE.Size = new System.Drawing.Size(50, 50);
            this.buttonFIVE.TabIndex = 9;
            this.buttonFIVE.Text = "5";
            this.buttonFIVE.UseVisualStyleBackColor = true;
            this.buttonFIVE.Click += new System.EventHandler(this.button_Click);
            // 
            // buttonTWO
            // 
            this.buttonTWO.Font = new System.Drawing.Font("Forte", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTWO.Location = new System.Drawing.Point(68, 225);
            this.buttonTWO.Name = "buttonTWO";
            this.buttonTWO.Size = new System.Drawing.Size(50, 50);
            this.buttonTWO.TabIndex = 10;
            this.buttonTWO.Text = "2";
            this.buttonTWO.UseVisualStyleBackColor = true;
            this.buttonTWO.Click += new System.EventHandler(this.button_Click);
            // 
            // buttonTHREE
            // 
            this.buttonTHREE.Font = new System.Drawing.Font("Forte", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTHREE.Location = new System.Drawing.Point(124, 225);
            this.buttonTHREE.Name = "buttonTHREE";
            this.buttonTHREE.Size = new System.Drawing.Size(50, 50);
            this.buttonTHREE.TabIndex = 11;
            this.buttonTHREE.Text = "3";
            this.buttonTHREE.UseVisualStyleBackColor = true;
            this.buttonTHREE.Click += new System.EventHandler(this.button_Click);
            // 
            // buttonMINUS
            // 
            this.buttonMINUS.Font = new System.Drawing.Font("Forte", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMINUS.Location = new System.Drawing.Point(180, 225);
            this.buttonMINUS.Name = "buttonMINUS";
            this.buttonMINUS.Size = new System.Drawing.Size(50, 50);
            this.buttonMINUS.TabIndex = 12;
            this.buttonMINUS.Text = "-";
            this.buttonMINUS.UseVisualStyleBackColor = true;
            this.buttonMINUS.Click += new System.EventHandler(this.operator_Click);
            // 
            // buttonSIX
            // 
            this.buttonSIX.Font = new System.Drawing.Font("Forte", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSIX.Location = new System.Drawing.Point(124, 169);
            this.buttonSIX.Name = "buttonSIX";
            this.buttonSIX.Size = new System.Drawing.Size(50, 50);
            this.buttonSIX.TabIndex = 13;
            this.buttonSIX.Text = "6";
            this.buttonSIX.UseVisualStyleBackColor = true;
            this.buttonSIX.Click += new System.EventHandler(this.button_Click);
            // 
            // buttonCROSS
            // 
            this.buttonCROSS.Font = new System.Drawing.Font("Forte", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCROSS.Location = new System.Drawing.Point(180, 169);
            this.buttonCROSS.Name = "buttonCROSS";
            this.buttonCROSS.Size = new System.Drawing.Size(50, 50);
            this.buttonCROSS.TabIndex = 14;
            this.buttonCROSS.Text = "*";
            this.buttonCROSS.UseVisualStyleBackColor = true;
            this.buttonCROSS.Click += new System.EventHandler(this.operator_Click);
            // 
            // buttonC
            // 
            this.buttonC.Font = new System.Drawing.Font("Forte", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonC.Location = new System.Drawing.Point(236, 169);
            this.buttonC.Name = "buttonC";
            this.buttonC.Size = new System.Drawing.Size(50, 50);
            this.buttonC.TabIndex = 15;
            this.buttonC.Text = "C";
            this.buttonC.UseVisualStyleBackColor = true;
            this.buttonC.Click += new System.EventHandler(this.clear_Click);
            // 
            // buttonNINE
            // 
            this.buttonNINE.Font = new System.Drawing.Font("Forte", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNINE.Location = new System.Drawing.Point(124, 113);
            this.buttonNINE.Name = "buttonNINE";
            this.buttonNINE.Size = new System.Drawing.Size(50, 50);
            this.buttonNINE.TabIndex = 16;
            this.buttonNINE.Text = "9";
            this.buttonNINE.UseVisualStyleBackColor = true;
            this.buttonNINE.Click += new System.EventHandler(this.button_Click);
            // 
            // buttonDIV
            // 
            this.buttonDIV.Font = new System.Drawing.Font("Forte", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDIV.Location = new System.Drawing.Point(180, 113);
            this.buttonDIV.Name = "buttonDIV";
            this.buttonDIV.Size = new System.Drawing.Size(50, 50);
            this.buttonDIV.TabIndex = 17;
            this.buttonDIV.Text = "/";
            this.buttonDIV.UseVisualStyleBackColor = true;
            this.buttonDIV.Click += new System.EventHandler(this.operator_Click);
            // 
            // labelText
            // 
            this.labelText.AutoSize = true;
            this.labelText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelText.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.labelText.Location = new System.Drawing.Point(12, 34);
            this.labelText.Name = "labelText";
            this.labelText.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelText.Size = new System.Drawing.Size(0, 20);
            this.labelText.TabIndex = 18;
            this.labelText.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBoxOperationResult
            // 
            this.textBoxOperationResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxOperationResult.Location = new System.Drawing.Point(12, 69);
            this.textBoxOperationResult.Name = "textBoxOperationResult";
            this.textBoxOperationResult.Size = new System.Drawing.Size(274, 38);
            this.textBoxOperationResult.TabIndex = 19;
            this.textBoxOperationResult.Text = "0";
            this.textBoxOperationResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 343);
            this.Controls.Add(this.textBoxOperationResult);
            this.Controls.Add(this.labelText);
            this.Controls.Add(this.buttonDIV);
            this.Controls.Add(this.buttonNINE);
            this.Controls.Add(this.buttonC);
            this.Controls.Add(this.buttonCROSS);
            this.Controls.Add(this.buttonSIX);
            this.Controls.Add(this.buttonMINUS);
            this.Controls.Add(this.buttonTHREE);
            this.Controls.Add(this.buttonTWO);
            this.Controls.Add(this.buttonFIVE);
            this.Controls.Add(this.buttonEIGHT);
            this.Controls.Add(this.buttonSEVEN);
            this.Controls.Add(this.buttonFOUR);
            this.Controls.Add(this.buttonONE);
            this.Controls.Add(this.buttonRESULT);
            this.Controls.Add(this.buttonPLUS);
            this.Controls.Add(this.buttonDOT);
            this.Controls.Add(this.buttonCE);
            this.Controls.Add(this.buttonZERO);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kalkulator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonZERO;
        private System.Windows.Forms.Button buttonCE;
        private System.Windows.Forms.Button buttonDOT;
        private System.Windows.Forms.Button buttonPLUS;
        private System.Windows.Forms.Button buttonRESULT;
        private System.Windows.Forms.Button buttonONE;
        private System.Windows.Forms.Button buttonFOUR;
        private System.Windows.Forms.Button buttonSEVEN;
        private System.Windows.Forms.Button buttonEIGHT;
        private System.Windows.Forms.Button buttonFIVE;
        private System.Windows.Forms.Button buttonTWO;
        private System.Windows.Forms.Button buttonTHREE;
        private System.Windows.Forms.Button buttonMINUS;
        private System.Windows.Forms.Button buttonSIX;
        private System.Windows.Forms.Button buttonCROSS;
        private System.Windows.Forms.Button buttonC;
        private System.Windows.Forms.Button buttonNINE;
        private System.Windows.Forms.Button buttonDIV;
        private System.Windows.Forms.Label labelText;
        private System.Windows.Forms.TextBox textBoxOperationResult;
    }
}

