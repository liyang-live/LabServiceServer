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
    /// Controller class for KETNOI_HIS_DANHMUC_DVU
    /// </summary>
    [System.ComponentModel.DataObject]
    public partial class KetnoiHisDanhmucDvuController
    {
        // Preload our schema..
        KetnoiHisDanhmucDvu thisSchemaLoad = new KetnoiHisDanhmucDvu();
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
        public KetnoiHisDanhmucDvuCollection FetchAll()
        {
            KetnoiHisDanhmucDvuCollection coll = new KetnoiHisDanhmucDvuCollection();
            Query qry = new Query(KetnoiHisDanhmucDvu.Schema);
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public KetnoiHisDanhmucDvuCollection FetchByID(object Id)
        {
            KetnoiHisDanhmucDvuCollection coll = new KetnoiHisDanhmucDvuCollection().Where("ID", Id).Load();
            return coll;
        }
		
		[DataObjectMethod(DataObjectMethodType.Select, false)]
        public KetnoiHisDanhmucDvuCollection FetchByQuery(Query qry)
        {
            KetnoiHisDanhmucDvuCollection coll = new KetnoiHisDanhmucDvuCollection();
            coll.LoadAndCloseReader(qry.ExecuteReader()); 
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(object Id)
        {
            return (KetnoiHisDanhmucDvu.Delete(Id) == 1);
        }
        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public bool Destroy(object Id)
        {
            return (KetnoiHisDanhmucDvu.Destroy(Id) == 1);
        }
        
        
    	
	    /// <summary>
	    /// Inserts a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Insert, true)]
	    public void Insert(string MaDvu,string TenDvu,string MaNhom,string TenNhom,string KieuDvu)
	    {
		    KetnoiHisDanhmucDvu item = new KetnoiHisDanhmucDvu();
		    
            item.MaDvu = MaDvu;
            
            item.TenDvu = TenDvu;
            
            item.MaNhom = MaNhom;
            
            item.TenNhom = TenNhom;
            
            item.KieuDvu = KieuDvu;
            
	    
		    item.Save(UserName);
	    }
    	
	    /// <summary>
	    /// Updates a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Update, true)]
	    public void Update(int Id,string MaDvu,string TenDvu,string MaNhom,string TenNhom,string KieuDvu)
	    {
		    KetnoiHisDanhmucDvu item = new KetnoiHisDanhmucDvu();
	        item.MarkOld();
	        item.IsLoaded = true;
		    
			item.Id = Id;
				
			item.MaDvu = MaDvu;
				
			item.TenDvu = TenDvu;
				
			item.MaNhom = MaNhom;
				
			item.TenNhom = TenNhom;
				
			item.KieuDvu = KieuDvu;
				
	        item.Save(UserName);
	    }
    }
}
