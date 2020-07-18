//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Oybab.DAL
{
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    
    public partial class Supplier
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Supplier()
        {
            this.tb_import = new HashSet<Import>();
            this.tb_supplierpay = new HashSet<SupplierPay>();
            this.tb_importpay = new HashSet<ImportPay>();
        }



        [JsonIgnore]
        public virtual Admin tb_admin { get; set; }
        [JsonIgnore]
        public virtual ICollection<Import> tb_import { get; set; }
        [JsonIgnore]
        public virtual ICollection<SupplierPay> tb_supplierpay { get; set; }
        [JsonIgnore]
        public virtual ICollection<ImportPay> tb_importpay { get; set; }

        public long SupplierId { get; set; }
        public string SupplierNo { get; set; }
        public string CardNo { get; set; }
        public string Password { get; set; }
        public string SupplierName0 { get; set; }
        public string SupplierName1 { get; set; }
        public string SupplierName2 { get; set; }
        public long Lang { get; set; }
        public long Sex { get; set; }
        public long Occupation { get; set; }
        public string Mobile { get; set; }
        public string Phone { get; set; }
        public string ImageName { get; set; }
        public string IDNumber { get; set; }
        public string Address0 { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string AddressLocation { get; set; }
        public Nullable<long> AdminId { get; set; }
        public double OfferRate { get; set; }
        public double BalancePrice { get; set; }
        public double MinBalancePrice { get; set; }
        public double MaxBalancePrice { get; set; }
        public double SpendPrice { get; set; }
        public double FavorablePrice { get; set; }
        public long ExpiredTime { get; set; }
        public long IsAllowBorrow { get; set; }
        public long Order { get; set; }
        public long IsEnable { get; set; }
        public long AddTime { get; set; }
        public Nullable<long> UpdateTime { get; set; }
        public string Remark { get; set; }
    
        

    }
}