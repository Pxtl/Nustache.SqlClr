 
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
        /// </summary>
        /// <param name="template">A Mustache template.  Length is effectively unbounded. Not null.</param>
        /// <param name="name1">The name of template data parameter 1, max length is 2000 chars.  Not null.</param>
        /// <param name="value1">The value of template data parameter 1.  Length is effectively unbounded.</param>
        /// <returns>The rendered template with all parameters replaced.</returns> 
        [SqlFunction(DataAccess = DataAccessKind.None, IsDeterministic = true)]
        [return: SqlFacet(MaxSize = -1, IsNullable = true)]
        public static SqlString  RenderTemplateWithStrings1(
            [SqlFacet(MaxSize = -1)] SqlString template
            , [SqlFacet(MaxSize = 2000)] SqlString name1
            , [SqlFacet(MaxSize = -1)] SqlString value1
        )
        {
			if (template.IsNull) { throw new ArgumentNullException(nameof(template)); }
            if (name1.IsNull) { throw new ArgumentNullException(nameof(name1)); }

            InitializeNustache();

            var paramDict = new Dictionary<string, string>()
            {
                { name1.ToNullableString(), value1.ToNullableString() }
            };

            return Render.StringToString(template.ToNullableString(), paramDict);
        }

		/// <summary>
        /// Renders the given Mustache template with the name/value arguments assembled into a parameter data object.
        /// </summary>
        /// <param name="template">A Mustache template.  Length is effectively unbounded. Not null.</param>
        /// <param name="name1">The name of template data parameter 1, max length is 2000 chars.  Not null.</param>
        /// <param name="value1">The value of template data parameter 1.  Length is effectively unbounded.</param>
        /// <param name="name2">The name of template data parameter 2, max length is 2000 chars.  Not null.</param>
        /// <param name="value2">The value of template data parameter 2.  Length is effectively unbounded.</param>
        /// <returns>The rendered template with all parameters replaced.</returns> 
        [SqlFunction(DataAccess = DataAccessKind.None, IsDeterministic = true)]
        [return: SqlFacet(MaxSize = -1, IsNullable = true)]
        public static SqlString  RenderTemplateWithStrings2(
            [SqlFacet(MaxSize = -1)] SqlString template
            , [SqlFacet(MaxSize = 2000)] SqlString name1
            , [SqlFacet(MaxSize = -1)] SqlString value1
            , [SqlFacet(MaxSize = 2000)] SqlString name2
            , [SqlFacet(MaxSize = -1)] SqlString value2
        )
        {
			if (template.IsNull) { throw new ArgumentNullException(nameof(template)); }
            if (name1.IsNull) { throw new ArgumentNullException(nameof(name1)); }
            if (name2.IsNull) { throw new ArgumentNullException(nameof(name2)); }

            InitializeNustache();

            var paramDict = new Dictionary<string, string>()
            {
                { name1.ToNullableString(), value1.ToNullableString() },
                { name2.ToNullableString(), value2.ToNullableString() }
            };

            return Render.StringToString(template.ToNullableString(), paramDict);
        }

		/// <summary>
        /// Renders the given Mustache template with the name/value arguments assembled into a parameter data object.
        /// </summary>
        /// <param name="template">A Mustache template.  Length is effectively unbounded. Not null.</param>
        /// <param name="name1">The name of template data parameter 1, max length is 2000 chars.  Not null.</param>
        /// <param name="value1">The value of template data parameter 1.  Length is effectively unbounded.</param>
        /// <param name="name2">The name of template data parameter 2, max length is 2000 chars.  Not null.</param>
        /// <param name="value2">The value of template data parameter 2.  Length is effectively unbounded.</param>
        /// <param name="name3">The name of template data parameter 3, max length is 2000 chars.  Not null.</param>
        /// <param name="value3">The value of template data parameter 3.  Length is effectively unbounded.</param>
        /// <returns>The rendered template with all parameters replaced.</returns> 
        [SqlFunction(DataAccess = DataAccessKind.None, IsDeterministic = true)]
        [return: SqlFacet(MaxSize = -1, IsNullable = true)]
        public static SqlString  RenderTemplateWithStrings3(
            [SqlFacet(MaxSize = -1)] SqlString template
            , [SqlFacet(MaxSize = 2000)] SqlString name1
            , [SqlFacet(MaxSize = -1)] SqlString value1
            , [SqlFacet(MaxSize = 2000)] SqlString name2
            , [SqlFacet(MaxSize = -1)] SqlString value2
            , [SqlFacet(MaxSize = 2000)] SqlString name3
            , [SqlFacet(MaxSize = -1)] SqlString value3
        )
        {
			if (template.IsNull) { throw new ArgumentNullException(nameof(template)); }
            if (name1.IsNull) { throw new ArgumentNullException(nameof(name1)); }
            if (name2.IsNull) { throw new ArgumentNullException(nameof(name2)); }
            if (name3.IsNull) { throw new ArgumentNullException(nameof(name3)); }

            InitializeNustache();

            var paramDict = new Dictionary<string, string>()
            {
                { name1.ToNullableString(), value1.ToNullableString() },
                { name2.ToNullableString(), value2.ToNullableString() },
                { name3.ToNullableString(), value3.ToNullableString() }
            };

            return Render.StringToString(template.ToNullableString(), paramDict);
        }

		/// <summary>
        /// Renders the given Mustache template with the name/value arguments assembled into a parameter data object.
        /// </summary>
        /// <param name="template">A Mustache template.  Length is effectively unbounded. Not null.</param>
        /// <param name="name1">The name of template data parameter 1, max length is 2000 chars.  Not null.</param>
        /// <param name="value1">The value of template data parameter 1.  Length is effectively unbounded.</param>
        /// <param name="name2">The name of template data parameter 2, max length is 2000 chars.  Not null.</param>
        /// <param name="value2">The value of template data parameter 2.  Length is effectively unbounded.</param>
        /// <param name="name3">The name of template data parameter 3, max length is 2000 chars.  Not null.</param>
        /// <param name="value3">The value of template data parameter 3.  Length is effectively unbounded.</param>
        /// <param name="name4">The name of template data parameter 4, max length is 2000 chars.  Not null.</param>
        /// <param name="value4">The value of template data parameter 4.  Length is effectively unbounded.</param>
        /// <returns>The rendered template with all parameters replaced.</returns> 
        [SqlFunction(DataAccess = DataAccessKind.None, IsDeterministic = true)]
        [return: SqlFacet(MaxSize = -1, IsNullable = true)]
        public static SqlString  RenderTemplateWithStrings4(
            [SqlFacet(MaxSize = -1)] SqlString template
            , [SqlFacet(MaxSize = 2000)] SqlString name1
            , [SqlFacet(MaxSize = -1)] SqlString value1
            , [SqlFacet(MaxSize = 2000)] SqlString name2
            , [SqlFacet(MaxSize = -1)] SqlString value2
            , [SqlFacet(MaxSize = 2000)] SqlString name3
            , [SqlFacet(MaxSize = -1)] SqlString value3
            , [SqlFacet(MaxSize = 2000)] SqlString name4
            , [SqlFacet(MaxSize = -1)] SqlString value4
        )
        {
			if (template.IsNull) { throw new ArgumentNullException(nameof(template)); }
            if (name1.IsNull) { throw new ArgumentNullException(nameof(name1)); }
            if (name2.IsNull) { throw new ArgumentNullException(nameof(name2)); }
            if (name3.IsNull) { throw new ArgumentNullException(nameof(name3)); }
            if (name4.IsNull) { throw new ArgumentNullException(nameof(name4)); }

            InitializeNustache();

            var paramDict = new Dictionary<string, string>()
            {
                { name1.ToNullableString(), value1.ToNullableString() },
                { name2.ToNullableString(), value2.ToNullableString() },
                { name3.ToNullableString(), value3.ToNullableString() },
                { name4.ToNullableString(), value4.ToNullableString() }
            };

            return Render.StringToString(template.ToNullableString(), paramDict);
        }

		/// <summary>
        /// Renders the given Mustache template with the name/value arguments assembled into a parameter data object.
        /// </summary>
        /// <param name="template">A Mustache template.  Length is effectively unbounded. Not null.</param>
        /// <param name="name1">The name of template data parameter 1, max length is 2000 chars.  Not null.</param>
        /// <param name="value1">The value of template data parameter 1.  Length is effectively unbounded.</param>
        /// <param name="name2">The name of template data parameter 2, max length is 2000 chars.  Not null.</param>
        /// <param name="value2">The value of template data parameter 2.  Length is effectively unbounded.</param>
        /// <param name="name3">The name of template data parameter 3, max length is 2000 chars.  Not null.</param>
        /// <param name="value3">The value of template data parameter 3.  Length is effectively unbounded.</param>
        /// <param name="name4">The name of template data parameter 4, max length is 2000 chars.  Not null.</param>
        /// <param name="value4">The value of template data parameter 4.  Length is effectively unbounded.</param>
        /// <param name="name5">The name of template data parameter 5, max length is 2000 chars.  Not null.</param>
        /// <param name="value5">The value of template data parameter 5.  Length is effectively unbounded.</param>
        /// <returns>The rendered template with all parameters replaced.</returns> 
        [SqlFunction(DataAccess = DataAccessKind.None, IsDeterministic = true)]
        [return: SqlFacet(MaxSize = -1, IsNullable = true)]
        public static SqlString  RenderTemplateWithStrings5(
            [SqlFacet(MaxSize = -1)] SqlString template
            , [SqlFacet(MaxSize = 2000)] SqlString name1
            , [SqlFacet(MaxSize = -1)] SqlString value1
            , [SqlFacet(MaxSize = 2000)] SqlString name2
            , [SqlFacet(MaxSize = -1)] SqlString value2
            , [SqlFacet(MaxSize = 2000)] SqlString name3
            , [SqlFacet(MaxSize = -1)] SqlString value3
            , [SqlFacet(MaxSize = 2000)] SqlString name4
            , [SqlFacet(MaxSize = -1)] SqlString value4
            , [SqlFacet(MaxSize = 2000)] SqlString name5
            , [SqlFacet(MaxSize = -1)] SqlString value5
        )
        {
			if (template.IsNull) { throw new ArgumentNullException(nameof(template)); }
            if (name1.IsNull) { throw new ArgumentNullException(nameof(name1)); }
            if (name2.IsNull) { throw new ArgumentNullException(nameof(name2)); }
            if (name3.IsNull) { throw new ArgumentNullException(nameof(name3)); }
            if (name4.IsNull) { throw new ArgumentNullException(nameof(name4)); }
            if (name5.IsNull) { throw new ArgumentNullException(nameof(name5)); }

            InitializeNustache();

            var paramDict = new Dictionary<string, string>()
            {
                { name1.ToNullableString(), value1.ToNullableString() },
                { name2.ToNullableString(), value2.ToNullableString() },
                { name3.ToNullableString(), value3.ToNullableString() },
                { name4.ToNullableString(), value4.ToNullableString() },
                { name5.ToNullableString(), value5.ToNullableString() }
            };

            return Render.StringToString(template.ToNullableString(), paramDict);
        }

		/// <summary>
        /// Renders the given Mustache template with the name/value arguments assembled into a parameter data object.
        /// </summary>
        /// <param name="template">A Mustache template.  Length is effectively unbounded. Not null.</param>
        /// <param name="name1">The name of template data parameter 1, max length is 2000 chars.  Not null.</param>
        /// <param name="value1">The value of template data parameter 1.  Length is effectively unbounded.</param>
        /// <param name="name2">The name of template data parameter 2, max length is 2000 chars.  Not null.</param>
        /// <param name="value2">The value of template data parameter 2.  Length is effectively unbounded.</param>
        /// <param name="name3">The name of template data parameter 3, max length is 2000 chars.  Not null.</param>
        /// <param name="value3">The value of template data parameter 3.  Length is effectively unbounded.</param>
        /// <param name="name4">The name of template data parameter 4, max length is 2000 chars.  Not null.</param>
        /// <param name="value4">The value of template data parameter 4.  Length is effectively unbounded.</param>
        /// <param name="name5">The name of template data parameter 5, max length is 2000 chars.  Not null.</param>
        /// <param name="value5">The value of template data parameter 5.  Length is effectively unbounded.</param>
        /// <param name="name6">The name of template data parameter 6, max length is 2000 chars.  Not null.</param>
        /// <param name="value6">The value of template data parameter 6.  Length is effectively unbounded.</param>
        /// <returns>The rendered template with all parameters replaced.</returns> 
        [SqlFunction(DataAccess = DataAccessKind.None, IsDeterministic = true)]
        [return: SqlFacet(MaxSize = -1, IsNullable = true)]
        public static SqlString  RenderTemplateWithStrings6(
            [SqlFacet(MaxSize = -1)] SqlString template
            , [SqlFacet(MaxSize = 2000)] SqlString name1
            , [SqlFacet(MaxSize = -1)] SqlString value1
            , [SqlFacet(MaxSize = 2000)] SqlString name2
            , [SqlFacet(MaxSize = -1)] SqlString value2
            , [SqlFacet(MaxSize = 2000)] SqlString name3
            , [SqlFacet(MaxSize = -1)] SqlString value3
            , [SqlFacet(MaxSize = 2000)] SqlString name4
            , [SqlFacet(MaxSize = -1)] SqlString value4
            , [SqlFacet(MaxSize = 2000)] SqlString name5
            , [SqlFacet(MaxSize = -1)] SqlString value5
            , [SqlFacet(MaxSize = 2000)] SqlString name6
            , [SqlFacet(MaxSize = -1)] SqlString value6
        )
        {
			if (template.IsNull) { throw new ArgumentNullException(nameof(template)); }
            if (name1.IsNull) { throw new ArgumentNullException(nameof(name1)); }
            if (name2.IsNull) { throw new ArgumentNullException(nameof(name2)); }
            if (name3.IsNull) { throw new ArgumentNullException(nameof(name3)); }
            if (name4.IsNull) { throw new ArgumentNullException(nameof(name4)); }
            if (name5.IsNull) { throw new ArgumentNullException(nameof(name5)); }
            if (name6.IsNull) { throw new ArgumentNullException(nameof(name6)); }

            InitializeNustache();

            var paramDict = new Dictionary<string, string>()
            {
                { name1.ToNullableString(), value1.ToNullableString() },
                { name2.ToNullableString(), value2.ToNullableString() },
                { name3.ToNullableString(), value3.ToNullableString() },
                { name4.ToNullableString(), value4.ToNullableString() },
                { name5.ToNullableString(), value5.ToNullableString() },
                { name6.ToNullableString(), value6.ToNullableString() }
            };

            return Render.StringToString(template.ToNullableString(), paramDict);
        }

		/// <summary>
        /// Renders the given Mustache template with the name/value arguments assembled into a parameter data object.
        /// </summary>
        /// <param name="template">A Mustache template.  Length is effectively unbounded. Not null.</param>
        /// <param name="name1">The name of template data parameter 1, max length is 2000 chars.  Not null.</param>
        /// <param name="value1">The value of template data parameter 1.  Length is effectively unbounded.</param>
        /// <param name="name2">The name of template data parameter 2, max length is 2000 chars.  Not null.</param>
        /// <param name="value2">The value of template data parameter 2.  Length is effectively unbounded.</param>
        /// <param name="name3">The name of template data parameter 3, max length is 2000 chars.  Not null.</param>
        /// <param name="value3">The value of template data parameter 3.  Length is effectively unbounded.</param>
        /// <param name="name4">The name of template data parameter 4, max length is 2000 chars.  Not null.</param>
        /// <param name="value4">The value of template data parameter 4.  Length is effectively unbounded.</param>
        /// <param name="name5">The name of template data parameter 5, max length is 2000 chars.  Not null.</param>
        /// <param name="value5">The value of template data parameter 5.  Length is effectively unbounded.</param>
        /// <param name="name6">The name of template data parameter 6, max length is 2000 chars.  Not null.</param>
        /// <param name="value6">The value of template data parameter 6.  Length is effectively unbounded.</param>
        /// <param name="name7">The name of template data parameter 7, max length is 2000 chars.  Not null.</param>
        /// <param name="value7">The value of template data parameter 7.  Length is effectively unbounded.</param>
        /// <returns>The rendered template with all parameters replaced.</returns> 
        [SqlFunction(DataAccess = DataAccessKind.None, IsDeterministic = true)]
        [return: SqlFacet(MaxSize = -1, IsNullable = true)]
        public static SqlString  RenderTemplateWithStrings7(
            [SqlFacet(MaxSize = -1)] SqlString template
            , [SqlFacet(MaxSize = 2000)] SqlString name1
            , [SqlFacet(MaxSize = -1)] SqlString value1
            , [SqlFacet(MaxSize = 2000)] SqlString name2
            , [SqlFacet(MaxSize = -1)] SqlString value2
            , [SqlFacet(MaxSize = 2000)] SqlString name3
            , [SqlFacet(MaxSize = -1)] SqlString value3
            , [SqlFacet(MaxSize = 2000)] SqlString name4
            , [SqlFacet(MaxSize = -1)] SqlString value4
            , [SqlFacet(MaxSize = 2000)] SqlString name5
            , [SqlFacet(MaxSize = -1)] SqlString value5
            , [SqlFacet(MaxSize = 2000)] SqlString name6
            , [SqlFacet(MaxSize = -1)] SqlString value6
            , [SqlFacet(MaxSize = 2000)] SqlString name7
            , [SqlFacet(MaxSize = -1)] SqlString value7
        )
        {
			if (template.IsNull) { throw new ArgumentNullException(nameof(template)); }
            if (name1.IsNull) { throw new ArgumentNullException(nameof(name1)); }
            if (name2.IsNull) { throw new ArgumentNullException(nameof(name2)); }
            if (name3.IsNull) { throw new ArgumentNullException(nameof(name3)); }
            if (name4.IsNull) { throw new ArgumentNullException(nameof(name4)); }
            if (name5.IsNull) { throw new ArgumentNullException(nameof(name5)); }
            if (name6.IsNull) { throw new ArgumentNullException(nameof(name6)); }
            if (name7.IsNull) { throw new ArgumentNullException(nameof(name7)); }

            InitializeNustache();

            var paramDict = new Dictionary<string, string>()
            {
                { name1.ToNullableString(), value1.ToNullableString() },
                { name2.ToNullableString(), value2.ToNullableString() },
                { name3.ToNullableString(), value3.ToNullableString() },
                { name4.ToNullableString(), value4.ToNullableString() },
                { name5.ToNullableString(), value5.ToNullableString() },
                { name6.ToNullableString(), value6.ToNullableString() },
                { name7.ToNullableString(), value7.ToNullableString() }
            };

            return Render.StringToString(template.ToNullableString(), paramDict);
        }

		/// <summary>
        /// Renders the given Mustache template with the name/value arguments assembled into a parameter data object.
        /// </summary>
        /// <param name="template">A Mustache template.  Length is effectively unbounded. Not null.</param>
        /// <param name="name1">The name of template data parameter 1, max length is 2000 chars.  Not null.</param>
        /// <param name="value1">The value of template data parameter 1.  Length is effectively unbounded.</param>
        /// <param name="name2">The name of template data parameter 2, max length is 2000 chars.  Not null.</param>
        /// <param name="value2">The value of template data parameter 2.  Length is effectively unbounded.</param>
        /// <param name="name3">The name of template data parameter 3, max length is 2000 chars.  Not null.</param>
        /// <param name="value3">The value of template data parameter 3.  Length is effectively unbounded.</param>
        /// <param name="name4">The name of template data parameter 4, max length is 2000 chars.  Not null.</param>
        /// <param name="value4">The value of template data parameter 4.  Length is effectively unbounded.</param>
        /// <param name="name5">The name of template data parameter 5, max length is 2000 chars.  Not null.</param>
        /// <param name="value5">The value of template data parameter 5.  Length is effectively unbounded.</param>
        /// <param name="name6">The name of template data parameter 6, max length is 2000 chars.  Not null.</param>
        /// <param name="value6">The value of template data parameter 6.  Length is effectively unbounded.</param>
        /// <param name="name7">The name of template data parameter 7, max length is 2000 chars.  Not null.</param>
        /// <param name="value7">The value of template data parameter 7.  Length is effectively unbounded.</param>
        /// <param name="name8">The name of template data parameter 8, max length is 2000 chars.  Not null.</param>
        /// <param name="value8">The value of template data parameter 8.  Length is effectively unbounded.</param>
        /// <returns>The rendered template with all parameters replaced.</returns> 
        [SqlFunction(DataAccess = DataAccessKind.None, IsDeterministic = true)]
        [return: SqlFacet(MaxSize = -1, IsNullable = true)]
        public static SqlString  RenderTemplateWithStrings8(
            [SqlFacet(MaxSize = -1)] SqlString template
            , [SqlFacet(MaxSize = 2000)] SqlString name1
            , [SqlFacet(MaxSize = -1)] SqlString value1
            , [SqlFacet(MaxSize = 2000)] SqlString name2
            , [SqlFacet(MaxSize = -1)] SqlString value2
            , [SqlFacet(MaxSize = 2000)] SqlString name3
            , [SqlFacet(MaxSize = -1)] SqlString value3
            , [SqlFacet(MaxSize = 2000)] SqlString name4
            , [SqlFacet(MaxSize = -1)] SqlString value4
            , [SqlFacet(MaxSize = 2000)] SqlString name5
            , [SqlFacet(MaxSize = -1)] SqlString value5
            , [SqlFacet(MaxSize = 2000)] SqlString name6
            , [SqlFacet(MaxSize = -1)] SqlString value6
            , [SqlFacet(MaxSize = 2000)] SqlString name7
            , [SqlFacet(MaxSize = -1)] SqlString value7
            , [SqlFacet(MaxSize = 2000)] SqlString name8
            , [SqlFacet(MaxSize = -1)] SqlString value8
        )
        {
			if (template.IsNull) { throw new ArgumentNullException(nameof(template)); }
            if (name1.IsNull) { throw new ArgumentNullException(nameof(name1)); }
            if (name2.IsNull) { throw new ArgumentNullException(nameof(name2)); }
            if (name3.IsNull) { throw new ArgumentNullException(nameof(name3)); }
            if (name4.IsNull) { throw new ArgumentNullException(nameof(name4)); }
            if (name5.IsNull) { throw new ArgumentNullException(nameof(name5)); }
            if (name6.IsNull) { throw new ArgumentNullException(nameof(name6)); }
            if (name7.IsNull) { throw new ArgumentNullException(nameof(name7)); }
            if (name8.IsNull) { throw new ArgumentNullException(nameof(name8)); }

            InitializeNustache();

            var paramDict = new Dictionary<string, string>()
            {
                { name1.ToNullableString(), value1.ToNullableString() },
                { name2.ToNullableString(), value2.ToNullableString() },
                { name3.ToNullableString(), value3.ToNullableString() },
                { name4.ToNullableString(), value4.ToNullableString() },
                { name5.ToNullableString(), value5.ToNullableString() },
                { name6.ToNullableString(), value6.ToNullableString() },
                { name7.ToNullableString(), value7.ToNullableString() },
                { name8.ToNullableString(), value8.ToNullableString() }
            };

            return Render.StringToString(template.ToNullableString(), paramDict);
        }

		/// <summary>
        /// Renders the given Mustache template with the name/value arguments assembled into a parameter data object.
        /// </summary>
        /// <param name="template">A Mustache template.  Length is effectively unbounded. Not null.</param>
        /// <param name="name1">The name of template data parameter 1, max length is 2000 chars.  Not null.</param>
        /// <param name="value1">The value of template data parameter 1.  Length is effectively unbounded.</param>
        /// <param name="name2">The name of template data parameter 2, max length is 2000 chars.  Not null.</param>
        /// <param name="value2">The value of template data parameter 2.  Length is effectively unbounded.</param>
        /// <param name="name3">The name of template data parameter 3, max length is 2000 chars.  Not null.</param>
        /// <param name="value3">The value of template data parameter 3.  Length is effectively unbounded.</param>
        /// <param name="name4">The name of template data parameter 4, max length is 2000 chars.  Not null.</param>
        /// <param name="value4">The value of template data parameter 4.  Length is effectively unbounded.</param>
        /// <param name="name5">The name of template data parameter 5, max length is 2000 chars.  Not null.</param>
        /// <param name="value5">The value of template data parameter 5.  Length is effectively unbounded.</param>
        /// <param name="name6">The name of template data parameter 6, max length is 2000 chars.  Not null.</param>
        /// <param name="value6">The value of template data parameter 6.  Length is effectively unbounded.</param>
        /// <param name="name7">The name of template data parameter 7, max length is 2000 chars.  Not null.</param>
        /// <param name="value7">The value of template data parameter 7.  Length is effectively unbounded.</param>
        /// <param name="name8">The name of template data parameter 8, max length is 2000 chars.  Not null.</param>
        /// <param name="value8">The value of template data parameter 8.  Length is effectively unbounded.</param>
        /// <param name="name9">The name of template data parameter 9, max length is 2000 chars.  Not null.</param>
        /// <param name="value9">The value of template data parameter 9.  Length is effectively unbounded.</param>
        /// <returns>The rendered template with all parameters replaced.</returns> 
        [SqlFunction(DataAccess = DataAccessKind.None, IsDeterministic = true)]
        [return: SqlFacet(MaxSize = -1, IsNullable = true)]
        public static SqlString  RenderTemplateWithStrings9(
            [SqlFacet(MaxSize = -1)] SqlString template
            , [SqlFacet(MaxSize = 2000)] SqlString name1
            , [SqlFacet(MaxSize = -1)] SqlString value1
            , [SqlFacet(MaxSize = 2000)] SqlString name2
            , [SqlFacet(MaxSize = -1)] SqlString value2
            , [SqlFacet(MaxSize = 2000)] SqlString name3
            , [SqlFacet(MaxSize = -1)] SqlString value3
            , [SqlFacet(MaxSize = 2000)] SqlString name4
            , [SqlFacet(MaxSize = -1)] SqlString value4
            , [SqlFacet(MaxSize = 2000)] SqlString name5
            , [SqlFacet(MaxSize = -1)] SqlString value5
            , [SqlFacet(MaxSize = 2000)] SqlString name6
            , [SqlFacet(MaxSize = -1)] SqlString value6
            , [SqlFacet(MaxSize = 2000)] SqlString name7
            , [SqlFacet(MaxSize = -1)] SqlString value7
            , [SqlFacet(MaxSize = 2000)] SqlString name8
            , [SqlFacet(MaxSize = -1)] SqlString value8
            , [SqlFacet(MaxSize = 2000)] SqlString name9
            , [SqlFacet(MaxSize = -1)] SqlString value9
        )
        {
			if (template.IsNull) { throw new ArgumentNullException(nameof(template)); }
            if (name1.IsNull) { throw new ArgumentNullException(nameof(name1)); }
            if (name2.IsNull) { throw new ArgumentNullException(nameof(name2)); }
            if (name3.IsNull) { throw new ArgumentNullException(nameof(name3)); }
            if (name4.IsNull) { throw new ArgumentNullException(nameof(name4)); }
            if (name5.IsNull) { throw new ArgumentNullException(nameof(name5)); }
            if (name6.IsNull) { throw new ArgumentNullException(nameof(name6)); }
            if (name7.IsNull) { throw new ArgumentNullException(nameof(name7)); }
            if (name8.IsNull) { throw new ArgumentNullException(nameof(name8)); }
            if (name9.IsNull) { throw new ArgumentNullException(nameof(name9)); }

            InitializeNustache();

            var paramDict = new Dictionary<string, string>()
            {
                { name1.ToNullableString(), value1.ToNullableString() },
                { name2.ToNullableString(), value2.ToNullableString() },
                { name3.ToNullableString(), value3.ToNullableString() },
                { name4.ToNullableString(), value4.ToNullableString() },
                { name5.ToNullableString(), value5.ToNullableString() },
                { name6.ToNullableString(), value6.ToNullableString() },
                { name7.ToNullableString(), value7.ToNullableString() },
                { name8.ToNullableString(), value8.ToNullableString() },
                { name9.ToNullableString(), value9.ToNullableString() }
            };

            return Render.StringToString(template.ToNullableString(), paramDict);
        }

		/// <summary>
        /// Renders the given Mustache template with the name/value arguments assembled into a parameter data object.
        /// </summary>
        /// <param name="template">A Mustache template.  Length is effectively unbounded. Not null.</param>
        /// <param name="name1">The name of template data parameter 1, max length is 2000 chars.  Not null.</param>
        /// <param name="value1">The value of template data parameter 1.  Length is effectively unbounded.</param>
        /// <param name="name2">The name of template data parameter 2, max length is 2000 chars.  Not null.</param>
        /// <param name="value2">The value of template data parameter 2.  Length is effectively unbounded.</param>
        /// <param name="name3">The name of template data parameter 3, max length is 2000 chars.  Not null.</param>
        /// <param name="value3">The value of template data parameter 3.  Length is effectively unbounded.</param>
        /// <param name="name4">The name of template data parameter 4, max length is 2000 chars.  Not null.</param>
        /// <param name="value4">The value of template data parameter 4.  Length is effectively unbounded.</param>
        /// <param name="name5">The name of template data parameter 5, max length is 2000 chars.  Not null.</param>
        /// <param name="value5">The value of template data parameter 5.  Length is effectively unbounded.</param>
        /// <param name="name6">The name of template data parameter 6, max length is 2000 chars.  Not null.</param>
        /// <param name="value6">The value of template data parameter 6.  Length is effectively unbounded.</param>
        /// <param name="name7">The name of template data parameter 7, max length is 2000 chars.  Not null.</param>
        /// <param name="value7">The value of template data parameter 7.  Length is effectively unbounded.</param>
        /// <param name="name8">The name of template data parameter 8, max length is 2000 chars.  Not null.</param>
        /// <param name="value8">The value of template data parameter 8.  Length is effectively unbounded.</param>
        /// <param name="name9">The name of template data parameter 9, max length is 2000 chars.  Not null.</param>
        /// <param name="value9">The value of template data parameter 9.  Length is effectively unbounded.</param>
        /// <param name="name10">The name of template data parameter 10, max length is 2000 chars.  Not null.</param>
        /// <param name="value10">The value of template data parameter 10.  Length is effectively unbounded.</param>
        /// <returns>The rendered template with all parameters replaced.</returns> 
        [SqlFunction(DataAccess = DataAccessKind.None, IsDeterministic = true)]
        [return: SqlFacet(MaxSize = -1, IsNullable = true)]
        public static SqlString  RenderTemplateWithStrings10(
            [SqlFacet(MaxSize = -1)] SqlString template
            , [SqlFacet(MaxSize = 2000)] SqlString name1
            , [SqlFacet(MaxSize = -1)] SqlString value1
            , [SqlFacet(MaxSize = 2000)] SqlString name2
            , [SqlFacet(MaxSize = -1)] SqlString value2
            , [SqlFacet(MaxSize = 2000)] SqlString name3
            , [SqlFacet(MaxSize = -1)] SqlString value3
            , [SqlFacet(MaxSize = 2000)] SqlString name4
            , [SqlFacet(MaxSize = -1)] SqlString value4
            , [SqlFacet(MaxSize = 2000)] SqlString name5
            , [SqlFacet(MaxSize = -1)] SqlString value5
            , [SqlFacet(MaxSize = 2000)] SqlString name6
            , [SqlFacet(MaxSize = -1)] SqlString value6
            , [SqlFacet(MaxSize = 2000)] SqlString name7
            , [SqlFacet(MaxSize = -1)] SqlString value7
            , [SqlFacet(MaxSize = 2000)] SqlString name8
            , [SqlFacet(MaxSize = -1)] SqlString value8
            , [SqlFacet(MaxSize = 2000)] SqlString name9
            , [SqlFacet(MaxSize = -1)] SqlString value9
            , [SqlFacet(MaxSize = 2000)] SqlString name10
            , [SqlFacet(MaxSize = -1)] SqlString value10
        )
        {
			if (template.IsNull) { throw new ArgumentNullException(nameof(template)); }
            if (name1.IsNull) { throw new ArgumentNullException(nameof(name1)); }
            if (name2.IsNull) { throw new ArgumentNullException(nameof(name2)); }
            if (name3.IsNull) { throw new ArgumentNullException(nameof(name3)); }
            if (name4.IsNull) { throw new ArgumentNullException(nameof(name4)); }
            if (name5.IsNull) { throw new ArgumentNullException(nameof(name5)); }
            if (name6.IsNull) { throw new ArgumentNullException(nameof(name6)); }
            if (name7.IsNull) { throw new ArgumentNullException(nameof(name7)); }
            if (name8.IsNull) { throw new ArgumentNullException(nameof(name8)); }
            if (name9.IsNull) { throw new ArgumentNullException(nameof(name9)); }
            if (name10.IsNull) { throw new ArgumentNullException(nameof(name10)); }

            InitializeNustache();

            var paramDict = new Dictionary<string, string>()
            {
                { name1.ToNullableString(), value1.ToNullableString() },
                { name2.ToNullableString(), value2.ToNullableString() },
                { name3.ToNullableString(), value3.ToNullableString() },
                { name4.ToNullableString(), value4.ToNullableString() },
                { name5.ToNullableString(), value5.ToNullableString() },
                { name6.ToNullableString(), value6.ToNullableString() },
                { name7.ToNullableString(), value7.ToNullableString() },
                { name8.ToNullableString(), value8.ToNullableString() },
                { name9.ToNullableString(), value9.ToNullableString() },
                { name10.ToNullableString(), value10.ToNullableString() }
            };

            return Render.StringToString(template.ToNullableString(), paramDict);
        }

		/// <summary>
        /// Renders the given Mustache template with the name/value arguments assembled into a parameter data object.
        /// </summary>
        /// <param name="template">A Mustache template.  Length is effectively unbounded. Not null.</param>
        /// <param name="name1">The name of template data parameter 1, max length is 2000 chars.  Not null.</param>
        /// <param name="value1">The value of template data parameter 1.  Length is effectively unbounded.</param>
        /// <param name="name2">The name of template data parameter 2, max length is 2000 chars.  Not null.</param>
        /// <param name="value2">The value of template data parameter 2.  Length is effectively unbounded.</param>
        /// <param name="name3">The name of template data parameter 3, max length is 2000 chars.  Not null.</param>
        /// <param name="value3">The value of template data parameter 3.  Length is effectively unbounded.</param>
        /// <param name="name4">The name of template data parameter 4, max length is 2000 chars.  Not null.</param>
        /// <param name="value4">The value of template data parameter 4.  Length is effectively unbounded.</param>
        /// <param name="name5">The name of template data parameter 5, max length is 2000 chars.  Not null.</param>
        /// <param name="value5">The value of template data parameter 5.  Length is effectively unbounded.</param>
        /// <param name="name6">The name of template data parameter 6, max length is 2000 chars.  Not null.</param>
        /// <param name="value6">The value of template data parameter 6.  Length is effectively unbounded.</param>
        /// <param name="name7">The name of template data parameter 7, max length is 2000 chars.  Not null.</param>
        /// <param name="value7">The value of template data parameter 7.  Length is effectively unbounded.</param>
        /// <param name="name8">The name of template data parameter 8, max length is 2000 chars.  Not null.</param>
        /// <param name="value8">The value of template data parameter 8.  Length is effectively unbounded.</param>
        /// <param name="name9">The name of template data parameter 9, max length is 2000 chars.  Not null.</param>
        /// <param name="value9">The value of template data parameter 9.  Length is effectively unbounded.</param>
        /// <param name="name10">The name of template data parameter 10, max length is 2000 chars.  Not null.</param>
        /// <param name="value10">The value of template data parameter 10.  Length is effectively unbounded.</param>
        /// <param name="name11">The name of template data parameter 11, max length is 2000 chars.  Not null.</param>
        /// <param name="value11">The value of template data parameter 11.  Length is effectively unbounded.</param>
        /// <returns>The rendered template with all parameters replaced.</returns> 
        [SqlFunction(DataAccess = DataAccessKind.None, IsDeterministic = true)]
        [return: SqlFacet(MaxSize = -1, IsNullable = true)]
        public static SqlString  RenderTemplateWithStrings11(
            [SqlFacet(MaxSize = -1)] SqlString template
            , [SqlFacet(MaxSize = 2000)] SqlString name1
            , [SqlFacet(MaxSize = -1)] SqlString value1
            , [SqlFacet(MaxSize = 2000)] SqlString name2
            , [SqlFacet(MaxSize = -1)] SqlString value2
            , [SqlFacet(MaxSize = 2000)] SqlString name3
            , [SqlFacet(MaxSize = -1)] SqlString value3
            , [SqlFacet(MaxSize = 2000)] SqlString name4
            , [SqlFacet(MaxSize = -1)] SqlString value4
            , [SqlFacet(MaxSize = 2000)] SqlString name5
            , [SqlFacet(MaxSize = -1)] SqlString value5
            , [SqlFacet(MaxSize = 2000)] SqlString name6
            , [SqlFacet(MaxSize = -1)] SqlString value6
            , [SqlFacet(MaxSize = 2000)] SqlString name7
            , [SqlFacet(MaxSize = -1)] SqlString value7
            , [SqlFacet(MaxSize = 2000)] SqlString name8
            , [SqlFacet(MaxSize = -1)] SqlString value8
            , [SqlFacet(MaxSize = 2000)] SqlString name9
            , [SqlFacet(MaxSize = -1)] SqlString value9
            , [SqlFacet(MaxSize = 2000)] SqlString name10
            , [SqlFacet(MaxSize = -1)] SqlString value10
            , [SqlFacet(MaxSize = 2000)] SqlString name11
            , [SqlFacet(MaxSize = -1)] SqlString value11
        )
        {
			if (template.IsNull) { throw new ArgumentNullException(nameof(template)); }
            if (name1.IsNull) { throw new ArgumentNullException(nameof(name1)); }
            if (name2.IsNull) { throw new ArgumentNullException(nameof(name2)); }
            if (name3.IsNull) { throw new ArgumentNullException(nameof(name3)); }
            if (name4.IsNull) { throw new ArgumentNullException(nameof(name4)); }
            if (name5.IsNull) { throw new ArgumentNullException(nameof(name5)); }
            if (name6.IsNull) { throw new ArgumentNullException(nameof(name6)); }
            if (name7.IsNull) { throw new ArgumentNullException(nameof(name7)); }
            if (name8.IsNull) { throw new ArgumentNullException(nameof(name8)); }
            if (name9.IsNull) { throw new ArgumentNullException(nameof(name9)); }
            if (name10.IsNull) { throw new ArgumentNullException(nameof(name10)); }
            if (name11.IsNull) { throw new ArgumentNullException(nameof(name11)); }

            InitializeNustache();

            var paramDict = new Dictionary<string, string>()
            {
                { name1.ToNullableString(), value1.ToNullableString() },
                { name2.ToNullableString(), value2.ToNullableString() },
                { name3.ToNullableString(), value3.ToNullableString() },
                { name4.ToNullableString(), value4.ToNullableString() },
                { name5.ToNullableString(), value5.ToNullableString() },
                { name6.ToNullableString(), value6.ToNullableString() },
                { name7.ToNullableString(), value7.ToNullableString() },
                { name8.ToNullableString(), value8.ToNullableString() },
                { name9.ToNullableString(), value9.ToNullableString() },
                { name10.ToNullableString(), value10.ToNullableString() },
                { name11.ToNullableString(), value11.ToNullableString() }
            };

            return Render.StringToString(template.ToNullableString(), paramDict);
        }

		/// <summary>
        /// Renders the given Mustache template with the name/value arguments assembled into a parameter data object.
        /// </summary>
        /// <param name="template">A Mustache template.  Length is effectively unbounded. Not null.</param>
        /// <param name="name1">The name of template data parameter 1, max length is 2000 chars.  Not null.</param>
        /// <param name="value1">The value of template data parameter 1.  Length is effectively unbounded.</param>
        /// <param name="name2">The name of template data parameter 2, max length is 2000 chars.  Not null.</param>
        /// <param name="value2">The value of template data parameter 2.  Length is effectively unbounded.</param>
        /// <param name="name3">The name of template data parameter 3, max length is 2000 chars.  Not null.</param>
        /// <param name="value3">The value of template data parameter 3.  Length is effectively unbounded.</param>
        /// <param name="name4">The name of template data parameter 4, max length is 2000 chars.  Not null.</param>
        /// <param name="value4">The value of template data parameter 4.  Length is effectively unbounded.</param>
        /// <param name="name5">The name of template data parameter 5, max length is 2000 chars.  Not null.</param>
        /// <param name="value5">The value of template data parameter 5.  Length is effectively unbounded.</param>
        /// <param name="name6">The name of template data parameter 6, max length is 2000 chars.  Not null.</param>
        /// <param name="value6">The value of template data parameter 6.  Length is effectively unbounded.</param>
        /// <param name="name7">The name of template data parameter 7, max length is 2000 chars.  Not null.</param>
        /// <param name="value7">The value of template data parameter 7.  Length is effectively unbounded.</param>
        /// <param name="name8">The name of template data parameter 8, max length is 2000 chars.  Not null.</param>
        /// <param name="value8">The value of template data parameter 8.  Length is effectively unbounded.</param>
        /// <param name="name9">The name of template data parameter 9, max length is 2000 chars.  Not null.</param>
        /// <param name="value9">The value of template data parameter 9.  Length is effectively unbounded.</param>
        /// <param name="name10">The name of template data parameter 10, max length is 2000 chars.  Not null.</param>
        /// <param name="value10">The value of template data parameter 10.  Length is effectively unbounded.</param>
        /// <param name="name11">The name of template data parameter 11, max length is 2000 chars.  Not null.</param>
        /// <param name="value11">The value of template data parameter 11.  Length is effectively unbounded.</param>
        /// <param name="name12">The name of template data parameter 12, max length is 2000 chars.  Not null.</param>
        /// <param name="value12">The value of template data parameter 12.  Length is effectively unbounded.</param>
        /// <returns>The rendered template with all parameters replaced.</returns> 
        [SqlFunction(DataAccess = DataAccessKind.None, IsDeterministic = true)]
        [return: SqlFacet(MaxSize = -1, IsNullable = true)]
        public static SqlString  RenderTemplateWithStrings12(
            [SqlFacet(MaxSize = -1)] SqlString template
            , [SqlFacet(MaxSize = 2000)] SqlString name1
            , [SqlFacet(MaxSize = -1)] SqlString value1
            , [SqlFacet(MaxSize = 2000)] SqlString name2
            , [SqlFacet(MaxSize = -1)] SqlString value2
            , [SqlFacet(MaxSize = 2000)] SqlString name3
            , [SqlFacet(MaxSize = -1)] SqlString value3
            , [SqlFacet(MaxSize = 2000)] SqlString name4
            , [SqlFacet(MaxSize = -1)] SqlString value4
            , [SqlFacet(MaxSize = 2000)] SqlString name5
            , [SqlFacet(MaxSize = -1)] SqlString value5
            , [SqlFacet(MaxSize = 2000)] SqlString name6
            , [SqlFacet(MaxSize = -1)] SqlString value6
            , [SqlFacet(MaxSize = 2000)] SqlString name7
            , [SqlFacet(MaxSize = -1)] SqlString value7
            , [SqlFacet(MaxSize = 2000)] SqlString name8
            , [SqlFacet(MaxSize = -1)] SqlString value8
            , [SqlFacet(MaxSize = 2000)] SqlString name9
            , [SqlFacet(MaxSize = -1)] SqlString value9
            , [SqlFacet(MaxSize = 2000)] SqlString name10
            , [SqlFacet(MaxSize = -1)] SqlString value10
            , [SqlFacet(MaxSize = 2000)] SqlString name11
            , [SqlFacet(MaxSize = -1)] SqlString value11
            , [SqlFacet(MaxSize = 2000)] SqlString name12
            , [SqlFacet(MaxSize = -1)] SqlString value12
        )
        {
			if (template.IsNull) { throw new ArgumentNullException(nameof(template)); }
            if (name1.IsNull) { throw new ArgumentNullException(nameof(name1)); }
            if (name2.IsNull) { throw new ArgumentNullException(nameof(name2)); }
            if (name3.IsNull) { throw new ArgumentNullException(nameof(name3)); }
            if (name4.IsNull) { throw new ArgumentNullException(nameof(name4)); }
            if (name5.IsNull) { throw new ArgumentNullException(nameof(name5)); }
            if (name6.IsNull) { throw new ArgumentNullException(nameof(name6)); }
            if (name7.IsNull) { throw new ArgumentNullException(nameof(name7)); }
            if (name8.IsNull) { throw new ArgumentNullException(nameof(name8)); }
            if (name9.IsNull) { throw new ArgumentNullException(nameof(name9)); }
            if (name10.IsNull) { throw new ArgumentNullException(nameof(name10)); }
            if (name11.IsNull) { throw new ArgumentNullException(nameof(name11)); }
            if (name12.IsNull) { throw new ArgumentNullException(nameof(name12)); }

            InitializeNustache();

            var paramDict = new Dictionary<string, string>()
            {
                { name1.ToNullableString(), value1.ToNullableString() },
                { name2.ToNullableString(), value2.ToNullableString() },
                { name3.ToNullableString(), value3.ToNullableString() },
                { name4.ToNullableString(), value4.ToNullableString() },
                { name5.ToNullableString(), value5.ToNullableString() },
                { name6.ToNullableString(), value6.ToNullableString() },
                { name7.ToNullableString(), value7.ToNullableString() },
                { name8.ToNullableString(), value8.ToNullableString() },
                { name9.ToNullableString(), value9.ToNullableString() },
                { name10.ToNullableString(), value10.ToNullableString() },
                { name11.ToNullableString(), value11.ToNullableString() },
                { name12.ToNullableString(), value12.ToNullableString() }
            };

            return Render.StringToString(template.ToNullableString(), paramDict);
        }

		/// <summary>
        /// Renders the given Mustache template with the name/value arguments assembled into a parameter data object.
        /// </summary>
        /// <param name="template">A Mustache template.  Length is effectively unbounded. Not null.</param>
        /// <param name="name1">The name of template data parameter 1, max length is 2000 chars.  Not null.</param>
        /// <param name="value1">The value of template data parameter 1.  Length is effectively unbounded.</param>
        /// <param name="name2">The name of template data parameter 2, max length is 2000 chars.  Not null.</param>
        /// <param name="value2">The value of template data parameter 2.  Length is effectively unbounded.</param>
        /// <param name="name3">The name of template data parameter 3, max length is 2000 chars.  Not null.</param>
        /// <param name="value3">The value of template data parameter 3.  Length is effectively unbounded.</param>
        /// <param name="name4">The name of template data parameter 4, max length is 2000 chars.  Not null.</param>
        /// <param name="value4">The value of template data parameter 4.  Length is effectively unbounded.</param>
        /// <param name="name5">The name of template data parameter 5, max length is 2000 chars.  Not null.</param>
        /// <param name="value5">The value of template data parameter 5.  Length is effectively unbounded.</param>
        /// <param name="name6">The name of template data parameter 6, max length is 2000 chars.  Not null.</param>
        /// <param name="value6">The value of template data parameter 6.  Length is effectively unbounded.</param>
        /// <param name="name7">The name of template data parameter 7, max length is 2000 chars.  Not null.</param>
        /// <param name="value7">The value of template data parameter 7.  Length is effectively unbounded.</param>
        /// <param name="name8">The name of template data parameter 8, max length is 2000 chars.  Not null.</param>
        /// <param name="value8">The value of template data parameter 8.  Length is effectively unbounded.</param>
        /// <param name="name9">The name of template data parameter 9, max length is 2000 chars.  Not null.</param>
        /// <param name="value9">The value of template data parameter 9.  Length is effectively unbounded.</param>
        /// <param name="name10">The name of template data parameter 10, max length is 2000 chars.  Not null.</param>
        /// <param name="value10">The value of template data parameter 10.  Length is effectively unbounded.</param>
        /// <param name="name11">The name of template data parameter 11, max length is 2000 chars.  Not null.</param>
        /// <param name="value11">The value of template data parameter 11.  Length is effectively unbounded.</param>
        /// <param name="name12">The name of template data parameter 12, max length is 2000 chars.  Not null.</param>
        /// <param name="value12">The value of template data parameter 12.  Length is effectively unbounded.</param>
        /// <param name="name13">The name of template data parameter 13, max length is 2000 chars.  Not null.</param>
        /// <param name="value13">The value of template data parameter 13.  Length is effectively unbounded.</param>
        /// <returns>The rendered template with all parameters replaced.</returns> 
        [SqlFunction(DataAccess = DataAccessKind.None, IsDeterministic = true)]
        [return: SqlFacet(MaxSize = -1, IsNullable = true)]
        public static SqlString  RenderTemplateWithStrings13(
            [SqlFacet(MaxSize = -1)] SqlString template
            , [SqlFacet(MaxSize = 2000)] SqlString name1
            , [SqlFacet(MaxSize = -1)] SqlString value1
            , [SqlFacet(MaxSize = 2000)] SqlString name2
            , [SqlFacet(MaxSize = -1)] SqlString value2
            , [SqlFacet(MaxSize = 2000)] SqlString name3
            , [SqlFacet(MaxSize = -1)] SqlString value3
            , [SqlFacet(MaxSize = 2000)] SqlString name4
            , [SqlFacet(MaxSize = -1)] SqlString value4
            , [SqlFacet(MaxSize = 2000)] SqlString name5
            , [SqlFacet(MaxSize = -1)] SqlString value5
            , [SqlFacet(MaxSize = 2000)] SqlString name6
            , [SqlFacet(MaxSize = -1)] SqlString value6
            , [SqlFacet(MaxSize = 2000)] SqlString name7
            , [SqlFacet(MaxSize = -1)] SqlString value7
            , [SqlFacet(MaxSize = 2000)] SqlString name8
            , [SqlFacet(MaxSize = -1)] SqlString value8
            , [SqlFacet(MaxSize = 2000)] SqlString name9
            , [SqlFacet(MaxSize = -1)] SqlString value9
            , [SqlFacet(MaxSize = 2000)] SqlString name10
            , [SqlFacet(MaxSize = -1)] SqlString value10
            , [SqlFacet(MaxSize = 2000)] SqlString name11
            , [SqlFacet(MaxSize = -1)] SqlString value11
            , [SqlFacet(MaxSize = 2000)] SqlString name12
            , [SqlFacet(MaxSize = -1)] SqlString value12
            , [SqlFacet(MaxSize = 2000)] SqlString name13
            , [SqlFacet(MaxSize = -1)] SqlString value13
        )
        {
			if (template.IsNull) { throw new ArgumentNullException(nameof(template)); }
            if (name1.IsNull) { throw new ArgumentNullException(nameof(name1)); }
            if (name2.IsNull) { throw new ArgumentNullException(nameof(name2)); }
            if (name3.IsNull) { throw new ArgumentNullException(nameof(name3)); }
            if (name4.IsNull) { throw new ArgumentNullException(nameof(name4)); }
            if (name5.IsNull) { throw new ArgumentNullException(nameof(name5)); }
            if (name6.IsNull) { throw new ArgumentNullException(nameof(name6)); }
            if (name7.IsNull) { throw new ArgumentNullException(nameof(name7)); }
            if (name8.IsNull) { throw new ArgumentNullException(nameof(name8)); }
            if (name9.IsNull) { throw new ArgumentNullException(nameof(name9)); }
            if (name10.IsNull) { throw new ArgumentNullException(nameof(name10)); }
            if (name11.IsNull) { throw new ArgumentNullException(nameof(name11)); }
            if (name12.IsNull) { throw new ArgumentNullException(nameof(name12)); }
            if (name13.IsNull) { throw new ArgumentNullException(nameof(name13)); }

            InitializeNustache();

            var paramDict = new Dictionary<string, string>()
            {
                { name1.ToNullableString(), value1.ToNullableString() },
                { name2.ToNullableString(), value2.ToNullableString() },
                { name3.ToNullableString(), value3.ToNullableString() },
                { name4.ToNullableString(), value4.ToNullableString() },
                { name5.ToNullableString(), value5.ToNullableString() },
                { name6.ToNullableString(), value6.ToNullableString() },
                { name7.ToNullableString(), value7.ToNullableString() },
                { name8.ToNullableString(), value8.ToNullableString() },
                { name9.ToNullableString(), value9.ToNullableString() },
                { name10.ToNullableString(), value10.ToNullableString() },
                { name11.ToNullableString(), value11.ToNullableString() },
                { name12.ToNullableString(), value12.ToNullableString() },
                { name13.ToNullableString(), value13.ToNullableString() }
            };

            return Render.StringToString(template.ToNullableString(), paramDict);
        }

		/// <summary>
        /// Renders the given Mustache template with the name/value arguments assembled into a parameter data object.
        /// </summary>
        /// <param name="template">A Mustache template.  Length is effectively unbounded. Not null.</param>
        /// <param name="name1">The name of template data parameter 1, max length is 2000 chars.  Not null.</param>
        /// <param name="value1">The value of template data parameter 1.  Length is effectively unbounded.</param>
        /// <param name="name2">The name of template data parameter 2, max length is 2000 chars.  Not null.</param>
        /// <param name="value2">The value of template data parameter 2.  Length is effectively unbounded.</param>
        /// <param name="name3">The name of template data parameter 3, max length is 2000 chars.  Not null.</param>
        /// <param name="value3">The value of template data parameter 3.  Length is effectively unbounded.</param>
        /// <param name="name4">The name of template data parameter 4, max length is 2000 chars.  Not null.</param>
        /// <param name="value4">The value of template data parameter 4.  Length is effectively unbounded.</param>
        /// <param name="name5">The name of template data parameter 5, max length is 2000 chars.  Not null.</param>
        /// <param name="value5">The value of template data parameter 5.  Length is effectively unbounded.</param>
        /// <param name="name6">The name of template data parameter 6, max length is 2000 chars.  Not null.</param>
        /// <param name="value6">The value of template data parameter 6.  Length is effectively unbounded.</param>
        /// <param name="name7">The name of template data parameter 7, max length is 2000 chars.  Not null.</param>
        /// <param name="value7">The value of template data parameter 7.  Length is effectively unbounded.</param>
        /// <param name="name8">The name of template data parameter 8, max length is 2000 chars.  Not null.</param>
        /// <param name="value8">The value of template data parameter 8.  Length is effectively unbounded.</param>
        /// <param name="name9">The name of template data parameter 9, max length is 2000 chars.  Not null.</param>
        /// <param name="value9">The value of template data parameter 9.  Length is effectively unbounded.</param>
        /// <param name="name10">The name of template data parameter 10, max length is 2000 chars.  Not null.</param>
        /// <param name="value10">The value of template data parameter 10.  Length is effectively unbounded.</param>
        /// <param name="name11">The name of template data parameter 11, max length is 2000 chars.  Not null.</param>
        /// <param name="value11">The value of template data parameter 11.  Length is effectively unbounded.</param>
        /// <param name="name12">The name of template data parameter 12, max length is 2000 chars.  Not null.</param>
        /// <param name="value12">The value of template data parameter 12.  Length is effectively unbounded.</param>
        /// <param name="name13">The name of template data parameter 13, max length is 2000 chars.  Not null.</param>
        /// <param name="value13">The value of template data parameter 13.  Length is effectively unbounded.</param>
        /// <param name="name14">The name of template data parameter 14, max length is 2000 chars.  Not null.</param>
        /// <param name="value14">The value of template data parameter 14.  Length is effectively unbounded.</param>
        /// <returns>The rendered template with all parameters replaced.</returns> 
        [SqlFunction(DataAccess = DataAccessKind.None, IsDeterministic = true)]
        [return: SqlFacet(MaxSize = -1, IsNullable = true)]
        public static SqlString  RenderTemplateWithStrings14(
            [SqlFacet(MaxSize = -1)] SqlString template
            , [SqlFacet(MaxSize = 2000)] SqlString name1
            , [SqlFacet(MaxSize = -1)] SqlString value1
            , [SqlFacet(MaxSize = 2000)] SqlString name2
            , [SqlFacet(MaxSize = -1)] SqlString value2
            , [SqlFacet(MaxSize = 2000)] SqlString name3
            , [SqlFacet(MaxSize = -1)] SqlString value3
            , [SqlFacet(MaxSize = 2000)] SqlString name4
            , [SqlFacet(MaxSize = -1)] SqlString value4
            , [SqlFacet(MaxSize = 2000)] SqlString name5
            , [SqlFacet(MaxSize = -1)] SqlString value5
            , [SqlFacet(MaxSize = 2000)] SqlString name6
            , [SqlFacet(MaxSize = -1)] SqlString value6
            , [SqlFacet(MaxSize = 2000)] SqlString name7
            , [SqlFacet(MaxSize = -1)] SqlString value7
            , [SqlFacet(MaxSize = 2000)] SqlString name8
            , [SqlFacet(MaxSize = -1)] SqlString value8
            , [SqlFacet(MaxSize = 2000)] SqlString name9
            , [SqlFacet(MaxSize = -1)] SqlString value9
            , [SqlFacet(MaxSize = 2000)] SqlString name10
            , [SqlFacet(MaxSize = -1)] SqlString value10
            , [SqlFacet(MaxSize = 2000)] SqlString name11
            , [SqlFacet(MaxSize = -1)] SqlString value11
            , [SqlFacet(MaxSize = 2000)] SqlString name12
            , [SqlFacet(MaxSize = -1)] SqlString value12
            , [SqlFacet(MaxSize = 2000)] SqlString name13
            , [SqlFacet(MaxSize = -1)] SqlString value13
            , [SqlFacet(MaxSize = 2000)] SqlString name14
            , [SqlFacet(MaxSize = -1)] SqlString value14
        )
        {
			if (template.IsNull) { throw new ArgumentNullException(nameof(template)); }
            if (name1.IsNull) { throw new ArgumentNullException(nameof(name1)); }
            if (name2.IsNull) { throw new ArgumentNullException(nameof(name2)); }
            if (name3.IsNull) { throw new ArgumentNullException(nameof(name3)); }
            if (name4.IsNull) { throw new ArgumentNullException(nameof(name4)); }
            if (name5.IsNull) { throw new ArgumentNullException(nameof(name5)); }
            if (name6.IsNull) { throw new ArgumentNullException(nameof(name6)); }
            if (name7.IsNull) { throw new ArgumentNullException(nameof(name7)); }
            if (name8.IsNull) { throw new ArgumentNullException(nameof(name8)); }
            if (name9.IsNull) { throw new ArgumentNullException(nameof(name9)); }
            if (name10.IsNull) { throw new ArgumentNullException(nameof(name10)); }
            if (name11.IsNull) { throw new ArgumentNullException(nameof(name11)); }
            if (name12.IsNull) { throw new ArgumentNullException(nameof(name12)); }
            if (name13.IsNull) { throw new ArgumentNullException(nameof(name13)); }
            if (name14.IsNull) { throw new ArgumentNullException(nameof(name14)); }

            InitializeNustache();

            var paramDict = new Dictionary<string, string>()
            {
                { name1.ToNullableString(), value1.ToNullableString() },
                { name2.ToNullableString(), value2.ToNullableString() },
                { name3.ToNullableString(), value3.ToNullableString() },
                { name4.ToNullableString(), value4.ToNullableString() },
                { name5.ToNullableString(), value5.ToNullableString() },
                { name6.ToNullableString(), value6.ToNullableString() },
                { name7.ToNullableString(), value7.ToNullableString() },
                { name8.ToNullableString(), value8.ToNullableString() },
                { name9.ToNullableString(), value9.ToNullableString() },
                { name10.ToNullableString(), value10.ToNullableString() },
                { name11.ToNullableString(), value11.ToNullableString() },
                { name12.ToNullableString(), value12.ToNullableString() },
                { name13.ToNullableString(), value13.ToNullableString() },
                { name14.ToNullableString(), value14.ToNullableString() }
            };

            return Render.StringToString(template.ToNullableString(), paramDict);
        }

		/// <summary>
        /// Renders the given Mustache template with the name/value arguments assembled into a parameter data object.
        /// </summary>
        /// <param name="template">A Mustache template.  Length is effectively unbounded. Not null.</param>
        /// <param name="name1">The name of template data parameter 1, max length is 2000 chars.  Not null.</param>
        /// <param name="value1">The value of template data parameter 1.  Length is effectively unbounded.</param>
        /// <param name="name2">The name of template data parameter 2, max length is 2000 chars.  Not null.</param>
        /// <param name="value2">The value of template data parameter 2.  Length is effectively unbounded.</param>
        /// <param name="name3">The name of template data parameter 3, max length is 2000 chars.  Not null.</param>
        /// <param name="value3">The value of template data parameter 3.  Length is effectively unbounded.</param>
        /// <param name="name4">The name of template data parameter 4, max length is 2000 chars.  Not null.</param>
        /// <param name="value4">The value of template data parameter 4.  Length is effectively unbounded.</param>
        /// <param name="name5">The name of template data parameter 5, max length is 2000 chars.  Not null.</param>
        /// <param name="value5">The value of template data parameter 5.  Length is effectively unbounded.</param>
        /// <param name="name6">The name of template data parameter 6, max length is 2000 chars.  Not null.</param>
        /// <param name="value6">The value of template data parameter 6.  Length is effectively unbounded.</param>
        /// <param name="name7">The name of template data parameter 7, max length is 2000 chars.  Not null.</param>
        /// <param name="value7">The value of template data parameter 7.  Length is effectively unbounded.</param>
        /// <param name="name8">The name of template data parameter 8, max length is 2000 chars.  Not null.</param>
        /// <param name="value8">The value of template data parameter 8.  Length is effectively unbounded.</param>
        /// <param name="name9">The name of template data parameter 9, max length is 2000 chars.  Not null.</param>
        /// <param name="value9">The value of template data parameter 9.  Length is effectively unbounded.</param>
        /// <param name="name10">The name of template data parameter 10, max length is 2000 chars.  Not null.</param>
        /// <param name="value10">The value of template data parameter 10.  Length is effectively unbounded.</param>
        /// <param name="name11">The name of template data parameter 11, max length is 2000 chars.  Not null.</param>
        /// <param name="value11">The value of template data parameter 11.  Length is effectively unbounded.</param>
        /// <param name="name12">The name of template data parameter 12, max length is 2000 chars.  Not null.</param>
        /// <param name="value12">The value of template data parameter 12.  Length is effectively unbounded.</param>
        /// <param name="name13">The name of template data parameter 13, max length is 2000 chars.  Not null.</param>
        /// <param name="value13">The value of template data parameter 13.  Length is effectively unbounded.</param>
        /// <param name="name14">The name of template data parameter 14, max length is 2000 chars.  Not null.</param>
        /// <param name="value14">The value of template data parameter 14.  Length is effectively unbounded.</param>
        /// <param name="name15">The name of template data parameter 15, max length is 2000 chars.  Not null.</param>
        /// <param name="value15">The value of template data parameter 15.  Length is effectively unbounded.</param>
        /// <returns>The rendered template with all parameters replaced.</returns> 
        [SqlFunction(DataAccess = DataAccessKind.None, IsDeterministic = true)]
        [return: SqlFacet(MaxSize = -1, IsNullable = true)]
        public static SqlString  RenderTemplateWithStrings15(
            [SqlFacet(MaxSize = -1)] SqlString template
            , [SqlFacet(MaxSize = 2000)] SqlString name1
            , [SqlFacet(MaxSize = -1)] SqlString value1
            , [SqlFacet(MaxSize = 2000)] SqlString name2
            , [SqlFacet(MaxSize = -1)] SqlString value2
            , [SqlFacet(MaxSize = 2000)] SqlString name3
            , [SqlFacet(MaxSize = -1)] SqlString value3
            , [SqlFacet(MaxSize = 2000)] SqlString name4
            , [SqlFacet(MaxSize = -1)] SqlString value4
            , [SqlFacet(MaxSize = 2000)] SqlString name5
            , [SqlFacet(MaxSize = -1)] SqlString value5
            , [SqlFacet(MaxSize = 2000)] SqlString name6
            , [SqlFacet(MaxSize = -1)] SqlString value6
            , [SqlFacet(MaxSize = 2000)] SqlString name7
            , [SqlFacet(MaxSize = -1)] SqlString value7
            , [SqlFacet(MaxSize = 2000)] SqlString name8
            , [SqlFacet(MaxSize = -1)] SqlString value8
            , [SqlFacet(MaxSize = 2000)] SqlString name9
            , [SqlFacet(MaxSize = -1)] SqlString value9
            , [SqlFacet(MaxSize = 2000)] SqlString name10
            , [SqlFacet(MaxSize = -1)] SqlString value10
            , [SqlFacet(MaxSize = 2000)] SqlString name11
            , [SqlFacet(MaxSize = -1)] SqlString value11
            , [SqlFacet(MaxSize = 2000)] SqlString name12
            , [SqlFacet(MaxSize = -1)] SqlString value12
            , [SqlFacet(MaxSize = 2000)] SqlString name13
            , [SqlFacet(MaxSize = -1)] SqlString value13
            , [SqlFacet(MaxSize = 2000)] SqlString name14
            , [SqlFacet(MaxSize = -1)] SqlString value14
            , [SqlFacet(MaxSize = 2000)] SqlString name15
            , [SqlFacet(MaxSize = -1)] SqlString value15
        )
        {
			if (template.IsNull) { throw new ArgumentNullException(nameof(template)); }
            if (name1.IsNull) { throw new ArgumentNullException(nameof(name1)); }
            if (name2.IsNull) { throw new ArgumentNullException(nameof(name2)); }
            if (name3.IsNull) { throw new ArgumentNullException(nameof(name3)); }
            if (name4.IsNull) { throw new ArgumentNullException(nameof(name4)); }
            if (name5.IsNull) { throw new ArgumentNullException(nameof(name5)); }
            if (name6.IsNull) { throw new ArgumentNullException(nameof(name6)); }
            if (name7.IsNull) { throw new ArgumentNullException(nameof(name7)); }
            if (name8.IsNull) { throw new ArgumentNullException(nameof(name8)); }
            if (name9.IsNull) { throw new ArgumentNullException(nameof(name9)); }
            if (name10.IsNull) { throw new ArgumentNullException(nameof(name10)); }
            if (name11.IsNull) { throw new ArgumentNullException(nameof(name11)); }
            if (name12.IsNull) { throw new ArgumentNullException(nameof(name12)); }
            if (name13.IsNull) { throw new ArgumentNullException(nameof(name13)); }
            if (name14.IsNull) { throw new ArgumentNullException(nameof(name14)); }
            if (name15.IsNull) { throw new ArgumentNullException(nameof(name15)); }

            InitializeNustache();

            var paramDict = new Dictionary<string, string>()
            {
                { name1.ToNullableString(), value1.ToNullableString() },
                { name2.ToNullableString(), value2.ToNullableString() },
                { name3.ToNullableString(), value3.ToNullableString() },
                { name4.ToNullableString(), value4.ToNullableString() },
                { name5.ToNullableString(), value5.ToNullableString() },
                { name6.ToNullableString(), value6.ToNullableString() },
                { name7.ToNullableString(), value7.ToNullableString() },
                { name8.ToNullableString(), value8.ToNullableString() },
                { name9.ToNullableString(), value9.ToNullableString() },
                { name10.ToNullableString(), value10.ToNullableString() },
                { name11.ToNullableString(), value11.ToNullableString() },
                { name12.ToNullableString(), value12.ToNullableString() },
                { name13.ToNullableString(), value13.ToNullableString() },
                { name14.ToNullableString(), value14.ToNullableString() },
                { name15.ToNullableString(), value15.ToNullableString() }
            };

            return Render.StringToString(template.ToNullableString(), paramDict);
        }

		/// <summary>
        /// Renders the given Mustache template with the name/value arguments assembled into a parameter data object.
        /// </summary>
        /// <param name="template">A Mustache template.  Length is effectively unbounded. Not null.</param>
        /// <param name="name1">The name of template data parameter 1, max length is 2000 chars.  Not null.</param>
        /// <param name="value1">The value of template data parameter 1.  Length is effectively unbounded.</param>
        /// <param name="name2">The name of template data parameter 2, max length is 2000 chars.  Not null.</param>
        /// <param name="value2">The value of template data parameter 2.  Length is effectively unbounded.</param>
        /// <param name="name3">The name of template data parameter 3, max length is 2000 chars.  Not null.</param>
        /// <param name="value3">The value of template data parameter 3.  Length is effectively unbounded.</param>
        /// <param name="name4">The name of template data parameter 4, max length is 2000 chars.  Not null.</param>
        /// <param name="value4">The value of template data parameter 4.  Length is effectively unbounded.</param>
        /// <param name="name5">The name of template data parameter 5, max length is 2000 chars.  Not null.</param>
        /// <param name="value5">The value of template data parameter 5.  Length is effectively unbounded.</param>
        /// <param name="name6">The name of template data parameter 6, max length is 2000 chars.  Not null.</param>
        /// <param name="value6">The value of template data parameter 6.  Length is effectively unbounded.</param>
        /// <param name="name7">The name of template data parameter 7, max length is 2000 chars.  Not null.</param>
        /// <param name="value7">The value of template data parameter 7.  Length is effectively unbounded.</param>
        /// <param name="name8">The name of template data parameter 8, max length is 2000 chars.  Not null.</param>
        /// <param name="value8">The value of template data parameter 8.  Length is effectively unbounded.</param>
        /// <param name="name9">The name of template data parameter 9, max length is 2000 chars.  Not null.</param>
        /// <param name="value9">The value of template data parameter 9.  Length is effectively unbounded.</param>
        /// <param name="name10">The name of template data parameter 10, max length is 2000 chars.  Not null.</param>
        /// <param name="value10">The value of template data parameter 10.  Length is effectively unbounded.</param>
        /// <param name="name11">The name of template data parameter 11, max length is 2000 chars.  Not null.</param>
        /// <param name="value11">The value of template data parameter 11.  Length is effectively unbounded.</param>
        /// <param name="name12">The name of template data parameter 12, max length is 2000 chars.  Not null.</param>
        /// <param name="value12">The value of template data parameter 12.  Length is effectively unbounded.</param>
        /// <param name="name13">The name of template data parameter 13, max length is 2000 chars.  Not null.</param>
        /// <param name="value13">The value of template data parameter 13.  Length is effectively unbounded.</param>
        /// <param name="name14">The name of template data parameter 14, max length is 2000 chars.  Not null.</param>
        /// <param name="value14">The value of template data parameter 14.  Length is effectively unbounded.</param>
        /// <param name="name15">The name of template data parameter 15, max length is 2000 chars.  Not null.</param>
        /// <param name="value15">The value of template data parameter 15.  Length is effectively unbounded.</param>
        /// <param name="name16">The name of template data parameter 16, max length is 2000 chars.  Not null.</param>
        /// <param name="value16">The value of template data parameter 16.  Length is effectively unbounded.</param>
        /// <returns>The rendered template with all parameters replaced.</returns> 
        [SqlFunction(DataAccess = DataAccessKind.None, IsDeterministic = true)]
        [return: SqlFacet(MaxSize = -1, IsNullable = true)]
        public static SqlString  RenderTemplateWithStrings16(
            [SqlFacet(MaxSize = -1)] SqlString template
            , [SqlFacet(MaxSize = 2000)] SqlString name1
            , [SqlFacet(MaxSize = -1)] SqlString value1
            , [SqlFacet(MaxSize = 2000)] SqlString name2
            , [SqlFacet(MaxSize = -1)] SqlString value2
            , [SqlFacet(MaxSize = 2000)] SqlString name3
            , [SqlFacet(MaxSize = -1)] SqlString value3
            , [SqlFacet(MaxSize = 2000)] SqlString name4
            , [SqlFacet(MaxSize = -1)] SqlString value4
            , [SqlFacet(MaxSize = 2000)] SqlString name5
            , [SqlFacet(MaxSize = -1)] SqlString value5
            , [SqlFacet(MaxSize = 2000)] SqlString name6
            , [SqlFacet(MaxSize = -1)] SqlString value6
            , [SqlFacet(MaxSize = 2000)] SqlString name7
            , [SqlFacet(MaxSize = -1)] SqlString value7
            , [SqlFacet(MaxSize = 2000)] SqlString name8
            , [SqlFacet(MaxSize = -1)] SqlString value8
            , [SqlFacet(MaxSize = 2000)] SqlString name9
            , [SqlFacet(MaxSize = -1)] SqlString value9
            , [SqlFacet(MaxSize = 2000)] SqlString name10
            , [SqlFacet(MaxSize = -1)] SqlString value10
            , [SqlFacet(MaxSize = 2000)] SqlString name11
            , [SqlFacet(MaxSize = -1)] SqlString value11
            , [SqlFacet(MaxSize = 2000)] SqlString name12
            , [SqlFacet(MaxSize = -1)] SqlString value12
            , [SqlFacet(MaxSize = 2000)] SqlString name13
            , [SqlFacet(MaxSize = -1)] SqlString value13
            , [SqlFacet(MaxSize = 2000)] SqlString name14
            , [SqlFacet(MaxSize = -1)] SqlString value14
            , [SqlFacet(MaxSize = 2000)] SqlString name15
            , [SqlFacet(MaxSize = -1)] SqlString value15
            , [SqlFacet(MaxSize = 2000)] SqlString name16
            , [SqlFacet(MaxSize = -1)] SqlString value16
        )
        {
			if (template.IsNull) { throw new ArgumentNullException(nameof(template)); }
            if (name1.IsNull) { throw new ArgumentNullException(nameof(name1)); }
            if (name2.IsNull) { throw new ArgumentNullException(nameof(name2)); }
            if (name3.IsNull) { throw new ArgumentNullException(nameof(name3)); }
            if (name4.IsNull) { throw new ArgumentNullException(nameof(name4)); }
            if (name5.IsNull) { throw new ArgumentNullException(nameof(name5)); }
            if (name6.IsNull) { throw new ArgumentNullException(nameof(name6)); }
            if (name7.IsNull) { throw new ArgumentNullException(nameof(name7)); }
            if (name8.IsNull) { throw new ArgumentNullException(nameof(name8)); }
            if (name9.IsNull) { throw new ArgumentNullException(nameof(name9)); }
            if (name10.IsNull) { throw new ArgumentNullException(nameof(name10)); }
            if (name11.IsNull) { throw new ArgumentNullException(nameof(name11)); }
            if (name12.IsNull) { throw new ArgumentNullException(nameof(name12)); }
            if (name13.IsNull) { throw new ArgumentNullException(nameof(name13)); }
            if (name14.IsNull) { throw new ArgumentNullException(nameof(name14)); }
            if (name15.IsNull) { throw new ArgumentNullException(nameof(name15)); }
            if (name16.IsNull) { throw new ArgumentNullException(nameof(name16)); }

            InitializeNustache();

            var paramDict = new Dictionary<string, string>()
            {
                { name1.ToNullableString(), value1.ToNullableString() },
                { name2.ToNullableString(), value2.ToNullableString() },
                { name3.ToNullableString(), value3.ToNullableString() },
                { name4.ToNullableString(), value4.ToNullableString() },
                { name5.ToNullableString(), value5.ToNullableString() },
                { name6.ToNullableString(), value6.ToNullableString() },
                { name7.ToNullableString(), value7.ToNullableString() },
                { name8.ToNullableString(), value8.ToNullableString() },
                { name9.ToNullableString(), value9.ToNullableString() },
                { name10.ToNullableString(), value10.ToNullableString() },
                { name11.ToNullableString(), value11.ToNullableString() },
                { name12.ToNullableString(), value12.ToNullableString() },
                { name13.ToNullableString(), value13.ToNullableString() },
                { name14.ToNullableString(), value14.ToNullableString() },
                { name15.ToNullableString(), value15.ToNullableString() },
                { name16.ToNullableString(), value16.ToNullableString() }
            };

            return Render.StringToString(template.ToNullableString(), paramDict);
        }

	}
}