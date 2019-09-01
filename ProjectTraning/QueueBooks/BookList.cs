using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTraning.QueueBooks
{
    class BookList
    {
        private List<Books> listOfBooks = new List<Books>()
        {
            new Books(1, "In Search of Lost Time ", "Marcel Proust"),

            new Books(2, "The Great Gatsby ", "F. Scott Fitzgerald"),

            new Books(3, "Moby Dick", "Herman Melville")
        };

        public List<Books> GetBookList()

        {

            return listOfBooks;

        }
    }
}
