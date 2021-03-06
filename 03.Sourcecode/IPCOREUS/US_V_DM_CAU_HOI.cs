///************************************************
/// Generated by: LinhDH
/// Date: 11/03/2014 08:59:46
/// Goal: Create User Service Class for V_DM_CAU_HOI
///************************************************
/// <summary>
/// Create User Service Class for V_DM_CAU_HOI
/// </summary>


using IPCOREDS;
using IP.Core.IPCommon;
using IP.Core.IPUserService;
using System.Data.SqlClient;
using System.Data;
using System;

namespace IPCOREUS
{

	public class US_V_DM_CAU_HOI : US_Object
	{
		private const string c_TableName = "V_DM_CAU_HOI";
		#region Public Properties
		public decimal dcID 
		{
			get
			{
				return CNull.RowNVLDecimal(pm_objDR, "ID", IPConstants.c_DefaultDecimal);
			}
			set	
			{
				pm_objDR["ID"] = value;
			}
		}

		public bool IsIDNull()	{
			return pm_objDR.IsNull("ID");
		}

		public void SetIDNull() {
			pm_objDR["ID"] = System.Convert.DBNull;
		}

		public decimal dcID_TO_CHUC 
		{
			get
			{
				return CNull.RowNVLDecimal(pm_objDR, "ID_TO_CHUC", IPConstants.c_DefaultDecimal);
			}
			set	
			{
				pm_objDR["ID_TO_CHUC"] = value;
			}
		}

		public bool IsID_TO_CHUCNull()	{
			return pm_objDR.IsNull("ID_TO_CHUC");
		}

		public void SetID_TO_CHUCNull() {
			pm_objDR["ID_TO_CHUC"] = System.Convert.DBNull;
		}

		public decimal dcID_NHOM_CAU_HOI 
		{
			get
			{
				return CNull.RowNVLDecimal(pm_objDR, "ID_NHOM_CAU_HOI", IPConstants.c_DefaultDecimal);
			}
			set	
			{
				pm_objDR["ID_NHOM_CAU_HOI"] = value;
			}
		}

		public bool IsID_NHOM_CAU_HOINull()	{
			return pm_objDR.IsNull("ID_NHOM_CAU_HOI");
		}

		public void SetID_NHOM_CAU_HOINull() {
			pm_objDR["ID_NHOM_CAU_HOI"] = System.Convert.DBNull;
		}

		public string strNOI_DUNG_CAU_HOI 
		{
			get 
			{
				return CNull.RowNVLString(pm_objDR, "NOI_DUNG_CAU_HOI", IPConstants.c_DefaultString);
			}
			set 
			{
				pm_objDR["NOI_DUNG_CAU_HOI"] = value;
			}
		}

		public bool IsNOI_DUNG_CAU_HOINull() 
		{
			return pm_objDR.IsNull("NOI_DUNG_CAU_HOI");
		}

		public void SetNOI_DUNG_CAU_HOINull() {
			pm_objDR["NOI_DUNG_CAU_HOI"] = System.Convert.DBNull;
		}

		public DateTime datNGAY_TAO
		{
			get   
			{
				return CNull.RowNVLDate(pm_objDR, "NGAY_TAO", IPConstants.c_DefaultDate);
			}
			set   
			{
				pm_objDR["NGAY_TAO"] = value;
			}
		}

		public bool IsNGAY_TAONull()
		{
			return pm_objDR.IsNull("NGAY_TAO");
		}

		public void SetNGAY_TAONull()
		{
			pm_objDR["NGAY_TAO"] = System.Convert.DBNull;
		}

		public decimal dcNGUOI_TAO 
		{
			get
			{
				return CNull.RowNVLDecimal(pm_objDR, "NGUOI_TAO", IPConstants.c_DefaultDecimal);
			}
			set	
			{
				pm_objDR["NGUOI_TAO"] = value;
			}
		}

		public bool IsNGUOI_TAONull()	{
			return pm_objDR.IsNull("NGUOI_TAO");
		}

		public void SetNGUOI_TAONull() {
			pm_objDR["NGUOI_TAO"] = System.Convert.DBNull;
		}

		public DateTime datNGAY_CAP_NHAP_CUOI
		{
			get   
			{
				return CNull.RowNVLDate(pm_objDR, "NGAY_CAP_NHAP_CUOI", IPConstants.c_DefaultDate);
			}
			set   
			{
				pm_objDR["NGAY_CAP_NHAP_CUOI"] = value;
			}
		}

