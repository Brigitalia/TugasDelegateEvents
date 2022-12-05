using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormCalculatorApp
{
    public partial class FormHasilHitung : Form
    {
        private IList<Calculator> listOfCalculator = new List<Calculator>();
        public FormHasilHitung()
        {
            InitializeComponent();
        }

        private void FormEntry_OnCreate(Calculator cal)
        {
            listOfCalculator.Clear();
            listOfCalculator.Add(cal);
            listHasil.Items.Add(cal.Hasil);
        }


        private void FormHasilHitung_Load(object sender, EventArgs e)
        {
            CalculatorForm CalFr = new CalculatorForm();
            CalFr.onCreate += FormEntry_OnCreate;

            // tampilkan form entry mahasiswa
            CalFr.ShowDialog();

        }
    }
}
