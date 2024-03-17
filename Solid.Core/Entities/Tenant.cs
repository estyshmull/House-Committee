using System.ComponentModel.DataAnnotations;

namespace newHouseCommittee.Entities
{
    public class Tenant
    {
        [Key]
        public int Id { get; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public Biulding Biulding { get; set; }
    }
}
