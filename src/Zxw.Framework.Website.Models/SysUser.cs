﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Zxw.Framework.NetCore.Models;

namespace Zxw.Framework.Website.Models
{
    [Table("SysUser"), Serializable]
    public class SysUser:BaseModel<string>
    {
        [Key]
        [Column("SysUserId")]
        public override string Id { get; set; }

        [Required]
        [MaxLength(20)]
        public string SysUserName { get; set; }

        [MaxLength(100)]
        public string EMail{get;set;}

        [MaxLength(20)]
        public string Telephone{get;set;}

        [Required]
        [MaxLength(100)]
        public string SysPassword { get; set; }

        [Required]
        public bool Activable { get; set; } = true;

        public DateTime CreatedDateTime{get;set;}=DateTime.Now;

        public DateTime? LatestLoginDateTime{get;set;}

        [MaxLength(100)]
        public string LatestLoginIP{get;set;}
    }
}
