namespace Reto2.Models
{
    public class Classroom
    {
        #region Propiedades
        public int Id { get; set; }
        public string Name { get; set; }
        public string Block { get; set; }
        public string Floor { get; set; }
        public string Status { get; set; }
        public List<SubjectProgram> Programs { get; set; }
        #endregion
        #region MyRegion
        public Classroom()
        {
            Name = string.Empty;
            Block = string.Empty;
            Floor = string.Empty;
            Status = string.Empty;
            Programs = new List<SubjectProgram>();
        }
        #endregion
    }
}