using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WolfPack.ILoveBeer.Domain.Entities;
using WolfPack.ILoveBeer.Domain.ValueObjects;

namespace WolfPack.ILoveBeer.Domain.Tests
{
    [TestClass]
    public class BeerTests
    {
        [TestMethod]
        public void ConstructorWithoutId_GeneratesId()
        {
            var brand = "Brand";
            var subBrand = "SubBrand";
            var beerStyle = BeerStyle.Blond;
            var beerType = BeerType.Trappist;

            var underTest = new Beer(brand, subBrand, beerStyle, beerType);

            Assert.AreEqual(brand, underTest.Brand);
            Assert.AreEqual(subBrand, underTest.SubBrand);
            Assert.AreEqual(beerStyle, underTest.Style);
            Assert.AreEqual(beerType, underTest.Type);
            Assert.AreNotEqual(default(Guid), underTest.Id);
        }

        [TestMethod]
        public void ConstructorWithId_DoesNotGenerateId()
        {
            var brand = "Brand";
            var subBrand = "SubBrand";
            var beerStyle = BeerStyle.Blond;
            var beerType = BeerType.Trappist;
            var id = Guid.NewGuid();

            var underTest = new Beer(id, brand, subBrand, beerStyle, beerType);

            Assert.AreEqual(brand, underTest.Brand);
            Assert.AreEqual(subBrand, underTest.SubBrand);
            Assert.AreEqual(beerStyle, underTest.Style);
            Assert.AreEqual(beerType, underTest.Type);
            Assert.AreEqual(id, underTest.Id);
        }

    }
}
