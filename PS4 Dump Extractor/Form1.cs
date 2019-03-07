using nor4ps;
using SLB2PS4;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tools;

namespace PS4_Dump_Extractor
{
    public partial class Form1 : Form
    {
        #region Variables
        static string bufferString, path, directoryName, filename;
        static byte[] bufferA = new byte[4];
        static byte[] bufferB = new byte[0];
        static int flag = 0;
        #endregion Variables

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            if (openPS4DMP.ShowDialog() == DialogResult.OK)
            {
                textOpen.Text = openPS4DMP.FileName;
                directoryName = Path.GetDirectoryName(textOpen.Text);
                if (PS4Nor.CheckHeader(textOpen.Text) == true)
                {
                    if (PS4Nor.CheckSize(textOpen.Text) == true)
                    {
                        checkBox1.Enabled = true;
                        checkBox2.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("PS4 Dump is corrupted");
                    }
                }
                else
                {
                    MessageBox.Show("Invalid file");
                }
            }
        }

        private void checkBox1_CheckStateChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked && !checkBox2.Checked)
            {
                checkBox2.Enabled = false;
                buttonExtractNow.Enabled = true;
            }
            else if(!checkBox1.Checked && checkBox2.Checked)
            {
                checkBox1.Enabled = true;
                buttonExtractNow.Enabled = true;
            }
            else if (!checkBox1.Checked && !checkBox2.Checked)
            {
                buttonExtractNow.Enabled = false;
                checkBox2.Enabled = true;
            }
        }

        private void checkBox2_CheckStateChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked && !checkBox1.Checked)
            {
                checkBox1.Enabled = false;
                buttonExtractNow.Enabled = true;
            }
            else if (!checkBox2.Checked && checkBox1.Checked)
            {
                checkBox2.Enabled = true;
                buttonExtractNow.Enabled = true;
            }
            else if (!checkBox1.Checked && !checkBox2.Checked)
            {
                buttonExtractNow.Enabled = false;
                checkBox1.Enabled = true;
            }
        }

        private void buttonExtractNow_Click(object sender, EventArgs e)
        {
            string path = Environment.CurrentDirectory;
            filename = Path.GetFileNameWithoutExtension(textOpen.Text);

            if (checkBox1.Checked)
            {
                if (!Directory.Exists(path + @"\flash_extracted\") == true)
                {
                    Directory.CreateDirectory(path + @"\flash_extracted\");
                    flag = 3;
                }
                if (flag == 3)
                {
                    int exception = 0;

                    try
                    {
                        PS4Nor.ExtractDump(textOpen.Text, path);
                    }
                    catch (Exception a)
                    {
                        MessageBox.Show(a.ToString());
                        exception = 1;
                    }
                    finally
                    {
                        if (exception != 1)
                        {
                            if (Directory.Exists(path + "\\" + filename + "_extracted\\"))
                            {
                                Directory.Delete(path + "\\" + filename + "_extracted\\", true);
                            }
                            System.IO.Directory.Move(path + @"\flash_extracted\", path + "\\" + filename + "_extracted\\");
                            MessageBox.Show("Extraction done", "Info");
                            System.Diagnostics.Process.Start("explorer.exe", path + "\\" + filename + "_extracted\\");
                        }
                    }
                }
            }
            else if (checkBox2.Checked)
            {
                string dir = path + "\\" + filename + "_sflash0";

                if (!Directory.Exists(path + "\\" + filename + "_sflash0"))
                {
                    Directory.CreateDirectory(dir);
                }

                //Header
                bufferB = sflash0.GetHeader(textOpen.Text);
                File.WriteAllBytes("Header.bin", bufferB);
                
                if (File.Exists(dir + "\\Header.bin"))
                {
                    File.Delete(dir + "\\Header.bin");
                }
                File.Move("Header.bin", dir + "\\Header.bin");

                //Unk
                bufferB = sflash0.GetUnk(textOpen.Text);
                File.WriteAllBytes("Unk.bin", bufferB);

                if (File.Exists(dir + "\\Unk.bin"))
                {
                    File.Delete(dir + "\\Unk.bin");
                }
                File.Move("Unk.bin", dir + "\\Unk.bin");

                //MBR1
                bufferB = sflash0.GetMBR1(textOpen.Text);
                File.WriteAllBytes("MBR1.bin", bufferB);

                if (File.Exists(dir + "\\MBR1.bin"))
                {
                    File.Delete(dir + "\\MBR1.bin");
                }
                File.Move("MBR1.bin", dir + "\\MBR1.bin");

                //MBR2
                bufferB = sflash0.GetMBR2(textOpen.Text);
                File.WriteAllBytes("MBR2.bin", bufferB);

                if (File.Exists(dir + "\\MBR2.bin"))
                {
                    File.Delete(dir + "\\MBR2.bin");
                }
                File.Move("MBR2.bin", dir + "\\MBR2.bin");

                //sflash0s0x32b 
                bufferB = sflash0.Getsflash0s0x32b(textOpen.Text);
                File.WriteAllBytes("sflash0s0x32b.bin", bufferB);

                if (File.Exists(dir + "\\sflash0s0x32b.bin"))
                {
                    File.Delete(dir + "\\sflash0s0x32b.bin");
                }
                File.Move("sflash0s0x32b.bin", dir + "\\sflash0s0x32b.bin");

                //sflash0s0x32  
                bufferB = sflash0.Getsflash0s0x32(textOpen.Text);
                File.WriteAllBytes("sflash0s0x32.bin", bufferB);

                if (File.Exists(dir + "\\sflash0s0x32.bin"))
                {
                    File.Delete(dir + "\\sflash0s0x32.bin");
                }
                File.Move("sflash0s0x32.bin", dir + "\\sflash0s0x32.bin");

                //sflash0s0x33  
                bufferB = sflash0.Getsflash0s0x33(textOpen.Text);
                File.WriteAllBytes("sflash0s0x33.bin", bufferB);

                if (File.Exists(dir + "\\sflash0s0x33.bin"))
                {
                    File.Delete(dir + "\\sflash0s0x33.bin");
                }
                File.Move("sflash0s0x33.bin", dir + "\\sflash0s0x33.bin");

                //sflash0s0x34  
                bufferB = sflash0.Getsflash0s0x34(textOpen.Text);
                File.WriteAllBytes("sflash0s0x34.bin", bufferB);

                if (File.Exists(dir + "\\sflash0s0x34.bin"))
                {
                    File.Delete(dir + "\\sflash0s0x34.bin");
                }
                File.Move("sflash0s0x34.bin", dir + "\\sflash0s0x34.bin");

                //sflash0s0x38   
                bufferB = sflash0.Getsflash0s0x38(textOpen.Text);
                File.WriteAllBytes("sflash0s0x38.bin", bufferB);

                if (File.Exists(dir + "\\sflash0s0x38.bin"))
                {
                    File.Delete(dir + "\\sflash0s0x38.bin");
                }
                File.Move("sflash0s0x38.bin", dir + "\\sflash0s0x38.bin");

                //sflash0s0x0    
                bufferB = sflash0.Getsflash0s0x0(textOpen.Text);
                File.WriteAllBytes("sflash0s0x0.bin", bufferB);

                if (File.Exists(dir + "\\sflash0s0x0.bin"))
                {
                    File.Delete(dir + "\\sflash0s0x0.bin");
                }
                File.Move("sflash0s0x0.bin", dir + "\\sflash0s0x0.bin");

                //Header2     
                bufferB = sflash0.GetHeader2(textOpen.Text);
                File.WriteAllBytes("Header2.bin", bufferB);

                if (File.Exists(dir + "\\Header2.bin"))
                {
                    File.Delete(dir + "\\Header2.bin");
                }
                File.Move("Header2.bin", dir + "\\Header2.bin");

                //Unk2     
                bufferB = sflash0.GetUnk2(textOpen.Text);
                File.WriteAllBytes("Unk2.bin", bufferB);

                if (File.Exists(dir + "\\Unk2.bin"))
                {
                    File.Delete(dir + "\\Unk2.bin");
                }
                File.Move("Unk2.bin", dir + "\\Unk2.bin");

                //MBR3     
                bufferB = sflash0.GetMBR3(textOpen.Text);
                File.WriteAllBytes("MBR3.bin", bufferB);

                if (File.Exists(dir + "\\MBR3.bin"))
                {
                    File.Delete(dir + "\\MBR3.bin");
                }
                File.Move("MBR3.bin", dir + "\\MBR3.bin");

                //MBR4
                bufferB = sflash0.GetMBR4(textOpen.Text);
                File.WriteAllBytes("MBR4.bin", bufferB);

                if (File.Exists(dir + "\\MBR4.bin"))
                {
                    File.Delete(dir + "\\MBR4.bin");
                }
                File.Move("MBR4.bin", dir + "\\MBR4.bin");

                //sflash0s1_cryptx2b
                bufferB = sflash0.Getsflash0s1_cryptx2b(textOpen.Text);
                File.WriteAllBytes("sflash0s1_cryptx2b.bin", bufferB);

                if (File.Exists(dir + "\\sflash0s1_cryptx2b.bin"))
                {
                    File.Delete(dir + "\\sflash0s1_cryptx2b.bin");
                }
                File.Move("sflash0s1_cryptx2b.bin", dir + "\\sflash0s1_cryptx2b.bin");

                //sflash0s1_cryptx2
                bufferB = sflash0.Getsflash0s1_cryptx2(textOpen.Text);
                File.WriteAllBytes("sflash0s1_cryptx2.bin", bufferB);

                if (File.Exists(dir + "\\sflash0s1_cryptx2.bin"))
                {
                    File.Delete(dir + "\\sflash0s1_cryptx2.bin");
                }
                File.Move("sflash0s1_cryptx2.bin", dir + "\\sflash0s1_cryptx2.bin");

                //sflash0s1_cryptx1
                bufferB = sflash0.Getsflash0s1_cryptx1(textOpen.Text);
                File.WriteAllBytes("sflash0s1_cryptx1.bin", bufferB);

                if (File.Exists(dir + "\\sflash0s1_cryptx1.bin"))
                {
                    File.Delete(dir + "\\sflash0s1_cryptx1.bin");
                }
                File.Move("sflash0s1_cryptx1.bin", dir + "\\sflash0s1_cryptx1.bin");

                //sflash0s1_cryptx39 
                bufferB = sflash0.Getsflash0s1_cryptx39(textOpen.Text);
                File.WriteAllBytes("sflash0s1_cryptx39.bin", bufferB);

                if (File.Exists(dir + "\\sflash0s1_cryptx39.bin"))
                {
                    File.Delete(dir + "\\sflash0s1_cryptx39.bin");
                }
                File.Move("sflash0s1_cryptx39.bin", dir + "\\sflash0s1_cryptx39.bin");

                //sflash0s1_cryptx6  
                bufferB = sflash0.Getsflash0s1_cryptx6(textOpen.Text);
                File.WriteAllBytes("sflash0s1_cryptx6.bin", bufferB);

                if (File.Exists(dir + "\\sflash0s1_cryptx6.bin"))
                {
                    File.Delete(dir + "\\sflash0s1_cryptx6.bin");
                }
                File.Move("sflash0s1_cryptx6.bin", dir + "\\sflash0s1_cryptx6.bin");

                //sflash0s1_cryptx3b  
                bufferB = sflash0.Getsflash0s1_cryptx3b(textOpen.Text);
                File.WriteAllBytes("sflash0s1_cryptx3b.bin", bufferB);

                if (File.Exists(dir + "\\sflash0s1_cryptx3b.bin"))
                {
                    File.Delete(dir + "\\sflash0s1_cryptx3b.bin");
                }
                File.Move("sflash0s1_cryptx3b.bin", dir + "\\sflash0s1_cryptx3b.bin");

                //sflash0s1_cryptx3  
                bufferB = sflash0.Getsflash0s1_cryptx3(textOpen.Text);
                File.WriteAllBytes("sflash0s1_cryptx3.bin", bufferB);

                if (File.Exists(dir + "\\sflash0s1_cryptx3.bin"))
                {
                    File.Delete(dir + "\\sflash0s1_cryptx3.bin");
                }
                File.Move("sflash0s1_cryptx3.bin", dir + "\\sflash0s1_cryptx3.bin");

                //sflash0s1_cryptx40  
                bufferB = sflash0.Getsflash0s1_cryptx40(textOpen.Text);
                File.WriteAllBytes("sflash0s1_cryptx40.bin", bufferB);

                if (File.Exists(dir + "\\sflash0s1_cryptx40.bin"))
                {
                    File.Delete(dir + "\\sflash0s1_cryptx40.bin");
                }
                File.Move("sflash0s1_cryptx40.bin", dir + "\\sflash0s1_cryptx40.bin");

                MessageBox.Show("Extraction done", "Info");
                System.Diagnostics.Process.Start("explorer.exe", dir);
            }
        }
    }
}
