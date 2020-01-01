using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_4
{
    public partial class Advanced_Search : UserControl
    {
        public Advanced_Search()
        {
            InitializeComponent();
        }

        public string GetCategory()
        {
            return categoryBox.Text;
        }

        public DateTime GetSince()
        {
            return since_dateTimePicker.Value;
        }

        public DateTime GetUntil()
        {
            return until_dateTimePicker2.Value;
        }

        public string GetCity()
        {
            return this.cityBox.Text;
        }
    }
}
