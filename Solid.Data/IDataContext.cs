namespace newHouseCommittee.Entities
{
    public interface IDataContext
    {
        public List<Month> months { get; set; }
        public List<Tenant> tenantList { get; set; }
        public List<Payment> paymentList { get; set; }
    }
}
