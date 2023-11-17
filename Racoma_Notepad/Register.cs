using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FaceRecognition;

namespace Racoma_Notepad
{
    public partial class Register : Form
    {
        FaceRec faceRec = new FaceRec();
        public Register()
        {
            InitializeComponent();
        }

        private void btnCamera_Click(object sender, EventArgs e)
        {
            faceRec.openCamera(pbCamera, pbCaptures);
        }

        private void btnDetectFace_Click(object sender, EventArgs e)
        {
            faceRec.isTrained = true;
        }

        private void btnSaveImage_Click(object sender, EventArgs e)
        {

        }
    }
}
