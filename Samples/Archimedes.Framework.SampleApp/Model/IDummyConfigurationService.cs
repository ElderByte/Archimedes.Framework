﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Archimedes.Framework.SampleApp.Model
{
    public interface IDummyConfigurationService
    {
        string GetProperty(string key);
    }
}
