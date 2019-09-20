using System;
using System.Collections.Generic;
using System.Text;

namespace DoesItBlend
{
    /// <summary>
    /// Interface for ittems that can blended.
    /// </summary>
    interface IBlendable
    {
        /// <summary>
        /// Blands the objet
        /// </summary>
        /// <returns> the string that is blended</returns>
        /// 
        string Blend();
    }
}
