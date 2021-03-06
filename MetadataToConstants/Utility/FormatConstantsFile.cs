﻿namespace Dynamics_CRM_Metadata_to_Constants.Utility
{
	public static class FormatConstantsFile
	{
		public static string NamespaceLine(string prefix)
		{
			return string.Format("namespace {0}.Constants\r\n", prefix);
		}

		public static string BlankLine(int numberOfTabs)
		{
			string line = string.Empty;
			for (int i = 0; i < numberOfTabs; i++)
			{
				line += string.Format("\t");
			}
			line += string.Format("\r\n");
			return line;
		}

		public static string CurlyForwardBrace(int numberOfTabs)
		{
			string line = string.Empty;
			for (int i = 0; i < numberOfTabs; i++)
			{
				line += string.Format("\t");
			}
			line += string.Format("{{ \r\n");
			return line;
		}

		public static string CurlyBackwardBrace(int numberOfTabs)
		{
			string line = string.Empty;
			for (int i = 0; i < numberOfTabs; i++)
			{
				line += string.Format("\t");
			}
			line += string.Format("}} \r\n");
			return line;
		}

		public static string Comment(int numberOfTabs, string comment)
		{
			string line = string.Empty;
			for (int i = 0; i < numberOfTabs; i++)
			{
				line += string.Format("\t");
			}
			line += string.Format("// {0} \r\n", comment);
			return line;
		}

		public static string AttributeString(int numberOfTabs, string attributeName, string attributeValue, string attributeType)
		{
			string line = string.Empty;
			for (int i = 0; i < numberOfTabs; i++)
			{
				line += string.Format("\t");
			}
			line += string.Format("public const string {0} = \"{1}\"; \\\\ {2} \r\n", attributeName, attributeValue, attributeType);
			return line;
		}

		public static string AttributeInt(int numberOfTabs, string attributeName, string attributeValue)
		{
			string line = string.Empty;
			for (int i = 0; i < numberOfTabs; i++)
			{
				line += string.Format("\t");
			}
			line += string.Format("public const int {0} = {1};\r\n", attributeName, attributeValue);
			return line;
		}

		public static string OptionSetItems(int numberOfTabs, string attributeName)
		{
			string line = string.Empty;
			for (int i = 0; i < numberOfTabs; i++)
			{
				line += string.Format("\t");
			}
			line += string.Format("public class {0}Item \r\n", attributeName);
			return line;
		}

		public static string OpenFile(string prefix, string entity)
		{
			string line = string.Empty;
			line += Comment(0, "**********************************************************");
			line += Comment(0, "Auto generated by IcicleGlow's Metadata to Constants tool");
			line += Comment(0, "**********************************************************");
			line += BlankLine(0);
			line += NamespaceLine(prefix);
			line += CurlyForwardBrace(0);
			line += string.Format("\tpublic static class {0}\r\n", entity);
			line += CurlyForwardBrace(1);

			return line;
		}
		public static string CloseFile()
		{
			string line = string.Empty;
			line += Utility.FormatConstantsFile.CurlyBackwardBrace(1);
			line += Utility.FormatConstantsFile.CurlyBackwardBrace(0);

			return line;
		}

	}
}
