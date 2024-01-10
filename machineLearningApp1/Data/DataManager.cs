using machineLearningApp1.Models;
using Microsoft.ML;
using Microsoft.ML.Data;
using static Microsoft.ML.DataOperationsCatalog;

namespace machineLearningApp1.Data
{
    internal class DataManager(MLContext context)
    {

        private readonly MLContext _context = context;
        internal TrainTestData LoadData(string filePath) =>
            _context.Data.TrainTestSplit(
                _context.Data.LoadFromTextFile<Review>(filePath, hasHeader: false),
                testFraction: 0.2);

        internal ITransformer CreateTrainModel(IDataView dataTrainView) =>
            _context.Transforms.Text.FeaturizeText(
                outputColumnName: "Opzioni",
                inputColumnName: nameof(Review.TextFeeling))
                    .Append(_context.BinaryClassification.Trainers.SdcaLogisticRegression(
                        labelColumnName: "Label",
                        featureColumnName: "Opzioni")).Fit(dataTrainView);

        internal Prediction getPrediction(ITransformer trans, Review rev) => _context.Model.CreatePredictionEngine<Review, Prediction>(trans).Predict(rev);
    }
}
