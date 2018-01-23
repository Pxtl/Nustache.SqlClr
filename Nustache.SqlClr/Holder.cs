using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Nustache.SqlClr
{
    /// <summary>
    /// Workaround for inability to assign to private static members in SQL-CLR.  
    /// You can't assign to private static, but you can have private statics and you can assign to their members.
    /// This is silly.
    /// </summary>
    internal class Holder<T>
    {
        public Holder(){}
        public Holder(T value) { this.Value = value; }
        internal T Value {get;set;}
    }
}
