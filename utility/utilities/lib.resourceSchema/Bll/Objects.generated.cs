namespace resourceSchema.Bll {
    
    
    public partial class Objects {
        
        private System.Nullable<int> _id;
        
        private string _title;
        
        private string _path;
        
        private System.Nullable<bool> _active;
        
        public virtual System.Nullable<int> Id {
            get {
                return _id;
            }
            set {
                _id = value;
            }
        }
        
        public virtual string Title {
            get {
                return _title;
            }
            set {
                _title = value;
            }
        }
        
        public virtual string Path {
            get {
                return _path;
            }
            set {
                _path = value;
            }
        }
        
        public virtual System.Nullable<bool> Active {
            get {
                return _active;
            }
            set {
                _active = value;
            }
        }
        
        private void Clean() {
            this.Id = null;
            this.Title = string.Empty;
            this.Path = string.Empty;
            this.Active = null;
        }
        
        private void Fill(System.Data.DataRow dr) {
            this.Clean();
            if ((dr["Id"] != System.DBNull.Value)) {
                this.Id = ((System.Nullable<int>)(dr["Id"]));
            }
            if ((dr["Title"] != System.DBNull.Value)) {
                this.Title = ((string)(dr["Title"]));
            }
            if ((dr["Path"] != System.DBNull.Value)) {
                this.Path = ((string)(dr["Path"]));
            }
            if ((dr["Active"] != System.DBNull.Value)) {
                this.Active = ((System.Nullable<bool>)(dr["Active"]));
            }
        }
        
        public static ObjectsCollection GetAll() {
            resourceSchema.Dal.Objects dbo = null;
            try {
                dbo = new resourceSchema.Dal.Objects();
                System.Data.DataSet ds = dbo.Objects_Select_All();
                ObjectsCollection collection = new ObjectsCollection();
                if (GlobalTools.IsSafeDataSet(ds)) {
                    for (int i = 0; (i < ds.Tables[0].Rows.Count); i = (i + 1)) {
                        Objects obj = new Objects();
                        obj.Fill(ds.Tables[0].Rows[i]);
                        if ((obj != null)) {
                            collection.Add(obj);
                        }
                    }
                }
                return collection;
            }
            catch (System.Exception ) {
                throw;
            }
            finally {
                if ((dbo != null)) {
                    dbo.Dispose();
                }
            }
        }
        
        public static Objects Load(System.Nullable<int> Id) {
            resourceSchema.Dal.Objects dbo = null;
            try {
                dbo = new resourceSchema.Dal.Objects();
                System.Data.DataSet ds = dbo.Objects_Select_One(Id);
                Objects obj = null;
                if (GlobalTools.IsSafeDataSet(ds)) {
                    if ((ds.Tables[0].Rows.Count > 0)) {
                        obj = new Objects();
                        obj.Fill(ds.Tables[0].Rows[0]);
                    }
                }
                return obj;
            }
            catch (System.Exception ) {
                throw;
            }
            finally {
                if ((dbo != null)) {
                    dbo.Dispose();
                }
            }
        }
        
        public virtual void Load() {
            resourceSchema.Dal.Objects dbo = null;
            try {
                dbo = new resourceSchema.Dal.Objects();
                System.Data.DataSet ds = dbo.Objects_Select_One(this.Id);
                if (GlobalTools.IsSafeDataSet(ds)) {
                    if ((ds.Tables[0].Rows.Count > 0)) {
                        this.Fill(ds.Tables[0].Rows[0]);
                    }
                }
            }
            catch (System.Exception ) {
                throw;
            }
            finally {
                if ((dbo != null)) {
                    dbo.Dispose();
                }
            }
        }
        
        public virtual void Insert() {
            resourceSchema.Dal.Objects dbo = null;
            try {
                dbo = new resourceSchema.Dal.Objects();
                dbo.Objects_Insert(this.Title, this.Path, this.Active);
            }
            catch (System.Exception ) {
                throw;
            }
            finally {
                if ((dbo != null)) {
                    dbo.Dispose();
                }
            }
        }
        
        public virtual void Delete() {
            resourceSchema.Dal.Objects dbo = null;
            try {
                dbo = new resourceSchema.Dal.Objects();
                dbo.Objects_Delete(this.Id);
            }
            catch (System.Exception ) {
                throw;
            }
            finally {
                if ((dbo != null)) {
                    dbo.Dispose();
                }
            }
        }
        
        public virtual void Update() {
            resourceSchema.Dal.Objects dbo = null;
            try {
                dbo = new resourceSchema.Dal.Objects();
                dbo.Objects_Update(this.Id, this.Title, this.Path, this.Active);
            }
            catch (System.Exception ) {
                throw;
            }
            finally {
                if ((dbo != null)) {
                    dbo.Dispose();
                }
            }
        }
    }
}
