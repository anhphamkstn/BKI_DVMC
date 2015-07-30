///************************************************
/// Generated by: uyvq
/// Date: 08/09/2012 09:36:46
/// Goal: Create User Service Class for HT_BACKUP_HISTORY
///************************************************
/// <summary>
/// Create User Service Class for HT_BACKUP_HISTORY
/// </summary>


using IPCOREDS;
using IP.Core.IPCommon;
using IP.Core.IPUserService;
using System.Data.SqlClient;
using System.Data;
using System;
namespace IPCOREUS
{

public class US_HT_BACKUP_HISTORY : US_Object
{
	private const string c_TableName = "HT_BACKUP_HISTORY";
#region "Public Properties"
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

	public string strNGUOI_BACKUP 
	{
		get 
		{
			return CNull.RowNVLString(pm_objDR, "NGUOI_BACKUP", IPConstants.c_DefaultString);
		}
		set 
		{
			pm_objDR["NGUOI_BACKUP"] = value;
		}
	}

	public bool IsNGUOI_BACKUPNull() 
	{
		return pm_objDR.IsNull("NGUOI_BACKUP");
	}

	public void SetNGUOI_BACKUPNull() {
		pm_objDR["NGUOI_BACKUP"] = System.Convert.DBNull;
	}

	public DateTime datNGAY_BACKUP
	{
		get   
		{
			return CNull.RowNVLDate(pm_objDR, "NGAY_BACKUP", IPConstants.c_DefaultDate);
		}
		set   
		{
			pm_objDR["NGAY_BACKUP"] = value;
		}
	}

	public bool IsNGAY_BACKUPNull()
	{
		return pm_objDR.IsNull("NGAY_BACKUP");
	}

	public void SetNGAY_BACKUPNull()
	{
		pm_objDR["NGAY_BACKUP"] = System.Convert.DBNull;
	}

	public string strNOI_LUU 
	{
		get 
		{
			return CNull.RowNVLString(pm_objDR, "NOI_LUU", IPConstants.c_DefaultString);
		}
		set 
		{
			pm_objDR["NOI_LUU"] = value;
		}
	}

	public bool IsNOI_LUUNull() 
	{
		return pm_objDR.IsNull("NOI_LUU");
	}

	public void SetNOI_LUUNull() {
		pm_objDR["NOI_LUU"] = System.Convert.DBNull;
	}

	public string strTEN_FILE 
	{
		get 
		{
			return CNull.RowNVLString(pm_objDR, "TEN_FILE", IPConstants.c_DefaultString);
		}
		set 
		{
			pm_objDR["TEN_FILE"] = value;
		}
	}

	public bool IsTEN_FILENull() 
	{
		return pm_objDR.IsNull("TEN_FILE");
	}

	public void SetTEN_FILENull() {
		pm_objDR["TEN_FILE"] = System.Convert.DBNull;
	}

	public string strGhI_CHU 
	{
		get 
		{
			return CNull.RowNVLString(pm_objDR, "GhI_CHU", IPConstants.c_DefaultString);
		}
		set 
		{
			pm_objDR["GhI_CHU"] = value;
		}
	}

	public bool IsGhI_CHUNull() 
	{
		return pm_objDR.IsNull("GhI_CHU");
	}

	public void SetGhI_CHUNull() {
		pm_objDR["GhI_CHU"] = System.Convert.DBNull;
	}

#endregion
#region "Init Functions"
	public US_HT_BACKUP_HISTORY() 
	{
		pm_objDS = new DS_HT_BACKUP_HISTORY();
		pm_strTableName = c_TableName;
		pm_objDR = pm_objDS.Tables[pm_strTableName].NewRow();
	}

	public US_HT_BACKUP_HISTORY(DataRow i_objDR): this()
	{
		this.DataRow2Me(i_objDR);
	}

	public US_HT_BACKUP_HISTORY(decimal i_dbID) 
	{
		pm_objDS = new DS_HT_BACKUP_HISTORY();
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
