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
    /// Логика взаимодействия для Vxod.xaml
    /// </summary>
    public partial class Vxod : Page
    {
        public Vxod()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var userObj = BdGoginEntities2.getcontect().Polzov.FirstOrDefault(x => x.Pochta== Log.Text && x.Parol == Par.Text);
            if (userObj == null)
            {
                MessageBox.Show("Пользователь с таким логином и паролем!", "Ошибка входа", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                MessageBox.Show("Здраствуйте  " + userObj.Familia + "!", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Information);
                this.NavigationService.Navigate(new tablic());
            }
            this.NavigationService.Navigate(new tablic());
        }
    }
}
