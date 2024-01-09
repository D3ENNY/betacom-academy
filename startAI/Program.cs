using Microsoft.ML;
using Microsoft.ML.Data;
using static Microsoft.ML.DataOperationsCatalog;

namespace startAI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MLContext MLcontext = new();
            TrainTestData data = LoadData(MLcontext);
            ITransformer transformer = CreateTrainModel(MLcontext, data.TrainSet);
            Valutation(MLcontext, transformer, data.TestSet);
            RealTimeValutation(MLcontext, transformer);
        }

        private static TrainTestData LoadData(MLContext MLcontext)
        {
            IDataView dataView = MLcontext.Data.LoadFromTextFile<Review>(
                Path.Combine(Environment.CurrentDirectory, "Data", "yelp_labelled.txt"), 
                hasHeader: false
            );

            return MLcontext.Data.TrainTestSplit(dataView, testFraction: 0.2);
        }

        private static ITransformer CreateTrainModel(MLContext MLcontext, IDataView dataTrainView) => 
            MLcontext.Transforms.Text.FeaturizeText(
                outputColumnName: "Opzioni",
                inputColumnName: nameof(Review.TextFeeling))
                    .Append(MLcontext.BinaryClassification.Trainers.SdcaLogisticRegression(
                        labelColumnName: "Label",
                        featureColumnName: "Opzioni")).Fit(dataTrainView);

        public static void Valutation(MLContext MLcontext, ITransformer transformer, IDataView dataView) 
        {
            CalibratedBinaryClassificationMetrics metric = MLcontext.BinaryClassification.Evaluate(transformer.Transform(dataView));
            Console.WriteLine($"Accuracy : {metric.Accuracy:P2}");
            Console.WriteLine($"AUC (ROC): {metric.AreaUnderRocCurve:P2}");
            Console.WriteLine($"f1Score : {metric.F1Score:P2}\n\n");
        }

        public static void RealTimeValutation(MLContext MLcontext, ITransformer transformer)
        {
            Review review = new(){ TextFeeling = "this was a very bad steak!!!" };

            PredictionEngine<Review, Prediction> realTimePrediction = MLcontext.Model.CreatePredictionEngine<Review, Prediction>(transformer);
            Prediction predictionResult = realTimePrediction.Predict(review);

            Console.WriteLine($"output Review: {review.TextFeeling}\n" +
                $"Prediction: {(Convert.ToBoolean(predictionResult.prediction) ? "Positive" : "Negative")}\n" +
                $"Probability: {predictionResult.probability}\n" +
                $"Score: {predictionResult.score}");
        }
        
       
    }
}
