using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebMiProyecto.Helpers
{
    public static class Helpers
    {
        public static IHtmlString LabelTest(this HtmlHelper htmlhelper)
        {
            return new HtmlString("<label>Test</label>");
        }
    }
}