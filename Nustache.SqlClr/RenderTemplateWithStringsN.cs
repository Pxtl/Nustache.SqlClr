 
using Microsoft.SqlServer.Server;
using Nustache.Core;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
namespace Nustache.SqlClr
{
	public static partial class UserDefinedFunctions
	{
		/// <summary>
        /// Renders the given Mustache template with the name/value arguments assembled into a parameter data object.
		/// All arguments must have string-value of length < 2000, longer string-values have not been tested.
        /// </summary>
        /// <param name="template">A Mustache template.</param>
        /// <param name="name1">The name of template data parameter 1.</param>
        /// <param name="value1">The value of template data parameter 1.</param>
        /// <returns>The rendered template with all parameters replaced.</returns> 
        [SqlFunction(DataAccess = DataAccessKind.None, IsDeterministic = true)]
        [return: SqlFacet(MaxSize = -1, IsNullable = true)]
        public static SqlString  RenderTemplateWithStrings1(
            [SqlFacet(MaxSize = -1, IsNullable = true)] SqlString template
            , [SqlFacet(MaxSize = 2000, IsNullable = false)] SqlString name1
            , [SqlFacet(MaxSize = -1, IsNullable = true)] SqlString value1
        )
        {
            InitializeNustache();

            var paramDict = new Dictionary<string, string>()
            {
                { name1.Value, value1.Value }
            };

            return Render.StringToString(template.Value, paramDict);
        }

		/// <summary>
        /// Renders the given Mustache template with the name/value arguments assembled into a parameter data object.
		/// All arguments must have string-value of length < 2000, longer string-values have not been tested.
        /// </summary>
        /// <param name="template">A Mustache template.</param>
        /// <param name="name1">The name of template data parameter 1.</param>
        /// <param name="value1">The value of template data parameter 1.</param>
        /// <param name="name2">The name of template data parameter 2.</param>
        /// <param name="value2">The value of template data parameter 2.</param>
        /// <returns>The rendered template with all parameters replaced.</returns> 
        [SqlFunction(DataAccess = DataAccessKind.None, IsDeterministic = true)]
        [return: SqlFacet(MaxSize = -1, IsNullable = true)]
        public static SqlString  RenderTemplateWithStrings2(
            [SqlFacet(MaxSize = -1, IsNullable = true)] SqlString template
            , [SqlFacet(MaxSize = 2000, IsNullable = false)] SqlString name1
            , [SqlFacet(MaxSize = -1, IsNullable = true)] SqlString value1
            , [SqlFacet(MaxSize = 2000, IsNullable = false)] SqlString name2
            , [SqlFacet(MaxSize = -1, IsNullable = true)] SqlString value2
        )
        {
            InitializeNustache();

            var paramDict = new Dictionary<string, string>()
            {
                { name1.Value, value1.Value },
                { name2.Value, value2.Value }
            };

            return Render.StringToString(template.Value, paramDict);
        }

		/// <summary>
        /// Renders the given Mustache template with the name/value arguments assembled into a parameter data object.
		/// All arguments must have string-value of length < 2000, longer string-values have not been tested.
        /// </summary>
        /// <param name="template">A Mustache template.</param>
        /// <param name="name1">The name of template data parameter 1.</param>
        /// <param name="value1">The value of template data parameter 1.</param>
        /// <param name="name2">The name of template data parameter 2.</param>
        /// <param name="value2">The value of template data parameter 2.</param>
        /// <param name="name3">The name of template data parameter 3.</param>
        /// <param name="value3">The value of template data parameter 3.</param>
        /// <returns>The rendered template with all parameters replaced.</returns> 
        [SqlFunction(DataAccess = DataAccessKind.None, IsDeterministic = true)]
        [return: SqlFacet(MaxSize = -1, IsNullable = true)]
        public static SqlString  RenderTemplateWithStrings3(
            [SqlFacet(MaxSize = -1, IsNullable = true)] SqlString template
            , [SqlFacet(MaxSize = 2000, IsNullable = false)] SqlString name1
            , [SqlFacet(MaxSize = -1, IsNullable = true)] SqlString value1
            , [SqlFacet(MaxSize = 2000, IsNullable = false)] SqlString name2
            , [SqlFacet(MaxSize = -1, IsNullable = true)] SqlString value2
            , [SqlFacet(MaxSize = 2000, IsNullable = false)] SqlString name3
            , [SqlFacet(MaxSize = -1, IsNullable = true)] SqlString value3
        )
        {
            InitializeNustache();

            var paramDict = new Dictionary<string, string>()
            {
                { name1.Value, value1.Value },
                { name2.Value, value2.Value },
                { name3.Value, value3.Value }
            };

            return Render.StringToString(template.Value, paramDict);
        }

		/// <summary>
        /// Renders the given Mustache template with the name/value arguments assembled into a parameter data object.
		/// All arguments must have string-value of length < 2000, longer string-values have not been tested.
        /// </summary>
        /// <param name="template">A Mustache template.</param>
        /// <param name="name1">The name of template data parameter 1.</param>
        /// <param name="value1">The value of template data parameter 1.</param>
        /// <param name="name2">The name of template data parameter 2.</param>
        /// <param name="value2">The value of template data parameter 2.</param>
        /// <param name="name3">The name of template data parameter 3.</param>
        /// <param name="value3">The value of template data parameter 3.</param>
        /// <param name="name4">The name of template data parameter 4.</param>
        /// <param name="value4">The value of template data parameter 4.</param>
        /// <returns>The rendered template with all parameters replaced.</returns> 
        [SqlFunction(DataAccess = DataAccessKind.None, IsDeterministic = true)]
        [return: SqlFacet(MaxSize = -1, IsNullable = true)]
        public static SqlString  RenderTemplateWithStrings4(
            [SqlFacet(MaxSize = -1, IsNullable = true)] SqlString template
            , [SqlFacet(MaxSize = 2000, IsNullable = false)] SqlString name1
            , [SqlFacet(MaxSize = -1, IsNullable = true)] SqlString value1
            , [SqlFacet(MaxSize = 2000, IsNullable = false)] SqlString name2
            , [SqlFacet(MaxSize = -1, IsNullable = true)] SqlString value2
            , [SqlFacet(MaxSize = 2000, IsNullable = false)] SqlString name3
            , [SqlFacet(MaxSize = -1, IsNullable = true)] SqlString value3
            , [SqlFacet(MaxSize = 2000, IsNullable = false)] SqlString name4
            , [SqlFacet(MaxSize = -1, IsNullable = true)] SqlString value4
        )
        {
            InitializeNustache();

            var paramDict = new Dictionary<string, string>()
            {
                { name1.Value, value1.Value },
                { name2.Value, value2.Value },
                { name3.Value, value3.Value },
                { name4.Value, value4.Value }
            };

            return Render.StringToString(template.Value, paramDict);
        }

