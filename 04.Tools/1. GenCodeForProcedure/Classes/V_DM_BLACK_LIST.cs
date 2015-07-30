///////////////////////////////////////////////////////////////////////////
// Description: Data Access class for the view 'V_DM_BLACK_LIST'
// Generated by LLBLGen v1.21.2003.712 Final on: Tuesday, April 01, 2014, 12:03:04 PM
// Because the Base Class already implements IDispose, this class doesn't.
///////////////////////////////////////////////////////////////////////////
using System;
using System.Data;
using System.Data.SqlTypes;
using System.Data.SqlClient;

namespace TOS_TicketSystemLLBL
{
	/// <summary>
	/// Purpose: Data Access class for the view 'V_DM_BLACK_LIST'.
	/// </summary>
	public class V_DM_BLACK_LIST : DBInteractionBase
	{
		#region Class Member Declarations
			private SqlDateTime		_nGAY_REMOVE, _nGAY_ADD;
			private SqlDecimal		_iD, _iD_NGUOI_REMOVE, _iD_NGUOI_ADD;
			private SqlString		_tEN_NGUOI_ADD, _aCCOUNT_NGUOI_ADD, _tEN_NGUOI_REMOVE, _aCCOUNT_NGUOI_REMOVE, _aDD_YN, _sO_DIEN_THOAI, _gHI_CHU_LY_DO, _hO_TEN_CHU_DIEN_THOAI;
		#endregion


		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public V_DM_BLACK_LIST()
		{
			// Nothing for now.
		}


		/// <summary>
		/// Purpose: Insert method. This method will insert one new row into the database.
		/// </summary>
		/// <returns>True if succeeded, otherwise an Exception is thrown. </returns>
		/// <remarks>
		/// Properties needed for this method: 
		/// <UL>
		///		 <LI>SO_DIEN_THOAI</LI>
		///		 <LI>ID_NGUOI_ADD. May be SqlDecimal.Null</LI>
		///		 <LI>ID_NGUOI_REMOVE. May be SqlDecimal.Null</LI>
		///		 <LI>NGAY_ADD. May be SqlDateTime.Null</LI>
		///		 <LI>NGAY_REMOVE. May be SqlDateTime.Null</LI>
		///		 <LI>ADD_YN</LI>
		///		 <LI>HO_TEN_CHU_DIEN_THOAI. May be SqlString.Null</LI>
		///		 <LI>GHI_CHU_LY_DO. May be SqlString.Null</LI>
		///		 <LI>ACCOUNT_NGUOI_ADD. May be SqlString.Null</LI>
		///		 <LI>TEN_NGUOI_ADD. May be SqlString.Null</LI>
		///		 <LI>ACCOUNT_NGUOI_REMOVE. May be SqlString.Null</LI>
		///		 <LI>TEN_NGUOI_REMOVE. May be SqlString.Null</LI>
		/// </UL>
		/// Properties set after a succesful call of this method: 
		/// <UL>
		///		 <LI>ID</LI>
		/// </UL>
		/// </remarks>
		public override bool Insert()
		{
			SqlCommand	cmdToExecute = new SqlCommand();
			cmdToExecute.CommandText = "dbo.[pr_V_DM_BLACK_LIST_Insert]";
			cmdToExecute.CommandType = CommandType.StoredProcedure;

			// Use base class' connection object
			cmdToExecute.Connection = _mainConnection;

			try
			{
				cmdToExecute.Parameters.Add(new SqlParameter("@SO_DIEN_THOAI", SqlDbType.NVarChar, 15, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, _sO_DIEN_THOAI));
				cmdToExecute.Parameters.Add(new SqlParameter("@ID_NGUOI_ADD", SqlDbType.Decimal, 9, ParameterDirection.Input, false, 18, 1, "", DataRowVersion.Proposed, _iD_NGUOI_ADD));
				cmdToExecute.Parameters.Add(new SqlParameter("@ID_NGUOI_REMOVE", SqlDbType.Decimal, 9, ParameterDirection.Input, false, 18, 1, "", DataRowVersion.Proposed, _iD_NGUOI_REMOVE));
				cmdToExecute.Parameters.Add(new SqlParameter("@NGAY_ADD", SqlDbType.DateTime, 8, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, _nGAY_ADD));
				cmdToExecute.Parameters.Add(new SqlParameter("@NGAY_REMOVE", SqlDbType.DateTime, 8, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, _nGAY_REMOVE));
				cmdToExecute.Parameters.Add(new SqlParameter("@ADD_YN", SqlDbType.NVarChar, 1, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, _aDD_YN));
				cmdToExecute.Parameters.Add(new SqlParameter("@HO_TEN_CHU_DIEN_THOAI", SqlDbType.NVarChar, 250, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, _hO_TEN_CHU_DIEN_THOAI));
				cmdToExecute.Parameters.Add(new SqlParameter("@GHI_CHU_LY_DO", SqlDbType.NVarChar, 250, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, _gHI_CHU_LY_DO));
				cmdToExecute.Parameters.Add(new SqlParameter("@ACCOUNT_NGUOI_ADD", SqlDbType.NVarChar, 35, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, _aCCOUNT_NGUOI_ADD));
				cmdToExecute.Parameters.Add(new SqlParameter("@TEN_NGUOI_ADD", SqlDbType.NVarChar, 250, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, _tEN_NGUOI_ADD));
				cmdToExecute.Parameters.Add(new SqlParameter("@ACCOUNT_NGUOI_REMOVE", SqlDbType.NVarChar, 35, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, _aCCOUNT_NGUOI_REMOVE));
				cmdToExecute.Parameters.Add(new SqlParameter("@TEN_NGUOI_REMOVE", SqlDbType.NVarChar, 250, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, _tEN_NGUOI_REMOVE));
				cmdToExecute.Parameters.Add(new SqlParameter("@ID", SqlDbType.Decimal, 9, ParameterDirection.Output, false, 18, 1, "", DataRowVersion.Proposed, _iD));

				// Open connection.
				_mainConnection.Open();

				// Execute query.
				_rowsAffected = cmdToExecute.ExecuteNonQuery();
				_iD = (Decimal)cmdToExecute.Parameters["@ID"].Value;
				return true;
			}
			catch(Exception ex)
			{
				// some error occured. Bubble it to caller and encapsulate Exception object
				throw new Exception("V_DM_BLACK_LIST::Insert::Error occured.", ex);
			}
			finally
			{
				// Close connection.
				_mainConnection.Close();
				cmdToExecute.Dispose();
			}
		}


