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
    [Fact]
    public void IsWithinWorkingHoursTest_startAndEndBefEmplStartTime_ReturnsFalse()
    {
      
        DateTime slotStartTime = new DateTime(2023, 4, 30, 07, 30, 0);
        DateTime slotEndTime = new DateTime(2023, 4, 30, 08, 00, 0);

        DateTime employeeStartTime = new DateTime(2023, 4, 30, 11, 00, 0);
        DateTime employeeEndTime = new DateTime(2023, 4, 30, 17, 00, 0);

        var appointmentRepositoryMock = new Mock<IAppointmentRepository>();
        var serviceRepositoryMock = new Mock<IServiceRepository>();
        var employeeRepositoryMock = new Mock<IEmployeeRepository>();
        var customerRepositoryMock = new Mock<ICustomerRepository>();
        var appointmentService = new AppointmentService(appointmentRepositoryMock.Object, serviceRepositoryMock.Object, employeeRepositoryMock.Object, customerRepositoryMock.Object);

        bool result = appointmentService.IsWithinWorkingHours(slotStartTime, slotEndTime, employeeStartTime, employeeEndTime);

        Assert.Equal(false, result);
    }
    [Fact]
    public void IsWithinWorkingHoursTest_startAndEndAftEmplStartTime_ReturnsFalse()
    {
      
        DateTime slotStartTime = new DateTime(2023, 4, 30, 18, 30, 0);
        DateTime slotEndTime = new DateTime(2023, 4, 30, 19, 00, 0);

        DateTime employeeStartTime = new DateTime(2023, 4, 30, 11, 00, 0);
        DateTime employeeEndTime = new DateTime(2023, 4, 30, 17, 00, 0);

        var appointmentRepositoryMock = new Mock<IAppointmentRepository>();
        var serviceRepositoryMock = new Mock<IServiceRepository>();
        var employeeRepositoryMock = new Mock<IEmployeeRepository>();
        var customerRepositoryMock = new Mock<ICustomerRepository>();
        var appointmentService = new AppointmentService(appointmentRepositoryMock.Object, serviceRepositoryMock.Object, employeeRepositoryMock.Object, customerRepositoryMock.Object);

        bool result = appointmentService.IsWithinWorkingHours(slotStartTime, slotEndTime, employeeStartTime, employeeEndTime);

        Assert.Equal(false, result);
    }
    [Fact]
    public void IsWithinWorkingHoursTest_startAndEndRightAftEmplStartTime_ReturnsFalse()
    {
      
        DateTime slotStartTime = new DateTime(2023, 4, 30, 17, 00, 0);
        DateTime slotEndTime = new DateTime(2023, 4, 30, 19, 00, 0);

        DateTime employeeStartTime = new DateTime(2023, 4, 30, 11, 00, 0);
        DateTime employeeEndTime = new DateTime(2023, 4, 30, 17, 00, 0);

        var appointmentRepositoryMock = new Mock<IAppointmentRepository>();
        var serviceRepositoryMock = new Mock<IServiceRepository>();
        var employeeRepositoryMock = new Mock<IEmployeeRepository>();
        var customerRepositoryMock = new Mock<ICustomerRepository>();
        var appointmentService = new AppointmentService(appointmentRepositoryMock.Object, serviceRepositoryMock.Object, employeeRepositoryMock.Object, customerRepositoryMock.Object);

        bool result = appointmentService.IsWithinWorkingHours(slotStartTime, slotEndTime, employeeStartTime, employeeEndTime);

        Assert.Equal(false, result);
    }
    [Fact]
    public void IsWithinWorkingHoursTest_startAndEndRightBefEmplStartTime_ReturnsFalse()
    {
      
        DateTime slotStartTime = new DateTime(2023, 4, 30, 10, 00, 0);
        DateTime slotEndTime = new DateTime(2023, 4, 30, 11, 00, 0);

        DateTime employeeStartTime = new DateTime(2023, 4, 30, 11, 00, 0);
        DateTime employeeEndTime = new DateTime(2023, 4, 30, 17, 00, 0);

        var appointmentRepositoryMock = new Mock<IAppointmentRepository>();
        var serviceRepositoryMock = new Mock<IServiceRepository>();
        var employeeRepositoryMock = new Mock<IEmployeeRepository>();
        var customerRepositoryMock = new Mock<ICustomerRepository>();
        var appointmentService = new AppointmentService(appointmentRepositoryMock.Object, serviceRepositoryMock.Object, employeeRepositoryMock.Object, customerRepositoryMock.Object);

        bool result = appointmentService.IsWithinWorkingHours(slotStartTime, slotEndTime, employeeStartTime, employeeEndTime);

        Assert.Equal(false, result);
    }
    [Fact]
    public void IsWithinWorkingHoursTest_startBefEmplStartEndDuringEmplTime_ReturnsFalse()
    {
      
        DateTime slotStartTime = new DateTime(2023, 4, 30, 10, 00, 0);
        DateTime slotEndTime = new DateTime(2023, 4, 30, 12, 00, 0);

        DateTime employeeStartTime = new DateTime(2023, 4, 30, 11, 00, 0);
        DateTime employeeEndTime = new DateTime(2023, 4, 30, 17, 00, 0);

        var appointmentRepositoryMock = new Mock<IAppointmentRepository>();
        var serviceRepositoryMock = new Mock<IServiceRepository>();
        var employeeRepositoryMock = new Mock<IEmployeeRepository>();
        var customerRepositoryMock = new Mock<ICustomerRepository>();
        var appointmentService = new AppointmentService(appointmentRepositoryMock.Object, serviceRepositoryMock.Object, employeeRepositoryMock.Object, customerRepositoryMock.Object);

        bool result = appointmentService.IsWithinWorkingHours(slotStartTime, slotEndTime, employeeStartTime, employeeEndTime);

        Assert.Equal(false, result);
    }
    [Fact]
    public void IsWithinWorkingHoursTest_startDuringEmplStartEndAfterEmplTime_ReturnsFalse()
    {
      
        DateTime slotStartTime = new DateTime(2023, 4, 30, 16, 00, 0);
        DateTime slotEndTime = new DateTime(2023, 4, 30, 18, 00, 0);

        DateTime employeeStartTime = new DateTime(2023, 4, 30, 11, 00, 0);
        DateTime employeeEndTime = new DateTime(2023, 4, 30, 17, 00, 0);

        var appointmentRepositoryMock = new Mock<IAppointmentRepository>();
        var serviceRepositoryMock = new Mock<IServiceRepository>();
        var employeeRepositoryMock = new Mock<IEmployeeRepository>();
        var customerRepositoryMock = new Mock<ICustomerRepository>();
        var appointmentService = new AppointmentService(appointmentRepositoryMock.Object, serviceRepositoryMock.Object, employeeRepositoryMock.Object, customerRepositoryMock.Object);

        bool result = appointmentService.IsWithinWorkingHours(slotStartTime, slotEndTime, employeeStartTime, employeeEndTime);

        Assert.Equal(false, result);
    }
    [Fact]
    public void IsWithinWorkingHoursTest_startDuringEmplStartEndDuringEmplTime_ReturnsTrue()
    {
      
        DateTime slotStartTime = new DateTime(2023, 4, 30, 12, 00, 0);
        DateTime slotEndTime = new DateTime(2023, 4, 30, 13, 00, 0);

        DateTime employeeStartTime = new DateTime(2023, 4, 30, 11, 00, 0);
        DateTime employeeEndTime = new DateTime(2023, 4, 30, 17, 00, 0);

        var appointmentRepositoryMock = new Mock<IAppointmentRepository>();
        var serviceRepositoryMock = new Mock<IServiceRepository>();
        var employeeRepositoryMock = new Mock<IEmployeeRepository>();
        var customerRepositoryMock = new Mock<ICustomerRepository>();
        var appointmentService = new AppointmentService(appointmentRepositoryMock.Object, serviceRepositoryMock.Object, employeeRepositoryMock.Object, customerRepositoryMock.Object);

        bool result = appointmentService.IsWithinWorkingHours(slotStartTime, slotEndTime, employeeStartTime, employeeEndTime);

        Assert.Equal(true, result);
    }
    [Fact]
    public void IsWithinWorkingHoursTest_startOnEmplStartEndDuringEmplTime_ReturnsTrue()
    {
      
        DateTime slotStartTime = new DateTime(2023, 4, 30, 11, 00, 0);
        DateTime slotEndTime = new DateTime(2023, 4, 30, 12, 00, 0);

        DateTime employeeStartTime = new DateTime(2023, 4, 30, 11, 00, 0);
        DateTime employeeEndTime = new DateTime(2023, 4, 30, 17, 00, 0);

        var appointmentRepositoryMock = new Mock<IAppointmentRepository>();
        var serviceRepositoryMock = new Mock<IServiceRepository>();
        var employeeRepositoryMock = new Mock<IEmployeeRepository>();
        var customerRepositoryMock = new Mock<ICustomerRepository>();
        var appointmentService = new AppointmentService(appointmentRepositoryMock.Object, serviceRepositoryMock.Object, employeeRepositoryMock.Object, customerRepositoryMock.Object);

        bool result = appointmentService.IsWithinWorkingHours(slotStartTime, slotEndTime, employeeStartTime, employeeEndTime);

        Assert.Equal(true, result);
    }
    [Fact]
    public void IsWithinWorkingHoursTest_startDuringEmplTimeEndOnEmplEndTime_ReturnsTrue()
    {
      
        DateTime slotStartTime = new DateTime(2023, 4, 30, 16, 00, 0);
        DateTime slotEndTime = new DateTime(2023, 4, 30, 17, 00, 0);

        DateTime employeeStartTime = new DateTime(2023, 4, 30, 11, 00, 0);
        DateTime employeeEndTime = new DateTime(2023, 4, 30, 17, 00, 0);

        var appointmentRepositoryMock = new Mock<IAppointmentRepository>();
        var serviceRepositoryMock = new Mock<IServiceRepository>();
        var employeeRepositoryMock = new Mock<IEmployeeRepository>();
        var customerRepositoryMock = new Mock<ICustomerRepository>();
        var appointmentService = new AppointmentService(appointmentRepositoryMock.Object, serviceRepositoryMock.Object, employeeRepositoryMock.Object, customerRepositoryMock.Object);

        bool result = appointmentService.IsWithinWorkingHours(slotStartTime, slotEndTime, employeeStartTime, employeeEndTime);

        Assert.Equal(true, result);
    }
    [Fact]
    public async void GetAvailableTimeSlotsForServiceTest_1EmplNoAppointments_ShouldReturn25()
    {
        var appointmentRepositoryMock = new Mock<IAppointmentRepository>();
        var serviceRepositoryMock = new Mock<IServiceRepository>();
        var employeeRepositoryMock = new Mock<IEmployeeRepository>();
        var customerRepositoryMock = new Mock<ICustomerRepository>();
        var appointmentService = new AppointmentService(appointmentRepositoryMock.Object, serviceRepositoryMock.Object, employeeRepositoryMock.Object, customerRepositoryMock.Object);
        Facility facility = new()
        {
            Name = "TestFacility",
            Adress = null,
            Owner = null,
            StartTime = new TimeOnly(09, 00, 00),
            EndTime = new TimeOnly(17, 00, 00)

        };
        Employee employee1 = new(){
            Id = 1,
            User = null,
            StartTime = new TimeOnly(09, 00, 00),
            EndTime = new TimeOnly(17, 00, 00)
        };
        List<Employee> employeesForService = [];
        employeesForService.Add(employee1);
        Service service = new()
        {
            Id = 1,
            Name = "TestService",
            Price = 10,
            Facility = facility,
            Employees = employeesForService,
            Length = TimeSpan.FromHours(2)
        };
        serviceRepositoryMock.Setup(repo => repo.GetByIdAsync(service.Id))
                .ReturnsAsync(service);

        List<TimeSlot> result = await appointmentService.GetAvailableTimeSlotsForService(service.Id, new DateOnly(2023, 10, 05));
        Assert.Equal(25, result.Count);
    }
    [Fact]
    public async void GetAvailableTimeSlotsForServiceTest_2EmplNoAppointments_ShouldReturn50()
    {
        var appointmentRepositoryMock = new Mock<IAppointmentRepository>();
        var serviceRepositoryMock = new Mock<IServiceRepository>();
        var employeeRepositoryMock = new Mock<IEmployeeRepository>();
        var customerRepositoryMock = new Mock<ICustomerRepository>();
        var appointmentService = new AppointmentService(appointmentRepositoryMock.Object, serviceRepositoryMock.Object, employeeRepositoryMock.Object, customerRepositoryMock.Object);
        Facility facility = new()
        {
            Name = "TestFacility",
            Adress = null,
            Owner = null,
            StartTime = new TimeOnly(09, 00, 00),
            EndTime = new TimeOnly(17, 00, 00)

        };
        Employee employee1 = new(){
            Id = 1,
            User = null,
            StartTime = new TimeOnly(09, 00, 00),
            EndTime = new TimeOnly(17, 00, 00)
        };
        Employee employee2 = new(){
            Id = 2,
            User = null,
            StartTime = new TimeOnly(09, 00, 00),
            EndTime = new TimeOnly(17, 00, 00)
        };
        List<Employee> employeesForService = [];
        employeesForService.Add(employee1);
        employeesForService.Add(employee2);
        Service service = new()
        {
            Id = 1,
            Name = "TestService",
            Price = 10,
            Facility = facility,
            Employees = employeesForService,
            Length = TimeSpan.FromHours(2)
        };
        serviceRepositoryMock.Setup(repo => repo.GetByIdAsync(service.Id))
                .ReturnsAsync(service);

        List<TimeSlot> result = await appointmentService.GetAvailableTimeSlotsForService(service.Id, new DateOnly(2023, 10, 05));
        Assert.Equal(50, result.Count);
    }
    [Fact]
    public async void GetAvailableTimeSlotsForServiceTest_1Empl1Appointment_ShouldReturn21()
    {
        var appointmentRepositoryMock = new Mock<IAppointmentRepository>();
        var serviceRepositoryMock = new Mock<IServiceRepository>();
        var employeeRepositoryMock = new Mock<IEmployeeRepository>();
        var customerRepositoryMock = new Mock<ICustomerRepository>();
        var appointmentService = new AppointmentService(appointmentRepositoryMock.Object, serviceRepositoryMock.Object, employeeRepositoryMock.Object, customerRepositoryMock.Object);
        DateOnly dateForAppointment = new DateOnly(2023, 10, 05);
        Facility facility = new()
        {
            Name = "TestFacility",
            Adress = null,
            Owner = null,
            StartTime = new TimeOnly(09, 00, 00),
            EndTime = new TimeOnly(17, 00, 00)

        };
        Appointment appointment = new()
        {
            StartTime = new DateTime(dateForAppointment.Year, dateForAppointment.Month, dateForAppointment.Day, 09, 00, 00),
            EndTime =  new DateTime(dateForAppointment.Year, dateForAppointment.Month, dateForAppointment.Day, 10, 00, 00),
            Service = null,
            Customer = null,
            Employee = null
        };
        List<Appointment> appointments = [];
        appointments.Add(appointment);
        Employee employee1 = new(){
            Id = 1,
            User = null,
            Appointments = appointments,
            StartTime = new TimeOnly(09, 00, 00),
            EndTime = new TimeOnly(17, 00, 00)
        };
       
        List<Employee> employeesForService = [];
        employeesForService.Add(employee1);
        Service service = new()
        {
            Id = 1,
            Name = "TestService",
            Price = 10,
            Facility = facility,
            Employees = employeesForService,
            Length = TimeSpan.FromHours(2)
        };
        serviceRepositoryMock.Setup(repo => repo.GetByIdAsync(service.Id))
                .ReturnsAsync(service);

        List<TimeSlot> result = await appointmentService.GetAvailableTimeSlotsForService(service.Id, dateForAppointment);
        Assert.Equal(21, result.Count);
    }
    [Fact]
    public async void GetAvailableTimeSlotsForServiceTest_2Empl1Appointment_ShouldReturn46()
    {
        var appointmentRepositoryMock = new Mock<IAppointmentRepository>();
        var serviceRepositoryMock = new Mock<IServiceRepository>();
        var employeeRepositoryMock = new Mock<IEmployeeRepository>();
        var customerRepositoryMock = new Mock<ICustomerRepository>();
        var appointmentService = new AppointmentService(appointmentRepositoryMock.Object, serviceRepositoryMock.Object, employeeRepositoryMock.Object, customerRepositoryMock.Object);
        DateOnly dateForAppointment = new DateOnly(2023, 10, 05);
        Facility facility = new()
        {
            Name = "TestFacility",
            Adress = null,
            Owner = null,
            StartTime = new TimeOnly(09, 00, 00),
            EndTime = new TimeOnly(17, 00, 00)

        };
        Appointment appointment = new()
        {
            StartTime = new DateTime(dateForAppointment.Year, dateForAppointment.Month, dateForAppointment.Day, 09, 00, 00),
            EndTime =  new DateTime(dateForAppointment.Year, dateForAppointment.Month, dateForAppointment.Day, 10, 00, 00),
            Service = null,
            Customer = null,
            Employee = null
        };
        List<Appointment> appointments1 = [];
        List<Appointment> appointments2 = [];
        appointments1.Add(appointment);
        Employee employee1 = new(){
            Id = 1,
            User = null,
            Appointments = appointments1,
            StartTime = new TimeOnly(09, 00, 00),
            EndTime = new TimeOnly(17, 00, 00)
        };
        Employee employee2 = new(){
            Id = 2,
            User = null,
            Appointments = appointments2,
            StartTime = new TimeOnly(09, 00, 00),
            EndTime = new TimeOnly(17, 00, 00)
        };
       
        List<Employee> employeesForService = [];
        employeesForService.Add(employee1);
        employeesForService.Add(employee2);
        Service service = new()
        {
            Id = 1,
            Name = "TestService",
            Price = 10,
            Facility = facility,
            Employees = employeesForService,
            Length = TimeSpan.FromHours(2)
        };
        serviceRepositoryMock.Setup(repo => repo.GetByIdAsync(service.Id))
                .ReturnsAsync(service);

        List<TimeSlot> result = await appointmentService.GetAvailableTimeSlotsForService(service.Id, dateForAppointment);
        Assert.Equal(46, result.Count);
    }
    [Fact]
    public async void GetAvailableTimeSlotsForServiceTest_2Empl2Appointments_ShouldReturn27()
    {
        var appointmentRepositoryMock = new Mock<IAppointmentRepository>();
        var serviceRepositoryMock = new Mock<IServiceRepository>();
        var employeeRepositoryMock = new Mock<IEmployeeRepository>();
        var customerRepositoryMock = new Mock<ICustomerRepository>();
        var appointmentService = new AppointmentService(appointmentRepositoryMock.Object, serviceRepositoryMock.Object, employeeRepositoryMock.Object, customerRepositoryMock.Object);
        DateOnly dateForAppointment = new DateOnly(2023, 10, 05);
        Facility facility = new()
        {
            Name = "TestFacility",
            Adress = null,
            Owner = null,
            StartTime = new TimeOnly(09, 00, 00),
            EndTime = new TimeOnly(17, 00, 00)

        };
        Appointment appointment1 = new()
        {
            StartTime = new DateTime(dateForAppointment.Year, dateForAppointment.Month, dateForAppointment.Day, 09, 00, 00),
            EndTime =  new DateTime(dateForAppointment.Year, dateForAppointment.Month, dateForAppointment.Day, 11, 00, 00),
            Service = null,
            Customer = null,
            Employee = null
        };
        Appointment appointment2 = new()
        {
            StartTime = new DateTime(dateForAppointment.Year, dateForAppointment.Month, dateForAppointment.Day, 11, 00, 00),
            EndTime =  new DateTime(dateForAppointment.Year, dateForAppointment.Month, dateForAppointment.Day, 13, 00, 00),
            Service = null,
            Customer = null,
            Employee = null
        };
        List<Appointment> appointments1 = [];
        List<Appointment> appointments2 = [];
        appointments1.Add(appointment1);
        appointments2.Add(appointment2);

        Employee employee1 = new(){
            Id = 1,
            User = null,
            Appointments = appointments1,
            StartTime = new TimeOnly(09, 00, 00),
            EndTime = new TimeOnly(17, 00, 00)
        };
        Employee employee2 = new(){
            Id = 2,
            User = null,
            Appointments = appointments2,
            StartTime = new TimeOnly(09, 00, 00),
            EndTime = new TimeOnly(17, 00, 00)
        };
       
        List<Employee> employeesForService = [];
        employeesForService.Add(employee1);
        employeesForService.Add(employee2);
        Service service = new()
        {
            Id = 1,
            Name = "TestService",
            Price = 10,
            Facility = facility,
            Employees = employeesForService,
            Length = TimeSpan.FromHours(2)
        };
        serviceRepositoryMock.Setup(repo => repo.GetByIdAsync(service.Id))
                .ReturnsAsync(service);

        List<TimeSlot> result = await appointmentService.GetAvailableTimeSlotsForService(service.Id, dateForAppointment);
        Assert.Equal(27, result.Count);
    }
    
    [Fact]
    public async void GetAvailableTimeSlotsForServiceTest_0Employees_ShouldReturn0Slots()
    {
        var appointmentRepositoryMock = new Mock<IAppointmentRepository>();
        var serviceRepositoryMock = new Mock<IServiceRepository>();
        var employeeRepositoryMock = new Mock<IEmployeeRepository>();
        var customerRepositoryMock = new Mock<ICustomerRepository>();
        var appointmentService = new AppointmentService(appointmentRepositoryMock.Object, serviceRepositoryMock.Object, employeeRepositoryMock.Object, customerRepositoryMock.Object);
        DateOnly dateForAppointment = new DateOnly(2023, 10, 05);
        Facility facility = new()
        {
            Name = "TestFacility",
            Adress = null,
            Owner = null,
            StartTime = new TimeOnly(09, 00, 00),
            EndTime = new TimeOnly(17, 00, 00)

        };
    
        List<Employee> employeesForService = [];
       
        serviceRepositoryMock.Setup(repo => repo.GetByIdAsync(1))
                .ReturnsAsync(() => null);

        await Assert.ThrowsAsync<ServiceNotFoundException>(async ()=> await appointmentService.GetAvailableTimeSlotsForService(1, dateForAppointment));

    }
}