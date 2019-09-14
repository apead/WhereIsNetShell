using System;

namespace WhereIsDotNet.Models
{
    public class Device
    {
        public Guid Id { get; set; } = Guid.NewGuid(); //generates random id

        public string DeviceName { get; set; }

        public string Description { get; set; }

        public string ImageUrl { get; set; }

        public string LogoUrl { get; set; }

        public string ThumbnailUrl { get; set; }
        public string WebsiteUrl { get; set; }

    }


}
