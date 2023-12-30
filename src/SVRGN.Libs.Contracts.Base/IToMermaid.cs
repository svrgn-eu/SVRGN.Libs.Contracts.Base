using System;
using System.Collections.Generic;
using System.Text;

namespace SVRGN.Libs.Contracts.Base
{
    public interface IToMermaid
    {
        #region Methods

        #region ToMermaid
        /// <summary>
        /// Generates a string output for <see href="https://mermaid.live/">Mermaid</see>
        /// </summary>
        /// <returns>a string being able to be pasted into mermaid</returns>
        string ToMermaid();
        #endregion ToMermaid

        #endregion Methods
    }
}
