using System.Text;

namespace CJTech.AddressFormatter
{
    public class UKAddress
    {
        private string addressLineOne;
        private string addressLineTwo;
        private string addressLineThree;
        private string addressLineFour;
        private string addressLineFive;
        private string addressPostcode;

        public UKAddress(
            string addressLineOne,
            string addressLineTwo,
            string addressLineThree,
            string addressLineFour,
            string addressLineFive,
            string addressPostcode
            )
        {
            this.addressLineOne = addressLineOne;
            this.addressLineTwo = addressLineTwo;
            this.addressLineThree = addressLineThree;
            this.addressLineFour = addressLineFour;
            this.addressLineFive = addressLineFive;
            this.addressPostcode = addressPostcode;
        }

        private StringBuilder AddComma(StringBuilder currentString)
        {
            return currentString.Append(", ");
        }

        public string Format()
        {
            if (string.IsNullOrEmpty(addressLineOne)
                && string.IsNullOrEmpty(addressLineTwo)
                && string.IsNullOrEmpty(addressLineThree)
                && string.IsNullOrEmpty(addressLineFour)
                && string.IsNullOrEmpty(addressLineFive)
                && string.IsNullOrEmpty(addressPostcode))
            {
                throw new AddressEmptyException("No address lines were populated");
            }

            var sb = new StringBuilder();
            if (!string.IsNullOrWhiteSpace(addressLineOne))
            {
                sb.Append(addressLineOne);
                AddComma(sb);
            }
            if (!string.IsNullOrWhiteSpace(addressLineTwo))
            {
                sb.Append(addressLineTwo);
                AddComma(sb);
            }
            if (!string.IsNullOrWhiteSpace(addressLineThree))
            {
                sb.Append(addressLineThree);
                AddComma(sb);
            }
            if (!string.IsNullOrWhiteSpace(addressLineFour))
            {
                sb.Append(addressLineFour);
                AddComma(sb);
            }
            if (!string.IsNullOrWhiteSpace(addressLineFive))
            {
                sb.Append(addressLineFive);
                AddComma(sb);
            }
            if (!string.IsNullOrWhiteSpace(addressPostcode))
            {
                sb.Append(addressPostcode);
            }

            var formattedAddress = sb.ToString().Trim();
            if (formattedAddress.Substring(formattedAddress.Length - 1) == ",")
            {
                formattedAddress = formattedAddress.TrimEnd(',');
            }
            return formattedAddress;
        }
    }
}
