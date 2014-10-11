namespace resourceSchema.Bll {
    
    
    public partial class Teamattributes {
        
        private System.Nullable<int> _sysid;
        
        private System.Nullable<System.DateTime> _createdate;
        
        private System.Nullable<System.DateTime> _lastmodifieddate;
        
        private string _sourcesystem;
        
        private System.Nullable<System.DateTime> _metaimportdate;
        
        public virtual System.Nullable<int> Sysid {
            get {
                return _sysid;
            }
            set {
                _sysid = value;
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
        
        public virtual string Sourcesystem {
            get {
                return _sourcesystem;
            }
            set {
                _sourcesystem = value;
            }
        }
        
        public virtual System.Nullable<System.DateTime> Metaimportdate {
            get {
                return _metaimportdate;
            }
            set {
                _metaimportdate = value;
            }
        }
        
        private void Clean() {
            this.Sysid = null;
            this.Createdate = null;
            this.Lastmodifieddate = null;
            this.Sourcesystem = string.Empty;
            this.Metaimportdate = null;
        }
        
        private void Fill(System.Data.DataRow dr) {
            this.Clean();
            if ((dr["SysId"] != System.DBNull.Value)) {
                this.Sysid = ((System.Nullable<int>)(dr["SysId"]));
            }
            if ((dr["CreateDate"] != System.DBNull.Value)) {
                this.Createdate = ((System.Nullable<System.DateTime>)(dr["CreateDate"]));
            }
            if ((dr["LastModifiedDate"] != System.DBNull.Value)) {
                this.Lastmodifieddate = ((System.Nullable<System.DateTime>)(dr["LastModifiedDate"]));
            }
            if ((dr["SourceSystem"] != System.DBNull.Value)) {
                this.Sourcesystem = ((string)(dr["SourceSystem"]));
            }
            if ((dr["MetaImportDate"] != System.DBNull.Value)) {
                this.Metaimportdate = ((System.Nullable<System.DateTime>)(dr["MetaImportDate"]));
            }
        }
        
        public static TeamattributesCollection GetAll() {
            resourceSchema.Dal.Teamattributes dbo = null;
            try {
                dbo = new resourceSchema.Dal.Teamattributes();
                System.Data.DataSet ds = dbo.TeamAttributes_Select_All();
                TeamattributesCollection collection = new TeamattributesCollection();
                if (GlobalTools.IsSafeDataSet(ds)) {
                    for (int i = 0; (i < ds.Tables[0].Rows.Count); i = (i + 1)) {
                        Teamattributes obj = new Teamattributes();
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
        
        public static Teamattributes Load(System.Nullable<int> SysId) {
            resourceSchema.Dal.Teamattributes dbo = null;
            try {
                dbo = new resourceSchema.Dal.Teamattributes();
                System.Data.DataSet ds = dbo.TeamAttributes_Select_One(SysId);
                Teamattributes obj = null;
                if (GlobalTools.IsSafeDataSet(ds)) {
                    if ((ds.Tables[0].Rows.Count > 0)) {
                        obj = new Teamattributes();
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
            resourceSchema.Dal.Teamattributes dbo = null;
            try {
                dbo = new resourceSchema.Dal.Teamattributes();
                System.Data.DataSet ds = dbo.TeamAttributes_Select_One(this.Sysid);
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
            resourceSchema.Dal.Teamattributes dbo = null;
            try {
                dbo = new resourceSchema.Dal.Teamattributes();
                dbo.TeamAttributes_Insert(this.Createdate, this.Lastmodifieddate, this.Sourcesystem, this.Metaimportdate);
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
            resourceSchema.Dal.Teamattributes dbo = null;
            try {
                dbo = new resourceSchema.Dal.Teamattributes();
                dbo.TeamAttributes_Delete(this.Sysid);
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
            resourceSchema.Dal.Teamattributes dbo = null;
            try {
                dbo = new resourceSchema.Dal.Teamattributes();
                dbo.TeamAttributes_Update(this.Sysid, this.Createdate, this.Lastmodifieddate, this.Sourcesystem, this.Metaimportdate);
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
