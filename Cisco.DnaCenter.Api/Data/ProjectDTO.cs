using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Cisco.DnaCenter.Api.Data;

/// <summary>
/// ProjectDto
/// </summary>
[DataContract]
public class ProjectDto
{
	/// <summary>
	/// Initializes a new instance of the <see cref="ProjectDto" /> class.
	/// </summary>
	/// <param name="CreateTime">CreateTime.</param>
	/// <param name="Description">Description.</param>
	/// <param name="Id">Id.</param>
	/// <param name="LastUpdateTime">LastUpdateTime.</param>
	/// <param name="Name">Name.</param>
	/// <param name="Tags">Tags.</param>
	/// <param name="Templates">Templates.</param>
	public ProjectDto(
		long? CreateTime = default,
		string? Description = default,
		string? Id = default,
		long? LastUpdateTime = default,
		string? Name = default,
		List<TagDto>? Tags = default,
		Object Templates = default)
	{
		this.CreateTime = CreateTime;
		this.Description = Description;
		this.Id = Id;
		this.LastUpdateTime = LastUpdateTime;
		this.Name = Name;
		this.Tags = Tags ?? new List<TagDto>();
		this.Templates = Templates;
	}

	/// <summary>
	/// Gets or Sets CreateTime
	/// </summary>
	[DataMember(Name = "createTime", EmitDefaultValue = false)]
	public long? CreateTime { get; set; }

	/// <summary>
	/// Gets or Sets Description
	/// </summary>
	[DataMember(Name = "description", EmitDefaultValue = false)]
	public string? Description { get; set; }

	/// <summary>
	/// Gets or Sets Id
	/// </summary>
	[DataMember(Name = "id", EmitDefaultValue = false)]
	public string? Id { get; set; }

	/// <summary>
	/// Gets or Sets LastUpdateTime
	/// </summary>
	[DataMember(Name = "lastUpdateTime", EmitDefaultValue = false)]
	public long? LastUpdateTime { get; set; }

	/// <summary>
	/// Gets or Sets Name
	/// </summary>
	[DataMember(Name = "name", EmitDefaultValue = false)]
	public string? Name { get; set; }

	/// <summary>
	/// Gets or Sets Tags
	/// </summary>
	[DataMember(Name = "tags", EmitDefaultValue = false)]
	public List<TagDto>? Tags { get; set; }

	/// <summary>
	/// Gets or Sets Templates
	/// </summary>
	[DataMember(Name = "templates", EmitDefaultValue = false)]
	public Object Templates { get; set; }

	/// <summary>
	/// Returns the string presentation of the object
	/// </summary>
	/// <returns>String presentation of the object</returns>
	public override string ToString()
	{
		var sb = new StringBuilder();
		sb.Append("class ProjectDto {\n");
		sb.Append("  CreateTime: ").Append(CreateTime).Append("\n");
		sb.Append("  Description: ").Append(Description).Append("\n");
		sb.Append("  Id: ").Append(Id).Append("\n");
		sb.Append("  LastUpdateTime: ").Append(LastUpdateTime).Append("\n");
		sb.Append("  Name: ").Append(Name).Append("\n");
		sb.Append("  Tags: ").Append(Tags).Append("\n");
		sb.Append("  Templates: ").Append(Templates).Append("\n");
		sb.Append("}\n");
		return sb.ToString();
	}
}
