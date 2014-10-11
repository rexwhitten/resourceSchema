namespace resourceSchema.Bll {
    
    
    public partial class Teamlinks {
        
        private System.Nullable<int> _sysid;
        
        private System.Nullable<System.Guid> _publicid;
        
        private System.Nullable<int> _parentteamsysid;
        
        private System.Nullable<int> _childteamsysid;
        
        private string _linkpath;
        
        private System.Nullable<System.DateTime> _createdate;
        
        private System.Nullable<System.DateTime> _lastmodifieddate;
        
        private System.Nullable<bool> _active;
        
        private Teams _teams;
        
        private Teams _teams2;
        
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
        
        public virtual Teams Teams {
            get {
                if ((this._teams == null)) {
                    this._teams = resourceSchema.Bll.Teams.Load(this._parentteamsysid);
                }
                return this._teams;
            }
            set {
                _teams = value;
            }
        }
        
        public virtual Teams Teams2 {
            get {
                if ((this._teams2 == null)) {
                    this._teams2 = resourceSchema.Bll.Teams.Load(this._childteamsysid);
                }
                return this._teams2;
            }
            set {
                _teams2 = value;
            }
        }
        
        private void Clean() {
            this.Sysid = null;
            this.Publicid = null;
            this._parentteamsysid = null;
            this._childteamsysid = null;
            this.Linkpath = string.Empty;
            this.Createdate = null;
            this.Lastmodifieddate = null;
            this.Active = null;
            this.Teams = null;
            this.Teams2 = null;
        }
        
        private void Fill(System.Data.DataRow dr) {
            this.Clean();
            if ((dr["SysId"] != System.DBNull.Value)) {
                this.Sysid = ((System.Nullable<int>)(dr["SysId"]));
            }
            if ((dr["PublicId"] != System.DBNull.Value)) {
                this.Publicid = ((System.Nullable<System.Guid>)(dr["PublicId"]));
            }
            if ((dr["ParentTeamSysId"] != System.DBNull.Value)) {
                this._parentteamsysid = ((System.Nullable<int>)(dr["ParentTeamSysId"]));
            }
            if ((dr["ChildTeamSysId"] != System.DBNull.Value)) {
                this._childteamsysid = ((System.Nullable<int>)(dr["ChildTeamSysId"]));
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
        
        public static TeamlinksCollection Select_TeamLinkss_By_ParentTeamSysId(System.Nullable<int> ParentTeamSysId) {
            resourceSchema.Dal.Teamlinks dbo = null;
            try {
                dbo = new resourceSchema.Dal.Teamlinks();
                System.Data.DataSet ds = dbo.Select_TeamLinkss_By_ParentTeamSysId(ParentTeamSysId);
                TeamlinksCollection collection = new TeamlinksCollection();
                if (GlobalTools.IsSafeDataSet(ds)) {
                    for (int i = 0; (i < ds.Tables[0].Rows.Count); i = (i + 1)) {
                        Teamlinks obj = new Teamlinks();
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
        
        public static TeamlinksCollection Select_TeamLinkss_By_ChildTeamSysId(System.Nullable<int> ChildTeamSysId) {
            resourceSchema.Dal.Teamlinks dbo = null;
            try {
                dbo = new resourceSchema.Dal.Teamlinks();
                System.Data.DataSet ds = dbo.Select_TeamLinkss_By_ChildTeamSysId(ChildTeamSysId);
                TeamlinksCollection collection = new TeamlinksCollection();
                if (GlobalTools.IsSafeDataSet(ds)) {
                    for (int i = 0; (i < ds.Tables[0].Rows.Count); i = (i + 1)) {
                        Teamlinks obj = new Teamlinks();
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
        
        public static TeamlinksCollection GetAll() {
            resourceSchema.Dal.Teamlinks dbo = null;
            try {
                dbo = new resourceSchema.Dal.Teamlinks();
                System.Data.DataSet ds = dbo.TeamLinks_Select_All();
                TeamlinksCollection collection = new TeamlinksCollection();
                if (GlobalTools.IsSafeDataSet(ds)) {
                    for (int i = 0; (i < ds.Tables[0].Rows.Count); i = (i + 1)) {
                        Teamlinks obj = new Teamlinks();
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
        
        public static Teamlinks Load(System.Nullable<int> SysId) {
            resourceSchema.Dal.Teamlinks dbo = null;
            try {
                dbo = new resourceSchema.Dal.Teamlinks();
                System.Data.DataSet ds = dbo.TeamLinks_Select_One(SysId);
                Teamlinks obj = null;
                if (GlobalTools.IsSafeDataSet(ds)) {
                    if ((ds.Tables[0].Rows.Count > 0)) {
                        obj = new Teamlinks();
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
            resourceSchema.Dal.Teamlinks dbo = null;
            try {
                dbo = new resourceSchema.Dal.Teamlinks();
                System.Data.DataSet ds = dbo.TeamLinks_Select_One(this.Sysid);
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
            resourceSchema.Dal.Teamlinks dbo = null;
            try {
                dbo = new resourceSchema.Dal.Teamlinks();
                dbo.TeamLinks_Insert(this.Publicid, this._parentteamsysid, this._childteamsysid, this.Linkpath, this.Createdate, this.Lastmodifieddate, this.Active);
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
            resourceSchema.Dal.Teamlinks dbo = null;
            try {
                dbo = new resourceSchema.Dal.Teamlinks();
                dbo.TeamLinks_Delete(this.Sysid);
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
            resourceSchema.Dal.Teamlinks dbo = null;
            try {
                dbo = new resourceSchema.Dal.Teamlinks();
                dbo.TeamLinks_Update(this.Sysid, this.Publicid, this._parentteamsysid, this._childteamsysid, this.Linkpath, this.Createdate, this.Lastmodifieddate, this.Active);
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
