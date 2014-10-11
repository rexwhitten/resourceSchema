namespace resourceSchema.Dal {
    using System;
    using System.Collections.Generic;
    using System.Data.SqlClient;
    using System.Configuration;
    using System.Data;
    using System.Xml;
    
    
    public partial class Iterations : IDisposable {
        
        private DataAccess _dataAccess;
        
        public Iterations() {
            this._dataAccess = new DataAccess();
        }
        
        public virtual System.Data.DataSet Select_Iterationss_By_IterationStatusSysId(System.Nullable<int> IterationStatusSysId) {
            this._dataAccess.CreateProcedureCommand("sp_Select_Iterationss_By_IterationStatusSysId");
            this._dataAccess.AddParameter("IterationStatusSysId", IterationStatusSysId, ParameterDirection.Input);
            DataSet value = this._dataAccess.ExecuteDataSet();
            return value;
        }
        
        public virtual System.Data.DataSet Select_Iterationss_By_IterationTypeSysId(System.Nullable<int> IterationTypeSysId) {
            this._dataAccess.CreateProcedureCommand("sp_Select_Iterationss_By_IterationTypeSysId");
            this._dataAccess.AddParameter("IterationTypeSysId", IterationTypeSysId, ParameterDirection.Input);
            DataSet value = this._dataAccess.ExecuteDataSet();
            return value;
        }
        
        public virtual System.Data.DataSet Iterations_Select_All() {
            this._dataAccess.CreateProcedureCommand("sp_Iterations_Select_All");
            DataSet value = this._dataAccess.ExecuteDataSet();
            return value;
        }
        
        public virtual System.Data.DataSet Iterations_Select_One(System.Nullable<int> SysId) {
            this._dataAccess.CreateProcedureCommand("sp_Iterations_Select_One");
            this._dataAccess.AddParameter("SysId", SysId, ParameterDirection.Input);
            DataSet value = this._dataAccess.ExecuteDataSet();
            return value;
        }
        
        public virtual System.Nullable<int> Iterations_Insert(System.Nullable<int> IterationStatusSysId, System.Nullable<int> IterationTypeSysId, System.Nullable<System.Guid> PublicId, string Path, System.Nullable<System.DateTime> CreateDate, System.Nullable<System.DateTime> LastModifiedDate, System.Nullable<bool> Is_ReadOnly, System.Nullable<bool> Active) {
            this._dataAccess.CreateProcedureCommand("sp_Iterations_Insert");
            this._dataAccess.AddParameter("IterationStatusSysId", IterationStatusSysId, ParameterDirection.Input);
            this._dataAccess.AddParameter("IterationTypeSysId", IterationTypeSysId, ParameterDirection.Input);
            this._dataAccess.AddParameter("PublicId", PublicId, ParameterDirection.Input);
            this._dataAccess.AddParameter("Path", Path, ParameterDirection.Input);
            this._dataAccess.AddParameter("CreateDate", CreateDate, ParameterDirection.Input);
            this._dataAccess.AddParameter("LastModifiedDate", LastModifiedDate, ParameterDirection.Input);
            this._dataAccess.AddParameter("Is_ReadOnly", Is_ReadOnly, ParameterDirection.Input);
            this._dataAccess.AddParameter("Active", Active, ParameterDirection.Input);
            int value = this._dataAccess.ExecuteNonQuery();
            return value;
        }
        
        public virtual System.Nullable<int> Iterations_Delete(System.Nullable<int> SysId) {
            this._dataAccess.CreateProcedureCommand("sp_Iterations_Delete");
            this._dataAccess.AddParameter("SysId", SysId, ParameterDirection.Input);
            int value = this._dataAccess.ExecuteNonQuery();
            return value;
        }
        
        public virtual System.Nullable<int> Iterations_Update(System.Nullable<int> SysId, System.Nullable<int> IterationStatusSysId, System.Nullable<int> IterationTypeSysId, System.Nullable<System.Guid> PublicId, string Path, System.Nullable<System.DateTime> CreateDate, System.Nullable<System.DateTime> LastModifiedDate, System.Nullable<bool> Is_ReadOnly, System.Nullable<bool> Active) {
            this._dataAccess.CreateProcedureCommand("sp_Iterations_Update");
            this._dataAccess.AddParameter("SysId", SysId, ParameterDirection.Input);
            this._dataAccess.AddParameter("IterationStatusSysId", IterationStatusSysId, ParameterDirection.Input);
            this._dataAccess.AddParameter("IterationTypeSysId", IterationTypeSysId, ParameterDirection.Input);
            this._dataAccess.AddParameter("PublicId", PublicId, ParameterDirection.Input);
            this._dataAccess.AddParameter("Path", Path, ParameterDirection.Input);
            this._dataAccess.AddParameter("CreateDate", CreateDate, ParameterDirection.Input);
            this._dataAccess.AddParameter("LastModifiedDate", LastModifiedDate, ParameterDirection.Input);
            this._dataAccess.AddParameter("Is_ReadOnly", Is_ReadOnly, ParameterDirection.Input);
            this._dataAccess.AddParameter("Active", Active, ParameterDirection.Input);
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
