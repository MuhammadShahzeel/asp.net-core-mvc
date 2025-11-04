namespace WebApplication1.Models
{
    public class Employee
    {
        //for input
        public string Name { get; set; }

        //for dropdown
        public Gender Gender{ get; set; }
        // for radio button
        public string MaritalStatus { get; set; }
        //for text area
        public string Address { get; set; }   // for TextArea
    }

    //enum for dropdown
    public enum Gender
    {
        Male,Female

    }


}
