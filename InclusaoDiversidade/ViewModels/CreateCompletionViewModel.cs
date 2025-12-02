public class CreateCompletionViewModel
{
    [Required]
    public int EnrollmentId { get; set; }


    [Required]
    public string Result { get; set; } = string.Empty;
}