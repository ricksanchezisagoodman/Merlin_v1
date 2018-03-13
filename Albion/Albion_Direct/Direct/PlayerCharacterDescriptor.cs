////////////////////////////////////////////////////////////////////////////////////
// Merlin API for Albion Online v1.10.357.113485-prod
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
    /* Internal type: aid */
    public partial class PlayerCharacterDescriptor : CharacterDescriptor
    {
        private static List<MethodInfo> _methodReflectionPool = new List<MethodInfo>();
        private static List<PropertyInfo> _propertyReflectionPool = new List<PropertyInfo>();
        private static List<FieldInfo> _fieldReflectionPool = new List<FieldInfo>();
        
        private aid _internal;
        
        #region Properties
        
        public aid PlayerCharacterDescriptor_Internal => _internal;
        
        #endregion
        
        #region Fields
        
        
        #endregion
        
        #region Methods
        
        public float GetHarvestRange() => _internal.d5();
        public int GetInventorySize() => _internal.d4();
        public float GetUseObjectRange() => _internal.d7();
        
        #endregion
        
        #region Constructor
        
        public PlayerCharacterDescriptor(aid instance) : base(instance)
        {
            _internal = instance;
        }
        
        static PlayerCharacterDescriptor()
        {
            
        }
        
        #endregion
        
        #region Conversion
        
        public static implicit operator aid(PlayerCharacterDescriptor instance)
        {
            return instance._internal;
        }
        
        public static implicit operator PlayerCharacterDescriptor(aid instance)
        {
            return new PlayerCharacterDescriptor(instance);
        }
        
        public static implicit operator bool(PlayerCharacterDescriptor instance)
        {
            return instance._internal != null;
        }
        #endregion
    }
}
