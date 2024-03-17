using System.ComponentModel.DataAnnotations;

namespace newHouseCommittee.Entities
{
    public class Biulding
    {
        [Key]
        public int Id { get; }
        public string Street { get; set; }
        public int NumberStreet { get; set; }
        public int City { get; set; }
        public List<Tenant> BiuldingTenant { get; set; }
    }
}
