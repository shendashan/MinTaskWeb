using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TaskWebS.Mode
{
    public class BaseEntity
    {
        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime CreateTime { get; set; }
        /// <summary>
        /// 创建人
        /// </summary>
        public long CreateUserId { get; set; }
        /// <summary>
        /// 修改时间
        /// </summary>
        public DateTime UpdateTime { get; set; }
        /// <summary>
        /// 修改人
        /// </summary>
        public long UpdateUserId { get; set; }
        /// <summary>
        /// 删除时间
        /// </summary>
        public DateTime DeleteTime { get; set; }
        /// <summary>
        /// 删除人
        /// </summary>
        public long DeleteUserId { get; set; }
        /// <summary>
        /// 删除状态
        /// </summary>
        public bool IsDelete { get; set; }
    }
}
