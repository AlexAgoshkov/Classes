using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Book
    {
      
        public void AddBook(string authorName, string title, string content)
        {
            _author = new Author(authorName);
            _title = new Title(title);
            _content = new Content(content);
        }
        public void Showk()
        {
            _title.Show();
            _author.Show();
            _content.Show();
        }

        private Content _content;

        private Author _author;

        private Title _title;

    }
}
