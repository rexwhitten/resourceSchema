namespace resourceSchema.Dal {
    using System;
    using System.Collections.Generic;
    using System.Data.SqlClient;
    using System.Configuration;
    using System.Data;
    using System.Xml;
    
    
    public partial class Timeentryattributes : IDisposable {
        
        private DataAccess _dataAccess;
        
        public Timeentryattributes() {
            this._dataAccess = new DataAccess();
        }
        
        public virtual System.Data.DataSet Select_TimeEntryAttributess_By_TimeEntrySysId(System.Nullable<int> TimeEntrySysId) {
            this._dataAccess.CreateProcedureCommand("sp_Select_TimeEntryAttributess_By_TimeEntrySysId");
            this._dataAccess.AddParameter("TimeEntrySysId", TimeEntrySysId, ParameterDirection.Input);
            DataSet value = this._dataAccess.ExecuteDataSet();
            return value;
        }
        
        public virtual System.Data.DataSet TimeEntryAttributes_Select_All() {
            this._dataAccess.CreateProcedureCommand("sp_TimeEntryAttributes_Select_All");
            DataSet value = this._dataAccess.ExecuteDataSet();
            return value;
        }
        
        public virtual System.Data.DataSet TimeEntryAttributes_Select_One(System.Nullable<int> SysId) {
            this._dataAccess.CreateProcedureCommand("sp_TimeEntryAttributes_Select_One");
            this._dataAccess.AddParameter("SysId", SysId, ParameterDirection.Input);
            DataSet value = this._dataAccess.ExecuteDataSet();
            return value;
        }
        
        public virtual System.Nullable<int> TimeEntryAttributes_Insert(System.Nullable<int> TimeEntrySysId, System.Nullable<System.DateTime> CreateDate, System.Nullable<System.DateTime> LastModifiedDate, System.Nullable<System.DateTime> TimeEntryDate, System.Nullable<decimal> Hours, System.Nullable<bool> Billable, string Note) {
            this._dataAccess.CreateProcedureCommand("sp_TimeEntryAttributes_Insert");
            this._dataAccess.AddParameter("TimeEntrySysId", TimeEntrySysId, ParameterDirection.Input);
            this._dataAccess.AddParameter("CreateDate", CreateDate, ParameterDirection.Input);
            this._dataAccess.AddParameter("LastModifiedDate", LastModifiedDate, ParameterDirection.Input);
            this._dataAccess.AddParameter("TimeEntryDate", TimeEntryDate, ParameterDirection.Input);
            this._dataAccess.AddParameter("Hours", Hours, ParameterDirection.Input);
            this._dataAccess.AddParameter("Billable", Billable, ParameterDirection.Input);
            this._dataAccess.AddParameter("Note", Note, ParameterDirection.Input);
            int value = this._dataAccess.ExecuteNonQuery();
            return value;
        }
        
        public virtual System.Nullable<int> TimeEntryAttributes_Delete(System.Nullable<int> SysId) {
            this._dataAccess.CreateProcedureCommand("sp_TimeEntryAttributes_Delete");
            this._dataAccess.AddParameter("SysId", SysId, ParameterDirection.Input);
            int value = this._dataAccess.ExecuteNonQuery();
            return value;
        }
        
        public virtual System.Nullable<int> TimeEntryAttributes_Update(System.Nullable<int> SysId, System.Nullable<int> TimeEntrySysId, System.Nullable<System.DateTime> CreateDate, System.Nullable<System.DateTime> LastModifiedDate, System.Nullable<System.DateTime> TimeEntryDate, System.Nullable<decimal> Hours, System.Nullable<bool> Billable, string Note) {
            this._dataAccess.CreateProcedureCommand("sp_TimeEntryAttributes_Update");
            this._dataAccess.AddParameter("SysId", SysId, ParameterDirection.Input);
            this._dataAccess.AddParameter("TimeEntrySysId", TimeEntrySysId, ParameterDirection.Input);
            this._dataAccess.AddParameter("CreateDate", CreateDate, ParameterDirection.Input);
            this._dataAccess.AddParameter("LastModifiedDate", LastModifiedDate, ParameterDirection.Input);
            this._dataAccess.AddParameter("TimeEntryDate", TimeEntryDate, ParameterDirection.Input);
            this._dataAccess.AddParameter("Hours", Hours, ParameterDirection.Input);
            this._dataAccess.AddParameter("Billable", Billable, ParameterDirection.Input);
            this._dataAccess.AddParameter("Note", Note, ParameterDirection.Input);
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
