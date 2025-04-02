using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryForDelegates
{
    public delegate void CourseFees(int f1, int f2);//Step 2 Declare a declare which references the method

    public class Enrollments//Step 1 create the class with the Method
    {
        static int _receiptno=1;
        public int TotalFees { get; set; }
        public double Discount { get; set; }
        public double FeesAfterDiscount { get; set; }

        public string PaymentMode { get; set; }
        public int ReceiptNo { get; set; }
        public void CalculateTotalCourseFees(int crsfees1, int crsfeees2)
        {
            TotalFees = crsfees1 + crsfeees2;

        }

        public void CalculateDiscountOnFees(int crsfees1, int crsfeees2)
        {

            if ((crsfees1 > 10000) || (crsfeees2 > 10000))
            {
                Discount=TotalFees * .10;
                FeesAfterDiscount = TotalFees - Discount;

            }
            else 
            {
                Discount = 0;
            }
        
        }


        public void GenerateReceipt(int crsfees1, int crsfeees2)
        {
            _receiptno++;
            ReceiptNo=_receiptno;
            PaymentMode = "Cash";

        
        }


    }
}
