using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace WinMatriculaApp
{
    public class MatriculaTeste
    {
        //Método para verificar somente uma matrícula.
        public static string InformarMatricula(string matricula)
        {
            return MatriculaTeste.VerificarMatricula(matricula);
        }

        //Método para verificar matrícula dentro de um arquivo.
        public static int VerificarMatriculaArquivo(string path)
        {
            try
            {
                if (File.Exists(path))
                {
                    List<string> list = new List<string>();

                    foreach (string matricula in File.ReadAllLines(path))
                    {
                        list.Add(MatriculaTeste.VerificarMatricula(matricula));
                    }

                    EnviarParaArquivo(1, list);
                    return 1; // Retorno OK;
                }
                else
                {
                    return 0; // Nenhum arquivo informado;
                }
            }
            catch (Exception)
            {
                return -1; // Erro gerado;
            }
        }

        //Método para testar se as verificações das matrícula num arquivo estão corretas.
        public static int TestarVerificacaoMatriculaArquivo(string path)
        {
            try
            {
                if (File.Exists(path))
                {
                    List<string> list = new List<string>();
                    String result = "";

                    foreach (string matricula in File.ReadAllLines(path))
                    {
                        if((matricula == MatriculaTeste.VerificarMatricula(matricula.Substring(0, 4))))
                        {
                            result = "Verdadeiro";
                        }
                        else
                        {
                            result = "Falso";
                        }
                        list.Add(matricula + " - " + result);
                    }

                    return EnviarParaArquivo(2, list);
                }
                else
                {
                    return 0; //Arquivo não encontrado;
                }
            }
            catch (Exception)
            {
                return -1;   //Erro gerado; 
            }
        }

        //Método utilizado para salvar as informãções em arquivo.
        private static int EnviarParaArquivo(int opc, List<string> matriculas)
        {
            try
            {
                StreamWriter file = null;

                //Criando arquivo de saída de verificação de matrícula.
                if (opc == 1)
                {
                    file = new StreamWriter(@"matriculasComDV.txt");
                    foreach (string matricula in matriculas)
                    {
                        file.WriteLine(matricula);
                    }
                }

                //Criando arquivo de saída de teste da verificação de matrícula.
                if (opc == 2)
                {
                    file = new StreamWriter(@"matriculasVerificadas.txt");
                    foreach (string matricula in matriculas)
                    {
                        file.WriteLine(matricula);
                    }
                }

                file.Close();

                return 1;
            }
            catch (Exception)
            {
                return -1;
            }
        }

        //Método para validar entrada de uma matrícula.
        private static bool ValidarMatricula(String matricula)
        {
            string pattern = "^[0-9]{4}$";
            Regex rgx = new Regex(pattern, RegexOptions.None);
            return rgx.IsMatch(matricula);
        }

        //Método que faz a verificação da matrícula.
        private static string VerificarMatricula(String matricula)
        {
            try
            {
                if(MatriculaTeste.ValidarMatricula(matricula))
                {
                    int i = 6;
                    int soma = 0;

                    foreach (char item in matricula)
                    {
                        soma = soma + Int32.Parse(item.ToString()) * (--i);
                    }

                    int div = soma % 16;
                    string hexValue = div.ToString("X");
                    return String.Format("{0}-{1}", matricula, hexValue);
                }
                else
                {
                    return String.Format("{0} - MATRICULA INVÁLIDA.", matricula);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
