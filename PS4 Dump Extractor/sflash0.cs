using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PS4_Dump_Extractor
{
    class sflash0
    {
        static byte[] bufferA = new byte[0];



        public static byte[] GetHeader(string dump)
        {
            using (BinaryReader b = new BinaryReader(new FileStream(dump, FileMode.Open)))
            {
                bufferA = new byte[4096];
                b.BaseStream.Seek(0x000000, SeekOrigin.Begin);
                b.Read(bufferA, 0, 4096);
                return bufferA;
            }
        }

        public static byte[] GetUnk(string dump)
        {
            using (BinaryReader b = new BinaryReader(new FileStream(dump, FileMode.Open)))
            {
                bufferA = new byte[4096];
                b.BaseStream.Seek(0x001000, SeekOrigin.Begin);
                b.Read(bufferA, 0, 4096);
                return bufferA;
            }
        }

        public static byte[] GetMBR1(string dump)
        {
            using (BinaryReader b = new BinaryReader(new FileStream(dump, FileMode.Open)))
            {
                bufferA = new byte[4096];
                b.BaseStream.Seek(0x2000, SeekOrigin.Begin);
                b.Read(bufferA, 0, 4096);
                return bufferA;
            }
        }

        public static byte[] GetMBR2(string dump)
        {
            using (BinaryReader b = new BinaryReader(new FileStream(dump, FileMode.Open)))
            {
                bufferA = new byte[4096];
                b.BaseStream.Seek(0x3000, SeekOrigin.Begin);
                b.Read(bufferA, 0, 4096);
                return bufferA;
            }
        }

        public static byte[] Getsflash0s0x32b(string dump)
        {
            using (BinaryReader b = new BinaryReader(new FileStream(dump, FileMode.Open)))
            {
                bufferA = new byte[393216];
                b.BaseStream.Seek(0x4000, SeekOrigin.Begin);
                b.Read(bufferA, 0, 393216);
                return bufferA;
            }
        }

        public static byte[] Getsflash0s0x32(string dump)
        {
            using (BinaryReader b = new BinaryReader(new FileStream(dump, FileMode.Open)))
            {
                bufferA = new byte[393216];
                b.BaseStream.Seek(0x64000, SeekOrigin.Begin);
                b.Read(bufferA, 0, 393216);
                return bufferA;
            }
        }

        public static byte[] Getsflash0s0x33(string dump)
        {
            using (BinaryReader b = new BinaryReader(new FileStream(dump, FileMode.Open)))
            {
                bufferA = new byte[524288];
                b.BaseStream.Seek(0xC4000, SeekOrigin.Begin);
                b.Read(bufferA, 0, 524288);
                return bufferA;
            }
        }

        public static byte[] Getsflash0s0x34(string dump)
        {
            using (BinaryReader b = new BinaryReader(new FileStream(dump, FileMode.Open)))
            {
                bufferA = new byte[524288];
                b.BaseStream.Seek(0x144000, SeekOrigin.Begin);
                b.Read(bufferA, 0, 524288);
                return bufferA;
            }
        }

        public static byte[] Getsflash0s0x38(string dump)
        {
            using (BinaryReader b = new BinaryReader(new FileStream(dump, FileMode.Open)))
            {
                bufferA = new byte[49152];
                b.BaseStream.Seek(0x1C4000, SeekOrigin.Begin);
                b.Read(bufferA, 0, 49152);
                return bufferA;
            }
        }

        public static byte[] Getsflash0s0x0(string dump)
        {
            using (BinaryReader b = new BinaryReader(new FileStream(dump, FileMode.Open)))
            {
                bufferA = new byte[196608];
                b.BaseStream.Seek(0x1D0000, SeekOrigin.Begin);
                b.Read(bufferA, 0, 196608);
                return bufferA;
            }
        }

        public static byte[] GetHeader2(string dump)
        {
            using (BinaryReader b = new BinaryReader(new FileStream(dump, FileMode.Open)))
            {
                bufferA = new byte[4096];
                b.BaseStream.Seek(0x200000, SeekOrigin.Begin);
                b.Read(bufferA, 0, 4096);
                return bufferA;
            }
        }

        public static byte[] GetUnk2(string dump)
        {
            using (BinaryReader b = new BinaryReader(new FileStream(dump, FileMode.Open)))
            {
                bufferA = new byte[4096];
                b.BaseStream.Seek(0x201000, SeekOrigin.Begin);
                b.Read(bufferA, 0, 4096);
                return bufferA;
            }
        }

        public static byte[] GetMBR3(string dump)
        {
            using (BinaryReader b = new BinaryReader(new FileStream(dump, FileMode.Open)))
            {
                bufferA = new byte[4096];
                b.BaseStream.Seek(0x202000, SeekOrigin.Begin);
                b.Read(bufferA, 0, 4096);
                return bufferA;
            }
        }

        public static byte[] GetMBR4(string dump)
        {
            using (BinaryReader b = new BinaryReader(new FileStream(dump, FileMode.Open)))
            {
                bufferA = new byte[4096];
                b.BaseStream.Seek(0x203000, SeekOrigin.Begin);
                b.Read(bufferA, 0, 4096);
                return bufferA;
            }
        }

        public static byte[] Getsflash0s1_cryptx2b(string dump)
        {
            using (BinaryReader b = new BinaryReader(new FileStream(dump, FileMode.Open)))
            {
                bufferA = new byte[253952];
                b.BaseStream.Seek(0x204000, SeekOrigin.Begin);
                b.Read(bufferA, 0, 253952);
                return bufferA;
            }
        }

        public static byte[] Getsflash0s1_cryptx2(string dump)
        {
            using (BinaryReader b = new BinaryReader(new FileStream(dump, FileMode.Open)))
            {
                bufferA = new byte[253952];
                b.BaseStream.Seek(0x242000, SeekOrigin.Begin);
                b.Read(bufferA, 0, 253952);
                return bufferA;
            }
        }

        public static byte[] Getsflash0s1_cryptx1(string dump)
        {
            using (BinaryReader b = new BinaryReader(new FileStream(dump, FileMode.Open)))
            {
                bufferA = new byte[524288];
                b.BaseStream.Seek(0x280000, SeekOrigin.Begin);
                b.Read(bufferA, 0, 524288);
                return bufferA;
            }
        }

        public static byte[] Getsflash0s1_cryptx39(string dump)
        {
            using (BinaryReader b = new BinaryReader(new FileStream(dump, FileMode.Open)))
            {
                bufferA = new byte[524288];
                b.BaseStream.Seek(0x300000, SeekOrigin.Begin);
                b.Read(bufferA, 0, 524288);
                return bufferA;
            }
        }

        public static byte[] Getsflash0s1_cryptx6(string dump)
        {
            using (BinaryReader b = new BinaryReader(new FileStream(dump, FileMode.Open)))
            {
                bufferA = new byte[262144];
                b.BaseStream.Seek(0x380000, SeekOrigin.Begin);
                b.Read(bufferA, 0, 262144);
                return bufferA;
            }
        }

        public static byte[] Getsflash0s1_cryptx3b(string dump)
        {
            using (BinaryReader b = new BinaryReader(new FileStream(dump, FileMode.Open)))
            {
                bufferA = new byte[13369344];
                b.BaseStream.Seek(0x3C0000, SeekOrigin.Begin);
                b.Read(bufferA, 0, 13369344);
                return bufferA;
            }
        }

        public static byte[] Getsflash0s1_cryptx3(string dump)
        {
            using (BinaryReader b = new BinaryReader(new FileStream(dump, FileMode.Open)))
            {
                bufferA = new byte[13369344];
                b.BaseStream.Seek(0x1080000, SeekOrigin.Begin);
                b.Read(bufferA, 0, 13369344);
                return bufferA;
            }
        }

        public static byte[] Getsflash0s1_cryptx40(string dump)
        {
            using (BinaryReader b = new BinaryReader(new FileStream(dump, FileMode.Open)))
            {
                bufferA = new byte[2883584];
                b.BaseStream.Seek(0x1D40000, SeekOrigin.Begin);
                b.Read(bufferA, 0, 2883584);
                return bufferA;
            }
        }

    }
}
