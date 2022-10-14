using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboApiGroup_DAL
{
    public class Command
    {
        internal string Query { get; set; }
        internal bool IsStoredProcedure { get; set; }
        internal Dictionary<string, object> Parameters { get; set; }

        /// <summary>
        /// Create a new command to set query and choice if it is a stored procedure
        /// </summary>
        /// <param name="query">string query</param>
        /// <param name="isStoredProcedure"> true or false if it is a stored Procedure</param>
        public Command(string query, bool isStoredProcedure = false)
        {
            this.Query = query;
            this.Parameters = new Dictionary<string, object>();
            this.IsStoredProcedure = isStoredProcedure;
        }

        /// <summary>
        /// set your parameter of your table
        /// </summary>
        /// <param name="parameterName"></param>
        /// <param name="value"></param>
        public void AddParameter(string parameterName, object value)
        {
            this.Parameters.Add(parameterName, value ?? DBNull.Value);
        }
    }
}
