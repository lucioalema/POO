namespace Eventos
{
    public class Numeros
    {
        private int _Num;
        public int Num
        {
            get {return _Num;}
            set
            {
                _Num = value;
                if (_Num % 2 == 0 && EventoPar != null)
                    EventoPar();
            }
        }
        public delegate void NumerPar();
        public event NumerPar EventoPar;
    }
}