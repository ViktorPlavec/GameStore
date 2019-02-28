using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameStore.Domain.Entities
{
    public class ShippingDetails
    {
        [Required(ErrorMessage = "Укажите как вас зовут")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Укажите адрес доставки")]
        [Display(Name = "Адрес:")]
        public string Adress { get; set; }

        [Required(ErrorMessage = "Укажите город")]
        [Display(Name = "Город:")]
        public string City { get; set; }

        [Required(ErrorMessage = "Укажите страну")]
        [Display(Name = "Страна:")]
        public string Country { get; set; }

        public bool GiftWrap { get; set; }
    }
}
