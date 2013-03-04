using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace sd_final
{
    public static class DB_Context
    {
        private static DataClasses1DataContext _context;

        public static DataClasses1DataContext context { get{return _context;} }

        static DB_Context()
        {
            _context = new DataClasses1DataContext();
        }
    }
}
