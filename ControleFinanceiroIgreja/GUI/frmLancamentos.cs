using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using ControleFinanceiroIgreja.TAD;
using ControleFinanceiroIgreja.DAO;
using System.Globalization;

namespace ControleFinanceiroIgreja.GUI
{
    public partial class frmLancamentos : Form
    {
        decimal saldoMes = 0;
        Igreja ig;

        public frmLancamentos(Igreja ig)
        {

            InitializeComponent();
            this.ig = ig;

        }




        private void btnEntrada_Click(object sender, EventArgs e)
        {
            int ano = 0; int mes = 0;
            Entrada ent = new Entrada();
            ent.id = 0;

            if ((cbAno.Items.Count > 0) && (cbAno.SelectedIndex >= 0) && (cbMes.SelectedIndex >= 0))
            {
                ano = Convert.ToInt32(cbAno.Text);
                mes = cbMes.SelectedIndex + 1;
            }

            frmEntrada frm = new frmEntrada(ent, ano, mes);

            frm.ShowDialog();

            while (frm.chkLote.Checked)
            {
                atualizaDados();
                //está em lote, loop até desmarcar
                ent = new Entrada();
                ent.id = 0;
                frm = new frmEntrada(ent, ano, mes);
                frm.chkLote.Checked = true;

                frm.ShowDialog();

            }

            atualizaDados();


        }

