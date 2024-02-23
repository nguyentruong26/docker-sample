using Microsoft.AspNetCore.Mvc;

namespace DockerBignner.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FileController : ControllerBase
    {
        private readonly ILogger<FileController> _logger;
        private readonly TestContext _contextFactory;

        public FileController(ILogger<FileController> logger, TestContext contextFactory)
        {
            _logger = logger;
            _contextFactory = contextFactory;
        }

        [HttpGet(Name = "FileList")]
        public IEnumerable<File> GetFileList()
        {
            var fileList = _contextFactory.Files;
            return fileList.ToList();
        }
    } 
}
