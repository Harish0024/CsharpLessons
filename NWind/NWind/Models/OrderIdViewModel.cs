using Microsoft.AspNetCore.Mvc.Rendering;



namespace NWind.Models
{
    public class OrderIdViewModel
    {
        public int Id { get; set; }
        public readonly List<SelectListItem> OrderIdSelectedList;
        public OrderIdViewModel(List<int> OrderIds)
        {
            OrderIdSelectedList = new List<SelectListItem>();
            foreach (int Id in OrderIds)
            {
                OrderIdSelectedList.Add(new SelectListItem { Text = $"{Id}", Value = $"{Id}" });
            }
        }
    }
}