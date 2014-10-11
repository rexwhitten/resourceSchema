namespace resourceSchema.Dal {
    using System;
    using System.Collections.Generic;
    using System.Data.SqlClient;
    using System.Configuration;
    using System.Data;
    using System.Xml;
    
    
    public partial class Areaattributes : IDisposable {
        
        private DataAccess _dataAccess;
        
        public Areaattributes() {
            this._dataAccess = new DataAccess();
        }
        
        public virtual System.Data.DataSet AreaAttributes_Select_All() {
            this._dataAccess.CreateProcedureCommand("sp_AreaAttributes_Select_All");
            DataSet value = this._dataAccess.ExecuteDataSet();
            return value;
        }
        
        public virtual System.Data.DataSet AreaAttributes_Select_One(System.Nullable<int> SysId) {
            this._dataAccess.CreateProcedureCommand("sp_AreaAttributes_Select_One");
            this._dataAccess.AddParameter("SysId", SysId, ParameterDirection.Input);
            DataSet value = this._dataAccess.ExecuteDataSet();
            return value;
        }
        
        public virtual System.Nullable<int> AreaAttributes_Insert(System.Nullable<System.DateTime> CreateDate, System.Nullable<System.DateTime> LastModifiedDate, string SourceSystem, System.Nullable<System.DateTime> MetaImportDate) {
            this._dataAccess.CreateProcedureCommand("sp_AreaAttributes_Insert");
            this._dataAccess.AddParameter("CreateDate", CreateDate, ParameterDirection.Input);
            this._dataAccess.AddParameter("LastModifiedDate", LastModifiedDate, ParameterDirection.Input);
            this._dataAccess.AddParameter("SourceSystem", SourceSystem, ParameterDirection.Input);
            this._dataAccess.AddParameter("MetaImportDate", MetaImportDate, ParameterDirection.Input);
            int value = this._dataAccess.ExecuteNonQuery();
            return value;
        }
        
        public virtual System.Nullable<int> AreaAttributes_Delete(System.Nullable<int> SysId) {
            this._dataAccess.CreateProcedureCommand("sp_AreaAttributes_Delete");
            this._dataAccess.AddParameter("SysId", SysId, ParameterDirection.Input);
            int value = this._dataAccess.ExecuteNonQuery();
            return value;
        }
        
        public virtual System.Nullable<int> AreaAttributes_Update(System.Nullable<int> SysId, System.Nullable<System.DateTime> CreateDate, System.Nullable<System.DateTime> LastModifiedDate, string SourceSystem, System.Nullable<System.DateTime> MetaImportDate) {
            this._dataAccess.CreateProcedureCommand("sp_AreaAttributes_Update");
            this._dataAccess.AddParameter("SysId", SysId, ParameterDirection.Input);
            this._dataAccess.AddParameter("CreateDate", CreateDate, ParameterDirection.Input);
            this._dataAccess.AddParameter("LastModifiedDate", LastModifiedDate, ParameterDirection.Input);
            this._dataAccess.AddParameter("SourceSystem", SourceSystem, ParameterDirection.Input);
            this._dataAccess.AddParameter("MetaImportDate", MetaImportDate, ParameterDirection.Input);
            int value = this._dataAccess.ExecuteNonQuery();
            return value;
        }
        
        public virtual void Dispose() {
            if ((this._dataAccess != null)) {
                this._dataAccess.Dispose();
            }
        }
    }
}
