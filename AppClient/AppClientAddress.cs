using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Domain.AppClient
{
    public class AppClientAddress
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "App Client"),
            Column(TypeName = "int"),
            Required]
        public int AppClientId { get; set; }

        [Display(Name = "Address Type"),
            Column(TypeName = "int"),
            Required]
        public int AddressTypeId { get; set; }

        [Display(Name = "Address"),
            MaxLength(450, ErrorMessage = "Max Length 450 Characters"),
            DataType(DataType.Text),
            Column(TypeName = "nvarchar(450)"),
            Required]
        public string Address { get; set; } = string.Empty;

        [Display(Name = "City"),
            MaxLength(50, ErrorMessage = "Max Length 50 Characters"),
            DataType(DataType.Text),
            Column(TypeName = "nvarchar(50)"),
            Required]
        public string City { get; set; } = string.Empty;

        [Display(Name = "State"),
            MaxLength(50, ErrorMessage = "Max Length 50 Characters"),
            DataType(DataType.Text),
            Column(TypeName = "nvarchar(50)"),
            Required]
        public string State { get; set; } = string.Empty;

        [Display(Name = "Zip Code"),
            MaxLength(10, ErrorMessage = "Max Length 10 Characters"),
            DataType(DataType.PostalCode),
            Column(TypeName = "nvarchar(10)"),
            Required]
        public string ZipCode { get; set; } = string.Empty;

        [Display(Name = "Country"),
            MaxLength(50, ErrorMessage = "Max Length 50 Characters"),
            DataType(DataType.Text),
            Column(TypeName = "nvarchar(50)"),
            Required]
        public string Country { get; set; } = string.Empty;

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

        [JsonIgnore, ForeignKey("AddressTypeId")]
        public virtual AppClientAddressType AddressType { get; set; } = null!;

        [JsonIgnore, ForeignKey("AppClientId")]
        public virtual AppClient AppClient { get; set; } = null!;
    }
}