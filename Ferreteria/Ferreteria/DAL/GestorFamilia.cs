using BlibliotecaBodega.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlibliotecaBodega.DAL
{
    public class GestorFamilia
    {
        private static List<Familia> familias = new List<Familia>();

        public void ingresar(Familia fam)
        {
            familias.Add(fam);
        }

        public List<Familia> mostrar()
        {
            return familias;
        }

        public void eliminar(Familia fam)
        {
            familias.Remove(fam);
        }

        public void modificar(int indice, Familia fam)
        {
            familias.Insert(indice, fam);
        }
    }
}
