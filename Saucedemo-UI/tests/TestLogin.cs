using OpenQA.Selenium;
using Saucedemo_UI.src.core;
using Saucedemo_UI.src.models;
using Saucedemo_UI.src.pages.inventory;
using Saucedemo_UI.src.pages.login;
using Saucedemo_UI.src.pages.navbar;

namespace Saucedemo_UI.tests
{
    public class Tests

    {
        private string[] items = { "Sauce Labs Backpack", "Sauce Labs Bike Light" };

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestValidLogin()
        {
            LoginSteps.Login("standard_user", "secret_sauce");
            string heading = InventorySteps.GetHeading();

            Assert.That(heading, Is.EqualTo("Products"));
        }
        [Test]
        public void TestAddingItemsToCart()
        {
            LoginSteps.Login("standard_user", "secret_sauce");
            List<Item> addedItems = InventorySteps.GetInvenotry(items);
            int cartCount = NavBarSteps.GetShoppingCartItemsCount();
            Assert.That(addedItems, Has.Count.EqualTo(2));
            Assert.That(cartCount, Is.EqualTo(2));
        }

        [TearDown]
        public void TearDown()
        {
            DriverManager.QuitDriver();
        }


    }
}