using machineLearningApp1.Data;
using machineLearningApp1.Models;
using Microsoft.ML;
using static Microsoft.ML.DataOperationsCatalog;

namespace machineLearningApp1
{
    internal class Program
    {

        private readonly DataManager _dataManager;

        public Program(MLContext context)
        { 
            this._dataManager = new(context);

            Review rev = new() 
            { 
                TextFeeling = "the coffe was good" 
            };

            TrainTestData data = _dataManager.LoadData(Path.Combine(Environment.CurrentDirectory, "Data", "imdb_labelled.txt"));
            Valutation(rev, _dataManager.getPrediction(_dataManager.CreateTrainModel(data.TrainSet), rev));

        }    

        public void Valutation(Review review, Prediction prediction) =>
            Console.WriteLine($"output Review: {review.TextFeeling}\n" +
                $"Prediction: {(Convert.ToBoolean(prediction.prediction) ? "Positive" : "Negative")}\n" +
                $"Probability: {prediction.probability}\n" +
                $"Score: {prediction.score}");
   

        static void Main(string[] args) => new Program(new MLContext());
    }
}
