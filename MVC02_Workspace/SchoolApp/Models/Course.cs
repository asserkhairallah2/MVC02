using System.Collections.Generic;

namespace SchoolApp.Models
{
    #region Course Class
    public class Course
    {
        #region Properties
        public int Id { get; set; }
        public string Name { get; set; }
        public int Degree { get; set; }
        public int MinDegree { get; set; }
        public int DepartmentId { get; set; }
        #endregion

        #region Navigation Properties
        public Department Department { get; set; }
        public ICollection<Teacher> Teachers { get; set; }
        public ICollection<StuCrsRes> StuCrsRes { get; set; }
        #endregion
    }
    #endregion
}