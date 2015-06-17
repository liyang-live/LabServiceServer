using System; 
using System.Text; 
using System.Data;
using System.Data.SqlClient;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration; 
using System.Xml; 
using System.Xml.Serialization;
using SubSonic; 
using SubSonic.Utilities;
// <auto-generated />
namespace Vietbait.Lablink.Model
{
	/// <summary>
	/// Strongly-typed collection for the TblHislisReg class.
	/// </summary>
    [Serializable]
	public partial class TblHislisRegCollection : ActiveList<TblHislisReg, TblHislisRegCollection>
	{	   
		public TblHislisRegCollection() {}
        
        /// <summary>
		/// Filters an existing collection based on the set criteria. This is an in-memory filter
		/// Thanks to developingchris for this!
        /// </summary>
        /// <returns>TblHislisRegCollection</returns>
		public TblHislisRegCollection Filter()
        {
            for (int i = this.Count - 1; i > -1; i--)
            {
                TblHislisReg o = this[i];
                foreach (SubSonic.Where w in this.wheres)
                {
                    bool remove = false;
                    System.Reflection.PropertyInfo pi = o.GetType().GetProperty(w.ColumnName);
                    if (pi.CanRead)
                    {
                        object val = pi.GetValue(o, null);
                        switch (w.Comparison)
                        {
                            case SubSonic.Comparison.Equals:
                                if (!val.Equals(w.ParameterValue))
                                {
                                    remove = true;
                                }
                                break;
                        }
                    }
                    if (remove)
                    {
                        this.Remove(o);
                        break;
                    }
                }
            }
            return this;
        }
		
		
	}
	/// <summary>
	/// This is an ActiveRecord class which wraps the tbl_HISLIS_REG table.
	/// </summary>
	[Serializable]
	public partial class TblHislisReg : ActiveRecord<TblHislisReg>, IActiveRecord
	{
		#region .ctors and Default Settings
		
		public TblHislisReg()
		{
		  SetSQLProps();
		  InitSetDefaults();
		  MarkNew();
		}
		
		private void InitSetDefaults() { SetDefaults(); }
		
		public TblHislisReg(bool useDatabaseDefaults)
		{
			SetSQLProps();
			if(useDatabaseDefaults)
				ForceDefaults();
			MarkNew();
		}
        
		public TblHislisReg(object keyID)
		{
			SetSQLProps();
			InitSetDefaults();
			LoadByKey(keyID);
		}
		 
		public TblHislisReg(string columnName, object columnValue)
		{
			SetSQLProps();
			InitSetDefaults();
			LoadByParam(columnName,columnValue);
		}
		
		protected static void SetSQLProps() { GetTableSchema(); }
		
		#endregion
		
		#region Schema and Query Accessor	
		public static Query CreateQuery() { return new Query(Schema); }
		public static TableSchema.Table Schema
		{
			get
			{
				if (BaseSchema == null)
					SetSQLProps();
				return BaseSchema;
			}
		}
		
