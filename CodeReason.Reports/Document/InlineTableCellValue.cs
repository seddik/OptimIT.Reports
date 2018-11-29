/************************************************************************
 * Copyright: Hans Wolff
 *
 * License:  This software abides by the LGPL license terms. For further
 *           licensing information please see the top level LICENSE.txt 
 *           file found in the root directory of OptimIT Reports.
 *
 * Author:   Hans Wolff
 *
 ************************************************************************/

using System.IO;
using OptimIT.Reports.Interfaces;

namespace OptimIT.Reports.Document
{
    /// <summary>
    /// Ccontains a single report value that is to be displayed on the report (e.g. report title)
    /// </summary>
    public class InlineTableCellValue : InlinePropertyValue, ITableCellValue
    {
        private string _aggregateGroup;
        /// <summary>
        /// Gets or sets the aggregate group
        /// </summary>
        public string AggregateGroup
        {
            get { return _aggregateGroup; }
            set { _aggregateGroup = value; }
        }
    }
}
