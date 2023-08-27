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
                    FileInfo[] allFiles = dir.GetFiles();
                    Console.WriteLine("Found {0} files in Downloads folder\n", allFiles.Length);

            FileInfo[] pngFiles = dir.GetFiles("*.png");
            FileInfo[] jpgFiles = dir.GetFiles("*.jpg");
            FileInfo[] avifFiles = dir.GetFiles("*.avif");
            String imgPath = @"C:\Users\LehlohonoloRamakatan\OneDrive - Flash\Pictures\Organizer\";

            FileInfo[] pdfFiles = dir.GetFiles("*.pdf");
            FileInfo[] docxFiles = dir.GetFiles("*.docx");
            FileInfo[] ymlFiles = dir.GetFiles("*.yml");
            FileInfo[] bashFiles = dir.GetFiles("*.sh");
            FileInfo[] exeFiles = dir.GetFiles("*.exe");
            FileInfo[] pptxFiles = dir.GetFiles("*.pptx");
            FileInfo[] txtFiles = dir.GetFiles("*.txt");
            String docuPath = @"C:\Users\LehlohonoloRamakatan\OneDrive - Flash\Documents\Organizer\";

            FileInfo[] mp4Files = dir.GetFiles("*.mp4");
            String vidsPath = @"C:\Users\LehlohonoloRamakatan\Videos\Organizer\";
            
            FileInfo[] mp3Files = dir.GetFiles("*.mp3");
            String musicPath = @"C:\Users\LehlohonoloRamakatan\Music\Organizer\";


            Console.WriteLine("Found {0} *.png files\n", pngFiles.Length);
            Console.WriteLine("Found {0} *.jpg files\n", jpgFiles.Length);
            Console.WriteLine("Found {0} *.pdf files\n", pdfFiles.Length);

            //I can already see a problem with this. Each new file extension will need a new foreach loop
            foreach (FileInfo f in pngFiles)
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
                        Console.WriteLine("{0} was moved to {1}.", f.Name, imgPath);
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("The process failed: {0}", e.ToString());
                }
            }

            foreach (FileInfo f in jpgFiles)
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
                        Console.WriteLine("{0} was moved to {1}.", f.Name, imgPath);
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("The process failed: {0}", e.ToString());
                }
            }

            foreach (FileInfo f in pdfFiles)
            {
                try
                {
                    if (!Directory.Exists(docuPath))
                    {
                        Directory.CreateDirectory(docuPath);
                    }
                    else
                    {
                        File.Move(f.FullName, docuPath + f.Name, true);
                        Console.WriteLine("{0} was moved to {1}.", f.Name, docuPath);
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("The process failed: {0}", e.ToString());
                }
            }

            /*            foreach (FileInfo file in allFiles)
                        {
                            try
                            {
                               var ext = file.Extension;                  
                                // Console.WriteLine(ext);
                                //TODO: Even if the file is a .jpg format, it's not getting moved...
                                if (ext == "*.jpg")
                                {

                                    String imgPath = @"C:\Users\LehlohonoloRamakatan\Pictures\Organizer\";
                                    File.Move(file.FullName, imgPath + file.Name, true);
                                    Console.WriteLine("{0} was moved to {1}.", file.FullName, imgPath + file.Name);
                                }

                            }
                            catch (Exception e) {

                                Console.WriteLine(e.ToString());

                            }
                        }*/

            /*  Console.WriteLine("File name: {0}", f.Name);
                Console.WriteLine("File size: {0}", f.Length);
                Console.WriteLine("Creation: {0}", f.CreationTime);
                Console.WriteLine("Attributes: {0}", f.Attributes);*/

        }
    }
}