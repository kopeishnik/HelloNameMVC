using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Controllers;
//using System.Web.Mvc;
using System.Web.Routing;

namespace IControllerFactorySample.ControllerFactories
{
    public class CustomControllerFactory : IControllerFactory
    {
        public IController CreateController(RequestContext requestContext, string controllerName)
        {
            if (string.IsNullOrEmpty(controllerName)) throw new ArgumentNullException("controllerName");

            Type controllerType = Type.GetType($"HelloNameMVC.Controllers.{controllerName}ControllerOlexandr");

            return Activator.CreateInstance(controllerType) as IController;
        }

        object IControllerFactory.CreateController(ControllerContext context)
        {
            throw new NotImplementedException();
        }

        void IControllerFactory.ReleaseController(ControllerContext context, object controller)
        {
            throw new NotImplementedException();
        }
    }
}

/*IController ? controller;

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
            }*/