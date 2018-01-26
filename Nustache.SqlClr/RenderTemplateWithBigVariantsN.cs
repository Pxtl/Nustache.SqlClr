 
using Microsoft.SqlServer.Server;
using Nustache.Core;
using PxtlCa.BigVariant.Core;
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
        /// <param name="value1">The value of template data parameter 1.  See PxtlCa.BigVariant documentation for details.</param>
        /// <returns>The rendered template with all parameters replaced.</returns> 
        [SqlFunction(DataAccess = DataAccessKind.None, IsDeterministic = true)]
        [return: SqlFacet(MaxSize = -1, IsNullable = true)]
        public static SqlString  RenderTemplateWithBigVariants1(
            [SqlFacet(MaxSize = -1)] SqlString template
            , [SqlFacet(MaxSize = 2000)] SqlString name1
            , BigVariant value1
        )
        {
			if (template.IsNull) { throw new ArgumentNullException(nameof(template)); }
            if (name1.IsNull) { throw new ArgumentNullException(nameof(name1)); }

            InitializeNustache();

            var paramDict = new Dictionary<string, object>()
            {
                { name1.ToNullableString(), value1.AsTemplateObject() }
            };

            return Render.StringToString(template.ToNullableString(), paramDict);
        }

		/// <summary>
        /// Renders the given Mustache template with the name/value arguments assembled into a parameter data object.
        /// </summary>
        /// <param name="template">A Mustache template.  Length is effectively unbounded. Not null.</param>
        /// <param name="name1">The name of template data parameter 1, max length is 2000 chars.  Not null.</param>
        /// <param name="value1">The value of template data parameter 1.  See PxtlCa.BigVariant documentation for details.</param>
        /// <param name="name2">The name of template data parameter 2, max length is 2000 chars.  Not null.</param>
        /// <param name="value2">The value of template data parameter 2.  See PxtlCa.BigVariant documentation for details.</param>
        /// <returns>The rendered template with all parameters replaced.</returns> 
        [SqlFunction(DataAccess = DataAccessKind.None, IsDeterministic = true)]
        [return: SqlFacet(MaxSize = -1, IsNullable = true)]
        public static SqlString  RenderTemplateWithBigVariants2(
            [SqlFacet(MaxSize = -1)] SqlString template
            , [SqlFacet(MaxSize = 2000)] SqlString name1
            , BigVariant value1
            , [SqlFacet(MaxSize = 2000)] SqlString name2
            , BigVariant value2
        )
        {
			if (template.IsNull) { throw new ArgumentNullException(nameof(template)); }
            if (name1.IsNull) { throw new ArgumentNullException(nameof(name1)); }
            if (name2.IsNull) { throw new ArgumentNullException(nameof(name2)); }

            InitializeNustache();

            var paramDict = new Dictionary<string, object>()
            {
                { name1.ToNullableString(), value1.AsTemplateObject() },
                { name2.ToNullableString(), value2.AsTemplateObject() }
            };

            return Render.StringToString(template.ToNullableString(), paramDict);
        }

		/// <summary>
        /// Renders the given Mustache template with the name/value arguments assembled into a parameter data object.
        /// </summary>
        /// <param name="template">A Mustache template.  Length is effectively unbounded. Not null.</param>
        /// <param name="name1">The name of template data parameter 1, max length is 2000 chars.  Not null.</param>
        /// <param name="value1">The value of template data parameter 1.  See PxtlCa.BigVariant documentation for details.</param>
        /// <param name="name2">The name of template data parameter 2, max length is 2000 chars.  Not null.</param>
        /// <param name="value2">The value of template data parameter 2.  See PxtlCa.BigVariant documentation for details.</param>
        /// <param name="name3">The name of template data parameter 3, max length is 2000 chars.  Not null.</param>
        /// <param name="value3">The value of template data parameter 3.  See PxtlCa.BigVariant documentation for details.</param>
        /// <returns>The rendered template with all parameters replaced.</returns> 
        [SqlFunction(DataAccess = DataAccessKind.None, IsDeterministic = true)]
        [return: SqlFacet(MaxSize = -1, IsNullable = true)]
        public static SqlString  RenderTemplateWithBigVariants3(
            [SqlFacet(MaxSize = -1)] SqlString template
            , [SqlFacet(MaxSize = 2000)] SqlString name1
            , BigVariant value1
            , [SqlFacet(MaxSize = 2000)] SqlString name2
            , BigVariant value2
            , [SqlFacet(MaxSize = 2000)] SqlString name3
            , BigVariant value3
        )
        {
			if (template.IsNull) { throw new ArgumentNullException(nameof(template)); }
            if (name1.IsNull) { throw new ArgumentNullException(nameof(name1)); }
            if (name2.IsNull) { throw new ArgumentNullException(nameof(name2)); }
            if (name3.IsNull) { throw new ArgumentNullException(nameof(name3)); }

            InitializeNustache();

            var paramDict = new Dictionary<string, object>()
            {
                { name1.ToNullableString(), value1.AsTemplateObject() },
                { name2.ToNullableString(), value2.AsTemplateObject() },
                { name3.ToNullableString(), value3.AsTemplateObject() }
            };

            return Render.StringToString(template.ToNullableString(), paramDict);
        }

		/// <summary>
        /// Renders the given Mustache template with the name/value arguments assembled into a parameter data object.
        /// </summary>
        /// <param name="template">A Mustache template.  Length is effectively unbounded. Not null.</param>
        /// <param name="name1">The name of template data parameter 1, max length is 2000 chars.  Not null.</param>
        /// <param name="value1">The value of template data parameter 1.  See PxtlCa.BigVariant documentation for details.</param>
        /// <param name="name2">The name of template data parameter 2, max length is 2000 chars.  Not null.</param>
        /// <param name="value2">The value of template data parameter 2.  See PxtlCa.BigVariant documentation for details.</param>
        /// <param name="name3">The name of template data parameter 3, max length is 2000 chars.  Not null.</param>
        /// <param name="value3">The value of template data parameter 3.  See PxtlCa.BigVariant documentation for details.</param>
        /// <param name="name4">The name of template data parameter 4, max length is 2000 chars.  Not null.</param>
        /// <param name="value4">The value of template data parameter 4.  See PxtlCa.BigVariant documentation for details.</param>
        /// <returns>The rendered template with all parameters replaced.</returns> 
        [SqlFunction(DataAccess = DataAccessKind.None, IsDeterministic = true)]
        [return: SqlFacet(MaxSize = -1, IsNullable = true)]
        public static SqlString  RenderTemplateWithBigVariants4(
            [SqlFacet(MaxSize = -1)] SqlString template
            , [SqlFacet(MaxSize = 2000)] SqlString name1
            , BigVariant value1
            , [SqlFacet(MaxSize = 2000)] SqlString name2
            , BigVariant value2
            , [SqlFacet(MaxSize = 2000)] SqlString name3
            , BigVariant value3
            , [SqlFacet(MaxSize = 2000)] SqlString name4
            , BigVariant value4
        )
        {
			if (template.IsNull) { throw new ArgumentNullException(nameof(template)); }
            if (name1.IsNull) { throw new ArgumentNullException(nameof(name1)); }
            if (name2.IsNull) { throw new ArgumentNullException(nameof(name2)); }
            if (name3.IsNull) { throw new ArgumentNullException(nameof(name3)); }
            if (name4.IsNull) { throw new ArgumentNullException(nameof(name4)); }

            InitializeNustache();

            var paramDict = new Dictionary<string, object>()
            {
                { name1.ToNullableString(), value1.AsTemplateObject() },
                { name2.ToNullableString(), value2.AsTemplateObject() },
                { name3.ToNullableString(), value3.AsTemplateObject() },
                { name4.ToNullableString(), value4.AsTemplateObject() }
            };

            return Render.StringToString(template.ToNullableString(), paramDict);
        }

		/// <summary>
        /// Renders the given Mustache template with the name/value arguments assembled into a parameter data object.
        /// </summary>
        /// <param name="template">A Mustache template.  Length is effectively unbounded. Not null.</param>
        /// <param name="name1">The name of template data parameter 1, max length is 2000 chars.  Not null.</param>
        /// <param name="value1">The value of template data parameter 1.  See PxtlCa.BigVariant documentation for details.</param>
        /// <param name="name2">The name of template data parameter 2, max length is 2000 chars.  Not null.</param>
        /// <param name="value2">The value of template data parameter 2.  See PxtlCa.BigVariant documentation for details.</param>
        /// <param name="name3">The name of template data parameter 3, max length is 2000 chars.  Not null.</param>
        /// <param name="value3">The value of template data parameter 3.  See PxtlCa.BigVariant documentation for details.</param>
        /// <param name="name4">The name of template data parameter 4, max length is 2000 chars.  Not null.</param>
        /// <param name="value4">The value of template data parameter 4.  See PxtlCa.BigVariant documentation for details.</param>
        /// <param name="name5">The name of template data parameter 5, max length is 2000 chars.  Not null.</param>
        /// <param name="value5">The value of template data parameter 5.  See PxtlCa.BigVariant documentation for details.</param>
        /// <returns>The rendered template with all parameters replaced.</returns> 
        [SqlFunction(DataAccess = DataAccessKind.None, IsDeterministic = true)]
        [return: SqlFacet(MaxSize = -1, IsNullable = true)]
        public static SqlString  RenderTemplateWithBigVariants5(
            [SqlFacet(MaxSize = -1)] SqlString template
            , [SqlFacet(MaxSize = 2000)] SqlString name1
            , BigVariant value1
            , [SqlFacet(MaxSize = 2000)] SqlString name2
            , BigVariant value2
            , [SqlFacet(MaxSize = 2000)] SqlString name3
            , BigVariant value3
            , [SqlFacet(MaxSize = 2000)] SqlString name4
            , BigVariant value4
            , [SqlFacet(MaxSize = 2000)] SqlString name5
            , BigVariant value5
        )
        {
			if (template.IsNull) { throw new ArgumentNullException(nameof(template)); }
            if (name1.IsNull) { throw new ArgumentNullException(nameof(name1)); }
            if (name2.IsNull) { throw new ArgumentNullException(nameof(name2)); }
            if (name3.IsNull) { throw new ArgumentNullException(nameof(name3)); }
            if (name4.IsNull) { throw new ArgumentNullException(nameof(name4)); }
            if (name5.IsNull) { throw new ArgumentNullException(nameof(name5)); }

            InitializeNustache();

            var paramDict = new Dictionary<string, object>()
            {
                { name1.ToNullableString(), value1.AsTemplateObject() },
                { name2.ToNullableString(), value2.AsTemplateObject() },
                { name3.ToNullableString(), value3.AsTemplateObject() },
                { name4.ToNullableString(), value4.AsTemplateObject() },
                { name5.ToNullableString(), value5.AsTemplateObject() }
            };

            return Render.StringToString(template.ToNullableString(), paramDict);
        }

		/// <summary>
        /// Renders the given Mustache template with the name/value arguments assembled into a parameter data object.
        /// </summary>
        /// <param name="template">A Mustache template.  Length is effectively unbounded. Not null.</param>
        /// <param name="name1">The name of template data parameter 1, max length is 2000 chars.  Not null.</param>
        /// <param name="value1">The value of template data parameter 1.  See PxtlCa.BigVariant documentation for details.</param>
        /// <param name="name2">The name of template data parameter 2, max length is 2000 chars.  Not null.</param>
        /// <param name="value2">The value of template data parameter 2.  See PxtlCa.BigVariant documentation for details.</param>
        /// <param name="name3">The name of template data parameter 3, max length is 2000 chars.  Not null.</param>
        /// <param name="value3">The value of template data parameter 3.  See PxtlCa.BigVariant documentation for details.</param>
        /// <param name="name4">The name of template data parameter 4, max length is 2000 chars.  Not null.</param>
        /// <param name="value4">The value of template data parameter 4.  See PxtlCa.BigVariant documentation for details.</param>
        /// <param name="name5">The name of template data parameter 5, max length is 2000 chars.  Not null.</param>
        /// <param name="value5">The value of template data parameter 5.  See PxtlCa.BigVariant documentation for details.</param>
        /// <param name="name6">The name of template data parameter 6, max length is 2000 chars.  Not null.</param>
        /// <param name="value6">The value of template data parameter 6.  See PxtlCa.BigVariant documentation for details.</param>
        /// <returns>The rendered template with all parameters replaced.</returns> 
        [SqlFunction(DataAccess = DataAccessKind.None, IsDeterministic = true)]
        [return: SqlFacet(MaxSize = -1, IsNullable = true)]
        public static SqlString  RenderTemplateWithBigVariants6(
            [SqlFacet(MaxSize = -1)] SqlString template
            , [SqlFacet(MaxSize = 2000)] SqlString name1
            , BigVariant value1
            , [SqlFacet(MaxSize = 2000)] SqlString name2
            , BigVariant value2
            , [SqlFacet(MaxSize = 2000)] SqlString name3
            , BigVariant value3
            , [SqlFacet(MaxSize = 2000)] SqlString name4
            , BigVariant value4
            , [SqlFacet(MaxSize = 2000)] SqlString name5
            , BigVariant value5
            , [SqlFacet(MaxSize = 2000)] SqlString name6
            , BigVariant value6
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

            var paramDict = new Dictionary<string, object>()
            {
                { name1.ToNullableString(), value1.AsTemplateObject() },
                { name2.ToNullableString(), value2.AsTemplateObject() },
                { name3.ToNullableString(), value3.AsTemplateObject() },
                { name4.ToNullableString(), value4.AsTemplateObject() },
                { name5.ToNullableString(), value5.AsTemplateObject() },
                { name6.ToNullableString(), value6.AsTemplateObject() }
            };

            return Render.StringToString(template.ToNullableString(), paramDict);
        }

		/// <summary>
        /// Renders the given Mustache template with the name/value arguments assembled into a parameter data object.
        /// </summary>
        /// <param name="template">A Mustache template.  Length is effectively unbounded. Not null.</param>
        /// <param name="name1">The name of template data parameter 1, max length is 2000 chars.  Not null.</param>
        /// <param name="value1">The value of template data parameter 1.  See PxtlCa.BigVariant documentation for details.</param>
        /// <param name="name2">The name of template data parameter 2, max length is 2000 chars.  Not null.</param>
        /// <param name="value2">The value of template data parameter 2.  See PxtlCa.BigVariant documentation for details.</param>
        /// <param name="name3">The name of template data parameter 3, max length is 2000 chars.  Not null.</param>
        /// <param name="value3">The value of template data parameter 3.  See PxtlCa.BigVariant documentation for details.</param>
        /// <param name="name4">The name of template data parameter 4, max length is 2000 chars.  Not null.</param>
        /// <param name="value4">The value of template data parameter 4.  See PxtlCa.BigVariant documentation for details.</param>
        /// <param name="name5">The name of template data parameter 5, max length is 2000 chars.  Not null.</param>
        /// <param name="value5">The value of template data parameter 5.  See PxtlCa.BigVariant documentation for details.</param>
        /// <param name="name6">The name of template data parameter 6, max length is 2000 chars.  Not null.</param>
        /// <param name="value6">The value of template data parameter 6.  See PxtlCa.BigVariant documentation for details.</param>
        /// <param name="name7">The name of template data parameter 7, max length is 2000 chars.  Not null.</param>
        /// <param name="value7">The value of template data parameter 7.  See PxtlCa.BigVariant documentation for details.</param>
        /// <returns>The rendered template with all parameters replaced.</returns> 
        [SqlFunction(DataAccess = DataAccessKind.None, IsDeterministic = true)]
        [return: SqlFacet(MaxSize = -1, IsNullable = true)]
        public static SqlString  RenderTemplateWithBigVariants7(
            [SqlFacet(MaxSize = -1)] SqlString template
            , [SqlFacet(MaxSize = 2000)] SqlString name1
            , BigVariant value1
            , [SqlFacet(MaxSize = 2000)] SqlString name2
            , BigVariant value2
            , [SqlFacet(MaxSize = 2000)] SqlString name3
            , BigVariant value3
            , [SqlFacet(MaxSize = 2000)] SqlString name4
            , BigVariant value4
            , [SqlFacet(MaxSize = 2000)] SqlString name5
            , BigVariant value5
            , [SqlFacet(MaxSize = 2000)] SqlString name6
            , BigVariant value6
            , [SqlFacet(MaxSize = 2000)] SqlString name7
            , BigVariant value7
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

            var paramDict = new Dictionary<string, object>()
            {
                { name1.ToNullableString(), value1.AsTemplateObject() },
                { name2.ToNullableString(), value2.AsTemplateObject() },
                { name3.ToNullableString(), value3.AsTemplateObject() },
                { name4.ToNullableString(), value4.AsTemplateObject() },
                { name5.ToNullableString(), value5.AsTemplateObject() },
                { name6.ToNullableString(), value6.AsTemplateObject() },
                { name7.ToNullableString(), value7.AsTemplateObject() }
            };

            return Render.StringToString(template.ToNullableString(), paramDict);
        }

		/// <summary>
        /// Renders the given Mustache template with the name/value arguments assembled into a parameter data object.
        /// </summary>
        /// <param name="template">A Mustache template.  Length is effectively unbounded. Not null.</param>
        /// <param name="name1">The name of template data parameter 1, max length is 2000 chars.  Not null.</param>
        /// <param name="value1">The value of template data parameter 1.  See PxtlCa.BigVariant documentation for details.</param>
        /// <param name="name2">The name of template data parameter 2, max length is 2000 chars.  Not null.</param>
        /// <param name="value2">The value of template data parameter 2.  See PxtlCa.BigVariant documentation for details.</param>
        /// <param name="name3">The name of template data parameter 3, max length is 2000 chars.  Not null.</param>
        /// <param name="value3">The value of template data parameter 3.  See PxtlCa.BigVariant documentation for details.</param>
        /// <param name="name4">The name of template data parameter 4, max length is 2000 chars.  Not null.</param>
        /// <param name="value4">The value of template data parameter 4.  See PxtlCa.BigVariant documentation for details.</param>
        /// <param name="name5">The name of template data parameter 5, max length is 2000 chars.  Not null.</param>
        /// <param name="value5">The value of template data parameter 5.  See PxtlCa.BigVariant documentation for details.</param>
        /// <param name="name6">The name of template data parameter 6, max length is 2000 chars.  Not null.</param>
        /// <param name="value6">The value of template data parameter 6.  See PxtlCa.BigVariant documentation for details.</param>
        /// <param name="name7">The name of template data parameter 7, max length is 2000 chars.  Not null.</param>
        /// <param name="value7">The value of template data parameter 7.  See PxtlCa.BigVariant documentation for details.</param>
        /// <param name="name8">The name of template data parameter 8, max length is 2000 chars.  Not null.</param>
        /// <param name="value8">The value of template data parameter 8.  See PxtlCa.BigVariant documentation for details.</param>
        /// <returns>The rendered template with all parameters replaced.</returns> 
        [SqlFunction(DataAccess = DataAccessKind.None, IsDeterministic = true)]
        [return: SqlFacet(MaxSize = -1, IsNullable = true)]
        public static SqlString  RenderTemplateWithBigVariants8(
            [SqlFacet(MaxSize = -1)] SqlString template
            , [SqlFacet(MaxSize = 2000)] SqlString name1
            , BigVariant value1
            , [SqlFacet(MaxSize = 2000)] SqlString name2
            , BigVariant value2
            , [SqlFacet(MaxSize = 2000)] SqlString name3
            , BigVariant value3
            , [SqlFacet(MaxSize = 2000)] SqlString name4
            , BigVariant value4
            , [SqlFacet(MaxSize = 2000)] SqlString name5
            , BigVariant value5
            , [SqlFacet(MaxSize = 2000)] SqlString name6
            , BigVariant value6
            , [SqlFacet(MaxSize = 2000)] SqlString name7
            , BigVariant value7
            , [SqlFacet(MaxSize = 2000)] SqlString name8
            , BigVariant value8
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

            var paramDict = new Dictionary<string, object>()
            {
                { name1.ToNullableString(), value1.AsTemplateObject() },
                { name2.ToNullableString(), value2.AsTemplateObject() },
                { name3.ToNullableString(), value3.AsTemplateObject() },
                { name4.ToNullableString(), value4.AsTemplateObject() },
                { name5.ToNullableString(), value5.AsTemplateObject() },
                { name6.ToNullableString(), value6.AsTemplateObject() },
                { name7.ToNullableString(), value7.AsTemplateObject() },
                { name8.ToNullableString(), value8.AsTemplateObject() }
            };

            return Render.StringToString(template.ToNullableString(), paramDict);
        }

		/// <summary>
        /// Renders the given Mustache template with the name/value arguments assembled into a parameter data object.
        /// </summary>
        /// <param name="template">A Mustache template.  Length is effectively unbounded. Not null.</param>
        /// <param name="name1">The name of template data parameter 1, max length is 2000 chars.  Not null.</param>
        /// <param name="value1">The value of template data parameter 1.  See PxtlCa.BigVariant documentation for details.</param>
        /// <param name="name2">The name of template data parameter 2, max length is 2000 chars.  Not null.</param>
        /// <param name="value2">The value of template data parameter 2.  See PxtlCa.BigVariant documentation for details.</param>
        /// <param name="name3">The name of template data parameter 3, max length is 2000 chars.  Not null.</param>
        /// <param name="value3">The value of template data parameter 3.  See PxtlCa.BigVariant documentation for details.</param>
        /// <param name="name4">The name of template data parameter 4, max length is 2000 chars.  Not null.</param>
        /// <param name="value4">The value of template data parameter 4.  See PxtlCa.BigVariant documentation for details.</param>
        /// <param name="name5">The name of template data parameter 5, max length is 2000 chars.  Not null.</param>
        /// <param name="value5">The value of template data parameter 5.  See PxtlCa.BigVariant documentation for details.</param>
        /// <param name="name6">The name of template data parameter 6, max length is 2000 chars.  Not null.</param>
        /// <param name="value6">The value of template data parameter 6.  See PxtlCa.BigVariant documentation for details.</param>
        /// <param name="name7">The name of template data parameter 7, max length is 2000 chars.  Not null.</param>
        /// <param name="value7">The value of template data parameter 7.  See PxtlCa.BigVariant documentation for details.</param>
        /// <param name="name8">The name of template data parameter 8, max length is 2000 chars.  Not null.</param>
        /// <param name="value8">The value of template data parameter 8.  See PxtlCa.BigVariant documentation for details.</param>
        /// <param name="name9">The name of template data parameter 9, max length is 2000 chars.  Not null.</param>
        /// <param name="value9">The value of template data parameter 9.  See PxtlCa.BigVariant documentation for details.</param>
        /// <returns>The rendered template with all parameters replaced.</returns> 
        [SqlFunction(DataAccess = DataAccessKind.None, IsDeterministic = true)]
        [return: SqlFacet(MaxSize = -1, IsNullable = true)]
        public static SqlString  RenderTemplateWithBigVariants9(
            [SqlFacet(MaxSize = -1)] SqlString template
            , [SqlFacet(MaxSize = 2000)] SqlString name1
            , BigVariant value1
            , [SqlFacet(MaxSize = 2000)] SqlString name2
            , BigVariant value2
            , [SqlFacet(MaxSize = 2000)] SqlString name3
            , BigVariant value3
            , [SqlFacet(MaxSize = 2000)] SqlString name4
            , BigVariant value4
            , [SqlFacet(MaxSize = 2000)] SqlString name5
            , BigVariant value5
            , [SqlFacet(MaxSize = 2000)] SqlString name6
            , BigVariant value6
            , [SqlFacet(MaxSize = 2000)] SqlString name7
            , BigVariant value7
            , [SqlFacet(MaxSize = 2000)] SqlString name8
            , BigVariant value8
            , [SqlFacet(MaxSize = 2000)] SqlString name9
            , BigVariant value9
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

            var paramDict = new Dictionary<string, object>()
            {
                { name1.ToNullableString(), value1.AsTemplateObject() },
                { name2.ToNullableString(), value2.AsTemplateObject() },
                { name3.ToNullableString(), value3.AsTemplateObject() },
                { name4.ToNullableString(), value4.AsTemplateObject() },
                { name5.ToNullableString(), value5.AsTemplateObject() },
                { name6.ToNullableString(), value6.AsTemplateObject() },
                { name7.ToNullableString(), value7.AsTemplateObject() },
                { name8.ToNullableString(), value8.AsTemplateObject() },
                { name9.ToNullableString(), value9.AsTemplateObject() }
            };

            return Render.StringToString(template.ToNullableString(), paramDict);
        }

		/// <summary>
        /// Renders the given Mustache template with the name/value arguments assembled into a parameter data object.
        /// </summary>
        /// <param name="template">A Mustache template.  Length is effectively unbounded. Not null.</param>
        /// <param name="name1">The name of template data parameter 1, max length is 2000 chars.  Not null.</param>
        /// <param name="value1">The value of template data parameter 1.  See PxtlCa.BigVariant documentation for details.</param>
        /// <param name="name2">The name of template data parameter 2, max length is 2000 chars.  Not null.</param>
        /// <param name="value2">The value of template data parameter 2.  See PxtlCa.BigVariant documentation for details.</param>
        /// <param name="name3">The name of template data parameter 3, max length is 2000 chars.  Not null.</param>
        /// <param name="value3">The value of template data parameter 3.  See PxtlCa.BigVariant documentation for details.</param>
        /// <param name="name4">The name of template data parameter 4, max length is 2000 chars.  Not null.</param>
        /// <param name="value4">The value of template data parameter 4.  See PxtlCa.BigVariant documentation for details.</param>
        /// <param name="name5">The name of template data parameter 5, max length is 2000 chars.  Not null.</param>
        /// <param name="value5">The value of template data parameter 5.  See PxtlCa.BigVariant documentation for details.</param>
        /// <param name="name6">The name of template data parameter 6, max length is 2000 chars.  Not null.</param>
        /// <param name="value6">The value of template data parameter 6.  See PxtlCa.BigVariant documentation for details.</param>
        /// <param name="name7">The name of template data parameter 7, max length is 2000 chars.  Not null.</param>
        /// <param name="value7">The value of template data parameter 7.  See PxtlCa.BigVariant documentation for details.</param>
        /// <param name="name8">The name of template data parameter 8, max length is 2000 chars.  Not null.</param>
        /// <param name="value8">The value of template data parameter 8.  See PxtlCa.BigVariant documentation for details.</param>
        /// <param name="name9">The name of template data parameter 9, max length is 2000 chars.  Not null.</param>
        /// <param name="value9">The value of template data parameter 9.  See PxtlCa.BigVariant documentation for details.</param>
        /// <param name="name10">The name of template data parameter 10, max length is 2000 chars.  Not null.</param>
        /// <param name="value10">The value of template data parameter 10.  See PxtlCa.BigVariant documentation for details.</param>
        /// <returns>The rendered template with all parameters replaced.</returns> 
        [SqlFunction(DataAccess = DataAccessKind.None, IsDeterministic = true)]
        [return: SqlFacet(MaxSize = -1, IsNullable = true)]
        public static SqlString  RenderTemplateWithBigVariants10(
            [SqlFacet(MaxSize = -1)] SqlString template
            , [SqlFacet(MaxSize = 2000)] SqlString name1
            , BigVariant value1
            , [SqlFacet(MaxSize = 2000)] SqlString name2
            , BigVariant value2
            , [SqlFacet(MaxSize = 2000)] SqlString name3
            , BigVariant value3
            , [SqlFacet(MaxSize = 2000)] SqlString name4
            , BigVariant value4
            , [SqlFacet(MaxSize = 2000)] SqlString name5
            , BigVariant value5
            , [SqlFacet(MaxSize = 2000)] SqlString name6
            , BigVariant value6
            , [SqlFacet(MaxSize = 2000)] SqlString name7
            , BigVariant value7
            , [SqlFacet(MaxSize = 2000)] SqlString name8
            , BigVariant value8
            , [SqlFacet(MaxSize = 2000)] SqlString name9
            , BigVariant value9
            , [SqlFacet(MaxSize = 2000)] SqlString name10
            , BigVariant value10
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

            var paramDict = new Dictionary<string, object>()
            {
                { name1.ToNullableString(), value1.AsTemplateObject() },
                { name2.ToNullableString(), value2.AsTemplateObject() },
                { name3.ToNullableString(), value3.AsTemplateObject() },
                { name4.ToNullableString(), value4.AsTemplateObject() },
                { name5.ToNullableString(), value5.AsTemplateObject() },
                { name6.ToNullableString(), value6.AsTemplateObject() },
                { name7.ToNullableString(), value7.AsTemplateObject() },
                { name8.ToNullableString(), value8.AsTemplateObject() },
                { name9.ToNullableString(), value9.AsTemplateObject() },
                { name10.ToNullableString(), value10.AsTemplateObject() }
            };

            return Render.StringToString(template.ToNullableString(), paramDict);
        }

		/// <summary>
        /// Renders the given Mustache template with the name/value arguments assembled into a parameter data object.
        /// </summary>
        /// <param name="template">A Mustache template.  Length is effectively unbounded. Not null.</param>
        /// <param name="name1">The name of template data parameter 1, max length is 2000 chars.  Not null.</param>
        /// <param name="value1">The value of template data parameter 1.  See PxtlCa.BigVariant documentation for details.</param>
        /// <param name="name2">The name of template data parameter 2, max length is 2000 chars.  Not null.</param>
        /// <param name="value2">The value of template data parameter 2.  See PxtlCa.BigVariant documentation for details.</param>
        /// <param name="name3">The name of template data parameter 3, max length is 2000 chars.  Not null.</param>
        /// <param name="value3">The value of template data parameter 3.  See PxtlCa.BigVariant documentation for details.</param>
        /// <param name="name4">The name of template data parameter 4, max length is 2000 chars.  Not null.</param>
        /// <param name="value4">The value of template data parameter 4.  See PxtlCa.BigVariant documentation for details.</param>
        /// <param name="name5">The name of template data parameter 5, max length is 2000 chars.  Not null.</param>
        /// <param name="value5">The value of template data parameter 5.  See PxtlCa.BigVariant documentation for details.</param>
        /// <param name="name6">The name of template data parameter 6, max length is 2000 chars.  Not null.</param>
        /// <param name="value6">The value of template data parameter 6.  See PxtlCa.BigVariant documentation for details.</param>
        /// <param name="name7">The name of template data parameter 7, max length is 2000 chars.  Not null.</param>
        /// <param name="value7">The value of template data parameter 7.  See PxtlCa.BigVariant documentation for details.</param>
        /// <param name="name8">The name of template data parameter 8, max length is 2000 chars.  Not null.</param>
        /// <param name="value8">The value of template data parameter 8.  See PxtlCa.BigVariant documentation for details.</param>
        /// <param name="name9">The name of template data parameter 9, max length is 2000 chars.  Not null.</param>
        /// <param name="value9">The value of template data parameter 9.  See PxtlCa.BigVariant documentation for details.</param>
        /// <param name="name10">The name of template data parameter 10, max length is 2000 chars.  Not null.</param>
        /// <param name="value10">The value of template data parameter 10.  See PxtlCa.BigVariant documentation for details.</param>
        /// <param name="name11">The name of template data parameter 11, max length is 2000 chars.  Not null.</param>
        /// <param name="value11">The value of template data parameter 11.  See PxtlCa.BigVariant documentation for details.</param>
        /// <returns>The rendered template with all parameters replaced.</returns> 
        [SqlFunction(DataAccess = DataAccessKind.None, IsDeterministic = true)]
        [return: SqlFacet(MaxSize = -1, IsNullable = true)]
        public static SqlString  RenderTemplateWithBigVariants11(
            [SqlFacet(MaxSize = -1)] SqlString template
            , [SqlFacet(MaxSize = 2000)] SqlString name1
            , BigVariant value1
            , [SqlFacet(MaxSize = 2000)] SqlString name2
            , BigVariant value2
            , [SqlFacet(MaxSize = 2000)] SqlString name3
            , BigVariant value3
            , [SqlFacet(MaxSize = 2000)] SqlString name4
            , BigVariant value4
            , [SqlFacet(MaxSize = 2000)] SqlString name5
            , BigVariant value5
            , [SqlFacet(MaxSize = 2000)] SqlString name6
            , BigVariant value6
            , [SqlFacet(MaxSize = 2000)] SqlString name7
            , BigVariant value7
            , [SqlFacet(MaxSize = 2000)] SqlString name8
            , BigVariant value8
            , [SqlFacet(MaxSize = 2000)] SqlString name9
            , BigVariant value9
            , [SqlFacet(MaxSize = 2000)] SqlString name10
            , BigVariant value10
            , [SqlFacet(MaxSize = 2000)] SqlString name11
            , BigVariant value11
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

            var paramDict = new Dictionary<string, object>()
            {
                { name1.ToNullableString(), value1.AsTemplateObject() },
                { name2.ToNullableString(), value2.AsTemplateObject() },
                { name3.ToNullableString(), value3.AsTemplateObject() },
                { name4.ToNullableString(), value4.AsTemplateObject() },
                { name5.ToNullableString(), value5.AsTemplateObject() },
                { name6.ToNullableString(), value6.AsTemplateObject() },
                { name7.ToNullableString(), value7.AsTemplateObject() },
                { name8.ToNullableString(), value8.AsTemplateObject() },
                { name9.ToNullableString(), value9.AsTemplateObject() },
                { name10.ToNullableString(), value10.AsTemplateObject() },
                { name11.ToNullableString(), value11.AsTemplateObject() }
            };

            return Render.StringToString(template.ToNullableString(), paramDict);
        }

		/// <summary>
        /// Renders the given Mustache template with the name/value arguments assembled into a parameter data object.
        /// </summary>
        /// <param name="template">A Mustache template.  Length is effectively unbounded. Not null.</param>
        /// <param name="name1">The name of template data parameter 1, max length is 2000 chars.  Not null.</param>
        /// <param name="value1">The value of template data parameter 1.  See PxtlCa.BigVariant documentation for details.</param>
        /// <param name="name2">The name of template data parameter 2, max length is 2000 chars.  Not null.</param>
        /// <param name="value2">The value of template data parameter 2.  See PxtlCa.BigVariant documentation for details.</param>
        /// <param name="name3">The name of template data parameter 3, max length is 2000 chars.  Not null.</param>
        /// <param name="value3">The value of template data parameter 3.  See PxtlCa.BigVariant documentation for details.</param>
        /// <param name="name4">The name of template data parameter 4, max length is 2000 chars.  Not null.</param>
        /// <param name="value4">The value of template data parameter 4.  See PxtlCa.BigVariant documentation for details.</param>
        /// <param name="name5">The name of template data parameter 5, max length is 2000 chars.  Not null.</param>
        /// <param name="value5">The value of template data parameter 5.  See PxtlCa.BigVariant documentation for details.</param>
        /// <param name="name6">The name of template data parameter 6, max length is 2000 chars.  Not null.</param>
        /// <param name="value6">The value of template data parameter 6.  See PxtlCa.BigVariant documentation for details.</param>
        /// <param name="name7">The name of template data parameter 7, max length is 2000 chars.  Not null.</param>
        /// <param name="value7">The value of template data parameter 7.  See PxtlCa.BigVariant documentation for details.</param>
        /// <param name="name8">The name of template data parameter 8, max length is 2000 chars.  Not null.</param>
        /// <param name="value8">The value of template data parameter 8.  See PxtlCa.BigVariant documentation for details.</param>
        /// <param name="name9">The name of template data parameter 9, max length is 2000 chars.  Not null.</param>
        /// <param name="value9">The value of template data parameter 9.  See PxtlCa.BigVariant documentation for details.</param>
        /// <param name="name10">The name of template data parameter 10, max length is 2000 chars.  Not null.</param>
        /// <param name="value10">The value of template data parameter 10.  See PxtlCa.BigVariant documentation for details.</param>
        /// <param name="name11">The name of template data parameter 11, max length is 2000 chars.  Not null.</param>
        /// <param name="value11">The value of template data parameter 11.  See PxtlCa.BigVariant documentation for details.</param>
        /// <param name="name12">The name of template data parameter 12, max length is 2000 chars.  Not null.</param>
        /// <param name="value12">The value of template data parameter 12.  See PxtlCa.BigVariant documentation for details.</param>
        /// <returns>The rendered template with all parameters replaced.</returns> 
        [SqlFunction(DataAccess = DataAccessKind.None, IsDeterministic = true)]
        [return: SqlFacet(MaxSize = -1, IsNullable = true)]
        public static SqlString  RenderTemplateWithBigVariants12(
            [SqlFacet(MaxSize = -1)] SqlString template
            , [SqlFacet(MaxSize = 2000)] SqlString name1
            , BigVariant value1
            , [SqlFacet(MaxSize = 2000)] SqlString name2
            , BigVariant value2
            , [SqlFacet(MaxSize = 2000)] SqlString name3
            , BigVariant value3
            , [SqlFacet(MaxSize = 2000)] SqlString name4
            , BigVariant value4
            , [SqlFacet(MaxSize = 2000)] SqlString name5
            , BigVariant value5
            , [SqlFacet(MaxSize = 2000)] SqlString name6
            , BigVariant value6
            , [SqlFacet(MaxSize = 2000)] SqlString name7
            , BigVariant value7
            , [SqlFacet(MaxSize = 2000)] SqlString name8
            , BigVariant value8
            , [SqlFacet(MaxSize = 2000)] SqlString name9
            , BigVariant value9
            , [SqlFacet(MaxSize = 2000)] SqlString name10
            , BigVariant value10
            , [SqlFacet(MaxSize = 2000)] SqlString name11
            , BigVariant value11
            , [SqlFacet(MaxSize = 2000)] SqlString name12
            , BigVariant value12
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

            var paramDict = new Dictionary<string, object>()
            {
                { name1.ToNullableString(), value1.AsTemplateObject() },
                { name2.ToNullableString(), value2.AsTemplateObject() },
                { name3.ToNullableString(), value3.AsTemplateObject() },
                { name4.ToNullableString(), value4.AsTemplateObject() },
                { name5.ToNullableString(), value5.AsTemplateObject() },
                { name6.ToNullableString(), value6.AsTemplateObject() },
                { name7.ToNullableString(), value7.AsTemplateObject() },
                { name8.ToNullableString(), value8.AsTemplateObject() },
                { name9.ToNullableString(), value9.AsTemplateObject() },
                { name10.ToNullableString(), value10.AsTemplateObject() },
                { name11.ToNullableString(), value11.AsTemplateObject() },
                { name12.ToNullableString(), value12.AsTemplateObject() }
            };

            return Render.StringToString(template.ToNullableString(), paramDict);
        }

		/// <summary>
        /// Renders the given Mustache template with the name/value arguments assembled into a parameter data object.
        /// </summary>
        /// <param name="template">A Mustache template.  Length is effectively unbounded. Not null.</param>
        /// <param name="name1">The name of template data parameter 1, max length is 2000 chars.  Not null.</param>
        /// <param name="value1">The value of template data parameter 1.  See PxtlCa.BigVariant documentation for details.</param>
        /// <param name="name2">The name of template data parameter 2, max length is 2000 chars.  Not null.</param>
        /// <param name="value2">The value of template data parameter 2.  See PxtlCa.BigVariant documentation for details.</param>
        /// <param name="name3">The name of template data parameter 3, max length is 2000 chars.  Not null.</param>
        /// <param name="value3">The value of template data parameter 3.  See PxtlCa.BigVariant documentation for details.</param>
        /// <param name="name4">The name of template data parameter 4, max length is 2000 chars.  Not null.</param>
        /// <param name="value4">The value of template data parameter 4.  See PxtlCa.BigVariant documentation for details.</param>
        /// <param name="name5">The name of template data parameter 5, max length is 2000 chars.  Not null.</param>
        /// <param name="value5">The value of template data parameter 5.  See PxtlCa.BigVariant documentation for details.</param>
        /// <param name="name6">The name of template data parameter 6, max length is 2000 chars.  Not null.</param>
        /// <param name="value6">The value of template data parameter 6.  See PxtlCa.BigVariant documentation for details.</param>
        /// <param name="name7">The name of template data parameter 7, max length is 2000 chars.  Not null.</param>
        /// <param name="value7">The value of template data parameter 7.  See PxtlCa.BigVariant documentation for details.</param>
        /// <param name="name8">The name of template data parameter 8, max length is 2000 chars.  Not null.</param>
        /// <param name="value8">The value of template data parameter 8.  See PxtlCa.BigVariant documentation for details.</param>
        /// <param name="name9">The name of template data parameter 9, max length is 2000 chars.  Not null.</param>
        /// <param name="value9">The value of template data parameter 9.  See PxtlCa.BigVariant documentation for details.</param>
        /// <param name="name10">The name of template data parameter 10, max length is 2000 chars.  Not null.</param>
        /// <param name="value10">The value of template data parameter 10.  See PxtlCa.BigVariant documentation for details.</param>
        /// <param name="name11">The name of template data parameter 11, max length is 2000 chars.  Not null.</param>
        /// <param name="value11">The value of template data parameter 11.  See PxtlCa.BigVariant documentation for details.</param>
        /// <param name="name12">The name of template data parameter 12, max length is 2000 chars.  Not null.</param>
        /// <param name="value12">The value of template data parameter 12.  See PxtlCa.BigVariant documentation for details.</param>
        /// <param name="name13">The name of template data parameter 13, max length is 2000 chars.  Not null.</param>
        /// <param name="value13">The value of template data parameter 13.  See PxtlCa.BigVariant documentation for details.</param>
        /// <returns>The rendered template with all parameters replaced.</returns> 
        [SqlFunction(DataAccess = DataAccessKind.None, IsDeterministic = true)]
        [return: SqlFacet(MaxSize = -1, IsNullable = true)]
        public static SqlString  RenderTemplateWithBigVariants13(
            [SqlFacet(MaxSize = -1)] SqlString template
            , [SqlFacet(MaxSize = 2000)] SqlString name1
            , BigVariant value1
            , [SqlFacet(MaxSize = 2000)] SqlString name2
            , BigVariant value2
            , [SqlFacet(MaxSize = 2000)] SqlString name3
            , BigVariant value3
            , [SqlFacet(MaxSize = 2000)] SqlString name4
            , BigVariant value4
            , [SqlFacet(MaxSize = 2000)] SqlString name5
            , BigVariant value5
            , [SqlFacet(MaxSize = 2000)] SqlString name6
            , BigVariant value6
            , [SqlFacet(MaxSize = 2000)] SqlString name7
            , BigVariant value7
            , [SqlFacet(MaxSize = 2000)] SqlString name8
            , BigVariant value8
            , [SqlFacet(MaxSize = 2000)] SqlString name9
            , BigVariant value9
            , [SqlFacet(MaxSize = 2000)] SqlString name10
            , BigVariant value10
            , [SqlFacet(MaxSize = 2000)] SqlString name11
            , BigVariant value11
            , [SqlFacet(MaxSize = 2000)] SqlString name12
            , BigVariant value12
            , [SqlFacet(MaxSize = 2000)] SqlString name13
            , BigVariant value13
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

            var paramDict = new Dictionary<string, object>()
            {
                { name1.ToNullableString(), value1.AsTemplateObject() },
                { name2.ToNullableString(), value2.AsTemplateObject() },
                { name3.ToNullableString(), value3.AsTemplateObject() },
                { name4.ToNullableString(), value4.AsTemplateObject() },
                { name5.ToNullableString(), value5.AsTemplateObject() },
                { name6.ToNullableString(), value6.AsTemplateObject() },
                { name7.ToNullableString(), value7.AsTemplateObject() },
                { name8.ToNullableString(), value8.AsTemplateObject() },
                { name9.ToNullableString(), value9.AsTemplateObject() },
                { name10.ToNullableString(), value10.AsTemplateObject() },
                { name11.ToNullableString(), value11.AsTemplateObject() },
                { name12.ToNullableString(), value12.AsTemplateObject() },
                { name13.ToNullableString(), value13.AsTemplateObject() }
            };

            return Render.StringToString(template.ToNullableString(), paramDict);
        }

		/// <summary>
        /// Renders the given Mustache template with the name/value arguments assembled into a parameter data object.
        /// </summary>
        /// <param name="template">A Mustache template.  Length is effectively unbounded. Not null.</param>
        /// <param name="name1">The name of template data parameter 1, max length is 2000 chars.  Not null.</param>
        /// <param name="value1">The value of template data parameter 1.  See PxtlCa.BigVariant documentation for details.</param>
        /// <param name="name2">The name of template data parameter 2, max length is 2000 chars.  Not null.</param>
        /// <param name="value2">The value of template data parameter 2.  See PxtlCa.BigVariant documentation for details.</param>
        /// <param name="name3">The name of template data parameter 3, max length is 2000 chars.  Not null.</param>
        /// <param name="value3">The value of template data parameter 3.  See PxtlCa.BigVariant documentation for details.</param>
        /// <param name="name4">The name of template data parameter 4, max length is 2000 chars.  Not null.</param>
        /// <param name="value4">The value of template data parameter 4.  See PxtlCa.BigVariant documentation for details.</param>
        /// <param name="name5">The name of template data parameter 5, max length is 2000 chars.  Not null.</param>
        /// <param name="value5">The value of template data parameter 5.  See PxtlCa.BigVariant documentation for details.</param>
        /// <param name="name6">The name of template data parameter 6, max length is 2000 chars.  Not null.</param>
        /// <param name="value6">The value of template data parameter 6.  See PxtlCa.BigVariant documentation for details.</param>
        /// <param name="name7">The name of template data parameter 7, max length is 2000 chars.  Not null.</param>
        /// <param name="value7">The value of template data parameter 7.  See PxtlCa.BigVariant documentation for details.</param>
        /// <param name="name8">The name of template data parameter 8, max length is 2000 chars.  Not null.</param>
        /// <param name="value8">The value of template data parameter 8.  See PxtlCa.BigVariant documentation for details.</param>
        /// <param name="name9">The name of template data parameter 9, max length is 2000 chars.  Not null.</param>
        /// <param name="value9">The value of template data parameter 9.  See PxtlCa.BigVariant documentation for details.</param>
        /// <param name="name10">The name of template data parameter 10, max length is 2000 chars.  Not null.</param>
        /// <param name="value10">The value of template data parameter 10.  See PxtlCa.BigVariant documentation for details.</param>
        /// <param name="name11">The name of template data parameter 11, max length is 2000 chars.  Not null.</param>
        /// <param name="value11">The value of template data parameter 11.  See PxtlCa.BigVariant documentation for details.</param>
        /// <param name="name12">The name of template data parameter 12, max length is 2000 chars.  Not null.</param>
        /// <param name="value12">The value of template data parameter 12.  See PxtlCa.BigVariant documentation for details.</param>
        /// <param name="name13">The name of template data parameter 13, max length is 2000 chars.  Not null.</param>
        /// <param name="value13">The value of template data parameter 13.  See PxtlCa.BigVariant documentation for details.</param>
        /// <param name="name14">The name of template data parameter 14, max length is 2000 chars.  Not null.</param>
        /// <param name="value14">The value of template data parameter 14.  See PxtlCa.BigVariant documentation for details.</param>
        /// <returns>The rendered template with all parameters replaced.</returns> 
        [SqlFunction(DataAccess = DataAccessKind.None, IsDeterministic = true)]
        [return: SqlFacet(MaxSize = -1, IsNullable = true)]
        public static SqlString  RenderTemplateWithBigVariants14(
            [SqlFacet(MaxSize = -1)] SqlString template
            , [SqlFacet(MaxSize = 2000)] SqlString name1
            , BigVariant value1
            , [SqlFacet(MaxSize = 2000)] SqlString name2
            , BigVariant value2
            , [SqlFacet(MaxSize = 2000)] SqlString name3
            , BigVariant value3
            , [SqlFacet(MaxSize = 2000)] SqlString name4
            , BigVariant value4
            , [SqlFacet(MaxSize = 2000)] SqlString name5
            , BigVariant value5
            , [SqlFacet(MaxSize = 2000)] SqlString name6
            , BigVariant value6
            , [SqlFacet(MaxSize = 2000)] SqlString name7
            , BigVariant value7
            , [SqlFacet(MaxSize = 2000)] SqlString name8
            , BigVariant value8
            , [SqlFacet(MaxSize = 2000)] SqlString name9
            , BigVariant value9
            , [SqlFacet(MaxSize = 2000)] SqlString name10
            , BigVariant value10
            , [SqlFacet(MaxSize = 2000)] SqlString name11
            , BigVariant value11
            , [SqlFacet(MaxSize = 2000)] SqlString name12
            , BigVariant value12
            , [SqlFacet(MaxSize = 2000)] SqlString name13
            , BigVariant value13
            , [SqlFacet(MaxSize = 2000)] SqlString name14
            , BigVariant value14
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

            var paramDict = new Dictionary<string, object>()
            {
                { name1.ToNullableString(), value1.AsTemplateObject() },
                { name2.ToNullableString(), value2.AsTemplateObject() },
                { name3.ToNullableString(), value3.AsTemplateObject() },
                { name4.ToNullableString(), value4.AsTemplateObject() },
                { name5.ToNullableString(), value5.AsTemplateObject() },
                { name6.ToNullableString(), value6.AsTemplateObject() },
                { name7.ToNullableString(), value7.AsTemplateObject() },
                { name8.ToNullableString(), value8.AsTemplateObject() },
                { name9.ToNullableString(), value9.AsTemplateObject() },
                { name10.ToNullableString(), value10.AsTemplateObject() },
                { name11.ToNullableString(), value11.AsTemplateObject() },
                { name12.ToNullableString(), value12.AsTemplateObject() },
                { name13.ToNullableString(), value13.AsTemplateObject() },
                { name14.ToNullableString(), value14.AsTemplateObject() }
            };

            return Render.StringToString(template.ToNullableString(), paramDict);
        }

		/// <summary>
        /// Renders the given Mustache template with the name/value arguments assembled into a parameter data object.
        /// </summary>
        /// <param name="template">A Mustache template.  Length is effectively unbounded. Not null.</param>
        /// <param name="name1">The name of template data parameter 1, max length is 2000 chars.  Not null.</param>
        /// <param name="value1">The value of template data parameter 1.  See PxtlCa.BigVariant documentation for details.</param>
        /// <param name="name2">The name of template data parameter 2, max length is 2000 chars.  Not null.</param>
        /// <param name="value2">The value of template data parameter 2.  See PxtlCa.BigVariant documentation for details.</param>
        /// <param name="name3">The name of template data parameter 3, max length is 2000 chars.  Not null.</param>
        /// <param name="value3">The value of template data parameter 3.  See PxtlCa.BigVariant documentation for details.</param>
        /// <param name="name4">The name of template data parameter 4, max length is 2000 chars.  Not null.</param>
        /// <param name="value4">The value of template data parameter 4.  See PxtlCa.BigVariant documentation for details.</param>
        /// <param name="name5">The name of template data parameter 5, max length is 2000 chars.  Not null.</param>
        /// <param name="value5">The value of template data parameter 5.  See PxtlCa.BigVariant documentation for details.</param>
        /// <param name="name6">The name of template data parameter 6, max length is 2000 chars.  Not null.</param>
        /// <param name="value6">The value of template data parameter 6.  See PxtlCa.BigVariant documentation for details.</param>
        /// <param name="name7">The name of template data parameter 7, max length is 2000 chars.  Not null.</param>
        /// <param name="value7">The value of template data parameter 7.  See PxtlCa.BigVariant documentation for details.</param>
        /// <param name="name8">The name of template data parameter 8, max length is 2000 chars.  Not null.</param>
        /// <param name="value8">The value of template data parameter 8.  See PxtlCa.BigVariant documentation for details.</param>
        /// <param name="name9">The name of template data parameter 9, max length is 2000 chars.  Not null.</param>
        /// <param name="value9">The value of template data parameter 9.  See PxtlCa.BigVariant documentation for details.</param>
        /// <param name="name10">The name of template data parameter 10, max length is 2000 chars.  Not null.</param>
        /// <param name="value10">The value of template data parameter 10.  See PxtlCa.BigVariant documentation for details.</param>
        /// <param name="name11">The name of template data parameter 11, max length is 2000 chars.  Not null.</param>
        /// <param name="value11">The value of template data parameter 11.  See PxtlCa.BigVariant documentation for details.</param>
        /// <param name="name12">The name of template data parameter 12, max length is 2000 chars.  Not null.</param>
        /// <param name="value12">The value of template data parameter 12.  See PxtlCa.BigVariant documentation for details.</param>
        /// <param name="name13">The name of template data parameter 13, max length is 2000 chars.  Not null.</param>
        /// <param name="value13">The value of template data parameter 13.  See PxtlCa.BigVariant documentation for details.</param>
        /// <param name="name14">The name of template data parameter 14, max length is 2000 chars.  Not null.</param>
        /// <param name="value14">The value of template data parameter 14.  See PxtlCa.BigVariant documentation for details.</param>
        /// <param name="name15">The name of template data parameter 15, max length is 2000 chars.  Not null.</param>
        /// <param name="value15">The value of template data parameter 15.  See PxtlCa.BigVariant documentation for details.</param>
        /// <returns>The rendered template with all parameters replaced.</returns> 
        [SqlFunction(DataAccess = DataAccessKind.None, IsDeterministic = true)]
        [return: SqlFacet(MaxSize = -1, IsNullable = true)]
        public static SqlString  RenderTemplateWithBigVariants15(
            [SqlFacet(MaxSize = -1)] SqlString template
            , [SqlFacet(MaxSize = 2000)] SqlString name1
            , BigVariant value1
            , [SqlFacet(MaxSize = 2000)] SqlString name2
            , BigVariant value2
            , [SqlFacet(MaxSize = 2000)] SqlString name3
            , BigVariant value3
            , [SqlFacet(MaxSize = 2000)] SqlString name4
            , BigVariant value4
            , [SqlFacet(MaxSize = 2000)] SqlString name5
            , BigVariant value5
            , [SqlFacet(MaxSize = 2000)] SqlString name6
            , BigVariant value6
            , [SqlFacet(MaxSize = 2000)] SqlString name7
            , BigVariant value7
            , [SqlFacet(MaxSize = 2000)] SqlString name8
            , BigVariant value8
            , [SqlFacet(MaxSize = 2000)] SqlString name9
            , BigVariant value9
            , [SqlFacet(MaxSize = 2000)] SqlString name10
            , BigVariant value10
            , [SqlFacet(MaxSize = 2000)] SqlString name11
            , BigVariant value11
            , [SqlFacet(MaxSize = 2000)] SqlString name12
            , BigVariant value12
            , [SqlFacet(MaxSize = 2000)] SqlString name13
            , BigVariant value13
            , [SqlFacet(MaxSize = 2000)] SqlString name14
            , BigVariant value14
            , [SqlFacet(MaxSize = 2000)] SqlString name15
            , BigVariant value15
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

            var paramDict = new Dictionary<string, object>()
            {
                { name1.ToNullableString(), value1.AsTemplateObject() },
                { name2.ToNullableString(), value2.AsTemplateObject() },
                { name3.ToNullableString(), value3.AsTemplateObject() },
                { name4.ToNullableString(), value4.AsTemplateObject() },
                { name5.ToNullableString(), value5.AsTemplateObject() },
                { name6.ToNullableString(), value6.AsTemplateObject() },
                { name7.ToNullableString(), value7.AsTemplateObject() },
                { name8.ToNullableString(), value8.AsTemplateObject() },
                { name9.ToNullableString(), value9.AsTemplateObject() },
                { name10.ToNullableString(), value10.AsTemplateObject() },
                { name11.ToNullableString(), value11.AsTemplateObject() },
                { name12.ToNullableString(), value12.AsTemplateObject() },
                { name13.ToNullableString(), value13.AsTemplateObject() },
                { name14.ToNullableString(), value14.AsTemplateObject() },
                { name15.ToNullableString(), value15.AsTemplateObject() }
            };

            return Render.StringToString(template.ToNullableString(), paramDict);
        }

		/// <summary>
        /// Renders the given Mustache template with the name/value arguments assembled into a parameter data object.
        /// </summary>
        /// <param name="template">A Mustache template.  Length is effectively unbounded. Not null.</param>
        /// <param name="name1">The name of template data parameter 1, max length is 2000 chars.  Not null.</param>
        /// <param name="value1">The value of template data parameter 1.  See PxtlCa.BigVariant documentation for details.</param>
        /// <param name="name2">The name of template data parameter 2, max length is 2000 chars.  Not null.</param>
        /// <param name="value2">The value of template data parameter 2.  See PxtlCa.BigVariant documentation for details.</param>
        /// <param name="name3">The name of template data parameter 3, max length is 2000 chars.  Not null.</param>
        /// <param name="value3">The value of template data parameter 3.  See PxtlCa.BigVariant documentation for details.</param>
        /// <param name="name4">The name of template data parameter 4, max length is 2000 chars.  Not null.</param>
        /// <param name="value4">The value of template data parameter 4.  See PxtlCa.BigVariant documentation for details.</param>
        /// <param name="name5">The name of template data parameter 5, max length is 2000 chars.  Not null.</param>
        /// <param name="value5">The value of template data parameter 5.  See PxtlCa.BigVariant documentation for details.</param>
        /// <param name="name6">The name of template data parameter 6, max length is 2000 chars.  Not null.</param>
        /// <param name="value6">The value of template data parameter 6.  See PxtlCa.BigVariant documentation for details.</param>
        /// <param name="name7">The name of template data parameter 7, max length is 2000 chars.  Not null.</param>
        /// <param name="value7">The value of template data parameter 7.  See PxtlCa.BigVariant documentation for details.</param>
        /// <param name="name8">The name of template data parameter 8, max length is 2000 chars.  Not null.</param>
        /// <param name="value8">The value of template data parameter 8.  See PxtlCa.BigVariant documentation for details.</param>
        /// <param name="name9">The name of template data parameter 9, max length is 2000 chars.  Not null.</param>
        /// <param name="value9">The value of template data parameter 9.  See PxtlCa.BigVariant documentation for details.</param>
        /// <param name="name10">The name of template data parameter 10, max length is 2000 chars.  Not null.</param>
        /// <param name="value10">The value of template data parameter 10.  See PxtlCa.BigVariant documentation for details.</param>
        /// <param name="name11">The name of template data parameter 11, max length is 2000 chars.  Not null.</param>
        /// <param name="value11">The value of template data parameter 11.  See PxtlCa.BigVariant documentation for details.</param>
        /// <param name="name12">The name of template data parameter 12, max length is 2000 chars.  Not null.</param>
        /// <param name="value12">The value of template data parameter 12.  See PxtlCa.BigVariant documentation for details.</param>
        /// <param name="name13">The name of template data parameter 13, max length is 2000 chars.  Not null.</param>
        /// <param name="value13">The value of template data parameter 13.  See PxtlCa.BigVariant documentation for details.</param>
        /// <param name="name14">The name of template data parameter 14, max length is 2000 chars.  Not null.</param>
        /// <param name="value14">The value of template data parameter 14.  See PxtlCa.BigVariant documentation for details.</param>
        /// <param name="name15">The name of template data parameter 15, max length is 2000 chars.  Not null.</param>
        /// <param name="value15">The value of template data parameter 15.  See PxtlCa.BigVariant documentation for details.</param>
        /// <param name="name16">The name of template data parameter 16, max length is 2000 chars.  Not null.</param>
        /// <param name="value16">The value of template data parameter 16.  See PxtlCa.BigVariant documentation for details.</param>
        /// <returns>The rendered template with all parameters replaced.</returns> 
        [SqlFunction(DataAccess = DataAccessKind.None, IsDeterministic = true)]
        [return: SqlFacet(MaxSize = -1, IsNullable = true)]
        public static SqlString  RenderTemplateWithBigVariants16(
            [SqlFacet(MaxSize = -1)] SqlString template
            , [SqlFacet(MaxSize = 2000)] SqlString name1
            , BigVariant value1
            , [SqlFacet(MaxSize = 2000)] SqlString name2
            , BigVariant value2
            , [SqlFacet(MaxSize = 2000)] SqlString name3
            , BigVariant value3
            , [SqlFacet(MaxSize = 2000)] SqlString name4
            , BigVariant value4
            , [SqlFacet(MaxSize = 2000)] SqlString name5
            , BigVariant value5
            , [SqlFacet(MaxSize = 2000)] SqlString name6
            , BigVariant value6
            , [SqlFacet(MaxSize = 2000)] SqlString name7
            , BigVariant value7
            , [SqlFacet(MaxSize = 2000)] SqlString name8
            , BigVariant value8
            , [SqlFacet(MaxSize = 2000)] SqlString name9
            , BigVariant value9
            , [SqlFacet(MaxSize = 2000)] SqlString name10
            , BigVariant value10
            , [SqlFacet(MaxSize = 2000)] SqlString name11
            , BigVariant value11
            , [SqlFacet(MaxSize = 2000)] SqlString name12
            , BigVariant value12
            , [SqlFacet(MaxSize = 2000)] SqlString name13
            , BigVariant value13
            , [SqlFacet(MaxSize = 2000)] SqlString name14
            , BigVariant value14
            , [SqlFacet(MaxSize = 2000)] SqlString name15
            , BigVariant value15
            , [SqlFacet(MaxSize = 2000)] SqlString name16
            , BigVariant value16
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

            var paramDict = new Dictionary<string, object>()
            {
                { name1.ToNullableString(), value1.AsTemplateObject() },
                { name2.ToNullableString(), value2.AsTemplateObject() },
                { name3.ToNullableString(), value3.AsTemplateObject() },
                { name4.ToNullableString(), value4.AsTemplateObject() },
                { name5.ToNullableString(), value5.AsTemplateObject() },
                { name6.ToNullableString(), value6.AsTemplateObject() },
                { name7.ToNullableString(), value7.AsTemplateObject() },
                { name8.ToNullableString(), value8.AsTemplateObject() },
                { name9.ToNullableString(), value9.AsTemplateObject() },
                { name10.ToNullableString(), value10.AsTemplateObject() },
                { name11.ToNullableString(), value11.AsTemplateObject() },
                { name12.ToNullableString(), value12.AsTemplateObject() },
                { name13.ToNullableString(), value13.AsTemplateObject() },
                { name14.ToNullableString(), value14.AsTemplateObject() },
                { name15.ToNullableString(), value15.AsTemplateObject() },
                { name16.ToNullableString(), value16.AsTemplateObject() }
            };

            return Render.StringToString(template.ToNullableString(), paramDict);
        }

	}
}