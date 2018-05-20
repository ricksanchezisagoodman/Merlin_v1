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
    /* Internal type: a3l */
    public partial class SpellSlots
    {
        private static List<MethodInfo> _methodReflectionPool = new List<MethodInfo>();
        private static List<PropertyInfo> _propertyReflectionPool = new List<PropertyInfo>();
        private static List<FieldInfo> _fieldReflectionPool = new List<FieldInfo>();
        
        private a3l _internal;
        
        #region Properties
        
        public a3l SpellSlots_Internal => _internal;
        
        #endregion
        
        #region Fields
        
        
        #endregion
        
        #region Methods
        
        public LocalPlayerCharacter GetLocalPlayerCharacter() => _internal.d();
        public SpellSlot[] GetSlots() => _internal.c().Select(x =>(SpellSlot)x).ToArray();
        
        #endregion
        
        #region Constructor
        
        public SpellSlots(a3l instance)
        {
            _internal = instance;
        }
        
        static SpellSlots()
        {
            
        }
        
        #endregion
        
        #region Conversion
        
        public static implicit operator a3l(SpellSlots instance)
        {
            return instance._internal;
        }
        
        public static implicit operator SpellSlots(a3l instance)
        {
            return new SpellSlots(instance);
        }
        
        public static implicit operator bool(SpellSlots instance)
        {
            return instance._internal != null;
        }
        #endregion
    }
}
