namespace resourceSchema.Bll {
    
    
    public partial class Tasktimeentrys {
        
        private System.Nullable<int> _sysid;
        
        private System.Nullable<System.Guid> _publicid;
        
        private string _path;
        
        private System.Nullable<int> _tasksysid;
        
        private System.Nullable<int> _timeentrysysid;
        
        private System.Nullable<System.DateTime> _createdate;
        
        private System.Nullable<bool> _active;
        
        private Tasks _tasks;
        
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
        
        public virtual System.Nullable<bool> Active {
            get {
                return _active;
            }
            set {
                _active = value;
            }
        }
        
        public virtual Tasks Tasks {
            get {
                if ((this._tasks == null)) {
                    this._tasks = resourceSchema.Bll.Tasks.Load(this._tasksysid);
                }
                return this._tasks;
            }
            set {
                _tasks = value;
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
            this.Path = string.Empty;
            this._tasksysid = null;
            this._timeentrysysid = null;
            this.Createdate = null;
            this.Active = null;
            this.Tasks = null;
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
            if ((dr["Path"] != System.DBNull.Value)) {
                this.Path = ((string)(dr["Path"]));
            }
            if ((dr["TaskSysId"] != System.DBNull.Value)) {
                this._tasksysid = ((System.Nullable<int>)(dr["TaskSysId"]));
            }
            if ((dr["TimeEntrysysId"] != System.DBNull.Value)) {
                this._timeentrysysid = ((System.Nullable<int>)(dr["TimeEntrysysId"]));
            }
            if ((dr["CreateDate"] != System.DBNull.Value)) {
                this.Createdate = ((System.Nullable<System.DateTime>)(dr["CreateDate"]));
            }
            if ((dr["Active"] != System.DBNull.Value)) {
                this.Active = ((System.Nullable<bool>)(dr["Active"]));
            }
        }
        
        public static TasktimeentrysCollection Select_TaskTimeEntryss_By_TaskSysId(System.Nullable<int> TaskSysId) {
            resourceSchema.Dal.Tasktimeentrys dbo = null;
            try {
                dbo = new resourceSchema.Dal.Tasktimeentrys();
                System.Data.DataSet ds = dbo.Select_TaskTimeEntryss_By_TaskSysId(TaskSysId);
                TasktimeentrysCollection collection = new TasktimeentrysCollection();
                if (GlobalTools.IsSafeDataSet(ds)) {
                    for (int i = 0; (i < ds.Tables[0].Rows.Count); i = (i + 1)) {
                        Tasktimeentrys obj = new Tasktimeentrys();
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
        
        public static TasktimeentrysCollection Select_TaskTimeEntryss_By_TimeEntrysysId(System.Nullable<int> TimeEntrysysId) {
            resourceSchema.Dal.Tasktimeentrys dbo = null;
            try {
                dbo = new resourceSchema.Dal.Tasktimeentrys();
                System.Data.DataSet ds = dbo.Select_TaskTimeEntryss_By_TimeEntrysysId(TimeEntrysysId);
                TasktimeentrysCollection collection = new TasktimeentrysCollection();
                if (GlobalTools.IsSafeDataSet(ds)) {
                    for (int i = 0; (i < ds.Tables[0].Rows.Count); i = (i + 1)) {
                        Tasktimeentrys obj = new Tasktimeentrys();
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
        
        public static TasktimeentrysCollection GetAll() {
            resourceSchema.Dal.Tasktimeentrys dbo = null;
            try {
                dbo = new resourceSchema.Dal.Tasktimeentrys();
                System.Data.DataSet ds = dbo.TaskTimeEntrys_Select_All();
                TasktimeentrysCollection collection = new TasktimeentrysCollection();
                if (GlobalTools.IsSafeDataSet(ds)) {
                    for (int i = 0; (i < ds.Tables[0].Rows.Count); i = (i + 1)) {
                        Tasktimeentrys obj = new Tasktimeentrys();
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
        
        public static Tasktimeentrys Load(System.Nullable<int> SysId) {
            resourceSchema.Dal.Tasktimeentrys dbo = null;
            try {
                dbo = new resourceSchema.Dal.Tasktimeentrys();
                System.Data.DataSet ds = dbo.TaskTimeEntrys_Select_One(SysId);
                Tasktimeentrys obj = null;
                if (GlobalTools.IsSafeDataSet(ds)) {
                    if ((ds.Tables[0].Rows.Count > 0)) {
                        obj = new Tasktimeentrys();
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
            resourceSchema.Dal.Tasktimeentrys dbo = null;
            try {
                dbo = new resourceSchema.Dal.Tasktimeentrys();
                System.Data.DataSet ds = dbo.TaskTimeEntrys_Select_One(this.Sysid);
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
            resourceSchema.Dal.Tasktimeentrys dbo = null;
            try {
                dbo = new resourceSchema.Dal.Tasktimeentrys();
                dbo.TaskTimeEntrys_Insert(this.Publicid, this.Path, this._tasksysid, this._timeentrysysid, this.Createdate, this.Active);
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
            resourceSchema.Dal.Tasktimeentrys dbo = null;
            try {
                dbo = new resourceSchema.Dal.Tasktimeentrys();
                dbo.TaskTimeEntrys_Delete(this.Sysid);
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
            resourceSchema.Dal.Tasktimeentrys dbo = null;
            try {
                dbo = new resourceSchema.Dal.Tasktimeentrys();
                dbo.TaskTimeEntrys_Update(this.Sysid, this.Publicid, this.Path, this._tasksysid, this._timeentrysysid, this.Createdate, this.Active);
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
