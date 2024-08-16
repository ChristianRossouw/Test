using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CTU_ZooManagementSystem
{
    public partial class Form1 : Form
    {
        // Collection to store animals
        private List<Animal> animals = new List<Animal>();

        public Form1()
        {
            InitializeComponent();

            // Adding items to the combo box for all available animal types
            foreach (AnimalType animalType in Enum.GetValues(typeof(AnimalType)))
            {
                cmbAnimalType.Items.Add(animalType);
            }

            // Add the animals to the list and display their names in the ListBox
            AddAnimalToList(new Lion("Leo", 5));
            AddAnimalToList(new Parrot("Polly", 3));
            AddAnimalToList(new Turtle("Terry", 10));
            AddAnimalToList(new Elephant("Dumbo", 15));
            AddAnimalToList(new Crocodile("Snappy", 7));
            AddAnimalToList(new Eagle("Hawkeye", 8));

            // Hide the animal details input fields
            HideAnimalDetailsFields();

            // Apply child-friendly styles
            ApplyChildFriendlyStyles();
        }

        private void btnAddAnimal_Click(object sender, EventArgs e)
        {
            // Show the animal details input fields
            ShowAnimalDetailsFields();
        }

        private void btnConfirmAdd_Click(object sender, EventArgs e)
        {
            // Get animal details from the form
            string name = txtName.Text;
            int age = (int)numAge.Value;

            if (cmbAnimalType.SelectedItem != null)
            {
                AnimalType animalType;
                if (Enum.TryParse(cmbAnimalType.SelectedItem.ToString(), out animalType))
                {
                    // Create instance of the selected animal type
                    Animal newAnimal = CreateAnimalInstance(animalType, name, age);

                    // Add the new animal to the collection and display its name
                    if (newAnimal != null)
                    {
                        AddAnimalToList(newAnimal);

                        // Clear and hide the animal details input fields
                        ClearAnimalDetailsFields();
                        HideAnimalDetailsFields();
                    }
                }
                else
                {
                    MessageBox.Show("Invalid animal type.");
                }
            }
        }

        private void btnFeed_Click(object sender, EventArgs e)
        {
            // Feed the selected animal
            if (lstAnimals.SelectedIndex >= 0)
            {
                Animal selectedAnimal = animals[lstAnimals.SelectedIndex];
                selectedAnimal.Eat(); // Call the Eat method
            }
            else
            {
                MessageBox.Show("Please select an animal.");
            }
        }

        private void btnMove_Click(object sender, EventArgs e)
        {
            // Move the selected animal
            if (lstAnimals.SelectedIndex >= 0)
            {
                Animal selectedAnimal = animals[lstAnimals.SelectedIndex];
                MessageBox.Show(selectedAnimal.Move());
            }
            else
            {
                MessageBox.Show("Please select an animal.");
            }
        }

        private void btnViewAnimalDetails_Click(object sender, EventArgs e)
        {
            if (lstAnimals.SelectedIndex >= 0)
            {
                Animal selectedAnimal = animals[lstAnimals.SelectedIndex];
                MessageBox.Show($"Name: {selectedAnimal.Name}, Age: {selectedAnimal.Age}, Type: {selectedAnimal.GetType().Name}", "Animal Details");
            }
            else
            {
                MessageBox.Show("Please select an animal.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lstAnimals_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstAnimals.SelectedIndex >= 0)
            {
                Animal selectedAnimal = animals[lstAnimals.SelectedIndex];
                MessageBox.Show($"Selected animal: {selectedAnimal.Name} ({selectedAnimal.GetType().Name})");
            }
        }

        private void btnSpeak_Click(object sender, EventArgs e)
        {
            if (lstAnimals.SelectedIndex >= 0)
            {
                Animal selectedAnimal = animals[lstAnimals.SelectedIndex];
                MessageBox.Show(selectedAnimal.Speak());
            }
            else
            {
                MessageBox.Show("Please select an animal.");
            }
        }

        private void cmbAnimalType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbAnimalType.SelectedItem != null)
            {
                AnimalType selectedType = (AnimalType)cmbAnimalType.SelectedItem;

                // Clear the list box items
                lstAnimals.Items.Clear();

                // Add animals corresponding to the selected animal type
                foreach (Animal animal in animals)
                {
                    // Check if the animal's type matches the selected type
                    if (GetAnimalType(animal) == selectedType)
                    {
                        lstAnimals.Items.Add(animal.Name);
                    }
                }
            }
        }

        // Helper method to get the AnimalType of an animal
        private AnimalType GetAnimalType(Animal animal)
        {
            if (animal is Lion)
            {
                return AnimalType.Mammal;
            }
            else if (animal is Parrot)
            {
                return AnimalType.Bird;
            }
            else if (animal is Turtle)
            {
                return AnimalType.Reptile;
            }
            else if (animal is Elephant)
            {
                return AnimalType.Elephant;
            }
            else if (animal is Crocodile)
            {
                return AnimalType.Crocodile;
            }
            else if (animal is Eagle)
            {
                return AnimalType.Eagle;
            }
            else
            {
                throw new InvalidOperationException("Invalid animal type.");
            }
        }

        // Helper method to show the animal details input fields
        private void ShowAnimalDetailsFields()
        {
            lblName.Visible = true;
            lblAge.Visible = true;
            lblType.Visible = true;
            txtName.Visible = true;
            numAge.Visible = true;
            cmbAnimalType.Visible = true;
            btnConfirmAdd.Visible = true;
        }

        // Helper method to hide the animal details input fields
        private void HideAnimalDetailsFields()
        {
            lblName.Visible = false;
            lblAge.Visible = false;
            lblType.Visible = false;
            txtName.Visible = false;
            numAge.Visible = false;
            cmbAnimalType.Visible = false;
            btnConfirmAdd.Visible = false;
        }

        // Helper method to clear the animal details input fields
        private void ClearAnimalDetailsFields()
        {
            txtName.Text = "";
            numAge.Value = 0;
            cmbAnimalType.SelectedIndex = -1;
        }

        // Helper method to add an animal to the list and display its name
        private void AddAnimalToList(Animal animal)
        {
            animals.Add(animal);
            lstAnimals.Items.Add(animal.Name);
        }

        // Apply child-friendly styles
        private void ApplyChildFriendlyStyles()
        {
            // Font styles
            Font defaultFont = new Font("Comic Sans MS", 12, FontStyle.Regular);
            Font titleFont = new Font("Comic Sans MS", 16, FontStyle.Bold);

            // Colors
            Color backgroundColor = Color.FromArgb(255, 255, 204); // Light yellow
            Color textColor = Color.FromArgb(0, 102, 51); // Dark green
            Color buttonColor = Color.FromArgb(255, 204, 153); // Peach
            Color buttonTextColor = Color.FromArgb(0, 102, 51); // Dark green

            // Apply styles to controls
            this.BackColor = backgroundColor;
            lstAnimals.BackColor = Color.White;
            lstAnimals.ForeColor = textColor;
            lstAnimals.Font = defaultFont;
            lblName.Font = defaultFont;
            lblAge.Font = defaultFont;
            lblType.Font = defaultFont;
            txtName.Font = defaultFont;
            cmbAnimalType.Font = defaultFont;
            numAge.Font = defaultFont;
            btnAddAnimal.Font = defaultFont;
            btnAddAnimal.BackColor = buttonColor;
            btnAddAnimal.ForeColor = buttonTextColor;
            btnFeed.Font = defaultFont;
            btnFeed.BackColor = buttonColor;
            btnFeed.ForeColor = buttonTextColor;
            btnMove.Font = defaultFont;
            btnMove.BackColor = buttonColor;
            btnMove.ForeColor = buttonTextColor;
            btnViewAnimalDetails.Font = defaultFont;
            btnViewAnimalDetails.BackColor = buttonColor;
            btnViewAnimalDetails.ForeColor = buttonTextColor;
            btnConfirmAdd.Font = defaultFont;
            btnConfirmAdd.BackColor = buttonColor;
            btnConfirmAdd.ForeColor = buttonTextColor;
            btnSpeak.Font = defaultFont;
            btnSpeak.BackColor = buttonColor;
            btnSpeak.ForeColor = buttonTextColor;

            this.Font = defaultFont;
        }

        // Helper method to create an instance of any animal type
        private Animal CreateAnimalInstance(AnimalType type, string name, int age)
        {
            switch (type)
            {
                case AnimalType.Mammal:
                    return new Lion(name, age);
                case AnimalType.Bird:
                    return new Parrot(name, age);
                case AnimalType.Reptile:
                    return new Turtle(name, age);
                case AnimalType.Elephant:
                    return new Elephant(name, age);
                case AnimalType.Crocodile:
                    return new Crocodile(name, age);
                case AnimalType.Eagle:
                    return new Eagle(name, age);
                default:
                    return null;
            }
        }
    }
}