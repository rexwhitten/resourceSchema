namespace resourceSchema.Bll {
    
    
    public partial class Attributes {
        
        private System.Nullable<int> _id;
        
        private string _objecttitle;
        
        private string _name;
        
        private string _datatype;
        
        private System.Nullable<bool> _active;
        
        public virtual System.Nullable<int> Id {
            get {
                return _id;
            }
            set {
                _id = value;
            }
        }
        
        public virtual string Objecttitle {
            get {
                return _objecttitle;
            }
            set {
                _objecttitle = value;
            }
        }
        
        public virtual string Name {
            get {
                return _name;
            }
            set {
                _name = value;
            }
        }
        
        public virtual string Datatype {
            get {
                return _datatype;
            }
            set {
                _datatype = value;
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
        
        private void Clean() {
            this.Id = null;
            this.Objecttitle = string.Empty;
            this.Name = string.Empty;
            this.Datatype = string.Empty;
            this.Active = null;
        }
        
        private void Fill(System.Data.DataRow dr) {
            this.Clean();
            if ((dr["Id"] != System.DBNull.Value)) {
                this.Id = ((System.Nullable<int>)(dr["Id"]));
            }
            if ((dr["ObjectTitle"] != System.DBNull.Value)) {
                this.Objecttitle = ((string)(dr["ObjectTitle"]));
            }
            if ((dr["Name"] != System.DBNull.Value)) {
                this.Name = ((string)(dr["Name"]));
            }
            if ((dr["DataType"] != System.DBNull.Value)) {
                this.Datatype = ((string)(dr["DataType"]));
            }
            if ((dr["Active"] != System.DBNull.Value)) {
                this.Active = ((System.Nullable<bool>)(dr["Active"]));
            }
        }
        
        public static AttributesCollection GetAll() {
            resourceSchema.Dal.Attributes dbo = null;
            try {
                dbo = new resourceSchema.Dal.Attributes();
                System.Data.DataSet ds = dbo.Attributes_Select_All();
                AttributesCollection collection = new AttributesCollection();
                if (GlobalTools.IsSafeDataSet(ds)) {
                    for (int i = 0; (i < ds.Tables[0].Rows.Count); i = (i + 1)) {
                        Attributes obj = new Attributes();
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
        
        public static Attributes Load(System.Nullable<int> Id) {
            resourceSchema.Dal.Attributes dbo = null;
            try {
                dbo = new resourceSchema.Dal.Attributes();
                System.Data.DataSet ds = dbo.Attributes_Select_One(Id);
                Attributes obj = null;
                if (GlobalTools.IsSafeDataSet(ds)) {
                    if ((ds.Tables[0].Rows.Count > 0)) {
                        obj = new Attributes();
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
            resourceSchema.Dal.Attributes dbo = null;
            try {
                dbo = new resourceSchema.Dal.Attributes();
                System.Data.DataSet ds = dbo.Attributes_Select_One(this.Id);
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
            resourceSchema.Dal.Attributes dbo = null;
            try {
                dbo = new resourceSchema.Dal.Attributes();
                dbo.Attributes_Insert(this.Objecttitle, this.Name, this.Datatype, this.Active);
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
            resourceSchema.Dal.Attributes dbo = null;
            try {
                dbo = new resourceSchema.Dal.Attributes();
                dbo.Attributes_Delete(this.Id);
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
            resourceSchema.Dal.Attributes dbo = null;
            try {
                dbo = new resourceSchema.Dal.Attributes();
                dbo.Attributes_Update(this.Id, this.Objecttitle, this.Name, this.Datatype, this.Active);
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
