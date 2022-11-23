using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaoInvestigation
{
    internal class UserDaoException : Exception
    {
        public UserDaoException(string message)
            :base(message)
        {

        }
    }
}
