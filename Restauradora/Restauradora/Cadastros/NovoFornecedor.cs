﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Restauradora.Cadastros;

namespace Restauradora.Cadastros
{
    public partial class NovoFornecedor : ViewCadastroPadrao
    {
        private ViewPadrao f;
        public NovoFornecedor(ViewPadrao _f)
        {
            InitializeComponent();
            this.f = _f;
        }
    }
}