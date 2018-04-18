using System;
using System.Data.SqlTypes;
using System.Diagnostics;
using Microsoft.SqlServer.Types;

namespace Geography
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlServerTypes.Utilities.LoadNativeAssemblies(AppDomain.CurrentDomain.BaseDirectory);

            SqlGeography sqlGeography = SqlGeography.STGeomFromText(new SqlChars(Wkt.WKT), 4326);
            sqlGeography.MakeValid();

            Debugger.Break();
        }
    }
}
