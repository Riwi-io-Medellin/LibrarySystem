using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LibrarySystem.Models;

[Table("document_types")]
public class DocumentType
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Column("name")]
    [MaxLength(50, ErrorMessage = "The Name field must be at most {1} characters.")]
    public required string Name { get; set; }

    [Column("abbreviation")]
    [MinLength(2, ErrorMessage = "The Abbreviation field must be at least {1} characters.")]
    [MaxLength(10, ErrorMessage = "The Abbreviation field must be at most {1} characters.")]
    public required string Abbreviation { get; set; }

    [Column("description")]
    [MaxLength(10, ErrorMessage = "The Name field must be at most {1} characters.")]
    public string? Description { get; set; }
}
