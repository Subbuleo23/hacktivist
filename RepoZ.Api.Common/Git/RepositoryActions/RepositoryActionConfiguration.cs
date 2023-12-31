﻿using Newtonsoft.Json;
using System.Collections.Generic;

namespace RepoZ.Api.Common.Git
{
	public class RepositoryActionConfiguration
	{
        [JsonProperty("repository-actions")]
        public List<RepositoryAction> RepositoryActions { get; set; } = new List<RepositoryAction>();

        [JsonProperty("file-associations")]
        public List<FileAssociation> FileAssociations { get; set; } = new List<FileAssociation>();

        [JsonIgnore]
        public LoadState State { get; set; } = LoadState.None;

        [JsonIgnore]
        public string LoadError { get; set; }

        [System.Diagnostics.DebuggerDisplay("{Name}")]
        public class RepositoryAction
        {
            [JsonProperty("name")]
            public string Name { get; set; }

            [JsonProperty("command")]
            public string Command { get; set; }

            [JsonProperty("executables")]
            public List<string> Executables { get; set; } = new List<string>();

            [JsonProperty("arguments")]
            public string Arguments { get; set; }

            [JsonProperty("keys")]
            public string Keys { get; set; }

            [JsonProperty("active")]
            public bool Active { get; set; }
        }

        [System.Diagnostics.DebuggerDisplay("{Name}")]
        public class FileAssociation
        {
            [JsonProperty("name")]
            public string Name { get; set; }

            [JsonProperty("extension")]
            public string Extension { get; set; }

            [JsonProperty("executables")]
            public List<string> Executables { get; set; } = new List<string>();

            [JsonProperty("arguments")]
            public string Arguments { get; set; }

            [JsonProperty("active")]
            public bool Active { get; set; }
        }

        public enum LoadState
        {
            Ok,
            None,
            Error
        }
    }
}