		/// <summary>
        /// Renders the given Mustache template with the name/value arguments assembled into a parameter data object.
		/// All arguments must have string-value of length < 2000, longer string-values have not been tested.
        /// </summary>
        /// <param name="template">A Mustache template.</param>
        /// <param name="name1">The name of template data parameter 1.</param>
        /// <param name="value1">The value of template data parameter 1.</param>
        /// <param name="name2">The name of template data parameter 2.</param>
        /// <param name="value2">The value of template data parameter 2.</param>
        /// <param name="name3">The name of template data parameter 3.</param>
        /// <param name="value3">The value of template data parameter 3.</param>
        /// <param name="name4">The name of template data parameter 4.</param>
        /// <param name="value4">The value of template data parameter 4.</param>
        /// <param name="name5">The name of template data parameter 5.</param>
        /// <param name="value5">The value of template data parameter 5.</param>
        /// <returns>The rendered template with all parameters replaced.</returns> 
        [SqlFunction(DataAccess = DataAccessKind.None, IsDeterministic = true)]
        [return: SqlFacet(MaxSize = -1, IsNullable = true)]
        public static SqlString  RenderTemplateWithStrings5(
            [SqlFacet(MaxSize = -1, IsNullable = true)] SqlString template
            , [SqlFacet(MaxSize = 2000, IsNullable = false)] SqlString name1
            , [SqlFacet(MaxSize = -1, IsNullable = true)] SqlString value1
            , [SqlFacet(MaxSize = 2000, IsNullable = false)] SqlString name2
            , [SqlFacet(MaxSize = -1, IsNullable = true)] SqlString value2
            , [SqlFacet(MaxSize = 2000, IsNullable = false)] SqlString name3
            , [SqlFacet(MaxSize = -1, IsNullable = true)] SqlString value3
            , [SqlFacet(MaxSize = 2000, IsNullable = false)] SqlString name4
            , [SqlFacet(MaxSize = -1, IsNullable = true)] SqlString value4
            , [SqlFacet(MaxSize = 2000, IsNullable = false)] SqlString name5
            , [SqlFacet(MaxSize = -1, IsNullable = true)] SqlString value5
        )
        {
            InitializeNustache();

            var paramDict = new Dictionary<string, string>()
            {
                { name1.Value, value1.Value },
                { name2.Value, value2.Value },
                { name3.Value, value3.Value },
                { name4.Value, value4.Value },
                { name5.Value, value5.Value }
            };

            return Render.StringToString(template.Value, paramDict);
        }

		/// <summary>
        /// Renders the given Mustache template with the name/value arguments assembled into a parameter data object.
		/// All arguments must have string-value of length < 2000, longer string-values have not been tested.
        /// </summary>
        /// <param name="template">A Mustache template.</param>
        /// <param name="name1">The name of template data parameter 1.</param>
        /// <param name="value1">The value of template data parameter 1.</param>
        /// <param name="name2">The name of template data parameter 2.</param>
        /// <param name="value2">The value of template data parameter 2.</param>
        /// <param name="name3">The name of template data parameter 3.</param>
        /// <param name="value3">The value of template data parameter 3.</param>
        /// <param name="name4">The name of template data parameter 4.</param>
        /// <param name="value4">The value of template data parameter 4.</param>
        /// <param name="name5">The name of template data parameter 5.</param>
        /// <param name="value5">The value of template data parameter 5.</param>
        /// <param name="name6">The name of template data parameter 6.</param>
        /// <param name="value6">The value of template data parameter 6.</param>
        /// <returns>The rendered template with all parameters replaced.</returns> 
        [SqlFunction(DataAccess = DataAccessKind.None, IsDeterministic = true)]
        [return: SqlFacet(MaxSize = -1, IsNullable = true)]
        public static SqlString  RenderTemplateWithStrings6(
            [SqlFacet(MaxSize = -1, IsNullable = true)] SqlString template
            , [SqlFacet(MaxSize = 2000, IsNullable = false)] SqlString name1
            , [SqlFacet(MaxSize = -1, IsNullable = true)] SqlString value1
            , [SqlFacet(MaxSize = 2000, IsNullable = false)] SqlString name2
            , [SqlFacet(MaxSize = -1, IsNullable = true)] SqlString value2
            , [SqlFacet(MaxSize = 2000, IsNullable = false)] SqlString name3
            , [SqlFacet(MaxSize = -1, IsNullable = true)] SqlString value3
            , [SqlFacet(MaxSize = 2000, IsNullable = false)] SqlString name4
            , [SqlFacet(MaxSize = -1, IsNullable = true)] SqlString value4
            , [SqlFacet(MaxSize = 2000, IsNullable = false)] SqlString name5
            , [SqlFacet(MaxSize = -1, IsNullable = true)] SqlString value5
            , [SqlFacet(MaxSize = 2000, IsNullable = false)] SqlString name6
            , [SqlFacet(MaxSize = -1, IsNullable = true)] SqlString value6
        )
        {
            InitializeNustache();

            var paramDict = new Dictionary<string, string>()
            {
                { name1.Value, value1.Value },
                { name2.Value, value2.Value },
                { name3.Value, value3.Value },
                { name4.Value, value4.Value },
                { name5.Value, value5.Value },
                { name6.Value, value6.Value }
            };

            return Render.StringToString(template.Value, paramDict);
        }

		/// <summary>
        /// Renders the given Mustache template with the name/value arguments assembled into a parameter data object.
		/// All arguments must have string-value of length < 2000, longer string-values have not been tested.
        /// </summary>
        /// <param name="template">A Mustache template.</param>
        /// <param name="name1">The name of template data parameter 1.</param>
        /// <param name="value1">The value of template data parameter 1.</param>
        /// <param name="name2">The name of template data parameter 2.</param>
        /// <param name="value2">The value of template data parameter 2.</param>
        /// <param name="name3">The name of template data parameter 3.</param>
        /// <param name="value3">The value of template data parameter 3.</param>
        /// <param name="name4">The name of template data parameter 4.</param>
        /// <param name="value4">The value of template data parameter 4.</param>
        /// <param name="name5">The name of template data parameter 5.</param>
        /// <param name="value5">The value of template data parameter 5.</param>
        /// <param name="name6">The name of template data parameter 6.</param>
        /// <param name="value6">The value of template data parameter 6.</param>
        /// <param name="name7">The name of template data parameter 7.</param>
        /// <param name="value7">The value of template data parameter 7.</param>
        /// <returns>The rendered template with all parameters replaced.</returns> 
        [SqlFunction(DataAccess = DataAccessKind.None, IsDeterministic = true)]
        [return: SqlFacet(MaxSize = -1, IsNullable = true)]
        public static SqlString  RenderTemplateWithStrings7(
            [SqlFacet(MaxSize = -1, IsNullable = true)] SqlString template
            , [SqlFacet(MaxSize = 2000, IsNullable = false)] SqlString name1
            , [SqlFacet(MaxSize = -1, IsNullable = true)] SqlString value1
            , [SqlFacet(MaxSize = 2000, IsNullable = false)] SqlString name2
            , [SqlFacet(MaxSize = -1, IsNullable = true)] SqlString value2
            , [SqlFacet(MaxSize = 2000, IsNullable = false)] SqlString name3
            , [SqlFacet(MaxSize = -1, IsNullable = true)] SqlString value3
            , [SqlFacet(MaxSize = 2000, IsNullable = false)] SqlString name4
            , [SqlFacet(MaxSize = -1, IsNullable = true)] SqlString value4
            , [SqlFacet(MaxSize = 2000, IsNullable = false)] SqlString name5
            , [SqlFacet(MaxSize = -1, IsNullable = true)] SqlString value5
            , [SqlFacet(MaxSize = 2000, IsNullable = false)] SqlString name6
            , [SqlFacet(MaxSize = -1, IsNullable = true)] SqlString value6
            , [SqlFacet(MaxSize = 2000, IsNullable = false)] SqlString name7
            , [SqlFacet(MaxSize = -1, IsNullable = true)] SqlString value7
        )
        {
            InitializeNustache();

            var paramDict = new Dictionary<string, string>()
            {
                { name1.Value, value1.Value },
                { name2.Value, value2.Value },
                { name3.Value, value3.Value },
                { name4.Value, value4.Value },
                { name5.Value, value5.Value },
                { name6.Value, value6.Value },
                { name7.Value, value7.Value }
            };

            return Render.StringToString(template.Value, paramDict);
        }

