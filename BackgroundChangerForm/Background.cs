using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Runtime.InteropServices;
using Microsoft.Win32;
using System.IO;
using System.Threading;
using System.Windows.Forms;
namespace BackgroundChangerForm
{
    public partial class Form1
    {

        public static LinkedList<String> files = new LinkedList<String>();
        public static LinkedList<String> files_fav = new LinkedList<String>();
        public static Queue<String> files_exc = new Queue<String>();
        private static Random randNum = new Random();
        public static String pathDir;
        public static int countdown;
        public static String excludeFileName;
        public static String configFileName;
        public static String favFileName;
        public static int bufferSize;
        public static int currentStyle;
        public static int favFreq;

        public static void get_images_from_path(string dir)
        {
            try
            {
                foreach (string f in Directory.GetFiles(dir))
                {
                    files.AddLast(Path.GetFileName(f));
                }
            }
            catch
            {

            }
        }

        public static void get_image_exclusions(string f)
        {
            if(!File.Exists(f))
            {
                StreamWriter file = new StreamWriter(f);
                file.Close();
            }
            foreach (string line in File.ReadLines(f))
            {
                files_exc.Enqueue(line);
            }
        }

        public static string get_random_favorite()
        {
            int rNum = get_random_num(0, files_fav.Count);
            return files_fav.ElementAt(rNum);
        }

        public static void get_image_favorites(string f)
        {
            if (!File.Exists(f))
            {
                StreamWriter file = new StreamWriter(f);
                file.Close();
            }
            foreach (string line in File.ReadLines(f))
            {
                Console.WriteLine(line);
                files_fav.AddFirst(line);
            }
        }

        public static void remove_excluded_images()
        {
           foreach (string ex in files_exc)
            {
                files.Remove(ex);
            }
        }

        public static int get_random_num(int min, int max)
        {
            lock (randNum)
            {
                return randNum.Next(min, max);
            }
        }

        public static void randomize_images()
        {
            int imgCount = files.Count;
            for(int i = 0; i < imgCount; i++)
            {
                int rNum = get_random_num(0, imgCount);
                string temp = files.ElementAt(rNum);
                files.Find(files.ElementAt(rNum)).Value = files.ElementAt(i);
                files.Find(files.ElementAt(i)).Value = temp;
            }
        }

        public static void add_to_exclusions(string img)
        {
            if (!files_fav.Contains(img))
            {
                if (files_exc.Count >= bufferSize)
                {
                    files_exc.Enqueue(img);
                    files.AddLast(files_exc.Dequeue());
                }
                else
                {
                    files_exc.Enqueue(img);
                }
            }
        }

        public static void add_to_fav(string img)
        {
            files_fav.AddLast(img);
        }

        public static void remove_from_fav(string img)
        {
            files_fav.Remove(img);
        }


        public static void write_list_to_excfile(string file)
        {
            StreamWriter f = new StreamWriter(file);
            foreach (string ex in files_exc)
            {
                f.WriteLine(ex);
            }
            f.Close();
        }

        public static void write_list_to_favfile(string file)
        {
            StreamWriter f = new StreamWriter(file);
            foreach (string ex in files_fav)
            {
                f.WriteLine(ex);
            }
            f.Close();
        }

        public static void update_config_file(string file)
        {
            StreamWriter f = new StreamWriter(file);
            f.WriteLine(pathDir);
            f.WriteLine(countdown);
            f.WriteLine(bufferSize);
            f.WriteLine(currentStyle);
            f.WriteLine(favFreq);
            f.Close();
        }

        public enum PicStyle
        {
            Tile, Center, Stretch, Fit, Fill, Span
        }

        internal sealed class NativeMethods
        {
            [DllImport("user32.dll", CharSet = CharSet.Auto)]
            internal static extern int SystemParametersInfo(
                int uAction,
                int uParam,
                String lpvParam,
                int fuWinIni
                );
        }

        public static void set_background(string path, PicStyle style)
        {
            Console.WriteLine("Setting " + Path.GetFileName(path) + " as background...");
            RegistryKey key = Registry.CurrentUser.OpenSubKey(@"Control Panel\Desktop", true);
            switch (style)
            {
                case PicStyle.Tile:
                    key.SetValue(@"WallpaperStyle", "0");
                    key.SetValue(@"TileWallpaper", "1");
                    break;
                case PicStyle.Center:
                    key.SetValue(@"WallpaperStyleyle", "0");
                    key.SetValue(@"TileWallpaper", "0");
                    break;
                case PicStyle.Stretch:
                    key.SetValue(@"WallpaperStyle", "2");
                    key.SetValue(@"TileWallpaper", "0");
                    break;
                case PicStyle.Fit:
                    key.SetValue(@"WallpaperStyle", "6");
                    key.SetValue(@"TileWallpaper", "0");
                    break;
                case PicStyle.Fill:
                    key.SetValue(@"WallpaperStyle", "10");
                    key.SetValue(@"TileWallpaper", "0");
                    break;
                case PicStyle.Span:
                    key.SetValue(@"WallpaperStyle", "22");
                    key.SetValue(@"TileWallpaper", "0");
                    break;
            }
            key.Close();

            const int SET_DESKTOP_BACKGROUND = 20;
            const int UPDATE_INI_FILE = 1;
            const int SEND_WINDOWS_INI_CHANGE = 2;
            NativeMethods.SystemParametersInfo(SET_DESKTOP_BACKGROUND, 0, path, UPDATE_INI_FILE | SEND_WINDOWS_INI_CHANGE);
        }

    }
}
