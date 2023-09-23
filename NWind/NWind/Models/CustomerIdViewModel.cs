using Microsoft.AspNetCore.Mvc.Rendering;

namespace NWind.Models
{
    public class CustomerIdViewModel
    {
        public int Id { get; set; }
        public readonly List<SelectListItem> CustomerIdSelectedList;
        public CustomerIdViewModel(List<String> CustomerIds)
        {
            CustomerIdSelectedList = new List<SelectListItem>();
            foreach (String no in CustomerIds)
            {
                CustomerIdSelectedList.Add(new SelectListItem { Text = $"{no}", Value = $"{no}" });
            }
        }
    }
}
