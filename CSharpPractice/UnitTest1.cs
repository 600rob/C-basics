using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics;

namespace CSharpPractice
{
    [TestClass]
    public class PracticeTests
    {
        //how many times does this loop iterate
        [TestMethod]
        public void LoopQuiz1()
        {
            int x = 0;

            while (x < 1)
            {
                x++;
            }
        }

        //what is the output written by trace.writeline after execution completes
        [TestMethod]
        public void LoopQuiz2()
        {
            int x = 0;
            while (x < 1)
            {
                Trace.WriteLine(x);
                x++;
            }

        }

        //how many times does this loop iterate?
        [TestMethod]

        public void LoopQuiz3()
        {
            int x = 1;
            while (x < 1)
            {
                Trace.WriteLine(x);
                x++;
            }


        }

        //how many times does this loop iterate?
        [TestMethod]

        public void LoopQuiz4()
        {
            int x = 1;
            while (true)
            {
                Trace.WriteLine(x);
                x++;
            }


        }

        //how many times does this loop iterate?
        [TestMethod]

        public void LoopQuiz5()
        {
            int x = 1;
            while (!true)
            {
                Trace.WriteLine(x);
                x++;
            }



        }

        // wrtie something that will output numbers 1-10 in sequenction ascending order
        [TestMethod]

        public void LoopQuiz6()
        {
            for(int i =1; i<11; i++)
            {
                Trace.WriteLine(i);
            }
        }


        [TestMethod]

        public void addArrayNumbers()
        {

            int total = 0;
            int[] a = { 2, 4, 6, 8, 10 };

            for (int i = 0; i < a.Length; i++)
            {
                total += a[i];
              }
            Trace.WriteLine(total);
        }





    }
}
    