		private static void GetTableSchema() 
		{
			if(!IsSchemaInitialized)
			{
				//Schema declaration
				TableSchema.Table schema = new TableSchema.Table("tbl_HISLIS_REG", TableType.Table, DataService.GetInstance("ORM"));
				schema.Columns = new TableSchema.TableColumnCollection();
				schema.SchemaName = @"dbo";
				//columns
				
				TableSchema.TableColumn colvarId = new TableSchema.TableColumn(schema);
				colvarId.ColumnName = "ID";
				colvarId.DataType = DbType.Int32;
				colvarId.MaxLength = 0;
				colvarId.AutoIncrement = true;
				colvarId.IsNullable = false;
				colvarId.IsPrimaryKey = true;
				colvarId.IsForeignKey = false;
				colvarId.IsReadOnly = false;
				colvarId.DefaultSetting = @"";
				colvarId.ForeignKeyTableName = "";
				schema.Columns.Add(colvarId);
				
				TableSchema.TableColumn colvarSoPhieuChiDinh = new TableSchema.TableColumn(schema);
				colvarSoPhieuChiDinh.ColumnName = "SoPhieuChiDinh";
				colvarSoPhieuChiDinh.DataType = DbType.String;
				colvarSoPhieuChiDinh.MaxLength = 20;
				colvarSoPhieuChiDinh.AutoIncrement = false;
				colvarSoPhieuChiDinh.IsNullable = false;
				colvarSoPhieuChiDinh.IsPrimaryKey = false;
				colvarSoPhieuChiDinh.IsForeignKey = false;
				colvarSoPhieuChiDinh.IsReadOnly = false;
				colvarSoPhieuChiDinh.DefaultSetting = @"";
				colvarSoPhieuChiDinh.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSoPhieuChiDinh);
				
				TableSchema.TableColumn colvarIDXetNghiemHis = new TableSchema.TableColumn(schema);
				colvarIDXetNghiemHis.ColumnName = "IDXetNghiem_HIS";
				colvarIDXetNghiemHis.DataType = DbType.String;
				colvarIDXetNghiemHis.MaxLength = 10;
				colvarIDXetNghiemHis.AutoIncrement = false;
				colvarIDXetNghiemHis.IsNullable = true;
				colvarIDXetNghiemHis.IsPrimaryKey = false;
				colvarIDXetNghiemHis.IsForeignKey = false;
				colvarIDXetNghiemHis.IsReadOnly = false;
				colvarIDXetNghiemHis.DefaultSetting = @"";
				colvarIDXetNghiemHis.ForeignKeyTableName = "";
				schema.Columns.Add(colvarIDXetNghiemHis);
				
				TableSchema.TableColumn colvarIDTriSoHis = new TableSchema.TableColumn(schema);
				colvarIDTriSoHis.ColumnName = "IDTriSo_HIS";
				colvarIDTriSoHis.DataType = DbType.String;
				colvarIDTriSoHis.MaxLength = 10;
				colvarIDTriSoHis.AutoIncrement = false;
				colvarIDTriSoHis.IsNullable = true;
				colvarIDTriSoHis.IsPrimaryKey = false;
				colvarIDTriSoHis.IsForeignKey = false;
				colvarIDTriSoHis.IsReadOnly = false;
				colvarIDTriSoHis.DefaultSetting = @"";
				colvarIDTriSoHis.ForeignKeyTableName = "";
				schema.Columns.Add(colvarIDTriSoHis);
				
				TableSchema.TableColumn colvarIDChiDinhChiTiet = new TableSchema.TableColumn(schema);
				colvarIDChiDinhChiTiet.ColumnName = "IDChiDinhChiTiet";
				colvarIDChiDinhChiTiet.DataType = DbType.String;
				colvarIDChiDinhChiTiet.MaxLength = 10;
				colvarIDChiDinhChiTiet.AutoIncrement = false;
				colvarIDChiDinhChiTiet.IsNullable = true;
				colvarIDChiDinhChiTiet.IsPrimaryKey = false;
				colvarIDChiDinhChiTiet.IsForeignKey = false;
				colvarIDChiDinhChiTiet.IsReadOnly = false;
				colvarIDChiDinhChiTiet.DefaultSetting = @"";
				colvarIDChiDinhChiTiet.ForeignKeyTableName = "";
				schema.Columns.Add(colvarIDChiDinhChiTiet);
				
				TableSchema.TableColumn colvarTenXetNghiemTriSo = new TableSchema.TableColumn(schema);
				colvarTenXetNghiemTriSo.ColumnName = "TenXetNghiem_TriSo";
				colvarTenXetNghiemTriSo.DataType = DbType.String;
				colvarTenXetNghiemTriSo.MaxLength = 100;
				colvarTenXetNghiemTriSo.AutoIncrement = false;
				colvarTenXetNghiemTriSo.IsNullable = true;
				colvarTenXetNghiemTriSo.IsPrimaryKey = false;
				colvarTenXetNghiemTriSo.IsForeignKey = false;
				colvarTenXetNghiemTriSo.IsReadOnly = false;
				colvarTenXetNghiemTriSo.DefaultSetting = @"";
				colvarTenXetNghiemTriSo.ForeignKeyTableName = "";
				schema.Columns.Add(colvarTenXetNghiemTriSo);
				
				TableSchema.TableColumn colvarLaTriSo = new TableSchema.TableColumn(schema);
				colvarLaTriSo.ColumnName = "LaTriSo";
				colvarLaTriSo.DataType = DbType.String;
				colvarLaTriSo.MaxLength = 10;
				colvarLaTriSo.AutoIncrement = false;
				colvarLaTriSo.IsNullable = true;
				colvarLaTriSo.IsPrimaryKey = false;
				colvarLaTriSo.IsForeignKey = false;
				colvarLaTriSo.IsReadOnly = false;
				colvarLaTriSo.DefaultSetting = @"";
				colvarLaTriSo.ForeignKeyTableName = "";
				schema.Columns.Add(colvarLaTriSo);
				
				TableSchema.TableColumn colvarTriSoBinhThuong = new TableSchema.TableColumn(schema);
				colvarTriSoBinhThuong.ColumnName = "TriSoBinhThuong";
				colvarTriSoBinhThuong.DataType = DbType.String;
				colvarTriSoBinhThuong.MaxLength = 500;
				colvarTriSoBinhThuong.AutoIncrement = false;
				colvarTriSoBinhThuong.IsNullable = true;
				colvarTriSoBinhThuong.IsPrimaryKey = false;
				colvarTriSoBinhThuong.IsForeignKey = false;
				colvarTriSoBinhThuong.IsReadOnly = false;
				colvarTriSoBinhThuong.DefaultSetting = @"";
				colvarTriSoBinhThuong.ForeignKeyTableName = "";
				schema.Columns.Add(colvarTriSoBinhThuong);
				
				TableSchema.TableColumn colvarKetQua = new TableSchema.TableColumn(schema);
				colvarKetQua.ColumnName = "KetQua";
				colvarKetQua.DataType = DbType.String;
				colvarKetQua.MaxLength = 50;
				colvarKetQua.AutoIncrement = false;
				colvarKetQua.IsNullable = true;
				colvarKetQua.IsPrimaryKey = false;
				colvarKetQua.IsForeignKey = false;
				colvarKetQua.IsReadOnly = false;
				colvarKetQua.DefaultSetting = @"";
				colvarKetQua.ForeignKeyTableName = "";
				schema.Columns.Add(colvarKetQua);
				
				TableSchema.TableColumn colvarNhanXet = new TableSchema.TableColumn(schema);
				colvarNhanXet.ColumnName = "NhanXet";
				colvarNhanXet.DataType = DbType.String;
				colvarNhanXet.MaxLength = 200;
				colvarNhanXet.AutoIncrement = false;
				colvarNhanXet.IsNullable = true;
				colvarNhanXet.IsPrimaryKey = false;
				colvarNhanXet.IsForeignKey = false;
				colvarNhanXet.IsReadOnly = false;
				colvarNhanXet.DefaultSetting = @"";
				colvarNhanXet.ForeignKeyTableName = "";
				schema.Columns.Add(colvarNhanXet);
				
				TableSchema.TableColumn colvarBarcode = new TableSchema.TableColumn(schema);
				colvarBarcode.ColumnName = "Barcode";
				colvarBarcode.DataType = DbType.String;
				colvarBarcode.MaxLength = 50;
				colvarBarcode.AutoIncrement = false;
				colvarBarcode.IsNullable = true;
				colvarBarcode.IsPrimaryKey = false;
				colvarBarcode.IsForeignKey = false;
				colvarBarcode.IsReadOnly = false;
				colvarBarcode.DefaultSetting = @"";
				colvarBarcode.ForeignKeyTableName = "";
				schema.Columns.Add(colvarBarcode);
				
				BaseSchema = schema;
				//add this schema to the provider
				//so we can query it later
				DataService.Providers["ORM"].AddSchema("tbl_HISLIS_REG",schema);
			}
		}
		#endregion
		
