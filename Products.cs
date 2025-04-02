using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryForDelegates
{
    //Step 2 for delegate
    public delegate void CreateOrder(int productid, int qty, int price);
    public class Products //Step 1  for delegate
    {

        public int Amt { get; set; }

        public void RaiseOrder(int productid,int qty, int price)
        {
            Amt = qty * price;

        }
    }
}
