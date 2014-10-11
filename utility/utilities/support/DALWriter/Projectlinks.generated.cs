namespace resourceSchema.Dal {
    using System;
    using System.Collections.Generic;
    using System.Data.SqlClient;
    using System.Configuration;
    using System.Data;
    using System.Xml;
    
    
    public partial class Projectlinks : IDisposable {
        
        private DataAccess _dataAccess;
        
        public Projectlinks() {
            this._dataAccess = new DataAccess();
        }
        
        public virtual System.Data.DataSet Select_ProjectLinkss_By_ParentProjectSysId(System.Nullable<int> ParentProjectSysId) {
            this._dataAccess.CreateProcedureCommand("sp_Select_ProjectLinkss_By_ParentProjectSysId");
            this._dataAccess.AddParameter("ParentProjectSysId", ParentProjectSysId, ParameterDirection.Input);
            DataSet value = this._dataAccess.ExecuteDataSet();
            return value;
        }
        
        public virtual System.Data.DataSet Select_ProjectLinkss_By_ChildProjectSysId(System.Nullable<int> ChildProjectSysId) {
            this._dataAccess.CreateProcedureCommand("sp_Select_ProjectLinkss_By_ChildProjectSysId");
            this._dataAccess.AddParameter("ChildProjectSysId", ChildProjectSysId, ParameterDirection.Input);
            DataSet value = this._dataAccess.ExecuteDataSet();
            return value;
        }
        
        public virtual System.Data.DataSet ProjectLinks_Select_All() {
            this._dataAccess.CreateProcedureCommand("sp_ProjectLinks_Select_All");
            DataSet value = this._dataAccess.ExecuteDataSet();
            return value;
        }
        
        public virtual System.Data.DataSet ProjectLinks_Select_One(System.Nullable<int> SysId) {
            this._dataAccess.CreateProcedureCommand("sp_ProjectLinks_Select_One");
            this._dataAccess.AddParameter("SysId", SysId, ParameterDirection.Input);
            DataSet value = this._dataAccess.ExecuteDataSet();
            return value;
        }
        
        public virtual System.Nullable<int> ProjectLinks_Insert(System.Nullable<System.Guid> PublicId, System.Nullable<int> ParentProjectSysId, System.Nullable<int> ChildProjectSysId, string LinkPath, System.Nullable<System.DateTime> CreateDate, System.Nullable<System.DateTime> LastModifiedDate, System.Nullable<bool> Active) {
            this._dataAccess.CreateProcedureCommand("sp_ProjectLinks_Insert");
            this._dataAccess.AddParameter("PublicId", PublicId, ParameterDirection.Input);
            this._dataAccess.AddParameter("ParentProjectSysId", ParentProjectSysId, ParameterDirection.Input);
            this._dataAccess.AddParameter("ChildProjectSysId", ChildProjectSysId, ParameterDirection.Input);
            this._dataAccess.AddParameter("LinkPath", LinkPath, ParameterDirection.Input);
            this._dataAccess.AddParameter("CreateDate", CreateDate, ParameterDirection.Input);
            this._dataAccess.AddParameter("LastModifiedDate", LastModifiedDate, ParameterDirection.Input);
            this._dataAccess.AddParameter("Active", Active, ParameterDirection.Input);
            int value = this._dataAccess.ExecuteNonQuery();
            return value;
        }
        
        public virtual System.Nullable<int> ProjectLinks_Delete(System.Nullable<int> SysId) {
            this._dataAccess.CreateProcedureCommand("sp_ProjectLinks_Delete");
            this._dataAccess.AddParameter("SysId", SysId, ParameterDirection.Input);
            int value = this._dataAccess.ExecuteNonQuery();
            return value;
        }
        
        public virtual System.Nullable<int> ProjectLinks_Update(System.Nullable<int> SysId, System.Nullable<System.Guid> PublicId, System.Nullable<int> ParentProjectSysId, System.Nullable<int> ChildProjectSysId, string LinkPath, System.Nullable<System.DateTime> CreateDate, System.Nullable<System.DateTime> LastModifiedDate, System.Nullable<bool> Active) {
            this._dataAccess.CreateProcedureCommand("sp_ProjectLinks_Update");
            this._dataAccess.AddParameter("SysId", SysId, ParameterDirection.Input);
            this._dataAccess.AddParameter("PublicId", PublicId, ParameterDirection.Input);
            this._dataAccess.AddParameter("ParentProjectSysId", ParentProjectSysId, ParameterDirection.Input);
            this._dataAccess.AddParameter("ChildProjectSysId", ChildProjectSysId, ParameterDirection.Input);
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
