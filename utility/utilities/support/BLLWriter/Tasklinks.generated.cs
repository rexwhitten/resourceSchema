namespace resourceSchema.Bll {
    
    
    public partial class Tasklinks {
        
        private System.Nullable<int> _sysid;
        
        private System.Nullable<System.Guid> _publicid;
        
        private System.Nullable<int> _parenttasksysid;
        
        private System.Nullable<int> _childtasksysid;
        
        private string _linkpath;
        
        private System.Nullable<System.DateTime> _createdate;
        
        private System.Nullable<System.DateTime> _lastmodifieddate;
        
        private System.Nullable<bool> _active;
        
        private Tasks _tasks;
        
        private Tasks _tasks2;
        
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
        
        public virtual Tasks Tasks {
            get {
                if ((this._tasks == null)) {
                    this._tasks = resourceSchema.Bll.Tasks.Load(this._parenttasksysid);
                }
                return this._tasks;
            }
            set {
                _tasks = value;
            }
        }
        
        public virtual Tasks Tasks2 {
            get {
                if ((this._tasks2 == null)) {
                    this._tasks2 = resourceSchema.Bll.Tasks.Load(this._childtasksysid);
                }
                return this._tasks2;
            }
            set {
                _tasks2 = value;
            }
        }
        
        private void Clean() {
            this.Sysid = null;
            this.Publicid = null;
            this._parenttasksysid = null;
            this._childtasksysid = null;
            this.Linkpath = string.Empty;
            this.Createdate = null;
            this.Lastmodifieddate = null;
            this.Active = null;
            this.Tasks = null;
            this.Tasks2 = null;
        }
        
        private void Fill(System.Data.DataRow dr) {
            this.Clean();
            if ((dr["SysId"] != System.DBNull.Value)) {
                this.Sysid = ((System.Nullable<int>)(dr["SysId"]));
            }
            if ((dr["PublicId"] != System.DBNull.Value)) {
                this.Publicid = ((System.Nullable<System.Guid>)(dr["PublicId"]));
            }
            if ((dr["ParentTaskSysId"] != System.DBNull.Value)) {
                this._parenttasksysid = ((System.Nullable<int>)(dr["ParentTaskSysId"]));
            }
            if ((dr["ChildTaskSysId"] != System.DBNull.Value)) {
                this._childtasksysid = ((System.Nullable<int>)(dr["ChildTaskSysId"]));
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
        
        public static TasklinksCollection Select_TaskLinkss_By_ParentTaskSysId(System.Nullable<int> ParentTaskSysId) {
            resourceSchema.Dal.Tasklinks dbo = null;
            try {
                dbo = new resourceSchema.Dal.Tasklinks();
                System.Data.DataSet ds = dbo.Select_TaskLinkss_By_ParentTaskSysId(ParentTaskSysId);
                TasklinksCollection collection = new TasklinksCollection();
                if (GlobalTools.IsSafeDataSet(ds)) {
                    for (int i = 0; (i < ds.Tables[0].Rows.Count); i = (i + 1)) {
                        Tasklinks obj = new Tasklinks();
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
        
        public static TasklinksCollection Select_TaskLinkss_By_ChildTaskSysId(System.Nullable<int> ChildTaskSysId) {
            resourceSchema.Dal.Tasklinks dbo = null;
            try {
                dbo = new resourceSchema.Dal.Tasklinks();
                System.Data.DataSet ds = dbo.Select_TaskLinkss_By_ChildTaskSysId(ChildTaskSysId);
                TasklinksCollection collection = new TasklinksCollection();
                if (GlobalTools.IsSafeDataSet(ds)) {
                    for (int i = 0; (i < ds.Tables[0].Rows.Count); i = (i + 1)) {
                        Tasklinks obj = new Tasklinks();
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
        
        public static TasklinksCollection GetAll() {
            resourceSchema.Dal.Tasklinks dbo = null;
            try {
                dbo = new resourceSchema.Dal.Tasklinks();
                System.Data.DataSet ds = dbo.TaskLinks_Select_All();
                TasklinksCollection collection = new TasklinksCollection();
                if (GlobalTools.IsSafeDataSet(ds)) {
                    for (int i = 0; (i < ds.Tables[0].Rows.Count); i = (i + 1)) {
                        Tasklinks obj = new Tasklinks();
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
        
        public static Tasklinks Load(System.Nullable<int> SysId) {
            resourceSchema.Dal.Tasklinks dbo = null;
            try {
                dbo = new resourceSchema.Dal.Tasklinks();
                System.Data.DataSet ds = dbo.TaskLinks_Select_One(SysId);
                Tasklinks obj = null;
                if (GlobalTools.IsSafeDataSet(ds)) {
                    if ((ds.Tables[0].Rows.Count > 0)) {
                        obj = new Tasklinks();
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
            resourceSchema.Dal.Tasklinks dbo = null;
            try {
                dbo = new resourceSchema.Dal.Tasklinks();
                System.Data.DataSet ds = dbo.TaskLinks_Select_One(this.Sysid);
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
            resourceSchema.Dal.Tasklinks dbo = null;
            try {
                dbo = new resourceSchema.Dal.Tasklinks();
                dbo.TaskLinks_Insert(this.Publicid, this._parenttasksysid, this._childtasksysid, this.Linkpath, this.Createdate, this.Lastmodifieddate, this.Active);
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
            resourceSchema.Dal.Tasklinks dbo = null;
            try {
                dbo = new resourceSchema.Dal.Tasklinks();
                dbo.TaskLinks_Delete(this.Sysid);
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
            resourceSchema.Dal.Tasklinks dbo = null;
            try {
                dbo = new resourceSchema.Dal.Tasklinks();
                dbo.TaskLinks_Update(this.Sysid, this.Publicid, this._parenttasksysid, this._childtasksysid, this.Linkpath, this.Createdate, this.Lastmodifieddate, this.Active);
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
