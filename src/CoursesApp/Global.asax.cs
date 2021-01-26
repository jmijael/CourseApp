using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;
using CoursesApp.Entity;
using CoursesApp.Data;
using Microsoft.AspNet.WebFormsDependencyInjection.Unity;
using Unity;

namespace CoursesApp
{
    public class Global : HttpApplication
    {
        void Application_Start(object sender, EventArgs e)
        {
            var container = this.AddUnity();
            // Código que se ejecuta al iniciar la aplicación
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            container.RegisterType<ICourseRepository, CourseData>();
            container.RegisterType<IStudentRepository, StudentData>();

            container.RegisterType<ICourseFactory, CourseFactory>();
            container.RegisterType<IStudentFactory, StudentFactory>();
        }
    }
}