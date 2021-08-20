using AulaWF04Manha;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace ExercicioFM
{
    public partial class Exec03 : Form
    {
        public Exec03()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }

        private void Exec03_Load(object sender, EventArgs e)
        {
            AtualizaDG();
        }
        private void AtualizaDG()
        {
            List<string[]> lista = DBFunction.GenericSelectall("Historico");
            dtMstrar.Rows.Clear();
            foreach (var item in lista)
            {
                dtMstrar.Rows.Add(item);
            }
            for (int i = 0; i < dtMstrar.Rows.Count; i++)
            {
                if (Convert.ToDouble(dtMstrar.Rows[i].Cells["ValorLiquidoColl"].Value) < 0)
                {
                    dtMstrar.Rows[i].Cells["ValorLiquidoColl"].Style.ForeColor = Color.Red;
                }

            }
        }
        private void btnCaucula_Click(object sender, EventArgs e)
        {
            double valorLiquido = 0, novoSaldo = 0, despesa = 0, ganhos = 0;
            bool lucrou = true;

            double valor = Convert.ToDouble(dtMstrar.Rows[dtMstrar.Rows.Count - 1].Cells[1].Value);

            despesa = Convert.ToDouble(txtDespesas.Text);
            ganhos = Convert.ToDouble(txtGanhos.Text);

            CauculaMes(valor, despesa, ganhos, out valorLiquido, out novoSaldo, out lucrou);

            string insert = $"INSERT into dbo.Historico (ValorEmCaixa,DespesasDoMes,GanhosDoMes,ValorLiquido,SeLucro) values ({novoSaldo.ToString(CultureInfo.InvariantCulture)},{despesa.ToString(CultureInfo.InvariantCulture)},{ganhos.ToString(CultureInfo.InvariantCulture)},{valorLiquido.ToString(CultureInfo.InvariantCulture)},{Convert.ToInt32(lucrou)})";

            DBFunction.GenericExecute(insert);
            AtualizaDG();

        }
        private void CauculaMes(double saldoAtual, double despesas, double ganhos, out double valorLiquido, out double novoSaldo, out bool deuLucro)
        {
            valorLiquido = ganhos - despesas;
            novoSaldo = saldoAtual + valorLiquido;

            if (valorLiquido > 0)
            {
                deuLucro = true;
            }
            else
            {
                deuLucro = false;
            }
        }


    }
}
