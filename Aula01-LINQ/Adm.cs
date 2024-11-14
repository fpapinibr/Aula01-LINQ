using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Aula01_LINQ
{
    public class Adm
    {
        public static List<Person> LoadData()
        {
            var people = new List<Person>();
            people.Add(new Person() { Id = 1, Name = "Joana", Age = 18, Telephone = "190" });
            people.Add(new Person() { Id = 2, Name = "Joao", Age = 13, Telephone = "911" });
            people.Add(new Person() { Id = 3, Name = "Mario", Age = 51, Telephone = "193" });
            people.Add(new Person() { Id = 4, Name = "Maria", Age = 50, Telephone = "197" });
            return people;
        }
        public static void PrintData(List<Person> people)
        {
            foreach (var p in people)
            {
                Console.WriteLine(p.ToString());
            }
        }
        //Retornar dados do resultado do filtro aplicado: Maiores de 18 anos
        public static List<Person> FilterByAge(List<Person> people)
        {
            List<Person> result = new List<Person>();
            foreach (var p in people)
            {
                if (p.Age >= 18)
                {
                    result.Add(p);
                }
            }
            return result;
        }

        //public static List<Person> FilterByAgeUseLinq(List<Person> people)
        //{
        //    return people.Where(p => p.Age >= 18).ToList();
        //}

        public static List<Person> FilterByAgeUseLinq(List<Person> people) => people.Where(p => p.Age >= 18).ToList();

        //Retornar Pessoas que o nome iniciam com a Letra A
        public static List<Person> FilterByNameStartWith(List<Person> people, char letter)
        {
            var result = new List<Person>();
            foreach (var p in people)
            {
                if (p.Name.StartsWith(letter))
                {
                    result.Add(p);
                }
            }
            return result;
        }

        public static List<Person> OrderByName(List<Person> people)
        {
            return people.OrderBy(p => p.Name).ToList();
        }
    }
}
