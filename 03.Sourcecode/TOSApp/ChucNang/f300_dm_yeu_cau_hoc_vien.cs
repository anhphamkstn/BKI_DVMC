///************************************************
/// Generated by: thelk
/// Date: 22/03/2014 08:40:48
/// Goal: Create Form for V_GD_CAU_HOI_YEU_CAU
///************************************************


using System;
using System.Data;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

using IP.Core.IPCommon;
using IP.Core.IPException;
using IP.Core.IPData;
using IP.Core.IPUserService;

using IPCOREDS;
using IPCOREUS;
using IPCOREDS.CDBNames;

using C1.Win.C1FlexGrid;
using IP.Core.IPSystemAdmin;
using TOSApp.App_Code;
using TOSApp.ChucNang;
using TOSApp;

namespace TOSApp
{



	public class f300_dm_yeu_cau_hoc_vien : System.Windows.Forms.Form
	{
		internal System.Windows.Forms.ImageList ImageList;
		internal System.Windows.Forms.Panel m_pnl_out_place_dm;
		private C1.Win.C1FlexGrid.C1FlexGrid m_fg;
		internal SIS.Controls.Button.SiSButton m_cmd_nghe_lai;
		internal SIS.Controls.Button.SiSButton m_cmd_xu_ly_noi_bo;
		internal SIS.Controls.Button.SiSButton m_cmd_goi_lai_hoc_vien;
		internal SIS.Controls.Button.SiSButton m_cmd_exit;
        internal SIS.Controls.Button.SiSButton m_cmd_xuat_excel;
        private TextBox m_txt_ho_ten;
        private TextBox m_txt_dien_thoai;
        private Label label3;
        private Label label1;
        private DateTimePicker m_dat_tu_ngay;
        private Label label5;
        private Label label2;
        private DateTimePicker m_dat_den_ngay;
        internal SIS.Controls.Button.SiSButton m_cmd_loc_du_lieu;
        private Label label9;
        private ComboBox m_cbo_trang_thai_cau_hoi;
        private Panel panel1;
        private Label m_lb_header;
        private Label label4;
        private RadioButton m_rdb_assign_qlht_all;
        private RadioButton m_rdb_assign_qlht_y;
        private RadioButton m_rdb_assign_qlht_n;
		private System.ComponentModel.IContainer components;

