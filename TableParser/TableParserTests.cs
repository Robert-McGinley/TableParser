namespace TableParser
{
    using System;
    using System.Collections.Generic;
    using NUnit.Framework;

    [TestFixture]
    public class TableParserTests
    {
        private class User
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }

            public DateTime DateTime { get; set; }
            public DateTime? NullableDateTime { get; set; }

            public int IntValue { get; set; }
            public int? NullableIntValue { get; set; }
        }

        [Test]
        public void test_null_values()
        {
            var users = new List<User>
            {
                new User
                {
                    
                },
                new User
                {
                    FirstName = "Jake",
                    LastName = "Scott",
                    
                    DateTime = DateTime.UtcNow,
                    NullableDateTime = DateTime.UtcNow,

                    IntValue = 99,
                    NullableIntValue = 999
                }
            };

            var actual = users.ToStringTable(
                u => u.FirstName,
                u => u.LastName,

                u => u.DateTime,
                u => u.NullableDateTime,

                u => u.IntValue,
                u => u.NullableIntValue
            );

            Console.WriteLine(actual);
        }

        [Test]
        public void test_empty_list()
        {
            var users = new List<User>();

            var table = users.ToStringTable(
                u => u.FirstName,
                u => u.LastName,

                u => u.DateTime,
                u => u.NullableDateTime,

                u => u.IntValue,
                u => u.NullableIntValue
            );

            Console.WriteLine(table);
        }
    }
}