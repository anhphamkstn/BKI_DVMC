///************************************************
/// Generated by: LinhDH
/// Date: 25/05/2015 07:11:08
/// Goal: Create User Service Class for V_GD_NGUOI_XU_LY_DON_HANG
///************************************************
/// <summary>
/// Create User Service Class for V_GD_NGUOI_XU_LY_DON_HANG
/// </summary>

using System;
using IPCOREDS;
using IP.Core.IPCommon;
using IP.Core.IPUserService;
using System.Data.SqlClient;
using System.Data;


namespace IPCOREUS
{

	public class US_V_GD_NGUOI_XU_LY_DON_HANG : US_Object
	{
		private const string c_TableName = "V_GD_NGUOI_XU_LY_DON_HANG";
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

		public decimal dcID_DON_HANG 
		{
			get
			{
				return CNull.RowNVLDecimal(pm_objDR, "ID_DON_HANG", IPConstants.c_DefaultDecimal);
			}
			set	
			{
				pm_objDR["ID_DON_HANG"] = value;
			}
		}

		public bool IsID_DON_HANGNull()	{
			return pm_objDR.IsNull("ID_DON_HANG");
		}

		public void SetID_DON_HANGNull() {
			pm_objDR["ID_DON_HANG"] = System.Convert.DBNull;
		}

		public decimal dcID_NGUOI_XU_LY 
		{
			get
			{
				return CNull.RowNVLDecimal(pm_objDR, "ID_NGUOI_XU_LY", IPConstants.c_DefaultDecimal);
			}
			set	
			{
				pm_objDR["ID_NGUOI_XU_LY"] = value;
			}
		}

		public bool IsID_NGUOI_XU_LYNull()	{
			return pm_objDR.IsNull("ID_NGUOI_XU_LY");
		}

		public void SetID_NGUOI_XU_LYNull() {
			pm_objDR["ID_NGUOI_XU_LY"] = System.Convert.DBNull;
		}

		public string strMA_DON_HANG 
		{
			get 
			{
				return CNull.RowNVLString(pm_objDR, "MA_DON_HANG", IPConstants.c_DefaultString);
			}
			set 
			{
				pm_objDR["MA_DON_HANG"] = value;
			}
		}

		public bool IsMA_DON_HANGNull() 
		{
			return pm_objDR.IsNull("MA_DON_HANG");
		}

		public void SetMA_DON_HANGNull() {
			pm_objDR["MA_DON_HANG"] = System.Convert.DBNull;
		}

		public string strUSER_XU_LY 
		{
			get 
			{
				return CNull.RowNVLString(pm_objDR, "USER_XU_LY", IPConstants.c_DefaultString);
			}
			set 
			{
				pm_objDR["USER_XU_LY"] = value;
			}
		}

		public bool IsUSER_XU_LYNull() 
		{
			return pm_objDR.IsNull("USER_XU_LY");
		}

		public void SetUSER_XU_LYNull() {
			pm_objDR["USER_XU_LY"] = System.Convert.DBNull;
		}

		#endregion


		#region Init Functions
		public US_V_GD_NGUOI_XU_LY_DON_HANG() 
		{
			pm_objDS = new DS_V_GD_NGUOI_XU_LY_DON_HANG();
			pm_strTableName = c_TableName;
			pm_objDR = pm_objDS.Tables[pm_strTableName].NewRow();
		}

		public US_V_GD_NGUOI_XU_LY_DON_HANG(DataRow i_objDR): this()
		{
			this.DataRow2Me(i_objDR);
		}

		public US_V_GD_NGUOI_XU_LY_DON_HANG(decimal i_dbID) 
		{
			pm_objDS = new DS_V_GD_NGUOI_XU_LY_DON_HANG();
			pm_strTableName = c_TableName;
			IMakeSelectCmd v_objMkCmd = new CMakeAndSelectCmd(pm_objDS, c_TableName);
			v_objMkCmd.AddCondition("ID", i_dbID, eKieuDuLieu.KieuNumber, eKieuSoSanh.Bang);
			SqlCommand v_cmdSQL;
			v_cmdSQL = v_objMkCmd.getSelectCmd();
			this.FillDatasetByCommand(pm_objDS, v_cmdSQL);
			pm_objDR = getRowClone(pm_objDS.Tables[pm_strTableName].Rows[0]);
		}
		#endregion


	}
}
