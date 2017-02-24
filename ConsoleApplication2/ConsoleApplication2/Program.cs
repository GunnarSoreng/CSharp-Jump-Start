using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public class Trainer
    {
        void Operate()
        {
            var dog = new Poodle();

            // Subscribe to an event:
            // (Uses '+=' to 'add to') Intellisense created the name with capital 'D' and the eventhandler placeholder code.
            dog.HasSpoken += Dog_HasSpoken;
        }

        private void Dog_HasSpoken(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }

    public partial class Dog
    {
        // Properties hold values:
        // public string Name { get; set; }


        // Backing store / Backing variable (internal variable):
        private string _name;
        public string Name
        {
            get { return _name; }
            private set {
                // Look at value
                _name = value; }
        }

        // Define an event called 'HasSpoken':
        public event EventHandler HasSpoken;

        public void Speak(string what = "bark")
        {
            // Raise an event:

            // Gammel måte å gjøre det på, brukt i kurset:
            //if (HasSpoken != null)
            //    HasSpoken(this, EventArgs.Empty);

            // Simplified version suggested by Intellisense:
            HasSpoken?.Invoke(this, EventArgs.Empty);


        }

        // Default verdier må stå sist, etter vanlige input variabler
        // Variabler med default verdier er alltid optional når du kaller metoden:
        // Dvs du kan kalle denne metoden med bare ett tall, 'Speak(3)'.
        public void Speak(int times, string what = "bark", bool sit = true)
        {
            // Todo
        }


        // Only available to be used by this class:
        private void Foo() { }

        // only this and derived class:
        protected void Bar() { }

        // only in this assembly:
        internal void Daw() { }

    }

    // Poodle inherits from Dog:
    class Poodle : Dog
    {
        void x()
        {
            Speak(2, "woof");

            // Dette er ikke gyldig da det ikke matcher en gyldig signatur ( 1 eller 3 input parametre)
            // Speak(2, true);
            // Kan da bruke 'named' input parameter:
            Speak(2, sit: true);
        }
    }
}
