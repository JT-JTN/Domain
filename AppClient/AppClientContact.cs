using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Domain.AppClient
{
    public class AppClientContact
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "App Client"),
            Column(TypeName = "int"),
            Required]
        public int AppClientId { get; set; }

        [Display(Name = "Contact Type"),
            Column(TypeName = "int"),
            Required]
        public int ContactTypeId { get; set; }

        [Display(Name = "Contact First Name"),
            MaxLength(50, ErrorMessage = "Max Length 50 Characters"),
            DataType(DataType.Text),
            Column(TypeName = "nvarchar(50)"),
            Required]
        public string ContactFirstName { get; set; } = string.Empty;

        [Display(Name = "Contact Last Name"),
            MaxLength(50, ErrorMessage = "Max Length 50 Characters"),
            DataType(DataType.Text),
            Column(TypeName = "nvarchar(50)"),
            Required]
        public string ContactLastName { get; set; } = string.Empty;

        [Display(Name = "Contact Email"),
            MaxLength(450, ErrorMessage = "Max Length 450 Characters"),
            DataType(DataType.EmailAddress),
            Column(TypeName = "nvarchar(450)"),
            EmailAddress(ErrorMessage = "Invalid Email Address"),
            Required]
        public string ContactEmail { get; set; } = string.Empty;

        [Display(Name = "Contact Phone Number"),
            DataType(DataType.PhoneNumber),
            Column(TypeName = "nvarchar(50)"),
            MaxLength(50, ErrorMessage = "Max Length 50 Digits"),
            Required]
        public string ContactPhoneNumber { get; set; } = string.Empty;

        [Display(Name = "Created Date"),
            DataType(DataType.DateTime),
            Column(TypeName = "datetime2"),
            Required]
        public DateTime CreatedDate { get; set; } = DateTime.Now;

        [Display(Name = "Updated Date"),
            DataType(DataType.DateTime),
            Column(TypeName = "datetime2")]
        public DateTime? UpdatedDate { get; set; }

        [Timestamp]
        public byte[] RowVersion { get; set; } = null!;

        [JsonIgnore, ForeignKey("AppClientId")]
        public virtual AppClient AppClient { get; set; } = null!;

        [JsonIgnore, ForeignKey("ContactTypeId")]
        public virtual AppClientContactType ContactType { get; set; } = null!;
    }
}