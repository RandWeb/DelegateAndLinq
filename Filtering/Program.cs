using System;
using System.Linq;
using System.Linq.Expressions;
using Collections;
using Collections.Helper;

namespace Filtering
{
    class Program
    {
        static void Main(string[] args)
        {
            FilteringTest.UseWhere();
            FilteringTest.Search("Milad","","",0);
            FilteringTest.UseOfType();
            Console.ReadLine();
        }
    }

    public class FilteringTest
    {
        public static void UseWhere()
        {
            var students = SampleCollections.Students;
            var oldStudent = students.Where(c => c.Age > 19);
            SampleCollections.WriteCollection(oldStudent);
        }
        public static void Search(string firstname, string lastname, string nationalCode, int age)
        {
            Expression<Func<Student, bool>> ageExpression = null;
            Expression<Func<Student, bool>> firstNameExpression = null;
            Expression<Func<Student, bool>> lastNameExpression = null;
            Expression<Func<Student, bool>> natinalCodeExpression = null;
            if (age > 0)
            {
                ageExpression = s => s.Age == age;
            }
            if (!string.IsNullOrEmpty(firstname))
            {
                firstNameExpression = s => s.FirstName == firstname;
            }
            if (!string.IsNullOrEmpty(lastname))
            {
                lastNameExpression = s => s.LastName == lastname;
            }
            if (!string.IsNullOrEmpty(nationalCode))
            {
                natinalCodeExpression = s => s.NationalCode == nationalCode;
            }
            var exp = ExpressionHelper.AndExpressions(ageExpression,
                firstNameExpression, lastNameExpression,
                natinalCodeExpression);

            var stus=SampleCollections.Students.Where(exp.Compile());

            SampleCollections.WriteCollection(stus);

        }
        public static void UseOfType()
        {
            var teachers = SampleCollections.Persons.OfType<Teacher>();
            SampleCollections.WriteCollection(teachers);
        }
    }
}
