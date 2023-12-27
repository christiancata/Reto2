namespace Reto2.Models
{
    public class Grade
    {
        #region Propiedades
        public int Id { get; set; }
        public string Name { get; set; }
        public int Number { get; set; }
        public List<Student> Students { get; set; }
        #endregion
        #region Constructores
        public Grade()
        {
            Name = string.Empty;
            Students = new List<Student>();
        }
        #endregion
    }
}