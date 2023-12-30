using System;
using System.Collections.Generic;
using System.Text;

namespace SVRGN.Libs.Contracts.Base
{
    public interface IUpdate
    {
        #region Methods

        #region Properties

        TimeSpan UpdateInterval { get; }
        DateTime LastUpdatedAt { get; set; }

        #endregion Properties

        #region Update: used for regular update mechanics
        /// <summary>
        /// used for regular update mechanics
        /// </summary>
        void Update();
        #endregion Update

        #endregion Methods
    }
}
