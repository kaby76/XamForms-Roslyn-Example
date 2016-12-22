using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace App15
{
    public class Class1
    {
        public Class1()
        { }

        public static void YoDoit()
        {
            SyntaxTree tree = CSharpSyntaxTree.ParseText(@"
            public class MyClass
            {
                public void MyMethod()
                {
                }
            }");
            int x = 0/1;
        }
    }
}