namespace resourceSchema.Dal {
    using System;
    using System.Collections.Generic;
    using System.Data.SqlClient;
    using System.Configuration;
    using System.Data;
    using System.Xml;
    
    
    public partial class Projectteams : IDisposable {
        
        private DataAccess _dataAccess;
        
        public Projectteams() {
            this._dataAccess = new DataAccess();
        }
        
        public virtual System.Data.DataSet Select_ProjectTeamss_By_ProjectSysId(System.Nullable<int> ProjectSysId) {
            this._dataAccess.CreateProcedureCommand("sp_Select_ProjectTeamss_By_ProjectSysId");
            this._dataAccess.AddParameter("ProjectSysId", ProjectSysId, ParameterDirection.Input);
            DataSet value = this._dataAccess.ExecuteDataSet();
            return value;
        }
        
        public virtual System.Data.DataSet Select_ProjectTeamss_By_TeamsysId(System.Nullable<int> TeamsysId) {
            this._dataAccess.CreateProcedureCommand("sp_Select_ProjectTeamss_By_TeamsysId");
            this._dataAccess.AddParameter("TeamsysId", TeamsysId, ParameterDirection.Input);
            DataSet value = this._dataAccess.ExecuteDataSet();
            return value;
        }
        
        public virtual System.Data.DataSet ProjectTeams_Select_All() {
            this._dataAccess.CreateProcedureCommand("sp_ProjectTeams_Select_All");
            DataSet value = this._dataAccess.ExecuteDataSet();
            return value;
        }
        
        public virtual System.Data.DataSet ProjectTeams_Select_One(System.Nullable<int> SysId) {
            this._dataAccess.CreateProcedureCommand("sp_ProjectTeams_Select_One");
            this._dataAccess.AddParameter("SysId", SysId, ParameterDirection.Input);
            DataSet value = this._dataAccess.ExecuteDataSet();
            return value;
        }
        
        public virtual System.Nullable<int> ProjectTeams_Insert(System.Nullable<System.Guid> PublicId, string Path, System.Nullable<int> ProjectSysId, System.Nullable<int> TeamsysId, System.Nullable<System.DateTime> CreateDate, System.Nullable<bool> Active) {
            this._dataAccess.CreateProcedureCommand("sp_ProjectTeams_Insert");
            this._dataAccess.AddParameter("PublicId", PublicId, ParameterDirection.Input);
            this._dataAccess.AddParameter("Path", Path, ParameterDirection.Input);
            this._dataAccess.AddParameter("ProjectSysId", ProjectSysId, ParameterDirection.Input);
            this._dataAccess.AddParameter("TeamsysId", TeamsysId, ParameterDirection.Input);
            this._dataAccess.AddParameter("CreateDate", CreateDate, ParameterDirection.Input);
            this._dataAccess.AddParameter("Active", Active, ParameterDirection.Input);
            int value = this._dataAccess.ExecuteNonQuery();
            return value;
        }
        
        public virtual System.Nullable<int> ProjectTeams_Delete(System.Nullable<int> SysId) {
            this._dataAccess.CreateProcedureCommand("sp_ProjectTeams_Delete");
            this._dataAccess.AddParameter("SysId", SysId, ParameterDirection.Input);
            int value = this._dataAccess.ExecuteNonQuery();
            return value;
        }
        
        public virtual System.Nullable<int> ProjectTeams_Update(System.Nullable<int> SysId, System.Nullable<System.Guid> PublicId, string Path, System.Nullable<int> ProjectSysId, System.Nullable<int> TeamsysId, System.Nullable<System.DateTime> CreateDate, System.Nullable<bool> Active) {
            this._dataAccess.CreateProcedureCommand("sp_ProjectTeams_Update");
            this._dataAccess.AddParameter("SysId", SysId, ParameterDirection.Input);
            this._dataAccess.AddParameter("PublicId", PublicId, ParameterDirection.Input);
            this._dataAccess.AddParameter("Path", Path, ParameterDirection.Input);
            this._dataAccess.AddParameter("ProjectSysId", ProjectSysId, ParameterDirection.Input);
            this._dataAccess.AddParameter("TeamsysId", TeamsysId, ParameterDirection.Input);
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
