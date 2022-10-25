using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using System.IO;
using ControleFinanceiroIgreja.TAD;

namespace ControleFinanceiroIgreja.GUI
{
    public partial class frmVerRelatorio : Form
    {
        //parametros para emissao dos relatorios
        //lista de BindingSources
        //Lista de ReportParameters
        // Lista de Strings para totais e informações como essa
        List<BindingSource> listBS;
        List<Object> listTotais;
        List<ReportParameter> listParam;
        Igreja igr;
        int optRel;
        Membro mem;


        public frmVerRelatorio(List<BindingSource> listB,
                                List<Object> listTotais,
                                Igreja igr, int optRel, Membro mem = null)
        {
            InitializeComponent();

            this.listBS = listB;
            this.listTotais = listTotais;
            this.optRel = optRel;
            this.igr = igr;
            this.mem = mem;


        }

        private void frmVerRelatorio_Load(object sender, EventArgs e)
        {

            this.rvRelatorio.RefreshReport();

            //Comentar se for modo tablet... resolução muda tudo meu caro xD
            rvRelatorio.SetDisplayMode(DisplayMode.PrintLayout);

            this.rvRelatorio.ZoomMode = ZoomMode.PageWidth;

            tsZoom.SelectedIndex = 1;
            // rvRelatorio.

            switch (optRel)
            {

                case TiposRel.relMembros:
                    relListaMembros();
                    break;

                case TiposRel.relLancamentos:
                    relListaLancamentos();
                    break;
                case TiposRel.relGeral:
                    relLancGeral();
                    break;
                case TiposRel.livroCaixa:
                    livroCaixa();
                    break;
                case TiposRel.relSexos:
                    relSexos();
                    break;
                case TiposRel.relGeralChartAnual:
                    relGeralChartAnual();
                    break;
                case TiposRel.relAniversariantes:
                    relAniversariantes();
                    break;
                case TiposRel.niverDin:
                    niverDin();
                    break;
                case TiposRel.dizimistas:
                    relDizimistas();
                    break;
                case TiposRel.relBalancete:
                    relBalancete();
                    break;
                case TiposRel.relBalanceteChart:
                    relBalanceteChart();
                    break;
                case TiposRel.relGeralChart:
                    relGeralChart();
                    break;
                case TiposRel.relMembrosEntrada:
                    relMembrosEntrada();
                    break;
                case TiposRel.relEntradasMembro:
                    relEntradasMembro();
                    break;
                case TiposRel.relVisitantes:
                    relVisitantes();
                    break;
                case TiposRel.relCargos:
                    relCargos();
                    break;
                case TiposRel.relGeralAnual:
                    relLancAgrupAnual();
                    break;
                case TiposRel.relReuniao:
                    relReuniao();
                    break;
                case TiposRel.relProfessores:
                    relProfessores();
                    break;
                case TiposRel.relAlunos:
                    relAlunos();
                    break;
                case TiposRel.relReunioes:
                    relReunioes();
                    break;
                case TiposRel.chamadaReuniao:
                    chamadaReuniao();
                    break;
                case TiposRel.relReunioesChart:
                    relReunioesChart();
                    break;
                case TiposRel.relAlunosClasse:
                    relAlunosClasse();
                    break;
                case TiposRel.relClasses:
                    relClasses();
                    break;
                case TiposRel.relVisitas:
                    relVisitas();
                    break;
                case TiposRel.fichaNovoMembro:
                    fichaNovoMembro();
                    break;
                case TiposRel.ata:
                    imprimeAta();
                    break;
                case TiposRel.fichaNovoVisitante:
                    fichaNovoVisitante();
                    break;
                case TiposRel.fichaMembro:
                    fichaMembro();
                    break;
                case TiposRel.relQtdeMembros:
                    relQtdeMembros();
                    break;
                case TiposRel.carteira:
                    relCarteira();
                    break;

                default:
                    break;
            }

        }

        private void fichaNovoMembro()
        {
            rvRelatorio.Reset();
            rvRelatorio.ProcessingMode = ProcessingMode.Local;

            rvRelatorio.LocalReport.ReportEmbeddedResource =
                   "ControleFinanceiroIgreja.Report.RP_Ficha_Novo_Membro.rdlc";

            //ReportDataSource rds = new ReportDataSource("DS_Membros", listBS[0]);
            //rvRelatorio.LocalReport.DataSources.Add(rds);

            listParam = new List<ReportParameter>();
            //Loadend
            //listParam.Add(new ReportParameter
            // ("Lin", listTotais[0]));

            enviaDadosIgreja();
        }
        private void imprimeAta()
        {
            rvRelatorio.Reset();
            rvRelatorio.ProcessingMode = ProcessingMode.Local;

            rvRelatorio.LocalReport.ReportEmbeddedResource =
                   "ControleFinanceiroIgreja.Report.RP_Ata.rdlc";

            //ReportDataSource rds = new ReportDataSource("DS_Membros", listBS[0]);
            //rvRelatorio.LocalReport.DataSources.Add(rds);

            listParam = new List<ReportParameter>();
            //Loadend
            listParam.Add(new ReportParameter
             ("Lin", listTotais[0].ToString()));
            listParam.Add(new ReportParameter
             ("Titulo", listTotais[1].ToString()));
            listParam.Add(new ReportParameter
             ("Texto", listTotais[2].ToString()));
            listParam.Add(new ReportParameter
             ("FTit", listTotais[3].ToString()));



            enviaDadosIgreja();
        }

        private void fichaNovoVisitante()
        {
            rvRelatorio.Reset();
            rvRelatorio.ProcessingMode = ProcessingMode.Local;

            rvRelatorio.LocalReport.ReportEmbeddedResource =
                   "ControleFinanceiroIgreja.Report.RP_Ficha_Novo_Visitante.rdlc";

            ReportDataSource rds = new ReportDataSource("DS_Visitas", new BindingSource());
            rvRelatorio.LocalReport.DataSources.Add(rds);

            listParam = new List<ReportParameter>();
            //Loadend
            //listParam.Add(new ReportParameter
            // ("Lin", listTotais[0]));

            enviaDadosIgreja();
        }

