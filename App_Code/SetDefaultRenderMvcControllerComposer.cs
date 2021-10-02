using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using Umbraco.Core.Composing;
using Umbraco.Web;
using Umbraco.Web.Mvc;

namespace AarhusWebDevCoop.App_Code
{
    public class SetDefaultRenderMvcControllerComposer : IUserComposer
    {
       
        public void Compose(Composition composition)
        {
            //RouteTable.Routes.MapUmbracoRoute(
            //    "ProjectsCustomerRoute",
            //    "projects/{status}",
            //    new
            //    {
            //        controller = "ProjectsOverview",
            //        action = "index",
            //        status = UrlParameter.Optional
            //    },
            //    new UmbracoVirtualNodeByIdRouteHandler(1081));
        }
    }
}