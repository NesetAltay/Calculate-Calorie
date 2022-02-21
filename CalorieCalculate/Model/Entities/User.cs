using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalorieCalculate.Model.Entities
{
    public class User : BaseProperty
    {
        public string Email { get; set; }
        public string Password { get; set; }

        #region Navigation

        public virtual UserInformation UserInformation { get; set; }
        public virtual ICollection<Repast> Repasts { get; set; }

        #endregion
    }
}
