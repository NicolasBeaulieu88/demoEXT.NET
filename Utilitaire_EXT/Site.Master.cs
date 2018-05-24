using System;
using System.Web.UI;
using System.Collections.Generic;
using Ext.Net;

namespace Utilitaire_EXT
{
    public partial class SiteMaster : MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!X.IsAjaxRequest)
            {
                
            }
        }
        
    }
}