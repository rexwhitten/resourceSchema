using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace resourceSchema.Physical
{
    using Microsoft.SqlServer.Management.Smo;

    public static class TableBuilderExtensions
    {
        

        public static void BuildMaster(this Database db, String Schema, String ObjectName)
        {
            Table master = new Table();
            master.Schema = Schema;
            master.Name = String.Format("{0}Master", ObjectName);
            master.FileGroup = "Primary";

            Column SysId = new Column();
            SysId.Name = "SysID";
            SysId.Identity = true;
            SysId.IdentityIncrement = 1;
            SysId.IdentitySeed = 1;
            SysId.DataType = DataType.Int;
            master.Columns.Add(SysId);

            Column PublicId = new Column();
            PublicId.Name = "PublicId";
            PublicId.DataType = DataType.UniqueIdentifier;
            PublicId.Nullable = false;
            master.Columns.Add(PublicId);

            Column Path = new Column();
            Path.Nullable = false;
            Path.Name = "Path";
            Path.DataType = DataType.VarChar(512);
            master.Columns.Add(Path);


            db.Tables.Add(master);



        }

        )


    }
}
