using System;
using System.Collections.Generic;
using System.Text;

namespace SVRGN.Libs.Contracts.Base
{
    public interface IError : IBaseObject
    {
        #region Properties

        int Code { get; }
        string Description { get; }
        Exception ExplicitExeption { get; }

        string Hint { get; }

        #endregion Properties

        #region Methods

        #endregion Methods
    }
}
