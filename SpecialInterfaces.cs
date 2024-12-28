using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Advanced_Programming
{
    public class SpecialInterfaces
    {

        public int x = 10;

        public string y { get; set; } = "Hello";

        public void Printxandy()
        {
            Console.WriteLine(x);
            Console.WriteLine(y);
        }
       public class AgeComperer : IComparer<Persons>
        {
            public int Compare(Persons? x, Persons? y)
            {
                return x!.Age.CompareTo(y!.Age);
            }
        }





        public class Persons : IComparable<Persons>, ICloneable, IEquatable<Persons> ,IEnumerable<Persons>
        {
           
            public string Name { get; set; }
            public int Age { get; set; }

            public object Clone()
            {
                return this.MemberwiseClone();
            }

            public int CompareTo(Persons? other)
            {
                return Age.CompareTo(other!.Age);
            }

            public bool Equals(Persons? other)
            {
                return Name == other!.Name && Age == other!.Age; 
            }

            public IEnumerator<Persons> GetEnumerator()
            {
                throw new NotImplementedException();
            }

            IEnumerator IEnumerable.GetEnumerator()
            {
                throw new NotImplementedException();
            }
        }
    }
}
