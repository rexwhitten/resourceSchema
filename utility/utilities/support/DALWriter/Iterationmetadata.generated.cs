namespace resourceSchema.Dal {
    using System;
    using System.Collections.Generic;
    using System.Data.SqlClient;
    using System.Configuration;
    using System.Data;
    using System.Xml;
    
    
    public partial class Iterationmetadata : IDisposable {
        
        private DataAccess _dataAccess;
        
        public Iterationmetadata() {
            this._dataAccess = new DataAccess();
        }
        
        public virtual System.Data.DataSet Select_IterationMetaDatas_By_IterationSysId(System.Nullable<int> IterationSysId) {
            this._dataAccess.CreateProcedureCommand("sp_Select_IterationMetaDatas_By_IterationSysId");
            this._dataAccess.AddParameter("IterationSysId", IterationSysId, ParameterDirection.Input);
            DataSet value = this._dataAccess.ExecuteDataSet();
            return value;
        }
        
        public virtual System.Data.DataSet IterationMetaData_Select_All() {
            this._dataAccess.CreateProcedureCommand("sp_IterationMetaData_Select_All");
            DataSet value = this._dataAccess.ExecuteDataSet();
            return value;
        }
        
        public virtual System.Data.DataSet IterationMetaData_Select_One(System.Nullable<int> SysId) {
            this._dataAccess.CreateProcedureCommand("sp_IterationMetaData_Select_One");
            this._dataAccess.AddParameter("SysId", SysId, ParameterDirection.Input);
            DataSet value = this._dataAccess.ExecuteDataSet();
            return value;
        }
        
        public virtual System.Nullable<int> IterationMetaData_Insert(System.Nullable<System.Guid> PublicId, System.Nullable<int> IterationSysId, string KeyPath, string KeyValue, System.Nullable<bool> Active) {
            this._dataAccess.CreateProcedureCommand("sp_IterationMetaData_Insert");
            this._dataAccess.AddParameter("PublicId", PublicId, ParameterDirection.Input);
            this._dataAccess.AddParameter("IterationSysId", IterationSysId, ParameterDirection.Input);
            this._dataAccess.AddParameter("KeyPath", KeyPath, ParameterDirection.Input);
            this._dataAccess.AddParameter("KeyValue", KeyValue, ParameterDirection.Input);
            this._dataAccess.AddParameter("Active", Active, ParameterDirection.Input);
            int value = this._dataAccess.ExecuteNonQuery();
            return value;
        }
        
        public virtual System.Nullable<int> IterationMetaData_Delete(System.Nullable<int> SysId) {
            this._dataAccess.CreateProcedureCommand("sp_IterationMetaData_Delete");
            this._dataAccess.AddParameter("SysId", SysId, ParameterDirection.Input);
            int value = this._dataAccess.ExecuteNonQuery();
            return value;
        }
        
        public virtual System.Nullable<int> IterationMetaData_Update(System.Nullable<int> SysId, System.Nullable<System.Guid> PublicId, System.Nullable<int> IterationSysId, string KeyPath, string KeyValue, System.Nullable<bool> Active) {
            this._dataAccess.CreateProcedureCommand("sp_IterationMetaData_Update");
            this._dataAccess.AddParameter("SysId", SysId, ParameterDirection.Input);
            this._dataAccess.AddParameter("PublicId", PublicId, ParameterDirection.Input);
            this._dataAccess.AddParameter("IterationSysId", IterationSysId, ParameterDirection.Input);
            this._dataAccess.AddParameter("KeyPath", KeyPath, ParameterDirection.Input);
            this._dataAccess.AddParameter("KeyValue", KeyValue, ParameterDirection.Input);
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
