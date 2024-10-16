namespace GetSet
{
    public class Person
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public List<Address> Addresses { get; set; } = new List<Address>();

    }

    public class Address
    {
        public string AddressType{ get; set; }
        public string Line1 { get; set; }
        public string Line2 { get; set; }
        public string Pincode { get; set; }
    
    }
}