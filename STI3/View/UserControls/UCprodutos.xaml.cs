using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace STI3.View.UserControls
{
    /// <summary>
    /// Interação lógica para UCprodutos.xam
    /// </summary>
    public partial class UCprodutos : UserControl
    {
        public UCprodutos()
        {
            InitializeComponent();
        }

        private void BtnAdcionar_Click(object sender, RoutedEventArgs e)
        {

        }
    }

    public class PropertyChange : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        protected void OnPropertyChanged(String name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }

    public class UCprodutoViewModel : PropertyChange
    {
        private string _nome;
        public string Nome 
        {
            get => _nome;
            set
            {
                _nome = value;
                OnPropertyChanged(nameof(Nome));

            }
        }
    }
}
