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

namespace WindowsFormsApp8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
 
        public void button1_Click(object sender, EventArgs e)
        {
            string dateString = DateTime.Today.ToShortDateString();
            MessageBox.Show(dateString);
            string first = textBox1.Text;
            string second = textBox2.Text;
            string desktop = @"\Desktop\";
            string docs = @"\Documents\";
            string downloads = @"\Downloads\";
            string music = @"\Music\";
            string videos = @"\Videos\";
            string favorites = @"\Favorites\";
            string chrome = @"\AppData\Local\Google\Chrome\User Data\Default\Bookmarks.bak";
            string chromeDict = @"\AppData\Local\Google\Chrome\User Data\Default\Custom Dictionary.txt";
            string firefox = @"\AppData\Roaming\Mozilla\Firefox\Profiles\";
            string pictures = @"Pictures";
            string quickParts = @"\application data\microsoft\templates";
            string oneDrive = @"";
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

                //build the destination for this directory
                string target = textBox2.Text;
                //need to append the directory data to the variable
                string targetPath = target + desktop;

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
            if (checkBox7.Checked)
            {
                string sourcePath = first + chrome;
                //build the destination for this directory
                string target = textBox2.Text;
                //need to append the directory data to the variable
                string targetPath = target + chrome;

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
            if (checkBox8.Checked)
            {
                string sourcePath = first + chromeDict;
                //build the destination for this directory
                string target = textBox2.Text;
                //need to append the directory data to the variable
                string targetPath = target + chromeDict;

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
                MessageBox.Show(textBox1.Text = source.FileName);
            }
        }

        public void button3_Click(object sender, EventArgs e)
        {
            CommonOpenFileDialog dest = new CommonOpenFileDialog();
            dest.InitialDirectory = "C:\\";
            dest.IsFolderPicker = true;
            if (dest.ShowDialog() == CommonFileDialogResult.Ok)
            {
                MessageBox.Show(textBox2.Text = dest.FileName);
            }
        }


        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

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
    }
}