        private void fichaMembro()
        {
            rvRelatorio.Reset();
            rvRelatorio.ProcessingMode = ProcessingMode.Local;

            rvRelatorio.LocalReport.ReportEmbeddedResource =
                   "ControleFinanceiroIgreja.Report.RP_Ficha_Membro.rdlc";

            ReportDataSource rds = new ReportDataSource("DS_Historico", listBS[0]);
            rvRelatorio.LocalReport.DataSources.Add(rds);

            listParam = new List<ReportParameter>();
            //Loadend
            listParam.Add(new ReportParameter
                         ("NOME", mem.nome));
            listParam.Add(new ReportParameter
                         ("DTNASC", mem.dtnasc.ToShortDateString()));
            listParam.Add(new ReportParameter
                         ("DTCAS", mem.dtCasamento.ToString()));

            listParam.Add(new ReportParameter
                         ("ID", mem.id.ToString()));
            if (mem.cpf.Trim().Length == 11)
            {
                listParam.Add(new ReportParameter
                         ("CPF", Convert.ToUInt64(mem.cpf).ToString(@"000\.000\.000\-00")));
            }
            else
                listParam.Add(new ReportParameter
                             ("CPF", mem.cpf));
            listParam.Add(new ReportParameter
                         ("RG", mem.rg));
            listParam.Add(new ReportParameter
                         ("SEXO", mem.sexo));
            listParam.Add(new ReportParameter
                         ("ENDERECOMEMBRO", mem.endereco));
            listParam.Add(new ReportParameter
                         ("BAIRROMEMBRO", mem.bairro));
            listParam.Add(new ReportParameter
                         ("CIDADEMEMBRO", mem.cidade));
            listParam.Add(new ReportParameter
                         ("CEPMEMBRO", mem.cep));
            listParam.Add(new ReportParameter
                         ("UFMEMBRO", mem.uf));
            listParam.Add(new ReportParameter
                         ("TEL1MEMBRO", mem.tel1));
            listParam.Add(new ReportParameter
                         ("TEL2MEMBRO", mem.tel2));
            listParam.Add(new ReportParameter
                         ("EMAILMEMBRO", mem.email));
            listParam.Add(new ReportParameter
                         ("MEMBRO", mem.dtmembro));
            listParam.Add(new ReportParameter
                         ("ADMISSAO", mem.admissao));
            listParam.Add(new ReportParameter
                         ("STATUS", mem.status));
            listParam.Add(new ReportParameter
                         ("PROFISSAO", mem.profissao));
            listParam.Add(new ReportParameter
                         ("LOCALNASCIMENTO", mem.localNascimento));
            listParam.Add(new ReportParameter
                         ("PROCEDENCIA", mem.procedencia));
            listParam.Add(new ReportParameter
                         ("NOMEPAI", mem.nomePai));
            listParam.Add(new ReportParameter
                         ("NOMEMAE", mem.nomeMae));
            listParam.Add(new ReportParameter
                         ("OBS", mem.obs));
            listParam.Add(new ReportParameter
                         ("ESTADOCIVIL", mem.estadoCivil.Trim()));
            listParam.Add(new ReportParameter
                         ("TITELEITOR", mem.titEleitor));
            if (mem.inativo)
            {
                listParam.Add(new ReportParameter
                         ("ATIVO", "MEMBRO INATIVO NO SISTEMA"));
            }
            else
            {
                listParam.Add(new ReportParameter
                         ("ATIVO", "MEMBRO ATIVO NO SISTEMA"));
            }


            enviaDadosIgreja();
        }

        private void relCarteira()
        {


            rvRelatorio.Reset();
            rvRelatorio.ProcessingMode = ProcessingMode.Local;


            rvRelatorio.LocalReport.ReportEmbeddedResource =
                   "ControleFinanceiroIgreja.Report.RP_Carteirinha.rdlc";

            //ReportDataSource rds = new ReportDataSource("DS_QtdeMembros", listBS[0]);
            //rvRelatorio.LocalReport.DataSources.Add(rds);

            listParam = new List<ReportParameter>();
            //Loadend
            listParam.Add(new ReportParameter
                         ("NOME", mem.nome));
            listParam.Add(new ReportParameter
                         ("DTNASC", mem.dtnasc.ToShortDateString()));
            listParam.Add(new ReportParameter
                         ("DTCAS", mem.dtCasamento.ToString()));
            if (mem.cpf.Trim().Length == 11)
            {
                listParam.Add(new ReportParameter
                         ("CPF", Convert.ToUInt64(mem.cpf).ToString(@"000\.000\.000\-00")));
            }
            else
                listParam.Add(new ReportParameter
                             ("CPF", mem.cpf));
            listParam.Add(new ReportParameter
                         ("RG", mem.rg));
            listParam.Add(new ReportParameter
                         ("SEXO", mem.sexo));
            listParam.Add(new ReportParameter
                         ("ENDERECOMEMBRO", mem.endereco));
            listParam.Add(new ReportParameter
                         ("BAIRROMEMBRO", mem.bairro));
            listParam.Add(new ReportParameter
                         ("CIDADEMEMBRO", mem.cidade));
            listParam.Add(new ReportParameter
                         ("CEPMEMBRO", mem.cep));
            listParam.Add(new ReportParameter
                         ("UFMEMBRO", mem.uf));
            listParam.Add(new ReportParameter
                         ("TEL1MEMBRO", mem.tel1));
            listParam.Add(new ReportParameter
                         ("TEL2MEMBRO", mem.tel2));
            listParam.Add(new ReportParameter
                         ("EMAILMEMBRO", mem.email));
            listParam.Add(new ReportParameter
                         ("MEMBRO", mem.dtmembro));
            listParam.Add(new ReportParameter
                         ("ADMISSAO", mem.admissao));
            listParam.Add(new ReportParameter
                         ("STATUS", mem.status));
            listParam.Add(new ReportParameter
                         ("ID", mem.id.ToString()));


            enviaDadosIgreja();
        }

