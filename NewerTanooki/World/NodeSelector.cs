using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewerTanooki.World
{
    public partial class NodeSelector : Form
    {
        public NodeSelector()
        {
            InitializeComponent();
        }

        public int currentWorld = 0;
        public int selectedID = 0;
        bool hasChangesBeenMade = false;

        List<Panel> panelList = new List<Panel>();
        List<PictureBox> pictureList = new List<PictureBox>();
        Button previousButton = new Button();

        private void NodeSelector_Load(object sender, EventArgs e)
        {
            InitTimer();
            marioPictureBox.Visible = false;

            nodeTabControl.SelectedIndex = currentWorld;

            panelList.Add(yoshiPanel);
            panelList.Add(fullmapPanel);
            panelList.Add(sewerPanel);

            pictureList.Add(yoshiPictureBox);
            pictureList.Add(fullmapPictureBox);
            pictureList.Add(sewerPictureBox);

            if (currentWorld != 0)
            {
                //panelList[currentWorld].Controls.Add(marioPictureBox);
                //marioPictureBox.Parent = pictureList[currentWorld];
            }

            foreach (Control thisButton in panelList[currentWorld].Controls)
            {
                if (thisButton.GetType() == typeof(Button))
                {
                    if (Convert.ToInt32(thisButton.Text) == selectedID)
                    {
                        marioPictureBox.Parent = thisButton;
                        marioPictureBox.Location = new Point(thisButton.Location.X - 7, thisButton.Location.Y - 35);
                        thisButton.BackColor = Color.Red;
                        previousButton = (Button)thisButton;
                        break;
                    }
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void nodeButton_Click(object sender, EventArgs e)
        {
            hasChangesBeenMade = true;
            selectedID = Convert.ToInt32((sender as Button).Text);
            if (currentWorld != nodeTabControl.SelectedIndex)
            {
                currentWorld = nodeTabControl.SelectedIndex;
                //panelList[currentWorld].Controls.Add(marioPictureBox);
                //marioPictureBox.Parent = pictureList[currentWorld];
            }
            previousButton.BackColor = Color.Transparent;
            (sender as Button).BackColor = Color.Red;
            previousButton = (sender as Button);
            marioPictureBox.Location = new Point((sender as Button).Location.X - 7, (sender as Button).Location.Y - 35);
        }

        private void doneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void NodeSelector_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (hasChangesBeenMade)
            {
                switch (MessageBox.Show("Would you like to save the node you selected ?", Text, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question))
                {
                    case DialogResult.Yes:
                        this.DialogResult = DialogResult.OK; //Save
                        break;
                    case DialogResult.No:
                        this.DialogResult = DialogResult.Cancel; //RIP
                        break;
                    case DialogResult.Cancel:
                        e.Cancel = true; //OwO
                        break;
                }
            }
        }
    }
}
