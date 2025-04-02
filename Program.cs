using LibraryForDelegates;
internal class Program
{
    private static void Main(string[] args)
    {
        Enrollments studEnrollments=new Enrollments();
        Console.WriteLine("enter Fees for course1");
        int fees1=Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter fees for course 2");
        int fees2=Convert.ToInt32(Console.ReadLine());

        CourseFees[] courseFeesArray = new CourseFees[]
        {
            studEnrollments.CalculateTotalCourseFees ,
            studEnrollments.CalculateDiscountOnFees,
            studEnrollments.GenerateReceipt
        };

        CourseFees delobjCrs = (CourseFees)MulticastDelegate.Combine(courseFeesArray);
        delobjCrs(fees1, fees2);

        //CourseFees obj1 = new CourseFees(studEnrollments.CalculateTotalCourseFees);
        //CourseFees obj2=new CourseFees(studEnrollments.CalculateDiscountOnFees);

        //CourseFees delobjCrs=(CourseFees)MulticastDelegate.Combine(obj1, obj2);

        //delobjCrs(fees1,fees2);

        Console.WriteLine($"Total Fees ={studEnrollments.TotalFees}");
        Console.WriteLine($"Discount= {studEnrollments.Discount}");
        Console.WriteLine($"Fees After Discount to be Paid= {studEnrollments.FeesAfterDiscount}" );
        Console.WriteLine($"Receiptno={studEnrollments.ReceiptNo}");
        Console.WriteLine($"Payment Mode of Fees = {studEnrollments.PaymentMode}");






       ////Step 3---create the  object of the class which has the method
       //Student s=new Student();
       // //Step 4 Accept the data for the class and the parameters of the method
       // s.RollNo = 1;
       // s.Name = "Soham";
       // s.Sub1 = 20;
       // s.Sub2 = 30;
       // s.Sub3 = 65;

       // //Step 5 Create the object of delegate, delegate is a reference type, and pass the method reference to the delegate object
       // TotalMarksCalculation delobj = new TotalMarksCalculation(s.CalculateTotalMarks);
       // //The method passed to the delegate object is called target of invocation(call)

       // //Step 6 Invoke/Call the delegate 
       // delobj();
       // Console.WriteLine($"Total Marks= {s.TotalMarks}");

       // PercentageCalulation percentage=new PercentageCalulation(s.CalculatePercentage);
       // float AchievedPercentage=percentage();
       // Console.WriteLine($"Percentage= {AchievedPercentage}");

       // StudentResult result = new StudentResult(s.OverAllResult);
       // bool studResult=result(AchievedPercentage);
       // if (studResult) 
       //     Console.WriteLine($"Student has passed with {AchievedPercentage}");
       // else 
       //     Console.WriteLine($"Student has to try better next time, {AchievedPercentage}");


    }
}