using efcore_test.Entity;

namespace efcore_test {
    internal class Program {
        static void Main(string[] args) {
            var myDbContext = new MyDbContext();
            var book1 = new Book();
            book1.Name = "My New Book Name";
            myDbContext.Bks.Add(book1); ;
            myDbContext.SaveChanges();

            Console.WriteLine("Save is DONE!");
            Console.ReadLine();
        }
    }
}