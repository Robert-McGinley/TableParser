# Table Parser

Original code by [hubeza][0] on [Stackoverflow][1]

### Basic Usage
Format an IEnumerable<T> as a table using `ToStringTable`:

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

````
 | FirstName | LastName | DateTime                | NullableDateTime        | IntValue | NullableIntValue | 
 |--------------------------------------------------------------------------------------------------------| 
 | null      | null     | 1/01/0001 12:00:00 a.m. | null                    | 0        | null             | 
 | Jake      | Scott    | 12/05/2014 8:46:38 p.m. | 12/05/2014 8:46:38 p.m. | 99       | 999              | 
````

### Custom Column Headers

````csharp
var customTable = users.ToStringTable(new[] { "First Name", "Last Name" },
    u => u.FirstName,
    u => u.LastName
);

Console.WriteLine(customTable);
````

````
 | First Name | Last Name | 
 |------------------------| 
 | null       | null      | 
 | Jake       | Scott     | 
````
### Simple List of Guids

````csharp
var guids = new List<Guid>
{
    Guid.NewGuid(), 
    Guid.NewGuid()
};

var guidTable = guids.ToStringTable(new[] {"UserId"}, g => g);
Console.WriteLine(guidTable);
````

````
 | UserId                               | 
 |--------------------------------------| 
 | c98c46f6-5e7a-421e-a71d-a47f09c4eb87 | 
 | 4522d0f0-20b2-48db-83b2-1b41952999d6 | 
```` 

[0]:http://stackoverflow.com/users/133665/hubeza
[1]:http://stackoverflow.com/a/19353995/52360


