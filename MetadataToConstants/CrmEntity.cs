using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynamics_CRM_Metadata_to_Constants
{
	public class CrmEntity
	{
		public string Name { get; set; }
		public int ObjectTypeCode { get; set; }
		public List<CrmEntityAttribute> Fields { get; set; }
	}
}
