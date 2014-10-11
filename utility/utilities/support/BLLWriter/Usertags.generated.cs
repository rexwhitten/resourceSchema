namespace resourceSchema.Bll {
    
    
    public partial class Usertags {
        
        private System.Nullable<int> _sysid;
        
        private System.Nullable<int> _usersysid;
        
        private string _tag;
        
        private System.Nullable<System.DateTime> _createdate;
        
        private System.Nullable<bool> _active;
        
        private Users _users;
        
        public virtual System.Nullable<int> Sysid {
            get {
                return _sysid;
            }
            set {
                _sysid = value;
            }
        }
        
        public virtual System.Nullable<int> Usersysid {
            get {
                return _usersysid;
            }
            set {
                _usersysid = value;
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
        
        public virtual Users Users {
            get {
                if ((this._users == null)) {
                    this._users = resourceSchema.Bll.Users.Load(this._sysid);
                }
                return this._users;
            }
            set {
                _users = value;
            }
        }
        
        private void Clean() {
            this.Sysid = null;
            this.Usersysid = null;
            this.Tag = string.Empty;
            this.Createdate = null;
            this.Active = null;
            this.Users = null;
        }
        
        private void Fill(System.Data.DataRow dr) {
            this.Clean();
            if ((dr["SysId"] != System.DBNull.Value)) {
                this.Sysid = ((System.Nullable<int>)(dr["SysId"]));
            }
            if ((dr["UserSysId"] != System.DBNull.Value)) {
                this.Usersysid = ((System.Nullable<int>)(dr["UserSysId"]));
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
        
        public static UsertagsCollection Select_UserTagss_By_SysId(System.Nullable<int> SysId) {
            resourceSchema.Dal.Usertags dbo = null;
            try {
                dbo = new resourceSchema.Dal.Usertags();
                System.Data.DataSet ds = dbo.Select_UserTagss_By_SysId(SysId);
                UsertagsCollection collection = new UsertagsCollection();
                if (GlobalTools.IsSafeDataSet(ds)) {
                    for (int i = 0; (i < ds.Tables[0].Rows.Count); i = (i + 1)) {
                        Usertags obj = new Usertags();
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
        
        public static UsertagsCollection GetAll() {
            resourceSchema.Dal.Usertags dbo = null;
            try {
                dbo = new resourceSchema.Dal.Usertags();
                System.Data.DataSet ds = dbo.UserTags_Select_All();
                UsertagsCollection collection = new UsertagsCollection();
                if (GlobalTools.IsSafeDataSet(ds)) {
                    for (int i = 0; (i < ds.Tables[0].Rows.Count); i = (i + 1)) {
                        Usertags obj = new Usertags();
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
        
        public static Usertags Load(System.Nullable<int> SysId) {
            resourceSchema.Dal.Usertags dbo = null;
            try {
                dbo = new resourceSchema.Dal.Usertags();
                System.Data.DataSet ds = dbo.UserTags_Select_One(SysId);
                Usertags obj = null;
                if (GlobalTools.IsSafeDataSet(ds)) {
                    if ((ds.Tables[0].Rows.Count > 0)) {
                        obj = new Usertags();
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
            resourceSchema.Dal.Usertags dbo = null;
            try {
                dbo = new resourceSchema.Dal.Usertags();
                System.Data.DataSet ds = dbo.UserTags_Select_One(this.Sysid);
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
            resourceSchema.Dal.Usertags dbo = null;
            try {
                dbo = new resourceSchema.Dal.Usertags();
                dbo.UserTags_Insert(this.Usersysid, this.Tag, this.Createdate, this.Active);
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
            resourceSchema.Dal.Usertags dbo = null;
            try {
                dbo = new resourceSchema.Dal.Usertags();
                dbo.UserTags_Delete(this.Sysid);
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
            resourceSchema.Dal.Usertags dbo = null;
            try {
                dbo = new resourceSchema.Dal.Usertags();
                dbo.UserTags_Update(this.Sysid, this.Usersysid, this.Tag, this.Createdate, this.Active);
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
