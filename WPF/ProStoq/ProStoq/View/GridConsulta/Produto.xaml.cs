﻿using System;
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
using ProStoq.View.NovoCadastro;

namespace ProStoq.View
{
    /// <summary>
    /// Interaction logic for Produto.xaml
    /// </summary>
    public partial class Produto : UserControl
    {
        public Produto()
        {
            InitializeComponent();
            dataGrid.DataContext = FunGer.selectDB("SELECT * FROM Produto");
        }

        private void btnNovo_Click(object sender, RoutedEventArgs e)
        {
            var A = new ProdutoView();
            A.Show();
        }
    }
}
