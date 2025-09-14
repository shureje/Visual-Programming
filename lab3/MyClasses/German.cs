using System.Dynamic;

namespace MyClasses
{
    public class German : Language
    {
        private static char[] chars = {'a','b','c','d','e','f','g','h','i','j','k','l','m','n','o','p','q','r','s','t','u','v','w','x','y','z','ä','ö','ü','ß'};

        public German() : base(chars) { }
        public override string Hello() => "Hallo";
    }
}