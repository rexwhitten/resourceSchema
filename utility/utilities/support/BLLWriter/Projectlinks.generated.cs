namespace resourceSchema.Bll {
    
    
    public partial class Projectlinks {
        
        private System.Nullable<int> _sysid;
        
        private System.Nullable<System.Guid> _publicid;
        
        private System.Nullable<int> _parentprojectsysid;
        
        private System.Nullable<int> _childprojectsysid;
        
        private string _linkpath;
        
        private System.Nullable<System.DateTime> _createdate;
        
        private System.Nullable<System.DateTime> _lastmodifieddate;
        
        private System.Nullable<bool> _active;
        
        private Projects _projects;
        
        private Projects _projects2;
        
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
        
        public virtual Projects Projects {
            get {
                if ((this._projects == null)) {
                    this._projects = resourceSchema.Bll.Projects.Load(this._parentprojectsysid);
                }
                return this._projects;
            }
            set {
                _projects = value;
            }
        }
        
        public virtual Projects Projects2 {
            get {
                if ((this._projects2 == null)) {
                    this._projects2 = resourceSchema.Bll.Projects.Load(this._childprojectsysid);
                }
                return this._projects2;
            }
            set {
                _projects2 = value;
            }
        }
        
        private void Clean() {
            this.Sysid = null;
            this.Publicid = null;
            this._parentprojectsysid = null;
            this._childprojectsysid = null;
            this.Linkpath = string.Empty;
            this.Createdate = null;
            this.Lastmodifieddate = null;
            this.Active = null;
            this.Projects = null;
            this.Projects2 = null;
        }
        
        private void Fill(System.Data.DataRow dr) {
            this.Clean();
            if ((dr["SysId"] != System.DBNull.Value)) {
                this.Sysid = ((System.Nullable<int>)(dr["SysId"]));
            }
            if ((dr["PublicId"] != System.DBNull.Value)) {
                this.Publicid = ((System.Nullable<System.Guid>)(dr["PublicId"]));
            }
            if ((dr["ParentProjectSysId"] != System.DBNull.Value)) {
                this._parentprojectsysid = ((System.Nullable<int>)(dr["ParentProjectSysId"]));
            }
            if ((dr["ChildProjectSysId"] != System.DBNull.Value)) {
                this._childprojectsysid = ((System.Nullable<int>)(dr["ChildProjectSysId"]));
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
        
        public static ProjectlinksCollection Select_ProjectLinkss_By_ParentProjectSysId(System.Nullable<int> ParentProjectSysId) {
            resourceSchema.Dal.Projectlinks dbo = null;
            try {
                dbo = new resourceSchema.Dal.Projectlinks();
                System.Data.DataSet ds = dbo.Select_ProjectLinkss_By_ParentProjectSysId(ParentProjectSysId);
                ProjectlinksCollection collection = new ProjectlinksCollection();
                if (GlobalTools.IsSafeDataSet(ds)) {
                    for (int i = 0; (i < ds.Tables[0].Rows.Count); i = (i + 1)) {
                        Projectlinks obj = new Projectlinks();
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
        
        public static ProjectlinksCollection Select_ProjectLinkss_By_ChildProjectSysId(System.Nullable<int> ChildProjectSysId) {
            resourceSchema.Dal.Projectlinks dbo = null;
            try {
                dbo = new resourceSchema.Dal.Projectlinks();
                System.Data.DataSet ds = dbo.Select_ProjectLinkss_By_ChildProjectSysId(ChildProjectSysId);
                ProjectlinksCollection collection = new ProjectlinksCollection();
                if (GlobalTools.IsSafeDataSet(ds)) {
                    for (int i = 0; (i < ds.Tables[0].Rows.Count); i = (i + 1)) {
                        Projectlinks obj = new Projectlinks();
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
        
        public static ProjectlinksCollection GetAll() {
            resourceSchema.Dal.Projectlinks dbo = null;
            try {
                dbo = new resourceSchema.Dal.Projectlinks();
                System.Data.DataSet ds = dbo.ProjectLinks_Select_All();
                ProjectlinksCollection collection = new ProjectlinksCollection();
                if (GlobalTools.IsSafeDataSet(ds)) {
                    for (int i = 0; (i < ds.Tables[0].Rows.Count); i = (i + 1)) {
                        Projectlinks obj = new Projectlinks();
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
        
        public static Projectlinks Load(System.Nullable<int> SysId) {
            resourceSchema.Dal.Projectlinks dbo = null;
            try {
                dbo = new resourceSchema.Dal.Projectlinks();
                System.Data.DataSet ds = dbo.ProjectLinks_Select_One(SysId);
                Projectlinks obj = null;
                if (GlobalTools.IsSafeDataSet(ds)) {
                    if ((ds.Tables[0].Rows.Count > 0)) {
                        obj = new Projectlinks();
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
            resourceSchema.Dal.Projectlinks dbo = null;
            try {
                dbo = new resourceSchema.Dal.Projectlinks();
                System.Data.DataSet ds = dbo.ProjectLinks_Select_One(this.Sysid);
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
            resourceSchema.Dal.Projectlinks dbo = null;
            try {
                dbo = new resourceSchema.Dal.Projectlinks();
                dbo.ProjectLinks_Insert(this.Publicid, this._parentprojectsysid, this._childprojectsysid, this.Linkpath, this.Createdate, this.Lastmodifieddate, this.Active);
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
            resourceSchema.Dal.Projectlinks dbo = null;
            try {
                dbo = new resourceSchema.Dal.Projectlinks();
                dbo.ProjectLinks_Delete(this.Sysid);
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
            resourceSchema.Dal.Projectlinks dbo = null;
            try {
                dbo = new resourceSchema.Dal.Projectlinks();
                dbo.ProjectLinks_Update(this.Sysid, this.Publicid, this._parentprojectsysid, this._childprojectsysid, this.Linkpath, this.Createdate, this.Lastmodifieddate, this.Active);
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
