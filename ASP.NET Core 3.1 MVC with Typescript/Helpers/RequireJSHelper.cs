using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace ASP.NET_Core_3._1_MVC_with_Typescript.Helpers
{
    public static class RequireJSHelper
    {
        public static HtmlString InitPageMainModule(this IHtmlHelper helper, string pageModule)
        {
            var require = new StringBuilder();

            var scriptsPath = "/scripts/";

            require.AppendLine("<script>");
            require.AppendFormat("    require([\"{0}main.js\"]," + Environment.NewLine, scriptsPath);
            require.AppendLine("        function() {");
            require.AppendFormat("            require([\"{0}\", \"domReady!\"]);" + Environment.NewLine, pageModule);
            require.AppendLine("        }");
            require.AppendLine("    );");
            require.AppendLine("</script>");

            return new HtmlString(require.ToString());
        }
    }
}
