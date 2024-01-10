using ConAppTwo;

List<Employee> employees = new List<Employee>()
{
    new Employee() { Id=1, Name="Vijay", Designation= "Developer", DOJ = new DateTime(day:12, month:11, year:2022)},
    new Employee() { Id=2, Name="Niraj", Designation= "Tester", DOJ = new DateTime(day:11, month:10, year:2021)},
    new Employee() { Id=3, Name="Vipul", Designation= "Manager", DOJ = new DateTime(day:10, month:01, year:2020)},
    new Employee() { Id=4, Name="Gagan", Designation= "Developer", DOJ = new DateTime(day:15, month:05, year:2024)},
    new Employee() { Id=5, Name="Simi", Designation= "Manager", DOJ = new DateTime(day:18, month:12, year:2023)},
    new Employee() { Id=6, Name="Ritesh", Designation= "Developer", DOJ = new DateTime(day:16, month:06, year:2019)},
};

Console.WriteLine("Id \t \t Name \t \t Description \t \t Date of Joining");
Console.WriteLine("===========================================================================");
foreach (Employee emp in employees)
{
    Console.Write(emp.Id + "\t \t");
    Console.Write(emp.Name + "\t \t");
    Console.Write(emp.Designation + "\t \t");
    Console.Write(emp.DOJ.ToLongDateString());
    Console.WriteLine("\n");

}