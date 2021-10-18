using System;

namespace RestfullAPI.Models
{
    public class RequisitionProduct
    {
        public int Id { get; set; }
        public int ProductId {  get; set; }
        public Product Product { get; set; }
        public int RequisitionId { get; set; }
        public Requisition Requisition { get; set; }
        public int Quantity { get; set; }
        public DateTime CreateDate { get; set; }

    }
}
