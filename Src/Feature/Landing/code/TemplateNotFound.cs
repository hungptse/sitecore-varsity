using Sitecore.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sitecore.Feature.Landing
{
    public struct TemplateNotFound
    {
        public static readonly ID ID = new ID("{A8CD874A-0650-4070-A3F0-0B46733D30A4}");

        public struct Fields
        {
            public static readonly ID Title = new ID("{6FBBAE48-4C16-49B4-8744-DC2D697953DC}");
            public static readonly ID ErrorCode = new ID("{652606BE-9559-46BB-8783-ABA547E86C08}");
            public static readonly ID Description = new ID("{164D0838-8F04-44A2-8FC4-89FEB7B13408}");
        }
    }
}