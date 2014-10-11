namespace resourceSchema.Bll {
    
    
    public partial class Taskareas {
        
        private System.Nullable<int> _sysid;
        
        private System.Nullable<System.Guid> _publicid;
        
        private string _path;
        
        private System.Nullable<int> _tasksysid;
        
        private System.Nullable<int> _areasysid;
        
        private System.Nullable<System.DateTime> _createdate;
        
        private System.Nullable<bool> _active;
        
        private Areas _areas;
        
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
        
        public virtual Areas Areas {
            get {
                if ((this._areas == null)) {
                    this._areas = resourceSchema.Bll.Areas.Load(this._areasysid);
                }
                return this._areas;
            }
            set {
                _areas = value;
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
            this.Path = string.Empty;
            this._tasksysid = null;
            this._areasysid = null;
            this.Createdate = null;
            this.Active = null;
            this.Areas = null;
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
            if ((dr["Path"] != System.DBNull.Value)) {
                this.Path = ((string)(dr["Path"]));
            }
            if ((dr["TaskSysId"] != System.DBNull.Value)) {
                this._tasksysid = ((System.Nullable<int>)(dr["TaskSysId"]));
            }
            if ((dr["AreasysId"] != System.DBNull.Value)) {
                this._areasysid = ((System.Nullable<int>)(dr["AreasysId"]));
            }
            if ((dr["CreateDate"] != System.DBNull.Value)) {
                this.Createdate = ((System.Nullable<System.DateTime>)(dr["CreateDate"]));
            }
            if ((dr["Active"] != System.DBNull.Value)) {
                this.Active = ((System.Nullable<bool>)(dr["Active"]));
            }
        }
        
        public static TaskareasCollection Select_TaskAreass_By_AreasysId(System.Nullable<int> AreasysId) {
            resourceSchema.Dal.Taskareas dbo = null;
            try {
                dbo = new resourceSchema.Dal.Taskareas();
                System.Data.DataSet ds = dbo.Select_TaskAreass_By_AreasysId(AreasysId);
                TaskareasCollection collection = new TaskareasCollection();
                if (GlobalTools.IsSafeDataSet(ds)) {
                    for (int i = 0; (i < ds.Tables[0].Rows.Count); i = (i + 1)) {
                        Taskareas obj = new Taskareas();
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
        
        public static TaskareasCollection Select_TaskAreass_By_TaskSysId(System.Nullable<int> TaskSysId) {
            resourceSchema.Dal.Taskareas dbo = null;
            try {
                dbo = new resourceSchema.Dal.Taskareas();
                System.Data.DataSet ds = dbo.Select_TaskAreass_By_TaskSysId(TaskSysId);
                TaskareasCollection collection = new TaskareasCollection();
                if (GlobalTools.IsSafeDataSet(ds)) {
                    for (int i = 0; (i < ds.Tables[0].Rows.Count); i = (i + 1)) {
                        Taskareas obj = new Taskareas();
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
        
        public static TaskareasCollection GetAll() {
            resourceSchema.Dal.Taskareas dbo = null;
            try {
                dbo = new resourceSchema.Dal.Taskareas();
                System.Data.DataSet ds = dbo.TaskAreas_Select_All();
                TaskareasCollection collection = new TaskareasCollection();
                if (GlobalTools.IsSafeDataSet(ds)) {
                    for (int i = 0; (i < ds.Tables[0].Rows.Count); i = (i + 1)) {
                        Taskareas obj = new Taskareas();
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
        
        public static Taskareas Load(System.Nullable<int> SysId) {
            resourceSchema.Dal.Taskareas dbo = null;
            try {
                dbo = new resourceSchema.Dal.Taskareas();
                System.Data.DataSet ds = dbo.TaskAreas_Select_One(SysId);
                Taskareas obj = null;
                if (GlobalTools.IsSafeDataSet(ds)) {
                    if ((ds.Tables[0].Rows.Count > 0)) {
                        obj = new Taskareas();
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
            resourceSchema.Dal.Taskareas dbo = null;
            try {
                dbo = new resourceSchema.Dal.Taskareas();
                System.Data.DataSet ds = dbo.TaskAreas_Select_One(this.Sysid);
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
            resourceSchema.Dal.Taskareas dbo = null;
            try {
                dbo = new resourceSchema.Dal.Taskareas();
                dbo.TaskAreas_Insert(this.Publicid, this.Path, this._tasksysid, this._areasysid, this.Createdate, this.Active);
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
            resourceSchema.Dal.Taskareas dbo = null;
            try {
                dbo = new resourceSchema.Dal.Taskareas();
                dbo.TaskAreas_Delete(this.Sysid);
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
            resourceSchema.Dal.Taskareas dbo = null;
            try {
                dbo = new resourceSchema.Dal.Taskareas();
                dbo.TaskAreas_Update(this.Sysid, this.Publicid, this.Path, this._tasksysid, this._areasysid, this.Createdate, this.Active);
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
