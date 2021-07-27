using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OperationLibrary;

namespace OperationAB
{
    
    public partial class Form1 : Form
    {
        delegate string DoOperation(string a, string b);
        DoOperation operation = null;
        List<BaseOperation> operations;

        public Form1()
        {
            operations = AvailableOperations.operations.OrderBy(x=>x.OperationName).ToList();                

            InitializeComponent();
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.DataSource = operations.Select(x => x.OperationName).ToList();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            operation = operations
                .Where(x => x.OperationName == comboBox1.Text)
                .First()
                .DoOperation;

            try
            {
                textBox3.Text = operation(textBox1.Text, textBox2.Text);
            }
            catch (Exception exception)
            {
                System.Windows.Forms.MessageBox.Show(exception.Message);
            }             

        }
    }
}
