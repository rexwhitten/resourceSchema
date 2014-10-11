namespace resourceSchema.Bll {
    
    
    public partial class Tasks {
        
        private System.Nullable<int> _sysid;
        
        private System.Nullable<int> _taskstatussysid;
        
        private System.Nullable<int> _tasktypesysid;
        
        private System.Nullable<System.Guid> _publicid;
        
        private string _path;
        
        private System.Nullable<System.DateTime> _createdate;
        
        private System.Nullable<System.DateTime> _lastmodifieddate;
        
        private System.Nullable<bool> _isReadonly;
        
        private System.Nullable<bool> _active;
        
        private TaskareasCollection _taskareasCollection;
        
        private TaskiterationsCollection _taskiterationsCollection;
        
        private TasklinksCollection _tasklinksCollection;
        
        private TasklinksCollection _tasklinksCollection2;
        
        private TaskmetadataCollection _taskmetadataCollection;
        
        private Taskstatus _taskstatus;
        
        private Tasktypes _tasktypes;
        
        private TasktagsCollection _tasktagsCollection;
        
        private TaskteammembersCollection _taskteammembersCollection;
        
        private TasktimeentrysCollection _tasktimeentrysCollection;
        
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
        
        public virtual TaskareasCollection TaskareasCollection {
            get {
                if ((this._taskareasCollection == null)) {
                    _taskareasCollection = resourceSchema.Bll.Taskareas.Select_TaskAreass_By_TaskSysId(this.Sysid);
                }
                return this._taskareasCollection;
            }
        }
        
        public virtual TaskiterationsCollection TaskiterationsCollection {
            get {
                if ((this._taskiterationsCollection == null)) {
                    _taskiterationsCollection = resourceSchema.Bll.Taskiterations.Select_TaskIterationss_By_TaskSysId(this.Sysid);
                }
                return this._taskiterationsCollection;
            }
        }
        
        public virtual TasklinksCollection TasklinksCollection {
            get {
                if ((this._tasklinksCollection == null)) {
                    _tasklinksCollection = resourceSchema.Bll.Tasklinks.Select_TaskLinkss_By_ParentTaskSysId(this.Sysid);
                }
                return this._tasklinksCollection;
            }
        }
        
        public virtual TasklinksCollection TasklinksCollection2 {
            get {
                if ((this._tasklinksCollection2 == null)) {
                    _tasklinksCollection2 = resourceSchema.Bll.Tasklinks.Select_TaskLinkss_By_ChildTaskSysId(this.Sysid);
                }
                return this._tasklinksCollection2;
            }
        }
        
        public virtual TaskmetadataCollection TaskmetadataCollection {
            get {
                if ((this._taskmetadataCollection == null)) {
                    _taskmetadataCollection = resourceSchema.Bll.Taskmetadata.Select_TaskMetaDatas_By_TaskSysId(this.Sysid);
                }
                return this._taskmetadataCollection;
            }
        }
        
        public virtual Taskstatus Taskstatus {
            get {
                if ((this._taskstatus == null)) {
                    this._taskstatus = resourceSchema.Bll.Taskstatus.Load(this._taskstatussysid);
                }
                return this._taskstatus;
            }
            set {
                _taskstatus = value;
            }
        }
        
        public virtual Tasktypes Tasktypes {
            get {
                if ((this._tasktypes == null)) {
                    this._tasktypes = resourceSchema.Bll.Tasktypes.Load(this._tasktypesysid);
                }
                return this._tasktypes;
            }
            set {
                _tasktypes = value;
            }
        }
        
        public virtual TasktagsCollection TasktagsCollection {
            get {
                if ((this._tasktagsCollection == null)) {
                    _tasktagsCollection = resourceSchema.Bll.Tasktags.Select_TaskTagss_By_SysId(this.Sysid);
                }
                return this._tasktagsCollection;
            }
        }
        
        public virtual TaskteammembersCollection TaskteammembersCollection {
            get {
                if ((this._taskteammembersCollection == null)) {
                    _taskteammembersCollection = resourceSchema.Bll.Taskteammembers.Select_TaskTeamMemberss_By_TaskSysId(this.Sysid);
                }
                return this._taskteammembersCollection;
            }
        }
        
        public virtual TasktimeentrysCollection TasktimeentrysCollection {
            get {
                if ((this._tasktimeentrysCollection == null)) {
                    _tasktimeentrysCollection = resourceSchema.Bll.Tasktimeentrys.Select_TaskTimeEntryss_By_TaskSysId(this.Sysid);
                }
                return this._tasktimeentrysCollection;
            }
        }
        
        private void Clean() {
            this.Sysid = null;
            this._taskstatussysid = null;
            this._tasktypesysid = null;
            this.Publicid = null;
            this.Path = string.Empty;
            this.Createdate = null;
            this.Lastmodifieddate = null;
            this.IsReadonly = null;
            this.Active = null;
            this._taskareasCollection = null;
            this._taskiterationsCollection = null;
            this._tasklinksCollection = null;
            this._tasklinksCollection2 = null;
            this._taskmetadataCollection = null;
            this.Taskstatus = null;
            this.Tasktypes = null;
            this._tasktagsCollection = null;
            this._taskteammembersCollection = null;
            this._tasktimeentrysCollection = null;
        }
        
        private void Fill(System.Data.DataRow dr) {
            this.Clean();
            if ((dr["SysId"] != System.DBNull.Value)) {
                this.Sysid = ((System.Nullable<int>)(dr["SysId"]));
            }
            if ((dr["TaskStatusSysId"] != System.DBNull.Value)) {
                this._taskstatussysid = ((System.Nullable<int>)(dr["TaskStatusSysId"]));
            }
            if ((dr["TaskTypeSysId"] != System.DBNull.Value)) {
                this._tasktypesysid = ((System.Nullable<int>)(dr["TaskTypeSysId"]));
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
        
        public static TasksCollection Select_Taskss_By_TaskStatusSysId(System.Nullable<int> TaskStatusSysId) {
            resourceSchema.Dal.Tasks dbo = null;
            try {
                dbo = new resourceSchema.Dal.Tasks();
                System.Data.DataSet ds = dbo.Select_Taskss_By_TaskStatusSysId(TaskStatusSysId);
                TasksCollection collection = new TasksCollection();
                if (GlobalTools.IsSafeDataSet(ds)) {
                    for (int i = 0; (i < ds.Tables[0].Rows.Count); i = (i + 1)) {
                        Tasks obj = new Tasks();
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
        
        public static TasksCollection Select_Taskss_By_TaskTypeSysId(System.Nullable<int> TaskTypeSysId) {
            resourceSchema.Dal.Tasks dbo = null;
            try {
                dbo = new resourceSchema.Dal.Tasks();
                System.Data.DataSet ds = dbo.Select_Taskss_By_TaskTypeSysId(TaskTypeSysId);
                TasksCollection collection = new TasksCollection();
                if (GlobalTools.IsSafeDataSet(ds)) {
                    for (int i = 0; (i < ds.Tables[0].Rows.Count); i = (i + 1)) {
                        Tasks obj = new Tasks();
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
        
        public static TasksCollection GetAll() {
            resourceSchema.Dal.Tasks dbo = null;
            try {
                dbo = new resourceSchema.Dal.Tasks();
                System.Data.DataSet ds = dbo.Tasks_Select_All();
                TasksCollection collection = new TasksCollection();
                if (GlobalTools.IsSafeDataSet(ds)) {
                    for (int i = 0; (i < ds.Tables[0].Rows.Count); i = (i + 1)) {
                        Tasks obj = new Tasks();
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
        
        public static Tasks Load(System.Nullable<int> SysId) {
            resourceSchema.Dal.Tasks dbo = null;
            try {
                dbo = new resourceSchema.Dal.Tasks();
                System.Data.DataSet ds = dbo.Tasks_Select_One(SysId);
                Tasks obj = null;
                if (GlobalTools.IsSafeDataSet(ds)) {
                    if ((ds.Tables[0].Rows.Count > 0)) {
                        obj = new Tasks();
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
            resourceSchema.Dal.Tasks dbo = null;
            try {
                dbo = new resourceSchema.Dal.Tasks();
                System.Data.DataSet ds = dbo.Tasks_Select_One(this.Sysid);
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
            resourceSchema.Dal.Tasks dbo = null;
            try {
                dbo = new resourceSchema.Dal.Tasks();
                dbo.Tasks_Insert(this._taskstatussysid, this._tasktypesysid, this.Publicid, this.Path, this.Createdate, this.Lastmodifieddate, this.IsReadonly, this.Active);
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
            resourceSchema.Dal.Tasks dbo = null;
            try {
                dbo = new resourceSchema.Dal.Tasks();
                dbo.Tasks_Delete(this.Sysid);
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
            resourceSchema.Dal.Tasks dbo = null;
            try {
                dbo = new resourceSchema.Dal.Tasks();
                dbo.Tasks_Update(this.Sysid, this._taskstatussysid, this._tasktypesysid, this.Publicid, this.Path, this.Createdate, this.Lastmodifieddate, this.IsReadonly, this.Active);
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
