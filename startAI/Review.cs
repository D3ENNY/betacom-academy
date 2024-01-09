using Microsoft.ML.Data;

namespace startAI
{
    internal class Review
    {
        [LoadColumn(0)]
        public string TextFeeling { get; set; }
        [LoadColumn(1), ColumnName("Label")]
        public bool  feel {  get; set; }
    }

    internal class Prediction : Review
    {
        [ColumnName("PredictedLabel")]
        public bool prediction { get; set; }
        [ColumnName("Probability")]
        public float probability { get; set; }
        [ColumnName("Score")]
        public float score { get; set; }
    }
}
