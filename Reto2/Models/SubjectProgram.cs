namespace Reto2.Models
{
    public class SubjectProgram
    {
        #region Propiedades
        public int Id { get; set; }
        public int SubjectId { get; set; }
        public Subject Subject { get; set; }
        public int ClassroomId { get; set; }
        public Classroom Classroom { get; set; }
        public int ScheduleId { get; set; }
        public Schedule Schedule { get; set; }
        public int? TeacherId { get; set; }
        public Teacher? Teacher { get; set; } = null;
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Status { get; set; }
        public List<Enrollment> Enrollments { get; set; }
        #endregion
        #region Constructor
        public SubjectProgram()
        {
            Status = string.Empty;
        }
        #endregion
    }
}