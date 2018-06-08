using Microsoft.EntityFrameworkCore.Metadata;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TaskWebS.Mode
{
    /// <summary>
    /// User
    /// </summary>
    public class TaskUser:BaseEntity
    {

        /// <summary>
        /// 主键
        /// </summary>
        [Key]
        public long UserId { get; set; }
        /// <summary>
        /// 用户名称
        /// </summary>
        [StringLength(16)]
        public string UserName { get; set; }
        /// <summary>
        /// 用户登陆名称
        /// </summary>
        [StringLength(16)]
        public string UserLoginName { get; set; }
        /// <summary>
        /// 用户密码
        /// </summary>
        [StringLength(36)]
        public string UserPwd { get; set; }
        /// <summary>
        /// 手机号
        /// </summary>
        [StringLength(36)]
        public string UserPhone { get; set; }

        public virtual ICollection<TaskAndUser> TaskAndUsers { get; set; }
        public virtual  ICollection<TaskMessage> TaskMessages { get; set; }
    }
}
