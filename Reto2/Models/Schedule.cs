namespace Reto2.Models
{
    public class Schedule
    {
        #region Propiedades
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public string Status { get; set; }
        public List<SubjectProgram> Programs { get; set; }
        #endregion
        #region Constructores
        public Schedule()
        {
            Name = string.Empty;
        }
        #endregion
    }
}