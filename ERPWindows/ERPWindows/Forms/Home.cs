﻿using OrtakProje.Forms;
using OrtakProje.Forms.StokHareket;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace OrtakProje
{
    public partial class Home : Form
    {
        #region Object
        #endregion
        public Home()
        {
            InitializeComponent();
        }


        frmStokTanim frmstoktanim;
        private void mnStokTanim_Click(object sender, EventArgs e)
        {
            //acik olan sayfanin tekrar acilmasini engelledik
            if (frmstoktanim == null || frmstoktanim.IsDisposed)
            {
                frmstoktanim = new frmStokTanim();
                frmstoktanim.MdiParent = this;
                frmstoktanim.Show();
            }
        }

        frmRenkTanim frmrenktanim;
        private void mnRenkTanim_Click(object sender, EventArgs e)
        {
            if (frmrenktanim == null || frmrenktanim.IsDisposed)
            {
                frmrenktanim = new frmRenkTanim();
                frmrenktanim.MdiParent = this;
                frmrenktanim.Show();
            }
        }
        frmBirimTanim frmbirimtanim;
        private void mnBirimTanim_Click(object sender, EventArgs e)
        {
            if (frmbirimtanim == null || frmbirimtanim.IsDisposed)
            {
                frmbirimtanim = new frmBirimTanim();
                frmbirimtanim.MdiParent = this;
                frmbirimtanim.Show();
            }
        }
        frmFirmaTanim frmfirmatanim;
        private void mnFirmaTanim_Click(object sender, EventArgs e)
        {
            if (frmfirmatanim == null || frmfirmatanim.IsDisposed)
            {
                frmfirmatanim = new frmFirmaTanim();
                frmfirmatanim.MdiParent = this;
                frmfirmatanim.Show();
            }
        }
        frmDepoTanim frmdepotanim;
        private void mnDepoTanim_Click(object sender, EventArgs e)
        {
            if (frmdepotanim == null || frmdepotanim.IsDisposed)
            {
                frmdepotanim = new frmDepoTanim();
                frmdepotanim.MdiParent = this;
                frmdepotanim.Show();
            }
        }
        frmStokHareketListesi frm;
        private void stokHareketleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm = new frmStokHareketListesi();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
