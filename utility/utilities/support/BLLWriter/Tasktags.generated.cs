namespace resourceSchema.Bll {
    
    
    public partial class Tasktags {
        
        private System.Nullable<int> _sysid;
        
        private System.Nullable<int> _tasksysid;
        
        private string _tag;
        
        private System.Nullable<System.DateTime> _createdate;
        
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
        
        public virtual System.Nullable<int> Tasksysid {
            get {
                return _tasksysid;
            }
            set {
                _tasksysid = value;
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
        
        public virtual Tasks Tasks {
            get {
                if ((this._tasks == null)) {
                    this._tasks = resourceSchema.Bll.Tasks.Load(this._sysid);
                }
                return this._tasks;
            }
            set {
                _tasks = value;
            }
        }
        
        private void Clean() {
            this.Sysid = null;
            this.Tasksysid = null;
            this.Tag = string.Empty;
            this.Createdate = null;
            this.Active = null;
            this.Tasks = null;
        }
        
        private void Fill(System.Data.DataRow dr) {
            this.Clean();
            if ((dr["SysId"] != System.DBNull.Value)) {
                this.Sysid = ((System.Nullable<int>)(dr["SysId"]));
            }
            if ((dr["TaskSysId"] != System.DBNull.Value)) {
                this.Tasksysid = ((System.Nullable<int>)(dr["TaskSysId"]));
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
        
        public static TasktagsCollection Select_TaskTagss_By_SysId(System.Nullable<int> SysId) {
            resourceSchema.Dal.Tasktags dbo = null;
            try {
                dbo = new resourceSchema.Dal.Tasktags();
                System.Data.DataSet ds = dbo.Select_TaskTagss_By_SysId(SysId);
                TasktagsCollection collection = new TasktagsCollection();
                if (GlobalTools.IsSafeDataSet(ds)) {
                    for (int i = 0; (i < ds.Tables[0].Rows.Count); i = (i + 1)) {
                        Tasktags obj = new Tasktags();
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
        
        public static TasktagsCollection GetAll() {
            resourceSchema.Dal.Tasktags dbo = null;
            try {
                dbo = new resourceSchema.Dal.Tasktags();
                System.Data.DataSet ds = dbo.TaskTags_Select_All();
                TasktagsCollection collection = new TasktagsCollection();
                if (GlobalTools.IsSafeDataSet(ds)) {
                    for (int i = 0; (i < ds.Tables[0].Rows.Count); i = (i + 1)) {
                        Tasktags obj = new Tasktags();
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
        
        public static Tasktags Load(System.Nullable<int> SysId) {
            resourceSchema.Dal.Tasktags dbo = null;
            try {
                dbo = new resourceSchema.Dal.Tasktags();
                System.Data.DataSet ds = dbo.TaskTags_Select_One(SysId);
                Tasktags obj = null;
                if (GlobalTools.IsSafeDataSet(ds)) {
                    if ((ds.Tables[0].Rows.Count > 0)) {
                        obj = new Tasktags();
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
            resourceSchema.Dal.Tasktags dbo = null;
            try {
                dbo = new resourceSchema.Dal.Tasktags();
                System.Data.DataSet ds = dbo.TaskTags_Select_One(this.Sysid);
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
            resourceSchema.Dal.Tasktags dbo = null;
            try {
                dbo = new resourceSchema.Dal.Tasktags();
                dbo.TaskTags_Insert(this.Tasksysid, this.Tag, this.Createdate, this.Active);
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
            resourceSchema.Dal.Tasktags dbo = null;
            try {
                dbo = new resourceSchema.Dal.Tasktags();
                dbo.TaskTags_Delete(this.Sysid);
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
            resourceSchema.Dal.Tasktags dbo = null;
            try {
                dbo = new resourceSchema.Dal.Tasktags();
                dbo.TaskTags_Update(this.Sysid, this.Tasksysid, this.Tag, this.Createdate, this.Active);
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
