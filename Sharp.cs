using System;
using System.Collections.Generic;
using System.Linq;

namespace CodingPractice
{
    
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Role { get; set; }
        public bool IsActive { get; set; }

        
        public User(int id, string name, string role, bool isActive)
        {
            Id = id;
            Name = name;
            Role = role;
            IsActive = isActive;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== C# Practice Application Started ===\n");

            
            List<User> userDatabase = new List<User>()
            {
                new User(1, "Alice Smith", "Admin", true),
                new User(2, "Bob Jones", "Developer", true),
                new User(3, "Charlie Brown", "Guest", false),
                new User(4, "Diana Prince", "Developer", true),
                new User(5, "Evan Wright", "Guest", true)
            };

           
            Console.WriteLine("--- All Active Users ---");
            foreach (User user in userDatabase)
            {
                if (user.IsActive)
                {
                    Console.WriteLine($"[ID: {user.Id}] {user.Name} - Role: {user.Role}");
                }
            }

            
            Console.WriteLine("\n--- Filtering Developers via LINQ ---");
            var developers = userDatabase.Where(u => u.Role == "Developer" && u.IsActive);

            foreach (var dev in developers)
            {
                Console.WriteLine($"Developer Found: {dev.Name}");
            }

            
            Console.WriteLine("\n--- Database Search Check ---");
            int targetId = 99;
            User foundUser = userDatabase.FirstOrDefault(u => u.Id == targetId);

            if (foundUser != null)
            {
                Console.WriteLine($"Found user: {foundUser.Name}");
            }
            else
            {
                Console.WriteLine($"Error: User with ID {targetId} does not exist.");
            }

            Console.WriteLine("\n=== Execution Finished ===");
        }
    }
}
