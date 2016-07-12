using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Client;
using Microsoft.Xrm.Sdk.Discovery;
using System.ServiceModel.Description;

namespace Dynamics_CRM_Metadata_to_Constants.Utility
{
	public class Core2011
	{
		private OrganizationServiceProxy _serviceProxy;

		public OrganizationServiceProxy Service
		{
			get
			{
				return _serviceProxy;
			}
			set { _serviceProxy = value; }
		}

		public void login(string discoveryServiceAddress, string orgName, string username, string password, string domain)
		{
			IServiceManagement<IDiscoveryService> serviceManagement =
						ServiceConfigurationFactory.CreateManagement<IDiscoveryService>(
						new Uri(discoveryServiceAddress));
			AuthenticationProviderType endpointType = serviceManagement.AuthenticationType;

			// Set the credentials.
			AuthenticationCredentials authCredentials = GetCredentials(endpointType, username, password, domain);

			String organizationUri = String.Empty;
			// Get the discovery service proxy.
			using (DiscoveryServiceProxy discoveryProxy = GetProxy<IDiscoveryService, DiscoveryServiceProxy>(serviceManagement, authCredentials))
			{
				// Obtain organization information from the Discovery service. 
				if (discoveryProxy != null)
				{
					// Obtain information about the organizations that the system user belongs to.
					OrganizationDetailCollection orgs = DiscoverOrganizations(discoveryProxy);
					// Obtains the Web address (Uri) of the target organization.
					organizationUri = FindOrganization(orgName,
						orgs.ToArray()).Endpoints[EndpointType.OrganizationService];

				}
			}


			if (!String.IsNullOrWhiteSpace(organizationUri))
			{
				IServiceManagement<IOrganizationService> orgServiceManagement =
					ServiceConfigurationFactory.CreateManagement<IOrganizationService>(
					new Uri(organizationUri));

				// Set the credentials.
				AuthenticationCredentials credentials = GetCredentials(endpointType, username, password, domain);

				// Get the organization service proxy.
				using (OrganizationServiceProxy organizationProxy =
					GetProxy<IOrganizationService, OrganizationServiceProxy>(orgServiceManagement, credentials))
				{
					// This statement is required to enable early-bound type support.
					organizationProxy.EnableProxyTypes();

					this.Service = organizationProxy;
				}


			}

		}
		public AuthenticationCredentials GetCredentials(AuthenticationProviderType endpointType, string username, string password, string domain)
		{

			AuthenticationCredentials authCredentials = new AuthenticationCredentials();
			switch (endpointType)
			{
				case AuthenticationProviderType.ActiveDirectory:
					authCredentials.ClientCredentials.Windows.ClientCredential =
						new System.Net.NetworkCredential(username,
							password,
							domain);
					break;
				case AuthenticationProviderType.LiveId:
					authCredentials.ClientCredentials.UserName.UserName = username;
					authCredentials.ClientCredentials.UserName.Password = password;
					authCredentials.SupportingCredentials = new AuthenticationCredentials();
					//authCredentials.SupportingCredentials.ClientCredentials =
					//	Microsoft.Crm.Services.Utility.DeviceIdManager.LoadOrRegisterDevice();
					break;
				default: // For Federated and OnlineFederated environments.                    
					authCredentials.ClientCredentials.UserName.UserName = username;
					authCredentials.ClientCredentials.UserName.Password = password;
					// For OnlineFederated single-sign on, you could just use current UserPrincipalName instead of passing user name and password.
					// authCredentials.UserPrincipalName = UserPrincipal.Current.UserPrincipalName;  //Windows/Kerberos
					break;
			}

			return authCredentials;
		}
		public OrganizationDetailCollection DiscoverOrganizations(IDiscoveryService service)
		{
			if (service == null) throw new ArgumentNullException("service");
			RetrieveOrganizationsRequest orgRequest = new RetrieveOrganizationsRequest();
			RetrieveOrganizationsResponse orgResponse =
				(RetrieveOrganizationsResponse)service.Execute(orgRequest);

			return orgResponse.Details;
		}

		public OrganizationDetail FindOrganization(string orgUniqueName, OrganizationDetail[] orgDetails)
		{
			if (String.IsNullOrWhiteSpace(orgUniqueName))
				throw new ArgumentNullException("missing");
			if (orgDetails == null)
				throw new ArgumentNullException("missing");
			OrganizationDetail orgDetail = null;

			foreach (OrganizationDetail detail in orgDetails)
			{
				if (String.Compare(detail.UniqueName, orgUniqueName,
					StringComparison.InvariantCultureIgnoreCase) == 0)
				{
					orgDetail = detail;
					break;
				}
			}
			return orgDetail;
		}

		private TProxy GetProxy<TService, TProxy>(IServiceManagement<TService> serviceManagement, AuthenticationCredentials authCredentials)
			where TService : class
			where TProxy : ServiceProxy<TService>
		{
			Type classType = typeof(TProxy);

			if (serviceManagement.AuthenticationType != AuthenticationProviderType.ActiveDirectory)
			{
				AuthenticationCredentials tokenCredentials = serviceManagement.Authenticate(authCredentials);

				// Obtain discovery/organization service proxy for Federated, LiveId and OnlineFederated environments. 
				// Instantiate a new class of type using the 2 parameter constructor of type IServiceManagement and SecurityTokenResponse.
				return (TProxy)classType
					.GetConstructor(new Type[] { typeof(IServiceManagement<TService>), typeof(SecurityTokenResponse) })
					.Invoke(new object[] { serviceManagement, tokenCredentials.SecurityTokenResponse });
			}

			// Obtain discovery/organization service proxy for ActiveDirectory environment.
			// Instantiate a new class of type using the 2 parameter constructor of type IServiceManagement and ClientCredentials.
			return (TProxy)classType
				.GetConstructor(new Type[] { typeof(IServiceManagement<TService>), typeof(ClientCredentials) })
				.Invoke(new object[] { serviceManagement, authCredentials.ClientCredentials });
		}


	}
}
