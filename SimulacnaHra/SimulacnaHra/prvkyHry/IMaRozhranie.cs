namespace SimulacnaHra.prvkyHry
{
    /// <summary>
    /// Interface pe prvky v hre, ktoré najú voje rozhrania
    /// </summary>
    public interface IMaRozhranie
    {
        /// <summary>
        /// Zobrazí svoje rozhranie,
        /// ak je to potrebné, vycentruje mapu
        /// </summary>
        void ZobrazForm();

        void ZmazOkno();
    }
}
