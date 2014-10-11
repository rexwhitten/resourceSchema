namespace resourceSchema.Bll {
    
    
    public partial class Projects {
        
        private System.Nullable<int> _sysid;
        
        private System.Nullable<int> _projectstatussysid;
        
        private System.Nullable<int> _projecttypesysid;
        
        private System.Nullable<System.Guid> _publicid;
        
        private string _path;
        
        private System.Nullable<System.DateTime> _createdate;
        
        private System.Nullable<System.DateTime> _lastmodifieddate;
        
        private System.Nullable<bool> _isReadonly;
        
        private System.Nullable<bool> _active;
        
        private ProjectattributesCollection _projectattributesCollection;
        
        private ProjectiterationsCollection _projectiterationsCollection;
        
        private ProjectlinksCollection _projectlinksCollection;
        
        private ProjectlinksCollection _projectlinksCollection2;
        
        private ProjectmetadataCollection _projectmetadataCollection;
        
        private Projectstatus _projectstatus;
        
        private Projecttypes _projecttypes;
        
        private ProjecttagsCollection _projecttagsCollection;
        
        private ProjectteamsCollection _projectteamsCollection;
        
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
        
        public virtual ProjectattributesCollection ProjectattributesCollection {
            get {
                if ((this._projectattributesCollection == null)) {
                    _projectattributesCollection = resourceSchema.Bll.Projectattributes.Select_ProjectAttributess_By_ProjectSysId(this.Sysid);
                }
                return this._projectattributesCollection;
            }
        }
        
        public virtual ProjectiterationsCollection ProjectiterationsCollection {
            get {
                if ((this._projectiterationsCollection == null)) {
                    _projectiterationsCollection = resourceSchema.Bll.Projectiterations.Select_ProjectIterationss_By_ProjectSysId(this.Sysid);
                }
                return this._projectiterationsCollection;
            }
        }
        
        public virtual ProjectlinksCollection ProjectlinksCollection {
            get {
                if ((this._projectlinksCollection == null)) {
                    _projectlinksCollection = resourceSchema.Bll.Projectlinks.Select_ProjectLinkss_By_ParentProjectSysId(this.Sysid);
                }
                return this._projectlinksCollection;
            }
        }
        
        public virtual ProjectlinksCollection ProjectlinksCollection2 {
            get {
                if ((this._projectlinksCollection2 == null)) {
                    _projectlinksCollection2 = resourceSchema.Bll.Projectlinks.Select_ProjectLinkss_By_ChildProjectSysId(this.Sysid);
                }
                return this._projectlinksCollection2;
            }
        }
        
        public virtual ProjectmetadataCollection ProjectmetadataCollection {
            get {
                if ((this._projectmetadataCollection == null)) {
                    _projectmetadataCollection = resourceSchema.Bll.Projectmetadata.Select_ProjectMetaDatas_By_ProjectSysId(this.Sysid);
                }
                return this._projectmetadataCollection;
            }
        }
        
        public virtual Projectstatus Projectstatus {
            get {
                if ((this._projectstatus == null)) {
                    this._projectstatus = resourceSchema.Bll.Projectstatus.Load(this._projectstatussysid);
                }
                return this._projectstatus;
            }
            set {
                _projectstatus = value;
            }
        }
        
        public virtual Projecttypes Projecttypes {
            get {
                if ((this._projecttypes == null)) {
                    this._projecttypes = resourceSchema.Bll.Projecttypes.Load(this._projecttypesysid);
                }
                return this._projecttypes;
            }
            set {
                _projecttypes = value;
            }
        }
        
        public virtual ProjecttagsCollection ProjecttagsCollection {
            get {
                if ((this._projecttagsCollection == null)) {
                    _projecttagsCollection = resourceSchema.Bll.Projecttags.Select_ProjectTagss_By_SysId(this.Sysid);
                }
                return this._projecttagsCollection;
            }
        }
        
        public virtual ProjectteamsCollection ProjectteamsCollection {
            get {
                if ((this._projectteamsCollection == null)) {
                    _projectteamsCollection = resourceSchema.Bll.Projectteams.Select_ProjectTeamss_By_ProjectSysId(this.Sysid);
                }
                return this._projectteamsCollection;
            }
        }
        
        private void Clean() {
            this.Sysid = null;
            this._projectstatussysid = null;
            this._projecttypesysid = null;
            this.Publicid = null;
            this.Path = string.Empty;
            this.Createdate = null;
            this.Lastmodifieddate = null;
            this.IsReadonly = null;
            this.Active = null;
            this._projectattributesCollection = null;
            this._projectiterationsCollection = null;
            this._projectlinksCollection = null;
            this._projectlinksCollection2 = null;
            this._projectmetadataCollection = null;
            this.Projectstatus = null;
            this.Projecttypes = null;
            this._projecttagsCollection = null;
            this._projectteamsCollection = null;
        }
        
        private void Fill(System.Data.DataRow dr) {
            this.Clean();
            if ((dr["SysId"] != System.DBNull.Value)) {
                this.Sysid = ((System.Nullable<int>)(dr["SysId"]));
            }
            if ((dr["ProjectStatusSysId"] != System.DBNull.Value)) {
                this._projectstatussysid = ((System.Nullable<int>)(dr["ProjectStatusSysId"]));
            }
            if ((dr["ProjectTypeSysId"] != System.DBNull.Value)) {
                this._projecttypesysid = ((System.Nullable<int>)(dr["ProjectTypeSysId"]));
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
        
        public static ProjectsCollection Select_Projectss_By_ProjectStatusSysId(System.Nullable<int> ProjectStatusSysId) {
            resourceSchema.Dal.Projects dbo = null;
            try {
                dbo = new resourceSchema.Dal.Projects();
                System.Data.DataSet ds = dbo.Select_Projectss_By_ProjectStatusSysId(ProjectStatusSysId);
                ProjectsCollection collection = new ProjectsCollection();
                if (GlobalTools.IsSafeDataSet(ds)) {
                    for (int i = 0; (i < ds.Tables[0].Rows.Count); i = (i + 1)) {
                        Projects obj = new Projects();
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
        
        public static ProjectsCollection Select_Projectss_By_ProjectTypeSysId(System.Nullable<int> ProjectTypeSysId) {
            resourceSchema.Dal.Projects dbo = null;
            try {
                dbo = new resourceSchema.Dal.Projects();
                System.Data.DataSet ds = dbo.Select_Projectss_By_ProjectTypeSysId(ProjectTypeSysId);
                ProjectsCollection collection = new ProjectsCollection();
                if (GlobalTools.IsSafeDataSet(ds)) {
                    for (int i = 0; (i < ds.Tables[0].Rows.Count); i = (i + 1)) {
                        Projects obj = new Projects();
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
        
        public static ProjectsCollection GetAll() {
            resourceSchema.Dal.Projects dbo = null;
            try {
                dbo = new resourceSchema.Dal.Projects();
                System.Data.DataSet ds = dbo.Projects_Select_All();
                ProjectsCollection collection = new ProjectsCollection();
                if (GlobalTools.IsSafeDataSet(ds)) {
                    for (int i = 0; (i < ds.Tables[0].Rows.Count); i = (i + 1)) {
                        Projects obj = new Projects();
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
        
        public static Projects Load(System.Nullable<int> SysId) {
            resourceSchema.Dal.Projects dbo = null;
            try {
                dbo = new resourceSchema.Dal.Projects();
                System.Data.DataSet ds = dbo.Projects_Select_One(SysId);
                Projects obj = null;
                if (GlobalTools.IsSafeDataSet(ds)) {
                    if ((ds.Tables[0].Rows.Count > 0)) {
                        obj = new Projects();
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
            resourceSchema.Dal.Projects dbo = null;
            try {
                dbo = new resourceSchema.Dal.Projects();
                System.Data.DataSet ds = dbo.Projects_Select_One(this.Sysid);
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
            resourceSchema.Dal.Projects dbo = null;
            try {
                dbo = new resourceSchema.Dal.Projects();
                dbo.Projects_Insert(this._projectstatussysid, this._projecttypesysid, this.Publicid, this.Path, this.Createdate, this.Lastmodifieddate, this.IsReadonly, this.Active);
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
            resourceSchema.Dal.Projects dbo = null;
            try {
                dbo = new resourceSchema.Dal.Projects();
                dbo.Projects_Delete(this.Sysid);
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
            resourceSchema.Dal.Projects dbo = null;
            try {
                dbo = new resourceSchema.Dal.Projects();
                dbo.Projects_Update(this.Sysid, this._projectstatussysid, this._projecttypesysid, this.Publicid, this.Path, this.Createdate, this.Lastmodifieddate, this.IsReadonly, this.Active);
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
