///************************************************
/// Generated by: LinhDH
/// Date: 13/03/2014 07:40:18
/// Goal: Create Form for V_DM_CAU_HOI_KO_TRA_LOI
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
    public class f220_dm_cau_hoi_searching : System.Windows.Forms.Form
    {
        internal System.Windows.Forms.ImageList ImageList;
        internal System.Windows.Forms.Panel m_pnl_out_place_dm;
        private C1.Win.C1FlexGrid.C1FlexGrid m_fg;
        internal SIS.Controls.Button.SiSButton m_cmd_exit;
        internal SIS.Controls.Button.SiSButton m_cmd_select;
        private Label m_lbl_header;
        private Panel m_pnl_search_area;
        private GroupBox m_grb_dm_cau_hoi;
        private TextBox m_txt_key_cau_hoi;
        private Label label11;
        private Label label12;
        private ComboBox m_cbo_loai_cau_hoi_tren;
        private ComboBox m_cbo_don_vi_lien_quan;
        private Label label8;
        internal SIS.Controls.Button.SiSButton m_cmd_tim_kiem;
        private System.ComponentModel.IContainer components;

        public f220_dm_cau_hoi_searching()
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
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(f220_dm_cau_hoi_searching));
            this.ImageList = new System.Windows.Forms.ImageList(this.components);
            this.m_pnl_out_place_dm = new System.Windows.Forms.Panel();
            this.m_cmd_select = new SIS.Controls.Button.SiSButton();
            this.m_cmd_exit = new SIS.Controls.Button.SiSButton();
            this.m_fg = new C1.Win.C1FlexGrid.C1FlexGrid();
            this.m_lbl_header = new System.Windows.Forms.Label();
            this.m_pnl_search_area = new System.Windows.Forms.Panel();
            this.m_cmd_tim_kiem = new SIS.Controls.Button.SiSButton();
            this.label12 = new System.Windows.Forms.Label();
            this.m_cbo_loai_cau_hoi_tren = new System.Windows.Forms.ComboBox();
            this.m_cbo_don_vi_lien_quan = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.m_txt_key_cau_hoi = new System.Windows.Forms.TextBox();
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
            this.m_pnl_out_place_dm.Location = new System.Drawing.Point(0, 380);
            this.m_pnl_out_place_dm.Name = "m_pnl_out_place_dm";
            this.m_pnl_out_place_dm.Padding = new System.Windows.Forms.Padding(4);
            this.m_pnl_out_place_dm.Size = new System.Drawing.Size(792, 36);
            this.m_pnl_out_place_dm.TabIndex = 1;
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
            this.m_cmd_select.Size = new System.Drawing.Size(88, 28);
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
            this.m_cmd_exit.Location = new System.Drawing.Point(700, 4);
            this.m_cmd_exit.Name = "m_cmd_exit";
            this.m_cmd_exit.Size = new System.Drawing.Size(88, 28);
            this.m_cmd_exit.TabIndex = 1;
            this.m_cmd_exit.Text = "Thoát (Esc)";
            // 
            // m_fg
            // 
            this.m_fg.ColumnInfo = resources.GetString("m_fg.ColumnInfo");
            this.m_fg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_fg.Location = new System.Drawing.Point(3, 16);
            this.m_fg.Name = "m_fg";
            this.m_fg.Size = new System.Drawing.Size(786, 242);
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
            this.m_lbl_header.Size = new System.Drawing.Size(792, 40);
            this.m_lbl_header.TabIndex = 24;
            this.m_lbl_header.Text = "F220 - Tìm kiếm câu hỏi";
            this.m_lbl_header.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // m_pnl_search_area
            // 
            this.m_pnl_search_area.Controls.Add(this.m_cmd_tim_kiem);
            this.m_pnl_search_area.Controls.Add(this.label12);
            this.m_pnl_search_area.Controls.Add(this.m_cbo_loai_cau_hoi_tren);
            this.m_pnl_search_area.Controls.Add(this.m_cbo_don_vi_lien_quan);
            this.m_pnl_search_area.Controls.Add(this.label8);
            this.m_pnl_search_area.Controls.Add(this.m_txt_key_cau_hoi);
            this.m_pnl_search_area.Controls.Add(this.label11);
            this.m_pnl_search_area.Dock = System.Windows.Forms.DockStyle.Top;
            this.m_pnl_search_area.Location = new System.Drawing.Point(0, 40);
            this.m_pnl_search_area.Name = "m_pnl_search_area";
            this.m_pnl_search_area.Size = new System.Drawing.Size(792, 79);
            this.m_pnl_search_area.TabIndex = 0;
            // 
            // m_cmd_tim_kiem
            // 
            this.m_cmd_tim_kiem.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.m_cmd_tim_kiem.BtnShape = SIS.Controls.Button.emunType.BtnShape.Rectangle;
            this.m_cmd_tim_kiem.BtnStyle = SIS.Controls.Button.emunType.XPStyle.Default;
            this.m_cmd_tim_kiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_cmd_tim_kiem.ImageIndex = 5;
            this.m_cmd_tim_kiem.ImageList = this.ImageList;
            this.m_cmd_tim_kiem.Location = new System.Drawing.Point(610, 40);
            this.m_cmd_tim_kiem.Name = "m_cmd_tim_kiem";
            this.m_cmd_tim_kiem.Size = new System.Drawing.Size(88, 28);
            this.m_cmd_tim_kiem.TabIndex = 3;
            this.m_cmd_tim_kiem.Text = "Tìm kiếm";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(251, 22);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(65, 13);
            this.label12.TabIndex = 11;
            this.label12.Text = "Loại câu hỏi";
            // 
            // m_cbo_loai_cau_hoi_tren
            // 
            this.m_cbo_loai_cau_hoi_tren.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.m_cbo_loai_cau_hoi_tren.FormattingEnabled = true;
            this.m_cbo_loai_cau_hoi_tren.Location = new System.Drawing.Point(326, 17);
            this.m_cbo_loai_cau_hoi_tren.Name = "m_cbo_loai_cau_hoi_tren";
            this.m_cbo_loai_cau_hoi_tren.Size = new System.Drawing.Size(156, 21);
            this.m_cbo_loai_cau_hoi_tren.TabIndex = 1;
            // 
            // m_cbo_don_vi_lien_quan
            // 
            this.m_cbo_don_vi_lien_quan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.m_cbo_don_vi_lien_quan.FormattingEnabled = true;
            this.m_cbo_don_vi_lien_quan.Location = new System.Drawing.Point(140, 18);
            this.m_cbo_don_vi_lien_quan.Name = "m_cbo_don_vi_lien_quan";
            this.m_cbo_don_vi_lien_quan.Size = new System.Drawing.Size(73, 21);
            this.m_cbo_don_vi_lien_quan.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(51, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Đơn vị liên quan";
            // 
            // m_txt_key_cau_hoi
            // 
            this.m_txt_key_cau_hoi.Location = new System.Drawing.Point(140, 45);
            this.m_txt_key_cau_hoi.Name = "m_txt_key_cau_hoi";
            this.m_txt_key_cau_hoi.Size = new System.Drawing.Size(453, 20);
            this.m_txt_key_cau_hoi.TabIndex = 2;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(88, 48);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(47, 13);
            this.label11.TabIndex = 8;
            this.label11.Text = "Từ khóa";
            // 
            // m_grb_dm_cau_hoi
            // 
            this.m_grb_dm_cau_hoi.Controls.Add(this.m_fg);
            this.m_grb_dm_cau_hoi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_grb_dm_cau_hoi.Location = new System.Drawing.Point(0, 119);
            this.m_grb_dm_cau_hoi.Name = "m_grb_dm_cau_hoi";
            this.m_grb_dm_cau_hoi.Size = new System.Drawing.Size(792, 261);
            this.m_grb_dm_cau_hoi.TabIndex = 0;
            this.m_grb_dm_cau_hoi.TabStop = false;
            this.m_grb_dm_cau_hoi.Text = "Danh sách câu hỏi tìm kiếm";
            // 
            // f220_dm_cau_hoi_searching
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(792, 416);
            this.Controls.Add(this.m_grb_dm_cau_hoi);
            this.Controls.Add(this.m_pnl_search_area);
            this.Controls.Add(this.m_lbl_header);
            this.Controls.Add(this.m_pnl_out_place_dm);
            this.Name = "f220_dm_cau_hoi_searching";
            this.Text = "F220 - Tìm kiếm câu hỏi";
            this.m_pnl_out_place_dm.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.m_fg)).EndInit();
            this.m_pnl_search_area.ResumeLayout(false);
            this.m_pnl_search_area.PerformLayout();
            this.m_grb_dm_cau_hoi.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        #endregion

        #region Public Interface
        public DialogResult display_search(string i_str_key_search
            , decimal i_id_don_vi
            , decimal i_id_loai_cau_hoi
            , US_V_DM_CAU_HOI i_us)
        {
            m_e_form_mode = e_form_mode.DISPLAY_FROM_CALL_SINH_VIEN;
            load_data_2_cbo_don_vi_lien_quan();
            load_data_2_cbo_loai_cau_hoi_tren();
            m_txt_key_cau_hoi.Text = i_str_key_search;
            m_e_trangThai_cbo_Don_vi = e_trangThai_cbo_Don_vi.DANG_FILL_DATA;
            m_e_trangThai_cbo_Nhom_cau_hoi = e_trangThai_cbo_Nhom_cau_hoi.DANG_FILL_DATA;
            m_cbo_loai_cau_hoi_tren.SelectedValue = i_id_loai_cau_hoi;
            m_cbo_don_vi_lien_quan.SelectedValue = i_id_don_vi;
            m_e_trangThai_cbo_Don_vi = e_trangThai_cbo_Don_vi.DA_FILL_XONG;
            m_e_trangThai_cbo_Nhom_cau_hoi = e_trangThai_cbo_Nhom_cau_hoi.DA_FILL_XONG;
            m_us_cau_hoi = i_us;
            this.ShowDialog();
            return m_dlg_result;
        }
        public void display()
        {
            m_e_form_mode = e_form_mode.DISPLAY_FROM_MAIN_FORM;
            load_data_2_cbo_don_vi_lien_quan();
            load_data_2_cbo_loai_cau_hoi_tren();
            this.ShowDialog();
        }
        #endregion

        #region Data Structure
        private enum e_col_Number
        {
            TEN_NHOM_CAU_HOI = 2
            ,
            NOI_DUNG_CAU_HOI = 3
                ,
            TEN_NGUOI_CAP_NHAT_CUOI = 6
                ,
            NGAY_CAP_NHAP_CUOI = 7
                ,
            TEN_TO_CHUC = 1
                ,
            TEN_NGUOI_TAO = 5
                ,
            NGAY_TAO = 4
                ,
            NOI_DUNG_TRA_LOI = 8
                , ID_TRANG_THAI_CAU_TRA_LOI = 9

        }
        enum e_trangThai_cbo_Don_vi
        {
            DANG_FILL_DATA = 0
           , DA_FILL_XONG = 1
        }
        enum e_trangThai_cbo_Nhom_cau_hoi
        {
            DANG_FILL_DATA = 0
           , DA_FILL_XONG = 1
        }
        enum e_form_mode
        {
            DISPLAY_FROM_CALL_SINH_VIEN = 0
            , DISPLAY_FROM_MAIN_FORM = 1
        }
        #endregion

        #region Members
        ITransferDataRow m_obj_trans;
        DialogResult m_dlg_result;
        DS_V_DM_CAU_HOI m_ds_cau_hoi = new DS_V_DM_CAU_HOI();
        US_V_DM_CAU_HOI m_us_cau_hoi = new US_V_DM_CAU_HOI();

        e_form_mode m_e_form_mode = e_form_mode.DISPLAY_FROM_CALL_SINH_VIEN;

        DS_V_DM_CAU_TRA_LOI m_ds_cau_tra_loi = new DS_V_DM_CAU_TRA_LOI();
        US_V_DM_CAU_TRA_LOI m_us_cau_tra_loi = new US_V_DM_CAU_TRA_LOI();

        e_trangThai_cbo_Don_vi m_e_trangThai_cbo_Don_vi = e_trangThai_cbo_Don_vi.DANG_FILL_DATA;
        e_trangThai_cbo_Nhom_cau_hoi m_e_trangThai_cbo_Nhom_cau_hoi = e_trangThai_cbo_Nhom_cau_hoi.DANG_FILL_DATA;
        #endregion

        #region Private Methods
        private void format_controls()
        {
            CControlFormat.setFormStyle(this, new CAppContext_201(), IPFormStyle.DialogForm);
            CControlFormat.setC1FlexFormat(m_fg);
            CGridUtils.AddSearch_Handlers(m_fg);
            CGridUtils.AddSave_Excel_Handlers(m_fg);

            m_lbl_header.Font = new Font("Arial", 16);
            m_lbl_header.ForeColor = Color.DarkRed;
            m_lbl_header.TextAlign = ContentAlignment.MiddleCenter;

            m_fg.Tree.Style = TreeStyleFlags.SimpleLeaf;
            m_fg.Tree.Column = (int)e_col_Number.NOI_DUNG_CAU_HOI;

            m_fg.Cols[(int)e_col_Number.TEN_TO_CHUC].Visible = false;
            m_fg.Cols[(int)e_col_Number.TEN_NHOM_CAU_HOI].Visible = false;
            m_fg.Cols[(int)e_col_Number.NGAY_CAP_NHAP_CUOI].Visible = false;
            m_fg.Cols[(int)e_col_Number.NGAY_TAO].Visible = false;
            m_fg.Cols[(int)e_col_Number.TEN_NGUOI_CAP_NHAT_CUOI].Visible = false;
            m_fg.Cols[(int)e_col_Number.TEN_NGUOI_TAO].Visible = false;
            m_fg.Cols[(int)e_col_Number.ID_TRANG_THAI_CAU_TRA_LOI].DataMap = get_data_map_trang_thai();
            this.MaximizeBox = true;
            this.MinimizeBox = true;
            m_txt_key_cau_hoi.Focus();
            set_define_events();
            this.KeyPreview = true;
        }
        private void set_initial_form_load()
        {
            m_obj_trans = get_trans_object(m_fg);
            if(m_e_form_mode == e_form_mode.DISPLAY_FROM_CALL_SINH_VIEN)
                load_data_2_grid();
            if (m_e_form_mode == e_form_mode.DISPLAY_FROM_MAIN_FORM)
                m_cmd_select.Visible = false;
        }
        private ITransferDataRow get_trans_object(C1.Win.C1FlexGrid.C1FlexGrid i_fg)
        {
            Hashtable v_htb = new Hashtable();
            v_htb.Add(V_DM_CAU_HOI.TEN_NHOM_CAU_HOI, e_col_Number.TEN_NHOM_CAU_HOI);
            v_htb.Add(V_DM_CAU_HOI.NOI_DUNG_CAU_HOI, e_col_Number.NOI_DUNG_CAU_HOI);
            v_htb.Add(V_DM_CAU_HOI.TEN_NGUOI_CAP_NHAT_CUOI, e_col_Number.TEN_NGUOI_CAP_NHAT_CUOI);
            v_htb.Add(V_DM_CAU_HOI.NGAY_CAP_NHAP_CUOI, e_col_Number.NGAY_CAP_NHAP_CUOI);
            v_htb.Add(V_DM_CAU_HOI.TEN_TO_CHUC, e_col_Number.TEN_TO_CHUC);
            v_htb.Add(V_DM_CAU_HOI.TEN_NGUOI_TAO, e_col_Number.TEN_NGUOI_TAO);
            v_htb.Add(V_DM_CAU_HOI.NGAY_TAO, e_col_Number.NGAY_TAO);
            v_htb.Add(V_DM_CAU_HOI.CAU_TRA_LOI, e_col_Number.NOI_DUNG_TRA_LOI);
            v_htb.Add(V_DM_CAU_HOI.ID_TRANG_THAI_CAU_TRA_LOI, e_col_Number.ID_TRANG_THAI_CAU_TRA_LOI);

            ITransferDataRow v_obj_trans = new CC1TransferDataRow(i_fg, v_htb, m_ds_cau_hoi.V_DM_CAU_HOI.NewRow());
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
        private void load_data_2_cbo_don_vi_lien_quan()
        {
            m_e_trangThai_cbo_Don_vi = e_trangThai_cbo_Don_vi.DANG_FILL_DATA;
            US_CM_DM_TU_DIEN v_us_tu_dien_dv_lien_quan = new US_CM_DM_TU_DIEN();
            DS_CM_DM_TU_DIEN v_ds_tu_dien_dv_lien_quan = new DS_CM_DM_TU_DIEN();
            v_us_tu_dien_dv_lien_quan.fill_tu_dien_cung_loai_ds(LOAI_TU_DIEN_TEXT.TO_CHUC_TRUONG, CM_DM_TU_DIEN.MA_TU_DIEN, v_ds_tu_dien_dv_lien_quan);

            DataRow v_dr = v_ds_tu_dien_dv_lien_quan.CM_DM_TU_DIEN.NewCM_DM_TU_DIENRow();
            v_dr[CM_DM_TU_DIEN.ID] = "0";
            v_dr[CM_DM_TU_DIEN.MA_TU_DIEN] = "- Tất cả -";
            v_dr[CM_DM_TU_DIEN.TEN] = "- Tất cả -";
            v_ds_tu_dien_dv_lien_quan.EnforceConstraints = false;
            v_ds_tu_dien_dv_lien_quan.CM_DM_TU_DIEN.Rows.InsertAt(v_dr, 0);

            m_cbo_don_vi_lien_quan.DataSource = v_ds_tu_dien_dv_lien_quan.CM_DM_TU_DIEN;
            m_cbo_don_vi_lien_quan.DisplayMember = CM_DM_TU_DIEN.TEN;
            m_cbo_don_vi_lien_quan.ValueMember = CM_DM_TU_DIEN.ID;
            m_e_trangThai_cbo_Don_vi = e_trangThai_cbo_Don_vi.DA_FILL_XONG;
        }
        private void load_data_2_cbo_loai_cau_hoi_tren()
        {
            m_e_trangThai_cbo_Nhom_cau_hoi = e_trangThai_cbo_Nhom_cau_hoi.DANG_FILL_DATA;
            US_CM_DM_TU_DIEN v_us_tu_dien_truong = new US_CM_DM_TU_DIEN();
            DS_CM_DM_TU_DIEN v_ds_tu_dien_truong = new DS_CM_DM_TU_DIEN();
            v_us_tu_dien_truong.fill_tu_dien_cung_loai_ds(LOAI_TU_DIEN_TEXT.NHOM_CAU_HOI, CM_DM_TU_DIEN.MA_TU_DIEN, v_ds_tu_dien_truong);

            DataRow v_dr = v_ds_tu_dien_truong.CM_DM_TU_DIEN.NewCM_DM_TU_DIENRow();
            v_dr[CM_DM_TU_DIEN.ID] = "0";
            v_dr[CM_DM_TU_DIEN.MA_TU_DIEN] = "- Tất cả -";
            v_dr[CM_DM_TU_DIEN.TEN] = "- Tất cả -";
            v_ds_tu_dien_truong.EnforceConstraints = false;
            v_ds_tu_dien_truong.CM_DM_TU_DIEN.Rows.InsertAt(v_dr, 0);

            m_cbo_loai_cau_hoi_tren.DataSource = v_ds_tu_dien_truong.CM_DM_TU_DIEN;
            m_cbo_loai_cau_hoi_tren.DisplayMember = CM_DM_TU_DIEN.TEN;
            m_cbo_loai_cau_hoi_tren.ValueMember = CM_DM_TU_DIEN.ID;
            m_e_trangThai_cbo_Nhom_cau_hoi = e_trangThai_cbo_Nhom_cau_hoi.DA_FILL_XONG;
        }
        private void load_data_2_grid()
        {
            m_ds_cau_hoi = new DS_V_DM_CAU_HOI();
            m_us_cau_hoi.search_dm_cau_hoi(m_txt_key_cau_hoi.Text.Trim()
                , CIPConvert.ToDecimal(m_cbo_don_vi_lien_quan.SelectedValue)
                , CIPConvert.ToDecimal(m_cbo_loai_cau_hoi_tren.SelectedValue)
                , m_ds_cau_hoi);
            m_fg.Redraw = false;
            CGridUtils.Dataset2C1Grid(m_ds_cau_hoi, m_fg, m_obj_trans);
            set_tree_on_grid();
            m_fg.Redraw = true;
            m_fg.Focus();
            if (m_fg.Rows.Count > 3)
            {
                m_fg.Select(3, 3, true);
            }
        }


        private void set_tree_on_grid()
        {
            m_fg.Subtotal(AggregateEnum.None
                         , 0
                         , (int)e_col_Number.TEN_TO_CHUC
                         , (int)e_col_Number.TEN_NHOM_CAU_HOI
                         , "Tổ chức, đơn vị: {0}");
            m_fg.Subtotal(AggregateEnum.None
                       , 1
                       , (int)e_col_Number.TEN_NHOM_CAU_HOI
                       , (int)e_col_Number.TEN_NHOM_CAU_HOI
                       , "Nhóm câu hỏi: {0}");

        }

        private void grid2us_object(US_V_DM_CAU_HOI i_us
            , int i_grid_row)
        {
            DataRow v_dr;
            v_dr = (DataRow)m_fg.Rows[i_grid_row].UserData;
            m_obj_trans.GridRow2DataRow(i_grid_row, v_dr);
            i_us.DataRow2Me(v_dr);
        }


        private void us_object2grid(US_V_DM_CAU_HOI_KO_TRA_LOI i_us
            , int i_grid_row)
        {
            DataRow v_dr = (DataRow)m_fg.Rows[i_grid_row].UserData;
            i_us.Me2DataRow(v_dr);
            m_obj_trans.DataRow2GridRow(v_dr, i_grid_row);
        }

        private void set_define_events()
        {
            m_cmd_exit.Click += new EventHandler(m_cmd_exit_Click);
            this.Load += new EventHandler(f220_dm_cau_hoi_searching_Load);
            m_cmd_select.Click += new EventHandler(m_cmd_select_Click);
            m_txt_key_cau_hoi.KeyDown += new KeyEventHandler(m_txt_key_cau_hoi_KeyDown);
            m_fg.DoubleClick += new EventHandler(m_fg_DoubleClick);
            m_fg.KeyDown += new KeyEventHandler(m_fg_KeyDown);
            m_cmd_tim_kiem.Click += new EventHandler(m_cmd_tim_kiem_Click);
            this.KeyDown += new KeyEventHandler(f220_dm_cau_hoi_searching_KeyDown);
            m_cbo_don_vi_lien_quan.SelectedIndexChanged += new EventHandler(m_cbo_don_vi_lien_quan_SelectedIndexChanged);
            m_cbo_loai_cau_hoi_tren.SelectedIndexChanged += new EventHandler(m_cbo_loai_cau_hoi_tren_SelectedIndexChanged);
        }

        void m_cbo_loai_cau_hoi_tren_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (m_e_trangThai_cbo_Nhom_cau_hoi == e_trangThai_cbo_Nhom_cau_hoi.DANG_FILL_DATA) return;
                if (m_txt_key_cau_hoi.Text.Trim() == "") return;
                load_data_2_grid();
            }
            catch (Exception v_e)
            {
                CSystemLog_100.ExceptionHandle(v_e);
            }
        }

        void m_cbo_don_vi_lien_quan_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (m_e_trangThai_cbo_Don_vi == e_trangThai_cbo_Don_vi.DANG_FILL_DATA) return;
                if (m_txt_key_cau_hoi.Text.Trim() == "") return;
                load_data_2_grid();
            }
            catch (Exception v_e)
            {
                CSystemLog_100.ExceptionHandle(v_e);
            }
        }

        void f220_dm_cau_hoi_searching_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                switch (e.KeyCode)
                {
                    case Keys.Escape:
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

        void m_cmd_tim_kiem_Click(object sender, EventArgs e)
        {
            try
            {
                if (m_txt_key_cau_hoi.Text.Trim() == "") return;
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
                        grid2us_object(m_us_cau_hoi, m_fg.Row);
                        m_dlg_result = DialogResult.OK;
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
                if (m_e_form_mode == e_form_mode.DISPLAY_FROM_MAIN_FORM) return;
                if (!HelpUtils.is_validated_edit_grid_row(m_fg.Row, m_fg)) return;
                grid2us_object(m_us_cau_hoi, m_fg.Row);
                m_dlg_result = DialogResult.OK;
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
                if (!HelpUtils.is_validated_edit_grid_row(m_fg.Row, m_fg)) return;
                m_dlg_result = DialogResult.OK;
                grid2us_object(m_us_cau_hoi, m_fg.Row);
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
                        //if (m_txt_key_cau_hoi.Text.Trim() == "") return;
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

        void f220_dm_cau_hoi_searching_Load(object sender, EventArgs e)
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


        //
        //
        //		EVENT HANLDERS
        //
        //


        private void m_cmd_exit_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception v_e)
            {
                CSystemLog_100.ExceptionHandle(v_e);
            }
        }


        #endregion

    }
}
