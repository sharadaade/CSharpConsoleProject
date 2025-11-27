using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConsole.Concept
{
    public class Circle
    {
        double Radius = 22.3;

        public double GetRadius() // Provides only get access
        {
            return Radius;
        }

        public void SetRadius(double value) // Provides only set access
        {
            Radius = value;
        }


        // Property
        // Property is an member of class using which we can expose values associated with a class to the outside environment

        // NOTE :- We can achieve with public 
        // It doesn't make sence to write two methods GetRadius and SetRadius

        // ========================== IMP ============================
        // Benifits of property over the getter and setter method
        // 1. extra variable passing in setter method, We can overcome with property (value is predefined keyword) 
        //      => public void SetRadius(double value)
        // 2. No require double name for getter and setter
        //     => GetRadius(), SetRadius(double value)
        // 3. Conditional setter and conditional getter
        // ******************* IMP **********************************
        // 4. We can not apply condition on field normal variable



        /*
            Syntax of Property
            [<modifiers>] <Type> <Name>
            {
                [get {<statement>}] // Get accessor
                [set {<statement>}] // Set accessor
            }
        */

        double _Pi;

        public double Pi
        {
            get 
            { 
                return _Pi; 
            }
            set 
            { 
                if(value > _Pi)
                {
                    _Pi = value;
                }
            }

            /*
             if get only => get only
             if set only => set only
             if get & set => get and set both
             */
        }
    }
    internal class Properties1
    {
        static void Main(string[] args)
        {
            Circle c = new Circle();
            double r = c.GetRadius();
            c.SetRadius(33.3);
            Console.WriteLine(r);
        }
    }
}
