using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingApp
{
    class Cart
    {
        private static Cart __instant;

        public static Cart getInstant()
        {
            if (__instant == null)
                __instant = new Cart();
            return __instant;
        }

        private DataTable cart = new DataTable();
        public Cart()
        {
            cart.Columns.Add("id", typeof(string));
            cart.Columns.Add("idMeal", typeof(string));
            cart.Columns.Add("name", typeof(string));
            cart.Columns.Add("img", typeof(string));
            cart.Columns.Add("price", typeof(int));
        }

    }
}
