namespace resourceSchema.Bll {
    
    
    public partial class Projectattributes {
        
        private System.Nullable<int> _sysid;
        
        private System.Nullable<int> _projectsysid;
        
        private System.Nullable<System.DateTime> _createdate;
        
        private System.Nullable<System.DateTime> _lastmodifieddate;
        
        private string _description;
        
        private Projects _projects;
        
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
        
        public virtual Projects Projects {
            get {
                if ((this._projects == null)) {
                    this._projects = resourceSchema.Bll.Projects.Load(this._projectsysid);
                }
                return this._projects;
            }
            set {
                _projects = value;
            }
        }
        
        private void Clean() {
            this.Sysid = null;
            this._projectsysid = null;
            this.Createdate = null;
            this.Lastmodifieddate = null;
            this.Description = string.Empty;
            this.Projects = null;
        }
        
        private void Fill(System.Data.DataRow dr) {
            this.Clean();
            if ((dr["SysId"] != System.DBNull.Value)) {
                this.Sysid = ((System.Nullable<int>)(dr["SysId"]));
            }
            if ((dr["ProjectSysId"] != System.DBNull.Value)) {
                this._projectsysid = ((System.Nullable<int>)(dr["ProjectSysId"]));
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
        }
        
        public static ProjectattributesCollection Select_ProjectAttributess_By_ProjectSysId(System.Nullable<int> ProjectSysId) {
            resourceSchema.Dal.Projectattributes dbo = null;
            try {
                dbo = new resourceSchema.Dal.Projectattributes();
                System.Data.DataSet ds = dbo.Select_ProjectAttributess_By_ProjectSysId(ProjectSysId);
                ProjectattributesCollection collection = new ProjectattributesCollection();
                if (GlobalTools.IsSafeDataSet(ds)) {
                    for (int i = 0; (i < ds.Tables[0].Rows.Count); i = (i + 1)) {
                        Projectattributes obj = new Projectattributes();
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
        
        public static ProjectattributesCollection GetAll() {
            resourceSchema.Dal.Projectattributes dbo = null;
            try {
                dbo = new resourceSchema.Dal.Projectattributes();
                System.Data.DataSet ds = dbo.ProjectAttributes_Select_All();
                ProjectattributesCollection collection = new ProjectattributesCollection();
                if (GlobalTools.IsSafeDataSet(ds)) {
                    for (int i = 0; (i < ds.Tables[0].Rows.Count); i = (i + 1)) {
                        Projectattributes obj = new Projectattributes();
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
        
        public static Projectattributes Load(System.Nullable<int> SysId) {
            resourceSchema.Dal.Projectattributes dbo = null;
            try {
                dbo = new resourceSchema.Dal.Projectattributes();
                System.Data.DataSet ds = dbo.ProjectAttributes_Select_One(SysId);
                Projectattributes obj = null;
                if (GlobalTools.IsSafeDataSet(ds)) {
                    if ((ds.Tables[0].Rows.Count > 0)) {
                        obj = new Projectattributes();
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
            resourceSchema.Dal.Projectattributes dbo = null;
            try {
                dbo = new resourceSchema.Dal.Projectattributes();
                System.Data.DataSet ds = dbo.ProjectAttributes_Select_One(this.Sysid);
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
            resourceSchema.Dal.Projectattributes dbo = null;
            try {
                dbo = new resourceSchema.Dal.Projectattributes();
                dbo.ProjectAttributes_Insert(this._projectsysid, this.Createdate, this.Lastmodifieddate, this.Description);
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
            resourceSchema.Dal.Projectattributes dbo = null;
            try {
                dbo = new resourceSchema.Dal.Projectattributes();
                dbo.ProjectAttributes_Delete(this.Sysid);
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
            resourceSchema.Dal.Projectattributes dbo = null;
            try {
                dbo = new resourceSchema.Dal.Projectattributes();
                dbo.ProjectAttributes_Update(this.Sysid, this._projectsysid, this.Createdate, this.Lastmodifieddate, this.Description);
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
