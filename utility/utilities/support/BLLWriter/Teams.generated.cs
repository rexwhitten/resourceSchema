namespace resourceSchema.Bll {
    
    
    public partial class Teams {
        
        private System.Nullable<int> _sysid;
        
        private System.Nullable<int> _teamstatussysid;
        
        private System.Nullable<int> _teamtypesysid;
        
        private System.Nullable<System.Guid> _publicid;
        
        private string _path;
        
        private System.Nullable<System.DateTime> _createdate;
        
        private System.Nullable<System.DateTime> _lastmodifieddate;
        
        private System.Nullable<bool> _isReadonly;
        
        private System.Nullable<bool> _active;
        
        private ProjectteamsCollection _projectteamsCollection;
        
        private TeamlinksCollection _teamlinksCollection;
        
        private TeamlinksCollection _teamlinksCollection2;
        
        private TeammetadataCollection _teammetadataCollection;
        
        private Teamstatus _teamstatus;
        
        private Teamtypes _teamtypes;
        
        private TeamtagsCollection _teamtagsCollection;
        
        private TeamteammembersCollection _teamteammembersCollection;
        
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
        
        public virtual ProjectteamsCollection ProjectteamsCollection {
            get {
                if ((this._projectteamsCollection == null)) {
                    _projectteamsCollection = resourceSchema.Bll.Projectteams.Select_ProjectTeamss_By_TeamsysId(this.Sysid);
                }
                return this._projectteamsCollection;
            }
        }
        
        public virtual TeamlinksCollection TeamlinksCollection {
            get {
                if ((this._teamlinksCollection == null)) {
                    _teamlinksCollection = resourceSchema.Bll.Teamlinks.Select_TeamLinkss_By_ParentTeamSysId(this.Sysid);
                }
                return this._teamlinksCollection;
            }
        }
        
        public virtual TeamlinksCollection TeamlinksCollection2 {
            get {
                if ((this._teamlinksCollection2 == null)) {
                    _teamlinksCollection2 = resourceSchema.Bll.Teamlinks.Select_TeamLinkss_By_ChildTeamSysId(this.Sysid);
                }
                return this._teamlinksCollection2;
            }
        }
        
        public virtual TeammetadataCollection TeammetadataCollection {
            get {
                if ((this._teammetadataCollection == null)) {
                    _teammetadataCollection = resourceSchema.Bll.Teammetadata.Select_TeamMetaDatas_By_TeamSysId(this.Sysid);
                }
                return this._teammetadataCollection;
            }
        }
        
        public virtual Teamstatus Teamstatus {
            get {
                if ((this._teamstatus == null)) {
                    this._teamstatus = resourceSchema.Bll.Teamstatus.Load(this._teamstatussysid);
                }
                return this._teamstatus;
            }
            set {
                _teamstatus = value;
            }
        }
        
        public virtual Teamtypes Teamtypes {
            get {
                if ((this._teamtypes == null)) {
                    this._teamtypes = resourceSchema.Bll.Teamtypes.Load(this._teamtypesysid);
                }
                return this._teamtypes;
            }
            set {
                _teamtypes = value;
            }
        }
        
        public virtual TeamtagsCollection TeamtagsCollection {
            get {
                if ((this._teamtagsCollection == null)) {
                    _teamtagsCollection = resourceSchema.Bll.Teamtags.Select_TeamTagss_By_SysId(this.Sysid);
                }
                return this._teamtagsCollection;
            }
        }
        
        public virtual TeamteammembersCollection TeamteammembersCollection {
            get {
                if ((this._teamteammembersCollection == null)) {
                    _teamteammembersCollection = resourceSchema.Bll.Teamteammembers.Select_TeamTeamMemberss_By_TeamSysId(this.Sysid);
                }
                return this._teamteammembersCollection;
            }
        }
        
        private void Clean() {
            this.Sysid = null;
            this._teamstatussysid = null;
            this._teamtypesysid = null;
            this.Publicid = null;
            this.Path = string.Empty;
            this.Createdate = null;
            this.Lastmodifieddate = null;
            this.IsReadonly = null;
            this.Active = null;
            this._projectteamsCollection = null;
            this._teamlinksCollection = null;
            this._teamlinksCollection2 = null;
            this._teammetadataCollection = null;
            this.Teamstatus = null;
            this.Teamtypes = null;
            this._teamtagsCollection = null;
            this._teamteammembersCollection = null;
        }
        
        private void Fill(System.Data.DataRow dr) {
            this.Clean();
            if ((dr["SysId"] != System.DBNull.Value)) {
                this.Sysid = ((System.Nullable<int>)(dr["SysId"]));
            }
            if ((dr["TeamStatusSysId"] != System.DBNull.Value)) {
                this._teamstatussysid = ((System.Nullable<int>)(dr["TeamStatusSysId"]));
            }
            if ((dr["TeamTypeSysId"] != System.DBNull.Value)) {
                this._teamtypesysid = ((System.Nullable<int>)(dr["TeamTypeSysId"]));
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
        
        public static TeamsCollection Select_Teamss_By_TeamStatusSysId(System.Nullable<int> TeamStatusSysId) {
            resourceSchema.Dal.Teams dbo = null;
            try {
                dbo = new resourceSchema.Dal.Teams();
                System.Data.DataSet ds = dbo.Select_Teamss_By_TeamStatusSysId(TeamStatusSysId);
                TeamsCollection collection = new TeamsCollection();
                if (GlobalTools.IsSafeDataSet(ds)) {
                    for (int i = 0; (i < ds.Tables[0].Rows.Count); i = (i + 1)) {
                        Teams obj = new Teams();
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
        
        public static TeamsCollection Select_Teamss_By_TeamTypeSysId(System.Nullable<int> TeamTypeSysId) {
            resourceSchema.Dal.Teams dbo = null;
            try {
                dbo = new resourceSchema.Dal.Teams();
                System.Data.DataSet ds = dbo.Select_Teamss_By_TeamTypeSysId(TeamTypeSysId);
                TeamsCollection collection = new TeamsCollection();
                if (GlobalTools.IsSafeDataSet(ds)) {
                    for (int i = 0; (i < ds.Tables[0].Rows.Count); i = (i + 1)) {
                        Teams obj = new Teams();
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
        
        public static TeamsCollection GetAll() {
            resourceSchema.Dal.Teams dbo = null;
            try {
                dbo = new resourceSchema.Dal.Teams();
                System.Data.DataSet ds = dbo.Teams_Select_All();
                TeamsCollection collection = new TeamsCollection();
                if (GlobalTools.IsSafeDataSet(ds)) {
                    for (int i = 0; (i < ds.Tables[0].Rows.Count); i = (i + 1)) {
                        Teams obj = new Teams();
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
        
        public static Teams Load(System.Nullable<int> SysId) {
            resourceSchema.Dal.Teams dbo = null;
            try {
                dbo = new resourceSchema.Dal.Teams();
                System.Data.DataSet ds = dbo.Teams_Select_One(SysId);
                Teams obj = null;
                if (GlobalTools.IsSafeDataSet(ds)) {
                    if ((ds.Tables[0].Rows.Count > 0)) {
                        obj = new Teams();
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
            resourceSchema.Dal.Teams dbo = null;
            try {
                dbo = new resourceSchema.Dal.Teams();
                System.Data.DataSet ds = dbo.Teams_Select_One(this.Sysid);
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
            resourceSchema.Dal.Teams dbo = null;
            try {
                dbo = new resourceSchema.Dal.Teams();
                dbo.Teams_Insert(this._teamstatussysid, this._teamtypesysid, this.Publicid, this.Path, this.Createdate, this.Lastmodifieddate, this.IsReadonly, this.Active);
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
            resourceSchema.Dal.Teams dbo = null;
            try {
                dbo = new resourceSchema.Dal.Teams();
                dbo.Teams_Delete(this.Sysid);
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
            resourceSchema.Dal.Teams dbo = null;
            try {
                dbo = new resourceSchema.Dal.Teams();
                dbo.Teams_Update(this.Sysid, this._teamstatussysid, this._teamtypesysid, this.Publicid, this.Path, this.Createdate, this.Lastmodifieddate, this.IsReadonly, this.Active);
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
