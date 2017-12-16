using System.IO;
using Xamarin.Forms;
using Exemplo2.UWP;
using Windows.Storage;

[assembly: Dependency(typeof(FileHelper))]
namespace Exemplo2.UWP
{
    public class FileHelper : IFileHelper
    {
        public string GetLocalFilePath(string filename)
        {
            return Path.Combine(ApplicationData.Current.LocalFolder.Path, filename);
        }
    }
}
