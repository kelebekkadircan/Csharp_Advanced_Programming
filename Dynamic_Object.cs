using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Advanced_Programming
{
    public class Dynamic_Object : DynamicObject
    {
        public Dynamic_Object()
        {
            Console.WriteLine($"{nameof(Dynamic_Object)} instance Created");
        }
        readonly private Dictionary<string, object> properties = new();
        public override bool TrySetMember(SetMemberBinder binder, object? value)
        {
            properties.Add(binder.Name, value);
            return true;
        }

        public override bool TryGetMember(GetMemberBinder binder, out object? result)
        {
            return properties.TryGetValue(binder.Name, out result);
             
        }




    }
}
