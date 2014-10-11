namespace resourceSchema.Dal {
    using System;
    using System.Collections.Generic;
    using System.Data.SqlClient;
    using System.Configuration;
    using System.Data;
    using System.Xml;
    
    
    public partial class Relations : IDisposable {
        
        private DataAccess _dataAccess;
        
        public Relations() {
            this._dataAccess = new DataAccess();
        }
        
        public virtual System.Data.DataSet Relations_Select_All() {
            this._dataAccess.CreateProcedureCommand("sp_Relations_Select_All");
            DataSet value = this._dataAccess.ExecuteDataSet();
            return value;
        }
        
        public virtual System.Data.DataSet Relations_Select_One(System.Nullable<int> Id) {
            this._dataAccess.CreateProcedureCommand("sp_Relations_Select_One");
            this._dataAccess.AddParameter("Id", Id, ParameterDirection.Input);
            DataSet value = this._dataAccess.ExecuteDataSet();
            return value;
        }
        
        public virtual System.Nullable<int> Relations_Insert(string Parent, string Child, System.Nullable<bool> Active) {
            this._dataAccess.CreateProcedureCommand("sp_Relations_Insert");
            this._dataAccess.AddParameter("Parent", Parent, ParameterDirection.Input);
            this._dataAccess.AddParameter("Child", Child, ParameterDirection.Input);
            this._dataAccess.AddParameter("Active", Active, ParameterDirection.Input);
            int value = this._dataAccess.ExecuteNonQuery();
            return value;
        }
        
        public virtual System.Nullable<int> Relations_Delete(System.Nullable<int> Id) {
            this._dataAccess.CreateProcedureCommand("sp_Relations_Delete");
            this._dataAccess.AddParameter("Id", Id, ParameterDirection.Input);
            int value = this._dataAccess.ExecuteNonQuery();
            return value;
        }
        
        public virtual System.Nullable<int> Relations_Update(System.Nullable<int> Id, string Parent, string Child, System.Nullable<bool> Active) {
            this._dataAccess.CreateProcedureCommand("sp_Relations_Update");
            this._dataAccess.AddParameter("Id", Id, ParameterDirection.Input);
            this._dataAccess.AddParameter("Parent", Parent, ParameterDirection.Input);
            this._dataAccess.AddParameter("Child", Child, ParameterDirection.Input);
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
