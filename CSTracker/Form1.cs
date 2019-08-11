using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;
using System.Windows.Threading;
using Emgu.CV;
using Emgu.CV.Structure;


namespace CSTracker
{
    public partial class Form1 : Form
    {
        //member variables

        private VideoCapture capture;

        private CascadeClassifier cascadeClassifier;

        private bool DetectionInProgress;

        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

            try
            {
                capture = new VideoCapture();
                imgCamUser.Image = capture.QueryFrame();
            }
            catch (Exception ex)
            {
                MessageBox.Show("unable to read from webcam, error: " + Environment.NewLine + Environment.NewLine +
                                ex.Message + Environment.NewLine + Environment.NewLine +
                                "exiting program");
                Environment.Exit(0);
                return;


            }

            Application.Idle += processFrameUpdateGUI;
            DetectionInProgress = true;

        }

       

        void processFrameUpdateGUI(object sender, EventArgs arg)
        {

            cascadeClassifier = new CascadeClassifier(Application.StartupPath + "/opencv/data/haarcascades/haarcascade_frontalface_default.xml");

            using (var imageFrame = capture.QueryFrame().ToImage<Bgr, Byte>())
            {
                if (imageFrame != null)
                {
                    var grayframe = imageFrame.Convert<Gray, Byte>();
                    var faces = cascadeClassifier.DetectMultiScale(grayframe, 1.1, 10, Size.Empty); //the actual face detection happens here
                    foreach (var face in faces)
                    {

                        if (txtXYRadius.Text != "")
                        {
                            txtXYRadius.AppendText(Environment.NewLine);        
                        }

                        txtXYRadius.AppendText("face position = x " + face.X.ToString().PadLeft(4) + ", y = " + face.Y.ToString().PadLeft(4));          // Prints face position to text box                  

                        txtXYRadius.ScrollToCaret();                

                        imageFrame.Draw(face, new Bgr(Color.BurlyWood), 3);

                    }
                }
                imgCamUser.Image = imageFrame;
            }

        }

        private void ButtonPauseOrResume_Click(object sender, EventArgs e)
        {
            if (DetectionInProgress == true)                      
            {
                Application.Idle -= processFrameUpdateGUI;       
                DetectionInProgress = false;
                ButtonPauseOrResume.Text = " resume ";
            }
            else
            { 
                Application.Idle += processFrameUpdateGUI;       
                DetectionInProgress = true;                       
                ButtonPauseOrResume.Text = " pause ";                 
            }
        }


        private void Save_Click(object sender, EventArgs e)
        {

            SaveFileDialog dialog = new SaveFileDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (Bitmap image = capture.QueryFrame().Bitmap)
                    {
                        image.Save(dialog.FileName + ".jpeg", ImageFormat.Jpeg);
                    }
                    MessageBox.Show("Picture Saved Successfully.");
                }

                catch (Exception ex)
                {
                    MessageBox.Show("An Error has occured: \n" + ex.Message);
                }
            }

        }


        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

    }
}

