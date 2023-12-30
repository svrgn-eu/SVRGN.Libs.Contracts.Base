using System;
using System.Collections.Generic;
using System.Text;

namespace SVRGN.Libs.Contracts.Base
{
    public interface IInitialize
    {
        #region Properties

        bool IsInitialized { get; } 

        #endregion Properties

        #region Methods

        void Initialize();

        #endregion Methods
    }
}
