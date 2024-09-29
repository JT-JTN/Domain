using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Domain.AppClient
{
    public class AppClient
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Client First Name"),
            MaxLength(50, ErrorMessage = "Max Length 50 Characters"),
            DataType(DataType.Text),
            Column(TypeName = "nvarchar(50)"),
            Required]
        public string ClientFirstName { get; set; } = string.Empty;

        [Display(Name = "Client Last Name"),
            MaxLength(50, ErrorMessage = "Max Length 50 Characters"),
            DataType(DataType.Text),
            Column(TypeName = "nvarchar(50)"),
            Required]
        public string ClientLastName { get; set; } = string.Empty;

        [Display(Name = "Client Email"),
            MaxLength(450, ErrorMessage = "Max Length 450 Characters"),
            DataType(DataType.EmailAddress),
            Column(TypeName = "nvarchar(450)"),
            EmailAddress(ErrorMessage = "Invalid Email Address"),
            Required]
        public string ClientEmail { get; set; } = string.Empty;

        [Display(Name = "Client Phone Number"),
            DataType(DataType.PhoneNumber),
            Phone(ErrorMessage = "Invalid Phone Number"),
            Column(TypeName = "nvarchar(50)"),
            MaxLength(50, ErrorMessage = "Max Length 50 Digits"),
            Required]
        public string ClientPhoneNumber { get; set; } = string.Empty;

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

        [JsonIgnore]
        public virtual ICollection<AppClientAddress>? AppClientAddresses { get; set; }

        [JsonIgnore]
        public virtual ICollection<AppClientContact>? AppClientContacts { get; set; }

    }
}
