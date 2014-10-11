namespace resourceSchema.Dal {
    using System;
    using System.Collections.Generic;
    using System.Data.SqlClient;
    using System.Configuration;
    using System.Data;
    using System.Xml;
    
    
    public partial class Teamattributes : IDisposable {
        
        private DataAccess _dataAccess;
        
        public Teamattributes() {
            this._dataAccess = new DataAccess();
        }
        
        public virtual System.Data.DataSet TeamAttributes_Select_All() {
            this._dataAccess.CreateProcedureCommand("sp_TeamAttributes_Select_All");
            DataSet value = this._dataAccess.ExecuteDataSet();
            return value;
        }
        
        public virtual System.Data.DataSet TeamAttributes_Select_One(System.Nullable<int> SysId) {
            this._dataAccess.CreateProcedureCommand("sp_TeamAttributes_Select_One");
            this._dataAccess.AddParameter("SysId", SysId, ParameterDirection.Input);
            DataSet value = this._dataAccess.ExecuteDataSet();
            return value;
        }
        
        public virtual System.Nullable<int> TeamAttributes_Insert(System.Nullable<System.DateTime> CreateDate, System.Nullable<System.DateTime> LastModifiedDate, string SourceSystem, System.Nullable<System.DateTime> MetaImportDate) {
            this._dataAccess.CreateProcedureCommand("sp_TeamAttributes_Insert");
            this._dataAccess.AddParameter("CreateDate", CreateDate, ParameterDirection.Input);
            this._dataAccess.AddParameter("LastModifiedDate", LastModifiedDate, ParameterDirection.Input);
            this._dataAccess.AddParameter("SourceSystem", SourceSystem, ParameterDirection.Input);
            this._dataAccess.AddParameter("MetaImportDate", MetaImportDate, ParameterDirection.Input);
            int value = this._dataAccess.ExecuteNonQuery();
            return value;
        }
        
        public virtual System.Nullable<int> TeamAttributes_Delete(System.Nullable<int> SysId) {
            this._dataAccess.CreateProcedureCommand("sp_TeamAttributes_Delete");
            this._dataAccess.AddParameter("SysId", SysId, ParameterDirection.Input);
            int value = this._dataAccess.ExecuteNonQuery();
            return value;
        }
        
        public virtual System.Nullable<int> TeamAttributes_Update(System.Nullable<int> SysId, System.Nullable<System.DateTime> CreateDate, System.Nullable<System.DateTime> LastModifiedDate, string SourceSystem, System.Nullable<System.DateTime> MetaImportDate) {
            this._dataAccess.CreateProcedureCommand("sp_TeamAttributes_Update");
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
