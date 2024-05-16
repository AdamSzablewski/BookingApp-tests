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

}