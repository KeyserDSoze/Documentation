using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Documentation.Library.Database.Model
{
    /// <summary>
    /// it's an implementation of <see cref="IDatabase"/> to perform saving in Mssql Database.
    /// </summary>
    public class Storage : IDatabase
    {
        public int Get()
        {
            return 0;
        }

        public void Save()
        {
            Console.WriteLine("Save it");
        }
    }
}