		public bool IsNGAY_CAP_NHAP_CUOINull()
		{
			return pm_objDR.IsNull("NGAY_CAP_NHAP_CUOI");
		}

		public void SetNGAY_CAP_NHAP_CUOINull()
		{
			pm_objDR["NGAY_CAP_NHAP_CUOI"] = System.Convert.DBNull;
		}

		public decimal dcNGUOI_CAP_NHAT_CUOI 
		{
			get
			{
				return CNull.RowNVLDecimal(pm_objDR, "NGUOI_CAP_NHAT_CUOI", IPConstants.c_DefaultDecimal);
			}
			set	
			{
				pm_objDR["NGUOI_CAP_NHAT_CUOI"] = value;
			}
		}

		public bool IsNGUOI_CAP_NHAT_CUOINull()	{
			return pm_objDR.IsNull("NGUOI_CAP_NHAT_CUOI");
		}

		public void SetNGUOI_CAP_NHAT_CUOINull() {
			pm_objDR["NGUOI_CAP_NHAT_CUOI"] = System.Convert.DBNull;
		}

		public string strCAU_TRA_LOI 
		{
			get 
			{
				return CNull.RowNVLString(pm_objDR, "CAU_TRA_LOI", IPConstants.c_DefaultString);
			}
			set 
			{
				pm_objDR["CAU_TRA_LOI"] = value;
			}
		}

		public bool IsCAU_TRA_LOINull() 
		{
			return pm_objDR.IsNull("CAU_TRA_LOI");
		}

		public void SetCAU_TRA_LOINull() {
			pm_objDR["CAU_TRA_LOI"] = System.Convert.DBNull;
		}

        public string strLINK_TL_THAM_KHAO
		{
			get 
			{
                return CNull.RowNVLString(pm_objDR, "LINK_TL_THAM_KHAO", IPConstants.c_DefaultString);
			}
			set 
			{
                pm_objDR["LINK_TL_THAM_KHAO"] = value;
			}
		}

        public bool IsLINK_TL_THAM_KHAONull() 
		{
            return pm_objDR.IsNull("LINK_TL_THAM_KHAO");
		}

        public void SetLINK_TL_THAM_KHAONull()
        {
            pm_objDR["LINK_TL_THAM_KHAO"] = System.Convert.DBNull;
		}

        public decimal dcID_TRANG_THAI_CAU_TRA_LOI
		{
			get
			{
				return CNull.RowNVLDecimal(pm_objDR, "ID_TRANG_THAI_CAU_TRA_LOI", IPConstants.c_DefaultDecimal);
			}
			set	
			{
				pm_objDR["ID_TRANG_THAI_CAU_TRA_LOI"] = value;
			}
		}

		public bool IsID_TRANG_THAI_CAU_TRA_LOINull()	{
			return pm_objDR.IsNull("ID_TRANG_THAI_CAU_TRA_LOI");
		}

		public void SetID_TRANG_THAI_CAU_TRA_LOINull() {
			pm_objDR["ID_TRANG_THAI_CAU_TRA_LOI"] = System.Convert.DBNull;
		}
        
        public string strTEN_TO_CHUC
        {
            get
            {
                return CNull.RowNVLString(pm_objDR, "TEN_TO_CHUC", IPConstants.c_DefaultString);
            }
            set
            {
                pm_objDR["TEN_TO_CHUC"] = value;
            }
        }

        public bool IsTEN_TO_CHUCNull()
        {
            return pm_objDR.IsNull("TEN_TO_CHUC");
        }

        public void SetTEN_TO_CHUCNull()
        {
            pm_objDR["TEN_TO_CHUC"] = System.Convert.DBNull;
        }

        public string strTEN_NHOM_CAU_HOI
        {
            get
            {
                return CNull.RowNVLString(pm_objDR, "TEN_NHOM_CAU_HOI", IPConstants.c_DefaultString);
            }
            set
            {
                pm_objDR["TEN_NHOM_CAU_HOI"] = value;
            }
        }

        public bool IsTEN_NHOM_CAU_HOINull()
        {
            return pm_objDR.IsNull("TEN_NHOM_CAU_HOI");
        }