		/// <summary>
        /// Renders the given Mustache template with the name/value arguments assembled into a parameter data object.
		/// All arguments must have string-value of length < 2000, longer string-values have not been tested.
        /// </summary>
        /// <param name="template">A Mustache template.</param>
        /// <param name="name1">The name of template data parameter 1.</param>
        /// <param name="value1">The value of template data parameter 1.</param>
        /// <param name="name2">The name of template data parameter 2.</param>
        /// <param name="value2">The value of template data parameter 2.</param>
        /// <param name="name3">The name of template data parameter 3.</param>
        /// <param name="value3">The value of template data parameter 3.</param>
        /// <param name="name4">The name of template data parameter 4.</param>
        /// <param name="value4">The value of template data parameter 4.</param>
        /// <param name="name5">The name of template data parameter 5.</param>
        /// <param name="value5">The value of template data parameter 5.</param>
        /// <param name="name6">The name of template data parameter 6.</param>
        /// <param name="value6">The value of template data parameter 6.</param>
        /// <param name="name7">The name of template data parameter 7.</param>
        /// <param name="value7">The value of template data parameter 7.</param>
        /// <param name="name8">The name of template data parameter 8.</param>
        /// <param name="value8">The value of template data parameter 8.</param>
        /// <returns>The rendered template with all parameters replaced.</returns> 
        [SqlFunction(DataAccess = DataAccessKind.None, IsDeterministic = true)]
        [return: SqlFacet(MaxSize = -1, IsNullable = true)]
        public static SqlString  RenderTemplateWithStrings8(
            [SqlFacet(MaxSize = -1, IsNullable = true)] SqlString template
            , [SqlFacet(MaxSize = 2000, IsNullable = false)] SqlString name1
            , [SqlFacet(MaxSize = -1, IsNullable = true)] SqlString value1
            , [SqlFacet(MaxSize = 2000, IsNullable = false)] SqlString name2
            , [SqlFacet(MaxSize = -1, IsNullable = true)] SqlString value2
            , [SqlFacet(MaxSize = 2000, IsNullable = false)] SqlString name3
            , [SqlFacet(MaxSize = -1, IsNullable = true)] SqlString value3
            , [SqlFacet(MaxSize = 2000, IsNullable = false)] SqlString name4
            , [SqlFacet(MaxSize = -1, IsNullable = true)] SqlString value4
            , [SqlFacet(MaxSize = 2000, IsNullable = false)] SqlString name5
            , [SqlFacet(MaxSize = -1, IsNullable = true)] SqlString value5
            , [SqlFacet(MaxSize = 2000, IsNullable = false)] SqlString name6
            , [SqlFacet(MaxSize = -1, IsNullable = true)] SqlString value6
            , [SqlFacet(MaxSize = 2000, IsNullable = false)] SqlString name7
            , [SqlFacet(MaxSize = -1, IsNullable = true)] SqlString value7
            , [SqlFacet(MaxSize = 2000, IsNullable = false)] SqlString name8
            , [SqlFacet(MaxSize = -1, IsNullable = true)] SqlString value8
        )
        {
            InitializeNustache();

            var paramDict = new Dictionary<string, string>()
            {
                { name1.Value, value1.Value },
                { name2.Value, value2.Value },
                { name3.Value, value3.Value },
                { name4.Value, value4.Value },
                { name5.Value, value5.Value },
                { name6.Value, value6.Value },
                { name7.Value, value7.Value },
                { name8.Value, value8.Value }
            };

            return Render.StringToString(template.Value, paramDict);
        }

		/// <summary>
        /// Renders the given Mustache template with the name/value arguments assembled into a parameter data object.
		/// All arguments must have string-value of length < 2000, longer string-values have not been tested.
        /// </summary>
        /// <param name="template">A Mustache template.</param>
        /// <param name="name1">The name of template data parameter 1.</param>
        /// <param name="value1">The value of template data parameter 1.</param>
        /// <param name="name2">The name of template data parameter 2.</param>
        /// <param name="value2">The value of template data parameter 2.</param>
        /// <param name="name3">The name of template data parameter 3.</param>
        /// <param name="value3">The value of template data parameter 3.</param>
        /// <param name="name4">The name of template data parameter 4.</param>
        /// <param name="value4">The value of template data parameter 4.</param>
        /// <param name="name5">The name of template data parameter 5.</param>
        /// <param name="value5">The value of template data parameter 5.</param>
        /// <param name="name6">The name of template data parameter 6.</param>
        /// <param name="value6">The value of template data parameter 6.</param>
        /// <param name="name7">The name of template data parameter 7.</param>
        /// <param name="value7">The value of template data parameter 7.</param>
        /// <param name="name8">The name of template data parameter 8.</param>
        /// <param name="value8">The value of template data parameter 8.</param>
        /// <param name="name9">The name of template data parameter 9.</param>
        /// <param name="value9">The value of template data parameter 9.</param>
        /// <returns>The rendered template with all parameters replaced.</returns> 
        [SqlFunction(DataAccess = DataAccessKind.None, IsDeterministic = true)]
        [return: SqlFacet(MaxSize = -1, IsNullable = true)]
        public static SqlString  RenderTemplateWithStrings9(
            [SqlFacet(MaxSize = -1, IsNullable = true)] SqlString template
            , [SqlFacet(MaxSize = 2000, IsNullable = false)] SqlString name1
            , [SqlFacet(MaxSize = -1, IsNullable = true)] SqlString value1
            , [SqlFacet(MaxSize = 2000, IsNullable = false)] SqlString name2
            , [SqlFacet(MaxSize = -1, IsNullable = true)] SqlString value2
            , [SqlFacet(MaxSize = 2000, IsNullable = false)] SqlString name3
            , [SqlFacet(MaxSize = -1, IsNullable = true)] SqlString value3
            , [SqlFacet(MaxSize = 2000, IsNullable = false)] SqlString name4
            , [SqlFacet(MaxSize = -1, IsNullable = true)] SqlString value4
            , [SqlFacet(MaxSize = 2000, IsNullable = false)] SqlString name5
            , [SqlFacet(MaxSize = -1, IsNullable = true)] SqlString value5
            , [SqlFacet(MaxSize = 2000, IsNullable = false)] SqlString name6
            , [SqlFacet(MaxSize = -1, IsNullable = true)] SqlString value6
            , [SqlFacet(MaxSize = 2000, IsNullable = false)] SqlString name7
            , [SqlFacet(MaxSize = -1, IsNullable = true)] SqlString value7
            , [SqlFacet(MaxSize = 2000, IsNullable = false)] SqlString name8
            , [SqlFacet(MaxSize = -1, IsNullable = true)] SqlString value8
            , [SqlFacet(MaxSize = 2000, IsNullable = false)] SqlString name9
            , [SqlFacet(MaxSize = -1, IsNullable = true)] SqlString value9
        )
        {
            InitializeNustache();

            var paramDict = new Dictionary<string, string>()
            {
                { name1.Value, value1.Value },
                { name2.Value, value2.Value },
                { name3.Value, value3.Value },
                { name4.Value, value4.Value },
                { name5.Value, value5.Value },
                { name6.Value, value6.Value },
                { name7.Value, value7.Value },
                { name8.Value, value8.Value },
                { name9.Value, value9.Value }
            };

            return Render.StringToString(template.Value, paramDict);
        }

