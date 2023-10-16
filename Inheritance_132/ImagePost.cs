using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_132
{
    // ImagePost derives from Post class and adds a property (ImageUrl) and two constructors
    class ImagePost : Post
    {
        public string ImageURL { get; set; }

        public ImagePost() { }

        public ImagePost(string title, string author, string imageURL, bool isPublic)
        {
            this.ID = GetNextID();
            this.Title = title;
            this.Author = author;
            this.IsPublic = isPublic;

            // Property ImageURL is a member of ImagePost, but not of Post
            this.ImageURL = imageURL;
        }

        public override string ToString()
        {
            return String.Format("ID: {0} - Title: {1} - Author: {2} - Check it via this link: {3}"
                , this.ID, this.Title, this.Author, this.ImageURL);
        }
    }
}
