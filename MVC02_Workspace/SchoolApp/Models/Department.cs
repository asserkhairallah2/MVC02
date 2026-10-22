using System.Collections.Generic;

namespace SchoolApp.Models
{
    #region Department Class
    public class Department
    {
        #region Properties
        public int Id { get; set; }
        public string Name { get; set; }
        public string MgrName { get; set; }
        #endregion

        #region Navigation Properties
        public ICollection<Student> Students { get; set; }
        public ICollection<Teacher> Teachers { get; set; }
        public ICollection<Course> Courses { get; set; }
        #endregion
    }
    #endregion
}