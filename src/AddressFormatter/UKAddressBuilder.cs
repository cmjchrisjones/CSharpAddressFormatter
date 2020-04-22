namespace CJTech.AddressFormatter
{
    public class UKAddressBuilder
    {
        private string AddressLineOne;
        private string AddressLineTwo;
        private string AddressLineThree;
        private string AddressLineFour;
        private string AddressLineFive;
        private string Postcode;

        public UKAddressBuilder WithAddressLineOne(string addressLineOne)
        {
            this.AddressLineOne = addressLineOne;
            return this; 
        }
        public UKAddressBuilder WithAddressLineTwo(string addressLineTwo)
        {
            this.AddressLineTwo = addressLineTwo;
            return this;
        }
        public UKAddressBuilder WithAddressLineThree(string addressLineThree)
        {
            this.AddressLineThree = addressLineThree;
            return this;
        }
        public UKAddressBuilder WithAddressLineFour(string addressLineFour)
        {
            this.AddressLineFour = addressLineFour;
            return this;
        }
        public UKAddressBuilder WithAddressLineFive(string addressLineFive)
        {
            this.AddressLineFive = addressLineFive;
            return this;
        }
        public UKAddressBuilder WithPostcode(string Postcode)
        {
            this.Postcode = Postcode;
            return this;
        }

        public UKAddress Build()
        {
            return new UKAddress(AddressLineOne, AddressLineTwo, AddressLineThree, AddressLineFour, AddressLineFive, Postcode);
        }
    }
}
