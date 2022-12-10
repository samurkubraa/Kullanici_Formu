namespace KullaniciFormu
{
    partial class UserDelete
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
            this.btnsil = new System.Windows.Forms.Button();
            this.deletead = new System.Windows.Forms.TextBox();
            this.lblupdate = new System.Windows.Forms.Label();
            this.dgwupdate = new System.Windows.Forms.DataGridView();
            this.btnupdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwupdate)).BeginInit();
            this.SuspendLayout();
            // 
            // btnsil
            // 
            this.btnsil.Location = new System.Drawing.Point(92, 72);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(100, 23);
            this.btnsil.TabIndex = 18;
            this.btnsil.Text = "Sil";
            this.btnsil.UseVisualStyleBackColor = true;
            this.btnsil.Click += new System.EventHandler(this.btnsil_Click);
            // 
            // deletead
            // 
            this.deletead.Location = new System.Drawing.Point(92, 32);
            this.deletead.Name = "deletead";
            this.deletead.Size = new System.Drawing.Size(100, 20);
            this.deletead.TabIndex = 17;
            // 
            // lblupdate
            // 
            this.lblupdate.AutoSize = true;
            this.lblupdate.Location = new System.Drawing.Point(35, 39);
            this.lblupdate.Name = "lblupdate";
            this.lblupdate.Size = new System.Drawing.Size(20, 13);
            this.lblupdate.TabIndex = 16;
            this.lblupdate.Text = "Ad";
            // 
            // dgwupdate
            // 
            this.dgwupdate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwupdate.Location = new System.Drawing.Point(226, 32);
            this.dgwupdate.Name = "dgwupdate";
            this.dgwupdate.Size = new System.Drawing.Size(240, 241);
            this.dgwupdate.TabIndex = 19;
            // 
            // btnupdate
            // 
            this.btnupdate.Location = new System.Drawing.Point(92, 112);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(100, 23);
            this.btnupdate.TabIndex = 20;
            this.btnupdate.Text = "Kullanıcıları Listele";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // UserDelete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 365);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.dgwupdate);
            this.Controls.Add(this.btnsil);
            this.Controls.Add(this.deletead);
            this.Controls.Add(this.lblupdate);
            this.Name = "UserDelete";
            this.Text = "UserDelete";
            ((System.ComponentModel.ISupportInitialize)(this.dgwupdate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnsil;
        private System.Windows.Forms.TextBox deletead;
        private System.Windows.Forms.Label lblupdate;
        private System.Windows.Forms.DataGridView dgwupdate;
        private System.Windows.Forms.Button btnupdate;
    }
}