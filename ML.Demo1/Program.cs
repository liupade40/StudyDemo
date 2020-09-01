using Microsoft.ML;
using Microsoft.ML.Data;
using Microsoft.ML.Legacy;
using Microsoft.ML.Legacy.Data;
using Microsoft.ML.Legacy.Trainers;
using Microsoft.ML.Legacy.Transforms;
using Microsoft.ML.Runtime.Api;
using Microsoft.ML.Trainers;
using Microsoft.ML.Transforms;
using System;

namespace ML.Demo1
{
    class Program
    {
        static void Main(string[] args)
        {
            // 创建学习管道对象
            var pipeline = new LearningPipeline();

            // 载入样本文件,并用作,分隔符
            string dataPath = "iris.data.txt";
            //pipeline.Add(new TextLoader<IrisData>(dataPath, separator: ","));
            pipeline.Add(new TextLoader(dataPath).CreateFrom<IrisData>(separator: ','));

            // 转换数据
            pipeline.Add(new Dictionarizer("Label"));

            // 放入特征向量
            pipeline.Add(new ColumnConcatenator("Features", "SepalLength", "SepalWidth", "PetalLength", "PetalWidth"));

            //为管道添加分类器算法
            pipeline.Add(new StochasticDualCoordinateAscentClassifier());

            // 将Label转换为原始文本
            pipeline.Add(new PredictedLabelColumnOriginalValueConverter() { PredictedLabelColumn = "PredictedLabel" });

            // 训练模型
            var model = pipeline.Train<IrisData, IrisPrediction>();

            // 使用训练好的模型来预测结果
            var prediction = model.Predict(new IrisData()
            {
                SepalLength = 1.3f,
                SepalWidth = 1.6f,
                PetalLength = 0.2f,
                PetalWidth = 1.1f,
            });

            Console.WriteLine($"这朵花是: {prediction.PredictedLabels}");
            Console.ReadKey();
        }
    }
    ///花的样本实体类
    public class IrisData
    {
        //萼片长度
        [Column("0")]
        public float SepalLength;
        //萼片宽度
        [Column("1")]
        public float SepalWidth;
        //花瓣长度
        [Column("2")]
        public float PetalLength;
        //花瓣宽度
        [Column("3")]
        public float PetalWidth;
        //品种
        [Column("4")]
        [ColumnName("Label")]
        public string Label;
    }
    ///预测结果返回的实体类
    public class IrisPrediction
    {
        [ColumnName("PredictedLabel")]
        public string PredictedLabels;
    }
}
