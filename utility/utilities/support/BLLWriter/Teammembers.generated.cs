namespace resourceSchema.Bll {
    
    
    public partial class Teammembers {
        
        private System.Nullable<int> _sysid;
        
        private System.Nullable<int> _teammemberstatussysid;
        
        private System.Nullable<int> _teammembertypesysid;
        
        private System.Nullable<System.Guid> _publicid;
        
        private string _path;
        
        private System.Nullable<System.DateTime> _createdate;
        
        private System.Nullable<System.DateTime> _lastmodifieddate;
        
        private System.Nullable<bool> _isReadonly;
        
        private System.Nullable<bool> _active;
        
        private TaskteammembersCollection _taskteammembersCollection;
        
        private TeammemberlinksCollection _teammemberlinksCollection;
        
        private TeammemberlinksCollection _teammemberlinksCollection2;
        
        private TeammembermetadataCollection _teammembermetadataCollection;
        
        private Teammemberstatus _teammemberstatus;
        
        private Teammembertypes _teammembertypes;
        
        private TeammembertagsCollection _teammembertagsCollection;
        
        private TeamteammembersCollection _teamteammembersCollection;
        
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
        
        public virtual TaskteammembersCollection TaskteammembersCollection {
            get {
                if ((this._taskteammembersCollection == null)) {
                    _taskteammembersCollection = resourceSchema.Bll.Taskteammembers.Select_TaskTeamMemberss_By_TeamMembersysId(this.Sysid);
                }
                return this._taskteammembersCollection;
            }
        }
        
        public virtual TeammemberlinksCollection TeammemberlinksCollection {
            get {
                if ((this._teammemberlinksCollection == null)) {
                    _teammemberlinksCollection = resourceSchema.Bll.Teammemberlinks.Select_TeamMemberLinkss_By_ParentTeamMemberSysId(this.Sysid);
                }
                return this._teammemberlinksCollection;
            }
        }
        
        public virtual TeammemberlinksCollection TeammemberlinksCollection2 {
            get {
                if ((this._teammemberlinksCollection2 == null)) {
                    _teammemberlinksCollection2 = resourceSchema.Bll.Teammemberlinks.Select_TeamMemberLinkss_By_ChildTeamMemberSysId(this.Sysid);
                }
                return this._teammemberlinksCollection2;
            }
        }
        
        public virtual TeammembermetadataCollection TeammembermetadataCollection {
            get {
                if ((this._teammembermetadataCollection == null)) {
                    _teammembermetadataCollection = resourceSchema.Bll.Teammembermetadata.Select_TeamMemberMetaDatas_By_TeamMemberSysId(this.Sysid);
                }
                return this._teammembermetadataCollection;
            }
        }
        
        public virtual Teammemberstatus Teammemberstatus {
            get {
                if ((this._teammemberstatus == null)) {
                    this._teammemberstatus = resourceSchema.Bll.Teammemberstatus.Load(this._teammemberstatussysid);
                }
                return this._teammemberstatus;
            }
            set {
                _teammemberstatus = value;
            }
        }
        
        public virtual Teammembertypes Teammembertypes {
            get {
                if ((this._teammembertypes == null)) {
                    this._teammembertypes = resourceSchema.Bll.Teammembertypes.Load(this._teammembertypesysid);
                }
                return this._teammembertypes;
            }
            set {
                _teammembertypes = value;
            }
        }
        
        public virtual TeammembertagsCollection TeammembertagsCollection {
            get {
                if ((this._teammembertagsCollection == null)) {
                    _teammembertagsCollection = resourceSchema.Bll.Teammembertags.Select_TeamMemberTagss_By_SysId(this.Sysid);
                }
                return this._teammembertagsCollection;
            }
        }
        
        public virtual TeamteammembersCollection TeamteammembersCollection {
            get {
                if ((this._teamteammembersCollection == null)) {
                    _teamteammembersCollection = resourceSchema.Bll.Teamteammembers.Select_TeamTeamMemberss_By_TeamMembersysId(this.Sysid);
                }
                return this._teamteammembersCollection;
            }
        }
        
        public virtual UserteammembersCollection UserteammembersCollection {
            get {
                if ((this._userteammembersCollection == null)) {
                    _userteammembersCollection = resourceSchema.Bll.Userteammembers.Select_UserTeamMemberss_By_TeamMembersysId(this.Sysid);
                }
                return this._userteammembersCollection;
            }
        }
        
        private void Clean() {
            this.Sysid = null;
            this._teammemberstatussysid = null;
            this._teammembertypesysid = null;
            this.Publicid = null;
            this.Path = string.Empty;
            this.Createdate = null;
            this.Lastmodifieddate = null;
            this.IsReadonly = null;
            this.Active = null;
            this._taskteammembersCollection = null;
            this._teammemberlinksCollection = null;
            this._teammemberlinksCollection2 = null;
            this._teammembermetadataCollection = null;
            this.Teammemberstatus = null;
            this.Teammembertypes = null;
            this._teammembertagsCollection = null;
            this._teamteammembersCollection = null;
            this._userteammembersCollection = null;
        }
        
        private void Fill(System.Data.DataRow dr) {
            this.Clean();
            if ((dr["SysId"] != System.DBNull.Value)) {
                this.Sysid = ((System.Nullable<int>)(dr["SysId"]));
            }
            if ((dr["TeamMemberStatusSysId"] != System.DBNull.Value)) {
                this._teammemberstatussysid = ((System.Nullable<int>)(dr["TeamMemberStatusSysId"]));
            }
            if ((dr["TeamMemberTypeSysId"] != System.DBNull.Value)) {
                this._teammembertypesysid = ((System.Nullable<int>)(dr["TeamMemberTypeSysId"]));
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
        
        public static TeammembersCollection Select_TeamMemberss_By_TeamMemberStatusSysId(System.Nullable<int> TeamMemberStatusSysId) {
            resourceSchema.Dal.Teammembers dbo = null;
            try {
                dbo = new resourceSchema.Dal.Teammembers();
                System.Data.DataSet ds = dbo.Select_TeamMemberss_By_TeamMemberStatusSysId(TeamMemberStatusSysId);
                TeammembersCollection collection = new TeammembersCollection();
                if (GlobalTools.IsSafeDataSet(ds)) {
                    for (int i = 0; (i < ds.Tables[0].Rows.Count); i = (i + 1)) {
                        Teammembers obj = new Teammembers();
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
        
        public static TeammembersCollection Select_TeamMemberss_By_TeamMemberTypeSysId(System.Nullable<int> TeamMemberTypeSysId) {
            resourceSchema.Dal.Teammembers dbo = null;
            try {
                dbo = new resourceSchema.Dal.Teammembers();
                System.Data.DataSet ds = dbo.Select_TeamMemberss_By_TeamMemberTypeSysId(TeamMemberTypeSysId);
                TeammembersCollection collection = new TeammembersCollection();
                if (GlobalTools.IsSafeDataSet(ds)) {
                    for (int i = 0; (i < ds.Tables[0].Rows.Count); i = (i + 1)) {
                        Teammembers obj = new Teammembers();
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
        
        public static TeammembersCollection GetAll() {
            resourceSchema.Dal.Teammembers dbo = null;
            try {
                dbo = new resourceSchema.Dal.Teammembers();
                System.Data.DataSet ds = dbo.TeamMembers_Select_All();
                TeammembersCollection collection = new TeammembersCollection();
                if (GlobalTools.IsSafeDataSet(ds)) {
                    for (int i = 0; (i < ds.Tables[0].Rows.Count); i = (i + 1)) {
                        Teammembers obj = new Teammembers();
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
        
        public static Teammembers Load(System.Nullable<int> SysId) {
            resourceSchema.Dal.Teammembers dbo = null;
            try {
                dbo = new resourceSchema.Dal.Teammembers();
                System.Data.DataSet ds = dbo.TeamMembers_Select_One(SysId);
                Teammembers obj = null;
                if (GlobalTools.IsSafeDataSet(ds)) {
                    if ((ds.Tables[0].Rows.Count > 0)) {
                        obj = new Teammembers();
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
            resourceSchema.Dal.Teammembers dbo = null;
            try {
                dbo = new resourceSchema.Dal.Teammembers();
                System.Data.DataSet ds = dbo.TeamMembers_Select_One(this.Sysid);
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
            resourceSchema.Dal.Teammembers dbo = null;
            try {
                dbo = new resourceSchema.Dal.Teammembers();
                dbo.TeamMembers_Insert(this._teammemberstatussysid, this._teammembertypesysid, this.Publicid, this.Path, this.Createdate, this.Lastmodifieddate, this.IsReadonly, this.Active);
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
            resourceSchema.Dal.Teammembers dbo = null;
            try {
                dbo = new resourceSchema.Dal.Teammembers();
                dbo.TeamMembers_Delete(this.Sysid);
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
            resourceSchema.Dal.Teammembers dbo = null;
            try {
                dbo = new resourceSchema.Dal.Teammembers();
                dbo.TeamMembers_Update(this.Sysid, this._teammemberstatussysid, this._teammembertypesysid, this.Publicid, this.Path, this.Createdate, this.Lastmodifieddate, this.IsReadonly, this.Active);
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
