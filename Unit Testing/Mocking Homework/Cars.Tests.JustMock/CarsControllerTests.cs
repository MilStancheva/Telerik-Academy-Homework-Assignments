namespace Cars.Tests.JustMock
{
    using System;
    using System.Collections.Generic;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    using Cars.Contracts;
    using Cars.Tests.JustMock.Mocks;
    using Cars.Controllers;
    using Cars.Models;
    using Infrastructure;
    using Moq;
    using Data;

    [TestClass]
    public class CarsControllerTests
    {
        private readonly ICarsRepository carsData;
        private CarsController controller;

        public CarsControllerTests()
            : this(new JustMockCarsRepository())
        // : this(new MoqCarsRepository())
        {
        }

        private CarsControllerTests(ICarsRepositoryMock carsDataMock)
        {
            this.carsData = carsDataMock.CarsData;
        }

        [TestInitialize]
        public void CreateController()
        {
            this.controller = new CarsController(this.carsData);
        }

        [TestMethod]
        public void IndexShouldReturnAllCars()
        {
            var model = (ICollection<Car>)this.GetModel(() => this.controller.Index());

            Assert.AreEqual(4, model.Count);
        }

        [TestMethod]
        public void AddingCarShouldThrowArgumentNullExceptionIfCarIsNull()
        {
            try
            {
                var model = (Car)this.GetModel(() => this.controller.Add(null));
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {

            }
        }

        [TestMethod]
        public void AddingCarShouldThrowArgumentNullExceptionIfCarMakeIsNull()
        {
            var car = new Car
            {
                Id = 15,
                Make = "",
                Model = "330d",
                Year = 2014
            };

            try
            {
                var model = (Car)this.GetModel(() => this.controller.Add(car));
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {

            }
        }

        [TestMethod]
        public void AddingCarShouldThrowArgumentNullExceptionIfCarModelIsNull()
        {
            var car = new Car
            {
                Id = 15,
                Make = "BMW",
                Model = "",
                Year = 2014
            };

            try
            {
                var model = (Car)this.GetModel(() => this.controller.Add(car));
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {

            }
        }

        [TestMethod]
        public void AddingCarShouldReturnADetailID()
        {
            var car = new Car
            {
                Id = 15,
                Make = "BMW",
                Model = "330d",
                Year = 2014
            };

            var model = (Car)this.GetModel(() => this.controller.Add(car));

            Assert.AreEqual(1, model.Id);
        }

        [TestMethod]
        public void AddingCarShouldReturnADetailMake()
        {
            var car = new Car
            {
                Id = 15,
                Make = "BMW",
                Model = "330d",
                Year = 2014
            };

            var model = (Car)this.GetModel(() => this.controller.Add(car));

            Assert.AreEqual("Audi", model.Make);
        }

        [TestMethod]
        public void AddingCarShouldReturnADetailModel()
        {
            var car = new Car
            {
                Id = 15,
                Make = "BMW",
                Model = "330d",
                Year = 2014
            };

            var model = (Car)this.GetModel(() => this.controller.Add(car));

            Assert.AreEqual("A5", model.Model);
        }

        [TestMethod]
        public void AddingCarShouldReturnADetailYear()
        {
            var car = new Car
            {
                Id = 15,
                Make = "BMW",
                Model = "330d",
                Year = 2014
            };

            var model = (Car)this.GetModel(() => this.controller.Add(car));

            Assert.AreEqual(2005, model.Year);
        }

        [TestMethod]
        public void DetailsShouldThrowArgumentNullExceptionIfCarIsNotFound()
        {
            var mockedRepository = new Mock<ICarsRepository>();
            mockedRepository.Setup(x => x.GetById(It.IsAny<int>())).Returns((Car)(null));
            var carsController = new CarsController(mockedRepository.Object);

            try
            {
                Assert.IsNull(carsController.Details(1000000));
            }
            catch (ArgumentNullException)
            {

            }
        }

        [TestMethod]
        public void DetailsShouldReturnAValidCarView()
        {
            int id = 0;
            var car = this.carsData.GetById(id);
            var expectedResult = new View(car);

            Assert.IsInstanceOfType(expectedResult, typeof(View));
        }

        [TestMethod]
        public void SearchShouldReturnValidResultWhenProperConditionIsProvided()
        {
            var mockedData = new Mock<IDatabase>();
            mockedData.Setup(x => x.Cars).Returns(new List<Car>());
            var carsRepository = new CarsRepository(mockedData.Object);

            carsRepository.Add(new Car
            {
                Id = 6,
                Make = "Subaru",
                Model = "Forester",
                Year = 2015
            });

            carsRepository.Add(new Car
            {
                Id = 7,
                Make = "Citroen",
                Model = "DS4",
                Year = 2013
            });

            carsRepository.Add(new Car
            {
                Id = 8,
                Make = "Mazda",
                Model = "6",
                Year = 2015
            });

            carsRepository.Add(new Car
            {
                Id = 9,
                Make = "Renault",
                Model = "Laguna",
                Year = 2012
            });

            var carsController = new CarsController(carsRepository);
            var expectedModel = "Citroen";
            var result = (List<Car>)carsController.Search(expectedModel).Model;

            foreach (var car in result)
            {
                Assert.AreEqual(expectedModel, car.Make);
            }
        }

        [TestMethod]
        public void SearchShouldThrowExceptionIfConditionIsNotFound()
        {
            var mockedData = new Mock<IDatabase>();
            mockedData.Setup(x => x.Cars).Returns(new List<Car>());
            var carsRepository = new CarsRepository(mockedData.Object);

            carsRepository.Add(new Car
            {
                Id = 6,
                Make = "Subaru",
                Model = "Forester",
                Year = 2015
            });

            carsRepository.Add(new Car
            {
                Id = 7,
                Make = "Citroen",
                Model = "DS4",
                Year = 2013
            });

            carsRepository.Add(new Car
            {
                Id = 8,
                Make = "Mazda",
                Model = "6",
                Year = 2015
            });

            carsRepository.Add(new Car
            {
                Id = 9,
                Make = "Renault",
                Model = "Laguna",
                Year = 2012
            });

            var carsController = new CarsController(carsRepository);
            var condition = "Mercedez";
            try
            {
                var result = (List<Car>)carsController.Search(condition).Model;

                foreach (var car in result)
                {
                    Assert.Fail(condition, car.Make);
                }

            }
            catch (NullReferenceException)
            {

            }
        }

        [TestMethod]
        public void SortingByYearShouldReturnProperView()
        {
            var mockedData = new Mock<IDatabase>();
            mockedData.Setup(x => x.Cars).Returns(new List<Car>());
            var carsRepository = new CarsRepository(mockedData.Object);

            carsRepository.Add(new Car
            {
                Id = 6,
                Make = "Subaru",
                Model = "Forester",
                Year = 2015
            });

            carsRepository.Add(new Car
            {
                Id = 7,
                Make = "Citroen",
                Model = "DS4",
                Year = 2013
            });

            carsRepository.Add(new Car
            {
                Id = 8,
                Make = "Mazda",
                Model = "6",
                Year = 2015
            });

            carsRepository.Add(new Car
            {
                Id = 9,
                Make = "Renault",
                Model = "Laguna",
                Year = 2012
            });

            var carsController = new CarsController(carsRepository);

            var result = (List<Car>)carsController.Sort("year").Model;

            for (int i = 0; i < result.Count - 1; i++)
            {
                if (result[i].Year < result[i + 1].Year)
                {
                    Assert.Fail("Sorting by year has failed.");
                }
            }
        }

        [TestMethod]
        public void SortingByMakeShouldReturnProperView()
        {
            var mockedData = new Mock<IDatabase>();
            mockedData.Setup(x => x.Cars).Returns(new List<Car>());
            var carsRepository = new CarsRepository(mockedData.Object);

            carsRepository.Add(new Car
            {
                Id = 6,
                Make = "Subaru",
                Model = "Forester",
                Year = 2015
            });

            carsRepository.Add(new Car
            {
                Id = 7,
                Make = "Citroen",
                Model = "DS4",
                Year = 2013
            });

            carsRepository.Add(new Car
            {
                Id = 8,
                Make = "Mazda",
                Model = "6",
                Year = 2015
            });

            carsRepository.Add(new Car
            {
                Id = 9,
                Make = "Renault",
                Model = "Laguna",
                Year = 2012
            });

            var carsController = new CarsController(carsRepository);

            var result = (List<Car>)carsController.Sort("make").Model;

            for (int i = 0; i < result.Count - 1; i++)
            {
                if (string.Compare(result[i].Make, result[i + 1].Make) > 0)
                {
                    Assert.Fail("Sorting by year has failed.");
                }
            }
        }


        [TestMethod]
        public void SortingByInvalidParameterShouldThrowArgumentException()
        {
            var mockedData = new Mock<IDatabase>();
            mockedData.Setup(x => x.Cars).Returns(new List<Car>());
            var carsRepository = new CarsRepository(mockedData.Object);

            carsRepository.Add(new Car
            {
                Id = 6,
                Make = "Subaru",
                Model = "Forester",
                Year = 2015
            });

            carsRepository.Add(new Car
            {
                Id = 7,
                Make = "Citroen",
                Model = "DS4",
                Year = 2013
            });

            carsRepository.Add(new Car
            {
                Id = 8,
                Make = "Mazda",
                Model = "6",
                Year = 2015
            });

            carsRepository.Add(new Car
            {
                Id = 9,
                Make = "Renault",
                Model = "Laguna",
                Year = 2012
            });

            var carsController = new CarsController(carsRepository);

            try
            {
                var result = (List<Car>)carsController.Sort("hello").Model;
                Assert.Fail();
            }
            catch (ArgumentException)
            {

            }
        }


        private object GetModel(Func<IView> funcView)
        {
            var view = funcView();
            return view.Model;
        }
    }
}
