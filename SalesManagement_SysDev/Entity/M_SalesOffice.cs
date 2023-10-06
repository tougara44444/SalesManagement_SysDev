﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesManagement_SysDev
{
    class M_SalesOffice
    {
        public M_SalesOffice()
        {
            M_Client = new HashSet<M_Client>();
            M_Employee = new HashSet<M_Employee>();
            T_Arrival = new HashSet<T_Arrival>();
            T_Chumon = new HashSet<T_Chumon>();
            T_Order = new HashSet<T_Order>();
            T_Sale = new HashSet<T_Sale>();
            T_Shipment = new HashSet<T_Shipment>();
            T_Syukko = new HashSet<T_Syukko>();
        }

        [Key]
        public int SoID { get; set; }           //営業所ID
        [MaxLength(50)]
        [Required]
        public string SoName { get; set; }      //営業所名	
        [MaxLength(50)]
        [Required]
        public string SoAddress { get; set; }   //住所
        [MaxLength(13)]
        [Required]
        public string SoPhone { get; set; }     //電話番号
        [MaxLength(7)]
        [Required]
        public string SoPostal { get; set; }    //郵便番号	
        [MaxLength(13)]
        [Required]
        public string SoFAX { get; set; }       //FAX		
        public int SoFlag { get; set; }         //営業所管理フラグ	 
        public string SoHidden { get; set; }	//非表示理由		

        public virtual ICollection<M_Client> M_Client { get; set; }
        public virtual ICollection<M_Employee> M_Employee { get; set; }
        public virtual ICollection<T_Arrival> T_Arrival { get; set; }
        public virtual ICollection<T_Chumon> T_Chumon { get; set; }
        public virtual ICollection<T_Order> T_Order { get; set; }
        public virtual ICollection<T_Sale> T_Sale { get; set; }
        public virtual ICollection<T_Shipment> T_Shipment { get; set; }
        public virtual ICollection<T_Syukko> T_Syukko { get; set; }
    }
}
