namespace resourceSchema.Bll {
    
    
    public partial class Areatags {
        
        private System.Nullable<int> _sysid;
        
        private System.Nullable<int> _areasysid;
        
        private string _tag;
        
        private System.Nullable<System.DateTime> _createdate;
        
        private System.Nullable<bool> _active;
        
        private Areas _areas;
        
        public virtual System.Nullable<int> Sysid {
            get {
                return _sysid;
            }
            set {
                _sysid = value;
            }
        }
        
        public virtual System.Nullable<int> Areasysid {
            get {
                return _areasysid;
            }
            set {
                _areasysid = value;
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
        
        public virtual Areas Areas {
            get {
                if ((this._areas == null)) {
                    this._areas = resourceSchema.Bll.Areas.Load(this._sysid);
                }
                return this._areas;
            }
            set {
                _areas = value;
            }
        }
        
        private void Clean() {
            this.Sysid = null;
            this.Areasysid = null;
            this.Tag = string.Empty;
            this.Createdate = null;
            this.Active = null;
            this.Areas = null;
        }
        
        private void Fill(System.Data.DataRow dr) {
            this.Clean();
            if ((dr["SysId"] != System.DBNull.Value)) {
                this.Sysid = ((System.Nullable<int>)(dr["SysId"]));
            }
            if ((dr["AreaSysId"] != System.DBNull.Value)) {
                this.Areasysid = ((System.Nullable<int>)(dr["AreaSysId"]));
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
        
        public static AreatagsCollection Select_AreaTagss_By_SysId(System.Nullable<int> SysId) {
            resourceSchema.Dal.Areatags dbo = null;
            try {
                dbo = new resourceSchema.Dal.Areatags();
                System.Data.DataSet ds = dbo.Select_AreaTagss_By_SysId(SysId);
                AreatagsCollection collection = new AreatagsCollection();
                if (GlobalTools.IsSafeDataSet(ds)) {
                    for (int i = 0; (i < ds.Tables[0].Rows.Count); i = (i + 1)) {
                        Areatags obj = new Areatags();
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
        
        public static AreatagsCollection GetAll() {
            resourceSchema.Dal.Areatags dbo = null;
            try {
                dbo = new resourceSchema.Dal.Areatags();
                System.Data.DataSet ds = dbo.AreaTags_Select_All();
                AreatagsCollection collection = new AreatagsCollection();
                if (GlobalTools.IsSafeDataSet(ds)) {
                    for (int i = 0; (i < ds.Tables[0].Rows.Count); i = (i + 1)) {
                        Areatags obj = new Areatags();
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
        
        public static Areatags Load(System.Nullable<int> SysId) {
            resourceSchema.Dal.Areatags dbo = null;
            try {
                dbo = new resourceSchema.Dal.Areatags();
                System.Data.DataSet ds = dbo.AreaTags_Select_One(SysId);
                Areatags obj = null;
                if (GlobalTools.IsSafeDataSet(ds)) {
                    if ((ds.Tables[0].Rows.Count > 0)) {
                        obj = new Areatags();
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
            resourceSchema.Dal.Areatags dbo = null;
            try {
                dbo = new resourceSchema.Dal.Areatags();
                System.Data.DataSet ds = dbo.AreaTags_Select_One(this.Sysid);
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
            resourceSchema.Dal.Areatags dbo = null;
            try {
                dbo = new resourceSchema.Dal.Areatags();
                dbo.AreaTags_Insert(this.Areasysid, this.Tag, this.Createdate, this.Active);
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
            resourceSchema.Dal.Areatags dbo = null;
            try {
                dbo = new resourceSchema.Dal.Areatags();
                dbo.AreaTags_Delete(this.Sysid);
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
            resourceSchema.Dal.Areatags dbo = null;
            try {
                dbo = new resourceSchema.Dal.Areatags();
                dbo.AreaTags_Update(this.Sysid, this.Areasysid, this.Tag, this.Createdate, this.Active);
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
