﻿using System.IO;

namespace AssetRipper.VersionUtilities.Extensions
{
	/// <summary>
	/// Unity version extension methods for <see cref="BinaryWriter"/>
	/// </summary>
	public static class BinaryWriterExtensions
	{
		/// <summary>
		/// Write a Unity version to the stream
		/// </summary>
		/// <param name="writer">A binary writer</param>
		/// <param name="version">A Unity version</param>
		public static void Write(this BinaryWriter writer, UnityVersion version)
		{
			writer.Write(version.GetBits());
		}

		/// <summary>
		/// Write a Unity version to the stream
		/// </summary>
		/// <param name="writer">A binary writer</param>
		/// <param name="version">A Unity version</param>
		public static void Write(this BinaryWriter writer, CompactUnityVersion32 version)
		{
			writer.Write(version.GetBits());
		}

		/// <summary>
		/// Write a Unity version to the stream
		/// </summary>
		/// <param name="writer">A binary writer</param>
		/// <param name="version">A Unity version</param>
		public static void Write(this BinaryWriter writer, CompactUnityVersion24 version)
		{
			version.GetBits(out byte b, out ushort s);
			writer.Write(b);
			writer.Write(s);
		}
	}
}
