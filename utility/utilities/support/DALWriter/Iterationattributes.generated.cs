namespace resourceSchema.Dal {
    using System;
    using System.Collections.Generic;
    using System.Data.SqlClient;
    using System.Configuration;
    using System.Data;
    using System.Xml;
    
    
    public partial class Iterationattributes : IDisposable {
        
        private DataAccess _dataAccess;
        
        public Iterationattributes() {
            this._dataAccess = new DataAccess();
        }
        
        public virtual System.Data.DataSet Select_IterationAttributess_By_IterationSysId(System.Nullable<int> IterationSysId) {
            this._dataAccess.CreateProcedureCommand("sp_Select_IterationAttributess_By_IterationSysId");
            this._dataAccess.AddParameter("IterationSysId", IterationSysId, ParameterDirection.Input);
            DataSet value = this._dataAccess.ExecuteDataSet();
            return value;
        }
        
        public virtual System.Data.DataSet IterationAttributes_Select_All() {
            this._dataAccess.CreateProcedureCommand("sp_IterationAttributes_Select_All");
            DataSet value = this._dataAccess.ExecuteDataSet();
            return value;
        }
        
        public virtual System.Data.DataSet IterationAttributes_Select_One(System.Nullable<int> SysId) {
            this._dataAccess.CreateProcedureCommand("sp_IterationAttributes_Select_One");
            this._dataAccess.AddParameter("SysId", SysId, ParameterDirection.Input);
            DataSet value = this._dataAccess.ExecuteDataSet();
            return value;
        }
        
        public virtual System.Nullable<int> IterationAttributes_Insert(System.Nullable<int> IterationSysId, System.Nullable<System.DateTime> CreateDate, System.Nullable<System.DateTime> LastModifiedDate, string Description, string IterationNumber) {
            this._dataAccess.CreateProcedureCommand("sp_IterationAttributes_Insert");
            this._dataAccess.AddParameter("IterationSysId", IterationSysId, ParameterDirection.Input);
            this._dataAccess.AddParameter("CreateDate", CreateDate, ParameterDirection.Input);
            this._dataAccess.AddParameter("LastModifiedDate", LastModifiedDate, ParameterDirection.Input);
            this._dataAccess.AddParameter("Description", Description, ParameterDirection.Input);
            this._dataAccess.AddParameter("IterationNumber", IterationNumber, ParameterDirection.Input);
            int value = this._dataAccess.ExecuteNonQuery();
            return value;
        }
        
        public virtual System.Nullable<int> IterationAttributes_Delete(System.Nullable<int> SysId) {
            this._dataAccess.CreateProcedureCommand("sp_IterationAttributes_Delete");
            this._dataAccess.AddParameter("SysId", SysId, ParameterDirection.Input);
            int value = this._dataAccess.ExecuteNonQuery();
            return value;
        }
        
        public virtual System.Nullable<int> IterationAttributes_Update(System.Nullable<int> SysId, System.Nullable<int> IterationSysId, System.Nullable<System.DateTime> CreateDate, System.Nullable<System.DateTime> LastModifiedDate, string Description, string IterationNumber) {
            this._dataAccess.CreateProcedureCommand("sp_IterationAttributes_Update");
            this._dataAccess.AddParameter("SysId", SysId, ParameterDirection.Input);
            this._dataAccess.AddParameter("IterationSysId", IterationSysId, ParameterDirection.Input);
            this._dataAccess.AddParameter("CreateDate", CreateDate, ParameterDirection.Input);
            this._dataAccess.AddParameter("LastModifiedDate", LastModifiedDate, ParameterDirection.Input);
            this._dataAccess.AddParameter("Description", Description, ParameterDirection.Input);
            this._dataAccess.AddParameter("IterationNumber", IterationNumber, ParameterDirection.Input);
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
