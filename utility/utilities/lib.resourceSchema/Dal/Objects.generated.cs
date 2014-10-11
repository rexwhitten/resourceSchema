namespace resourceSchema.Dal {
    using System;
    using System.Collections.Generic;
    using System.Data.SqlClient;
    using System.Configuration;
    using System.Data;
    using System.Xml;
    
    
    public partial class Objects : IDisposable {
        
        private DataAccess _dataAccess;
        
        public Objects() {
            this._dataAccess = new DataAccess();
        }
        
        public virtual System.Data.DataSet Objects_Select_All() {
            this._dataAccess.CreateProcedureCommand("sp_Objects_Select_All");
            DataSet value = this._dataAccess.ExecuteDataSet();
            return value;
        }
        
        public virtual System.Data.DataSet Objects_Select_One(System.Nullable<int> Id) {
            this._dataAccess.CreateProcedureCommand("sp_Objects_Select_One");
            this._dataAccess.AddParameter("Id", Id, ParameterDirection.Input);
            DataSet value = this._dataAccess.ExecuteDataSet();
            return value;
        }
        
        public virtual System.Nullable<int> Objects_Insert(string Title, string Path, System.Nullable<bool> Active) {
            this._dataAccess.CreateProcedureCommand("sp_Objects_Insert");
            this._dataAccess.AddParameter("Title", Title, ParameterDirection.Input);
            this._dataAccess.AddParameter("Path", Path, ParameterDirection.Input);
            this._dataAccess.AddParameter("Active", Active, ParameterDirection.Input);
            int value = this._dataAccess.ExecuteNonQuery();
            return value;
        }
        
        public virtual System.Nullable<int> Objects_Delete(System.Nullable<int> Id) {
            this._dataAccess.CreateProcedureCommand("sp_Objects_Delete");
            this._dataAccess.AddParameter("Id", Id, ParameterDirection.Input);
            int value = this._dataAccess.ExecuteNonQuery();
            return value;
        }
        
        public virtual System.Nullable<int> Objects_Update(System.Nullable<int> Id, string Title, string Path, System.Nullable<bool> Active) {
            this._dataAccess.CreateProcedureCommand("sp_Objects_Update");
            this._dataAccess.AddParameter("Id", Id, ParameterDirection.Input);
            this._dataAccess.AddParameter("Title", Title, ParameterDirection.Input);
            this._dataAccess.AddParameter("Path", Path, ParameterDirection.Input);
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
