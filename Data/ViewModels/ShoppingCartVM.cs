using OnlineTicketsMovieManagement.Data.Cart;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineTicketsMovieManagement.Data.ViewModels
{
    public class ShoppingCartVM
    {
        public ShoppingCart ShoppingCart { get; set; }
        
        public double ShoppingCartTotal { get; set; }
    }
}
 