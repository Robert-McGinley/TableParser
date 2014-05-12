#Table Parser

Draws an IEnumerable<T> as a table like this:


````csharp

var users = new List<User>
{
    new User { },
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

var table = users.ToStringTable(
    u => u.FirstName, 
    u => u.LastName,
                
    u => u.DateTime,
    u => u.NullableDateTime,

    u => u.IntValue,
    u => u.NullableIntValue
);

Console.WriteLine(table);
````

Prints:

````
 | FirstName | LastName | DateTime                | NullableDateTime        | IntValue | NullableIntValue | 
 |--------------------------------------------------------------------------------------------------------| 
 | null      | null     | 1/01/0001 12:00:00 a.m. | null                    | 0        | null             | 
 | Jake      | Scott    | 12/05/2014 8:46:38 p.m. | 12/05/2014 8:46:38 p.m. | 99       | 999              | 
````

