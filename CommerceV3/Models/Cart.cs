using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CommerceV3.Models
{
    public class Cart
    {public Cart()
		{
			IsActive = true;
		}
		public string Id { get; set; }
		public string Owner { get; set; }
		public virtual ICollection<CartItem> CartITems { get; set; }

		public string CreatedBy { get; set; }
		public DateTime CreatedDate { get; set; }
		public string UpdatedBy { get; set; }
		public DateTime UpdateDate { get; set; }

		public bool IsActive { get; set; }
    }
}
