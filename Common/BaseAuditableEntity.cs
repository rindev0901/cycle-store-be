using Supabase.Postgrest.Attributes;

namespace cycle_store_be.Common
{
    public class BaseAuditableEntity : BaseEntity
    {
        [Column("created_at")]
        public DateTime CreatedAt { get; set; }
        [Column("modified_at")]
        public DateTime ModifiedAt { get; set; }
    }
}
