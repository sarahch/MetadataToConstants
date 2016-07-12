using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynamics_CRM_Metadata_to_Constants
{
	public class CrmEntityAttribute
	{
		public string DisplayName { get; set; } // Used for the File Name and Intellisense
		public string Name { get; set; } // How the system needs to see it
		public string Type { get; set; }
		// picklist
		// nvarchar
		// ntext
		// float
		// int
		// primarykey
		// money
		// lookup
		// datetime
		// bit
		// image
		// uniqueidentifier
		// decimal
		// owner
		// state
		// status

		public string OptionSetName { get; set; }

		public List<CrmOptionSetItem> OptionSetItems { get; set; }
	}
}
