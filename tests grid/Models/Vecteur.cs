﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R5._08.Project.Forms.Models
{
    public class Vecteur
    {
        public int v_Lenght = 0;
        public List<int[]> v_Coo;// ex. { { 1, 2 }, { 2, 3 }, ... } : les coordonnées que traversent le vecteur (pour être efficace en temps d'execution)
        public string v_Direction;
        public string[] v_AllDirections = { "Vertical", "Horizontale", "Diagonale-Gauche", "Diagonale-Droite" };

        public Vecteur(int p_Lenght, string p_Direction) {
            if (!v_AllDirections.Contains(p_Direction)) {
                throw new ArgumentException(p_Direction + " Invalide; Choix possibles: " + v_AllDirections.ToString());
            }

            this.v_Lenght = p_Lenght;
            this.v_Direction = p_Direction;
        }

        public void MergeCoo(List<int[]> p_Coo) {
            // Utilisation d'un HashSet pour éviter les duplications
            HashSet<int[]> v_MergedSet = new HashSet<int[]>(new IntArrayEqualityComparator());

            // Merger les éléments des listes
            foreach (var v_Array in this.v_Coo)
            {
                v_MergedSet.Add(v_Array);
            }
            foreach (var v_Array in p_Coo)
            {
                v_MergedSet.Add(v_Array);
            }

            this.v_Coo = new List<int[]>(v_MergedSet);
        }
    }
}