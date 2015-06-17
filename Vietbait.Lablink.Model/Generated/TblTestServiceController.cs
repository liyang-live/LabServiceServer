using System;
using System.ComponentModel;
using System.Threading;
using System.Web;
using SubSonic;

// <auto-generated />

namespace Vietbait.Lablink.Model
{
    /// <summary>
    ///     Controller class for tbl_TestService
    /// </summary>
    [DataObject]
    public class TblTestServiceController
    {
        // Preload our schema..
        private TblTestService thisSchemaLoad = new TblTestService();
        private string userName = String.Empty;

        protected string UserName
        {
            get
            {
                if (userName.Length == 0)
                {
                    if (HttpContext.Current != null)
                    {
                        userName = HttpContext.Current.User.Identity.Name;
                    }
                    else
                    {
                        userName = Thread.CurrentPrincipal.Identity.Name;
                    }
                }
                return userName;
            }
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public TblTestServiceCollection FetchAll()
        {
            var coll = new TblTestServiceCollection();
            var qry = new Query(TblTestService.Schema);
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }

        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public TblTestServiceCollection FetchByID(object Id)
        {
            TblTestServiceCollection coll = new TblTestServiceCollection().Where("ID", Id).Load();
            return coll;
        }

        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public TblTestServiceCollection FetchByQuery(Query qry)
        {
            var coll = new TblTestServiceCollection();
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }

        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(object Id)
        {
            return (TblTestService.Delete(Id) == 1);
        }

        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public bool Destroy(object Id)
        {
            return (TblTestService.Destroy(Id) == 1);
        }


        /// <summary>
        ///     Inserts a record, can be used with the Object Data Source
        /// </summary>
        [DataObjectMethod(DataObjectMethodType.Insert, true)]
        public void Insert(int Id, string SName, int? ParentID, decimal? FPrice, string SDesc)
        {
            var item = new TblTestService();

            item.Id = Id;

            item.SName = SName;

            item.ParentID = ParentID;

            item.FPrice = FPrice;

            item.SDesc = SDesc;


            item.Save(UserName);
        }

        /// <summary>
        ///     Updates a record, can be used with the Object Data Source
        /// </summary>
        [DataObjectMethod(DataObjectMethodType.Update, true)]
        public void Update(int Id, string SName, int? ParentID, decimal? FPrice, string SDesc)
        {
            var item = new TblTestService();
            item.MarkOld();
            item.IsLoaded = true;

            item.Id = Id;

            item.SName = SName;

            item.ParentID = ParentID;

            item.FPrice = FPrice;

            item.SDesc = SDesc;

            item.Save(UserName);
        }
    }
}