using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Client;
using NZWalks.API.Models.Domain;
using NZWalks.API.Models.DTOs;
using NZWalks.API.Repositories;

namespace NZWalks.API.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ImagesController : ControllerBase
	{
		private readonly IImageRepository imageRepository;

		public ImagesController(IImageRepository imageRepository)
		{
			this.imageRepository = imageRepository;
		}

		[HttpPost]
		public async Task<IActionResult> UploadImage([FromForm] ImageUploadRequestDto request)
		{
			ValidateFileUpload(request);

			if (ModelState.IsValid)
			{
				// Repository
				var imageDomainModel = new Image
				{
					File = request.File,
					FileExtension = Path.GetExtension(request.File.FileName),
					FileSizeInBytes = request.File.Length,
					FileName = request.FileName,
					FileDescription = request.FileDescription,
				};

				await imageRepository.Upload(imageDomainModel);
				return Ok(imageDomainModel);

			}
			return BadRequest(ModelState);
		}

		private void ValidateFileUpload(ImageUploadRequestDto request)
		{
			var allowedExtension = new string[] { ".jpg", ".jpeg", ".png" };
			if (!allowedExtension.Contains(Path.GetExtension(request.File.FileName)))
			{
				ModelState.AddModelError("file", "UnSupported file extension");
			}
			if (request.File.Length > 10485760)
			{
				ModelState.AddModelError("file", "File has size bigger than 10MB, please reupload a smaller file");
			}
		}
	}
}
