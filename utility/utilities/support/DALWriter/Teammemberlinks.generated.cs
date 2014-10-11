namespace resourceSchema.Dal {
    using System;
    using System.Collections.Generic;
    using System.Data.SqlClient;
    using System.Configuration;
    using System.Data;
    using System.Xml;
    
    
    public partial class Teammemberlinks : IDisposable {
        
        private DataAccess _dataAccess;
        
        public Teammemberlinks() {
            this._dataAccess = new DataAccess();
        }
        
        public virtual System.Data.DataSet Select_TeamMemberLinkss_By_ParentTeamMemberSysId(System.Nullable<int> ParentTeamMemberSysId) {
            this._dataAccess.CreateProcedureCommand("sp_Select_TeamMemberLinkss_By_ParentTeamMemberSysId");
            this._dataAccess.AddParameter("ParentTeamMemberSysId", ParentTeamMemberSysId, ParameterDirection.Input);
            DataSet value = this._dataAccess.ExecuteDataSet();
            return value;
        }
        
        public virtual System.Data.DataSet Select_TeamMemberLinkss_By_ChildTeamMemberSysId(System.Nullable<int> ChildTeamMemberSysId) {
            this._dataAccess.CreateProcedureCommand("sp_Select_TeamMemberLinkss_By_ChildTeamMemberSysId");
            this._dataAccess.AddParameter("ChildTeamMemberSysId", ChildTeamMemberSysId, ParameterDirection.Input);
            DataSet value = this._dataAccess.ExecuteDataSet();
            return value;
        }
        
        public virtual System.Data.DataSet TeamMemberLinks_Select_All() {
            this._dataAccess.CreateProcedureCommand("sp_TeamMemberLinks_Select_All");
            DataSet value = this._dataAccess.ExecuteDataSet();
            return value;
        }
        
        public virtual System.Data.DataSet TeamMemberLinks_Select_One(System.Nullable<int> SysId) {
            this._dataAccess.CreateProcedureCommand("sp_TeamMemberLinks_Select_One");
            this._dataAccess.AddParameter("SysId", SysId, ParameterDirection.Input);
            DataSet value = this._dataAccess.ExecuteDataSet();
            return value;
        }
        
        public virtual System.Nullable<int> TeamMemberLinks_Insert(System.Nullable<System.Guid> PublicId, System.Nullable<int> ParentTeamMemberSysId, System.Nullable<int> ChildTeamMemberSysId, string LinkPath, System.Nullable<System.DateTime> CreateDate, System.Nullable<System.DateTime> LastModifiedDate, System.Nullable<bool> Active) {
            this._dataAccess.CreateProcedureCommand("sp_TeamMemberLinks_Insert");
            this._dataAccess.AddParameter("PublicId", PublicId, ParameterDirection.Input);
            this._dataAccess.AddParameter("ParentTeamMemberSysId", ParentTeamMemberSysId, ParameterDirection.Input);
            this._dataAccess.AddParameter("ChildTeamMemberSysId", ChildTeamMemberSysId, ParameterDirection.Input);
            this._dataAccess.AddParameter("LinkPath", LinkPath, ParameterDirection.Input);
            this._dataAccess.AddParameter("CreateDate", CreateDate, ParameterDirection.Input);
            this._dataAccess.AddParameter("LastModifiedDate", LastModifiedDate, ParameterDirection.Input);
            this._dataAccess.AddParameter("Active", Active, ParameterDirection.Input);
            int value = this._dataAccess.ExecuteNonQuery();
            return value;
        }
        
        public virtual System.Nullable<int> TeamMemberLinks_Delete(System.Nullable<int> SysId) {
            this._dataAccess.CreateProcedureCommand("sp_TeamMemberLinks_Delete");
            this._dataAccess.AddParameter("SysId", SysId, ParameterDirection.Input);
            int value = this._dataAccess.ExecuteNonQuery();
            return value;
        }
        
        public virtual System.Nullable<int> TeamMemberLinks_Update(System.Nullable<int> SysId, System.Nullable<System.Guid> PublicId, System.Nullable<int> ParentTeamMemberSysId, System.Nullable<int> ChildTeamMemberSysId, string LinkPath, System.Nullable<System.DateTime> CreateDate, System.Nullable<System.DateTime> LastModifiedDate, System.Nullable<bool> Active) {
            this._dataAccess.CreateProcedureCommand("sp_TeamMemberLinks_Update");
            this._dataAccess.AddParameter("SysId", SysId, ParameterDirection.Input);
            this._dataAccess.AddParameter("PublicId", PublicId, ParameterDirection.Input);
            this._dataAccess.AddParameter("ParentTeamMemberSysId", ParentTeamMemberSysId, ParameterDirection.Input);
            this._dataAccess.AddParameter("ChildTeamMemberSysId", ChildTeamMemberSysId, ParameterDirection.Input);
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