        public void SetTEN_NHOM_CAU_HOINull()
        {
            pm_objDR["TEN_NHOM_CAU_HOI"] = System.Convert.DBNull;
        }

        public string strTEN_NGUOI_TAO
        {
            get
            {
                return CNull.RowNVLString(pm_objDR, "TEN_NGUOI_TAO", IPConstants.c_DefaultString);
            }
            set
            {
                pm_objDR["TEN_NGUOI_TAO"] = value;
            }
        }

        public bool IsTEN_NGUOI_TAONull()
        {
            return pm_objDR.IsNull("TEN_NGUOI_TAO");
        }

        public void SetTEN_NGUOI_TAONull()
        {
            pm_objDR["TEN_NGUOI_TAO"] = System.Convert.DBNull;
        }

        public string strTEN_NGUOI_CAP_NHAT_CUOI
        {
            get
            {
                return CNull.RowNVLString(pm_objDR, "TEN_NGUOI_CAP_NHAT_CUOI", IPConstants.c_DefaultString);
            }
            set
            {
                pm_objDR["TEN_NGUOI_CAP_NHAT_CUOI"] = value;
            }
        }

        public bool IsTEN_NGUOI_CAP_NHAT_CUOINull()
        {
            return pm_objDR.IsNull("TEN_NGUOI_CAP_NHAT_CUOI");
        }

        public void SetTEN_NGUOI_CAP_NHAT_CUOINull()
        {
            pm_objDR["TEN_NGUOI_CAP_NHAT_CUOI"] = System.Convert.DBNull;
        }

		#endregion


		#region Init Functions
		public US_V_DM_CAU_HOI() 
		{
			pm_objDS = new DS_V_DM_CAU_HOI();
			pm_strTableName = c_TableName;
			pm_objDR = pm_objDS.Tables[pm_strTableName].NewRow();
		}

		public US_V_DM_CAU_HOI(DataRow i_objDR): this()
		{
			this.DataRow2Me(i_objDR);
		}

		public US_V_DM_CAU_HOI(decimal i_dbID) 
		{
			pm_objDS = new DS_V_DM_CAU_HOI();
			pm_strTableName = c_TableName;
			IMakeSelectCmd v_objMkCmd = new CMakeAndSelectCmd(pm_objDS, c_TableName);
			v_objMkCmd.AddCondition("ID", i_dbID, eKieuDuLieu.KieuNumber, eKieuSoSanh.Bang);
			SqlCommand v_cmdSQL;
			v_cmdSQL = v_objMkCmd.getSelectCmd();
			this.FillDatasetByCommand(pm_objDS, v_cmdSQL);
			pm_objDR = getRowClone(pm_objDS.Tables[pm_strTableName].Rows[0]);
		}
		#endregion

        #region Additional Function
        public void them_cau_tra_loi()
        {
            CStoredProc v_cstore = new CStoredProc("pr_V_DM_CAU_HOI_Them_Cau_Tra_Loi");

            v_cstore.addDecimalInputParam("@ID_CAU_HOI", this.dcID);
            v_cstore.addDecimalInputParam("@NGUOI_TAO", this.dcNGUOI_TAO);
            v_cstore.addNVarcharInputParam("@CAU_TRA_LOI", this.strCAU_TRA_LOI);
            v_cstore.addDatetimeInputParam("@NGAY_TAO", this.datNGAY_TAO);
            v_cstore.addNVarcharInputParam("@LINK_TAI_LIEU", this.strLINK_TL_THAM_KHAO);
            v_cstore.ExecuteCommand(this);
        }
        public void search_dm_cau_hoi(string i_str_key_search
            ,decimal i_dc_id_don_vi_lien_quan
            ,decimal i_dc_id_loai_cau_hoi
            , DS_V_DM_CAU_HOI i_us_cau_hoi)
        {
            CStoredProc v_cstore = new CStoredProc("pr_V_GD_CAU_HOI_YEU_CAU_search_dm_cau_hoi");
            v_cstore.addNVarcharInputParam("@KEY_SEARCH", i_str_key_search);
            v_cstore.addDecimalInputParam("@ID_DON_VI", i_dc_id_don_vi_lien_quan);
            v_cstore.addDecimalInputParam("@ID_LOAI_CAU_HOI", i_dc_id_loai_cau_hoi);
            v_cstore.fillDataSetByCommand(this, i_us_cau_hoi);
        }
        #endregion
    }
}
