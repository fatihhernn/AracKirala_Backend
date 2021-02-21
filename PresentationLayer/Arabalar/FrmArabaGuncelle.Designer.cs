
namespace PresentationLayer.Arabalar
{
    partial class FrmArabaGuncelle
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
            this.gbxUserInfo = new System.Windows.Forms.GroupBox();
            this.txtModelYili = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.cbxModel = new System.Windows.Forms.ComboBox();
            this.btnRenkEkle = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cbxRenk = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtGunlukFiyat = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTanim = new System.Windows.Forms.TextBox();
            this.btnArabaGuncelle = new System.Windows.Forms.Button();
            this.gbxUserInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxUserInfo
            // 
            this.gbxUserInfo.Controls.Add(this.txtModelYili);
            this.gbxUserInfo.Controls.Add(this.button1);
            this.gbxUserInfo.Controls.Add(this.label6);
            this.gbxUserInfo.Controls.Add(this.cbxModel);
            this.gbxUserInfo.Controls.Add(this.btnRenkEkle);
            this.gbxUserInfo.Controls.Add(this.label5);
            this.gbxUserInfo.Controls.Add(this.cbxRenk);
            this.gbxUserInfo.Controls.Add(this.label3);
            this.gbxUserInfo.Controls.Add(this.txtGunlukFiyat);
            this.gbxUserInfo.Controls.Add(this.label2);
            this.gbxUserInfo.Controls.Add(this.label1);
            this.gbxUserInfo.Controls.Add(this.txtTanim);
            this.gbxUserInfo.Location = new System.Drawing.Point(12, 12);
            this.gbxUserInfo.Name = "gbxUserInfo";
            this.gbxUserInfo.Size = new System.Drawing.Size(336, 186);
            this.gbxUserInfo.TabIndex = 4;
            this.gbxUserInfo.TabStop = false;
            this.gbxUserInfo.Text = "Araba Bilgileri";
            this.gbxUserInfo.UseCompatibleTextRendering = true;
            // 
            // txtModelYili
            // 
            this.txtModelYili.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtModelYili.Location = new System.Drawing.Point(109, 63);
            this.txtModelYili.Name = "txtModelYili";
            this.txtModelYili.Size = new System.Drawing.Size(211, 20);
            this.txtModelYili.TabIndex = 14;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(223, 146);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Yeni Model Ekle";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 150);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Model";
            // 
            // cbxModel
            // 
            this.cbxModel.FormattingEnabled = true;
            this.cbxModel.Location = new System.Drawing.Point(109, 147);
            this.cbxModel.Name = "cbxModel";
            this.cbxModel.Size = new System.Drawing.Size(108, 21);
            this.cbxModel.TabIndex = 11;
            // 
            // btnRenkEkle
            // 
            this.btnRenkEkle.Location = new System.Drawing.Point(223, 118);
            this.btnRenkEkle.Name = "btnRenkEkle";
            this.btnRenkEkle.Size = new System.Drawing.Size(97, 23);
            this.btnRenkEkle.TabIndex = 10;
            this.btnRenkEkle.Text = "Yeni Renk Ekle";
            this.btnRenkEkle.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Renk";
            // 
            // cbxRenk
            // 
            this.cbxRenk.FormattingEnabled = true;
            this.cbxRenk.Location = new System.Drawing.Point(109, 120);
            this.cbxRenk.Name = "cbxRenk";
            this.cbxRenk.Size = new System.Drawing.Size(108, 21);
            this.cbxRenk.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Günlük Fiyat";
            // 
            // txtGunlukFiyat
            // 
            this.txtGunlukFiyat.Location = new System.Drawing.Point(109, 91);
            this.txtGunlukFiyat.Name = "txtGunlukFiyat";
            this.txtGunlukFiyat.Size = new System.Drawing.Size(211, 20);
            this.txtGunlukFiyat.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Model Yıl";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tanım";
            // 
            // txtTanim
            // 
            this.txtTanim.Location = new System.Drawing.Point(109, 34);
            this.txtTanim.Name = "txtTanim";
            this.txtTanim.Size = new System.Drawing.Size(211, 20);
            this.txtTanim.TabIndex = 0;
            // 
            // btnArabaGuncelle
            // 
            this.btnArabaGuncelle.Location = new System.Drawing.Point(12, 204);
            this.btnArabaGuncelle.Name = "btnArabaGuncelle";
            this.btnArabaGuncelle.Size = new System.Drawing.Size(336, 36);
            this.btnArabaGuncelle.TabIndex = 5;
            this.btnArabaGuncelle.Text = "Araba Güncelle";
            this.btnArabaGuncelle.UseVisualStyleBackColor = true;
            this.btnArabaGuncelle.Click += new System.EventHandler(this.btnArabaGuncelle_Click);
            // 
            // FrmArabaGuncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(359, 247);
            this.Controls.Add(this.gbxUserInfo);
            this.Controls.Add(this.btnArabaGuncelle);
            this.Name = "FrmArabaGuncelle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmArabaGuncelle";
            this.Load += new System.EventHandler(this.FrmArabaGuncelle_Load);
            this.gbxUserInfo.ResumeLayout(false);
            this.gbxUserInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxUserInfo;
        private System.Windows.Forms.DateTimePicker txtModelYili;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbxModel;
        private System.Windows.Forms.Button btnRenkEkle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbxRenk;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtGunlukFiyat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTanim;
        private System.Windows.Forms.Button btnArabaGuncelle;
    }
}