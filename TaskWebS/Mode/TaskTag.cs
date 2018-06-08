using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TaskWebS.Mode
{
    /// <summary>
    /// 标签表
    /// </summary>
    public class TaskTag:BaseEntity
    {
        /// <summary>
        /// 标签表主键
        /// </summary>
        [Key]
        public long TaskTagId { get; set; }
        /// <summary>
        /// 标签名
        /// </summary>
        [StringLength(12)]
        public string TaskTagName { get; set; }
        /// <summary>
        /// 标签备注
        /// </summary>
        [StringLength(120)]
        public string TaskTagRemark { get; set; }

    }
}
