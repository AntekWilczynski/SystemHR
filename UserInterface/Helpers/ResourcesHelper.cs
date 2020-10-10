using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemHR.UserInterface.Helpers
{
    public static class ResourcesHelper
    { public const string close = "delete-icon.png";
        public static string ResourcesFilePath = Path.Combine(System.IO.Path.GetFullPath(@"..\..\"), "Resources");

    }
}
