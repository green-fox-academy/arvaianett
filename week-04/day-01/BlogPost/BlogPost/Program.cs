using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogPost
{
    class Program
    {
        static void Main(string[] args)
        {
            BlogPost first = new BlogPost();

            first.AuthorName = "John Doe";
            first.Title = "Lorem Ipsum";
            first.Text = "Lorem ipsum dolor sit amet.";
            first.PublicationDate = "2000.05.04.";

            BlogPost second = new BlogPost();

            second.AuthorName = "Tim Urban";
            second.Title = "Wait but why";
            second.Text = "A popular long-form, stick-figure-illustrated blog about almost everything.";
            second.PublicationDate = "2010.10.10.";

            BlogPost third = new BlogPost();

            third.AuthorName = "William Turton";
            third.Title = "One Engineer Is Trying to Get IBM to Reckon With Trump";
            third.Text = "Daniel Hanley, a cybersecurity engineer at IBM, doesn’t want to be the center of attention. When I asked to take his picture outside one of IBM’s New York City offices, he told me that he wasn’t really into the whole organizer profile thing.";
            third.PublicationDate = "2017.03.28.";
        }
    }
}
