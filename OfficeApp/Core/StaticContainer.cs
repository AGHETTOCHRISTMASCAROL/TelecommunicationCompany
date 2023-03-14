using OfficeApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OfficeApp.Core
{
    internal static class StaticContainer
    {
        private static List<Service> _statementListOfServices;
        private static Building _statementBuilding;

        public static List<Service> StatementListOfServices
        {
            get { return _statementListOfServices; }
            set { _statementListOfServices = value; }
        }

        public static Building StatementBuilding
        {
            get { return _statementBuilding; }
            set { _statementBuilding = value; }
        }
    }
}
