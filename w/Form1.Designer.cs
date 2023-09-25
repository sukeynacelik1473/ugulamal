namespace w
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
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnbelirlinesneyisil = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.txtMeyve = new System.Windows.Forms.TextBox();
            this.lboxMeyveler = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(113, 157);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(107, 54);
            this.btnEkle.TabIndex = 0;
            this.btnEkle.Text = "ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnbelirlinesneyisil
            // 
            this.btnbelirlinesneyisil.Location = new System.Drawing.Point(113, 342);
            this.btnbelirlinesneyisil.Name = "btnbelirlinesneyisil";
            this.btnbelirlinesneyisil.Size = new System.Drawing.Size(107, 54);
            this.btnbelirlinesneyisil.TabIndex = 1;
            this.btnbelirlinesneyisil.Text = "belirli butonu sil";
            this.btnbelirlinesneyisil.UseVisualStyleBackColor = true;
            this.btnbelirlinesneyisil.Click += new System.EventHandler(this.btnbelirlinesneyisil_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(113, 243);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(107, 54);
            this.btnSil.TabIndex = 2;
            this.btnSil.Text = "sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // txtMeyve
            // 
            this.txtMeyve.Location = new System.Drawing.Point(113, 61);
            this.txtMeyve.Name = "txtMeyve";
            this.txtMeyve.Size = new System.Drawing.Size(182, 20);
            this.txtMeyve.TabIndex = 3;
            // 
            // lboxMeyveler
            // 
            this.lboxMeyveler.FormattingEnabled = true;
            this.lboxMeyveler.Location = new System.Drawing.Point(419, 145);
            this.lboxMeyveler.Name = "lboxMeyveler";
            this.lboxMeyveler.Size = new System.Drawing.Size(279, 212);
            this.lboxMeyveler.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lboxMeyveler);
            this.Controls.Add(this.txtMeyve);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnbelirlinesneyisil);
            this.Controls.Add(this.btnEkle);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnbelirlinesneyisil;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.TextBox txtMeyve;
        private System.Windows.Forms.ListBox lboxMeyveler;
    }
}

