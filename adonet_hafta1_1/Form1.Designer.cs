namespace adonet_hafta1_1
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
            this.lblCategoryid = new System.Windows.Forms.Label();
            this.lblCategoryname = new System.Windows.Forms.Label();
            this.btnList = new System.Windows.Forms.Button();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtCategoryid = new System.Windows.Forms.TextBox();
            this.txtCategoryname = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCategoryid
            // 
            this.lblCategoryid.AutoSize = true;
            this.lblCategoryid.Location = new System.Drawing.Point(37, 67);
            this.lblCategoryid.Name = "lblCategoryid";
            this.lblCategoryid.Size = new System.Drawing.Size(63, 13);
            this.lblCategoryid.TabIndex = 0;
            this.lblCategoryid.Text = "Kategori ID:";
            // 
            // lblCategoryname
            // 
            this.lblCategoryname.AutoSize = true;
            this.lblCategoryname.Location = new System.Drawing.Point(37, 117);
            this.lblCategoryname.Name = "lblCategoryname";
            this.lblCategoryname.Size = new System.Drawing.Size(67, 13);
            this.lblCategoryname.TabIndex = 1;
            this.lblCategoryname.Text = "Kategori Adı:";
            // 
            // btnList
            // 
            this.btnList.Location = new System.Drawing.Point(348, 39);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(75, 23);
            this.btnList.TabIndex = 2;
            this.btnList.Text = "Listele";
            this.btnList.UseVisualStyleBackColor = true;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // BtnAdd
            // 
            this.BtnAdd.Location = new System.Drawing.Point(348, 68);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(75, 23);
            this.BtnAdd.TabIndex = 3;
            this.BtnAdd.Text = "Ekle";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(348, 97);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Sil";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(348, 126);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "Güncelle";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(40, 340);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(383, 233);
            this.dataGridView1.TabIndex = 6;
            // 
            // txtCategoryid
            // 
            this.txtCategoryid.Location = new System.Drawing.Point(108, 64);
            this.txtCategoryid.Name = "txtCategoryid";
            this.txtCategoryid.Size = new System.Drawing.Size(208, 20);
            this.txtCategoryid.TabIndex = 7;
            // 
            // txtCategoryname
            // 
            this.txtCategoryname.Location = new System.Drawing.Point(108, 114);
            this.txtCategoryname.Name = "txtCategoryname";
            this.txtCategoryname.Size = new System.Drawing.Size(208, 20);
            this.txtCategoryname.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1092, 679);
            this.Controls.Add(this.txtCategoryname);
            this.Controls.Add(this.txtCategoryid);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.btnList);
            this.Controls.Add(this.lblCategoryname);
            this.Controls.Add(this.lblCategoryid);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCategoryid;
        private System.Windows.Forms.Label lblCategoryname;
        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtCategoryid;
        private System.Windows.Forms.TextBox txtCategoryname;
    }
}

