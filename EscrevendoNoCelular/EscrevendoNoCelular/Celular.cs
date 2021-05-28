using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscrevendoNoCelular
{
    public class Celular
    {
        public string mensagem;

        public Celular(string mensagem) 
        {
            this.mensagem = mensagem.ToUpper();
            
        }

        public string ConverteMensagemEmNumero()
        {
            string resposta = "";
            if (ValidaMensagem())
            {
                foreach (char c in mensagem)
                {
                    if (resposta != "")
                    {
                        if (resposta.Last<char>() == ConverteCharParaNumero(c).First<char>())
                        {
                            resposta += "_";
                        }
                    }
                    resposta += ConverteCharParaNumero(c);
                }
            }
            else 
            {
                resposta = "Mensagem Inválida";
            }
            return resposta;
        }

        public string ConverteCharParaNumero(char c) 
        {
            switch(c)
            {
                default:
                    {
                        return "";
                    }
                case 'A':
                    {
                        return "2";
                    }
                case 'B':
                    {
                        return "22";
                    }
                case 'C':
                    {
                        return "222";
                    }
                case 'D':
                    {
                        return "3";
                    }
                case 'E':
                    {
                        return "33";
                    }
                case 'F':
                    {
                        return "333";
                    }
                case 'G':
                    {
                        return "4";
                    }
                case 'H':
                    {
                        return "44";
                    }
                case 'I':
                    {
                        return "444";
                    }
                case 'J':
                    {
                        return "5";
                    }
                case 'K':
                    {
                        return "55";
                    }
                case 'L':
                    {
                        return "555";
                    }
                case 'M':
                    {
                        return "6";
                    }
                case 'N':
                    {
                        return "66";
                    }
                case 'O':
                    {
                        return "666";
                    }
                case 'P':
                    {
                        return "7";
                    }
                case 'Q':
                    {
                        return "77";
                    }
                case 'R':
                    {
                        return "777";
                    }
                case 'S':
                    {
                        return "7777";
                    }
                case 'T':
                    {
                        return "8";
                    }
                case 'U':
                    {
                        return "88";
                    }
                case 'V':
                    {
                        return "888";
                    }
                case 'W':
                    {
                        return "9";
                    }
                case 'X':
                    {
                        return "99";
                    }
                case 'Y':
                    {
                        return "999";
                    }
                case 'Z':
                    {
                        return "9999";
                    }
                case ' ':
                    {
                        return "0";
                    }
            }
        }

        public bool ValidaMensagem()
        {
            foreach (char c in mensagem)
            {
               if ((c != 'A') && (c != 'B') && (c != 'C') && (c != 'D') && (c != 'E') && (c != 'F')
                  && (c != 'G') && (c != 'H') && (c != 'I') && (c != 'J') && (c != 'K') && (c != 'L')
                  && (c != 'M') && (c != 'N') && (c != 'O') && (c != 'P') && (c != 'Q') && (c != 'R')
                  && (c != 'S') && (c != 'T') && (c != 'U') && (c != 'V') && (c != 'W') && (c != 'X')
                  && (c != 'Y') && (c != 'Z') && (c != ' '))
                    return false;
            }
            if (mensagem.Length > 255)
                return false;

            return true;
        }
    }
}
