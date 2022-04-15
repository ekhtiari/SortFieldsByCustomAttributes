namespace SortFieldsByCustomAttributes
{
    public class Model
    {
        [CustomAttribut("group1")]
        public string Field1 { get; set; }
        [CustomAttribut("group2")]
        public string Field2 { get; set; }
        [CustomAttribut("group1")]
        public string Field3 { get; set; }
        [CustomAttribut("group3")]
        public string Field4 { get; set; }
        [CustomAttribut("group3")]
        public string Field5 { get; set; }
    }
}