

using BurgerTimeApp.Domain.Entities;
using System.ComponentModel.DataAnnotations;

namespace BurgerTimeApp.ViewModels.ViewModel.OrderViewModel
{
    public class OrderViewModel
    {
        [Display(Name = "Order ID")]
        public int Id { get; set; }
        [Display(Name = "Name")] 
        public string FullName { get; set; }
        [Display(Name = "Address")]
        public string Address { get; set; }
        [Display(Name = "Is Delievered")]
        public bool IsDelievered { get; set; }
        [Display(Name = "Burgers")]
        public List<Burger> Burgers { get; set; }
        [Display(Name = "Location")]
        public string Location { get; set; }
    }
}
