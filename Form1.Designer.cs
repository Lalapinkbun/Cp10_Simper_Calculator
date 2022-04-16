namespace Practice_10_3
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
            this.btnPlus = new System.Windows.Forms.RadioButton();
            this.btnMinus = new System.Windows.Forms.RadioButton();
            this.btnMultiply = new System.Windows.Forms.RadioButton();
            this.btnDivide = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMath1 = new System.Windows.Forms.TextBox();
            this.txtMath2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnWhat = new System.Windows.Forms.Button();
            this.btnMath = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPlus
            // 
            this.btnPlus.AutoSize = true;
            this.btnPlus.Location = new System.Drawing.Point(37, 29);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(31, 17);
            this.btnPlus.TabIndex = 0;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = true;
            // 
            // btnMinus
            // 
            this.btnMinus.AutoSize = true;
            this.btnMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinus.Location = new System.Drawing.Point(74, 29);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(29, 17);
            this.btnMinus.TabIndex = 1;
            this.btnMinus.TabStop = true;
            this.btnMinus.Text = "-";
            this.btnMinus.UseVisualStyleBackColor = true;
            // 
            // btnMultiply
            // 
            this.btnMultiply.AutoSize = true;
            this.btnMultiply.Location = new System.Drawing.Point(109, 29);
            this.btnMultiply.Name = "btnMultiply";
            this.btnMultiply.Size = new System.Drawing.Size(29, 17);
            this.btnMultiply.TabIndex = 2;
            this.btnMultiply.TabStop = true;
            this.btnMultiply.Text = "*";
            this.btnMultiply.UseVisualStyleBackColor = true;
            // 
            // btnDivide
            // 
            this.btnDivide.AutoSize = true;
            this.btnDivide.Location = new System.Drawing.Point(144, 29);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(30, 17);
            this.btnDivide.TabIndex = 3;
            this.btnDivide.TabStop = true;
            this.btnDivide.Text = "/";
            this.btnDivide.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "数值一：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "数值二：";
            // 
            // txtMath1
            // 
            this.txtMath1.Location = new System.Drawing.Point(74, 62);
            this.txtMath1.Name = "txtMath1";
            this.txtMath1.Size = new System.Drawing.Size(100, 20);
            this.txtMath1.TabIndex = 6;
            // 
            // txtMath2
            // 
            this.txtMath2.Location = new System.Drawing.Point(74, 88);
            this.txtMath2.Name = "txtMath2";
            this.txtMath2.Size = new System.Drawing.Size(100, 20);
            this.txtMath2.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(57, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "超简易计算机";
            // 
            // btnWhat
            // 
            this.btnWhat.Location = new System.Drawing.Point(12, 123);
            this.btnWhat.Name = "btnWhat";
            this.btnWhat.Size = new System.Drawing.Size(75, 23);
            this.btnWhat.TabIndex = 9;
            this.btnWhat.Text = "这是什么？";
            this.btnWhat.UseVisualStyleBackColor = true;
            this.btnWhat.Click += new System.EventHandler(this.btnWhat_Click);
            // 
            // btnMath
            // 
            this.btnMath.Location = new System.Drawing.Point(195, 9);
            this.btnMath.Name = "btnMath";
            this.btnMath.Size = new System.Drawing.Size(75, 137);
            this.btnMath.TabIndex = 10;
            this.btnMath.Text = "计算";
            this.btnMath.UseVisualStyleBackColor = true;
            this.btnMath.Click += new System.EventHandler(this.btnMath_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 158);
            this.Controls.Add(this.btnMath);
            this.Controls.Add(this.btnWhat);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMath2);
            this.Controls.Add(this.txtMath1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDivide);
            this.Controls.Add(this.btnMultiply);
            this.Controls.Add(this.btnMinus);
            this.Controls.Add(this.btnPlus);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton btnPlus;
        private System.Windows.Forms.RadioButton btnMinus;
        private System.Windows.Forms.RadioButton btnMultiply;
        private System.Windows.Forms.RadioButton btnDivide;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMath1;
        private System.Windows.Forms.TextBox txtMath2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnWhat;
        private System.Windows.Forms.Button btnMath;
    }
}

