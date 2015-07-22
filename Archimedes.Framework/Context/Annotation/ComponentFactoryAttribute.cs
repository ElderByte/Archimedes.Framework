﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Archimedes.Framework.Context.Annotation
{
    /// <summary>
    /// Indicates that the method is a component factory, capable of creating implementation of the return type.
    /// </summary>
    [AttributeUsage(AttributeTargets.Method)]
    public class ComponentFactoryAttribute : Attribute
    {

    }
}
