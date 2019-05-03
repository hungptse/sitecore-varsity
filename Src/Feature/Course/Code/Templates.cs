using Sitecore.Data;

namespace Sitecore.Feature.Course
{
    public struct Templates
    {
        public struct CourseFolder
        {
            public static readonly ID ID = new ID("{26BA7A68-A774-4F7D-A284-0F1CB82FC70F}");
        }

        public struct CourseItem
        {
            public static readonly ID ID = new ID("{E9A00525-80F1-4FF1-B6E0-42687582566C}");

            public struct Fields
            {
                public static readonly ID Major = new ID("{8B1FB7C9-70B6-4C47-AE6C-785A98FFA9EA}");
                public static readonly ID Image = new ID("{0333675D-6A9B-4A67-AC10-4CBF907AF5FC}");
                public static readonly ID CountTime = new ID("{BEC135BF-9722-424E-AA5B-6BB077B0F98B}");
                public static readonly ID Header = new ID("{77C5D3DA-826D-4E74-B167-3B1CF711C881}");
                public static readonly ID Description = new ID("{C29A2694-BC68-4CC2-A7B8-88E3CE78BFFF}");
                public static readonly ID Price = new ID("{9006BF90-ECB4-4FAE-9640-26BC460CE7E8}");
                public static readonly ID Place = new ID("{33E709F8-F5E7-439F-91EE-5EC0DA0017C0}");
                public static readonly ID TotalStudent = new ID("{17540395-E122-41A5-BA75-33D8149ED6C9}");
                public static readonly ID Duration = new ID("{28744DB3-D455-4E6B-8B37-DF3B97F92C85}");
                public static readonly ID Start = new ID("{B51B77C8-0CDD-46E4-8F85-92A6177A3EEE}");
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
