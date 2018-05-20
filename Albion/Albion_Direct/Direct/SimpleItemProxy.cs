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
    /* Internal type: aya */
    public partial class SimpleItemProxy : ItemProxy
    {
        private static List<MethodInfo> _methodReflectionPool = new List<MethodInfo>();
        private static List<PropertyInfo> _propertyReflectionPool = new List<PropertyInfo>();
        private static List<FieldInfo> _fieldReflectionPool = new List<FieldInfo>();
        
        private aya _internal;
        
        #region Properties
        
        public aya SimpleItemProxy_Internal => _internal;
        
        #endregion
        
        #region Fields
        
        
        #endregion
        
        #region Methods
        
        
        #endregion
        
        #region Constructor
        
        public SimpleItemProxy(aya instance) : base(instance)
        {
            _internal = instance;
        }
        
        static SimpleItemProxy()
        {
            
        }
        
        #endregion
        
        #region Conversion
        
        public static implicit operator aya(SimpleItemProxy instance)
        {
            return instance._internal;
        }
        
        public static implicit operator SimpleItemProxy(aya instance)
        {
            return new SimpleItemProxy(instance);
        }
        
        public static implicit operator bool(SimpleItemProxy instance)
        {
            return instance._internal != null;
        }
        #endregion
    }
}
