namespace LibraryForDelegates
{
    public delegate void TotalMarksCalculation();//Step 2 Declare a declare which references the method

    public delegate float PercentageCalulation();
    public delegate bool StudentResult(float p);
    public class Student //Step 1 create the class with the Method
    {
        public int RollNo { get; set; }
        public string Name {get; set; }
        public int TotalMarks { get; set; }
        public int Sub1 { get; set; }
        public int Sub2 { get; set; }
        public int Sub3 { get; set; }
        public void CalculateTotalMarks()
        {
            TotalMarks = Sub1 + Sub2 + Sub3;
        }

        public float CalculatePercentage()
        {
            float percentage = (TotalMarks*100) / 300;
            return percentage;
       }

        public bool OverAllResult(float percentage)
        {
            bool result = false;
            if (percentage >= 75)
            {
                result = true;

            }
            return result;
        
        }

    }
}
