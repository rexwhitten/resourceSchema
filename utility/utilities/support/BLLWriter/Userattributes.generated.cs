namespace resourceSchema.Bll {
    
    
    public partial class Userattributes {
        
        private System.Nullable<int> _sysid;
        
        private System.Nullable<int> _usersysid;
        
        private System.Nullable<System.DateTime> _createdate;
        
        private System.Nullable<System.DateTime> _lastmodifieddate;
        
        private string _email;
        
        private string _firstname;
        
        private string _lastname;
        
        private Users _users;
        
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
        
        public virtual string Email {
            get {
                return _email;
            }
            set {
                _email = value;
            }
        }
        
        public virtual string Firstname {
            get {
                return _firstname;
            }
            set {
                _firstname = value;
            }
        }
        
        public virtual string Lastname {
            get {
                return _lastname;
            }
            set {
                _lastname = value;
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
            this._usersysid = null;
            this.Createdate = null;
            this.Lastmodifieddate = null;
            this.Email = string.Empty;
            this.Firstname = string.Empty;
            this.Lastname = string.Empty;
            this.Users = null;
        }
        
        private void Fill(System.Data.DataRow dr) {
            this.Clean();
            if ((dr["SysId"] != System.DBNull.Value)) {
                this.Sysid = ((System.Nullable<int>)(dr["SysId"]));
            }
            if ((dr["UserSysId"] != System.DBNull.Value)) {
                this._usersysid = ((System.Nullable<int>)(dr["UserSysId"]));
            }
            if ((dr["CreateDate"] != System.DBNull.Value)) {
                this.Createdate = ((System.Nullable<System.DateTime>)(dr["CreateDate"]));
            }
            if ((dr["LastModifiedDate"] != System.DBNull.Value)) {
                this.Lastmodifieddate = ((System.Nullable<System.DateTime>)(dr["LastModifiedDate"]));
            }
            if ((dr["Email"] != System.DBNull.Value)) {
                this.Email = ((string)(dr["Email"]));
            }
            if ((dr["FirstName"] != System.DBNull.Value)) {
                this.Firstname = ((string)(dr["FirstName"]));
            }
            if ((dr["LastName"] != System.DBNull.Value)) {
                this.Lastname = ((string)(dr["LastName"]));
            }
        }
        
        public static UserattributesCollection Select_UserAttributess_By_UserSysId(System.Nullable<int> UserSysId) {
            resourceSchema.Dal.Userattributes dbo = null;
            try {
                dbo = new resourceSchema.Dal.Userattributes();
                System.Data.DataSet ds = dbo.Select_UserAttributess_By_UserSysId(UserSysId);
                UserattributesCollection collection = new UserattributesCollection();
                if (GlobalTools.IsSafeDataSet(ds)) {
                    for (int i = 0; (i < ds.Tables[0].Rows.Count); i = (i + 1)) {
                        Userattributes obj = new Userattributes();
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
        
        public static UserattributesCollection GetAll() {
            resourceSchema.Dal.Userattributes dbo = null;
            try {
                dbo = new resourceSchema.Dal.Userattributes();
                System.Data.DataSet ds = dbo.UserAttributes_Select_All();
                UserattributesCollection collection = new UserattributesCollection();
                if (GlobalTools.IsSafeDataSet(ds)) {
                    for (int i = 0; (i < ds.Tables[0].Rows.Count); i = (i + 1)) {
                        Userattributes obj = new Userattributes();
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
        
        public static Userattributes Load(System.Nullable<int> SysId) {
            resourceSchema.Dal.Userattributes dbo = null;
            try {
                dbo = new resourceSchema.Dal.Userattributes();
                System.Data.DataSet ds = dbo.UserAttributes_Select_One(SysId);
                Userattributes obj = null;
                if (GlobalTools.IsSafeDataSet(ds)) {
                    if ((ds.Tables[0].Rows.Count > 0)) {
                        obj = new Userattributes();
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
            resourceSchema.Dal.Userattributes dbo = null;
            try {
                dbo = new resourceSchema.Dal.Userattributes();
                System.Data.DataSet ds = dbo.UserAttributes_Select_One(this.Sysid);
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
            resourceSchema.Dal.Userattributes dbo = null;
            try {
                dbo = new resourceSchema.Dal.Userattributes();
                dbo.UserAttributes_Insert(this._usersysid, this.Createdate, this.Lastmodifieddate, this.Email, this.Firstname, this.Lastname);
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
            resourceSchema.Dal.Userattributes dbo = null;
            try {
                dbo = new resourceSchema.Dal.Userattributes();
                dbo.UserAttributes_Delete(this.Sysid);
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
            resourceSchema.Dal.Userattributes dbo = null;
            try {
                dbo = new resourceSchema.Dal.Userattributes();
                dbo.UserAttributes_Update(this.Sysid, this._usersysid, this.Createdate, this.Lastmodifieddate, this.Email, this.Firstname, this.Lastname);
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
