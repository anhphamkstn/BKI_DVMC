using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using IP.Core.IPCommon;
using IP.Core.IPSystemAdmin;

using System.Data;
using TOSApp.HeThong;
using TOSApp.DanhMuc;
using IPCOREUS;
using IPCOREDS.CDBNames;
using System.IO;
using TOSApp.App_Code;
using TOSApp.ChucNang;
using TOSApp;
using IP.Core.IPUserService;

namespace TOSApp
{
	/// <summary>
	/// Summary description for f002_main_form.
	/// </summary>
	public class f003_main_form : System.Windows.Forms.Form
    {
        private IContainer components;

		public f003_main_form()
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(f003_main_form));
            this.panel1 = new System.Windows.Forms.Panel();
            this.m_cmd_exit = new System.Windows.Forms.Button();
            this.ImageList = new System.Windows.Forms.ImageList(this.components);
            this.m_pnl_menu = new System.Windows.Forms.Panel();
            this.m_cmd_tab_he_thong = new System.Windows.Forms.Button();
            this.m_cmd_tab_danh_muc = new System.Windows.Forms.Button();
            this.m_cmd_tab_chuc_nang = new System.Windows.Forms.Button();
            this.m_cmd_tab_bao_cao = new System.Windows.Forms.Button();
            this.m_cmd_tab_tro_giup = new System.Windows.Forms.Button();
            this.pictureBox17 = new System.Windows.Forms.PictureBox();
            this.m_tab = new System.Windows.Forms.TabControl();
            this.m_tab_quan_tri_he_thong = new System.Windows.Forms.TabPage();
            this.pictureBox16 = new System.Windows.Forms.PictureBox();
            this.groupBox16 = new System.Windows.Forms.GroupBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.groupBox15 = new System.Windows.Forms.GroupBox();
            this.groupBox23 = new System.Windows.Forms.GroupBox();
            this.m_mnu_change_pasword = new SIS.Controls.Button.SiSButton();
            this.groupBox22 = new System.Windows.Forms.GroupBox();
            this.m_cmd_lich_su_truy_cap = new SIS.Controls.Button.SiSButton();
            this.m_cmd_nguoi_su_dung = new SIS.Controls.Button.SiSButton();
            this.m_cmd_nhom_nguoi_dung = new SIS.Controls.Button.SiSButton();
            this.m_cmd_tu_dien = new SIS.Controls.Button.SiSButton();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.m_tab_danh_muc = new System.Windows.Forms.TabPage();
            this.pictureBox15 = new System.Windows.Forms.PictureBox();
            this.groupBox12 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.m_mnu_nguoi_dai_dien = new SIS.Controls.Button.SiSButton();
            this.m_mnu_ds_qlht = new SIS.Controls.Button.SiSButton();
            this.m_mnu_dm_cau_hoi = new SIS.Controls.Button.SiSButton();
            this.m_grp_introduction = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.m_tab_chuc_nang = new System.Windows.Forms.TabPage();
            this.pictureBox14 = new System.Windows.Forms.PictureBox();
            this.groupBox17 = new System.Windows.Forms.GroupBox();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.siSButton7 = new SIS.Controls.Button.SiSButton();
            this.siSButton8 = new SIS.Controls.Button.SiSButton();
            this.siSButton9 = new SIS.Controls.Button.SiSButton();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.siSButton4 = new SIS.Controls.Button.SiSButton();
            this.siSButton6 = new SIS.Controls.Button.SiSButton();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.siSButton1 = new SIS.Controls.Button.SiSButton();
            this.siSButton2 = new SIS.Controls.Button.SiSButton();
            this.siSButton3 = new SIS.Controls.Button.SiSButton();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.m_cmd_nhap_thong_tin_cuoc_goi = new SIS.Controls.Button.SiSButton();
            this.m_cmd_danh_sach_cau_hoi_hoc_vien = new SIS.Controls.Button.SiSButton();
            this.groupBox18 = new System.Windows.Forms.GroupBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.m_tab_bao_cao = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox13 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.m_tab_tro_giup = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.m_cmd_hien_thi_ma_may = new SIS.Controls.Button.SiSButton();
            this.m_cmd_ban_quyen = new SIS.Controls.Button.SiSButton();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.stbMain = new System.Windows.Forms.StatusBar();
            this.stMess = new System.Windows.Forms.StatusBarPanel();
            this.stUser = new System.Windows.Forms.StatusBarPanel();
            this.stComputer = new System.Windows.Forms.StatusBarPanel();
            this.stDate = new System.Windows.Forms.StatusBarPanel();
            this.m_pnl_hide = new System.Windows.Forms.Panel();
            this.siSButton5 = new SIS.Controls.Button.SiSButton();
            this.siSButton10 = new SIS.Controls.Button.SiSButton();
            this.panel1.SuspendLayout();
            this.m_pnl_menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox17)).BeginInit();
            this.m_tab.SuspendLayout();
            this.m_tab_quan_tri_he_thong.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox16)).BeginInit();
            this.groupBox16.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.groupBox15.SuspendLayout();
            this.groupBox23.SuspendLayout();
            this.groupBox22.SuspendLayout();
            this.m_tab_danh_muc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox15)).BeginInit();
            this.groupBox12.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.m_grp_introduction.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.m_tab_chuc_nang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).BeginInit();
            this.groupBox17.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox18.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.m_tab_bao_cao.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).BeginInit();
            this.m_tab_tro_giup.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stMess)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stComputer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stDate)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(12)))), ((int)(((byte)(21)))));
            this.panel1.Controls.Add(this.m_cmd_exit);
            this.panel1.Controls.Add(this.m_pnl_menu);
            this.panel1.Controls.Add(this.pictureBox17);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(140, 742);
            this.panel1.TabIndex = 1;
            // 
            // m_cmd_exit
            // 
            this.m_cmd_exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(12)))), ((int)(((byte)(21)))));
            this.m_cmd_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.m_cmd_exit.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.m_cmd_exit.ForeColor = System.Drawing.Color.White;
            this.m_cmd_exit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_cmd_exit.ImageIndex = 52;
            this.m_cmd_exit.ImageList = this.ImageList;
            this.m_cmd_exit.Location = new System.Drawing.Point(28, 493);
            this.m_cmd_exit.Name = "m_cmd_exit";
            this.m_cmd_exit.Size = new System.Drawing.Size(79, 35);
            this.m_cmd_exit.TabIndex = 147;
            this.m_cmd_exit.Text = "Thoát";
            this.m_cmd_exit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.m_cmd_exit.UseVisualStyleBackColor = false;
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
            this.ImageList.Images.SetKeyName(22, "");
            this.ImageList.Images.SetKeyName(23, "");
            this.ImageList.Images.SetKeyName(24, "");
            this.ImageList.Images.SetKeyName(25, "");
            this.ImageList.Images.SetKeyName(26, "");
            this.ImageList.Images.SetKeyName(27, "");
            this.ImageList.Images.SetKeyName(28, "");
            this.ImageList.Images.SetKeyName(29, "");
            this.ImageList.Images.SetKeyName(30, "");
            this.ImageList.Images.SetKeyName(31, "");
            this.ImageList.Images.SetKeyName(32, "");
            this.ImageList.Images.SetKeyName(33, "");
            this.ImageList.Images.SetKeyName(34, "");
            this.ImageList.Images.SetKeyName(35, "");
            this.ImageList.Images.SetKeyName(36, "");
            this.ImageList.Images.SetKeyName(37, "");
            this.ImageList.Images.SetKeyName(38, "");
            this.ImageList.Images.SetKeyName(39, "");
            this.ImageList.Images.SetKeyName(40, "");
            this.ImageList.Images.SetKeyName(41, "");
            this.ImageList.Images.SetKeyName(42, "");
            this.ImageList.Images.SetKeyName(43, "");
            this.ImageList.Images.SetKeyName(44, "");
            this.ImageList.Images.SetKeyName(45, "");
            this.ImageList.Images.SetKeyName(46, "");
            this.ImageList.Images.SetKeyName(47, "");
            this.ImageList.Images.SetKeyName(48, "");
            this.ImageList.Images.SetKeyName(49, "");
            this.ImageList.Images.SetKeyName(50, "");
            this.ImageList.Images.SetKeyName(51, "");
            this.ImageList.Images.SetKeyName(52, "");
            this.ImageList.Images.SetKeyName(53, "");
            this.ImageList.Images.SetKeyName(54, "grey_pause.png");
            this.ImageList.Images.SetKeyName(55, "Grey_play.png");
            // 
            // m_pnl_menu
            // 
            this.m_pnl_menu.BackColor = System.Drawing.SystemColors.Control;
            this.m_pnl_menu.Controls.Add(this.m_cmd_tab_he_thong);
            this.m_pnl_menu.Controls.Add(this.m_cmd_tab_danh_muc);
            this.m_pnl_menu.Controls.Add(this.m_cmd_tab_chuc_nang);
            this.m_pnl_menu.Controls.Add(this.m_cmd_tab_bao_cao);
            this.m_pnl_menu.Controls.Add(this.m_cmd_tab_tro_giup);
            this.m_pnl_menu.Location = new System.Drawing.Point(7, 137);
            this.m_pnl_menu.Name = "m_pnl_menu";
            this.m_pnl_menu.Size = new System.Drawing.Size(127, 203);
            this.m_pnl_menu.TabIndex = 146;
            // 
            // m_cmd_tab_he_thong
            // 
            this.m_cmd_tab_he_thong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(12)))), ((int)(((byte)(21)))));
            this.m_cmd_tab_he_thong.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.m_cmd_tab_he_thong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.m_cmd_tab_he_thong.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.m_cmd_tab_he_thong.ForeColor = System.Drawing.Color.White;
            this.m_cmd_tab_he_thong.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.m_cmd_tab_he_thong.Location = new System.Drawing.Point(0, 1);
            this.m_cmd_tab_he_thong.Name = "m_cmd_tab_he_thong";
            this.m_cmd_tab_he_thong.Size = new System.Drawing.Size(127, 40);
            this.m_cmd_tab_he_thong.TabIndex = 8;
            this.m_cmd_tab_he_thong.Text = "Hệ thống";
            this.m_cmd_tab_he_thong.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.m_cmd_tab_he_thong.UseVisualStyleBackColor = false;
            // 
            // m_cmd_tab_danh_muc
            // 
            this.m_cmd_tab_danh_muc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(12)))), ((int)(((byte)(21)))));
            this.m_cmd_tab_danh_muc.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.m_cmd_tab_danh_muc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.m_cmd_tab_danh_muc.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.m_cmd_tab_danh_muc.ForeColor = System.Drawing.Color.White;
            this.m_cmd_tab_danh_muc.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.m_cmd_tab_danh_muc.Location = new System.Drawing.Point(0, 41);
            this.m_cmd_tab_danh_muc.Name = "m_cmd_tab_danh_muc";
            this.m_cmd_tab_danh_muc.Size = new System.Drawing.Size(127, 39);
            this.m_cmd_tab_danh_muc.TabIndex = 6;
            this.m_cmd_tab_danh_muc.Text = "Danh mục";
            this.m_cmd_tab_danh_muc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.m_cmd_tab_danh_muc.UseVisualStyleBackColor = false;
            // 
            // m_cmd_tab_chuc_nang
            // 
            this.m_cmd_tab_chuc_nang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.m_cmd_tab_chuc_nang.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.m_cmd_tab_chuc_nang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.m_cmd_tab_chuc_nang.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.m_cmd_tab_chuc_nang.ForeColor = System.Drawing.Color.White;
            this.m_cmd_tab_chuc_nang.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.m_cmd_tab_chuc_nang.Location = new System.Drawing.Point(0, 80);
            this.m_cmd_tab_chuc_nang.Name = "m_cmd_tab_chuc_nang";
            this.m_cmd_tab_chuc_nang.Size = new System.Drawing.Size(127, 44);
            this.m_cmd_tab_chuc_nang.TabIndex = 7;
            this.m_cmd_tab_chuc_nang.Text = "Chức năng";
            this.m_cmd_tab_chuc_nang.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.m_cmd_tab_chuc_nang.UseVisualStyleBackColor = false;
            // 
            // m_cmd_tab_bao_cao
            // 
            this.m_cmd_tab_bao_cao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(12)))), ((int)(((byte)(21)))));
            this.m_cmd_tab_bao_cao.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.m_cmd_tab_bao_cao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.m_cmd_tab_bao_cao.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.m_cmd_tab_bao_cao.ForeColor = System.Drawing.Color.White;
            this.m_cmd_tab_bao_cao.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_cmd_tab_bao_cao.Location = new System.Drawing.Point(0, 124);
            this.m_cmd_tab_bao_cao.Name = "m_cmd_tab_bao_cao";
            this.m_cmd_tab_bao_cao.Size = new System.Drawing.Size(127, 40);
            this.m_cmd_tab_bao_cao.TabIndex = 11;
            this.m_cmd_tab_bao_cao.Text = "Báo cáo";
            this.m_cmd_tab_bao_cao.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.m_cmd_tab_bao_cao.UseCompatibleTextRendering = true;
            this.m_cmd_tab_bao_cao.UseVisualStyleBackColor = true;
            // 
            // m_cmd_tab_tro_giup
            // 
            this.m_cmd_tab_tro_giup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(12)))), ((int)(((byte)(21)))));
            this.m_cmd_tab_tro_giup.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.m_cmd_tab_tro_giup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.m_cmd_tab_tro_giup.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.m_cmd_tab_tro_giup.ForeColor = System.Drawing.Color.White;
            this.m_cmd_tab_tro_giup.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.m_cmd_tab_tro_giup.Location = new System.Drawing.Point(0, 164);
            this.m_cmd_tab_tro_giup.Name = "m_cmd_tab_tro_giup";
            this.m_cmd_tab_tro_giup.Size = new System.Drawing.Size(127, 39);
            this.m_cmd_tab_tro_giup.TabIndex = 4;
            this.m_cmd_tab_tro_giup.Text = "Trợ giúp";
            this.m_cmd_tab_tro_giup.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.m_cmd_tab_tro_giup.UseVisualStyleBackColor = false;
            // 
            // pictureBox17
            // 
            this.pictureBox17.Image = global::TOSApp.Properties.Resources.status;
            this.pictureBox17.Location = new System.Drawing.Point(7, 15);
            this.pictureBox17.Name = "pictureBox17";
            this.pictureBox17.Size = new System.Drawing.Size(100, 100);
            this.pictureBox17.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox17.TabIndex = 145;
            this.pictureBox17.TabStop = false;
            // 
            // m_tab
            // 
            this.m_tab.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.m_tab.Controls.Add(this.m_tab_quan_tri_he_thong);
            this.m_tab.Controls.Add(this.m_tab_danh_muc);
            this.m_tab.Controls.Add(this.m_tab_chuc_nang);
            this.m_tab.Controls.Add(this.m_tab_bao_cao);
            this.m_tab.Controls.Add(this.m_tab_tro_giup);
            this.m_tab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_tab.ImageList = this.ImageList;
            this.m_tab.ItemSize = new System.Drawing.Size(42, 15);
            this.m_tab.Location = new System.Drawing.Point(140, 0);
            this.m_tab.Name = "m_tab";
            this.m_tab.Padding = new System.Drawing.Point(0, 0);
            this.m_tab.SelectedIndex = 0;
            this.m_tab.Size = new System.Drawing.Size(907, 722);
            this.m_tab.TabIndex = 3;
            // 
            // m_tab_quan_tri_he_thong
            // 
            this.m_tab_quan_tri_he_thong.BackColor = System.Drawing.Color.White;
            this.m_tab_quan_tri_he_thong.Controls.Add(this.pictureBox16);
            this.m_tab_quan_tri_he_thong.Controls.Add(this.groupBox16);
            this.m_tab_quan_tri_he_thong.Controls.Add(this.groupBox15);
            this.m_tab_quan_tri_he_thong.Controls.Add(this.label7);
            this.m_tab_quan_tri_he_thong.Controls.Add(this.label3);
            this.m_tab_quan_tri_he_thong.Location = new System.Drawing.Point(4, 19);
            this.m_tab_quan_tri_he_thong.Name = "m_tab_quan_tri_he_thong";
            this.m_tab_quan_tri_he_thong.Size = new System.Drawing.Size(899, 699);
            this.m_tab_quan_tri_he_thong.TabIndex = 3;
            this.m_tab_quan_tri_he_thong.UseVisualStyleBackColor = true;
            this.m_tab_quan_tri_he_thong.Visible = false;
            // 
            // pictureBox16
            // 
            this.pictureBox16.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox16.Image")));
            this.pictureBox16.Location = new System.Drawing.Point(4, 3);
            this.pictureBox16.Name = "pictureBox16";
            this.pictureBox16.Size = new System.Drawing.Size(119, 44);
            this.pictureBox16.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox16.TabIndex = 144;
            this.pictureBox16.TabStop = false;
            // 
            // groupBox16
            // 
            this.groupBox16.BackColor = System.Drawing.Color.White;
            this.groupBox16.Controls.Add(this.pictureBox3);
            this.groupBox16.Location = new System.Drawing.Point(0, 83);
            this.groupBox16.Name = "groupBox16";
            this.groupBox16.Size = new System.Drawing.Size(200, 398);
            this.groupBox16.TabIndex = 138;
            this.groupBox16.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.White;
            this.pictureBox3.Image = global::TOSApp.Properties.Resources.advancedsettings;
            this.pictureBox3.Location = new System.Drawing.Point(25, 36);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(132, 120);
            this.pictureBox3.TabIndex = 113;
            this.pictureBox3.TabStop = false;
            // 
            // groupBox15
            // 
            this.groupBox15.BackColor = System.Drawing.Color.White;
            this.groupBox15.Controls.Add(this.groupBox23);
            this.groupBox15.Controls.Add(this.groupBox22);
            this.groupBox15.Location = new System.Drawing.Point(200, 83);
            this.groupBox15.Name = "groupBox15";
            this.groupBox15.Size = new System.Drawing.Size(690, 398);
            this.groupBox15.TabIndex = 137;
            this.groupBox15.TabStop = false;
            // 
            // groupBox23
            // 
            this.groupBox23.Controls.Add(this.m_mnu_change_pasword);
            this.groupBox23.Location = new System.Drawing.Point(22, 17);
            this.groupBox23.Name = "groupBox23";
            this.groupBox23.Size = new System.Drawing.Size(260, 88);
            this.groupBox23.TabIndex = 137;
            this.groupBox23.TabStop = false;
            this.groupBox23.Text = "Nhóm 1: TÀI KHOẢN CÁ NHÂN";
            // 
            // m_mnu_change_pasword
            // 
            this.m_mnu_change_pasword.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.m_mnu_change_pasword.BackColor = System.Drawing.Color.White;
            this.m_mnu_change_pasword.BtnShape = SIS.Controls.Button.emunType.BtnShape.Rectangle;
            this.m_mnu_change_pasword.BtnStyle = SIS.Controls.Button.emunType.XPStyle.Default;
            this.m_mnu_change_pasword.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_mnu_change_pasword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(12)))), ((int)(((byte)(21)))));
            this.m_mnu_change_pasword.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_mnu_change_pasword.ImageIndex = 40;
            this.m_mnu_change_pasword.ImageList = this.ImageList;
            this.m_mnu_change_pasword.Location = new System.Drawing.Point(20, 26);
            this.m_mnu_change_pasword.Name = "m_mnu_change_pasword";
            this.m_mnu_change_pasword.Size = new System.Drawing.Size(168, 35);
            this.m_mnu_change_pasword.TabIndex = 2;
            this.m_mnu_change_pasword.Text = "Thay đổi mật khẩu";
            this.m_mnu_change_pasword.UseVisualStyleBackColor = false;
            // 
            // groupBox22
            // 
            this.groupBox22.Controls.Add(this.m_cmd_lich_su_truy_cap);
            this.groupBox22.Controls.Add(this.m_cmd_nguoi_su_dung);
            this.groupBox22.Controls.Add(this.m_cmd_nhom_nguoi_dung);
            this.groupBox22.Controls.Add(this.m_cmd_tu_dien);
            this.groupBox22.Location = new System.Drawing.Point(288, 17);
            this.groupBox22.Name = "groupBox22";
            this.groupBox22.Size = new System.Drawing.Size(252, 211);
            this.groupBox22.TabIndex = 136;
            this.groupBox22.TabStop = false;
            this.groupBox22.Text = "NHÓM 2: QUẢN TRỊ HỆ THỐNG";
            // 
            // m_cmd_lich_su_truy_cap
            // 
            this.m_cmd_lich_su_truy_cap.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.m_cmd_lich_su_truy_cap.BackColor = System.Drawing.Color.White;
            this.m_cmd_lich_su_truy_cap.BtnShape = SIS.Controls.Button.emunType.BtnShape.Rectangle;
            this.m_cmd_lich_su_truy_cap.BtnStyle = SIS.Controls.Button.emunType.XPStyle.Default;
            this.m_cmd_lich_su_truy_cap.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_cmd_lich_su_truy_cap.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(12)))), ((int)(((byte)(21)))));
            this.m_cmd_lich_su_truy_cap.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_cmd_lich_su_truy_cap.ImageIndex = 31;
            this.m_cmd_lich_su_truy_cap.ImageList = this.ImageList;
            this.m_cmd_lich_su_truy_cap.Location = new System.Drawing.Point(20, 164);
            this.m_cmd_lich_su_truy_cap.Name = "m_cmd_lich_su_truy_cap";
            this.m_cmd_lich_su_truy_cap.Size = new System.Drawing.Size(168, 35);
            this.m_cmd_lich_su_truy_cap.TabIndex = 9;
            this.m_cmd_lich_su_truy_cap.Text = "Lịch sử truy cập";
            this.m_cmd_lich_su_truy_cap.UseVisualStyleBackColor = false;
            // 
            // m_cmd_nguoi_su_dung
            // 
            this.m_cmd_nguoi_su_dung.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.m_cmd_nguoi_su_dung.BackColor = System.Drawing.Color.White;
            this.m_cmd_nguoi_su_dung.BtnShape = SIS.Controls.Button.emunType.BtnShape.Rectangle;
            this.m_cmd_nguoi_su_dung.BtnStyle = SIS.Controls.Button.emunType.XPStyle.Default;
            this.m_cmd_nguoi_su_dung.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_cmd_nguoi_su_dung.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(12)))), ((int)(((byte)(21)))));
            this.m_cmd_nguoi_su_dung.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_cmd_nguoi_su_dung.ImageIndex = 24;
            this.m_cmd_nguoi_su_dung.ImageList = this.ImageList;
            this.m_cmd_nguoi_su_dung.Location = new System.Drawing.Point(20, 116);
            this.m_cmd_nguoi_su_dung.Name = "m_cmd_nguoi_su_dung";
            this.m_cmd_nguoi_su_dung.Size = new System.Drawing.Size(168, 35);
            this.m_cmd_nguoi_su_dung.TabIndex = 8;
            this.m_cmd_nguoi_su_dung.Text = "Người sử dụng";
            this.m_cmd_nguoi_su_dung.UseVisualStyleBackColor = false;
            // 
            // m_cmd_nhom_nguoi_dung
            // 
            this.m_cmd_nhom_nguoi_dung.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.m_cmd_nhom_nguoi_dung.BackColor = System.Drawing.Color.White;
            this.m_cmd_nhom_nguoi_dung.BtnShape = SIS.Controls.Button.emunType.BtnShape.Rectangle;
            this.m_cmd_nhom_nguoi_dung.BtnStyle = SIS.Controls.Button.emunType.XPStyle.Default;
            this.m_cmd_nhom_nguoi_dung.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_cmd_nhom_nguoi_dung.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(12)))), ((int)(((byte)(21)))));
            this.m_cmd_nhom_nguoi_dung.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_cmd_nhom_nguoi_dung.ImageIndex = 46;
            this.m_cmd_nhom_nguoi_dung.ImageList = this.ImageList;
            this.m_cmd_nhom_nguoi_dung.Location = new System.Drawing.Point(20, 68);
            this.m_cmd_nhom_nguoi_dung.Name = "m_cmd_nhom_nguoi_dung";
            this.m_cmd_nhom_nguoi_dung.Size = new System.Drawing.Size(168, 35);
            this.m_cmd_nhom_nguoi_dung.TabIndex = 3;
            this.m_cmd_nhom_nguoi_dung.Text = "Nhóm người dùng";
            this.m_cmd_nhom_nguoi_dung.UseVisualStyleBackColor = false;
            // 
            // m_cmd_tu_dien
            // 
            this.m_cmd_tu_dien.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.m_cmd_tu_dien.BackColor = System.Drawing.Color.White;
            this.m_cmd_tu_dien.BtnShape = SIS.Controls.Button.emunType.BtnShape.Rectangle;
            this.m_cmd_tu_dien.BtnStyle = SIS.Controls.Button.emunType.XPStyle.Default;
            this.m_cmd_tu_dien.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_cmd_tu_dien.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(12)))), ((int)(((byte)(21)))));
            this.m_cmd_tu_dien.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_cmd_tu_dien.ImageIndex = 48;
            this.m_cmd_tu_dien.ImageList = this.ImageList;
            this.m_cmd_tu_dien.Location = new System.Drawing.Point(20, 26);
            this.m_cmd_tu_dien.Name = "m_cmd_tu_dien";
            this.m_cmd_tu_dien.Size = new System.Drawing.Size(168, 35);
            this.m_cmd_tu_dien.TabIndex = 7;
            this.m_cmd_tu_dien.Text = "Từ điển hệ thống";
            this.m_cmd_tu_dien.UseVisualStyleBackColor = false;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(12)))), ((int)(((byte)(21)))));
            this.label7.Dock = System.Windows.Forms.DockStyle.Top;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label7.ImageIndex = 34;
            this.label7.ImageList = this.ImageList;
            this.label7.Location = new System.Drawing.Point(0, 50);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(899, 33);
            this.label7.TabIndex = 1;
            this.label7.Text = "       Cập nhật quản trị hệ thống";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(12)))), ((int)(((byte)(21)))));
            this.label3.Image = global::TOSApp.Properties.Resources.call;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(899, 50);
            this.label3.TabIndex = 0;
            this.label3.Text = "HỆ THỐNG            .";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // m_tab_danh_muc
            // 
            this.m_tab_danh_muc.BackColor = System.Drawing.Color.White;
            this.m_tab_danh_muc.Controls.Add(this.pictureBox15);
            this.m_tab_danh_muc.Controls.Add(this.groupBox12);
            this.m_tab_danh_muc.Controls.Add(this.m_grp_introduction);
            this.m_tab_danh_muc.Controls.Add(this.label5);
            this.m_tab_danh_muc.Controls.Add(this.label1);
            this.m_tab_danh_muc.Location = new System.Drawing.Point(4, 19);
            this.m_tab_danh_muc.Name = "m_tab_danh_muc";
            this.m_tab_danh_muc.Size = new System.Drawing.Size(899, 699);
            this.m_tab_danh_muc.TabIndex = 0;
            this.m_tab_danh_muc.UseVisualStyleBackColor = true;
            this.m_tab_danh_muc.Visible = false;
            // 
            // pictureBox15
            // 
            this.pictureBox15.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox15.Image")));
            this.pictureBox15.Location = new System.Drawing.Point(1, 3);
            this.pictureBox15.Name = "pictureBox15";
            this.pictureBox15.Size = new System.Drawing.Size(118, 44);
            this.pictureBox15.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox15.TabIndex = 144;
            this.pictureBox15.TabStop = false;
            // 
            // groupBox12
            // 
            this.groupBox12.BackColor = System.Drawing.Color.White;
            this.groupBox12.Controls.Add(this.groupBox3);
            this.groupBox12.Location = new System.Drawing.Point(200, 83);
            this.groupBox12.Name = "groupBox12";
            this.groupBox12.Size = new System.Drawing.Size(639, 398);
            this.groupBox12.TabIndex = 4;
            this.groupBox12.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.m_mnu_nguoi_dai_dien);
            this.groupBox3.Controls.Add(this.m_mnu_ds_qlht);
            this.groupBox3.Controls.Add(this.m_mnu_dm_cau_hoi);
            this.groupBox3.Location = new System.Drawing.Point(29, 23);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(361, 248);
            this.groupBox3.TabIndex = 144;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "DANH MỤC CỦA HỆ THỐNG";
            // 
            // m_mnu_nguoi_dai_dien
            // 
            this.m_mnu_nguoi_dai_dien.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.m_mnu_nguoi_dai_dien.BtnShape = SIS.Controls.Button.emunType.BtnShape.Rectangle;
            this.m_mnu_nguoi_dai_dien.BtnStyle = SIS.Controls.Button.emunType.XPStyle.Default;
            this.m_mnu_nguoi_dai_dien.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_mnu_nguoi_dai_dien.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(12)))), ((int)(((byte)(21)))));
            this.m_mnu_nguoi_dai_dien.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_mnu_nguoi_dai_dien.ImageIndex = 45;
            this.m_mnu_nguoi_dai_dien.ImageList = this.ImageList;
            this.m_mnu_nguoi_dai_dien.Location = new System.Drawing.Point(202, 48);
            this.m_mnu_nguoi_dai_dien.Name = "m_mnu_nguoi_dai_dien";
            this.m_mnu_nguoi_dai_dien.Size = new System.Drawing.Size(151, 39);
            this.m_mnu_nguoi_dai_dien.TabIndex = 120;
            this.m_mnu_nguoi_dai_dien.Text = "Người đại diện";
            this.m_mnu_nguoi_dai_dien.Visible = false;
            // 
            // m_mnu_ds_qlht
            // 
            this.m_mnu_ds_qlht.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.m_mnu_ds_qlht.BtnShape = SIS.Controls.Button.emunType.BtnShape.Rectangle;
            this.m_mnu_ds_qlht.BtnStyle = SIS.Controls.Button.emunType.XPStyle.Default;
            this.m_mnu_ds_qlht.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_mnu_ds_qlht.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(12)))), ((int)(((byte)(21)))));
            this.m_mnu_ds_qlht.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_mnu_ds_qlht.ImageIndex = 49;
            this.m_mnu_ds_qlht.ImageList = this.ImageList;
            this.m_mnu_ds_qlht.Location = new System.Drawing.Point(22, 117);
            this.m_mnu_ds_qlht.Name = "m_mnu_ds_qlht";
            this.m_mnu_ds_qlht.Size = new System.Drawing.Size(163, 40);
            this.m_mnu_ds_qlht.TabIndex = 113;
            this.m_mnu_ds_qlht.Text = "Danh sách QLHT";
            // 
            // m_mnu_dm_cau_hoi
            // 
            this.m_mnu_dm_cau_hoi.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.m_mnu_dm_cau_hoi.BtnShape = SIS.Controls.Button.emunType.BtnShape.Rectangle;
            this.m_mnu_dm_cau_hoi.BtnStyle = SIS.Controls.Button.emunType.XPStyle.Default;
            this.m_mnu_dm_cau_hoi.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_mnu_dm_cau_hoi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(12)))), ((int)(((byte)(21)))));
            this.m_mnu_dm_cau_hoi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_mnu_dm_cau_hoi.ImageIndex = 45;
            this.m_mnu_dm_cau_hoi.ImageList = this.ImageList;
            this.m_mnu_dm_cau_hoi.Location = new System.Drawing.Point(22, 48);
            this.m_mnu_dm_cau_hoi.Name = "m_mnu_dm_cau_hoi";
            this.m_mnu_dm_cau_hoi.Size = new System.Drawing.Size(161, 39);
            this.m_mnu_dm_cau_hoi.TabIndex = 119;
            this.m_mnu_dm_cau_hoi.Text = "Danh sách câu hỏi";
            // 
            // m_grp_introduction
            // 
            this.m_grp_introduction.BackColor = System.Drawing.Color.White;
            this.m_grp_introduction.Controls.Add(this.pictureBox1);
            this.m_grp_introduction.Location = new System.Drawing.Point(0, 83);
            this.m_grp_introduction.Name = "m_grp_introduction";
            this.m_grp_introduction.Size = new System.Drawing.Size(200, 398);
            this.m_grp_introduction.TabIndex = 2;
            this.m_grp_introduction.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(25, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(132, 120);
            this.pictureBox1.TabIndex = 112;
            this.pictureBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(12)))), ((int)(((byte)(21)))));
            this.label5.Dock = System.Windows.Forms.DockStyle.Top;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label5.ImageIndex = 37;
            this.label5.ImageList = this.ImageList;
            this.label5.Location = new System.Drawing.Point(0, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(899, 33);
            this.label5.TabIndex = 1;
            this.label5.Text = "        Nhóm các danh mục ";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(12)))), ((int)(((byte)(21)))));
            this.label1.Image = global::TOSApp.Properties.Resources.call;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(899, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = " DANH MỤC            .";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // m_tab_chuc_nang
            // 
            this.m_tab_chuc_nang.BackColor = System.Drawing.Color.White;
            this.m_tab_chuc_nang.Controls.Add(this.pictureBox14);
            this.m_tab_chuc_nang.Controls.Add(this.groupBox17);
            this.m_tab_chuc_nang.Controls.Add(this.groupBox18);
            this.m_tab_chuc_nang.Controls.Add(this.label4);
            this.m_tab_chuc_nang.Controls.Add(this.label6);
            this.m_tab_chuc_nang.Location = new System.Drawing.Point(4, 19);
            this.m_tab_chuc_nang.Name = "m_tab_chuc_nang";
            this.m_tab_chuc_nang.Size = new System.Drawing.Size(899, 699);
            this.m_tab_chuc_nang.TabIndex = 2;
            this.m_tab_chuc_nang.UseVisualStyleBackColor = true;
            this.m_tab_chuc_nang.Visible = false;
            // 
            // pictureBox14
            // 
            this.pictureBox14.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox14.Image")));
            this.pictureBox14.Location = new System.Drawing.Point(2, 3);
            this.pictureBox14.Name = "pictureBox14";
            this.pictureBox14.Size = new System.Drawing.Size(114, 44);
            this.pictureBox14.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox14.TabIndex = 144;
            this.pictureBox14.TabStop = false;
            // 
            // groupBox17
            // 
            this.groupBox17.Controls.Add(this.groupBox10);
            this.groupBox17.Controls.Add(this.groupBox9);
            this.groupBox17.Controls.Add(this.groupBox8);
            this.groupBox17.Controls.Add(this.groupBox7);
            this.groupBox17.Location = new System.Drawing.Point(212, 86);
            this.groupBox17.Name = "groupBox17";
            this.groupBox17.Size = new System.Drawing.Size(665, 598);
            this.groupBox17.TabIndex = 141;
            this.groupBox17.TabStop = false;
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.siSButton10);
            this.groupBox10.Controls.Add(this.siSButton7);
            this.groupBox10.Controls.Add(this.siSButton8);
            this.groupBox10.Controls.Add(this.siSButton9);
            this.groupBox10.Location = new System.Drawing.Point(339, 263);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(256, 302);
            this.groupBox10.TabIndex = 147;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "QUẢN LÝ LỚP MÔN";
            // 
            // siSButton7
            // 
            this.siSButton7.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.siSButton7.BtnShape = SIS.Controls.Button.emunType.BtnShape.Rectangle;
            this.siSButton7.BtnStyle = SIS.Controls.Button.emunType.XPStyle.Default;
            this.siSButton7.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siSButton7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(12)))), ((int)(((byte)(21)))));
            this.siSButton7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.siSButton7.ImageIndex = 36;
            this.siSButton7.ImageList = this.ImageList;
            this.siSButton7.Location = new System.Drawing.Point(13, 106);
            this.siSButton7.Name = "siSButton7";
            this.siSButton7.Size = new System.Drawing.Size(202, 46);
            this.siSButton7.TabIndex = 146;
            this.siSButton7.Text = "Assign học viên vào lớp môn";
            // 
            // siSButton8
            // 
            this.siSButton8.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.siSButton8.BtnShape = SIS.Controls.Button.emunType.BtnShape.Rectangle;
            this.siSButton8.BtnStyle = SIS.Controls.Button.emunType.XPStyle.Default;
            this.siSButton8.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siSButton8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(12)))), ((int)(((byte)(21)))));
            this.siSButton8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.siSButton8.ImageIndex = 10;
            this.siSButton8.ImageList = this.ImageList;
            this.siSButton8.Location = new System.Drawing.Point(13, 158);
            this.siSButton8.Name = "siSButton8";
            this.siSButton8.Size = new System.Drawing.Size(202, 46);
            this.siSButton8.TabIndex = 146;
            this.siSButton8.Text = "Import bảng điểm lớp môn";
            // 
            // siSButton9
            // 
            this.siSButton9.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.siSButton9.BtnShape = SIS.Controls.Button.emunType.BtnShape.Rectangle;
            this.siSButton9.BtnStyle = SIS.Controls.Button.emunType.XPStyle.Default;
            this.siSButton9.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siSButton9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(12)))), ((int)(((byte)(21)))));
            this.siSButton9.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.siSButton9.ImageIndex = 24;
            this.siSButton9.ImageList = this.ImageList;
            this.siSButton9.Location = new System.Drawing.Point(13, 45);
            this.siSButton9.Name = "siSButton9";
            this.siSButton9.Size = new System.Drawing.Size(202, 46);
            this.siSButton9.TabIndex = 145;
            this.siSButton9.Text = "Quản lý lớp môn";
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.siSButton5);
            this.groupBox9.Controls.Add(this.siSButton4);
            this.groupBox9.Controls.Add(this.siSButton6);
            this.groupBox9.Location = new System.Drawing.Point(25, 263);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(256, 223);
            this.groupBox9.TabIndex = 146;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "ĐAI -NGẠCH";
            // 
            // siSButton4
            // 
            this.siSButton4.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.siSButton4.BtnShape = SIS.Controls.Button.emunType.BtnShape.Rectangle;
            this.siSButton4.BtnStyle = SIS.Controls.Button.emunType.XPStyle.Default;
            this.siSButton4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siSButton4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(12)))), ((int)(((byte)(21)))));
            this.siSButton4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.siSButton4.ImageIndex = 22;
            this.siSButton4.ImageList = this.ImageList;
            this.siSButton4.Location = new System.Drawing.Point(13, 106);
            this.siSButton4.Name = "siSButton4";
            this.siSButton4.Size = new System.Drawing.Size(202, 46);
            this.siSButton4.TabIndex = 146;
            this.siSButton4.Text = "Cấu hình học phần theo Đai";
            // 
            // siSButton6
            // 
            this.siSButton6.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.siSButton6.BtnShape = SIS.Controls.Button.emunType.BtnShape.Rectangle;
            this.siSButton6.BtnStyle = SIS.Controls.Button.emunType.XPStyle.Default;
            this.siSButton6.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siSButton6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(12)))), ((int)(((byte)(21)))));
            this.siSButton6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.siSButton6.ImageIndex = 20;
            this.siSButton6.ImageList = this.ImageList;
            this.siSButton6.Location = new System.Drawing.Point(13, 45);
            this.siSButton6.Name = "siSButton6";
            this.siSButton6.Size = new System.Drawing.Size(202, 46);
            this.siSButton6.TabIndex = 145;
            this.siSButton6.Text = "Quản lý đai";
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.siSButton1);
            this.groupBox8.Controls.Add(this.siSButton2);
            this.groupBox8.Controls.Add(this.siSButton3);
            this.groupBox8.Location = new System.Drawing.Point(339, 22);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(256, 223);
            this.groupBox8.TabIndex = 145;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "HỌC PHẦN - MÔN HỌC";
            // 
            // siSButton1
            // 
            this.siSButton1.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.siSButton1.BtnShape = SIS.Controls.Button.emunType.BtnShape.Rectangle;
            this.siSButton1.BtnStyle = SIS.Controls.Button.emunType.XPStyle.Default;
            this.siSButton1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siSButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(12)))), ((int)(((byte)(21)))));
            this.siSButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.siSButton1.ImageIndex = 31;
            this.siSButton1.ImageList = this.ImageList;
            this.siSButton1.Location = new System.Drawing.Point(13, 106);
            this.siSButton1.Name = "siSButton1";
            this.siSButton1.Size = new System.Drawing.Size(202, 46);
            this.siSButton1.TabIndex = 146;
            this.siSButton1.Text = "Quản lý môn học \r\n- version môn";
            // 
            // siSButton2
            // 
            this.siSButton2.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.siSButton2.BtnShape = SIS.Controls.Button.emunType.BtnShape.Rectangle;
            this.siSButton2.BtnStyle = SIS.Controls.Button.emunType.XPStyle.Default;
            this.siSButton2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siSButton2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(12)))), ((int)(((byte)(21)))));
            this.siSButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.siSButton2.ImageIndex = 37;
            this.siSButton2.ImageList = this.ImageList;
            this.siSButton2.Location = new System.Drawing.Point(13, 158);
            this.siSButton2.Name = "siSButton2";
            this.siSButton2.Size = new System.Drawing.Size(202, 46);
            this.siSButton2.TabIndex = 146;
            this.siSButton2.Text = "Ghép môn - học phần tự chọn";
            // 
            // siSButton3
            // 
            this.siSButton3.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.siSButton3.BtnShape = SIS.Controls.Button.emunType.BtnShape.Rectangle;
            this.siSButton3.BtnStyle = SIS.Controls.Button.emunType.XPStyle.Default;
            this.siSButton3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siSButton3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(12)))), ((int)(((byte)(21)))));
            this.siSButton3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.siSButton3.ImageIndex = 21;
            this.siSButton3.ImageList = this.ImageList;
            this.siSButton3.Location = new System.Drawing.Point(13, 45);
            this.siSButton3.Name = "siSButton3";
            this.siSButton3.Size = new System.Drawing.Size(202, 46);
            this.siSButton3.TabIndex = 145;
            this.siSButton3.Text = "Quản lý học phần";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.m_cmd_nhap_thong_tin_cuoc_goi);
            this.groupBox7.Controls.Add(this.m_cmd_danh_sach_cau_hoi_hoc_vien);
            this.groupBox7.Location = new System.Drawing.Point(25, 22);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(256, 223);
            this.groupBox7.TabIndex = 143;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "CHƯƠNG TRÌNH ĐÀO TẠO";
            // 
            // m_cmd_nhap_thong_tin_cuoc_goi
            // 
            this.m_cmd_nhap_thong_tin_cuoc_goi.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.m_cmd_nhap_thong_tin_cuoc_goi.BtnShape = SIS.Controls.Button.emunType.BtnShape.Rectangle;
            this.m_cmd_nhap_thong_tin_cuoc_goi.BtnStyle = SIS.Controls.Button.emunType.XPStyle.Default;
            this.m_cmd_nhap_thong_tin_cuoc_goi.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_cmd_nhap_thong_tin_cuoc_goi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(12)))), ((int)(((byte)(21)))));
            this.m_cmd_nhap_thong_tin_cuoc_goi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_cmd_nhap_thong_tin_cuoc_goi.ImageIndex = 48;
            this.m_cmd_nhap_thong_tin_cuoc_goi.ImageList = this.ImageList;
            this.m_cmd_nhap_thong_tin_cuoc_goi.Location = new System.Drawing.Point(13, 106);
            this.m_cmd_nhap_thong_tin_cuoc_goi.Name = "m_cmd_nhap_thong_tin_cuoc_goi";
            this.m_cmd_nhap_thong_tin_cuoc_goi.Size = new System.Drawing.Size(202, 46);
            this.m_cmd_nhap_thong_tin_cuoc_goi.TabIndex = 146;
            this.m_cmd_nhap_thong_tin_cuoc_goi.Text = "Setting lộ trình học cho \r\nChương trình";
            // 
            // m_cmd_danh_sach_cau_hoi_hoc_vien
            // 
            this.m_cmd_danh_sach_cau_hoi_hoc_vien.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.m_cmd_danh_sach_cau_hoi_hoc_vien.BtnShape = SIS.Controls.Button.emunType.BtnShape.Rectangle;
            this.m_cmd_danh_sach_cau_hoi_hoc_vien.BtnStyle = SIS.Controls.Button.emunType.XPStyle.Default;
            this.m_cmd_danh_sach_cau_hoi_hoc_vien.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_cmd_danh_sach_cau_hoi_hoc_vien.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(12)))), ((int)(((byte)(21)))));
            this.m_cmd_danh_sach_cau_hoi_hoc_vien.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_cmd_danh_sach_cau_hoi_hoc_vien.ImageIndex = 29;
            this.m_cmd_danh_sach_cau_hoi_hoc_vien.ImageList = this.ImageList;
            this.m_cmd_danh_sach_cau_hoi_hoc_vien.Location = new System.Drawing.Point(13, 45);
            this.m_cmd_danh_sach_cau_hoi_hoc_vien.Name = "m_cmd_danh_sach_cau_hoi_hoc_vien";
            this.m_cmd_danh_sach_cau_hoi_hoc_vien.Size = new System.Drawing.Size(202, 46);
            this.m_cmd_danh_sach_cau_hoi_hoc_vien.TabIndex = 145;
            this.m_cmd_danh_sach_cau_hoi_hoc_vien.Text = "Quản lý chương trình";
            // 
            // groupBox18
            // 
            this.groupBox18.Controls.Add(this.pictureBox4);
            this.groupBox18.Location = new System.Drawing.Point(6, 86);
            this.groupBox18.Name = "groupBox18";
            this.groupBox18.Size = new System.Drawing.Size(200, 598);
            this.groupBox18.TabIndex = 140;
            this.groupBox18.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::TOSApp.Properties.Resources.advancedsettings;
            this.pictureBox4.Location = new System.Drawing.Point(25, 36);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(132, 120);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 126;
            this.pictureBox4.TabStop = false;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(12)))), ((int)(((byte)(21)))));
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label4.ImageIndex = 29;
            this.label4.ImageList = this.ImageList;
            this.label4.Location = new System.Drawing.Point(0, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(899, 33);
            this.label4.TabIndex = 1;
            this.label4.Text = "        Chức năng nghiệp vụ phần mềm";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Dock = System.Windows.Forms.DockStyle.Top;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(12)))), ((int)(((byte)(21)))));
            this.label6.Image = global::TOSApp.Properties.Resources.call;
            this.label6.Location = new System.Drawing.Point(0, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(899, 50);
            this.label6.TabIndex = 0;
            this.label6.Text = " CHỨC NĂNG           .";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // m_tab_bao_cao
            // 
            this.m_tab_bao_cao.BackColor = System.Drawing.Color.White;
            this.m_tab_bao_cao.Controls.Add(this.groupBox2);
            this.m_tab_bao_cao.Controls.Add(this.groupBox1);
            this.m_tab_bao_cao.Controls.Add(this.pictureBox13);
            this.m_tab_bao_cao.Controls.Add(this.label8);
            this.m_tab_bao_cao.Controls.Add(this.label2);
            this.m_tab_bao_cao.Location = new System.Drawing.Point(4, 19);
            this.m_tab_bao_cao.Name = "m_tab_bao_cao";
            this.m_tab_bao_cao.Size = new System.Drawing.Size(899, 699);
            this.m_tab_bao_cao.TabIndex = 1;
            this.m_tab_bao_cao.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(210, 86);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(573, 398);
            this.groupBox2.TabIndex = 146;
            this.groupBox2.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Location = new System.Drawing.Point(4, 88);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 398);
            this.groupBox1.TabIndex = 145;
            this.groupBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.InitialImage")));
            this.pictureBox2.Location = new System.Drawing.Point(25, 36);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(132, 120);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 126;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox13
            // 
            this.pictureBox13.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox13.Image")));
            this.pictureBox13.Location = new System.Drawing.Point(1, 3);
            this.pictureBox13.Name = "pictureBox13";
            this.pictureBox13.Size = new System.Drawing.Size(120, 44);
            this.pictureBox13.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox13.TabIndex = 144;
            this.pictureBox13.TabStop = false;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(12)))), ((int)(((byte)(21)))));
            this.label8.Dock = System.Windows.Forms.DockStyle.Top;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label8.ImageIndex = 28;
            this.label8.ImageList = this.ImageList;
            this.label8.Location = new System.Drawing.Point(0, 50);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(899, 33);
            this.label8.TabIndex = 1;
            this.label8.Text = "       Báo cáo chi tiết";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(12)))), ((int)(((byte)(21)))));
            this.label2.Image = global::TOSApp.Properties.Resources.call;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(899, 50);
            this.label2.TabIndex = 0;
            this.label2.Text = " BÁO CÁO            .";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // m_tab_tro_giup
            // 
            this.m_tab_tro_giup.Controls.Add(this.groupBox4);
            this.m_tab_tro_giup.Controls.Add(this.groupBox5);
            this.m_tab_tro_giup.Controls.Add(this.pictureBox7);
            this.m_tab_tro_giup.Controls.Add(this.label9);
            this.m_tab_tro_giup.Controls.Add(this.label10);
            this.m_tab_tro_giup.Location = new System.Drawing.Point(4, 19);
            this.m_tab_tro_giup.Name = "m_tab_tro_giup";
            this.m_tab_tro_giup.Padding = new System.Windows.Forms.Padding(3);
            this.m_tab_tro_giup.Size = new System.Drawing.Size(899, 699);
            this.m_tab_tro_giup.TabIndex = 4;
            this.m_tab_tro_giup.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.groupBox6);
            this.groupBox4.Location = new System.Drawing.Point(211, 106);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(573, 398);
            this.groupBox4.TabIndex = 151;
            this.groupBox4.TabStop = false;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.m_cmd_hien_thi_ma_may);
            this.groupBox6.Controls.Add(this.m_cmd_ban_quyen);
            this.groupBox6.Location = new System.Drawing.Point(25, 22);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(335, 241);
            this.groupBox6.TabIndex = 144;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "TRỢ GIÚP CỦA HỆ THỐNG";
            // 
            // m_cmd_hien_thi_ma_may
            // 
            this.m_cmd_hien_thi_ma_may.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.m_cmd_hien_thi_ma_may.BtnShape = SIS.Controls.Button.emunType.BtnShape.Rectangle;
            this.m_cmd_hien_thi_ma_may.BtnStyle = SIS.Controls.Button.emunType.XPStyle.Default;
            this.m_cmd_hien_thi_ma_may.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_cmd_hien_thi_ma_may.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(12)))), ((int)(((byte)(21)))));
            this.m_cmd_hien_thi_ma_may.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_cmd_hien_thi_ma_may.ImageIndex = 29;
            this.m_cmd_hien_thi_ma_may.ImageList = this.ImageList;
            this.m_cmd_hien_thi_ma_may.Location = new System.Drawing.Point(13, 45);
            this.m_cmd_hien_thi_ma_may.Name = "m_cmd_hien_thi_ma_may";
            this.m_cmd_hien_thi_ma_may.Size = new System.Drawing.Size(224, 46);
            this.m_cmd_hien_thi_ma_may.TabIndex = 145;
            this.m_cmd_hien_thi_ma_may.Text = "     Hiển thị lại mã máy điện thoại";
            this.m_cmd_hien_thi_ma_may.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // m_cmd_ban_quyen
            // 
            this.m_cmd_ban_quyen.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.m_cmd_ban_quyen.BtnShape = SIS.Controls.Button.emunType.BtnShape.Rectangle;
            this.m_cmd_ban_quyen.BtnStyle = SIS.Controls.Button.emunType.XPStyle.Default;
            this.m_cmd_ban_quyen.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_cmd_ban_quyen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(12)))), ((int)(((byte)(21)))));
            this.m_cmd_ban_quyen.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_cmd_ban_quyen.ImageIndex = 40;
            this.m_cmd_ban_quyen.ImageList = this.ImageList;
            this.m_cmd_ban_quyen.Location = new System.Drawing.Point(13, 111);
            this.m_cmd_ban_quyen.Name = "m_cmd_ban_quyen";
            this.m_cmd_ban_quyen.Size = new System.Drawing.Size(172, 45);
            this.m_cmd_ban_quyen.TabIndex = 144;
            this.m_cmd_ban_quyen.Text = "    Bản quyền phần mềm";
            this.m_cmd_ban_quyen.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.pictureBox5);
            this.groupBox5.Location = new System.Drawing.Point(5, 108);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(200, 398);
            this.groupBox5.TabIndex = 150;
            this.groupBox5.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox5.InitialImage")));
            this.pictureBox5.Location = new System.Drawing.Point(25, 36);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(132, 120);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 126;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(2, 6);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(120, 44);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 149;
            this.pictureBox7.TabStop = false;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(12)))), ((int)(((byte)(21)))));
            this.label9.Dock = System.Windows.Forms.DockStyle.Top;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label9.ImageIndex = 28;
            this.label9.ImageList = this.ImageList;
            this.label9.Location = new System.Drawing.Point(3, 53);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(893, 33);
            this.label9.TabIndex = 148;
            this.label9.Text = "       Trợ giúp";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label10.Dock = System.Windows.Forms.DockStyle.Top;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(12)))), ((int)(((byte)(21)))));
            this.label10.Image = global::TOSApp.Properties.Resources.call;
            this.label10.Location = new System.Drawing.Point(3, 3);
            this.label10.Margin = new System.Windows.Forms.Padding(0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(893, 50);
            this.label10.TabIndex = 147;
            this.label10.Text = " TRỢ GIÚP            ";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // stbMain
            // 
            this.stbMain.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.stbMain.Location = new System.Drawing.Point(140, 722);
            this.stbMain.Name = "stbMain";
            this.stbMain.Panels.AddRange(new System.Windows.Forms.StatusBarPanel[] {
            this.stMess,
            this.stUser,
            this.stComputer,
            this.stDate});
            this.stbMain.ShowPanels = true;
            this.stbMain.Size = new System.Drawing.Size(907, 20);
            this.stbMain.TabIndex = 4;
            this.stbMain.Text = "statusBar";
            // 
            // stMess
            // 
            this.stMess.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Spring;
            this.stMess.Icon = ((System.Drawing.Icon)(resources.GetObject("stMess.Icon")));
            this.stMess.Name = "stMess";
            this.stMess.Width = 222;
            // 
            // stUser
            // 
            this.stUser.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Spring;
            this.stUser.Icon = ((System.Drawing.Icon)(resources.GetObject("stUser.Icon")));
            this.stUser.Name = "stUser";
            this.stUser.Width = 222;
            // 
            // stComputer
            // 
            this.stComputer.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Spring;
            this.stComputer.Icon = ((System.Drawing.Icon)(resources.GetObject("stComputer.Icon")));
            this.stComputer.Name = "stComputer";
            this.stComputer.Width = 222;
            // 
            // stDate
            // 
            this.stDate.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Spring;
            this.stDate.Icon = ((System.Drawing.Icon)(resources.GetObject("stDate.Icon")));
            this.stDate.Name = "stDate";
            this.stDate.Width = 222;
            // 
            // m_pnl_hide
            // 
            this.m_pnl_hide.BackColor = System.Drawing.Color.White;
            this.m_pnl_hide.Location = new System.Drawing.Point(140, 0);
            this.m_pnl_hide.Name = "m_pnl_hide";
            this.m_pnl_hide.Size = new System.Drawing.Size(905, 10);
            this.m_pnl_hide.TabIndex = 5;
            // 
            // siSButton5
            // 
            this.siSButton5.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.siSButton5.BtnShape = SIS.Controls.Button.emunType.BtnShape.Rectangle;
            this.siSButton5.BtnStyle = SIS.Controls.Button.emunType.XPStyle.Default;
            this.siSButton5.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siSButton5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(12)))), ((int)(((byte)(21)))));
            this.siSButton5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.siSButton5.ImageIndex = 27;
            this.siSButton5.ImageList = this.ImageList;
            this.siSButton5.Location = new System.Drawing.Point(13, 158);
            this.siSButton5.Name = "siSButton5";
            this.siSButton5.Size = new System.Drawing.Size(202, 46);
            this.siSButton5.TabIndex = 147;
            this.siSButton5.Text = "Lộ trình học của học viên";
            // 
            // siSButton10
            // 
            this.siSButton10.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.siSButton10.BtnShape = SIS.Controls.Button.emunType.BtnShape.Rectangle;
            this.siSButton10.BtnStyle = SIS.Controls.Button.emunType.XPStyle.Default;
            this.siSButton10.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siSButton10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(12)))), ((int)(((byte)(21)))));
            this.siSButton10.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.siSButton10.ImageIndex = 25;
            this.siSButton10.ImageList = this.ImageList;
            this.siSButton10.Location = new System.Drawing.Point(13, 210);
            this.siSButton10.Name = "siSButton10";
            this.siSButton10.Size = new System.Drawing.Size(202, 46);
            this.siSButton10.TabIndex = 147;
            this.siSButton10.Text = "Bảng điểm toàn khóa học viên";
            // 
            // f003_main_form
            // 
            this.ClientSize = new System.Drawing.Size(1047, 742);
            this.Controls.Add(this.m_pnl_hide);
            this.Controls.Add(this.m_tab);
            this.Controls.Add(this.stbMain);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "f003_main_form";
            this.Text = "DTNB - Chương trình quản lý Đào tạo nội bộ.ver1.1.2015-06-20";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.m_pnl_menu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox17)).EndInit();
            this.m_tab.ResumeLayout(false);
            this.m_tab_quan_tri_he_thong.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox16)).EndInit();
            this.groupBox16.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.groupBox15.ResumeLayout(false);
            this.groupBox23.ResumeLayout(false);
            this.groupBox22.ResumeLayout(false);
            this.m_tab_danh_muc.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox15)).EndInit();
            this.groupBox12.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.m_grp_introduction.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.m_tab_chuc_nang.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).EndInit();
            this.groupBox17.ResumeLayout(false);
            this.groupBox10.ResumeLayout(false);
            this.groupBox9.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox18.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.m_tab_bao_cao.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).EndInit();
            this.m_tab_tro_giup.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stMess)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stComputer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stDate)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

        #region public Interface
        public void display(ref IPConstants.HowUserWantTo_Exit_MainForm o_exitMode)
        {
            this.ShowDialog();
            o_exitMode = m_exitMode;
        }

        #endregion

        #region Data Structures
        enum button_enum
        {
            he_thong = 1,
            chuc_nang = 2,
            danh_muc = 4,
            bao_cao = 5,
            tro_giup = 6,
        }
        #endregion

        #region Members
        US_V_HT_LOG_TRUY_CAP m_us_log_truy_cap = new US_V_HT_LOG_TRUY_CAP();
        US_GD_CUOC_GOI_YEU_CAU m_us_gd_cuoc_goi_yc = new US_GD_CUOC_GOI_YEU_CAU();
        IPConstants.HowUserWantTo_Exit_MainForm m_exitMode = IPConstants.HowUserWantTo_Exit_MainForm.ExitFromSystem;
        public static string m_str_stationId;
        public static string m_str_web_service_url;
        public static string m_str_web_record_url;
        public static string m_str_mainform_title;
        public static decimal m_dc_id_user;
        public static decimal m_dc_interval_incoming;
        public static string m_str_email_dvmc = "", m_str_password_dvmc = "", m_str_ho_ten_dtv = "", m_str_url_xac_nhan_don_hang = "", m_str_url_hoan_thanh_don_hang = "", m_str_chu_ky_dvmc = "";

        string m_str_agentcode;
        private Panel panel1;
        private PictureBox pictureBox17;
        private Panel m_pnl_menu;
        private Button m_cmd_tab_he_thong;
        private Button m_cmd_tab_danh_muc;
        private Button m_cmd_tab_chuc_nang;
        private Button m_cmd_tab_tro_giup;
        internal ImageList ImageList;
        private Button m_cmd_exit;
        private Button m_cmd_tab_bao_cao;
        private TabControl m_tab;
        private TabPage m_tab_quan_tri_he_thong;
        private PictureBox pictureBox16;
        private GroupBox groupBox16;
        private GroupBox groupBox15;
        private GroupBox groupBox23;
        private SIS.Controls.Button.SiSButton m_mnu_change_pasword;
        private GroupBox groupBox22;
        private SIS.Controls.Button.SiSButton m_cmd_nguoi_su_dung;
        private SIS.Controls.Button.SiSButton m_cmd_nhom_nguoi_dung;
        private SIS.Controls.Button.SiSButton m_cmd_tu_dien;
        private Label label7;
        private Label label3;
        private TabPage m_tab_danh_muc;
        private GroupBox groupBox12;
        private SIS.Controls.Button.SiSButton m_mnu_nguoi_dai_dien;
        private SIS.Controls.Button.SiSButton m_mnu_dm_cau_hoi;
        private SIS.Controls.Button.SiSButton m_mnu_ds_qlht;
        private GroupBox m_grp_introduction;
        private PictureBox pictureBox1;
        private Label label5;
        private Label label1;
        private TabPage m_tab_chuc_nang;
        private PictureBox pictureBox14;
        private GroupBox groupBox17;
        private GroupBox groupBox7;
        private GroupBox groupBox18;
        private PictureBox pictureBox4;
        private Label label4;
        private Label label6;
        private TabPage m_tab_bao_cao;
        private PictureBox pictureBox13;
        private Label label8;
        private Label label2;
        private PictureBox pictureBox3;
        private SIS.Controls.Button.SiSButton m_cmd_danh_sach_cau_hoi_hoc_vien;
        internal StatusBar stbMain;
        internal StatusBarPanel stMess;
        internal StatusBarPanel stUser;
        internal StatusBarPanel stComputer;
        internal StatusBarPanel stDate;
        private PictureBox pictureBox15;
        private SIS.Controls.Button.SiSButton m_cmd_lich_su_truy_cap;
        private GroupBox groupBox1;
        private PictureBox pictureBox2;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Panel m_pnl_hide;
        private TabPage m_tab_tro_giup;
        private GroupBox groupBox4;
        private GroupBox groupBox5;
        private PictureBox pictureBox5;
        private PictureBox pictureBox7;
        private Label label9;
        private Label label10;
        private GroupBox groupBox6;
        private SIS.Controls.Button.SiSButton m_cmd_nhap_thong_tin_cuoc_goi;
        private SIS.Controls.Button.SiSButton m_cmd_hien_thi_ma_may;
        private SIS.Controls.Button.SiSButton m_cmd_ban_quyen;
        private GroupBox groupBox8;
        private SIS.Controls.Button.SiSButton siSButton1;
        private SIS.Controls.Button.SiSButton siSButton2;
        private SIS.Controls.Button.SiSButton siSButton3;
        private GroupBox groupBox9;
        private SIS.Controls.Button.SiSButton siSButton4;
        private SIS.Controls.Button.SiSButton siSButton6;
        private GroupBox groupBox10;
        private SIS.Controls.Button.SiSButton siSButton7;
        private SIS.Controls.Button.SiSButton siSButton8;
        private SIS.Controls.Button.SiSButton siSButton9;
        private SIS.Controls.Button.SiSButton siSButton5;
        private SIS.Controls.Button.SiSButton siSButton10;
        string m_str_ipadress;
        #endregion
        
        #region Private Methods
        private void set_active_button(button_enum i_e_button)
        {

            m_cmd_tab_he_thong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(12)))), ((int)(((byte)(21)))));
            m_cmd_tab_danh_muc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(12)))), ((int)(((byte)(21)))));
            m_cmd_tab_chuc_nang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(12)))), ((int)(((byte)(21)))));
            m_cmd_tab_bao_cao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(12)))), ((int)(((byte)(21)))));
            m_cmd_tab_tro_giup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(12)))), ((int)(((byte)(21)))));
            switch (i_e_button)
            {
                case button_enum.he_thong:
                    m_cmd_tab_he_thong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
                    break;
                case button_enum.danh_muc:
                    m_cmd_tab_danh_muc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
                    break;
                case button_enum.chuc_nang:
                    m_cmd_tab_chuc_nang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
                    break;
                case button_enum.bao_cao:
                    m_cmd_tab_bao_cao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(46)))));
                    break;
                case button_enum.tro_giup:
                    m_cmd_tab_tro_giup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(46)))));
                    break;
            }
        }
        private void format_controls()
        {
            //CControlFormat.setFormStyle(this);
            this.MinimizeBox = true;
            this.MaximizeBox = true;
            this.ShowInTaskbar = true;
            this.HelpButton = false;
            m_pnl_hide.Height = 18;

            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
            
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            m_tab.SelectedTab = m_tab_chuc_nang;
            set_active_button(button_enum.chuc_nang);
            
            set_define_events();
        }
        private void set_inital_form_load()
        {
            m_pnl_menu.Visible = true;

            /* 1. Load tham số hệ thống */
            US_DM_NGUOI_DUNG_STATION v_us = new US_DM_NGUOI_DUNG_STATION();
            m_dc_id_user = CAppContext_201.getCurrentUserID();
            US_HT_NGUOI_SU_DUNG v_us_nsd = new US_HT_NGUOI_SU_DUNG(m_dc_id_user);
            m_str_stationId = v_us.get_station_id_by_user(m_dc_id_user);
            m_str_agentcode = v_us_nsd.strTEN_TRUY_CAP;
            m_str_ipadress = HelpUtils.get_current_ipaddress().ToString();
            m_str_mainform_title = HelpUtils.get_version_build_title_mainform();
            m_str_web_record_url = HelpUtils.get_web_record_server();
            m_str_web_service_url = HelpUtils.get_web_service_url();
            m_dc_interval_incoming = HelpUtils.get_time_interval_incoming_call();
            m_str_email_dvmc = HelpUtils.get_email_dvmc();
            m_str_password_dvmc = HelpUtils.get_password_email_dvmc();
            m_str_chu_ky_dvmc = HelpUtils.get_chu_ky_dvmc();
            m_str_url_xac_nhan_don_hang = HelpUtils.get_url_xac_nhan_don_hang();
            m_str_url_hoan_thanh_don_hang = HelpUtils.get_url_hoan_thah_don_hang();
            m_str_ho_ten_dtv = v_us_nsd.strTEN;
            //this.Text = m_str_mainform_title;

            /* 0. Ghi log hệ thống: user đăng nhập với ipphone nào? */
            HelpUtils.ghi_log_he_thong(LOG_TRUY_CAP.DANG_NHAP, LOG_DOI_TUONG_TAC_DONG.HT_NGUOI_SU_DUNG, "", "");
            /* 5. Hiển thị thông tin cơ bản về user */
            stbMain.Panels[0].Text = "ĐTNB";
            stbMain.Panels[1].Text = m_str_agentcode;
            stbMain.Panels[2].Text = m_str_ipadress;
            stbMain.Panels[3].Text = "Sẵn sàng sử dụng hệ thống";
        }
        private void form_2_us_obj_log_he_thong()
        {
            m_us_log_truy_cap.dcID_DANG_NHAP = CAppContext_201.getCurrentUserID();
            m_us_log_truy_cap.dcID_LOAI_HANH_DONG = LOG_TRUY_CAP.DANG_NHAP;
            m_us_log_truy_cap.datTHOI_GIAN = DateTime.Now;
            m_us_log_truy_cap.strDOI_TUONG_THAO_TAC = LOG_DOI_TUONG_TAC_DONG.DANG_NHAP_XUAT;
            m_us_log_truy_cap.strMO_TA = "Đăng nhập hệ thống";
            m_us_log_truy_cap.SetGHI_CHUNull();
        }
        private void show_manager_user()
        {
            if (!CAppContext_201.IsHavingQuyen(IP.Core.IPSystemAdmin.PHAN_QUYEN.QLHT_NGUOI_SU_DUNG))
            {
                BaseMessages.MsgBox_Infor(THONG_BAO.ER_KHONG_CO_QUYEN_SU_DUNG);
                return;
            }
            f999_ht_nguoi_su_dung v_frm_999 = new f999_ht_nguoi_su_dung();
            v_frm_999.display();
        }
        private void show_introduction()
        {
            if (!CAppContext_201.IsHavingQuyen(IP.Core.IPSystemAdmin.PHAN_QUYEN.LIC_GIOI_THIEU))
            {
                BaseMessages.MsgBox_Infor(THONG_BAO.ER_KHONG_CO_QUYEN_SU_DUNG);
                return;
            }
            f996_license_form v_frm996 = new f996_license_form();
            v_frm996.display();
        }
        private void show_tu_dien_phan_quyen()
        {
            if (!CAppContext_201.IsHavingQuyen(IP.Core.IPSystemAdmin.PHAN_QUYEN.QLTD_TU_DIEN))
            {
                BaseMessages.MsgBox_Infor(" Người sử dụng không có quyền truy nhập phần này ! ");
                return;
            }
            f100_TuDien v_frm = new f100_TuDien();
            v_frm.ShowDialog();
        }
        private void show_lich_su_truy_cap()
        {
            if (!CAppContext_201.IsHavingQuyen(IP.Core.IPSystemAdmin.PHAN_QUYEN.QLHT_LICH_SU_TRUY_CAP))
            {
                BaseMessages.MsgBox_Infor(THONG_BAO.ER_KHONG_CO_QUYEN_SU_DUNG);
                return;
            }
            f661_bao_cao_log_he_thong v_frm661 = new f661_bao_cao_log_he_thong();
            v_frm661.display();
        }
        private void show_dm_nhom_nguoi_dung()
        {
            if (!CAppContext_201.IsHavingQuyen(IP.Core.IPSystemAdmin.PHAN_QUYEN.QLHT_NHOM_NGUOI_DUNG))
            {
                BaseMessages.MsgBox_Infor(THONG_BAO.ER_KHONG_CO_QUYEN_SU_DUNG);
                return;
            }
            f997_ht_nhom_quyen v_frm997 = new f997_ht_nhom_quyen();
            v_frm997.display();
        }
        private void show_dm_cau_hoi()
        {
            if (!CAppContext_201.IsHavingQuyen(IP.Core.IPSystemAdmin.PHAN_QUYEN.QLDM_CAU_HOI))
            {
                BaseMessages.MsgBox_Infor(THONG_BAO.ER_KHONG_CO_QUYEN_SU_DUNG);
                return;
            }
            f110_dm_cau_hoi v_f111 = new f110_dm_cau_hoi();
            v_f111.display();
        }
        private void show_dm_nguoi_dai_dien()
        {
            if (!CAppContext_201.IsHavingQuyen(IP.Core.IPSystemAdmin.PHAN_QUYEN.QLDM_NGUOI_DAI_DIEN))
            {
                BaseMessages.MsgBox_Infor(THONG_BAO.ER_KHONG_CO_QUYEN_SU_DUNG);
                return;
            }
            f500_ds_nguoi_dai_dien v_f500 = new f500_ds_nguoi_dai_dien();
            v_f500.display();
        }
        private void show_xu_ly_noi_bo()
        {
            if (!CAppContext_201.IsHavingQuyen(IP.Core.IPSystemAdmin.PHAN_QUYEN.QLNV_XU_LY_NOI_BO))
            {
                BaseMessages.MsgBox_Infor(THONG_BAO.ER_KHONG_CO_QUYEN_SU_DUNG);
                return;
            }
            f400_gd_xu_ly_noi_bo v_f400_xl_noi_bo = new f400_gd_xu_ly_noi_bo();
            v_f400_xl_noi_bo.display();
        }
        private void show_quan_tri_black_list()
        {
            if (!CAppContext_201.IsHavingQuyen(IP.Core.IPSystemAdmin.PHAN_QUYEN.QLNV_BLACKLIST))
            {
                BaseMessages.MsgBox_Infor(THONG_BAO.ER_KHONG_CO_QUYEN_SU_DUNG);
                return;
            }
            f430_quan_ly_blacklist v_f430_blacklist = new f430_quan_ly_blacklist();
            v_f430_blacklist.display();
        }
        private void show_danh_sach_qlht()
        {
            if (!CAppContext_201.IsHavingQuyen(IP.Core.IPSystemAdmin.PHAN_QUYEN.QLDM_DS_QLHT))
            {
                BaseMessages.MsgBox_Infor(THONG_BAO.ER_KHONG_CO_QUYEN_SU_DUNG);
                return;
            }
            f430_dm_quan_ly_hoc_tap v_f430_dm_qlht = new f430_dm_quan_ly_hoc_tap();
            v_f430_dm_qlht.display();
        }
        private void show_change_password()
        {
            string v_str_ten_truy_cap = CAppContext_201.getCurrentUserName();
            US_HT_NGUOI_SU_DUNG v_us_ht_nguoi_dung = new US_HT_NGUOI_SU_DUNG();
            v_us_ht_nguoi_dung.InitByTenTruyCap(v_str_ten_truy_cap);
            f998_ht_nguoi_su_dung_de v_f998_change_password = new f998_ht_nguoi_su_dung_de();
            v_f998_change_password.change_password(v_us_ht_nguoi_dung, "Y");
        }
        private void show_tim_kiem_cau_hoi()
        {
            if (!CAppContext_201.IsHavingQuyen(IP.Core.IPSystemAdmin.PHAN_QUYEN.QLDM_TIM_KIEM_CAU_HOI))
            {
                BaseMessages.MsgBox_Infor(THONG_BAO.ER_KHONG_CO_QUYEN_SU_DUNG);
                return;
            }
            f220_dm_cau_hoi_searching v_frm = new f220_dm_cau_hoi_searching();
            v_frm.display();
        }
        private void show_hien_thi_ma_may()
        {
            f310_dm_station v_f310 = new f310_dm_station();
            v_f310.display();
        }
        private void show_dat_hang_moi()
        {
            if (!CAppContext_201.IsHavingQuyen(IP.Core.IPSystemAdmin.PHAN_QUYEN.QLNV_NHAP_DAT_HANG_MOI))
            {
                BaseMessages.MsgBox_Infor(THONG_BAO.ER_KHONG_CO_QUYEN_SU_DUNG);
                return;
            }
            f100_dat_hang_moi v_f100 = new f100_dat_hang_moi();
            v_f100.display_for_insert_form_main();
        }
        private void show_ds_dat_hang_moi()
        {
            if (!CAppContext_201.IsHavingQuyen(IP.Core.IPSystemAdmin.PHAN_QUYEN.QLNV_DS_DAT_HANG))
            {
                BaseMessages.MsgBox_Infor(THONG_BAO.ER_KHONG_CO_QUYEN_SU_DUNG);
                return;
            }
            f200_ds_dat_hang v_f200 = new f200_ds_dat_hang();
            v_f200.display();
        }
        #endregion

        #region Events

        private void set_define_events()
        {

            this.Load += new EventHandler(f002_main_form_Load);
            m_cmd_tab_he_thong.Click += new EventHandler(m_cmd_tab_he_thong_Click);
            this.m_cmd_tab_danh_muc.Click += new EventHandler(m_cmd_tab_danh_muc_Click);
            this.m_cmd_tab_chuc_nang.Click += new EventHandler(m_cmd_tab_chuc_nang_Click);
            this.m_cmd_tab_bao_cao.Click += new EventHandler(m_cmd_tab_bao_cao_Click);
            m_mnu_dm_cau_hoi.Click += new EventHandler(m_mnu_dm_cau_hoi_Click);
            m_mnu_nguoi_dai_dien.Click += new EventHandler(m_mnu_nguoi_dai_dien_Click);
            m_cmd_danh_sach_cau_hoi_hoc_vien.Click += new EventHandler(m_cmd_danh_sach_cau_hoi_hoc_vien_Click);
            //m_mnu_qtri_blacklist.Click += new EventHandler(m_mnu_qtri_blacklist_Click);
            m_mnu_ds_qlht.Click += new EventHandler(m_mnu_ds_qlht_Click);
            m_mnu_change_pasword.Click += new EventHandler(m_mnu_change_pasword_Click);
            m_cmd_tab_tro_giup.Click += new EventHandler(m_cmd_tab_tro_giup_Click);
            m_cmd_exit.Click +=new EventHandler(m_cmd_exit_Click);
            m_cmd_tu_dien.Click +=new EventHandler(m_cmd_tu_dien_Click);
            m_cmd_lich_su_truy_cap.Click += new EventHandler(m_cmd_lich_su_truy_cap_Click);
            m_cmd_nhom_nguoi_dung.Click +=new EventHandler(m_cmd_nhom_nguoi_dung_Click);
            m_cmd_nguoi_su_dung.Click +=new EventHandler(m_cmd_nguoi_su_dung_Click);
            //m_cmd_tim_kiem_cau_hoi.Click += new EventHandler(m_cmd_tim_kiem_cau_hoi_Click);
            m_cmd_nhap_thong_tin_cuoc_goi.Click += new EventHandler(m_cmd_nhap_thong_tin_cuoc_goi_Click);
            //m_cmd_dat_hang_moi.Click += new EventHandler(m_cmd_dat_hang_moi_Click);
            
        }

        void m_cmd_dat_hang_moi_Click(object sender, EventArgs e)
        {
            try
            {
                show_dat_hang_moi();
            }
            catch (Exception v_e)
            {
                CSystemLog_100.ExceptionHandle(v_e);
            }  
        }

        void m_cmd_nhap_thong_tin_cuoc_goi_Click(object sender, EventArgs e)
        {
            try
            {
                //f200_sinh_vien_goi_den v_frm = new f200_sinh_vien_goi_den();
                //App_Code.SinhVien v_sinh_vien = new App_Code.SinhVien();
                //v_sinh_vien.Dien_thoai = "01682077618";
                //v_sinh_vien.Ngay_sinh = CAppContext_201.getCurentDate();
                //v_sinh_vien.Truong = "HOU";
                //v_sinh_vien.Ma_sinh_vien = "HOU001";
                //v_sinh_vien.Ma_lop = "A12";
                //v_sinh_vien.Noi_sinh = "Hung Yên";
                //v_sinh_vien.Ho_ten = "Lê Khắc Thế";
                //v_frm.display(v_sinh_vien, "1394630244");

                //string v_str_output = CallCenterUtils.get_incoming_call(m_str_stationId).Data;
                //if (v_str_output == "") return;
                //CallInfor v_obj_callinfo = HelpUtils.get_start_callinfo_from_client_string_call(v_str_output);
                //CallInfor v_obj_callinfo = new CallInfor();
                //v_obj_callinfo.call_id = "13982230191260";
                //if (v_obj_callinfo.mobile_phone == "Anonymous") return;
                //if (m_us_gd_cuoc_goi_yc.is_call_id_exist(v_obj_callinfo.call_id)) return;
                //m_timer_imcoming_call.Enabled = false;
                //HelpUtils.open_form_sinh_vien_call(v_obj_callinfo);
               // m_timer_imcoming_call.Enabled = true;

                f200_sinh_vien_goi_den v_f200 = new f200_sinh_vien_goi_den();
                v_f200.display();
            }
            catch (Exception v_e)
            {
                CSystemLog_100.ExceptionHandle(v_e);
            }
        }

        void m_cmd_hien_thi_ma_may_Click(object sender, EventArgs e)
        {
            try
            {
                show_hien_thi_ma_may();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }   
        }

        void m_cmd_tim_kiem_cau_hoi_Click(object sender, EventArgs e)
        {
            try
            {
                show_tim_kiem_cau_hoi();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_tab_he_thong_Click(object sender, EventArgs e)
        {
            try
            {
                m_tab.SelectedTab = m_tab_quan_tri_he_thong;
                set_active_button(button_enum.he_thong);
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_tab_chuc_nang_Click(object sender, EventArgs e)
        {
            try
            {

                m_tab.SelectedTab = m_tab_chuc_nang;
                set_active_button(button_enum.chuc_nang);
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_tab_danh_muc_Click(object sender, EventArgs e)
        {
            try
            {
                m_tab.SelectedTab = m_tab_danh_muc;
                set_active_button(button_enum.danh_muc);
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_tab_bao_cao_Click(object sender, EventArgs e)
        {
            try
            {
                m_tab.SelectedTab = m_tab_bao_cao;
                set_active_button(button_enum.bao_cao);
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_tab_tro_giup_Click(object sender, EventArgs e)
        {
            try
            {
                m_tab.SelectedTab = m_tab_tro_giup;
                set_active_button(button_enum.tro_giup);
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_mnu_change_pasword_Click(object sender, EventArgs e)
        {
            try
            {
                show_change_password();
            }
            catch (Exception v_e)
            {
                CSystemLog_100.ExceptionHandle(v_e);
            }
        }

        void m_mnu_ds_qlht_Click(object sender, EventArgs e)
        {
            try
            {
                show_danh_sach_qlht();
            }
            catch (Exception v_e)
            {
                CSystemLog_100.ExceptionHandle(v_e);
            }
        }

        void m_mnu_qtri_blacklist_Click(object sender, EventArgs e)
        {
            try
            {
                show_quan_tri_black_list();
            }
            catch (Exception v_e)
            {
                CSystemLog_100.ExceptionHandle(v_e);
            }
        }

        void m_cmd_danh_sach_cau_hoi_hoc_vien_Click(object sender, EventArgs e)
        {
            try
            {
                show_ds_dat_hang_moi();
            }
            catch (Exception v_e)
            {
                CSystemLog_100.ExceptionHandle(v_e);
            }
        }

        void m_mnu_xu_ly_noi_bo_Click(object sender, EventArgs e)
        {
            try
            {
                show_xu_ly_noi_bo();
            }
            catch (Exception v_e)
            {
                CSystemLog_100.ExceptionHandle(v_e);
            }
        }

        void m_mnu_nguoi_dai_dien_Click(object sender, EventArgs e)
        {
            try
            {
                show_dm_nguoi_dai_dien();
            }
            catch (Exception v_e)
            {

                CSystemLog_100.ExceptionHandle(v_e);
            }
        }

        void m_mnu_dm_cau_hoi_Click(object sender, EventArgs e)
        {
            try
            {
                show_dm_cau_hoi();
            }
            catch (Exception v_e)
            {

                CSystemLog_100.ExceptionHandle(v_e);
            }
            
        }

        void m_cmd_sinh_vien_goi_den_Click(object sender, EventArgs e)
        {
            try
            {
                f200_sinh_vien_goi_den v_frm = new f200_sinh_vien_goi_den();
                App_Code.SinhVien v_sinh_vien = new App_Code.SinhVien();
                v_sinh_vien.Dien_thoai = "01682077618";
                v_sinh_vien.Ngay_sinh = CAppContext_201.getCurentDate();
                v_sinh_vien.Truong = "HOU";
                v_sinh_vien.Ma_sinh_vien = "HOU001";
                v_sinh_vien.Ma_lop = "A12";
                v_sinh_vien.Noi_sinh = "Hung Yên";
                v_sinh_vien.Ho_ten = "Lê Khắc Thế";
                v_frm.display(v_sinh_vien, "1394630244");
            }
            catch (Exception v_e)
            {
                CSystemLog_100.ExceptionHandle(v_e);
            }
        }

        void f002_main_form_Load(object sender, EventArgs e)
        {
            try
            {
                set_inital_form_load();
            }
            catch (Exception v_e)
            {

                CSystemLog_100.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_exit_Click(object sender, EventArgs e)
        {
            try
            {
                if (BaseMessages.MsgBox_Confirm("Bạn có thật sự muốn kết thúc chương trình không ? "))
                {
                    m_exitMode = IPConstants.HowUserWantTo_Exit_MainForm.ExitFromSystem;
                    this.Close();
                }
            }
            catch (Exception v_e)
            {
                CSystemLog_100.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_nguoi_su_dung_Click(object sender, EventArgs e)
        {
            try
            {
                show_manager_user();
                
            }
            catch (Exception v_e)
            {

                CSystemLog_100.ExceptionHandle(v_e);
            }
            
        }

        private void mnu_license_Click(object sender, EventArgs e)
        {
            try
            {
              show_introduction();
            }
            catch (Exception v_e)
            {

                CSystemLog_100.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_tu_dien_Click(object sender, EventArgs e)
        {
            try
            {
                show_tu_dien_phan_quyen();
            }
            catch (Exception v_e)
            {

                CSystemLog_100.ExceptionHandle(v_e);
            }
        }

        private void mnu_type_of_directory_Click(object sender, EventArgs e)
        {
            try
            {

                
            }
            catch (Exception v_e)
            {

                CSystemLog_100.ExceptionHandle(v_e);
            }
        }

        private void mnu_category_Click(object sender, EventArgs e)
        {
            try
            {
               
            }
            catch (Exception v_e)
            {

                CSystemLog_100.ExceptionHandle(v_e);
            }
        }

        void m_cmd_lich_su_truy_cap_Click(object sender, EventArgs e)
        {
            try
            {
                show_lich_su_truy_cap();
            }
            catch (Exception v_e)
            {
                CSystemLog_100.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_nhom_nguoi_dung_Click(object sender, EventArgs e)
        {
            try
            {
                show_dm_nhom_nguoi_dung();
            }
            catch (Exception v_e)
            {
                
                CSystemLog_100.ExceptionHandle(v_e);
            }
        }
        #endregion
    }
}
