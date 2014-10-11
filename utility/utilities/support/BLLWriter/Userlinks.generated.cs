namespace resourceSchema.Bll {
    
    
    public partial class Userlinks {
        
        private System.Nullable<int> _sysid;
        
        private System.Nullable<System.Guid> _publicid;
        
        private System.Nullable<int> _parentusersysid;
        
        private System.Nullable<int> _childusersysid;
        
        private string _linkpath;
        
        private System.Nullable<System.DateTime> _createdate;
        
        private System.Nullable<System.DateTime> _lastmodifieddate;
        
        private System.Nullable<bool> _active;
        
        private Users _users;
        
        private Users _users2;
        
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
        
        public virtual Users Users {
            get {
                if ((this._users == null)) {
                    this._users = resourceSchema.Bll.Users.Load(this._parentusersysid);
                }
                return this._users;
            }
            set {
                _users = value;
            }
        }
        
        public virtual Users Users2 {
            get {
                if ((this._users2 == null)) {
                    this._users2 = resourceSchema.Bll.Users.Load(this._childusersysid);
                }
                return this._users2;
            }
            set {
                _users2 = value;
            }
        }
        
        private void Clean() {
            this.Sysid = null;
            this.Publicid = null;
            this._parentusersysid = null;
            this._childusersysid = null;
            this.Linkpath = string.Empty;
            this.Createdate = null;
            this.Lastmodifieddate = null;
            this.Active = null;
            this.Users = null;
            this.Users2 = null;
        }
        
        private void Fill(System.Data.DataRow dr) {
            this.Clean();
            if ((dr["SysId"] != System.DBNull.Value)) {
                this.Sysid = ((System.Nullable<int>)(dr["SysId"]));
            }
            if ((dr["PublicId"] != System.DBNull.Value)) {
                this.Publicid = ((System.Nullable<System.Guid>)(dr["PublicId"]));
            }
            if ((dr["ParentUserSysId"] != System.DBNull.Value)) {
                this._parentusersysid = ((System.Nullable<int>)(dr["ParentUserSysId"]));
            }
            if ((dr["ChildUserSysId"] != System.DBNull.Value)) {
                this._childusersysid = ((System.Nullable<int>)(dr["ChildUserSysId"]));
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
        
        public static UserlinksCollection Select_UserLinkss_By_ParentUserSysId(System.Nullable<int> ParentUserSysId) {
            resourceSchema.Dal.Userlinks dbo = null;
            try {
                dbo = new resourceSchema.Dal.Userlinks();
                System.Data.DataSet ds = dbo.Select_UserLinkss_By_ParentUserSysId(ParentUserSysId);
                UserlinksCollection collection = new UserlinksCollection();
                if (GlobalTools.IsSafeDataSet(ds)) {
                    for (int i = 0; (i < ds.Tables[0].Rows.Count); i = (i + 1)) {
                        Userlinks obj = new Userlinks();
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
        
        public static UserlinksCollection Select_UserLinkss_By_ChildUserSysId(System.Nullable<int> ChildUserSysId) {
            resourceSchema.Dal.Userlinks dbo = null;
            try {
                dbo = new resourceSchema.Dal.Userlinks();
                System.Data.DataSet ds = dbo.Select_UserLinkss_By_ChildUserSysId(ChildUserSysId);
                UserlinksCollection collection = new UserlinksCollection();
                if (GlobalTools.IsSafeDataSet(ds)) {
                    for (int i = 0; (i < ds.Tables[0].Rows.Count); i = (i + 1)) {
                        Userlinks obj = new Userlinks();
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
        
        public static UserlinksCollection GetAll() {
            resourceSchema.Dal.Userlinks dbo = null;
            try {
                dbo = new resourceSchema.Dal.Userlinks();
                System.Data.DataSet ds = dbo.UserLinks_Select_All();
                UserlinksCollection collection = new UserlinksCollection();
                if (GlobalTools.IsSafeDataSet(ds)) {
                    for (int i = 0; (i < ds.Tables[0].Rows.Count); i = (i + 1)) {
                        Userlinks obj = new Userlinks();
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
        
        public static Userlinks Load(System.Nullable<int> SysId) {
            resourceSchema.Dal.Userlinks dbo = null;
            try {
                dbo = new resourceSchema.Dal.Userlinks();
                System.Data.DataSet ds = dbo.UserLinks_Select_One(SysId);
                Userlinks obj = null;
                if (GlobalTools.IsSafeDataSet(ds)) {
                    if ((ds.Tables[0].Rows.Count > 0)) {
                        obj = new Userlinks();
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
            resourceSchema.Dal.Userlinks dbo = null;
            try {
                dbo = new resourceSchema.Dal.Userlinks();
                System.Data.DataSet ds = dbo.UserLinks_Select_One(this.Sysid);
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
            resourceSchema.Dal.Userlinks dbo = null;
            try {
                dbo = new resourceSchema.Dal.Userlinks();
                dbo.UserLinks_Insert(this.Publicid, this._parentusersysid, this._childusersysid, this.Linkpath, this.Createdate, this.Lastmodifieddate, this.Active);
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
            resourceSchema.Dal.Userlinks dbo = null;
            try {
                dbo = new resourceSchema.Dal.Userlinks();
                dbo.UserLinks_Delete(this.Sysid);
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
            resourceSchema.Dal.Userlinks dbo = null;
            try {
                dbo = new resourceSchema.Dal.Userlinks();
                dbo.UserLinks_Update(this.Sysid, this.Publicid, this._parentusersysid, this._childusersysid, this.Linkpath, this.Createdate, this.Lastmodifieddate, this.Active);
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
