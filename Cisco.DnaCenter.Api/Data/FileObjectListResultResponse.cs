using System;
using System.Text;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Cisco.DnaCenter.Api.Data;

/// <summary>
/// FileObjectListResultResponse
/// </summary>
[DataContract]
public class FileObjectListResultResponse
{
	/// <summary>
	/// Initializes a new instance of the <see cref="FileObjectListResultResponse" /> class.
	/// </summary>
	/// <param name="AttributeInfo">AttributeInfo.</param>
	/// <param name="DownloadPath">DownloadPath.</param>
	/// <param name="Encrypted">Encrypted.</param>
	/// <param name="FileFormat">FileFormat.</param>
	/// <param name="FileSize">FileSize.</param>
	/// <param name="Id">Id.</param>
	/// <param name="Md5Checksum">Md5Checksum.</param>
	/// <param name="Name">Name.</param>
	/// <param name="_NameSpace">_NameSpace.</param>
	/// <param name="SftpServerList">SftpServerList.</param>
	/// <param name="Sha1Checksum">Sha1Checksum.</param>
	/// <param name="TaskId">TaskId.</param>
	public FileObjectListResultResponse(Object AttributeInfo = default, string? DownloadPath = default, bool? Encrypted = default, string? FileFormat = default, string? FileSize = default, string? Id = default, string? Md5Checksum = default, string? Name = default, string? _NameSpace = default, List<Object> SftpServerList = default, string? Sha1Checksum = default, Object TaskId = default)
	{
		this.AttributeInfo = AttributeInfo;
		this.DownloadPath = DownloadPath;
		this.Encrypted = Encrypted;
		this.FileFormat = FileFormat;
		this.FileSize = FileSize;
		this.Id = Id;
		this.Md5Checksum = Md5Checksum;
		this.Name = Name;
		this._NameSpace = _NameSpace;
		this.SftpServerList = SftpServerList;
		this.Sha1Checksum = Sha1Checksum;
		this.TaskId = TaskId;
	}

	/// <summary>
	/// Gets or Sets AttributeInfo
	/// </summary>
	[DataMember(Name = "attributeInfo", EmitDefaultValue = false)]
	public Object AttributeInfo { get; set; }

	/// <summary>
	/// Gets or Sets DownloadPath
	/// </summary>
	[DataMember(Name = "downloadPath", EmitDefaultValue = false)]
	public string? DownloadPath { get; set; }

	/// <summary>
	/// Gets or Sets Encrypted
	/// </summary>
	[DataMember(Name = "encrypted", EmitDefaultValue = false)]
	public bool? Encrypted { get; set; }

	/// <summary>
	/// Gets or Sets FileFormat
	/// </summary>
	[DataMember(Name = "fileFormat", EmitDefaultValue = false)]
	public string? FileFormat { get; set; }

	/// <summary>
	/// Gets or Sets FileSize
	/// </summary>
	[DataMember(Name = "fileSize", EmitDefaultValue = false)]
	public string? FileSize { get; set; }

	/// <summary>
	/// Gets or Sets Id
	/// </summary>
	[DataMember(Name = "id", EmitDefaultValue = false)]
	public string? Id { get; set; }

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
	/// Gets or Sets _NameSpace
	/// </summary>
	[DataMember(Name = "nameSpace", EmitDefaultValue = false)]
	public string? _NameSpace { get; set; }

	/// <summary>
	/// Gets or Sets SftpServerList
	/// </summary>
	[DataMember(Name = "sftpServerList", EmitDefaultValue = false)]
	public List<Object> SftpServerList { get; set; }

	/// <summary>
	/// Gets or Sets Sha1Checksum
	/// </summary>
	[DataMember(Name = "sha1Checksum", EmitDefaultValue = false)]
	public string? Sha1Checksum { get; set; }

	/// <summary>
	/// Gets or Sets TaskId
	/// </summary>
	[DataMember(Name = "taskId", EmitDefaultValue = false)]
	public Object TaskId { get; set; }

	/// <summary>
	/// Returns the string presentation of the object
	/// </summary>
	/// <returns>String presentation of the object</returns>
	public override string ToString()
	{
		var sb = new StringBuilder();
		sb.Append("class FileObjectListResultResponse {\n");
		sb.Append("  AttributeInfo: ").Append(AttributeInfo).Append("\n");
		sb.Append("  DownloadPath: ").Append(DownloadPath).Append("\n");
		sb.Append("  Encrypted: ").Append(Encrypted).Append("\n");
		sb.Append("  FileFormat: ").Append(FileFormat).Append("\n");
		sb.Append("  FileSize: ").Append(FileSize).Append("\n");
		sb.Append("  Id: ").Append(Id).Append("\n");
		sb.Append("  Md5Checksum: ").Append(Md5Checksum).Append("\n");
		sb.Append("  Name: ").Append(Name).Append("\n");
		sb.Append("  _NameSpace: ").Append(_NameSpace).Append("\n");
		sb.Append("  SftpServerList: ").Append(SftpServerList).Append("\n");
		sb.Append("  Sha1Checksum: ").Append(Sha1Checksum).Append("\n");
		sb.Append("  TaskId: ").Append(TaskId).Append("\n");
		sb.Append("}\n");
		return sb.ToString();
	}
}
