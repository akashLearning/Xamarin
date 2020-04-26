using System;
using System.Collections.Generic;
using System.Text;

namespace HelloXamarinWorld.List
{
    public class ProfileGroup: List<Profile>
    {
        public string GroupTitle { get; set; }
        public string ShortGroupTitle { get; set; }

        public ProfileGroup(string gt, string sgt)
        {
            GroupTitle = gt;
            ShortGroupTitle = sgt;
        }
    }
}
