using System.Windows.Forms;

namespace Vatsim_Trafic_and_ATC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            
            if(e.ClickedItem.Name == "ATC") { }
            if(e.ClickedItem.Name == "pilot") { }
        }
    }
}
