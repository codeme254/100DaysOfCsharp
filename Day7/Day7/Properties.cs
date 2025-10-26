namespace Properties
{
    public class Employee
    {
        private int _EmpId;
        private string _EmpName;

        // Public property for _EmpId
        public int EmpId
        {
            // Set accessor to set _EmpId private variable/field
            set
            {
                _EmpId = value;
            }

            // Get accessor to return _EmpId private variable value
            get
            {
                return _EmpId;
            }
        }

        // Public property for _EmpName
        public string EmpName
        {
            // Set accessor to set _EmpName private variable/field
            set
            {
                _EmpName = value;
            }

            // Get accessor to return _EmpName private variable value
            get
            {
                return _EmpName;
            }
        }
    }
    internal class Program
    {
        //public static void Main(string[] args)
        //{
        //    Employee e = new Employee();
        //    // We cannot access private data members
        //    // So we use set accessors to set the values
        //    e.EmpId = 100;
        //    e.EmpName = "John";

        //    // We use get accessors to get the values
        //    Console.WriteLine(e.EmpId);
        //    Console.WriteLine(e.EmpName);
        //}
    }
}
