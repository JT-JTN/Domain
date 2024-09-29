using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.AppClient
{
    public class AppClientContactType
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Contact Type"),
            MaxLength(50, ErrorMessage = "Max Length 50 Characters"),
            DataType(DataType.Text),
            Required]
        public string ContactTypeName { get; set; } = string.Empty;

        [Display(Name = "Created Date"),
            DataType(DataType.DateTime),
            Column(TypeName = "datetime2"),
            Required]
        public DateTime CreatedDate { get; set; } = DateTime.Now;

        [Display(Name = "Updated Date"),
            Column(TypeName = "datetime2"),
            DataType(DataType.DateTime)]
        public DateTime? UpdatedDate { get; set; }

        [Timestamp]
        public byte[] RowVersion { get; set; } = null!;
    }
}