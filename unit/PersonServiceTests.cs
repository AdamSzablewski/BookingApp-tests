namespace BookingApp.Tests;
public class PersonServiceTests
{
    [Fact]
    public async Task GetUserDtoById_ValidId_ReturnsDto()
    {
        string userId = "validUserId";
            Person person = new(){
                FirstName = "Adam",
                LastName = "SZ"
            };
            var mockRepository = new Mock<IPersonRepository>();
            mockRepository.Setup(repo => repo.GetByIdAsync(userId))
                          .ReturnsAsync(person);
            var service = new PersonService(mockRepository.Object);

            
            PersonDto result = await service.GetUserDtoById(userId);

            
            Assert.NotNull(result);
            Assert.Equal(person.FirstName, result.FirstName);
            Assert.Equal(person.LastName, result.LastName);
            
    }
    [Fact]
    public async Task GetUserDtoById_ValidId_ThrowsUserNotFoundError()
    {
            string userId = "userId";
            var mockRepository = new Mock<IPersonRepository>();
            mockRepository.Setup(repo => repo.GetByIdAsync(userId))
                          .ReturnsAsync(() => null);
            var service = new PersonService(mockRepository.Object);
            await Assert.ThrowsAsync<UserNotFoundException>(async () => await service.GetUserDtoById(userId));   
    }
    [Fact]
    public async Task GetUserDtoByEmail_ValidId_ReturnsDto()
    {
        string mail = "mail";
            Person person = new(){
                FirstName = "Adam",
                LastName = "SZ"
            };
           
            var mockRepository = new Mock<IPersonRepository>();
            mockRepository.Setup(repo => repo.GetByEmailAsync(mail))
                          .ReturnsAsync(person);
            var service = new PersonService(mockRepository.Object);

            
            PersonDto result = await service.GetUserByEmail(mail);

            
            Assert.NotNull(result);
            Assert.Equal(person.FirstName, result.FirstName);
            Assert.Equal(person.LastName, result.LastName);
            
    }
    [Fact]
    public async Task GetUserDtoByEmail_NotValidId_ThrowsUserNotFoundError()
    {
            string userId = "userId";
            var mockRepository = new Mock<IPersonRepository>();
            mockRepository.Setup(repo => repo.GetByEmailAsync(userId))
                          .ReturnsAsync(() => null);
            var service = new PersonService(mockRepository.Object);
            await Assert.ThrowsAsync<UserNotFoundException>(async () => await service.GetUserDtoById(userId));   
    }
}