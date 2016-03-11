using System.;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace INClassProj2
{
    public partial class TerrisForm : Form
    {
        public TerrisForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //kkkfkfkfkf
        }

        private void terrisclick(object sender, EventArgs e)
        {
            this.textBox1.Text = this.comboBox1.SelectedItem.ToString();
        }
    }
}
