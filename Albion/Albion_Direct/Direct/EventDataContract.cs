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
    /* Internal type: k4 */
    public partial class EventDataContract
    {
        private static List<MethodInfo> _methodReflectionPool = new List<MethodInfo>();
        private static List<PropertyInfo> _propertyReflectionPool = new List<PropertyInfo>();
        private static List<FieldInfo> _fieldReflectionPool = new List<FieldInfo>();
        
        private k4 _internal;
        
        #region Properties
        
        public k4 EventDataContract_Internal => _internal;
        
        #endregion
        
        #region Fields
        
        
        #endregion
        
        #region Methods
        
        
        #endregion
        
        #region Constructor
        
        public EventDataContract(k4 instance)
        {
            _internal = instance;
        }
        
        static EventDataContract()
        {
            
        }
        
        #endregion
        
        #region Conversion
        
        public static implicit operator k4(EventDataContract instance)
        {
            return instance._internal;
        }
        
        public static implicit operator EventDataContract(k4 instance)
        {
            return new EventDataContract(instance);
        }
        
        public static implicit operator bool(EventDataContract instance)
        {
            return instance._internal != null;
        }
        #endregion
    }
}
