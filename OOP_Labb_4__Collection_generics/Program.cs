namespace OOP_Labb_4__Collection_generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee em1 = new Employee() {ID = 9001, Gender = "Male", Name = "Ture", Salary = 42000 };
            Employee em2 = new Employee() {ID = 9002, Gender = "Female", Name = "Hanna", Salary = 37500 };
            Employee em3 = new Employee() {ID = 9003, Gender = "Female", Name = "Jen", Salary =25000 };
            Employee em4 = new Employee() {ID = 9004, Gender = "Female", Name = "Blerina", Salary = 28000};
            Employee em5 = new Employee() {ID = 9005, Gender = "Male", Name = "Tony", Salary = 32300 };


            /////////////////////// STACK ///////////////////////
           Console.WriteLine("---------------- STACK -------------------");

            Stack<Employee> emstack = new Stack<Employee>();

            emstack.Push(em1);
            emstack.Push(em2);
            emstack.Push(em3);
            emstack.Push(em4);
            emstack.Push(em5);

            //Writes out all items and number of items in stack With peek, count stays the same
            foreach (Employee item in emstack) 
            {
                Console.WriteLine("Items left in the stack = " + emstack.Count());
                Console.WriteLine("{0} - {1} - {2} - {3} ", item.ID, item.Name, item.Gender, item.Salary);
            }
            Console.WriteLine("-----------------------------------");

            //takes away object in stack untill stack i empty. Writes out count and object thats been taken out off stack
            Console.WriteLine("Retrive using pop method ");
            do
            {
                Employee itempop = emstack.Pop();
                Console.WriteLine("{0} - {1} - {2} - {3} ", itempop.ID, itempop.Name, itempop.Gender, itempop.Salary);
                Console.WriteLine("Items left in stack = " + emstack.Count());
            }
            while (emstack.Count != 0);
                                       
            Console.WriteLine("-----------------------------------");


            emstack.Push(em1);
            emstack.Push(em2);
            emstack.Push(em3);
            emstack.Push(em4);
            emstack.Push(em5);

            //Peeks att last object and write it out two times
            Console.WriteLine("Retrive using peek method ");
            for (int i = 0; i <= 1; i++)
            {
                Employee empeek = emstack.Peek();
                Console.WriteLine("{0} - {1} - {2} - {3} ", empeek.ID, empeek.Name, empeek.Gender, empeek.Salary);
                Console.WriteLine("Items left in stack = " + emstack.Count());
            }

            Console.WriteLine("-----------------------------------");

            // Checks if stack contains a specific object and writes out result
            if (emstack.Contains(em3))
            {
                Console.WriteLine("em3 is in stack");
            }
            else
            {
                Console.WriteLine("em3 is not in stack");
            }



            /////////////////////// LIST ///////////////////////
            Console.WriteLine("---------------- LIST ----------------");
            List<Employee> emList = new List<Employee>();

            emList.Add(em1);
            emList.Add(em2);
            emList.Add(em3);
            emList.Add(em4);
            emList.Add(em5);


            //checks if List contains object em2 and writes out result
            if (emList.Contains(em2))
            {
                Console.WriteLine("em2 object exist in the list");
            }
            else
            {
                Console.WriteLine("em2 object does not exist in the list");
            }
            Console.WriteLine("-----------------------------------");

            //writes out the first object in list that meets the condition
            Employee emFind = emList.Find(e => e.Gender == "Male");
            Console.WriteLine("{0} - {1} - {2} - {3} ", emFind.ID, emFind.Name, emFind.Gender, emFind.Salary);

            Console.WriteLine("-----------------------------------");

            //Writes out all of the objects that meets the condition
            foreach (Employee emFindAll in emList.FindAll(e => e.Gender == "Male"))
            {
                Console.WriteLine("{0} - {1} - {2} - {3} ", emFindAll.ID, emFindAll.Name, emFindAll.Gender, emFindAll.Salary);
            }
            
        }
    }
}