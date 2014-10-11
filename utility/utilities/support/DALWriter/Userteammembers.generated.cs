namespace resourceSchema.Dal {
    using System;
    using System.Collections.Generic;
    using System.Data.SqlClient;
    using System.Configuration;
    using System.Data;
    using System.Xml;
    
    
    public partial class Userteammembers : IDisposable {
        
        private DataAccess _dataAccess;
        
        public Userteammembers() {
            this._dataAccess = new DataAccess();
        }
        
        public virtual System.Data.DataSet Select_UserTeamMemberss_By_TeamMembersysId(System.Nullable<int> TeamMembersysId) {
            this._dataAccess.CreateProcedureCommand("sp_Select_UserTeamMemberss_By_TeamMembersysId");
            this._dataAccess.AddParameter("TeamMembersysId", TeamMembersysId, ParameterDirection.Input);
            DataSet value = this._dataAccess.ExecuteDataSet();
            return value;
        }
        
        public virtual System.Data.DataSet Select_UserTeamMemberss_By_UserSysId(System.Nullable<int> UserSysId) {
            this._dataAccess.CreateProcedureCommand("sp_Select_UserTeamMemberss_By_UserSysId");
            this._dataAccess.AddParameter("UserSysId", UserSysId, ParameterDirection.Input);
            DataSet value = this._dataAccess.ExecuteDataSet();
            return value;
        }
        
        public virtual System.Data.DataSet UserTeamMembers_Select_All() {
            this._dataAccess.CreateProcedureCommand("sp_UserTeamMembers_Select_All");
            DataSet value = this._dataAccess.ExecuteDataSet();
            return value;
        }
        
        public virtual System.Data.DataSet UserTeamMembers_Select_One(System.Nullable<int> SysId) {
            this._dataAccess.CreateProcedureCommand("sp_UserTeamMembers_Select_One");
            this._dataAccess.AddParameter("SysId", SysId, ParameterDirection.Input);
            DataSet value = this._dataAccess.ExecuteDataSet();
            return value;
        }
        
        public virtual System.Nullable<int> UserTeamMembers_Insert(System.Nullable<System.Guid> PublicId, string Path, System.Nullable<int> UserSysId, System.Nullable<int> TeamMembersysId, System.Nullable<System.DateTime> CreateDate, System.Nullable<bool> Active) {
            this._dataAccess.CreateProcedureCommand("sp_UserTeamMembers_Insert");
            this._dataAccess.AddParameter("PublicId", PublicId, ParameterDirection.Input);
            this._dataAccess.AddParameter("Path", Path, ParameterDirection.Input);
            this._dataAccess.AddParameter("UserSysId", UserSysId, ParameterDirection.Input);
            this._dataAccess.AddParameter("TeamMembersysId", TeamMembersysId, ParameterDirection.Input);
            this._dataAccess.AddParameter("CreateDate", CreateDate, ParameterDirection.Input);
            this._dataAccess.AddParameter("Active", Active, ParameterDirection.Input);
            int value = this._dataAccess.ExecuteNonQuery();
            return value;
        }
        
        public virtual System.Nullable<int> UserTeamMembers_Delete(System.Nullable<int> SysId) {
            this._dataAccess.CreateProcedureCommand("sp_UserTeamMembers_Delete");
            this._dataAccess.AddParameter("SysId", SysId, ParameterDirection.Input);
            int value = this._dataAccess.ExecuteNonQuery();
            return value;
        }
        
        public virtual System.Nullable<int> UserTeamMembers_Update(System.Nullable<int> SysId, System.Nullable<System.Guid> PublicId, string Path, System.Nullable<int> UserSysId, System.Nullable<int> TeamMembersysId, System.Nullable<System.DateTime> CreateDate, System.Nullable<bool> Active) {
            this._dataAccess.CreateProcedureCommand("sp_UserTeamMembers_Update");
            this._dataAccess.AddParameter("SysId", SysId, ParameterDirection.Input);
            this._dataAccess.AddParameter("PublicId", PublicId, ParameterDirection.Input);
            this._dataAccess.AddParameter("Path", Path, ParameterDirection.Input);
            this._dataAccess.AddParameter("UserSysId", UserSysId, ParameterDirection.Input);
            this._dataAccess.AddParameter("TeamMembersysId", TeamMembersysId, ParameterDirection.Input);
            this._dataAccess.AddParameter("CreateDate", CreateDate, ParameterDirection.Input);
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
