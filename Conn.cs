using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeiroSistemaApp
{
    static class Conn
    {
        static private string servidor = "localhost";
        static private string bancoDados = "perfumar";
        static private string usuario = "root";
        static private string senha = "perfumardb";

        static public string strConn = $"server={servidor};User ID={usuario};database={bancoDados}";
    }
}
