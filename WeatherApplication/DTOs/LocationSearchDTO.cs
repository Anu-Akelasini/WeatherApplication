using System.ComponentModel.DataAnnotations;

namespace TodoBlazor.DTOs
{
	public class LocationSearchDTO
	{
		[Required]
		public string? Location { get; set; }
	}
}