		/// <summary>
        /// Renders the given Mustache template with the name/value arguments assembled into a parameter data object.
		/// All arguments must have string-value of length < 2000, longer string-values have not been tested.
        /// </summary>
        /// <param name="template">A Mustache template.</param>
        /// <param name="name1">The name of template data parameter 1.</param>
        /// <param name="value1">The value of template data parameter 1.</param>
        /// <param name="name2">The name of template data parameter 2.</param>
        /// <param name="value2">The value of template data parameter 2.</param>
        /// <param name="name3">The name of template data parameter 3.</param>
        /// <param name="value3">The value of template data parameter 3.</param>
        /// <param name="name4">The name of template data parameter 4.</param>
        /// <param name="value4">The value of template data parameter 4.</param>
        /// <param name="name5">The name of template data parameter 5.</param>
        /// <param name="value5">The value of template data parameter 5.</param>
        /// <param name="name6">The name of template data parameter 6.</param>
        /// <param name="value6">The value of template data parameter 6.</param>
        /// <param name="name7">The name of template data parameter 7.</param>
        /// <param name="value7">The value of template data parameter 7.</param>
        /// <param name="name8">The name of template data parameter 8.</param>
        /// <param name="value8">The value of template data parameter 8.</param>
        /// <param name="name9">The name of template data parameter 9.</param>
        /// <param name="value9">The value of template data parameter 9.</param>
        /// <param name="name10">The name of template data parameter 10.</param>
        /// <param name="value10">The value of template data parameter 10.</param>
        /// <returns>The rendered template with all parameters replaced.</returns> 
        [SqlFunction(DataAccess = DataAccessKind.None, IsDeterministic = true)]
        [return: SqlFacet(MaxSize = -1, IsNullable = true)]
        public static SqlString  RenderTemplateWithStrings10(
            [SqlFacet(MaxSize = -1, IsNullable = true)] SqlString template
            , [SqlFacet(MaxSize = 2000, IsNullable = false)] SqlString name1
            , [SqlFacet(MaxSize = -1, IsNullable = true)] SqlString value1
            , [SqlFacet(MaxSize = 2000, IsNullable = false)] SqlString name2
            , [SqlFacet(MaxSize = -1, IsNullable = true)] SqlString value2
            , [SqlFacet(MaxSize = 2000, IsNullable = false)] SqlString name3
            , [SqlFacet(MaxSize = -1, IsNullable = true)] SqlString value3
            , [SqlFacet(MaxSize = 2000, IsNullable = false)] SqlString name4
            , [SqlFacet(MaxSize = -1, IsNullable = true)] SqlString value4
            , [SqlFacet(MaxSize = 2000, IsNullable = false)] SqlString name5
            , [SqlFacet(MaxSize = -1, IsNullable = true)] SqlString value5
            , [SqlFacet(MaxSize = 2000, IsNullable = false)] SqlString name6
            , [SqlFacet(MaxSize = -1, IsNullable = true)] SqlString value6
            , [SqlFacet(MaxSize = 2000, IsNullable = false)] SqlString name7
            , [SqlFacet(MaxSize = -1, IsNullable = true)] SqlString value7
            , [SqlFacet(MaxSize = 2000, IsNullable = false)] SqlString name8
            , [SqlFacet(MaxSize = -1, IsNullable = true)] SqlString value8
            , [SqlFacet(MaxSize = 2000, IsNullable = false)] SqlString name9
            , [SqlFacet(MaxSize = -1, IsNullable = true)] SqlString value9
            , [SqlFacet(MaxSize = 2000, IsNullable = false)] SqlString name10
            , [SqlFacet(MaxSize = -1, IsNullable = true)] SqlString value10
        )
        {
            InitializeNustache();

            var paramDict = new Dictionary<string, string>()
            {
                { name1.Value, value1.Value },
                { name2.Value, value2.Value },
                { name3.Value, value3.Value },
                { name4.Value, value4.Value },
                { name5.Value, value5.Value },
                { name6.Value, value6.Value },
                { name7.Value, value7.Value },
                { name8.Value, value8.Value },
                { name9.Value, value9.Value },
                { name10.Value, value10.Value }
            };

            return Render.StringToString(template.Value, paramDict);
        }

		/// <summary>
        /// Renders the given Mustache template with the name/value arguments assembled into a parameter data object.
		/// All arguments must have string-value of length < 2000, longer string-values have not been tested.
        /// </summary>
        /// <param name="template">A Mustache template.</param>
        /// <param name="name1">The name of template data parameter 1.</param>
        /// <param name="value1">The value of template data parameter 1.</param>
        /// <param name="name2">The name of template data parameter 2.</param>
        /// <param name="value2">The value of template data parameter 2.</param>
        /// <param name="name3">The name of template data parameter 3.</param>
        /// <param name="value3">The value of template data parameter 3.</param>
        /// <param name="name4">The name of template data parameter 4.</param>
        /// <param name="value4">The value of template data parameter 4.</param>
        /// <param name="name5">The name of template data parameter 5.</param>
        /// <param name="value5">The value of template data parameter 5.</param>
        /// <param name="name6">The name of template data parameter 6.</param>
        /// <param name="value6">The value of template data parameter 6.</param>
        /// <param name="name7">The name of template data parameter 7.</param>
        /// <param name="value7">The value of template data parameter 7.</param>
        /// <param name="name8">The name of template data parameter 8.</param>
        /// <param name="value8">The value of template data parameter 8.</param>
        /// <param name="name9">The name of template data parameter 9.</param>
        /// <param name="value9">The value of template data parameter 9.</param>
        /// <param name="name10">The name of template data parameter 10.</param>
        /// <param name="value10">The value of template data parameter 10.</param>
        /// <param name="name11">The name of template data parameter 11.</param>
        /// <param name="value11">The value of template data parameter 11.</param>
        /// <returns>The rendered template with all parameters replaced.</returns> 
        [SqlFunction(DataAccess = DataAccessKind.None, IsDeterministic = true)]
        [return: SqlFacet(MaxSize = -1, IsNullable = true)]
        public static SqlString  RenderTemplateWithStrings11(
            [SqlFacet(MaxSize = -1, IsNullable = true)] SqlString template
            , [SqlFacet(MaxSize = 2000, IsNullable = false)] SqlString name1
            , [SqlFacet(MaxSize = -1, IsNullable = true)] SqlString value1
            , [SqlFacet(MaxSize = 2000, IsNullable = false)] SqlString name2
            , [SqlFacet(MaxSize = -1, IsNullable = true)] SqlString value2
            , [SqlFacet(MaxSize = 2000, IsNullable = false)] SqlString name3
            , [SqlFacet(MaxSize = -1, IsNullable = true)] SqlString value3
            , [SqlFacet(MaxSize = 2000, IsNullable = false)] SqlString name4
            , [SqlFacet(MaxSize = -1, IsNullable = true)] SqlString value4
            , [SqlFacet(MaxSize = 2000, IsNullable = false)] SqlString name5
            , [SqlFacet(MaxSize = -1, IsNullable = true)] SqlString value5
            , [SqlFacet(MaxSize = 2000, IsNullable = false)] SqlString name6
            , [SqlFacet(MaxSize = -1, IsNullable = true)] SqlString value6
            , [SqlFacet(MaxSize = 2000, IsNullable = false)] SqlString name7
            , [SqlFacet(MaxSize = -1, IsNullable = true)] SqlString value7
            , [SqlFacet(MaxSize = 2000, IsNullable = false)] SqlString name8
            , [SqlFacet(MaxSize = -1, IsNullable = true)] SqlString value8
            , [SqlFacet(MaxSize = 2000, IsNullable = false)] SqlString name9
            , [SqlFacet(MaxSize = -1, IsNullable = true)] SqlString value9
            , [SqlFacet(MaxSize = 2000, IsNullable = false)] SqlString name10
            , [SqlFacet(MaxSize = -1, IsNullable = true)] SqlString value10
            , [SqlFacet(MaxSize = 2000, IsNullable = false)] SqlString name11
            , [SqlFacet(MaxSize = -1, IsNullable = true)] SqlString value11
        )
        {
            InitializeNustache();

            var paramDict = new Dictionary<string, string>()
            {
                { name1.Value, value1.Value },
                { name2.Value, value2.Value },
                { name3.Value, value3.Value },
                { name4.Value, value4.Value },
                { name5.Value, value5.Value },
                { name6.Value, value6.Value },
                { name7.Value, value7.Value },
                { name8.Value, value8.Value },
                { name9.Value, value9.Value },
                { name10.Value, value10.Value },
                { name11.Value, value11.Value }
            };

            return Render.StringToString(template.Value, paramDict);
        }

