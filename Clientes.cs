namespace Atividade
{
    public abstract class cliente
    {
        public string Nome;
        public string Endereço;
        public float Valor { get; protected set; }  //value before taxes
        public float ValorImposto { get; protected set; }   //taxes value
        public float Total { get; protected set; }  //total with taxes
        public virtual void PagarImposto(float v)   //paytaxes method
        {
            Valor = v;
            Total = Valor * 1.1F;
            ValorImposto = Total - Valor;
        }
        public virtual void imprimir(){}
    }
}