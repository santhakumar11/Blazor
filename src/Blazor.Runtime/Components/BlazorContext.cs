﻿using System.Security.Claims;
using System.Security.Principal;

namespace Blazor.Runtime.Components
{
    public class BlazorContext
    {
        public string AbsoluteUrl { get; private set; }

        public BlazorContext(string absoluteUrl)
        {
            AbsoluteUrl = absoluteUrl;
        }
    }
}
