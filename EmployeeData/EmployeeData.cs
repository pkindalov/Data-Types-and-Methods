using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeData
{
    class EmployeeData
    {
        static void Main(string[] args)
        {
		
			//A marketing company wants to keep record of its employees. Each record would have the following characteristics:
			//•	First name
			//•	Last name
			//•	Age (0...100)
			//•	Gender (m or f)
			//•	Personal ID number (e.g. 8306112507)
			//•	Unique employee number (27560000…27569999)

		
            string firstName = Console.ReadLine();
            string lastName = Console.ReadLine();
            byte age = byte.Parse(Console.ReadLine());
            char gender = char.Parse(Console.ReadLine());
            long personnalID = long.Parse(Console.ReadLine());
            uint uniqueEmployeeNum = uint.Parse(Console.ReadLine());

            Console.WriteLine($"First name: {firstName}");
            Console.WriteLine($"Last name: { lastName}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Gender: {gender}");
            Console.WriteLine($"Personal ID: {personnalID}");
            Console.WriteLine($"Unique Employee number: {uniqueEmployeeNum}");

        }
    }
}
