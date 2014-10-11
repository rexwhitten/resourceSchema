namespace resourceSchema.Dal {
    using System;
    using System.Collections.Generic;
    using System.Data.SqlClient;
    using System.Configuration;
    using System.Data;
    using System.Xml;
    
    
    public partial class Teams : IDisposable {
        
        private DataAccess _dataAccess;
        
        public Teams() {
            this._dataAccess = new DataAccess();
        }
        
        public virtual System.Data.DataSet Select_Teamss_By_TeamStatusSysId(System.Nullable<int> TeamStatusSysId) {
            this._dataAccess.CreateProcedureCommand("sp_Select_Teamss_By_TeamStatusSysId");
            this._dataAccess.AddParameter("TeamStatusSysId", TeamStatusSysId, ParameterDirection.Input);
            DataSet value = this._dataAccess.ExecuteDataSet();
            return value;
        }
        
        public virtual System.Data.DataSet Select_Teamss_By_TeamTypeSysId(System.Nullable<int> TeamTypeSysId) {
            this._dataAccess.CreateProcedureCommand("sp_Select_Teamss_By_TeamTypeSysId");
            this._dataAccess.AddParameter("TeamTypeSysId", TeamTypeSysId, ParameterDirection.Input);
            DataSet value = this._dataAccess.ExecuteDataSet();
            return value;
        }
        
        public virtual System.Data.DataSet Teams_Select_All() {
            this._dataAccess.CreateProcedureCommand("sp_Teams_Select_All");
            DataSet value = this._dataAccess.ExecuteDataSet();
            return value;
        }
        
        public virtual System.Data.DataSet Teams_Select_One(System.Nullable<int> SysId) {
            this._dataAccess.CreateProcedureCommand("sp_Teams_Select_One");
            this._dataAccess.AddParameter("SysId", SysId, ParameterDirection.Input);
            DataSet value = this._dataAccess.ExecuteDataSet();
            return value;
        }
        
        public virtual System.Nullable<int> Teams_Insert(System.Nullable<int> TeamStatusSysId, System.Nullable<int> TeamTypeSysId, System.Nullable<System.Guid> PublicId, string Path, System.Nullable<System.DateTime> CreateDate, System.Nullable<System.DateTime> LastModifiedDate, System.Nullable<bool> Is_ReadOnly, System.Nullable<bool> Active) {
            this._dataAccess.CreateProcedureCommand("sp_Teams_Insert");
            this._dataAccess.AddParameter("TeamStatusSysId", TeamStatusSysId, ParameterDirection.Input);
            this._dataAccess.AddParameter("TeamTypeSysId", TeamTypeSysId, ParameterDirection.Input);
            this._dataAccess.AddParameter("PublicId", PublicId, ParameterDirection.Input);
            this._dataAccess.AddParameter("Path", Path, ParameterDirection.Input);
            this._dataAccess.AddParameter("CreateDate", CreateDate, ParameterDirection.Input);
            this._dataAccess.AddParameter("LastModifiedDate", LastModifiedDate, ParameterDirection.Input);
            this._dataAccess.AddParameter("Is_ReadOnly", Is_ReadOnly, ParameterDirection.Input);
            this._dataAccess.AddParameter("Active", Active, ParameterDirection.Input);
            int value = this._dataAccess.ExecuteNonQuery();
            return value;
        }
        
        public virtual System.Nullable<int> Teams_Delete(System.Nullable<int> SysId) {
            this._dataAccess.CreateProcedureCommand("sp_Teams_Delete");
            this._dataAccess.AddParameter("SysId", SysId, ParameterDirection.Input);
            int value = this._dataAccess.ExecuteNonQuery();
            return value;
        }
        
        public virtual System.Nullable<int> Teams_Update(System.Nullable<int> SysId, System.Nullable<int> TeamStatusSysId, System.Nullable<int> TeamTypeSysId, System.Nullable<System.Guid> PublicId, string Path, System.Nullable<System.DateTime> CreateDate, System.Nullable<System.DateTime> LastModifiedDate, System.Nullable<bool> Is_ReadOnly, System.Nullable<bool> Active) {
            this._dataAccess.CreateProcedureCommand("sp_Teams_Update");
            this._dataAccess.AddParameter("SysId", SysId, ParameterDirection.Input);
            this._dataAccess.AddParameter("TeamStatusSysId", TeamStatusSysId, ParameterDirection.Input);
            this._dataAccess.AddParameter("TeamTypeSysId", TeamTypeSysId, ParameterDirection.Input);
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