        private void relQtdeMembros()
        {
            rvRelatorio.Reset();
            rvRelatorio.ProcessingMode = ProcessingMode.Local;

            rvRelatorio.LocalReport.ReportEmbeddedResource =
                   "ControleFinanceiroIgreja.Report.RP_Qtde_Membros.rdlc";

            ReportDataSource rds = new ReportDataSource("DS_QtdeMembros", listBS[0]);
            rvRelatorio.LocalReport.DataSources.Add(rds);

            listParam = new List<ReportParameter>();
            //Loadend
            listParam.Add(new ReportParameter
                         ("Total", listTotais[0].ToString()));
            listParam.Add(new ReportParameter
                         ("Membros", listTotais[1].ToString()));
            listParam.Add(new ReportParameter
                         ("Casados", listTotais[2].ToString()));
            listParam.Add(new ReportParameter
                         ("Inativos", listTotais[3].ToString()));
            listParam.Add(new ReportParameter
                         ("Solteiros", listTotais[4].ToString()));
            listParam.Add(new ReportParameter
                         ("Divorciados", listTotais[5].ToString()));
            listParam.Add(new ReportParameter
                         ("Viuvos", listTotais[6].ToString()));
            listParam.Add(new ReportParameter
                         ("Outros", listTotais[7].ToString()));



            enviaDadosIgreja();
        }
        private void relListaMembros()
        {
            rvRelatorio.Reset();
            rvRelatorio.ProcessingMode = ProcessingMode.Local;

            rvRelatorio.LocalReport.ReportEmbeddedResource =
                   "ControleFinanceiroIgreja.Report.RP_Membros.rdlc";

            ReportDataSource rds = new ReportDataSource("DS_Membros", listBS[0]);
            rvRelatorio.LocalReport.DataSources.Add(rds);

            listParam = new List<ReportParameter>();
            //Loadend
            listParam.Add(new ReportParameter
                ("Lin", listTotais[0].ToString()));

            enviaDadosIgreja();

        }

        private void relVisitantes()
        {
            rvRelatorio.Reset();
            rvRelatorio.ProcessingMode = ProcessingMode.Local;

            rvRelatorio.LocalReport.ReportEmbeddedResource =
                   "ControleFinanceiroIgreja.Report.RP_Visitantes.rdlc";

            ReportDataSource rds = new ReportDataSource("DS_Visitantes", listBS[0]);
            rvRelatorio.LocalReport.DataSources.Add(rds);

            listParam = new List<ReportParameter>();
            //Loadend
            listParam.Add(new ReportParameter
                ("Lin", listTotais[0].ToString()));

            enviaDadosIgreja();

        }

        private void relCargos()
        {
            rvRelatorio.Reset();
            rvRelatorio.ProcessingMode = ProcessingMode.Local;

            rvRelatorio.LocalReport.ReportEmbeddedResource =
                   "ControleFinanceiroIgreja.Report.RP_Cargos.rdlc";

            ReportDataSource rds = new ReportDataSource("DS_Cargos", listBS[0]);
            rvRelatorio.LocalReport.DataSources.Add(rds);

            listParam = new List<ReportParameter>();
            //Loadend
            listParam.Add(new ReportParameter
                ("Lin", listTotais[0].ToString()));

            listParam.Add(new ReportParameter("Val", listTotais[1].ToString()));

            enviaDadosIgreja();

        }


        private void relReuniao()
        {
            rvRelatorio.Reset();
            rvRelatorio.ProcessingMode = ProcessingMode.Local;

            if (listTotais[2] != null)
            {
                rvRelatorio.LocalReport.ReportEmbeddedResource =
                      "ControleFinanceiroIgreja.Report.RP_Reuniao_Null.rdlc";
            }
            else
            {
                rvRelatorio.LocalReport.ReportEmbeddedResource =
                       "ControleFinanceiroIgreja.Report.RP_Reuniao.rdlc";


            }
            ReportDataSource rds = new ReportDataSource("DS_Reuniao", listBS[0]);
            rvRelatorio.LocalReport.DataSources.Add(rds);
            listParam = new List<ReportParameter>();
            //Loadend
            listParam.Add(new ReportParameter
                ("Lin", listTotais[0].ToString()));

            listParam.Add(new ReportParameter("Val", listTotais[1].ToString()));

            enviaDadosIgreja();

        }

        private void relProfessores()
        {
            rvRelatorio.Reset();
            rvRelatorio.ProcessingMode = ProcessingMode.Local;


            rvRelatorio.LocalReport.ReportEmbeddedResource =
                  "ControleFinanceiroIgreja.Report.RP_Professores.rdlc";


            ReportDataSource rds = new ReportDataSource("DS_Reuniao", listBS[0]);
            rvRelatorio.LocalReport.DataSources.Add(rds);
            listParam = new List<ReportParameter>();
            //Loadend
            listParam.Add(new ReportParameter
                ("Lin", listTotais[0].ToString()));

            listParam.Add(new ReportParameter("Val", listTotais[1].ToString()));

            enviaDadosIgreja();

        }

        private void relAlunos()
        {
            rvRelatorio.Reset();
            rvRelatorio.ProcessingMode = ProcessingMode.Local;


            rvRelatorio.LocalReport.ReportEmbeddedResource =
                  "ControleFinanceiroIgreja.Report.RP_Alunos.rdlc";


            ReportDataSource rds = new ReportDataSource("DS_Reuniao", listBS[0]);
            rvRelatorio.LocalReport.DataSources.Add(rds);
            listParam = new List<ReportParameter>();
            //Loadend
            listParam.Add(new ReportParameter
                ("Lin", listTotais[0].ToString()));

            listParam.Add(new ReportParameter("Val", listTotais[1].ToString()));

            enviaDadosIgreja();

        }

