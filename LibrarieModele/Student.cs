﻿using System;

namespace LibrarieModele
{
    public class Student
    {
        //constante
        private const char SEPARATOR_PRINCIPAL_FISIER = ';';

        private const int ID = 0;
        private const int NUME = 1;
        private const int PRENUME = 2;

        //proprietati auto-implemented 
        private int idStudent; //identificator unic student
        private string nume;
        private string prenume;

        //contructor implicit
        public Student()
        {
            nume = string.Empty;
            prenume = string.Empty;
            
        }
        public Student(string _nume, string _prenume )
        {
            nume = _nume;
            prenume = _prenume;

        }

        //constructor cu parametri
        public Student(int idStudent, string nume, string prenume)
        {
            this.idStudent = idStudent;
            this.nume = nume;
            this.prenume = prenume;
        }

        //constructor cu un singur parametru de tip string care reprezinta o linie dintr-un fisier text
        public Student(string linieFisier)
        {
            var dateFisier = linieFisier.Split(SEPARATOR_PRINCIPAL_FISIER);

            //ordinea de preluare a campurilor este data de ordinea in care au fost scrise in fisier prin apelul implicit al metodei ConversieLaSir_PentruFisier()
            idStudent = Convert.ToInt32(dateFisier[ID]);
            nume = dateFisier[NUME];
            prenume = dateFisier[PRENUME];
        }

        public string ConversieLaSir_PentruFisier()
        {
            string obiectStudentPentruFisier = string.Format("{1}{0}{2}{0}{3}{0}",
                SEPARATOR_PRINCIPAL_FISIER,
                idStudent.ToString(),
                (nume ?? " NECUNOSCUT "),
                (prenume ?? " NECUNOSCUT "));

            return obiectStudentPentruFisier;
        }

        public int GetIdStudent()
        {
            return idStudent;
        }

        public string GetNume()
        {
            return nume;
        }

        public string GetPrenume()
        {
            return prenume;
        }
    }
}
