namespace resourceSchema.Dal {
    using System;
    using System.Collections.Generic;
    using System.Data.SqlClient;
    using System.Configuration;
    using System.Data;
    using System.Xml;
    
    
    public partial class Teamteammembers : IDisposable {
        
        private DataAccess _dataAccess;
        
        public Teamteammembers() {
            this._dataAccess = new DataAccess();
        }
        
        public virtual System.Data.DataSet Select_TeamTeamMemberss_By_TeamMembersysId(System.Nullable<int> TeamMembersysId) {
            this._dataAccess.CreateProcedureCommand("sp_Select_TeamTeamMemberss_By_TeamMembersysId");
            this._dataAccess.AddParameter("TeamMembersysId", TeamMembersysId, ParameterDirection.Input);
            DataSet value = this._dataAccess.ExecuteDataSet();
            return value;
        }
        
        public virtual System.Data.DataSet Select_TeamTeamMemberss_By_TeamSysId(System.Nullable<int> TeamSysId) {
            this._dataAccess.CreateProcedureCommand("sp_Select_TeamTeamMemberss_By_TeamSysId");
            this._dataAccess.AddParameter("TeamSysId", TeamSysId, ParameterDirection.Input);
            DataSet value = this._dataAccess.ExecuteDataSet();
            return value;
        }
        
        public virtual System.Data.DataSet TeamTeamMembers_Select_All() {
            this._dataAccess.CreateProcedureCommand("sp_TeamTeamMembers_Select_All");
            DataSet value = this._dataAccess.ExecuteDataSet();
            return value;
        }
        
        public virtual System.Data.DataSet TeamTeamMembers_Select_One(System.Nullable<int> SysId) {
            this._dataAccess.CreateProcedureCommand("sp_TeamTeamMembers_Select_One");
            this._dataAccess.AddParameter("SysId", SysId, ParameterDirection.Input);
            DataSet value = this._dataAccess.ExecuteDataSet();
            return value;
        }
        
        public virtual System.Nullable<int> TeamTeamMembers_Insert(System.Nullable<System.Guid> PublicId, string Path, System.Nullable<int> TeamSysId, System.Nullable<int> TeamMembersysId, System.Nullable<System.DateTime> CreateDate, System.Nullable<bool> Active) {
            this._dataAccess.CreateProcedureCommand("sp_TeamTeamMembers_Insert");
            this._dataAccess.AddParameter("PublicId", PublicId, ParameterDirection.Input);
            this._dataAccess.AddParameter("Path", Path, ParameterDirection.Input);
            this._dataAccess.AddParameter("TeamSysId", TeamSysId, ParameterDirection.Input);
            this._dataAccess.AddParameter("TeamMembersysId", TeamMembersysId, ParameterDirection.Input);
            this._dataAccess.AddParameter("CreateDate", CreateDate, ParameterDirection.Input);
            this._dataAccess.AddParameter("Active", Active, ParameterDirection.Input);
            int value = this._dataAccess.ExecuteNonQuery();
            return value;
        }
        
        public virtual System.Nullable<int> TeamTeamMembers_Delete(System.Nullable<int> SysId) {
            this._dataAccess.CreateProcedureCommand("sp_TeamTeamMembers_Delete");
            this._dataAccess.AddParameter("SysId", SysId, ParameterDirection.Input);
            int value = this._dataAccess.ExecuteNonQuery();
            return value;
        }
        
        public virtual System.Nullable<int> TeamTeamMembers_Update(System.Nullable<int> SysId, System.Nullable<System.Guid> PublicId, string Path, System.Nullable<int> TeamSysId, System.Nullable<int> TeamMembersysId, System.Nullable<System.DateTime> CreateDate, System.Nullable<bool> Active) {
            this._dataAccess.CreateProcedureCommand("sp_TeamTeamMembers_Update");
            this._dataAccess.AddParameter("SysId", SysId, ParameterDirection.Input);
            this._dataAccess.AddParameter("PublicId", PublicId, ParameterDirection.Input);
            this._dataAccess.AddParameter("Path", Path, ParameterDirection.Input);
            this._dataAccess.AddParameter("TeamSysId", TeamSysId, ParameterDirection.Input);
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
