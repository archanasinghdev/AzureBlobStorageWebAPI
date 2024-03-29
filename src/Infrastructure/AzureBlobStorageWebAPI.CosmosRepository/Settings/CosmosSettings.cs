﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AzureBlobStorageWebAPI.CosmosRepository.Settings
{
    public class CosmosSettings
    {
        public const string SettingName = "CosmosSettings";

        public string Endpoint { get; set; }
        public string Key { get; set; }
        public string DatabaseName { get; set; }
        public string MovieContainer { get; set; }
    }
}
