using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using Abp.Timing;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SunRose.ProjMgr.Projects
{
    [Table("Project")]
    public class Project : FullAuditedEntity
    {
        public const int MaxTitleLength = 256;

        /// <summary>
        /// 项目名称
        /// </summary>
        [Required]
        [MaxLength(MaxTitleLength)]
        public string Name { get; set; }

        /// <summary>
        /// 项目状态
        /// </summary>
        public ProjectState State { get; set; }

        /// <summary>
        /// 项目类型
        /// </summary>
        public ProjectType Type { get; set; }

        /// <summary>
        /// 合同编号
        /// </summary>
        public string ContractCode { get; set; }

        /// <summary>
        /// 客户地址
        /// </summary>
        public string CustomAddress { get; set; }

        //public string WorkOrderId { get; set; }

        /// <summary>
        /// 项目结算类型
        /// </summary>
        public SettlementType SettleType { get; set; }

        /// <summary>
        /// 项目预算
        /// </summary>
        public decimal Budget { get; set; }

        /// <summary>
        /// 施工内容
        /// </summary>
        public string WorkContent { get; set; }

        public Project()
        {
            CreationTime = Clock.Now;
            State = ProjectState.Open;
        }

    }
}
