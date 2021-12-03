using System.Drawing.Imaging;
using System.Drawing;

namespace ImageResizer
{
    public partial class Form1 : Form
    {
        List<Picture> picturesList;
        public Form1()
        {
            picturesList = new List<Picture>();
            InitializeComponent();
        }

        private void _btnLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image files (*.JPG;*.JPEG;*.PNG)|*.JPG;*.JPEG;*.PNG";
            openFileDialog.Multiselect = true;

            var result = openFileDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                if (!(openFileDialog.FileNames.Length > 1))
                {
                    string file = openFileDialog.FileName;
                    char charRange = (char) 92;
                    int endIndex = file.LastIndexOf(charRange);
                    Picture picture = new Picture(file.Substring(endIndex + 1, file.Length - 1 - endIndex), file);

                    _listBoxChoose.Items.Add(picture);

                    
                } else
                {
                    foreach (string file in openFileDialog.FileNames)
                    {
                        char charRange = (char)92;
                        int endIndex = file.LastIndexOf(charRange);
                        Picture picture = new Picture(file.Substring(endIndex + 1, file.Length - 1 - endIndex), file);

                        _listBoxChoose.Items.Add(picture);
                    }
                }

                _btnClear.Visible = true;
                _pictureBox.Visible = true;
            } else
            {
                MessageBox.Show("You choose nothing!", "Warning", MessageBoxButtons.OK);
            }

            
        }

        private void _listBoxChoose_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                _listBoxChoose.Items.RemoveAt(_listBoxChoose.SelectedIndex);

                if (_listBoxChoose.Items.Count == 0)
                {
                    _btnClear.Visible = false;
                    _pictureBox.Visible = false;
                }

            }
        }

        private void _btnClear_Click(object sender, EventArgs e)
        {
            _listBoxChoose.Items.Clear();
            _btnClear.Visible = false;
            _pictureBox.Visible = false;
        }

        private void _btnResize_Click(object sender, EventArgs e)
        {
            if (_listBoxChoose.Items.Count != 0)
            {
                foreach (Picture picture in _listBoxChoose.Items)
                {
                    char charRange = (char)92;
                    int endIndex = picture.Location.LastIndexOf(charRange);
                    string pathString = Path.Combine(picture.Location.Substring(0, endIndex), "Resize_Images");

                    if (!File.Exists(pathString))
                    {
                        Directory.CreateDirectory(pathString);
                    }

                    char typeRange = '.';
                    int typeEndIndex = picture.Name.LastIndexOf(typeRange);
                    string pathStringfWithFile = Path.Combine(pathString, $"{picture.Name.Substring(0, typeEndIndex)}.jpg");

                    if (!File.Exists(pathStringfWithFile))
                    {
                        File.Delete(pathStringfWithFile);
                    }

                    int resizeInt = Convert.ToInt32(_numericResizer.Text);
                    double newHeight = (picture.Image.Height / (double) picture.Image.Width) * (picture.Image.Width / (double) resizeInt);
                    double newWidth = (picture.Image.Width / (double) picture.Image.Height) * newHeight;
                    Bitmap bitmap = new Bitmap(picture.Image, new Size((int) Math.Ceiling(newWidth), (int) Math.Ceiling(newHeight)));
                    bitmap.Save(pathStringfWithFile);

                }

                MessageBox.Show("You successfuly resize your image!", "Information");

            } else
            {
                MessageBox.Show("You choose nothing.", "Warning");
            }
        }

        private void _listBoxChoose_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_listBoxChoose.SelectedIndex >= 0)
            {
                Picture picture = _listBoxChoose.Items[_listBoxChoose.SelectedIndex] as Picture;
                _pictureBox.Image = new Bitmap(picture.Image, new Size(_pictureBox.Height, _pictureBox.Width));
            }

        }
    }
}