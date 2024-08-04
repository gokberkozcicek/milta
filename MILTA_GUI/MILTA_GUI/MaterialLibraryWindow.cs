using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MiltaCore;
namespace MILTA_GUI
{
    public partial class MaterialLibraryWindow : Form
    {
        public MaterialCollection Materias { get; set; }= new MaterialCollection();
        public MaterialLibraryWindow()
        {
            InitializeComponent();

        }
        

        private void MaterialLibraryWindow_Load(object sender, EventArgs e)
        {

         }

        private void FillMaterials()
        {
            materialDataGridView.DataSource = Materias;

            materialDataGridView.Columns.Clear();
            materialDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Name",
                HeaderText = "Material Name",
            });
   
            materialDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "YoungModulus",
                HeaderText = "YoungModulus",
            });
            materialDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "PoissonsRatio",
                HeaderText = "PoissonsRatio",
            });
            materialDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "G",
                HeaderText = "Shear Modulus",
            });
            materialDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "YieldStregnth",
                HeaderText = "YieldStregnth",
            }); 
            materialDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "UTS",
                HeaderText = "UTS",
            });
            materialDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Density",
                HeaderText = "Density",
            });

    }
    }
}
