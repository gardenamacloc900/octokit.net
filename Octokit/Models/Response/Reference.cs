﻿using System;
using System.Diagnostics;
using System.Globalization;

namespace Octokit
{
    [DebuggerDisplay("{DebuggerDisplay,nq}")]
    public class Reference
    {
        public string Ref { get; protected set; }

        public string Url { get; protected set; }

        public TagObject Object { get; protected set; }

        internal string DebuggerDisplay
        {
            get { return String.Format(CultureInfo.InvariantCulture, "Ref: {0}", Ref); }
        }
    }
}
