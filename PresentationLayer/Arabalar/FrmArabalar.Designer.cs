
namespace PresentationLayer
{
    partial class FrmArabalar
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
            this.gbxUsers = new System.Windows.Forms.GroupBox();
            this.btnListeGuncelle = new System.Windows.Forms.Button();
            this.btnArabaSil = new System.Windows.Forms.Button();
            this.btnArabaGuncelle = new System.Windows.Forms.Button();
            this.btnYeniArabaEkle = new System.Windows.Forms.Button();
            this.dgvArabalar = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxModelSec = new System.Windows.Forms.ComboBox();
            this.txtArabaAra = new System.Windows.Forms.TextBox();
            this.gbxUsers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArabalar)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxUsers
            // 
            this.gbxUsers.Controls.Add(this.btnListeGuncelle);
            this.gbxUsers.Controls.Add(this.btnArabaSil);
            this.gbxUsers.Controls.Add(this.btnArabaGuncelle);
            this.gbxUsers.Controls.Add(this.btnYeniArabaEkle);
            this.gbxUsers.Controls.Add(this.dgvArabalar);
            this.gbxUsers.Location = new System.Drawing.Point(12, 106);
            this.gbxUsers.Name = "gbxUsers";
            this.gbxUsers.Size = new System.Drawing.Size(588, 250);
            this.gbxUsers.TabIndex = 1;
            this.gbxUsers.TabStop = false;
            this.gbxUsers.Text = "Arabalar";
            // 
            // btnListeGuncelle
            // 
            this.btnListeGuncelle.BackColor = System.Drawing.Color.Goldenrod;
            this.btnListeGuncelle.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnListeGuncelle.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnListeGuncelle.Location = new System.Drawing.Point(439, 202);
            this.btnListeGuncelle.Name = "btnListeGuncelle";
            this.btnListeGuncelle.Size = new System.Drawing.Size(138, 39);
            this.btnListeGuncelle.TabIndex = 4;
            this.btnListeGuncelle.Text = "Listeyi Güncelle";
            this.btnListeGuncelle.UseVisualStyleBackColor = false;
            this.btnListeGuncelle.Click += new System.EventHandler(this.btnListeGuncelle_Click);
            // 
            // btnArabaSil
            // 
            this.btnArabaSil.BackColor = System.Drawing.Color.Goldenrod;
            this.btnArabaSil.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnArabaSil.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnArabaSil.Location = new System.Drawing.Point(295, 202);
            this.btnArabaSil.Name = "btnArabaSil";
            this.btnArabaSil.Size = new System.Drawing.Size(138, 39);
            this.btnArabaSil.TabIndex = 3;
            this.btnArabaSil.Text = "Araba Sil";
            this.btnArabaSil.UseVisualStyleBackColor = false;
            this.btnArabaSil.Click += new System.EventHandler(this.btnArabaSil_Click);
            // 
            // btnArabaGuncelle
            // 
            this.btnArabaGuncelle.BackColor = System.Drawing.Color.Goldenrod;
            this.btnArabaGuncelle.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnArabaGuncelle.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnArabaGuncelle.Location = new System.Drawing.Point(154, 202);
            this.btnArabaGuncelle.Name = "btnArabaGuncelle";
            this.btnArabaGuncelle.Size = new System.Drawing.Size(135, 39);
            this.btnArabaGuncelle.TabIndex = 2;
            this.btnArabaGuncelle.Text = "Araba Güncelle";
            this.btnArabaGuncelle.UseVisualStyleBackColor = false;
            this.btnArabaGuncelle.Click += new System.EventHandler(this.btnArabaGuncelle_Click);
            // 
            // btnYeniArabaEkle
            // 
            this.btnYeniArabaEkle.BackColor = System.Drawing.Color.Goldenrod;
            this.btnYeniArabaEkle.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYeniArabaEkle.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnYeniArabaEkle.Location = new System.Drawing.Point(8, 202);
            this.btnYeniArabaEkle.Name = "btnYeniArabaEkle";
            this.btnYeniArabaEkle.Size = new System.Drawing.Size(139, 39);
            this.btnYeniArabaEkle.TabIndex = 1;
            this.btnYeniArabaEkle.Text = "Yeni Araba Ekle";
            this.btnYeniArabaEkle.UseVisualStyleBackColor = false;
            this.btnYeniArabaEkle.Click += new System.EventHandler(this.btnYeniArabaEkle_Click);
            // 
            // dgvArabalar
            // 
            this.dgvArabalar.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvArabalar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArabalar.Location = new System.Drawing.Point(7, 22);
            this.dgvArabalar.Name = "dgvArabalar";
            this.dgvArabalar.Size = new System.Drawing.Size(570, 173);
            this.dgvArabalar.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbxModelSec);
            this.groupBox1.Controls.Add(this.txtArabaAra);
            this.groupBox1.Location = new System.Drawing.Point(20, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(580, 73);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tercihler";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(310, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Araba Model Seçiniz";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Araba Adı Giriniz";
            // 
            // cbxModelSec
            // 
            this.cbxModelSec.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.cbxModelSec.FormattingEnabled = true;
            this.cbxModelSec.Location = new System.Drawing.Point(420, 30);
            this.cbxModelSec.Name = "cbxModelSec";
            this.cbxModelSec.Size = new System.Drawing.Size(138, 21);
            this.cbxModelSec.TabIndex = 1;
            // 
            // txtArabaAra
            // 
            this.txtArabaAra.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtArabaAra.Location = new System.Drawing.Point(115, 31);
            this.txtArabaAra.Name = "txtArabaAra";
            this.txtArabaAra.Size = new System.Drawing.Size(171, 20);
            this.txtArabaAra.TabIndex = 0;
            this.txtArabaAra.TextChanged += new System.EventHandler(this.txtArabaAra_TextChanged);
            // 
            // FrmArabalar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(612, 370);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbxUsers);
            this.Name = "FrmArabalar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmArabalar";
            this.Load += new System.EventHandler(this.FrmArabalar_Load);
            this.gbxUsers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArabalar)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxUsers;
        private System.Windows.Forms.Button btnListeGuncelle;
        private System.Windows.Forms.Button btnArabaSil;
        private System.Windows.Forms.Button btnArabaGuncelle;
        private System.Windows.Forms.Button btnYeniArabaEkle;
        private System.Windows.Forms.DataGridView dgvArabalar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxModelSec;
        private System.Windows.Forms.TextBox txtArabaAra;
    }
}