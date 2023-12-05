using System;
using System.Collections.Generic;

namespace MemoryAllocation2
{
    internal class Program
    {
        public delegate void TestDelegate();
        public delegate bool TestBoolDelegate(int i);

        private static TestDelegate _testDelegate;
        private static TestBoolDelegate _testBoolDelegateFunction;

        public delegate int DelegateOps(int a, int b);

        private static DelegateOps _delegateOps;

        public static void Main(string[] args)
        {
            // _testDelegate = MyTestDelegateFunc;
            // _testDelegate += MySecondTestDelegateFunc;
            // _testDelegate();
            // List <Object> del = new List<Object>();
            DelegateOps[] delegations = new DelegateOps[]
            {
                Add,
                Sous,
                Mul
            };

            foreach (var operation in delegations)
            {
                int result = operation(5, 6);
                Console.WriteLine(result);
            }
        }

        private static void MyTestDelegateFunc()
        {
            Console.WriteLine("My first Test Delegate Function");
        }
        
        private static void MySecondTestDelegateFunc()
        {
            Console.WriteLine("MySecondTestDelegateFunc");
        }

        private static bool MyTestBoolDelegateFunc(int i)
        {
            return i < 5;
        }
        
        private static int Add(int a, int b)
        {
            return a + b;
        }
        private static int Mul(int a, int b)
        {
            return a * b;
        }
        private static int Sous(int a, int b)
        {
            return a - b;
        }
        
    }
}