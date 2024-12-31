using System.Diagnostics.SymbolStore;

namespace EncapsulationSamples
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string _colorName;
        
        public string ColorName
        {
            get
            {
                return _colorName;
            }
            set
            {
                if (value == "")
                {
                    _colorName = "Black";
                }
                else
                {
                    _colorName = value;
                }
            }
        }

        private void buttonSetColor_Click(object sender, EventArgs e)
        {
            ColorName = textBoxColorValue.Text;
            labelColorResult.ForeColor = Color.FromName(ColorName);
        }
    }
}
