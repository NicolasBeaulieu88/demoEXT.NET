using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace Utilitaire_EXT
{
    public class Global : System.Web.HttpApplication
    {
        protected void Application_Start(object sender, EventArgs e)
        {
            Application["Ext.Net.LicenseKey"] = "OTM1NTY5ODgsMiw5OTk5LTEyLTMx";
        }
    }
}