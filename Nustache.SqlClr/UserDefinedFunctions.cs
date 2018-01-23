using Microsoft.SqlServer.Server;
using Nustache.Core;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;

namespace Nustache.SqlClr
{
    /// <summary>
    /// This class collects together various SQL User-Defined-functions 
    /// used to execute nustache templates in SQL.
    /// </summary>
    public static partial class UserDefinedFunctions
    {
        private static readonly Holder<bool> _IsInitializedHolder = new Holder<bool>(false);

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
    }
}
