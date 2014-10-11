namespace resourceSchema.Bll {
    
    
    public partial class Timeentryattributes {
        
        private System.Nullable<int> _sysid;
        
        private System.Nullable<int> _timeentrysysid;
        
        private System.Nullable<System.DateTime> _createdate;
        
        private System.Nullable<System.DateTime> _lastmodifieddate;
        
        private System.Nullable<System.DateTime> _timeentrydate;
        
        private System.Nullable<decimal> _hours;
        
        private System.Nullable<bool> _billable;
        
        private string _note;
        
        private Timeentrys _timeentrys;
        
        public virtual System.Nullable<int> Sysid {
            get {
                return _sysid;
            }
            set {
                _sysid = value;
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
        
        public virtual System.Nullable<System.DateTime> Timeentrydate {
            get {
                return _timeentrydate;
            }
            set {
                _timeentrydate = value;
            }
        }
        
        public virtual System.Nullable<decimal> Hours {
            get {
                return _hours;
            }
            set {
                _hours = value;
            }
        }
        
        public virtual System.Nullable<bool> Billable {
            get {
                return _billable;
            }
            set {
                _billable = value;
            }
        }
        
        public virtual string Note {
            get {
                return _note;
            }
            set {
                _note = value;
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
            this._timeentrysysid = null;
            this.Createdate = null;
            this.Lastmodifieddate = null;
            this.Timeentrydate = null;
            this.Hours = null;
            this.Billable = null;
            this.Note = string.Empty;
            this.Timeentrys = null;
        }
        
        private void Fill(System.Data.DataRow dr) {
            this.Clean();
            if ((dr["SysId"] != System.DBNull.Value)) {
                this.Sysid = ((System.Nullable<int>)(dr["SysId"]));
            }
            if ((dr["TimeEntrySysId"] != System.DBNull.Value)) {
                this._timeentrysysid = ((System.Nullable<int>)(dr["TimeEntrySysId"]));
            }
            if ((dr["CreateDate"] != System.DBNull.Value)) {
                this.Createdate = ((System.Nullable<System.DateTime>)(dr["CreateDate"]));
            }
            if ((dr["LastModifiedDate"] != System.DBNull.Value)) {
                this.Lastmodifieddate = ((System.Nullable<System.DateTime>)(dr["LastModifiedDate"]));
            }
            if ((dr["TimeEntryDate"] != System.DBNull.Value)) {
                this.Timeentrydate = ((System.Nullable<System.DateTime>)(dr["TimeEntryDate"]));
            }
            if ((dr["Hours"] != System.DBNull.Value)) {
                this.Hours = ((System.Nullable<decimal>)(dr["Hours"]));
            }
            if ((dr["Billable"] != System.DBNull.Value)) {
                this.Billable = ((System.Nullable<bool>)(dr["Billable"]));
            }
            if ((dr["Note"] != System.DBNull.Value)) {
                this.Note = ((string)(dr["Note"]));
            }
        }
        
        public static TimeentryattributesCollection Select_TimeEntryAttributess_By_TimeEntrySysId(System.Nullable<int> TimeEntrySysId) {
            resourceSchema.Dal.Timeentryattributes dbo = null;
            try {
                dbo = new resourceSchema.Dal.Timeentryattributes();
                System.Data.DataSet ds = dbo.Select_TimeEntryAttributess_By_TimeEntrySysId(TimeEntrySysId);
                TimeentryattributesCollection collection = new TimeentryattributesCollection();
                if (GlobalTools.IsSafeDataSet(ds)) {
                    for (int i = 0; (i < ds.Tables[0].Rows.Count); i = (i + 1)) {
                        Timeentryattributes obj = new Timeentryattributes();
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
        
        public static TimeentryattributesCollection GetAll() {
            resourceSchema.Dal.Timeentryattributes dbo = null;
            try {
                dbo = new resourceSchema.Dal.Timeentryattributes();
                System.Data.DataSet ds = dbo.TimeEntryAttributes_Select_All();
                TimeentryattributesCollection collection = new TimeentryattributesCollection();
                if (GlobalTools.IsSafeDataSet(ds)) {
                    for (int i = 0; (i < ds.Tables[0].Rows.Count); i = (i + 1)) {
                        Timeentryattributes obj = new Timeentryattributes();
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
        
        public static Timeentryattributes Load(System.Nullable<int> SysId) {
            resourceSchema.Dal.Timeentryattributes dbo = null;
            try {
                dbo = new resourceSchema.Dal.Timeentryattributes();
                System.Data.DataSet ds = dbo.TimeEntryAttributes_Select_One(SysId);
                Timeentryattributes obj = null;
                if (GlobalTools.IsSafeDataSet(ds)) {
                    if ((ds.Tables[0].Rows.Count > 0)) {
                        obj = new Timeentryattributes();
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
            resourceSchema.Dal.Timeentryattributes dbo = null;
            try {
                dbo = new resourceSchema.Dal.Timeentryattributes();
                System.Data.DataSet ds = dbo.TimeEntryAttributes_Select_One(this.Sysid);
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
            resourceSchema.Dal.Timeentryattributes dbo = null;
            try {
                dbo = new resourceSchema.Dal.Timeentryattributes();
                dbo.TimeEntryAttributes_Insert(this._timeentrysysid, this.Createdate, this.Lastmodifieddate, this.Timeentrydate, this.Hours, this.Billable, this.Note);
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
            resourceSchema.Dal.Timeentryattributes dbo = null;
            try {
                dbo = new resourceSchema.Dal.Timeentryattributes();
                dbo.TimeEntryAttributes_Delete(this.Sysid);
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
            resourceSchema.Dal.Timeentryattributes dbo = null;
            try {
                dbo = new resourceSchema.Dal.Timeentryattributes();
                dbo.TimeEntryAttributes_Update(this.Sysid, this._timeentrysysid, this.Createdate, this.Lastmodifieddate, this.Timeentrydate, this.Hours, this.Billable, this.Note);
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
