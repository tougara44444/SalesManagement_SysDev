﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SalesManagement_SysDev
{
    class T_Arrival
    {
        public T_Arrival()
        {
            T_ArrivalDetail = new HashSet<T_ArrivalDetail>();
        }

        [Key]
        public int ArID { get; set; }               //入荷ID	
        public int SoID { get; set; }               //営業所ID	
        public int? EmID { get; set; }              //社員ID	
        public int ClID { get; set; }               //顧客ID	
        public int OrID { get; set; }               //受注ID	
        [DataType(DataType.Date)]
        [Column(TypeName = "date")]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}", ApplyFormatInEditMode = true)]
        public DateTime? ArDate { get; set; }       //入荷年月日	
        public int ArStateFlag { get; set; }        //入荷状態フラグ
        public int ArFlag { get; set; }	            //入荷管理フラグ
        public string ArHidden { get; set; }	    //非表示理由	

        public virtual M_Client M_Client { get; set; }
        public virtual M_Employee M_Employee { get; set; }
        public virtual M_SalesOffice M_SalesOffice { get; set; }
        public virtual T_Order T_Order { get; set; }
        public virtual ICollection<T_ArrivalDetail> T_ArrivalDetail { get; set; }
    }
}
