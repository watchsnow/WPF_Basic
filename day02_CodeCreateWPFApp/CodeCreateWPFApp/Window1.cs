using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;

namespace CodeCreateWPFApp
{
    class Window1:Window
    {
        private Button btn1;
        public Window1()
        {
            InitializeComponent();
        }
        public void InitializeComponent()
        {
            this.Width = 285;
            this.Height = 250;
            this.Left = this.Top = 100;
            this.Title = "Code-Only Window";
            DockPanel pa = new DockPanel();
            btn1 = new Button();
            btn1.Content = "Please click me";
            btn1.Margin = new Thickness(30);
            btn1.Click += btn1_clieck;
            IAddChild con = pa;
            con.AddChild(btn1);
            con = this;
            con.AddChild(pa);
        }
        private void btn1_clieck(object sender, RoutedEventArgs enent)
        {
            btn1.Content = "thank you";
        }
    }
}
