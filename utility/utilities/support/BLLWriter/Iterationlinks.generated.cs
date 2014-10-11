namespace resourceSchema.Bll {
    
    
    public partial class Iterationlinks {
        
        private System.Nullable<int> _sysid;
        
        private System.Nullable<System.Guid> _publicid;
        
        private System.Nullable<int> _parentiterationsysid;
        
        private System.Nullable<int> _childiterationsysid;
        
        private string _linkpath;
        
        private System.Nullable<System.DateTime> _createdate;
        
        private System.Nullable<System.DateTime> _lastmodifieddate;
        
        private System.Nullable<bool> _active;
        
        private Iterations _iterations;
        
        private Iterations _iterations2;
        
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
        
        public virtual string Linkpath {
            get {
                return _linkpath;
            }
            set {
                _linkpath = value;
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
                    this._iterations = resourceSchema.Bll.Iterations.Load(this._parentiterationsysid);
                }
                return this._iterations;
            }
            set {
                _iterations = value;
            }
        }
        
        public virtual Iterations Iterations2 {
            get {
                if ((this._iterations2 == null)) {
                    this._iterations2 = resourceSchema.Bll.Iterations.Load(this._childiterationsysid);
                }
                return this._iterations2;
            }
            set {
                _iterations2 = value;
            }
        }
        
        private void Clean() {
            this.Sysid = null;
            this.Publicid = null;
            this._parentiterationsysid = null;
            this._childiterationsysid = null;
            this.Linkpath = string.Empty;
            this.Createdate = null;
            this.Lastmodifieddate = null;
            this.Active = null;
            this.Iterations = null;
            this.Iterations2 = null;
        }
        
        private void Fill(System.Data.DataRow dr) {
            this.Clean();
            if ((dr["SysId"] != System.DBNull.Value)) {
                this.Sysid = ((System.Nullable<int>)(dr["SysId"]));
            }
            if ((dr["PublicId"] != System.DBNull.Value)) {
                this.Publicid = ((System.Nullable<System.Guid>)(dr["PublicId"]));
            }
            if ((dr["ParentIterationSysId"] != System.DBNull.Value)) {
                this._parentiterationsysid = ((System.Nullable<int>)(dr["ParentIterationSysId"]));
            }
            if ((dr["ChildIterationSysId"] != System.DBNull.Value)) {
                this._childiterationsysid = ((System.Nullable<int>)(dr["ChildIterationSysId"]));
            }
            if ((dr["LinkPath"] != System.DBNull.Value)) {
                this.Linkpath = ((string)(dr["LinkPath"]));
            }
            if ((dr["CreateDate"] != System.DBNull.Value)) {
                this.Createdate = ((System.Nullable<System.DateTime>)(dr["CreateDate"]));
            }
            if ((dr["LastModifiedDate"] != System.DBNull.Value)) {
                this.Lastmodifieddate = ((System.Nullable<System.DateTime>)(dr["LastModifiedDate"]));
            }
            if ((dr["Active"] != System.DBNull.Value)) {
                this.Active = ((System.Nullable<bool>)(dr["Active"]));
            }
        }
        
        public static IterationlinksCollection Select_IterationLinkss_By_ParentIterationSysId(System.Nullable<int> ParentIterationSysId) {
            resourceSchema.Dal.Iterationlinks dbo = null;
            try {
                dbo = new resourceSchema.Dal.Iterationlinks();
                System.Data.DataSet ds = dbo.Select_IterationLinkss_By_ParentIterationSysId(ParentIterationSysId);
                IterationlinksCollection collection = new IterationlinksCollection();
                if (GlobalTools.IsSafeDataSet(ds)) {
                    for (int i = 0; (i < ds.Tables[0].Rows.Count); i = (i + 1)) {
                        Iterationlinks obj = new Iterationlinks();
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
        
        public static IterationlinksCollection Select_IterationLinkss_By_ChildIterationSysId(System.Nullable<int> ChildIterationSysId) {
            resourceSchema.Dal.Iterationlinks dbo = null;
            try {
                dbo = new resourceSchema.Dal.Iterationlinks();
                System.Data.DataSet ds = dbo.Select_IterationLinkss_By_ChildIterationSysId(ChildIterationSysId);
                IterationlinksCollection collection = new IterationlinksCollection();
                if (GlobalTools.IsSafeDataSet(ds)) {
                    for (int i = 0; (i < ds.Tables[0].Rows.Count); i = (i + 1)) {
                        Iterationlinks obj = new Iterationlinks();
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
        
        public static IterationlinksCollection GetAll() {
            resourceSchema.Dal.Iterationlinks dbo = null;
            try {
                dbo = new resourceSchema.Dal.Iterationlinks();
                System.Data.DataSet ds = dbo.IterationLinks_Select_All();
                IterationlinksCollection collection = new IterationlinksCollection();
                if (GlobalTools.IsSafeDataSet(ds)) {
                    for (int i = 0; (i < ds.Tables[0].Rows.Count); i = (i + 1)) {
                        Iterationlinks obj = new Iterationlinks();
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
        
        public static Iterationlinks Load(System.Nullable<int> SysId) {
            resourceSchema.Dal.Iterationlinks dbo = null;
            try {
                dbo = new resourceSchema.Dal.Iterationlinks();
                System.Data.DataSet ds = dbo.IterationLinks_Select_One(SysId);
                Iterationlinks obj = null;
                if (GlobalTools.IsSafeDataSet(ds)) {
                    if ((ds.Tables[0].Rows.Count > 0)) {
                        obj = new Iterationlinks();
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
            resourceSchema.Dal.Iterationlinks dbo = null;
            try {
                dbo = new resourceSchema.Dal.Iterationlinks();
                System.Data.DataSet ds = dbo.IterationLinks_Select_One(this.Sysid);
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
            resourceSchema.Dal.Iterationlinks dbo = null;
            try {
                dbo = new resourceSchema.Dal.Iterationlinks();
                dbo.IterationLinks_Insert(this.Publicid, this._parentiterationsysid, this._childiterationsysid, this.Linkpath, this.Createdate, this.Lastmodifieddate, this.Active);
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
            resourceSchema.Dal.Iterationlinks dbo = null;
            try {
                dbo = new resourceSchema.Dal.Iterationlinks();
                dbo.IterationLinks_Delete(this.Sysid);
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
            resourceSchema.Dal.Iterationlinks dbo = null;
            try {
                dbo = new resourceSchema.Dal.Iterationlinks();
                dbo.IterationLinks_Update(this.Sysid, this.Publicid, this._parentiterationsysid, this._childiterationsysid, this.Linkpath, this.Createdate, this.Lastmodifieddate, this.Active);
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
