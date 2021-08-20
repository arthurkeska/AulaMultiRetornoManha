using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoZero
{
    public partial class Exec03 : Form
    {
        private object DBFunction;
        private object dgHistorico;

        public Exec03()
        {
            InitializeComponent();
        }

        private void Exec03_Load(object sender, EventArgs e)
        {
            AtualizaDG();
        }

        private void AtualizaDG()
        {
            List<string[]> lista = DBFunction.GenericSelectAll("Historico");
            dgHistorico.Rows.Clear();
            foreach (var item in lista)
            {
                dgHistorico.Rows.Add(item);
            }
        }

        private void btncalcula_Click(object sender, EventArgs e)
        {
            double ValorLiquido = 0, NovoSaldo = 0,despesa = 0, ganhos = 0;
            bool Lucrou = true;
            
            
            double valor = Convert.ToDouble(dgHistorico.Rows.[dgHistorico.Rows.Count - 1].Cells[1].Value.);

            despesa = Convert.ToDouble(txtdespesas.Text);
            ganhos = Convert.ToDouble(txtganhos.Text);

            CalculaMes(valor, despesa, ganhos, out double ValorLiquido, out double NovoSaldo, out bool deuLucro);

 string select = $"insert into dbo.Historico(ValorEmCaixa, DespesasDoMes, GanhosDoMes, ValorLiquido, SeLucrou) values({NovoSaldo},{despesa},{}


        }


        private void CalculaMes(Double SaldoAtual, double Despesas, double Ganhos, out double ValorLiquido, out double NovoSaldo, out bool deuLucro)
        {

            ValorLiquido = Ganhos - Despesas;
            NovoSaldo = SaldoAtual - ValorLiquido;
            if (ValorLiquido > 0)
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
