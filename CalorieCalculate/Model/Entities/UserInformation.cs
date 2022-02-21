using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalorieCalculate.Model.Entities
{
   public class UserInformation : BaseProperty
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public int Height { get; set; }
        public int Weight { get; set; }

        #region Navigation

        public virtual User User { get; set; }

        #endregion
    }
}
