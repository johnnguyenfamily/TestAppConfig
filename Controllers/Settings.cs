using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestAppConfig.Controllers
{
    public class Settings
    {
        public string BackgroundColor { get; set; }
        public long FontSize { get; set; }
        public string FontColor { get; set; }
        public string Message { get; set; }
        public string KeyVaultMessage { get; set; }
    }
}