		public f300_dm_yeu_cau_hoc_vien()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
			format_controls();
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(f300_dm_yeu_cau_hoc_vien));
            this.ImageList = new System.Windows.Forms.ImageList(this.components);
            this.m_pnl_out_place_dm = new System.Windows.Forms.Panel();
            this.m_cmd_goi_lai_hoc_vien = new SIS.Controls.Button.SiSButton();
            this.m_cmd_xu_ly_noi_bo = new SIS.Controls.Button.SiSButton();
            this.m_cmd_xuat_excel = new SIS.Controls.Button.SiSButton();
            this.m_cmd_nghe_lai = new SIS.Controls.Button.SiSButton();
            this.m_cmd_exit = new SIS.Controls.Button.SiSButton();
            this.m_fg = new C1.Win.C1FlexGrid.C1FlexGrid();
            this.m_txt_ho_ten = new System.Windows.Forms.TextBox();
            this.m_txt_dien_thoai = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.m_dat_tu_ngay = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.m_dat_den_ngay = new System.Windows.Forms.DateTimePicker();
            this.m_cmd_loc_du_lieu = new SIS.Controls.Button.SiSButton();
            this.label9 = new System.Windows.Forms.Label();
            this.m_cbo_trang_thai_cau_hoi = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.m_rdb_assign_qlht_n = new System.Windows.Forms.RadioButton();
            this.m_rdb_assign_qlht_y = new System.Windows.Forms.RadioButton();
            this.m_rdb_assign_qlht_all = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.m_lb_header = new System.Windows.Forms.Label();
            this.m_pnl_out_place_dm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_fg)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ImageList
            // 
            this.ImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImageList.ImageStream")));
            this.ImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.ImageList.Images.SetKeyName(0, "");
            this.ImageList.Images.SetKeyName(1, "");
            this.ImageList.Images.SetKeyName(2, "");
            this.ImageList.Images.SetKeyName(3, "");
            this.ImageList.Images.SetKeyName(4, "");
            this.ImageList.Images.SetKeyName(5, "");
            this.ImageList.Images.SetKeyName(6, "");
            this.ImageList.Images.SetKeyName(7, "");
            this.ImageList.Images.SetKeyName(8, "");
            this.ImageList.Images.SetKeyName(9, "");
            this.ImageList.Images.SetKeyName(10, "");
            this.ImageList.Images.SetKeyName(11, "");
            this.ImageList.Images.SetKeyName(12, "");
            this.ImageList.Images.SetKeyName(13, "");
            this.ImageList.Images.SetKeyName(14, "");
            this.ImageList.Images.SetKeyName(15, "");
            this.ImageList.Images.SetKeyName(16, "");
            this.ImageList.Images.SetKeyName(17, "");
            this.ImageList.Images.SetKeyName(18, "");
            this.ImageList.Images.SetKeyName(19, "");
            this.ImageList.Images.SetKeyName(20, "");
            this.ImageList.Images.SetKeyName(21, "");
            // 
            // m_pnl_out_place_dm
            // 
            this.m_pnl_out_place_dm.Controls.Add(this.m_cmd_goi_lai_hoc_vien);
            this.m_pnl_out_place_dm.Controls.Add(this.m_cmd_xu_ly_noi_bo);
            this.m_pnl_out_place_dm.Controls.Add(this.m_cmd_xuat_excel);
            this.m_pnl_out_place_dm.Controls.Add(this.m_cmd_nghe_lai);
            this.m_pnl_out_place_dm.Controls.Add(this.m_cmd_exit);
            this.m_pnl_out_place_dm.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.m_pnl_out_place_dm.Location = new System.Drawing.Point(0, 526);
            this.m_pnl_out_place_dm.Name = "m_pnl_out_place_dm";
            this.m_pnl_out_place_dm.Padding = new System.Windows.Forms.Padding(4);
            this.m_pnl_out_place_dm.Size = new System.Drawing.Size(984, 36);
            this.m_pnl_out_place_dm.TabIndex = 1;
            // 
            // m_cmd_goi_lai_hoc_vien
            // 
            this.m_cmd_goi_lai_hoc_vien.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.m_cmd_goi_lai_hoc_vien.BtnShape = SIS.Controls.Button.emunType.BtnShape.Rectangle;
            this.m_cmd_goi_lai_hoc_vien.BtnStyle = SIS.Controls.Button.emunType.XPStyle.Default;
            this.m_cmd_goi_lai_hoc_vien.Dock = System.Windows.Forms.DockStyle.Right;
            this.m_cmd_goi_lai_hoc_vien.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_cmd_goi_lai_hoc_vien.ImageIndex = 11;
            this.m_cmd_goi_lai_hoc_vien.ImageList = this.ImageList;
            this.m_cmd_goi_lai_hoc_vien.Location = new System.Drawing.Point(601, 4);
            this.m_cmd_goi_lai_hoc_vien.Name = "m_cmd_goi_lai_hoc_vien";
            this.m_cmd_goi_lai_hoc_vien.Size = new System.Drawing.Size(115, 28);
            this.m_cmd_goi_lai_hoc_vien.TabIndex = 0;
            this.m_cmd_goi_lai_hoc_vien.Text = "Gọi lại học viên";
            // 
            // m_cmd_xu_ly_noi_bo
            // 
            this.m_cmd_xu_ly_noi_bo.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.m_cmd_xu_ly_noi_bo.BtnShape = SIS.Controls.Button.emunType.BtnShape.Rectangle;
            this.m_cmd_xu_ly_noi_bo.BtnStyle = SIS.Controls.Button.emunType.XPStyle.Default;
            this.m_cmd_xu_ly_noi_bo.Dock = System.Windows.Forms.DockStyle.Right;
            this.m_cmd_xu_ly_noi_bo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_cmd_xu_ly_noi_bo.ImageIndex = 9;
            this.m_cmd_xu_ly_noi_bo.ImageList = this.ImageList;
            this.m_cmd_xu_ly_noi_bo.Location = new System.Drawing.Point(716, 4);
            this.m_cmd_xu_ly_noi_bo.Name = "m_cmd_xu_ly_noi_bo";
            this.m_cmd_xu_ly_noi_bo.Size = new System.Drawing.Size(88, 28);
            this.m_cmd_xu_ly_noi_bo.TabIndex = 1;
            this.m_cmd_xu_ly_noi_bo.Text = "&Xử lý nội bộ";
            // 
            // m_cmd_xuat_excel
            // 
            this.m_cmd_xuat_excel.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.m_cmd_xuat_excel.BtnShape = SIS.Controls.Button.emunType.BtnShape.Rectangle;
            this.m_cmd_xuat_excel.BtnStyle = SIS.Controls.Button.emunType.XPStyle.Default;
            this.m_cmd_xuat_excel.Dock = System.Windows.Forms.DockStyle.Left;
            this.m_cmd_xuat_excel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_cmd_xuat_excel.ImageIndex = 19;
            this.m_cmd_xuat_excel.ImageList = this.ImageList;
            this.m_cmd_xuat_excel.Location = new System.Drawing.Point(4, 4);
            this.m_cmd_xuat_excel.Name = "m_cmd_xuat_excel";
            this.m_cmd_xuat_excel.Size = new System.Drawing.Size(88, 28);
            this.m_cmd_xuat_excel.TabIndex = 3;
            this.m_cmd_xuat_excel.Text = "Xuất Excel";
            // 
            // m_cmd_nghe_lai
            // 
            this.m_cmd_nghe_lai.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.m_cmd_nghe_lai.BtnShape = SIS.Controls.Button.emunType.BtnShape.Rectangle;
            this.m_cmd_nghe_lai.BtnStyle = SIS.Controls.Button.emunType.XPStyle.Default;
            this.m_cmd_nghe_lai.Dock = System.Windows.Forms.DockStyle.Right;
            this.m_cmd_nghe_lai.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_cmd_nghe_lai.ImageIndex = 1;
            this.m_cmd_nghe_lai.ImageList = this.ImageList;
            this.m_cmd_nghe_lai.Location = new System.Drawing.Point(804, 4);
            this.m_cmd_nghe_lai.Name = "m_cmd_nghe_lai";
            this.m_cmd_nghe_lai.Size = new System.Drawing.Size(88, 28);
            this.m_cmd_nghe_lai.TabIndex = 2;
            this.m_cmd_nghe_lai.Text = "&Nghe lại";
            // 
            // m_cmd_exit
            // 
            this.m_cmd_exit.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.m_cmd_exit.BtnShape = SIS.Controls.Button.emunType.BtnShape.Rectangle;
            this.m_cmd_exit.BtnStyle = SIS.Controls.Button.emunType.XPStyle.Default;
            this.m_cmd_exit.Dock = System.Windows.Forms.DockStyle.Right;
            this.m_cmd_exit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_cmd_exit.ImageIndex = 12;
            this.m_cmd_exit.ImageList = this.ImageList;
            this.m_cmd_exit.Location = new System.Drawing.Point(892, 4);
            this.m_cmd_exit.Name = "m_cmd_exit";
            this.m_cmd_exit.Size = new System.Drawing.Size(88, 28);
            this.m_cmd_exit.TabIndex = 4;
            this.m_cmd_exit.Text = "Thoát (Esc)";
            // 
            // m_fg
            // 
            this.m_fg.ColumnInfo = resources.GetString("m_fg.ColumnInfo");
            this.m_fg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_fg.Location = new System.Drawing.Point(0, 165);
            this.m_fg.Name = "m_fg";
            this.m_fg.Size = new System.Drawing.Size(984, 361);
            this.m_fg.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(resources.GetString("m_fg.Styles"));
            this.m_fg.TabIndex = 1;
            // 
            // m_txt_ho_ten
            // 
            this.m_txt_ho_ten.BackColor = System.Drawing.SystemColors.Window;
            this.m_txt_ho_ten.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.m_txt_ho_ten.Location = new System.Drawing.Point(546, 57);
            this.m_txt_ho_ten.Name = "m_txt_ho_ten";
            this.m_txt_ho_ten.Size = new System.Drawing.Size(159, 20);
            this.m_txt_ho_ten.TabIndex = 1;
            // 
            // m_txt_dien_thoai
            // 
            this.m_txt_dien_thoai.BackColor = System.Drawing.SystemColors.Window;
            this.m_txt_dien_thoai.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.m_txt_dien_thoai.Location = new System.Drawing.Point(234, 57);
            this.m_txt_dien_thoai.Name = "m_txt_dien_thoai";
            this.m_txt_dien_thoai.Size = new System.Drawing.Size(148, 20);
            this.m_txt_dien_thoai.TabIndex = 0;
            this.m_txt_dien_thoai.TextChanged += new System.EventHandler(this.m_txt_dien_thoai_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(501, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "Họ tên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(176, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Điện thoại";
            // 
            // m_dat_tu_ngay
            // 
            this.m_dat_tu_ngay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.m_dat_tu_ngay.Location = new System.Drawing.Point(234, 93);
            this.m_dat_tu_ngay.Name = "m_dat_tu_ngay";
            this.m_dat_tu_ngay.Size = new System.Drawing.Size(148, 20);
            this.m_dat_tu_ngay.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(151, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 30;
            this.label5.Text = "Thời gian gọi từ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(487, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 30;
            this.label2.Text = "Đến ngày";
            // 
            // m_dat_den_ngay
            // 
            this.m_dat_den_ngay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.m_dat_den_ngay.Location = new System.Drawing.Point(546, 93);
            this.m_dat_den_ngay.Name = "m_dat_den_ngay";
            this.m_dat_den_ngay.Size = new System.Drawing.Size(159, 20);
            this.m_dat_den_ngay.TabIndex = 3;
            // 
            // m_cmd_loc_du_lieu
            // 
            this.m_cmd_loc_du_lieu.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.m_cmd_loc_du_lieu.BtnShape = SIS.Controls.Button.emunType.BtnShape.Rectangle;
            this.m_cmd_loc_du_lieu.BtnStyle = SIS.Controls.Button.emunType.XPStyle.Default;
            this.m_cmd_loc_du_lieu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_cmd_loc_du_lieu.ImageIndex = 17;
            this.m_cmd_loc_du_lieu.ImageList = this.ImageList;
            this.m_cmd_loc_du_lieu.Location = new System.Drawing.Point(725, 60);
            this.m_cmd_loc_du_lieu.Name = "m_cmd_loc_du_lieu";
            this.m_cmd_loc_du_lieu.Size = new System.Drawing.Size(95, 79);
            this.m_cmd_loc_du_lieu.TabIndex = 8;
            this.m_cmd_loc_du_lieu.Text = "&Lọc dữ liệu";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(132, 126);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(99, 13);
            this.label9.TabIndex = 33;
            this.label9.Text = "Trạng thái cuộc gọi";
            // 
            // m_cbo_trang_thai_cau_hoi
            // 
            this.m_cbo_trang_thai_cau_hoi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.m_cbo_trang_thai_cau_hoi.FormattingEnabled = true;
            this.m_cbo_trang_thai_cau_hoi.Location = new System.Drawing.Point(234, 124);
            this.m_cbo_trang_thai_cau_hoi.Name = "m_cbo_trang_thai_cau_hoi";
            this.m_cbo_trang_thai_cau_hoi.Size = new System.Drawing.Size(148, 21);
            this.m_cbo_trang_thai_cau_hoi.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.m_rdb_assign_qlht_n);
            this.panel1.Controls.Add(this.m_rdb_assign_qlht_y);
            this.panel1.Controls.Add(this.m_rdb_assign_qlht_all);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.m_cmd_loc_du_lieu);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.m_lb_header);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.m_cbo_trang_thai_cau_hoi);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.m_txt_dien_thoai);
            this.panel1.Controls.Add(this.m_dat_den_ngay);
            this.panel1.Controls.Add(this.m_txt_ho_ten);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.m_dat_tu_ngay);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(984, 165);
            this.panel1.TabIndex = 0;
            // 
            // m_rdb_assign_qlht_n
            // 
            this.m_rdb_assign_qlht_n.AutoSize = true;
            this.m_rdb_assign_qlht_n.Location = new System.Drawing.Point(650, 125);
            this.m_rdb_assign_qlht_n.Name = "m_rdb_assign_qlht_n";
            this.m_rdb_assign_qlht_n.Size = new System.Drawing.Size(56, 17);
            this.m_rdb_assign_qlht_n.TabIndex = 7;
            this.m_rdb_assign_qlht_n.TabStop = true;
            this.m_rdb_assign_qlht_n.Text = "Không";
            this.m_rdb_assign_qlht_n.UseVisualStyleBackColor = true;
            // 
            // m_rdb_assign_qlht_y
            // 
            this.m_rdb_assign_qlht_y.AutoSize = true;
            this.m_rdb_assign_qlht_y.Location = new System.Drawing.Point(606, 125);
            this.m_rdb_assign_qlht_y.Name = "m_rdb_assign_qlht_y";
            this.m_rdb_assign_qlht_y.Size = new System.Drawing.Size(38, 17);
            this.m_rdb_assign_qlht_y.TabIndex = 6;
            this.m_rdb_assign_qlht_y.TabStop = true;
            this.m_rdb_assign_qlht_y.Text = "Có";
            this.m_rdb_assign_qlht_y.UseVisualStyleBackColor = true;
            // 
            // m_rdb_assign_qlht_all
            // 
            this.m_rdb_assign_qlht_all.AutoSize = true;
            this.m_rdb_assign_qlht_all.Checked = true;
            this.m_rdb_assign_qlht_all.Location = new System.Drawing.Point(546, 125);
            this.m_rdb_assign_qlht_all.Name = "m_rdb_assign_qlht_all";
            this.m_rdb_assign_qlht_all.Size = new System.Drawing.Size(56, 17);
            this.m_rdb_assign_qlht_all.TabIndex = 5;
            this.m_rdb_assign_qlht_all.TabStop = true;
            this.m_rdb_assign_qlht_all.Text = "Tất cả";
            this.m_rdb_assign_qlht_all.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(428, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 13);
            this.label4.TabIndex = 34;
            this.label4.Text = "Có assign cho QLHT?";
            // 
            // m_lb_header
            // 
            this.m_lb_header.AutoSize = true;
            this.m_lb_header.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_lb_header.ForeColor = System.Drawing.Color.Maroon;
            this.m_lb_header.Location = new System.Drawing.Point(291, 10);
            this.m_lb_header.Name = "m_lb_header";
            this.m_lb_header.Size = new System.Drawing.Size(433, 26);
            this.m_lb_header.TabIndex = 26;
            this.m_lb_header.Text = "F300 - Danh sách các câu hỏi của sinh viên";
            this.m_lb_header.Click += new System.EventHandler(this.m_lb_header_Click);
            // 
            // f300_dm_yeu_cau_hoc_vien
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(984, 562);
            this.Controls.Add(this.m_fg);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.m_pnl_out_place_dm);
            this.Name = "f300_dm_yeu_cau_hoc_vien";
            this.Text = "F300 - Danh Sách Yêu Cầu Của Sinh Viên";
            this.Load += new System.EventHandler(this.f300_dm_yeu_cau_hoc_vien_Load);
            this.m_pnl_out_place_dm.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.m_fg)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

		}
		#endregion

		#region Public Interface
		public void display(){			
			this.ShowDialog();
		}
		#endregion

		#region Data Structure
		private enum e_col_Number{
            START_TIME = 3
            ,NOI_DUNG_TRA_LOI = 5
            ,THOI_DIEM_HEN_GOI_LAI = 7
            ,GHI_CHU_LICH_HEN = 8
            ,ID = 10
            ,SO_DIEN_THOAI = 1
            ,HO_TEN_SINH_VIEN = 2
            ,ID_YEU_CAU = 9
            ,NOI_DUNG_CAU_HOI = 4
            ,STT =0
            ,TRANG_THAI = 6
		}			
		#endregion

		#region Members
		ITransferDataRow m_obj_trans;		
		DS_V_GD_CAU_HOI_YEU_CAU m_ds = new DS_V_GD_CAU_HOI_YEU_CAU();
		US_V_GD_CAU_HOI_YEU_CAU m_us = new US_V_GD_CAU_HOI_YEU_CAU();
		#endregion

		#region Private Methods
		private void format_controls(){
			CControlFormat.setFormStyle(this, new CAppContext_201(), IPFormStyle.DialogForm);
			CControlFormat.setC1FlexFormat(m_fg);
			CGridUtils.AddSearch_Handlers(m_fg);
            CGridUtils.AddSave_Excel_Handlers(m_fg);
            m_fg.Cols[(int)e_col_Number.SO_DIEN_THOAI].Visible = false;
            m_fg.Cols[(int)e_col_Number.HO_TEN_SINH_VIEN].Visible = false;
            m_fg.Cols[(int)e_col_Number.START_TIME].Visible = false;
            m_fg.Cols[(int)e_col_Number.ID].Visible = false;
            m_fg.Cols[(int)e_col_Number.ID_YEU_CAU].Visible = false;
            m_fg.Tree.Column = (int)e_col_Number.NOI_DUNG_CAU_HOI;
            m_fg.Tree.Style = C1.Win.C1FlexGrid.TreeStyleFlags.SimpleLeaf;

            m_lb_header.Font = new Font("Arial",16,FontStyle.Regular);
            m_lb_header.ForeColor = Color.DarkRed;
            //m_fg.Cols[(int)e_col_Number.ID_TRANG_THAI].DataMap = get_data_map_trang_thai();
            this.MaximizeBox = true;
            this.MinimizeBox = true;
            m_txt_dien_thoai.Focus();
			set_define_events();
			this.KeyPreview = true;
		}
		private void set_initial_form_load(){						
			m_obj_trans = get_trans_object(m_fg);
            load_data_2_cbo_trang_thai_cau_hoi();
		}	
		private ITransferDataRow get_trans_object(C1.Win.C1FlexGrid.C1FlexGrid i_fg){
			Hashtable v_htb = new Hashtable();
			v_htb.Add(V_GD_CAU_HOI_YEU_CAU.START_TIME, e_col_Number.START_TIME);
            v_htb.Add(V_GD_CAU_HOI_YEU_CAU.HO_TEN_SINH_VIEN, e_col_Number.HO_TEN_SINH_VIEN);
            v_htb.Add(V_GD_CAU_HOI_YEU_CAU.NOI_DUNG_TRA_LOI, e_col_Number.NOI_DUNG_TRA_LOI);
			v_htb.Add(V_GD_CAU_HOI_YEU_CAU.THOI_DIEM_HEN_GOI_LAI, e_col_Number.THOI_DIEM_HEN_GOI_LAI);
			v_htb.Add(V_GD_CAU_HOI_YEU_CAU.GHI_CHU_LICH_HEN, e_col_Number.GHI_CHU_LICH_HEN);
			v_htb.Add(V_GD_CAU_HOI_YEU_CAU.TRANG_THAI_CAU_HOI, e_col_Number.TRANG_THAI);
			v_htb.Add(V_GD_CAU_HOI_YEU_CAU.ID, e_col_Number.ID);
			v_htb.Add(V_GD_CAU_HOI_YEU_CAU.SO_DIEN_THOAI, e_col_Number.SO_DIEN_THOAI);
			v_htb.Add(V_GD_CAU_HOI_YEU_CAU.ID_YEU_CAU, e_col_Number.ID_YEU_CAU);
			v_htb.Add(V_GD_CAU_HOI_YEU_CAU.NOI_DUNG_CAU_HOI, e_col_Number.NOI_DUNG_CAU_HOI);
									
			ITransferDataRow v_obj_trans = new CC1TransferDataRow(i_fg,v_htb,m_ds.V_GD_CAU_HOI_YEU_CAU.NewRow());
			return v_obj_trans;			
		}
        private Hashtable get_data_map_trang_thai()
        {
            US_CM_DM_TU_DIEN v_us = new US_CM_DM_TU_DIEN();
            DS_CM_DM_TU_DIEN v_ds = new DS_CM_DM_TU_DIEN();
            v_us.fill_tu_dien_cung_loai_ds(LOAI_TU_DIEN_TEXT.TRANG_THAI_GD_CAU_HOI_SV, CM_DM_TU_DIEN.MA_TU_DIEN, v_ds);
            Hashtable v_htb = new Hashtable();
            foreach (DS_CM_DM_TU_DIEN.CM_DM_TU_DIENRow v_tu_dien in v_ds.CM_DM_TU_DIEN.Rows)
            {
                v_htb.Add(v_tu_dien[CM_DM_TU_DIEN.ID], v_tu_dien[CM_DM_TU_DIEN.TEN]);
            }
            return v_htb;
        }
        private void load_data_2_cbo_trang_thai_cau_hoi()
        {
            US_CM_DM_TU_DIEN v_us_tu_dien_trang_thai = new US_CM_DM_TU_DIEN();
            DS_CM_DM_TU_DIEN v_ds_tu_dien_trang_thai = new DS_CM_DM_TU_DIEN();
            v_us_tu_dien_trang_thai.fill_tu_dien_cung_loai_ds(LOAI_TU_DIEN_TEXT.TRANG_THAI_GD_CAU_HOI_SV, CM_DM_TU_DIEN.MA_TU_DIEN, v_ds_tu_dien_trang_thai);

            DataRow v_dr = v_ds_tu_dien_trang_thai.CM_DM_TU_DIEN.NewCM_DM_TU_DIENRow();
            v_dr[CM_DM_TU_DIEN.ID] = "0";
            v_dr[CM_DM_TU_DIEN.TEN] = "-- Tất cả --";
            v_ds_tu_dien_trang_thai.EnforceConstraints = false;
            v_ds_tu_dien_trang_thai.CM_DM_TU_DIEN.Rows.InsertAt(v_dr, 0);

            m_cbo_trang_thai_cau_hoi.DataSource = v_ds_tu_dien_trang_thai.CM_DM_TU_DIEN;
            m_cbo_trang_thai_cau_hoi.DisplayMember = CM_DM_TU_DIEN.TEN;
            m_cbo_trang_thai_cau_hoi.ValueMember = CM_DM_TU_DIEN.ID;
        }
		private void load_data_2_grid(){
            string v_str_co_assign_qlht_yn = "";
            if (m_rdb_assign_qlht_all.Checked) v_str_co_assign_qlht_yn = "A";
            else if (m_rdb_assign_qlht_y.Checked) v_str_co_assign_qlht_yn = "Y";
            else v_str_co_assign_qlht_yn = "N";
            m_ds = new DS_V_GD_CAU_HOI_YEU_CAU();
            m_ds.EnforceConstraints = false;
            m_us.fill_danh_sach_yeu_cau_hoc_vien(m_ds
                                         , m_txt_dien_thoai.Text.Trim()
                                         , m_txt_ho_ten.Text.Trim()
                                         , m_dat_tu_ngay.Value
                                         , m_dat_den_ngay.Value
                                         , CIPConvert.ToDecimal(m_cbo_trang_thai_cau_hoi.SelectedValue)
                                         , v_str_co_assign_qlht_yn);
			m_fg.Redraw = false;
			CGridUtils.Dataset2C1Grid(m_ds, m_fg, m_obj_trans);
			m_fg.Redraw = true;
            
            set_tree_on_grid();
            make_stt();
		}
        private void make_stt()
        {
            int v_dc_stt = 0;
            for (int i_stt = 1; i_stt <= m_fg.Rows.Count - 1; i_stt++)
            {
                if (m_fg.Rows[i_stt].IsNode)
                {
                    v_dc_stt = 0;
                }
                else
                {
                    v_dc_stt = v_dc_stt + 1;
                    m_fg[i_stt, (int)e_col_Number.STT] = v_dc_stt;
                }
            }
        }
		private void grid2us_object(US_V_GD_CAU_HOI_YEU_CAU i_us
			, int i_grid_row) {
			DataRow v_dr;
			v_dr = (DataRow) m_fg.Rows[i_grid_row].UserData;
			m_obj_trans.GridRow2DataRow(i_grid_row,v_dr);
			i_us.DataRow2Me(v_dr);
		}

        private void set_tree_on_grid()
        {
            m_fg.Subtotal(AggregateEnum.None
                         , 0
                         , (int)e_col_Number.SO_DIEN_THOAI
                         , (int)e_col_Number.SO_DIEN_THOAI
                         //, (int)e_col_Number.HO_TEN_SINH_VIEN
                         , "Điện thoại gọi: {0}");
            m_fg.Subtotal(AggregateEnum.None
                       , 1
                       , (int)e_col_Number.START_TIME
                       , (int)e_col_Number.START_TIME
                       , (int)e_col_Number.NOI_DUNG_CAU_HOI
                       , "Thời gian gọi: {0}");

        }
		private void us_object2grid(US_V_GD_CAU_HOI_YEU_CAU i_us
			, int i_grid_row) {
			DataRow v_dr = (DataRow) m_fg.Rows[i_grid_row].UserData;
			i_us.Me2DataRow(v_dr);
			m_obj_trans.DataRow2GridRow(v_dr, i_grid_row);
		}


		private void insert_v_gd_cau_hoi_yeu_cau(){			
		//	f300_dm_yeu_cau_hoc_vien_DE v_fDE = new  f300_dm_yeu_cau_hoc_vien_DE();								
		//	v_fDE.display();
			load_data_2_grid();
		}

		private void update_v_gd_cau_hoi_yeu_cau(){			
			if (!CGridUtils.IsThere_Any_NonFixed_Row(m_fg)) return;
			if (!CGridUtils.isValid_NonFixed_RowIndex(m_fg, m_fg.Row)) return;			
			grid2us_object(m_us, m_fg.Row);
		//	f300_dm_yeu_cau_hoc_vien_DE v_fDE = new f300_dm_yeu_cau_hoc_vien_DE();
		//	v_fDE.display(m_us);
			load_data_2_grid();
		}
				
		private void delete_v_gd_cau_hoi_yeu_cau(){
			if (!CGridUtils.IsThere_Any_NonFixed_Row(m_fg)) return;
			if (!CGridUtils.isValid_NonFixed_RowIndex(m_fg, m_fg.Row)) return;
			if (BaseMessages.askUser_DataCouldBeDeleted(8) != BaseMessages.IsDataCouldBeDeleted.CouldBeDeleted)  return;
			US_V_GD_CAU_HOI_YEU_CAU v_us = new US_V_GD_CAU_HOI_YEU_CAU();
			grid2us_object(v_us, m_fg.Row);
			try {			
				v_us.BeginTransaction();    											
				v_us.Delete();                      								
				v_us.CommitTransaction();
				m_fg.Rows.Remove(m_fg.Row);				
			}
			catch (Exception v_e) {
				v_us.Rollback();
				CDBExceptionHandler v_objErrHandler = new CDBExceptionHandler(v_e,
					new CDBClientDBExceptionInterpret());
				v_objErrHandler.showErrorMessage();
			}
		}

		private void view_v_gd_cau_hoi_yeu_cau(){			
			if (!CGridUtils.IsThere_Any_NonFixed_Row(m_fg)) return;
			if (!CGridUtils.isValid_NonFixed_RowIndex(m_fg, m_fg.Row)) return;
			grid2us_object(m_us, m_fg.Row);
		//	f300_dm_yeu_cau_hoc_vien_DE v_fDE = new f300_dm_yeu_cau_hoc_vien_DE();			
		//	v_fDE.display(m_us);
		}
		#endregion

