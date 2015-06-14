using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Toegevoegde usings voor de browse functie
using System.IO;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;

namespace ImageAdder
{
    public partial class Form1 : Form
    {
        //blob 
        public string strImageName = "";
        private int _imageLength;
        private byte[] _imageData;
        byte[] data;
        //Voor de database.
        private OracleConnection conn;
        //fields
        string filePath;

        public Form1()
        {
            InitializeComponent();
            conn = new OracleConnection();
            ConnectDatabase();
        }

        public void ConnectDatabase()
        {
            try
            {
                String user = "dbi324575"; //gebruikersnaam van de database.
                String pw = "GBNITclsn2"; //wachtwoord van de database.
                //String user = "dbi323305";
                //String pw = "dRuklSz8nY";

                conn.ConnectionString = "User Id=" + user + ";Password=" + pw + ";Data Source=" + " //192.168.15.50:1521/fhictora" + ";";  //string om verbinding te maken.
                conn.Open(); //opent connectie met de Connectionstring die voor deze connectie is ingesteld.
                MessageBox.Show("Connectie gelukt!");
            }
            catch { MessageBox.Show("Kon geen connectie maken"); }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            // how to get picture in picture box from path
            //pbPhoto.Image = System.Drawing.Bitmap.FromFile("het path uit de list met afbeeldingen");

            // Instantiate File Dialog box
            FileDialog fileDlg = new OpenFileDialog();
            // Set the initial directory
            fileDlg.InitialDirectory ="C:\\";
            // Filter image(.jpg, .bmp, .gif) files only
            fileDlg.Filter = "Image File (*.jpg;*.bmp;*.gif)|*.jpg;*.bmp;*.gif";
            // Restores the current directory before closing
            fileDlg.RestoreDirectory = true;

            // When file is selected from the File Dialog
            if (fileDlg.ShowDialog() == DialogResult.OK)
            {
                //Path of the selected file
                filePath = Path.GetFullPath(fileDlg.FileName);
                // Store the name of selected file into a variable
                strImageName = fileDlg.FileName;
                // Create a bitmap for selected image
                /*Bitmap newImage = new Bitmap(strImageName);
                // Fit the image to the size of picture box
                pbPhoto.SizeMode = PictureBoxSizeMode.StretchImage;
                // Show the bitmap in picture box
                pbPhoto.Image = (Image)newImage;*/
            }

            // No Image chosen
            fileDlg = null;
            FileStream fs;

            // Get Image Data from the Filesystem if User has loaded a Photo
            // by the 'Browse' button
            if (strImageName != "")
            {
                fs = new FileStream(@strImageName, FileMode.Open, FileAccess.Read);
                _imageLength = (int)fs.Length;
                // Create a byte array of file stream length
                _imageData = new byte[fs.Length];
                // Read block of bytes from stream into the byte array
                fs.Read(_imageData, 0, System.Convert.ToInt32(fs.Length));
                // Close the File Stream
                fs.Close();
            }
            try
            {
                OracleCommand cmd = conn.CreateCommand();
                OracleTransaction otn = conn.BeginTransaction(IsolationLevel.ReadCommitted);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "INSERT INTO catafbeelding VALUES ("+tbAfbeeldingID.Text+","+tbCategorieID.Text+", utl_raw.cast_to_raw('" + filePath + "'),'"+tbFormaat.Text+"')";
                cmd.ExecuteNonQuery();
                otn.Commit();
                MessageBox.Show("Image added to blob field");
                cmd.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
