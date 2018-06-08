using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TaskWebS.Mode
{
    /// <summary>
    /// 留言表
    /// </summary>
    public class TaskMessage:BaseEntity
    {
        /// <summary>
        /// 留言表主键
        /// </summary>
        [Key]
        public long TaskMessageId { get; set; }
        /// <summary>
        /// 用户主键
        /// </summary>
        public long UserId { get; set; }
        /// <summary>
        /// 任务主键
        /// </summary>
        public long TaskId { get; set; }
        /// <summary>
        /// 留言内容
        /// </summary>
        [StringLength(250)]
        public string MessageContent { get; set; }
        [ForeignKey("UserId")]
        public virtual TaskUser TaskUser { get; set; }
        [ForeignKey("TaskId")]
        public virtual TaskTable TaskTable { get; set; }
    }
}
