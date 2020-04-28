using System;
using System.Text;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Cisco.DnaCenter.Api.Data
{
	/// <summary>
	/// GetClientDetailResponseDetailOnboarding
	/// </summary>
	[DataContract]
	public class GetClientDetailResponseDetailOnboarding
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="GetClientDetailResponseDetailOnboarding" /> class.
		/// </summary>
		/// <param name="AverageRunDuration">AverageRunDuration.</param>
		/// <param name="MaxRunDuration">MaxRunDuration.</param>
		/// <param name="AverageAssocDuration">AverageAssocDuration.</param>
		/// <param name="MaxAssocDuration">MaxAssocDuration.</param>
		/// <param name="AverageAuthDuration">AverageAuthDuration.</param>
		/// <param name="MaxAuthDuration">MaxAuthDuration.</param>
		/// <param name="AverageDhcpDuration">AverageDhcpDuration.</param>
		/// <param name="MaxDhcpDuration">MaxDhcpDuration.</param>
		/// <param name="AaaServerIp">AaaServerIp.</param>
		/// <param name="DhcpServerIp">DhcpServerIp.</param>
		/// <param name="AuthDoneTime">AuthDoneTime.</param>
		/// <param name="AssocDoneTime">AssocDoneTime.</param>
		/// <param name="DhcpDoneTime">DhcpDoneTime.</param>
		/// <param name="AssocRootcauseList">AssocRootcauseList.</param>
		/// <param name="AaaRootcauseList">AaaRootcauseList.</param>
		/// <param name="DhcpRootcauseList">DhcpRootcauseList.</param>
		/// <param name="OtherRootcauseList">OtherRootcauseList.</param>
		public GetClientDetailResponseDetailOnboarding(Object AverageRunDuration = default, Object MaxRunDuration = default, Object AverageAssocDuration = default, Object MaxAssocDuration = default, Object AverageAuthDuration = default, Object MaxAuthDuration = default, Object AverageDhcpDuration = default, Object MaxDhcpDuration = default, string? AaaServerIp = default, Object DhcpServerIp = default, Object AuthDoneTime = default, Object AssocDoneTime = default, Object DhcpDoneTime = default, List<Object> AssocRootcauseList = default, List<Object> AaaRootcauseList = default, List<Object> DhcpRootcauseList = default, List<Object> OtherRootcauseList = default)
		{
			this.AverageRunDuration = AverageRunDuration;
			this.MaxRunDuration = MaxRunDuration;
			this.AverageAssocDuration = AverageAssocDuration;
			this.MaxAssocDuration = MaxAssocDuration;
			this.AverageAuthDuration = AverageAuthDuration;
			this.MaxAuthDuration = MaxAuthDuration;
			this.AverageDhcpDuration = AverageDhcpDuration;
			this.MaxDhcpDuration = MaxDhcpDuration;
			this.AaaServerIp = AaaServerIp;
			this.DhcpServerIp = DhcpServerIp;
			this.AuthDoneTime = AuthDoneTime;
			this.AssocDoneTime = AssocDoneTime;
			this.DhcpDoneTime = DhcpDoneTime;
			this.AssocRootcauseList = AssocRootcauseList;
			this.AaaRootcauseList = AaaRootcauseList;
			this.DhcpRootcauseList = DhcpRootcauseList;
			this.OtherRootcauseList = OtherRootcauseList;
		}

		/// <summary>
		/// Gets or Sets AverageRunDuration
		/// </summary>
		[DataMember(Name = "averageRunDuration", EmitDefaultValue = false)]
		public Object AverageRunDuration { get; set; }

		/// <summary>
		/// Gets or Sets MaxRunDuration
		/// </summary>
		[DataMember(Name = "maxRunDuration", EmitDefaultValue = false)]
		public Object MaxRunDuration { get; set; }

		/// <summary>
		/// Gets or Sets AverageAssocDuration
		/// </summary>
		[DataMember(Name = "averageAssocDuration", EmitDefaultValue = false)]
		public Object AverageAssocDuration { get; set; }

		/// <summary>
		/// Gets or Sets MaxAssocDuration
		/// </summary>
		[DataMember(Name = "maxAssocDuration", EmitDefaultValue = false)]
		public Object MaxAssocDuration { get; set; }

		/// <summary>
		/// Gets or Sets AverageAuthDuration
		/// </summary>
		[DataMember(Name = "averageAuthDuration", EmitDefaultValue = false)]
		public Object AverageAuthDuration { get; set; }

		/// <summary>
		/// Gets or Sets MaxAuthDuration
		/// </summary>
		[DataMember(Name = "maxAuthDuration", EmitDefaultValue = false)]
		public Object MaxAuthDuration { get; set; }

		/// <summary>
		/// Gets or Sets AverageDhcpDuration
		/// </summary>
		[DataMember(Name = "averageDhcpDuration", EmitDefaultValue = false)]
		public Object AverageDhcpDuration { get; set; }

		/// <summary>
		/// Gets or Sets MaxDhcpDuration
		/// </summary>
		[DataMember(Name = "maxDhcpDuration", EmitDefaultValue = false)]
		public Object MaxDhcpDuration { get; set; }

		/// <summary>
		/// Gets or Sets AaaServerIp
		/// </summary>
		[DataMember(Name = "aaaServerIp", EmitDefaultValue = false)]
		public string? AaaServerIp { get; set; }

		/// <summary>
		/// Gets or Sets DhcpServerIp
		/// </summary>
		[DataMember(Name = "dhcpServerIp", EmitDefaultValue = false)]
		public Object DhcpServerIp { get; set; }

		/// <summary>
		/// Gets or Sets AuthDoneTime
		/// </summary>
		[DataMember(Name = "authDoneTime", EmitDefaultValue = false)]
		public Object AuthDoneTime { get; set; }

		/// <summary>
		/// Gets or Sets AssocDoneTime
		/// </summary>
		[DataMember(Name = "assocDoneTime", EmitDefaultValue = false)]
		public Object AssocDoneTime { get; set; }

		/// <summary>
		/// Gets or Sets DhcpDoneTime
		/// </summary>
		[DataMember(Name = "dhcpDoneTime", EmitDefaultValue = false)]
		public Object DhcpDoneTime { get; set; }

		/// <summary>
		/// Gets or Sets AssocRootcauseList
		/// </summary>
		[DataMember(Name = "assocRootcauseList", EmitDefaultValue = false)]
		public List<Object> AssocRootcauseList { get; set; }

		/// <summary>
		/// Gets or Sets AaaRootcauseList
		/// </summary>
		[DataMember(Name = "aaaRootcauseList", EmitDefaultValue = false)]
		public List<Object> AaaRootcauseList { get; set; }

		/// <summary>
		/// Gets or Sets DhcpRootcauseList
		/// </summary>
		[DataMember(Name = "dhcpRootcauseList", EmitDefaultValue = false)]
		public List<Object> DhcpRootcauseList { get; set; }

		/// <summary>
		/// Gets or Sets OtherRootcauseList
		/// </summary>
		[DataMember(Name = "otherRootcauseList", EmitDefaultValue = false)]
		public List<Object> OtherRootcauseList { get; set; }

		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class GetClientDetailResponseDetailOnboarding {\n");
			sb.Append("  AverageRunDuration: ").Append(AverageRunDuration).Append("\n");
			sb.Append("  MaxRunDuration: ").Append(MaxRunDuration).Append("\n");
			sb.Append("  AverageAssocDuration: ").Append(AverageAssocDuration).Append("\n");
			sb.Append("  MaxAssocDuration: ").Append(MaxAssocDuration).Append("\n");
			sb.Append("  AverageAuthDuration: ").Append(AverageAuthDuration).Append("\n");
			sb.Append("  MaxAuthDuration: ").Append(MaxAuthDuration).Append("\n");
			sb.Append("  AverageDhcpDuration: ").Append(AverageDhcpDuration).Append("\n");
			sb.Append("  MaxDhcpDuration: ").Append(MaxDhcpDuration).Append("\n");
			sb.Append("  AaaServerIp: ").Append(AaaServerIp).Append("\n");
			sb.Append("  DhcpServerIp: ").Append(DhcpServerIp).Append("\n");
			sb.Append("  AuthDoneTime: ").Append(AuthDoneTime).Append("\n");
			sb.Append("  AssocDoneTime: ").Append(AssocDoneTime).Append("\n");
			sb.Append("  DhcpDoneTime: ").Append(DhcpDoneTime).Append("\n");
			sb.Append("  AssocRootcauseList: ").Append(AssocRootcauseList).Append("\n");
			sb.Append("  AaaRootcauseList: ").Append(AaaRootcauseList).Append("\n");
			sb.Append("  DhcpRootcauseList: ").Append(DhcpRootcauseList).Append("\n");
			sb.Append("  OtherRootcauseList: ").Append(OtherRootcauseList).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
