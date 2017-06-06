using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Html;
namespace BrandSheet.Helpers {
    public static class FakeInputHelper {
        public static IHtmlString Radio(string name, bool isChecked, string value, string text) {
            StringBuilder builder = new StringBuilder();
            builder.Append("<label class=\"fakeinput radio\">");
            builder.Append("<input type=\"radio\" value=\""+ value + "\" name=\"" + name + "\" " + (isChecked ? "checked=\"checked\"" : "") + " />");
            builder.Append("<div class=\"fakebox\"><div class=\"fakefill\"></div></div>");
            builder.Append("<span>" + text + "</span>");
            builder.Append("</label>");
            return new HtmlString(builder.ToString());
        }

        public static IHtmlString Checkbox(string name, bool isChecked, string text) {
            StringBuilder builder = new StringBuilder();
            builder.Append("<label class=\"fakeinput checkbox\">");
            builder.Append("<input type=\"checkbox\" name=\"" + name + "\" " + (isChecked ? "checked" : "") + " />");
            builder.Append("<div class=\"fakebox\"><div class=\"fakefill\"></div></div>");
            builder.Append("<span>" + text + "</span>");
            builder.Append("</label>");
            return new HtmlString(builder.ToString());
        }
    }
}