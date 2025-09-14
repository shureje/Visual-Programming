namespace MyClasses
{
    public abstract class Language
    {
        private char[]? chars;

        public Language()
        {
        }
        public Language(char[] chars)
        {
            this.chars = chars;
        }
        virtual public string Alphabet()
        {
            if (chars == null)
            {
                return "Alphabet not set";
            }
            return string.Join(", ", chars);
        }

        public abstract string Hello();
    }
}