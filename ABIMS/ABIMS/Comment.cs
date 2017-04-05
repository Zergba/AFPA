using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABIMS
{
    public class Comment
    {
        private String author;
        private DateTime date;
        private String text;

        public string Author
        {
            get
            {
                return author;
            }

            set
            {
                author = value;
            }
        }

        public DateTime Date
        {
            get
            {
                return date;
            }

            set
            {
                date = value;
            }
        }

        public string Text
        {
            get
            {
                return text;
            }

            set
            {
                text = value;
            }
        }
        public Comment(String Text)
        {
            this.Text = Text;
            this.Date = DateTime.UtcNow;
        }

        public override string ToString()
        {
            return this.Date.ToString() + " - " + this.Text;
        }
    }
}
