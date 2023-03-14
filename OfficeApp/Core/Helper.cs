using OfficeApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OfficeApp.Core
{
    internal static class Helper
    {
        private static TelecommunicationsСompanyEntities _context;

        public static TelecommunicationsСompanyEntities GetContext()
        {
            if (_context == null)
            {
                _context = new TelecommunicationsСompanyEntities();
            }
            return _context;
        }
    }
}
