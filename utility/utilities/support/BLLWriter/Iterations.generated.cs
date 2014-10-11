namespace resourceSchema.Bll {
    
    
    public partial class Iterations {
        
        private System.Nullable<int> _sysid;
        
        private System.Nullable<int> _iterationstatussysid;
        
        private System.Nullable<int> _iterationtypesysid;
        
        private System.Nullable<System.Guid> _publicid;
        
        private string _path;
        
        private System.Nullable<System.DateTime> _createdate;
        
        private System.Nullable<System.DateTime> _lastmodifieddate;
        
        private System.Nullable<bool> _isReadonly;
        
        private System.Nullable<bool> _active;
        
        private IterationattributesCollection _iterationattributesCollection;
        
        private IterationlinksCollection _iterationlinksCollection;
        
        private IterationlinksCollection _iterationlinksCollection2;
        
        private IterationmetadataCollection _iterationmetadataCollection;
        
        private Iterationstatus _iterationstatus;
        
        private Iterationtypes _iterationtypes;
        
        private IterationtagsCollection _iterationtagsCollection;
        
        private ProjectiterationsCollection _projectiterationsCollection;
        
        private TaskiterationsCollection _taskiterationsCollection;
        
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
        
        public virtual string Path {
            get {
                return _path;
            }
            set {
                _path = value;
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
        
        public virtual System.Nullable<bool> IsReadonly {
            get {
                return _isReadonly;
            }
            set {
                _isReadonly = value;
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
        
        public virtual IterationattributesCollection IterationattributesCollection {
            get {
                if ((this._iterationattributesCollection == null)) {
                    _iterationattributesCollection = resourceSchema.Bll.Iterationattributes.Select_IterationAttributess_By_IterationSysId(this.Sysid);
                }
                return this._iterationattributesCollection;
            }
        }
        
        public virtual IterationlinksCollection IterationlinksCollection {
            get {
                if ((this._iterationlinksCollection == null)) {
                    _iterationlinksCollection = resourceSchema.Bll.Iterationlinks.Select_IterationLinkss_By_ParentIterationSysId(this.Sysid);
                }
                return this._iterationlinksCollection;
            }
        }
        
        public virtual IterationlinksCollection IterationlinksCollection2 {
            get {
                if ((this._iterationlinksCollection2 == null)) {
                    _iterationlinksCollection2 = resourceSchema.Bll.Iterationlinks.Select_IterationLinkss_By_ChildIterationSysId(this.Sysid);
                }
                return this._iterationlinksCollection2;
            }
        }
        
        public virtual IterationmetadataCollection IterationmetadataCollection {
            get {
                if ((this._iterationmetadataCollection == null)) {
                    _iterationmetadataCollection = resourceSchema.Bll.Iterationmetadata.Select_IterationMetaDatas_By_IterationSysId(this.Sysid);
                }
                return this._iterationmetadataCollection;
            }
        }
        
        public virtual Iterationstatus Iterationstatus {
            get {
                if ((this._iterationstatus == null)) {
                    this._iterationstatus = resourceSchema.Bll.Iterationstatus.Load(this._iterationstatussysid);
                }
                return this._iterationstatus;
            }
            set {
                _iterationstatus = value;
            }
        }
        
        public virtual Iterationtypes Iterationtypes {
            get {
                if ((this._iterationtypes == null)) {
                    this._iterationtypes = resourceSchema.Bll.Iterationtypes.Load(this._iterationtypesysid);
                }
                return this._iterationtypes;
            }
            set {
                _iterationtypes = value;
            }
        }
        
        public virtual IterationtagsCollection IterationtagsCollection {
            get {
                if ((this._iterationtagsCollection == null)) {
                    _iterationtagsCollection = resourceSchema.Bll.Iterationtags.Select_IterationTagss_By_SysId(this.Sysid);
                }
                return this._iterationtagsCollection;
            }
        }
        
        public virtual ProjectiterationsCollection ProjectiterationsCollection {
            get {
                if ((this._projectiterationsCollection == null)) {
                    _projectiterationsCollection = resourceSchema.Bll.Projectiterations.Select_ProjectIterationss_By_IterationsysId(this.Sysid);
                }
                return this._projectiterationsCollection;
            }
        }
        
        public virtual TaskiterationsCollection TaskiterationsCollection {
            get {
                if ((this._taskiterationsCollection == null)) {
                    _taskiterationsCollection = resourceSchema.Bll.Taskiterations.Select_TaskIterationss_By_IterationsysId(this.Sysid);
                }
                return this._taskiterationsCollection;
            }
        }
        
        private void Clean() {
            this.Sysid = null;
            this._iterationstatussysid = null;
            this._iterationtypesysid = null;
            this.Publicid = null;
            this.Path = string.Empty;
            this.Createdate = null;
            this.Lastmodifieddate = null;
            this.IsReadonly = null;
            this.Active = null;
            this._iterationattributesCollection = null;
            this._iterationlinksCollection = null;
            this._iterationlinksCollection2 = null;
            this._iterationmetadataCollection = null;
            this.Iterationstatus = null;
            this.Iterationtypes = null;
            this._iterationtagsCollection = null;
            this._projectiterationsCollection = null;
            this._taskiterationsCollection = null;
        }
        
        private void Fill(System.Data.DataRow dr) {
            this.Clean();
            if ((dr["SysId"] != System.DBNull.Value)) {
                this.Sysid = ((System.Nullable<int>)(dr["SysId"]));
            }
            if ((dr["IterationStatusSysId"] != System.DBNull.Value)) {
                this._iterationstatussysid = ((System.Nullable<int>)(dr["IterationStatusSysId"]));
            }
            if ((dr["IterationTypeSysId"] != System.DBNull.Value)) {
                this._iterationtypesysid = ((System.Nullable<int>)(dr["IterationTypeSysId"]));
            }
            if ((dr["PublicId"] != System.DBNull.Value)) {
                this.Publicid = ((System.Nullable<System.Guid>)(dr["PublicId"]));
            }
            if ((dr["Path"] != System.DBNull.Value)) {
                this.Path = ((string)(dr["Path"]));
            }
            if ((dr["CreateDate"] != System.DBNull.Value)) {
                this.Createdate = ((System.Nullable<System.DateTime>)(dr["CreateDate"]));
            }
            if ((dr["LastModifiedDate"] != System.DBNull.Value)) {
                this.Lastmodifieddate = ((System.Nullable<System.DateTime>)(dr["LastModifiedDate"]));
            }
            if ((dr["Is_ReadOnly"] != System.DBNull.Value)) {
                this.IsReadonly = ((System.Nullable<bool>)(dr["Is_ReadOnly"]));
            }
            if ((dr["Active"] != System.DBNull.Value)) {
                this.Active = ((System.Nullable<bool>)(dr["Active"]));
            }
        }
        
        public static IterationsCollection Select_Iterationss_By_IterationStatusSysId(System.Nullable<int> IterationStatusSysId) {
            resourceSchema.Dal.Iterations dbo = null;
            try {
                dbo = new resourceSchema.Dal.Iterations();
                System.Data.DataSet ds = dbo.Select_Iterationss_By_IterationStatusSysId(IterationStatusSysId);
                IterationsCollection collection = new IterationsCollection();
                if (GlobalTools.IsSafeDataSet(ds)) {
                    for (int i = 0; (i < ds.Tables[0].Rows.Count); i = (i + 1)) {
                        Iterations obj = new Iterations();
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
        
        public static IterationsCollection Select_Iterationss_By_IterationTypeSysId(System.Nullable<int> IterationTypeSysId) {
            resourceSchema.Dal.Iterations dbo = null;
            try {
                dbo = new resourceSchema.Dal.Iterations();
                System.Data.DataSet ds = dbo.Select_Iterationss_By_IterationTypeSysId(IterationTypeSysId);
                IterationsCollection collection = new IterationsCollection();
                if (GlobalTools.IsSafeDataSet(ds)) {
                    for (int i = 0; (i < ds.Tables[0].Rows.Count); i = (i + 1)) {
                        Iterations obj = new Iterations();
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
        
        public static IterationsCollection GetAll() {
            resourceSchema.Dal.Iterations dbo = null;
            try {
                dbo = new resourceSchema.Dal.Iterations();
                System.Data.DataSet ds = dbo.Iterations_Select_All();
                IterationsCollection collection = new IterationsCollection();
                if (GlobalTools.IsSafeDataSet(ds)) {
                    for (int i = 0; (i < ds.Tables[0].Rows.Count); i = (i + 1)) {
                        Iterations obj = new Iterations();
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
        
        public static Iterations Load(System.Nullable<int> SysId) {
            resourceSchema.Dal.Iterations dbo = null;
            try {
                dbo = new resourceSchema.Dal.Iterations();
                System.Data.DataSet ds = dbo.Iterations_Select_One(SysId);
                Iterations obj = null;
                if (GlobalTools.IsSafeDataSet(ds)) {
                    if ((ds.Tables[0].Rows.Count > 0)) {
                        obj = new Iterations();
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
            resourceSchema.Dal.Iterations dbo = null;
            try {
                dbo = new resourceSchema.Dal.Iterations();
                System.Data.DataSet ds = dbo.Iterations_Select_One(this.Sysid);
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
            resourceSchema.Dal.Iterations dbo = null;
            try {
                dbo = new resourceSchema.Dal.Iterations();
                dbo.Iterations_Insert(this._iterationstatussysid, this._iterationtypesysid, this.Publicid, this.Path, this.Createdate, this.Lastmodifieddate, this.IsReadonly, this.Active);
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
            resourceSchema.Dal.Iterations dbo = null;
            try {
                dbo = new resourceSchema.Dal.Iterations();
                dbo.Iterations_Delete(this.Sysid);
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
            resourceSchema.Dal.Iterations dbo = null;
            try {
                dbo = new resourceSchema.Dal.Iterations();
                dbo.Iterations_Update(this.Sysid, this._iterationstatussysid, this._iterationtypesysid, this.Publicid, this.Path, this.Createdate, this.Lastmodifieddate, this.IsReadonly, this.Active);
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
