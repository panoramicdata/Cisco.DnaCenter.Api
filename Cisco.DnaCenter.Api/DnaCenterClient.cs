using Cisco.DnaCenter.Api.Interfaces;
using Refit;
using System.Threading.Tasks;
using System;
using System.Net.Http;

namespace Cisco.DnaCenter.Api
{
	/// <summary>
	/// API client is mainly responsible for making the HTTP call to the API backend.
	/// </summary>
	public class DnaCenterClient : IDisposable
	{
		public DnaCenterClient(DnaCenterClientOptions options)
		{
			if (options is null)
			{
				throw new ArgumentNullException(nameof(options));
			}
			options.Validate();

			HttpClient client;
			if (options.HttpClient != null)
			{
				// An HttpClient was provided to us.
				client = options.HttpClient;
			}
			else
			{
				// We are creating an HttpClient (one was not provided), so set _httpClient so that we know to dispose of it later.
				_client = client = new HttpClient(new AuthenticatedHttpClientHandler(options.Scheme, options.Token))
				{
					BaseAddress = options.Uri
				};
			}

			ApplicationPolicyApiClient = RestService.For<IApplicationPolicy>(client);
			AuthenticationApiClient = RestService.For<IAuthentication>(client);
			ClientsApiClient = RestService.For<IClients>(client);
			CommandRunnerApiClient = RestService.For<ICommandRunner>(client);
			ConfigurationTemplatesApiClient = RestService.For<IConfigurationTemplates>(client);
			DeviceOnboardingPnPApiClient = RestService.For<IDeviceOnboardingPnP>(client);
			DevicesApiClient = RestService.For<IDevices>(client);
			EventManagementApiClient = RestService.For<IEventManagement>(client);
			FileApiClient = RestService.For<IFile>(client);
			IssuesApiClient = RestService.For<IIssues>(client);
			NetworkDiscoveryApiClient = RestService.For<INetworkDiscovery>(client);
			NetworkSettingsApiClient = RestService.For<INetworkSettings>(client);
			NonFabricWirelessApiClient = RestService.For<INonFabricWireless>(client);
			PathTraceApiClient = RestService.For<IPathTrace>(client);
			SDAApiClient = RestService.For<ISda>(client);
			SiteDesignApiClient = RestService.For<ISiteDesign>(client);
			SitesApiClient = RestService.For<ISites>(client);
			SoftwareImageManagementSWIMApiClient = RestService.For<ISoftwareImageManagement>(client);
			TagApiClient = RestService.For<ITag>(client);
			TaskApiClient = RestService.For<ITask>(client);
			TopologyApiClient = RestService.For<ITopology>(client);
			UsersApiClient = RestService.For<IUsers>(client);
		}

		/// <inheritdoc />
		public IApplicationPolicy ApplicationPolicyApiClient { get; }

		/// <inheritdoc />
		public IAuthentication AuthenticationApiClient { get; }

		/// <inheritdoc />
		public IClients ClientsApiClient { get; }

		/// <inheritdoc />
		public ICommandRunner CommandRunnerApiClient { get; }

		/// <inheritdoc />
		public IConfigurationTemplates ConfigurationTemplatesApiClient { get; }

		/// <inheritdoc />
		public IDeviceOnboardingPnP DeviceOnboardingPnPApiClient { get; }

		/// <inheritdoc />
		public IDevices DevicesApiClient { get; }

		/// <inheritdoc />
		public IEventManagement EventManagementApiClient { get; }

		/// <inheritdoc />
		public IFile FileApiClient { get; }

		/// <inheritdoc />
		public IIssues IssuesApiClient { get; }

		/// <inheritdoc />
		public INetworkDiscovery NetworkDiscoveryApiClient { get; }

		/// <inheritdoc />
		public INetworkSettings NetworkSettingsApiClient { get; }

		/// <inheritdoc />
		public INonFabricWireless NonFabricWirelessApiClient { get; }

		/// <inheritdoc />
		public IPathTrace PathTraceApiClient { get; }

		/// <inheritdoc />
		public ISda SDAApiClient { get; }

		/// <inheritdoc />
		public ISiteDesign SiteDesignApiClient { get; }

		/// <inheritdoc />
		public ISites SitesApiClient { get; }

		/// <inheritdoc />
		public ISoftwareImageManagement SoftwareImageManagementSWIMApiClient { get; }

		/// <inheritdoc />
		public ITag TagApiClient { get; }

		/// <inheritdoc />
		public ITask TaskApiClient { get; }

		/// <inheritdoc />
		public ITopology TopologyApiClient { get; }

		/// <inheritdoc />
		public IUsers UsersApiClient { get; }

		#region IDisposable Support
		private bool disposedValue = false; // To detect redundant calls

		// Only set if an HttpsClient was NOT provided in the options.
		private HttpClient? _client;

		protected virtual void Dispose(bool disposing)
		{
			if (!disposedValue)
			{
				if (disposing)
				{
					// Dispose managed state (managed objects).
					_client?.Dispose();
					_client = null;
				}

				// TODO: set large fields to null.

				disposedValue = true;
			}
		}

		// This code added to correctly implement the disposable pattern.
		public void Dispose() =>
			// Do not change this code. Put cleanup code in Dispose(bool disposing) above.
			Dispose(true);// TODO: uncomment the following line if the finalizer is overridden above.// GC.SuppressFinalize(this);
		#endregion
	}
}