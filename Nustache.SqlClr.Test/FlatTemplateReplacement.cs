using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Data.SqlTypes;

namespace Nustache.SqlClr.Test
{
    [TestClass]
    public class FlatTemplateReplacement
    {
        [TestMethod]
        public void SimpleSingleReplacement()
        {
            var template = new SqlString("test {{name}}");
            var name = new SqlString("name");
            var value = new SqlString("value");
            var result = Nustache.SqlClr.UserDefinedFunctions.RenderTemplateWithStrings1(template, name, value);
            Assert.AreEqual(result.Value, "test value");
        }
    }
}
