namespace resourceSchema.Bll {
    
    
    public partial class Projecttags {
        
        private System.Nullable<int> _sysid;
        
        private System.Nullable<int> _projectsysid;
        
        private string _tag;
        
        private System.Nullable<System.DateTime> _createdate;
        
        private System.Nullable<bool> _active;
        
        private Projects _projects;
        
        public virtual System.Nullable<int> Sysid {
            get {
                return _sysid;
            }
            set {
                _sysid = value;
            }
        }
        
        public virtual System.Nullable<int> Projectsysid {
            get {
                return _projectsysid;
            }
            set {
                _projectsysid = value;
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
        
        public virtual Projects Projects {
            get {
                if ((this._projects == null)) {
                    this._projects = resourceSchema.Bll.Projects.Load(this._sysid);
                }
                return this._projects;
            }
            set {
                _projects = value;
            }
        }
        
        private void Clean() {
            this.Sysid = null;
            this.Projectsysid = null;
            this.Tag = string.Empty;
            this.Createdate = null;
            this.Active = null;
            this.Projects = null;
        }
        
        private void Fill(System.Data.DataRow dr) {
            this.Clean();
            if ((dr["SysId"] != System.DBNull.Value)) {
                this.Sysid = ((System.Nullable<int>)(dr["SysId"]));
            }
            if ((dr["ProjectSysId"] != System.DBNull.Value)) {
                this.Projectsysid = ((System.Nullable<int>)(dr["ProjectSysId"]));
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
        
        public static ProjecttagsCollection Select_ProjectTagss_By_SysId(System.Nullable<int> SysId) {
            resourceSchema.Dal.Projecttags dbo = null;
            try {
                dbo = new resourceSchema.Dal.Projecttags();
                System.Data.DataSet ds = dbo.Select_ProjectTagss_By_SysId(SysId);
                ProjecttagsCollection collection = new ProjecttagsCollection();
                if (GlobalTools.IsSafeDataSet(ds)) {
                    for (int i = 0; (i < ds.Tables[0].Rows.Count); i = (i + 1)) {
                        Projecttags obj = new Projecttags();
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
        
        public static ProjecttagsCollection GetAll() {
            resourceSchema.Dal.Projecttags dbo = null;
            try {
                dbo = new resourceSchema.Dal.Projecttags();
                System.Data.DataSet ds = dbo.ProjectTags_Select_All();
                ProjecttagsCollection collection = new ProjecttagsCollection();
                if (GlobalTools.IsSafeDataSet(ds)) {
                    for (int i = 0; (i < ds.Tables[0].Rows.Count); i = (i + 1)) {
                        Projecttags obj = new Projecttags();
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
        
        public static Projecttags Load(System.Nullable<int> SysId) {
            resourceSchema.Dal.Projecttags dbo = null;
            try {
                dbo = new resourceSchema.Dal.Projecttags();
                System.Data.DataSet ds = dbo.ProjectTags_Select_One(SysId);
                Projecttags obj = null;
                if (GlobalTools.IsSafeDataSet(ds)) {
                    if ((ds.Tables[0].Rows.Count > 0)) {
                        obj = new Projecttags();
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
            resourceSchema.Dal.Projecttags dbo = null;
            try {
                dbo = new resourceSchema.Dal.Projecttags();
                System.Data.DataSet ds = dbo.ProjectTags_Select_One(this.Sysid);
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
            resourceSchema.Dal.Projecttags dbo = null;
            try {
                dbo = new resourceSchema.Dal.Projecttags();
                dbo.ProjectTags_Insert(this.Projectsysid, this.Tag, this.Createdate, this.Active);
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
            resourceSchema.Dal.Projecttags dbo = null;
            try {
                dbo = new resourceSchema.Dal.Projecttags();
                dbo.ProjectTags_Delete(this.Sysid);
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
            resourceSchema.Dal.Projecttags dbo = null;
            try {
                dbo = new resourceSchema.Dal.Projecttags();
                dbo.ProjectTags_Update(this.Sysid, this.Projectsysid, this.Tag, this.Createdate, this.Active);
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
