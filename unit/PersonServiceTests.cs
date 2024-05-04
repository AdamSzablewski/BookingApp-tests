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
    [Fact]
    public async Task DeletePerson_ValidId_ReturnTrue()
    {
        string userId = "uid";
            Person person = new(){
                FirstName = "Adam",
                LastName = "SZ"
            };
        var mockPersonRepository = new Mock<IPersonRepository>();
        mockPersonRepository.Setup(repo => repo.GetByIdAsync(userId))
                .ReturnsAsync(person);
        mockPersonRepository.Setup(repo => repo.DeleteAsync(person))
                .ReturnsAsync(true);
        var service = new PersonService(mockPersonRepository.Object);

        bool result = await service.DeletePerson(userId);

        Assert.Equal(true, result);
    }
    [Fact]
    public async Task DeletePerson_UserNotFound_ThrowException()
    {
        string userId = "uid";
            Person person = new(){
                FirstName = "Adam",
                LastName = "SZ"
            };
        var mockPersonRepository = new Mock<IPersonRepository>();
        mockPersonRepository.Setup(repo => repo.GetByIdAsync(userId))
                .ReturnsAsync(()=> null);
        var service = new PersonService(mockPersonRepository.Object);

        await Assert.ThrowsAsync<UserNotFoundException>(async ()=> await service.DeletePerson(userId));
    }
    [Fact]
    public async Task UpdatePerson_CorrectPersonUpdateDto_ReturnDto()
    {
        string userId = "uid";
        Adress adress = new(){
            Country = "BeforeCountry",
            City = "BeforeCity"
        };
        Person person = new(){
                FirstName = "BeforeFirst",
                LastName = "BeforeLast",
                Email = "BeforeEmail",
                PhoneNumber = "BeforeNumber",
                Adress = adress

        };
        PersonUpdateDto personUpdateDto = new(){
                FirstName = "AfterFirst",
                LastName = "AfterLast",
                Email = "AfterEmail",
                PhoneNumber = "AfterNumber",
                Country = "AfterCountry",
                City = "AfterCity"
        };
        var mockPersonRepository = new Mock<IPersonRepository>();
        var service = new PersonService(mockPersonRepository.Object);
        mockPersonRepository.Setup(repo => repo.GetByIdAsync(userId))
                .ReturnsAsync(person);

        PersonDto result = await service.UpdatePerson(personUpdateDto, userId);

        Assert.Equal(person.FirstName, personUpdateDto.FirstName);
        Assert.Equal(person.LastName, personUpdateDto.LastName);
        Assert.Equal(person.Email, personUpdateDto.Email);
        Assert.Equal(person.PhoneNumber, personUpdateDto.PhoneNumber);
        Assert.Equal(person.Adress.Country, personUpdateDto.Country);
        Assert.Equal(person.Adress.City, personUpdateDto.City);







    }
}