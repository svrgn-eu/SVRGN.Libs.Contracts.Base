using System;
using System.Collections.Generic;
using System.Text;

namespace SVRGN.Libs.Contracts.Base
{
    public interface IOrderBy
    {
        #region Properties

        #region Order: criteria used to bring items in an order, e.g. for Chain of Command implementations, when the order plays a significant role
        /// <summary>
        /// criteria used to bring items in an order, e.g. for Chain of Command implementations, when the order plays a significant role
        /// </summary>
        int Order { get; set; }
        #endregion Order

        #endregion Properties
    }
}
