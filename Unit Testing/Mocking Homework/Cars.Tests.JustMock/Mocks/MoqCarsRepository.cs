namespace Cars.Tests.JustMock.Mocks
{
    using Cars.Contracts;
    using Cars.Models;
    using Moq;
    using System.Linq;

    public class MoqCarsRepository : CarRepositoryMock, ICarsRepositoryMock
    {
        protected override void ArrangeCarsRepositoryMock()
        {
            var mockedCarsRepository = new Mock<ICarsRepository>();
            mockedCarsRepository.Setup(r => r.Add(It.IsAny<Car>())).Verifiable();
            mockedCarsRepository.Setup(r => r.Remove(It.IsAny<Car>())).Verifiable();
            mockedCarsRepository.Setup(r => r.GetById(It.IsAny<int>())).Returns(this.FakeCarCollection.First());
            mockedCarsRepository.Setup(r => r.All()).Returns(this.FakeCarCollection);
            mockedCarsRepository.Setup(r => r.SortedByMake()).Returns(() => this.FakeCarCollection.OrderBy(car => car.Make).ToList());
            mockedCarsRepository.Setup(r => r.SortedByYear()).Returns(() => this.FakeCarCollection.OrderByDescending(car => car.Year).ToList());
            mockedCarsRepository.Setup(r => r.Search(It.IsAny<string>()))
                        .Returns<string>(str => this.FakeCarCollection.Where(car => car.Make.ToLower().Contains(str.ToLower()) ||
                                                                             car.Model.ToLower().Contains(str.ToLower())).ToList());
            this.CarsData = mockedCarsRepository.Object;
        }
    }
}