		#region Props
		  
		[XmlAttribute("Id")]
		[Bindable(true)]
		public int Id 
		{
			get { return GetColumnValue<int>(Columns.Id); }
			set { SetColumnValue(Columns.Id, value); }
		}
		  
		[XmlAttribute("SoPhieuChiDinh")]
		[Bindable(true)]
		public string SoPhieuChiDinh 
		{
			get { return GetColumnValue<string>(Columns.SoPhieuChiDinh); }
			set { SetColumnValue(Columns.SoPhieuChiDinh, value); }
		}
		  
		[XmlAttribute("IDXetNghiemHis")]
		[Bindable(true)]
		public string IDXetNghiemHis 
		{
			get { return GetColumnValue<string>(Columns.IDXetNghiemHis); }
			set { SetColumnValue(Columns.IDXetNghiemHis, value); }
		}
		  
		[XmlAttribute("IDTriSoHis")]
		[Bindable(true)]
		public string IDTriSoHis 
		{
			get { return GetColumnValue<string>(Columns.IDTriSoHis); }
			set { SetColumnValue(Columns.IDTriSoHis, value); }
		}
		  
		[XmlAttribute("IDChiDinhChiTiet")]
		[Bindable(true)]
		public string IDChiDinhChiTiet 
		{
			get { return GetColumnValue<string>(Columns.IDChiDinhChiTiet); }
			set { SetColumnValue(Columns.IDChiDinhChiTiet, value); }
		}
		  
