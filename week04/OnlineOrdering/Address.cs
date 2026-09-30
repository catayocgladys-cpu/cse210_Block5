//Stores the street, city, state or province, and country. Checks whether the address is in the USA or not.
//GladysCatayoc

namespace OnlineOrdering
{
    public class Address
    {
        private string _street;
        private string _city;
        private string _state;
        private string _country;

        public Address(string street, string city, string state, string county)
        {
            _street = street;
            _city = city;
            _state = state;
            _country = county;

        }
        public book IsInUSA()
        {
            return _country.Trim().Equals("USA", System.StringComparison.OrdinalIgnoreCase);
        }
        public string GetAddressString()
        {
            return _street + "\n" + _city + "," + _state + "\n" + _country;
        }
    }
}