using System;
using System.Collections.Generic;
using System.Text;

namespace SVRGN.Libs.Contracts.Base
{
    /// <summary>
    /// the interface providing a unique Id
    /// </summary>
    public interface IId
    {
        #region Properties

        #region Id: a unique Id, probably generated at class creation time with Guid.NewGuid()
        /// <summary>
        /// a unique Id, probably generated at class creation time with Guid.NewGuid()
        /// </summary>
        Guid Id { get; }
        #endregion Id

        #endregion Properties

        #region Methods

        #endregion Methods
    }
}
