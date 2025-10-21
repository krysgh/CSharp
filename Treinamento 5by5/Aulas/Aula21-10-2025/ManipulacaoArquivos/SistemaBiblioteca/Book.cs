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
        public string GetAuthor() {  return this.Author; }
        public string GetCategory() {  return this.Category; }


        public void SetTitle(string title) { this.Title= title; }
        public void SetAuthor(string author) { this.Author= author; }
        public void SetCategory(string category) {  this.Category= category;}


        public override string ToString()
        {
            return $"{this.Title}|{this.Author}|{this.Category}";
        }
    
    }
}
