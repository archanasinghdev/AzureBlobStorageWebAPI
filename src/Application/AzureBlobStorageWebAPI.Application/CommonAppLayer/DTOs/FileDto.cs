﻿using AzureBlobStorageWebAPI.Application.SeedWork.Extensions;
using System.IO;

namespace AzureBlobStorageWebAPI.Application.CommonAppLayer.DTOs
{
    public class FileDto
    {
        public Stream Content { get; set; }
        public string Name { get; set; }
        public string ContentType { get; set; }

        public string GetPathWithFileName()
        {
            string uniqueAutoGeneratedFileName = Path.GetRandomFileName();
            string shortClientSideFileNameWithoutExt = Path.GetFileNameWithoutExtension(Name).TruncateLongString(10);  //Trimming to max 10 as client side file name can be too long
            string ext = Path.GetExtension(Name);
            string basePath = "user1/stories/";

            return basePath + uniqueAutoGeneratedFileName + "_" + shortClientSideFileNameWithoutExt + ext;
        }
    }
}
