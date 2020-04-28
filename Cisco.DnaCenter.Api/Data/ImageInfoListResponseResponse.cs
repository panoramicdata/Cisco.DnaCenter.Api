using System;
using System.Text;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Cisco.DnaCenter.Api.Data
{
	/// <summary>
	/// ImageInfoListResponseResponse
	/// </summary>
	[DataContract]
	public class ImageInfoListResponseResponse
	{
		/// <summary>
		/// Gets or Sets ImportSourceType
		/// </summary>
		[JsonConverter(typeof(StringEnumConverter))]
		public enum ImportSourceTypeEnum
		{

			/// <summary>
			/// Enum DEVICE for "DEVICE"
			/// </summary>
			[EnumMember(Value = "DEVICE")]
			DEVICE,

			/// <summary>
			/// Enum REMOTEURL for "REMOTEURL"
			/// </summary>
			[EnumMember(Value = "REMOTEURL")]
			REMOTEURL,

			/// <summary>
			/// Enum CCO for "CCO"
			/// </summary>
			[EnumMember(Value = "CCO")]
			CCO,

			/// <summary>
			/// Enum FILESYSTEM for "FILESYSTEM"
			/// </summary>
			[EnumMember(Value = "FILESYSTEM")]
			FILESYSTEM
		}

		/// <summary>
		/// Gets or Sets ImportSourceType
		/// </summary>
		[DataMember(Name = "importSourceType", EmitDefaultValue = false)]
		public ImportSourceTypeEnum? ImportSourceType { get; set; }

		/// <summary>
		/// Initializes a new instance of the <see cref="ImageInfoListResponseResponse" /> class.
		/// </summary>
		/// <param name="ApplicableDevicesForImage">ApplicableDevicesForImage.</param>
		/// <param name="ApplicationType">ApplicationType.</param>
		/// <param name="CreatedTime">CreatedTime.</param>
		/// <param name="ExtendedAttributes">ExtendedAttributes.</param>
		/// <param name="Family">Family.</param>
		/// <param name="Feature">Feature.</param>
		/// <param name="FileServiceId">FileServiceId.</param>
		/// <param name="FileSize">FileSize.</param>
		/// <param name="ImageIntegrityStatus">ImageIntegrityStatus.</param>
		/// <param name="ImageName">ImageName.</param>
		/// <param name="ImageSeries">ImageSeries.</param>
		/// <param name="ImageSource">ImageSource.</param>
		/// <param name="ImageType">ImageType.</param>
		/// <param name="ImageUuid">ImageUuid.</param>
		/// <param name="ImportSourceType">ImportSourceType.</param>
		/// <param name="IsTaggedGolden">IsTaggedGolden.</param>
		/// <param name="Md5Checksum">Md5Checksum.</param>
		/// <param name="Name">Name.</param>
		/// <param name="ProfileInfo">ProfileInfo.</param>
		/// <param name="ShaCheckSum">ShaCheckSum.</param>
		/// <param name="Vendor">Vendor.</param>
		/// <param name="_Version">_Version.</param>
		public ImageInfoListResponseResponse(List<ImageInfoListResponseApplicableDevicesForImage> ApplicableDevicesForImage = default, string? ApplicationType = default, string? CreatedTime = default, Object ExtendedAttributes = default, string? Family = default, string? Feature = default, string? FileServiceId = default, string? FileSize = default, string? ImageIntegrityStatus = default, string? ImageName = default, List<string> ImageSeries = default, string? ImageSource = default, string? ImageType = default, string? ImageUuid = default, ImportSourceTypeEnum? ImportSourceType = default, bool? IsTaggedGolden = default, string? Md5Checksum = default, string? Name = default, List<ImageInfoListResponseProfileInfo> ProfileInfo = default, string? ShaCheckSum = default, string? Vendor = default, string? _Version = default)
		{
			this.ApplicableDevicesForImage = ApplicableDevicesForImage;
			this.ApplicationType = ApplicationType;
			this.CreatedTime = CreatedTime;
			this.ExtendedAttributes = ExtendedAttributes;
			this.Family = Family;
			this.Feature = Feature;
			this.FileServiceId = FileServiceId;
			this.FileSize = FileSize;
			this.ImageIntegrityStatus = ImageIntegrityStatus;
			this.ImageName = ImageName;
			this.ImageSeries = ImageSeries;
			this.ImageSource = ImageSource;
			this.ImageType = ImageType;
			this.ImageUuid = ImageUuid;
			this.ImportSourceType = ImportSourceType;
			this.IsTaggedGolden = IsTaggedGolden;
			this.Md5Checksum = Md5Checksum;
			this.Name = Name;
			this.ProfileInfo = ProfileInfo;
			this.ShaCheckSum = ShaCheckSum;
			this.Vendor = Vendor;
			this._Version = _Version;
		}

		/// <summary>
		/// Gets or Sets ApplicableDevicesForImage
		/// </summary>
		[DataMember(Name = "applicableDevicesForImage", EmitDefaultValue = false)]
		public List<ImageInfoListResponseApplicableDevicesForImage> ApplicableDevicesForImage { get; set; }

		/// <summary>
		/// Gets or Sets ApplicationType
		/// </summary>
		[DataMember(Name = "applicationType", EmitDefaultValue = false)]
		public string? ApplicationType { get; set; }

		/// <summary>
		/// Gets or Sets CreatedTime
		/// </summary>
		[DataMember(Name = "createdTime", EmitDefaultValue = false)]
		public string? CreatedTime { get; set; }

		/// <summary>
		/// Gets or Sets ExtendedAttributes
		/// </summary>
		[DataMember(Name = "extendedAttributes", EmitDefaultValue = false)]
		public Object ExtendedAttributes { get; set; }

		/// <summary>
		/// Gets or Sets Family
		/// </summary>
		[DataMember(Name = "family", EmitDefaultValue = false)]
		public string? Family { get; set; }

		/// <summary>
		/// Gets or Sets Feature
		/// </summary>
		[DataMember(Name = "feature", EmitDefaultValue = false)]
		public string? Feature { get; set; }

		/// <summary>
		/// Gets or Sets FileServiceId
		/// </summary>
		[DataMember(Name = "fileServiceId", EmitDefaultValue = false)]
		public string? FileServiceId { get; set; }

		/// <summary>
		/// Gets or Sets FileSize
		/// </summary>
		[DataMember(Name = "fileSize", EmitDefaultValue = false)]
		public string? FileSize { get; set; }

		/// <summary>
		/// Gets or Sets ImageIntegrityStatus
		/// </summary>
		[DataMember(Name = "imageIntegrityStatus", EmitDefaultValue = false)]
		public string? ImageIntegrityStatus { get; set; }

		/// <summary>
		/// Gets or Sets ImageName
		/// </summary>
		[DataMember(Name = "imageName", EmitDefaultValue = false)]
		public string? ImageName { get; set; }

		/// <summary>
		/// Gets or Sets ImageSeries
		/// </summary>
		[DataMember(Name = "imageSeries", EmitDefaultValue = false)]
		public List<string> ImageSeries { get; set; }

		/// <summary>
		/// Gets or Sets ImageSource
		/// </summary>
		[DataMember(Name = "imageSource", EmitDefaultValue = false)]
		public string? ImageSource { get; set; }

		/// <summary>
		/// Gets or Sets ImageType
		/// </summary>
		[DataMember(Name = "imageType", EmitDefaultValue = false)]
		public string? ImageType { get; set; }

		/// <summary>
		/// Gets or Sets ImageUuid
		/// </summary>
		[DataMember(Name = "imageUuid", EmitDefaultValue = false)]
		public string? ImageUuid { get; set; }

		/// <summary>
		/// Gets or Sets IsTaggedGolden
		/// </summary>
		[DataMember(Name = "isTaggedGolden", EmitDefaultValue = false)]
		public bool? IsTaggedGolden { get; set; }

		/// <summary>
		/// Gets or Sets Md5Checksum
		/// </summary>
		[DataMember(Name = "md5Checksum", EmitDefaultValue = false)]
		public string? Md5Checksum { get; set; }

		/// <summary>
		/// Gets or Sets Name
		/// </summary>
		[DataMember(Name = "name", EmitDefaultValue = false)]
		public string? Name { get; set; }

		/// <summary>
		/// Gets or Sets ProfileInfo
		/// </summary>
		[DataMember(Name = "profileInfo", EmitDefaultValue = false)]
		public List<ImageInfoListResponseProfileInfo> ProfileInfo { get; set; }

		/// <summary>
		/// Gets or Sets ShaCheckSum
		/// </summary>
		[DataMember(Name = "shaCheckSum", EmitDefaultValue = false)]
		public string? ShaCheckSum { get; set; }

		/// <summary>
		/// Gets or Sets Vendor
		/// </summary>
		[DataMember(Name = "vendor", EmitDefaultValue = false)]
		public string? Vendor { get; set; }

		/// <summary>
		/// Gets or Sets _Version
		/// </summary>
		[DataMember(Name = "version", EmitDefaultValue = false)]
		public string? _Version { get; set; }

		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class ImageInfoListResponseResponse {\n");
			sb.Append("  ApplicableDevicesForImage: ").Append(ApplicableDevicesForImage).Append("\n");
			sb.Append("  ApplicationType: ").Append(ApplicationType).Append("\n");
			sb.Append("  CreatedTime: ").Append(CreatedTime).Append("\n");
			sb.Append("  ExtendedAttributes: ").Append(ExtendedAttributes).Append("\n");
			sb.Append("  Family: ").Append(Family).Append("\n");
			sb.Append("  Feature: ").Append(Feature).Append("\n");
			sb.Append("  FileServiceId: ").Append(FileServiceId).Append("\n");
			sb.Append("  FileSize: ").Append(FileSize).Append("\n");
			sb.Append("  ImageIntegrityStatus: ").Append(ImageIntegrityStatus).Append("\n");
			sb.Append("  ImageName: ").Append(ImageName).Append("\n");
			sb.Append("  ImageSeries: ").Append(ImageSeries).Append("\n");
			sb.Append("  ImageSource: ").Append(ImageSource).Append("\n");
			sb.Append("  ImageType: ").Append(ImageType).Append("\n");
			sb.Append("  ImageUuid: ").Append(ImageUuid).Append("\n");
			sb.Append("  ImportSourceType: ").Append(ImportSourceType).Append("\n");
			sb.Append("  IsTaggedGolden: ").Append(IsTaggedGolden).Append("\n");
			sb.Append("  Md5Checksum: ").Append(Md5Checksum).Append("\n");
			sb.Append("  Name: ").Append(Name).Append("\n");
			sb.Append("  ProfileInfo: ").Append(ProfileInfo).Append("\n");
			sb.Append("  ShaCheckSum: ").Append(ShaCheckSum).Append("\n");
			sb.Append("  Vendor: ").Append(Vendor).Append("\n");
			sb.Append("  _Version: ").Append(_Version).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
