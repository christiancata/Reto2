namespace Reto2.Models
{
    public class Subject
    {
        #region Propiedades
        public int Id { get; set; }
        public string Name { get; set; }
        public string Status { get; set; }
        public List<Enrollment> Enrollments { get; set; }
        #endregion
        #region Constructores
        public Subject()
        {
            Name = string.Empty;
            Status = string.Empty;
        }
        #endregion
    }
}