using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ToDoApp.TagHelpers
{
    [HtmlTargetElement("*", Attributes = "day-of-the-week")]
    public class DayOfWeekTagHelper: TagHelper
    {
        public DateTime TodoDate { get; set; }
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            // should receive this from tag helper
            
            var stringDate = TodoDate < DateTime.Now.AddDays(7) ? TodoDate.DayOfWeek.ToString() : TodoDate.ToString("MM/dd/yyyy");

            output.Content.SetContent(stringDate);
            // item.Created < DateTime.Now.AddDays(7) ? item.Created.DayOfWeek.ToString() : item.Created.ToString("mm/dd/yyyy"))
        }
    }
}