		/// <summary>
        /// Renders the given Mustache template with the name/value arguments assembled into a parameter data object.
		/// All arguments must have string-value of length < 2000, longer string-values have not been tested.
        /// </summary>
        /// <param name="template">A Mustache template.</param>
        /// <param name="name1">The name of template data parameter 1.</param>
        /// <param name="value1">The value of template data parameter 1.</param>
        /// <param name="name2">The name of template data parameter 2.</param>
        /// <param name="value2">The value of template data parameter 2.</param>
        /// <param name="name3">The name of template data parameter 3.</param>
        /// <param name="value3">The value of template data parameter 3.</param>
        /// <param name="name4">The name of template data parameter 4.</param>
        /// <param name="value4">The value of template data parameter 4.</param>
        /// <param name="name5">The name of template data parameter 5.</param>
        /// <param name="value5">The value of template data parameter 5.</param>
        /// <param name="name6">The name of template data parameter 6.</param>
        /// <param name="value6">The value of template data parameter 6.</param>
        /// <param name="name7">The name of template data parameter 7.</param>
        /// <param name="value7">The value of template data parameter 7.</param>
        /// <param name="name8">The name of template data parameter 8.</param>
        /// <param name="value8">The value of template data parameter 8.</param>
        /// <param name="name9">The name of template data parameter 9.</param>
        /// <param name="value9">The value of template data parameter 9.</param>
        /// <param name="name10">The name of template data parameter 10.</param>
        /// <param name="value10">The value of template data parameter 10.</param>
        /// <param name="name11">The name of template data parameter 11.</param>
        /// <param name="value11">The value of template data parameter 11.</param>
        /// <param name="name12">The name of template data parameter 12.</param>
        /// <param name="value12">The value of template data parameter 12.</param>
        /// <returns>The rendered template with all parameters replaced.</returns> 
        [SqlFunction(DataAccess = DataAccessKind.None, IsDeterministic = true)]
        [return: SqlFacet(MaxSize = -1, IsNullable = true)]
        public static SqlString  RenderTemplateWithStrings12(
            [SqlFacet(MaxSize = -1, IsNullable = true)] SqlString template
            , [SqlFacet(MaxSize = 2000, IsNullable = false)] SqlString name1
            , [SqlFacet(MaxSize = -1, IsNullable = true)] SqlString value1
            , [SqlFacet(MaxSize = 2000, IsNullable = false)] SqlString name2
            , [SqlFacet(MaxSize = -1, IsNullable = true)] SqlString value2
            , [SqlFacet(MaxSize = 2000, IsNullable = false)] SqlString name3
            , [SqlFacet(MaxSize = -1, IsNullable = true)] SqlString value3
            , [SqlFacet(MaxSize = 2000, IsNullable = false)] SqlString name4
            , [SqlFacet(MaxSize = -1, IsNullable = true)] SqlString value4
            , [SqlFacet(MaxSize = 2000, IsNullable = false)] SqlString name5
            , [SqlFacet(MaxSize = -1, IsNullable = true)] SqlString value5
            , [SqlFacet(MaxSize = 2000, IsNullable = false)] SqlString name6
            , [SqlFacet(MaxSize = -1, IsNullable = true)] SqlString value6
            , [SqlFacet(MaxSize = 2000, IsNullable = false)] SqlString name7
            , [SqlFacet(MaxSize = -1, IsNullable = true)] SqlString value7
            , [SqlFacet(MaxSize = 2000, IsNullable = false)] SqlString name8
            , [SqlFacet(MaxSize = -1, IsNullable = true)] SqlString value8
            , [SqlFacet(MaxSize = 2000, IsNullable = false)] SqlString name9
            , [SqlFacet(MaxSize = -1, IsNullable = true)] SqlString value9
            , [SqlFacet(MaxSize = 2000, IsNullable = false)] SqlString name10
            , [SqlFacet(MaxSize = -1, IsNullable = true)] SqlString value10
            , [SqlFacet(MaxSize = 2000, IsNullable = false)] SqlString name11
            , [SqlFacet(MaxSize = -1, IsNullable = true)] SqlString value11
            , [SqlFacet(MaxSize = 2000, IsNullable = false)] SqlString name12
            , [SqlFacet(MaxSize = -1, IsNullable = true)] SqlString value12
        )
        {
            InitializeNustache();

            var paramDict = new Dictionary<string, string>()
            {
                { name1.Value, value1.Value },
                { name2.Value, value2.Value },
                { name3.Value, value3.Value },
                { name4.Value, value4.Value },
                { name5.Value, value5.Value },
                { name6.Value, value6.Value },
                { name7.Value, value7.Value },
                { name8.Value, value8.Value },
                { name9.Value, value9.Value },
                { name10.Value, value10.Value },
                { name11.Value, value11.Value },
                { name12.Value, value12.Value }
            };

            return Render.StringToString(template.Value, paramDict);
        }

