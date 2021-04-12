using System;
using System.Linq;

public class FinalProject
{
  public static void Main(string[] args)
  {
    Console.WriteLine("Welcome to try out the set program!");
    Console.WriteLine("Let's start by creating 1-5 sets!");
    Console.WriteLine("How many sets do you want to create?");
    int amount = Convert.ToInt32(Console.ReadLine());

    if (amount < 1 || amount > 5)
    {
      Console.WriteLine("The amount of sets needs to be between 1-5!");
    }

    else if (amount > 0 || amount < 6)
    {
      Console.WriteLine("You'll create " + amount + " sets!");
      Console.WriteLine("");
      Console.WriteLine("How many objects should the sets contain?");
      int length = Convert.ToInt32(Console.ReadLine());
      string[] strings1 = new string[length];
      string[] strings2 = new string[length];
      string[] strings3 = new string[length];
      string[] strings4 = new string[length];
      string[] strings5 = new string[length];

      //These integers counts the objects of the set, the program doesn't count empty strings as part of the set! 
      int length1 = 0;
      int length2 = 0;
      int length3 = 0;
      int length4 = 0;
      int length5 = 0;
      Console.WriteLine("");

      Console.WriteLine("Now you will add " + length + " objects to your " + amount + " sets. If you don't want a set to contain " + length + " objects leave the command empty.");

      if (amount >= 1 && amount < 6)
      {
        Console.WriteLine("Add " + length + " objects to your first set:");
        for (int i = 0; i < strings1.Length; i++)
        {
          strings1[i] = Console.ReadLine();
        }
        Console.WriteLine("");
      }
      if (amount >= 2 && amount < 6)
      {
        Console.WriteLine("Add " + length + " objects to your second set:");
        for (int i = 0; i < strings2.Length; i++)
        {
          strings2[i] = Console.ReadLine();
        }
        Console.WriteLine("");
      }
      if (amount >= 3 && amount < 6)
      {
        Console.WriteLine("Add " + length + " objects to your third set:");
        for (int i = 0; i < strings3.Length; i++)
        {
          strings3[i] = Console.ReadLine();
        }
        Console.WriteLine("");
      }
      if (amount >= 4 && amount < 6)
      {
        Console.WriteLine("Add " + length + " objects to your fourth set:");
        for (int i = 0; i < strings4.Length; i++)
        {
          strings4[i] = Console.ReadLine();
        }
        Console.WriteLine("");
      }
      if (amount == 5 && amount < 6)
      {
        Console.WriteLine("Add " + length + " objects to your fifth set:");
        for (int i = 0; i < strings5.Length; i++)
        {
          strings5[i] = Console.ReadLine();
        }
        Console.WriteLine("");
      }

      //counts the non-null values in the arrays
      for (int i = 0; i < strings1.Length; i++)
      {
        if (strings1[i] != "")
        {
          length1 += 1;
        }
      }
      for (int i = 0; i < strings2.Length; i++)
      {
        if (strings2[i] != "")
        {
          length2 += 1;
        }
      }
      for (int i = 0; i < strings3.Length; i++)
      {
        if (strings3[i] != "")
        {
          length3 += 1;
        }
      }
      for (int i = 0; i < strings4.Length; i++)
      {
        if (strings4[i] != "")
        {
          length4 += 1;
        }
      }
      for (int i = 0; i < strings5.Length; i++)
      {
        if (strings5[i] != "")
        {
          length5 += 1;
        }
      }

      while (true)
      {
        Console.WriteLine("What do you want to do next?\n 1. Perform operations. \n 2. Print sets and their information. \n 3. Exit program.");

        int userinput = Convert.ToInt32(Console.ReadLine());

        if (userinput == 1)
        {
          Console.WriteLine("What operation do you want to use?\n 1. Union \n 2. Intersection \n 3. Difference \n 4. Complement");
          int operation = Convert.ToInt32(Console.ReadLine());

          if (operation == 1)
          {
            string[] operations1 = strings1.Concat(strings2).Concat(strings3).Concat(strings4).Concat(strings5).ToArray();
            string[] unique = operations1.Distinct().ToArray();
            Console.WriteLine("The union of the sets contains these elements:");
            foreach (string s in unique)
            {
              Console.Write(s + " ");
            }
            Console.WriteLine();
          }

          if (operation == 2)
          {
            if (amount == 2)
            {
              string[] operations2 = strings1.Intersect(strings2).ToArray();
              Console.WriteLine("The intersection of the sets contains these elements:");
              foreach (string s in operations2)
              {
                Console.Write(s + " ");
              }
            }
            if (amount == 3)
            {
              string[] operations2 = strings1.Intersect(strings2).ToArray();
              string[] op = operations2.Intersect(strings3).ToArray();
              Console.WriteLine("The intersection of the sets contains these elements:");
              foreach (string s in op)
              {
                Console.Write(s + " ");
              }
            }
            if (amount == 4)
            {
              string[] operations2 = strings1.Intersect(strings2).ToArray();
              string[] op = operations2.Intersect(strings3).ToArray();
              string[] ope = op.Intersect(strings4).ToArray();
              Console.WriteLine("The intersection of the sets contains these elements:");
              foreach (string s in ope)
              {
                Console.Write(s + " ");
              }
            }
            if (amount == 5)
            {
              string[] operations2 = strings1.Intersect(strings2).ToArray();
              string[] op = operations2.Intersect(strings3).ToArray();
              string[] ope = op.Intersect(strings4).ToArray();
              string[] final = ope.Intersect(strings5).ToArray();
              Console.WriteLine("The intersection of the sets contains these elements:");
              foreach (string s in final)
              {
                Console.Write(s + " ");
              }
            }
            Console.WriteLine();
          }

          if (operation == 3)
          {
            Console.WriteLine("What set do you want to use? Choose between 1 and " + amount + "!");
            int usedSet = Convert.ToInt32(Console.ReadLine());

            if (usedSet > amount)
            {
              Console.WriteLine("Must choose valid set! Please use a number between 1 and " + amount + "!");
            }
            if (usedSet == 1)
            {
              string[] compared = strings2.Concat(strings3).Concat(strings4).Concat(strings5).ToArray();
              string[] compare = compared.Distinct().ToArray();
              string[] comp = strings1.Except(compare).ToArray();
              Console.WriteLine("The difference is:");
              foreach (string s in comp)
              {
                Console.Write(s + " ");
              }
              Console.WriteLine();
            }

            if (usedSet == 2 && usedSet <= amount)
            {
              string[] compared = strings1.Concat(strings3).Concat(strings4).Concat(strings5).ToArray();
              string[] compare = compared.Distinct().ToArray();
              string[] comp = strings2.Except(compare).ToArray();
              Console.WriteLine("The difference is:");
              foreach (string s in comp)
              {
                Console.Write(s + " ");
              }
              Console.WriteLine();
            }

            if (usedSet == 3 && usedSet <= amount)
            {
              string[] compared = strings1.Concat(strings2).Concat(strings4).Concat(strings5).ToArray();
              string[] compare = compared.Distinct().ToArray();
              string[] comp = strings3.Except(compare).ToArray();
              Console.WriteLine("The difference is:");
              foreach (string s in comp)
              {
                Console.Write(s + " ");
              }
              Console.WriteLine();
            }

            if (usedSet == 4 && usedSet <= amount)
            {
              string[] compared = strings1.Concat(strings2).Concat(strings3).Concat(strings5).ToArray();
              string[] compare = compared.Distinct().ToArray();
              string[] comp = strings4.Except(compare).ToArray();
              Console.WriteLine("The difference is:");
              foreach (string s in comp)
              {
                Console.Write(s + " ");
              }
              Console.WriteLine();
            }

            if (usedSet == 5 && usedSet <= amount)
            {
              string[] compared = strings1.Concat(strings2).Concat(strings3).Concat(strings4).ToArray();
              string[] compare = compared.Distinct().ToArray();
              string[] comp = strings5.Except(compare).ToArray();
              Console.WriteLine("The difference is:");
              foreach (string s in comp)
              {
                Console.Write(s + " ");
              }
              Console.WriteLine();
            }
          }

          if (operation == 4)
          {
            Console.WriteLine("What set do you want to use? Choose between 1 and " + amount + "!");
            int usedSet = Convert.ToInt32(Console.ReadLine());

            if (usedSet > amount)
            {
              Console.WriteLine("Must choose valid set! Please use a number between 1 and " + amount + "!");
            }

            if (usedSet == 1)
            {
              string[] compared = strings2.Concat(strings3).Concat(strings4).Concat(strings5).ToArray();
              string[] compare = compared.Distinct().ToArray();
              string[] comp = compare.Except(strings1).ToArray();
              Console.WriteLine("The complement of the set is:");
              foreach (string s in comp)
              {
                Console.Write(s + " ");
              }
              Console.WriteLine();
            }

            if (usedSet == 2 && usedSet <= amount)
            {
              string[] compared = strings1.Concat(strings3).Concat(strings4).Concat(strings5).ToArray();
              string[] compare = compared.Distinct().ToArray();
              string[] comp = compare.Except(strings2).ToArray();
              Console.WriteLine("The complement of the set is:");
              foreach (string s in comp)
              {
                Console.Write(s + " ");
              }
              Console.WriteLine();
            }

            if (usedSet == 3 && usedSet <= amount)
            {
              string[] compared = strings1.Concat(strings2).Concat(strings4).Concat(strings5).ToArray();
              string[] compare = compared.Distinct().ToArray();
              string[] comp = compare.Except(strings3).ToArray();
              Console.WriteLine("The complement of the set is:");
              foreach (string s in comp)
              {
                Console.Write(s + " ");
              }
              Console.WriteLine();
            }

            if (usedSet == 4 && usedSet <= amount)
            {
              string[] compared = strings1.Concat(strings2).Concat(strings3).Concat(strings5).ToArray();
              string[] compare = compared.Distinct().ToArray();
              string[] comp = compare.Except(strings4).ToArray();
              Console.WriteLine("The complement of the set is:");
              foreach (string s in comp)
              {
                Console.Write(s + " ");
              }
              Console.WriteLine();
            }

            if (usedSet == 5 && usedSet <= amount)
            {
              string[] compared = strings1.Concat(strings2).Concat(strings3).Concat(strings4).ToArray();
              string[] compare = compared.Distinct().ToArray();
              string[] comp = compare.Except(strings5).ToArray();
              Console.WriteLine("The complement of the set is:");
              foreach (string s in comp)
              {
                Console.Write(s + " ");
              }
              Console.WriteLine();
            }
          }
        }

        else if (userinput == 2)
        {
          if (amount >= 1)
          {
            Console.WriteLine("The first set contain: " + length1 + " objects!");
            for (int i = 0; i < strings1.Length; i++)
            {
              if (strings1[i] != "")
              {
                Console.WriteLine(strings1[i]);
              }
            }
            Console.WriteLine("");
          }
          if (amount >= 2)
          {
            Console.WriteLine("The second set contain: " + length2 + " objects!");
            for (int i = 0; i < strings2.Length; i++)
            {
              if (strings2[i] != "")
              {
                Console.WriteLine(strings2[i]);
              }
            }
            Console.WriteLine("");
          }
          if (amount >= 3)
          {
            Console.WriteLine("The third set contain: " + length3 + " objects!");
            for (int i = 0; i < strings3.Length; i++)
            {
              if (strings3[i] != "")
              {
                Console.WriteLine(strings3[i]);
              }
            }
            Console.WriteLine("");
          }
          if (amount >= 4)
          {
            Console.WriteLine("The fourth set contain: " + length4 + " objects!");
            for (int i = 0; i < strings4.Length; i++)
            {
              if (strings4[i] != "")
              {
                Console.WriteLine(strings4[i]);
              }
            }
            Console.WriteLine("");
          }
          else if (amount >= 5)
          {
            Console.WriteLine("The fifth set contain: " + length5 + " objects!");
            for (int i = 0; i < strings5.Length; i++)
            {
              if (strings5[i] != "")
              {
                Console.WriteLine(strings5[i]);
              }
            }
          }
        }

        else if (userinput == 3)
        {
          Console.WriteLine("Thank you for trying the program!");
          break;
        }
      }
    }
  }
}
