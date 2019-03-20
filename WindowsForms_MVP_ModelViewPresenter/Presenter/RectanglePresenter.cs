using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsForms_MVP_ModelViewPresenter.View;
using WindowsForms_MVP_ModelViewPresenter.Model;

namespace WindowsForms_MVP_ModelViewPresenter.Presenter
{
    public class RectanglePresenter
    {
        IRectangle rectangleView;

        public RectanglePresenter(IRectangle view)
        {
            rectangleView = view;
        }


        public void CalculateArea()
        {
            Rectangle rectangle = new Rectangle();
            rectangle.Length = double.Parse(rectangleView.LengthText);
            rectangle.Breadth = double.Parse(rectangleView.BreadthText);

            rectangleView.AreaText = rectangle.CalcArea().ToString();
        }
    }
}
