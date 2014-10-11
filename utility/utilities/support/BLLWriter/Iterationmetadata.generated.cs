namespace resourceSchema.Bll {
    
    
    public partial class Iterationmetadata {
        
        private System.Nullable<int> _sysid;
        
        private System.Nullable<System.Guid> _publicid;
        
        private System.Nullable<int> _iterationsysid;
        
        private string _keypath;
        
        private string _keyvalue;
        
        private System.Nullable<bool> _active;
        
        private Iterations _iterations;
        
        public virtual System.Nullable<int> Sysid {
            get {
                return _sysid;
            }
            set {
                _sysid = value;
            }
        }
        
        public virtual System.Nullable<System.Guid> Publicid {
            get {
                return _publicid;
            }
            set {
                _publicid = value;
            }
        }
        
        public virtual string Keypath {
            get {
                return _keypath;
            }
            set {
                _keypath = value;
            }
        }
        
        public virtual string Keyvalue {
            get {
                return _keyvalue;
            }
            set {
                _keyvalue = value;
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
        
        public virtual Iterations Iterations {
            get {
                if ((this._iterations == null)) {
                    this._iterations = resourceSchema.Bll.Iterations.Load(this._iterationsysid);
                }
                return this._iterations;
            }
            set {
                _iterations = value;
            }
        }
        
        private void Clean() {
            this.Sysid = null;
            this.Publicid = null;
            this._iterationsysid = null;
            this.Keypath = string.Empty;
            this.Keyvalue = string.Empty;
            this.Active = null;
            this.Iterations = null;
        }
        
        private void Fill(System.Data.DataRow dr) {
            this.Clean();
            if ((dr["SysId"] != System.DBNull.Value)) {
                this.Sysid = ((System.Nullable<int>)(dr["SysId"]));
            }
            if ((dr["PublicId"] != System.DBNull.Value)) {
                this.Publicid = ((System.Nullable<System.Guid>)(dr["PublicId"]));
            }
            if ((dr["IterationSysId"] != System.DBNull.Value)) {
                this._iterationsysid = ((System.Nullable<int>)(dr["IterationSysId"]));
            }
            if ((dr["KeyPath"] != System.DBNull.Value)) {
                this.Keypath = ((string)(dr["KeyPath"]));
            }
            if ((dr["KeyValue"] != System.DBNull.Value)) {
                this.Keyvalue = ((string)(dr["KeyValue"]));
            }
            if ((dr["Active"] != System.DBNull.Value)) {
                this.Active = ((System.Nullable<bool>)(dr["Active"]));
            }
        }
        
        public static IterationmetadataCollection Select_IterationMetaDatas_By_IterationSysId(System.Nullable<int> IterationSysId) {
            resourceSchema.Dal.Iterationmetadata dbo = null;
            try {
                dbo = new resourceSchema.Dal.Iterationmetadata();
                System.Data.DataSet ds = dbo.Select_IterationMetaDatas_By_IterationSysId(IterationSysId);
                IterationmetadataCollection collection = new IterationmetadataCollection();
                if (GlobalTools.IsSafeDataSet(ds)) {
                    for (int i = 0; (i < ds.Tables[0].Rows.Count); i = (i + 1)) {
                        Iterationmetadata obj = new Iterationmetadata();
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
        
        public static IterationmetadataCollection GetAll() {
            resourceSchema.Dal.Iterationmetadata dbo = null;
            try {
                dbo = new resourceSchema.Dal.Iterationmetadata();
                System.Data.DataSet ds = dbo.IterationMetaData_Select_All();
                IterationmetadataCollection collection = new IterationmetadataCollection();
                if (GlobalTools.IsSafeDataSet(ds)) {
                    for (int i = 0; (i < ds.Tables[0].Rows.Count); i = (i + 1)) {
                        Iterationmetadata obj = new Iterationmetadata();
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
        
        public static Iterationmetadata Load(System.Nullable<int> SysId) {
            resourceSchema.Dal.Iterationmetadata dbo = null;
            try {
                dbo = new resourceSchema.Dal.Iterationmetadata();
                System.Data.DataSet ds = dbo.IterationMetaData_Select_One(SysId);
                Iterationmetadata obj = null;
                if (GlobalTools.IsSafeDataSet(ds)) {
                    if ((ds.Tables[0].Rows.Count > 0)) {
                        obj = new Iterationmetadata();
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
            resourceSchema.Dal.Iterationmetadata dbo = null;
            try {
                dbo = new resourceSchema.Dal.Iterationmetadata();
                System.Data.DataSet ds = dbo.IterationMetaData_Select_One(this.Sysid);
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
            resourceSchema.Dal.Iterationmetadata dbo = null;
            try {
                dbo = new resourceSchema.Dal.Iterationmetadata();
                dbo.IterationMetaData_Insert(this.Publicid, this._iterationsysid, this.Keypath, this.Keyvalue, this.Active);
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
            resourceSchema.Dal.Iterationmetadata dbo = null;
            try {
                dbo = new resourceSchema.Dal.Iterationmetadata();
                dbo.IterationMetaData_Delete(this.Sysid);
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
            resourceSchema.Dal.Iterationmetadata dbo = null;
            try {
                dbo = new resourceSchema.Dal.Iterationmetadata();
                dbo.IterationMetaData_Update(this.Sysid, this.Publicid, this._iterationsysid, this.Keypath, this.Keyvalue, this.Active);
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
