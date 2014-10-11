namespace resourceSchema.Dal {
    using System;
    using System.Collections.Generic;
    using System.Data.SqlClient;
    using System.Configuration;
    using System.Data;
    using System.Xml;
    
    
    public partial class Tasks : IDisposable {
        
        private DataAccess _dataAccess;
        
        public Tasks() {
            this._dataAccess = new DataAccess();
        }
        
        public virtual System.Data.DataSet Select_Taskss_By_TaskStatusSysId(System.Nullable<int> TaskStatusSysId) {
            this._dataAccess.CreateProcedureCommand("sp_Select_Taskss_By_TaskStatusSysId");
            this._dataAccess.AddParameter("TaskStatusSysId", TaskStatusSysId, ParameterDirection.Input);
            DataSet value = this._dataAccess.ExecuteDataSet();
            return value;
        }
        
        public virtual System.Data.DataSet Select_Taskss_By_TaskTypeSysId(System.Nullable<int> TaskTypeSysId) {
            this._dataAccess.CreateProcedureCommand("sp_Select_Taskss_By_TaskTypeSysId");
            this._dataAccess.AddParameter("TaskTypeSysId", TaskTypeSysId, ParameterDirection.Input);
            DataSet value = this._dataAccess.ExecuteDataSet();
            return value;
        }
        
        public virtual System.Data.DataSet Tasks_Select_All() {
            this._dataAccess.CreateProcedureCommand("sp_Tasks_Select_All");
            DataSet value = this._dataAccess.ExecuteDataSet();
            return value;
        }
        
        public virtual System.Data.DataSet Tasks_Select_One(System.Nullable<int> SysId) {
            this._dataAccess.CreateProcedureCommand("sp_Tasks_Select_One");
            this._dataAccess.AddParameter("SysId", SysId, ParameterDirection.Input);
            DataSet value = this._dataAccess.ExecuteDataSet();
            return value;
        }
        
        public virtual System.Nullable<int> Tasks_Insert(System.Nullable<int> TaskStatusSysId, System.Nullable<int> TaskTypeSysId, System.Nullable<System.Guid> PublicId, string Path, System.Nullable<System.DateTime> CreateDate, System.Nullable<System.DateTime> LastModifiedDate, System.Nullable<bool> Is_ReadOnly, System.Nullable<bool> Active) {
            this._dataAccess.CreateProcedureCommand("sp_Tasks_Insert");
            this._dataAccess.AddParameter("TaskStatusSysId", TaskStatusSysId, ParameterDirection.Input);
            this._dataAccess.AddParameter("TaskTypeSysId", TaskTypeSysId, ParameterDirection.Input);
            this._dataAccess.AddParameter("PublicId", PublicId, ParameterDirection.Input);
            this._dataAccess.AddParameter("Path", Path, ParameterDirection.Input);
            this._dataAccess.AddParameter("CreateDate", CreateDate, ParameterDirection.Input);
            this._dataAccess.AddParameter("LastModifiedDate", LastModifiedDate, ParameterDirection.Input);
            this._dataAccess.AddParameter("Is_ReadOnly", Is_ReadOnly, ParameterDirection.Input);
            this._dataAccess.AddParameter("Active", Active, ParameterDirection.Input);
            int value = this._dataAccess.ExecuteNonQuery();
            return value;
        }
        
        public virtual System.Nullable<int> Tasks_Delete(System.Nullable<int> SysId) {
            this._dataAccess.CreateProcedureCommand("sp_Tasks_Delete");
            this._dataAccess.AddParameter("SysId", SysId, ParameterDirection.Input);
            int value = this._dataAccess.ExecuteNonQuery();
            return value;
        }
        
        public virtual System.Nullable<int> Tasks_Update(System.Nullable<int> SysId, System.Nullable<int> TaskStatusSysId, System.Nullable<int> TaskTypeSysId, System.Nullable<System.Guid> PublicId, string Path, System.Nullable<System.DateTime> CreateDate, System.Nullable<System.DateTime> LastModifiedDate, System.Nullable<bool> Is_ReadOnly, System.Nullable<bool> Active) {
            this._dataAccess.CreateProcedureCommand("sp_Tasks_Update");
            this._dataAccess.AddParameter("SysId", SysId, ParameterDirection.Input);
            this._dataAccess.AddParameter("TaskStatusSysId", TaskStatusSysId, ParameterDirection.Input);
            this._dataAccess.AddParameter("TaskTypeSysId", TaskTypeSysId, ParameterDirection.Input);
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
