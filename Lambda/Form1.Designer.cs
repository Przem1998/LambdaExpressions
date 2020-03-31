namespace Lambda
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
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.a = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.n = new System.Windows.Forms.TextBox();
            this.l_n = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.result = new System.Windows.Forms.Label();
            this.resultString = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.s2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.s1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.x = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.resultArray = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Wyrażenie a^n";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(96, 42);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Sprawdź";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // a
            // 
            this.a.Location = new System.Drawing.Point(31, 12);
            this.a.Name = "a";
            this.a.Size = new System.Drawing.Size(37, 20);
            this.a.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "a";
            // 
            // n
            // 
            this.n.Location = new System.Drawing.Point(134, 12);
            this.n.Name = "n";
            this.n.Size = new System.Drawing.Size(37, 20);
            this.n.TabIndex = 4;
            // 
            // l_n
            // 
            this.l_n.AutoSize = true;
            this.l_n.Location = new System.Drawing.Point(115, 15);
            this.l_n.Name = "l_n";
            this.l_n.Size = new System.Drawing.Size(13, 13);
            this.l_n.TabIndex = 5;
            this.l_n.Text = "n";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Wynik";
            // 
            // result
            // 
            this.result.AutoSize = true;
            this.result.Location = new System.Drawing.Point(55, 85);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(0, 13);
            this.result.TabIndex = 7;
            // 
            // resultString
            // 
            this.resultString.AutoSize = true;
            this.resultString.Location = new System.Drawing.Point(55, 192);
            this.resultString.Name = "resultString";
            this.resultString.Size = new System.Drawing.Size(0, 13);
            this.resultString.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Wynik";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(96, 122);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(13, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "b";
            // 
            // s2
            // 
            this.s2.Location = new System.Drawing.Point(115, 119);
            this.s2.Name = "s2";
            this.s2.Size = new System.Drawing.Size(56, 20);
            this.s2.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 122);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(13, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "a";
            // 
            // s1
            // 
            this.s1.Location = new System.Drawing.Point(31, 119);
            this.s1.Name = "s1";
            this.s1.Size = new System.Drawing.Size(59, 20);
            this.s1.TabIndex = 10;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(58, 145);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "Złącz";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(268, 52);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "x^i_10";
            // 
            // x
            // 
            this.x.Location = new System.Drawing.Point(312, 50);
            this.x.Name = "x";
            this.x.Size = new System.Drawing.Size(37, 20);
            this.x.TabIndex = 18;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(355, 47);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 17;
            this.button3.Text = "Sprawdź";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(268, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Tablica 10-elementowa";
            // 
            // resultArray
            // 
            this.resultArray.AutoSize = true;
            this.resultArray.Location = new System.Drawing.Point(416, 85);
            this.resultArray.Name = "resultArray";
            this.resultArray.Size = new System.Drawing.Size(0, 13);
            this.resultArray.TabIndex = 21;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.resultArray);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.x);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.resultString);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.s2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.s1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.result);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.l_n);
            this.Controls.Add(this.n);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.a);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Wyrażenie lambda";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox a;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox n;
        private System.Windows.Forms.Label l_n;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label result;
        private System.Windows.Forms.Label resultString;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox s2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox s1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox x;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label resultArray;
    }
}

