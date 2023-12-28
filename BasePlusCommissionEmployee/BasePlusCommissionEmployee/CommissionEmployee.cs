using System;
public class CommissionEmployee
{
    public string FirstName { get; }
    public string LastName { get; }
    public string SocialSecurityNumber { get; }
    private decimal grossSales;
    private decimal commissionRate;
    private decimal baseSalary;

    public CommissionEmployee(string firstName, string lastName, string socialSecurityNumber, decimal grossSales, decimal commissionRate, decimal baseSalary)
    {
        FirstName = firstName;
        LastName = lastName;
        SocialSecurityNumber = socialSecurityNumber;
        GrossSales = grossSales;
        CommissionRate = commissionRate;
        BaseSalary = baseSalary;
    }

    public decimal GrossSales
    {
        get { return grossSales; }
        set
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(value), value, $"{nameof(GrossSales)} must be >= 0");
            }
            grossSales = value;
        }
    }

    public decimal CommissionRate
    {
        get { return commissionRate; }
        set
        {
            if (value <= 0 || value >= 1)
            {
                throw new ArgumentOutOfRangeException(nameof(value), value, $"{nameof(CommissionRate)} must be > 0 and < 1");
            }
            commissionRate = value;
        }
    }

    public decimal BaseSalary
    {
        get { return baseSalary; }
        set
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(value), value, $"{nameof(BaseSalary)} must be >= 0");
            }
            baseSalary = value;
        }
    }

    public decimal Earnings() => BaseSalary + (CommissionRate * GrossSales);

    public override string ToString() =>
        $"Komisyon Çalışanı: {FirstName} {LastName}\n" +
        $"Sosyal Güvenlik Numarası: {SocialSecurityNumber}\n" +
        $"Brüt satışlar: {GrossSales:F2}\n" +
        $"Komisyon oranı: {CommissionRate:F2}\n" +
        $"Asgari ücret: {BaseSalary:F2}";

}

class Program
{
    static void main()
    {
        var employee = new CommissionEmployee("Buğra", "Özel", "594-26-4455", 100M, .20M, 500M);

        Console.WriteLine("Özellikleri ve yöntemleriyle elde edilen çalışan bilgileri: \n");
        Console.WriteLine($"Adı {employee.FirstName}");
        Console.WriteLine($"Soyadı {employee.LastName}");
        Console.WriteLine($"Sosyal Güvenlik Numarası {employee.SocialSecurityNumber}");
        Console.WriteLine($"Brüt satışlar {employee.GrossSales:F2}");
        Console.WriteLine($"Komisyon oranı {employee.CommissionRate:F2}");
        Console.WriteLine($"Kazancı {employee.Earnings():F2}");

        employee.GrossSales = 100M;
        employee.CommissionRate = .20M;

        Console.WriteLine("\nToString tarafından elde edilen güncellenmiş çalışan bilgileri:\n");
        Console.WriteLine(employee);
        Console.WriteLine($"Kazancı: {employee.Earnings():F2}");
    }
}