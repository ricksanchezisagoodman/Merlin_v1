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
    /* Internal type: ax5 */
    public partial class EquipmentItemProxy : DurableItemProxy
    {
        private static List<MethodInfo> _methodReflectionPool = new List<MethodInfo>();
        private static List<PropertyInfo> _propertyReflectionPool = new List<PropertyInfo>();
        private static List<FieldInfo> _fieldReflectionPool = new List<FieldInfo>();
        
        private ax5 _internal;
        
        #region Properties
        
        public ax5 EquipmentItemProxy_Internal => _internal;
        
        #endregion
        
        #region Fields
        
        
        #endregion
        
        #region Methods
        
        
        #endregion
        
        #region Constructor
        
        public EquipmentItemProxy(ax5 instance) : base(instance)
        {
            _internal = instance;
        }
        
        static EquipmentItemProxy()
        {
            
        }
        
        #endregion
        
        #region Conversion
        
        public static implicit operator ax5(EquipmentItemProxy instance)
        {
            return instance._internal;
        }
        
        public static implicit operator EquipmentItemProxy(ax5 instance)
        {
            return new EquipmentItemProxy(instance);
        }
        
        public static implicit operator bool(EquipmentItemProxy instance)
        {
            return instance._internal != null;
        }
        #endregion
    }
}
