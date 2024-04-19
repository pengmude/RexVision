using System;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;
using SharpDX;
using SharpDX.Direct2D1;
using SharpDX.DXGI;
using D2D = SharpDX.Direct2D1;
using DXGI = SharpDX.DXGI;
using AlphaMode = SharpDX.Direct2D1.AlphaMode;
using Bitmap = SharpDX.Direct2D1.Bitmap;
using PixelFormat = SharpDX.Direct2D1.PixelFormat;

namespace VisionCore
{
    public class SharpDXTool
    {
        public static Bitmap LoadFromFile(RenderTarget renderTarget, string file)
        {
            // Loads from file using System.Drawing.Image
            using (var bitmap = (System.Drawing.Bitmap)System.Drawing.Image.FromFile(file))
            {
                var sourceArea = new System.Drawing.Rectangle(0, 0, bitmap.Width, bitmap.Height);
                var bitmapProperties = new BitmapProperties(new PixelFormat(Format.R8G8B8A8_UNorm, AlphaMode.Premultiplied));
                var size = new Size2(bitmap.Width, bitmap.Height);

                // Transform pixels from BGRA to RGBA
                int stride = bitmap.Width * sizeof(int);
                using (var tempStream = new DataStream(bitmap.Height * stride, true, true))
                {
                    // Lock System.Drawing.Bitmap
                    var bitmapData = bitmap.LockBits(sourceArea, ImageLockMode.ReadOnly, System.Drawing.Imaging.PixelFormat.Format32bppPArgb);

                    // Convert all pixels 
                    for (int y = 0; y < bitmap.Height; y++)
                    {
                        int offset = bitmapData.Stride * y;
                        for (int x = 0; x < bitmap.Width; x++)
                        {
                            // Not optimized 
                            byte B = Marshal.ReadByte(bitmapData.Scan0, offset++);
                            byte G = Marshal.ReadByte(bitmapData.Scan0, offset++);
                            byte R = Marshal.ReadByte(bitmapData.Scan0, offset++);
                            byte A = Marshal.ReadByte(bitmapData.Scan0, offset++);
                            int rgba = R | (G << 8) | (B << 16) | (A << 24);
                            tempStream.Write(rgba);
                        }

                    }
                    bitmap.UnlockBits(bitmapData);
                    tempStream.Position = 0;

                    return new Bitmap(renderTarget, size, tempStream, stride, bitmapProperties);
                }
            }
        }

        public static Bitmap Convert2BitMap(RenderTarget renderTarget, System.Drawing.Bitmap bitmap)
        {

            var sourceArea = new System.Drawing.Rectangle(0, 0, bitmap.Width, bitmap.Height);
            var bitmapProperties = new BitmapProperties(new PixelFormat(Format.R8G8B8A8_UNorm, AlphaMode.Premultiplied));
            var size = new Size2(bitmap.Width, bitmap.Height);

            // Transform pixels from BGRA to RGBA
            int stride = bitmap.Width * sizeof(int);
            using (var tempStream = new DataStream(bitmap.Height * stride, true, true))
            {
                // Lock System.Drawing.Bitmap
                var bitmapData = bitmap.LockBits(sourceArea, ImageLockMode.ReadOnly, System.Drawing.Imaging.PixelFormat.Format32bppPArgb);

                // Convert all pixels 
                for (int y = 0; y < bitmap.Height; y++)
                {
                    int offset = bitmapData.Stride * y;
                    for (int x = 0; x < bitmap.Width; x++)
                    {
                        // Not optimized 
                        byte B = Marshal.ReadByte(bitmapData.Scan0, offset++);
                        byte G = Marshal.ReadByte(bitmapData.Scan0, offset++);
                        byte R = Marshal.ReadByte(bitmapData.Scan0, offset++);
                        byte A = Marshal.ReadByte(bitmapData.Scan0, offset++);
                        int rgba = R | (G << 8) | (B << 16) | (A << 24);
                        tempStream.Write(rgba);
                    }

                }
                bitmap.UnlockBits(bitmapData);
                tempStream.Position = 0;

                return new Bitmap(renderTarget, size, tempStream, stride, bitmapProperties);
            }
        }


        public static D2D.Bitmap ConvertFromSystemBitmap(RenderTarget renderTarget, System.Drawing.Bitmap bmp)
        {

            System.Drawing.Bitmap desBitmap;//预定义要是使用的bitmap				
                                            //如果原始的图像像素格式不是32位带alpha通道				
                                            //需要转换为32位带alpha通道的格式				
                                            //否则无法和Direct2D的格式对应				
            if (bmp.PixelFormat != System.Drawing.Imaging.PixelFormat.Format32bppPArgb)
            {
                desBitmap = new System.Drawing.Bitmap(bmp.Width, bmp.Height, System.Drawing.Imaging.PixelFormat.Format32bppPArgb);
                using (System.Drawing.Graphics g = System.Drawing.Graphics.FromImage(desBitmap))
                {
                    g.DrawImage(bmp, 0, 0);
                }
            }
            else
            {
                desBitmap = bmp;
            }


            //直接内存copy会非常快				
            //如果使用循环逐点转换会非常慢				
            System.Drawing.Imaging.BitmapData bmpData = desBitmap.LockBits(
            new System.Drawing.Rectangle(0, 0, desBitmap.Width, desBitmap.Height),
            System.Drawing.Imaging.ImageLockMode.ReadOnly,
            desBitmap.PixelFormat
            );
            int numBytes = bmpData.Stride * desBitmap.Height;
            byte[] byteData = new byte[numBytes];
            IntPtr ptr = bmpData.Scan0;
            System.Runtime.InteropServices.Marshal.Copy(ptr, byteData, 0, numBytes);
            desBitmap.UnlockBits(bmpData);


            D2D.BitmapProperties bp;
            D2D.PixelFormat pixelFormat = new D2D.PixelFormat(DXGI.Format.B8G8R8A8_UNorm, D2D.AlphaMode.Premultiplied);

            bp = new D2D.BitmapProperties(
            pixelFormat,
            desBitmap.HorizontalResolution,
            desBitmap.VerticalResolution
            );
            D2D.Bitmap tempBitmap = new D2D.Bitmap(renderTarget, new Size2(desBitmap.Width, desBitmap.Height), bp);
            tempBitmap.CopyFromMemory(byteData, bmpData.Stride);

            return tempBitmap;
        }



    }
}
