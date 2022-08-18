using System;

namespace WindowsFormsAppactivity2converter
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
            this.convert = new System.Windows.Forms.Button();
            this.lblUSD = new System.Windows.Forms.Label();
            this.lblEuro = new System.Windows.Forms.Label();
            this.txtAmount1 = new System.Windows.Forms.TextBox();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.toUSD = new System.Windows.Forms.RadioButton();
            this.toEuro = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // convert
            // 
            this.convert.Location = new System.Drawing.Point(598, 190);
            this.convert.Name = "convert";
            this.convert.Size = new System.Drawing.Size(75, 23);
            this.convert.TabIndex = 0;
            this.convert.Text = "Convert";
            this.convert.UseVisualStyleBackColor = true;
            this.convert.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblUSD
            // 
            this.lblUSD.AutoSize = true;
            this.lblUSD.Location = new System.Drawing.Point(167, 110);
            this.lblUSD.Name = "lblUSD";
            this.lblUSD.Size = new System.Drawing.Size(43, 16);
            this.lblUSD.TabIndex = 1;
            this.lblUSD.Text = "USD$";
            this.lblUSD.Click += new System.EventHandler(this.lblUSD_Click);
            // 
            // lblEuro
            // 
            this.lblEuro.AutoSize = true;
            this.lblEuro.Location = new System.Drawing.Point(167, 221);
            this.lblEuro.Name = "lblEuro";
            this.lblEuro.Size = new System.Drawing.Size(46, 16);
            this.lblEuro.TabIndex = 2;
            this.lblEuro.Text = "EURO";
            this.lblEuro.Click += new System.EventHandler(this.lblUSD_Click);
            // 
            // txtAmount1
            // 
            this.txtAmount1.Location = new System.Drawing.Point(148, 250);
            this.txtAmount1.Name = "txtAmount1";
            this.txtAmount1.Size = new System.Drawing.Size(100, 22);
            this.txtAmount1.TabIndex = 3;
            this.txtAmount1.Text = "EnterAmount";
            this.txtAmount1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(148, 141);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(100, 22);
            this.txtAmount.TabIndex = 4;
            this.txtAmount.Text = "enterAmount";
            this.txtAmount.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // toUSD
            // 
            this.toUSD.AutoSize = true;
            this.toUSD.Location = new System.Drawing.Point(406, 127);
            this.toUSD.Name = "toUSD";
            this.toUSD.Size = new System.Drawing.Size(84, 20);
            this.toUSD.TabIndex = 7;
            this.toUSD.TabStop = true;
            this.toUSD.Text = "To USD$";
            this.toUSD.UseVisualStyleBackColor = true;
            this.toUSD.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // toEuro
            // 
            this.toEuro.AutoSize = true;
            this.toEuro.Location = new System.Drawing.Point(406, 251);
            this.toEuro.Name = "toEuro";
            this.toEuro.Size = new System.Drawing.Size(76, 20);
            this.toEuro.TabIndex = 8;
            this.toEuro.TabStop = true;
            this.toEuro.Text = "To Euro";
            this.toEuro.UseVisualStyleBackColor = true;
            this.toEuro.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toEuro);
            this.Controls.Add(this.toUSD);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.txtAmount1);
            this.Controls.Add(this.lblEuro);
            this.Controls.Add(this.lblUSD);
            this.Controls.Add(this.convert);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void lblUSD_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Button convert;
        private System.Windows.Forms.Label lblUSD;
        private System.Windows.Forms.Label lblEuro;
        private System.Windows.Forms.TextBox txtAmount1;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.RadioButton toUSD;
        private System.Windows.Forms.RadioButton toEuro;
    }
}

