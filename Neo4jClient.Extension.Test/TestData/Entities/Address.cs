namespace Neo4jClient.Extension.Test.Cypher
{
    public class Address
    {
        //No FK in graph land 
        //public int Id { get; set; }

        public string Street { get; set; }

        public string Suburb { get; set; }

        public override string ToString()
        {
            return string.Format("Street='{0}', Suburb='{1}'", Street, Suburb);
        }
    }
}