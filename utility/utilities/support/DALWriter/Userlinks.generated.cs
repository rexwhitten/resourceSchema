namespace resourceSchema.Dal {
    using System;
    using System.Collections.Generic;
    using System.Data.SqlClient;
    using System.Configuration;
    using System.Data;
    using System.Xml;
    
    
    public partial class Userlinks : IDisposable {
        
        private DataAccess _dataAccess;
        
        public Userlinks() {
            this._dataAccess = new DataAccess();
        }
        
        public virtual System.Data.DataSet Select_UserLinkss_By_ParentUserSysId(System.Nullable<int> ParentUserSysId) {
            this._dataAccess.CreateProcedureCommand("sp_Select_UserLinkss_By_ParentUserSysId");
            this._dataAccess.AddParameter("ParentUserSysId", ParentUserSysId, ParameterDirection.Input);
            DataSet value = this._dataAccess.ExecuteDataSet();
            return value;
        }
        
        public virtual System.Data.DataSet Select_UserLinkss_By_ChildUserSysId(System.Nullable<int> ChildUserSysId) {
            this._dataAccess.CreateProcedureCommand("sp_Select_UserLinkss_By_ChildUserSysId");
            this._dataAccess.AddParameter("ChildUserSysId", ChildUserSysId, ParameterDirection.Input);
            DataSet value = this._dataAccess.ExecuteDataSet();
            return value;
        }
        
        public virtual System.Data.DataSet UserLinks_Select_All() {
            this._dataAccess.CreateProcedureCommand("sp_UserLinks_Select_All");
            DataSet value = this._dataAccess.ExecuteDataSet();
            return value;
        }
        
        public virtual System.Data.DataSet UserLinks_Select_One(System.Nullable<int> SysId) {
            this._dataAccess.CreateProcedureCommand("sp_UserLinks_Select_One");
            this._dataAccess.AddParameter("SysId", SysId, ParameterDirection.Input);
            DataSet value = this._dataAccess.ExecuteDataSet();
            return value;
        }
        
        public virtual System.Nullable<int> UserLinks_Insert(System.Nullable<System.Guid> PublicId, System.Nullable<int> ParentUserSysId, System.Nullable<int> ChildUserSysId, string LinkPath, System.Nullable<System.DateTime> CreateDate, System.Nullable<System.DateTime> LastModifiedDate, System.Nullable<bool> Active) {
            this._dataAccess.CreateProcedureCommand("sp_UserLinks_Insert");
            this._dataAccess.AddParameter("PublicId", PublicId, ParameterDirection.Input);
            this._dataAccess.AddParameter("ParentUserSysId", ParentUserSysId, ParameterDirection.Input);
            this._dataAccess.AddParameter("ChildUserSysId", ChildUserSysId, ParameterDirection.Input);
            this._dataAccess.AddParameter("LinkPath", LinkPath, ParameterDirection.Input);
            this._dataAccess.AddParameter("CreateDate", CreateDate, ParameterDirection.Input);
            this._dataAccess.AddParameter("LastModifiedDate", LastModifiedDate, ParameterDirection.Input);
            this._dataAccess.AddParameter("Active", Active, ParameterDirection.Input);
            int value = this._dataAccess.ExecuteNonQuery();
            return value;
        }
        
        public virtual System.Nullable<int> UserLinks_Delete(System.Nullable<int> SysId) {
            this._dataAccess.CreateProcedureCommand("sp_UserLinks_Delete");
            this._dataAccess.AddParameter("SysId", SysId, ParameterDirection.Input);
            int value = this._dataAccess.ExecuteNonQuery();
            return value;
        }
        
        public virtual System.Nullable<int> UserLinks_Update(System.Nullable<int> SysId, System.Nullable<System.Guid> PublicId, System.Nullable<int> ParentUserSysId, System.Nullable<int> ChildUserSysId, string LinkPath, System.Nullable<System.DateTime> CreateDate, System.Nullable<System.DateTime> LastModifiedDate, System.Nullable<bool> Active) {
            this._dataAccess.CreateProcedureCommand("sp_UserLinks_Update");
            this._dataAccess.AddParameter("SysId", SysId, ParameterDirection.Input);
            this._dataAccess.AddParameter("PublicId", PublicId, ParameterDirection.Input);
            this._dataAccess.AddParameter("ParentUserSysId", ParentUserSysId, ParameterDirection.Input);
            this._dataAccess.AddParameter("ChildUserSysId", ChildUserSysId, ParameterDirection.Input);
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
