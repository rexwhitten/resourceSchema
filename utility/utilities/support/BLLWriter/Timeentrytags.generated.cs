namespace resourceSchema.Bll {
    
    
    public partial class Timeentrytags {
        
        private System.Nullable<int> _sysid;
        
        private System.Nullable<int> _timeentrysysid;
        
        private string _tag;
        
        private System.Nullable<System.DateTime> _createdate;
        
        private System.Nullable<bool> _active;
        
        private Timeentrys _timeentrys;
        
        public virtual System.Nullable<int> Sysid {
            get {
                return _sysid;
            }
            set {
                _sysid = value;
            }
        }
        
        public virtual System.Nullable<int> Timeentrysysid {
            get {
                return _timeentrysysid;
            }
            set {
                _timeentrysysid = value;
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
        
        public virtual Timeentrys Timeentrys {
            get {
                if ((this._timeentrys == null)) {
                    this._timeentrys = resourceSchema.Bll.Timeentrys.Load(this._sysid);
                }
                return this._timeentrys;
            }
            set {
                _timeentrys = value;
            }
        }
        
        private void Clean() {
            this.Sysid = null;
            this.Timeentrysysid = null;
            this.Tag = string.Empty;
            this.Createdate = null;
            this.Active = null;
            this.Timeentrys = null;
        }
        
        private void Fill(System.Data.DataRow dr) {
            this.Clean();
            if ((dr["SysId"] != System.DBNull.Value)) {
                this.Sysid = ((System.Nullable<int>)(dr["SysId"]));
            }
            if ((dr["TimeEntrySysId"] != System.DBNull.Value)) {
                this.Timeentrysysid = ((System.Nullable<int>)(dr["TimeEntrySysId"]));
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
        
        public static TimeentrytagsCollection Select_TimeEntryTagss_By_SysId(System.Nullable<int> SysId) {
            resourceSchema.Dal.Timeentrytags dbo = null;
            try {
                dbo = new resourceSchema.Dal.Timeentrytags();
                System.Data.DataSet ds = dbo.Select_TimeEntryTagss_By_SysId(SysId);
                TimeentrytagsCollection collection = new TimeentrytagsCollection();
                if (GlobalTools.IsSafeDataSet(ds)) {
                    for (int i = 0; (i < ds.Tables[0].Rows.Count); i = (i + 1)) {
                        Timeentrytags obj = new Timeentrytags();
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
        
        public static TimeentrytagsCollection GetAll() {
            resourceSchema.Dal.Timeentrytags dbo = null;
            try {
                dbo = new resourceSchema.Dal.Timeentrytags();
                System.Data.DataSet ds = dbo.TimeEntryTags_Select_All();
                TimeentrytagsCollection collection = new TimeentrytagsCollection();
                if (GlobalTools.IsSafeDataSet(ds)) {
                    for (int i = 0; (i < ds.Tables[0].Rows.Count); i = (i + 1)) {
                        Timeentrytags obj = new Timeentrytags();
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
        
        public static Timeentrytags Load(System.Nullable<int> SysId) {
            resourceSchema.Dal.Timeentrytags dbo = null;
            try {
                dbo = new resourceSchema.Dal.Timeentrytags();
                System.Data.DataSet ds = dbo.TimeEntryTags_Select_One(SysId);
                Timeentrytags obj = null;
                if (GlobalTools.IsSafeDataSet(ds)) {
                    if ((ds.Tables[0].Rows.Count > 0)) {
                        obj = new Timeentrytags();
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
            resourceSchema.Dal.Timeentrytags dbo = null;
            try {
                dbo = new resourceSchema.Dal.Timeentrytags();
                System.Data.DataSet ds = dbo.TimeEntryTags_Select_One(this.Sysid);
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
            resourceSchema.Dal.Timeentrytags dbo = null;
            try {
                dbo = new resourceSchema.Dal.Timeentrytags();
                dbo.TimeEntryTags_Insert(this.Timeentrysysid, this.Tag, this.Createdate, this.Active);
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
            resourceSchema.Dal.Timeentrytags dbo = null;
            try {
                dbo = new resourceSchema.Dal.Timeentrytags();
                dbo.TimeEntryTags_Delete(this.Sysid);
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
            resourceSchema.Dal.Timeentrytags dbo = null;
            try {
                dbo = new resourceSchema.Dal.Timeentrytags();
                dbo.TimeEntryTags_Update(this.Sysid, this.Timeentrysysid, this.Tag, this.Createdate, this.Active);
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
