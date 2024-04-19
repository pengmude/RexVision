using HalconDotNet;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using VisionCore;

namespace Plugin.Camera
{
    public class HobjectToBimp
    {
        //其中CopyMemory的API引用 需要引入命名空间 using System.Runtime.InteropServices; 和如下代码

        [DllImport("kernel32.dll")]
        public static extern void CopyMemory(int Destination, int add, int Length);

        /// <summary>
        /// HObject转8位Bitmap(单通道)
        /// </summary>
        /// <param name="image"></param>
        /// <param name="res"></param>
        public static void HObject2Bpp8(HObject image, out Bitmap res)
        {
            try
            {
                HTuple hpoint, type, width, height;

                const int Alpha = 255;
                int[] ptr = new int[2];
                HOperatorSet.GetImagePointer1(image, out hpoint, out type, out width, out height);

                res = new Bitmap(width, height, PixelFormat.Format8bppIndexed);
                ColorPalette pal = res.Palette;
                for (int i = 0; i <= 255; i++)
                {
                    pal.Entries[i] = Color.FromArgb(Alpha, i, i, i);
                }
                res.Palette = pal;
                Rectangle rect = new Rectangle(0, 0, width, height);
                BitmapData bitmapData = res.LockBits(rect, ImageLockMode.WriteOnly, PixelFormat.Format8bppIndexed);
                int PixelSize = Bitmap.GetPixelFormatSize(bitmapData.PixelFormat) / 8;
                ptr[0] = bitmapData.Scan0.ToInt32();
                ptr[1] = hpoint.I;
                if (width % 4 == 0)
                    CopyMemory(ptr[0], ptr[1], width * height * PixelSize);
                else
                {
                    for (int i = 0; i < height - 1; i++)
                    {
                        ptr[1] += width;
                        CopyMemory(ptr[0], ptr[1], width * PixelSize);
                        ptr[0] += bitmapData.Stride;
                    }
                }
                res.UnlockBits(bitmapData);
            }
            catch (Exception ex)
            {
                res = null;
                Log.Info(ex.Message);
            }
        }
        /// <summary>
        /// HObject转24位Bitmap
        /// </summary>
        /// <param name="image"></param>
        /// <param name="res"></param>
        public static void HObject2Bpp24(HObject image, out Bitmap res)
        {
            try
            {
                HTuple hred, hgreen, hblue, type, width, height;

                HOperatorSet.GetImagePointer3(image, out hred, out hgreen, out hblue, out type, out width, out height);

                res = new Bitmap(width, height, System.Drawing.Imaging.PixelFormat.Format32bppRgb);

                Rectangle rect = new Rectangle(0, 0, width, height);
                BitmapData bitmapData = res.LockBits(rect, ImageLockMode.ReadWrite, PixelFormat.Format32bppRgb);
                int imglength = width * height;
                unsafe
                {
                    byte* bptr = (byte*)bitmapData.Scan0;
                    byte* r = ((byte*)hred.I);
                    byte* g = ((byte*)hgreen.I);
                    byte* b = ((byte*)hblue.I);
                    for (int i = 0; i < imglength; i++)
                    {
                        bptr[i * 4] = (b)[i];
                        bptr[i * 4 + 1] = (g)[i];
                        bptr[i * 4 + 2] = (r)[i];
                        bptr[i * 4 + 3] = 255;
                    }
                }

                res.UnlockBits(bitmapData);
            }
            catch (Exception ex)
            {
                res = null;
                Log.Info(ex.Message);
            }
        }

        //net4.5及以上环境的hobject转bitmap24方法

        /// <summary>
        /// HObject转24位Bitmap,net4.5及以上版本
        /// </summary>
        /// <param name="image"></param>
        /// <param name="res"></param>
        public static void HObject2Bpp24Net45(HObject image, out Bitmap res)
        {
            try
            {
                HTuple hred, hgreen, hblue, type, width, height;

                HOperatorSet.GetImagePointer3(image, out hred, out hgreen, out hblue, out type, out width, out height);
                res = new Bitmap(width, height, System.Drawing.Imaging.PixelFormat.Format32bppRgb);
                Rectangle rect = new Rectangle(0, 0, width, height);
                BitmapData bitmapData = res.LockBits(rect, ImageLockMode.ReadWrite, PixelFormat.Format32bppRgb);
                int imglength = width * height;
                unsafe
                {
                    byte* bptr = (byte*)bitmapData.Scan0;
                    byte* r = ((byte*)hred.L);
                    byte* g = ((byte*)hgreen.L);
                    byte* b = ((byte*)hblue.L);
                    for (int i = 0; i < imglength; i++)
                    {
                        bptr[i * 4] = (b)[i];
                        bptr[i * 4 + 1] = (g)[i];
                        bptr[i * 4 + 2] = (r)[i];
                        bptr[i * 4 + 3] = 255;
                    }
                }

                res.UnlockBits(bitmapData);
            }
            catch (Exception ex)
            {
                res = null;
                Log.Info(ex.Message);
            }
        }



