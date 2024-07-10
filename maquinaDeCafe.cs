namespace MaquinaCafe
{
    public enum TamanoTaza
    {
        Pequeno,
        Mediano,
        Grande
    }

    public class TazaDeCafe
    {
        public TamanoTaza Tamano { get; set; }
        public int CucharadasAzucar { get; set; }
        public int OnzasDeCafe { get; set; }
    }

    public class MaquinaDeCafe
    {
        private TamanoTaza _tamanoTaza;
        private int _cucharadasAzucar;

        public int SeleccionarTamanoTaza(TamanoTaza tamanoTaza)
        {
            _tamanoTaza = tamanoTaza;
            return tamanoTaza switch
            {
                TamanoTaza.Pequeno => 3,
                TamanoTaza.Mediano => 5,
                TamanoTaza.Grande => 7,
                _ => 0
            };
        }

        public int SeleccionarCucharadasAzucar(int cucharadas)
        {
            _cucharadasAzucar = cucharadas;
            return _cucharadasAzucar;
        }

        public TazaDeCafe RecogerTaza()
        {
            return new TazaDeCafe
            {
                Tamano = _tamanoTaza,
                CucharadasAzucar = _cucharadasAzucar,
                OnzasDeCafe = _tamanoTaza switch
                {
                    TamanoTaza.Pequeno => 3,
                    TamanoTaza.Mediano => 5,
                    TamanoTaza.Grande => 7,
                    _ => 0
                }
            };
        }
    }
}
