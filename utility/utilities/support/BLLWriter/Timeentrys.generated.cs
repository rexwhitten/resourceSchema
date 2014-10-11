namespace resourceSchema.Bll {
    
    
    public partial class Timeentrys {
        
        private System.Nullable<int> _sysid;
        
        private System.Nullable<int> _timeentrystatussysid;
        
        private System.Nullable<int> _timeentrytypesysid;
        
        private System.Nullable<System.Guid> _publicid;
        
        private string _path;
        
        private System.Nullable<System.DateTime> _createdate;
        
        private System.Nullable<System.DateTime> _lastmodifieddate;
        
        private System.Nullable<bool> _isReadonly;
        
        private System.Nullable<bool> _active;
        
        private TasktimeentrysCollection _tasktimeentrysCollection;
        
        private TimeentryattributesCollection _timeentryattributesCollection;
        
        private TimeentrylinksCollection _timeentrylinksCollection;
        
        private TimeentrylinksCollection _timeentrylinksCollection2;
        
        private TimeentrymetadataCollection _timeentrymetadataCollection;
        
        private Timeentrystatus _timeentrystatus;
        
        private Timeentrytypes _timeentrytypes;
        
        private TimeentrytagsCollection _timeentrytagsCollection;
        
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
        
        public virtual TasktimeentrysCollection TasktimeentrysCollection {
            get {
                if ((this._tasktimeentrysCollection == null)) {
                    _tasktimeentrysCollection = resourceSchema.Bll.Tasktimeentrys.Select_TaskTimeEntryss_By_TimeEntrysysId(this.Sysid);
                }
                return this._tasktimeentrysCollection;
            }
        }
        
        public virtual TimeentryattributesCollection TimeentryattributesCollection {
            get {
                if ((this._timeentryattributesCollection == null)) {
                    _timeentryattributesCollection = resourceSchema.Bll.Timeentryattributes.Select_TimeEntryAttributess_By_TimeEntrySysId(this.Sysid);
                }
                return this._timeentryattributesCollection;
            }
        }
        
        public virtual TimeentrylinksCollection TimeentrylinksCollection {
            get {
                if ((this._timeentrylinksCollection == null)) {
                    _timeentrylinksCollection = resourceSchema.Bll.Timeentrylinks.Select_TimeEntryLinkss_By_ParentTimeEntrySysId(this.Sysid);
                }
                return this._timeentrylinksCollection;
            }
        }
        
        public virtual TimeentrylinksCollection TimeentrylinksCollection2 {
            get {
                if ((this._timeentrylinksCollection2 == null)) {
                    _timeentrylinksCollection2 = resourceSchema.Bll.Timeentrylinks.Select_TimeEntryLinkss_By_ChildTimeEntrySysId(this.Sysid);
                }
                return this._timeentrylinksCollection2;
            }
        }
        
        public virtual TimeentrymetadataCollection TimeentrymetadataCollection {
            get {
                if ((this._timeentrymetadataCollection == null)) {
                    _timeentrymetadataCollection = resourceSchema.Bll.Timeentrymetadata.Select_TimeEntryMetaDatas_By_TimeEntrySysId(this.Sysid);
                }
                return this._timeentrymetadataCollection;
            }
        }
        
        public virtual Timeentrystatus Timeentrystatus {
            get {
                if ((this._timeentrystatus == null)) {
                    this._timeentrystatus = resourceSchema.Bll.Timeentrystatus.Load(this._timeentrystatussysid);
                }
                return this._timeentrystatus;
            }
            set {
                _timeentrystatus = value;
            }
        }
        
        public virtual Timeentrytypes Timeentrytypes {
            get {
                if ((this._timeentrytypes == null)) {
                    this._timeentrytypes = resourceSchema.Bll.Timeentrytypes.Load(this._timeentrytypesysid);
                }
                return this._timeentrytypes;
            }
            set {
                _timeentrytypes = value;
            }
        }
        
        public virtual TimeentrytagsCollection TimeentrytagsCollection {
            get {
                if ((this._timeentrytagsCollection == null)) {
                    _timeentrytagsCollection = resourceSchema.Bll.Timeentrytags.Select_TimeEntryTagss_By_SysId(this.Sysid);
                }
                return this._timeentrytagsCollection;
            }
        }
        
        private void Clean() {
            this.Sysid = null;
            this._timeentrystatussysid = null;
            this._timeentrytypesysid = null;
            this.Publicid = null;
            this.Path = string.Empty;
            this.Createdate = null;
            this.Lastmodifieddate = null;
            this.IsReadonly = null;
            this.Active = null;
            this._tasktimeentrysCollection = null;
            this._timeentryattributesCollection = null;
            this._timeentrylinksCollection = null;
            this._timeentrylinksCollection2 = null;
            this._timeentrymetadataCollection = null;
            this.Timeentrystatus = null;
            this.Timeentrytypes = null;
            this._timeentrytagsCollection = null;
        }
        
        private void Fill(System.Data.DataRow dr) {
            this.Clean();
            if ((dr["SysId"] != System.DBNull.Value)) {
                this.Sysid = ((System.Nullable<int>)(dr["SysId"]));
            }
            if ((dr["TimeEntryStatusSysId"] != System.DBNull.Value)) {
                this._timeentrystatussysid = ((System.Nullable<int>)(dr["TimeEntryStatusSysId"]));
            }
            if ((dr["TimeEntryTypeSysId"] != System.DBNull.Value)) {
                this._timeentrytypesysid = ((System.Nullable<int>)(dr["TimeEntryTypeSysId"]));
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
        
        public static TimeentrysCollection Select_TimeEntryss_By_TimeEntryStatusSysId(System.Nullable<int> TimeEntryStatusSysId) {
            resourceSchema.Dal.Timeentrys dbo = null;
            try {
                dbo = new resourceSchema.Dal.Timeentrys();
                System.Data.DataSet ds = dbo.Select_TimeEntryss_By_TimeEntryStatusSysId(TimeEntryStatusSysId);
                TimeentrysCollection collection = new TimeentrysCollection();
                if (GlobalTools.IsSafeDataSet(ds)) {
                    for (int i = 0; (i < ds.Tables[0].Rows.Count); i = (i + 1)) {
                        Timeentrys obj = new Timeentrys();
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
        
        public static TimeentrysCollection Select_TimeEntryss_By_TimeEntryTypeSysId(System.Nullable<int> TimeEntryTypeSysId) {
            resourceSchema.Dal.Timeentrys dbo = null;
            try {
                dbo = new resourceSchema.Dal.Timeentrys();
                System.Data.DataSet ds = dbo.Select_TimeEntryss_By_TimeEntryTypeSysId(TimeEntryTypeSysId);
                TimeentrysCollection collection = new TimeentrysCollection();
                if (GlobalTools.IsSafeDataSet(ds)) {
                    for (int i = 0; (i < ds.Tables[0].Rows.Count); i = (i + 1)) {
                        Timeentrys obj = new Timeentrys();
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
        
        public static TimeentrysCollection GetAll() {
            resourceSchema.Dal.Timeentrys dbo = null;
            try {
                dbo = new resourceSchema.Dal.Timeentrys();
                System.Data.DataSet ds = dbo.TimeEntrys_Select_All();
                TimeentrysCollection collection = new TimeentrysCollection();
                if (GlobalTools.IsSafeDataSet(ds)) {
                    for (int i = 0; (i < ds.Tables[0].Rows.Count); i = (i + 1)) {
                        Timeentrys obj = new Timeentrys();
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
        
        public static Timeentrys Load(System.Nullable<int> SysId) {
            resourceSchema.Dal.Timeentrys dbo = null;
            try {
                dbo = new resourceSchema.Dal.Timeentrys();
                System.Data.DataSet ds = dbo.TimeEntrys_Select_One(SysId);
                Timeentrys obj = null;
                if (GlobalTools.IsSafeDataSet(ds)) {
                    if ((ds.Tables[0].Rows.Count > 0)) {
                        obj = new Timeentrys();
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
            resourceSchema.Dal.Timeentrys dbo = null;
            try {
                dbo = new resourceSchema.Dal.Timeentrys();
                System.Data.DataSet ds = dbo.TimeEntrys_Select_One(this.Sysid);
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
            resourceSchema.Dal.Timeentrys dbo = null;
            try {
                dbo = new resourceSchema.Dal.Timeentrys();
                dbo.TimeEntrys_Insert(this._timeentrystatussysid, this._timeentrytypesysid, this.Publicid, this.Path, this.Createdate, this.Lastmodifieddate, this.IsReadonly, this.Active);
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
            resourceSchema.Dal.Timeentrys dbo = null;
            try {
                dbo = new resourceSchema.Dal.Timeentrys();
                dbo.TimeEntrys_Delete(this.Sysid);
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
            resourceSchema.Dal.Timeentrys dbo = null;
            try {
                dbo = new resourceSchema.Dal.Timeentrys();
                dbo.TimeEntrys_Update(this.Sysid, this._timeentrystatussysid, this._timeentrytypesysid, this.Publicid, this.Path, this.Createdate, this.Lastmodifieddate, this.IsReadonly, this.Active);
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
