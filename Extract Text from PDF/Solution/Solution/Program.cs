using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Imaging;
using System.Drawing;
using tessnet2;

namespace Solution
{
    class Program
    {
        static void Main(string[] args)
        {


            var testImagePath = @"C:\Users\manis\Documents\copart-internship.github.io\Extract Text from PDF\Title Doc\title_arkansas.jpg";
            var dataPath = @"C:\Users\manis\Documents\copart-internship.github.io\Extract Text from PDF\Solution\Solution\tessdata\";

            try
            {
                var image = new Bitmap(testImagePath);
                var ocr = new Tesseract();
                ocr.SetVariable("tessedit_char_whitelist", "0123456789abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ"); // If digit only
                //@"C:\OCRTest\tessdata" contains the language package, without this the method crash and app breaks
                ocr.Init(dataPath, "eng", true);
                var result = ocr.DoOCR(image, Rectangle.Empty);
                foreach (Word word in result)
                    Console.WriteLine("{0} : {1}", word.Confidence, word.Text);

                Console.ReadLine();
            }
            catch (Exception exception)
            {
                Console.WriteLine("Error: " + exception.Message);
            }

        }
    }
}
