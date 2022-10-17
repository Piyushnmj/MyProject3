class Program
{
   static void Main(string[] args)
    {
        EmpWageBuilder empWageBuilder = new EmpWageBuilder();
        empWageBuilder.addCompanyEmpWage("Microsoft", 100, 20, 100);
        empWageBuilder.addCompanyEmpWage("Google", 200, 30, 150);
        empWageBuilder.computeEmpWage();
        Console.WriteLine("Total wage for Microsoft: " + empWageBuilder.getTotalWage("Microsoft"));
    }
}