namespace resourceSchema.Dal {
    using System;
    using System.Collections.Generic;
    using System.Data.SqlClient;
    using System.Configuration;
    using System.Data;
    using System.Xml;
    
    
    public partial class Userattributes : IDisposable {
        
        private DataAccess _dataAccess;
        
        public Userattributes() {
            this._dataAccess = new DataAccess();
        }
        
        public virtual System.Data.DataSet Select_UserAttributess_By_UserSysId(System.Nullable<int> UserSysId) {
            this._dataAccess.CreateProcedureCommand("sp_Select_UserAttributess_By_UserSysId");
            this._dataAccess.AddParameter("UserSysId", UserSysId, ParameterDirection.Input);
            DataSet value = this._dataAccess.ExecuteDataSet();
            return value;
        }
        
        public virtual System.Data.DataSet UserAttributes_Select_All() {
            this._dataAccess.CreateProcedureCommand("sp_UserAttributes_Select_All");
            DataSet value = this._dataAccess.ExecuteDataSet();
            return value;
        }
        
        public virtual System.Data.DataSet UserAttributes_Select_One(System.Nullable<int> SysId) {
            this._dataAccess.CreateProcedureCommand("sp_UserAttributes_Select_One");
            this._dataAccess.AddParameter("SysId", SysId, ParameterDirection.Input);
            DataSet value = this._dataAccess.ExecuteDataSet();
            return value;
        }
        
        public virtual System.Nullable<int> UserAttributes_Insert(System.Nullable<int> UserSysId, System.Nullable<System.DateTime> CreateDate, System.Nullable<System.DateTime> LastModifiedDate, string Email, string FirstName, string LastName) {
            this._dataAccess.CreateProcedureCommand("sp_UserAttributes_Insert");
            this._dataAccess.AddParameter("UserSysId", UserSysId, ParameterDirection.Input);
            this._dataAccess.AddParameter("CreateDate", CreateDate, ParameterDirection.Input);
            this._dataAccess.AddParameter("LastModifiedDate", LastModifiedDate, ParameterDirection.Input);
            this._dataAccess.AddParameter("Email", Email, ParameterDirection.Input);
            this._dataAccess.AddParameter("FirstName", FirstName, ParameterDirection.Input);
            this._dataAccess.AddParameter("LastName", LastName, ParameterDirection.Input);
            int value = this._dataAccess.ExecuteNonQuery();
            return value;
        }
        
        public virtual System.Nullable<int> UserAttributes_Delete(System.Nullable<int> SysId) {
            this._dataAccess.CreateProcedureCommand("sp_UserAttributes_Delete");
            this._dataAccess.AddParameter("SysId", SysId, ParameterDirection.Input);
            int value = this._dataAccess.ExecuteNonQuery();
            return value;
        }
        
        public virtual System.Nullable<int> UserAttributes_Update(System.Nullable<int> SysId, System.Nullable<int> UserSysId, System.Nullable<System.DateTime> CreateDate, System.Nullable<System.DateTime> LastModifiedDate, string Email, string FirstName, string LastName) {
            this._dataAccess.CreateProcedureCommand("sp_UserAttributes_Update");
            this._dataAccess.AddParameter("SysId", SysId, ParameterDirection.Input);
            this._dataAccess.AddParameter("UserSysId", UserSysId, ParameterDirection.Input);
            this._dataAccess.AddParameter("CreateDate", CreateDate, ParameterDirection.Input);
            this._dataAccess.AddParameter("LastModifiedDate", LastModifiedDate, ParameterDirection.Input);
            this._dataAccess.AddParameter("Email", Email, ParameterDirection.Input);
            this._dataAccess.AddParameter("FirstName", FirstName, ParameterDirection.Input);
            this._dataAccess.AddParameter("LastName", LastName, ParameterDirection.Input);
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