        private void relReunioes()
        {
            rvRelatorio.Reset();
            rvRelatorio.ProcessingMode = ProcessingMode.Local;


            rvRelatorio.LocalReport.ReportEmbeddedResource =
                  "ControleFinanceiroIgreja.Report.RP_Reunioes.rdlc";


            ReportDataSource rds = new ReportDataSource("DS_Reunioes", listBS[0]);
            rvRelatorio.LocalReport.DataSources.Add(rds);
            listParam = new List<ReportParameter>();
            //Loadend
            listParam.Add(new ReportParameter
                ("Lin", listTotais[0].ToString()));

            listParam.Add(new ReportParameter("Val", listTotais[1].ToString()));

            enviaDadosIgreja();

        }

        private void chamadaReuniao()
        {
            rvRelatorio.Reset();
            rvRelatorio.ProcessingMode = ProcessingMode.Local;


            rvRelatorio.LocalReport.ReportEmbeddedResource =
                  "ControleFinanceiroIgreja.Report.RP_ChamadaReuniao.rdlc";


            ReportDataSource rds = new ReportDataSource("DS_ChamadaReuniao", listBS[0]);
            rvRelatorio.LocalReport.DataSources.Add(rds);
            listParam = new List<ReportParameter>();
            //Loadend
            listParam.Add(new ReportParameter
                ("Lin", listTotais[0].ToString()));

            listParam.Add(new ReportParameter("Val", listTotais[1].ToString()));
            listParam.Add(new ReportParameter("Data", listTotais[2].ToString()));
            listParam.Add(new ReportParameter("Biblias", listTotais[3].ToString()));
            listParam.Add(new ReportParameter("Revistas", listTotais[4].ToString()));
            listParam.Add(new ReportParameter("Visitantes", listTotais[5].ToString()));
            listParam.Add(new ReportParameter("Oferta", listTotais[6].ToString()));
            listParam.Add(new ReportParameter("Obs", listTotais[7].ToString()));

            enviaDadosIgreja();

        }

        private void relReunioesChart()
        {
            rvRelatorio.Reset();
            rvRelatorio.ProcessingMode = ProcessingMode.Local;


            rvRelatorio.LocalReport.ReportEmbeddedResource =
                  "ControleFinanceiroIgreja.Report.RP_Reunioes_Chart.rdlc";


            ReportDataSource rds = new ReportDataSource("DS_Reunioes", listBS[0]);
            rvRelatorio.LocalReport.DataSources.Add(rds);
            listParam = new List<ReportParameter>();
            //Loadend
            listParam.Add(new ReportParameter
                ("Lin", listTotais[0].ToString()));

            listParam.Add(new ReportParameter("Val", listTotais[1].ToString()));

            enviaDadosIgreja();

        }

        private void relAlunosClasse()
        {
            rvRelatorio.Reset();
            rvRelatorio.ProcessingMode = ProcessingMode.Local;


            rvRelatorio.LocalReport.ReportEmbeddedResource =
                  "ControleFinanceiroIgreja.Report.RP_AlunosClasse.rdlc";


            ReportDataSource rds = new ReportDataSource("DS_AlunosClasse", listBS[0]);
            rvRelatorio.LocalReport.DataSources.Add(rds);
            listParam = new List<ReportParameter>();
            //Loadend
            listParam.Add(new ReportParameter
                ("Lin", listTotais[0].ToString()));

            listParam.Add(new ReportParameter("Classe", listTotais[1].ToString()));

            listParam.Add(new ReportParameter("Ano", listTotais[2].ToString()));

            enviaDadosIgreja();

        }

        private void relClasses()
        {
            rvRelatorio.Reset();
            rvRelatorio.ProcessingMode = ProcessingMode.Local;


            rvRelatorio.LocalReport.ReportEmbeddedResource =
                  "ControleFinanceiroIgreja.Report.RP_Classes.rdlc";


            ReportDataSource rds = new ReportDataSource("DS_Classes", listBS[0]);
            rvRelatorio.LocalReport.DataSources.Add(rds);
            listParam = new List<ReportParameter>();
            //Loadend
            listParam.Add(new ReportParameter
                ("Lin", listTotais[0].ToString()));


            enviaDadosIgreja();

        }

        private void relVisitas()
        {
            rvRelatorio.Reset();
            rvRelatorio.ProcessingMode = ProcessingMode.Local;

            rvRelatorio.LocalReport.ReportEmbeddedResource =
                   "ControleFinanceiroIgreja.Report.RP_Visitas.rdlc";

            ReportDataSource rds = new ReportDataSource("DS_Visitas", listBS[0]);
            rvRelatorio.LocalReport.DataSources.Add(rds);

            listParam = new List<ReportParameter>();
            //Loadend
            listParam.Add(new ReportParameter
                ("Lin", listTotais[0].ToString()));

            Visitantes vi = (Visitantes)listTotais[1];

            listParam.Add(new ReportParameter
                         ("NOME", vi.nome));
            listParam.Add(new ReportParameter
                         ("DTNASC", vi.dtnasc.ToShortDateString()));
            listParam.Add(new ReportParameter
                         ("DTCAS", vi.dtCasamento.ToString()));

            listParam.Add(new ReportParameter
                         ("SEXO", vi.sexo));
            listParam.Add(new ReportParameter
                         ("ENDERECOMEMBRO", vi.endereco));
            listParam.Add(new ReportParameter
                         ("BAIRROMEMBRO", vi.bairro));
            listParam.Add(new ReportParameter
                         ("CIDADEMEMBRO", vi.cidade));
            listParam.Add(new ReportParameter
                         ("CEPMEMBRO", vi.cep));
            listParam.Add(new ReportParameter
                         ("UFMEMBRO", vi.uf));
            listParam.Add(new ReportParameter
                         ("TEL1MEMBRO", vi.tel1));
            listParam.Add(new ReportParameter
                         ("TEL2MEMBRO", vi.tel2));
            listParam.Add(new ReportParameter
                         ("EMAILMEMBRO", vi.email));
            listParam.Add(new ReportParameter
                         ("OBS", vi.obs));
            listParam.Add(new ReportParameter
                         ("ESTADOCIVIL", vi.estadoCivil.Trim()));

            listParam.Add(new ReportParameter
                        ("PROFISSAO", vi.profissao));
            listParam.Add(new ReportParameter
                        ("LOCALNASCIMENTO", vi.localNascimento));

            enviaDadosIgreja();

        }

