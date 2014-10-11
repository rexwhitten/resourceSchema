namespace resourceSchema.Bll {
    
    
    public partial class Taskteammembers {
        
        private System.Nullable<int> _sysid;
        
        private System.Nullable<System.Guid> _publicid;
        
        private string _path;
        
        private System.Nullable<int> _tasksysid;
        
        private System.Nullable<int> _teammembersysid;
        
        private System.Nullable<System.DateTime> _createdate;
        
        private System.Nullable<bool> _active;
        
        private Tasks _tasks;
        
        private Teammembers _teammembers;
        
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
        
        public virtual Tasks Tasks {
            get {
                if ((this._tasks == null)) {
                    this._tasks = resourceSchema.Bll.Tasks.Load(this._tasksysid);
                }
                return this._tasks;
            }
            set {
                _tasks = value;
            }
        }
        
        public virtual Teammembers Teammembers {
            get {
                if ((this._teammembers == null)) {
                    this._teammembers = resourceSchema.Bll.Teammembers.Load(this._teammembersysid);
                }
                return this._teammembers;
            }
            set {
                _teammembers = value;
            }
        }
        
        private void Clean() {
            this.Sysid = null;
            this.Publicid = null;
            this.Path = string.Empty;
            this._tasksysid = null;
            this._teammembersysid = null;
            this.Createdate = null;
            this.Active = null;
            this.Tasks = null;
            this.Teammembers = null;
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
            if ((dr["TaskSysId"] != System.DBNull.Value)) {
                this._tasksysid = ((System.Nullable<int>)(dr["TaskSysId"]));
            }
            if ((dr["TeamMembersysId"] != System.DBNull.Value)) {
                this._teammembersysid = ((System.Nullable<int>)(dr["TeamMembersysId"]));
            }
            if ((dr["CreateDate"] != System.DBNull.Value)) {
                this.Createdate = ((System.Nullable<System.DateTime>)(dr["CreateDate"]));
            }
            if ((dr["Active"] != System.DBNull.Value)) {
                this.Active = ((System.Nullable<bool>)(dr["Active"]));
            }
        }
        
        public static TaskteammembersCollection Select_TaskTeamMemberss_By_TaskSysId(System.Nullable<int> TaskSysId) {
            resourceSchema.Dal.Taskteammembers dbo = null;
            try {
                dbo = new resourceSchema.Dal.Taskteammembers();
                System.Data.DataSet ds = dbo.Select_TaskTeamMemberss_By_TaskSysId(TaskSysId);
                TaskteammembersCollection collection = new TaskteammembersCollection();
                if (GlobalTools.IsSafeDataSet(ds)) {
                    for (int i = 0; (i < ds.Tables[0].Rows.Count); i = (i + 1)) {
                        Taskteammembers obj = new Taskteammembers();
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
        
        public static TaskteammembersCollection Select_TaskTeamMemberss_By_TeamMembersysId(System.Nullable<int> TeamMembersysId) {
            resourceSchema.Dal.Taskteammembers dbo = null;
            try {
                dbo = new resourceSchema.Dal.Taskteammembers();
                System.Data.DataSet ds = dbo.Select_TaskTeamMemberss_By_TeamMembersysId(TeamMembersysId);
                TaskteammembersCollection collection = new TaskteammembersCollection();
                if (GlobalTools.IsSafeDataSet(ds)) {
                    for (int i = 0; (i < ds.Tables[0].Rows.Count); i = (i + 1)) {
                        Taskteammembers obj = new Taskteammembers();
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
        
        public static TaskteammembersCollection GetAll() {
            resourceSchema.Dal.Taskteammembers dbo = null;
            try {
                dbo = new resourceSchema.Dal.Taskteammembers();
                System.Data.DataSet ds = dbo.TaskTeamMembers_Select_All();
                TaskteammembersCollection collection = new TaskteammembersCollection();
                if (GlobalTools.IsSafeDataSet(ds)) {
                    for (int i = 0; (i < ds.Tables[0].Rows.Count); i = (i + 1)) {
                        Taskteammembers obj = new Taskteammembers();
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
        
        public static Taskteammembers Load(System.Nullable<int> SysId) {
            resourceSchema.Dal.Taskteammembers dbo = null;
            try {
                dbo = new resourceSchema.Dal.Taskteammembers();
                System.Data.DataSet ds = dbo.TaskTeamMembers_Select_One(SysId);
                Taskteammembers obj = null;
                if (GlobalTools.IsSafeDataSet(ds)) {
                    if ((ds.Tables[0].Rows.Count > 0)) {
                        obj = new Taskteammembers();
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
            resourceSchema.Dal.Taskteammembers dbo = null;
            try {
                dbo = new resourceSchema.Dal.Taskteammembers();
                System.Data.DataSet ds = dbo.TaskTeamMembers_Select_One(this.Sysid);
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
            resourceSchema.Dal.Taskteammembers dbo = null;
            try {
                dbo = new resourceSchema.Dal.Taskteammembers();
                dbo.TaskTeamMembers_Insert(this.Publicid, this.Path, this._tasksysid, this._teammembersysid, this.Createdate, this.Active);
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
            resourceSchema.Dal.Taskteammembers dbo = null;
            try {
                dbo = new resourceSchema.Dal.Taskteammembers();
                dbo.TaskTeamMembers_Delete(this.Sysid);
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
            resourceSchema.Dal.Taskteammembers dbo = null;
            try {
                dbo = new resourceSchema.Dal.Taskteammembers();
                dbo.TaskTeamMembers_Update(this.Sysid, this.Publicid, this.Path, this._tasksysid, this._teammembersysid, this.Createdate, this.Active);
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
