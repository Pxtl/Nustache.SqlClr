using Microsoft.SqlServer.Server;
using Nustache.Core;
using PxtlCa.BigVariant.Core;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Xml;

namespace Nustache.SqlClr
{
    /// <summary>
    /// This class collects together various SQL User-Defined-functions 
    /// used to execute nustache templates in SQL.
    /// </summary>
    public static partial class UserDefinedFunctions
    {
        /// <summary>
        /// Hack workaround for the fact that SQLCLR does not allow usage of statics, but doesn't check for members of statics.
        /// Is True if the Nustache system has already been initialized.
        /// </summary>
        private static readonly Holder<bool> _IsInitializedHolder = new Holder<bool>(false);

        /// <summary>
        /// Initialized the Nustache library, removing components that are incompatible with the SQLCLR environment.
        /// </summary>
        private static void InitializeNustache()
        {
            if(!_IsInitializedHolder.Value)
            {
                //clear out all factories that will not work in a restricted context
                var filteredFactories = ValueGetterFactories.Factories
                    .ToList() //can't use threading constructs so reduce threading risk by copying here.
                    .Where(fac 
                        => fac.GetType().Name != "PropertyDescriptorValueGetterFactory" //TODO: switch this away from using strings
                        && fac.GetType().Name != "MethodInfoValueGatterFactory"
                        && fac.GetType().Name != "PropertyInfoValueGetterFactory"
                        && fac.GetType().Name != "FieldInfoValueGetterFactory"
                    ).ToList();

                ValueGetterFactories.Factories.Clear(); //TODO: switch this to atomic replace.
                foreach(var fac in filteredFactories)
                {
                    ValueGetterFactories.Factories.Add(fac);
                }
                _IsInitializedHolder.Value = true;
            }
        }

        public static string ToNullableString(this SqlString sqlString)
        {
            return sqlString.IsNull ? null : sqlString.Value;
        }

        public static object AsTemplateObject(this BigVariant bigVariant)
        {
            if (bigVariant.IsNull)
            {
                return null;
            }

            if(bigVariant.Type == "SqlXml")
            {
                XmlDocument doc = new XmlDocument();
                doc.LoadXml(bigVariant.AsXml.Value);
                return doc.DocumentElement;
            }
            else
            {
                return bigVariant.AsClrObject;
            }
        }
    }
}