		/// <summary>
        /// Renders the given Mustache template with the name/value arguments assembled into a parameter data object.
		/// All arguments must have string-value of length < 2000, longer string-values have not been tested.
        /// </summary>
        /// <param name="template">A Mustache template.</param>
        /// <param name="name1">The name of template data parameter 1.</param>
        /// <param name="value1">The value of template data parameter 1.</param>
        /// <param name="name2">The name of template data parameter 2.</param>
        /// <param name="value2">The value of template data parameter 2.</param>
        /// <param name="name3">The name of template data parameter 3.</param>
        /// <param name="value3">The value of template data parameter 3.</param>
        /// <param name="name4">The name of template data parameter 4.</param>
        /// <param name="value4">The value of template data parameter 4.</param>
        /// <param name="name5">The name of template data parameter 5.</param>
        /// <param name="value5">The value of template data parameter 5.</param>
        /// <param name="name6">The name of template data parameter 6.</param>
        /// <param name="value6">The value of template data parameter 6.</param>
        /// <param name="name7">The name of template data parameter 7.</param>
        /// <param name="value7">The value of template data parameter 7.</param>
        /// <param name="name8">The name of template data parameter 8.</param>
        /// <param name="value8">The value of template data parameter 8.</param>
        /// <param name="name9">The name of template data parameter 9.</param>
        /// <param name="value9">The value of template data parameter 9.</param>
        /// <param name="name10">The name of template data parameter 10.</param>
        /// <param name="value10">The value of template data parameter 10.</param>
        /// <param name="name11">The name of template data parameter 11.</param>
        /// <param name="value11">The value of template data parameter 11.</param>
        /// <param name="name12">The name of template data parameter 12.</param>
        /// <param name="value12">The value of template data parameter 12.</param>
        /// <param name="name13">The name of template data parameter 13.</param>
        /// <param name="value13">The value of template data parameter 13.</param>
        /// <returns>The rendered template with all parameters replaced.</returns> 
        [SqlFunction(DataAccess = DataAccessKind.None, IsDeterministic = true)]
        [return: SqlFacet(MaxSize = -1, IsNullable = true)]
        public static SqlString  RenderTemplateWithStrings13(
            [SqlFacet(MaxSize = -1, IsNullable = true)] SqlString template
            , [SqlFacet(MaxSize = 2000, IsNullable = false)] SqlString name1
            , [SqlFacet(MaxSize = -1, IsNullable = true)] SqlString value1
            , [SqlFacet(MaxSize = 2000, IsNullable = false)] SqlString name2
            , [SqlFacet(MaxSize = -1, IsNullable = true)] SqlString value2
            , [SqlFacet(MaxSize = 2000, IsNullable = false)] SqlString name3
            , [SqlFacet(MaxSize = -1, IsNullable = true)] SqlString value3
            , [SqlFacet(MaxSize = 2000, IsNullable = false)] SqlString name4
            , [SqlFacet(MaxSize = -1, IsNullable = true)] SqlString value4
            , [SqlFacet(MaxSize = 2000, IsNullable = false)] SqlString name5
            , [SqlFacet(MaxSize = -1, IsNullable = true)] SqlString value5
            , [SqlFacet(MaxSize = 2000, IsNullable = false)] SqlString name6
            , [SqlFacet(MaxSize = -1, IsNullable = true)] SqlString value6
            , [SqlFacet(MaxSize = 2000, IsNullable = false)] SqlString name7
            , [SqlFacet(MaxSize = -1, IsNullable = true)] SqlString value7
            , [SqlFacet(MaxSize = 2000, IsNullable = false)] SqlString name8
            , [SqlFacet(MaxSize = -1, IsNullable = true)] SqlString value8
            , [SqlFacet(MaxSize = 2000, IsNullable = false)] SqlString name9
            , [SqlFacet(MaxSize = -1, IsNullable = true)] SqlString value9
            , [SqlFacet(MaxSize = 2000, IsNullable = false)] SqlString name10
            , [SqlFacet(MaxSize = -1, IsNullable = true)] SqlString value10
            , [SqlFacet(MaxSize = 2000, IsNullable = false)] SqlString name11
            , [SqlFacet(MaxSize = -1, IsNullable = true)] SqlString value11
            , [SqlFacet(MaxSize = 2000, IsNullable = false)] SqlString name12
            , [SqlFacet(MaxSize = -1, IsNullable = true)] SqlString value12
            , [SqlFacet(MaxSize = 2000, IsNullable = false)] SqlString name13
            , [SqlFacet(MaxSize = -1, IsNullable = true)] SqlString value13
        )
        {
            InitializeNustache();

            var paramDict = new Dictionary<string, string>()
            {
                { name1.Value, value1.Value },
                { name2.Value, value2.Value },
                { name3.Value, value3.Value },
                { name4.Value, value4.Value },
                { name5.Value, value5.Value },
                { name6.Value, value6.Value },
                { name7.Value, value7.Value },
                { name8.Value, value8.Value },
                { name9.Value, value9.Value },
                { name10.Value, value10.Value },
                { name11.Value, value11.Value },
                { name12.Value, value12.Value },
                { name13.Value, value13.Value }
            };

            return Render.StringToString(template.Value, paramDict);
        }

		/// <summary>
        /// Renders the given Mustache template with the name/value arguments assembled into a parameter data object.
		/// All arguments must have string-value of length < 2000, longer string-values have not been tested.
        /// </summary>
        /// <param name="template">A Mustache template.</param>
        /// <param name="name1">The name of template data parameter 1.</param>
        /// <param name="value1">The value of template data parameter 1.</param>
        /// <param name="name2">The name of template data parameter 2.</param>
        /// <param name="value2">The value of template data parameter 2.</param>
        /// <param name="name3">The name of template data parameter 3.</param>
        /// <param name="value3">The value of template data parameter 3.</param>
        /// <param name="name4">The name of template data parameter 4.</param>
        /// <param name="value4">The value of template data parameter 4.</param>
        /// <param name="name5">The name of template data parameter 5.</param>
        /// <param name="value5">The value of template data parameter 5.</param>
        /// <param name="name6">The name of template data parameter 6.</param>
        /// <param name="value6">The value of template data parameter 6.</param>
        /// <param name="name7">The name of template data parameter 7.</param>
        /// <param name="value7">The value of template data parameter 7.</param>
        /// <param name="name8">The name of template data parameter 8.</param>
        /// <param name="value8">The value of template data parameter 8.</param>
        /// <param name="name9">The name of template data parameter 9.</param>
        /// <param name="value9">The value of template data parameter 9.</param>
        /// <param name="name10">The name of template data parameter 10.</param>
        /// <param name="value10">The value of template data parameter 10.</param>
        /// <param name="name11">The name of template data parameter 11.</param>
        /// <param name="value11">The value of template data parameter 11.</param>
        /// <param name="name12">The name of template data parameter 12.</param>
        /// <param name="value12">The value of template data parameter 12.</param>
        /// <param name="name13">The name of template data parameter 13.</param>
        /// <param name="value13">The value of template data parameter 13.</param>
        /// <param name="name14">The name of template data parameter 14.</param>
        /// <param name="value14">The value of template data parameter 14.</param>
        /// <returns>The rendered template with all parameters replaced.</returns> 
        [SqlFunction(DataAccess = DataAccessKind.None, IsDeterministic = true)]
        [return: SqlFacet(MaxSize = -1, IsNullable = true)]
        public static SqlString  RenderTemplateWithStrings14(
            [SqlFacet(MaxSize = -1, IsNullable = true)] SqlString template
            , [SqlFacet(MaxSize = 2000, IsNullable = false)] SqlString name1
            , [SqlFacet(MaxSize = -1, IsNullable = true)] SqlString value1
            , [SqlFacet(MaxSize = 2000, IsNullable = false)] SqlString name2
            , [SqlFacet(MaxSize = -1, IsNullable = true)] SqlString value2
            , [SqlFacet(MaxSize = 2000, IsNullable = false)] SqlString name3
            , [SqlFacet(MaxSize = -1, IsNullable = true)] SqlString value3
            , [SqlFacet(MaxSize = 2000, IsNullable = false)] SqlString name4
            , [SqlFacet(MaxSize = -1, IsNullable = true)] SqlString value4
            , [SqlFacet(MaxSize = 2000, IsNullable = false)] SqlString name5
            , [SqlFacet(MaxSize = -1, IsNullable = true)] SqlString value5
            , [SqlFacet(MaxSize = 2000, IsNullable = false)] SqlString name6
            , [SqlFacet(MaxSize = -1, IsNullable = true)] SqlString value6
            , [SqlFacet(MaxSize = 2000, IsNullable = false)] SqlString name7
            , [SqlFacet(MaxSize = -1, IsNullable = true)] SqlString value7
            , [SqlFacet(MaxSize = 2000, IsNullable = false)] SqlString name8
            , [SqlFacet(MaxSize = -1, IsNullable = true)] SqlString value8
            , [SqlFacet(MaxSize = 2000, IsNullable = false)] SqlString name9
            , [SqlFacet(MaxSize = -1, IsNullable = true)] SqlString value9
            , [SqlFacet(MaxSize = 2000, IsNullable = false)] SqlString name10
            , [SqlFacet(MaxSize = -1, IsNullable = true)] SqlString value10
            , [SqlFacet(MaxSize = 2000, IsNullable = false)] SqlString name11
            , [SqlFacet(MaxSize = -1, IsNullable = true)] SqlString value11
            , [SqlFacet(MaxSize = 2000, IsNullable = false)] SqlString name12
            , [SqlFacet(MaxSize = -1, IsNullable = true)] SqlString value12
            , [SqlFacet(MaxSize = 2000, IsNullable = false)] SqlString name13
            , [SqlFacet(MaxSize = -1, IsNullable = true)] SqlString value13
            , [SqlFacet(MaxSize = 2000, IsNullable = false)] SqlString name14
            , [SqlFacet(MaxSize = -1, IsNullable = true)] SqlString value14
        )
        {
            InitializeNustache();

            var paramDict = new Dictionary<string, string>()
            {
                { name1.Value, value1.Value },
                { name2.Value, value2.Value },
                { name3.Value, value3.Value },
                { name4.Value, value4.Value },
                { name5.Value, value5.Value },
                { name6.Value, value6.Value },
                { name7.Value, value7.Value },
                { name8.Value, value8.Value },
                { name9.Value, value9.Value },
                { name10.Value, value10.Value },
                { name11.Value, value11.Value },
                { name12.Value, value12.Value },
                { name13.Value, value13.Value },
                { name14.Value, value14.Value }
            };

            return Render.StringToString(template.Value, paramDict);
        }

