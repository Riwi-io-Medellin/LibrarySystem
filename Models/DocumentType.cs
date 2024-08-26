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
    public required string Name { get; set; }

    [Column("abbreviation")]
    public required string Abbreviation { get; set; }

    [Column("description")]
    public string? Description { get; set; }
}
