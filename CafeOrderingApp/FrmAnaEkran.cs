﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeOrderingApp
{
    public partial class FrmAnaEkran : Form
    {
        public FrmAnaEkran()
        {
            InitializeComponent();
        }
        private FrmMenu _frmMenu;
        private void ürünlerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(_frmMenu==null || _frmMenu.IsDisposed)
            {
                _frmMenu = new FrmMenu();
                
            }
            _frmMenu.Show();
            _frmMenu.WindowState = FormWindowState.Maximized;


        }
        private FrmKatAyar _frmKatAyar;
        private void katMasaAyarlarıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(_frmKatAyar==null || _frmKatAyar.IsDisposed)
            {
                _frmKatAyar = new FrmKatAyar();
               
            }
            _frmKatAyar.Show();
            _frmKatAyar.WindowState = FormWindowState.Maximized;    
        }
        private FrmKafe _frmKafe;
        private void siparişToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_frmKafe == null || _frmKafe.IsDisposed)
                _frmKafe = new FrmKafe();
            _frmKafe.Show();
            _frmKafe.WindowState = FormWindowState.Maximized;
        }
    }
}
