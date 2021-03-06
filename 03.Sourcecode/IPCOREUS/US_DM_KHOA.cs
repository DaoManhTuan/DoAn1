///************************************************
/// Generated by: tuandm
/// Date: 01/12/2015 05:10:11
/// Goal: Create User Service Class for DM_KHOA
///************************************************
/// <summary>
/// Create User Service Class for DM_KHOA
/// </summary>

using System;
using IPCOREDS;
using IP.Core.IPCommon;
using IP.Core.IPUserService;
using System.Data.SqlClient;
using System.Data;


namespace IPCOREUS
{

	public class US_DM_KHOA : US_Object
	{
		private const string c_TableName = "DM_KHOA";
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

		public string strKHOA 
		{
			get 
			{
				return CNull.RowNVLString(pm_objDR, "KHOA", IPConstants.c_DefaultString);
			}
			set 
			{
				pm_objDR["KHOA"] = value;
			}
		}

		public bool IsKHOANull() 
		{
			return pm_objDR.IsNull("KHOA");
		}

		public void SetKHOANull() {
			pm_objDR["KHOA"] = System.Convert.DBNull;
		}

		public decimal dcNAM_BAT_DAU 
		{
			get
			{
				return CNull.RowNVLDecimal(pm_objDR, "NAM_BAT_DAU", IPConstants.c_DefaultDecimal);
			}
			set	
			{
				pm_objDR["NAM_BAT_DAU"] = value;
			}
		}

		public bool IsNAM_BAT_DAUNull()	{
			return pm_objDR.IsNull("NAM_BAT_DAU");
		}

		public void SetNAM_BAT_DAUNull() {
			pm_objDR["NAM_BAT_DAU"] = System.Convert.DBNull;
		}

		public decimal dcTRANG_THAI_HSD 
		{
			get
			{
				return CNull.RowNVLDecimal(pm_objDR, "TRANG_THAI_HSD", IPConstants.c_DefaultDecimal);
			}
			set	
			{
				pm_objDR["TRANG_THAI_HSD"] = value;
			}
		}

		public bool IsTRANG_THAI_HSDNull()	{
			return pm_objDR.IsNull("TRANG_THAI_HSD");
		}

		public void SetTRANG_THAI_HSDNull() {
			pm_objDR["TRANG_THAI_HSD"] = System.Convert.DBNull;
		}

		#endregion


		#region Init Functions
		public US_DM_KHOA() 
		{
			pm_objDS = new DS_DM_KHOA();
			pm_strTableName = c_TableName;
			pm_objDR = pm_objDS.Tables[pm_strTableName].NewRow();
		}

		public US_DM_KHOA(DataRow i_objDR): this()
		{
			this.DataRow2Me(i_objDR);
		}

		public US_DM_KHOA(decimal i_dbID) 
		{
			pm_objDS = new DS_DM_KHOA();
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
