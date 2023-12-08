using System;
using System.Collections.Generic;
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

namespace Gogin203Ekz.Pages
{
    /// <summary>
    /// Логика взаимодействия для tablic.xaml
    /// </summary>
    public partial class tablic : Page
    {
        public tablic()
        {
            InitializeComponent();
            Tablic.ItemsSource = BdGoginEntities2.getcontect().Naim_Opis.ToList();
           
        }

        private void tabl_1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
          
        }

        private void Tablic_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
