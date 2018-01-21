////////////////////////////////////////////////////////////////////////////////////
// Merlin API for Albion Online v1.10.351.108124-prod
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
    /* Internal type: ayy */
    public partial class CastSpellEventHandler
    {
        private static List<MethodInfo> _methodReflectionPool = new List<MethodInfo>();
        private static List<PropertyInfo> _propertyReflectionPool = new List<PropertyInfo>();
        private static List<FieldInfo> _fieldReflectionPool = new List<FieldInfo>();
        
        private ayy _internal;
        
        #region Properties
        
        public ayy CastSpellEventHandler_Internal => _internal;
        
        #endregion
        
        #region Fields
        
        
        #endregion
        
        #region Methods
        
        public bool IsReady(byte A_0) => _internal.f((byte)A_0);
        
        #endregion
        
        #region Constructor
        
        public CastSpellEventHandler(ayy instance)
        {
            _internal = instance;
        }
        
        static CastSpellEventHandler()
        {
            
        }
        
        #endregion
        
        #region Conversion
        
        public static implicit operator ayy(CastSpellEventHandler instance)
        {
            return instance._internal;
        }
        
        public static implicit operator CastSpellEventHandler(ayy instance)
        {
            return new CastSpellEventHandler(instance);
        }
        
        public static implicit operator bool(CastSpellEventHandler instance)
        {
            return instance._internal != null;
        }
        #endregion
    }
}
