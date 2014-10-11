namespace resourceSchema.Dal {
    using System;
    using System.Collections.Generic;
    using System.Data.SqlClient;
    using System.Configuration;
    using System.Data;
    using System.Xml;
    
    
    public partial class Timeentrylinks : IDisposable {
        
        private DataAccess _dataAccess;
        
        public Timeentrylinks() {
            this._dataAccess = new DataAccess();
        }
        
        public virtual System.Data.DataSet Select_TimeEntryLinkss_By_ParentTimeEntrySysId(System.Nullable<int> ParentTimeEntrySysId) {
            this._dataAccess.CreateProcedureCommand("sp_Select_TimeEntryLinkss_By_ParentTimeEntrySysId");
            this._dataAccess.AddParameter("ParentTimeEntrySysId", ParentTimeEntrySysId, ParameterDirection.Input);
            DataSet value = this._dataAccess.ExecuteDataSet();
            return value;
        }
        
        public virtual System.Data.DataSet Select_TimeEntryLinkss_By_ChildTimeEntrySysId(System.Nullable<int> ChildTimeEntrySysId) {
            this._dataAccess.CreateProcedureCommand("sp_Select_TimeEntryLinkss_By_ChildTimeEntrySysId");
            this._dataAccess.AddParameter("ChildTimeEntrySysId", ChildTimeEntrySysId, ParameterDirection.Input);
            DataSet value = this._dataAccess.ExecuteDataSet();
            return value;
        }
        
        public virtual System.Data.DataSet TimeEntryLinks_Select_All() {
            this._dataAccess.CreateProcedureCommand("sp_TimeEntryLinks_Select_All");
            DataSet value = this._dataAccess.ExecuteDataSet();
            return value;
        }
        
        public virtual System.Data.DataSet TimeEntryLinks_Select_One(System.Nullable<int> SysId) {
            this._dataAccess.CreateProcedureCommand("sp_TimeEntryLinks_Select_One");
            this._dataAccess.AddParameter("SysId", SysId, ParameterDirection.Input);
            DataSet value = this._dataAccess.ExecuteDataSet();
            return value;
        }
        
        public virtual System.Nullable<int> TimeEntryLinks_Insert(System.Nullable<System.Guid> PublicId, System.Nullable<int> ParentTimeEntrySysId, System.Nullable<int> ChildTimeEntrySysId, string LinkPath, System.Nullable<System.DateTime> CreateDate, System.Nullable<System.DateTime> LastModifiedDate, System.Nullable<bool> Active) {
            this._dataAccess.CreateProcedureCommand("sp_TimeEntryLinks_Insert");
            this._dataAccess.AddParameter("PublicId", PublicId, ParameterDirection.Input);
            this._dataAccess.AddParameter("ParentTimeEntrySysId", ParentTimeEntrySysId, ParameterDirection.Input);
            this._dataAccess.AddParameter("ChildTimeEntrySysId", ChildTimeEntrySysId, ParameterDirection.Input);
            this._dataAccess.AddParameter("LinkPath", LinkPath, ParameterDirection.Input);
            this._dataAccess.AddParameter("CreateDate", CreateDate, ParameterDirection.Input);
            this._dataAccess.AddParameter("LastModifiedDate", LastModifiedDate, ParameterDirection.Input);
            this._dataAccess.AddParameter("Active", Active, ParameterDirection.Input);
            int value = this._dataAccess.ExecuteNonQuery();
            return value;
        }
        
        public virtual System.Nullable<int> TimeEntryLinks_Delete(System.Nullable<int> SysId) {
            this._dataAccess.CreateProcedureCommand("sp_TimeEntryLinks_Delete");
            this._dataAccess.AddParameter("SysId", SysId, ParameterDirection.Input);
            int value = this._dataAccess.ExecuteNonQuery();
            return value;
        }
        
        public virtual System.Nullable<int> TimeEntryLinks_Update(System.Nullable<int> SysId, System.Nullable<System.Guid> PublicId, System.Nullable<int> ParentTimeEntrySysId, System.Nullable<int> ChildTimeEntrySysId, string LinkPath, System.Nullable<System.DateTime> CreateDate, System.Nullable<System.DateTime> LastModifiedDate, System.Nullable<bool> Active) {
            this._dataAccess.CreateProcedureCommand("sp_TimeEntryLinks_Update");
            this._dataAccess.AddParameter("SysId", SysId, ParameterDirection.Input);
            this._dataAccess.AddParameter("PublicId", PublicId, ParameterDirection.Input);
            this._dataAccess.AddParameter("ParentTimeEntrySysId", ParentTimeEntrySysId, ParameterDirection.Input);
            this._dataAccess.AddParameter("ChildTimeEntrySysId", ChildTimeEntrySysId, ParameterDirection.Input);
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
