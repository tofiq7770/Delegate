
using Delegate.Extentions;
using Delegate.Models;

namespace Delegate
{
    public class BookDelegate
    {
        public delegate bool CheckAuthor(List<Book> books);
        Authors firstAuthor = Authors.Nizami_Ganjavi;
        Authors seccondAuthor = Authors.Mirza_Fatali_Akundov;
        Authors thirdAuthor = Authors.Jafar_Jabbarli;

        public void ShowCountOfBook(List<Book> books, Predicate<Book> predicate)
        {
            int count = books.Count(book => predicate(book));
            Console.WriteLine(count);
        }


        public void Result(string authorName)
        {
            List<Book> books = new List<Book>()
            {
              new Book() {AuthorName= firstAuthor.ToString(),BookName="Bookname 1"},
              new Book() {AuthorName= seccondAuthor.ToString(),BookName="Bookname 2"},
            };
            ShowCountOfBook(books, books => books.AuthorName == authorName);
        }
    }
}
