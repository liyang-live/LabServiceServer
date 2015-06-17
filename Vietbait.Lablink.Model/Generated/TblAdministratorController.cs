using System;
using System.ComponentModel;
using System.Threading;
using System.Web;
using SubSonic;

// <auto-generated />

namespace Vietbait.Lablink.Model
{
    /// <summary>
    ///     Controller class for tbl_Administrator
    /// </summary>
    [DataObject]
    public class TblAdministratorController
    {
        // Preload our schema..
        private TblAdministrator thisSchemaLoad = new TblAdministrator();
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
        public TblAdministratorCollection FetchAll()
        {
            var coll = new TblAdministratorCollection();
            var qry = new Query(TblAdministrator.Schema);
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }

        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public TblAdministratorCollection FetchByID(object PkSAdminID)
        {
            TblAdministratorCollection coll = new TblAdministratorCollection().Where("PK_sAdminID", PkSAdminID).Load();
            return coll;
        }

        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public TblAdministratorCollection FetchByQuery(Query qry)
        {
            var coll = new TblAdministratorCollection();
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }

        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(object PkSAdminID)
        {
            return (TblAdministrator.Delete(PkSAdminID) == 1);
        }

        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public bool Destroy(object PkSAdminID)
        {
            return (TblAdministrator.Destroy(PkSAdminID) == 1);
        }


        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(string PkSAdminID, string FpSBranchID)
        {
            var qry = new Query(TblAdministrator.Schema);
            qry.QueryType = QueryType.Delete;
            qry.AddWhere("PkSAdminID", PkSAdminID).AND("FpSBranchID", FpSBranchID);
            qry.Execute();
            return (true);
        }


        /// <summary>
        ///     Inserts a record, can be used with the Object Data Source
        /// </summary>
        [DataObjectMethod(DataObjectMethodType.Insert, true)]
        public void Insert(string PkSAdminID, string FpSBranchID, string PkSCreator, string SPWD, int? IMonth,
            int? IYear)
        {
            var item = new TblAdministrator();

            item.PkSAdminID = PkSAdminID;

            item.FpSBranchID = FpSBranchID;

            item.PkSCreator = PkSCreator;

            item.SPWD = SPWD;

            item.IMonth = IMonth;

            item.IYear = IYear;


            item.Save(UserName);
        }

        /// <summary>
        ///     Updates a record, can be used with the Object Data Source
        /// </summary>
        [DataObjectMethod(DataObjectMethodType.Update, true)]
        public void Update(string PkSAdminID, string FpSBranchID, string PkSCreator, string SPWD, int? IMonth,
            int? IYear)
        {
            var item = new TblAdministrator();
            item.MarkOld();
            item.IsLoaded = true;

            item.PkSAdminID = PkSAdminID;

            item.FpSBranchID = FpSBranchID;

            item.PkSCreator = PkSCreator;

            item.SPWD = SPWD;

            item.IMonth = IMonth;

            item.IYear = IYear;

            item.Save(UserName);
        }
    }
}