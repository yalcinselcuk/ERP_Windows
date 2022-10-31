﻿using ERPBase;
using OrtakProje.BaseForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ERPBase;

namespace OrtakProje.Forms
{
    public partial class frmBirimTanim : frmBaseTanim
    {

        #region Objects
        birimtanimclass birimtanim = null;
        #endregion

        #region Constructor
        public frmBirimTanim()
        {
            birimtanim = new birimtanimclass();


            grdList.DataSource = birimtanim.XdtMain;
            birimtanim.XdtMain.Columns.Add(new DataColumn("id", typeof(int)));
            birimtanim.XdtMain.Columns.Add(new DataColumn("kod", typeof(string)));
            birimtanim.XdtMain.Columns.Add(new DataColumn("aciklama", typeof(string)));
            birimtanim.LoadData();
            grdProperty();
            InitializeComponent();
        }
        #endregion


        public override void btnSave_Click(object sender, EventArgs e)
        {
            if (birimtanim.Validate())
            {
                birimtanim.SaveData();
            }
        }
        public override void frmBaseTanim_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Değişikler Kaydedilsin mi?", "KeyBilgi", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                if (birimtanim.Validate())
                {
                    birimtanim.SaveData();
                }
            }
        }
        void grdProperty()
        {
            grdList.Columns[0].HeaderText = "ID";
            grdList.Columns[0].Visible = false;
            grdList.Columns[1].HeaderText = "KOD";
            grdList.Columns[2].HeaderText = "AÇIKLAMA";
        }

    }
}
