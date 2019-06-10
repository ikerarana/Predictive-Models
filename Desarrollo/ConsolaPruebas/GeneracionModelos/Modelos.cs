using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using weka.classifiers;
using weka.core;
using static weka.core.converters.ConverterUtils;

namespace GeneracionModelos
{
    public static class Modelos
    {
        public static void GenerarModelo()
        {
            // Fuente de datos
            DataSource source = new DataSource(DirectorioDatosPrueba());

            // convertimos a instancias
            Instances data = source.getDataSet();

            // generamos una copia
            Instances dataCopy = new Instances(data);

            // hay qeu decirle cual es el atributo de clase
            if (data.classIndex() == -1)
                data.setClassIndex(data.numAttributes() - 1);

            #region Iker

            #region Discretizacion

            //// DISCRETIZACION
            //bool bHasNonNominal = true;
            //bool bHasMissingValues = true;

            //weka.filters.unsupervised.attribute.Discretize unSupervised = new weka.filters.unsupervised.attribute.Discretize();
            //weka.filters.supervised.attribute.Discretize supervised = new weka.filters.supervised.attribute.Discretize();

            ////Instances dataCopy = new Instances(data);

            //// Quitamos las missing classes de las instancias
            ////data.deleteWithMissingClass();

            //// 
            ////data = NormalizeDataset(data);

            //// si no hay missing values
            //if (bHasNonNominal)
            //{

            //    // Para los que son nominales y no son missing values
            //    weka.filters.supervised.attribute.Discretize supervised2 = new weka.filters.supervised.attribute.Discretize();
            //    bool k = supervised2.getUseKononenko();
            //    supervised2.setUseKononenko(true);
            //    k = supervised2.getUseKononenko();
            //    k= supervised2.setInputFormat(data);
            //    data = weka.filters.Filter.useFilter(data, supervised2);
            //}

            //// si hay missing valyes
            //if (bHasMissingValues)
            //{
            //    //System.err.println("Warning: filling in missing values in data set");
            //    weka.filters.unsupervised.attribute.ReplaceMissingValues m_MissingValuesFilter = new weka.filters.unsupervised.attribute.ReplaceMissingValues();
            //    m_MissingValuesFilter.setInputFormat(data);
            //    data = weka.filters.Filter.useFilter(data, m_MissingValuesFilter);
            //}

            //// EQUAL FREQUENCIES

            //// creamos el objeto para discretizar
            //weka.filters.unsupervised.attribute.Discretize discretizer = new weka.filters.unsupervised.attribute.Discretize();

            //// Le decimos que use el metodo equal frequecies
            //discretizer.setUseEqualFrequency(true);

            //// ponemos el numero de bins que nos salga de las narices
            //discretizer.setBins(3);

            //// Este metodo es de la clase PotentialClassIgnorer 
            //discretizer.setIgnoreClass(true);//Set the IgnoreClass value. Set this to true if the class index is to be unset before the filter is applied.

            //// Sets the format of the input instances.
            //bool val = discretizer.setInputFormat(data);

            //// Aplicamos la discretizacion
            //data = Filter.useFilter(data, discretizer);

            //// FIND NUM BINS

            //// creamos el discretizador
            //weka.filters.unsupervised.attribute.Discretize discretizer2 = new weka.filters.unsupervised.attribute.Discretize();

            //// le decimos que use este metodo
            //discretizer2.setFindNumBins(true);

            //// esto es opcional
            //discretizer2.setIgnoreClass(true);

            //// 
            //discretizer2.setInputFormat(data);

            ////
            //data = Filter.useFilter(data, discretizer2);

            #endregion

            #region Modelos

            #region Cadenas de texto
            // hay qeu decirle cual es el atributo de clase
            if (data.classIndex() == -1)
                data.setClassIndex(data.numAttributes() - 1);

            string k2 = "weka.classifiers.bayes.BayesNet -D -Q weka.classifiers.bayes.net.search.local.K2 -- -P 1 -S BAYES -E weka.classifiers.bayes.net.estimate.SimpleEstimator -- -A 0.5";
            string HillClimber = "weka.classifiers.bayes.BayesNet -D -Q weka.classifiers.bayes.net.search.local.HillClimber -- -P 1 -S BAYES -E weka.classifiers.bayes.net.estimate.SimpleEstimator -- -A 0.5";
            string TAN = "weka.classifiers.bayes.BayesNet -D -Q weka.classifiers.bayes.net.search.local.TAN -- -S BAYES -E weka.classifiers.bayes.net.estimate.SimpleEstimator -- -A 0.5";
            string bayesNetworkNaiveBayes = "weka.classifiers.bayes.NaiveBayes";

            string j48 = "weka.classifiers.trees.J48 -C 0.25 -M 2";
            string rF = "weka.classifiers.trees.RandomForest -P 100 -I 100 -num-slots 1 -K 0 -M 1.0 -V 0.001 -S 1";

            string knn = "weka.classifiers.lazy.IBk -K " + 1.ToString() + " -W 0 -A \"weka.core.neighboursearch.LinearNNSearch -A \\\"weka.core.EuclideanDistance -R first-last\\\"\"";

            string ann = "weka.classifiers.functions.MultilayerPerceptron -L 0.3 -M 0.2 -N 500 -V 0 -S 0 -E 20 -H a";

            string polykernel = "weka.classifiers.functions.SMO -C 1.0 -L 0.001 -P 1.0E-12 -N 0 -V -1 -W 1 -K \"weka.classifiers.functions.supportVector.PolyKernel -E 1.0 -C 250007\" -calibrator \"weka.classifiers.functions.Logistic -R 1.0E-8 -M -1 -num-decimal-places 4\"";
            string rbfkernell = "weka.classifiers.functions.SMO -C 1.0 -L 0.001 -P 1.0E-12 -N 0 -V -1 -W 1 -K \"weka.classifiers.functions.supportVector.RBFKernel -G 0.01 -C 250007\" -calibrator \"weka.classifiers.functions.Logistic -R 1.0E-8 -M -1 -num-decimal-places 4\"";
            string normalized = "weka.classifiers.functions.SMO -C 1.0 -L 0.001 -P 1.0E-12 -N 0 -V -1 -W 1 -K \"weka.classifiers.functions.supportVector.NormalizedPolyKernel -E 2.0 -C 250007\" -calibrator \"weka.classifiers.functions.Logistic -R 1.0E-8 -M -1 -num-decimal-places 4\"";
            string puk = "weka.classifiers.functions.SMO -C 1.0 -L 0.001 -P 1.0E-12 -N 0 -V -1 -W 1 -K \"weka.classifiers.functions.supportVector.Puk -O 1.0 -S 1.0 -C 250007\" -calibrator \"weka.classifiers.functions.Logistic -R 1.0E-8 -M -1 -num-decimal-places 4\"";

            #endregion

            #region Clasificador

            // Separamos la cadena de texto del clasificador en un array
            string[] options = Utils.splitOptions("weka.classifiers.functions.SMO -C 1.0 -L 0.001 -P 1.0E-12 -N 0 -V -1 -W 1 -K \"weka.classifiers.functions.supportVector.PolyKernel -E 1.0 -C 250007\" -calibrator \"weka.classifiers.functions.Logistic -R 1.0E-8 -M -1 -num-decimal-places 4\"");
            string className = options[0];
            options[0] = string.Empty;

            // Creamos el clasificador
            weka.classifiers.Classifier scheme = (Classifier)Utils.forName(java.lang.Class.forName("weka.classifiers.Classifier"), className, options);

            #endregion

            #region Evaluar

            #region Percentage split

            // porcentaje que queremos para predecir
            int trainingPercent = 80;

            // sacamos el numero de isntancias que se corresponden a ese procentaje
            int trainSize = (int)Math.Round(data.numInstances() * ((double)trainingPercent / (double)100));

            // sacamos el porentajhe que queremos para probar
            int testSize = data.numInstances() - trainSize;

            // aleatoreizamos el dataset para asegurarnos que las instancias no estan ordenadas
            data.randomize(new java.util.Random(DateTime.Now.Ticks));

            // Separamos las instancias en 2 grupos (entrenar con unas y predecri con otras)
            Instances train = new Instances(data, 0, trainSize);
            Instances test = new Instances(data, trainSize, testSize);

            // Generamos el clasificador con el training y lo evaluamos con el test
            Classifier clsCopyTest = AbstractClassifier.makeCopy(scheme);
            clsCopyTest.buildClassifier(train);
            Evaluation evalTest = new Evaluation(data);
            evalTest.evaluateModel(clsCopyTest, test);

            Console.WriteLine();
            Console.WriteLine("Correct % = " + evalTest.pctCorrect());
            Console.WriteLine("Incorrect % = " + evalTest.pctIncorrect());
            Console.WriteLine("AUC = " + evalTest.areaUnderROC(1));
            Console.WriteLine("kappa = " + evalTest.kappa());
            Console.WriteLine("MAE = " + evalTest.meanAbsoluteError());
            Console.WriteLine("RMSE = " + evalTest.rootMeanSquaredError());
            Console.WriteLine("RAE = " + evalTest.relativeAbsoluteError());
            Console.WriteLine("RRSE = " + evalTest.rootRelativeSquaredError());
            Console.WriteLine("Precision = " + evalTest.precision(1));
            Console.WriteLine("Recall = " + evalTest.recall(1));
            Console.WriteLine("fMeasure = " + evalTest.fMeasure(1));
            Console.WriteLine("Error Rate = " + evalTest.errorRate());
            double[][] conf = evalTest.confusionMatrix();
            #endregion

            #region Cross Validation

            long seed = DateTime.Now.Ticks;
            int folds = 15;

            // randomizamos los datos en funcion de la semilla
            java.util.Random rand = new java.util.Random(seed);
            data.randomize(rand);

            // estratificamso el dataset
            if (data.classAttribute().isNominal())
                data.stratify(folds);

            // crear evaluador
            Evaluation eval3 = new Evaluation(data);

            // iteramos en funcion de los diferentes folds con los que querams hacer el CV para ver si mejora con mas folds
            for (int n = 0; n < folds; n++)
            {
                //dividimos aleatroiamente el numero de instancias en train y test en funcion de la validacion
                Instances train2 = data.trainCV(folds, n);
                Instances test2 = data.testCV(folds, n);

                // creamos y evaluamos el clasificador	 
                Classifier clsCopy = AbstractClassifier.makeCopy(scheme);
                clsCopy.buildClassifier(train);
                eval3.evaluateModel(clsCopy, test);
            }

            // output evaluation
            Console.WriteLine();
            //Console.WriteLine(eval3.toMatrixString("=== Confusion matrix for fold " + (n + 1) + "/" + folds + " ===\n"));
            Console.WriteLine("Correct % = " + eval3.pctCorrect());
            Console.WriteLine("Incorrect % = " + eval3.pctIncorrect());
            Console.WriteLine("AUC = " + eval3.areaUnderROC(1));
            Console.WriteLine("kappa = " + eval3.kappa());
            Console.WriteLine("MAE = " + eval3.meanAbsoluteError());
            Console.WriteLine("RMSE = " + eval3.rootMeanSquaredError());
            Console.WriteLine("RAE = " + eval3.relativeAbsoluteError());
            Console.WriteLine("RRSE = " + eval3.rootRelativeSquaredError());
            Console.WriteLine("Precision = " + eval3.precision(1));
            Console.WriteLine("Recall = " + eval3.recall(1));
            Console.WriteLine("fMeasure = " + eval3.fMeasure(1));
            Console.WriteLine("Error Rate = " + eval3.errorRate());

            // Matriz de confusion
            Console.WriteLine(eval3.toMatrixString("=== Overall Confusion Matrix ===\n"));

            #endregion

            #region Predecir

            #region Clasificar

            // Le decimos cual es la clase sobre la que tiene que predecir
            data.setClassIndex(data.numAttributes() - 1);

            // Cogemos el numero de clases de ese atributo
            int numClasses = data.numClasses();

            // Pintamos por consola cuales son las clases de un atributo
            for (int i = 0; i < numClasses; i++)
            {
                // Pintamos por consola
                String classValue = data.classAttribute().value(i);
                Console.WriteLine("Class Value " + i + " is " + classValue);
            }

            //creamos el clasificador
            scheme.buildClassifier(data);

            // TODO: aqui deberiamos cargar los nuevos datosque queremos que el modelo clasifique
            // nosotors lo hacemos con el Dtaset almacenado en la variable data2 que es el mismo que data


            // Le decimos que prediga sobre la ultima clase
            //data2.setClassIndex(data2.numAttributes() - 1);

            // Pintamos la cabecera
            Console.WriteLine("===================");
            Console.WriteLine("Actual Class, Predicted Class");

            // Clasificamos cada instancia del dataset data2
            for (int i = 0; i < data.numInstances(); i++)
            {
                // coge el numero de la clase a la que pertenece esa instancia para un atributo (en el caso de Beta 0-1-2-3)
                double actualClass = data.instance(i).classValue();

                //valor para esa clase en concreto (en el caso de B cogeria el intervalo correspondiente a la clase dentro de los 4 intervalos en los que puede estar)
                String actual = data.classAttribute().value((int)actualClass);

                // cogemos la instancia completa dle nuevo dataser
                Instance newInst = (Instance)data.instance(i).copy();
                newInst.setClassMissing();

                // TODO: hay que llamar a esto de forma recursiva, llamar  a un metodo desde el otro
                // claificamso la instancia
                double predNB = scheme.classifyInstance(newInst);
                double[] distribution = scheme.distributionForInstance(newInst);

                // cogemos la clase a la que se ha predicho que pretende la instancia
                String predString = data.classAttribute().value((int)predNB);

                Console.WriteLine(actual + ", " + predString);
            }

            #endregion

            #region Regresion

            ////set class index to the last attribute
            //data.setClassIndex(data.numAttributes() - 1);

            ////build model
            //SMOreg smo = new SMOreg();
            //smo.buildClassifier(data);

            ////output model
            //Console.WriteLine(smo);

            //// Cargar nuevos datos para predecir

            ////set class index to the last attribute
            //data2.setClassIndex(data2.numAttributes() - 1);

            ////loop through the new dataset and make predictions
            //Console.WriteLine("===================");
            //Console.WriteLine("Actual Class, SMO Predicted");

            //for (int i = 0; i < data2.numInstances(); i++)
            //{
            //    //get class double value for current instance
            //    double actualValue = data2.instance(i).classValue();

            //    //get Instance object of current instance
            //    Instance newInst = data2.instance(i);
            //    //call classifyInstance, which returns a double value for the class
            //    double predSMO = smo.classifyInstance(newInst);

            //    Console.WriteLine(actualValue + ", " + predSMO);
            //}

            #endregion

            #endregion

            #endregion


            // Lo construimos
            scheme.buildClassifier(data);

            // Pintar datos en consola
            //Console.WriteLine(eval.toSummaryString());
            //Console.WriteLine(System.Environment.NewLine);
            //Console.WriteLine(eval.toClassDetailsString());

            #endregion



            #endregion

        }

        /// <summary>
        /// Cogemos los datos de prueba del directorio del programa
        /// </summary>
        /// <returns></returns>
        private static string DirectorioDatosPrueba()
        {
            // cogemos la ruta del fichero
            return Path.GetFullPath
                (Path.Combine(Directory.GetCurrentDirectory(), @"..\..\..\..\..\Documentos\iris.arff"));
        }
    }
}
