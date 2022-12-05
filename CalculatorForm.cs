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
    public partial class CalculatorForm : Form
    {
        // deklarasi tipe data untuk event OnCreate dan OnUpdate
        public delegate void CreateUpdateEventHandler(CalculatorForm cal);
        // deklarasi event ketika terjadi proses input data baru
        public event CreateUpdateEventHandler OnCreate;

        private bool isNewData = true;
        // deklarasi variabel/objek mhs untuk meyimpan data mahasiswa
        private Calculator cal;

        public CalculatorForm()
        {
            InitializeComponent();
        }
        public string operasi;
        private void button1_Click(object sender, EventArgs e)
        {
            if (isNewData) cal = new Calculator();

            if (operasi == "Penjumlahan")
            {
                cal.Hasil = "Hasil Penjumlahan " + txtNilaiA.Text + " + " + txtNilaiB.Text + " = " + (int.Parse(txtNilaiA.Text) + int.Parse(txtNilaiB.Text));
            }
            else if (operasi == "Pengurangan")
            {
                cal.Hasil = "Hasil Pengurangan " + txtNilaiA.Text + " - " + txtNilaiB.Text + " = " + (int.Parse(txtNilaiA.Text) - int.Parse(txtNilaiB.Text));
            }
            else if (operasi == "Perkalian")
            {
                cal.Hasil = "Hasil Perkalian " + txtNilaiA.Text + " x " + txtNilaiB.Text + " = " + (int.Parse(txtNilaiA.Text) * int.Parse(txtNilaiB.Text));
            }
            else if (operasi == "Pembagian")
            {
                cal.Hasil = "Hasil Pembagian " + txtNilaiA.Text + " : " + txtNilaiB.Text + " = " + (int.Parse(txtNilaiA.Text) / int.Parse(txtNilaiB.Text));
            }

            if (isNewData)
            {
                OnCreate(Calculator.cal);
            }

            FormHasilHitung Hsl = new FormHasilHitung();

            Hsl.ShowDialog();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            operasi = cmbOperasi.SelectedItem.ToString();
           
        }
    }
}
