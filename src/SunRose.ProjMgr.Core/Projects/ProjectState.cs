using System;
using System.Collections.Generic;
using System.Text;

namespace SunRose.ProjMgr.Projects
{
    public enum ProjectState : byte
    {
        Open = 0,//创建完成-已派工
        Completed = 1,//项目结束
        Appointed = 2,//施工商确认-已经派工
        QuoteCheck = 3,//工程师审核
        ChargeCheck=4,//客服经理审核
        Collect=5,//专员汇总
        Analysis = 6//管理员分析
    }

    public class ProjectStateHelper
    {
        public static string StateName(ProjectState state)
        {
            string result = "";
            switch ((byte)state)
            {
                case 0:
                    result = "已派单";
                    break;
                case 1:
                    result = "结束";
                    break;
                case 2:
                    result = "施工商已确认";
                    break;
                case 3:
                    result = "工程师审核";
                    break;
                case 4:
                    result = "客服经理复审";
                    break;
                case 5:
                    result = "专员汇总";
                    break;
                case 6:
                    result = "管理员分析";
                    break;
            }

            return result;
        }

        public static string StateDescription(ProjectState state)
        {
            string result = "";
            switch ((byte)state)
            {
                case 0:
                    result = "工程师已派单，等待施工商提交结算单";
                    break;
                case 1:
                    result = "项目结束";
                    break;
                case 2:
                    result = "施工商已确认，提交结算单，等待工程师审核";
                    break;
                case 3:
                    result = "工程师已审核结算单，等待客服经理复审";
                    break;
                case 4:
                    result = "客服经理已复审，等待专员汇总";
                    break;
                case 5:
                    result = "专员已汇总提交";
                    break;
                case 6:
                    result = "已提交给管理员";
                    break;
            }

            return result;
        }
    }
}