        private void relSexos()
        {
            rvRelatorio.Reset();
            rvRelatorio.ProcessingMode = ProcessingMode.Local;

            rvRelatorio.LocalReport.ReportEmbeddedResource =
                   "ControleFinanceiroIgreja.Report.RP_Sexo.rdlc";

            ReportDataSource rds = new ReportDataSource("DS_Sexos", listBS[0]);
            rvRelatorio.LocalReport.DataSources.Add(rds);

            listParam = new List<ReportParameter>();
            //Loadend
            listParam.Add(new ReportParameter
                ("Lin", listTotais[0].ToString()));

            enviaDadosIgreja();

        }

        private void relDizimistas()
        {
            rvRelatorio.Reset();
            rvRelatorio.ProcessingMode = ProcessingMode.Local;

            rvRelatorio.LocalReport.ReportEmbeddedResource =
                   "ControleFinanceiroIgreja.Report.RP_Dizimistas.rdlc";

            ReportDataSource rds = new ReportDataSource("DS_Dizimistas", listBS[0]);
            rvRelatorio.LocalReport.DataSources.Add(rds);

            listParam = new List<ReportParameter>();
            //Loadend
            listParam.Add(new ReportParameter
                ("Lin", listTotais[0].ToString()));
            listParam.Add(new ReportParameter
                ("Ano", listTotais[1].ToString()));
            listParam.Add(new ReportParameter
                ("Categoria", listTotais[2].ToString()));
            listParam.Add(new ReportParameter
                ("Mes", listTotais[3].ToString()));


            enviaDadosIgreja();

        }

        private void niverDin()
        {
            rvRelatorio.Reset();
            rvRelatorio.ProcessingMode = ProcessingMode.Local;

            rvRelatorio.LocalReport.ReportEmbeddedResource =
                   "ControleFinanceiroIgreja.Report.RP_NiverDin.rdlc";

            ReportDataSource rds = new ReportDataSource("DS_NiverDin", listBS[0]);
            rvRelatorio.LocalReport.DataSources.Add(rds);

            rds = new ReportDataSource("DS_NiverDinVis", listBS[1]);
            rvRelatorio.LocalReport.DataSources.Add(rds);

            listParam = new List<ReportParameter>();
            //Loadend
            listParam.Add(new ReportParameter
                ("Lin", listTotais[0].ToString()));
            listParam.Add(new ReportParameter
                ("Mes", listTotais[1].ToString()));


            enviaDadosIgreja();

        }

        private void relAniversariantes()
        {
            rvRelatorio.Reset();
            rvRelatorio.ProcessingMode = ProcessingMode.Local;

            rvRelatorio.LocalReport.ReportEmbeddedResource =
                   "ControleFinanceiroIgreja.Report.RP_Aniversariantes.rdlc";

            ReportDataSource rds = new ReportDataSource("DS_Aniversariantes", listBS[0]);
            rvRelatorio.LocalReport.DataSources.Add(rds);

            listParam = new List<ReportParameter>();
            //Loadend
            listParam.Add(new ReportParameter
                ("Lin", listTotais[0].ToString()));
            listParam.Add(new ReportParameter
                ("Mes", listTotais[1].ToString()));


            enviaDadosIgreja();

        }

        private void relListaLancamentos()
        {
            rvRelatorio.Reset();
            rvRelatorio.ProcessingMode = ProcessingMode.Local;

            rvRelatorio.LocalReport.ReportEmbeddedResource =
                   "ControleFinanceiroIgreja.Report.RP_Lancamentos.rdlc";

            ReportDataSource rdsEntrada = new ReportDataSource
                                    ("DS_Entradas", listBS[0]);

            rvRelatorio.LocalReport.DataSources.Add(rdsEntrada);

            ReportDataSource rdsSaida = new ReportDataSource
                                    ("DS_Saidas", listBS[1]);

            rvRelatorio.LocalReport.DataSources.Add(rdsSaida);

            listParam = new List<ReportParameter>();
            //Loadend
            listParam.Add(new ReportParameter
                ("Lin", listTotais[0].ToString()));
            listParam.Add(new ReportParameter
                ("TotalEntradas", listTotais[1].ToString()));
            listParam.Add(new ReportParameter
                ("TotalSaidas", listTotais[2].ToString()));
            listParam.Add(new ReportParameter
                ("SaldoMes", listTotais[3].ToString()));
            listParam.Add(new ReportParameter
                ("Mes", listTotais[4].ToString()));
            listParam.Add(new ReportParameter
                ("Ano", listTotais[5].ToString()));
            listParam.Add(new ReportParameter
                ("SaldoAnterior", listTotais[6].ToString()));
            listParam.Add(new ReportParameter
                 ("SaldoAtual", listTotais[7].ToString()));

            enviaDadosIgreja();

        }

