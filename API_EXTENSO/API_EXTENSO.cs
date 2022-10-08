
namespace API_EXTENSO
{
    public class APiExtenso
    {
        public static string Imprimir(int n)
        {
            if (n < 10) return Unidades(n);
            else if (n < 100) return Dezenas(n);
            else if (n < 1000) return Centena(n);
            else if (n < 10000) return Milhar(n);
            else return "";
        }

        private static string Milhar(int n)
        {
            string[] c = new string[] {
                "", "mil", "dois mil", "três mil", "quatro mil", "cinco mil",  "seis mil", "sete mil",
                "oito mil", "nove mil"
            };

            if (n == 1000) return "mil";
            else if (n % 1000 == 0) return Unidades(n / 1000) + " mil ";
            else return Unidades(n / 1000) + " mil " + Imprimir(n % 1000);
        }
        private static string Centena(int n)
        {
            string[] c = new string[] {
                "","cento","duzentos","trezentos",
                "quatrocentos","quinhentos",
                "seiscentos","setecentos",
                "oitocentos","novecentos"
            };

            if (n == 100) return "cem";
            else if (n % 100 == 0) return c[n / 100];
            else return c[n / 100] + " e " + Imprimir(n % 100);
        }

            private static string Dezenas(int n)
        {
            string[] d = new string[]
            {
                "", "dez", "vinte", "trinta","quarenta", "cinquenta","sessenta"," setenta", "oitenta", "noventa"
            };

            string[] du = new string[]
            {
                "", "onze", "doze", "treze", "quatorze", "quinze", "dezesseis", "dezessete", "dezoito", "dezenove"
            };

            if (n % 10 == 0) return d[n / 10];
            else if (n > 20) return d[n / 10] + " e " + Imprimir(n % 10);
            else return du[n%10];
        }

        private static string Unidades(int n)
        {
            string[] u = new string[]
            {
                "zero", "um", "dois","três", "quatro", "cinco", "seis", "sete", "oito", "nove"
            };
            return u[n];
        }

    }
}