﻿namespace WindowsApp
{
    partial class Form2
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
            this.lblNota1 = new System.Windows.Forms.Label();
            this.lblNota2 = new System.Windows.Forms.Label();
            this.lblNota3 = new System.Windows.Forms.Label();
            this.lblNota4 = new System.Windows.Forms.Label();
            this.txtNota1 = new System.Windows.Forms.TextBox();
            this.txtNota2 = new System.Windows.Forms.TextBox();
            this.txtNota3 = new System.Windows.Forms.TextBox();
            this.txtNota4 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNota1
            // 
            this.lblNota1.AutoSize = true;
            this.lblNota1.Location = new System.Drawing.Point(45, 33);
            this.lblNota1.Name = "lblNota1";
            this.lblNota1.Size = new System.Drawing.Size(75, 25);
            this.lblNota1.TabIndex = 0;
            this.lblNota1.Text = "Nota 1:";
            // 
            // lblNota2
            // 
            this.lblNota2.AutoSize = true;
            this.lblNota2.Location = new System.Drawing.Point(45, 68);
            this.lblNota2.Name = "lblNota2";
            this.lblNota2.Size = new System.Drawing.Size(75, 25);
            this.lblNota2.TabIndex = 1;
            this.lblNota2.Text = "Nota 2:";
            // 
            // lblNota3
            // 
            this.lblNota3.AutoSize = true;
            this.lblNota3.Location = new System.Drawing.Point(45, 103);
            this.lblNota3.Name = "lblNota3";
            this.lblNota3.Size = new System.Drawing.Size(75, 25);
            this.lblNota3.TabIndex = 2;
            this.lblNota3.Text = "Nota 3:";
            // 
            // lblNota4
            // 
            this.lblNota4.AutoSize = true;
            this.lblNota4.Location = new System.Drawing.Point(45, 138);
            this.lblNota4.Name = "lblNota4";
            this.lblNota4.Size = new System.Drawing.Size(75, 25);
            this.lblNota4.TabIndex = 3;
            this.lblNota4.Text = "Nota 4:";
            // 
            // txtNota1
            // 
            this.txtNota1.Location = new System.Drawing.Point(133, 30);
            this.txtNota1.Name = "txtNota1";
            this.txtNota1.Size = new System.Drawing.Size(243, 29);
            this.txtNota1.TabIndex = 7;
            // 
            // txtNota2
            // 
            this.txtNota2.Location = new System.Drawing.Point(133, 65);
            this.txtNota2.Name = "txtNota2";
            this.txtNota2.Size = new System.Drawing.Size(243, 29);
            this.txtNota2.TabIndex = 8;
            // 
            // txtNota3
            // 
            this.txtNota3.Location = new System.Drawing.Point(133, 100);
            this.txtNota3.Name = "txtNota3";
            this.txtNota3.Size = new System.Drawing.Size(243, 29);
            this.txtNota3.TabIndex = 9;
            // 
            // txtNota4
            // 
            this.txtNota4.Location = new System.Drawing.Point(133, 135);
            this.txtNota4.Name = "txtNota4";
            this.txtNota4.Size = new System.Drawing.Size(243, 29);
            this.txtNota4.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(118, 194);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(188, 69);
            this.button1.TabIndex = 11;
            this.button1.Text = "Calcular";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 291);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtNota4);
            this.Controls.Add(this.txtNota3);
            this.Controls.Add(this.txtNota2);
            this.Controls.Add(this.txtNota1);
            this.Controls.Add(this.lblNota4);
            this.Controls.Add(this.lblNota3);
            this.Controls.Add(this.lblNota2);
            this.Controls.Add(this.lblNota1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNota1;
        private System.Windows.Forms.Label lblNota2;
        private System.Windows.Forms.Label lblNota3;
        private System.Windows.Forms.Label lblNota4;
        private System.Windows.Forms.TextBox txtNota1;
        private System.Windows.Forms.TextBox txtNota2;
        private System.Windows.Forms.TextBox txtNota3;
        private System.Windows.Forms.TextBox txtNota4;
        private System.Windows.Forms.Button button1;
    }
}