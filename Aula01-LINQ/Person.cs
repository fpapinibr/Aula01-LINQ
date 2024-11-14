using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula01_LINQ
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Telephone { get; set; }
        public int Age { get; set; }

        //public override string? ToString()
        //{
        //    return $"Id: {Id}, Name: {Name} Age: {Age}, Telephone: {Telephone}";
        //}

        public override string ToString() => 
            $"Id: {Id}, Name: {Name} Age: {Age}, Telephone: {Telephone}";

    }
}
