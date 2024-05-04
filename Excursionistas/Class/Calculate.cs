using Excursionistas.Models;

namespace Excursionistas.Class
{
    public class Calculate
    {
        private List<Variables.Elementos> Elementos = null;
        private void CargarDatos()
        {
            //en este proceso se cargaran los datos para realizar el proceso actualmente se van a realizar desde codigo
            //si se desea realizar el cargue de la informcaion de otro lugar o otro proceso de consultar la informacion actual se realiza en este modulo
            List<Variables.Elementos> elementos = new List<Variables.Elementos>
            {
            new Variables.Elementos { Name = "E1", Peso = 5, Calorias = 3 },
            new Variables.Elementos { Name = "E2", Peso = 3, Calorias = 5 },
            new Variables.Elementos { Name = "E3", Peso = 5, Calorias = 2 },
            new Variables.Elementos { Name = "E4", Peso = 1, Calorias = 8 },
            new Variables.Elementos { Name = "E5", Peso = 2, Calorias = 3 }
            };
            Elementos = elementos;
        }
        public Variables.GetCalculare MejorCalculo(int calorias, int peso)
        {
            Variables.GetCalculare resultado = new Variables.GetCalculare();
            resultado.elementos = new List<Variables.Elementos>();
            //se realiza el estudio de los elementos que puede llevar

            //Se cargan los datos para el estudio
            if (Elementos == null)
            {
                CargarDatos();
            }
            resultado.MaxCalorias = 0;
            List<string> MejorCombinacion = new List<string>();

            for (int i = 0; i < Elementos.Count; i++)
            {
                int CuenPeso = 0;
                List<string> CuenVariables = new List<string>();
                int CuenCalorias = 0;
                for (int j = 0; j < Elementos.Count; j++)
                {
                    if (i != j)
                    {
                        if ((CuenPeso + Elementos[j].Peso) < peso)
                        {
                            //podemos utilizar esta convinacion y guardamos los datos para continuar
                            CuenPeso += Elementos[j].Peso;
                            CuenCalorias += Elementos[j].Calorias;
                            CuenVariables.Add(Elementos[j].Name);
                        }
                    }
                }
                //luego de realizar el estudio con cada una de las posivilidades posibles validamos cual puede llegar a ser la mas viable
                if (resultado.MaxCalorias < CuenCalorias)
                {
                    resultado.MaxCalorias = CuenCalorias;
                    resultado.MinPeso = peso;
                    MejorCombinacion = CuenVariables;
                }
                //con eso finalizamos y ya sabremos cual es el mayor

            }

            //proceso para obtener la mayor eficiencia posible
            foreach(string v in  MejorCombinacion)
            {
                Variables.Elementos encontrado = Elementos.Find(e => e.Name == v);
                if (encontrado != null)
                {
                    resultado.elementos.Add(encontrado);
                }             
            }
            resultado.Mensaje = "Se ha completado la búsqueda Correcta";
            return resultado;
        }
    }
}
