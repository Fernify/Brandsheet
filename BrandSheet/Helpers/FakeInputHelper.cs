using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace BrandSheet.Helpers {
    public static class FakeInputHelper {
        public static IHtmlString Radio(this MvcHtmlString helper, string text) {
            StringBuilder builder = new StringBuilder();
            builder.Append("<label class=\"fakeinput radio\">");
            //builder.Append("<input type=\"radio\" name=\"" + name + "\" " + (isChecked ? "checked=\"checked\"" : "") + ">");
            builder.Append(helper.ToString());
            builder.Append("<div class=\"fakebox\"><div class=\"fakefill\"></div></div>");
            builder.Append("<span>" + text + "</span>");
            builder.Append("</label>");
            return new HtmlString(builder.ToString());
        }
    }
}