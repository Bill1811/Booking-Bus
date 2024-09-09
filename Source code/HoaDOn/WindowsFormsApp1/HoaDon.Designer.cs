
namespace WindowsFormsApp1
{
    partial class HoaDon
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
            this.button1 = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.IDHoaDon = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ngayxuat = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.TextBox();
            this.ngayxuadat = new System.Windows.Forms.Label();
            this.txtve = new System.Windows.Forms.TextBox();
            this.mave = new System.Windows.Forms.Label();
            this.sdt = new System.Windows.Forms.TextBox();
            this.eq = new System.Windows.Forms.Label();
            this.tongtien = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.hoten = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtHD = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ttCombo = new System.Windows.Forms.Label();
            this.slve = new System.Windows.Forms.TextBox();
            this.gq = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.tkHĐ = new System.Windows.Forms.TextBox();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.label1.Location = new System.Drawing.Point(323, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hóa Đơn";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button1.Location = new System.Drawing.Point(597, 83);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 27);
            this.button1.TabIndex = 7;
            this.button1.Text = "Hiển thị bảng ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnSearch.Location = new System.Drawing.Point(289, 75);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 12;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // IDHoaDon
            // 
            this.IDHoaDon.AutoSize = true;
            this.IDHoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.IDHoaDon.Location = new System.Drawing.Point(55, 80);
            this.IDHoaDon.Name = "IDHoaDon";
            this.IDHoaDon.Size = new System.Drawing.Size(87, 17);
            this.IDHoaDon.TabIndex = 10;
            this.IDHoaDon.Text = "Mã Hóa Đơn";
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnExit.Location = new System.Drawing.Point(597, 450);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(97, 41);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "Đóng";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ngayxuat);
            this.groupBox2.Controls.Add(this.email);
            this.groupBox2.Controls.Add(this.ngayxuadat);
            this.groupBox2.Controls.Add(this.txtve);
            this.groupBox2.Controls.Add(this.mave);
            this.groupBox2.Controls.Add(this.sdt);
            this.groupBox2.Controls.Add(this.eq);
            this.groupBox2.Controls.Add(this.tongtien);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.hoten);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtHD);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.ttCombo);
            this.groupBox2.Controls.Add(this.slve);
            this.groupBox2.Controls.Add(this.gq);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.groupBox2.Location = new System.Drawing.Point(58, 305);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(651, 140);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chi tiết hóa đơn";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // ngayxuat
            // 
            this.ngayxuat.Location = new System.Drawing.Point(342, 107);
            this.ngayxuat.Name = "ngayxuat";
            this.ngayxuat.Size = new System.Drawing.Size(143, 23);
            this.ngayxuat.TabIndex = 21;
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(90, 68);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(129, 23);
            this.email.TabIndex = 20;
            // 
            // ngayxuadat
            // 
            this.ngayxuadat.AutoSize = true;
            this.ngayxuadat.Location = new System.Drawing.Point(238, 110);
            this.ngayxuadat.Name = "ngayxuadat";
            this.ngayxuadat.Size = new System.Drawing.Size(98, 17);
            this.ngayxuadat.TabIndex = 17;
            this.ngayxuadat.Text = "Ngày Xuất HĐ";
            // 
            // txtve
            // 
            this.txtve.Location = new System.Drawing.Point(526, 67);
            this.txtve.Name = "txtve";
            this.txtve.Size = new System.Drawing.Size(102, 23);
            this.txtve.TabIndex = 19;
            // 
            // mave
            // 
            this.mave.AutoSize = true;
            this.mave.Location = new System.Drawing.Point(470, 71);
            this.mave.Name = "mave";
            this.mave.Size = new System.Drawing.Size(48, 17);
            this.mave.TabIndex = 18;
            this.mave.Text = "Mã Vé";
            // 
            // sdt
            // 
            this.sdt.Location = new System.Drawing.Point(526, 22);
            this.sdt.Name = "sdt";
            this.sdt.Size = new System.Drawing.Size(102, 23);
            this.sdt.TabIndex = 17;
            // 
            // eq
            // 
            this.eq.AutoSize = true;
            this.eq.Location = new System.Drawing.Point(6, 71);
            this.eq.Name = "eq";
            this.eq.Size = new System.Drawing.Size(42, 17);
            this.eq.TabIndex = 15;
            this.eq.Text = "Email";
            // 
            // tongtien
            // 
            this.tongtien.Location = new System.Drawing.Point(90, 107);
            this.tongtien.Name = "tongtien";
            this.tongtien.Size = new System.Drawing.Size(129, 23);
            this.tongtien.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Tổng tiền";
            // 
            // hoten
            // 
            this.hoten.Location = new System.Drawing.Point(342, 22);
            this.hoten.Name = "hoten";
            this.hoten.Size = new System.Drawing.Size(107, 23);
            this.hoten.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(238, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Họ tên KH";
            // 
            // txtHD
            // 
            this.txtHD.Location = new System.Drawing.Point(90, 22);
            this.txtHD.Name = "txtHD";
            this.txtHD.Size = new System.Drawing.Size(129, 23);
            this.txtHD.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã Hóa Đơn";
            // 
            // ttCombo
            // 
            this.ttCombo.AutoSize = true;
            this.ttCombo.Location = new System.Drawing.Point(238, 71);
            this.ttCombo.Name = "ttCombo";
            this.ttCombo.Size = new System.Drawing.Size(83, 17);
            this.ttCombo.TabIndex = 5;
            this.ttCombo.Text = "Số lượng vé";
            // 
            // slve
            // 
            this.slve.Location = new System.Drawing.Point(342, 68);
            this.slve.Name = "slve";
            this.slve.Size = new System.Drawing.Size(107, 23);
            this.slve.TabIndex = 6;
            // 
            // gq
            // 
            this.gq.AutoSize = true;
            this.gq.Location = new System.Drawing.Point(482, 26);
            this.gq.Name = "gq";
            this.gq.Size = new System.Drawing.Size(36, 17);
            this.gq.TabIndex = 9;
            this.gq.Text = "SDT";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGrid);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.groupBox1.Location = new System.Drawing.Point(52, 116);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(640, 183);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bảng hóa đơn";
            // 
            // dataGrid
            // 
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Location = new System.Drawing.Point(0, 19);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.Size = new System.Drawing.Size(634, 158);
            this.dataGrid.TabIndex = 0;
            this.dataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_CellContentClick);
            // 
            // tkHĐ
            // 
            this.tkHĐ.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tkHĐ.Location = new System.Drawing.Point(148, 77);
            this.tkHĐ.Name = "tkHĐ";
            this.tkHĐ.Size = new System.Drawing.Size(129, 23);
            this.tkHĐ.TabIndex = 22;
            this.tkHĐ.TextChanged += new System.EventHandler(this.tkHĐ_TextChanged);
            // 
            // HoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 503);
            this.Controls.Add(this.tkHĐ);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.IDHoaDon);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Name = "HoaDon";
            this.Text = "Form1";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label IDHoaDon;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label ttCombo;
        private System.Windows.Forms.TextBox txtHD;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.TextBox slve;
        private System.Windows.Forms.TextBox tongtien;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label gq;
        private System.Windows.Forms.TextBox hoten;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label eq;
        private System.Windows.Forms.Label ngayxuadat;
        private System.Windows.Forms.TextBox sdt;
        private System.Windows.Forms.TextBox txtve;
        private System.Windows.Forms.Label mave;
        private System.Windows.Forms.TextBox ngayxuat;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.TextBox tkHĐ;
    }
}

