using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace c34688cc_550a_4fb5_9b4f_b049ba618050
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Permet d'affecter la même data source que Form1.bindingSource1
        /// </summary>
        /// <param name="dataSourceOfbindingSource1OfForm1"></param>
        public void SetBindingSourceOfCombo(object dataSourceOfbindingSource1OfForm1)
        {
            this.bindingSourceOfCombo.DataSource = dataSourceOfbindingSource1OfForm1;
            this.bindingSourceOfCombo.DataMember = "DataTable1";

            this.ColonnedeComboBox.ValueMember = "AAA";  // Dans la combo box on souhaite afficher la colonne AAA de Form1
        }

        private void dataGridView2_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            // Si la valeur changée concerne la colonne de combo et si ce n'est pas le titre (-1)
            if (e.ColumnIndex == this.ColonnedeComboBox.Index && e.RowIndex != -1)
            {
                // La combo a changé de valeur
                // Récupérer la ligne de données associée
                DataSet1.DataTable2Row row;
                row = (DataSet1.DataTable2Row)((DataRowView)this.bindingSource2.Current).Row;

                // Récupérer la ligne de donnée sélectionné dans la combo
                DataSet1.DataTable1Row comboRow;
                comboRow = (DataSet1.DataTable1Row)((DataRowView)this.bindingSourceOfCombo.Current).Row;

                // Copier AAA, BBB, CCC de comboRow => row
                row.AAA = comboRow.AAA;
                row.BBB = comboRow.BBB;
                row.CCC = comboRow.CCC;

                // Remplir les autres colonnes
                row.DDD = comboRow.AAA + " " + comboRow.BBB;
                row.EEE = "Vive le café !!";
                row.FFF = "Avec les forums MSDN France, j'obtiens toujours une réponse à mes questions !";

                this.dataGridView2.InvalidateRow(e.RowIndex);
            }
        }
    }
}
