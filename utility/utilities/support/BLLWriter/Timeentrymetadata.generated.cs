namespace resourceSchema.Bll {
    
    
    public partial class Timeentrymetadata {
        
        private System.Nullable<int> _sysid;
        
        private System.Nullable<System.Guid> _publicid;
        
        private System.Nullable<int> _timeentrysysid;
        
        private string _keypath;
        
        private string _keyvalue;
        
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
        
        public virtual Timeentrys Timeentrys {
            get {
                if ((this._timeentrys == null)) {
                    this._timeentrys = resourceSchema.Bll.Timeentrys.Load(this._timeentrysysid);
                }
                return this._timeentrys;
            }
            set {
                _timeentrys = value;
            }
        }
        
        private void Clean() {
            this.Sysid = null;
            this.Publicid = null;
            this._timeentrysysid = null;
            this.Keypath = string.Empty;
            this.Keyvalue = string.Empty;
            this.Active = null;
            this.Timeentrys = null;
        }
        
        private void Fill(System.Data.DataRow dr) {
            this.Clean();
            if ((dr["SysId"] != System.DBNull.Value)) {
                this.Sysid = ((System.Nullable<int>)(dr["SysId"]));
            }
            if ((dr["PublicId"] != System.DBNull.Value)) {
                this.Publicid = ((System.Nullable<System.Guid>)(dr["PublicId"]));
            }
            if ((dr["TimeEntrySysId"] != System.DBNull.Value)) {
                this._timeentrysysid = ((System.Nullable<int>)(dr["TimeEntrySysId"]));
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
        
        public static TimeentrymetadataCollection Select_TimeEntryMetaDatas_By_TimeEntrySysId(System.Nullable<int> TimeEntrySysId) {
            resourceSchema.Dal.Timeentrymetadata dbo = null;
            try {
                dbo = new resourceSchema.Dal.Timeentrymetadata();
                System.Data.DataSet ds = dbo.Select_TimeEntryMetaDatas_By_TimeEntrySysId(TimeEntrySysId);
                TimeentrymetadataCollection collection = new TimeentrymetadataCollection();
                if (GlobalTools.IsSafeDataSet(ds)) {
                    for (int i = 0; (i < ds.Tables[0].Rows.Count); i = (i + 1)) {
                        Timeentrymetadata obj = new Timeentrymetadata();
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
        
        public static TimeentrymetadataCollection GetAll() {
            resourceSchema.Dal.Timeentrymetadata dbo = null;
            try {
                dbo = new resourceSchema.Dal.Timeentrymetadata();
                System.Data.DataSet ds = dbo.TimeEntryMetaData_Select_All();
                TimeentrymetadataCollection collection = new TimeentrymetadataCollection();
                if (GlobalTools.IsSafeDataSet(ds)) {
                    for (int i = 0; (i < ds.Tables[0].Rows.Count); i = (i + 1)) {
                        Timeentrymetadata obj = new Timeentrymetadata();
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
        
        public static Timeentrymetadata Load(System.Nullable<int> SysId) {
            resourceSchema.Dal.Timeentrymetadata dbo = null;
            try {
                dbo = new resourceSchema.Dal.Timeentrymetadata();
                System.Data.DataSet ds = dbo.TimeEntryMetaData_Select_One(SysId);
                Timeentrymetadata obj = null;
                if (GlobalTools.IsSafeDataSet(ds)) {
                    if ((ds.Tables[0].Rows.Count > 0)) {
                        obj = new Timeentrymetadata();
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
            resourceSchema.Dal.Timeentrymetadata dbo = null;
            try {
                dbo = new resourceSchema.Dal.Timeentrymetadata();
                System.Data.DataSet ds = dbo.TimeEntryMetaData_Select_One(this.Sysid);
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
            resourceSchema.Dal.Timeentrymetadata dbo = null;
            try {
                dbo = new resourceSchema.Dal.Timeentrymetadata();
                dbo.TimeEntryMetaData_Insert(this.Publicid, this._timeentrysysid, this.Keypath, this.Keyvalue, this.Active);
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
            resourceSchema.Dal.Timeentrymetadata dbo = null;
            try {
                dbo = new resourceSchema.Dal.Timeentrymetadata();
                dbo.TimeEntryMetaData_Delete(this.Sysid);
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
            resourceSchema.Dal.Timeentrymetadata dbo = null;
            try {
                dbo = new resourceSchema.Dal.Timeentrymetadata();
                dbo.TimeEntryMetaData_Update(this.Sysid, this.Publicid, this._timeentrysysid, this.Keypath, this.Keyvalue, this.Active);
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
