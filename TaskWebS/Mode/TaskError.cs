using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TaskWebS.Mode
{
    /// <summary>
    /// 日志表
    /// </summary>
    public class TaskError:BaseEntity
    {
        /// <summary>
        /// 主键
        /// </summary>
        [Key]
        public long TaskErrorId { get; set; }
        /// <summary>
        /// 错误模块名称
        /// </summary>
        [StringLength(50)]
        public string TaskErrorName { get; set; }
        /// <summary>
        /// 错误内容
        /// </summary>
        [StringLength(500)]
        public string TaskErrorMessage { get; set; }
        /// <summary>
        /// 错误标记
        /// </summary>
        [StringLength(30)]
        public string TaskErrorTag { get; set; }
        /// <summary>
        /// 错误发生时间
        /// </summary>
        public DateTime TaskErrorCurrentTime { get; set; }

    }
}
