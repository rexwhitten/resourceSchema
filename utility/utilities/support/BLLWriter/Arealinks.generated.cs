namespace resourceSchema.Bll {
    
    
    public partial class Arealinks {
        
        private System.Nullable<int> _sysid;
        
        private System.Nullable<System.Guid> _publicid;
        
        private System.Nullable<int> _parentareasysid;
        
        private System.Nullable<int> _childareasysid;
        
        private string _linkpath;
        
        private System.Nullable<System.DateTime> _createdate;
        
        private System.Nullable<System.DateTime> _lastmodifieddate;
        
        private System.Nullable<bool> _active;
        
        private Areas _areas;
        
        private Areas _areas2;
        
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
        
        public virtual Areas Areas {
            get {
                if ((this._areas == null)) {
                    this._areas = resourceSchema.Bll.Areas.Load(this._parentareasysid);
                }
                return this._areas;
            }
            set {
                _areas = value;
            }
        }
        
        public virtual Areas Areas2 {
            get {
                if ((this._areas2 == null)) {
                    this._areas2 = resourceSchema.Bll.Areas.Load(this._childareasysid);
                }
                return this._areas2;
            }
            set {
                _areas2 = value;
            }
        }
        
        private void Clean() {
            this.Sysid = null;
            this.Publicid = null;
            this._parentareasysid = null;
            this._childareasysid = null;
            this.Linkpath = string.Empty;
            this.Createdate = null;
            this.Lastmodifieddate = null;
            this.Active = null;
            this.Areas = null;
            this.Areas2 = null;
        }
        
        private void Fill(System.Data.DataRow dr) {
            this.Clean();
            if ((dr["SysId"] != System.DBNull.Value)) {
                this.Sysid = ((System.Nullable<int>)(dr["SysId"]));
            }
            if ((dr["PublicId"] != System.DBNull.Value)) {
                this.Publicid = ((System.Nullable<System.Guid>)(dr["PublicId"]));
            }
            if ((dr["ParentAreaSysId"] != System.DBNull.Value)) {
                this._parentareasysid = ((System.Nullable<int>)(dr["ParentAreaSysId"]));
            }
            if ((dr["ChildAreaSysId"] != System.DBNull.Value)) {
                this._childareasysid = ((System.Nullable<int>)(dr["ChildAreaSysId"]));
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
        
        public static ArealinksCollection Select_AreaLinkss_By_ParentAreaSysId(System.Nullable<int> ParentAreaSysId) {
            resourceSchema.Dal.Arealinks dbo = null;
            try {
                dbo = new resourceSchema.Dal.Arealinks();
                System.Data.DataSet ds = dbo.Select_AreaLinkss_By_ParentAreaSysId(ParentAreaSysId);
                ArealinksCollection collection = new ArealinksCollection();
                if (GlobalTools.IsSafeDataSet(ds)) {
                    for (int i = 0; (i < ds.Tables[0].Rows.Count); i = (i + 1)) {
                        Arealinks obj = new Arealinks();
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
        
        public static ArealinksCollection Select_AreaLinkss_By_ChildAreaSysId(System.Nullable<int> ChildAreaSysId) {
            resourceSchema.Dal.Arealinks dbo = null;
            try {
                dbo = new resourceSchema.Dal.Arealinks();
                System.Data.DataSet ds = dbo.Select_AreaLinkss_By_ChildAreaSysId(ChildAreaSysId);
                ArealinksCollection collection = new ArealinksCollection();
                if (GlobalTools.IsSafeDataSet(ds)) {
                    for (int i = 0; (i < ds.Tables[0].Rows.Count); i = (i + 1)) {
                        Arealinks obj = new Arealinks();
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
        
        public static ArealinksCollection GetAll() {
            resourceSchema.Dal.Arealinks dbo = null;
            try {
                dbo = new resourceSchema.Dal.Arealinks();
                System.Data.DataSet ds = dbo.AreaLinks_Select_All();
                ArealinksCollection collection = new ArealinksCollection();
                if (GlobalTools.IsSafeDataSet(ds)) {
                    for (int i = 0; (i < ds.Tables[0].Rows.Count); i = (i + 1)) {
                        Arealinks obj = new Arealinks();
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
        
        public static Arealinks Load(System.Nullable<int> SysId) {
            resourceSchema.Dal.Arealinks dbo = null;
            try {
                dbo = new resourceSchema.Dal.Arealinks();
                System.Data.DataSet ds = dbo.AreaLinks_Select_One(SysId);
                Arealinks obj = null;
                if (GlobalTools.IsSafeDataSet(ds)) {
                    if ((ds.Tables[0].Rows.Count > 0)) {
                        obj = new Arealinks();
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
            resourceSchema.Dal.Arealinks dbo = null;
            try {
                dbo = new resourceSchema.Dal.Arealinks();
                System.Data.DataSet ds = dbo.AreaLinks_Select_One(this.Sysid);
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
            resourceSchema.Dal.Arealinks dbo = null;
            try {
                dbo = new resourceSchema.Dal.Arealinks();
                dbo.AreaLinks_Insert(this.Publicid, this._parentareasysid, this._childareasysid, this.Linkpath, this.Createdate, this.Lastmodifieddate, this.Active);
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
            resourceSchema.Dal.Arealinks dbo = null;
            try {
                dbo = new resourceSchema.Dal.Arealinks();
                dbo.AreaLinks_Delete(this.Sysid);
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
            resourceSchema.Dal.Arealinks dbo = null;
            try {
                dbo = new resourceSchema.Dal.Arealinks();
                dbo.AreaLinks_Update(this.Sysid, this.Publicid, this._parentareasysid, this._childareasysid, this.Linkpath, this.Createdate, this.Lastmodifieddate, this.Active);
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
