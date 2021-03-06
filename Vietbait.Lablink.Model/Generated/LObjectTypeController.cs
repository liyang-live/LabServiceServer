using System;
using System.ComponentModel;
using System.Threading;
using System.Web;
using SubSonic;

// <auto-generated />

namespace Vietbait.Lablink.Model
{
    /// <summary>
    ///     Controller class for L_ObjectType
    /// </summary>
    [DataObject]
    public class LObjectTypeController
    {
        // Preload our schema..
        private LObjectType thisSchemaLoad = new LObjectType();
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
        public LObjectTypeCollection FetchAll()
        {
            var coll = new LObjectTypeCollection();
            var qry = new Query(LObjectType.Schema);
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }

        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public LObjectTypeCollection FetchByID(object Id)
        {
            LObjectTypeCollection coll = new LObjectTypeCollection().Where("ID", Id).Load();
            return coll;
        }

        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public LObjectTypeCollection FetchByQuery(Query qry)
        {
            var coll = new LObjectTypeCollection();
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }

        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(object Id)
        {
            return (LObjectType.Delete(Id) == 1);
        }

        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public bool Destroy(object Id)
        {
            return (LObjectType.Destroy(Id) == 1);
        }


        /// <summary>
        ///     Inserts a record, can be used with the Object Data Source
        /// </summary>
        [DataObjectMethod(DataObjectMethodType.Insert, true)]
        public void Insert(string SName, string SDesc)
        {
            var item = new LObjectType();

            item.SName = SName;

            item.SDesc = SDesc;


            item.Save(UserName);
        }

        /// <summary>
        ///     Updates a record, can be used with the Object Data Source
        /// </summary>
        [DataObjectMethod(DataObjectMethodType.Update, true)]
        public void Update(short Id, string SName, string SDesc)
        {
            var item = new LObjectType();
            item.MarkOld();
            item.IsLoaded = true;

            item.Id = Id;

            item.SName = SName;

            item.SDesc = SDesc;

            item.Save(UserName);
        }
    }
}