		#region Class Property Declarations
		public SqlDecimal ID
		{
			get
			{
				return _iD;
			}
			set
			{
				SqlDecimal iDTmp = (SqlDecimal)value;
				if(iDTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("ID", "ID can't be NULL");
				}
				_iD = value;
			}
		}


		public SqlString SO_DIEN_THOAI
		{
			get
			{
				return _sO_DIEN_THOAI;
			}
			set
			{
				SqlString sO_DIEN_THOAITmp = (SqlString)value;
				if(sO_DIEN_THOAITmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("SO_DIEN_THOAI", "SO_DIEN_THOAI can't be NULL");
				}
				_sO_DIEN_THOAI = value;
			}
		}


		public SqlDecimal ID_NGUOI_ADD
		{
			get
			{
				return _iD_NGUOI_ADD;
			}
			set
			{
				SqlDecimal iD_NGUOI_ADDTmp = (SqlDecimal)value;
				if(iD_NGUOI_ADDTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("ID_NGUOI_ADD", "ID_NGUOI_ADD can't be NULL");
				}
				_iD_NGUOI_ADD = value;
			}
		}


		public SqlDecimal ID_NGUOI_REMOVE
		{
			get
			{
				return _iD_NGUOI_REMOVE;
			}
			set
			{
				SqlDecimal iD_NGUOI_REMOVETmp = (SqlDecimal)value;
				if(iD_NGUOI_REMOVETmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("ID_NGUOI_REMOVE", "ID_NGUOI_REMOVE can't be NULL");
				}
				_iD_NGUOI_REMOVE = value;
			}
		}


