namespace resourceSchema.Bll {
    
    
    public partial class Userteammembers {
        
        private System.Nullable<int> _sysid;
        
        private System.Nullable<System.Guid> _publicid;
        
        private string _path;
        
        private System.Nullable<int> _usersysid;
        
        private System.Nullable<int> _teammembersysid;
        
        private System.Nullable<System.DateTime> _createdate;
        
        private System.Nullable<bool> _active;
        
        private Teammembers _teammembers;
        
        private Users _users;
        
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
        
        public virtual Users Users {
            get {
                if ((this._users == null)) {
                    this._users = resourceSchema.Bll.Users.Load(this._usersysid);
                }
                return this._users;
            }
            set {
                _users = value;
            }
        }
        
        private void Clean() {
            this.Sysid = null;
            this.Publicid = null;
            this.Path = string.Empty;
            this._usersysid = null;
            this._teammembersysid = null;
            this.Createdate = null;
            this.Active = null;
            this.Teammembers = null;
            this.Users = null;
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
            if ((dr["UserSysId"] != System.DBNull.Value)) {
                this._usersysid = ((System.Nullable<int>)(dr["UserSysId"]));
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
        
        public static UserteammembersCollection Select_UserTeamMemberss_By_TeamMembersysId(System.Nullable<int> TeamMembersysId) {
            resourceSchema.Dal.Userteammembers dbo = null;
            try {
                dbo = new resourceSchema.Dal.Userteammembers();
                System.Data.DataSet ds = dbo.Select_UserTeamMemberss_By_TeamMembersysId(TeamMembersysId);
                UserteammembersCollection collection = new UserteammembersCollection();
                if (GlobalTools.IsSafeDataSet(ds)) {
                    for (int i = 0; (i < ds.Tables[0].Rows.Count); i = (i + 1)) {
                        Userteammembers obj = new Userteammembers();
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
        
        public static UserteammembersCollection Select_UserTeamMemberss_By_UserSysId(System.Nullable<int> UserSysId) {
            resourceSchema.Dal.Userteammembers dbo = null;
            try {
                dbo = new resourceSchema.Dal.Userteammembers();
                System.Data.DataSet ds = dbo.Select_UserTeamMemberss_By_UserSysId(UserSysId);
                UserteammembersCollection collection = new UserteammembersCollection();
                if (GlobalTools.IsSafeDataSet(ds)) {
                    for (int i = 0; (i < ds.Tables[0].Rows.Count); i = (i + 1)) {
                        Userteammembers obj = new Userteammembers();
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
        
        public static UserteammembersCollection GetAll() {
            resourceSchema.Dal.Userteammembers dbo = null;
            try {
                dbo = new resourceSchema.Dal.Userteammembers();
                System.Data.DataSet ds = dbo.UserTeamMembers_Select_All();
                UserteammembersCollection collection = new UserteammembersCollection();
                if (GlobalTools.IsSafeDataSet(ds)) {
                    for (int i = 0; (i < ds.Tables[0].Rows.Count); i = (i + 1)) {
                        Userteammembers obj = new Userteammembers();
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
        
        public static Userteammembers Load(System.Nullable<int> SysId) {
            resourceSchema.Dal.Userteammembers dbo = null;
            try {
                dbo = new resourceSchema.Dal.Userteammembers();
                System.Data.DataSet ds = dbo.UserTeamMembers_Select_One(SysId);
                Userteammembers obj = null;
                if (GlobalTools.IsSafeDataSet(ds)) {
                    if ((ds.Tables[0].Rows.Count > 0)) {
                        obj = new Userteammembers();
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
            resourceSchema.Dal.Userteammembers dbo = null;
            try {
                dbo = new resourceSchema.Dal.Userteammembers();
                System.Data.DataSet ds = dbo.UserTeamMembers_Select_One(this.Sysid);
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
            resourceSchema.Dal.Userteammembers dbo = null;
            try {
                dbo = new resourceSchema.Dal.Userteammembers();
                dbo.UserTeamMembers_Insert(this.Publicid, this.Path, this._usersysid, this._teammembersysid, this.Createdate, this.Active);
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
            resourceSchema.Dal.Userteammembers dbo = null;
            try {
                dbo = new resourceSchema.Dal.Userteammembers();
                dbo.UserTeamMembers_Delete(this.Sysid);
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
            resourceSchema.Dal.Userteammembers dbo = null;
            try {
                dbo = new resourceSchema.Dal.Userteammembers();
                dbo.UserTeamMembers_Update(this.Sysid, this.Publicid, this.Path, this._usersysid, this._teammembersysid, this.Createdate, this.Active);
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
