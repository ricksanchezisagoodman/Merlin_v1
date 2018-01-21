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
    /* Internal type: au6 */
    public partial class SimulationObject
    {
        private static List<MethodInfo> _methodReflectionPool = new List<MethodInfo>();
        private static List<PropertyInfo> _propertyReflectionPool = new List<PropertyInfo>();
        private static List<FieldInfo> _fieldReflectionPool = new List<FieldInfo>();
        
        private au6 _internal;
        
        #region Properties
        
        public au6 SimulationObject_Internal => _internal;
        
        #endregion
        
        #region Fields
        
        
        #endregion
        
        #region Methods
        
        public long GetId() => _internal.az();
        
        #endregion
        
        #region Constructor
        
        public SimulationObject(au6 instance)
        {
            _internal = instance;
        }
        
        static SimulationObject()
        {
            
        }
        
        #endregion
        
        #region Conversion
        
        public static implicit operator au6(SimulationObject instance)
        {
            return instance._internal;
        }
        
        public static implicit operator SimulationObject(au6 instance)
        {
            return new SimulationObject(instance);
        }
        
        public static implicit operator bool(SimulationObject instance)
        {
            return instance._internal != null;
        }
        #endregion
    }
}
