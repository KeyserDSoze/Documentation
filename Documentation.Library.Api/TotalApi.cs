using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Documentation.Library.Api
{
    /// <summary>
    /// Api for total connection with the world.
    /// </summary>
    public class TotalApi
    {
        /// <summary>
        /// A field.
        /// </summary>
        public string Field;
        /// <summary>
        /// A property.
        /// </summary>
        public string Property { get; set; }
        /// <summary>
        /// Subscribe a user.
        /// </summary>
        /// <param name="x">Big possibility to use an int as parameter.</param>
        /// <returns>A complex empty string.</returns>
        public string Subscribe(int x) => string.Empty;
        /// <summary>
        /// Unsubscribe a user.
        /// </summary>
        /// <param name="x">Big possibility to use an int as parameter <seealso cref="Subscribe(int)"/></param>
        /// <param name="z">If you want to reset a User make this parameter null</param>
        /// <returns>A complex empty string.</returns>
        public string Unsubscribe(int x, int z) => string.Empty;
    }
}
