using System;
using System.Configuration;
using System.Web.Mvc;
using System.Web.Routing;
using HelloNameMVC.Controllers;

namespace IControllerFactorySample.ControllerFactories
{
    public class CustomControllerFactory : DefaultControllerFactory
    {
        public override IController CreateController(RequestContext requestContext, string controllerName)
        {
            if (string.IsNullOrEmpty(controllerName)) throw new ArgumentNullException("controllerName");

            Type controllerType = controllerName == "Home" ? Type.GetType("HelloNameMVC.Controllers.HomeControllerOlexandr") : Type.GetType($"HelloNameMVC.Controllers.{controllerName}Controller");

            IController? controller;

            if (controllerType == null)
            {
                throw new ArgumentNullException("controllerType");
            }
            else
            {
                controller = Activator.CreateInstance(controllerType) as IController;
            }
            
            if (controller == null)
            {
                throw new ArgumentNullException("controller");
            }
            else
            {
                return controller;
            }
        }
    }
}