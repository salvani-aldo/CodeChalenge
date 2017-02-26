using CodeChalenge.Interface;
using CodeChalenge.library;
using CodeChalenge.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodeChalenge
{
    public partial class main : Form
    {

        public main()
        {
            InitializeComponent();
        }

        private void ComputeCost_Click(object sender, EventArgs e)
        {
            try
            {
                if (!InputValid())
                    return;

                productModel _model = GetValues();
                List<IBase> delivery = new DeliveryBuilder(_model).SetReject().SetHeavy().SetSmall().SetMedium().SetLarge().Build();

                foreach (var _base in delivery)
                {
                    var result = _base.Processed();
                    if (result)
                    {
                        cost.Text = _base.GetCost().ToString();
                        category.Text = _base.GetCategory();

                        break;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Code Chalenge", MessageBoxButtons.OK);
            }
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private productModel GetValues()
        {
            return new productModel()
            {
                Depth = double.Parse(depth.Text),
                Height = double.Parse(height.Text),
                Weight = double.Parse(weight.Text),
                Width = double.Parse(width.Text)
            };
        }

        private bool InputValid()
        {
            bool result = true;

            if (string.IsNullOrEmpty(weight.Text) || weight.Text == "0")
            {
                errorProvider.SetError(weight, "Input Weight greater than 0");
                result = false;
            }
            else
            {
                errorProvider.SetError(weight, "");
            }

            if (string.IsNullOrEmpty(height.Text) || height.Text == "0")
            {
                errorProvider.SetError(height, "Input Height greater than 0");
                result = false;
            }
            else
            {
                errorProvider.SetError(height, "");
            }

            if (string.IsNullOrEmpty(width.Text) || width.Text == "0")
            {
                errorProvider.SetError(width, "Input Width greater than 0");
                result = false;
            }
            else
            {
                errorProvider.SetError(width, "");
            }

            if (string.IsNullOrEmpty(depth.Text) || depth.Text == "0")
            {
                errorProvider.SetError(depth, "Input Depth greater than 0");
                result = false;
            }
            else
            {
                errorProvider.SetError(depth, "");
            }

            return result;
        }

        private void weight_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = ValidInput(e);
        }

        private bool ValidInput(KeyPressEventArgs e)
        {
            if (e.KeyChar != '.' && !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                return true;
            }

            return false;
        }

        private void height_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = ValidInput(e);
        }

        private void width_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = ValidInput(e);
        }

        private void depth_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = ValidInput(e);
        }
    }
}
