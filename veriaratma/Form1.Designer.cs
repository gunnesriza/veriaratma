namespace veriaratma
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.bulbutton = new System.Windows.Forms.Button();
            this.txtarama = new System.Windows.Forms.TextBox();
            this.veri = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bulbutton
            // 
            this.bulbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bulbutton.Location = new System.Drawing.Point(255, 74);
            this.bulbutton.Name = "bulbutton";
            this.bulbutton.Size = new System.Drawing.Size(108, 39);
            this.bulbutton.TabIndex = 0;
            this.bulbutton.Text = "BUL";
            this.bulbutton.UseVisualStyleBackColor = true;
            this.bulbutton.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtarama
            // 
            this.txtarama.Location = new System.Drawing.Point(54, 82);
            this.txtarama.Name = "txtarama";
            this.txtarama.Size = new System.Drawing.Size(168, 22);
            this.txtarama.TabIndex = 1;
            // 
            // veri
            // 
            this.veri.FormattingEnabled = true;
            this.veri.ItemHeight = 16;
            this.veri.Location = new System.Drawing.Point(114, 137);
            this.veri.Name = "veri";
            this.veri.Size = new System.Drawing.Size(194, 372);
            this.veri.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(110, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Aradığınız metni giriniz.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(430, 579);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.veri);
            this.Controls.Add(this.txtarama);
            this.Controls.Add(this.bulbutton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bulbutton;
        private System.Windows.Forms.TextBox txtarama;
        private System.Windows.Forms.ListBox veri;
        private System.Windows.Forms.Label label1;
    }
}

