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
using Restauradora.ViewCadastros;

namespace Restauradora
{
    public partial class ViewPadrao : Form
    {
        public static string _tipoCadastro;
        public static string _tipoConexao;
        public static string _tipoSQL;


        //public static Fornecedor _tipoFornecedor;

        public ViewPadrao()
        {
            InitializeComponent();
            IniciaGrid();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            IniciaCadastros();
        }

        public void IniciaGrid()
        {
            dgvCadastro.DataSource = FunGer.selectDB(_tipoSQL);
        }

        public void IniciaCadastros()
        {
            switch (_tipoCadastro)
            {
                case "novousuario":
                    NovoUsuario A = new NovoUsuario(this);
                    A.Show();
                    break;
                case "novocliente":
                    NovoCliente B = new NovoCliente(this);
                    B.Show();
                    break;
                case "novoproduto":
                    NovoProduto C = new NovoProduto(this);
                    C.Show();
                    break;
                case "novofornecedor":
                    NovoFornecedor D = new NovoFornecedor(this);
                    D.Show();
                    break;
                case "novopedido":
                    NovoPedido E = new NovoPedido(this);
                    E.Show();
                    break;
                default:
                    break;
            }
        }

        private void btnExluir_Click(object sender, EventArgs e)
        {
            switch (_tipoCadastro)
            {
                case "novousuario":
                    RemovePadrao("USUARIO");
                    break;
                case "novocliente":
                    RemovePadrao("CLIENTES");
                    break;
                case "novoproduto":
                    RemovePadrao("PRODUTO");
                    break;
                case "novofornecedor":
                    RemovePadrao("FORNECEDOR");
                    break;
                case "novopedido":
                    RemovePadrao("PEDIDO");
                    break;
                default:
                    break;
            }
        }

        public void RemovePadrao(string _tabela)
        {
            try
            {
                 string idremove = dgvCadastro.SelectedRows[0].Cells[0].Value.ToString();
                //FunGer.deleteDB("DELETE FROM CLIENTES WHERE id = '" + Convert.ToInt32(idremove) + "'");
                 FunGer.ExecutaSQL("UPDATE " + _tabela + " SET ativo = 0 WHERE id = '" + idremove + "' ");
                 dgvCadastro.DataSource = FunGer.selectDB("SELECT * FROM " + _tabela + " WHERE Ativo = 1");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            switch (_tipoCadastro)
            {
                case "novousuario":
                    AtualizaGrid("USUARIO");
                    break;
                case "novocliente":
                    AtualizaGrid("CLIENTES");
                    break;
                case "novoproduto":
                    AtualizaGrid("PRODUTO");
                    break;
                case "novofornecedor":
                    AtualizaGrid("FORNECEDOR");
                    break;
                case "novopedido":
                    AtualizaGrid("PEDIDO");
                    break;
                default:
                    break;
            }
        }

        public void AtualizaGrid(string _tabela)
        {
            dgvCadastro.DataSource = FunGer.selectDB("SELECT * FROM " + _tabela + " WHERE Ativo = 1");
        }
    }
}