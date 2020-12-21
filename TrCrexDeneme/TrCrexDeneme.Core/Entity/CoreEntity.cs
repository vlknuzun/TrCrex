using System;


namespace TrCrexDeneme.Core.Entity
{
    public class CoreEntity : IEntity<int>
    {
        public CoreEntity()
        {
            
            this.CreatedDate = DateTime.Now;
        }

        public int Id { get; set; }
        
        public DateTime? CreatedDate { get; set; }
    }
}
