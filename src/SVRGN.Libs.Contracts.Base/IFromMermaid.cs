using System;
using System.Collections.Generic;
using System.Text;

namespace SVRGN.Libs.Contracts.Base
{
    public interface IFromMermaid
    {
        #region Methods

        #region FromMermaid: Generates a class instance from a Mermaid diagram input
        /// <summary>
        /// Generates a class instance from a <see href="https://mermaid.live/">Mermaid</see> diagram input
        /// </summary>
        /// <param name="Input">The input string in mermaid editor format</param>
        void FromMermaid(string Input);
        #endregion FromMermaid

        #endregion Methods
    }
}
