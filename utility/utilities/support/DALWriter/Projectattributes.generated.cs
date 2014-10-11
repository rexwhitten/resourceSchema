namespace resourceSchema.Dal {
    using System;
    using System.Collections.Generic;
    using System.Data.SqlClient;
    using System.Configuration;
    using System.Data;
    using System.Xml;
    
    
    public partial class Projectattributes : IDisposable {
        
        private DataAccess _dataAccess;
        
        public Projectattributes() {
            this._dataAccess = new DataAccess();
        }
        
        public virtual System.Data.DataSet Select_ProjectAttributess_By_ProjectSysId(System.Nullable<int> ProjectSysId) {
            this._dataAccess.CreateProcedureCommand("sp_Select_ProjectAttributess_By_ProjectSysId");
            this._dataAccess.AddParameter("ProjectSysId", ProjectSysId, ParameterDirection.Input);
            DataSet value = this._dataAccess.ExecuteDataSet();
            return value;
        }
        
        public virtual System.Data.DataSet ProjectAttributes_Select_All() {
            this._dataAccess.CreateProcedureCommand("sp_ProjectAttributes_Select_All");
            DataSet value = this._dataAccess.ExecuteDataSet();
            return value;
        }
        
        public virtual System.Data.DataSet ProjectAttributes_Select_One(System.Nullable<int> SysId) {
            this._dataAccess.CreateProcedureCommand("sp_ProjectAttributes_Select_One");
            this._dataAccess.AddParameter("SysId", SysId, ParameterDirection.Input);
            DataSet value = this._dataAccess.ExecuteDataSet();
            return value;
        }
        
        public virtual System.Nullable<int> ProjectAttributes_Insert(System.Nullable<int> ProjectSysId, System.Nullable<System.DateTime> CreateDate, System.Nullable<System.DateTime> LastModifiedDate, string Description) {
            this._dataAccess.CreateProcedureCommand("sp_ProjectAttributes_Insert");
            this._dataAccess.AddParameter("ProjectSysId", ProjectSysId, ParameterDirection.Input);
            this._dataAccess.AddParameter("CreateDate", CreateDate, ParameterDirection.Input);
            this._dataAccess.AddParameter("LastModifiedDate", LastModifiedDate, ParameterDirection.Input);
            this._dataAccess.AddParameter("Description", Description, ParameterDirection.Input);
            int value = this._dataAccess.ExecuteNonQuery();
            return value;
        }
        
        public virtual System.Nullable<int> ProjectAttributes_Delete(System.Nullable<int> SysId) {
            this._dataAccess.CreateProcedureCommand("sp_ProjectAttributes_Delete");
            this._dataAccess.AddParameter("SysId", SysId, ParameterDirection.Input);
            int value = this._dataAccess.ExecuteNonQuery();
            return value;
        }
        
        public virtual System.Nullable<int> ProjectAttributes_Update(System.Nullable<int> SysId, System.Nullable<int> ProjectSysId, System.Nullable<System.DateTime> CreateDate, System.Nullable<System.DateTime> LastModifiedDate, string Description) {
            this._dataAccess.CreateProcedureCommand("sp_ProjectAttributes_Update");
            this._dataAccess.AddParameter("SysId", SysId, ParameterDirection.Input);
            this._dataAccess.AddParameter("ProjectSysId", ProjectSysId, ParameterDirection.Input);
            this._dataAccess.AddParameter("CreateDate", CreateDate, ParameterDirection.Input);
            this._dataAccess.AddParameter("LastModifiedDate", LastModifiedDate, ParameterDirection.Input);
            this._dataAccess.AddParameter("Description", Description, ParameterDirection.Input);
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
