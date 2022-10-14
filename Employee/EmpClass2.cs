public class CompanyEmpWage
{
    private string companyname;
    private int empRatePerHour;
    private int numOfWorkingDays;
    private int maxHoursPerMonth;
    private int totalEmpWage;

    public CompanyEmpWage(string companyname, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonth)
    {
        this.companyname = companyname;
        this.empRatePerHour = empRatePerHour;
        this.numOfWorkingDays = numOfWorkingDays;
        this.maxHoursPerMonth = maxHoursPerMonth;
    }
    public void setTotalEmpWage(int totalEmpWage)
    { 
        this.totalEmpWage = totalEmpWage;
    }
    public string toString()
    {
        return "Total Employee Wage for Company: " + this.companyname + " is: " + this.totalEmpWage;
    }
}