﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Nest.Domain
{
	[JsonObject]
	public class GlobalStats : Stats
	{
		[JsonProperty(PropertyName = "indices")]
		public Dictionary<string, Stats> Indices { get; set; }

	}
}
