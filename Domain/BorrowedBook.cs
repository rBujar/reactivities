namespace Domain
{
     public class BorrowedBook
    {
        public int Id { get; set; }
      //  public virtual Book Book { get; set; }
        public string DateOfReceipt { get; set; }
        public string ReturnDate { get; set; }
        public int ConditionId { get; set; }
   //     public virtual Condition Condition { get; set; }
        public int clientId{ get; set; }
      //  public virtual Client client{ get; set; }
    }
}