		[XmlAttribute("TenXetNghiemTriSo")]
		[Bindable(true)]
		public string TenXetNghiemTriSo 
		{
			get { return GetColumnValue<string>(Columns.TenXetNghiemTriSo); }
			set { SetColumnValue(Columns.TenXetNghiemTriSo, value); }
		}
		  
		[XmlAttribute("LaTriSo")]
		[Bindable(true)]
		public string LaTriSo 
		{
			get { return GetColumnValue<string>(Columns.LaTriSo); }
			set { SetColumnValue(Columns.LaTriSo, value); }
		}
		  
		[XmlAttribute("TriSoBinhThuong")]
		[Bindable(true)]
		public string TriSoBinhThuong 
		{
			get { return GetColumnValue<string>(Columns.TriSoBinhThuong); }
			set { SetColumnValue(Columns.TriSoBinhThuong, value); }
		}
		  
		[XmlAttribute("KetQua")]
		[Bindable(true)]
		public string KetQua 
		{
			get { return GetColumnValue<string>(Columns.KetQua); }
			set { SetColumnValue(Columns.KetQua, value); }
		}
		  
		[XmlAttribute("NhanXet")]
		[Bindable(true)]
		public string NhanXet 
		{
			get { return GetColumnValue<string>(Columns.NhanXet); }
			set { SetColumnValue(Columns.NhanXet, value); }
		}
		  
		[XmlAttribute("Barcode")]
		[Bindable(true)]
		public string Barcode 
		{
			get { return GetColumnValue<string>(Columns.Barcode); }
			set { SetColumnValue(Columns.Barcode, value); }
		}
		
		#endregion
		
		
			
		
		//no foreign key tables defined (0)
		
		
		
		//no ManyToMany tables defined (0)
		
        
        
