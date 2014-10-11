namespace resourceSchema.Bll {
    
    
    public partial class Iterationtags {
        
        private System.Nullable<int> _sysid;
        
        private System.Nullable<int> _iterationsysid;
        
        private string _tag;
        
        private System.Nullable<System.DateTime> _createdate;
        
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
        
        public virtual System.Nullable<int> Iterationsysid {
            get {
                return _iterationsysid;
            }
            set {
                _iterationsysid = value;
            }
        }
        
        public virtual string Tag {
            get {
                return _tag;
            }
            set {
                _tag = value;
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
                    this._iterations = resourceSchema.Bll.Iterations.Load(this._sysid);
                }
                return this._iterations;
            }
            set {
                _iterations = value;
            }
        }
        
        private void Clean() {
            this.Sysid = null;
            this.Iterationsysid = null;
            this.Tag = string.Empty;
            this.Createdate = null;
            this.Active = null;
            this.Iterations = null;
        }
        
        private void Fill(System.Data.DataRow dr) {
            this.Clean();
            if ((dr["SysId"] != System.DBNull.Value)) {
                this.Sysid = ((System.Nullable<int>)(dr["SysId"]));
            }
            if ((dr["IterationSysId"] != System.DBNull.Value)) {
                this.Iterationsysid = ((System.Nullable<int>)(dr["IterationSysId"]));
            }
            if ((dr["Tag"] != System.DBNull.Value)) {
                this.Tag = ((string)(dr["Tag"]));
            }
            if ((dr["CreateDate"] != System.DBNull.Value)) {
                this.Createdate = ((System.Nullable<System.DateTime>)(dr["CreateDate"]));
            }
            if ((dr["Active"] != System.DBNull.Value)) {
                this.Active = ((System.Nullable<bool>)(dr["Active"]));
            }
        }
        
        public static IterationtagsCollection Select_IterationTagss_By_SysId(System.Nullable<int> SysId) {
            resourceSchema.Dal.Iterationtags dbo = null;
            try {
                dbo = new resourceSchema.Dal.Iterationtags();
                System.Data.DataSet ds = dbo.Select_IterationTagss_By_SysId(SysId);
                IterationtagsCollection collection = new IterationtagsCollection();
                if (GlobalTools.IsSafeDataSet(ds)) {
                    for (int i = 0; (i < ds.Tables[0].Rows.Count); i = (i + 1)) {
                        Iterationtags obj = new Iterationtags();
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
        
        public static IterationtagsCollection GetAll() {
            resourceSchema.Dal.Iterationtags dbo = null;
            try {
                dbo = new resourceSchema.Dal.Iterationtags();
                System.Data.DataSet ds = dbo.IterationTags_Select_All();
                IterationtagsCollection collection = new IterationtagsCollection();
                if (GlobalTools.IsSafeDataSet(ds)) {
                    for (int i = 0; (i < ds.Tables[0].Rows.Count); i = (i + 1)) {
                        Iterationtags obj = new Iterationtags();
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
        
        public static Iterationtags Load(System.Nullable<int> SysId) {
            resourceSchema.Dal.Iterationtags dbo = null;
            try {
                dbo = new resourceSchema.Dal.Iterationtags();
                System.Data.DataSet ds = dbo.IterationTags_Select_One(SysId);
                Iterationtags obj = null;
                if (GlobalTools.IsSafeDataSet(ds)) {
                    if ((ds.Tables[0].Rows.Count > 0)) {
                        obj = new Iterationtags();
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
            resourceSchema.Dal.Iterationtags dbo = null;
            try {
                dbo = new resourceSchema.Dal.Iterationtags();
                System.Data.DataSet ds = dbo.IterationTags_Select_One(this.Sysid);
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
            resourceSchema.Dal.Iterationtags dbo = null;
            try {
                dbo = new resourceSchema.Dal.Iterationtags();
                dbo.IterationTags_Insert(this.Iterationsysid, this.Tag, this.Createdate, this.Active);
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
            resourceSchema.Dal.Iterationtags dbo = null;
            try {
                dbo = new resourceSchema.Dal.Iterationtags();
                dbo.IterationTags_Delete(this.Sysid);
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
            resourceSchema.Dal.Iterationtags dbo = null;
            try {
                dbo = new resourceSchema.Dal.Iterationtags();
                dbo.IterationTags_Update(this.Sysid, this.Iterationsysid, this.Tag, this.Createdate, this.Active);
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
