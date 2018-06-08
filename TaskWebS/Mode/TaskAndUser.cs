using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TaskWebS.Mode
{
    /// <summary>
    /// 人员和任务中间表
    /// </summary>
    public class TaskAndUser:BaseEntity
    {
        /// <summary>
        /// 人员和任务中间表
        /// </summary>
        [Key]
        public long UserAndTaskId { get; set; }
        /// <summary>
        /// 用户表主键
        /// </summary>
        public long UserId { get; set; }
        /// <summary>
        /// 任务表主键
        /// </summary>
        public long TaskId { get; set; }

        [ForeignKey("UserId")]
        public virtual TaskUser TaskUser { get; set; }

        [ForeignKey("TaskId")]
        public virtual TaskTable TaskTable { get; set; }
    }
}
