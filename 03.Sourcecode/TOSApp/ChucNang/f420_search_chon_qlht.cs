///************************************************
/// Generated by: LinhDH
/// Date: 13/03/2014 07:40:18
/// Goal: Create Form for DM_QLHT_SCM
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
	public class f420_search_chon_qlht : System.Windows.Forms.Form
	{
		internal System.Windows.Forms.ImageList ImageList;
		internal System.Windows.Forms.Panel m_pnl_out_place_dm;
        private C1.Win.C1FlexGrid.C1FlexGrid m_fg;
		internal SIS.Controls.Button.SiSButton m_cmd_exit;
		internal SIS.Controls.Button.SiSButton m_cmd_select;
        private Label m_lbl_header;
        private Panel m_pnl_search_area;
        private GroupBox m_grb_dm_cau_hoi;
        private TextBox m_txt_key_ten_qlht;
        private Label label11;
        private TextBox m_txt_key_ma_lop;
        private Label label1;
        private ComboBox m_cbo_qlht_truong;
        private Label label16;
        internal SIS.Controls.Button.SiSButton m_cmd_loc;
		private System.ComponentModel.IContainer components;

        public f420_search_chon_qlht()
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(f420_search_chon_qlht));
            this.ImageList = new System.Windows.Forms.ImageList(this.components);
            this.m_pnl_out_place_dm = new System.Windows.Forms.Panel();
            this.m_cmd_select = new SIS.Controls.Button.SiSButton();
            this.m_cmd_exit = new SIS.Controls.Button.SiSButton();
            this.m_fg = new C1.Win.C1FlexGrid.C1FlexGrid();
            this.m_lbl_header = new System.Windows.Forms.Label();
            this.m_pnl_search_area = new System.Windows.Forms.Panel();
            this.m_cmd_loc = new SIS.Controls.Button.SiSButton();
            this.m_cbo_qlht_truong = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.m_txt_key_ma_lop = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.m_txt_key_ten_qlht = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.m_grb_dm_cau_hoi = new System.Windows.Forms.GroupBox();
            this.m_pnl_out_place_dm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_fg)).BeginInit();
            this.m_pnl_search_area.SuspendLayout();
            this.m_grb_dm_cau_hoi.SuspendLayout();
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
            this.m_pnl_out_place_dm.Controls.Add(this.m_cmd_select);
            this.m_pnl_out_place_dm.Controls.Add(this.m_cmd_exit);
            this.m_pnl_out_place_dm.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.m_pnl_out_place_dm.Location = new System.Drawing.Point(0, 421);
            this.m_pnl_out_place_dm.Name = "m_pnl_out_place_dm";
            this.m_pnl_out_place_dm.Padding = new System.Windows.Forms.Padding(4);
            this.m_pnl_out_place_dm.Size = new System.Drawing.Size(648, 41);
            this.m_pnl_out_place_dm.TabIndex = 19;
            // 
            // m_cmd_select
            // 
            this.m_cmd_select.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.m_cmd_select.BtnShape = SIS.Controls.Button.emunType.BtnShape.Rectangle;
            this.m_cmd_select.BtnStyle = SIS.Controls.Button.emunType.XPStyle.Default;
            this.m_cmd_select.Dock = System.Windows.Forms.DockStyle.Left;
            this.m_cmd_select.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_cmd_select.ImageIndex = 13;
            this.m_cmd_select.ImageList = this.ImageList;
            this.m_cmd_select.Location = new System.Drawing.Point(4, 4);
            this.m_cmd_select.Name = "m_cmd_select";
            this.m_cmd_select.Size = new System.Drawing.Size(81, 33);
            this.m_cmd_select.TabIndex = 0;
            this.m_cmd_select.Text = "Chọn";
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
            this.m_cmd_exit.Location = new System.Drawing.Point(556, 4);
            this.m_cmd_exit.Name = "m_cmd_exit";
            this.m_cmd_exit.Size = new System.Drawing.Size(88, 33);
            this.m_cmd_exit.TabIndex = 1;
            this.m_cmd_exit.Text = "Thoát (Esc)";
            // 
            // m_fg
            // 
            this.m_fg.ColumnInfo = resources.GetString("m_fg.ColumnInfo");
            this.m_fg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_fg.Location = new System.Drawing.Point(3, 16);
            this.m_fg.Name = "m_fg";
            this.m_fg.Size = new System.Drawing.Size(642, 272);
            this.m_fg.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(resources.GetString("m_fg.Styles"));
            this.m_fg.TabIndex = 20;
            // 
            // m_lbl_header
            // 
            this.m_lbl_header.Dock = System.Windows.Forms.DockStyle.Top;
            this.m_lbl_header.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_lbl_header.ForeColor = System.Drawing.Color.Maroon;
            this.m_lbl_header.Location = new System.Drawing.Point(0, 0);
            this.m_lbl_header.Name = "m_lbl_header";
            this.m_lbl_header.Size = new System.Drawing.Size(648, 40);
            this.m_lbl_header.TabIndex = 24;
            this.m_lbl_header.Text = "F420 - Chọn Quản lý học tập";
            this.m_lbl_header.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // m_pnl_search_area
            // 
            this.m_pnl_search_area.Controls.Add(this.m_cmd_loc);
            this.m_pnl_search_area.Controls.Add(this.m_cbo_qlht_truong);
            this.m_pnl_search_area.Controls.Add(this.label16);
            this.m_pnl_search_area.Controls.Add(this.m_txt_key_ma_lop);
            this.m_pnl_search_area.Controls.Add(this.label1);
            this.m_pnl_search_area.Controls.Add(this.m_txt_key_ten_qlht);
            this.m_pnl_search_area.Controls.Add(this.label11);
            this.m_pnl_search_area.Dock = System.Windows.Forms.DockStyle.Top;
            this.m_pnl_search_area.Location = new System.Drawing.Point(0, 40);
            this.m_pnl_search_area.Name = "m_pnl_search_area";
            this.m_pnl_search_area.Size = new System.Drawing.Size(648, 90);
            this.m_pnl_search_area.TabIndex = 0;
            // 
            // m_cmd_loc
            // 
            this.m_cmd_loc.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.m_cmd_loc.BtnShape = SIS.Controls.Button.emunType.BtnShape.Rectangle;
            this.m_cmd_loc.BtnStyle = SIS.Controls.Button.emunType.XPStyle.Default;
            this.m_cmd_loc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.m_cmd_loc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_cmd_loc.ImageIndex = 5;
            this.m_cmd_loc.ImageList = this.ImageList;
            this.m_cmd_loc.Location = new System.Drawing.Point(437, 46);
            this.m_cmd_loc.Name = "m_cmd_loc";
            this.m_cmd_loc.Size = new System.Drawing.Size(95, 37);
            this.m_cmd_loc.TabIndex = 3;
            this.m_cmd_loc.Text = "&Tìm kiếm";
            // 
            // m_cbo_qlht_truong
            // 
            this.m_cbo_qlht_truong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.m_cbo_qlht_truong.FormattingEnabled = true;
            this.m_cbo_qlht_truong.Location = new System.Drawing.Point(407, 18);
            this.m_cbo_qlht_truong.Name = "m_cbo_qlht_truong";
            this.m_cbo_qlht_truong.Size = new System.Drawing.Size(125, 21);
            this.m_cbo_qlht_truong.TabIndex = 2;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(359, 22);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(41, 13);
            this.label16.TabIndex = 21;
            this.label16.Text = "Trường";
            // 
            // m_txt_key_ma_lop
            // 
            this.m_txt_key_ma_lop.Location = new System.Drawing.Point(162, 59);
            this.m_txt_key_ma_lop.Name = "m_txt_key_ma_lop";
            this.m_txt_key_ma_lop.Size = new System.Drawing.Size(158, 20);
            this.m_txt_key_ma_lop.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Mã lớp quản lý";
            // 
            // m_txt_key_ten_qlht
            // 
            this.m_txt_key_ten_qlht.Location = new System.Drawing.Point(162, 17);
            this.m_txt_key_ten_qlht.Name = "m_txt_key_ten_qlht";
            this.m_txt_key_ten_qlht.Size = new System.Drawing.Size(158, 20);
            this.m_txt_key_ten_qlht.TabIndex = 0;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(80, 20);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(71, 13);
            this.label11.TabIndex = 8;
            this.label11.Text = "Họ tên QLHT";
            // 
            // m_grb_dm_cau_hoi
            // 
            this.m_grb_dm_cau_hoi.Controls.Add(this.m_fg);
            this.m_grb_dm_cau_hoi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_grb_dm_cau_hoi.Location = new System.Drawing.Point(0, 130);
            this.m_grb_dm_cau_hoi.Name = "m_grb_dm_cau_hoi";
            this.m_grb_dm_cau_hoi.Size = new System.Drawing.Size(648, 291);
            this.m_grb_dm_cau_hoi.TabIndex = 1;
            this.m_grb_dm_cau_hoi.TabStop = false;
            this.m_grb_dm_cau_hoi.Text = "Danh sách Quản lý học tập";
            // 
            // f420_search_chon_qlht
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(648, 462);
            this.Controls.Add(this.m_grb_dm_cau_hoi);
            this.Controls.Add(this.m_pnl_search_area);
            this.Controls.Add(this.m_lbl_header);
            this.Controls.Add(this.m_pnl_out_place_dm);
            this.Name = "f420_search_chon_qlht";
            this.Text = "F420 - Chọn Quản lý học tập";
            this.m_pnl_out_place_dm.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.m_fg)).EndInit();
            this.m_pnl_search_area.ResumeLayout(false);
            this.m_pnl_search_area.PerformLayout();
            this.m_grb_dm_cau_hoi.ResumeLayout(false);
            this.ResumeLayout(false);

		}
		#endregion

		#region Public Interface
		public DialogResult display_search(string i_str_key_search, US_V_DM_CAU_HOI i_us){
            m_txt_key_ten_qlht.Text = i_str_key_search;
            //m_us_cau_hoi = i_us;
			this.ShowDialog();
            return m_dlg_result;
		}
        public US_DM_QLHT_SCM display()
        {
            this.ShowDialog();
            return m_us_dm_qlht_scm;
        }
		#endregion

		#region Data Structure
		private enum e_col_Number{
             MA_TRUONG = 1
            , HO_TEN_QLHT = 2
            , ACCOUNT_SCM = 3
		}
		#endregion

		#region Members
		ITransferDataRow m_obj_trans;
        DialogResult m_dlg_result;
        DataSet m_ds_qlht = new DataSet();
        US_DM_QLHT_SCM m_us_dm_qlht_scm = new US_DM_QLHT_SCM();
        DS_DM_QLHT_SCM m_ds_dm_qlht_scm = new DS_DM_QLHT_SCM();
        SCMServices.SyncData m_scm_ws;
        
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

            m_fg.Tree.Style = TreeStyleFlags.SimpleLeaf;
            m_fg.Tree.Column = (int)e_col_Number.HO_TEN_QLHT;

            m_fg.Cols[(int)e_col_Number.MA_TRUONG].Visible = false;
            this.MaximizeBox = true;
            this.MinimizeBox = true;
            m_txt_key_ten_qlht.Focus();
            
			set_define_events();
			this.KeyPreview = true;		
		}
		private void set_initial_form_load(){
            load_data_2_cbo_truong();
            m_obj_trans = get_trans_object(m_fg);
            //load_data_2_grid();		
		}	
		private ITransferDataRow get_trans_object(C1.Win.C1FlexGrid.C1FlexGrid i_fg){
			Hashtable v_htb = new Hashtable();
            v_htb.Add(DM_QLHT_SCM.MA_TRUONG, e_col_Number.MA_TRUONG);
            v_htb.Add(DM_QLHT_SCM.TEN_THAT, e_col_Number.HO_TEN_QLHT);
            v_htb.Add(DM_QLHT_SCM.ACCOUNT, e_col_Number.ACCOUNT_SCM);

            ITransferDataRow v_obj_trans = new CC1TransferDataRow(i_fg, v_htb, m_ds_dm_qlht_scm.DM_QLHT_SCM.NewRow());
			return v_obj_trans;			
		}
        private Hashtable get_data_map_trang_thai()
        {
            US_CM_DM_TU_DIEN v_us = new US_CM_DM_TU_DIEN();
            DS_CM_DM_TU_DIEN v_ds = new DS_CM_DM_TU_DIEN();
            v_us.fill_tu_dien_cung_loai_ds(LOAI_TU_DIEN_TEXT.TRANG_THAI_DM_CAU_TRA_LOI, CM_DM_TU_DIEN.MA_TU_DIEN, v_ds);
            Hashtable v_htb = new Hashtable();
            foreach (DS_CM_DM_TU_DIEN.CM_DM_TU_DIENRow v_tu_dien in v_ds.CM_DM_TU_DIEN.Rows)
            {
                v_htb.Add(v_tu_dien[CM_DM_TU_DIEN.ID], v_tu_dien[CM_DM_TU_DIEN.TEN]);
            }
            return v_htb;
        }
        private void load_data_2_grid(){
            string v_str_key_search = "";
            string v_str_ho_ten = m_txt_key_ten_qlht.Text.Trim();
            string v_str_ma_lop = m_txt_key_ma_lop.Text.Trim();
            string v_str_ma_truong =CIPConvert.ToStr(m_cbo_qlht_truong.SelectedValue);
            v_str_key_search = HelpUtils.gen_string_call_scm_get_QLHT_ws("", v_str_ho_ten, v_str_ma_truong, v_str_ma_lop, "20");
            
            m_ds_dm_qlht_scm = new DS_DM_QLHT_SCM();
            m_scm_ws = new SCMServices.SyncData();
            m_ds_qlht = m_scm_ws.TOS_search_qlht_all_T(v_str_key_search);
            
            dataset_2_ds_qlht();

            m_fg.Redraw = false;
            CGridUtils.Dataset2C1Grid(m_ds_dm_qlht_scm, m_fg, m_obj_trans);
            set_tree_on_grid();
            m_fg.Redraw = true;
            m_fg.Focus();
		}
        private void dataset_2_ds_qlht()
        {
            DataRow v_dr;
            for (int v_i = 0; v_i < m_ds_qlht.Tables[0].Rows.Count; v_i++)
            {
                v_dr = m_ds_dm_qlht_scm.DM_QLHT_SCM.NewDM_QLHT_SCMRow();
                v_dr[DM_QLHT_SCM.ID] = m_ds_qlht.Tables[0].Rows[v_i][DM_QLHT_SCM.ID];
                v_dr[DM_QLHT_SCM.ACCOUNT] = m_ds_qlht.Tables[0].Rows[v_i][DM_QLHT_SCM.ACCOUNT];
                v_dr[DM_QLHT_SCM.TEN_THAT] = m_ds_qlht.Tables[0].Rows[v_i][DM_QLHT_SCM.TEN_THAT];
                //v_dr[DM_QLHT_SCM.MA_LOP] = m_ds_qlht.Tables[0].Rows[v_i][DM_QLHT_SCM.MA_LOP];
                v_dr[DM_QLHT_SCM.MA_TRUONG] = m_ds_qlht.Tables[0].Rows[v_i][DM_QLHT_SCM.MA_TRUONG];

                m_ds_dm_qlht_scm.DM_QLHT_SCM.Rows.InsertAt(v_dr, v_i);
            }
        }
        private void set_tree_on_grid()
        {
            m_fg.Subtotal(AggregateEnum.None
                         , 0
                         , (int)e_col_Number.MA_TRUONG
                         , (int)e_col_Number.MA_TRUONG
                         , "Tổ chức, đơn vị: {0}");
        }
        
        private void grid2us_object(US_DM_QLHT_SCM i_us
			, int i_grid_row) {
			DataRow v_dr;
			v_dr = (DataRow) m_fg.Rows[i_grid_row].UserData;
			m_obj_trans.GridRow2DataRow(i_grid_row,v_dr);
			i_us.DataRow2Me(v_dr);
		}

        private void load_data_2_cbo_truong()
        {
            US_CM_DM_TU_DIEN v_us_tu_dien = new US_CM_DM_TU_DIEN();
            DS_CM_DM_TU_DIEN v_ds_tu_dien = new DS_CM_DM_TU_DIEN();
            string v_str_loai_tu_dien = LOAI_TU_DIEN_ID.TO_CHUC_TRUONG.ToString();

            v_us_tu_dien.fill_tu_dien_by_procedure("pr_CM_DM_TU_DIEN_Load_tu_dien_by_procedure", v_str_loai_tu_dien, v_ds_tu_dien);
            
            m_cbo_qlht_truong.DisplayMember = CM_DM_TU_DIEN.MA_TU_DIEN;
            m_cbo_qlht_truong.ValueMember = CM_DM_TU_DIEN.TEN_NGAN;
            m_cbo_qlht_truong.DataSource = v_ds_tu_dien.CM_DM_TU_DIEN;
        }
        private void us_object2grid(US_DM_QLHT_SCM i_us
			, int i_grid_row) {
			DataRow v_dr = (DataRow) m_fg.Rows[i_grid_row].UserData;
			i_us.Me2DataRow(v_dr);
			m_obj_trans.DataRow2GridRow(v_dr, i_grid_row);
		}
        #endregion

        #region Events
        private void set_define_events(){
			m_cmd_exit.Click += new EventHandler(m_cmd_exit_Click);
            this.Load += new EventHandler(f420_search_chon_qlht_Load);
            m_cmd_select.Click += new EventHandler(m_cmd_select_Click);
            m_txt_key_ten_qlht.KeyDown += new KeyEventHandler(m_txt_key_cau_hoi_KeyDown);
            m_fg.DoubleClick += new EventHandler(m_fg_DoubleClick);
            m_fg.KeyDown += new KeyEventHandler(m_fg_KeyDown);
            m_cmd_loc.Click += new EventHandler(m_cmd_loc_Click);
		}

        void m_cmd_loc_Click(object sender, EventArgs e)
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

        void m_fg_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                switch (e.KeyCode)
                {
                    case Keys.Enter:
                        if (!HelpUtils.is_validated_edit_grid_row(m_fg.Row, m_fg)) return;
                        grid2us_object(m_us_dm_qlht_scm, m_fg.Row);
                        this.Close();
                        break;
                    default:
                        break;
                }
                
            }
            catch (Exception v_e)
            {
                CSystemLog_100.ExceptionHandle(v_e);
            }
        }

        void m_fg_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if(!HelpUtils.is_validated_edit_grid_row(m_fg.Row,m_fg)) return;
                grid2us_object(m_us_dm_qlht_scm,m_fg.Row);
                this.Close();
            }
            catch (Exception v_e)
            {
                CSystemLog_100.ExceptionHandle(v_e);
            }
        }

        void m_cmd_select_Click(object sender, EventArgs e)
        {
            try
            {
                if(!HelpUtils.is_validated_edit_grid_row(m_fg.Row,m_fg)) return;
                grid2us_object(m_us_dm_qlht_scm, m_fg.Row);
                this.Close();
            }
            catch (Exception v_e)
            {
                CSystemLog_100.ExceptionHandle(v_e);
            }
        }

        void m_txt_key_cau_hoi_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                switch (e.KeyCode)
                {
                    case Keys.Enter:
                        load_data_2_grid();
                        break;
                    default:
                        break;
                }
            }
            catch (Exception v_e)
            {
                CSystemLog_100.ExceptionHandle(v_e);
            }
        }

        void f420_search_chon_qlht_Load(object sender, EventArgs e)
        {
            try
            {
                set_initial_form_load();
            }
            catch (Exception v_e)
            {
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


        #endregion

    }
}

