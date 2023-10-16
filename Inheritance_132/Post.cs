using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Inheritance_132
{
    class Post
    {
        private static int currentPostId;

        //properties
        protected int ID { get; set; }
        protected string Title { get; set; }
        protected string Author { get; set; }
        protected bool IsPublic { get; set; }

        //Default constructor. If a derived class does not invoke a base-class
        //constructor explicitly, the default constructor is called implicitly
        public Post()
        {
            ID = 0;
            Title = "Title from default constructor";
            Author = "Legend";
            IsPublic = true;
        }

        //instance constructor that has three parameters
        public Post(string title, string author, bool isPublic)
        {
            this.ID = GetNextID();
            this.Title = title;
            this.Author = author;
            this.IsPublic = isPublic;
        }

        protected int GetNextID()
        {
            return ++currentPostId;
        }

        public void Update(string title, bool isPublic)
        {
            this.Title = title;
            this.IsPublic = isPublic;
        }

        //Virtual method overrirde of the ToString method that is inherited from System.Object
        public override string ToString()
        {
            return String.Format("ID: {0} - Title: {1} - Author: {2}", this.ID, this.Title, this.Author);
        }

    }
}
