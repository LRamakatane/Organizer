using System.Diagnostics;

namespace Organizer
{
    class Program
    {
        static void Main(string[] args)
        {

            DirectoryInfo dir = new DirectoryInfo(@"C:\Users\LehlohonoloRamakatan\Downloads");
            //TODO: How to handle other image formats e.g *.jpg
            FileInfo[] imageFiles = dir.GetFiles("*.png");
            String imgPath = @"C:\Users\LehlohonoloRamakatan\OneDrive - Flash\Pictures\Organizer\";

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
                        /*File.Move(f.FullName, imgPath);*/
                        f.MoveTo(imgPath);
                        Console.WriteLine("{0} was moved to {1}.", f.FullName, imgPath);
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("The process failed: {0}", e.ToString());
                    /* 
                     * Currently getting this error:
                     * 
                       System.IO.IOException: Cannot create a file when that file already exists.
                       at System.IO.FileSystem.MoveFile(String sourceFullPath, String destFullPath, Boolean overwrite)
                    */
                }

                //Console.WriteLine("File name: {0}", f.Name);
                //TODO: Error handling incase directory doesn't exist. 
                //f.MoveTo(imgPath);
                /*                Console.WriteLine("File size: {0}", f.Length);
                                Console.WriteLine("Creation: {0}", f.CreationTime);
                                Console.WriteLine("Attributes: {0}", f.Attributes);*/

            }


        }
    }
}