///************************************************
/// Generated by: LinhDH
/// Date: 01/04/2014 11:15:52
/// Goal: Create Form for V_DM_BLACK_LIST
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
using TOSApp.App_Code;

using C1.Win.C1FlexGrid;
using IP.Core.IPSystemAdmin;

namespace TOSApp
{



	public class f430_quan_ly_blacklist : System.Windows.Forms.Form
	{
		internal System.Windows.Forms.ImageList ImageList;
		internal System.Windows.Forms.Panel m_pnl_out_place_dm;
		private C1.Win.C1FlexGrid.C1FlexGrid m_fg;
		internal SIS.Controls.Button.SiSButton m_cmd_remove_black_list;
		internal SIS.Controls.Button.SiSButton m_cmd_update;
		internal SIS.Controls.Button.SiSButton m_cmd_insert;
		internal SIS.Controls.Button.SiSButton m_cmd_exit;
		internal SIS.Controls.Button.SiSButton m_cmd_view;
        private Label m_lbl_header;
        private GroupBox groupBox4;
        private TextBox m_txt_ghi_chu_ly_do;
        private TextBox m_txt_so_dien_thoai;
        private Label label19;
        private Label label20;
        private TextBox m_txt_ten_chu_dien_thoai;
        private Label label1;
        private Label label2;
		private System.ComponentModel.IContainer components;