        private void relLancGeral()
        {
            rvRelatorio.Reset();
            rvRelatorio.ProcessingMode = ProcessingMode.Local;

            rvRelatorio.LocalReport.ReportEmbeddedResource =
                   "ControleFinanceiroIgreja.Report.RP_LancGeral.rdlc";

            ReportDataSource rdsEntrada = new ReportDataSource
                                    ("DSEntradasGeral", listBS[0]);

            rvRelatorio.LocalReport.DataSources.Add(rdsEntrada);

            ReportDataSource rdsSaida = new ReportDataSource
                                    ("DSSaidasGeral", listBS[1]);

            rvRelatorio.LocalReport.DataSources.Add(rdsSaida);

            listParam = new List<ReportParameter>();
            //Loadend
            listParam.Add(new ReportParameter
                ("Lin", listTotais[0].ToString()));
            listParam.Add(new ReportParameter
                ("TotalEntradas", listTotais[1].ToString()));
            listParam.Add(new ReportParameter
                ("TotalSaidas", listTotais[2].ToString()));
            listParam.Add(new ReportParameter
                ("SaldoMes", listTotais[3].ToString()));
            listParam.Add(new ReportParameter
                ("Mes", listTotais[4].ToString()));
            listParam.Add(new ReportParameter
                ("Ano", listTotais[5].ToString()));
            listParam.Add(new ReportParameter
                ("SaldoAnterior", listTotais[6].ToString()));
            listParam.Add(new ReportParameter
                 ("SaldoAtual", listTotais[7].ToString()));

            enviaDadosIgreja();

        }
        private void livroCaixa()
        {
            rvRelatorio.Reset();
            rvRelatorio.ProcessingMode = ProcessingMode.Local;

            rvRelatorio.LocalReport.ReportEmbeddedResource =
                   "ControleFinanceiroIgreja.Report.RP_LivroCaixa.rdlc";

            ReportDataSource rdsLivro = new ReportDataSource
                                    ("DSLivroCaixa", listBS[0]);

            rvRelatorio.LocalReport.DataSources.Add(rdsLivro);



            listParam = new List<ReportParameter>();
            //Loadend
            listParam.Add(new ReportParameter
                ("Lin", listTotais[0].ToString()));
            listParam.Add(new ReportParameter
                ("SaldoMes", listTotais[1].ToString()));
            listParam.Add(new ReportParameter
                ("Mes", listTotais[2].ToString()));
            listParam.Add(new ReportParameter
                ("Ano", listTotais[3].ToString()));
            listParam.Add(new ReportParameter
               ("SaldoAnterior", listTotais[4].ToString()));
            listParam.Add(new ReportParameter
               ("SaldoAtual", listTotais[5].ToString()));

            enviaDadosIgreja();

        }

        private void relLancAgrupAnual()
        {
            rvRelatorio.Reset();
            rvRelatorio.ProcessingMode = ProcessingMode.Local;

            rvRelatorio.LocalReport.ReportEmbeddedResource =
                   "ControleFinanceiroIgreja.Report.RP_LancGeralAnual.rdlc";

            ReportDataSource rdsEntrada = new ReportDataSource
                                    ("DSEntradasGeral", listBS[0]);

            rvRelatorio.LocalReport.DataSources.Add(rdsEntrada);

            ReportDataSource rdsSaida = new ReportDataSource
                                    ("DSSaidasGeral", listBS[1]);

            rvRelatorio.LocalReport.DataSources.Add(rdsSaida);

            listParam = new List<ReportParameter>();
            //Loadend
            listParam.Add(new ReportParameter
                ("Lin", listTotais[0].ToString()));

            listParam.Add(new ReportParameter
              ("Mes", listTotais[1].ToString()));

            listParam.Add(new ReportParameter
              ("Ano", listTotais[2].ToString()));

            listParam.Add(new ReportParameter
             ("TotalEntradas", listTotais[3].ToString()));

            listParam.Add(new ReportParameter
             ("TotalSaidas", listTotais[4].ToString()));

            listParam.Add(new ReportParameter
             ("SaldoAnterior", listTotais[5].ToString()));

            //listParam.Add(new ReportParameter
            // ("TotalEntradas", listTotais[3].ToString()));


            enviaDadosIgreja();

        }

        private void relGeralChart()
        {
            rvRelatorio.Reset();
            rvRelatorio.ProcessingMode = ProcessingMode.Local;

            rvRelatorio.LocalReport.ReportEmbeddedResource =
                   "ControleFinanceiroIgreja.Report.RP_GeralChart.rdlc";


            ReportDataSource rdsEntrada = new ReportDataSource
                                    ("DSEntradasGeral", listBS[0]);

            rvRelatorio.LocalReport.DataSources.Add(rdsEntrada);

            ReportDataSource rdsSaida = new ReportDataSource
                                    ("DSSaidasGeral", listBS[1]);

            rvRelatorio.LocalReport.DataSources.Add(rdsSaida);

            listParam = new List<ReportParameter>();
            //Loadend
            listParam.Add(new ReportParameter
                ("Lin", listTotais[0].ToString()));

            listParam.Add(new ReportParameter
                ("Mes", listTotais[1].ToString()));
            listParam.Add(new ReportParameter
                ("Ano", listTotais[2].ToString()));

            enviaDadosIgreja();

        }

        private void relGeralChartAnual()
        {
            rvRelatorio.Reset();
            rvRelatorio.ProcessingMode = ProcessingMode.Local;

            rvRelatorio.LocalReport.ReportEmbeddedResource =
                   "ControleFinanceiroIgreja.Report.RP_GeralChartAnual.rdlc";


            ReportDataSource rdsEntrada = new ReportDataSource
                                    ("DSEntradasGeral", listBS[0]);

            rvRelatorio.LocalReport.DataSources.Add(rdsEntrada);

            ReportDataSource rdsSaida = new ReportDataSource
                                    ("DSSaidasGeral", listBS[1]);

            rvRelatorio.LocalReport.DataSources.Add(rdsSaida);

            listParam = new List<ReportParameter>();
            //Loadend
            listParam.Add(new ReportParameter
                ("Lin", listTotais[0].ToString()));

            listParam.Add(new ReportParameter
                ("Mes", listTotais[1].ToString()));
            listParam.Add(new ReportParameter
                ("Ano", listTotais[2].ToString()));

            enviaDadosIgreja();

        }

        private void relBalancete()
        {
            rvRelatorio.Reset();
            rvRelatorio.ProcessingMode = ProcessingMode.Local;

            rvRelatorio.LocalReport.ReportEmbeddedResource =
                   "ControleFinanceiroIgreja.Report.RP_Balancete.rdlc";


            ReportDataSource rds = new ReportDataSource
                                    ("DS_Balancete", listBS[0]);

            rvRelatorio.LocalReport.DataSources.Add(rds);


            listParam = new List<ReportParameter>();
            //Loadend
            listParam.Add(new ReportParameter
                ("Lin", listTotais[0].ToString()));
            listParam.Add(new ReportParameter
                ("TotalEntradas", listTotais[1].ToString()));
            listParam.Add(new ReportParameter
                ("TotalSaidas", listTotais[2].ToString()));
            listParam.Add(new ReportParameter
                ("SaldoAno", listTotais[3].ToString()));

            listParam.Add(new ReportParameter
                ("Ano", listTotais[4].ToString()));
            listParam.Add(new ReportParameter
                ("SaldoAnterior", listTotais[5].ToString()));
            listParam.Add(new ReportParameter
                 ("SaldoAtual", listTotais[6].ToString()));

            enviaDadosIgreja();

        }

