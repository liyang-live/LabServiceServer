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
    /// Controller class for tbl_HISLIS_REG
    /// </summary>
    [System.ComponentModel.DataObject]
    public partial class TblHislisRegController
    {
        // Preload our schema..
        TblHislisReg thisSchemaLoad = new TblHislisReg();
        private string userName = String.Empty;
        protected string UserName
        {
            get
            {
				if (userName.Length == 0) 
				{
    				if (System.Web.HttpContext.Current != null)
    				{
						userName=System.Web.HttpContext.Current.User.Identity.Name;
					}
					else
					{
						userName=System.Threading.Thread.CurrentPrincipal.Identity.Name;
					}
				}
				return userName;
            }
        }
        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public TblHislisRegCollection FetchAll()
        {
            TblHislisRegCollection coll = new TblHislisRegCollection();
            Query qry = new Query(TblHislisReg.Schema);
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public TblHislisRegCollection FetchByID(object Id)
        {
            TblHislisRegCollection coll = new TblHislisRegCollection().Where("ID", Id).Load();
            return coll;
        }
		
		[DataObjectMethod(DataObjectMethodType.Select, false)]
        public TblHislisRegCollection FetchByQuery(Query qry)
        {
            TblHislisRegCollection coll = new TblHislisRegCollection();
            coll.LoadAndCloseReader(qry.ExecuteReader()); 
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(object Id)
        {
            return (TblHislisReg.Delete(Id) == 1);
        }
        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public bool Destroy(object Id)
        {
            return (TblHislisReg.Destroy(Id) == 1);
        }
        
        
    	
	    /// <summary>
	    /// Inserts a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Insert, true)]
	    public void Insert(string SoPhieuChiDinh,string IDXetNghiemHis,string IDTriSoHis,string IDChiDinhChiTiet,string TenXetNghiemTriSo,string LaTriSo,string TriSoBinhThuong,string KetQua,string NhanXet,string Barcode)
	    {
		    TblHislisReg item = new TblHislisReg();
		    
            item.SoPhieuChiDinh = SoPhieuChiDinh;
            
            item.IDXetNghiemHis = IDXetNghiemHis;
            
            item.IDTriSoHis = IDTriSoHis;
            
            item.IDChiDinhChiTiet = IDChiDinhChiTiet;
            
            item.TenXetNghiemTriSo = TenXetNghiemTriSo;
            
            item.LaTriSo = LaTriSo;
            
            item.TriSoBinhThuong = TriSoBinhThuong;
            
            item.KetQua = KetQua;
            
            item.NhanXet = NhanXet;
            
            item.Barcode = Barcode;
            
	    
		    item.Save(UserName);
	    }
    	
	    /// <summary>
	    /// Updates a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Update, true)]
	    public void Update(int Id,string SoPhieuChiDinh,string IDXetNghiemHis,string IDTriSoHis,string IDChiDinhChiTiet,string TenXetNghiemTriSo,string LaTriSo,string TriSoBinhThuong,string KetQua,string NhanXet,string Barcode)
	    {
		    TblHislisReg item = new TblHislisReg();
	        item.MarkOld();
	        item.IsLoaded = true;
		    
			item.Id = Id;
				
			item.SoPhieuChiDinh = SoPhieuChiDinh;
				
			item.IDXetNghiemHis = IDXetNghiemHis;
				
			item.IDTriSoHis = IDTriSoHis;
				
			item.IDChiDinhChiTiet = IDChiDinhChiTiet;
				
			item.TenXetNghiemTriSo = TenXetNghiemTriSo;
				
			item.LaTriSo = LaTriSo;
				
			item.TriSoBinhThuong = TriSoBinhThuong;
				
			item.KetQua = KetQua;
				
			item.NhanXet = NhanXet;
				
			item.Barcode = Barcode;
				
	        item.Save(UserName);
	    }
    }
}
