using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MCON_368.WinForm.UserControls
{
    public partial class DateTimeUserControl : UserControl
    {
        public string LabelMessage = string.Empty;

        public DateTimeUserControl()
        {
            InitializeComponent();
        }

        private void DateTimeUserControl_Load(object sender, EventArgs e)
        {
            DateTimeLabel.Text = LabelMessage;
        }
    }
}
