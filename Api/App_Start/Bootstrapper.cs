using Api.Mappings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Api.App_Start
{
    public static class Bootstrapper
    {
        public static void Run() 
        {
            //Configure AutoMapper
            AutoMapperConfiguration.Configure();
        }
    }
}