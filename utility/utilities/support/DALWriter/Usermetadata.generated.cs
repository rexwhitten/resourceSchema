namespace resourceSchema.Dal {
    using System;
    using System.Collections.Generic;
    using System.Data.SqlClient;
    using System.Configuration;
    using System.Data;
    using System.Xml;
    
    
    public partial class Usermetadata : IDisposable {
        
        private DataAccess _dataAccess;
        
        public Usermetadata() {
            this._dataAccess = new DataAccess();
        }
        
        public virtual System.Data.DataSet Select_UserMetaDatas_By_UserSysId(System.Nullable<int> UserSysId) {
            this._dataAccess.CreateProcedureCommand("sp_Select_UserMetaDatas_By_UserSysId");
            this._dataAccess.AddParameter("UserSysId", UserSysId, ParameterDirection.Input);
            DataSet value = this._dataAccess.ExecuteDataSet();
            return value;
        }
        
        public virtual System.Data.DataSet UserMetaData_Select_All() {
            this._dataAccess.CreateProcedureCommand("sp_UserMetaData_Select_All");
            DataSet value = this._dataAccess.ExecuteDataSet();
            return value;
        }
        
        public virtual System.Data.DataSet UserMetaData_Select_One(System.Nullable<int> SysId) {
            this._dataAccess.CreateProcedureCommand("sp_UserMetaData_Select_One");
            this._dataAccess.AddParameter("SysId", SysId, ParameterDirection.Input);
            DataSet value = this._dataAccess.ExecuteDataSet();
            return value;
        }
        
        public virtual System.Nullable<int> UserMetaData_Insert(System.Nullable<System.Guid> PublicId, System.Nullable<int> UserSysId, string KeyPath, string KeyValue, System.Nullable<bool> Active) {
            this._dataAccess.CreateProcedureCommand("sp_UserMetaData_Insert");
            this._dataAccess.AddParameter("PublicId", PublicId, ParameterDirection.Input);
            this._dataAccess.AddParameter("UserSysId", UserSysId, ParameterDirection.Input);
            this._dataAccess.AddParameter("KeyPath", KeyPath, ParameterDirection.Input);
            this._dataAccess.AddParameter("KeyValue", KeyValue, ParameterDirection.Input);
            this._dataAccess.AddParameter("Active", Active, ParameterDirection.Input);
            int value = this._dataAccess.ExecuteNonQuery();
            return value;
        }
        
        public virtual System.Nullable<int> UserMetaData_Delete(System.Nullable<int> SysId) {
            this._dataAccess.CreateProcedureCommand("sp_UserMetaData_Delete");
            this._dataAccess.AddParameter("SysId", SysId, ParameterDirection.Input);
            int value = this._dataAccess.ExecuteNonQuery();
            return value;
        }
        
        public virtual System.Nullable<int> UserMetaData_Update(System.Nullable<int> SysId, System.Nullable<System.Guid> PublicId, System.Nullable<int> UserSysId, string KeyPath, string KeyValue, System.Nullable<bool> Active) {
            this._dataAccess.CreateProcedureCommand("sp_UserMetaData_Update");
            this._dataAccess.AddParameter("SysId", SysId, ParameterDirection.Input);
            this._dataAccess.AddParameter("PublicId", PublicId, ParameterDirection.Input);
            this._dataAccess.AddParameter("UserSysId", UserSysId, ParameterDirection.Input);
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
