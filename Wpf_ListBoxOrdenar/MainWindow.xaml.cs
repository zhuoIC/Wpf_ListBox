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
//----------------------------------------------
using System.ComponentModel;

namespace Wpf_ListBoxOrdenar
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void cbxOrdenar_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // Al seleccionar una opción
            lbxMiListBox.Items.SortDescriptions.Clear(); // No hay ningún criterio de ordenación
            if (cbxOrdenar.SelectedIndex == 0)
            {
                lbxMiListBox.Items.SortDescriptions.Add(new SortDescription("Content", ListSortDirection.Ascending));
            }
            if (cbxOrdenar.SelectedIndex == 1)
            {
                lbxMiListBox.Items.SortDescriptions.Add(new SortDescription("Content", ListSortDirection.Descending));
            }
        }
    }
}
