using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBiblioteca
{
    public class Book
    {

        private string Title { get; set; }
        private string Author { get; set; }
        private string Category { get; set; }

        public Book(string title,string author,string category)
        {
            this.Title = title;
            this.Author = author;
            this.Category = category;
        }

        public string GetTitle() { return this.Title; }

        public void SetTitle(string title) { this.Title= title; }

        public override string ToString()
        {
            return $"{this.Title}|{this.Author}|{this.Category}";
        }
    
    }
}
