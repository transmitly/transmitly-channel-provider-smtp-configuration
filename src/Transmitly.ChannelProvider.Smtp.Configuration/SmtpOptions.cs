// Copyright (c) Code Impressions, LLC. All Rights Reserved.
//  
//  Licensed under the Apache License, Version 2.0 (the "License")
//  you may not use this file except in compliance with the License.
//  You may obtain a copy of the License at
//  
//      http://www.apache.org/licenses/LICENSE-2.0
//  
//  Unless required by applicable law or agreed to in writing, software
//  distributed under the License is distributed on an "AS IS" BASIS,
//  WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//  See the License for the specific language governing permissions and
//  limitations under the License.

using System.Net;
using System.Text;

namespace Transmitly.ChannelProvider.Smtp.Configuration
{
	/// <summary>
	/// Common set of options available for configuring Smtp channel providers.
	/// </summary>
	public sealed class SmtpOptions
	{
		/// <summary>
		/// The SSL and/or TLS encryption that
		/// should be used for a connection.
		/// </summary>
		public SecureSocketOptions SocketOptions { get; set; } = SecureSocketOptions.Auto;

		/// <summary>
		/// The Uri host for the Smtp server.
		/// </summary>
		public string? Host { get; set; }
		/// <summary>
		/// The port to use for the Smtp server. 
		/// </summary>
		public int? Port { get; set; }
		/// <summary>
		/// Default encoding to use for communications.
		/// </summary>
		public Encoding Encoding { get; set; } = Encoding.UTF8;
		/// <summary>
		/// Optional credentials for authenticating with the Smtp server.
		/// <para>
		/// See also: <seealso cref="UserName"/>/<seealso cref="Password"/>
		/// </para>
		/// </summary>
		public ICredentials? Credentials { get; set; }
		/// <summary>
		/// The username for the Smtp server.
		/// <para>
		/// See also: <seealso cref="Credentials"/>
		/// </para>
		/// </summary>
		public string? UserName { get; set; }
		/// <summary>
		/// The password for the Smtp server.
		/// <para>
		/// See also: <seealso cref="Credentials"/>
		/// </para>
		/// </summary>
		public string? Password { get; set; }
	}
}
