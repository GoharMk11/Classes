/*Ստեղծիր բազային դաս Message․
● Virtual մեթոդ Print() → տպում "Generic message"
Ստեղծիր derived դասեր․
● ErrorMessage → override Print() → տպում "Error occurred!"
● SuccessMessage → override Print() → տպում "Operation successful!"
Գրիր ծրագիր, որը ստեղծում է մեկ Message փոփոխական, սկզբում պահում է ErrorMessage, 
հետո վերագրում է SuccessMessage, և յուրաքանչյուր անգամ կանչում է Print()*/

using System;
namespace Ex1
{
    public class Message
    {
        public virtual void Print()
        {
            Console.WriteLine("Generic message");
        }
    }
    public class ErrorMessage : Message
    {
        public override void Print()
        {
            Console.WriteLine("Error occurred!");
        }
    }
    public class SuccessMessage : Message
    {
        public override void Print()
        {
            Console.WriteLine("Operation successful!");
        }
    }
    class Program
    {
        static void Main()
        {
            Message msg;

            msg = new ErrorMessage();
            msg.Print();

            msg = new SuccessMessage();
            msg.Print();
        }
    }
}