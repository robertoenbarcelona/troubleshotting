﻿using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebHost.Startup))]
namespace WebHost
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
        }
    }
}
