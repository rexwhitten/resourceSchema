namespace resourceSchema.Bll {
    
    
    public partial class Taskmetadata {
        
        private System.Nullable<int> _sysid;
        
        private System.Nullable<System.Guid> _publicid;
        
        private System.Nullable<int> _tasksysid;
        
        private string _keypath;
        
        private string _keyvalue;
        
        private System.Nullable<bool> _active;
        
        private Tasks _tasks;
        
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
        
        private void Clean() {
            this.Sysid = null;
            this.Publicid = null;
            this._tasksysid = null;
            this.Keypath = string.Empty;
            this.Keyvalue = string.Empty;
            this.Active = null;
            this.Tasks = null;
        }
        
        private void Fill(System.Data.DataRow dr) {
            this.Clean();
            if ((dr["SysId"] != System.DBNull.Value)) {
                this.Sysid = ((System.Nullable<int>)(dr["SysId"]));
            }
            if ((dr["PublicId"] != System.DBNull.Value)) {
                this.Publicid = ((System.Nullable<System.Guid>)(dr["PublicId"]));
            }
            if ((dr["TaskSysId"] != System.DBNull.Value)) {
                this._tasksysid = ((System.Nullable<int>)(dr["TaskSysId"]));
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
        
        public static TaskmetadataCollection Select_TaskMetaDatas_By_TaskSysId(System.Nullable<int> TaskSysId) {
            resourceSchema.Dal.Taskmetadata dbo = null;
            try {
                dbo = new resourceSchema.Dal.Taskmetadata();
                System.Data.DataSet ds = dbo.Select_TaskMetaDatas_By_TaskSysId(TaskSysId);
                TaskmetadataCollection collection = new TaskmetadataCollection();
                if (GlobalTools.IsSafeDataSet(ds)) {
                    for (int i = 0; (i < ds.Tables[0].Rows.Count); i = (i + 1)) {
                        Taskmetadata obj = new Taskmetadata();
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
        
        public static TaskmetadataCollection GetAll() {
            resourceSchema.Dal.Taskmetadata dbo = null;
            try {
                dbo = new resourceSchema.Dal.Taskmetadata();
                System.Data.DataSet ds = dbo.TaskMetaData_Select_All();
                TaskmetadataCollection collection = new TaskmetadataCollection();
                if (GlobalTools.IsSafeDataSet(ds)) {
                    for (int i = 0; (i < ds.Tables[0].Rows.Count); i = (i + 1)) {
                        Taskmetadata obj = new Taskmetadata();
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
        
        public static Taskmetadata Load(System.Nullable<int> SysId) {
            resourceSchema.Dal.Taskmetadata dbo = null;
            try {
                dbo = new resourceSchema.Dal.Taskmetadata();
                System.Data.DataSet ds = dbo.TaskMetaData_Select_One(SysId);
                Taskmetadata obj = null;
                if (GlobalTools.IsSafeDataSet(ds)) {
                    if ((ds.Tables[0].Rows.Count > 0)) {
                        obj = new Taskmetadata();
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
            resourceSchema.Dal.Taskmetadata dbo = null;
            try {
                dbo = new resourceSchema.Dal.Taskmetadata();
                System.Data.DataSet ds = dbo.TaskMetaData_Select_One(this.Sysid);
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
            resourceSchema.Dal.Taskmetadata dbo = null;
            try {
                dbo = new resourceSchema.Dal.Taskmetadata();
                dbo.TaskMetaData_Insert(this.Publicid, this._tasksysid, this.Keypath, this.Keyvalue, this.Active);
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
            resourceSchema.Dal.Taskmetadata dbo = null;
            try {
                dbo = new resourceSchema.Dal.Taskmetadata();
                dbo.TaskMetaData_Delete(this.Sysid);
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
            resourceSchema.Dal.Taskmetadata dbo = null;
            try {
                dbo = new resourceSchema.Dal.Taskmetadata();
                dbo.TaskMetaData_Update(this.Sysid, this.Publicid, this._tasksysid, this.Keypath, this.Keyvalue, this.Active);
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
