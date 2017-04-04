using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Visitor.Person
{
    public class ObjectStructurePerson
    {
        private IList<Person> elements = new List<Person>();

        public void Attach(Person element)
        {
            elements.Add(element);
        }

        public void Detach(Person element)
        {
            elements.Add(element);
        }

        public void Display(Aaction visitor)
        {
            foreach (Person item in elements)
            {
                item.Accept(visitor);
            }
        }
    }
}
