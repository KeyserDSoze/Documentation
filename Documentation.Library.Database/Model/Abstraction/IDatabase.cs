using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Documentation.Library.Database.Model
{
    /// <summary>
    /// Abstraction used to perform a saving and fetching of data
    /// </summary>
    public interface IDatabase
    {
        /// <summary>
        /// Save data.
        /// </summary>
        void Save();
        /// <summary>
        /// Fetch data.
        /// </summary>
        /// <returns>A <see cref="int"/> that represents nothing.</returns>
        int Get();
    }
}
