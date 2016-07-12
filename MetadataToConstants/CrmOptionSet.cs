using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynamics_CRM_Metadata_to_Constants
{
	public class CrmOptionSet
	{
		public string DisplayName { get; set; } // How the system needs to see it
		public string Name { get; set; } // How the system needs to see it
		public string OptionSetType { get; set; }
		public List<CrmOptionSetItem> Options { get; set; }

	}
}
