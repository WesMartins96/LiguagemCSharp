using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Xadrez.tabuleiro
{
    class TabuleiroException : Exception
    {
        public TabuleiroException(string message) : base(message)
        {
        }
    }
}
