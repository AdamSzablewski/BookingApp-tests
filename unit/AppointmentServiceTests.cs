namespace BookingApp.Tests;
public class AppointmentServiceTests
{
    [Fact]
    public void AppointmentOverlapsTest_startAndEndBeforeApp_ReturnsFalse()
    {
        Appointment appointment = new(){
            Service = null,
            StartTime = new DateTime(2023, 4, 30, 10, 30, 0),
            EndTime = new DateTime(2023, 4, 30, 11, 00, 0),
            Customer = null,
            Employee = null
        };
        DateTime slotStartTime = new DateTime(2023, 4, 30, 12, 30, 0);
        DateTime slotEndTime = new DateTime(2023, 4, 30, 13, 00, 0);

        var appointmentRepositoryMock = new Mock<IAppointmentRepository>();
        var serviceRepositoryMock = new Mock<IServiceRepository>();
        var employeeRepositoryMock = new Mock<IEmployeeRepository>();
        var customerRepositoryMock = new Mock<ICustomerRepository>();
        var appointmentService = new AppointmentService(appointmentRepositoryMock.Object, serviceRepositoryMock.Object, employeeRepositoryMock.Object, customerRepositoryMock.Object);

        bool result = appointmentService.AppointmentOverlaps(appointment, slotStartTime, slotEndTime);

        Assert.Equal(false, result);

    }
    [Fact]
    public void AppointmentOverlapsTest_startAndEndAfterApp_ReturnsFalse()
    {
        Appointment appointment = new(){
            Service = null,
            StartTime = new DateTime(2023, 4, 30, 14, 30, 0),
            EndTime = new DateTime(2023, 4, 30, 15, 00, 0),
            Customer = null,
            Employee = null
        };
        DateTime slotStartTime = new DateTime(2023, 4, 30, 12, 30, 0);
        DateTime slotEndTime = new DateTime(2023, 4, 30, 13, 00, 0);

        var appointmentRepositoryMock = new Mock<IAppointmentRepository>();
        var serviceRepositoryMock = new Mock<IServiceRepository>();
        var employeeRepositoryMock = new Mock<IEmployeeRepository>();
        var customerRepositoryMock = new Mock<ICustomerRepository>();
        var appointmentService = new AppointmentService(appointmentRepositoryMock.Object, serviceRepositoryMock.Object, employeeRepositoryMock.Object, customerRepositoryMock.Object);

        bool result = appointmentService.AppointmentOverlaps(appointment, slotStartTime, slotEndTime);

        Assert.Equal(false, result);

    }
    [Fact]
    public void AppointmentOverlapsTest_startAndEndRightAfterApp_ReturnsFalse()
    {
        Appointment appointment = new(){
            Service = null,
            StartTime = new DateTime(2023, 4, 30, 13, 00, 0),
            EndTime = new DateTime(2023, 4, 30, 14, 00, 0),
            Customer = null,
            Employee = null
        };
        DateTime slotStartTime = new DateTime(2023, 4, 30, 12, 30, 0);
        DateTime slotEndTime = new DateTime(2023, 4, 30, 13, 00, 0);

        var appointmentRepositoryMock = new Mock<IAppointmentRepository>();
        var serviceRepositoryMock = new Mock<IServiceRepository>();
        var employeeRepositoryMock = new Mock<IEmployeeRepository>();
        var customerRepositoryMock = new Mock<ICustomerRepository>();
        var appointmentService = new AppointmentService(appointmentRepositoryMock.Object, serviceRepositoryMock.Object, employeeRepositoryMock.Object, customerRepositoryMock.Object);

        bool result = appointmentService.AppointmentOverlaps(appointment, slotStartTime, slotEndTime);

        Assert.Equal(false, result);

    }
    [Fact]
    public void AppointmentOverlapsTest_startAndEndRightBeforeApp_ReturnsFalse()
    {
        Appointment appointment = new(){
            Service = null,
            StartTime = new DateTime(2023, 4, 30, 11, 00, 0),
            EndTime = new DateTime(2023, 4, 30, 12, 30, 0),
            Customer = null,
            Employee = null
        };
        DateTime slotStartTime = new DateTime(2023, 4, 30, 12, 30, 0);
        DateTime slotEndTime = new DateTime(2023, 4, 30, 13, 00, 0);

        var appointmentRepositoryMock = new Mock<IAppointmentRepository>();
        var serviceRepositoryMock = new Mock<IServiceRepository>();
        var employeeRepositoryMock = new Mock<IEmployeeRepository>();
        var customerRepositoryMock = new Mock<ICustomerRepository>();
        var appointmentService = new AppointmentService(appointmentRepositoryMock.Object, serviceRepositoryMock.Object, employeeRepositoryMock.Object, customerRepositoryMock.Object);

        bool result = appointmentService.AppointmentOverlaps(appointment, slotStartTime, slotEndTime);

        Assert.Equal(false, result);
    }
    [Fact]
    public void AppointmentOverlapsTest_startBefAppEndDuringApp_ReturnsTrue()
    {
        Appointment appointment = new(){
            Service = null,
            StartTime = new DateTime(2023, 4, 30, 11, 00, 0),
            EndTime = new DateTime(2023, 4, 30, 12, 30, 0),
            Customer = null,
            Employee = null
        };
        DateTime slotStartTime = new DateTime(2023, 4, 30, 11, 30, 0);
        DateTime slotEndTime = new DateTime(2023, 4, 30, 13, 00, 0);

        var appointmentRepositoryMock = new Mock<IAppointmentRepository>();
        var serviceRepositoryMock = new Mock<IServiceRepository>();
        var employeeRepositoryMock = new Mock<IEmployeeRepository>();
        var customerRepositoryMock = new Mock<ICustomerRepository>();
        var appointmentService = new AppointmentService(appointmentRepositoryMock.Object, serviceRepositoryMock.Object, employeeRepositoryMock.Object, customerRepositoryMock.Object);

        bool result = appointmentService.AppointmentOverlaps(appointment, slotStartTime, slotEndTime);

        Assert.Equal(true, result);
    }
    [Fact]
    public void AppointmentOverlapsTest_startDuringAppEndDuringApp_ReturnsTrue()
    {
        Appointment appointment = new(){
            Service = null,
            StartTime = new DateTime(2023, 4, 30, 12, 00, 0),
            EndTime = new DateTime(2023, 4, 30, 12, 30, 0),
            Customer = null,
            Employee = null
        };
        DateTime slotStartTime = new DateTime(2023, 4, 30, 11, 30, 0);
        DateTime slotEndTime = new DateTime(2023, 4, 30, 13, 00, 0);

        var appointmentRepositoryMock = new Mock<IAppointmentRepository>();
        var serviceRepositoryMock = new Mock<IServiceRepository>();
        var employeeRepositoryMock = new Mock<IEmployeeRepository>();
        var customerRepositoryMock = new Mock<ICustomerRepository>();
        var appointmentService = new AppointmentService(appointmentRepositoryMock.Object, serviceRepositoryMock.Object, employeeRepositoryMock.Object, customerRepositoryMock.Object);

        bool result = appointmentService.AppointmentOverlaps(appointment, slotStartTime, slotEndTime);

        Assert.Equal(true, result);
    }
    [Fact]
    public void AppointmentOverlapsTest_startDuringAppEndAfterApp_ReturnsTrue()
    {
        Appointment appointment = new(){
            Service = null,
            StartTime = new DateTime(2023, 4, 30, 12, 00, 0),
            EndTime = new DateTime(2023, 4, 30, 14, 30, 0),
            Customer = null,
            Employee = null
        };
        DateTime slotStartTime = new DateTime(2023, 4, 30, 11, 30, 0);
        DateTime slotEndTime = new DateTime(2023, 4, 30, 13, 00, 0);

        var appointmentRepositoryMock = new Mock<IAppointmentRepository>();
        var serviceRepositoryMock = new Mock<IServiceRepository>();
        var employeeRepositoryMock = new Mock<IEmployeeRepository>();
        var customerRepositoryMock = new Mock<ICustomerRepository>();
        var appointmentService = new AppointmentService(appointmentRepositoryMock.Object, serviceRepositoryMock.Object, employeeRepositoryMock.Object, customerRepositoryMock.Object);

        bool result = appointmentService.AppointmentOverlaps(appointment, slotStartTime, slotEndTime);

        Assert.Equal(true, result);
    }
}