		/// <summary>
        /// Renders the given Mustache template with the name/value arguments assembled into a parameter data object.
		/// All arguments must have string-value of length < 2000, longer string-values have not been tested.
        /// </summary>
        /// <param name="template">A Mustache template.</param>
        /// <param name="name1">The name of template data parameter 1.</param>
        /// <param name="value1">The value of template data parameter 1.</param>
        /// <param name="name2">The name of template data parameter 2.</param>
        /// <param name="value2">The value of template data parameter 2.</param>
        /// <param name="name3">The name of template data parameter 3.</param>
        /// <param name="value3">The value of template data parameter 3.</param>
        /// <param name="name4">The name of template data parameter 4.</param>
        /// <param name="value4">The value of template data parameter 4.</param>
        /// <param name="name5">The name of template data parameter 5.</param>
        /// <param name="value5">The value of template data parameter 5.</param>
        /// <param name="name6">The name of template data parameter 6.</param>
        /// <param name="value6">The value of template data parameter 6.</param>
        /// <param name="name7">The name of template data parameter 7.</param>
        /// <param name="value7">The value of template data parameter 7.</param>
        /// <param name="name8">The name of template data parameter 8.</param>
        /// <param name="value8">The value of template data parameter 8.</param>
        /// <param name="name9">The name of template data parameter 9.</param>
        /// <param name="value9">The value of template data parameter 9.</param>
        /// <param name="name10">The name of template data parameter 10.</param>
        /// <param name="value10">The value of template data parameter 10.</param>
        /// <param name="name11">The name of template data parameter 11.</param>
        /// <param name="value11">The value of template data parameter 11.</param>
        /// <param name="name12">The name of template data parameter 12.</param>
        /// <param name="value12">The value of template data parameter 12.</param>
        /// <param name="name13">The name of template data parameter 13.</param>
        /// <param name="value13">The value of template data parameter 13.</param>
        /// <param name="name14">The name of template data parameter 14.</param>
        /// <param name="value14">The value of template data parameter 14.</param>
        /// <param name="name15">The name of template data parameter 15.</param>
        /// <param name="value15">The value of template data parameter 15.</param>
        /// <returns>The rendered template with all parameters replaced.</returns> 
        [SqlFunction(DataAccess = DataAccessKind.None, IsDeterministic = true)]
        [return: SqlFacet(MaxSize = -1, IsNullable = true)]
        public static SqlString  RenderTemplateWithStrings15(
            [SqlFacet(MaxSize = -1, IsNullable = true)] SqlString template
            , [SqlFacet(MaxSize = 2000, IsNullable = false)] SqlString name1
            , [SqlFacet(MaxSize = -1, IsNullable = true)] SqlString value1
            , [SqlFacet(MaxSize = 2000, IsNullable = false)] SqlString name2
            , [SqlFacet(MaxSize = -1, IsNullable = true)] SqlString value2
            , [SqlFacet(MaxSize = 2000, IsNullable = false)] SqlString name3
            , [SqlFacet(MaxSize = -1, IsNullable = true)] SqlString value3
            , [SqlFacet(MaxSize = 2000, IsNullable = false)] SqlString name4
            , [SqlFacet(MaxSize = -1, IsNullable = true)] SqlString value4
            , [SqlFacet(MaxSize = 2000, IsNullable = false)] SqlString name5
            , [SqlFacet(MaxSize = -1, IsNullable = true)] SqlString value5
            , [SqlFacet(MaxSize = 2000, IsNullable = false)] SqlString name6
            , [SqlFacet(MaxSize = -1, IsNullable = true)] SqlString value6
            , [SqlFacet(MaxSize = 2000, IsNullable = false)] SqlString name7
            , [SqlFacet(MaxSize = -1, IsNullable = true)] SqlString value7
            , [SqlFacet(MaxSize = 2000, IsNullable = false)] SqlString name8
            , [SqlFacet(MaxSize = -1, IsNullable = true)] SqlString value8
            , [SqlFacet(MaxSize = 2000, IsNullable = false)] SqlString name9
            , [SqlFacet(MaxSize = -1, IsNullable = true)] SqlString value9
            , [SqlFacet(MaxSize = 2000, IsNullable = false)] SqlString name10
            , [SqlFacet(MaxSize = -1, IsNullable = true)] SqlString value10
            , [SqlFacet(MaxSize = 2000, IsNullable = false)] SqlString name11
            , [SqlFacet(MaxSize = -1, IsNullable = true)] SqlString value11
            , [SqlFacet(MaxSize = 2000, IsNullable = false)] SqlString name12
            , [SqlFacet(MaxSize = -1, IsNullable = true)] SqlString value12
            , [SqlFacet(MaxSize = 2000, IsNullable = false)] SqlString name13
            , [SqlFacet(MaxSize = -1, IsNullable = true)] SqlString value13
            , [SqlFacet(MaxSize = 2000, IsNullable = false)] SqlString name14
            , [SqlFacet(MaxSize = -1, IsNullable = true)] SqlString value14
            , [SqlFacet(MaxSize = 2000, IsNullable = false)] SqlString name15
            , [SqlFacet(MaxSize = -1, IsNullable = true)] SqlString value15
        )
        {
            InitializeNustache();

            var paramDict = new Dictionary<string, string>()
            {
                { name1.Value, value1.Value },
                { name2.Value, value2.Value },
                { name3.Value, value3.Value },
                { name4.Value, value4.Value },
                { name5.Value, value5.Value },
                { name6.Value, value6.Value },
                { name7.Value, value7.Value },
                { name8.Value, value8.Value },
                { name9.Value, value9.Value },
                { name10.Value, value10.Value },
                { name11.Value, value11.Value },
                { name12.Value, value12.Value },
                { name13.Value, value13.Value },
                { name14.Value, value14.Value },
                { name15.Value, value15.Value }
            };

            return Render.StringToString(template.Value, paramDict);
        }

