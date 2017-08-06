using Newtonsoft.Json;

namespace Droid_People
{
    public class Caracteristics
    {
        #region Attributs
        [JsonProperty(PropertyName = "Perception")]
        public int Perception;
        [JsonProperty(PropertyName = "Franchise")]
        public int Franchise;
        [JsonProperty(PropertyName = "Vivacite")]
        public int Vivacite;
        [JsonProperty(PropertyName = "Coordination")]
        public int Coordination;
        [JsonProperty(PropertyName = "Humilite")]
        public int Humilite;
        [JsonProperty(PropertyName = "Crualite")]
        public int Crualite;
        [JsonProperty(PropertyName = "Instinct_de_survie")]
        public int Instinct_de_survie;
        [JsonProperty(PropertyName = "Patience")]
        public int Patience;
        [JsonProperty(PropertyName = "Determination")]
        public int Determination;
        [JsonProperty(PropertyName = "Imagination")]
        public int Imagination;
        [JsonProperty(PropertyName = "Curiosite")]
        public int Curiosite;
        [JsonProperty(PropertyName = "Agressivite")]
        public int Agressivite;
        [JsonProperty(PropertyName = "Loyaute")]
        public int Loyaute;
        [JsonProperty(PropertyName = "Empathie")]
        public int Empathie;
        [JsonProperty(PropertyName = "Tenacite")]
        public int Tenacite;
        [JsonProperty(PropertyName = "Courage")]
        public int Courage;
        [JsonProperty(PropertyName = "Sensualite")]
        public int Sensualite;
        [JsonProperty(PropertyName = "Charme")]
        public int Charme;
        [JsonProperty(PropertyName = "Humour")]
        public int Humour;
        #endregion

        #region Constructor
        public Caracteristics(int defaultLevel = 10)
        {
            Perception = defaultLevel;
            Franchise = defaultLevel;
            Vivacite = defaultLevel;
            Coordination = defaultLevel;
            Humilite = defaultLevel;
            Crualite = defaultLevel;
            Instinct_de_survie = defaultLevel;
            Patience = defaultLevel;
            Determination = defaultLevel;
            Imagination = defaultLevel;
            Curiosite = defaultLevel;
            Agressivite = defaultLevel;
            Loyaute = defaultLevel;
            Empathie = defaultLevel;
            Tenacite = defaultLevel;
            Courage = defaultLevel;
            Sensualite = defaultLevel;
            Charme = defaultLevel;
            Humour = defaultLevel;
        }
        #endregion
    }
}