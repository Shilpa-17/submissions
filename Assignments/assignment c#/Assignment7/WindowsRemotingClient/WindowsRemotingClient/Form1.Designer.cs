
namespace WindowsRemotingClient
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
            this.num1 = new System.Windows.Forms.Label();
            this.num2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnHighest = new System.Windows.Forms.Button();
            this.textResult = new System.Windows.Forms.TextBox();
            this.btnSmallest = new System.Windows.Forms.Button();
            this.btnMul = new System.Windows.Forms.Button();
            this.btnRem = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // num1
            // 
            this.num1.AutoSize = true;
            this.num1.Location = new System.Drawing.Point(318, 64);
            this.num1.Name = "num1";
            this.num1.Size = new System.Drawing.Size(90, 20);
            this.num1.TabIndex = 0;
            this.num1.Text = "enter num1";
            // 
            // num2
            // 
            this.num2.AutoSize = true;
            this.num2.Location = new System.Drawing.Point(318, 151);
            this.num2.Name = "num2";
            this.num2.Size = new System.Drawing.Size(90, 20);
            this.num2.TabIndex = 1;
            this.num2.Text = "enter num2";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(30, 58);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(245, 26);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(30, 145);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(237, 26);
            this.textBox2.TabIndex = 3;
            // 
            // btnHighest
            // 
            this.btnHighest.Location = new System.Drawing.Point(12, 279);
            this.btnHighest.Name = "btnHighest";
            this.btnHighest.Size = new System.Drawing.Size(177, 61);
            this.btnHighest.TabIndex = 4;
            this.btnHighest.Text = "Highest Number";
            this.btnHighest.UseVisualStyleBackColor = true;
            this.btnHighest.Click += new System.EventHandler(this.btnHighest_Click);
            // 
            // textResult
            // 
            this.textResult.Location = new System.Drawing.Point(457, 94);
            this.textResult.Name = "textResult";
            this.textResult.Size = new System.Drawing.Size(210, 26);
            this.textResult.TabIndex = 5;
            // 
            // btnSmallest
            // 
            this.btnSmallest.Location = new System.Drawing.Point(227, 279);
            this.btnSmallest.Name = "btnSmallest";
            this.btnSmallest.Size = new System.Drawing.Size(169, 61);
            this.btnSmallest.TabIndex = 6;
            this.btnSmallest.Text = "Smallest Number";
            this.btnSmallest.UseVisualStyleBackColor = true;
            this.btnSmallest.Click += new System.EventHandler(this.btnSmallest_Click);
            // 
            // btnMul
            // 
            this.btnMul.Location = new System.Drawing.Point(418, 279);
            this.btnMul.Name = "btnMul";
            this.btnMul.Size = new System.Drawing.Size(186, 64);
            this.btnMul.TabIndex = 7;
            this.btnMul.Text = "Multiplication";
            this.btnMul.UseVisualStyleBackColor = true;
            this.btnMul.Click += new System.EventHandler(this.btnMul_Click);
            // 
            // btnRem
            // 
            this.btnRem.Location = new System.Drawing.Point(640, 279);
            this.btnRem.Name = "btnRem";
            this.btnRem.Size = new System.Drawing.Size(164, 61);
            this.btnRem.TabIndex = 8;
            this.btnRem.Text = "Reminder";
            this.btnRem.UseVisualStyleBackColor = true;
            this.btnRem.Click += new System.EventHandler(this.btnRem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 538);
            this.Controls.Add(this.btnRem);
            this.Controls.Add(this.btnMul);
            this.Controls.Add(this.btnSmallest);
            this.Controls.Add(this.textResult);
            this.Controls.Add(this.btnHighest);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.num2);
            this.Controls.Add(this.num1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label num1;
        private System.Windows.Forms.Label num2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btnHighest;
        private System.Windows.Forms.TextBox textResult;
        private System.Windows.Forms.Button btnSmallest;
        private System.Windows.Forms.Button btnMul;
        private System.Windows.Forms.Button btnRem;
    }
}

