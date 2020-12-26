using System;
namespace OOP3
{
    public class BrokenLine : CPoint
    {
        public BrokenLine(int A1, int R1, int A3, int R3) : base(A1, R1, A3,  R3)
        {
            throw new System.NotImplementedException();
        }

        ~BrokenLine()
        {
            throw new System.NotImplementedException();
        }

        public static void Funktion()
        {
            CPoint.Input();
            CGraphicsObject figure = new CPoint(CPoint.a, CPoint.a1, CPoint.b, CPoint.b1);
            figure.Info();
        }
    }
}