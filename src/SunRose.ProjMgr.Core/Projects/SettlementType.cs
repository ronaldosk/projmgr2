using System;
using System.Collections.Generic;
using System.Text;

namespace SunRose.ProjMgr.Projects
{
    public enum SettlementType : byte
    {
        Standard = 0,//小费用结算
        Hybird = 1,//买可保安装结算
        Completed = 2//气站安装结算
    }
}
