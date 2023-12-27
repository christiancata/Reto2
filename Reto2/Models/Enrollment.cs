namespace Reto2.Models
{
    public class Enrollment
    {
        #region Propiedades
        public int Id { get; set; }
        public int SubjectProgramId { get; set; }
        public SubjectProgram SubjectProgram { get; set; }
        public int StudentId { get; set; }
        public Student Student { get; set; }
        public DateTime EnrollmentDate { get; set; }
        public DateTime DisenrollmentDate { get; set; }
        public string Status { get; set; }
        #endregion
        #region Constructores
        public Enrollment()
        {
            Status = string.Empty;
        }
        #endregion
    }
}