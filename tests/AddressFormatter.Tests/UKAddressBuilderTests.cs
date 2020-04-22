using FluentAssertions;
using Xunit;

namespace CJTech.AddressFormatter.Tests
{
    public class UKAddressBuilderTests
    {
        [Theory]
        [InlineData("62 The Street", "", "", "", "", "", "62 The Street")]
        [InlineData("", "Suburb", "", "", "", "", "Suburb")]
        [InlineData("", "", "Town", "", "", "", "Town")]
        [InlineData("", "", "", "County", "", "", "County")]
        [InlineData("", "", "", "", "City", "", "City")]
        [InlineData("", "", "", "", "", "Postcode", "Postcode")]

        public void AddressFormattedCorrectlyWithSingleLines(string addressLineOne, string addressLineTwo, string addressLineThree, string addressLineFour, string addressLineFive, string postcode, string expectedFormattedOutput)
        {
            // Arrange
            var sut = new UKAddressBuilder();

            // Act
            sut
                .WithAddressLineOne(addressLineOne)
                .WithAddressLineTwo(addressLineTwo)
                .WithAddressLineThree(addressLineThree)
                .WithAddressLineFour(addressLineFour)
                .WithAddressLineFive(addressLineFive)
                .WithPostcode(postcode);

            // Assert
            var address = sut.Build();
            var formattedAddress = address.Format();
            formattedAddress.Should().Be(expectedFormattedOutput);
        }

        [Fact]
        public void AddressWithAllLinesFormatsCorrectly()
        {
            // Arrange
            var sut = new UKAddressBuilder();

            // Act
            sut.WithAddressLineOne("62 The Street")
                .WithAddressLineTwo("Suburb")
                .WithAddressLineThree("Town")
                .WithAddressLineFour("County")
                .WithAddressLineFive("City")
                .WithPostcode("Postcode");

            // Assert
            var expected = "62 The Street, Suburb, Town, County, City, Postcode";
            var actual = sut.Build();
            actual.Format().Should().Be(expected);

        }

        [Fact]
        public void AddressThrowsExceptionsWhenFormatIsCalledAndNoAddressLinesArePopulated()
        {
            // Arrange
            var sut = new UKAddressBuilder();

            // Act & Assert
            Assert.Throws<AddressEmptyException>(() => sut.Build().Format()).Message.Should().Be("No address lines were populated");
        }
    }
}
