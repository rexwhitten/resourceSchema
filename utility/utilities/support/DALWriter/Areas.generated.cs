namespace resourceSchema.Dal {
    using System;
    using System.Collections.Generic;
    using System.Data.SqlClient;
    using System.Configuration;
    using System.Data;
    using System.Xml;
    
    
    public partial class Areas : IDisposable {
        
        private DataAccess _dataAccess;
        
        public Areas() {
            this._dataAccess = new DataAccess();
        }
        
        public virtual System.Data.DataSet Select_Areass_By_AreaStatusSysId(System.Nullable<int> AreaStatusSysId) {
            this._dataAccess.CreateProcedureCommand("sp_Select_Areass_By_AreaStatusSysId");
            this._dataAccess.AddParameter("AreaStatusSysId", AreaStatusSysId, ParameterDirection.Input);
            DataSet value = this._dataAccess.ExecuteDataSet();
            return value;
        }
        
        public virtual System.Data.DataSet Select_Areass_By_AreaTypeSysId(System.Nullable<int> AreaTypeSysId) {
            this._dataAccess.CreateProcedureCommand("sp_Select_Areass_By_AreaTypeSysId");
            this._dataAccess.AddParameter("AreaTypeSysId", AreaTypeSysId, ParameterDirection.Input);
            DataSet value = this._dataAccess.ExecuteDataSet();
            return value;
        }
        
        public virtual System.Data.DataSet Areas_Select_All() {
            this._dataAccess.CreateProcedureCommand("sp_Areas_Select_All");
            DataSet value = this._dataAccess.ExecuteDataSet();
            return value;
        }
        
        public virtual System.Data.DataSet Areas_Select_One(System.Nullable<int> SysId) {
            this._dataAccess.CreateProcedureCommand("sp_Areas_Select_One");
            this._dataAccess.AddParameter("SysId", SysId, ParameterDirection.Input);
            DataSet value = this._dataAccess.ExecuteDataSet();
            return value;
        }
        
        public virtual System.Nullable<int> Areas_Insert(System.Nullable<int> AreaStatusSysId, System.Nullable<int> AreaTypeSysId, System.Nullable<System.Guid> PublicId, string Path, System.Nullable<System.DateTime> CreateDate, System.Nullable<System.DateTime> LastModifiedDate, System.Nullable<bool> Is_ReadOnly, System.Nullable<bool> Active) {
            this._dataAccess.CreateProcedureCommand("sp_Areas_Insert");
            this._dataAccess.AddParameter("AreaStatusSysId", AreaStatusSysId, ParameterDirection.Input);
            this._dataAccess.AddParameter("AreaTypeSysId", AreaTypeSysId, ParameterDirection.Input);
            this._dataAccess.AddParameter("PublicId", PublicId, ParameterDirection.Input);
            this._dataAccess.AddParameter("Path", Path, ParameterDirection.Input);
            this._dataAccess.AddParameter("CreateDate", CreateDate, ParameterDirection.Input);
            this._dataAccess.AddParameter("LastModifiedDate", LastModifiedDate, ParameterDirection.Input);
            this._dataAccess.AddParameter("Is_ReadOnly", Is_ReadOnly, ParameterDirection.Input);
            this._dataAccess.AddParameter("Active", Active, ParameterDirection.Input);
            int value = this._dataAccess.ExecuteNonQuery();
            return value;
        }
        
        public virtual System.Nullable<int> Areas_Delete(System.Nullable<int> SysId) {
            this._dataAccess.CreateProcedureCommand("sp_Areas_Delete");
            this._dataAccess.AddParameter("SysId", SysId, ParameterDirection.Input);
            int value = this._dataAccess.ExecuteNonQuery();
            return value;
        }
        
        public virtual System.Nullable<int> Areas_Update(System.Nullable<int> SysId, System.Nullable<int> AreaStatusSysId, System.Nullable<int> AreaTypeSysId, System.Nullable<System.Guid> PublicId, string Path, System.Nullable<System.DateTime> CreateDate, System.Nullable<System.DateTime> LastModifiedDate, System.Nullable<bool> Is_ReadOnly, System.Nullable<bool> Active) {
            this._dataAccess.CreateProcedureCommand("sp_Areas_Update");
            this._dataAccess.AddParameter("SysId", SysId, ParameterDirection.Input);
            this._dataAccess.AddParameter("AreaStatusSysId", AreaStatusSysId, ParameterDirection.Input);
            this._dataAccess.AddParameter("AreaTypeSysId", AreaTypeSysId, ParameterDirection.Input);
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
