using System;

class CommissionEmployeeTest
{
    static void Main()
    {
        var employee = new CommissionEmployee("Buğra", "Özel", "594-26-4455", 100M, .20M, 500M);
        Console.WriteLine("Özellikleri ve yöntemleriyle elde edilen çalışan bilgileri: \n");
        Console.WriteLine($"Adı {employee.FirstName}");
        Console.WriteLine($"Soyadı {employee.LastName}");
        Console.WriteLine($"Sosyal Güvenlik Numarası {employee.SocialSecurityNumber}");
        Console.WriteLine($"Brüt satışlar {employee.GrossSales:F2}");
        Console.WriteLine($"Komisyon oranı {employee.CommissionRate:F2}");
        Console.WriteLine($"Kazancı {employee.Earnings():F2}");
        Console.WriteLine($"Asgari Ücret: {employee.BaseSalary:F2}"); 
        employee.GrossSales = 100M;
        employee.CommissionRate = .20M;
        Console.WriteLine("\nToString tarafından elde edilen güncellenmiş çalışan bilgileri:\n");
        Console.WriteLine(employee);
        Console.WriteLine($"Kazancı: {employee.Earnings():F2}");
    }
}

