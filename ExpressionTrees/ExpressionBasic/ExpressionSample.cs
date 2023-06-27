using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace ExpressionTrees.ExpressionBasic
{
    public class ExpressionSample
    {
        private Func<Person, bool> CheckPersonAge;// = person => person.Age > 12;
        private Action<Person> PrintPersonDetails;// = person => Console.WriteLine(person.ToString());

        private Expression<Func<Person,bool>> CheckPersonAgeExpression= person => person.Age > 12;
        private Expression<Action<Person>> PrintPersonDetailsExpression= person => Console.WriteLine(person.ToString());


        public void Execute()
        {
            CheckPersonAge = CheckPersonAgeExpression.Compile();
            PrintPersonDetails = PrintPersonDetailsExpression.Compile();

            var persons=new Person[]
            {
                new Person()
                {
                    FullName = "milad",
                    NationalCode="123",
                    Age=11
                },
                new Person()
                {
                    FullName = "ali",
                    NationalCode="1203",
                    Age=16
                },
                new Person()
                {
                    FullName = "ahmad",
                    NationalCode="1023",
                    Age=21
                }
            };

            foreach (var person in persons)
            {
                if (CheckPersonAge(person))
                {
                    PrintPersonDetails(person);
                }
            }
        }
    }
}
