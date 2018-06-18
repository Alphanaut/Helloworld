namespace Registration.Domain
{
    public class Address
    {
        public int Id { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public int StateId { get; set; }
        public string ZipCode { get; set; }
        public int CountryId { get; set; }
        public int AddressTypeId { get; set; }

        public State State { get; set; }
        public virtual Country Country { get; set; }
        public virtual AddressType AddressType { get; set; }
        
    }
}
