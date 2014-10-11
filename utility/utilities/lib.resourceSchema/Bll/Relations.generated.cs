namespace resourceSchema.Bll {
    
    
    public partial class Relations {
        
        private System.Nullable<int> _id;
        
        private string _parent;
        
        private string _child;
        
        private System.Nullable<bool> _active;
        
        public virtual System.Nullable<int> Id {
            get {
                return _id;
            }
            set {
                _id = value;
            }
        }
        
        public virtual string Parent {
            get {
                return _parent;
            }
            set {
                _parent = value;
            }
        }
        
        public virtual string Child {
            get {
                return _child;
            }
            set {
                _child = value;
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
            this.Parent = string.Empty;
            this.Child = string.Empty;
            this.Active = null;
        }
        
        private void Fill(System.Data.DataRow dr) {
            this.Clean();
            if ((dr["Id"] != System.DBNull.Value)) {
                this.Id = ((System.Nullable<int>)(dr["Id"]));
            }
            if ((dr["Parent"] != System.DBNull.Value)) {
                this.Parent = ((string)(dr["Parent"]));
            }
            if ((dr["Child"] != System.DBNull.Value)) {
                this.Child = ((string)(dr["Child"]));
            }
            if ((dr["Active"] != System.DBNull.Value)) {
                this.Active = ((System.Nullable<bool>)(dr["Active"]));
            }
        }
        
        public static RelationsCollection GetAll() {
            resourceSchema.Dal.Relations dbo = null;
            try {
                dbo = new resourceSchema.Dal.Relations();
                System.Data.DataSet ds = dbo.Relations_Select_All();
                RelationsCollection collection = new RelationsCollection();
                if (GlobalTools.IsSafeDataSet(ds)) {
                    for (int i = 0; (i < ds.Tables[0].Rows.Count); i = (i + 1)) {
                        Relations obj = new Relations();
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
        
        public static Relations Load(System.Nullable<int> Id) {
            resourceSchema.Dal.Relations dbo = null;
            try {
                dbo = new resourceSchema.Dal.Relations();
                System.Data.DataSet ds = dbo.Relations_Select_One(Id);
                Relations obj = null;
                if (GlobalTools.IsSafeDataSet(ds)) {
                    if ((ds.Tables[0].Rows.Count > 0)) {
                        obj = new Relations();
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
            resourceSchema.Dal.Relations dbo = null;
            try {
                dbo = new resourceSchema.Dal.Relations();
                System.Data.DataSet ds = dbo.Relations_Select_One(this.Id);
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
            resourceSchema.Dal.Relations dbo = null;
            try {
                dbo = new resourceSchema.Dal.Relations();
                dbo.Relations_Insert(this.Parent, this.Child, this.Active);
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
            resourceSchema.Dal.Relations dbo = null;
            try {
                dbo = new resourceSchema.Dal.Relations();
                dbo.Relations_Delete(this.Id);
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
            resourceSchema.Dal.Relations dbo = null;
            try {
                dbo = new resourceSchema.Dal.Relations();
                dbo.Relations_Update(this.Id, this.Parent, this.Child, this.Active);
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
