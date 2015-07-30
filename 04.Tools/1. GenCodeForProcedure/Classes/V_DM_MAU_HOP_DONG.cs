///////////////////////////////////////////////////////////////////////////
// Description: Data Access class for the view 'V_DM_MAU_HOP_DONG'
// Generated by LLBLGen v1.21.2003.712 Final on: Thursday, April 30, 2015, 22:19:36
// Because the Base Class already implements IDispose, this class doesn't.
///////////////////////////////////////////////////////////////////////////
using System;
using System.Data;
using System.Data.SqlTypes;
using System.Data.SqlClient;

namespace TRMLLBL
{
	/// <summary>
	/// Purpose: Data Access class for the view 'V_DM_MAU_HOP_DONG'.
	/// </summary>
	public class V_DM_MAU_HOP_DONG : DBInteractionBase
	{
		#region Class Member Declarations
			private SqlDateTime		_nGAY_TAO;
			private SqlDecimal		_iD_DV_THANH_TOAN, _iD_HINH_THUC_HD, _iD_NGUOI_TAO, _iD, _iD_DV_QUAN_LY;
			private SqlString		_tEN_FILE_HD, _hINH_THUC_HD, _mA_MAU_HD, _dV_QUAN_LY, _dV_THANH_TOAN;
		#endregion


		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public V_DM_MAU_HOP_DONG()
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
		///		 <LI>MA_MAU_HD</LI>
		///		 <LI>ID_DV_QUAN_LY</LI>
		///		 <LI>DV_QUAN_LY. May be SqlString.Null</LI>
		///		 <LI>ID_DV_THANH_TOAN</LI>
		///		 <LI>DV_THANH_TOAN. May be SqlString.Null</LI>
		///		 <LI>ID_HINH_THUC_HD</LI>
		///		 <LI>HINH_THUC_HD. May be SqlString.Null</LI>
		///		 <LI>NGAY_TAO</LI>
		///		 <LI>ID_NGUOI_TAO</LI>
		///		 <LI>TEN_FILE_HD</LI>
		/// </UL>
		/// Properties set after a succesful call of this method: 
		/// <UL>
		///		 <LI>ID</LI>
		/// </UL>
		/// </remarks>
		public override bool Insert()
		{
			SqlCommand	cmdToExecute = new SqlCommand();
			cmdToExecute.CommandText = "dbo.[pr_V_DM_MAU_HOP_DONG_Insert]";
			cmdToExecute.CommandType = CommandType.StoredProcedure;

			// Use base class' connection object
			cmdToExecute.Connection = _mainConnection;

			try
			{
				cmdToExecute.Parameters.Add(new SqlParameter("@MA_MAU_HD", SqlDbType.NVarChar, 35, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, _mA_MAU_HD));
				cmdToExecute.Parameters.Add(new SqlParameter("@ID_DV_QUAN_LY", SqlDbType.Decimal, 9, ParameterDirection.Input, false, 18, 1, "", DataRowVersion.Proposed, _iD_DV_QUAN_LY));
				cmdToExecute.Parameters.Add(new SqlParameter("@DV_QUAN_LY", SqlDbType.NVarChar, 250, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, _dV_QUAN_LY));
				cmdToExecute.Parameters.Add(new SqlParameter("@ID_DV_THANH_TOAN", SqlDbType.Decimal, 9, ParameterDirection.Input, false, 18, 1, "", DataRowVersion.Proposed, _iD_DV_THANH_TOAN));
				cmdToExecute.Parameters.Add(new SqlParameter("@DV_THANH_TOAN", SqlDbType.NVarChar, 250, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, _dV_THANH_TOAN));
				cmdToExecute.Parameters.Add(new SqlParameter("@ID_HINH_THUC_HD", SqlDbType.Decimal, 9, ParameterDirection.Input, false, 18, 1, "", DataRowVersion.Proposed, _iD_HINH_THUC_HD));
				cmdToExecute.Parameters.Add(new SqlParameter("@HINH_THUC_HD", SqlDbType.NVarChar, 250, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, _hINH_THUC_HD));
				cmdToExecute.Parameters.Add(new SqlParameter("@NGAY_TAO", SqlDbType.DateTime, 8, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, _nGAY_TAO));
				cmdToExecute.Parameters.Add(new SqlParameter("@ID_NGUOI_TAO", SqlDbType.Decimal, 9, ParameterDirection.Input, false, 18, 1, "", DataRowVersion.Proposed, _iD_NGUOI_TAO));
				cmdToExecute.Parameters.Add(new SqlParameter("@TEN_FILE_HD", SqlDbType.NVarChar, 250, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, _tEN_FILE_HD));
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
				throw new Exception("V_DM_MAU_HOP_DONG::Insert::Error occured.", ex);
			}
			finally
			{
				// Close connection.
				_mainConnection.Close();
				cmdToExecute.Dispose();
			}
		}