        private void relBalanceteChart()
        {
            rvRelatorio.Reset();
            rvRelatorio.ProcessingMode = ProcessingMode.Local;

            rvRelatorio.LocalReport.ReportEmbeddedResource =
                   "ControleFinanceiroIgreja.Report.RP_BalanceteChart.rdlc";


            ReportDataSource rds = new ReportDataSource
                                    ("DS_Balancete", listBS[0]);

            rvRelatorio.LocalReport.DataSources.Add(rds);


            listParam = new List<ReportParameter>();
            //Loadend
            listParam.Add(new ReportParameter
                ("Lin", listTotais[0].ToString()));

            listParam.Add(new ReportParameter
                ("Ano", listTotais[1].ToString()));


            enviaDadosIgreja();

        }

        private void relMembrosEntrada()
        {
            rvRelatorio.Reset();
            rvRelatorio.ProcessingMode = ProcessingMode.Local;

            rvRelatorio.LocalReport.ReportEmbeddedResource =
                   "ControleFinanceiroIgreja.Report.RP_MembrosEntrada.rdlc";

            ReportDataSource rds = new ReportDataSource
                                    ("DS_MembrosEntrada", listBS[0]);

            rvRelatorio.LocalReport.DataSources.Add(rds);


            listParam = new List<ReportParameter>();
            //Loadend
            listParam.Add(new ReportParameter
                ("Lin", listTotais[0].ToString()));
            //ano
            listParam.Add(new ReportParameter
                ("Ano", listTotais[1].ToString()));
            //cat
            listParam.Add(new ReportParameter
                ("Categoria", listTotais[2].ToString()));


            enviaDadosIgreja();

        }

        private void relEntradasMembro()
        {
            rvRelatorio.Reset();
            rvRelatorio.ProcessingMode = ProcessingMode.Local;

            rvRelatorio.LocalReport.ReportEmbeddedResource =
                   "ControleFinanceiroIgreja.Report.RP_EntradasMembro.rdlc";

            ReportDataSource rds = new ReportDataSource
                                    ("DS_EntradasMembro", listBS[0]);

            rvRelatorio.LocalReport.DataSources.Add(rds);


            listParam = new List<ReportParameter>();
            //Loadend
            listParam.Add(new ReportParameter
                ("Lin", listTotais[0].ToString()));
            //ano
            listParam.Add(new ReportParameter
                ("Ano", listTotais[1].ToString()));
            //cat
            listParam.Add(new ReportParameter
                ("Membro", listTotais[2].ToString()));


            enviaDadosIgreja();

        }

        private void enviaDadosIgreja()
        {

            try
            {
                rvRelatorio.LocalReport.EnableExternalImages = true;
                string image = Directory.GetParent(Application.ExecutablePath) + @"\Img\imgLogo.jpg";

                rvRelatorio.LocalReport.EnableExternalImages = true;
                string imagePath = new Uri(image).AbsoluteUri;
                ReportParameter parameter = new ReportParameter("imgLogo", imagePath);
                rvRelatorio.LocalReport.SetParameters(parameter);
                rvRelatorio.LocalReport.Refresh();

                listParam.Add(new ReportParameter
                    ("DataGerado", DateTime.Now.ToShortDateString()));
                listParam.Add(new ReportParameter("NomeIgreja", igr.nome));
                listParam.Add(new ReportParameter("Endereco", igr.endereco));
                listParam.Add(new ReportParameter("Cidade", igr.cidade));
                listParam.Add(new ReportParameter("UF", igr.uf));
                listParam.Add(new ReportParameter("Email", igr.email));
                listParam.Add(new ReportParameter("Bairro", igr.bairro));

                if (igr.cnpj.Trim().Length == 14)
                {
                    listParam.Add(new ReportParameter("CNPJ", Convert.ToUInt64(igr.cnpj).ToString(@"00\.000\.000\/0000\-00")));
                }
                else
                    listParam.Add(new ReportParameter("CNPJ", igr.cnpj));

                listParam.Add(new ReportParameter("CEP", String.Format("{0:#####-###}", Convert.ToInt64(igr.cep))));
                listParam.Add(new ReportParameter("Tel1", igr.tel1));
                listParam.Add(new ReportParameter("Tel2", igr.tel2));
                listParam.Add(new ReportParameter("Tit1", igr.tit1));
                listParam.Add(new ReportParameter("Tit2", igr.tit2));
                listParam.Add(new ReportParameter("Assinatura1", igr.assinatura1));
                listParam.Add(new ReportParameter("Assinatura2", igr.assinatura2));

                rvRelatorio.LocalReport.SetParameters(listParam);
                rvRelatorio.LocalReport.Refresh();
                rvRelatorio.RefreshReport();

            }
            catch (Exception e)
            {
                MessageBox.Show("Preencha os dados da Igreja corretamente antes de gerar relatórios\n " + e.Message,
                    "Atenção",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);

                frmDadosIgreja frm = new frmDadosIgreja(this.igr);


                this.Close();


                frm.ShowDialog();



            }




        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            rvRelatorio.PrintDialog();
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            rvRelatorio.SetDisplayMode(DisplayMode.PrintLayout);
        }

        private void btnPDF_Click(object sender, EventArgs e)
        {

        }

        private void btnFuncao_Click(object sender, EventArgs e)
        {


        }

        private void btnObs_Click(object sender, EventArgs e)
        {

        }

        private void rvRelatorio_Load(object sender, EventArgs e)
        {

        }

        private void tsConfig_Click(object sender, EventArgs e)
        {
            rvRelatorio.PageSetupDialog();
        }

