using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABIMS
{
    public class Contact
    {
        String name;
        String phone;
        String email;
        Int32 totalTimeWorked;

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public string Phone
        {
            get
            {
                return phone;
            }

            set
            {
                phone = value;
            }
        }

        public string Email
        {
            get
            {
                return email;
            }

            set
            {
                email = value;
            }
        }

        public int TotalTimeWorked
        {
            get
            {
                return totalTimeWorked;
            }

            set
            {
                totalTimeWorked = value;
            }
        }
    }
}
