using System.Drawing;
using System.Windows.Forms;



namespace NewForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

           
        }

        private void timer1_Tick(object sender, System.EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                Color Cscreent = lib.ScreenLib.GetColorPixel(Cursor.Position);
                this.BackColor = Cscreent;
                ColorLabel.Text = Cscreent.ToString();
            }  
        }
    }
}
