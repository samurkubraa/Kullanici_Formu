namespace KullaniciFormu
{
    partial class UserUpdate
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
            this.lblupdate = new System.Windows.Forms.Label();
            this.adupdate = new System.Windows.Forms.TextBox();
            this.btnupdate = new System.Windows.Forms.Button();
            this.soyadupdate = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dgwupdate = new System.Windows.Forms.DataGridView();
            this.btnlistele = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwupdate)).BeginInit();
            this.SuspendLayout();
            // 
            // lblupdate
            // 
            this.lblupdate.AutoSize = true;
            this.lblupdate.Location = new System.Drawing.Point(64, 70);
            this.lblupdate.Name = "lblupdate";
            this.lblupdate.Size = new System.Drawing.Size(20, 13);
            this.lblupdate.TabIndex = 0;
            this.lblupdate.Text = "Ad";
            // 
            // adupdate
            // 
            this.adupdate.Location = new System.Drawing.Point(149, 63);
            this.adupdate.Name = "adupdate";
            this.adupdate.Size = new System.Drawing.Size(100, 20);
            this.adupdate.TabIndex = 1;
            // 
            // btnupdate
            // 
            this.btnupdate.Location = new System.Drawing.Point(149, 281);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(100, 23);
            this.btnupdate.TabIndex = 2;
            this.btnupdate.Text = "Güncelle";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // soyadupdate
            // 
            this.soyadupdate.Location = new System.Drawing.Point(149, 108);
            this.soyadupdate.Name = "soyadupdate";
            this.soyadupdate.Size = new System.Drawing.Size(100, 20);
            this.soyadupdate.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Soyad";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(149, 243);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(64, 247);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Şifre";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(149, 202);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(64, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "E Mail";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(149, 160);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Kullanıcı Adı";
            // 
            // dgwupdate
            // 
            this.dgwupdate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwupdate.Location = new System.Drawing.Point(322, 63);
            this.dgwupdate.Name = "dgwupdate";
            this.dgwupdate.Size = new System.Drawing.Size(240, 241);
            this.dgwupdate.TabIndex = 16;
            // 
            // btnlistele
            // 
            this.btnlistele.Location = new System.Drawing.Point(149, 320);
            this.btnlistele.Name = "btnlistele";
            this.btnlistele.Size = new System.Drawing.Size(100, 23);
            this.btnlistele.TabIndex = 17;
            this.btnlistele.Text = "Kullanıcıları Listele";
            this.btnlistele.UseVisualStyleBackColor = true;
            this.btnlistele.Click += new System.EventHandler(this.btnlistele_Click);
            // 
            // UserUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnlistele);
            this.Controls.Add(this.dgwupdate);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.soyadupdate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.adupdate);
            this.Controls.Add(this.lblupdate);
            this.Name = "UserUpdate";
            this.Text = "UserUpdate";
            ((System.ComponentModel.ISupportInitialize)(this.dgwupdate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblupdate;
        private System.Windows.Forms.TextBox adupdate;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.TextBox soyadupdate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgwupdate;
        private System.Windows.Forms.Button btnlistele;
    }
}