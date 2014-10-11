namespace resourceSchema.Dal {
    using System;
    using System.Collections.Generic;
    using System.Data.SqlClient;
    using System.Configuration;
    using System.Data;
    using System.Xml;
    
    
    public partial class Taskteammembers : IDisposable {
        
        private DataAccess _dataAccess;
        
        public Taskteammembers() {
            this._dataAccess = new DataAccess();
        }
        
        public virtual System.Data.DataSet Select_TaskTeamMemberss_By_TaskSysId(System.Nullable<int> TaskSysId) {
            this._dataAccess.CreateProcedureCommand("sp_Select_TaskTeamMemberss_By_TaskSysId");
            this._dataAccess.AddParameter("TaskSysId", TaskSysId, ParameterDirection.Input);
            DataSet value = this._dataAccess.ExecuteDataSet();
            return value;
        }
        
        public virtual System.Data.DataSet Select_TaskTeamMemberss_By_TeamMembersysId(System.Nullable<int> TeamMembersysId) {
            this._dataAccess.CreateProcedureCommand("sp_Select_TaskTeamMemberss_By_TeamMembersysId");
            this._dataAccess.AddParameter("TeamMembersysId", TeamMembersysId, ParameterDirection.Input);
            DataSet value = this._dataAccess.ExecuteDataSet();
            return value;
        }
        
        public virtual System.Data.DataSet TaskTeamMembers_Select_All() {
            this._dataAccess.CreateProcedureCommand("sp_TaskTeamMembers_Select_All");
            DataSet value = this._dataAccess.ExecuteDataSet();
            return value;
        }
        
        public virtual System.Data.DataSet TaskTeamMembers_Select_One(System.Nullable<int> SysId) {
            this._dataAccess.CreateProcedureCommand("sp_TaskTeamMembers_Select_One");
            this._dataAccess.AddParameter("SysId", SysId, ParameterDirection.Input);
            DataSet value = this._dataAccess.ExecuteDataSet();
            return value;
        }
        
        public virtual System.Nullable<int> TaskTeamMembers_Insert(System.Nullable<System.Guid> PublicId, string Path, System.Nullable<int> TaskSysId, System.Nullable<int> TeamMembersysId, System.Nullable<System.DateTime> CreateDate, System.Nullable<bool> Active) {
            this._dataAccess.CreateProcedureCommand("sp_TaskTeamMembers_Insert");
            this._dataAccess.AddParameter("PublicId", PublicId, ParameterDirection.Input);
            this._dataAccess.AddParameter("Path", Path, ParameterDirection.Input);
            this._dataAccess.AddParameter("TaskSysId", TaskSysId, ParameterDirection.Input);
            this._dataAccess.AddParameter("TeamMembersysId", TeamMembersysId, ParameterDirection.Input);
            this._dataAccess.AddParameter("CreateDate", CreateDate, ParameterDirection.Input);
            this._dataAccess.AddParameter("Active", Active, ParameterDirection.Input);
            int value = this._dataAccess.ExecuteNonQuery();
            return value;
        }
        
        public virtual System.Nullable<int> TaskTeamMembers_Delete(System.Nullable<int> SysId) {
            this._dataAccess.CreateProcedureCommand("sp_TaskTeamMembers_Delete");
            this._dataAccess.AddParameter("SysId", SysId, ParameterDirection.Input);
            int value = this._dataAccess.ExecuteNonQuery();
            return value;
        }
        
        public virtual System.Nullable<int> TaskTeamMembers_Update(System.Nullable<int> SysId, System.Nullable<System.Guid> PublicId, string Path, System.Nullable<int> TaskSysId, System.Nullable<int> TeamMembersysId, System.Nullable<System.DateTime> CreateDate, System.Nullable<bool> Active) {
            this._dataAccess.CreateProcedureCommand("sp_TaskTeamMembers_Update");
            this._dataAccess.AddParameter("SysId", SysId, ParameterDirection.Input);
            this._dataAccess.AddParameter("PublicId", PublicId, ParameterDirection.Input);
            this._dataAccess.AddParameter("Path", Path, ParameterDirection.Input);
            this._dataAccess.AddParameter("TaskSysId", TaskSysId, ParameterDirection.Input);
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
