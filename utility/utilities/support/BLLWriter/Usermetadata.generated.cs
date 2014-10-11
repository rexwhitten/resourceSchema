namespace resourceSchema.Bll {
    
    
    public partial class Usermetadata {
        
        private System.Nullable<int> _sysid;
        
        private System.Nullable<System.Guid> _publicid;
        
        private System.Nullable<int> _usersysid;
        
        private string _keypath;
        
        private string _keyvalue;
        
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
        
        public virtual System.Nullable<System.Guid> Publicid {
            get {
                return _publicid;
            }
            set {
                _publicid = value;
            }
        }
        
        public virtual string Keypath {
            get {
                return _keypath;
            }
            set {
                _keypath = value;
            }
        }
        
        public virtual string Keyvalue {
            get {
                return _keyvalue;
            }
            set {
                _keyvalue = value;
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
            this._usersysid = null;
            this.Keypath = string.Empty;
            this.Keyvalue = string.Empty;
            this.Active = null;
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
            if ((dr["UserSysId"] != System.DBNull.Value)) {
                this._usersysid = ((System.Nullable<int>)(dr["UserSysId"]));
            }
            if ((dr["KeyPath"] != System.DBNull.Value)) {
                this.Keypath = ((string)(dr["KeyPath"]));
            }
            if ((dr["KeyValue"] != System.DBNull.Value)) {
                this.Keyvalue = ((string)(dr["KeyValue"]));
            }
            if ((dr["Active"] != System.DBNull.Value)) {
                this.Active = ((System.Nullable<bool>)(dr["Active"]));
            }
        }
        
        public static UsermetadataCollection Select_UserMetaDatas_By_UserSysId(System.Nullable<int> UserSysId) {
            resourceSchema.Dal.Usermetadata dbo = null;
            try {
                dbo = new resourceSchema.Dal.Usermetadata();
                System.Data.DataSet ds = dbo.Select_UserMetaDatas_By_UserSysId(UserSysId);
                UsermetadataCollection collection = new UsermetadataCollection();
                if (GlobalTools.IsSafeDataSet(ds)) {
                    for (int i = 0; (i < ds.Tables[0].Rows.Count); i = (i + 1)) {
                        Usermetadata obj = new Usermetadata();
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
        
        public static UsermetadataCollection GetAll() {
            resourceSchema.Dal.Usermetadata dbo = null;
            try {
                dbo = new resourceSchema.Dal.Usermetadata();
                System.Data.DataSet ds = dbo.UserMetaData_Select_All();
                UsermetadataCollection collection = new UsermetadataCollection();
                if (GlobalTools.IsSafeDataSet(ds)) {
                    for (int i = 0; (i < ds.Tables[0].Rows.Count); i = (i + 1)) {
                        Usermetadata obj = new Usermetadata();
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
        
        public static Usermetadata Load(System.Nullable<int> SysId) {
            resourceSchema.Dal.Usermetadata dbo = null;
            try {
                dbo = new resourceSchema.Dal.Usermetadata();
                System.Data.DataSet ds = dbo.UserMetaData_Select_One(SysId);
                Usermetadata obj = null;
                if (GlobalTools.IsSafeDataSet(ds)) {
                    if ((ds.Tables[0].Rows.Count > 0)) {
                        obj = new Usermetadata();
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
            resourceSchema.Dal.Usermetadata dbo = null;
            try {
                dbo = new resourceSchema.Dal.Usermetadata();
                System.Data.DataSet ds = dbo.UserMetaData_Select_One(this.Sysid);
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
            resourceSchema.Dal.Usermetadata dbo = null;
            try {
                dbo = new resourceSchema.Dal.Usermetadata();
                dbo.UserMetaData_Insert(this.Publicid, this._usersysid, this.Keypath, this.Keyvalue, this.Active);
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
            resourceSchema.Dal.Usermetadata dbo = null;
            try {
                dbo = new resourceSchema.Dal.Usermetadata();
                dbo.UserMetaData_Delete(this.Sysid);
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
            resourceSchema.Dal.Usermetadata dbo = null;
            try {
                dbo = new resourceSchema.Dal.Usermetadata();
                dbo.UserMetaData_Update(this.Sysid, this.Publicid, this._usersysid, this.Keypath, this.Keyvalue, this.Active);
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
