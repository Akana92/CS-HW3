using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_HW3
{
    internal class NewComlex
    {
        public double im;
        public double re;

        /// Конструктор без параметров
        public NewComlex()
        {
            im = 0;
            re = 0;
        }
        ///Конструктор с параметрами
        public NewComlex(double im, double re)
        {
            this.im = im;
            this.re = re;
        }

        ///Метод сложения с другим комплексным числом
        public NewComlex Plus(NewComlex x)
        {
            NewComlex y = new NewComlex();
            y.im = x.im + im;
            y.re = x.re + re;
            return y;
        }
        ///Метод разности с другим комплексным числом
        public NewComlex Minus(NewComlex x)
        {
            NewComlex y = new NewComlex();
            y.im = im - x.im;
            y.re = re - x.re;
            return y;
        }
        ///Метод произведения с другим комплексным числом
        public NewComlex Multi(NewComlex x)
        {
            NewComlex y = new NewComlex();
            y.im = re * x.im + im * x.re;
            y.re = re * x.re - im * x.im;
            return y;
        }
        ///Свойство для мнимой части
        public double Im
        {
            get { return im; }
            set
            {
                if (value >= 0) im = value;
            }
        }
        public string ToString()
        {
            return re + "+" + im + "i";
        }
    }
}
