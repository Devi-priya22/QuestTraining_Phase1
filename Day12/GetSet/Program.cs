namespace GetSet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var p = new Person();
            p.Name = "Alpha";
            p.Email = "alpha@gmial.com";

            p.Addresses = new List<Address>();
            p.Addresses.Add(new Address {AddressType = "Home", Line1 = "Church Street", Line2 = "Bangalore", Pincode = "678765"});
            p.Addresses.Add(new Address {AddressType = "Office", Line1 = "Mount Road", Line2 = "Chennai", Pincode = "987665"});

        }
    }
}