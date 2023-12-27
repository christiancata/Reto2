namespace Reto2.Models
{
    public class Student
    {
        #region Propiedades
        public int Id { get; set; }
        public string Document { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public int GradeId { get; set; }
        public Grade Grade { get; set; }
        public List<Enrollment> Enrollment { get; set; }
        #endregion
        #region Constructores
        public Student()
        {
            Document = string.Empty;
            Name = string.Empty;
            Email = string.Empty;
        }
        #endregion
    }
}