using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace ClassLibrary1
{
    public class TextBoxHelper
    {
        //需要添加的程序集
        //PresentationCore presentationFrameWork Xaml

        public static string GetMyTxt(DependencyObject obj)
        {
            return (string)obj.GetValue(MyTxtProperty);
        }

        public static void SetMyTxt(DependencyObject obj, string value)
        {
            obj.SetValue(MyTxtProperty, value);
        }

        // Using a DependencyProperty as the backing store for MyTxt.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty MyTxtProperty =
            DependencyProperty.RegisterAttached("MyTxt", typeof(string), typeof(TextBoxHelper), new PropertyMetadata("xxx",TextChanged));
       
        // "xxx"  后面回调方法
        private static void TextChanged(DependencyObject obj, DependencyPropertyChangedEventArgs e)
        {
            TextBox element = obj as TextBox;
            if (element!=null)
            {
                element.Text = e.NewValue.ToString();
            }
        }

               
    }
}
