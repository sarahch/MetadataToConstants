using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using System.Xml.Linq;

using System.Text.RegularExpressions;

namespace Dynamics_CRM_Metadata_to_Constants
{
	public partial class frmMain : Form
	{
		public frmMain()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			//btnGo_Click(sender, e);
		}

		private void btnGo_Click(object sender, EventArgs e)
		{
			// Find the file in the target folder
			string xmlFile = txtSourceFolder.Text;

			// D:\Temp\MetadatatoConstants_1_0_0_0\customizations.xml
				
			XDocument importExportXml = XDocument.Load(xmlFile);

			try
			{
				// Get the list of entities from the customizations.xml
				var entities = from entity in importExportXml.Descendants("Entity")
							   select new CrmEntity
							   {
								   Name = entity.Element("Name").Value,
								   ObjectTypeCode = Convert.ToInt32(entity.Element("ObjectTypeCode").Value),
								   Fields = (from attr in entity.Descendants("attributes").Elements("attribute") 
											 select new CrmEntityAttribute
											{
												DisplayName = attr.Attribute("PhysicalName").Value,
												Name = attr.Element("Name").Value,
												Type = attr.Element("Type").Value,
												OptionSetName = (attr.Element("optionset") != null) ? attr.Element("optionset").Attribute("Name").Value : string.Empty
											 }).ToList()
							   };

				// Status updates
				lblCountOfEntities.Text = entities.Count().ToString();
				int entityCount = 0;
				lblEntitesProcessed.Text = entityCount.ToString();

				// Step thru each of the entities and create a file for it
				foreach (var entity in entities)
				{
					lblStatusEntity.Text = entity.Name;
					string lines = string.Empty;

					string namespacePrefix = txtPluginPrefix.Text;

					// Open the file and put the things we know are in every entity
					lines += Utility.FormatConstantsFile.OpenFile(namespacePrefix, entity.Name);
					lines += Utility.FormatConstantsFile.AttributeString(2, "This", entity.Name.ToLower(), "string");
					lines += Utility.FormatConstantsFile.AttributeString(2, "ObjectTypeCode", entity.ObjectTypeCode.ToString(), "int");
					lines += Utility.FormatConstantsFile.BlankLine(2);
					lines += Utility.FormatConstantsFile.Comment(2, "Attributes");

					// Put the attributes into the file
					foreach (var attr in entity.Fields)
					{
						lines += Utility.FormatConstantsFile.AttributeString(2, attr.DisplayName, attr.Name, attr.Type);

						// if it's a picklist, then get the option values
						if (attr.Type == Constants.FieldTypesText.Picklist)
						{
							lines += Utility.FormatConstantsFile.OptionSetItems(2, attr.DisplayName);
							lines += Utility.FormatConstantsFile.CurlyForwardBrace(2);

							// walk down the tree to the explicit optionset, since these can be global
							// Consider a future feature: Make global optionsets only once
							CrmOptionSet optionset = new CrmOptionSet();
							optionset.Options = (from xEntity in importExportXml.Descendants("Entity")
												 from attributes in xEntity.Descendants("attributes")
												 from attribute in attributes.Descendants("attribute")
												 from optionSet in attribute.Descendants("optionset")
												 from options in optionSet.Descendants("options")
												 from option in options.Descendants("option")
												 where attribute.Attribute("PhysicalName").Value == attr.DisplayName
												 where optionSet.Attribute("Name").Value == attr.OptionSetName
												 select new CrmOptionSetItem
												 {
													 OptValue = option.Attribute("value").Value // attribute at this level
													, OptLabel = option.Descendants("labels").Descendants("label").Attributes("description").FirstOrDefault().Value
												 }).ToList();

							// output each option
							if (optionset.Options != null)
								foreach (var item in optionset.Options)
								{
									lines += Utility.FormatConstantsFile.AttributeInt(3, item.OptLabel.Replace(" ", ""), item.OptValue);
								}
							lines += Utility.FormatConstantsFile.CurlyBackwardBrace(2);
							lines += Utility.FormatConstantsFile.BlankLine(2);
						}
					}

					// We're done! Close the file and write it to the location specified in the UI
					lines += Utility.FormatConstantsFile.CloseFile();

					// Make sure the path is in the format we want
					string destinationFolder = txtTargetFolder.Text.Trim();
					if (destinationFolder.Substring(destinationFolder.Length) != "\\")
						destinationFolder += "\\";

					// Create a file in the target directory, entity.Name + ".cs"
					string constantsFileName = string.Format("{0}{1}.cs", destinationFolder, entity.Name);

					if (File.Exists(constantsFileName))
					{
						File.Delete(constantsFileName);
					}

					File.WriteAllText(constantsFileName, lines);

					entityCount += 1;
					lblEntitesProcessed.Text = entityCount.ToString();

				}
				lblEntitesProcessed.Text = "All done, my friend!";
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		private void btnExit_Click(object sender, EventArgs e)
		{
			// simple - they want out, let them go
			this.Close();
		}

		#region XMLHelper
		//using System.Text.RegularExpressions; 
		public static string RemoveWhitespace(string xml)
		{
			Regex regex = new Regex(@">\s*<");
			xml = regex.Replace(xml, "><");
			return xml.Trim();
		}
		#endregion

		private void btnBrowse_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Not Yet Implemented");
		}

		private void btnValidateCRM_Click(object sender, EventArgs e)
		{
			////using Windows.Security.Authentication.Web;
			////string redirectUri = WebAuthenticationBroker.GetCurrentApplicationCallbackUri().ToString();

			//// TODO Substitute your app registration values that can be obtained after you
			//// register the app in Active Directory on the Microsoft Azure portal.
			//string clientId = "e5cf0024-a66a-4f16-85ce-99ba97a24bb2";
			//string redirectUrl = "http://localhost/SdkSample";
			
			////// Authenticate the registered application with Azure Active Directory.
			////AuthenticationContext authContext =
			////	new AuthenticationContext("https://login.windows.net/common", false);
			////AuthenticationResult result = authContext.AcquireToken(txtWebApi.Text, clientId, new
			////													   Uri(redirectUrl));
		}

	}
}
