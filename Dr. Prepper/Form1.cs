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

namespace Dr.Prepper
{
    public partial class Form1 : Form
    {
        private IEnumerable<string> patterns = new List<string>()
        {
            @"~",
            @"#",
            @"%",
            @"&",
            @"{",
            @"}",
            @"+",
            @"..",
        };

        private List<string> matches = new List<string>();

        public Form1()
        {
            InitializeComponent();
            btn_scan.Enabled = false;
            btn_rename.Enabled = false;
            //dirname.Text = "B:\\temp\\testing";
            lbl_success.Visible = false;
        }

        private void btn_browse_Click(object sender, EventArgs e)
        {
            // New FolderBrowserDialog instance
            FolderBrowserDialog Fld = new FolderBrowserDialog();

            // Set initial selected folder
            Fld.SelectedPath = dirname.Text;

            // Show the "Make new folder" button
            Fld.ShowNewFolderButton = true;

            if (Fld.ShowDialog() == DialogResult.OK)
            {
                // Select successful
                // MessageBox.Show("The folder you selected is : " + Fld.SelectedPath);
                dirname.Text = Fld.SelectedPath;
            }
        }

        private void dirname_TextChanged(object sender, EventArgs e)
        {
            btn_scan.Enabled = Directory.Exists( dirname.Text.ToString() );
           
        }

        private void btn_scan_Click(object sender, EventArgs e)
        {
            results.Text = String.Empty;
            matches = new List<string>();
            btn_browse.Enabled = false;
            btn_scan.Text = "Scanning...this may take a while";
            btn_scan.Enabled = false;
            scanFolder(dirname.Text, true);

            btn_browse.Enabled = true;
            btn_scan.Enabled = true;
            btn_scan.Text = "Scan";

            if ( matches.Count < 1 )
            {
                results.Text = "All set. Your files do not need renaming";
                return;
            }



            foreach(string match in matches)
            {
                results.Text += match + "  -->  " + sanitize(match) + Environment.NewLine;
            }

            btn_rename.Enabled = true;


        }

        public void scanFolder(string path, bool recurse = true)
        {
            try
            {
                Console.WriteLine("Scanning " + path);

                
                // look for files matching patterns
                var files = Directory
                    .EnumerateFiles(path)
                    .Where(file => patterns.Any( Path.GetFileName(file).Contains));

                foreach(string file in files)
                {
                    matches.Add(file);
                }

                // look for files that start with .
                files = Directory
                    .EnumerateFiles(path)
                    .Where(file => Path.GetFileName(file).StartsWith("."));

                foreach (string file in files)
                {
                    matches.Add(file);
                }

                // look for files that end with .
                files = Directory
                    .EnumerateFiles(path)
                    .Where(file => Path.GetFileName(file).EndsWith("."));

                foreach (string file in files)
                {
                    matches.Add(file);
                }


                if (recurse)
                {
                    foreach (string dir in Directory.EnumerateDirectories(path))
                    {
                        scanFolder(dir);
                    }
                }

            }

            catch (System.IO.DirectoryNotFoundException e) // ignore
            { }


            catch (System.UnauthorizedAccessException e) // ignore
            { }


            catch (System.Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        private string sanitize(string filename)
        {
            return sanitize(filename, String.Empty);
        }

        private string sanitize(string filename, string suffix)
        {
            var replaced = Path.GetFileName(filename).Replace('~', '-')
            .Replace("#", String.Empty)
            .Replace("%", " percent ")
            .Replace("&", " and ")
            .Replace('{', '(')
            .Replace('}', ')')
            .Replace("+", " and ")
            .Replace("..", ".")
            .Replace("  ", " ");

            // filename cannot start with a .
            if (replaced.StartsWith(".")) replaced = replaced.Substring(1);

            // filename cannot end with a .
            if (replaced.EndsWith(".")) replaced = replaced.Substring(0,replaced.Length-1);

            if ( suffix == null || suffix == String.Empty )
            {
                return replaced;
            }

            return Path.GetFileNameWithoutExtension(replaced) + "-" + suffix + Path.GetExtension(replaced);
        }

        private void move(string file)
        {
            var newPath = Path.Combine( Path.GetDirectoryName(file), sanitize(file));
            int suffix = 0;

            while ( File.Exists(newPath) ) // append a number 
            {
                suffix++;
                newPath = Path.Combine( Path.GetDirectoryName(file), sanitize(file,suffix.ToString() ) );
            }

            File.Move(file, newPath);
        }

        private void btn_rename_Click(object sender, EventArgs e)
        {
            btn_rename.Enabled = false;
            btn_rename.Text = "Renaming...";

            foreach(string file in matches)
            {
                move(file);
            }

            btn_rename.Text = "Rename";

            lbl_success.Visible = true;
        }
    }
}
