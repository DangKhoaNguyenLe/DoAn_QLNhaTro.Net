using CloudinaryDotNet;
using CloudinaryDotNet.Actions;

namespace GUI
{
    public class ImageProcess
    {
        private Cloudinary cloudinary;

        public ImageProcess()
        {
            cloudinary = new Cloudinary(new Account(
                "dr9dnapj4",
                "813398647145949",
                "ASKbyIrKBs30Ntc-6UTxHjdXksQ"
            ));

            cloudinary.Api.Secure = true; 
        }

      
        public string UploadImage(string filePath)
        {
            var upload = new ImageUploadParams()
            {
                File = new FileDescription(filePath),
                Folder = "nhatro",
                UseFilename = false,
                UniqueFilename = true,
                Overwrite = false
            };

            var uploadResult = cloudinary.Upload(upload);

            return uploadResult.SecureUrl.ToString();
        }
    }
}
