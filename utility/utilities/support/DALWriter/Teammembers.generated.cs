namespace resourceSchema.Dal {
    using System;
    using System.Collections.Generic;
    using System.Data.SqlClient;
    using System.Configuration;
    using System.Data;
    using System.Xml;
    
    
    public partial class Teammembers : IDisposable {
        
        private DataAccess _dataAccess;
        
        public Teammembers() {
            this._dataAccess = new DataAccess();
        }
        
        public virtual System.Data.DataSet Select_TeamMemberss_By_TeamMemberStatusSysId(System.Nullable<int> TeamMemberStatusSysId) {
            this._dataAccess.CreateProcedureCommand("sp_Select_TeamMemberss_By_TeamMemberStatusSysId");
            this._dataAccess.AddParameter("TeamMemberStatusSysId", TeamMemberStatusSysId, ParameterDirection.Input);
            DataSet value = this._dataAccess.ExecuteDataSet();
            return value;
        }
        
        public virtual System.Data.DataSet Select_TeamMemberss_By_TeamMemberTypeSysId(System.Nullable<int> TeamMemberTypeSysId) {
            this._dataAccess.CreateProcedureCommand("sp_Select_TeamMemberss_By_TeamMemberTypeSysId");
            this._dataAccess.AddParameter("TeamMemberTypeSysId", TeamMemberTypeSysId, ParameterDirection.Input);
            DataSet value = this._dataAccess.ExecuteDataSet();
            return value;
        }
        
        public virtual System.Data.DataSet TeamMembers_Select_All() {
            this._dataAccess.CreateProcedureCommand("sp_TeamMembers_Select_All");
            DataSet value = this._dataAccess.ExecuteDataSet();
            return value;
        }
        
        public virtual System.Data.DataSet TeamMembers_Select_One(System.Nullable<int> SysId) {
            this._dataAccess.CreateProcedureCommand("sp_TeamMembers_Select_One");
            this._dataAccess.AddParameter("SysId", SysId, ParameterDirection.Input);
            DataSet value = this._dataAccess.ExecuteDataSet();
            return value;
        }
        
        public virtual System.Nullable<int> TeamMembers_Insert(System.Nullable<int> TeamMemberStatusSysId, System.Nullable<int> TeamMemberTypeSysId, System.Nullable<System.Guid> PublicId, string Path, System.Nullable<System.DateTime> CreateDate, System.Nullable<System.DateTime> LastModifiedDate, System.Nullable<bool> Is_ReadOnly, System.Nullable<bool> Active) {
            this._dataAccess.CreateProcedureCommand("sp_TeamMembers_Insert");
            this._dataAccess.AddParameter("TeamMemberStatusSysId", TeamMemberStatusSysId, ParameterDirection.Input);
            this._dataAccess.AddParameter("TeamMemberTypeSysId", TeamMemberTypeSysId, ParameterDirection.Input);
            this._dataAccess.AddParameter("PublicId", PublicId, ParameterDirection.Input);
            this._dataAccess.AddParameter("Path", Path, ParameterDirection.Input);
            this._dataAccess.AddParameter("CreateDate", CreateDate, ParameterDirection.Input);
            this._dataAccess.AddParameter("LastModifiedDate", LastModifiedDate, ParameterDirection.Input);
            this._dataAccess.AddParameter("Is_ReadOnly", Is_ReadOnly, ParameterDirection.Input);
            this._dataAccess.AddParameter("Active", Active, ParameterDirection.Input);
            int value = this._dataAccess.ExecuteNonQuery();
            return value;
        }
        
        public virtual System.Nullable<int> TeamMembers_Delete(System.Nullable<int> SysId) {
            this._dataAccess.CreateProcedureCommand("sp_TeamMembers_Delete");
            this._dataAccess.AddParameter("SysId", SysId, ParameterDirection.Input);
            int value = this._dataAccess.ExecuteNonQuery();
            return value;
        }
        
        public virtual System.Nullable<int> TeamMembers_Update(System.Nullable<int> SysId, System.Nullable<int> TeamMemberStatusSysId, System.Nullable<int> TeamMemberTypeSysId, System.Nullable<System.Guid> PublicId, string Path, System.Nullable<System.DateTime> CreateDate, System.Nullable<System.DateTime> LastModifiedDate, System.Nullable<bool> Is_ReadOnly, System.Nullable<bool> Active) {
            this._dataAccess.CreateProcedureCommand("sp_TeamMembers_Update");
            this._dataAccess.AddParameter("SysId", SysId, ParameterDirection.Input);
            this._dataAccess.AddParameter("TeamMemberStatusSysId", TeamMemberStatusSysId, ParameterDirection.Input);
            this._dataAccess.AddParameter("TeamMemberTypeSysId", TeamMemberTypeSysId, ParameterDirection.Input);
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
