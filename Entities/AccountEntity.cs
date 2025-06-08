using cycle_store_be.Common;
using Supabase.Postgrest.Attributes;

namespace cycle_store_be.Entities
{
    [Table("account")]
    public class AccountEntity : BaseAuditableEntity
    {
        [PrimaryKey("account_id", false)]
        public int AccountId { get; set; }
        [Column("user_id")]
        public Guid UserId { get; set; }
        [Column("user_name")]
        public string Username { get; set; }
        [Column("email")]
        public string Email { get; set; }
        [Column("phone_number")]
        public string PhoneNumber { get; set; }
        [Column("avatar_url")]
        public string AvatarUrl { get; set; }
        [Column("avatar_name")]
        public string AvatarName { get; set; }
    }
}
