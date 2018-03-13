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
    /* Internal type: bb2 */
    public partial class GuiFurnitureItemProxy : GuiDurableItemProxy
    {
        private static List<MethodInfo> _methodReflectionPool = new List<MethodInfo>();
        private static List<PropertyInfo> _propertyReflectionPool = new List<PropertyInfo>();
        private static List<FieldInfo> _fieldReflectionPool = new List<FieldInfo>();
        
        private bb2 _internal;
        
        #region Properties
        
        public bb2 GuiFurnitureItemProxy_Internal => _internal;
        
        #endregion
        
        #region Fields
        
        
        #endregion
        
        #region Methods
        
        
        #endregion
        
        #region Constructor
        
        public GuiFurnitureItemProxy(bb2 instance) : base(instance)
        {
            _internal = instance;
        }
        
        static GuiFurnitureItemProxy()
        {
            
        }
        
        #endregion
        
        #region Conversion
        
        public static implicit operator bb2(GuiFurnitureItemProxy instance)
        {
            return instance._internal;
        }
        
        public static implicit operator GuiFurnitureItemProxy(bb2 instance)
        {
            return new GuiFurnitureItemProxy(instance);
        }
        
        public static implicit operator bool(GuiFurnitureItemProxy instance)
        {
            return instance._internal != null;
        }
        #endregion
    }
}
