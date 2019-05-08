using Sitecore.Data;

namespace Sitecore.Feature.Course
{
    public struct Templates
    {
        public struct CourseFolder
        {
            public static readonly ID ID = new ID("{E2BA1682-70B5-4FE7-8D45-B659F1EDB1C8}");
        }

        public struct CourseItem
        {
            public static readonly ID ID = new ID("{F2C05EA7-2295-466D-ADDB-036E77E35B24}");

            public struct Fields
            {
                public static readonly ID Major = new ID("{3762B756-B9FE-4A41-BB01-0EC8DCD03E95}");
                public static readonly ID Image = new ID("{10E73820-443E-4C69-9513-91ACA18F0D29}");
                public static readonly ID CountTime = new ID("{D200191F-5CE7-495D-A458-90876145E197}");
                public static readonly ID Header = new ID("{DF3426C6-46DA-44E5-A56E-FD6D66270378}");
                public static readonly ID Description = new ID("{D839B08B-B4FA-4023-8BBC-90AB7242B412}");
                public static readonly ID Price = new ID("{6F7420FA-7F35-4560-B16D-D6077D31D07C}");
                public static readonly ID Place = new ID("{8DB24D84-E54B-4068-8FD8-94AAC562E295}");
                public static readonly ID TotalStudent = new ID("{9BD8056E-8277-4DD7-9D4C-C504830D3E7E}");
                public static readonly ID Duration = new ID("{BF55D192-B26F-447D-904D-38A3825209A2}");
                public static readonly ID Start = new ID("{5AA7270F-15D1-4B76-873B-C60919A44570}");
            }
        }  
        //public struct Parameters 
        //{
        //    public static readonly ID ID = new ID("{9B7419B0-4218-4D7A-843B-4BDAE32EC722}");
        //    public struct Fields
        //    {
        //        public static readonly ID ITEM_PER_PAGE = new ID("{BEEFA759-0A2D-40F1-A4E4-202E7E4C4026}");
        //    }
        //}
    }
}
