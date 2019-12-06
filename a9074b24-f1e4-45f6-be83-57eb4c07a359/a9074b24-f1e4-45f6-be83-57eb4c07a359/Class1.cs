using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace a9074b24_f1e4_45f6_be83_57eb4c07a359
{
    public class Class1
    {
        public static void T()
        {
            HttpUtility.ParseQueryString("/signin.ashsx");

            HttpContext context;

            string userId = context.Request.QueryString["userId"];
        }
    }
}