using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserDaoLibrary
{
    internal class UserDaoException : Exception
    {
        public UserDaoException(string message)
            :base(message)
        {

        }
    }
}
