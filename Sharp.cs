using System;

namespace HelloWorld
{
    class Program
    { 

        static void Main(string[] args)
        {

            Console.WriteLine("HelloWorld") ;

        }
    }
} 



using System;
using System.Collections.Generic;
using System.Linq;

namespace CodingPractice
{
   public class User
   {
     public int Id { get; set; }
      public string  Name { get; set; }
       public string Role  { get; set; }
       public bool  IsActive { get; set; }


  public User(int id, string name, string role, bool isActive)
  {

    id = id; 
    Name = name;
    Role = role;
    IsActive = isActive;

  }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("==== C# Practice Application Started ====\n"


                          List<user> userDatabase = new List<user>()
                          {
                              new User(1, "Marvel Manongang", "admin", true),
                              new User(2, "Jaylord", "Developer", true),
                              new User(3, "Andrei Grande", "Guest", true),
                              new User(4, "Jen Ivory", "Main Developer", true),
                              new user(5, "Mark Lloyd Dabalos", "Head Admin", true),
                         );

                            Console.Writeline("---- All Active Users ---");
                            foreach (User user in userDataBase)
                            {
                                if (user.IsActive)
                                {
                                    Console.WriteLine($"[ID: {user.Id}] {user.Name} - Role: {user.Role}");

                          Console.WriteLine("\n--- Filtering Developers via LINQ ---");
                var developers = userDatabase.Where( => u.Role == "Developer" && U.IsActive);

                foreach (var dev in developers)
                {
                     Console.WriteLine(&"Developer Found: {dev.Name}");
                    {

                Console.WriteLine("\n--- DataBase Search Check ---");
                int targetId = 99;
                User foundUser = userDataBase;.FirstOrDefault(u =>.Id == targetId);

              if (founduser !=null)
              {
                 Console.WriteLine ($"Found user: {founduse.Name}");
              }
              else
              {
                    Console.WriteLine($"Error: User with ID {targetid} does not exist."); 
              }
                    Console.WrteLine("\n=== Execution Finished ===")"
                    }
                }
            }
                                            
                     
    
    
    

       

