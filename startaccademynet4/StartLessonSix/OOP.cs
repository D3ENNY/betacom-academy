namespace startaccademynet4;

internal class OOPTest
{
    internal abstract class MezziLocomozione    //classe astratta
    {
        public string peso {get; set;} = "";
        public bool trasportoPasseggeri {get; set;}
        public string tipoTrasporto {get; set;} = "";
        private int numeroMarcie {get; set;}    //incapsulamento
        public abstract bool Ruote {get; set;}  //va implementato obbligatoriamente => abstract
        public abstract string TipoMotore();

        public string getTipoTrasporto()
        {
            return $"tipo trasporto: {this.tipoTrasporto}";
        }
    }
    internal class MezziTrasporto : MezziLocomozione //ereditarietà
    {
        public override bool Ruote { get; set; }
        public override string TipoMotore() 
        {
            return "A scoppio";
        }
    }

    internal class MountainBike : MezziLocomozione
    {
        public override bool Ruote { get; set; }

        public override string TipoMotore()
        {
            return "pedali";
        }
    }

    internal interface IUtilizzoAuto   //best practice => per le interfaccie si mette la I maiuscola davanti
    {
        public string Accensione();
        public bool Climatizzatore();

    }

    internal interface IInterni //le interfaccie possono implementare solo le firme dei metodi 
    {
        public string Rivestimento();
        public string Luci();
    }

    internal class GestioneInterni : IUtilizzoAuto, IInterni
    {
        public string Accensione()
        {
            throw new NotImplementedException();
        }

        public bool Climatizzatore()
        {
            throw new NotImplementedException();
        }

        public string Luci()
        {
            throw new NotImplementedException();
        }

        public string Rivestimento()
        {
            throw new NotImplementedException();
        }
    }
}