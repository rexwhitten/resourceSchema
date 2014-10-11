namespace resourceSchema.Bll {
    
    
    public partial class Areas {
        
        private System.Nullable<int> _sysid;
        
        private System.Nullable<int> _areastatussysid;
        
        private System.Nullable<int> _areatypesysid;
        
        private System.Nullable<System.Guid> _publicid;
        
        private string _path;
        
        private System.Nullable<System.DateTime> _createdate;
        
        private System.Nullable<System.DateTime> _lastmodifieddate;
        
        private System.Nullable<bool> _isReadonly;
        
        private System.Nullable<bool> _active;
        
        private ArealinksCollection _arealinksCollection;
        
        private ArealinksCollection _arealinksCollection2;
        
        private AreametadataCollection _areametadataCollection;
        
        private Areastatus _areastatus;
        
        private Areatypes _areatypes;
        
        private AreatagsCollection _areatagsCollection;
        
        private TaskareasCollection _taskareasCollection;
        
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
        
        public virtual ArealinksCollection ArealinksCollection {
            get {
                if ((this._arealinksCollection == null)) {
                    _arealinksCollection = resourceSchema.Bll.Arealinks.Select_AreaLinkss_By_ParentAreaSysId(this.Sysid);
                }
                return this._arealinksCollection;
            }
        }
        
        public virtual ArealinksCollection ArealinksCollection2 {
            get {
                if ((this._arealinksCollection2 == null)) {
                    _arealinksCollection2 = resourceSchema.Bll.Arealinks.Select_AreaLinkss_By_ChildAreaSysId(this.Sysid);
                }
                return this._arealinksCollection2;
            }
        }
        
        public virtual AreametadataCollection AreametadataCollection {
            get {
                if ((this._areametadataCollection == null)) {
                    _areametadataCollection = resourceSchema.Bll.Areametadata.Select_AreaMetaDatas_By_AreaSysId(this.Sysid);
                }
                return this._areametadataCollection;
            }
        }
        
        public virtual Areastatus Areastatus {
            get {
                if ((this._areastatus == null)) {
                    this._areastatus = resourceSchema.Bll.Areastatus.Load(this._areastatussysid);
                }
                return this._areastatus;
            }
            set {
                _areastatus = value;
            }
        }
        
        public virtual Areatypes Areatypes {
            get {
                if ((this._areatypes == null)) {
                    this._areatypes = resourceSchema.Bll.Areatypes.Load(this._areatypesysid);
                }
                return this._areatypes;
            }
            set {
                _areatypes = value;
            }
        }
        
        public virtual AreatagsCollection AreatagsCollection {
            get {
                if ((this._areatagsCollection == null)) {
                    _areatagsCollection = resourceSchema.Bll.Areatags.Select_AreaTagss_By_SysId(this.Sysid);
                }
                return this._areatagsCollection;
            }
        }
        
        public virtual TaskareasCollection TaskareasCollection {
            get {
                if ((this._taskareasCollection == null)) {
                    _taskareasCollection = resourceSchema.Bll.Taskareas.Select_TaskAreass_By_AreasysId(this.Sysid);
                }
                return this._taskareasCollection;
            }
        }
        
        private void Clean() {
            this.Sysid = null;
            this._areastatussysid = null;
            this._areatypesysid = null;
            this.Publicid = null;
            this.Path = string.Empty;
            this.Createdate = null;
            this.Lastmodifieddate = null;
            this.IsReadonly = null;
            this.Active = null;
            this._arealinksCollection = null;
            this._arealinksCollection2 = null;
            this._areametadataCollection = null;
            this.Areastatus = null;
            this.Areatypes = null;
            this._areatagsCollection = null;
            this._taskareasCollection = null;
        }
        
        private void Fill(System.Data.DataRow dr) {
            this.Clean();
            if ((dr["SysId"] != System.DBNull.Value)) {
                this.Sysid = ((System.Nullable<int>)(dr["SysId"]));
            }
            if ((dr["AreaStatusSysId"] != System.DBNull.Value)) {
                this._areastatussysid = ((System.Nullable<int>)(dr["AreaStatusSysId"]));
            }
            if ((dr["AreaTypeSysId"] != System.DBNull.Value)) {
                this._areatypesysid = ((System.Nullable<int>)(dr["AreaTypeSysId"]));
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
        
        public static AreasCollection Select_Areass_By_AreaStatusSysId(System.Nullable<int> AreaStatusSysId) {
            resourceSchema.Dal.Areas dbo = null;
            try {
                dbo = new resourceSchema.Dal.Areas();
                System.Data.DataSet ds = dbo.Select_Areass_By_AreaStatusSysId(AreaStatusSysId);
                AreasCollection collection = new AreasCollection();
                if (GlobalTools.IsSafeDataSet(ds)) {
                    for (int i = 0; (i < ds.Tables[0].Rows.Count); i = (i + 1)) {
                        Areas obj = new Areas();
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
        
        public static AreasCollection Select_Areass_By_AreaTypeSysId(System.Nullable<int> AreaTypeSysId) {
            resourceSchema.Dal.Areas dbo = null;
            try {
                dbo = new resourceSchema.Dal.Areas();
                System.Data.DataSet ds = dbo.Select_Areass_By_AreaTypeSysId(AreaTypeSysId);
                AreasCollection collection = new AreasCollection();
                if (GlobalTools.IsSafeDataSet(ds)) {
                    for (int i = 0; (i < ds.Tables[0].Rows.Count); i = (i + 1)) {
                        Areas obj = new Areas();
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
        
        public static AreasCollection GetAll() {
            resourceSchema.Dal.Areas dbo = null;
            try {
                dbo = new resourceSchema.Dal.Areas();
                System.Data.DataSet ds = dbo.Areas_Select_All();
                AreasCollection collection = new AreasCollection();
                if (GlobalTools.IsSafeDataSet(ds)) {
                    for (int i = 0; (i < ds.Tables[0].Rows.Count); i = (i + 1)) {
                        Areas obj = new Areas();
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
        
        public static Areas Load(System.Nullable<int> SysId) {
            resourceSchema.Dal.Areas dbo = null;
            try {
                dbo = new resourceSchema.Dal.Areas();
                System.Data.DataSet ds = dbo.Areas_Select_One(SysId);
                Areas obj = null;
                if (GlobalTools.IsSafeDataSet(ds)) {
                    if ((ds.Tables[0].Rows.Count > 0)) {
                        obj = new Areas();
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
            resourceSchema.Dal.Areas dbo = null;
            try {
                dbo = new resourceSchema.Dal.Areas();
                System.Data.DataSet ds = dbo.Areas_Select_One(this.Sysid);
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
            resourceSchema.Dal.Areas dbo = null;
            try {
                dbo = new resourceSchema.Dal.Areas();
                dbo.Areas_Insert(this._areastatussysid, this._areatypesysid, this.Publicid, this.Path, this.Createdate, this.Lastmodifieddate, this.IsReadonly, this.Active);
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
            resourceSchema.Dal.Areas dbo = null;
            try {
                dbo = new resourceSchema.Dal.Areas();
                dbo.Areas_Delete(this.Sysid);
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
            resourceSchema.Dal.Areas dbo = null;
            try {
                dbo = new resourceSchema.Dal.Areas();
                dbo.Areas_Update(this.Sysid, this._areastatussysid, this._areatypesysid, this.Publicid, this.Path, this.Createdate, this.Lastmodifieddate, this.IsReadonly, this.Active);
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
