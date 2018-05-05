using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.ViewFeatures;

namespace CustomHtmlHelper2.Helpers
{
    public static class CustomHtmlHelpers
    {
        public static IHtmlContent CustomLabelFor<TModel, TValue>(this HtmlHelper<TModel> html,
            Expression<Func<TModel, TValue>> expression,
            object htmlAttributes = null)
        {
            return html.LabelFor(expression, null, htmlAttributes);
        }
    }
}