        private void impGraficoAnual(object sender, EventArgs e)
        {

            //se nao possui ano entao sai fora meu filho
            if (cbAno.Items.Count == 0)
            {
                MessageBox.Show("Nenhum lançamento foi encontrado no sistema!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            int ano = 0, mes = 0;

            frmSelMes frmSel = new frmSelMes(false, true, true);

            frmSel.ShowDialog();

            if (frmSel.DialogResult != DialogResult.OK)
                return;

            ano = frmSel.ano;
            mes = frmSel.chkd ? frmSel.mes : 1;

            List<BindingSource> listBS = new List<BindingSource>();
            List<Object> listTotais = new List<Object>();

            BindingSource bse = new BindingSource();

            bse.DataSource = new CrudEntrada().listaEntradaGeralAno(Conexao.con, ano, mes);

            listBS.Add(bse);

            BindingSource bss = new BindingSource();

            bss.DataSource = new CrudSaida().listaSaidaGeralAno(Conexao.con, ano, mes);

            listBS.Add(bss);

            listTotais.Add((bse.Count + bss.Count).ToString());


            listTotais.Add(frmSel.chkd ? frmSel.nomeMes : "Janeiro");
            listTotais.Add(ano.ToString());



            frmVerRelatorio frm = new frmVerRelatorio(listBS, listTotais,
                ig, TiposRel.relGeralChartAnual);

            frm.ShowDialog();
        }

        private void impGrafico(object sender, EventArgs e)
        {

            //se nao possui ano entao sai fora meu filho
            if (cbAno.SelectedIndex == -1)
            {
                MessageBox.Show("Nenhum lançamento foi encontrado no sistema!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            int ano = 0, mes = 0;

            ano = Convert.ToInt32(cbAno.Text);
            mes = cbMes.SelectedIndex + 1;

            List<BindingSource> listBS = new List<BindingSource>();
            List<Object> listTotais = new List<Object>();

            BindingSource bse = new BindingSource();

            bse.DataSource = new CrudEntrada().listaEntradaGeral(Conexao.con, ano, mes);

            listBS.Add(bse);

            BindingSource bss = new BindingSource();

            bss.DataSource = new CrudSaida().listaSaidaGeral(Conexao.con, ano, mes);

            listBS.Add(bss);

            listTotais.Add((bse.Count + bss.Count).ToString());


            listTotais.Add(cbMes.Text);
            listTotais.Add(ano.ToString());



            frmVerRelatorio frm = new frmVerRelatorio(listBS, listTotais,
                ig, TiposRel.relGeralChart);

            frm.ShowDialog();
        }

        private void btnSaida_Click(object sender, EventArgs e)
        {
            int ano = 0; int mes = 0;
            Saida sai = new Saida();
            sai.id = 0;

            if ((cbAno.Items.Count > 0) && (cbAno.SelectedIndex >= 0) && (cbMes.SelectedIndex >= 0))
            {
                ano = Convert.ToInt32(cbAno.Text);
                mes = cbMes.SelectedIndex + 1;
            }

            frmSaida frm = new frmSaida(sai, ano, mes);
            frm.ShowDialog();

            while (frm.chkLote.Checked)

            {

                atualizaDados();
                //está em lote, loop até desmarcar
                frm = new frmSaida(sai, ano, mes);
                frm.chkLote.Checked = true;

                frm.ShowDialog();

            }

            atualizaDados();
        }


        private void impAgrupado(object sender, EventArgs e)
        {

            //se nao possui ano entao sai fora meu filho
            if (cbAno.SelectedIndex == -1)
            {
                MessageBox.Show("Nenhum lançamento foi encontrado no sistema!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            //criar grids e preencher

            DataGridView dtgEntradasAg = new DataGridView(), dtgSaidasAg = new DataGridView();

            dtgEntradasAg.DataSource =
                  new CrudEntrada().listaEntradaGeral(Conexao.con,
                      Convert.ToInt32(cbAno.Text),
                      cbMes.SelectedIndex + 1);

            dtgSaidasAg.DataSource =
              new CrudSaida().listaSaidaGeral(Conexao.con,
                  Convert.ToInt32(cbAno.Text),
                  cbMes.SelectedIndex + 1);


            //Enviar para impressao
            List<BindingSource> listBS = new List<BindingSource>();
            List<Object> listTotais = new List<Object>();
            int ano = 0, mes = 0;
            BindingSource bs = new BindingSource();

            bs.DataSource = dtgEntradasAg.DataSource;

            listBS.Add(bs);

            bs = new BindingSource();

            bs.DataSource = dtgSaidasAg.DataSource;

            listBS.Add(bs);

            //enviar SaldoAnterior (mes,ano)
            if ((cbAno.Items.Count > 0) && (cbAno.SelectedIndex >= 0) && (cbMes.SelectedIndex >= 0))
            {
                ano = Convert.ToInt32(cbAno.Text);
                mes = cbMes.SelectedIndex + 1;
            }

            listTotais.Add(listBS[0].Count + listBS[1].Count);

            listTotais.Add(new CrudLancamento().totalEntrada(Conexao.con, ano, mes));
            listTotais.Add(new CrudLancamento().totalSaida(Conexao.con, ano, mes));
            listTotais.Add(lblSaldoMes.Text);
            listTotais.Add(cbMes.Text);
            listTotais.Add(cbAno.Text);


            decimal saldoAnterior = new CrudLancamento().saldoAnterior(Conexao.con, ano, mes);

            listTotais.Add(saldoAnterior);
            //enviar SaldoAtual (mes,ano)
            decimal saldoAtual = saldoAnterior + saldoMes;

            listTotais.Add(saldoAtual);

            frmVerRelatorio frm = new frmVerRelatorio(listBS, listTotais,
                ig, TiposRel.relGeral);

            frm.ShowDialog();
        }

        private void impAgrupadoAnual(object sender, EventArgs e)
        {

            //se nao possui ano entao sai fora meu filho
            if (cbAno.Items.Count == 0)
            {
                MessageBox.Show("Nenhum lançamento foi encontrado no sistema!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            frmSelMes frmSel = new frmSelMes(false, true, true);

            frmSel.ShowDialog();


            if (frmSel.DialogResult != DialogResult.OK)
                return;

            DataGridView dtgEntradasAg = new DataGridView(), dtgSaidasAg = new DataGridView();
            decimal totalEntradas, totalSaidas, saldoAnterior;

            int ano = frmSel.ano;

            if (frmSel.chkd)
            {

                dtgEntradasAg.DataSource =
                      new CrudEntrada().listaEntradaGeralAno(Conexao.con,
                          ano,
                          frmSel.mes);

                dtgSaidasAg.DataSource =
                  new CrudSaida().listaSaidaGeralAno(Conexao.con,
                      ano, frmSel.mes);

                //repetir
                totalEntradas = new CrudLancamento().totalEntradasRelAnual(Conexao.con, ano, frmSel.mes);
                totalSaidas = new CrudLancamento().totalSaidasRelAnual(Conexao.con, ano, frmSel.mes);
                saldoAnterior = new CrudLancamento().saldoAnterior(Conexao.con, ano, frmSel.mes);



            }
            else
            {
                dtgEntradasAg.DataSource =
                      new CrudEntrada().listaEntradaGeralAno(Conexao.con,
                          ano,
                          1);

                dtgSaidasAg.DataSource =
                  new CrudSaida().listaSaidaGeralAno(Conexao.con,
                      ano, 1);

                totalEntradas = new CrudLancamento().totalEntradaAnual(Conexao.con, ano);
                totalSaidas = new CrudLancamento().totalSaidaAnual(Conexao.con, ano);
                saldoAnterior = new CrudLancamento().saldoAnterior(Conexao.con, ano, 1);
            }


            //Enviar para impressao
            List<BindingSource> listBS = new List<BindingSource>();
            List<Object> listTotais = new List<Object>();
            int lin = 0;
            BindingSource bs = new BindingSource();

            bs.DataSource = dtgEntradasAg.DataSource;

            listBS.Add(bs);

            lin += bs.Count;

            bs = new BindingSource();

            bs.DataSource = dtgSaidasAg.DataSource;

            listBS.Add(bs);

            lin += bs.Count;

            listTotais.Add(listBS[0].Count + listBS[1].Count);


            listTotais.Add(frmSel.chkd ? frmSel.nomeMes : "Janeiro");
            listTotais.Add(ano);


            listTotais.Add(totalEntradas);
            listTotais.Add(totalSaidas);
            listTotais.Add(saldoAnterior);
            // listTotais.Add(saldoAtual);

            frmVerRelatorio frm = new frmVerRelatorio(listBS, listTotais,
                ig, TiposRel.relGeralAnual);

            frm.ShowDialog();
        }

        private void carregaDados()
        {

            DataTable dt = new CrudLancamento().anosLanc(Conexao.con);

            dtgEntradas.DataSource = new DataTable();
            dtgSaidas.DataSource = new DataTable();
            lblTotalEntradas.Text = "R$ 0,00";
            lblTotalSaidas.Text = "R$ 0,00";
            lblSaldoMes.Text = "R$ 0,00";

            if (dt.Rows.Count > 0)
            {
                cbAno.Items.Clear();

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    cbAno.Items.Add(dt.Rows[i]["Ano"].ToString());
                }


            }


            cbMes.SelectedIndex = DateTime.Now.Month - 1;
            cbAno.SelectedIndex = cbAno.Items.IndexOf(DateTime.Now.Year.ToString());


        }

        private void cbAno_SelectedIndexChanged(object sender, EventArgs e)
        {
            atualizaDados();
        }

        private void cbMes_SelectedIndexChanged(object sender, EventArgs e)
        {
            atualizaDados();
        }

        private void frmLancamentos_Load(object sender, EventArgs e)
        {
            if (Program.tablet)
                dtgEntradas.RowTemplate.MinimumHeight = Program.heightGrid;
            if (Program.tablet)
                dtgSaidas.RowTemplate.MinimumHeight = Program.heightGrid;

            carregaDados();

        }


        private void ribRelLancBal_Click(object sender, EventArgs e)
        {
            int ano = 0;

            frmSelMes frmSel = new frmSelMes(false, true, dinamico: true);

            frmSel.ShowDialog();

            if (frmSel.DialogResult != DialogResult.OK)
                return;
            List<BindingSource> listBS = new List<BindingSource>();
            List<Object> listTotais = new List<Object>();

            BindingSource bs = new BindingSource();
            decimal entradas = 0, saidas = 0, saldoano = 0,
                saldoanterior = 0, saldoatual = 0;

            ano = frmSel.ano;

            if (frmSel.chkd)
            {
                bs.DataSource = new CrudLancamento().relAnual(Conexao.con, ano, frmSel.mes);
                entradas = new CrudLancamento().totalEntradasRelAnual(Conexao.con, ano, frmSel.mes);
                saidas = new CrudLancamento().totalSaidasRelAnual(Conexao.con, ano, frmSel.mes);
            }
            else
            {
                bs.DataSource = new CrudLancamento().relAnual(Conexao.con, ano, 1);
                entradas = new CrudLancamento().totalEntradaAnual(Conexao.con, ano);
                saidas = new CrudLancamento().totalSaidaAnual(Conexao.con, ano);


            }

            saldoano = entradas - saidas;
            listBS.Add(bs);

            listTotais.Add(bs.Count.ToString());

            listTotais.Add(entradas);
            listTotais.Add(saidas);
            listTotais.Add(saldoano);

            listTotais.Add(frmSel.chkd ? "a partir de " + frmSel.nomeMes + "/" + ano : ano.ToString());


            saldoanterior = new CrudLancamento().saldoAnterior(Conexao.con, ano, frmSel.chkd ? frmSel.mes : 1);

            listTotais.Add(saldoanterior);
            //enviar SaldoAtual (mes,ano)
            saldoatual = saldoanterior + saldoano;

            listTotais.Add(saldoatual);

            frmVerRelatorio frm = new frmVerRelatorio(listBS, listTotais,
                ig, TiposRel.relBalancete);

            frm.ShowDialog();
        }

        private void ribRelLancBalChrt_Click(object sender, EventArgs e)
        {
            int ano = 0;

            frmSelMes frmSel = new frmSelMes(false, true, true);

            frmSel.ShowDialog();

            if (frmSel.DialogResult != DialogResult.OK)
                return;

            ano = frmSel.ano;

            List<BindingSource> listBS = new List<BindingSource>();
            List<Object> listTotais = new List<Object>();

            BindingSource bs = new BindingSource();

            if (frmSel.chkd)
                bs.DataSource = new CrudLancamento().relAnual(Conexao.con, ano, frmSel.mes);

            else
            {
                //   bs.DataSource = new CrudLancamento().balancete(Conexao.con, ano);
                bs.DataSource = new CrudLancamento().relAnual(Conexao.con, ano, 1);
            }
            listBS.Add(bs);

            listTotais.Add(bs.Count.ToString());

            listTotais.Add(frmSel.chkd ? "a partir de " + frmSel.nomeMes + " - " + ano : ano.ToString());

            frmVerRelatorio frm = new frmVerRelatorio(listBS, listTotais,
                ig, TiposRel.relBalanceteChart);

            frm.ShowDialog();
        }



        private void ribRelLancCont_Click(object sender, EventArgs e)
        {
            int ano = 0, idCat = 0, mes;
            string categoria, nomeMes;

            frmSelAnoEntrada frmSel = new frmSelAnoEntrada(selMes: true);

            frmSel.ShowDialog();

            if (frmSel.DialogResult == DialogResult.OK)
            {

                ano = frmSel.ano;
                idCat = frmSel.idCat;
                categoria = frmSel.cat;
                mes = frmSel.mes;
                nomeMes = frmSel.nomeMes;

                List<BindingSource> listBS = new List<BindingSource>();
                List<Object> listTotais = new List<Object>();
                BindingSource bs = new BindingSource();

                //criar funcao
                DataTable dt = new DAO.CrudLancamento().dizimistas(DAO.Conexao.con, ano: ano, id: idCat, mes: mes);

                bs.DataSource = dt;

                listBS.Add(bs);
                listTotais.Add(dt.Rows.Count.ToString());
                listTotais.Add(ano.ToString());
                listTotais.Add(categoria);
                listTotais.Add(nomeMes);

                frmVerRelatorio frmR = new frmVerRelatorio(listBS, listTotais,
                   ig, TiposRel.dizimistas);

                frmR.ShowDialog();


            }
        }

        private void ribRelLanMemEnt_Click(object sender, EventArgs e)
        {
            int ano = 0, idCat = 0;
            string categoria;

            frmSelAnoEntrada frmSel = new frmSelAnoEntrada();

            frmSel.ShowDialog();

            if (frmSel.DialogResult == DialogResult.OK)
            {

                ano = frmSel.ano;
                idCat = frmSel.idCat;
                categoria = frmSel.cat;

                List<BindingSource> listBS = new List<BindingSource>();
                List<Object> listTotais = new List<Object>();
                BindingSource bs = new BindingSource();

                DataTable dt = new DAO.CrudLancamento().membrosEntrada(DAO.Conexao.con, ano: ano, idCat: idCat);

                bs.DataSource = dt;

                listBS.Add(bs);
                listTotais.Add(dt.Rows.Count.ToString());
                listTotais.Add(ano.ToString());
                listTotais.Add(categoria);

                frmVerRelatorio frmR = new frmVerRelatorio(listBS, listTotais,
                   ig, TiposRel.relMembrosEntrada);

                frmR.ShowDialog();


            }
        }

        private void ribRelLancEntMem_Click(object sender, EventArgs e)
        {
            int ano = 0, idMembro = 0;
            string nomeMembro;

            frmSelAnoMembro frmSel = new frmSelAnoMembro();

            frmSel.ShowDialog();

            if (frmSel.DialogResult == DialogResult.OK)
            {

                ano = frmSel.ano;
                idMembro = frmSel.idMembro;
                nomeMembro = frmSel.nomeMembro;

                List<BindingSource> listBS = new List<BindingSource>();
                List<Object> listTotais = new List<Object>();
                BindingSource bs = new BindingSource();

                DataTable dt = new DAO.CrudLancamento().entradasMembro(DAO.Conexao.con,
                    ano: ano, idMembro: idMembro);

                bs.DataSource = dt;

                listBS.Add(bs);
                listTotais.Add(dt.Rows.Count.ToString());
                listTotais.Add(ano.ToString());
                listTotais.Add(nomeMembro);

                frmVerRelatorio frmR = new frmVerRelatorio(listBS, listTotais,
                   ig, TiposRel.relEntradasMembro);

                frmR.ShowDialog();


            }
        }

        private void atualizaDados()
        {



            //se ano tem count, e os dois tem index >= 0
            if ((cbAno.Items.Count > 0) && (cbAno.SelectedIndex >= 0) && (cbMes.SelectedIndex >= 0))
            {
                dtgEntradas.DataSource =
                  new CrudEntrada().listaEntrada(Conexao.con,
                      Convert.ToInt32(cbAno.Text),
                      cbMes.SelectedIndex + 1);

                dtgSaidas.DataSource =
                  new CrudSaida().listaSaida(Conexao.con,
                      Convert.ToInt32(cbAno.Text),
                      cbMes.SelectedIndex + 1);

                DataGridViewCellStyle style = new DataGridViewCellStyle();
                style.Format = "N2";
                dtgSaidas.Columns["Valor"].DefaultCellStyle = style;
                dtgEntradas.Columns["Valor"].DefaultCellStyle = style;

                decimal totalEntrada = 0, totalSaida = 0;

                totalEntrada = new CrudLancamento().totalEntrada(Conexao.con,
                      Convert.ToInt32(cbAno.Text),
                      cbMes.SelectedIndex + 1);
                totalSaida = new CrudLancamento().totalSaida(Conexao.con,
                      Convert.ToInt32(cbAno.Text),
                      cbMes.SelectedIndex + 1);
                saldoMes = totalEntrada - totalSaida;

                decimal saldoAnterior = new CrudLancamento().saldoAnterior(Conexao.con, Convert.ToInt32(cbAno.Text),
                      cbMes.SelectedIndex + 1);

                decimal totalGeral = saldoAnterior + saldoMes;

                lblTotalEntradas.Text = String.Format(
                    new CultureInfo("pt-BR"),
                    "{0:C}", totalEntrada);

                lblTotalSaidas.Text = String.Format(
                    new CultureInfo("pt-BR"),
                    "{0:C}", totalSaida);

                if (saldoMes < 0)
                {
                    lblSaldoMes.Text = String.Format(
                    new CultureInfo("pt-BR"),
                    "{0:C}", saldoMes);

                    lblSaldoMes.ForeColor = Color.Red;
                }
                else
                {
                    lblSaldoMes.Text = String.Format(
                    new CultureInfo("pt-BR"),
                    "{0:C}", saldoMes);

                    lblSaldoMes.ForeColor = Color.DeepSkyBlue;
                }

                if (totalGeral < 0)
                {
                    lblSaldoGeral.Text = String.Format(
                    new CultureInfo("pt-BR"),
                    "{0:C}", totalGeral);

                    lblSaldoGeral.ForeColor = Color.Red;
                }
                else
                {
                    lblSaldoGeral.Text = String.Format(
                    new CultureInfo("pt-BR"),
                    "{0:C}", totalGeral);

                    lblSaldoGeral.ForeColor = Color.DeepSkyBlue;
                }


                if (dtgEntradas.Rows.Count > 0)
                {
                    dtgEntradas.ClearSelection();//If you want

                    int nRowIndex = dtgEntradas.Rows.Count - 1;
                    int nColumnIndex = 3;

                    dtgEntradas.Rows[nRowIndex].Selected = true;
                    dtgEntradas.Rows[nRowIndex].Cells[nColumnIndex].Selected = true;

                    //In case if you want to scroll down as well.
                    dtgEntradas.FirstDisplayedScrollingRowIndex = nRowIndex;
                }
                //$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$

                if (dtgSaidas.Rows.Count > 0)
                {
                    dtgSaidas.ClearSelection();//If you want

                    int nRowIndex = dtgSaidas.Rows.Count - 1;
                    int nColumnIndex = 3;

                    dtgSaidas.Rows[nRowIndex].Selected = true;
                    dtgSaidas.Rows[nRowIndex].Cells[nColumnIndex].Selected = true;

                    //In case if you want to scroll down as well.
                    dtgSaidas.FirstDisplayedScrollingRowIndex = nRowIndex;
                }


            }
            else
            {
                dtgEntradas.DataSource = new DataTable();
                dtgSaidas.DataSource = new DataTable();

                lblTotalEntradas.Text = "R$ 0,00";
                lblTotalSaidas.Text = "R$ 0,00";
                lblSaldoMes.Text = "R$ 0,00";
                lblSaldoGeral.Text = "R$ 0,00";

            }



        }

        private void dtgEntradas_DoubleClick(object sender, EventArgs e)
        {

            /*@" SELECT  Id, Descricao, " +
                             @" Valor, Data, Membro, Obs " +
                             @" from VWEntradas " +
                             @" where YEAR(DATA) = " + ano + " " +
                             @" AND MONTH(DATA) = " + mes;*/

            if (dtgEntradas.SelectedRows.Count > 0)
            {

                Entrada entr = new Entrada();


                entr.id = Convert.ToInt32(dtgEntradas.SelectedRows[0].Cells["ID"].Value);
                entr.valor = Convert.ToDecimal(dtgEntradas.SelectedRows[0].Cells["Valor"].Value.ToString());
                entr.data = DateTime.Parse(dtgEntradas.SelectedRows[0].Cells["Data"].Value.ToString());
                entr.nomeMembro = dtgEntradas.SelectedRows[0].Cells["Membro"].Value.ToString();
                entr.idmembro = (entr.nomeMembro.Length >= 2) ? new CrudEntrada().getIdMembroEntrada(Conexao.con, entr.id) : 0;
                entr.idcat = new CrudEntrada().getIdCatEntrada(Conexao.con, entr.id);
                entr.obs = dtgEntradas.SelectedRows[0].Cells["Obs"].Value.ToString();

                frmEntrada frm = new frmEntrada(entr, 0, 0);

                frm.ShowDialog();

                if (frm.DialogResult == DialogResult.OK)
                {
                    atualizaDados();
                }



            }


        }



        private void dtgSaidas_DoubleClick(object sender, EventArgs e)
        {
            if (dtgSaidas.SelectedRows.Count > 0)
            {

                Saida said = new Saida();

                said.id = Convert.ToInt32(dtgSaidas.SelectedRows[0].Cells["ID"].Value);
                said.valor = Convert.ToDecimal(dtgSaidas.SelectedRows[0].Cells["Valor"].Value);
                said.data = DateTime.Parse(dtgSaidas.SelectedRows[0].Cells["Data"].Value.ToString());
                said.idCat = new CrudSaida().getIdCatSaida(Conexao.con, said.id);
                said.obs = dtgSaidas.SelectedRows[0].Cells["Obs"].Value.ToString();

                frmSaida frm = new frmSaida(said, 0, 0);

                frm.ShowDialog();

                if (frm.DialogResult == DialogResult.OK)
                {
                    atualizaDados();
                }


            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            //se nao possui ano entao sai fora meu filho
            if (cbAno.SelectedIndex == -1)
            {
                MessageBox.Show("Nenhum lançamento foi encontrado no sistema!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            List<BindingSource> listBS = new List<BindingSource>();
            List<Object> listTotais = new List<Object>();
            int ano = 0, mes = 0;
            BindingSource bs = new BindingSource();

            //enviar SaldoAnterior (mes,ano)
            if ((cbAno.Items.Count > 0) && (cbAno.SelectedIndex >= 0) && (cbMes.SelectedIndex >= 0))
            {
                ano = Convert.ToInt32(cbAno.Text);
                mes = cbMes.SelectedIndex + 1;
            }

            bs.DataSource = dtgEntradas.DataSource;

            listBS.Add(bs);

            bs = new BindingSource();

            bs.DataSource = dtgSaidas.DataSource;

            listBS.Add(bs);

            listTotais.Add((dtgEntradas.Rows.Count + dtgSaidas.Rows.Count).ToString());

            listTotais.Add(new CrudLancamento().totalEntrada(Conexao.con, ano, mes));
            listTotais.Add(lblTotalSaidas.Text);
            listTotais.Add(lblSaldoMes.Text);
            listTotais.Add(cbMes.Text);
            listTotais.Add(cbAno.Text);


            decimal saldoAnterior = new CrudLancamento().saldoAnterior(Conexao.con, ano, mes);

            listTotais.Add(saldoAnterior);
            //enviar SaldoAtual (mes,ano)
            decimal saldoAtual = saldoAnterior + saldoMes;

            listTotais.Add(saldoAtual);

            frmVerRelatorio frm = new frmVerRelatorio(listBS, listTotais,
                ig, TiposRel.relLancamentos);

            frm.ShowDialog();
        }

        private void dtgEntradas_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var hti = dtgEntradas.HitTest(e.X, e.Y);
                dtgEntradas.ClearSelection();

                if (hti.RowIndex < 0)
                {
                    editarEntradasMenu.Enabled = false;
                    removerEntradaMenu.Enabled = false;
                    return;
                }
                else
                {
                    editarEntradasMenu.Enabled = true;
                    removerEntradaMenu.Enabled = true;

                    dtgEntradas.Rows[hti.RowIndex].Selected = true;

                }
            }
        }//mouseDown

        private void dtgSaidas_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var hti = dtgSaidas.HitTest(e.X, e.Y);
                dtgSaidas.ClearSelection();

                if (hti.RowIndex < 0)
                {
                    editarSaidaMenu.Enabled = false;
                    removerSaidaMenu.Enabled = false;
                    return;
                }
                else
                {
                    editarSaidaMenu.Enabled = true;
                    removerSaidaMenu.Enabled = true;

                    dtgSaidas.Rows[hti.RowIndex].Selected = true;

                }
            }
        }

        private void removerEntradaMenu_Click(object sender, EventArgs e)
        {
            if (dtgEntradas.SelectedRows.Count > 0)
            {

                int id = Convert.ToInt32(dtgEntradas.SelectedRows[0].Cells[0].Value);

                if (MessageBox.Show("Tem certeza que deseja remover a ENTRADA de ID: " + id + "?",
                    "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    new CrudEntrada().removeEntrada(Conexao.con, id);

                    MessageBox.Show("Dados salvos com sucesso!",
                    "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    atualizaDados();

                }


            }
        }

        private void removerSaidaMenu_Click(object sender, EventArgs e)
        {
            if (dtgSaidas.SelectedRows.Count > 0)
            {

                int id = Convert.ToInt32(dtgSaidas.SelectedRows[0].Cells[0].Value);

                if (MessageBox.Show("Tem certeza que deseja remover a SAÍDA de ID: " + id + "?",
                    "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    new CrudSaida().removeSaida(Conexao.con, id);

                    MessageBox.Show("Dados salvos com sucesso!",
                    "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    atualizaDados();

                }


            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gbSaidas_Enter(object sender, EventArgs e)
        {

        }

        private void dtgSaidas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmLancamentos_Activated(object sender, EventArgs e)
        {


        }

        private void cmsEntradas_Opening(object sender, CancelEventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            carregaDados();
        }

        private void frmLancamentos_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void btnHome_Click(object sender, EventArgs e)
        {

        }

        private void frmLancamentos_FormClosed(object sender, FormClosedEventArgs e)
        {
        }

        private void frmLancamentos_Enter(object sender, EventArgs e)
        {
            frmHome frm = (frmHome)this.MdiParent;
            frm.esconder();
            frm.marcarBotoes(frm.btnLancamentos);
        }

        private void imprimirToolStripMenuItem_DropDownOpened(object sender, EventArgs e)
        {
            imprimirToolStripMenuItem.Image = ControleFinanceiroIgreja.Properties.Resources.printer_48_black;
        }

        private void imprimirToolStripMenuItem_DropDownClosed(object sender, EventArgs e)
        {
            imprimirToolStripMenuItem.Image = ControleFinanceiroIgreja.Properties.Resources.printer_48;
        }

        private void cbMes_DrawItem(object sender, DrawItemEventArgs e)
        {

            int index = e.Index >= 0 ? e.Index : 0;
            var brush = Brushes.White;
            e.DrawBackground();
            e.Graphics.DrawString(cbMes.Items[index].ToString(), e.Font, brush, e.Bounds, StringFormat.GenericDefault);
            e.DrawFocusRectangle();
        }

        private void cbAno_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (cbAno.Items.Count == 0)
                return;

            int index = e.Index >= 0 ? e.Index : 0;
            var brush = Brushes.White;
            e.DrawBackground();
            e.Graphics.DrawString(cbAno.Items[index].ToString(), e.Font, brush, e.Bounds, StringFormat.GenericDefault);
            e.DrawFocusRectangle();
        }

        private void livroCaixaToolStripMenuItem_Click(object sender, EventArgs e)
        {

            //se nao possui ano entao sai fora meu filho
            if (cbAno.SelectedIndex == -1)
            {
                MessageBox.Show("Nenhum lançamento foi encontrado no sistema!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            DataTable dt = new DataTable();

            dt.Columns.Add("Data", typeof(DateTime));
            dt.Columns.Add("Referência", typeof(string));
            dt.Columns.Add("Entrada", typeof(Decimal));
            dt.Columns.Add("Saída", typeof(Decimal));
            dt.Columns.Add("Saldo", typeof(Decimal));


            DataRow row = dt.NewRow();

            int ano = Convert.ToInt32(cbAno.Text);
            int mes = cbMes.SelectedIndex + 1;
            Decimal saldoAnterior = new CrudLancamento().saldoAnterior(Conexao.con, ano, mes);



            //row["Data"] = ;
            row["Referência"] = "Saldo Anterior";
            row["Entrada"] = 0;
            row["Saída"] = 0;
            row["Saldo"] = saldoAnterior;

            dt.Rows.Add(row);


            Decimal Saldo = saldoAnterior;

            //agora começa a série de loops
            for (int i = 0; i < DateTime.DaysInMonth(ano, mes) - 1; i++)
            {
                //linhas de entradas do dia i + 1
                DataTable dtDia = new CrudEntrada().livroCaixa(Conexao.con, ano, mes, i + 1);


                //desmembrar e popular um DataRow e add no DataTable principal

                foreach (DataRow r in dtDia.Rows)
                {
                    row = dt.NewRow();
                    row["Data"] = r["Data"];
                    row["Referência"] = r["Referência"];
                    row["Entrada"] = r["Entrada"];
                    row["Saída"] = r["Saída"];
                    Saldo = Saldo + Convert.ToDecimal(r["Entrada"]);
                    row["Saldo"] = Saldo;

                    dt.Rows.Add(row);

                }

                //linhas de saidas do dia i + 1
                dtDia = new CrudSaida().livroCaixa(Conexao.con, ano, mes, i + 1);


                //desmembrar e popular um DataRow e add no DataTable principal

                foreach (DataRow r in dtDia.Rows)
                {
                    row = dt.NewRow();
                    row["Data"] = r["Data"];
                    row["Referência"] = r["Referência"];
                    row["Entrada"] = r["Entrada"];
                    row["Saída"] = r["Saída"];
                    Saldo = Saldo - Convert.ToDecimal(r["Saída"]);
                    row["Saldo"] = Saldo;

                    dt.Rows.Add(row);

                }

            }

            //Enviar para impressao
            List<BindingSource> listBS = new List<BindingSource>();
            List<Object> listTotais = new List<Object>();
            BindingSource bs = new BindingSource();

            bs.DataSource = dt;

            listBS.Add(bs);

            bs = new BindingSource();


            listTotais.Add(listBS[0].Count);

            listTotais.Add(lblSaldoMes.Text);
            listTotais.Add(cbMes.Text);
            listTotais.Add(cbAno.Text);
            listTotais.Add(saldoAnterior);

            decimal saldoAtual = saldoAnterior + saldoMes;

            listTotais.Add(saldoAtual);

            frmVerRelatorio frm = new frmVerRelatorio(listBS, listTotais,
                ig, TiposRel.livroCaixa);

            frm.ShowDialog();


            //Criar uma tabela Dia/Referência/Entrada/Saída/Saldo
            //recuperar Entrada/Saida num loop de cada dia do mes até endOfMonth
            //agregando os valores na tabela
            //mandar imprimir




        }
    }//Class
}//NameSpace
