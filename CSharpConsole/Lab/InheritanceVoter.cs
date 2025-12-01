using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConsole.Lab
{
    internal class InheritanceVoter
    {
        public class Citizen
        {
            public string Name;
            public long AadharNumber;
            public string Address;

            public Citizen(string Name, long AadharNumber, string Address)
            {
                this.Name = Name;
                this.AadharNumber = AadharNumber;
                this.Address = Address;
            }

            public override string ToString()
            {
                return $"Name: {Name} \nAadharNumber: {AadharNumber} \nAddress: {Address}";
            }
        }

        public class Voter : Citizen
        {
            public string VoterId;
            public string PollingBooth;

            public Voter(string VoterId, string PollingBooth, string Name, long AadharNumber, string Address)
                        : base(Name, AadharNumber, Address)
            {
                this.VoterId = VoterId;
                this.PollingBooth = PollingBooth;
            }

            public override string ToString()
            {
                return base.ToString() + $"\nVoterId: {VoterId} \nPollingBooth: {PollingBooth}";
            }
        }
        static void Main(string[] args)
        {
            Voter v = new Voter("44567832", "ZP School", "Fall", 313885780829, "White City");
            Console.WriteLine(v.ToString());
        }
    }
}
