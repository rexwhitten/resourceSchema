namespace resourceSchema.Dal {
    using System;
    using System.Collections.Generic;
    using System.Data.SqlClient;
    using System.Configuration;
    using System.Data;
    using System.Xml;
    
    
    public partial class Attributes : IDisposable {
        
        private DataAccess _dataAccess;
        
        public Attributes() {
            this._dataAccess = new DataAccess();
        }
        
        public virtual System.Data.DataSet Attributes_Select_All() {
            this._dataAccess.CreateProcedureCommand("sp_Attributes_Select_All");
            DataSet value = this._dataAccess.ExecuteDataSet();
            return value;
        }
        
        public virtual System.Data.DataSet Attributes_Select_One(System.Nullable<int> Id) {
            this._dataAccess.CreateProcedureCommand("sp_Attributes_Select_One");
            this._dataAccess.AddParameter("Id", Id, ParameterDirection.Input);
            DataSet value = this._dataAccess.ExecuteDataSet();
            return value;
        }
        
        public virtual System.Nullable<int> Attributes_Insert(string ObjectTitle, string Name, string DataType, System.Nullable<bool> Active) {
            this._dataAccess.CreateProcedureCommand("sp_Attributes_Insert");
            this._dataAccess.AddParameter("ObjectTitle", ObjectTitle, ParameterDirection.Input);
            this._dataAccess.AddParameter("Name", Name, ParameterDirection.Input);
            this._dataAccess.AddParameter("DataType", DataType, ParameterDirection.Input);
            this._dataAccess.AddParameter("Active", Active, ParameterDirection.Input);
            int value = this._dataAccess.ExecuteNonQuery();
            return value;
        }
        
        public virtual System.Nullable<int> Attributes_Delete(System.Nullable<int> Id) {
            this._dataAccess.CreateProcedureCommand("sp_Attributes_Delete");
            this._dataAccess.AddParameter("Id", Id, ParameterDirection.Input);
            int value = this._dataAccess.ExecuteNonQuery();
            return value;
        }
        
        public virtual System.Nullable<int> Attributes_Update(System.Nullable<int> Id, string ObjectTitle, string Name, string DataType, System.Nullable<bool> Active) {
            this._dataAccess.CreateProcedureCommand("sp_Attributes_Update");
            this._dataAccess.AddParameter("Id", Id, ParameterDirection.Input);
            this._dataAccess.AddParameter("ObjectTitle", ObjectTitle, ParameterDirection.Input);
            this._dataAccess.AddParameter("Name", Name, ParameterDirection.Input);
            this._dataAccess.AddParameter("DataType", DataType, ParameterDirection.Input);
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
