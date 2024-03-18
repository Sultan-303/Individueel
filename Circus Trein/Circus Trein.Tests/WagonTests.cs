using System.Drawing;
using System.Net.Security;
using System.Xml.Linq;

namespace Circus_Trein.Tests
{
    [TestClass]
    public class WagonTests
    {   
        
        [TestMethod]
        public void Right_Amount_Of_Wagons_Created_Test_1()
        {
            // Arrange
            var allAnimals = new List<Animal>
            {
                // Add animals to the list
                Animal.SmallCarnivore, // Adding one small carnivore
                Animal.LargeHerbivore, // Adding one large herbivore
                Animal.LargeHerbivore, // Adding one medium carnivore
                Animal.MediumHerbivore, // Adding one small herbivore
                Animal.MediumHerbivore, // Adding one large carnivore
                Animal.MediumHerbivore // Adding one medium herbivore
            };

            // Act
            var distributor = new Distributor();
            distributor.DistributeAnimals(allAnimals);

            // Assert
            Assert.AreEqual(2, distributor.Wagons.Count);
        }

        [TestMethod]
        public void Right_Amount_Of_Wagons_Created_Test_2()
        {
            // Arrange
            var allAnimals = new List<Animal>
            {
                // Add animals to the list
                Animal.SmallCarnivore, // Adding one small carnivore
                Animal.LargeHerbivore, // Adding one large herbivore
                Animal.MediumHerbivore, // Adding one medium carnivore
                Animal.MediumHerbivore, // Adding one medium carnivore
                Animal.SmallHerbivore, // Adding one small herbivore
                Animal.SmallHerbivore, // Adding one small herbivore
                Animal.SmallHerbivore, // Adding one small herbivore
                Animal.SmallHerbivore, // Adding one small herbivore
                Animal.SmallHerbivore // Adding one small herbivore
            };

            // Act
            var distributor = new Distributor();
            distributor.DistributeAnimals(allAnimals);

            // Assert
            Assert.AreEqual(2, distributor.Wagons.Count);
        }

        [TestMethod]
        public void Right_Amount_Of_Wagons_Created_Test_3()
        {
            // Arrange
            var allAnimals = new List<Animal>
            {
                // Add animals to the list
                Animal.LargeCarnivore, // Adding one large carnivore
                Animal.MediumCarnivore, // Adding one medium carnivore
                Animal.SmallCarnivore, // Adding one small carnivore
                Animal.LargeHerbivore, // Adding one large herbivore
                Animal.MediumHerbivore, // Adding one medium herbivore
                Animal.SmallHerbivore // Adding one small herbivore
            };

            // Act
            var distributor = new Distributor();
            distributor.DistributeAnimals(allAnimals);

            // Assert
            Assert.AreEqual(4, distributor.Wagons.Count);
        }

        [TestMethod]
        public void Right_Amount_Of_Wagons_Created_Test_4()
        {
            // Arrange
            var allAnimals = new List<Animal>
            {
                // Add animals to the list
                Animal.LargeCarnivore, // Adding one large carnivore
                Animal.LargeCarnivore, // Adding one large carnivore
                Animal.MediumCarnivore, // Adding one medium carnivore
                Animal.SmallCarnivore, // Adding one small carnivore
                Animal.LargeHerbivore, // Adding one large herbivore
                Animal.MediumHerbivore, // Adding one medium herbivore
                Animal.MediumHerbivore, // Adding one medium herbivore
                Animal.MediumHerbivore, // Adding one medium herbivore
                Animal.MediumHerbivore, // Adding one medium herbivore
                Animal.MediumHerbivore, // Adding one medium herbivore
                Animal.SmallHerbivore // Adding one small herbivore
            };

            // Act
            var distributor = new Distributor();
            distributor.DistributeAnimals(allAnimals);

            // Assert
            Assert.AreEqual(5, distributor.Wagons.Count);
        }

        [TestMethod]
        public void Right_Amount_Of_Wagons_Created_Test_5()
        {
            // Arrange
            var allAnimals = new List<Animal>
            {
                // Add animals to the list
                Animal.SmallCarnivore, // Adding one small carnivore
                Animal.LargeHerbivore, // Adding one large herbivore
                Animal.LargeHerbivore, // Adding one large herbivore
                Animal.MediumHerbivore, // Adding one medium herbivore
                Animal.SmallHerbivore // Adding one small herbivore
            };

            // Act
            var distributor = new Distributor();
            distributor.DistributeAnimals(allAnimals);

            // Assert
            Assert.AreEqual(2, distributor.Wagons.Count);
        }

        [TestMethod]
        public void Right_Amount_Of_Wagons_Created_Test_6()
        {
            // Arrange
            var allAnimals = new List<Animal>
            {
                // Add animals to the list
                Animal.SmallCarnivore, // Adding one small carnivore
                Animal.SmallCarnivore, // Adding one small carnivore
                Animal.SmallCarnivore, // Adding one small carnivore
                Animal.LargeHerbivore, // Adding one large herbivore
                Animal.LargeHerbivore, // Adding one large herbivore
                Animal.LargeHerbivore, // Adding one large herbivore
                Animal.MediumHerbivore, // Adding one medium herbivore
                Animal.MediumHerbivore // Adding one medium herbivore
            };

            // Act
            var distributor = new Distributor();
            distributor.DistributeAnimals(allAnimals);

            // Assert
            Assert.AreEqual(3, distributor.Wagons.Count);
        }

        [TestMethod]
        public void Right_Amount_Of_Wagons_Created_Test_7()
        {
            var allAnimals = new List<Animal>
            {
                // Add animals to the list
                Animal.LargeCarnivore, // Adding one large carnivore
                Animal.LargeCarnivore, // Adding one large carnivore
                Animal.LargeCarnivore, // Adding one large carnivore
                Animal.MediumCarnivore, // Adding one medium carnivore
                Animal.MediumCarnivore, // Adding one medium carnivore
                Animal.MediumCarnivore, // Adding one medium carnivore
                Animal.SmallCarnivore, // Adding one small carnivore
                Animal.SmallCarnivore, // Adding one small carnivore
                Animal.SmallCarnivore, // Adding one small carnivore
                Animal.SmallCarnivore, // Adding one small carnivore
                Animal.SmallCarnivore, // Adding one small carnivore
                Animal.SmallCarnivore, // Adding one small carnivore
                Animal.SmallCarnivore, // Adding one small carnivore
                Animal.LargeHerbivore, // Adding one large herbivore
                Animal.LargeHerbivore, // Adding one large herbivore
                Animal.LargeHerbivore, // Adding one large herbivore
                Animal.LargeHerbivore, // Adding one large herbivore
                Animal.LargeHerbivore, // Adding one large herbivore
                Animal.LargeHerbivore, // Adding one large herbivore
                Animal.MediumHerbivore, // Adding one Medium herbivore
                Animal.MediumHerbivore, // Adding one Medium herbivore
                Animal.MediumHerbivore, // Adding one Medium herbivore
                Animal.MediumHerbivore, // Adding one Medium herbivore
                Animal.MediumHerbivore, // Adding one Medium herbivore
                Animal.MediumHerbivore // Adding one Medium herbivore
            };

            // Act
            var distributor = new Distributor();
            distributor.DistributeAnimals(allAnimals);

            // Assert
            Assert.AreEqual(13, distributor.Wagons.Count);

        }
    }
}