﻿using FogGerenciadorDeVendas.Telas.Controles.Produtos;
using MetroFramework.Forms;
using System;
using System.Drawing;
using System.Linq;
using Unity;

namespace FogGerenciadorDeVendas
{
    public partial class Menu : MetroForm
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            var produtos = Program.container.Resolve<Produtos>();
            produtos.Size = panel_principal.Size;
            panel_principal.Controls.Clear();
            panel_principal.Controls.Add(produtos);
        }
    }
}