namespace resourceSchema.Bll {
    
    
    public partial class Timeentrylinks {
        
        private System.Nullable<int> _sysid;
        
        private System.Nullable<System.Guid> _publicid;
        
        private System.Nullable<int> _parenttimeentrysysid;
        
        private System.Nullable<int> _childtimeentrysysid;
        
        private string _linkpath;
        
        private System.Nullable<System.DateTime> _createdate;
        
        private System.Nullable<System.DateTime> _lastmodifieddate;
        
        private System.Nullable<bool> _active;
        
        private Timeentrys _timeentrys;
        
        private Timeentrys _timeentrys2;
        
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
        
        public virtual Timeentrys Timeentrys {
            get {
                if ((this._timeentrys == null)) {
                    this._timeentrys = resourceSchema.Bll.Timeentrys.Load(this._parenttimeentrysysid);
                }
                return this._timeentrys;
            }
            set {
                _timeentrys = value;
            }
        }
        
        public virtual Timeentrys Timeentrys2 {
            get {
                if ((this._timeentrys2 == null)) {
                    this._timeentrys2 = resourceSchema.Bll.Timeentrys.Load(this._childtimeentrysysid);
                }
                return this._timeentrys2;
            }
            set {
                _timeentrys2 = value;
            }
        }
        
        private void Clean() {
            this.Sysid = null;
            this.Publicid = null;
            this._parenttimeentrysysid = null;
            this._childtimeentrysysid = null;
            this.Linkpath = string.Empty;
            this.Createdate = null;
            this.Lastmodifieddate = null;
            this.Active = null;
            this.Timeentrys = null;
            this.Timeentrys2 = null;
        }
        
        private void Fill(System.Data.DataRow dr) {
            this.Clean();
            if ((dr["SysId"] != System.DBNull.Value)) {
                this.Sysid = ((System.Nullable<int>)(dr["SysId"]));
            }
            if ((dr["PublicId"] != System.DBNull.Value)) {
                this.Publicid = ((System.Nullable<System.Guid>)(dr["PublicId"]));
            }
            if ((dr["ParentTimeEntrySysId"] != System.DBNull.Value)) {
                this._parenttimeentrysysid = ((System.Nullable<int>)(dr["ParentTimeEntrySysId"]));
            }
            if ((dr["ChildTimeEntrySysId"] != System.DBNull.Value)) {
                this._childtimeentrysysid = ((System.Nullable<int>)(dr["ChildTimeEntrySysId"]));
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
        
        public static TimeentrylinksCollection Select_TimeEntryLinkss_By_ParentTimeEntrySysId(System.Nullable<int> ParentTimeEntrySysId) {
            resourceSchema.Dal.Timeentrylinks dbo = null;
            try {
                dbo = new resourceSchema.Dal.Timeentrylinks();
                System.Data.DataSet ds = dbo.Select_TimeEntryLinkss_By_ParentTimeEntrySysId(ParentTimeEntrySysId);
                TimeentrylinksCollection collection = new TimeentrylinksCollection();
                if (GlobalTools.IsSafeDataSet(ds)) {
                    for (int i = 0; (i < ds.Tables[0].Rows.Count); i = (i + 1)) {
                        Timeentrylinks obj = new Timeentrylinks();
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
        
        public static TimeentrylinksCollection Select_TimeEntryLinkss_By_ChildTimeEntrySysId(System.Nullable<int> ChildTimeEntrySysId) {
            resourceSchema.Dal.Timeentrylinks dbo = null;
            try {
                dbo = new resourceSchema.Dal.Timeentrylinks();
                System.Data.DataSet ds = dbo.Select_TimeEntryLinkss_By_ChildTimeEntrySysId(ChildTimeEntrySysId);
                TimeentrylinksCollection collection = new TimeentrylinksCollection();
                if (GlobalTools.IsSafeDataSet(ds)) {
                    for (int i = 0; (i < ds.Tables[0].Rows.Count); i = (i + 1)) {
                        Timeentrylinks obj = new Timeentrylinks();
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
        
        public static TimeentrylinksCollection GetAll() {
            resourceSchema.Dal.Timeentrylinks dbo = null;
            try {
                dbo = new resourceSchema.Dal.Timeentrylinks();
                System.Data.DataSet ds = dbo.TimeEntryLinks_Select_All();
                TimeentrylinksCollection collection = new TimeentrylinksCollection();
                if (GlobalTools.IsSafeDataSet(ds)) {
                    for (int i = 0; (i < ds.Tables[0].Rows.Count); i = (i + 1)) {
                        Timeentrylinks obj = new Timeentrylinks();
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
        
        public static Timeentrylinks Load(System.Nullable<int> SysId) {
            resourceSchema.Dal.Timeentrylinks dbo = null;
            try {
                dbo = new resourceSchema.Dal.Timeentrylinks();
                System.Data.DataSet ds = dbo.TimeEntryLinks_Select_One(SysId);
                Timeentrylinks obj = null;
                if (GlobalTools.IsSafeDataSet(ds)) {
                    if ((ds.Tables[0].Rows.Count > 0)) {
                        obj = new Timeentrylinks();
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
            resourceSchema.Dal.Timeentrylinks dbo = null;
            try {
                dbo = new resourceSchema.Dal.Timeentrylinks();
                System.Data.DataSet ds = dbo.TimeEntryLinks_Select_One(this.Sysid);
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
            resourceSchema.Dal.Timeentrylinks dbo = null;
            try {
                dbo = new resourceSchema.Dal.Timeentrylinks();
                dbo.TimeEntryLinks_Insert(this.Publicid, this._parenttimeentrysysid, this._childtimeentrysysid, this.Linkpath, this.Createdate, this.Lastmodifieddate, this.Active);
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
            resourceSchema.Dal.Timeentrylinks dbo = null;
            try {
                dbo = new resourceSchema.Dal.Timeentrylinks();
                dbo.TimeEntryLinks_Delete(this.Sysid);
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
            resourceSchema.Dal.Timeentrylinks dbo = null;
            try {
                dbo = new resourceSchema.Dal.Timeentrylinks();
                dbo.TimeEntryLinks_Update(this.Sysid, this.Publicid, this._parenttimeentrysysid, this._childtimeentrysysid, this.Linkpath, this.Createdate, this.Lastmodifieddate, this.Active);
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
