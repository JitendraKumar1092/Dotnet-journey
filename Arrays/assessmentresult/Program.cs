namespace AssessmentResult //DO NOT change the namespace name
{
    public class Program //DO NOT change the class name
    {
        public string GetAssessmentResult(int? mark, double? attendance)
        {
            if (mark == null || attendance == null)
            {
                return "N/A";
            }
            else if (mark >= 80 && attendance >= 80)
            {
                return "Pass with distinction";
            }
            else if (mark >= 60 && attendance >= 60)
            {
                return "Pass";
            }
            else
            {
                return "Fail";
            }
        }

        public static void Main(string[] args)  //DO NOT change the method signature
        {
            Console.WriteLine("Enter the mark (or leave blank for null)");
            string markInput = Console.ReadLine();
            int? mark = string.IsNullOrEmpty(markInput) ? (int?)null : int.Parse(markInput);

            Console.WriteLine("Enter the attendance (or leave blank for null)");
            string attendanceInput = Console.ReadLine();
            double? attendance = string.IsNullOrEmpty(attendanceInput) ? (double?)null : double.Parse(attendanceInput);

            Program program = new Program();
            string result = program.GetAssessmentResult(mark, attendance);

            Console.WriteLine(result);
        }
    }
}
