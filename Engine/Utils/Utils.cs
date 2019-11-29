using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Utils
{
    public class Utils
    {
        //public static void SaveScreenshot(string filename, GraphicsDevice graphics)
        //{
        //    int w = graphics.PresentationParameters.BackBufferWidth;
        //    int h = graphics.PresentationParameters.BackBufferHeight;

        //    filename += DateTime.Now.ToString("MM-dd-yy-mm-ss");

        //    int[] backbuffer = new int[w * h];
        //    graphics.GetBackBufferData(backbuffer);

        //    Texture2D screenshot = new Texture2D(graphics, w, h, false, graphics.PresentationParameters.BackBufferFormat);
        //    screenshot.SetData(backbuffer);

        //    if (!File.Exists(Path.Combine(
        //            Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
        //            "IdleBouncer", "Screenshots")))
        //    {
        //        Directory.CreateDirectory(Path.Combine(
        //            Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
        //            "IdleBouncer", "Screenshots"));
        //    }
        //    var stream = File.OpenWrite(
        //    Path.Combine(
        //        Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
        //        "IdleBouncer", "Screenshots", $"{filename}.png"));

        //    screenshot.SaveAsPng(stream, w, h);
        //    stream.Dispose();
        //    screenshot.Dispose();
        //}
    }
}
