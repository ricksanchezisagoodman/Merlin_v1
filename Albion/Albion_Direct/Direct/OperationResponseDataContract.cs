////////////////////////////////////////////////////////////////////////////////////
// Merlin API for Albion Online v1.11.362.118917-prod
////////////////////////////////////////////////////////////////////////////////////
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by a tool.
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Linq;

using UnityEngine;

using Albion.Common.Time;

namespace Albion_Direct
{
    /* Internal type: nx */
    public partial class OperationResponseDataContract
    {
        private static List<MethodInfo> _methodReflectionPool = new List<MethodInfo>();
        private static List<PropertyInfo> _propertyReflectionPool = new List<PropertyInfo>();
        private static List<FieldInfo> _fieldReflectionPool = new List<FieldInfo>();
        
        private nx _internal;
        
        #region Properties
        
        public nx OperationResponseDataContract_Internal => _internal;
        
        #endregion
        
        #region Fields
        
        
        #endregion
        
        #region Methods
        
        
        #endregion
        
        #region Constructor
        
        public OperationResponseDataContract(nx instance)
        {
            _internal = instance;
        }
        
        static OperationResponseDataContract()
        {
            
        }
        
        #endregion
        
        #region Conversion
        
        public static implicit operator nx(OperationResponseDataContract instance)
        {
            return instance._internal;
        }
        
        public static implicit operator OperationResponseDataContract(nx instance)
        {
            return new OperationResponseDataContract(instance);
        }
        
        public static implicit operator bool(OperationResponseDataContract instance)
        {
            return instance._internal != null;
        }
        #endregion
    }
}