		public f430_quan_ly_blacklist()
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(f430_quan_ly_blacklist));
            this.ImageList = new System.Windows.Forms.ImageList(this.components);
            this.m_pnl_out_place_dm = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.m_cmd_update = new SIS.Controls.Button.SiSButton();
            this.m_cmd_view = new SIS.Controls.Button.SiSButton();
            this.m_cmd_remove_black_list = new SIS.Controls.Button.SiSButton();
            this.m_cmd_exit = new SIS.Controls.Button.SiSButton();
            this.m_cmd_insert = new SIS.Controls.Button.SiSButton();
            this.m_fg = new C1.Win.C1FlexGrid.C1FlexGrid();
            this.m_lbl_header = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.m_txt_ghi_chu_ly_do = new System.Windows.Forms.TextBox();
            this.m_txt_ten_chu_dien_thoai = new System.Windows.Forms.TextBox();
            this.m_txt_so_dien_thoai = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.m_pnl_out_place_dm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_fg)).BeginInit();
            this.groupBox4.SuspendLayout();
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
            this.m_pnl_out_place_dm.Controls.Add(this.label2);
            this.m_pnl_out_place_dm.Controls.Add(this.m_cmd_update);
            this.m_pnl_out_place_dm.Controls.Add(this.m_cmd_view);
            this.m_pnl_out_place_dm.Controls.Add(this.m_cmd_remove_black_list);
            this.m_pnl_out_place_dm.Controls.Add(this.m_cmd_exit);
            this.m_pnl_out_place_dm.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.m_pnl_out_place_dm.Location = new System.Drawing.Point(0, 446);
            this.m_pnl_out_place_dm.Name = "m_pnl_out_place_dm";
            this.m_pnl_out_place_dm.Padding = new System.Windows.Forms.Padding(4);
            this.m_pnl_out_place_dm.Size = new System.Drawing.Size(790, 36);
            this.m_pnl_out_place_dm.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(95, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Nhấn Ctrl + F để tìm kiếm trên lưới";
            // 
            // m_cmd_update
            // 
            this.m_cmd_update.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.m_cmd_update.BtnShape = SIS.Controls.Button.emunType.BtnShape.Rectangle;
            this.m_cmd_update.BtnStyle = SIS.Controls.Button.emunType.XPStyle.Default;
            this.m_cmd_update.Dock = System.Windows.Forms.DockStyle.Right;
            this.m_cmd_update.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_cmd_update.ImageIndex = 3;
            this.m_cmd_update.ImageList = this.ImageList;
            this.m_cmd_update.Location = new System.Drawing.Point(468, 4);
            this.m_cmd_update.Name = "m_cmd_update";
            this.m_cmd_update.Size = new System.Drawing.Size(88, 28);
            this.m_cmd_update.TabIndex = 0;
            this.m_cmd_update.Text = "&Sửa";
            // 
            // m_cmd_view
            // 
            this.m_cmd_view.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.m_cmd_view.BtnShape = SIS.Controls.Button.emunType.BtnShape.Rectangle;
            this.m_cmd_view.BtnStyle = SIS.Controls.Button.emunType.XPStyle.Default;
            this.m_cmd_view.Dock = System.Windows.Forms.DockStyle.Left;
            this.m_cmd_view.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_cmd_view.ImageIndex = 18;
            this.m_cmd_view.ImageList = this.ImageList;
            this.m_cmd_view.Location = new System.Drawing.Point(4, 4);
            this.m_cmd_view.Name = "m_cmd_view";
            this.m_cmd_view.Size = new System.Drawing.Size(88, 28);
            this.m_cmd_view.TabIndex = 21;
            this.m_cmd_view.Text = "Xem";
            // 
            // m_cmd_remove_black_list
            // 
            this.m_cmd_remove_black_list.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.m_cmd_remove_black_list.BtnShape = SIS.Controls.Button.emunType.BtnShape.Rectangle;
            this.m_cmd_remove_black_list.BtnStyle = SIS.Controls.Button.emunType.XPStyle.Default;
            this.m_cmd_remove_black_list.Dock = System.Windows.Forms.DockStyle.Right;
            this.m_cmd_remove_black_list.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_cmd_remove_black_list.ImageIndex = 4;
            this.m_cmd_remove_black_list.ImageList = this.ImageList;
            this.m_cmd_remove_black_list.Location = new System.Drawing.Point(556, 4);
            this.m_cmd_remove_black_list.Name = "m_cmd_remove_black_list";
            this.m_cmd_remove_black_list.Size = new System.Drawing.Size(142, 28);
            this.m_cmd_remove_black_list.TabIndex = 1;
            this.m_cmd_remove_black_list.Text = "&Remove khỏi Blacklist";
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
            this.m_cmd_exit.Location = new System.Drawing.Point(698, 4);
            this.m_cmd_exit.Name = "m_cmd_exit";
            this.m_cmd_exit.Size = new System.Drawing.Size(88, 28);
            this.m_cmd_exit.TabIndex = 2;
            this.m_cmd_exit.Text = "Thoát (Esc)";
            // 
            // m_cmd_insert
            // 
            this.m_cmd_insert.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.m_cmd_insert.BtnShape = SIS.Controls.Button.emunType.BtnShape.Rectangle;
            this.m_cmd_insert.BtnStyle = SIS.Controls.Button.emunType.XPStyle.Default;
            this.m_cmd_insert.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_cmd_insert.ImageIndex = 10;
            this.m_cmd_insert.ImageList = this.ImageList;
            this.m_cmd_insert.Location = new System.Drawing.Point(679, 36);
            this.m_cmd_insert.Name = "m_cmd_insert";
            this.m_cmd_insert.Size = new System.Drawing.Size(88, 71);
            this.m_cmd_insert.TabIndex = 3;
            this.m_cmd_insert.Text = "&Thêm";
            // 
            // m_fg
            // 
            this.m_fg.ColumnInfo = resources.GetString("m_fg.ColumnInfo");
            this.m_fg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_fg.Location = new System.Drawing.Point(0, 172);
            this.m_fg.Name = "m_fg";
            this.m_fg.Size = new System.Drawing.Size(790, 274);
            this.m_fg.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(resources.GetString("m_fg.Styles"));
            this.m_fg.TabIndex = 1;
            // 
            // m_lbl_header
            // 
            this.m_lbl_header.Dock = System.Windows.Forms.DockStyle.Top;
            this.m_lbl_header.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_lbl_header.ForeColor = System.Drawing.Color.Maroon;
            this.m_lbl_header.Location = new System.Drawing.Point(0, 0);
            this.m_lbl_header.Name = "m_lbl_header";
            this.m_lbl_header.Size = new System.Drawing.Size(790, 40);
            this.m_lbl_header.TabIndex = 26;
            this.m_lbl_header.Text = "F430 - Quản lý danh sách Blacklist";
            this.m_lbl_header.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.m_cmd_insert);
            this.groupBox4.Controls.Add(this.m_txt_ghi_chu_ly_do);
            this.groupBox4.Controls.Add(this.m_txt_ten_chu_dien_thoai);
            this.groupBox4.Controls.Add(this.m_txt_so_dien_thoai);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.label19);
            this.groupBox4.Controls.Add(this.label20);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox4.Location = new System.Drawing.Point(0, 40);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(790, 132);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Thông tin Quản lý học tập";
            // 
            // m_txt_ghi_chu_ly_do
            // 
            this.m_txt_ghi_chu_ly_do.BackColor = System.Drawing.Color.White;
            this.m_txt_ghi_chu_ly_do.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.m_txt_ghi_chu_ly_do.Location = new System.Drawing.Point(122, 73);
            this.m_txt_ghi_chu_ly_do.Multiline = true;
            this.m_txt_ghi_chu_ly_do.Name = "m_txt_ghi_chu_ly_do";
            this.m_txt_ghi_chu_ly_do.Size = new System.Drawing.Size(528, 34);
            this.m_txt_ghi_chu_ly_do.TabIndex = 2;
            // 
            // m_txt_ten_chu_dien_thoai
            // 
            this.m_txt_ten_chu_dien_thoai.BackColor = System.Drawing.Color.White;
            this.m_txt_ten_chu_dien_thoai.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.m_txt_ten_chu_dien_thoai.Location = new System.Drawing.Point(474, 36);
            this.m_txt_ten_chu_dien_thoai.Name = "m_txt_ten_chu_dien_thoai";
            this.m_txt_ten_chu_dien_thoai.Size = new System.Drawing.Size(176, 20);
            this.m_txt_ten_chu_dien_thoai.TabIndex = 1;
            // 
            // m_txt_so_dien_thoai
            // 
            this.m_txt_so_dien_thoai.BackColor = System.Drawing.Color.White;
            this.m_txt_so_dien_thoai.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.m_txt_so_dien_thoai.Location = new System.Drawing.Point(122, 36);
            this.m_txt_so_dien_thoai.Name = "m_txt_so_dien_thoai";
            this.m_txt_so_dien_thoai.Size = new System.Drawing.Size(140, 20);
            this.m_txt_so_dien_thoai.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(312, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Họ tên người chủ số điện thoại";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(45, 83);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(69, 13);
            this.label19.TabIndex = 11;
            this.label19.Text = "Ghi chú lý do";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(44, 38);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(70, 13);
            this.label20.TabIndex = 10;
            this.label20.Text = "Số điện thoại";
            // 
            // f430_quan_ly_blacklist
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(790, 482);
            this.Controls.Add(this.m_fg);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.m_lbl_header);
            this.Controls.Add(this.m_pnl_out_place_dm);
            this.Name = "f430_quan_ly_blacklist";
            this.Text = "F430 - Quản lý danh sách Blacklist";
            this.Load += new System.EventHandler(this.f430_quan_ly_blacklist_Load);
            this.m_pnl_out_place_dm.ResumeLayout(false);
            this.m_pnl_out_place_dm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_fg)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
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
			 STT = 1            , SO_DIEN_THOAI = 2            ,ACCOUNT_NGUOI_ADD = 6            ,HO_TEN_CHU_DIEN_THOAI = 3            , GHI_CHU_LY_DO = 4            ,NGAY_ADD = 5
		}			
		#endregion

		#region Members
		ITransferDataRow m_obj_trans;		
		DS_V_DM_BLACK_LIST m_ds = new DS_V_DM_BLACK_LIST();
		US_V_DM_BLACK_LIST m_us = new US_V_DM_BLACK_LIST();
		#endregion

		#region Private Methods
		private void format_controls(){
			CControlFormat.setFormStyle(this, new CAppContext_201(), IPFormStyle.DialogForm);
			CControlFormat.setC1FlexFormat(m_fg);
			CGridUtils.AddSearch_Handlers(m_fg);
            CGridUtils.AddSave_Excel_Handlers(m_fg);

            m_lbl_header.Font = new Font("Arial", 16);
            m_lbl_header.ForeColor = Color.DarkRed;
            m_lbl_header.TextAlign = ContentAlignment.MiddleCenter;

            m_cmd_view.Visible = false;
            m_cmd_update.Visible = false;
            m_txt_so_dien_thoai.Focus();
			set_define_events();
			this.KeyPreview = true;
		}
		private void set_initial_form_load(){						
			m_obj_trans = get_trans_object(m_fg);
			load_data_2_grid();		
		}	
		private ITransferDataRow get_trans_object(C1.Win.C1FlexGrid.C1FlexGrid i_fg){
			Hashtable v_htb = new Hashtable();
			v_htb.Add(V_DM_BLACK_LIST.SO_DIEN_THOAI, e_col_Number.SO_DIEN_THOAI);			v_htb.Add(V_DM_BLACK_LIST.ACCOUNT_NGUOI_ADD, e_col_Number.ACCOUNT_NGUOI_ADD);			v_htb.Add(V_DM_BLACK_LIST.HO_TEN_CHU_DIEN_THOAI, e_col_Number.HO_TEN_CHU_DIEN_THOAI);
            v_htb.Add(V_DM_BLACK_LIST.GHI_CHU_LY_DO, e_col_Number.GHI_CHU_LY_DO);			v_htb.Add(V_DM_BLACK_LIST.NGAY_ADD, e_col_Number.NGAY_ADD);									
			ITransferDataRow v_obj_trans = new CC1TransferDataRow(i_fg,v_htb,m_ds.V_DM_BLACK_LIST.NewRow());
			return v_obj_trans;			
		}
		private void load_data_2_grid(){						
			m_ds = new DS_V_DM_BLACK_LIST();
            m_us.load_blacklist_by_dien_thoai(m_ds, "");
			m_fg.Redraw = false;
			CGridUtils.Dataset2C1Grid(m_ds, m_fg, m_obj_trans);
			m_fg.Redraw = true;
		}
		private void grid2us_object(US_V_DM_BLACK_LIST i_us
			, int i_grid_row) {
			DataRow v_dr;
			v_dr = (DataRow) m_fg.Rows[i_grid_row].UserData;
			m_obj_trans.GridRow2DataRow(i_grid_row,v_dr);
			i_us.DataRow2Me(v_dr);
		}

        private void reset_form()
        {
            m_txt_ghi_chu_ly_do.Text = "";
            m_txt_so_dien_thoai.Text = "";
            m_txt_ten_chu_dien_thoai.Text = "";
        }
		private void us_object2grid(US_V_DM_BLACK_LIST i_us
			, int i_grid_row) {
			DataRow v_dr = (DataRow) m_fg.Rows[i_grid_row].UserData;
			i_us.Me2DataRow(v_dr);
			m_obj_trans.DataRow2GridRow(v_dr, i_grid_row);
		}


		private void insert_v_dm_black_list(){
            int v_i_check_validate = check_validate();
            switch (v_i_check_validate)
            {
                case 0:
                    break;
                case 1:
                    if (!BaseMessages.MsgBox_Confirm(THONG_BAO.CF_ADD_BLACKLIST)) return;
                    form_2_us_obj();
                    try
                    {
                        CAddRemoveBlackListData v_add_bl_data = new CAddRemoveBlackListData();
                        v_add_bl_data = CallCenterUtils.add_remove_blacklist(m_us.strSO_DIEN_THOAI, 10);
                        if (v_add_bl_data.Status == TRANG_THAI_GOI_WS.THAT_BAI)
                        {
                            BaseMessages.MsgBox_Infor(THONG_BAO.ER_KHONG_ADD_BLACKLIST_DUOC);
                            HelpUtils.ghi_log_he_thong(LOG_TRUY_CAP.ADD_BLACKLIST, "BLACK_LIST", "Add blacklist: " + m_us.strSO_DIEN_THOAI, "Error");
                            break;
                        }
                        m_us.readd_black_list();
                        HelpUtils.ghi_log_he_thong(LOG_TRUY_CAP.ADD_BLACKLIST, "BLACK_LIST", "Add blacklist: " + m_us.strSO_DIEN_THOAI, "Readd");
                        BaseMessages.MsgBox_Infor(THONG_BAO.SC_ADD_BLACKLIST_THANH_CONG);
                    }
                    catch (Exception v_e)
                    {
                        CSystemLog_100.ExceptionHandle(v_e);
                    }
                    break;
                case 2:
                    form_2_us_obj();
                    try
                    {
                        CAddRemoveBlackListData v_add_bl_data = new CAddRemoveBlackListData();
                        v_add_bl_data = CallCenterUtils.add_remove_blacklist(m_us.strSO_DIEN_THOAI, 10);
                        if (v_add_bl_data.Status == TRANG_THAI_GOI_WS.THAT_BAI)
                        {
                            BaseMessages.MsgBox_Infor(THONG_BAO.ER_KHONG_ADD_BLACKLIST_DUOC);
                            HelpUtils.ghi_log_he_thong(LOG_TRUY_CAP.ADD_BLACKLIST, "BLACK_LIST", "Add blacklist: " + m_us.strSO_DIEN_THOAI, "Error");
                            break;
                        }
                        m_us.Insert();
                        HelpUtils.ghi_log_he_thong(LOG_TRUY_CAP.ADD_BLACKLIST, "BLACK_LIST", "Add blacklist: " + m_us.strSO_DIEN_THOAI, "Add");
                        BaseMessages.MsgBox_Infor(THONG_BAO.SC_ADD_BLACKLIST_THANH_CONG);
                    }
                    catch (Exception v_e)
                    {
                        CSystemLog_100.ExceptionHandle(v_e);
                    }
                    break;
            }
			load_data_2_grid();
            reset_form();
		}

		private void update_v_dm_black_list(){			
			if (!CGridUtils.IsThere_Any_NonFixed_Row(m_fg)) return;
			if (!CGridUtils.isValid_NonFixed_RowIndex(m_fg, m_fg.Row)) return;			
			grid2us_object(m_us, m_fg.Row);
		//	f430_quan_ly_blacklist_DE v_fDE = new f430_quan_ly_blacklist_DE();
		//	v_fDE.display(m_us);
			load_data_2_grid();
		}
				
		private void remove_v_dm_black_list(){
            if (!HelpUtils.is_validated_edit_grid_row(m_fg.Row, m_fg)) return;
			if (!BaseMessages.MsgBox_Confirm(THONG_BAO.CF_REMOVE_BLACKLIST))  return;
			US_V_DM_BLACK_LIST v_us = new US_V_DM_BLACK_LIST();
			grid2us_object(v_us, m_fg.Row);
			try {
                v_us.BeginTransaction();
                CAddRemoveBlackListData v_add_bl_data = new CAddRemoveBlackListData();
                v_add_bl_data = CallCenterUtils.add_remove_blacklist(v_us.strSO_DIEN_THOAI, 20);
                if (v_add_bl_data.Status == TRANG_THAI_GOI_WS.THAT_BAI)
                {
                    BaseMessages.MsgBox_Infor(THONG_BAO.ER_REMOVE_BLACKLIST_KO_THANH_CONG);
                    HelpUtils.ghi_log_he_thong(LOG_TRUY_CAP.REMOVE_BLACKLIST, "BLACK_LIST", "Remove blacklist: " + m_us.strSO_DIEN_THOAI, "Error");
                    return;
                }
                v_us.dcID_NGUOI_REMOVE = CAppContext_201.getCurrentUserID();
                v_us.Update();
                HelpUtils.ghi_log_he_thong(LOG_TRUY_CAP.REMOVE_BLACKLIST, "BLACK_LIST", "Remove blacklist: " + m_us.strSO_DIEN_THOAI, "Remove");
                BaseMessages.MsgBox_Infor(THONG_BAO.SC_REMOVE_BLACKLIST_THANH_CONG);
                v_us.CommitTransaction();
                load_data_2_grid();
			}
			catch (Exception v_e) {
				v_us.Rollback();
                CSystemLog_100.ExceptionHandle(v_e);
			}
		}

		private void view_v_dm_black_list(){			
			if (!CGridUtils.IsThere_Any_NonFixed_Row(m_fg)) return;
			if (!CGridUtils.isValid_NonFixed_RowIndex(m_fg, m_fg.Row)) return;
			grid2us_object(m_us, m_fg.Row);
		//	f430_quan_ly_blacklist_DE v_fDE = new f430_quan_ly_blacklist_DE();			
		//	v_fDE.display(m_us);
		}
		private void set_define_events(){
			m_cmd_exit.Click += new EventHandler(m_cmd_exit_Click);
			m_cmd_insert.Click += new EventHandler(m_cmd_insert_Click);
			m_cmd_update.Click += new EventHandler(m_cmd_update_Click);
			m_cmd_remove_black_list.Click += new EventHandler(m_cmd_delete_Click);
			m_cmd_view.Click += new EventHandler(m_cmd_view_Click);
            this.KeyDown += new KeyEventHandler(f430_quan_ly_blacklist_KeyDown);
		}

        private void form_2_us_obj()
        {
            m_us.dcID_NGUOI_ADD = CAppContext_201.getCurrentUserID();
            m_us.strHO_TEN_CHU_DIEN_THOAI = m_txt_ten_chu_dien_thoai.Text.Trim();
            m_us.strSO_DIEN_THOAI = m_txt_so_dien_thoai.Text.Trim();
            m_us.strGHI_CHU_LY_DO = m_txt_ghi_chu_ly_do.Text.Trim();
        }

        /// <summary>
        /// 0: ko cho add
        /// 1: đã có, đã block 1 lần rồi; và add tiếp (update)
        /// 2: chưa có, oke add
        /// </summary>
        /// <returns></returns>
        private int check_validate()
        {
            if (!CValidateTextBox.IsValid(m_txt_so_dien_thoai, DataType.StringType, allowNull.NO)) return 0;
            m_us.load_blacklist_by_dien_thoai(m_ds, m_txt_so_dien_thoai.Text.Trim());
            // nếu số điện thoại đã tồn tại trong ds blacklist
            if (m_ds.V_DM_BLACK_LIST.Rows.Count > 0)
            {
                // Nếu đã add vào nhưng lại đang ở chế độ remove rồi
                if (m_ds.V_DM_BLACK_LIST.Rows[0][V_DM_BLACK_LIST.ADD_YN].ToString().Equals("N"))
                {
                    if (BaseMessages.MsgBox_Confirm("Số điện thoại này đã được remove khỏi blacklist một lần. Bạn có chắc muốn add số điện thoại này vào blacklist không?"))
                    {
                        return 1;
                    }
                    else return 0;
                }
            }
            return 2;
        }
        #endregion

        #region Events
        void f430_quan_ly_blacklist_KeyDown(object sender, KeyEventArgs e)
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
        private void f430_quan_ly_blacklist_Load(object sender, System.EventArgs e) {
			try{
				set_initial_form_load();
			}
			catch (Exception v_e){
				CSystemLog_301.ExceptionHandle(v_e);
			}
		
		}

		private void m_cmd_exit_Click(object sender, EventArgs e) {
			try{
				this.Close();
			}
			catch (Exception v_e){
				CSystemLog_301.ExceptionHandle(v_e);
			}
		}

		private void m_cmd_insert_Click(object sender, EventArgs e) {
			try{
				insert_v_dm_black_list();
			}
			catch (Exception v_e){
				CSystemLog_301.ExceptionHandle(v_e);
			}
		}

		private void m_cmd_update_Click(object sender, EventArgs e) {
			try{
				update_v_dm_black_list();
			}
			catch (Exception v_e){
				CSystemLog_301.ExceptionHandle(v_e);
			}
		}

		private void m_cmd_delete_Click(object sender, EventArgs e) {
			try{
				remove_v_dm_black_list();
			}
			catch (Exception v_e){
				CSystemLog_301.ExceptionHandle(v_e);
			}
		}

		private void m_cmd_view_Click(object sender, EventArgs e) {
			try{
				view_v_dm_black_list();
			}
			catch (Exception v_e){
				CSystemLog_301.ExceptionHandle(v_e);
			}
        }
        
        #endregion
    }
}

