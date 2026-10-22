using System;

namespace SchoolApp.Models
{
    #region Teacher Class
    public class Teacher
    {
        #region Properties
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Salary { get; set; }
        public string Address { get; set; }
        public int CourseId { get; set; }
        public int DepartmentId { get; set; }
        #endregion

        #region Navigation Properties
        public Department Department { get; set; }
        public Course Course { get; set; }
        #endregion
    }
    #endregion
}