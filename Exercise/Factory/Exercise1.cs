using System.Reflection.Metadata.Ecma335;

namespace Design_Patterns_in_C_.Exercise.Factory
{
    public class Exercise1
    {
        public class Person
        {
            public int Id { get; set; }
            public string Name { get; set; }
        }
        public class PersonFactory
        {
            private int Id = 0;

            public Person CreatePerson(string name)
            {
                return new Person { Id = Id++, Name = name };
            }
            
        }
    }
}
