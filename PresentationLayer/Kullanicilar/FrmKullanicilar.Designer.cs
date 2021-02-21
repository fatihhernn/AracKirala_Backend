
namespace PresentationLayer
{
    partial class FrmKullanıcılar
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
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btn = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dgvUsers = new System.Windows.Forms.DataGridView();
            this.gbxUsers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxUsers
            // 
            this.gbxUsers.Controls.Add(this.btnRefresh);
            this.gbxUsers.Controls.Add(this.btn);
            this.gbxUsers.Controls.Add(this.btnUpdate);
            this.gbxUsers.Controls.Add(this.btnAdd);
            this.gbxUsers.Controls.Add(this.dgvUsers);
            this.gbxUsers.Location = new System.Drawing.Point(13, 12);
            this.gbxUsers.Name = "gbxUsers";
            this.gbxUsers.Size = new System.Drawing.Size(588, 250);
            this.gbxUsers.TabIndex = 0;
            this.gbxUsers.TabStop = false;
            this.gbxUsers.Text = "Kullancılar";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(439, 202);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(138, 39);
            this.btnRefresh.TabIndex = 4;
            this.btnRefresh.Text = "Listeyi Güncelle";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btn
            // 
            this.btn.Location = new System.Drawing.Point(295, 202);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(138, 39);
            this.btn.TabIndex = 3;
            this.btn.Text = "Kullancı Sil";
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(154, 202);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(135, 39);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "Kullanıcı Güncelle";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(8, 202);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(139, 39);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Yeni Kullanıcı Ekle";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dgvUsers
            // 
            this.dgvUsers.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsers.Location = new System.Drawing.Point(7, 22);
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.Size = new System.Drawing.Size(570, 173);
            this.dgvUsers.TabIndex = 0;
            // 
            // FrmKullanıcılar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(604, 276);
            this.Controls.Add(this.gbxUsers);
            this.Name = "FrmKullanıcılar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kullanıcılar";
            this.Load += new System.EventHandler(this.User_Load);
            this.gbxUsers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxUsers;
        private System.Windows.Forms.DataGridView dgvUsers;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
    }
}