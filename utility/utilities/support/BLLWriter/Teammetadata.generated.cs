namespace resourceSchema.Bll {
    
    
    public partial class Teammetadata {
        
        private System.Nullable<int> _sysid;
        
        private System.Nullable<System.Guid> _publicid;
        
        private System.Nullable<int> _teamsysid;
        
        private string _keypath;
        
        private string _keyvalue;
        
        private System.Nullable<bool> _active;
        
        private Teams _teams;
        
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
        
        public virtual Teams Teams {
            get {
                if ((this._teams == null)) {
                    this._teams = resourceSchema.Bll.Teams.Load(this._teamsysid);
                }
                return this._teams;
            }
            set {
                _teams = value;
            }
        }
        
        private void Clean() {
            this.Sysid = null;
            this.Publicid = null;
            this._teamsysid = null;
            this.Keypath = string.Empty;
            this.Keyvalue = string.Empty;
            this.Active = null;
            this.Teams = null;
        }
        
        private void Fill(System.Data.DataRow dr) {
            this.Clean();
            if ((dr["SysId"] != System.DBNull.Value)) {
                this.Sysid = ((System.Nullable<int>)(dr["SysId"]));
            }
            if ((dr["PublicId"] != System.DBNull.Value)) {
                this.Publicid = ((System.Nullable<System.Guid>)(dr["PublicId"]));
            }
            if ((dr["TeamSysId"] != System.DBNull.Value)) {
                this._teamsysid = ((System.Nullable<int>)(dr["TeamSysId"]));
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
        
        public static TeammetadataCollection Select_TeamMetaDatas_By_TeamSysId(System.Nullable<int> TeamSysId) {
            resourceSchema.Dal.Teammetadata dbo = null;
            try {
                dbo = new resourceSchema.Dal.Teammetadata();
                System.Data.DataSet ds = dbo.Select_TeamMetaDatas_By_TeamSysId(TeamSysId);
                TeammetadataCollection collection = new TeammetadataCollection();
                if (GlobalTools.IsSafeDataSet(ds)) {
                    for (int i = 0; (i < ds.Tables[0].Rows.Count); i = (i + 1)) {
                        Teammetadata obj = new Teammetadata();
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
        
        public static TeammetadataCollection GetAll() {
            resourceSchema.Dal.Teammetadata dbo = null;
            try {
                dbo = new resourceSchema.Dal.Teammetadata();
                System.Data.DataSet ds = dbo.TeamMetaData_Select_All();
                TeammetadataCollection collection = new TeammetadataCollection();
                if (GlobalTools.IsSafeDataSet(ds)) {
                    for (int i = 0; (i < ds.Tables[0].Rows.Count); i = (i + 1)) {
                        Teammetadata obj = new Teammetadata();
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
        
        public static Teammetadata Load(System.Nullable<int> SysId) {
            resourceSchema.Dal.Teammetadata dbo = null;
            try {
                dbo = new resourceSchema.Dal.Teammetadata();
                System.Data.DataSet ds = dbo.TeamMetaData_Select_One(SysId);
                Teammetadata obj = null;
                if (GlobalTools.IsSafeDataSet(ds)) {
                    if ((ds.Tables[0].Rows.Count > 0)) {
                        obj = new Teammetadata();
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
            resourceSchema.Dal.Teammetadata dbo = null;
            try {
                dbo = new resourceSchema.Dal.Teammetadata();
                System.Data.DataSet ds = dbo.TeamMetaData_Select_One(this.Sysid);
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
            resourceSchema.Dal.Teammetadata dbo = null;
            try {
                dbo = new resourceSchema.Dal.Teammetadata();
                dbo.TeamMetaData_Insert(this.Publicid, this._teamsysid, this.Keypath, this.Keyvalue, this.Active);
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
            resourceSchema.Dal.Teammetadata dbo = null;
            try {
                dbo = new resourceSchema.Dal.Teammetadata();
                dbo.TeamMetaData_Delete(this.Sysid);
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
            resourceSchema.Dal.Teammetadata dbo = null;
            try {
                dbo = new resourceSchema.Dal.Teammetadata();
                dbo.TeamMetaData_Update(this.Sysid, this.Publicid, this._teamsysid, this.Keypath, this.Keyvalue, this.Active);
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
