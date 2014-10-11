namespace resourceSchema.Dal {
    using System;
    using System.Collections.Generic;
    using System.Data.SqlClient;
    using System.Configuration;
    using System.Data;
    using System.Xml;
    
    
    public partial class Iterationtags : IDisposable {
        
        private DataAccess _dataAccess;
        
        public Iterationtags() {
            this._dataAccess = new DataAccess();
        }
        
        public virtual System.Data.DataSet Select_IterationTagss_By_SysId(System.Nullable<int> SysId) {
            this._dataAccess.CreateProcedureCommand("sp_Select_IterationTagss_By_SysId");
            this._dataAccess.AddParameter("SysId", SysId, ParameterDirection.Input);
            DataSet value = this._dataAccess.ExecuteDataSet();
            return value;
        }
        
        public virtual System.Data.DataSet IterationTags_Select_All() {
            this._dataAccess.CreateProcedureCommand("sp_IterationTags_Select_All");
            DataSet value = this._dataAccess.ExecuteDataSet();
            return value;
        }
        
        public virtual System.Data.DataSet IterationTags_Select_One(System.Nullable<int> SysId) {
            this._dataAccess.CreateProcedureCommand("sp_IterationTags_Select_One");
            this._dataAccess.AddParameter("SysId", SysId, ParameterDirection.Input);
            DataSet value = this._dataAccess.ExecuteDataSet();
            return value;
        }
        
        public virtual System.Nullable<int> IterationTags_Insert(System.Nullable<int> IterationSysId, string Tag, System.Nullable<System.DateTime> CreateDate, System.Nullable<bool> Active) {
            this._dataAccess.CreateProcedureCommand("sp_IterationTags_Insert");
            this._dataAccess.AddParameter("IterationSysId", IterationSysId, ParameterDirection.Input);
            this._dataAccess.AddParameter("Tag", Tag, ParameterDirection.Input);
            this._dataAccess.AddParameter("CreateDate", CreateDate, ParameterDirection.Input);
            this._dataAccess.AddParameter("Active", Active, ParameterDirection.Input);
            int value = this._dataAccess.ExecuteNonQuery();
            return value;
        }
        
        public virtual System.Nullable<int> IterationTags_Delete(System.Nullable<int> SysId) {
            this._dataAccess.CreateProcedureCommand("sp_IterationTags_Delete");
            this._dataAccess.AddParameter("SysId", SysId, ParameterDirection.Input);
            int value = this._dataAccess.ExecuteNonQuery();
            return value;
        }
        
        public virtual System.Nullable<int> IterationTags_Update(System.Nullable<int> SysId, System.Nullable<int> IterationSysId, string Tag, System.Nullable<System.DateTime> CreateDate, System.Nullable<bool> Active) {
            this._dataAccess.CreateProcedureCommand("sp_IterationTags_Update");
            this._dataAccess.AddParameter("SysId", SysId, ParameterDirection.Input);
            this._dataAccess.AddParameter("IterationSysId", IterationSysId, ParameterDirection.Input);
            this._dataAccess.AddParameter("Tag", Tag, ParameterDirection.Input);
            this._dataAccess.AddParameter("CreateDate", CreateDate, ParameterDirection.Input);
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
