--------------Q1-------------------

1
2 2
3 3 3
4 4 4 4
5 5 5 5 5

==========================================
using System;

class pattern{
static void Main(){


Console.Write("Enter Rows : ");
int r = Convert.ToInt32(Console.ReadLine());

for(int i=1; i<=r; i++){
 for(int j=1; j<=i; j++){
   Console.Write($"{i} ");
}
Console.WriteLine();

}
}
}


o/p - 
Enter Rows : 5
1
2 2
3 3 3
4 4 4 4
5 5 5 5 5


---------------------Q2-------------------------------
  
using System;

class pattern{
static void Main(){


Console.Write("Enter Rows : ");
int r = Convert.ToInt32(Console.ReadLine());

for(int i=r; i>=1; i--){
 for(int j=1; j<=i; j++){
   Console.Write($"{j} ");
}
Console.WriteLine();

}
}
}

================================================
o/p-
Enter Rows : 5
1 2 3 4 5
1 2 3 4
1 2 3
1 2
1


--------------------------Q3---------------------------------------------------
  
using System;

class pattern{
static void Main(){


Console.Write("Enter Rows : ");
int r = Convert.ToInt32(Console.ReadLine());

for(int i=r; i>=1; i--){
 for(int j=1; j<=i; j++){
   Console.Write($"{i} ");
}
Console.WriteLine();

}
}
}

====================================================
o/p-
Enter Rows : 5
5 5 5 5 5
4 4 4 4
3 3 3
2 2
1



--------------------------Q4---------------------------------
  using System;

class Pattern
{
    static void Main()
    {
        Console.Write("Enter Rows: ");
        int r = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i <= r; i++)
        {
            for (int j = 1; j <= r + i - 1; j++)
            {
                if (j <= r - i)
                {
                    Console.Write(" ");                 
 }
                else
                {
                    Console.Write($"{i} ");                 
 }
            }
            Console.WriteLine(); 

        }
    }
}

==============================================================

Enter Rows: 5
    1
   2 2 2
  3 3 3 3 3
 4 4 4 4 4 4 4
5 5 5 5 5 5 5 5 5


