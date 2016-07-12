namespace Dynamics_CRM_Metadata_to_Constants
{
	class Constants
	{
		public const string UnknownMimeType = "application/unknown";
		public const string Attachment = "attachment";
		public const string PartyList = "partylist";
		public const string RelatedEntity = "relatedentity";

		public class XmlInput
		{
			public const string AttributeName = "name";
			public const string AttributeAction = "action";
			public const string Bemsid = "bemsid";
			public const string Id = "id";
			public const string StateCode = "statecode";
			public const string StatusCode = "statuscode";
			public const string Timezone = "timezone";

			public class Action
			{
				public const string Create = "create";
				public const string Update = "update";
				public const string Delete = "delete";
			}
		}

		public class XmlOutput
		{
			public const string AttributeAction = "action";
			public const string Bemsid = "bemsid";
			public const string Error = "error";
			public const string ManageEntityRecords = "ManageEntityRecords";

			public class Action
			{
				public const string Created = "created";
				public const string Updated = "updated";
				public const string Deleted = "deleted";
				public const string AttachmentFailed = "failed to upload";
				public const string EntityFailed = "failed to load";
			}
		}

		public class XrmSdk
		{
			// CRM Strings
			public const string OptionSetValue = "Microsoft.Xrm.Sdk.OptionSetValue";
			public const string EntityReference = "Microsoft.Xrm.Sdk.EntityReference";
			public const string DateTime = "System.DateTime";
			public const string Guid = "System.Guid";
			public const string String = "System.Guid";
			public const string Int32 = "System.Int32";
		}

		public class FieldTypes
		{
			public const int SingleLineOfText = 100000000;
			public const int SqlNvarchar = 100000016;
			public const int MultipleLinesOfText = 100000007;
			public const int SqlNtext = 100000015;
			public const int DateTime = 100000008;
			public const int SqlDateTime = 100000011;
			public const int WholeNumber = 100000003;
			public const int SqlWholeNumber = 100000013;
			public const int FloatingPointNumber = 100000004;
			public const int DecimalNumber = 100000005;
			public const int SqlDecimal = 100000012;
			public const int Currency = 100000006;
			public const int SqlMoney = 100000014;
			public const int OptionSet = 100000001;
			public const int SqlPicklist = 100000017;
			public const int TwoOptions = 100000002;
			public const int SqlBit = 100000010;
			public const int Lookup = 100000009;
			public const int Annotation = 100000021; // Attachment
			public const int SqlPrimaryKey = 100000018;
			public const int State = 100000019;
			public const int Status = 100000020;
			public const int PartyList = 100000022;
			public const int RelatedEntity = 100000023;
		}

		public class FieldTypesText
		{
			public const string SingleLineOfText = "singlelineoftext";
			public const string SqlNvarchar = "sqlnvarchar";
			public const string MultipleLinesOfText = "multiplelinesoftext";
			public const string SqlNtext = "sqlntext";
			public const string DateTime = "datetime";
			public const string SqlDateTime = "sqldatetime";
			public const string WholeNumber = "wholenumber";
			public const string SqlWholeNumber = "sqlwholenumber";
			public const string FloatingPointNumber = "floatingpointnumber";
			public const string DecimalNumber = "decimalnumber";
			public const string SqlDecimal = "sqldecimal";
			public const string Currency = "currency";
			public const string SqlMoney = "sqlmoney";
			public const string OptionSet = "optionset";
			public const string Picklist = "picklist";
			public const string SqlPicklist = "sqlpicklist";
			public const string TwoOptions = "twooptions";
			public const string SqlBit = "sqlbit";
			public const string Lookup = "lookup";
			public const string Annotation = "annotation";
			public const string SqlPrimaryKey = "sqlprimarykey";
			public const string State = "state";
			public const string Status = "status";
			public const string PartyList = "partylist";
			public const string RelatedEntity = "relatedentity";
		}
	}

	public class MimeTypeInfo
	{
		public const string Name = "ems_name";
		public const string Extension = "ems_fileext";
		public const string MimeType = "ems_mimetype";
		public const string Id = "ems_mimetypeid";

	}

	public class AnnotationInfo
	{
		public const string Id = "annotationid";
		public const string Subject = "subject";
		public const string FileName = "filename";
		public const string FileSize = "filesize";
		public const string DocumentBody = "documentbody";
		public const string MimeType = "mimetype";
		public const string NoteText = "notetext";
		public const string Regarding = "objectid";
		public const string RegardingEntityCode = "objecttypecode";
		public const string IsDocument = "isdocument";
	}

	public class ActivityInfo
	{
		public const string Id = "activityid";
	}

	public class PartyListInfo
	{
	}

	public class RelatedEntityInfo
	{

	}
}
