using FruitClassifierCNN.UserControls;
using Python.Runtime;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Keras;
using Tensorflow;

namespace FruitClassifierCNN
{
    public partial class MainForm : Form
    {
        private dynamic model = null;
        private string imagePath = null;
        public MainForm()
        {
            InitializeComponent();
            InitializeModel();
            LoadModel(@"C:\Users\Acer\Desktop\IS pics\PADA_ARRADAZA_IS\config.json", @"C:\Users\Acer\Desktop\IS pics\PADA_ARRADAZA_IS\model.weights.h5"); 
            fruitClassified1.Visible = false;
            fruitPicture_gunaPictureBox.Visible = false;
            fruitImage_gunaPanel.Visible = true;
        }
        private void InitializeModel()
        {
            
            // loadp python
            //string pythonDllPath = @"C:\Users\David Ty\AppData\Local\Programs\Python\Python312\python312.dll";
            string pythonDllPath = @"C:\Program Files\Python311\python311.dll";
            Runtime.PythonDLL = pythonDllPath;
            //string pythonHome = @"C:\Users\David Ty\AppData\Local\Programs\Python\Python312";
            string pythonHome = @"C:\Program Files\Python311";
            Environment.SetEnvironmentVariable("PYTHONHOME", pythonHome);
            try
            {
                PythonEngine.Initialize();
            }
            catch (PythonException ex)
            {
                MessageBox.Show($"Python initialization failed: {ex.Message}");
            }

        }
        private bool IsValidImage(string filePath)
        {
            try
            {
                using (Image image = Image.FromFile(filePath))
                {
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }
        private string GetModelSummary()
        {
            using (Py.GIL())
            {
                dynamic sys = Py.Import("sys");
                dynamic io = Py.Import("io");

                dynamic capturedOutput = io.StringIO();
                sys.stdout = capturedOutput;

                this.model.summary();

                string summary = capturedOutput.getvalue();

                sys.stdout = sys.__stdout__;

                return summary;
            }
        }

        private void esc_button_Click(object sender, EventArgs e)
        {
            Close();
        }
        public void LoadModel(string modelJsonPath, string modelWeightsPath)
        {
            try
            {
                // Check if the model JSON file exists
                if (!File.Exists(modelJsonPath))
                {
                    MessageBox.Show($"Model JSON file not found: {modelJsonPath}");
                    return;
                }
                //MessageBox.Show("Model JSON file found. Proceeding to load model...");

                dynamic tensorflow = Py.Import("tensorflow");

                // Read model JSON content
                string modelJson = File.ReadAllText(modelJsonPath);
                //MessageBox.Show("Model JSON file read successfully.");

                using (Py.GIL())
                {
                    try
                    {
                       // MessageBox.Show("Acquiring Keras model from TensorFlow...");

                        dynamic kerasModels = tensorflow.keras.models;

                        // Load the model architecture
                        this.model = kerasModels.model_from_json(modelJson);
                        if (this.model == null)
                        {
                            MessageBox.Show("Model architecture could not be loaded. The model JSON may be invalid.");
                            return;
                        }
                       // MessageBox.Show("Model architecture loaded successfully.");

                        // Load the model weights
                        this.model.load_weights(modelWeightsPath);
                       // MessageBox.Show("Model weights loaded successfully.");

                        // Optionally, get the model summary (if you want to check this part as well)
                        string modelSummary = GetModelSummary();
                        //MessageBox.Show("Model Summary: " + modelSummary);
                    }
                    catch (PythonException ex)
                    {
                       MessageBox.Show($"Python error: {ex.Message}");
                    }
                }
            }
            catch (FileNotFoundException ex)
            {
                MessageBox.Show($"File not found: {ex.Message}");
            }
            catch (PythonException ex)
            {
                MessageBox.Show($"Python error: {ex.Message}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        private void enterImage_button_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
                openFileDialog.Title = "Select an Image";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    imagePath = openFileDialog.FileName;

                    if (File.Exists(imagePath) && IsValidImage(imagePath))
                    {
                        fruitPicture_gunaPictureBox.Image = Image.FromFile(openFileDialog.FileName);                    
                    }
                    else
                    {
                        MessageBox.Show("Invalid image file. Please select a valid image.");
                    }
                }
                else
                {
                    MessageBox.Show("No image selected.");
                }
            }

            fruitImage_gunaPanel.Visible = false;
            fruitPicture_gunaPictureBox.Visible = true;
        }

        private void gunaGradiantButton1_Click(object sender, EventArgs e)
        {
            string name = PredictImage(imagePath);
            fruitClassified1.Visible = true;
        }

        public string PredictImage(string imagePath)
        {
            try
            {
                dynamic imageArray = PreprocessImage(imagePath);
                if (imageArray == null)
                {
                    MessageBox.Show("Error: Image preprocessing failed.");
                    return "Unclassified";
                }

                if (this.model == null)
                {
                    MessageBox.Show("Error: Model is not loaded.");
                    return "Unclassified";
                }

                using (Py.GIL())
                {
                    // Reshape image for model input
                    imageArray = imageArray.reshape(new int[] { 1, 100, 100, 3 });
                    //imageArray = imageArray / 255.0;

                   // DisplayImageArray(imageArray);

                    // Make prediction
                    dynamic prediction = this.model.predict(imageArray, verbose: 0);

                    if (prediction == null)
                    {
                        MessageBox.Show("Error: Model prediction returned None.");
                        return "Unclassified";
                    }

                    dynamic np = Py.Import("numpy");

                    dynamic predictionArray = np.array(prediction);


                    dynamic predictedClassIndex = np.argmax(predictionArray, axis: -1);
                    var classNames = new List<string> { "Banana", "Corn", "Ripe Cucumber", "Mango", "Tomato" };

                    string predictedClass = classNames[(int)predictedClassIndex[0]];

                    int index = (int)predictedClassIndex[0];
                    //MessageBox.Show($"Predicted Index: {index}");
                    string predictedClass1 = classNames[index];

                    MessageBox.Show($"Predicted class: {predictedClass1}");
                    return predictedClass1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error during prediction: {ex.Message}");
                return "Unclassified";
            }
        }

        private dynamic PreprocessImage(string imagePath)
        {
            if (!File.Exists(imagePath))
            {
                throw new FileNotFoundException($"Image file not found: {imagePath}");
            }

            try
            {
                dynamic np = Py.Import("numpy");
                dynamic cv2 = Py.Import("cv2");
                dynamic utils = Py.Import("tensorflow.keras.utils");

                dynamic image_bgr = cv2.imread(imagePath);

                dynamic image_rgb = cv2.cvtColor(image_bgr, cv2.COLOR_BGR2RGB);

                if (image_rgb == null)
                {
                    throw new Exception($"Failed to load the image: {imagePath}");
                }


                dynamic img_array = utils.img_to_array(image_rgb);
                img_array = np.expand_dims(img_array, axis: 0);

                img_array = img_array * 1.0 / 255;

                return img_array;  // Return img_array, not img (the image array is processed, not the image itself)
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error processing the image: {ex.Message}");
                return null;
            }
        }



        private Bitmap ConvertImageArrayToBitmap(dynamic imageArray)
        {
            try
            {
                using (Py.GIL())
                {
                    // Import numpy
                    dynamic np = Py.Import("numpy");

                    // Convert the array to a format suitable for C#
                    dynamic byteArray = np.clip(imageArray * 255, 0, 255).astype(np.uint8); // Scale back to 0-255 and convert to uint8
                    byte[] rawData = (byte[])byteArray.tobytes(); // Convert numpy array to byte array

                    // Create a Bitmap from the byte array
                    int width = 100; // Assuming the image is resized to 100x100
                    int height = 100;
                    Bitmap bitmap = new Bitmap(width, height, System.Drawing.Imaging.PixelFormat.Format24bppRgb);

                    // Lock the bitmap's bits
                    var rect = new Rectangle(0, 0, width, height);
                    var bitmapData = bitmap.LockBits(rect, System.Drawing.Imaging.ImageLockMode.WriteOnly, bitmap.PixelFormat);

                    // Copy rawData into bitmap
                    System.Runtime.InteropServices.Marshal.Copy(rawData, 0, bitmapData.Scan0, rawData.Length);

                    // Unlock the bits
                    bitmap.UnlockBits(bitmapData);

                    return bitmap;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error converting image array to bitmap: {ex.Message}");
                return null;
            }
        }
        public void DisplayImageArray(dynamic imageArray)
        {
            Bitmap bitmap = ConvertImageArrayToBitmap(imageArray);
            if (bitmap != null)
            {
                // Display the image in a PictureBox
                PictureBox pictureBox = new PictureBox
                {
                    Image = bitmap,
                    SizeMode = PictureBoxSizeMode.StretchImage,
                    Dock = DockStyle.Fill
                };

                // Create a form to show the image
                Form displayForm = new Form
                {
                    Text = "Image Array Display",
                    Width = 200,
                    Height = 200
                };
                displayForm.Controls.Add(pictureBox);
                displayForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Error: Unable to display the image.");
            }
        }

    }
}
