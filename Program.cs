namespace ExpressionBodyMembers
{
    public class Money
    {
        private decimal value;

        public decimal Value
        {
            get => value;
            set => SetValue(value);
        }

        public Money(decimal value)
        {
            SetValue(value);
        }

        public string AsString => $"₹{value}";

        public override string ToString() => $"Your money is {AsString}";


        private void SetValue(decimal newValue)
        {
            value = newValue >= 0 ? newValue : throw new InvalidDataException("Value must be greater than Zero.");
        }
    }

    public class Program
    {
        private static void Main()
        {
            var money = new Money(10);

            Console.WriteLine(money.AsString);
            Console.WriteLine(money.ToString());
        }
    }
}
