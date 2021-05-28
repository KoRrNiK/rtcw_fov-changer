using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime;
using Memory;
using System.Diagnostics;

namespace Return_to_Castle_Wolfenstein_Fov_changer
{
    public partial class Form1 : Form
    {

        public Mem m = new Mem();
        string fovBytes = "cgamex86.dll+9DC928";
        string nameGame = "WolfSP";
       
        public Form1()
        {
            InitializeComponent();
        }

        int r = 252;
        int g = 3;
        int b = 3;
        bool processOpen = false;

        int mouseX = 0, mouseY = 0;
        bool mouseDown;

        private const int CS_DropShadow = 0x20000;

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= CS_DropShadow;
                return cp;
            }
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            m.WriteMemory(fovBytes, "float", "90");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            fov_bar.Value = 90;
            valueFov.Text = fov_bar.Value.ToString();
            valueFov.ForeColor = Color.FromArgb(255,200,0);

            tittleProgram.ForeColor = Color.FromArgb(r, g, b);

            timer1.Start();
            timer7.Start();
            timer8.Start();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            g += 5;
            tittleProgram.ForeColor = Color.FromArgb(r, g, b);
            if (g <= 252)
            {
                timer1.Stop();
                timer2.Start();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            r -= 5;
            tittleProgram.ForeColor = Color.FromArgb(r, g, b);
            if (r <= 3)
            {
                timer2.Stop();
                timer3.Start();
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            b += 5;
            tittleProgram.ForeColor = Color.FromArgb(r, g, b);
            if (b >= 252)
            {
                timer3.Stop();
                timer4.Start();
            }
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            g -= 5;
            tittleProgram.ForeColor = Color.FromArgb(r, g, b);
            if (g <= 3)
            {
                timer4.Stop();
                timer5.Start();
            }
        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            r += 5;
            tittleProgram.ForeColor = Color.FromArgb(r, g, b);
            if (r >= 252)
            {
                timer5.Stop();
                timer6.Start();
            }
        }

        private void timer6_Tick(object sender, EventArgs e)
        {
            b -= 5;
            tittleProgram.ForeColor = Color.FromArgb(r, g, b);
            if (b <= 3)
            {
                timer6.Stop();
                timer1.Start();
            }
        }
        private void up_bar_button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.SetDesktopLocation(MousePosition.X - mouseX, MousePosition.Y - mouseY);
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            mouseX = e.X;
            mouseY = e.Y;
        }
        private void up_bar_button2_Click(object sender, EventArgs e)
        {
            m.WriteMemory(fovBytes, "float", "90");
            this.Close();
        }

        private void timer7_Tick(object sender, EventArgs e)
        {
            if (processOpen){
                string val = fov_bar.Value.ToString();
                m.WriteMemory(fovBytes, "float", val);
            }
        }

        private void timer8_Tick(object sender, EventArgs e)
        {
            processOpen = processOpen = m.OpenProcess(nameGame);
            int pID = m.GetProcIdFromName(nameGame);

            if (processOpen)
            {
                processOpenLabel.ForeColor = Color.Green;
                processOpenLabel.Text = "Game Found";
                processOpenLabel.Font = new Font(processOpenLabel.Font, FontStyle.Bold);

                processID.ForeColor = Color.Green;
                processID.Text = pID.ToString();
                processID.Font = new Font(processID.Font, FontStyle.Bold);
            }
            else
            {
                string na = "N/A";
                processOpenLabel.ForeColor = Color.DarkRed;
                processOpenLabel.Text = na;
                processOpenLabel.Font = new Font(processOpenLabel.Font, FontStyle.Regular);

                processID.ForeColor = Color.DarkRed;
                processID.Text = na;
                processID.Font = new Font(processID.Font, FontStyle.Regular);
                return; 
            }

        }

        private void fov_bar_Scroll(object sender, EventArgs e)
        {
            string val = fov_bar.Value.ToString();
            
            if (fov_bar.Value == 90) valueFov.ForeColor = Color.FromArgb(255,200,0);
            else if(fov_bar.Value > 90) valueFov.ForeColor = Color.FromArgb(fov_bar.Value, 0, 0);
            else valueFov.ForeColor = Color.FromArgb(0, fov_bar.Value, 0);

            if (processOpen) m.WriteMemory(fovBytes, "float", val);
            

            valueFov.Text = val;
        }

    }
}
