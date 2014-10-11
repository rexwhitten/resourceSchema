namespace resourceSchema.Dal {
    using System;
    using System.Collections.Generic;
    using System.Data.SqlClient;
    using System.Configuration;
    using System.Data;
    using System.Xml;
    
    
    public partial class Teamlinks : IDisposable {
        
        private DataAccess _dataAccess;
        
        public Teamlinks() {
            this._dataAccess = new DataAccess();
        }
        
        public virtual System.Data.DataSet Select_TeamLinkss_By_ParentTeamSysId(System.Nullable<int> ParentTeamSysId) {
            this._dataAccess.CreateProcedureCommand("sp_Select_TeamLinkss_By_ParentTeamSysId");
            this._dataAccess.AddParameter("ParentTeamSysId", ParentTeamSysId, ParameterDirection.Input);
            DataSet value = this._dataAccess.ExecuteDataSet();
            return value;
        }
        
        public virtual System.Data.DataSet Select_TeamLinkss_By_ChildTeamSysId(System.Nullable<int> ChildTeamSysId) {
            this._dataAccess.CreateProcedureCommand("sp_Select_TeamLinkss_By_ChildTeamSysId");
            this._dataAccess.AddParameter("ChildTeamSysId", ChildTeamSysId, ParameterDirection.Input);
            DataSet value = this._dataAccess.ExecuteDataSet();
            return value;
        }
        
        public virtual System.Data.DataSet TeamLinks_Select_All() {
            this._dataAccess.CreateProcedureCommand("sp_TeamLinks_Select_All");
            DataSet value = this._dataAccess.ExecuteDataSet();
            return value;
        }
        
        public virtual System.Data.DataSet TeamLinks_Select_One(System.Nullable<int> SysId) {
            this._dataAccess.CreateProcedureCommand("sp_TeamLinks_Select_One");
            this._dataAccess.AddParameter("SysId", SysId, ParameterDirection.Input);
            DataSet value = this._dataAccess.ExecuteDataSet();
            return value;
        }
        
        public virtual System.Nullable<int> TeamLinks_Insert(System.Nullable<System.Guid> PublicId, System.Nullable<int> ParentTeamSysId, System.Nullable<int> ChildTeamSysId, string LinkPath, System.Nullable<System.DateTime> CreateDate, System.Nullable<System.DateTime> LastModifiedDate, System.Nullable<bool> Active) {
            this._dataAccess.CreateProcedureCommand("sp_TeamLinks_Insert");
            this._dataAccess.AddParameter("PublicId", PublicId, ParameterDirection.Input);
            this._dataAccess.AddParameter("ParentTeamSysId", ParentTeamSysId, ParameterDirection.Input);
            this._dataAccess.AddParameter("ChildTeamSysId", ChildTeamSysId, ParameterDirection.Input);
            this._dataAccess.AddParameter("LinkPath", LinkPath, ParameterDirection.Input);
            this._dataAccess.AddParameter("CreateDate", CreateDate, ParameterDirection.Input);
            this._dataAccess.AddParameter("LastModifiedDate", LastModifiedDate, ParameterDirection.Input);
            this._dataAccess.AddParameter("Active", Active, ParameterDirection.Input);
            int value = this._dataAccess.ExecuteNonQuery();
            return value;
        }
        
        public virtual System.Nullable<int> TeamLinks_Delete(System.Nullable<int> SysId) {
            this._dataAccess.CreateProcedureCommand("sp_TeamLinks_Delete");
            this._dataAccess.AddParameter("SysId", SysId, ParameterDirection.Input);
            int value = this._dataAccess.ExecuteNonQuery();
            return value;
        }
        
        public virtual System.Nullable<int> TeamLinks_Update(System.Nullable<int> SysId, System.Nullable<System.Guid> PublicId, System.Nullable<int> ParentTeamSysId, System.Nullable<int> ChildTeamSysId, string LinkPath, System.Nullable<System.DateTime> CreateDate, System.Nullable<System.DateTime> LastModifiedDate, System.Nullable<bool> Active) {
            this._dataAccess.CreateProcedureCommand("sp_TeamLinks_Update");
            this._dataAccess.AddParameter("SysId", SysId, ParameterDirection.Input);
            this._dataAccess.AddParameter("PublicId", PublicId, ParameterDirection.Input);
            this._dataAccess.AddParameter("ParentTeamSysId", ParentTeamSysId, ParameterDirection.Input);
            this._dataAccess.AddParameter("ChildTeamSysId", ChildTeamSysId, ParameterDirection.Input);
            this._dataAccess.AddParameter("LinkPath", LinkPath, ParameterDirection.Input);
            this._dataAccess.AddParameter("CreateDate", CreateDate, ParameterDirection.Input);
            this._dataAccess.AddParameter("LastModifiedDate", LastModifiedDate, ParameterDirection.Input);
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
