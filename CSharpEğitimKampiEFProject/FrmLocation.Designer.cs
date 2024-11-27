namespace CSharpEğitimKampiEFProject
{
    partial class FrmLocation
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
            this.BtnGetById = new System.Windows.Forms.Button();
            this.BtnEkle = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.txtÜlke = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSehir = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnLİstele = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFiyat = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtGünGece = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbRehber = new System.Windows.Forms.ComboBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnGetById
            // 
            this.BtnGetById.Location = new System.Drawing.Point(316, 607);
            this.BtnGetById.Name = "BtnGetById";
            this.BtnGetById.Size = new System.Drawing.Size(125, 60);
            this.BtnGetById.TabIndex = 23;
            this.BtnGetById.Text = "Id Göre Getir";
            this.BtnGetById.UseVisualStyleBackColor = true;
            // 
            // BtnEkle
            // 
            this.BtnEkle.Location = new System.Drawing.Point(47, 606);
            this.BtnEkle.Name = "BtnEkle";
            this.BtnEkle.Size = new System.Drawing.Size(125, 57);
            this.BtnEkle.TabIndex = 22;
            this.BtnEkle.Text = "Ekle";
            this.BtnEkle.UseVisualStyleBackColor = true;
            this.BtnEkle.Click += new System.EventHandler(this.BtnEkle_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Location = new System.Drawing.Point(185, 607);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(125, 57);
            this.BtnDelete.TabIndex = 21;
            this.BtnDelete.Text = "Sil";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.Location = new System.Drawing.Point(185, 532);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(125, 57);
            this.BtnUpdate.TabIndex = 20;
            this.BtnUpdate.Text = "Güncelle";
            this.BtnUpdate.UseVisualStyleBackColor = true;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // txtÜlke
            // 
            this.txtÜlke.Location = new System.Drawing.Point(193, 237);
            this.txtÜlke.Name = "txtÜlke";
            this.txtÜlke.Size = new System.Drawing.Size(100, 29);
            this.txtÜlke.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 237);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 25);
            this.label3.TabIndex = 18;
            this.label3.Text = "Ülke:";
            // 
            // txtSehir
            // 
            this.txtSehir.Location = new System.Drawing.Point(193, 185);
            this.txtSehir.Name = "txtSehir";
            this.txtSehir.Size = new System.Drawing.Size(100, 29);
            this.txtSehir.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 25);
            this.label2.TabIndex = 16;
            this.label2.Text = "Şehir:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(359, 131);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 72;
            this.dataGridView1.RowTemplate.Height = 31;
            this.dataGridView1.Size = new System.Drawing.Size(745, 444);
            this.dataGridView1.TabIndex = 15;
            // 
            // btnLİstele
            // 
            this.btnLİstele.Location = new System.Drawing.Point(47, 532);
            this.btnLİstele.Name = "btnLİstele";
            this.btnLİstele.Size = new System.Drawing.Size(125, 57);
            this.btnLİstele.TabIndex = 14;
            this.btnLİstele.Text = "Lİstele";
            this.btnLİstele.UseVisualStyleBackColor = true;
            this.btnLİstele.Click += new System.EventHandler(this.btnLİstele_Click);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(193, 140);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 29);
            this.txtId.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 25);
            this.label1.TabIndex = 12;
            this.label1.Text = "Lokasyon Id:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 286);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 25);
            this.label4.TabIndex = 24;
            this.label4.Text = "Kapasite:";
            // 
            // txtFiyat
            // 
            this.txtFiyat.Location = new System.Drawing.Point(200, 329);
            this.txtFiyat.Name = "txtFiyat";
            this.txtFiyat.Size = new System.Drawing.Size(100, 29);
            this.txtFiyat.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 329);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 25);
            this.label5.TabIndex = 26;
            this.label5.Text = "Fiyat:";
            // 
            // txtGünGece
            // 
            this.txtGünGece.Location = new System.Drawing.Point(203, 373);
            this.txtGünGece.Name = "txtGünGece";
            this.txtGünGece.Size = new System.Drawing.Size(100, 29);
            this.txtGünGece.TabIndex = 29;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(36, 373);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 25);
            this.label6.TabIndex = 28;
            this.label6.Text = "Gün Gece:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(30, 420);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 25);
            this.label7.TabIndex = 30;
            this.label7.Text = "Rehber:";
            // 
            // cmbRehber
            // 
            this.cmbRehber.FormattingEnabled = true;
            this.cmbRehber.Location = new System.Drawing.Point(203, 420);
            this.cmbRehber.Name = "cmbRehber";
            this.cmbRehber.Size = new System.Drawing.Size(121, 32);
            this.cmbRehber.TabIndex = 31;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(193, 286);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 29);
            this.numericUpDown1.TabIndex = 32;
            // 
            // FrmLocation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1131, 706);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.cmbRehber);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtGünGece);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtFiyat);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BtnGetById);
            this.Controls.Add(this.BtnEkle);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnUpdate);
            this.Controls.Add(this.txtÜlke);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSehir);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnLİstele);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label1);
            this.Name = "FrmLocation";
            this.Text = "FrmLocation";
            this.Load += new System.EventHandler(this.FrmLocation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnGetById;
        private System.Windows.Forms.Button BtnEkle;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.TextBox txtÜlke;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSehir;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnLİstele;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtFiyat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtGünGece;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbRehber;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
    }
}