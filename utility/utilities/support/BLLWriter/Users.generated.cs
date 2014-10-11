namespace resourceSchema.Bll {
    
    
    public partial class Users {
        
        private System.Nullable<int> _sysid;
        
        private System.Nullable<int> _userstatussysid;
        
        private System.Nullable<int> _usertypesysid;
        
        private System.Nullable<System.Guid> _publicid;
        
        private string _path;
        
        private System.Nullable<System.DateTime> _createdate;
        
        private System.Nullable<System.DateTime> _lastmodifieddate;
        
        private System.Nullable<bool> _isReadonly;
        
        private System.Nullable<bool> _active;
        
        private UserattributesCollection _userattributesCollection;
        
        private UserlinksCollection _userlinksCollection;
        
        private UserlinksCollection _userlinksCollection2;
        
        private UsermetadataCollection _usermetadataCollection;
        
        private Userstatus _userstatus;
        
        private Usertypes _usertypes;
        
        private UsertagsCollection _usertagsCollection;
        
        private UserteammembersCollection _userteammembersCollection;
        
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
        
        public virtual System.Nullable<System.DateTime> Lastmodifieddate {
            get {
                return _lastmodifieddate;
            }
            set {
                _lastmodifieddate = value;
            }
        }
        
        public virtual System.Nullable<bool> IsReadonly {
            get {
                return _isReadonly;
            }
            set {
                _isReadonly = value;
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
        
        public virtual UserattributesCollection UserattributesCollection {
            get {
                if ((this._userattributesCollection == null)) {
                    _userattributesCollection = resourceSchema.Bll.Userattributes.Select_UserAttributess_By_UserSysId(this.Sysid);
                }
                return this._userattributesCollection;
            }
        }
        
        public virtual UserlinksCollection UserlinksCollection {
            get {
                if ((this._userlinksCollection == null)) {
                    _userlinksCollection = resourceSchema.Bll.Userlinks.Select_UserLinkss_By_ParentUserSysId(this.Sysid);
                }
                return this._userlinksCollection;
            }
        }
        
        public virtual UserlinksCollection UserlinksCollection2 {
            get {
                if ((this._userlinksCollection2 == null)) {
                    _userlinksCollection2 = resourceSchema.Bll.Userlinks.Select_UserLinkss_By_ChildUserSysId(this.Sysid);
                }
                return this._userlinksCollection2;
            }
        }
        
        public virtual UsermetadataCollection UsermetadataCollection {
            get {
                if ((this._usermetadataCollection == null)) {
                    _usermetadataCollection = resourceSchema.Bll.Usermetadata.Select_UserMetaDatas_By_UserSysId(this.Sysid);
                }
                return this._usermetadataCollection;
            }
        }
        
        public virtual Userstatus Userstatus {
            get {
                if ((this._userstatus == null)) {
                    this._userstatus = resourceSchema.Bll.Userstatus.Load(this._userstatussysid);
                }
                return this._userstatus;
            }
            set {
                _userstatus = value;
            }
        }
        
        public virtual Usertypes Usertypes {
            get {
                if ((this._usertypes == null)) {
                    this._usertypes = resourceSchema.Bll.Usertypes.Load(this._usertypesysid);
                }
                return this._usertypes;
            }
            set {
                _usertypes = value;
            }
        }
        
        public virtual UsertagsCollection UsertagsCollection {
            get {
                if ((this._usertagsCollection == null)) {
                    _usertagsCollection = resourceSchema.Bll.Usertags.Select_UserTagss_By_SysId(this.Sysid);
                }
                return this._usertagsCollection;
            }
        }
        
        public virtual UserteammembersCollection UserteammembersCollection {
            get {
                if ((this._userteammembersCollection == null)) {
                    _userteammembersCollection = resourceSchema.Bll.Userteammembers.Select_UserTeamMemberss_By_UserSysId(this.Sysid);
                }
                return this._userteammembersCollection;
            }
        }
        
        private void Clean() {
            this.Sysid = null;
            this._userstatussysid = null;
            this._usertypesysid = null;
            this.Publicid = null;
            this.Path = string.Empty;
            this.Createdate = null;
            this.Lastmodifieddate = null;
            this.IsReadonly = null;
            this.Active = null;
            this._userattributesCollection = null;
            this._userlinksCollection = null;
            this._userlinksCollection2 = null;
            this._usermetadataCollection = null;
            this.Userstatus = null;
            this.Usertypes = null;
            this._usertagsCollection = null;
            this._userteammembersCollection = null;
        }
        
        private void Fill(System.Data.DataRow dr) {
            this.Clean();
            if ((dr["SysId"] != System.DBNull.Value)) {
                this.Sysid = ((System.Nullable<int>)(dr["SysId"]));
            }
            if ((dr["UserStatusSysId"] != System.DBNull.Value)) {
                this._userstatussysid = ((System.Nullable<int>)(dr["UserStatusSysId"]));
            }
            if ((dr["UserTypeSysId"] != System.DBNull.Value)) {
                this._usertypesysid = ((System.Nullable<int>)(dr["UserTypeSysId"]));
            }
            if ((dr["PublicId"] != System.DBNull.Value)) {
                this.Publicid = ((System.Nullable<System.Guid>)(dr["PublicId"]));
            }
            if ((dr["Path"] != System.DBNull.Value)) {
                this.Path = ((string)(dr["Path"]));
            }
            if ((dr["CreateDate"] != System.DBNull.Value)) {
                this.Createdate = ((System.Nullable<System.DateTime>)(dr["CreateDate"]));
            }
            if ((dr["LastModifiedDate"] != System.DBNull.Value)) {
                this.Lastmodifieddate = ((System.Nullable<System.DateTime>)(dr["LastModifiedDate"]));
            }
            if ((dr["Is_ReadOnly"] != System.DBNull.Value)) {
                this.IsReadonly = ((System.Nullable<bool>)(dr["Is_ReadOnly"]));
            }
            if ((dr["Active"] != System.DBNull.Value)) {
                this.Active = ((System.Nullable<bool>)(dr["Active"]));
            }
        }
        
        public static UsersCollection Select_Userss_By_UserStatusSysId(System.Nullable<int> UserStatusSysId) {
            resourceSchema.Dal.Users dbo = null;
            try {
                dbo = new resourceSchema.Dal.Users();
                System.Data.DataSet ds = dbo.Select_Userss_By_UserStatusSysId(UserStatusSysId);
                UsersCollection collection = new UsersCollection();
                if (GlobalTools.IsSafeDataSet(ds)) {
                    for (int i = 0; (i < ds.Tables[0].Rows.Count); i = (i + 1)) {
                        Users obj = new Users();
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
        
        public static UsersCollection Select_Userss_By_UserTypeSysId(System.Nullable<int> UserTypeSysId) {
            resourceSchema.Dal.Users dbo = null;
            try {
                dbo = new resourceSchema.Dal.Users();
                System.Data.DataSet ds = dbo.Select_Userss_By_UserTypeSysId(UserTypeSysId);
                UsersCollection collection = new UsersCollection();
                if (GlobalTools.IsSafeDataSet(ds)) {
                    for (int i = 0; (i < ds.Tables[0].Rows.Count); i = (i + 1)) {
                        Users obj = new Users();
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
        
        public static UsersCollection GetAll() {
            resourceSchema.Dal.Users dbo = null;
            try {
                dbo = new resourceSchema.Dal.Users();
                System.Data.DataSet ds = dbo.Users_Select_All();
                UsersCollection collection = new UsersCollection();
                if (GlobalTools.IsSafeDataSet(ds)) {
                    for (int i = 0; (i < ds.Tables[0].Rows.Count); i = (i + 1)) {
                        Users obj = new Users();
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
        
        public static Users Load(System.Nullable<int> SysId) {
            resourceSchema.Dal.Users dbo = null;
            try {
                dbo = new resourceSchema.Dal.Users();
                System.Data.DataSet ds = dbo.Users_Select_One(SysId);
                Users obj = null;
                if (GlobalTools.IsSafeDataSet(ds)) {
                    if ((ds.Tables[0].Rows.Count > 0)) {
                        obj = new Users();
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
            resourceSchema.Dal.Users dbo = null;
            try {
                dbo = new resourceSchema.Dal.Users();
                System.Data.DataSet ds = dbo.Users_Select_One(this.Sysid);
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
            resourceSchema.Dal.Users dbo = null;
            try {
                dbo = new resourceSchema.Dal.Users();
                dbo.Users_Insert(this._userstatussysid, this._usertypesysid, this.Publicid, this.Path, this.Createdate, this.Lastmodifieddate, this.IsReadonly, this.Active);
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
            resourceSchema.Dal.Users dbo = null;
            try {
                dbo = new resourceSchema.Dal.Users();
                dbo.Users_Delete(this.Sysid);
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
            resourceSchema.Dal.Users dbo = null;
            try {
                dbo = new resourceSchema.Dal.Users();
                dbo.Users_Update(this.Sysid, this._userstatussysid, this._usertypesysid, this.Publicid, this.Path, this.Createdate, this.Lastmodifieddate, this.IsReadonly, this.Active);
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
