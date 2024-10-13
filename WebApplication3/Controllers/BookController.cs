using Microsoft.AspNetCore.Mvc;
using WebApplication3.Model;
using WebApplication3.Repositiory;

namespace WebApplication3.Controllers
{
    public class BookController : Controller
    {
        private readonly BookRepositiory _bookRepositiory;
        public BookController() 
        {
           _bookRepositiory=new BookRepositiory();
        } 
        public List<BookModel> AllBooks()
        {
           return _bookRepositiory.AllBooks();
        }
        public BookModel GetBooksByID(int id)
        {
            return _bookRepositiory.GetBooksByID(id);
        }
        public List<BookModel> SearchBook(string title,string author)
        {
            return _bookRepositiory.SearchBook(title,author);
        }
    }
}
