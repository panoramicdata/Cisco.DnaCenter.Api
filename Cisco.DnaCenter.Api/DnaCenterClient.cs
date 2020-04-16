using Cisco.DnaCenter.Api.Interfaces;
using Refit;
using System;
using System.Data;
using System.Net.Http;
using System.Threading.Tasks;

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
			// Options are valid

			_options = options;

			if (_options.HttpClient != null)
			{
				// An HttpClient was provided to us.
				_httpClient = _options.HttpClient;
			}
			else
			{
				// We are creating an HttpClient (one was not provided), so set _httpClient so that we know to dispose of it later.
				_authenticatedHttpClientHandler = new AuthenticatedHttpClientHandler(_options.Token);
				_httpClient = new HttpClient()
				{
					BaseAddress = _options.Uri
				};
				_shouldDisposeHttpClient = true;
			}

			ApplicationPoliies = RestService.For<IApplicationPolicies>(_httpClient);
			Authentication = RestService.For<IAuthentication>(_httpClient);
			Clients = RestService.For<IClients>(_httpClient);
			CommandRunner = RestService.For<ICommandRunner>(_httpClient);
			ConfigurationTemplates = RestService.For<IConfigurationTemplates>(_httpClient);
			DeviceOnboardingPnP = RestService.For<IDeviceOnboardingPnP>(_httpClient);
			Devices = RestService.For<IDevices>(_httpClient);
			EventManagement = RestService.For<IEventManagement>(_httpClient);
			Files = RestService.For<IFiles>(_httpClient);
			Issues = RestService.For<IIssues>(_httpClient);
			NetworkDiscovery = RestService.For<INetworkDiscovery>(_httpClient);
			NetworkSettings = RestService.For<INetworkSettings>(_httpClient);
			NonFabricWireless = RestService.For<INonFabricWireless>(_httpClient);
			PathTrace = RestService.For<IPathTrace>(_httpClient);
			Sda = RestService.For<ISda>(_httpClient);
			SiteDesign = RestService.For<ISiteDesign>(_httpClient);
			Sites = RestService.For<ISites>(_httpClient);
			SoftwareImageManagement = RestService.For<ISoftwareImageManagement>(_httpClient);
			Tags = RestService.For<ITags>(_httpClient);
			Tasks = RestService.For<ITasks>(_httpClient);
			Topologies = RestService.For<ITopologies>(_httpClient);
			Users = RestService.For<IUsers>(_httpClient);
		}

		public async Task ConnectAsync()
		{
			if (!_options.IsUsernamePasswordAuthenticated)
			{
				throw new InvalidOperationException("There is no need to connect.  An HttpClient or Token were already provided.");
			}

			if (_isConnected)
			{
				throw new InvalidOperationException("Already connected.");
			}

			var authenticationResponse = await Authentication
				.Authenticate("application/json", _options.GetBase64UsernamePassword())
				.ConfigureAwait(false);
			_authenticatedHttpClientHandler.Token = authenticationResponse.Token ?? throw new DataException("Api returned null Token.");
			_isConnected = true;
		}

		/// <inheritdoc />
		public IApplicationPolicies ApplicationPoliies { get; }

		/// <inheritdoc />
		public IAuthentication Authentication { get; }

		/// <inheritdoc />
		public IClients Clients { get; }

		/// <inheritdoc />
		public ICommandRunner CommandRunner { get; }

		/// <inheritdoc />
		public IConfigurationTemplates ConfigurationTemplates { get; }

		/// <inheritdoc />
		public IDeviceOnboardingPnP DeviceOnboardingPnP { get; }

		/// <inheritdoc />
		public IDevices Devices { get; }

		/// <inheritdoc />
		public IEventManagement EventManagement { get; }

		/// <inheritdoc />
		public IFiles Files { get; }

		/// <inheritdoc />
		public IIssues Issues { get; }

		/// <inheritdoc />
		public INetworkDiscovery NetworkDiscovery { get; }

		/// <inheritdoc />
		public INetworkSettings NetworkSettings { get; }

		/// <inheritdoc />
		public INonFabricWireless NonFabricWireless { get; }

		/// <inheritdoc />
		public IPathTrace PathTrace { get; }

		/// <inheritdoc />
		public ISda Sda { get; }

		/// <inheritdoc />
		public ISiteDesign SiteDesign { get; }

		/// <inheritdoc />
		public ISites Sites { get; }

		/// <inheritdoc />
		public ISoftwareImageManagement SoftwareImageManagement { get; }

		/// <inheritdoc />
		public ITags Tags { get; }

		/// <inheritdoc />
		public ITasks Tasks { get; }

		/// <inheritdoc />
		public ITopologies Topologies { get; }

		/// <inheritdoc />
		public IUsers Users { get; }

		#region IDisposable Support
		private bool _disposedValue = false; // To detect redundant calls
		private readonly AuthenticatedHttpClientHandler? _authenticatedHttpClientHandler;

		// Only set if an HttpsClient was NOT provided in the options.
		private HttpClient? _httpClient;
		private bool _isConnected;
		private readonly bool _shouldDisposeHttpClient;
		private readonly DnaCenterClientOptions _options;

		protected virtual void Dispose(bool disposing)
		{
			if (!_disposedValue)
			{
				if (disposing)
				{
					// Dispose managed state (managed objects).
					if (_shouldDisposeHttpClient)
					{
						_httpClient?.Dispose();
						_httpClient = null;
					}
				}

				// TODO: set large fields to null.

				_disposedValue = true;
			}
		}

		// This code added to correctly implement the disposable pattern.
		public void Dispose() =>
			// Do not change this code. Put cleanup code in Dispose(bool disposing) above.
			Dispose(true);// TODO: uncomment the following line if the finalizer is overridden above.// GC.SuppressFinalize(this);
		#endregion
	}
}