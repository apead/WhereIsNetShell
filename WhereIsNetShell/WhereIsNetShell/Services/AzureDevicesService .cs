using Microsoft.AppCenter.Data;
using System.Collections.Generic;
using System.Threading.Tasks;
using WhereIsDotNet.Models;
using System.Linq;
using WhereIsNetShell.Services;

namespace WhereIsDotNet.Services
{
    public class AzureDevicesService : IDeviceService
    {
        public async void PopulateCosmosDbWithSamples()
        {
            var device = new Device();
            device.DeviceName = "iOS";
            await Data.CreateAsync(device.Id.ToString(), device, DefaultPartitions.AppDocuments);
        }

        /*
        public static string Path { get; set; } = "devices.db";

        private IMobileServiceSyncTable<Device> _deviceTable;


        public MobileServiceClient DevicesMobileService { get; set; }



        public async Task InitializeAsync()
        {
            DevicesMobileService = new MobileServiceClient("https://cpttechsummitdemo.azurewebsites.net/");

           try
            {


                var store = new MobileServiceSQLiteStore(Path);
                store.DefineTable<Device>();
                await DevicesMobileService.SyncContext.InitializeAsync(store, new MobileServiceSyncHandler());

                _deviceTable = DevicesMobileService.GetSyncTable<Device>();

            }
            catch (Exception ex)
            {
                // Handle exception

                Debug.WriteLine(ex.Message);
            }

        }
        */

        public async Task<List<Device>> GetDevicesAsync()
        {
            var page = new List<Device>();
            var result = await Data.ListAsync<Device>(DefaultPartitions.AppDocuments);
            page.AddRange(result.CurrentPage.Items.Select(a => a.DeserializedValue));
            return page.OrderBy(c => c.DeviceName).ToList();
        }
    }
}
