using System.Diagnostics;

namespace Organizer
{
    class Program
    {
        static void Main(string[] args)
        {

            DirectoryInfo dir = new DirectoryInfo(@"C:\Users\LehlohonoloRamakatan\Downloads");
            /*TODO: How to handle other image formats e.g *.jpg & other file formats e.g *.pdf
                    Or maybe get all files instead of images and the sort them within the foreach loop*/
            FileInfo[] imageFiles = dir.GetFiles("*.png");
            String imgPath = @"C:\Users\LehlohonoloRamakatan\Pictures\Organizer\";

            Console.WriteLine("Found {0} *.png files\n", imageFiles.Length);

            foreach (FileInfo f in imageFiles)
            {
                try
                {
                    if (!Directory.Exists(imgPath))
                    {
                        Directory.CreateDirectory(imgPath);
                    }
                    else
                    {
                        File.Move(f.FullName, imgPath + f.Name, true);
                        Console.WriteLine("{0} was moved to {1}.", f.FullName, imgPath + f.Name);
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("The process failed: {0}", e.ToString());
                }

                /*Console.WriteLine("File name: {0}", f.Name);
                  Console.WriteLine("File size: {0}", f.Length);
                  Console.WriteLine("Creation: {0}", f.CreationTime);
                  Console.WriteLine("Attributes: {0}", f.Attributes);*/

            }


        }
    }
}