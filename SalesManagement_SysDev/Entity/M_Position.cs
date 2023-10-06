﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SalesManagement_SysDev
{
    class M_Position
    {
        public M_Position()
        {
            M_Employee = new HashSet<M_Employee>();
        }

        [Key]
        public int PoID { get; set; }           //役職ID
        [MaxLength(50)]
        [Required]
        public string PoName { get; set; }      //役職名		
        public int PoFlag { get; set; }         //役職管理フラグ
        public string PoHidden { get; set; }    //非表示理由		

        public virtual ICollection<M_Employee> M_Employee { get; set; }
    }
}