//
		//
		//		EVENT HANLDERS
		//
		//
        private void set_define_events()
        {
            m_cmd_exit.Click += new EventHandler(m_cmd_exit_Click);
            m_cmd_goi_lai_hoc_vien.Click += new EventHandler(m_cmd_goi_lai_hoc_vien_Click);
            m_cmd_xu_ly_noi_bo.Click += new EventHandler(m_cmd_xu_ly_noi_bo_Click);
            m_cmd_xuat_excel.Click += new EventHandler(m_cmd_view_Click);
            m_cmd_loc_du_lieu.Click += new EventHandler(m_cmd_loc_du_lieu_Click);
            m_cmd_nghe_lai.Click += new EventHandler(m_cmd_nghe_lai_Click);
            this.KeyDown += new KeyEventHandler(f300_dm_yeu_cau_hoc_vien_KeyDown);
        }

        void f300_dm_yeu_cau_hoc_vien_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                switch (e.KeyCode)
                {
                    case Keys.Escape:
                        this.Close();
                        break;
                }
            }
            catch (Exception v_e)
            {
                CSystemLog_100.ExceptionHandle(v_e);
            }
        }

        void m_cmd_nghe_lai_Click(object sender, EventArgs e)
        {
            try
            {
                int v_i_row = 0;
                if (m_fg.Rows[m_fg.Row].IsNode)
                {
                    v_i_row = m_fg.Row - 1;
                }
                else v_i_row = m_fg.Row;
                if (!HelpUtils.is_validated_edit_grid_row(v_i_row, m_fg)) return;
                grid2us_object(m_us, v_i_row);
                US_GD_CUOC_GOI_YEU_CAU v_us_cuoc_goi = new US_GD_CUOC_GOI_YEU_CAU(m_us.dcID_YEU_CAU);
                HelpUtils.open_link_in_default_browser(HelpUtils.get_file_record(v_us_cuoc_goi.strVOICE_CALL_LINK));
            }
            catch (Exception)
            {
                BaseMessages.MsgBox_Infor("Link file ghi âm không tồn tại");
            }
        }

        void m_cmd_loc_du_lieu_Click(object sender, EventArgs e)
        {
            try
            {
                load_data_2_grid();
            }
            catch (Exception v_e)
            {
                CSystemLog_100.ExceptionHandle(v_e);
            }
        }
		private void f300_dm_yeu_cau_hoc_vien_Load(object sender, System.EventArgs e) {
			try{
				set_initial_form_load();
			}
			catch (Exception v_e){
				CSystemLog_100.ExceptionHandle(v_e);
			}
		
		}

		private void m_cmd_exit_Click(object sender, EventArgs e) {
			try{
				this.Close();
			}
			catch (Exception v_e){
				CSystemLog_100.ExceptionHandle(v_e);
			}
		}

        private void m_cmd_goi_lai_hoc_vien_Click(object sender, EventArgs e)
        {
			try{
                if (!HelpUtils.is_validated_edit_grid_row(m_fg.Row, m_fg)) return;
                f210_goi_lai_sinh_vien v_frm = new f210_goi_lai_sinh_vien();
                US_V_GD_CAU_HOI_YEU_CAU v_us_v_cau_hoi = new US_V_GD_CAU_HOI_YEU_CAU();
                DS_V_GD_CAU_HOI_YEU_CAU v_ds_v_cau_hoi = new DS_V_GD_CAU_HOI_YEU_CAU();
                v_us_v_cau_hoi.FillDataset(v_ds_v_cau_hoi, "where id = " + CIPConvert.ToDecimal(m_fg[m_fg.Row, (int)e_col_Number.ID]));
                if(v_ds_v_cau_hoi.V_GD_CAU_HOI_YEU_CAU.Rows.Count > 0)
                {
                    v_us_v_cau_hoi.DataRow2Me(v_ds_v_cau_hoi.V_GD_CAU_HOI_YEU_CAU.Rows[0]);
                    v_frm.display_xu_ly_cau_hoi(v_us_v_cau_hoi);
                }
                
			}
			catch (Exception v_e){
				CSystemLog_100.ExceptionHandle(v_e);
			}
		}

        private void m_cmd_xu_ly_noi_bo_Click(object sender, EventArgs e)
        {
			try{
                if (!HelpUtils.is_validated_edit_grid_row(m_fg.Row, m_fg)) return;
                f400_gd_xu_ly_noi_bo v_frm = new f400_gd_xu_ly_noi_bo();
                v_frm.display_xu_ly_cau_hoi(CIPConvert.ToDecimal(m_fg[m_fg.Row,(int)e_col_Number.ID]));
			}
			catch (Exception v_e){
				CSystemLog_100.ExceptionHandle(v_e);
			}
		}

		private void m_cmd_delete_Click(object sender, EventArgs e) {
			try{
				delete_v_gd_cau_hoi_yeu_cau();
			}
			catch (Exception v_e){
				CSystemLog_100.ExceptionHandle(v_e);
			}
		}

		private void m_cmd_view_Click(object sender, EventArgs e) {
			try{
				view_v_gd_cau_hoi_yeu_cau();
			}
			catch (Exception v_e){
				CSystemLog_100.ExceptionHandle(v_e);
			}
		}

        private void m_lb_header_Click(object sender, EventArgs e)
        {

        }

        private void m_txt_dien_thoai_TextChanged(object sender, EventArgs e)
        {

        }

	}
}

