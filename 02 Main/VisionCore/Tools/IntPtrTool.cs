using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace VisionCore
{
    public static class IntPtrTool
    {
        public static IntPtr Bytes2IntPtr(byte[] bytes)
        {
            GCHandle handle = GCHandle.Alloc(bytes, GCHandleType.Pinned);
            IntPtr ptr = handle.AddrOfPinnedObject();
            if (handle.IsAllocated)
            {
                handle.Free();
            }
            return ptr;
        }

        public static T BytesToStruct<T>(byte[] bytes, int startIndex, int length)
        {
            T local;
            if (bytes == null)
            {
                return default(T);
            }
            if (bytes.Length <= 0)
            {
                return default(T);
            }
            IntPtr destination = Marshal.AllocHGlobal(length);
            try
            {
                Marshal.Copy(bytes, startIndex, destination, length);
                local = (T)Marshal.PtrToStructure(destination, typeof(T));
            }
            catch (Exception exception)
            {
                throw new Exception("Error in BytesToStruct ! " + exception.Message);
            }
            finally
            {
                Marshal.FreeHGlobal(destination);
            }
            return local;
        }

        public static byte[] IntPtr2Bytes(IntPtr ptr, int size)
        {
            byte[] destination = new byte[size];
            Marshal.Copy(ptr, destination, 0, size);
            return destination;
        }

        public static T[] IntPtr2Ts<T>(IntPtr ptr, int size)
        {
            T[] localArray = new T[size];
            if (localArray is int[])
            {
                int[] destination = localArray as int[];
                Marshal.Copy(ptr, destination, 0, size);
                return localArray;
            }
            if (localArray is byte[])
            {
                byte[] buffer = localArray as byte[];
                Marshal.Copy(ptr, buffer, 0, size);
                return localArray;
            }
            if (localArray is float[])
            {
                float[] numArray2 = localArray as float[];
                Marshal.Copy(ptr, numArray2, 0, size);
                return localArray;
            }
            return null;
        }

        public static void PtrToStructure<T>(IntPtr ptr, ref T structure)
        {
            structure = (T)Marshal.PtrToStructure(ptr, typeof(T));
            Marshal.FreeHGlobal(ptr);
        }

        public static T[] PtrToStructursArr<T>(IntPtr pt, int lenth)
        {
            T[] localArray = new T[lenth];
            for (int i = 0; i < lenth; i++)
            {
                long a = (long)pt;
                IntPtr ptr = (IntPtr)(((long)pt) + (i * Marshal.SizeOf(typeof(T))));

                localArray[i] = (T)Marshal.PtrToStructure(ptr, typeof(T));
            }
            return localArray;
        }

        public static List<T> PtrToStructursList<T>(IntPtr pt, int lenth)
        {
            List<T> localArray = new List<T>();
            for (int i = 0; i < lenth; i++)
            {
                long a = (long)pt;
                IntPtr ptr = (IntPtr)(((long)pt) + (i * Marshal.SizeOf(typeof(T))));

                localArray.Add((T)Marshal.PtrToStructure(ptr, typeof(T)));
            }
            return localArray;
        }

        public static byte[] StructToBytes(object structObj, int size)
        {
            byte[] buffer2;
            IntPtr ptr = Marshal.AllocHGlobal(size);
            try
            {
                Marshal.StructureToPtr(structObj, ptr, false);
                byte[] destination = new byte[size];
                Marshal.Copy(ptr, destination, 0, size);
                buffer2 = destination;
            }
            catch (Exception exception)
            {
                throw new Exception("Error in StructToBytes ! " + exception.Message);
            }
            finally
            {
                Marshal.FreeHGlobal(ptr);
            }
            return buffer2;
        }

        public static IntPtr StructureToPtr(object structure)
        {
            IntPtr ptr = Marshal.AllocCoTaskMem(Marshal.SizeOf(structure));
            Marshal.StructureToPtr(structure, ptr, true);
            return ptr;
        }

        public static void StructureToPtr(object structure, IntPtr ptr)
        {
            ptr = Marshal.AllocCoTaskMem(Marshal.SizeOf(structure));
            Marshal.StructureToPtr(structure, ptr, true);
        }
    }
}
