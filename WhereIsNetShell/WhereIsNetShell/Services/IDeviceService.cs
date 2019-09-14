using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using WhereIsDotNet.Models;

namespace WhereIsNetShell.Services
{
    public interface IDeviceService
    {
        Task<List<Device>> GetDevicesAsync();
    }
}
