using System;
using System.Collections.Generic;
using System.Text;

namespace SunRose.ProjMgr.Projects
{
    public enum ProjectType : byte
    {
        SelfHave = 0,//自有
        Customer = 1,//客户气站维修
        Outsource = 2//客户付费
    }
}
