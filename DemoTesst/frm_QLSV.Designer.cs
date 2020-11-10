namespace DemoTesst
{
    partial class frm_QLSV
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lb_Khoa = new System.Windows.Forms.ListBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_them = new System.Windows.Forms.Button();
            this.txt_msv = new System.Windows.Forms.TextBox();
            this.txt_tensv = new System.Windows.Forms.TextBox();
            this.txt_tenk = new System.Windows.Forms.TextBox();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.gv_sv = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv_sv)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Danh sách khoa";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lb_Khoa);
            this.panel1.Location = new System.Drawing.Point(34, 62);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(155, 100);
            this.panel1.TabIndex = 1;
            // 
            // lb_Khoa
            // 
            this.lb_Khoa.FormattingEnabled = true;
            this.lb_Khoa.Location = new System.Drawing.Point(4, 4);
            this.lb_Khoa.Name = "lb_Khoa";
            this.lb_Khoa.Size = new System.Drawing.Size(148, 95);
            this.lb_Khoa.TabIndex = 0;
            this.lb_Khoa.SelectedIndexChanged += new System.EventHandler(this.lb_Khoa_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txt_tenk);
            this.panel2.Controls.Add(this.txt_tensv);
            this.panel2.Controls.Add(this.txt_msv);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(260, 26);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(484, 167);
            this.panel2.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã sv:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên sv:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(25, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Khoa:";
            // 
            // btn_them
            // 
            this.btn_them.Location = new System.Drawing.Point(63, 232);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(75, 23);
            this.btn_them.TabIndex = 3;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_Click);
            // 
            // txt_msv
            // 
            this.txt_msv.Location = new System.Drawing.Point(127, 22);
            this.txt_msv.Name = "txt_msv";
            this.txt_msv.Size = new System.Drawing.Size(270, 20);
            this.txt_msv.TabIndex = 4;
            // 
            // txt_tensv
            // 
            this.txt_tensv.Location = new System.Drawing.Point(127, 63);
            this.txt_tensv.Name = "txt_tensv";
            this.txt_tensv.Size = new System.Drawing.Size(270, 20);
            this.txt_tensv.TabIndex = 5;
            // 
            // txt_tenk
            // 
            this.txt_tenk.Location = new System.Drawing.Point(127, 104);
            this.txt_tenk.Name = "txt_tenk";
            this.txt_tenk.Size = new System.Drawing.Size(270, 20);
            this.txt_tenk.TabIndex = 6;
            // 
            // btn_sua
            // 
            this.btn_sua.Location = new System.Drawing.Point(229, 232);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(75, 23);
            this.btn_sua.TabIndex = 4;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = true;
            this.btn_sua.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Location = new System.Drawing.Point(410, 232);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(75, 23);
            this.btn_xoa.TabIndex = 5;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_thoat
            // 
            this.btn_thoat.Location = new System.Drawing.Point(605, 232);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(75, 23);
            this.btn_thoat.TabIndex = 6;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.UseVisualStyleBackColor = true;
            this.btn_thoat.Click += new System.EventHandler(this.btn_Click);
            // 
            // gv_sv
            // 
            this.gv_sv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv_sv.Location = new System.Drawing.Point(38, 288);
            this.gv_sv.Name = "gv_sv";
            this.gv_sv.Size = new System.Drawing.Size(706, 150);
            this.gv_sv.TabIndex = 7;
            this.gv_sv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gv_sv_CellClick);

            // 
            // frm_QLSV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gv_sv);
            this.Controls.Add(this.btn_thoat);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.btn_them);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "frm_QLSV";
            this.Text = "Quản lý sinh viên";
            this.Load += new System.EventHandler(this.frm_QLSV_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv_sv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox lb_Khoa;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txt_tenk;
        private System.Windows.Forms.TextBox txt_tensv;
        private System.Windows.Forms.TextBox txt_msv;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_thoat;
        private System.Windows.Forms.DataGridView gv_sv;
    }
}