        private void tsImpView_Click(object sender, EventArgs e)
        {

            if (rvRelatorio.DisplayMode == DisplayMode.Normal)
            {

                rvRelatorio.SetDisplayMode(DisplayMode.PrintLayout);
                rvRelatorio.ZoomMode = ZoomMode.PageWidth;
                tsZoom.SelectedIndex = 1;

            }
            else
            {
                rvRelatorio.SetDisplayMode(DisplayMode.Normal);
                rvRelatorio.ZoomMode = ZoomMode.PageWidth;
                tsZoom.SelectedIndex = 1;
            }


        }

        private void tsZoom_Click(object sender, EventArgs e)
        {

        }

        private void tsZoom_SelectedIndexChanged(object sender, EventArgs e)
        {

            /*
             pagina inteira
             largura da pagina
             500
             200
             150
             100
             75
             50
             25
             
             */

            switch (tsZoom.SelectedIndex)
            {

                case 0:
                    rvRelatorio.ZoomMode = ZoomMode.FullPage;
                    break;
                case 1:
                    rvRelatorio.ZoomMode = ZoomMode.PageWidth;
                    break;
                case 2:
                    rvRelatorio.ZoomMode = ZoomMode.Percent;
                    rvRelatorio.ZoomPercent = 500;
                    break;
                case 3:
                    rvRelatorio.ZoomMode = ZoomMode.Percent;
                    rvRelatorio.ZoomPercent = 200;
                    break;
                case 4:
                    rvRelatorio.ZoomMode = ZoomMode.Percent;
                    rvRelatorio.ZoomPercent = 150;
                    break;
                case 5:
                    rvRelatorio.ZoomMode = ZoomMode.Percent;
                    rvRelatorio.ZoomPercent = 100;
                    break;
                case 6:
                    rvRelatorio.ZoomMode = ZoomMode.Percent;
                    rvRelatorio.ZoomPercent = 75;
                    break;
                case 7:
                    rvRelatorio.ZoomMode = ZoomMode.Percent;
                    rvRelatorio.ZoomPercent = 50;
                    break;
                case 8:
                    rvRelatorio.ZoomMode = ZoomMode.Percent;
                    rvRelatorio.ZoomPercent = 25;
                    break;

                default:
                    break;
            }


        }

        private void tsImp_Click(object sender, EventArgs e)
        {

            rvRelatorio.ExportDialog(rvRelatorio.LocalReport.ListRenderingExtensions()[3]);
        }

        private void rvRelatorio_PageNavigation(object sender, PageNavigationEventArgs e)
        {



        }

        private void tsPrim_Click(object sender, EventArgs e)
        {
            rvRelatorio.CurrentPage = 1;
            tsTxtPag.Text = "1";
        }

        private void tsUlt_Click(object sender, EventArgs e)
        {

            rvRelatorio.CurrentPage = rvRelatorio.GetTotalPages();

            tsTxtPag.Text = rvRelatorio.GetTotalPages().ToString();

        }

        private void tsAnt_Click(object sender, EventArgs e)
        {
            if (rvRelatorio.CurrentPage > 1)
            {
                rvRelatorio.CurrentPage--;
                tsTxtPag.Text = rvRelatorio.CurrentPage.ToString();
            }
        }

        private void tsProx_Click(object sender, EventArgs e)
        {

            if (rvRelatorio.CurrentPage < rvRelatorio.GetTotalPages())
            {
                rvRelatorio.CurrentPage++;
                tsTxtPag.Text = rvRelatorio.CurrentPage.ToString();
            }
        }

        private void rvRelatorio_DocumentMapNavigation(object sender, DocumentMapNavigationEventArgs e)
        {

        }

        private void rvRelatorio_StatusChanged(object sender, EventArgs e)
        {







        }

        private void tsTxtPag_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

            if (e.KeyChar == (char)Keys.Enter)
            {

                //seta a pagina se existir

                int pag = Convert.ToInt32(tsTxtPag.Text);

                if (pag <= rvRelatorio.GetTotalPages() && pag > 0)
                {

                    rvRelatorio.CurrentPage = pag;

                }
                else
                {
                    tsTxtPag.Text = rvRelatorio.CurrentPage.ToString();
                    rvRelatorio.Focus();
                }

            }

        }

        private void tsTxtPag_Click(object sender, EventArgs e)
        {

        }

        private void tsTxtPag_Enter(object sender, EventArgs e)
        {
            tsTxtPag.SelectAll();
        }

        private void rvRelatorio_ZoomChange(object sender, ZoomChangeEventArgs e)
        {

            switch (rvRelatorio.ZoomMode)
            {
                case ZoomMode.FullPage:
                    tsZoom.SelectedIndex = 0;
                    break;
                case ZoomMode.PageWidth:
                    tsZoom.SelectedIndex = 1;
                    break;
                case ZoomMode.Percent:
                    switch (rvRelatorio.ZoomPercent)
                    {
                        case 500:
                            tsZoom.SelectedIndex = 2;
                            break;
                        case 200:
                            tsZoom.SelectedIndex = 3;
                            break;
                        case 150:
                            tsZoom.SelectedIndex = 4;
                            break;
                        case 100:
                            tsZoom.SelectedIndex = 5;
                            break;
                        case 75:
                            tsZoom.SelectedIndex = 6;
                            break;
                        case 50:
                            tsZoom.SelectedIndex = 7;
                            break;
                        case 25:
                            tsZoom.SelectedIndex = 8;
                            break;

                        default:
                            break;
                    }
                    break;
                default:
                    break;
            }


        }

        private void rvRelatorio_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void rvRelatorio_RenderingComplete(object sender, RenderingCompleteEventArgs e)
        {
            if (rvRelatorio.CurrentStatus.CanNavigatePages)
            {

                if (rvRelatorio.GetTotalPages() > 1)
                {
                    tsAnt.Enabled =
                       tsPrim.Enabled =
                       tsUlt.Enabled =
                       tsProx.Enabled = true;


                }

                tsPag.Text = "de " + rvRelatorio.GetTotalPages();

            }
        }

        private void tsImprimir_Click(object sender, EventArgs e)
        {
            rvRelatorio.PrintDialog();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
