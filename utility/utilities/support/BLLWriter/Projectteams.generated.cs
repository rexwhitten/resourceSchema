namespace resourceSchema.Bll {
    
    
    public partial class Projectteams {
        
        private System.Nullable<int> _sysid;
        
        private System.Nullable<System.Guid> _publicid;
        
        private string _path;
        
        private System.Nullable<int> _projectsysid;
        
        private System.Nullable<int> _teamsysid;
        
        private System.Nullable<System.DateTime> _createdate;
        
        private System.Nullable<bool> _active;
        
        private Projects _projects;
        
        private Teams _teams;
        
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
        
        public virtual Teams Teams {
            get {
                if ((this._teams == null)) {
                    this._teams = resourceSchema.Bll.Teams.Load(this._teamsysid);
                }
                return this._teams;
            }
            set {
                _teams = value;
            }
        }
        
        private void Clean() {
            this.Sysid = null;
            this.Publicid = null;
            this.Path = string.Empty;
            this._projectsysid = null;
            this._teamsysid = null;
            this.Createdate = null;
            this.Active = null;
            this.Projects = null;
            this.Teams = null;
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
            if ((dr["TeamsysId"] != System.DBNull.Value)) {
                this._teamsysid = ((System.Nullable<int>)(dr["TeamsysId"]));
            }
            if ((dr["CreateDate"] != System.DBNull.Value)) {
                this.Createdate = ((System.Nullable<System.DateTime>)(dr["CreateDate"]));
            }
            if ((dr["Active"] != System.DBNull.Value)) {
                this.Active = ((System.Nullable<bool>)(dr["Active"]));
            }
        }
        
        public static ProjectteamsCollection Select_ProjectTeamss_By_ProjectSysId(System.Nullable<int> ProjectSysId) {
            resourceSchema.Dal.Projectteams dbo = null;
            try {
                dbo = new resourceSchema.Dal.Projectteams();
                System.Data.DataSet ds = dbo.Select_ProjectTeamss_By_ProjectSysId(ProjectSysId);
                ProjectteamsCollection collection = new ProjectteamsCollection();
                if (GlobalTools.IsSafeDataSet(ds)) {
                    for (int i = 0; (i < ds.Tables[0].Rows.Count); i = (i + 1)) {
                        Projectteams obj = new Projectteams();
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
        
        public static ProjectteamsCollection Select_ProjectTeamss_By_TeamsysId(System.Nullable<int> TeamsysId) {
            resourceSchema.Dal.Projectteams dbo = null;
            try {
                dbo = new resourceSchema.Dal.Projectteams();
                System.Data.DataSet ds = dbo.Select_ProjectTeamss_By_TeamsysId(TeamsysId);
                ProjectteamsCollection collection = new ProjectteamsCollection();
                if (GlobalTools.IsSafeDataSet(ds)) {
                    for (int i = 0; (i < ds.Tables[0].Rows.Count); i = (i + 1)) {
                        Projectteams obj = new Projectteams();
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
        
        public static ProjectteamsCollection GetAll() {
            resourceSchema.Dal.Projectteams dbo = null;
            try {
                dbo = new resourceSchema.Dal.Projectteams();
                System.Data.DataSet ds = dbo.ProjectTeams_Select_All();
                ProjectteamsCollection collection = new ProjectteamsCollection();
                if (GlobalTools.IsSafeDataSet(ds)) {
                    for (int i = 0; (i < ds.Tables[0].Rows.Count); i = (i + 1)) {
                        Projectteams obj = new Projectteams();
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
        
        public static Projectteams Load(System.Nullable<int> SysId) {
            resourceSchema.Dal.Projectteams dbo = null;
            try {
                dbo = new resourceSchema.Dal.Projectteams();
                System.Data.DataSet ds = dbo.ProjectTeams_Select_One(SysId);
                Projectteams obj = null;
                if (GlobalTools.IsSafeDataSet(ds)) {
                    if ((ds.Tables[0].Rows.Count > 0)) {
                        obj = new Projectteams();
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
            resourceSchema.Dal.Projectteams dbo = null;
            try {
                dbo = new resourceSchema.Dal.Projectteams();
                System.Data.DataSet ds = dbo.ProjectTeams_Select_One(this.Sysid);
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
            resourceSchema.Dal.Projectteams dbo = null;
            try {
                dbo = new resourceSchema.Dal.Projectteams();
                dbo.ProjectTeams_Insert(this.Publicid, this.Path, this._projectsysid, this._teamsysid, this.Createdate, this.Active);
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
            resourceSchema.Dal.Projectteams dbo = null;
            try {
                dbo = new resourceSchema.Dal.Projectteams();
                dbo.ProjectTeams_Delete(this.Sysid);
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
            resourceSchema.Dal.Projectteams dbo = null;
            try {
                dbo = new resourceSchema.Dal.Projectteams();
                dbo.ProjectTeams_Update(this.Sysid, this.Publicid, this.Path, this._projectsysid, this._teamsysid, this.Createdate, this.Active);
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