		/// <summary>
        /// Renders the given Mustache template with the name/value arguments assembled into a parameter data object.
		/// All arguments must have string-value of length < 2000, longer string-values have not been tested.
        /// </summary>
        /// <param name="template">A Mustache template.</param>
        /// <param name="name1">The name of template data parameter 1.</param>
        /// <param name="value1">The value of template data parameter 1.</param>
        /// <param name="name2">The name of template data parameter 2.</param>
        /// <param name="value2">The value of template data parameter 2.</param>
        /// <param name="name3">The name of template data parameter 3.</param>
        /// <param name="value3">The value of template data parameter 3.</param>
        /// <param name="name4">The name of template data parameter 4.</param>
        /// <param name="value4">The value of template data parameter 4.</param>
        /// <param name="name5">The name of template data parameter 5.</param>
        /// <param name="value5">The value of template data parameter 5.</param>
        /// <param name="name6">The name of template data parameter 6.</param>
        /// <param name="value6">The value of template data parameter 6.</param>
        /// <param name="name7">The name of template data parameter 7.</param>
        /// <param name="value7">The value of template data parameter 7.</param>
        /// <param name="name8">The name of template data parameter 8.</param>
        /// <param name="value8">The value of template data parameter 8.</param>
        /// <param name="name9">The name of template data parameter 9.</param>
        /// <param name="value9">The value of template data parameter 9.</param>
        /// <param name="name10">The name of template data parameter 10.</param>
        /// <param name="value10">The value of template data parameter 10.</param>
        /// <param name="name11">The name of template data parameter 11.</param>
        /// <param name="value11">The value of template data parameter 11.</param>
        /// <param name="name12">The name of template data parameter 12.</param>
        /// <param name="value12">The value of template data parameter 12.</param>
        /// <param name="name13">The name of template data parameter 13.</param>
        /// <param name="value13">The value of template data parameter 13.</param>
        /// <param name="name14">The name of template data parameter 14.</param>
        /// <param name="value14">The value of template data parameter 14.</param>
        /// <param name="name15">The name of template data parameter 15.</param>
        /// <param name="value15">The value of template data parameter 15.</param>
        /// <param name="name16">The name of template data parameter 16.</param>
        /// <param name="value16">The value of template data parameter 16.</param>
        /// <returns>The rendered template with all parameters replaced.</returns> 
        [SqlFunction(DataAccess = DataAccessKind.None, IsDeterministic = true)]
        [return: SqlFacet(MaxSize = -1, IsNullable = true)]
        public static SqlString  RenderTemplateWithStrings16(
            [SqlFacet(MaxSize = -1, IsNullable = true)] SqlString template
            , [SqlFacet(MaxSize = 2000, IsNullable = false)] SqlString name1
            , [SqlFacet(MaxSize = -1, IsNullable = true)] SqlString value1
            , [SqlFacet(MaxSize = 2000, IsNullable = false)] SqlString name2
            , [SqlFacet(MaxSize = -1, IsNullable = true)] SqlString value2
            , [SqlFacet(MaxSize = 2000, IsNullable = false)] SqlString name3
            , [SqlFacet(MaxSize = -1, IsNullable = true)] SqlString value3
            , [SqlFacet(MaxSize = 2000, IsNullable = false)] SqlString name4
            , [SqlFacet(MaxSize = -1, IsNullable = true)] SqlString value4
            , [SqlFacet(MaxSize = 2000, IsNullable = false)] SqlString name5
            , [SqlFacet(MaxSize = -1, IsNullable = true)] SqlString value5
            , [SqlFacet(MaxSize = 2000, IsNullable = false)] SqlString name6
            , [SqlFacet(MaxSize = -1, IsNullable = true)] SqlString value6
            , [SqlFacet(MaxSize = 2000, IsNullable = false)] SqlString name7
            , [SqlFacet(MaxSize = -1, IsNullable = true)] SqlString value7
            , [SqlFacet(MaxSize = 2000, IsNullable = false)] SqlString name8
            , [SqlFacet(MaxSize = -1, IsNullable = true)] SqlString value8
            , [SqlFacet(MaxSize = 2000, IsNullable = false)] SqlString name9
            , [SqlFacet(MaxSize = -1, IsNullable = true)] SqlString value9
            , [SqlFacet(MaxSize = 2000, IsNullable = false)] SqlString name10
            , [SqlFacet(MaxSize = -1, IsNullable = true)] SqlString value10
            , [SqlFacet(MaxSize = 2000, IsNullable = false)] SqlString name11
            , [SqlFacet(MaxSize = -1, IsNullable = true)] SqlString value11
            , [SqlFacet(MaxSize = 2000, IsNullable = false)] SqlString name12
            , [SqlFacet(MaxSize = -1, IsNullable = true)] SqlString value12
            , [SqlFacet(MaxSize = 2000, IsNullable = false)] SqlString name13
            , [SqlFacet(MaxSize = -1, IsNullable = true)] SqlString value13
            , [SqlFacet(MaxSize = 2000, IsNullable = false)] SqlString name14
            , [SqlFacet(MaxSize = -1, IsNullable = true)] SqlString value14
            , [SqlFacet(MaxSize = 2000, IsNullable = false)] SqlString name15
            , [SqlFacet(MaxSize = -1, IsNullable = true)] SqlString value15
            , [SqlFacet(MaxSize = 2000, IsNullable = false)] SqlString name16
            , [SqlFacet(MaxSize = -1, IsNullable = true)] SqlString value16
        )
        {
            InitializeNustache();

            var paramDict = new Dictionary<string, string>()
            {
                { name1.Value, value1.Value },
                { name2.Value, value2.Value },
                { name3.Value, value3.Value },
                { name4.Value, value4.Value },
                { name5.Value, value5.Value },
                { name6.Value, value6.Value },
                { name7.Value, value7.Value },
                { name8.Value, value8.Value },
                { name9.Value, value9.Value },
                { name10.Value, value10.Value },
                { name11.Value, value11.Value },
                { name12.Value, value12.Value },
                { name13.Value, value13.Value },
                { name14.Value, value14.Value },
                { name15.Value, value15.Value },
                { name16.Value, value16.Value }
            };

            return Render.StringToString(template.Value, paramDict);
        }

	}
}