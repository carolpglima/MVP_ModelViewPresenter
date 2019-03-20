using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsForms_MVP_ModelViewPresenter.View;
using WindowsForms_MVP_ModelViewPresenter.Presenter;

namespace WindowsForms_MVP_ModelViewPresenter
{
    public partial class Form1 : Form,IRectangle
    {
        public Form1()
        {
            InitializeComponent();
        }

        public string LengthText
        {
            get
            {
                return textLength.Text;
            }
            set
            {
                textLength.Text = value;
            }
        }
           // => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string BreadthText
        {
            get
            {
                return textBreadth.Text;
            }
            set
            {
                textBreadth.Text = value;
            }
            //{ get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        }
        public string AreaText
        {
            get
            {
                return lArea.Text;
            }
            set
            {
                lArea.Text = value;
            }
            //=> throw new NotImplementedException(); set => throw new NotImplementedException(); }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            RectanglePresenter presenter = new RectanglePresenter(this);
            presenter.CalculateArea();
        }
    }
}
