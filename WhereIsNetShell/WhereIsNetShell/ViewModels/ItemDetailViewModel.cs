using System;

using WhereIsNetShell.Models;

namespace WhereIsNetShell.ViewModels
{
    public class ItemDetailViewModel : BaseViewModel
    {
        public WhereIsDotNet.Models.Device Item { get; set; }
        private string _imageUrl;
        private string _deviceName;
        private string _description;
        private string _websiteUrl;
        private string _logoUrl;

        public string ImageUrl
        {
            get { return _imageUrl; }
            set { SetProperty(ref _imageUrl, value); }
        }

        public string DeviceName
        {
            get { return _deviceName; }
            set { SetProperty(ref _deviceName, value); }
        }

        public string Description
        {
            get { return _description; }
            set { SetProperty(ref _description, value); }
        }

        public string WebsiteUrl
        {
            get { return _websiteUrl; }
            set { SetProperty(ref _websiteUrl, value); }
        }

        public string LogoUrl
        {
            get { return _logoUrl; }
            set { SetProperty(ref _logoUrl, value); }
        }



        public ItemDetailViewModel(WhereIsDotNet.Models.Device item = null)
        {
            Title = item?.DeviceName;
            Item = item;


            DeviceName = item.DeviceName;
            Description = item.Description;
            WebsiteUrl = item.WebsiteUrl;
            LogoUrl = item.LogoUrl;
            ImageUrl = item.ImageUrl;
            Title = item.DeviceName;
        }
    }
}