		/// <summary>
		/// Purpose: Select method for a unique field. This method will Select one row from the database, based on the unique field 'ID'
		/// </summary>
		/// <returns>DataTable object if succeeded, otherwise an Exception is thrown. </returns>
		/// <remarks>
		/// Properties needed for this method: 
		/// <UL>
		///		 <LI>ID</LI>
		/// </UL>
		///		 <LI>ID</LI>
		///		 <LI>MA_MAU_HD</LI>
		///		 <LI>ID_DV_QUAN_LY</LI>
		///		 <LI>DV_QUAN_LY</LI>
		///		 <LI>ID_DV_THANH_TOAN</LI>
		///		 <LI>DV_THANH_TOAN</LI>
		///		 <LI>ID_HINH_THUC_HD</LI>
		///		 <LI>HINH_THUC_HD</LI>
		///		 <LI>NGAY_TAO</LI>
		///		 <LI>ID_NGUOI_TAO</LI>
		///		 <LI>TEN_FILE_HD</LI>
		/// Will fill all properties corresponding with a field in the view with the value of the row selected.
		/// </remarks>
		public DataTable SelectOneWIDLogic()
		{
			SqlCommand	cmdToExecute = new SqlCommand();
			cmdToExecute.CommandText = "dbo.[pr_V_DM_MAU_HOP_DONG_SelectOneWIDLogic]";
			cmdToExecute.CommandType = CommandType.StoredProcedure;
			DataTable toReturn = new DataTable("V_DM_MAU_HOP_DONG");
			SqlDataAdapter adapter = new SqlDataAdapter(cmdToExecute);

			// Use base class' connection object
			cmdToExecute.Connection = _mainConnection;

			try
			{
				cmdToExecute.Parameters.Add(new SqlParameter("@ID", SqlDbType.Decimal, 9, ParameterDirection.Input, false, 18, 1, "", DataRowVersion.Proposed, _iD));

				// Open connection.
				_mainConnection.Open();

				// Execute query.
				adapter.Fill(toReturn);
				if(toReturn.Rows.Count > 0)
				{
					_iD = (Decimal)toReturn.Rows[0]["ID"];
					_mA_MAU_HD = (string)toReturn.Rows[0]["MA_MAU_HD"];
					_iD_DV_QUAN_LY = (Decimal)toReturn.Rows[0]["ID_DV_QUAN_LY"];
					_dV_QUAN_LY = toReturn.Rows[0]["DV_QUAN_LY"] == System.DBNull.Value ? SqlString.Null : (string)toReturn.Rows[0]["DV_QUAN_LY"];
					_iD_DV_THANH_TOAN = (Decimal)toReturn.Rows[0]["ID_DV_THANH_TOAN"];
					_dV_THANH_TOAN = toReturn.Rows[0]["DV_THANH_TOAN"] == System.DBNull.Value ? SqlString.Null : (string)toReturn.Rows[0]["DV_THANH_TOAN"];
					_iD_HINH_THUC_HD = (Decimal)toReturn.Rows[0]["ID_HINH_THUC_HD"];
					_hINH_THUC_HD = toReturn.Rows[0]["HINH_THUC_HD"] == System.DBNull.Value ? SqlString.Null : (string)toReturn.Rows[0]["HINH_THUC_HD"];
					_nGAY_TAO = (DateTime)toReturn.Rows[0]["NGAY_TAO"];
					_iD_NGUOI_TAO = (Decimal)toReturn.Rows[0]["ID_NGUOI_TAO"];
					_tEN_FILE_HD = (string)toReturn.Rows[0]["TEN_FILE_HD"];
				}
				return toReturn;
			}
			catch(Exception ex)
			{
				// some error occured. Bubble it to caller and encapsulate Exception object
				throw new Exception("V_DM_MAU_HOP_DONG::SelectOneWIDLogic::Error occured.", ex);
			}
			finally
			{
				// Close connection.
				_mainConnection.Close();
				cmdToExecute.Dispose();
				adapter.Dispose();
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


		public SqlString MA_MAU_HD
		{
			get
			{
				return _mA_MAU_HD;
			}
			set
			{
				SqlString mA_MAU_HDTmp = (SqlString)value;
				if(mA_MAU_HDTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("MA_MAU_HD", "MA_MAU_HD can't be NULL");
				}
				_mA_MAU_HD = value;
			}
		}


		public SqlDecimal ID_DV_QUAN_LY
		{
			get
			{
				return _iD_DV_QUAN_LY;
			}
			set
			{
				SqlDecimal iD_DV_QUAN_LYTmp = (SqlDecimal)value;
				if(iD_DV_QUAN_LYTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("ID_DV_QUAN_LY", "ID_DV_QUAN_LY can't be NULL");
				}
				_iD_DV_QUAN_LY = value;
			}
		}


		public SqlString DV_QUAN_LY
		{
			get
			{
				return _dV_QUAN_LY;
			}
			set
			{
				SqlString dV_QUAN_LYTmp = (SqlString)value;
				if(dV_QUAN_LYTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("DV_QUAN_LY", "DV_QUAN_LY can't be NULL");
				}
				_dV_QUAN_LY = value;
			}
		}


		public SqlDecimal ID_DV_THANH_TOAN
		{
			get
			{
				return _iD_DV_THANH_TOAN;
			}
			set
			{
				SqlDecimal iD_DV_THANH_TOANTmp = (SqlDecimal)value;
				if(iD_DV_THANH_TOANTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("ID_DV_THANH_TOAN", "ID_DV_THANH_TOAN can't be NULL");
				}
				_iD_DV_THANH_TOAN = value;
			}
		}


		public SqlString DV_THANH_TOAN
		{
			get
			{
				return _dV_THANH_TOAN;
			}
			set
			{
				SqlString dV_THANH_TOANTmp = (SqlString)value;
				if(dV_THANH_TOANTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("DV_THANH_TOAN", "DV_THANH_TOAN can't be NULL");
				}
				_dV_THANH_TOAN = value;
			}
		}


		public SqlDecimal ID_HINH_THUC_HD
		{
			get
			{
				return _iD_HINH_THUC_HD;
			}
			set
			{
				SqlDecimal iD_HINH_THUC_HDTmp = (SqlDecimal)value;
				if(iD_HINH_THUC_HDTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("ID_HINH_THUC_HD", "ID_HINH_THUC_HD can't be NULL");
				}
				_iD_HINH_THUC_HD = value;
			}
		}


		public SqlString HINH_THUC_HD
		{
			get
			{
				return _hINH_THUC_HD;
			}
			set
			{
				SqlString hINH_THUC_HDTmp = (SqlString)value;
				if(hINH_THUC_HDTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("HINH_THUC_HD", "HINH_THUC_HD can't be NULL");
				}
				_hINH_THUC_HD = value;
			}
		}


		public SqlDateTime NGAY_TAO
		{
			get
			{
				return _nGAY_TAO;
			}
			set
			{
				SqlDateTime nGAY_TAOTmp = (SqlDateTime)value;
				if(nGAY_TAOTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("NGAY_TAO", "NGAY_TAO can't be NULL");
				}
				_nGAY_TAO = value;
			}
		}


		public SqlDecimal ID_NGUOI_TAO
		{
			get
			{
				return _iD_NGUOI_TAO;
			}
			set
			{
				SqlDecimal iD_NGUOI_TAOTmp = (SqlDecimal)value;
				if(iD_NGUOI_TAOTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("ID_NGUOI_TAO", "ID_NGUOI_TAO can't be NULL");
				}
				_iD_NGUOI_TAO = value;
			}
		}


		public SqlString TEN_FILE_HD
		{
			get
			{
				return _tEN_FILE_HD;
			}
			set
			{
				SqlString tEN_FILE_HDTmp = (SqlString)value;
				if(tEN_FILE_HDTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("TEN_FILE_HD", "TEN_FILE_HD can't be NULL");
				}
				_tEN_FILE_HD = value;
			}
		}
		#endregion
	}
}