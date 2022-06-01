
namespace TahminOyunu
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
            this.random1 = new System.Windows.Forms.Label();
            this.random2 = new System.Windows.Forms.Label();
            this.random3 = new System.Windows.Forms.Label();
            this.random4 = new System.Windows.Forms.Label();
            this.tahmin1 = new System.Windows.Forms.TextBox();
            this.tahmin2 = new System.Windows.Forms.TextBox();
            this.tahmin3 = new System.Windows.Forms.TextBox();
            this.tahmin4 = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // random1
            // 
            this.random1.AutoSize = true;
            this.random1.Location = new System.Drawing.Point(30, 22);
            this.random1.Name = "random1";
            this.random1.Size = new System.Drawing.Size(50, 20);
            this.random1.TabIndex = 0;
            this.random1.Text = "label1";
            // 
            // random2
            // 
            this.random2.AutoSize = true;
            this.random2.Location = new System.Drawing.Point(86, 22);
            this.random2.Name = "random2";
            this.random2.Size = new System.Drawing.Size(50, 20);
            this.random2.TabIndex = 1;
            this.random2.Text = "label2";
            // 
            // random3
            // 
            this.random3.AutoSize = true;
            this.random3.Location = new System.Drawing.Point(142, 22);
            this.random3.Name = "random3";
            this.random3.Size = new System.Drawing.Size(50, 20);
            this.random3.TabIndex = 2;
            this.random3.Text = "label3";
            // 
            // random4
            // 
            this.random4.AutoSize = true;
            this.random4.Location = new System.Drawing.Point(198, 22);
            this.random4.Name = "random4";
            this.random4.Size = new System.Drawing.Size(50, 20);
            this.random4.TabIndex = 3;
            this.random4.Text = "label4";
            // 
            // tahmin1
            // 
            this.tahmin1.Location = new System.Drawing.Point(30, 66);
            this.tahmin1.Name = "tahmin1";
            this.tahmin1.Size = new System.Drawing.Size(50, 27);
            this.tahmin1.TabIndex = 4;
            // 
            // tahmin2
            // 
            this.tahmin2.Location = new System.Drawing.Point(86, 66);
            this.tahmin2.Name = "tahmin2";
            this.tahmin2.Size = new System.Drawing.Size(50, 27);
            this.tahmin2.TabIndex = 5;
            // 
            // tahmin3
            // 
            this.tahmin3.Location = new System.Drawing.Point(142, 66);
            this.tahmin3.Name = "tahmin3";
            this.tahmin3.Size = new System.Drawing.Size(50, 27);
            this.tahmin3.TabIndex = 6;
            // 
            // tahmin4
            // 
            this.tahmin4.Location = new System.Drawing.Point(198, 66);
            this.tahmin4.Name = "tahmin4";
            this.tahmin4.Size = new System.Drawing.Size(50, 27);
            this.tahmin4.TabIndex = 7;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(30, 226);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(218, 84);
            this.listBox1.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(30, 175);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(218, 35);
            this.button1.TabIndex = 9;
            this.button1.Text = "Kontrol Et!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 403);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(106, 35);
            this.button2.TabIndex = 15;
            this.button2.Text = "Sayı Tut!";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(28, 329);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(219, 35);
            this.button3.TabIndex = 16;
            this.button3.Text = "Temizle!";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.tahmin4);
            this.Controls.Add(this.tahmin3);
            this.Controls.Add(this.tahmin2);
            this.Controls.Add(this.tahmin1);
            this.Controls.Add(this.random4);
            this.Controls.Add(this.random3);
            this.Controls.Add(this.random2);
            this.Controls.Add(this.random1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label random1;
        private System.Windows.Forms.Label random2;
        private System.Windows.Forms.Label random3;
        private System.Windows.Forms.Label random4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox tahmin2;
        private System.Windows.Forms.TextBox tahmin3;
        private System.Windows.Forms.TextBox tahmin4;
        private System.Windows.Forms.TextBox tahmin1;
    }
}

