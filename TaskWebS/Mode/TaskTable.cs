using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TaskWebS.Mode
{
    /// <summary>
    /// Task
    /// </summary>
    public class TaskTable:BaseEntity
    {
        /// <summary>
        /// 任务主键
        /// </summary>
        [Key]
        public long TaskId { get; set; }
        /// <summary>
        /// 任务名
        /// </summary>
        [StringLength(36)]
        public string TaskName { get; set; }
        /// <summary>
        /// 任务级别
        /// </summary>
        public long TagId { get; set; }
        /// <summary>
        /// 任务备注
        /// </summary>
        [StringLength(250)]
        public string TaskRemark { get; set; }

        [ForeignKey("TagId")]
        public virtual TaskTag TaskTag { get; set; }
    }
}
