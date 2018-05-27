using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace WinMatriculaApp
{
    public partial class FrmMatricula : Form
    {
        public FrmMatricula()
        {
            InitializeComponent();
        }

        private void FrmMatricula_Load(object sender, EventArgs e)
        {
            this.gpMatricula.Enabled = true;
            this.gpArquivo.Enabled = false;
            this.btnTestar.Enabled = false;
            this.txtPath.Clear();
            this.txtMatricula.Clear();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            file.Filter = "Text|*.txt";
            file.InitialDirectory = System.IO.Directory.GetCurrentDirectory();
            file.ShowDialog();
        }

        private void txtMatricula_TextChanged(object sender, EventArgs e)
        {
            if (this.txtMatricula.Text != String.Empty)
            {
                try
                {
                    Int32.Parse(this.txtMatricula.Text);
                }
                catch (Exception)
                {
                    this.txtMatricula.Clear();
                }
            }
        }

        private void rdInforme_CheckedChanged(object sender, EventArgs e)
        {
            this.gpMatricula.Enabled = true;
            this.gpArquivo.Enabled = false;
            this.btnTestar.Enabled = false;
            this.txtPath.Clear();
            this.txtMatricula.Clear();
        }

        private void rdArquivo_CheckedChanged(object sender, EventArgs e)
        {
            this.gpMatricula.Enabled = false;
            this.gpArquivo.Enabled = true;
            this.btnTestar.Enabled = true;
            this.txtPath.Clear();
            this.txtMatricula.Clear();
        }

     

        private void file_FileOk(object sender, CancelEventArgs e)
        {
            this.txtPath.Text = file.FileName;
        }

        private bool ValidarMatricula(String matricula)
        {
            string pattern = "^[0-9]{4}$";
            Regex rgx = new Regex(pattern, RegexOptions.None);
            return rgx.IsMatch(matricula);
        }

        private bool ValidarPath(String path)
        {
            return true;
        }

        private void btnTestar_Click(object sender, EventArgs e)
        {
            if (ValidarPath(this.txtPath.Text))
            {
                int result = MatriculaTeste.TestarVerificacaoMatriculaArquivo(this.txtPath.Text);

                if (result == 1)
                {
                    MessageBox.Show("Teste da verificações de matrículas efetuado.", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Erro ao testar as verificações de matrículas em arquivo.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Diretório do arquivo inválido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (this.rdInforme.Checked)
            {
                if (this.txtMatricula.Text != String.Empty)
                {
                    if (ValidarMatricula(this.txtMatricula.Text))
                    {
                        MessageBox.Show("Matricula verificada: " + MatriculaTeste.InformarMatricula(this.txtMatricula.Text), "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Matricula inválida.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Nenhuma matrícula foi informada", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

            if (this.rdArquivo.Checked)
            {
                if (ValidarPath(this.txtPath.Text))
                {
                    int result = MatriculaTeste.VerificarMatriculaArquivo(this.txtPath.Text);

                    if (result == 1)
                    {
                        MessageBox.Show("Verificação de matrículas em arquivo efetuado.", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Erro ao verificar matrículas em arquivo.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Diretório do arquivo inválido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
