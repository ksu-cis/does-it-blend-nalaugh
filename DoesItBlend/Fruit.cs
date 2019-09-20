using System;
using System.Collections.Generic;
using System.Text;

namespace DoesItBlend
{
    /// <summary>
    /// A base class representing fruit
    /// absterat is a hyarical relationship  a banana is a fruit
    /// banana implamets a blend
    /// </summary>
    public abstract class Fruit : IBlendable
    {
        public abstract string Blend();
        
        
    }
}
