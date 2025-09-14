using System.Dynamic;

namespace MyClasses
{
    public class English : Language
    {
        private static char[] chars = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };


        public English() : base(chars) { }

        public override string Hello() => "Hello";
       
    }
}