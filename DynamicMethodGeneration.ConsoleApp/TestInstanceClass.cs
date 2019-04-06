﻿using System;
using System.Collections.Generic;

namespace DynamicMethodGeneration.ConsoleApp
{
    public class TestInstanceClass
    {
        public int PropertyWithoutArgument { get; set; }

        private Dictionary<string, string> _indexerBackingField;
        public string this[string key]
        {
            get { return _indexerBackingField[key]; }
            set { _indexerBackingField[key] = value; }
        }

        public int MethodWithManyArgsAndReturn(int a, int b, int c, int d, int e, int f)
        {
            return a * b;
        }

        public int MethodWithArgsAndReturn(int a, int b)
        {
            return a * b;
        }

        public void MethodWithArgsAndNoReturn(int a, int b)
        {
            Console.WriteLine($"Output is {a + b}");
        }

        public int MethodNoArgsHasReturn()
        {
            return 42;
        }

        public void MethodNoArgsNoReturn()
        {
            Console.WriteLine("Hello World!");
        }
    }
}
