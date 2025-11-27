namespace CSharpConsole.Concept
{
    public class Customer
    {
        int CustId;
        bool Status;
        string CName;
        double Balance;

        public Customer(int _CustId, bool _Status, string _CName, double _Balance)
        {
            this.CustId = _CustId;
            this.Status = _Status;
            this.CName = _CName;
            this.Balance = _Balance;
        }

    }

    internal class Properties2
    {
        static void Main(string[] args)
        {
            Customer obj = new Customer(101, false, "Fall", 50000.00);
            Console.WriteLine(obj);// Error
        }
    }
}
