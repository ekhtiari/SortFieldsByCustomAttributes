namespace SortFieldsByCustomAttributes
{
    public class CustomAttribut:System.Attribute
    {
        public string _name;

        public CustomAttribut(string name)
        {
            _name = name;
        }
    }
}