namespace resourceSchema.Bll {
    
    
    public partial class Iterationattributes {
        
        private System.Nullable<int> _sysid;
        
        private System.Nullable<int> _iterationsysid;
        
        private System.Nullable<System.DateTime> _createdate;
        
        private System.Nullable<System.DateTime> _lastmodifieddate;
        
        private string _description;
        
        private string _iterationnumber;
        
        private Iterations _iterations;
        
        public virtual System.Nullable<int> Sysid {
            get {
                return _sysid;
            }
            set {
                _sysid = value;
            }
        }
        
        public virtual System.Nullable<System.DateTime> Createdate {
            get {
                return _createdate;
            }
            set {
                _createdate = value;
            }
        }
        
        public virtual System.Nullable<System.DateTime> Lastmodifieddate {
            get {
                return _lastmodifieddate;
            }
            set {
                _lastmodifieddate = value;
            }
        }
        
        public virtual string Description {
            get {
                return _description;
            }
            set {
                _description = value;
            }
        }
        
        public virtual string Iterationnumber {
            get {
                return _iterationnumber;
            }
            set {
                _iterationnumber = value;
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
            this._iterationsysid = null;
            this.Createdate = null;
            this.Lastmodifieddate = null;
            this.Description = string.Empty;
            this.Iterationnumber = string.Empty;
            this.Iterations = null;
        }
        
        private void Fill(System.Data.DataRow dr) {
            this.Clean();
            if ((dr["SysId"] != System.DBNull.Value)) {
                this.Sysid = ((System.Nullable<int>)(dr["SysId"]));
            }
            if ((dr["IterationSysId"] != System.DBNull.Value)) {
                this._iterationsysid = ((System.Nullable<int>)(dr["IterationSysId"]));
            }
            if ((dr["CreateDate"] != System.DBNull.Value)) {
                this.Createdate = ((System.Nullable<System.DateTime>)(dr["CreateDate"]));
            }
            if ((dr["LastModifiedDate"] != System.DBNull.Value)) {
                this.Lastmodifieddate = ((System.Nullable<System.DateTime>)(dr["LastModifiedDate"]));
            }
            if ((dr["Description"] != System.DBNull.Value)) {
                this.Description = ((string)(dr["Description"]));
            }
            if ((dr["IterationNumber"] != System.DBNull.Value)) {
                this.Iterationnumber = ((string)(dr["IterationNumber"]));
            }
        }
        
        public static IterationattributesCollection Select_IterationAttributess_By_IterationSysId(System.Nullable<int> IterationSysId) {
            resourceSchema.Dal.Iterationattributes dbo = null;
            try {
                dbo = new resourceSchema.Dal.Iterationattributes();
                System.Data.DataSet ds = dbo.Select_IterationAttributess_By_IterationSysId(IterationSysId);
                IterationattributesCollection collection = new IterationattributesCollection();
                if (GlobalTools.IsSafeDataSet(ds)) {
                    for (int i = 0; (i < ds.Tables[0].Rows.Count); i = (i + 1)) {
                        Iterationattributes obj = new Iterationattributes();
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
        
        public static IterationattributesCollection GetAll() {
            resourceSchema.Dal.Iterationattributes dbo = null;
            try {
                dbo = new resourceSchema.Dal.Iterationattributes();
                System.Data.DataSet ds = dbo.IterationAttributes_Select_All();
                IterationattributesCollection collection = new IterationattributesCollection();
                if (GlobalTools.IsSafeDataSet(ds)) {
                    for (int i = 0; (i < ds.Tables[0].Rows.Count); i = (i + 1)) {
                        Iterationattributes obj = new Iterationattributes();
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
        
        public static Iterationattributes Load(System.Nullable<int> SysId) {
            resourceSchema.Dal.Iterationattributes dbo = null;
            try {
                dbo = new resourceSchema.Dal.Iterationattributes();
                System.Data.DataSet ds = dbo.IterationAttributes_Select_One(SysId);
                Iterationattributes obj = null;
                if (GlobalTools.IsSafeDataSet(ds)) {
                    if ((ds.Tables[0].Rows.Count > 0)) {
                        obj = new Iterationattributes();
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
            resourceSchema.Dal.Iterationattributes dbo = null;
            try {
                dbo = new resourceSchema.Dal.Iterationattributes();
                System.Data.DataSet ds = dbo.IterationAttributes_Select_One(this.Sysid);
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
            resourceSchema.Dal.Iterationattributes dbo = null;
            try {
                dbo = new resourceSchema.Dal.Iterationattributes();
                dbo.IterationAttributes_Insert(this._iterationsysid, this.Createdate, this.Lastmodifieddate, this.Description, this.Iterationnumber);
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
            resourceSchema.Dal.Iterationattributes dbo = null;
            try {
                dbo = new resourceSchema.Dal.Iterationattributes();
                dbo.IterationAttributes_Delete(this.Sysid);
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
            resourceSchema.Dal.Iterationattributes dbo = null;
            try {
                dbo = new resourceSchema.Dal.Iterationattributes();
                dbo.IterationAttributes_Update(this.Sysid, this._iterationsysid, this.Createdate, this.Lastmodifieddate, this.Description, this.Iterationnumber);
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
