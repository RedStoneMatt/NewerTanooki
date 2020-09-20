using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewerTanooki
{
    public partial class Compare : Form
    {
        public Compare()
        {
            InitializeComponent();
        }

        public int compareInt;
        public int withInt;

        private void Compare_Load(object sender, EventArgs e)
        {
            compareComboBox.SelectedIndex = 0;
            withComboBox.SelectedIndex = 1;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            if (compareComboBox.SelectedIndex != withComboBox.SelectedIndex)
            {
                compareInt = compareComboBox.SelectedIndex;
                withInt = withComboBox.SelectedIndex;
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Please choose different save files.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
