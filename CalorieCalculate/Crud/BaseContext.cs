using CalorieCalculate.Model.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalorieCalculate.Crud
{
    public class BaseContext
    {
        // Singilton metot
        private static DatabaseContext _db;
        private BaseContext()
        {
            
        }
        public static DatabaseContext GetInstance()
        {
            if (_db is null)
                _db = new DatabaseContext();
            return _db;
        }
    }
}