		public SqlDateTime NGAY_ADD
		{
			get
			{
				return _nGAY_ADD;
			}
			set
			{
				SqlDateTime nGAY_ADDTmp = (SqlDateTime)value;
				if(nGAY_ADDTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("NGAY_ADD", "NGAY_ADD can't be NULL");
				}
				_nGAY_ADD = value;
			}
		}


		public SqlDateTime NGAY_REMOVE
		{
			get
			{
				return _nGAY_REMOVE;
			}
			set
			{
				SqlDateTime nGAY_REMOVETmp = (SqlDateTime)value;
				if(nGAY_REMOVETmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("NGAY_REMOVE", "NGAY_REMOVE can't be NULL");
				}
				_nGAY_REMOVE = value;
			}
		}


		public SqlString ADD_YN
		{
			get
			{
				return _aDD_YN;
			}
			set
			{
				SqlString aDD_YNTmp = (SqlString)value;
				if(aDD_YNTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("ADD_YN", "ADD_YN can't be NULL");
				}
				_aDD_YN = value;
			}
		}


		public SqlString HO_TEN_CHU_DIEN_THOAI
		{
			get
			{
				return _hO_TEN_CHU_DIEN_THOAI;
			}
			set
			{
				SqlString hO_TEN_CHU_DIEN_THOAITmp = (SqlString)value;
				if(hO_TEN_CHU_DIEN_THOAITmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("HO_TEN_CHU_DIEN_THOAI", "HO_TEN_CHU_DIEN_THOAI can't be NULL");
				}
				_hO_TEN_CHU_DIEN_THOAI = value;
			}
		}


		public SqlString GHI_CHU_LY_DO
		{
			get
			{
				return _gHI_CHU_LY_DO;
			}
			set
			{
				SqlString gHI_CHU_LY_DOTmp = (SqlString)value;
				if(gHI_CHU_LY_DOTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("GHI_CHU_LY_DO", "GHI_CHU_LY_DO can't be NULL");
				}
				_gHI_CHU_LY_DO = value;
			}
		}


		public SqlString ACCOUNT_NGUOI_ADD
		{
			get
			{
				return _aCCOUNT_NGUOI_ADD;
			}
			set
			{
				SqlString aCCOUNT_NGUOI_ADDTmp = (SqlString)value;
				if(aCCOUNT_NGUOI_ADDTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("ACCOUNT_NGUOI_ADD", "ACCOUNT_NGUOI_ADD can't be NULL");
				}
				_aCCOUNT_NGUOI_ADD = value;
			}
		}


		public SqlString TEN_NGUOI_ADD
		{
			get
			{
				return _tEN_NGUOI_ADD;
			}
			set
			{
				SqlString tEN_NGUOI_ADDTmp = (SqlString)value;
				if(tEN_NGUOI_ADDTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("TEN_NGUOI_ADD", "TEN_NGUOI_ADD can't be NULL");
				}
				_tEN_NGUOI_ADD = value;
			}
		}


		public SqlString ACCOUNT_NGUOI_REMOVE
		{
			get
			{
				return _aCCOUNT_NGUOI_REMOVE;
			}
			set
			{
				SqlString aCCOUNT_NGUOI_REMOVETmp = (SqlString)value;
				if(aCCOUNT_NGUOI_REMOVETmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("ACCOUNT_NGUOI_REMOVE", "ACCOUNT_NGUOI_REMOVE can't be NULL");
				}
				_aCCOUNT_NGUOI_REMOVE = value;
			}
		}


		public SqlString TEN_NGUOI_REMOVE
		{
			get
			{
				return _tEN_NGUOI_REMOVE;
			}
			set
			{
				SqlString tEN_NGUOI_REMOVETmp = (SqlString)value;
				if(tEN_NGUOI_REMOVETmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("TEN_NGUOI_REMOVE", "TEN_NGUOI_REMOVE can't be NULL");
				}
				_tEN_NGUOI_REMOVE = value;
			}
		}
		#endregion
	}
}
