﻿namespace Loggly.Example
{
    partial class MainForm
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
            this.btnPlainText = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPlainText
            // 
            this.btnPlainText.Location = new System.Drawing.Point(22, 29);
            this.btnPlainText.Name = "btnPlainText";
            this.btnPlainText.Size = new System.Drawing.Size(114, 23);
            this.btnPlainText.TabIndex = 0;
            this.btnPlainText.Text = "Plain text message";
            this.btnPlainText.UseVisualStyleBackColor = true;
            this.btnPlainText.Click += new System.EventHandler(this.btnPlainText_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 380);
            this.Controls.Add(this.btnPlainText);
            this.Name = "MainForm";
            this.Text = "Loggly Example Application";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPlainText;
    }
}

