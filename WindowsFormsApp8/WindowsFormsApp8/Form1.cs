using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Microsoft.WindowsAPICodePack.Dialogs;
using System.Security.Principal;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Microsoft.Win32;
namespace WindowsFormsApp8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //let us get the uptime of the computer. For shits and giggles.
            float ticks = System.Environment.TickCount;
            string uTimeM = (ticks / 1000 / 60).ToString();
            string uTimeH = (ticks / 1000 / 60 / 60).ToString();
            string uTimeD = (ticks / 1000 / 60 / 60 / 24).ToString();
            string upTime = "Days " + uTimeD + "| Hours " + uTimeH + "| Minutes " + uTimeM;




            //we need to get the install date of the OS let us do that here.

            
        



            //some more variable data and mapping to labels in the GUI
            string userName = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
            string dateString = DateTime.Today.ToShortDateString();
            string cName = System.Environment.MachineName.ToString();
            string osVersion = Registry.GetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion", "ReleaseId", "").ToString();

            string version = 
            label4.Text = userName;
            label5.Text = dateString;
            label6.Text = cName;
            label8.Text = upTime;
            label10.Text = osVersion;
            //label12.Text = 

        }
        //Need to get the Operating System Version. Hang on it gets crazy from here...
  

      
        public void button1_Click(object sender, EventArgs e)
        {
            string dateString = DateTime.Today.ToShortDateString();
            //MessageBox.Show(dateString);
            string first = textBox1.Text;
            string second = textBox2.Text;
            string desktop = @"\Desktop\";
            string docs = @"\Documents\";
            string downloads = @"\Downloads\";
            string music = @"\Music\";
            string videos = @"\Videos\";
            string favorites = @"\Favorites\";
            string chrome = @"\AppData\Local\Google\Chrome\User Data\Default\";
            string chromeDict = @"\AppData\Local\Google\Chrome\User Data\Default\";
            string chromeFile = @"\AppData\Local\Google\Chrome\User Data\Default\Bookmarks.bak";
            string chromeDictFile = @"\AppData\Local\Google\Chrome\User Data\Default\Custom Dictionary.txt";
            string firefox = @"\AppData\Roaming\Mozilla\Firefox\Profiles\";
            string pictures = @"\Pictures\";
            string quickParts = @"\application data\microsoft\templates";
            string oneDrive = @"\OneDrive\";
            string adobeSig = @"\AppData\Roaming\Adobe\Acrobat\DC\Security";
            string outlookSig = @"\application data\microsoft\signatures";
            string outlookSettings = @"\AppData\Local\Microsoft\Outlook";
            string officeRibbon = @"\AppData\Local\Microsoft\Office";
            string stickyNotes = @"\AppData\Local\Packages\Microsoft.MicrosoftStickyNotes_8wekyb3d8bbwe\LocalState";
            string oneNote2016 = @"\AppData\Roaming\Microsoft\OneNote";
            string oDBA = @"\ODBA";
            string windowsDict = @"\AppData\Roaming\Microsoft\UProof";
            string fonts = @"C:\Windows\Fonts";

            if (checkBox1.Checked)
            {
                //build the source for this directory
                string sourcePath = first + desktop;
                //I want to know how big the profile is before we start. 

                //build the destination for this directory
                string target = textBox2.Text;
                //need to append the directory data to the variable
                string targetPath = target + desktop;

                //create directory if not already done, if already there this does nothing
                System.IO.Directory.CreateDirectory(targetPath);

                if (System.IO.Directory.Exists(sourcePath))
                {
                    //Now Create all of the directories
                    foreach (string dirPath in Directory.GetDirectories(sourcePath, "*",
                        SearchOption.AllDirectories))
                        Directory.CreateDirectory(dirPath.Replace(sourcePath, targetPath));

                    //Copy all the files & Replaces any files with the same name
                    foreach (string newPath in Directory.GetFiles(sourcePath, "*.*",
                        SearchOption.AllDirectories))
                        File.Copy(newPath, newPath.Replace(sourcePath, targetPath), true);

                    //string[] files = System.IO.Directory.GetFiles(sourcePath);

                    // Copy the files and overwrite destination files if they already exist.
                    //foreach (string s in files)
                    //{
                    // Use static Path methods to extract only the file name from the path.
                    //  string fileName = System.IO.Path.GetFileName(s);
                    //  string destFile = System.IO.Path.Combine(targetPath, fileName);
                    //  System.IO.File.Copy(s, destFile, true);
                    // }
                }
                else
                {
                    Console.WriteLine("Source path does not exist!");
                }

            }
            if (checkBox2.Checked)
            {
                string sourcePath = first + docs;
                //build the destination for this directory
                string target = textBox2.Text;
                //need to append the directory data to the variable
                string targetPath = target + docs;

                //create directory if not already done, if already there this does nothing
                System.IO.Directory.CreateDirectory(targetPath);

                if (System.IO.Directory.Exists(sourcePath))
                {
                    //Now Create all of the directories
                    foreach (string dirPath in Directory.GetDirectories(sourcePath, "*",
                        SearchOption.AllDirectories))
                        Directory.CreateDirectory(dirPath.Replace(sourcePath, targetPath));

                    //Copy all the files & Replaces any files with the same name
                    foreach (string newPath in Directory.GetFiles(sourcePath, "*.*",
                        SearchOption.AllDirectories))
                        File.Copy(newPath, newPath.Replace(sourcePath, targetPath), true);
                }
                else
                {
                    Console.WriteLine("Source path does not exist!");
                }
            }
            if (checkBox3.Checked)
            {
                string sourcePath = first + downloads;
                //build the destination for this directory
                string target = textBox2.Text;
                //need to append the directory data to the variable
                string targetPath = target + downloads;

                //create directory if not already done, if already there this does nothing
                System.IO.Directory.CreateDirectory(targetPath);

                if (System.IO.Directory.Exists(sourcePath))
                {
                    //Now Create all of the directories
                    foreach (string dirPath in Directory.GetDirectories(sourcePath, "*",
                        SearchOption.AllDirectories))
                        Directory.CreateDirectory(dirPath.Replace(sourcePath, targetPath));

                    //Copy all the files & Replaces any files with the same name
                    foreach (string newPath in Directory.GetFiles(sourcePath, "*.*",
                        SearchOption.AllDirectories))
                        File.Copy(newPath, newPath.Replace(sourcePath, targetPath), true);
                }
                else
                {
                    Console.WriteLine("Source path does not exist!");
                }
            }
            if (checkBox4.Checked)
            {
                string sourcePath = first + music;
                //build the destination for this directory
                string target = textBox2.Text;
                //need to append the directory data to the variable
                string targetPath = target + music;

                //create directory if not already done, if already there this does nothing
                System.IO.Directory.CreateDirectory(targetPath);

                if (System.IO.Directory.Exists(sourcePath))
                {
                    //Now Create all of the directories
                    foreach (string dirPath in Directory.GetDirectories(sourcePath, "*",
                        SearchOption.AllDirectories))
                        Directory.CreateDirectory(dirPath.Replace(sourcePath, targetPath));

                    //Copy all the files & Replaces any files with the same name
                    foreach (string newPath in Directory.GetFiles(sourcePath, "*.*",
                        SearchOption.AllDirectories))
                        File.Copy(newPath, newPath.Replace(sourcePath, targetPath), true);
                }
                else
                {
                    Console.WriteLine("Source path does not exist!");
                }
            }
            if (checkBox5.Checked)
            {
                string sourcePath = first + videos;
                //build the destination for this directory
                string target = textBox2.Text;
                //need to append the directory data to the variable
                string targetPath = target + videos;

                //create directory if not already done, if already there this does nothing
                System.IO.Directory.CreateDirectory(targetPath);

                if (System.IO.Directory.Exists(sourcePath))
                {
                    //Now Create all of the directories
                    foreach (string dirPath in Directory.GetDirectories(sourcePath, "*",
                        SearchOption.AllDirectories))
                        Directory.CreateDirectory(dirPath.Replace(sourcePath, targetPath));

                    //Copy all the files & Replaces any files with the same name
                    foreach (string newPath in Directory.GetFiles(sourcePath, "*.*",
                        SearchOption.AllDirectories))
                        File.Copy(newPath, newPath.Replace(sourcePath, targetPath), true);
                }
                else
                {
                    Console.WriteLine("Source path does not exist!");
                }
            }
            if (checkBox6.Checked)
            {
                string sourcePath = first + favorites;
                //build the destination for this directory
                string target = textBox2.Text;
                //need to append the directory data to the variable
                string targetPath = target + favorites;

                //create directory if not already done, if already there this does nothing
                System.IO.Directory.CreateDirectory(targetPath);

                if (System.IO.Directory.Exists(sourcePath))
                {
                    //Now Create all of the directories
                    foreach (string dirPath in Directory.GetDirectories(sourcePath, "*",
                        SearchOption.AllDirectories))
                        Directory.CreateDirectory(dirPath.Replace(sourcePath, targetPath));

                    //Copy all the files & Replaces any files with the same name
                    foreach (string newPath in Directory.GetFiles(sourcePath, "*.*",
                        SearchOption.AllDirectories))
                        File.Copy(newPath, newPath.Replace(sourcePath, targetPath), true);
                }
                else
                {
                    Console.WriteLine("Source path does not exist!");
                }
            }
            if (checkBox7.Checked)
            {
                string sourcePath = first + chrome;
                string sourcePathFile = first + chromeFile;
                //build the destination for this directory
                string target = textBox2.Text;
                //need to append the directory data to the variable
                string targetPath = target + chrome;
                string targetPathFile = target + chromeFile;

                //create directory if not already done, if already there this does nothing
                System.IO.Directory.CreateDirectory(targetPath);

                if (System.IO.Directory.Exists(sourcePath))
                {
                    File.Copy(sourcePathFile, targetPathFile, true);
                }
                else
                {
                    Console.WriteLine("Source path does not exist!");
                }
            }
            if (checkBox8.Checked)
            {
                string sourcePath = first + chromeDict;
                string sourcePathFile = first + chromeDictFile;
                //build the destination for this directory
                string target = textBox2.Text;
                //need to append the directory data to the variable
                string targetPath = target + chromeDict;
                string targetPathFile = target + chromeDictFile;

                //create directory if not already done, if already there this does nothing
                System.IO.Directory.CreateDirectory(targetPath);

                if (System.IO.Directory.Exists(sourcePath))
                {
                    File.Copy(sourcePathFile, targetPathFile, true);
                }
                else
                {
                    Console.WriteLine("Source path does not exist!");
                }
            }
            if (checkBox9.Checked)
            {
                string sourcePath = first + firefox;
                //build the destination for this directory
                string target = textBox2.Text;
                //need to append the directory data to the variable
                string targetPath = target + firefox;

                //create directory if not already done, if already there this does nothing
                System.IO.Directory.CreateDirectory(targetPath);

                if (System.IO.Directory.Exists(sourcePath))
                {
                    //Now Create all of the directories
                    foreach (string dirPath in Directory.GetDirectories(sourcePath, "*",
                        SearchOption.AllDirectories))
                        Directory.CreateDirectory(dirPath.Replace(sourcePath, targetPath));

                    //Copy all the files & Replaces any files with the same name
                    foreach (string newPath in Directory.GetFiles(sourcePath, "*.*",
                        SearchOption.AllDirectories))
                        File.Copy(newPath, newPath.Replace(sourcePath, targetPath), true);
                }
                else
                {
                    Console.WriteLine("Source path does not exist!");
                }
            }
            if (checkBox10.Checked)
            {
                string sourcePath = first + pictures;
                //build the destination for this directory
                string target = textBox2.Text;
                //need to append the directory data to the variable
                string targetPath = target + pictures;

                //create directory if not already done, if already there this does nothing
                System.IO.Directory.CreateDirectory(targetPath);

                if (System.IO.Directory.Exists(sourcePath))
                {
                    //Now Create all of the directories
                    foreach (string dirPath in Directory.GetDirectories(sourcePath, "*",
                        SearchOption.AllDirectories))
                        Directory.CreateDirectory(dirPath.Replace(sourcePath, targetPath));

                    //Copy all the files & Replaces any files with the same name
                    foreach (string newPath in Directory.GetFiles(sourcePath, "*.*",
                        SearchOption.AllDirectories))
                        File.Copy(newPath, newPath.Replace(sourcePath, targetPath), true);
                }
                else
                {
                    Console.WriteLine("Source path does not exist!");
                }
            }
            if (checkBox11.Checked)
            {
                string sourcePath = first + quickParts;
                //build the destination for this directory
                string target = textBox2.Text;
                //need to append the directory data to the variable
                string targetPath = target + quickParts;

                //create directory if not already done, if already there this does nothing
                System.IO.Directory.CreateDirectory(targetPath);

                if (System.IO.Directory.Exists(sourcePath))
                {
                    //Now Create all of the directories
                    foreach (string dirPath in Directory.GetDirectories(sourcePath, "*",
                        SearchOption.AllDirectories))
                        Directory.CreateDirectory(dirPath.Replace(sourcePath, targetPath));

                    //Copy all the files & Replaces any files with the same name
                    foreach (string newPath in Directory.GetFiles(sourcePath, "*.*",
                        SearchOption.AllDirectories))
                        File.Copy(newPath, newPath.Replace(sourcePath, targetPath), true);
                }
                else
                {
                    Console.WriteLine("Source path does not exist!");
                }
            }
            if (checkBox12.Checked)
            {
                string sourcePath = first + oneDrive;
                //build the destination for this directory
                string target = textBox2.Text;
                //need to append the directory data to the variable
                string targetPath = target + oneDrive;

                //create directory if not already done, if already there this does nothing
                System.IO.Directory.CreateDirectory(targetPath);

                if (System.IO.Directory.Exists(sourcePath))
                {
                    //Now Create all of the directories
                    foreach (string dirPath in Directory.GetDirectories(sourcePath, "*",
                        SearchOption.AllDirectories))
                        Directory.CreateDirectory(dirPath.Replace(sourcePath, targetPath));

                    //Copy all the files & Replaces any files with the same name
                    foreach (string newPath in Directory.GetFiles(sourcePath, "*.*",
                        SearchOption.AllDirectories))
                        File.Copy(newPath, newPath.Replace(sourcePath, targetPath), true);
                }
                else
                {
                    Console.WriteLine("Source path does not exist!");
                }
            }
            if (checkBox13.Checked)
            {
                string sourcePath = first + adobeSig;
                //build the destination for this directory
                string target = textBox2.Text;
                //need to append the directory data to the variable
                string targetPath = target + adobeSig;

                //create directory if not already done, if already there this does nothing
                System.IO.Directory.CreateDirectory(targetPath);

                if (System.IO.Directory.Exists(sourcePath))
                {
                    //Now Create all of the directories
                    foreach (string dirPath in Directory.GetDirectories(sourcePath, "*",
                        SearchOption.AllDirectories))
                        Directory.CreateDirectory(dirPath.Replace(sourcePath, targetPath));

                    //Copy all the files & Replaces any files with the same name
                    foreach (string newPath in Directory.GetFiles(sourcePath, "*.*",
                        SearchOption.AllDirectories))
                        File.Copy(newPath, newPath.Replace(sourcePath, targetPath), true);
                }
                else
                {
                    Console.WriteLine("Source path does not exist!");
                }
            }
            if (checkBox14.Checked)
            {
                string sourcePath = first + outlookSig;
                //build the destination for this directory
                string target = textBox2.Text;
                //need to append the directory data to the variable
                string targetPath = target + outlookSig;

                //create directory if not already done, if already there this does nothing
                System.IO.Directory.CreateDirectory(targetPath);

                if (System.IO.Directory.Exists(sourcePath))
                {
                    //Now Create all of the directories
                    foreach (string dirPath in Directory.GetDirectories(sourcePath, "*",
                        SearchOption.AllDirectories))
                        Directory.CreateDirectory(dirPath.Replace(sourcePath, targetPath));

                    //Copy all the files & Replaces any files with the same name
                    foreach (string newPath in Directory.GetFiles(sourcePath, "*.*",
                        SearchOption.AllDirectories))
                        File.Copy(newPath, newPath.Replace(sourcePath, targetPath), true);
                }
                else
                {
                    Console.WriteLine("Source path does not exist!");
                }
            }
            if (checkBox15.Checked)
            {
                string sourcePath = first + outlookSettings;
                //build the destination for this directory
                string target = textBox2.Text;
                //need to append the directory data to the variable
                string targetPath = target + outlookSettings;

                //create directory if not already done, if already there this does nothing
                System.IO.Directory.CreateDirectory(targetPath);

                if (System.IO.Directory.Exists(sourcePath))
                {
                    //Now Create all of the directories
                    foreach (string dirPath in Directory.GetDirectories(sourcePath, "*",
                        SearchOption.AllDirectories))
                        Directory.CreateDirectory(dirPath.Replace(sourcePath, targetPath));

                    //Copy all the files & Replaces any files with the same name
                    foreach (string newPath in Directory.GetFiles(sourcePath, "*.*",
                        SearchOption.AllDirectories))
                        File.Copy(newPath, newPath.Replace(sourcePath, targetPath), true);
                }
                else
                {
                    Console.WriteLine("Source path does not exist!");
                }
            }
            if (checkBox16.Checked)
            {
                string sourcePath = first + officeRibbon;
                //build the destination for this directory
                string target = textBox2.Text;
                //need to append the directory data to the variable
                string targetPath = target + officeRibbon;

                //create directory if not already done, if already there this does nothing
                System.IO.Directory.CreateDirectory(targetPath);

                if (System.IO.Directory.Exists(sourcePath))
                {
                    //Now Create all of the directories
                    foreach (string dirPath in Directory.GetDirectories(sourcePath, "*",
                        SearchOption.AllDirectories))
                        Directory.CreateDirectory(dirPath.Replace(sourcePath, targetPath));

                    //Copy all the files & Replaces any files with the same name
                    foreach (string newPath in Directory.GetFiles(sourcePath, "*.*",
                        SearchOption.AllDirectories))
                        File.Copy(newPath, newPath.Replace(sourcePath, targetPath), true);
                }
                else
                {
                    Console.WriteLine("Source path does not exist!");
                }
            }
            if (checkBox17.Checked)
            {
                string sourcePath = first + stickyNotes;
                //build the destination for this directory
                string target = textBox2.Text;
                //need to append the directory data to the variable
                string targetPath = target + stickyNotes;

                //create directory if not already done, if already there this does nothing
                System.IO.Directory.CreateDirectory(targetPath);

                 if (System.IO.Directory.Exists(sourcePath))
                {
                    //Now Create all of the directories
                    foreach (string dirPath in Directory.GetDirectories(sourcePath, "*",
                        SearchOption.AllDirectories))
                        Directory.CreateDirectory(dirPath.Replace(sourcePath, targetPath));

                    //Copy all the files & Replaces any files with the same name
                    foreach (string newPath in Directory.GetFiles(sourcePath, "*.*",
                        SearchOption.AllDirectories))
                        File.Copy(newPath, newPath.Replace(sourcePath, targetPath), true);
                }
                else
                {
                    Console.WriteLine("Source path does not exist!");
                }
            }
            if (checkBox18.Checked)
            {
                string sourcePath = first + oneNote2016;
                //build the destination for this directory
                string target = textBox2.Text;
                //need to append the directory data to the variable
                string targetPath = target + oneNote2016;

                //create directory if not already done, if already there this does nothing
                System.IO.Directory.CreateDirectory(targetPath);

                if (System.IO.Directory.Exists(sourcePath))
                {
                    //Now Create all of the directories
                    foreach (string dirPath in Directory.GetDirectories(sourcePath, "*",
                        SearchOption.AllDirectories))
                        Directory.CreateDirectory(dirPath.Replace(sourcePath, targetPath));

                    //Copy all the files & Replaces any files with the same name
                    foreach (string newPath in Directory.GetFiles(sourcePath, "*.*",
                        SearchOption.AllDirectories))
                        File.Copy(newPath, newPath.Replace(sourcePath, targetPath), true);
                }
                else
                {
                    Console.WriteLine("Source path does not exist!");
                }
            }
            if (checkBox19.Checked)
            {
                string sourcePath = first + oDBA;
                //build the destination for this directory
                string target = textBox2.Text;
                //need to append the directory data to the variable
                string targetPath = target + oDBA;

                //create directory if not already done, if already there this does nothing
                System.IO.Directory.CreateDirectory(targetPath);

                if (System.IO.Directory.Exists(sourcePath))
                {
                    //Now Create all of the directories
                    foreach (string dirPath in Directory.GetDirectories(sourcePath, "*",
                        SearchOption.AllDirectories))
                        Directory.CreateDirectory(dirPath.Replace(sourcePath, targetPath));

                    //Copy all the files & Replaces any files with the same name
                    foreach (string newPath in Directory.GetFiles(sourcePath, "*.*",
                        SearchOption.AllDirectories))
                        File.Copy(newPath, newPath.Replace(sourcePath, targetPath), true);
                }
                else
                {
                    Console.WriteLine("Source path does not exist!");
                }
            }
            if (checkBox20.Checked)
            {
                string sourcePath = first + windowsDict;
                //build the destination for this directory
                string target = textBox2.Text;
                //need to append the directory data to the variable
                string targetPath = target + windowsDict;

                //create directory if not already done, if already there this does nothing
                System.IO.Directory.CreateDirectory(targetPath);

                if (System.IO.Directory.Exists(sourcePath))
                {
                    //Now Create all of the directories
                    foreach (string dirPath in Directory.GetDirectories(sourcePath, "*",
                        SearchOption.AllDirectories))
                        Directory.CreateDirectory(dirPath.Replace(sourcePath, targetPath));

                    //Copy all the files & Replaces any files with the same name
                    foreach (string newPath in Directory.GetFiles(sourcePath, "*.*",
                        SearchOption.AllDirectories))
                        File.Copy(newPath, newPath.Replace(sourcePath, targetPath), true);
                }
                else
                {
                    Console.WriteLine("Source path does not exist!");
                }
            }
            if (checkBox21.Checked)
            {
                string sourcePath = first + fonts;
                //build the destination for this directory
                string target = textBox2.Text;
                //need to append the directory data to the variable
                string targetPath = target + "Fonts";

                //create directory if not already done, if already there this does nothing
                System.IO.Directory.CreateDirectory(targetPath);

                if (System.IO.Directory.Exists(sourcePath))
                {
                    string[] files = System.IO.Directory.GetFiles(sourcePath);

                    // Copy the files and overwrite destination files if they already exist.
                    foreach (string s in files)
                    {
                        // Use static Path methods to extract only the file name from the path.
                        string fileName = System.IO.Path.GetFileName(s);
                        string destFile = System.IO.Path.Combine(targetPath, fileName);
                        System.IO.File.Copy(s, destFile, true);
                    }
                }
                else
                {
                    Console.WriteLine("Source path does not exist!");
                }
            }


        }

        public void button2_Click(object sender, EventArgs e)
        {
            CommonOpenFileDialog source = new CommonOpenFileDialog();
            source.InitialDirectory = "C:\\Users";
            source.IsFolderPicker = true;
            if (source.ShowDialog() == CommonFileDialogResult.Ok)
            {
                string size = (GetDirectorySize(source.FileName)).ToString();
                MessageBox.Show("This profile is " + size + " bytes large.");
                textBox1.Text = source.FileName;
            }
        }

        public void button3_Click(object sender, EventArgs e)
        {
            CommonOpenFileDialog dest = new CommonOpenFileDialog();
            dest.InitialDirectory = "C:\\";
            dest.IsFolderPicker = true;
            if (dest.ShowDialog() == CommonFileDialogResult.Ok)
            {
                MessageBox.Show("Destination Location: " + dest.FileName);
                textBox2.Text = dest.FileName;
            }
        }


        static long GetDirectorySize(string p)
        {
            // 1.
            // Get array of all file names.
            string[] a = Directory.GetFiles(p, "*.*");

            // 2.
            // Calculate total bytes of all files in a loop.
            long b = 0;
            foreach (string name in a)
            {
                // 3.
                // Use FileInfo to get length of each file.
                FileInfo info = new FileInfo(name);
                b += info.Length;
            }
            // 4.
            // Return total size
            return b;
        }




        private void button4_Click(object sender, EventArgs e)
        {
  
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void checkBox22_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox22.Checked)
            {
                checkBox21.Checked = true;
                checkBox20.Checked = true;
                checkBox19.Checked = true;
                checkBox18.Checked = true;
                checkBox17.Checked = true;
                checkBox16.Checked = true;
                checkBox15.Checked = true;
                checkBox14.Checked = true;
                checkBox13.Checked = true;
                checkBox12.Checked = true;
                checkBox11.Checked = true;
                checkBox10.Checked = true;
                checkBox9.Checked = true;
                checkBox8.Checked = true;
                checkBox7.Checked = true;
                checkBox6.Checked = true;
                checkBox5.Checked = true;
                checkBox4.Checked = true;
                checkBox3.Checked = true;
                checkBox2.Checked = true;
                checkBox1.Checked = true;

            }
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

     }
}
