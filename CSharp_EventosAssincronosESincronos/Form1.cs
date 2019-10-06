using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventosAssincronosESincronos
{
    public partial class FrmPrincipal : Form
    {
        private int _numeroProcessos;
        private bool _deveCancelar = false;

        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void BtnProcessarSincrono_Click(object sender, EventArgs e)
        {
            try
            {
                _deveCancelar = false;

                HabilitarrControles(false);

                ValidarTelaEPreencherCampos();

                LblProgresso.Visible = true;

                for (var i = 1; i <= _numeroProcessos && !_deveCancelar; i++)
                {
                    LblProgresso.Text = $"Processo {i} de {_numeroProcessos}.";

                    Thread.Sleep(100);
                }

                if (_deveCancelar)
                {
                    MostrarAviso("Processo cancelado pelo usuário.");
                }
                else
                {
                    MostrarInformacao("Processo concluído com êxito.");
                }
            }
            catch(AggregateException ex)
            {
                TratarErroAgregado(ex);
            }
            catch(Exception)
            {
                MostrarErro("Erro desconhecido.");
            }
            finally
            {
                HabilitarrControles(true);
            }
        }

        private void MostrarInformacao(string mensagem)
        {
            MostrarMensagem(mensagem, NivelInformacao.Informacao);
        }

        private void MostrarAviso(string mensagem)
        {
            MostrarMensagem(mensagem, NivelInformacao.Aviso);
        }

        private void MostrarErro(string mensagem)
        {
            MostrarMensagem(mensagem, NivelInformacao.Erro);
        }

        private void MostrarMensagem(string mensagem, NivelInformacao nivelInformacao)
        {
            var parametrosInformacao = new ParametrosMensagem 
            { 
                Caption = "Informação", 
                MessageBoxButtons = MessageBoxButtons.OK, 
                MessageBoxIcon = MessageBoxIcon.Information 
            };

            var parametrosAviso = new ParametrosMensagem
            {
                Caption = "Aviso",
                MessageBoxButtons = MessageBoxButtons.OK,
                MessageBoxIcon = MessageBoxIcon.Warning
            };

            var parametrosErro = new ParametrosMensagem
            {
                Caption = "Erro",
                MessageBoxButtons = MessageBoxButtons.OK,
                MessageBoxIcon = MessageBoxIcon.Error
            };

            var parametrosMensagemPorNivelInformacao = new Dictionary<NivelInformacao, ParametrosMensagem>
            {
                { NivelInformacao.Informacao, parametrosInformacao },
                { NivelInformacao.Aviso, parametrosAviso },
                { NivelInformacao.Erro, parametrosErro }
            };

            var parametrosMensagem = parametrosMensagemPorNivelInformacao[nivelInformacao];

            MessageBox.Show(mensagem, parametrosMensagem.Caption, parametrosMensagem.MessageBoxButtons, parametrosMensagem.MessageBoxIcon);
        }

        private void HabilitarrControles(bool habilitado)
        {
            TxtNumeroProcessos.Enabled = habilitado;
            BtnProcessarAsync.Enabled = habilitado;
            BtnProcessarSincrono.Enabled = habilitado;
            BtnCancelar.Enabled = !habilitado;
        }

        private void TratarErroAgregado(AggregateException excecaoAgregada)
        {
            if (excecaoAgregada != null)
            {
                var innerExceptions = excecaoAgregada.InnerExceptions;

                if (innerExceptions != null && innerExceptions.Any()) 
                {
                    var sb = new StringBuilder();

                    foreach(var ex in innerExceptions)
                    {
                        var linha = $"* {ex.Message}";

                        sb.AppendLine(linha);
                    }

                    var mensagem = sb.ToString();

                    MessageBox.Show(mensagem, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void ValidarTelaEPreencherCampos()
        {
            ValidarNumeroProcessos();
        }

        private void ValidarNumeroProcessos()
        {
            var excecoes = new List<Exception>();

            try
            {
                if (string.IsNullOrWhiteSpace(TxtNumeroProcessos.Text))
                {
                    throw new ArgumentException("Número é obrigatório.");
                }
            }
            catch(Exception ex)
            {
                excecoes.Add(ex);
            }

            
            try
            {
                bool ehInteiro = int.TryParse(TxtNumeroProcessos.Text, out _numeroProcessos);

                if (!ehInteiro)
                {
                    throw new ArgumentException("Número deve ser inteiro.");
                }

                if (_numeroProcessos <= 0)
                {
                    throw new ArgumentException("O número deve ser pelo menos 1.");
                }
            }
            catch(Exception ex)
            {
                excecoes.Add(ex);
            }

            if (excecoes.Any())
            {
                throw new AggregateException(excecoes);
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            _deveCancelar = true;
        }

        private async void BtnProcessarAsync_Click(object sender, EventArgs e)
        {
            try
            {
                _deveCancelar = false;

                HabilitarrControles(false);

                ValidarTelaEPreencherCampos();

                LblProgresso.Visible = true;

                for (var i = 1; i <= _numeroProcessos && !_deveCancelar; i++)
                {
                    LblProgresso.Text = $"Processo {i} de {_numeroProcessos}.";

                    await Task.Delay(100);
                }

                if (_deveCancelar)
                {
                    MostrarAviso("Processo cancelado pelo usuário.");
                }
                else
                {
                    MostrarInformacao("Processo concluído com êxito.");
                }
            }
            catch (AggregateException ex)
            {
                TratarErroAgregado(ex);
            }
            catch (Exception ex)
            {
                MostrarErro("Erro desconhecido.");
            }
            finally
            {
                HabilitarrControles(true);
            }
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            HabilitarrControles(true);

            TxtNumeroProcessos.Select();
        }
    }
}
