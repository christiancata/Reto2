namespace Reto2.Models
{
    public class Teacher
    {
        #region Propiedades
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Specialty { get; set; }
        public List<Enrollment> Enrollments { get; set; }
        #endregion
        #region Constructores
        public Teacher()
        {
            Name = string.Empty;
            Email = string.Empty;
            Specialty = string.Empty;
        }
        #endregion
    }
}