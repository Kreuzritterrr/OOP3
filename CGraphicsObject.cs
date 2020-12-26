using System;
namespace OOP3
{
    public abstract class CGraphicsObject
    {
        public abstract string Length();
        public void Info()
        {
            Console.WriteLine($"\nLength: {Length()}\n");
        }
    }
}