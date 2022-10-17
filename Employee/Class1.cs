﻿public class EmpWageBuilder : IComputeEmpWage
{
    public const int IS_PART_TIME = 1;
    public const int IS_FULL_TIME = 2;

    private LinkedList<CompanyEmpWage> companyEmpWageList;
    private Dictionary<string, CompanyEmpWage> companyToEmpWageMap;

    public EmpWageBuilder()
    {
        this.companyEmpWageList = new LinkedList<CompanyEmpWage>();
        this.companyToEmpWageMap = new Dictionary<string, CompanyEmpWage>();
    }

    public void addCompanyEmpWage(string companyname, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonth)
    {
        CompanyEmpWage companyEmpWage = new CompanyEmpWage(companyname, empRatePerHour, numOfWorkingDays, maxHoursPerMonth);
        this.companyEmpWageList.AddLast(companyEmpWage);
        this.companyToEmpWageMap.Add(companyname, companyEmpWage);
    }

    public void computeEmpWage()
    {
        foreach (CompanyEmpWage companyEmpWage in this.companyEmpWageList)
        {
            companyEmpWage.setTotalEmpWage(this.computeEmpWage(companyEmpWage));
            Console.WriteLine(companyEmpWage.toString());
        }
    }

    private int computeEmpWage(CompanyEmpWage companyEmpWage)

    public int getTotalWage(string company)
    {
        return this.companyToEmpWageMap[companyname].totalEmpWage;
    }

    void IComputeEmpWage.getTotalWage(string companyname)
    {
        throw new NotImplementedException();
    }
}