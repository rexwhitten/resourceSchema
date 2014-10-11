namespace resourceSchema.Dal {
    using System;
    using System.Collections.Generic;
    using System.Data.SqlClient;
    using System.Configuration;
    using System.Data;
    using System.Xml;
    
    
    public partial class Timeentrymetadata : IDisposable {
        
        private DataAccess _dataAccess;
        
        public Timeentrymetadata() {
            this._dataAccess = new DataAccess();
        }
        
        public virtual System.Data.DataSet Select_TimeEntryMetaDatas_By_TimeEntrySysId(System.Nullable<int> TimeEntrySysId) {
            this._dataAccess.CreateProcedureCommand("sp_Select_TimeEntryMetaDatas_By_TimeEntrySysId");
            this._dataAccess.AddParameter("TimeEntrySysId", TimeEntrySysId, ParameterDirection.Input);
            DataSet value = this._dataAccess.ExecuteDataSet();
            return value;
        }
        
        public virtual System.Data.DataSet TimeEntryMetaData_Select_All() {
            this._dataAccess.CreateProcedureCommand("sp_TimeEntryMetaData_Select_All");
            DataSet value = this._dataAccess.ExecuteDataSet();
            return value;
        }
        
        public virtual System.Data.DataSet TimeEntryMetaData_Select_One(System.Nullable<int> SysId) {
            this._dataAccess.CreateProcedureCommand("sp_TimeEntryMetaData_Select_One");
            this._dataAccess.AddParameter("SysId", SysId, ParameterDirection.Input);
            DataSet value = this._dataAccess.ExecuteDataSet();
            return value;
        }
        
        public virtual System.Nullable<int> TimeEntryMetaData_Insert(System.Nullable<System.Guid> PublicId, System.Nullable<int> TimeEntrySysId, string KeyPath, string KeyValue, System.Nullable<bool> Active) {
            this._dataAccess.CreateProcedureCommand("sp_TimeEntryMetaData_Insert");
            this._dataAccess.AddParameter("PublicId", PublicId, ParameterDirection.Input);
            this._dataAccess.AddParameter("TimeEntrySysId", TimeEntrySysId, ParameterDirection.Input);
            this._dataAccess.AddParameter("KeyPath", KeyPath, ParameterDirection.Input);
            this._dataAccess.AddParameter("KeyValue", KeyValue, ParameterDirection.Input);
            this._dataAccess.AddParameter("Active", Active, ParameterDirection.Input);
            int value = this._dataAccess.ExecuteNonQuery();
            return value;
        }
        
        public virtual System.Nullable<int> TimeEntryMetaData_Delete(System.Nullable<int> SysId) {
            this._dataAccess.CreateProcedureCommand("sp_TimeEntryMetaData_Delete");
            this._dataAccess.AddParameter("SysId", SysId, ParameterDirection.Input);
            int value = this._dataAccess.ExecuteNonQuery();
            return value;
        }
        
        public virtual System.Nullable<int> TimeEntryMetaData_Update(System.Nullable<int> SysId, System.Nullable<System.Guid> PublicId, System.Nullable<int> TimeEntrySysId, string KeyPath, string KeyValue, System.Nullable<bool> Active) {
            this._dataAccess.CreateProcedureCommand("sp_TimeEntryMetaData_Update");
            this._dataAccess.AddParameter("SysId", SysId, ParameterDirection.Input);
            this._dataAccess.AddParameter("PublicId", PublicId, ParameterDirection.Input);
            this._dataAccess.AddParameter("TimeEntrySysId", TimeEntrySysId, ParameterDirection.Input);
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
