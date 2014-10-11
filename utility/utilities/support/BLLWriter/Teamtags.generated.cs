namespace resourceSchema.Bll {
    
    
    public partial class Teamtags {
        
        private System.Nullable<int> _sysid;
        
        private System.Nullable<int> _teamsysid;
        
        private string _tag;
        
        private System.Nullable<System.DateTime> _createdate;
        
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
        
        public virtual System.Nullable<int> Teamsysid {
            get {
                return _teamsysid;
            }
            set {
                _teamsysid = value;
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
        
        public virtual Teams Teams {
            get {
                if ((this._teams == null)) {
                    this._teams = resourceSchema.Bll.Teams.Load(this._sysid);
                }
                return this._teams;
            }
            set {
                _teams = value;
            }
        }
        
        private void Clean() {
            this.Sysid = null;
            this.Teamsysid = null;
            this.Tag = string.Empty;
            this.Createdate = null;
            this.Active = null;
            this.Teams = null;
        }
        
        private void Fill(System.Data.DataRow dr) {
            this.Clean();
            if ((dr["SysId"] != System.DBNull.Value)) {
                this.Sysid = ((System.Nullable<int>)(dr["SysId"]));
            }
            if ((dr["TeamSysId"] != System.DBNull.Value)) {
                this.Teamsysid = ((System.Nullable<int>)(dr["TeamSysId"]));
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
        
        public static TeamtagsCollection Select_TeamTagss_By_SysId(System.Nullable<int> SysId) {
            resourceSchema.Dal.Teamtags dbo = null;
            try {
                dbo = new resourceSchema.Dal.Teamtags();
                System.Data.DataSet ds = dbo.Select_TeamTagss_By_SysId(SysId);
                TeamtagsCollection collection = new TeamtagsCollection();
                if (GlobalTools.IsSafeDataSet(ds)) {
                    for (int i = 0; (i < ds.Tables[0].Rows.Count); i = (i + 1)) {
                        Teamtags obj = new Teamtags();
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
        
        public static TeamtagsCollection GetAll() {
            resourceSchema.Dal.Teamtags dbo = null;
            try {
                dbo = new resourceSchema.Dal.Teamtags();
                System.Data.DataSet ds = dbo.TeamTags_Select_All();
                TeamtagsCollection collection = new TeamtagsCollection();
                if (GlobalTools.IsSafeDataSet(ds)) {
                    for (int i = 0; (i < ds.Tables[0].Rows.Count); i = (i + 1)) {
                        Teamtags obj = new Teamtags();
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
        
        public static Teamtags Load(System.Nullable<int> SysId) {
            resourceSchema.Dal.Teamtags dbo = null;
            try {
                dbo = new resourceSchema.Dal.Teamtags();
                System.Data.DataSet ds = dbo.TeamTags_Select_One(SysId);
                Teamtags obj = null;
                if (GlobalTools.IsSafeDataSet(ds)) {
                    if ((ds.Tables[0].Rows.Count > 0)) {
                        obj = new Teamtags();
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
            resourceSchema.Dal.Teamtags dbo = null;
            try {
                dbo = new resourceSchema.Dal.Teamtags();
                System.Data.DataSet ds = dbo.TeamTags_Select_One(this.Sysid);
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
            resourceSchema.Dal.Teamtags dbo = null;
            try {
                dbo = new resourceSchema.Dal.Teamtags();
                dbo.TeamTags_Insert(this.Teamsysid, this.Tag, this.Createdate, this.Active);
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
            resourceSchema.Dal.Teamtags dbo = null;
            try {
                dbo = new resourceSchema.Dal.Teamtags();
                dbo.TeamTags_Delete(this.Sysid);
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
            resourceSchema.Dal.Teamtags dbo = null;
            try {
                dbo = new resourceSchema.Dal.Teamtags();
                dbo.TeamTags_Update(this.Sysid, this.Teamsysid, this.Tag, this.Createdate, this.Active);
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
