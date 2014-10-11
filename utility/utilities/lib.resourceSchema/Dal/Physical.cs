namespace resourceSchema.Dal {
    using System;
    using System.Collections.Generic;
    using System.Data.SqlClient;
    using System.Configuration;
    using System.Data;
    using System.Xml;
    using Microsoft.SqlServer.Management.Smo;
    
    
    
    public partial class Physical : IDisposable {
        
        private DataAccess _dataAccess;

        public Physical()
        {
            this._dataAccess = new DataAccess();
        }

        public virtual System.Nullable<int> DropFunctions() {
            this._dataAccess.CreateProcedureCommand("[meta].[drop_functions]");
            int value = this._dataAccess.ExecuteNonQuery();
            return value;
        }

        public virtual System.Nullable<int> DropKeys()
        {
            this._dataAccess.CreateProcedureCommand("[meta].[drop_key]");
            int value = this._dataAccess.ExecuteNonQuery();
            return value;
        }

        public virtual System.Nullable<int> DropMasters()
        {
            this._dataAccess.CreateProcedureCommand("[meta].[drop_Masters]");
            int value = this._dataAccess.ExecuteNonQuery();
            return value;
        }

        public virtual System.Nullable<int> PreBuild()
        {
            this._dataAccess.CreateProcedureCommand("[meta].[Pre_Build]");
            int value = this._dataAccess.ExecuteNonQuery();
            return value;
        }

        public virtual System.Nullable<int> CreateRelations()
        {
            this._dataAccess.CreateProcedureCommand("[meta].[Create_Relations]");
            int value = this._dataAccess.ExecuteNonQuery();
            return value;
        }

        public virtual System.Nullable<int> CreaterMasters()
        {
            this._dataAccess.CreateProcedureCommand("[meta].[Create_Masters]");
            int value = this._dataAccess.ExecuteNonQuery();
            return value;
        }

        public virtual System.Nullable<int> CreaterAttributes()
        {
            this._dataAccess.CreateProcedureCommand("[meta].[Create_Attributes]");
            int value = this._dataAccess.ExecuteNonQuery();
            return value;
        }

        public virtual System.Nullable<int> BuildAttributesTable()
        {
            this._dataAccess.CreateProcedureCommand("[meta].[Build_AttributesTable]");
            int value = this._dataAccess.ExecuteNonQuery();
            return value;
        }


        public virtual System.Nullable<int> BuildDatabase(String Name)
        {
            string sql = "";

            try
            {
                Console.WriteLine("\n Creating New Database {0}", Name);
                // Build a Database PHysical Form 
                sql = String.Format(System.IO.File.ReadAllText(@"sql\database.sql"), Name).Replace("GO", "");
                this._dataAccess.ExecuteSql(sql);
                Console.WriteLine("\n Physcial Database Objects Created... {0}", Name);

                // Apply Meta Schema and Objects
                
                // Create Schema 
                sql = String.Format(System.IO.File.ReadAllText(@"sql\meta\meta.Schema.sql"), Name).Replace("GO","");
                this._dataAccess.ExecuteSql(sql);
                Console.WriteLine("\n Meta Schema Created... {0}", Name);


                //Server server = new Server(@"(local)\SQLEXPRESS");
                //Database buildDb = server.Databases[Name];

                foreach(var script_file in (new System.IO.DirectoryInfo(@"sql\meta").GetFiles("*.sql",System.IO.SearchOption.AllDirectories)))
                {
                    this._dataAccess = new DataAccess();

                    if (script_file.Name != "meta.Schema.sql")
                    {
                        string object_sql = "";

                        object_sql = String.Format("USE [{0}] \n GO \n", Name);

                        object_sql = object_sql + String.Format(System.IO.File.ReadAllText(script_file.FullName), Name);
                        object_sql = object_sql + "\nGO\n";

                        if (script_file.Name.Contains("StoredProcedure"))
                        {
                            //this._dataAccess.ExecuteNonQuery(object_sql);
                        }
                        else
                        {
                            object_sql = object_sql.Replace("GO", "");
                            this._dataAccess.ExecuteSql(object_sql);
                        }
                    }
                }
            
                Console.WriteLine("\n Meta Schema Objects Created... {0}", Name);
            }
            catch(DataAccessException dax)
            {
                Console.WriteLine(String.Format("Build Error : {0}", dax.Message));
            }



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
