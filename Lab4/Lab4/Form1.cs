using System;
using System.Windows.Forms;

namespace Lab4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "lab4DataSet.material". При необходимости она может быть перемещена или удалена.
            this.materialTableAdapter.Fill(this.lab4DataSet.material);

        }
    }
}
