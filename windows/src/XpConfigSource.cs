﻿using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Net.XpFramework.Runner
{
    interface XpConfigSource 
    {

        /// <summary>
        /// Returns the use_xp setting derived from this config source
        /// </summary>
        IEnumerable<string> GetUse();

        /// <summary>
        /// Returns the PHP runtime to be used from this config source
        /// </summary>
        string GetRuntime();

        /// <summary>
        /// Returns the PHP runtime arguments to be used from this config source
        /// </summary>
        Dictionary<string, IEnumerable<string>> GetArgs();
        
    }
}
