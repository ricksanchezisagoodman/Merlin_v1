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
    /* Internal type: ajb */
    public partial struct Rectangle
    {
        private static List<MethodInfo> _methodReflectionPool = new List<MethodInfo>();
        private static List<PropertyInfo> _propertyReflectionPool = new List<PropertyInfo>();
        private static List<FieldInfo> _fieldReflectionPool = new List<FieldInfo>();
        
        private ajb _internal;
        
        #region Properties
        
        public ajb Rectangle_Internal => _internal;
        
        #endregion
        
        #region Fields
        
        
        #endregion
        
        #region Methods
        
        
        #endregion
        
        #region Constructor
        
        public Rectangle(ajb instance)
        {
            _internal = instance;
        }
        
        static Rectangle()
        {
            
        }
        
        #endregion
        
        #region Conversion
        
        public static implicit operator ajb(Rectangle instance)
        {
            return instance._internal;
        }
        
        public static implicit operator Rectangle(ajb instance)
        {
            return new Rectangle(instance);
        }
        #endregion
    }
}
