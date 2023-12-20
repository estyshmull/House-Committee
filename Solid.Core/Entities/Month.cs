namespace newHouseCommittee.Entities
{
    public enum EmonthName
    {
        January, February, March,
        April, May, June, July, August, September, October,
        November, December
    }
    public class Month
    {
        static int id = 0;
        public int Id { get; }
        public bool IsTake { get; set; }
        public EmonthName Name { get; set; }
        public Month()
        {
            Id = id++;
        }

    }
}
