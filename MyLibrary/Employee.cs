namespace MyLibrary;

    public abstract class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int GetInt()
        {
            return 5;
        }
        public virtual decimal CalculateMonthPayment()
        {
            return 12000;
        }

        public int GetPaymentDays()
        {
            return 30;
        }
              
    }

public class Secretary : Employee
{
    public override decimal CalculateMonthPayment() => 15000;
    
}

public class Manager : Employee
{
    public override decimal CalculateMonthPayment()
    {
        return 30000;
    }
}

public class Developer : Employee
{
    public new int GetPaymentDays()
    {
        return 20;
    }
}