////////////////////////////////////////////////////////////////////////////////////
// Merlin API for Albion Online v1.11.362.117521-prod
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
    /* Internal type: ayn */
    public partial class ItemObjectCollection
    {
        private static List<MethodInfo> _methodReflectionPool = new List<MethodInfo>();
        private static List<PropertyInfo> _propertyReflectionPool = new List<PropertyInfo>();
        private static List<FieldInfo> _fieldReflectionPool = new List<FieldInfo>();
        
        private ayn _internal;
        
        #region Properties
        
        public ayn ItemObjectCollection_Internal => _internal;
        
        #endregion
        
        #region Fields
        
        
        #endregion
        
        #region Methods
        
        
        #endregion
        
        #region Constructor
        
        public ItemObjectCollection(ayn instance)
        {
            _internal = instance;
        }
        
        static ItemObjectCollection()
        {
            
        }
        
        #endregion
        
        #region Conversion
        
        public static implicit operator ayn(ItemObjectCollection instance)
        {
            return instance._internal;
        }
        
        public static implicit operator ItemObjectCollection(ayn instance)
        {
            return new ItemObjectCollection(instance);
        }
        
        public static implicit operator bool(ItemObjectCollection instance)
        {
            return instance._internal != null;
        }
        #endregion
    }
}
