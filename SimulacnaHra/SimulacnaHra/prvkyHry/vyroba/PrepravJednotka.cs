///////////////////////////////////////////////////////////
//  PrepravJednotka.cs
//  Implementation of the Class PrepravJednotka
//  Generated by Enterprise Architect
//  Created on:      17-2-2016 17:13:22
//  Original author: Dobroslav Grygar
///////////////////////////////////////////////////////////

using SimulacnaHra.hra;
using SimulacnaHra.prvkyHry.infrastruktura;

namespace SimulacnaHra.prvkyHry.vyroba {

    /// <summary>
    /// Prepravn� jednotka sl��i na prepravovanie - teda tvorbu zisku v hre
    /// </summary>
	public class PrepravJednotka {

		private Stanica aCiel;
		private Stanica aZdroj;
        private int aZaciatocnyDen;

        public int CasNalozenia { set{ aZaciatocnyDen = value;} }
        public Stanica Zdroj { set { aZdroj = value; } }
	    public TypPrepravJednotky Typ { get; internal set; }

	    public PrepravJednotka(Stanica paZaciatok, TypPrepravJednotky paTyp){
            aZdroj = paZaciatok;
            Typ = paTyp;
		}

        public PrepravJednotka(TypPrepravJednotky paTyp)
        {
            Typ = paTyp;
        }

        /// <summary>
        /// V�po�et koeficientu ziskuCena sa odv�ja od vzdialenosti a d�ky prepravy
        /// </summary>
        /// <param name="paZaklPocetDni">Ako dlho mala teoreticky trva� preprava </param>
        /// <param name="paSkutPocetDni">skuto�n� trvanie prepravy</param>
        /// <returns>koeficient zisku</returns>
        private double DajKoeficient(int paZaklPocetDni, int paSkutPocetDni)
	    {
            int rozdielDni = paZaklPocetDni - paSkutPocetDni;
            double koeficient;

            if (rozdielDni <= paZaklPocetDni * 0.1 && rozdielDni >= paZaklPocetDni * (-0.1))
            {
                koeficient = 1;
            }
            else if (rozdielDni > paZaklPocetDni * 0.1 && rozdielDni <= paZaklPocetDni * 0.25)
            {
                koeficient = 1.25;
            }
            else if (rozdielDni > paZaklPocetDni * 0.25 && rozdielDni <= paZaklPocetDni * 0.5)
            {
                koeficient = 1.5;
            }
            else if (rozdielDni > paZaklPocetDni * 0.5 && rozdielDni <= paZaklPocetDni * 0.75)
            {
                koeficient = 1.75;
            }
            else if (rozdielDni > paZaklPocetDni * 0.75)
            {
                koeficient = 1.99;
            }
            else if (rozdielDni < paZaklPocetDni * (-0.1) && rozdielDni >= paZaklPocetDni * (-0.25))
            {
                koeficient = 0.8;
            }
            else if (rozdielDni < paZaklPocetDni * (-0.25) && rozdielDni >= paZaklPocetDni * (-0.5))
            {
                koeficient = 0.65;
            }
            else if (rozdielDni < paZaklPocetDni * (-0.5) && rozdielDni >= paZaklPocetDni * (-0.75))
            {
                koeficient = 0.55;
            }
            else
            {
                koeficient = 0.5;
            }
            return koeficient;
	    }

        /// <summary>
        /// Vyplatenie odmeny Zastavka prepravu
        /// </summary>
	    public void VydajOdnemu(Stanica paStanica)
	    {
	        aCiel = paStanica;
            int zaklPocetDni = aZdroj.Poloha.Vzdialenost(aCiel.Poloha)/5;
	        int skutPocetDni = Hra.DajInstanciu().Den - aZaciatocnyDen;
	        double koeficient = this.DajKoeficient(zaklPocetDni, skutPocetDni);
            Spolocnost.UpravFinancie((int)((double)koeficient * (int)Typ *zaklPocetDni));
	    }
    }//end PrepravJednotka

}//end namespace vyroba