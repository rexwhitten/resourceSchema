namespace resourceSchema.Bll {
    
    
    public partial class Teammemberlinks {
        
        private System.Nullable<int> _sysid;
        
        private System.Nullable<System.Guid> _publicid;
        
        private System.Nullable<int> _parentteammembersysid;
        
        private System.Nullable<int> _childteammembersysid;
        
        private string _linkpath;
        
        private System.Nullable<System.DateTime> _createdate;
        
        private System.Nullable<System.DateTime> _lastmodifieddate;
        
        private System.Nullable<bool> _active;
        
        private Teammembers _teammembers;
        
        private Teammembers _teammembers2;
        
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
        
        public virtual Teammembers Teammembers {
            get {
                if ((this._teammembers == null)) {
                    this._teammembers = resourceSchema.Bll.Teammembers.Load(this._parentteammembersysid);
                }
                return this._teammembers;
            }
            set {
                _teammembers = value;
            }
        }
        
        public virtual Teammembers Teammembers2 {
            get {
                if ((this._teammembers2 == null)) {
                    this._teammembers2 = resourceSchema.Bll.Teammembers.Load(this._childteammembersysid);
                }
                return this._teammembers2;
            }
            set {
                _teammembers2 = value;
            }
        }
        
        private void Clean() {
            this.Sysid = null;
            this.Publicid = null;
            this._parentteammembersysid = null;
            this._childteammembersysid = null;
            this.Linkpath = string.Empty;
            this.Createdate = null;
            this.Lastmodifieddate = null;
            this.Active = null;
            this.Teammembers = null;
            this.Teammembers2 = null;
        }
        
        private void Fill(System.Data.DataRow dr) {
            this.Clean();
            if ((dr["SysId"] != System.DBNull.Value)) {
                this.Sysid = ((System.Nullable<int>)(dr["SysId"]));
            }
            if ((dr["PublicId"] != System.DBNull.Value)) {
                this.Publicid = ((System.Nullable<System.Guid>)(dr["PublicId"]));
            }
            if ((dr["ParentTeamMemberSysId"] != System.DBNull.Value)) {
                this._parentteammembersysid = ((System.Nullable<int>)(dr["ParentTeamMemberSysId"]));
            }
            if ((dr["ChildTeamMemberSysId"] != System.DBNull.Value)) {
                this._childteammembersysid = ((System.Nullable<int>)(dr["ChildTeamMemberSysId"]));
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
        
        public static TeammemberlinksCollection Select_TeamMemberLinkss_By_ParentTeamMemberSysId(System.Nullable<int> ParentTeamMemberSysId) {
            resourceSchema.Dal.Teammemberlinks dbo = null;
            try {
                dbo = new resourceSchema.Dal.Teammemberlinks();
                System.Data.DataSet ds = dbo.Select_TeamMemberLinkss_By_ParentTeamMemberSysId(ParentTeamMemberSysId);
                TeammemberlinksCollection collection = new TeammemberlinksCollection();
                if (GlobalTools.IsSafeDataSet(ds)) {
                    for (int i = 0; (i < ds.Tables[0].Rows.Count); i = (i + 1)) {
                        Teammemberlinks obj = new Teammemberlinks();
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
        
        public static TeammemberlinksCollection Select_TeamMemberLinkss_By_ChildTeamMemberSysId(System.Nullable<int> ChildTeamMemberSysId) {
            resourceSchema.Dal.Teammemberlinks dbo = null;
            try {
                dbo = new resourceSchema.Dal.Teammemberlinks();
                System.Data.DataSet ds = dbo.Select_TeamMemberLinkss_By_ChildTeamMemberSysId(ChildTeamMemberSysId);
                TeammemberlinksCollection collection = new TeammemberlinksCollection();
                if (GlobalTools.IsSafeDataSet(ds)) {
                    for (int i = 0; (i < ds.Tables[0].Rows.Count); i = (i + 1)) {
                        Teammemberlinks obj = new Teammemberlinks();
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
        
        public static TeammemberlinksCollection GetAll() {
            resourceSchema.Dal.Teammemberlinks dbo = null;
            try {
                dbo = new resourceSchema.Dal.Teammemberlinks();
                System.Data.DataSet ds = dbo.TeamMemberLinks_Select_All();
                TeammemberlinksCollection collection = new TeammemberlinksCollection();
                if (GlobalTools.IsSafeDataSet(ds)) {
                    for (int i = 0; (i < ds.Tables[0].Rows.Count); i = (i + 1)) {
                        Teammemberlinks obj = new Teammemberlinks();
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
        
        public static Teammemberlinks Load(System.Nullable<int> SysId) {
            resourceSchema.Dal.Teammemberlinks dbo = null;
            try {
                dbo = new resourceSchema.Dal.Teammemberlinks();
                System.Data.DataSet ds = dbo.TeamMemberLinks_Select_One(SysId);
                Teammemberlinks obj = null;
                if (GlobalTools.IsSafeDataSet(ds)) {
                    if ((ds.Tables[0].Rows.Count > 0)) {
                        obj = new Teammemberlinks();
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
            resourceSchema.Dal.Teammemberlinks dbo = null;
            try {
                dbo = new resourceSchema.Dal.Teammemberlinks();
                System.Data.DataSet ds = dbo.TeamMemberLinks_Select_One(this.Sysid);
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
            resourceSchema.Dal.Teammemberlinks dbo = null;
            try {
                dbo = new resourceSchema.Dal.Teammemberlinks();
                dbo.TeamMemberLinks_Insert(this.Publicid, this._parentteammembersysid, this._childteammembersysid, this.Linkpath, this.Createdate, this.Lastmodifieddate, this.Active);
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
            resourceSchema.Dal.Teammemberlinks dbo = null;
            try {
                dbo = new resourceSchema.Dal.Teammemberlinks();
                dbo.TeamMemberLinks_Delete(this.Sysid);
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
            resourceSchema.Dal.Teammemberlinks dbo = null;
            try {
                dbo = new resourceSchema.Dal.Teammemberlinks();
                dbo.TeamMemberLinks_Update(this.Sysid, this.Publicid, this._parentteammembersysid, this._childteammembersysid, this.Linkpath, this.Createdate, this.Lastmodifieddate, this.Active);
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