		#region ObjectDataSource support
		
		
		/// <summary>
		/// Inserts a record, can be used with the Object Data Source
		/// </summary>
		public static void Insert(string varSoPhieuChiDinh,string varIDXetNghiemHis,string varIDTriSoHis,string varIDChiDinhChiTiet,string varTenXetNghiemTriSo,string varLaTriSo,string varTriSoBinhThuong,string varKetQua,string varNhanXet,string varBarcode)
		{
			TblHislisReg item = new TblHislisReg();
			
			item.SoPhieuChiDinh = varSoPhieuChiDinh;
			
			item.IDXetNghiemHis = varIDXetNghiemHis;
			
			item.IDTriSoHis = varIDTriSoHis;
			
			item.IDChiDinhChiTiet = varIDChiDinhChiTiet;
			
			item.TenXetNghiemTriSo = varTenXetNghiemTriSo;
			
			item.LaTriSo = varLaTriSo;
			
			item.TriSoBinhThuong = varTriSoBinhThuong;
			
			item.KetQua = varKetQua;
			
			item.NhanXet = varNhanXet;
			
			item.Barcode = varBarcode;
			
		
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		
		/// <summary>
		/// Updates a record, can be used with the Object Data Source
		/// </summary>
		public static void Update(int varId,string varSoPhieuChiDinh,string varIDXetNghiemHis,string varIDTriSoHis,string varIDChiDinhChiTiet,string varTenXetNghiemTriSo,string varLaTriSo,string varTriSoBinhThuong,string varKetQua,string varNhanXet,string varBarcode)
		{
			TblHislisReg item = new TblHislisReg();
			
				item.Id = varId;
			
				item.SoPhieuChiDinh = varSoPhieuChiDinh;
			
				item.IDXetNghiemHis = varIDXetNghiemHis;
			
				item.IDTriSoHis = varIDTriSoHis;
			
				item.IDChiDinhChiTiet = varIDChiDinhChiTiet;
			
				item.TenXetNghiemTriSo = varTenXetNghiemTriSo;
			
				item.LaTriSo = varLaTriSo;
			
				item.TriSoBinhThuong = varTriSoBinhThuong;
			
				item.KetQua = varKetQua;
			
				item.NhanXet = varNhanXet;
			
				item.Barcode = varBarcode;
			
			item.IsNew = false;
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		#endregion
        
        
        
        #region Typed Columns
        
        
        public static TableSchema.TableColumn IdColumn
        {
            get { return Schema.Columns[0]; }
        }
        
        
        
        public static TableSchema.TableColumn SoPhieuChiDinhColumn
        {
            get { return Schema.Columns[1]; }
        }
        
        
        
        public static TableSchema.TableColumn IDXetNghiemHisColumn
        {
            get { return Schema.Columns[2]; }
        }
        
        
        
        public static TableSchema.TableColumn IDTriSoHisColumn
        {
            get { return Schema.Columns[3]; }
        }
        
        
        
        public static TableSchema.TableColumn IDChiDinhChiTietColumn
        {
            get { return Schema.Columns[4]; }
        }
        
        
        
        public static TableSchema.TableColumn TenXetNghiemTriSoColumn
        {
            get { return Schema.Columns[5]; }
        }
        
        
        
        public static TableSchema.TableColumn LaTriSoColumn
        {
            get { return Schema.Columns[6]; }
        }
        
        
        
        public static TableSchema.TableColumn TriSoBinhThuongColumn
        {
            get { return Schema.Columns[7]; }
        }
        
        
        
        public static TableSchema.TableColumn KetQuaColumn
        {
            get { return Schema.Columns[8]; }
        }
        
        
        
        public static TableSchema.TableColumn NhanXetColumn
        {
            get { return Schema.Columns[9]; }
        }
        
        
        
        public static TableSchema.TableColumn BarcodeColumn
        {
            get { return Schema.Columns[10]; }
        }
        
        
        
        #endregion
		#region Columns Struct
		public struct Columns
		{
			 public static string Id = @"ID";
			 public static string SoPhieuChiDinh = @"SoPhieuChiDinh";
			 public static string IDXetNghiemHis = @"IDXetNghiem_HIS";
			 public static string IDTriSoHis = @"IDTriSo_HIS";
			 public static string IDChiDinhChiTiet = @"IDChiDinhChiTiet";
			 public static string TenXetNghiemTriSo = @"TenXetNghiem_TriSo";
			 public static string LaTriSo = @"LaTriSo";
			 public static string TriSoBinhThuong = @"TriSoBinhThuong";
			 public static string KetQua = @"KetQua";
			 public static string NhanXet = @"NhanXet";
			 public static string Barcode = @"Barcode";
						
		}
		#endregion
		
		#region Update PK Collections
		
        #endregion
    
        #region Deep Save
		
        #endregion
	}
}