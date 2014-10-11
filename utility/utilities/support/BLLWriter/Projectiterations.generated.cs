namespace resourceSchema.Bll {
    
    
    public partial class Projectiterations {
        
        private System.Nullable<int> _sysid;
        
        private System.Nullable<System.Guid> _publicid;
        
        private string _path;
        
        private System.Nullable<int> _projectsysid;
        
        private System.Nullable<int> _iterationsysid;
        
        private System.Nullable<System.DateTime> _createdate;
        
        private System.Nullable<bool> _active;
        
        private Iterations _iterations;
        
        private Projects _projects;
        
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
            this.Publicid = null;
            this.Path = string.Empty;
            this._projectsysid = null;
            this._iterationsysid = null;
            this.Createdate = null;
            this.Active = null;
            this.Iterations = null;
            this.Projects = null;
        }
        
        private void Fill(System.Data.DataRow dr) {
            this.Clean();
            if ((dr["SysId"] != System.DBNull.Value)) {
                this.Sysid = ((System.Nullable<int>)(dr["SysId"]));
            }
            if ((dr["PublicId"] != System.DBNull.Value)) {
                this.Publicid = ((System.Nullable<System.Guid>)(dr["PublicId"]));
            }
            if ((dr["Path"] != System.DBNull.Value)) {
                this.Path = ((string)(dr["Path"]));
            }
            if ((dr["ProjectSysId"] != System.DBNull.Value)) {
                this._projectsysid = ((System.Nullable<int>)(dr["ProjectSysId"]));
            }
            if ((dr["IterationsysId"] != System.DBNull.Value)) {
                this._iterationsysid = ((System.Nullable<int>)(dr["IterationsysId"]));
            }
            if ((dr["CreateDate"] != System.DBNull.Value)) {
                this.Createdate = ((System.Nullable<System.DateTime>)(dr["CreateDate"]));
            }
            if ((dr["Active"] != System.DBNull.Value)) {
                this.Active = ((System.Nullable<bool>)(dr["Active"]));
            }
        }
        
        public static ProjectiterationsCollection Select_ProjectIterationss_By_IterationsysId(System.Nullable<int> IterationsysId) {
            resourceSchema.Dal.Projectiterations dbo = null;
            try {
                dbo = new resourceSchema.Dal.Projectiterations();
                System.Data.DataSet ds = dbo.Select_ProjectIterationss_By_IterationsysId(IterationsysId);
                ProjectiterationsCollection collection = new ProjectiterationsCollection();
                if (GlobalTools.IsSafeDataSet(ds)) {
                    for (int i = 0; (i < ds.Tables[0].Rows.Count); i = (i + 1)) {
                        Projectiterations obj = new Projectiterations();
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
        
        public static ProjectiterationsCollection Select_ProjectIterationss_By_ProjectSysId(System.Nullable<int> ProjectSysId) {
            resourceSchema.Dal.Projectiterations dbo = null;
            try {
                dbo = new resourceSchema.Dal.Projectiterations();
                System.Data.DataSet ds = dbo.Select_ProjectIterationss_By_ProjectSysId(ProjectSysId);
                ProjectiterationsCollection collection = new ProjectiterationsCollection();
                if (GlobalTools.IsSafeDataSet(ds)) {
                    for (int i = 0; (i < ds.Tables[0].Rows.Count); i = (i + 1)) {
                        Projectiterations obj = new Projectiterations();
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
        
        public static ProjectiterationsCollection GetAll() {
            resourceSchema.Dal.Projectiterations dbo = null;
            try {
                dbo = new resourceSchema.Dal.Projectiterations();
                System.Data.DataSet ds = dbo.ProjectIterations_Select_All();
                ProjectiterationsCollection collection = new ProjectiterationsCollection();
                if (GlobalTools.IsSafeDataSet(ds)) {
                    for (int i = 0; (i < ds.Tables[0].Rows.Count); i = (i + 1)) {
                        Projectiterations obj = new Projectiterations();
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
        
        public static Projectiterations Load(System.Nullable<int> SysId) {
            resourceSchema.Dal.Projectiterations dbo = null;
            try {
                dbo = new resourceSchema.Dal.Projectiterations();
                System.Data.DataSet ds = dbo.ProjectIterations_Select_One(SysId);
                Projectiterations obj = null;
                if (GlobalTools.IsSafeDataSet(ds)) {
                    if ((ds.Tables[0].Rows.Count > 0)) {
                        obj = new Projectiterations();
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
            resourceSchema.Dal.Projectiterations dbo = null;
            try {
                dbo = new resourceSchema.Dal.Projectiterations();
                System.Data.DataSet ds = dbo.ProjectIterations_Select_One(this.Sysid);
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
            resourceSchema.Dal.Projectiterations dbo = null;
            try {
                dbo = new resourceSchema.Dal.Projectiterations();
                dbo.ProjectIterations_Insert(this.Publicid, this.Path, this._projectsysid, this._iterationsysid, this.Createdate, this.Active);
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
            resourceSchema.Dal.Projectiterations dbo = null;
            try {
                dbo = new resourceSchema.Dal.Projectiterations();
                dbo.ProjectIterations_Delete(this.Sysid);
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
            resourceSchema.Dal.Projectiterations dbo = null;
            try {
                dbo = new resourceSchema.Dal.Projectiterations();
                dbo.ProjectIterations_Update(this.Sysid, this.Publicid, this.Path, this._projectsysid, this._iterationsysid, this.Createdate, this.Active);
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
