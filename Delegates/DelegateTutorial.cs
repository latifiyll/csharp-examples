using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesAndEvents
{
    class DelegateTutorial
    {
        delegate void DelegateExample(int a); //to use delegates, the method should match with method parameters

        void Start()
        {
            DelegateExample myDelegate = Bar;
            FooBar(Bar);
        }
        void FooBar(DelegateExample myDelegate)
        {
            myDelegate(50);
        }

        void Foo(int a)
        {

        }
        void Bar(int a)
        {

        }
    }
}
