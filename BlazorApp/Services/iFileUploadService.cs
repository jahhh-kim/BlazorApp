using BlazorInputFile;
using Microsoft.AspNetCore.Hosting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp.Services
{
    public interface IFileUploadService
    {
        Task UploadAsync(IFileListEntry file);
    }
    public class FileUploadService : IFileUploadService
    {
        private readonly IWebHostEnvironment _envirment; //주사기 주입한다는 의미로 언더스코어 붙인다

        public FileUploadService(IWebHostEnvironment env)
        {
            this._envirment = env;
        }

        public async Task UploadAsync(IFileListEntry fileEntry)
        {
            var path = Path.Combine(_envirment.WebRootPath, "Upload", fileEntry.Name);
            var ms = new MemoryStream();
            await fileEntry.Data.CopyToAsync(ms);
            using (FileStream file = new FileStream(path, FileMode.Create, FileAccess.Write))
            {
                ms.WriteTo(file);

            }
        }
    }
}
