///************************************************
/// Generated by: LinhDH
/// Date: 11/03/2014 08:33:36
/// Goal: Create User Service Class for V_DM_NGUOI_DAI_DIEN
///************************************************
/// <summary>
/// Create User Service Class for V_DM_NGUOI_DAI_DIEN
/// </summary>


using IPCOREDS;
using IP.Core.IPCommon;
using IP.Core.IPUserService;
using System.Data.SqlClient;
using System.Data;
using System;

namespace IPCOREUS
{

	public class US_V_DM_NGUOI_DAI_DIEN : US_Object
	{
		private const string c_TableName = "V_DM_NGUOI_DAI_DIEN";
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

		public decimal dcID_DON_VI 
		{
			get
			{
				return CNull.RowNVLDecimal(pm_objDR, "ID_DON_VI", IPConstants.c_DefaultDecimal);
			}
			set	
			{
				pm_objDR["ID_DON_VI"] = value;
			}
		}

		public bool IsID_DON_VINull()	{
			return pm_objDR.IsNull("ID_DON_VI");
		}

		public void SetID_DON_VINull() {
			pm_objDR["ID_DON_VI"] = System.Convert.DBNull;
		}

		public string strTEN_DON_VI 
		{
			get 
			{
				return CNull.RowNVLString(pm_objDR, "TEN_DON_VI", IPConstants.c_DefaultString);
			}
			set 
			{
				pm_objDR["TEN_DON_VI"] = value;
			}
		}

		public bool IsTEN_DON_VINull() 
		{
			return pm_objDR.IsNull("TEN_DON_VI");
		}

		public void SetTEN_DON_VINull() {
			pm_objDR["TEN_DON_VI"] = System.Convert.DBNull;
		}

		public string strNDD_HO_TEN 
		{
			get 
			{
				return CNull.RowNVLString(pm_objDR, "NDD_HO_TEN", IPConstants.c_DefaultString);
			}
			set 
			{
				pm_objDR["NDD_HO_TEN"] = value;
			}
		}

		public bool IsNDD_HO_TENNull() 
		{
			return pm_objDR.IsNull("NDD_HO_TEN");
		}

		public void SetNDD_HO_TENNull() {
			pm_objDR["NDD_HO_TEN"] = System.Convert.DBNull;
		}

		public string strNDD_DIEN_THOAI 
		{
			get 
			{
				return CNull.RowNVLString(pm_objDR, "NDD_DIEN_THOAI", IPConstants.c_DefaultString);
			}
			set 
			{
				pm_objDR["NDD_DIEN_THOAI"] = value;
			}
		}

		public bool IsNDD_DIEN_THOAINull() 
		{
			return pm_objDR.IsNull("NDD_DIEN_THOAI");
		}

		public void SetNDD_DIEN_THOAINull() {
			pm_objDR["NDD_DIEN_THOAI"] = System.Convert.DBNull;
		}

		public string strNDD_EMAIL 
		{
			get 
			{
				return CNull.RowNVLString(pm_objDR, "NDD_EMAIL", IPConstants.c_DefaultString);
			}
			set 
			{
				pm_objDR["NDD_EMAIL"] = value;
			}
		}

		public bool IsNDD_EMAILNull() 
		{
			return pm_objDR.IsNull("NDD_EMAIL");
		}

		public void SetNDD_EMAILNull() {
			pm_objDR["NDD_EMAIL"] = System.Convert.DBNull;
		}

		public string strNDD_CHUC_VU 
		{
			get 
			{
				return CNull.RowNVLString(pm_objDR, "NDD_CHUC_VU", IPConstants.c_DefaultString);
			}
			set 
			{
				pm_objDR["NDD_CHUC_VU"] = value;
			}
		}

		public bool IsNDD_CHUC_VUNull() 
		{
			return pm_objDR.IsNull("NDD_CHUC_VU");
		}

		public void SetNDD_CHUC_VUNull() {
			pm_objDR["NDD_CHUC_VU"] = System.Convert.DBNull;
		}

		#endregion


		#region Init Functions
		public US_V_DM_NGUOI_DAI_DIEN() 
		{
			pm_objDS = new DS_V_DM_NGUOI_DAI_DIEN();
			pm_strTableName = c_TableName;
			pm_objDR = pm_objDS.Tables[pm_strTableName].NewRow();
		}

		public US_V_DM_NGUOI_DAI_DIEN(DataRow i_objDR): this()
		{
			this.DataRow2Me(i_objDR);
		}

		public US_V_DM_NGUOI_DAI_DIEN(decimal i_dbID) 
		{
			pm_objDS = new DS_V_DM_NGUOI_DAI_DIEN();
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
        public void load_ds_nguoi_dai_dien_by_id_to_chuc(DS_V_DM_NGUOI_DAI_DIEN op_ds_dm_nguoi_dai_dien)
        {
            CStoredProc v_cstore = new CStoredProc("pr_V_DM_NGUOI_DAI_DIEN_Load_Ds_Nguoi_Dai_Dien_By_To_Chuc");
            v_cstore.addDecimalInputParam("@ID_DON_VI", this.dcID_DON_VI);
            v_cstore.addNVarcharInputParam("@CHUC_VU", this.strNDD_CHUC_VU);
            v_cstore.fillDataSetByCommand(this, op_ds_dm_nguoi_dai_dien);
        }
        public void load_nguoi_dai_dien_by_acc_scm(DS_V_DM_NGUOI_DAI_DIEN op_ds_dm_nguoi_dai_dien, string ip_str_acc_scm)
        {
            CStoredProc v_cstore = new CStoredProc("pr_V_DM_NGUOI_DAI_DIEN_Load_Nguoi_Dai_Dien_By_Acc_SCM");
            v_cstore.addNVarcharInputParam("@ACC_SCM", ip_str_acc_scm);
            v_cstore.fillDataSetByCommand(this, op_ds_dm_nguoi_dai_dien);
        }
        #endregion
    }
}