        // <summary>
        /// 灰度图像 HObject -> Bitmap
        /// </summary>
        public static Bitmap HObject2Bitmap(HObject ho)
        {
            try
            {
                HTuple type, width, height, pointer;
                //HOperatorSet.AccessChannel(ho, out ho, 1);
                HOperatorSet.GetImagePointer1(ho, out pointer, out type, out width, out height);
                //himg.GetImagePointer1(out type, out width, out height);

                Bitmap bmp = new Bitmap(width.I, height.I, PixelFormat.Format8bppIndexed);
                ColorPalette pal = bmp.Palette;
                for (int i = 0; i <= 255; i++)
                {
                    pal.Entries[i] = Color.FromArgb(255, i, i, i);
                }
                bmp.Palette = pal;
                BitmapData bitmapData = bmp.LockBits(new Rectangle(0, 0, width, height), ImageLockMode.WriteOnly, PixelFormat.Format8bppIndexed);
                int PixelSize = Bitmap.GetPixelFormatSize(bitmapData.PixelFormat) / 24;
                int stride = bitmapData.Stride;
                int ptr = height;// bitmapData.Scan0.ToInt32();
                for (int i = 0; i < height; i++)
                {
                    CopyMemory(ptr, pointer, width * PixelSize);
                    pointer += width;
                    ptr += bitmapData.Stride;
                }

                bmp.UnlockBits(bitmapData);
                return bmp;
            }
            catch (Exception exc)
            {
                return null;
            }
        }
        /// <summary>
        /// 灰度图像 HObject -> HImage1
        /// </summary>
        public HImage HObject2HImage1(HObject hObj)
        {
            HImage image = new HImage();
            HTuple type, width, height, pointer;
            HOperatorSet.GetImagePointer1(hObj, out pointer, out type, out width, out height);
            image.GenImage1(type, width, height, pointer);
            return image;
        }

        /// <summary>
        /// 彩色图像 HObject -> HImage3
        /// </summary>
        public HImage HObject2HImage3(HObject hObj)
        {
            HImage image = new HImage();
            HTuple type, width, height, pointerRed, pointerGreen, pointerBlue;
            HOperatorSet.GetImagePointer3(hObj, out pointerRed, out pointerGreen, out pointerBlue,
                           out type, out width, out height);
            image.GenImage3(type, width, height, pointerRed, pointerGreen, pointerBlue);
            return image;
        }




        //bmp = new Bitmap(1000, 1000);
        //Graphics g = Graphics.FromImage(bmp);
        //g.Clear(Color.White);
        //    g.Dispose();
        //    newPictureBox1.Image = bmp;
        //    //newPictureBox1.
        //    newPictureBox1.Initialize_pic();
        public static Bitmap CvtHObj2Bmp(HObject vImg)
        {
            Bitmap tBmp;
            HTuple hpoint, type, width, height;
            const int Alpha = 255;
            IntPtr[] ptr = new IntPtr[2];
            HOperatorSet.GetImagePointer1(vImg, out hpoint, out type, out width, out height);

            tBmp = new Bitmap(width, height, PixelFormat.Format8bppIndexed);
            ColorPalette pal = tBmp.Palette;
            for (int i = 0; i <= 255; i++)
            {
                pal.Entries[i] = Color.FromArgb(Alpha, i, i, i);
            }
            tBmp.Palette = pal;
            Rectangle rect = new Rectangle(0, 0, width, height);
            BitmapData bitmapData = tBmp.LockBits(rect, ImageLockMode.WriteOnly, PixelFormat.Format8bppIndexed);
            int PixelSize = Bitmap.GetPixelFormatSize(bitmapData.PixelFormat) / 8;
            ptr[0] = bitmapData.Scan0;
            ptr[1] = hpoint;
            if (width % 4 == 0)
            {
                memcpy(ptr[0], ptr[1], width * height * PixelSize);
            }
            else
            {
                for (int i = 0; i < height - 1; i++)
                {
                    ptr[1] = (ptr[1].ToInt64() + width);
                    memcpy(ptr[0], ptr[1], width * PixelSize);
                    ptr[0] += bitmapData.Stride;
                }
            }
            tBmp.UnlockBits(bitmapData);
            return tBmp;
        }
        [DllImport("msvcrt.dll", CallingConvention = CallingConvention.Cdecl)]
        private static extern int memcpy(IntPtr dst, IntPtr src, int bytes);

    }

}

