namespace BookingApp.Tests;

public class ReviewServiceTest
{
    [Fact]
    public async Task GetActiveReviewsForUserTest_shouldReturnEmptyList()
    {
        string userId = "userId";
        var reviewRepositoryMock = new Mock<IReviewRepository>();
        reviewRepositoryMock.Setup(repo => repo.GetActiveForUser(userId))
            .ReturnsAsync(new List<Review>(0));
        var facilityRepositoryMock = new Mock<IFacilityRepository>();
        var reviewService = new ReviewService(reviewRepositoryMock.Object, facilityRepositoryMock.Object);

        List<Review> result = await reviewService.GetActiveReviewsForUser(userId);

        Assert.Equal(0, result.Count);

    }
    [Fact]
    public async Task GetActiveReviewsForUserTest_shouldReturnOneInList()
    {
        string userId = "userId";
        Review review = new()
        {
            Id = 0
        };
        var reviewRepositoryMock = new Mock<IReviewRepository>();
        reviewRepositoryMock.Setup(repo => repo.GetActiveForUser(userId))
            .ReturnsAsync(new List<Review>{ review});
        var facilityRepositoryMock = new Mock<IFacilityRepository>();
        var reviewService = new ReviewService(reviewRepositoryMock.Object, facilityRepositoryMock.Object);

        List<Review> result = await reviewService.GetActiveReviewsForUser(userId);

        Assert.Equal(1, result.Count);

    }
    [Fact]
    public async Task GetCompletedReviewsForUserTest_shouldReturnEmptyList()
    {
        string userId = "userId";
        var reviewRepositoryMock = new Mock<IReviewRepository>();
        reviewRepositoryMock.Setup(repo => repo.GetCompletedForUser(userId))
            .ReturnsAsync(new List<Review>(0));
        var facilityRepositoryMock = new Mock<IFacilityRepository>();
        var reviewService = new ReviewService(reviewRepositoryMock.Object, facilityRepositoryMock.Object);

        List<Review> result = await reviewService.GetCompletedReviewsForUser(userId);

        Assert.Equal(0, result.Count);

    }
    [Fact]
    public async Task GetCompletedReviewsForUserTest_shouldReturnOneInList()
    {
        string userId = "userId";
        Review review = new()
        {
            Id = 0
        };
        var reviewRepositoryMock = new Mock<IReviewRepository>();
        reviewRepositoryMock.Setup(repo => repo.GetCompletedForUser(userId))
            .ReturnsAsync(new List<Review>{ review});
        var facilityRepositoryMock = new Mock<IFacilityRepository>();
        var reviewService = new ReviewService(reviewRepositoryMock.Object, facilityRepositoryMock.Object);

        List<Review> result = await reviewService.GetCompletedReviewsForUser(userId);

        Assert.Equal(1, result.Count);
    }
    // [Fact]
     public async Task PostReviewTest_shouldPublishReview()
    {
        string userId = "userId";
        Review review = new()
        {
            Id = 0
        };
        ReviewCreateDto reviewCreateDto = new()
            {
                Id = 0,
                UserId = "userId",
                FacilityId = 1,
                Points = 5,
                Text = "Ok"
            };
        Facility facility = new()
        {
            Owner = null,
            Adress = null,
            Name = null,
            Id = 1,
            //Points = new Dictionary<int, int>();
        };
        
        var reviewRepositoryMock = new Mock<IReviewRepository>();
        reviewRepositoryMock.Setup(repo => repo.GetByIdAsync(reviewCreateDto.Id))
            .ReturnsAsync(review);
        var facilityRepositoryMock = new Mock<IFacilityRepository>();
        facilityRepositoryMock.Setup(repo => repo.GetByIdAsync(reviewCreateDto.FacilityId))
            .ReturnsAsync(facility);

        var reviewService = new ReviewService(reviewRepositoryMock.Object, facilityRepositoryMock.Object);

        await reviewService.PostReview(reviewCreateDto);

        Assert.Equal(facility.Points[5], 1);
    }

}