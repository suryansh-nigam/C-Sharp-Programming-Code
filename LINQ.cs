LINQ Query Examples in C#

LINQ stands for Language Integrated Query.

In C# 3.0 Microsoft has introduced a new language known as “LINQ” much like SQL .
 
LINQ (Language Integrated Query) is a feature in .NET that allows developers to write SQL-like queries directly in C# code to retrieve, filter, sort, and manipulate data.

Normally, different data sources require different ways of querying:

Arrays → loops(foreach , for)

Collections → foreach

Databases → SQL

XML → XPath

But LINQ brings a single, common query syntax for all these data sources.
  
LINQ has a great power of querying on any source of data, where the Data Source could be collections of objects (arrays & collections), Database or XML Source and 
 it is divided into 3 parts: 

LINQ to Objects:  
-->  Used to perform queries against the in-memory data like an Array or Collection. 
 
LINQ to XML (XLinq):  
--> Used to perform queries against an XML Source.  
 
LINQ to Databases: under this we again have 2 options like, 
-->  LINQ to SQL is used to perform queries against a Relation Database, but only Microsoft SQL Server. 
-->  LINQ to Entities is used to perform queries against any Relation Database like SQL Server, Oracle, etc.  

 Advantages of LINQ: 
-->  LINQ offers an object-based, language-integrated way to Query over data, no matter where that data came 
     from. So, through LINQ we can query Database, XML as well as Collections & Arrays.  

 -->  Compile-time syntax checking. 

 --> It allows you to Query - Collections, Arrays, and classes etc. in the native language of your application like VB 
or C# or F# with out using SQL Syntax’s. 

=> LINQ to Objects 
--------------------
This is designed to write queries against the in-memory data like an array or collection and filter or sort 

the information present under them. Syntax of the query we want to use on objects will be as following: 

      from <alias> in <array name | collection name> [<clauses>] select <alias> | new {<Column List>} 

-- LINQ-Query starts with from and ends with select. 
-- In clauses we need to use the alias name just like we use column names in SQL in case of scalar types. 
-- Clauses in LINQ are where, group by and order by. 
-- To use LINQ in your application first we need to import “System.Linq” namespace.

 
== > A relational database is a type of database that stores data in tables (rows + columns), and these tables are linked to each other using relationships.

== > An entity is any real-world object or concept about which you want to store data in a database.
 
1. orderby

 Used to sort the data in ascending or descending order.

2. IndexOf()

 Returns the index (position) of a character or substring inside a string.

3. Substring()

 Extracts a part of a string from a specific starting index.

4. Contains()

 Checks whether a string or collection contains the specified value.

--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQExamples
{
    internal class Program
    {
        
            static void Main()
            {
                string[] colors = { "Red", "Blue", "Green", "Black", "White", "Brown", "Orange", "Purple", "Yellow", "Aqua" };

                //Gets the list of all colors as is
                var coll1 = from s in colors select s;
                Console.WriteLine(String.Join(" ", coll1) + "\n");

                //Gets the list of all colors in ascending order
                var coll2 = from s in colors orderby s select s;
                Console.WriteLine(String.Join(" ", coll2) + "\n");

                //Gets the list of all colors in descending order
                var coll3 = from s in colors orderby s descending select s;
                Console.WriteLine(String.Join(" ", coll3) + "\n");

                //Gets the list of colors whose length is 5 characters
                var coll4 = from s in colors where s.Length == 5 select s;
                Console.WriteLine(String.Join(" ", coll4) + "\n");

                //Getting the list of colors whose name starts with character "B":
                var coll5 = from s in colors where s[0] == 'B' select s;
                Console.WriteLine(String.Join(" ", coll5));
                var coll6 = from s in colors where s.IndexOf("B") == 0 select s;
                Console.WriteLine(String.Join(" ", coll6));
                var coll7 = from s in colors where s.StartsWith("B") select s;
                Console.WriteLine(String.Join(" ", coll7));
                var coll8 = from s in colors where s.Substring(0, 1) == "B" select s;
                Console.WriteLine(String.Join(" ", coll8) + "\n");

                //Getting the list of colors whose name ends with character "e":
                var coll9 = from s in colors where s[s.Length - 1] == 'e' select s;
                Console.WriteLine(String.Join(" ", coll9));
                var coll10 = from s in colors where s.IndexOf("e") == s.Length - 1 select s;
                Console.WriteLine(String.Join(" ", coll10));
                var coll11 = from s in colors where s.EndsWith("e") select s;
                Console.WriteLine(String.Join(" ", coll11));
                var coll12 = from s in colors where s.Substring(s.Length - 1) == "e" select s;
                Console.WriteLine(String.Join(" ", coll12) + "\n");

                //Getting the list of colors whose name contains character "a" at 3rd place: 
                var coll13 = from s in colors where s[2] == 'a' select s;
                Console.WriteLine(String.Join(" ", coll13));
                var coll14 = from s in colors where s.IndexOf("a") == 2 select s;
                Console.WriteLine(String.Join(" ", coll14));
                var coll15 = from s in colors where s.Substring(2, 1) == "a" select s;
                Console.WriteLine(String.Join(" ", coll15) + "\n");

                //Getting the list of colors whose name contains character "O or o" in it: 
                var coll16 = from s in colors where s.Contains('O') || s.Contains('o') select s;
                Console.WriteLine(String.Join(" ", coll16));
                var coll17 = from s in colors where s.IndexOf('O') >= 0 || s.IndexOf('o') >= 0 select s;
                Console.WriteLine(String.Join(" ", coll17));
                var coll18 = from s in colors where s.ToUpper().Contains('O') select s;
                Console.WriteLine(String.Join(" ", coll18));
                var coll19 = from s in colors where s.ToLower().IndexOf('o') >= 0 select s;
                Console.WriteLine(String.Join(" ", coll19) + "\n");

                //Getting the list of colors whose name doesn’t contains character "O or o" in it: 
                var coll20 = from s in colors where s.Contains('O') == false && s.Contains('o') == false select s;
                Console.WriteLine(String.Join(" ", coll20));
                var coll21 = from s in colors where s.IndexOf('O') == -1 && s.IndexOf('o') == -1 select s;
                Console.WriteLine(String.Join(" ", coll21));
                var coll22 = from s in colors where s.ToUpper().Contains('O') == false select s;
                Console.WriteLine(String.Join(" ", coll22));
                var coll23 = from s in colors where s.ToLower().IndexOf('o') == -1 select s;
                Console.WriteLine(String.Join(" ", coll23) + "\n");
                Console.ReadLine();
            }
    }

}
