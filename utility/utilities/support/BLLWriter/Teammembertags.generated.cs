namespace resourceSchema.Bll {
    
    
    public partial class Teammembertags {
        
        private System.Nullable<int> _sysid;
        
        private System.Nullable<int> _teammembersysid;
        
        private string _tag;
        
        private System.Nullable<System.DateTime> _createdate;
        
        private System.Nullable<bool> _active;
        
        private Teammembers _teammembers;
        
        public virtual System.Nullable<int> Sysid {
            get {
                return _sysid;
            }
            set {
                _sysid = value;
            }
        }
        
        public virtual System.Nullable<int> Teammembersysid {
            get {
                return _teammembersysid;
            }
            set {
                _teammembersysid = value;
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
        
        public virtual Teammembers Teammembers {
            get {
                if ((this._teammembers == null)) {
                    this._teammembers = resourceSchema.Bll.Teammembers.Load(this._sysid);
                }
                return this._teammembers;
            }
            set {
                _teammembers = value;
            }
        }
        
        private void Clean() {
            this.Sysid = null;
            this.Teammembersysid = null;
            this.Tag = string.Empty;
            this.Createdate = null;
            this.Active = null;
            this.Teammembers = null;
        }
        
        private void Fill(System.Data.DataRow dr) {
            this.Clean();
            if ((dr["SysId"] != System.DBNull.Value)) {
                this.Sysid = ((System.Nullable<int>)(dr["SysId"]));
            }
            if ((dr["TeamMemberSysId"] != System.DBNull.Value)) {
                this.Teammembersysid = ((System.Nullable<int>)(dr["TeamMemberSysId"]));
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
        
        public static TeammembertagsCollection Select_TeamMemberTagss_By_SysId(System.Nullable<int> SysId) {
            resourceSchema.Dal.Teammembertags dbo = null;
            try {
                dbo = new resourceSchema.Dal.Teammembertags();
                System.Data.DataSet ds = dbo.Select_TeamMemberTagss_By_SysId(SysId);
                TeammembertagsCollection collection = new TeammembertagsCollection();
                if (GlobalTools.IsSafeDataSet(ds)) {
                    for (int i = 0; (i < ds.Tables[0].Rows.Count); i = (i + 1)) {
                        Teammembertags obj = new Teammembertags();
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
        
        public static TeammembertagsCollection GetAll() {
            resourceSchema.Dal.Teammembertags dbo = null;
            try {
                dbo = new resourceSchema.Dal.Teammembertags();
                System.Data.DataSet ds = dbo.TeamMemberTags_Select_All();
                TeammembertagsCollection collection = new TeammembertagsCollection();
                if (GlobalTools.IsSafeDataSet(ds)) {
                    for (int i = 0; (i < ds.Tables[0].Rows.Count); i = (i + 1)) {
                        Teammembertags obj = new Teammembertags();
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
        
        public static Teammembertags Load(System.Nullable<int> SysId) {
            resourceSchema.Dal.Teammembertags dbo = null;
            try {
                dbo = new resourceSchema.Dal.Teammembertags();
                System.Data.DataSet ds = dbo.TeamMemberTags_Select_One(SysId);
                Teammembertags obj = null;
                if (GlobalTools.IsSafeDataSet(ds)) {
                    if ((ds.Tables[0].Rows.Count > 0)) {
                        obj = new Teammembertags();
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
            resourceSchema.Dal.Teammembertags dbo = null;
            try {
                dbo = new resourceSchema.Dal.Teammembertags();
                System.Data.DataSet ds = dbo.TeamMemberTags_Select_One(this.Sysid);
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
            resourceSchema.Dal.Teammembertags dbo = null;
            try {
                dbo = new resourceSchema.Dal.Teammembertags();
                dbo.TeamMemberTags_Insert(this.Teammembersysid, this.Tag, this.Createdate, this.Active);
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
            resourceSchema.Dal.Teammembertags dbo = null;
            try {
                dbo = new resourceSchema.Dal.Teammembertags();
                dbo.TeamMemberTags_Delete(this.Sysid);
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
            resourceSchema.Dal.Teammembertags dbo = null;
            try {
                dbo = new resourceSchema.Dal.Teammembertags();
                dbo.TeamMemberTags_Update(this.Sysid, this.Teammembersysid, this.Tag, this.Createdate, this.Active);
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
