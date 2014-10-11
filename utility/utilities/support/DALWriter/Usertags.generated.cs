namespace resourceSchema.Dal {
    using System;
    using System.Collections.Generic;
    using System.Data.SqlClient;
    using System.Configuration;
    using System.Data;
    using System.Xml;
    
    
    public partial class Usertags : IDisposable {
        
        private DataAccess _dataAccess;
        
        public Usertags() {
            this._dataAccess = new DataAccess();
        }
        
        public virtual System.Data.DataSet Select_UserTagss_By_SysId(System.Nullable<int> SysId) {
            this._dataAccess.CreateProcedureCommand("sp_Select_UserTagss_By_SysId");
            this._dataAccess.AddParameter("SysId", SysId, ParameterDirection.Input);
            DataSet value = this._dataAccess.ExecuteDataSet();
            return value;
        }
        
        public virtual System.Data.DataSet UserTags_Select_All() {
            this._dataAccess.CreateProcedureCommand("sp_UserTags_Select_All");
            DataSet value = this._dataAccess.ExecuteDataSet();
            return value;
        }
        
        public virtual System.Data.DataSet UserTags_Select_One(System.Nullable<int> SysId) {
            this._dataAccess.CreateProcedureCommand("sp_UserTags_Select_One");
            this._dataAccess.AddParameter("SysId", SysId, ParameterDirection.Input);
            DataSet value = this._dataAccess.ExecuteDataSet();
            return value;
        }
        
        public virtual System.Nullable<int> UserTags_Insert(System.Nullable<int> UserSysId, string Tag, System.Nullable<System.DateTime> CreateDate, System.Nullable<bool> Active) {
            this._dataAccess.CreateProcedureCommand("sp_UserTags_Insert");
            this._dataAccess.AddParameter("UserSysId", UserSysId, ParameterDirection.Input);
            this._dataAccess.AddParameter("Tag", Tag, ParameterDirection.Input);
            this._dataAccess.AddParameter("CreateDate", CreateDate, ParameterDirection.Input);
            this._dataAccess.AddParameter("Active", Active, ParameterDirection.Input);
            int value = this._dataAccess.ExecuteNonQuery();
            return value;
        }
        
        public virtual System.Nullable<int> UserTags_Delete(System.Nullable<int> SysId) {
            this._dataAccess.CreateProcedureCommand("sp_UserTags_Delete");
            this._dataAccess.AddParameter("SysId", SysId, ParameterDirection.Input);
            int value = this._dataAccess.ExecuteNonQuery();
            return value;
        }
        
        public virtual System.Nullable<int> UserTags_Update(System.Nullable<int> SysId, System.Nullable<int> UserSysId, string Tag, System.Nullable<System.DateTime> CreateDate, System.Nullable<bool> Active) {
            this._dataAccess.CreateProcedureCommand("sp_UserTags_Update");
            this._dataAccess.AddParameter("SysId", SysId, ParameterDirection.Input);
            this._dataAccess.AddParameter("UserSysId", UserSysId, ParameterDirection.Input);
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
