using System;
using System.Drawing;
using System.Windows.Forms;

namespace YourNamespace
{
    public class YourForm : Form
    {
        private string selectedBodyPart;

        public YourForm()
        {
            pictureBox1 = new PictureBox();
            pictureBox1.Width = 200;
            pictureBox1.Height = 200;

            this.Controls.Add(pictureBox1);

            selectFaceButton = new Button();
            selectFaceButton.Text = "Select Face";
            selectFaceButton.Location = new Point(50, 250);
            selectFaceButton.Click += selectFaceButton_Click;

            this.Controls.Add(selectFaceButton);

            transformButton = new Button();
            transformButton.Text = "Transform";
            transformButton.Location = new Point(200, 250);
            transformButton.Click += transformButton_Click;
            this.Controls.Add(transformButton);
        }



        private void selectFaceButton_Click(object sender, EventArgs e)

        {

            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif";

            if (openFileDialog.ShowDialog() == DialogResult.OK)

            {

                pictureBox1.Image = Image.FromFile(openFileDialog.FileName);

            }

        }



        private void transformButton_Click(object sender, EventArgs e)

        {

            TransformFace();

        }



        private void TransformFace()

        {

            if (selectedBodyPart == "Arm")

            {

                // Превращаем лицо в руку

            }

            else if (selectedBodyPart == "Leg")

            {

                // Превращаем лицо в ногу

            }



            if (pictureBox1.Image != null && pictureBox1.Image is Image)
            {
                pictureBox1.Refresh();
            }

        }

        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.selectFaceButton = new System.Windows.Forms.Button();
            this.transformButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(200, 200);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // selectFaceButton
            // 
            this.selectFaceButton.Location = new System.Drawing.Point(22, 79);
            this.selectFaceButton.Name = "selectFaceButton";
            this.selectFaceButton.Size = new System.Drawing.Size(75, 23);
            this.selectFaceButton.TabIndex = 1;
            this.selectFaceButton.Text = "Select Face";
            this.selectFaceButton.UseVisualStyleBackColor = true;
            // 
            // transformButton
            // 
            this.transformButton.Location = new System.Drawing.Point(200, 250);
            this.transformButton.Name = "transformButton";
            this.transformButton.Size = new System.Drawing.Size(75, 23);
            this.transformButton.TabIndex = 2;
            this.transformButton.Text = "Transform";
            this.transformButton.UseVisualStyleBackColor = true;
            // 
            // YourForm
            // 
            this.ClientSize = new System.Drawing.Size(318, 273);
            this.Controls.Add(this.transformButton);
            this.Controls.Add(this.selectFaceButton);
            this.Controls.Add(this.pictureBox1);
            this.Name = "YourForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        private PictureBox pictureBox1;
        private Button selectFaceButton;
        private Button transformButton;
    }

}