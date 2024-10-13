using WebApplication3.Model;

namespace WebApplication3.Repositiory
{
    public class BookRepositiory
    {
        public List<BookModel> AllBooks()
        {
            return GetBooksDetails();
        }
        public BookModel GetBooksByID(int id)
        {
            return GetBooksDetails().Where(x => x.ID == id).FirstOrDefault();
        }
        public List<BookModel> SearchBook(string title,string author)
        {
            return GetBooksDetails().Where(x => x.Title.Contains(title)).ToList();
        }
        public List<BookModel> GetBooksDetails()
        {
            return new List<BookModel>()
            {
    new BookModel(){ID=1,Title="C#",Description="C# Languge Book",Author="Vaibhav"},
    new BookModel(){ID=2,Title="C",Description="C Languge Book",Author="Ragini"},
    new BookModel(){ID=3,Title="Java",Description="Java Languge Book",Author="Shubham"},
    new BookModel(){ID=4,Title="Angular",Description="HTML Languge Book",Author="Kiran"},
    new BookModel(){ID=5,Title="TypeScript",Description="TypeScript Languge Book",Author="Anuja"}
            };
        }

    }
}
