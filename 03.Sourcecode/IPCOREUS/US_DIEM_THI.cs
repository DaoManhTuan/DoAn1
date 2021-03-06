///************************************************
/// Generated by: tuandm
/// Date: 03/12/2015 04:53:55
/// Goal: Create User Service Class for DIEM_THI
///************************************************
/// <summary>
/// Create User Service Class for DIEM_THI
/// </summary>

using System;
using IPCOREDS;
using IP.Core.IPCommon;
using IP.Core.IPUserService;
using System.Data.SqlClient;
using System.Data;


namespace IPCOREUS
{

	public class US_DIEM_THI : US_Object
	{
		private const string c_TableName = "DIEM_THI";
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

		public decimal dcID_SINH_VIEN 
		{
			get
			{
				return CNull.RowNVLDecimal(pm_objDR, "ID_SINH_VIEN", IPConstants.c_DefaultDecimal);
			}
			set	
			{
				pm_objDR["ID_SINH_VIEN"] = value;
			}
		}

		public bool IsID_SINH_VIENNull()	{
			return pm_objDR.IsNull("ID_SINH_VIEN");
		}

		public void SetID_SINH_VIENNull() {
			pm_objDR["ID_SINH_VIEN"] = System.Convert.DBNull;
		}

		public decimal dcID_LOP_HOC 
		{
			get
			{
				return CNull.RowNVLDecimal(pm_objDR, "ID_LOP_HOC", IPConstants.c_DefaultDecimal);
			}
			set	
			{
				pm_objDR["ID_LOP_HOC"] = value;
			}
		}

		public bool IsID_LOP_HOCNull()	{
			return pm_objDR.IsNull("ID_LOP_HOC");
		}

		public void SetID_LOP_HOCNull() {
			pm_objDR["ID_LOP_HOC"] = System.Convert.DBNull;
		}

		public decimal dcDIEM_QUA_TRINH 
		{
			get
			{
				return CNull.RowNVLDecimal(pm_objDR, "DIEM_QUA_TRINH", IPConstants.c_DefaultDecimal);
			}
			set	
			{
				pm_objDR["DIEM_QUA_TRINH"] = value;
			}
		}

		public bool IsDIEM_QUA_TRINHNull()	{
			return pm_objDR.IsNull("DIEM_QUA_TRINH");
		}

		public void SetDIEM_QUA_TRINHNull() {
			pm_objDR["DIEM_QUA_TRINH"] = System.Convert.DBNull;
		}

		public decimal dcDIEM_THI 
		{
			get
			{
				return CNull.RowNVLDecimal(pm_objDR, "DIEM_THI", IPConstants.c_DefaultDecimal);
			}
			set	
			{
				pm_objDR["DIEM_THI"] = value;
			}
		}

		public bool IsDIEM_THINull()	{
			return pm_objDR.IsNull("DIEM_THI");
		}

		public void SetDIEM_THINull() {
			pm_objDR["DIEM_THI"] = System.Convert.DBNull;
		}

		public string strDIEM_CHU 
		{
			get 
			{
				return CNull.RowNVLString(pm_objDR, "DIEM_CHU", IPConstants.c_DefaultString);
			}
			set 
			{
				pm_objDR["DIEM_CHU"] = value;
			}
		}

		public bool IsDIEM_CHUNull() 
		{
			return pm_objDR.IsNull("DIEM_CHU");
		}

		public void SetDIEM_CHUNull() {
			pm_objDR["DIEM_CHU"] = System.Convert.DBNull;
		}

		#endregion


		#region Init Functions
		public US_DIEM_THI() 
		{
			pm_objDS = new DS_DIEM_THI();
			pm_strTableName = c_TableName;
			pm_objDR = pm_objDS.Tables[pm_strTableName].NewRow();
		}

		public US_DIEM_THI(DataRow i_objDR): this()
		{
			this.DataRow2Me(i_objDR);
		}

		public US_DIEM_THI(decimal i_dbID) 
		{
			pm_objDS = new DS_DIEM_THI();
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
